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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, BYGWYMIDFLH resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, BYGWYMIDFLH resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface OUOPVATJLZR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface AAZMAJKQBQQ<a> : OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, BYGWYMIDFLH formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LTKGVGMANFH<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void REKKNCEGHLB(JsonWriter a, a b, BYGWYMIDFLH c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b);
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
	public static class DQPKVXXDMLW
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x38FB300", Offset = "0x38FA300", VA = "0x1838FB300")]
		public static string ToJsonString<T>(this AAZMAJKQBQQ<T> formatter, T value, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AAZMAJKQBQQ<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class ODSZZDEBUAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D599A0", Offset = "0x3D589A0", VA = "0x183D599A0")]
		public static AAZMAJKQBQQ<a> ARVQSZLCHPX<a>(this BYGWYMIDFLH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA53F600", Offset = "0xA53E600", VA = "0x18A53F600")]
		public static object GQPQCPANXCF(this BYGWYMIDFLH a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA533030", Offset = "0xA532030", VA = "0x18A533030")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class HYHXZDVXWBF
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] UACTDCSPTPQ;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] RFMLDRKRLKD;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] ZAMWVOVCNTG;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] YQWNDTANBDR;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] YQSSBJXRMDY;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] KJNAAWSKCXP;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] WKZBZLLUXHP;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] EBEKIHMQVXK;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class SERZYYKRZGY : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0xA540710", Offset = "0xA53F710", VA = "0x18A540710")]
				public SERZYYKRZGY(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xA5405F0", Offset = "0xA53F5F0", VA = "0x18A5405F0")]
				public SERZYYKRZGY SQBZERFLCRA(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class BFPVVPIIBMH
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] TPDALQXGJSA;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] AGTRCNZLVFJ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private SERZYYKRZGY start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private SERZYYKRZGY end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA540AB0", Offset = "0xA53FAB0", VA = "0x18A540AB0")]
			public void SQBZERFLCRA([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA540970", Offset = "0xA53F970", VA = "0x18A540970")]
			public void SQBZERFLCRA(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA540BC0", Offset = "0xA53FBC0", VA = "0x18A540BC0")]
			public ReadOnlySequence<byte> VIHQHQNZGQJ()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA540CF0", Offset = "0xA53FCF0", VA = "0x18A540CF0")]
			private void XXZYUFAWZKR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA540780", Offset = "0xA53F780", VA = "0x18A540780")]
			private void OWBRJVJGSAP([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA53CFD0", Offset = "0xA53BFD0", VA = "0x18A53CFD0")]
		public JsonReader([In] ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA53CE60", Offset = "0xA53BE60", VA = "0x18A53CE60")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA53CAC0", Offset = "0xA53BAC0", VA = "0x18A53CAC0")]
		private JsonParsingException YXDBDCFPWNN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA53C290", Offset = "0xA53B290", VA = "0x18A53C290")]
		private JsonParsingException XMSXAHITNLU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA53B2F0", Offset = "0xA53A2F0", VA = "0x18A53B2F0")]
		public JsonToken OCEYRNBUFJA()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA53A340", Offset = "0xA539340", VA = "0x18A53A340")]
		public void GLDLAUBDQZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA53C140", Offset = "0xA53B140", VA = "0x18A53C140")]
		private bool WTYBBGCNXDY(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA53C0E0", Offset = "0xA53B0E0", VA = "0x18A53C0E0")]
		private bool WTYBBGCNXDY(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA53C3A0", Offset = "0xA53B3A0", VA = "0x18A53C3A0")]
		private void XOXDOPEECEH(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA53B500", Offset = "0xA53A500", VA = "0x18A53B500")]
		public bool PDQUKZCZPVV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA53C0D0", Offset = "0xA53B0D0", VA = "0x18A53C0D0")]
		public void VPZAUQTEBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA53CE10", Offset = "0xA53BE10", VA = "0x18A53CE10")]
		public bool ZJYTAJWJOIE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA53AE70", Offset = "0xA539E70", VA = "0x18A53AE70")]
		public void KDXIFUOOFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA53A570", Offset = "0xA539570", VA = "0x18A53A570")]
		public void IFHVYGFMGMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA539D60", Offset = "0xA538D60", VA = "0x18A539D60")]
		public bool BMKYUWCVOPO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA53BD50", Offset = "0xA53AD50", VA = "0x18A53BD50")]
		public void SLMLOWHCFNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA53C0C0", Offset = "0xA53B0C0", VA = "0x18A53C0C0")]
		public void TQIVQMHTZEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA53B1C0", Offset = "0xA53A1C0", VA = "0x18A53B1C0")]
		public bool NFVIJJWMNZJ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA53A180", Offset = "0xA539180", VA = "0x18A53A180")]
		public bool FDAZRKLJOWK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA53C450", Offset = "0xA53B450", VA = "0x18A53C450")]
		public bool XYEQLVDRQZF(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA53BD60", Offset = "0xA53AD60", VA = "0x18A53BD60")]
		public bool SXCPPIJWZMO(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA53A580", Offset = "0xA539580", VA = "0x18A53A580")]
		private ReadOnlySequence<byte> IMDFGCPRGOL()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA53C850", Offset = "0xA53B850", VA = "0x18A53C850")]
		private ReadOnlySequence<byte> YKHSWCWGBIK()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA53C660", Offset = "0xA53B660", VA = "0x18A53C660")]
		private void YKHEBPZHGMW(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA53BEC0", Offset = "0xA53AEC0", VA = "0x18A53BEC0")]
		private void TJBGWUCTQLD(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA53AA70", Offset = "0xA539A70", VA = "0x18A53AA70")]
		private void JHNLJDJCRNO(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA53AD60", Offset = "0xA539D60", VA = "0x18A53AD60")]
		private void JOWARPWIWQH(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA52EC60", Offset = "0xA52DC60", VA = "0x18A52EC60")]
		private static int JYMBOBSFMSG(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA53B9C0", Offset = "0xA53A9C0", VA = "0x18A53B9C0")]
		public ReadOnlySequence<byte> RCHHHIZVRCG()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA53BE40", Offset = "0xA53AE40", VA = "0x18A53BE40")]
		public string TFPPGMPYPED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA53C1A0", Offset = "0xA53B1A0", VA = "0x18A53C1A0")]
		public string XFNGGKXUSRG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA53C590", Offset = "0xA53B590", VA = "0x18A53C590")]
		public ReadOnlySequence<byte> YJXIQSKPJMK()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA53A260", Offset = "0xA539260", VA = "0x18A53A260")]
		public ReadOnlySequence<byte> FDDIMTVLKMN()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA53BA90", Offset = "0xA53AA90", VA = "0x18A53BA90")]
		public bool RLLPLGILEDY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA53BBE0", Offset = "0xA53ABE0", VA = "0x18A53BBE0")]
		private void RZFNDPJFJZK(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA53B9B0", Offset = "0xA53A9B0", VA = "0x18A53B9B0")]
		public void QWYVFIUIMMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA539DB0", Offset = "0xA538DB0", VA = "0x18A539DB0")]
		private void CXNUXRLRTPZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA53B860", Offset = "0xA53A860", VA = "0x18A53B860")]
		public sbyte PSRQDGWDOOR()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA53B110", Offset = "0xA53A110", VA = "0x18A53B110")]
		public short MDQSFBTQJXS()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA53C4E0", Offset = "0xA53B4E0", VA = "0x18A53C4E0")]
		public int YIUUXZQEUMC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA53A110", Offset = "0xA539110", VA = "0x18A53A110")]
		public long EHDSJSESECB()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA539FF0", Offset = "0xA538FF0", VA = "0x18A539FF0")]
		public byte DGUODXJFDUA()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA53C1E0", Offset = "0xA53B1E0", VA = "0x18A53C1E0")]
		public ushort XHGZBRIZLIB()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA53AE80", Offset = "0xA539E80", VA = "0x18A53AE80")]
		public uint KKSXDVBJKFZ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA53A0A0", Offset = "0xA5390A0", VA = "0x18A53A0A0")]
		public ulong EFXNBUACKQY()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA53B250", Offset = "0xA53A250", VA = "0x18A53B250")]
		public float NSIBKGAMDQC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA53B910", Offset = "0xA53A910", VA = "0x18A53B910")]
		public double PYVEZOAIUDN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA53AF30", Offset = "0xA539F30", VA = "0x18A53AF30")]
		public ReadOnlySequence<byte> LQECNHCMTOE()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA53B5C0", Offset = "0xA53A5C0", VA = "0x18A53B5C0")]
		private void PEGPBVLZOLQ()
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
			[Cpp2IlInjected.Address(RVA = "0xF93B00", Offset = "0xF92B00", VA = "0x180F93B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA539D00", Offset = "0xA538D00", VA = "0x18A539D00")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA539C80", Offset = "0xA538C80", VA = "0x18A539C80")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class ATTJLHKNWNC
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class HXXFGNPNRYT
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] TPDALQXGJSA;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA539010", Offset = "0xA538010", VA = "0x18A539010")]
			public static byte[] PDKKJSIZGWI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static BYGWYMIDFLH CCXZJJAKOSB;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] OTHVWQJPSCI;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] NNIHGRUCKMS;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static BYGWYMIDFLH SHCWSIXZGSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA531E50", Offset = "0xA530E50", VA = "0x18A531E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA531DE0", Offset = "0xA530DE0", VA = "0x18A531DE0")]
		public static void NUCFVQSDBEB(BYGWYMIDFLH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x336C400", Offset = "0x336B400", VA = "0x18336C400")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x336C290", Offset = "0x336B290", VA = "0x18336C290")]
		public static byte[] Serialize<T>(T value, BYGWYMIDFLH resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x336C870", Offset = "0x336B870", VA = "0x18336C870")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x336C8F0", Offset = "0x336B8F0", VA = "0x18336C8F0")]
		public static string ToJsonString<T>(T value, BYGWYMIDFLH resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x336BBA0", Offset = "0x336ABA0", VA = "0x18336BBA0")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x336BDF0", Offset = "0x336ADF0", VA = "0x18336BDF0")]
		public static T Deserialize<T>(string json, BYGWYMIDFLH resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x336BAD0", Offset = "0x336AAD0", VA = "0x18336BAD0")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x336BA00", Offset = "0x336AA00", VA = "0x18336BA00")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, BYGWYMIDFLH resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x336B400", Offset = "0x336A400", VA = "0x18336B400")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x336B230", Offset = "0x336A230", VA = "0x18336B230")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, BYGWYMIDFLH resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA531F50", Offset = "0xA530F50", VA = "0x18A531F50")]
		public static byte[] WGZVPQBRVBU(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA531480", Offset = "0xA530480", VA = "0x18A531480")]
		private static void FTKQRYQEKZI(JsonReader a, JsonWriter b, int c)
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
		public int MYTIGVQDAVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xF584A0", Offset = "0xF574A0", VA = "0x180F584A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA53E340", Offset = "0xA53D340", VA = "0x18A53E340")]
		public void XKFTKUKXSFB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA53D1F0", Offset = "0xA53C1F0", VA = "0x18A53D1F0")]
		public static byte[] CHSFUHMOXZY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA53E090", Offset = "0xA53D090", VA = "0x18A53E090")]
		public static byte[] UVUYWXBHYXM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA53D2D0", Offset = "0xA53C2D0", VA = "0x18A53D2D0")]
		public static byte[] CUUUTJFQAPG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA53D970", Offset = "0xA53C970", VA = "0x18A53D970")]
		public static byte[] FVBKNBAOVWI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2ABDED0", Offset = "0x2ABCED0", VA = "0x182ABDED0")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA53DD30", Offset = "0xA53CD30", VA = "0x18A53DD30")]
		public ArraySegment<byte> PDKKJSIZGWI()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA53E1B0", Offset = "0xA53D1B0", VA = "0x18A53E1B0")]
		public byte[] VWWXILPGBSX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA53DFA0", Offset = "0xA53CFA0", VA = "0x18A53DFA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA53DB60", Offset = "0xA53CB60", VA = "0x18A53DB60")]
		public void GAKMMDDZWUU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA52ED20", Offset = "0xA52DD20", VA = "0x18A52ED20")]
		public void HBKKGMASXEB(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA53DB70", Offset = "0xA53CB70", VA = "0x18A53DB70")]
		public void HBKKGMASXEB(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA53E000", Offset = "0xA53D000", VA = "0x18A53E000")]
		public void UDLSLZYCEHR(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x50D8B20", Offset = "0x50D7B20", VA = "0x1850D8B20")]
		public void GWBCXDNSXFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x50D8B70", Offset = "0x50D7B70", VA = "0x1850D8B70")]
		public void JPJYZTYKXQL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5075DA0", Offset = "0x5074DA0", VA = "0x185075DA0")]
		public void NKYOFNDDPOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4F07370", Offset = "0x4F06370", VA = "0x184F07370")]
		public void VDWWMBQBYCR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5075D50", Offset = "0x5074D50", VA = "0x185075D50")]
		public void MTZMOTLEEDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5075DF0", Offset = "0x5074DF0", VA = "0x185075DF0")]
		public void NQJKAADBBUB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA53DC20", Offset = "0xA53CC20", VA = "0x18A53DC20")]
		public void NTRYEQOAAPZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA53DBD0", Offset = "0xA53CBD0", VA = "0x18A53DBD0")]
		public void KTPGJWAJYQJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4F072D0", Offset = "0x4F062D0", VA = "0x184F072D0")]
		public void KRYQHUIWWGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD4D0", Offset = "0x8DFC4D0", VA = "0x188DFD4D0")]
		public void YUDPPGNNDBV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA53E400", Offset = "0xA53D400", VA = "0x18A53E400")]
		public void ZTPECHZGCEN(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA53DEB0", Offset = "0xA53CEB0", VA = "0x18A53DEB0")]
		public void RPVVOIYCNHK(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA53DE40", Offset = "0xA53CE40", VA = "0x18A53DE40")]
		public void PZDIXEUNSRJ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA53DAF0", Offset = "0xA53CAF0", VA = "0x18A53DAF0")]
		public void GAJEPYNLNXU(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA53DF30", Offset = "0xA53CF30", VA = "0x18A53DF30")]
		public void TBTQABEQHME(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA53E3D0", Offset = "0xA53D3D0", VA = "0x18A53E3D0")]
		public void ZAXPAUUTCVN(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA53DDD0", Offset = "0xA53CDD0", VA = "0x18A53DDD0")]
		public void PKWZOIZKYTW(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA53DCC0", Offset = "0xA53CCC0", VA = "0x18A53DCC0")]
		public void NVHYYHGWXJP(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA53D180", Offset = "0xA53C180", VA = "0x18A53D180")]
		public void AYTXAKZGWHN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA53E060", Offset = "0xA53D060", VA = "0x18A53E060")]
		public void UTYMYJXZWSM(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA53D3F0", Offset = "0xA53C3F0", VA = "0x18A53D3F0")]
		public void FTZSUUIGOUU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA53E350", Offset = "0xA53D350", VA = "0x18A53E350")]
		private static bool XMTLLBQXIJA(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA53E040", Offset = "0xA53D040", VA = "0x18A53E040")]
		private static byte UKLJFWETKWI(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA52ED80", Offset = "0xA52DD80", VA = "0x18A52ED80")]
		private static void WNHIHNZTMDD(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class PHMLTQJQGXQ : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6FC11F0", Offset = "0x6FC01F0", VA = "0x186FC11F0")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private PHMLTQJQGXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class LOHEFYKDEKD : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6FC86A0", Offset = "0x6FC76A0", VA = "0x186FC86A0")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class GVDOJPUAZRT
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> GLHTRSHCDUK;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA533090", Offset = "0xA532090", VA = "0x18A533090")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private LOHEFYKDEKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class AAEJDFBRZCT : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6FCC500", Offset = "0x6FCB500", VA = "0x186FCC500")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly AAEJDFBRZCT CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool PUYJOLUYVPN;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static OUOPVATJLZR[] RDWTBUKHBXP;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static BYGWYMIDFLH[] OKZSKAVJJMR;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private AAEJDFBRZCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA5305A0", Offset = "0xA52F5A0", VA = "0x18A5305A0")]
		public static void OTSRDIPIITJ(params BYGWYMIDFLH[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA530680", Offset = "0xA52F680", VA = "0x18A530680")]
		public static void OTSRDIPIITJ(params OUOPVATJLZR[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA530760", Offset = "0xA52F760", VA = "0x18A530760")]
		public static void SBVIEOQXPYZ(OUOPVATJLZR[] a, BYGWYMIDFLH[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class YTVXCVBPZDM : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9F60", Offset = "0x6FC8F60", VA = "0x186FC9F60")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private YTVXCVBPZDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class PBUAOXTLIHT
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly BYGWYMIDFLH HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly BYGWYMIDFLH SHUEEMAIWMW;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class HHKFUVYKEDD
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly BYGWYMIDFLH HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly BYGWYMIDFLH QSPSJUTBEHC;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly BYGWYMIDFLH DPRDLNXPXTQ;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly BYGWYMIDFLH PAYBUUWNJER;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly BYGWYMIDFLH JHCLEFOBKIR;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly BYGWYMIDFLH PJBZCOPUJSP;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly BYGWYMIDFLH OASUIKQRJAS;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly BYGWYMIDFLH QNYZTBNYSII;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly BYGWYMIDFLH SDYQFAJHUHE;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly BYGWYMIDFLH GJAGMCEKBBH;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly BYGWYMIDFLH ZLDIYMXGRSJ;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly BYGWYMIDFLH LCRIBYNBOIH;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class XCHBLWBFCYM
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> GLHTRSHCDUK;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA5412E0", Offset = "0xA5402E0", VA = "0x18A5412E0")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA542F60", Offset = "0xA541F60", VA = "0x18A542F60")]
		private static object ZIYZHYENTHL(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class FDFIEIPPYIK : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6FCDFD0", Offset = "0x6FCCFD0", VA = "0x186FCDFD0")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private FDFIEIPPYIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class CFEGDBALEGX : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6FC6FF0", Offset = "0x6FC5FF0", VA = "0x186FC6FF0")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private CFEGDBALEGX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class AQTPVGNMRAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly BYGWYMIDFLH[] CVMNKEEEWYG;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class QLHUSVODMCU : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x6FCDCC0", Offset = "0x6FCCCC0", VA = "0x186FCDCC0")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class GVENYRJITXS : BYGWYMIDFLH
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class MUSYCROGFOF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x6FC2710", Offset = "0x6FC1710", VA = "0x186FC2710")]
				static MUSYCROGFOF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly BYGWYMIDFLH CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly BYGWYMIDFLH[] OKZSKAVJJMR;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			private GVENYRJITXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
			public AAZMAJKQBQQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly AAZMAJKQBQQ<object> JRPXDSMPIUC;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private QLHUSVODMCU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class LJLGCUGNSZJ : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6FCAF10", Offset = "0x6FC9F10", VA = "0x186FCAF10")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class GVENYRJITXS : BYGWYMIDFLH
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class MUSYCROGFOF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x6FD0D00", Offset = "0x6FCFD00", VA = "0x186FD0D00")]
				static MUSYCROGFOF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly BYGWYMIDFLH CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly BYGWYMIDFLH[] OKZSKAVJJMR;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			private GVENYRJITXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
			public AAZMAJKQBQQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly AAZMAJKQBQQ<object> JRPXDSMPIUC;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private LJLGCUGNSZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class OJYDFNHLLXT : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8080", Offset = "0x6FC7080", VA = "0x186FC8080")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class GVENYRJITXS : BYGWYMIDFLH
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class MUSYCROGFOF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x6FCA150", Offset = "0x6FC9150", VA = "0x186FCA150")]
				static MUSYCROGFOF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly BYGWYMIDFLH CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly BYGWYMIDFLH[] OKZSKAVJJMR;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			private GVENYRJITXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
			public AAZMAJKQBQQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly AAZMAJKQBQQ<object> JRPXDSMPIUC;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private OJYDFNHLLXT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class IRICIDJLCWW : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6FCED50", Offset = "0x6FCDD50", VA = "0x186FCED50")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class GVENYRJITXS : BYGWYMIDFLH
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class MUSYCROGFOF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x6FC9520", Offset = "0x6FC8520", VA = "0x186FC9520")]
				static MUSYCROGFOF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly BYGWYMIDFLH CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly BYGWYMIDFLH[] OKZSKAVJJMR;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			private GVENYRJITXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
			public AAZMAJKQBQQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly AAZMAJKQBQQ<object> JRPXDSMPIUC;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private IRICIDJLCWW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class CIBIHETURTU : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x6FC0D70", Offset = "0x6FBFD70", VA = "0x186FC0D70")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class GVENYRJITXS : BYGWYMIDFLH
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class MUSYCROGFOF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x6FC8D50", Offset = "0x6FC7D50", VA = "0x186FC8D50")]
				static MUSYCROGFOF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly BYGWYMIDFLH CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly BYGWYMIDFLH[] OKZSKAVJJMR;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			private GVENYRJITXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
			public AAZMAJKQBQQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly AAZMAJKQBQQ<object> JRPXDSMPIUC;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private CIBIHETURTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class DNPBHOJDERK : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6FD0880", Offset = "0x6FCF880", VA = "0x186FD0880")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class GVENYRJITXS : BYGWYMIDFLH
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class MUSYCROGFOF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x6FCB500", Offset = "0x6FCA500", VA = "0x186FCB500")]
				static MUSYCROGFOF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly BYGWYMIDFLH CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly BYGWYMIDFLH[] OKZSKAVJJMR;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			private GVENYRJITXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
			public AAZMAJKQBQQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly AAZMAJKQBQQ<object> JRPXDSMPIUC;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private DNPBHOJDERK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class PXEKMBVREVX : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6FCE8D0", Offset = "0x6FCD8D0", VA = "0x186FCE8D0")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class GVENYRJITXS : BYGWYMIDFLH
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class MUSYCROGFOF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x6FC6500", Offset = "0x6FC5500", VA = "0x186FC6500")]
				static MUSYCROGFOF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly BYGWYMIDFLH CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly BYGWYMIDFLH[] OKZSKAVJJMR;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			private GVENYRJITXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
			public AAZMAJKQBQQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly AAZMAJKQBQQ<object> JRPXDSMPIUC;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private PXEKMBVREVX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class FZEZHXUCNZF : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8390", Offset = "0x6FC7390", VA = "0x186FC8390")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class GVENYRJITXS : BYGWYMIDFLH
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class MUSYCROGFOF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x6FCB670", Offset = "0x6FCA670", VA = "0x186FCB670")]
				static MUSYCROGFOF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly BYGWYMIDFLH CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly BYGWYMIDFLH[] OKZSKAVJJMR;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			private GVENYRJITXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
			public AAZMAJKQBQQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly AAZMAJKQBQQ<object> JRPXDSMPIUC;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private FZEZHXUCNZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class YHKOTKQFIHP : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x6FC08F0", Offset = "0x6FBF8F0", VA = "0x186FC08F0")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class GVENYRJITXS : BYGWYMIDFLH
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class MUSYCROGFOF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x6FCD840", Offset = "0x6FCC840", VA = "0x186FCD840")]
				static MUSYCROGFOF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly BYGWYMIDFLH CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly BYGWYMIDFLH[] OKZSKAVJJMR;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			private GVENYRJITXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
			public AAZMAJKQBQQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly AAZMAJKQBQQ<object> JRPXDSMPIUC;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private YHKOTKQFIHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class UEPOLVDVPSK : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x6FC2BE0", Offset = "0x6FC1BE0", VA = "0x186FC2BE0")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class GVENYRJITXS : BYGWYMIDFLH
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class MUSYCROGFOF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x6FC34E0", Offset = "0x6FC24E0", VA = "0x186FC34E0")]
				static MUSYCROGFOF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly BYGWYMIDFLH CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly BYGWYMIDFLH[] OKZSKAVJJMR;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			private GVENYRJITXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
			public AAZMAJKQBQQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly AAZMAJKQBQQ<object> JRPXDSMPIUC;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private UEPOLVDVPSK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class DTYVXMBDMRU : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6FCAC00", Offset = "0x6FC9C00", VA = "0x186FCAC00")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class GVENYRJITXS : BYGWYMIDFLH
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class MUSYCROGFOF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x6FC9800", Offset = "0x6FC8800", VA = "0x186FC9800")]
				static MUSYCROGFOF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly BYGWYMIDFLH CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly BYGWYMIDFLH[] OKZSKAVJJMR;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			private GVENYRJITXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
			public AAZMAJKQBQQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly AAZMAJKQBQQ<object> JRPXDSMPIUC;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private DTYVXMBDMRU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class TYHQDMSCKJK : BYGWYMIDFLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class MUSYCROGFOF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7C00", Offset = "0x6FC6C00", VA = "0x186FC7C00")]
			static MUSYCROGFOF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class GVENYRJITXS : BYGWYMIDFLH
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class MUSYCROGFOF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly AAZMAJKQBQQ<a> AGONRIFYRIE;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x6FCF650", Offset = "0x6FCE650", VA = "0x186FCF650")]
				static MUSYCROGFOF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly BYGWYMIDFLH CIARLSLMHCZ;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly BYGWYMIDFLH[] OKZSKAVJJMR;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			private GVENYRJITXS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
			public AAZMAJKQBQQ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly BYGWYMIDFLH CIARLSLMHCZ;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly AAZMAJKQBQQ<object> JRPXDSMPIUC;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		private TYHQDMSCKJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3364E40", Offset = "0x3363E40", VA = "0x183364E40", Slot = "4")]
		public AAZMAJKQBQQ<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x7510020", Offset = "0x750F020", VA = "0x187510020")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x750FD20", Offset = "0x750ED20", VA = "0x18750FD20")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x750FF90", Offset = "0x750EF90", VA = "0x18750FF90")]
		public T[] TTMPAXROIBO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class CFWGMFCGTFE<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int EBQTQRTLOSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object XCSNUADHKGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int JEHIAJMVLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] VEJAQQCAFPX;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5082B30", Offset = "0x5081B30", VA = "0x185082B30")]
		public CFWGMFCGTFE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x50826B0", Offset = "0x50816B0", VA = "0x1850826B0")]
		public a[] ELUQUCQZPND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x50828F0", Offset = "0x50818F0", VA = "0x1850828F0")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class EKGFJVGXTUY : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class ASEYPQZTZUY : IComparable<ASEYPQZTZUY>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class HQSCZOTUCIY : IEnumerable<ASEYPQZTZUY>, IEnumerable, IEnumerator<ASEYPQZTZUY>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int KVXTPCCUFNU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private ASEYPQZTZUY NNNUNWANACF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int LNNEGLEATET;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public ASEYPQZTZUY NJJCUEUTHZM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int AVRZTXKIQLK;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private ASEYPQZTZUY YWPBRVKDSWZ
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object BVCEDTADISM
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
				[DebuggerHidden]
				public HQSCZOTUCIY(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "7")]
				[DebuggerHidden]
				private void OHWWSGWCEEL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xA538EB0", Offset = "0xA537EB0", VA = "0x18A538EB0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xA538FD0", Offset = "0xA537FD0", VA = "0x18A538FD0", Slot = "10")]
				[DebuggerHidden]
				private void UCVOSCIFQDQ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xA538F30", Offset = "0xA537F30", VA = "0x18A538F30", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<ASEYPQZTZUY> OZLLBTHBPXA()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0xA538F30", Offset = "0xA537F30", VA = "0x18A538F30", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator YIRXJWVWWXR()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly ASEYPQZTZUY[] HIYDYWVMUUY;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] GSQAQVAEYWP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong AOHZFAYUMAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int WZVCBEIJRSP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string FFFGEPELDNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private ASEYPQZTZUY[] MYGTDSAEQUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] OLOTOMIJQWH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int UQAYGHULZQR;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA5313C0", Offset = "0xA5303C0", VA = "0x18A5313C0")]
			public ASEYPQZTZUY(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA530E60", Offset = "0xA52FE60", VA = "0x18A530E60")]
			public ASEYPQZTZUY Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA530E00", Offset = "0xA52FE00", VA = "0x18A530E00")]
			public ASEYPQZTZUY Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA531060", Offset = "0xA530060", VA = "0x18A531060")]
			public ASEYPQZTZUY CGJTZNQDXEC(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA531200", Offset = "0xA530200", VA = "0x18A531200")]
			internal static int MIYKXKJDGYH(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA5311D0", Offset = "0xA5301D0", VA = "0x18A5311D0", Slot = "4")]
			public int CompareTo(ASEYPQZTZUY other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xA531290", Offset = "0xA530290", VA = "0x18A531290")]
			[IteratorStateMachine(typeof(HQSCZOTUCIY))]
			public IEnumerable<ASEYPQZTZUY> OWLXETCIQBK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class ZHEBHZDPFDE : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int LNNEGLEATET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<ASEYPQZTZUY> MYGTDSAEQUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<ASEYPQZTZUY> BGKNCGPWHGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<ASEYPQZTZUY> PQBFSTXQTPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private ASEYPQZTZUY ONMHVCPWAXN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> PPQRYGJWASU;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> PGJBPMAOAPR
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0xD8EE10", Offset = "0xD8DE10", VA = "0x180D8EE10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000139")]
				[Cpp2IlInjected.Address(RVA = "0xA5439D0", Offset = "0xA5429D0", VA = "0x18A5439D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1D167A0", Offset = "0x1D157A0", VA = "0x181D167A0")]
			[DebuggerHidden]
			public ZHEBHZDPFDE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xA543F20", Offset = "0xA542F20", VA = "0x18A543F20", Slot = "7")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xA543AC0", Offset = "0xA542AC0", VA = "0x18A543AC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xA543A20", Offset = "0xA542A20", VA = "0x18A543A20")]
			private void LZWZIAQZAET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA543A70", Offset = "0xA542A70", VA = "0x18A543A70")]
			private void MACGFHKWJQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA544070", Offset = "0xA543070", VA = "0x18A544070", Slot = "10")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xA5440B0", Offset = "0xA5430B0", VA = "0x18A5440B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> YNSSFBDVQUA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xA5440B0", Offset = "0xA5430B0", VA = "0x18A5440B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator YIRXJWVWWXR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly ASEYPQZTZUY DIIJJEHZBXI;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA532EB0", Offset = "0xA531EB0", VA = "0x18A532EB0")]
		public EKGFJVGXTUY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA532660", Offset = "0xA531660", VA = "0x18A532660")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA532DA0", Offset = "0xA531DA0", VA = "0x18A532DA0")]
		public bool YBTJOCJEVNY(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA532B80", Offset = "0xA531B80", VA = "0x18A532B80")]
		public bool QUXSZURUZLJ([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA532C90", Offset = "0xA531C90", VA = "0x18A532C90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA532840", Offset = "0xA531840", VA = "0x18A532840")]
		private static void GZSNDGWNRXH(IEnumerable<ASEYPQZTZUY> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA532B20", Offset = "0xA531B20", VA = "0x18A532B20", Slot = "5")]
		private IEnumerator YIRXJWVWWXR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA532B20", Offset = "0xA531B20", VA = "0x18A532B20", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA532D20", Offset = "0xA531D20", VA = "0x18A532D20")]
		[IteratorStateMachine(typeof(ZHEBHZDPFDE))]
		private static IEnumerable<KeyValuePair<string, int>> YBIAPMARLKY(IEnumerable<ASEYPQZTZUY> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class JKUSIABDMLF
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo QKCOUZMXJFW;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA539480", Offset = "0xA538480", VA = "0x18A539480")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA539630", Offset = "0xA538630", VA = "0x18A539630")]
		public static ulong UOBHUTDYBHK(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class HNFZIGLAMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA538D70", Offset = "0xA537D70", VA = "0x18A538D70")]
		public static void GAKMMDDZWUU(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA538C50", Offset = "0xA537C50", VA = "0x18A538C50")]
		public static void ESUISXIGGVS(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA538B10", Offset = "0xA537B10", VA = "0x18A538B10")]
		public static byte[] CITTCONRWYJ(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class BTAXCVOTERJ<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x5B71100", Offset = "0x5B70100", VA = "0x185B71100", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class WQXKUYJVAQP : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public BTAXCVOTERJ<a> NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] PQBFSTXQTPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int PPVYVNDTKED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] PPQRYGJWASU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int PRBOFBTDOUF;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> CBWJLVVLPWO
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xD8EE10", Offset = "0xD8DE10", VA = "0x180D8EE10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0x653AF30", Offset = "0x6539F30", VA = "0x18653AF30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public WQXKUYJVAQP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x872E710", Offset = "0x872D710", VA = "0x18872E710", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "8")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] EPDYGXCIWON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong UQBWFKBNNWZ;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool NSXGILIHIVU;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4F20D20", Offset = "0x4F1FD20", VA = "0x184F20D20")]
		public BTAXCVOTERJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4F20E10", Offset = "0x4F1FE10", VA = "0x184F20E10")]
		public BTAXCVOTERJ(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4F0D9F0", Offset = "0x4F0C9F0", VA = "0x184F0D9F0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4F1A830", Offset = "0x4F19830", VA = "0x184F1A830")]
		private bool XSXVCWXWTLF(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4F1D2F0", Offset = "0x4F1C2F0", VA = "0x184F1D2F0")]
		public bool YBTJOCJEVNY([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4F11F60", Offset = "0x4F10F60", VA = "0x184F11F60")]
		private static ulong UULQMWMGJFM([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4F0F2B0", Offset = "0x4F0E2B0", VA = "0x184F0F2B0")]
		private static ulong UULQMWMGJFM([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4F0ED20", Offset = "0x4F0DD20", VA = "0x184F0ED20")]
		private static int SVZXAMGKVFU(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4F0EAB0", Offset = "0x4F0DAB0", VA = "0x184F0EAB0", Slot = "4")]
		[IteratorStateMachine(typeof(BTAXCVOTERJ<>.WQXKUYJVAQP))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4F20AA0", Offset = "0x4F1FAA0", VA = "0x184F20AA0", Slot = "5")]
		private IEnumerator YIRXJWVWWXR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class POBXMTXJBYG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3D79480", Offset = "0x3D78480", VA = "0x183D79480")]
		public static Func<a> WTFHYSPOAYM<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3D793C0", Offset = "0x3D783C0", VA = "0x183D793C0")]
		private static c FPQSDHBLCOF<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0xA5372F0", Offset = "0xA5362F0", VA = "0x18A5372F0")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA537300", Offset = "0xA536300", VA = "0x18A537300")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA537160", Offset = "0xA536160", VA = "0x18A537160")]
		private static byte QEFKLZXAOHT(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA52E880", Offset = "0xA52D880", VA = "0x18A52E880")]
		private static byte IXWCQSJIYER(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA536900", Offset = "0xA535900", VA = "0x18A536900")]
		public void NTXNIJJJHYF(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class KUSHQGKMSSV
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA53E8A0", Offset = "0xA53D8A0", VA = "0x18A53E8A0")]
		public static bool GGMEIGGXBNB(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA53F0E0", Offset = "0xA53E0E0", VA = "0x18A53F0E0")]
		public static bool ROAWRGZSSDM(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA53EDC0", Offset = "0xA53DDC0", VA = "0x18A53EDC0")]
		public static sbyte PSRQDGWDOOR([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA53E9B0", Offset = "0xA53D9B0", VA = "0x18A53E9B0")]
		public static short MDQSFBTQJXS([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA53F3E0", Offset = "0xA53E3E0", VA = "0x18A53F3E0")]
		public static int YIUUXZQEUMC([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA53E660", Offset = "0xA53D660", VA = "0x18A53E660")]
		public static long EHDSJSESECB([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA53E710", Offset = "0xA53D710", VA = "0x18A53E710")]
		public static bool EHXNVFXJFWO(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA53E550", Offset = "0xA53D550", VA = "0x18A53E550")]
		public static byte DGUODXJFDUA([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA53F1B0", Offset = "0xA53E1B0", VA = "0x18A53F1B0")]
		public static ushort XHGZBRIZLIB([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA53E950", Offset = "0xA53D950", VA = "0x18A53E950")]
		public static uint KKSXDVBJKFZ([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA53E5B0", Offset = "0xA53D5B0", VA = "0x18A53E5B0")]
		public static ulong EFXNBUACKQY([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA53EA10", Offset = "0xA53DA10", VA = "0x18A53EA10")]
		public static bool MDWQFLZZSPL(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA53F210", Offset = "0xA53E210", VA = "0x18A53F210")]
		public static bool YAXACRTGJEN(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA53EBC0", Offset = "0xA53DBC0", VA = "0x18A53EBC0")]
		public static bool MXFMLXNIXYB(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA53E8B0", Offset = "0xA53D8B0", VA = "0x18A53E8B0")]
		public static bool IGBVTHTOTSH(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA53ECD0", Offset = "0xA53DCD0", VA = "0x18A53ECD0")]
		public static float NSIBKGAMDQC([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA53F150", Offset = "0xA53E150", VA = "0x18A53F150")]
		public static bool WCQLFWLWIRJ(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA53EE20", Offset = "0xA53DE20", VA = "0x18A53EE20")]
		public static double PYVEZOAIUDN([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA53EB60", Offset = "0xA53DB60", VA = "0x18A53EB60")]
		public static bool MTOWNRQHWKS(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA52FA90", Offset = "0xA52EA90", VA = "0x18A52FA90")]
		public static int ZAXPAUUTCVN(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA52F0D0", Offset = "0xA52E0D0", VA = "0x18A52F0D0")]
		public static int UTYMYJXZWSM(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA53EF10", Offset = "0xA53DF10", VA = "0x18A53EF10")]
		public static bool RLLPLGILEDY([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class NSEEUPXXFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA53F550", Offset = "0xA53E550", VA = "0x18A53F550")]
		public static bool BSVWLEYOHBZ(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class AJNMRNWNLIK
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding ZGENQAPXYAB;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class GVYHFFNCADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA535A40", Offset = "0xA534A40", VA = "0x18A535A40")]
		public static void AGDMWFSTARB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA5359D0", Offset = "0xA5349D0", VA = "0x18A5359D0")]
		public static void AFYFYYYVRFS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA535B20", Offset = "0xA534B20", VA = "0x18A535B20")]
		public static void AGOAQTGNTNT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA535AB0", Offset = "0xA534AB0", VA = "0x18A535AB0")]
		public static void AGITTMMQKCK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA535D50", Offset = "0xA534D50", VA = "0x18A535D50")]
		public static void AIORPIXNJXF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA535CE0", Offset = "0xA534CE0", VA = "0x18A535CE0")]
		public static void AIJKSCDQALW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA536730", Offset = "0xA535730", VA = "0x18A536730")]
		public static void UDKEQNBSBWU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA5367A0", Offset = "0xA5357A0", VA = "0x18A5367A0")]
		public static void UDPLNTVPLID(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA536810", Offset = "0xA535810", VA = "0x18A536810")]
		public static void UDUSLAPMUTM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA536880", Offset = "0xA535880", VA = "0x18A536880")]
		public static void UDZZIHJKEEV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA536530", Offset = "0xA535530", VA = "0x18A536530")]
		public static void UCPDBMACQDK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA5365B0", Offset = "0xA5355B0", VA = "0x18A5365B0")]
		public static void UCUJYSTZZOT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA536630", Offset = "0xA535630", VA = "0x18A536630")]
		public static void UCZQVZNXJAC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA5366B0", Offset = "0xA5356B0", VA = "0x18A5366B0")]
		public static void UDEXTGHUSLL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA536430", Offset = "0xA535430", VA = "0x18A536430")]
		public static void UBUBMKYNEKA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA5364B0", Offset = "0xA5354B0", VA = "0x18A5364B0")]
		public static void UBZIJRSKNVJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA536190", Offset = "0xA535190", VA = "0x18A536190")]
		public static void NYZIIZOFVEL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA536110", Offset = "0xA535110", VA = "0x18A536110")]
		public static void NYUBLSUILTC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA536290", Offset = "0xA535290", VA = "0x18A536290")]
		public static void NZJWDNCAOBD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA536210", Offset = "0xA535210", VA = "0x18A536210")]
		public static void NZEPGGIDEPU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA535F70", Offset = "0xA534F70", VA = "0x18A535F70")]
		public static void NYEGTYMQJLB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA535EE0", Offset = "0xA534EE0", VA = "0x18A535EE0")]
		public static void NXYZWRSSZZS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA536080", Offset = "0xA535080", VA = "0x18A536080")]
		public static void NYOUOMALCHT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA535FF0", Offset = "0xA534FF0", VA = "0x18A535FF0")]
		public static void NYJNRFGNSWK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA5363A0", Offset = "0xA5353A0", VA = "0x18A5363A0")]
		public static void OAPLNBRKSRF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA536310", Offset = "0xA535310", VA = "0x18A536310")]
		public static void OAKEPUXNJFW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA535DC0", Offset = "0xA534DC0", VA = "0x18A535DC0")]
		public static void GYIDKHGDFMC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA535E50", Offset = "0xA534E50", VA = "0x18A535E50")]
		public static void GYNKHOAAOXL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA535B90", Offset = "0xA534B90", VA = "0x18A535B90")]
		public static void AGTHOAALCZC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA535C70", Offset = "0xA534C70", VA = "0x18A535C70")]
		public static void AHJCFUIDFHD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA535C00", Offset = "0xA534C00", VA = "0x18A535C00")]
		public static void AHDVINOFVVU(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class OYCSBWNEKER
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA53F860", Offset = "0xA53E860", VA = "0x18A53F860")]
		public static void AIORPIXNJXF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA53F7F0", Offset = "0xA53E7F0", VA = "0x18A53F7F0")]
		public static void AIJKSCDQALW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA5401A0", Offset = "0xA53F1A0", VA = "0x18A5401A0")]
		public static void UDKEQNBSBWU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA540210", Offset = "0xA53F210", VA = "0x18A540210")]
		public static void UDPLNTVPLID(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA540280", Offset = "0xA53F280", VA = "0x18A540280")]
		public static void UDUSLAPMUTM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA5402F0", Offset = "0xA53F2F0", VA = "0x18A5402F0")]
		public static void UDZZIHJKEEV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA53FFD0", Offset = "0xA53EFD0", VA = "0x18A53FFD0")]
		public static void UCPDBMACQDK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA540040", Offset = "0xA53F040", VA = "0x18A540040")]
		public static void UCUJYSTZZOT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA5400B0", Offset = "0xA53F0B0", VA = "0x18A5400B0")]
		public static void UCZQVZNXJAC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA540120", Offset = "0xA53F120", VA = "0x18A540120")]
		public static void UDEXTGHUSLL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA53FED0", Offset = "0xA53EED0", VA = "0x18A53FED0")]
		public static void UBUBMKYNEKA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA53FF50", Offset = "0xA53EF50", VA = "0x18A53FF50")]
		public static void UBZIJRSKNVJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA53FC50", Offset = "0xA53EC50", VA = "0x18A53FC50")]
		public static void NYZIIZOFVEL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA53FBD0", Offset = "0xA53EBD0", VA = "0x18A53FBD0")]
		public static void NYUBLSUILTC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA53FD50", Offset = "0xA53ED50", VA = "0x18A53FD50")]
		public static void NZJWDNCAOBD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA53FCD0", Offset = "0xA53ECD0", VA = "0x18A53FCD0")]
		public static void NZEPGGIDEPU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA53FA50", Offset = "0xA53EA50", VA = "0x18A53FA50")]
		public static void NYEGTYMQJLB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA53F9D0", Offset = "0xA53E9D0", VA = "0x18A53F9D0")]
		public static void NXYZWRSSZZS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA53FB50", Offset = "0xA53EB50", VA = "0x18A53FB50")]
		public static void NYOUOMALCHT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA53FAD0", Offset = "0xA53EAD0", VA = "0x18A53FAD0")]
		public static void NYJNRFGNSWK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA53FE50", Offset = "0xA53EE50", VA = "0x18A53FE50")]
		public static void OAPLNBRKSRF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA53FDD0", Offset = "0xA53EDD0", VA = "0x18A53FDD0")]
		public static void OAKEPUXNJFW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA53F8D0", Offset = "0xA53E8D0", VA = "0x18A53F8D0")]
		public static void GYIDKHGDFMC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA53F950", Offset = "0xA53E950", VA = "0x18A53F950")]
		public static void GYNKHOAAOXL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA535B90", Offset = "0xA534B90", VA = "0x18A535B90")]
		public static void AGTHOAALCZC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA535C70", Offset = "0xA534C70", VA = "0x18A535C70")]
		public static void AHJCFUIDFHD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA535C00", Offset = "0xA534C00", VA = "0x18A535C00")]
		public static void AHDVINOFVVU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA535A40", Offset = "0xA534A40", VA = "0x18A535A40")]
		public static void AGDMWFSTARB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA5359D0", Offset = "0xA5349D0", VA = "0x18A5359D0")]
		public static void AFYFYYYVRFS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA535B20", Offset = "0xA534B20", VA = "0x18A535B20")]
		public static void AGOAQTGNTNT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA535AB0", Offset = "0xA534AB0", VA = "0x18A535AB0")]
		public static void AGITTMMQKCK(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class ISIYQSYOLUP
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool NSXGILIHIVU;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA54B2D0", Offset = "0xA54A2D0", VA = "0x18A54B2D0")]
		public static void HBKKGMASXEB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA54CD20", Offset = "0xA54BD20", VA = "0x18A54CD20")]
		public static void XOOGFOFDMMA(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x2B67E80", Offset = "0x2B66E80", VA = "0x182B67E80")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA546320", Offset = "0xA545320", VA = "0x18A546320")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA546280", Offset = "0xA545280", VA = "0x18A546280")]
		public static DiyFp MSNRYILABKS(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA546290", Offset = "0xA545290", VA = "0x18A546290")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA5461E0", Offset = "0xA5451E0", VA = "0x18A5461E0")]
		public static DiyFp LKWFJUPPTHS(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA5461A0", Offset = "0xA5451A0", VA = "0x18A5461A0")]
		public void JVMOALRWMXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA546150", Offset = "0xA545150", VA = "0x18A546150")]
		public static DiyFp JVMOALRWMXP(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xDAE230", Offset = "0xDAD230", VA = "0x180DAE230")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA52ED20", Offset = "0xA52DD20", VA = "0x18A52ED20")]
		public void NSIMCXQEMPC(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA554500", Offset = "0xA553500", VA = "0x18A554500")]
		public void OVHOVBDXAPS(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA554720", Offset = "0xA553720", VA = "0x18A554720")]
		public void XHPJVMETVZK(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA554680", Offset = "0xA553680", VA = "0x18A554680")]
		public void XHPJVMETVZK(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA554480", Offset = "0xA553480", VA = "0x18A554480")]
		public void CEZJUHEBYRM(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA554580", Offset = "0xA553580", VA = "0x18A554580")]
		public void XBIXAWFHHIR(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class XDSJDWFCVPD
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
		private static byte[] OPLCWAXVNVU;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] DKSNXERCBXA;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] DWSTWIRXFUA;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] TFZPYSCGQLL;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags AHMWUANAHDI;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char SJYTSBRCPUC;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int BBWAIAEAKTI;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int TZAGEMWSLSS;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] HLABMMQMUVS;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA55B9D0", Offset = "0xA55A9D0", VA = "0x18A55B9D0")]
		private static byte[] CYCJISUNBKW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA55B8F0", Offset = "0xA55A8F0", VA = "0x18A55B8F0")]
		private static byte[] CCOFPOSRNOO(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA55CD10", Offset = "0xA55BD10", VA = "0x18A55CD10")]
		public static int WFFJHJZZYTT(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA55CBF0", Offset = "0xA55BBF0", VA = "0x18A55CBF0")]
		public static int WFFJHJZZYTT(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA55CE30", Offset = "0xA55BE30", VA = "0x18A55CE30")]
		private static bool WWCBMYNWIID(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA55CB00", Offset = "0xA55BB00", VA = "0x18A55CB00")]
		private static void VCGFYZSGWUH(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA55D2C0", Offset = "0xA55C2C0", VA = "0x18A55D2C0")]
		private static bool ZGUNTNVQWAP(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA55C680", Offset = "0xA55B680", VA = "0x18A55C680")]
		private static bool QQIKKDDOXZR(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA55BC70", Offset = "0xA55AC70", VA = "0x18A55BC70")]
		private static bool HTYPKPNQQUA(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA55BAA0", Offset = "0xA55AAA0", VA = "0x18A55BAA0")]
		private static bool GIGCNAEJJZT(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA55BD70", Offset = "0xA55AD70", VA = "0x18A55BD70")]
		private static bool KSXLVCDSRTO(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA55CF20", Offset = "0xA55BF20", VA = "0x18A55CF20")]
		private static void YHTIDZZOQWQ(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA55C250", Offset = "0xA55B250", VA = "0x18A55C250")]
		private static void PRGRVGFJPSU(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA55B700", Offset = "0xA55A700", VA = "0x18A55B700")]
		private static bool AWKBRIZBHVX(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0xA546950", Offset = "0xA545950", VA = "0x18A546950")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5468B0", Offset = "0xA5458B0", VA = "0x18A5468B0")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA546840", Offset = "0xA545840", VA = "0x18A546840")]
		public DiyFp ZXLPLBWWLXU()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5467C0", Offset = "0xA5457C0", VA = "0x18A5467C0")]
		public DiyFp ZWYFCTMVTVX()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xECDF60", Offset = "0xECCF60", VA = "0x180ECDF60")]
		public ulong HQQOUHYRFIQ()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA546330", Offset = "0xA545330", VA = "0x18A546330")]
		public double ARAFOTTPCGC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA546440", Offset = "0xA545440", VA = "0x18A546440")]
		public double CWMKAROTPIK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA546560", Offset = "0xA545560", VA = "0x18A546560")]
		public int OITTXQNFQUR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA546590", Offset = "0xA545590", VA = "0x18A546590")]
		public ulong ONOOPHSZLOB()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA546520", Offset = "0xA545520", VA = "0x18A546520")]
		public bool IUUVQYSCZGS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA546660", Offset = "0xA545660", VA = "0x18A546660")]
		public bool XJVDKCMNMZH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA5464E0", Offset = "0xA5454E0", VA = "0x18A5464E0")]
		public bool HNULVEAVSOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xA5465C0", Offset = "0xA5455C0", VA = "0x18A5465C0")]
		public bool QQIXOXZRLKW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA546640", Offset = "0xA545640", VA = "0x18A546640")]
		public int VOYAXZWRNNN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA546680", Offset = "0xA545680", VA = "0x18A546680")]
		public void YHVWIWKKVGJ([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA5465F0", Offset = "0xA5455F0", VA = "0x18A5465F0")]
		public bool VBLKQVNCHVF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x406BD00", Offset = "0x406AD00", VA = "0x18406BD00")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA546540", Offset = "0xA545540", VA = "0x18A546540")]
		public static int MEZLGVSDYBA(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA546510", Offset = "0xA545510", VA = "0x18A546510")]
		public static double HOZZMDTFCKK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA5463B0", Offset = "0xA5453B0", VA = "0x18A5463B0")]
		public static ulong ASCNYHGQIND(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x1862330", Offset = "0x1861330", VA = "0x181862330")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA554420", Offset = "0xA553420", VA = "0x18A554420")]
		public DiyFp ZXLPLBWWLXU()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xF58350", Offset = "0xF57350", VA = "0x180F58350")]
		public uint OSXBDQZTDNR()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA554270", Offset = "0xA553270", VA = "0x18A554270")]
		public int OITTXQNFQUR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA554290", Offset = "0xA553290", VA = "0x18A554290")]
		public uint ONOOPHSZLOB()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA554260", Offset = "0xA553260", VA = "0x18A554260")]
		public bool IUUVQYSCZGS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA5542F0", Offset = "0xA5532F0", VA = "0x18A5542F0")]
		public void YHVWIWKKVGJ([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA5542B0", Offset = "0xA5532B0", VA = "0x18A5542B0")]
		public bool VBLKQVNCHVF()
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
		[Cpp2IlInjected.Address(RVA = "0xA5457D0", Offset = "0xA5447D0", VA = "0x18A5457D0")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class TMNAXFFBMUO
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] GTLDTSGIWVF;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA555AD0", Offset = "0xA554AD0", VA = "0x18A555AD0")]
		public static void XQXAGEPMGTV(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA555A00", Offset = "0xA554A00", VA = "0x18A555A00")]
		public static void QWTEXTTPJRW(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0xA55AEC0", Offset = "0xA559EC0", VA = "0x18A55AEC0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4EDAEA0", Offset = "0x4ED9EA0", VA = "0x184EDAEA0")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D9EC20", Offset = "0x2D9DC20", VA = "0x182D9EC20")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA55AE60", Offset = "0xA559E60", VA = "0x18A55AE60")]
		public Vector XDJQCPRTPPB(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class MKDZATYDUPZ
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] IGCILEMEZIF;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] TBWVPUCYJPS;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int CVROUVQHDYJ;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA54EB10", Offset = "0xA54DB10", VA = "0x18A54EB10")]
		private static byte[] FJWFTTVOCTH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA54F840", Offset = "0xA54E840", VA = "0x18A54F840")]
		private static Vector UXJECJYWZPV(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA54EA30", Offset = "0xA54DA30", VA = "0x18A54EA30")]
		private static Vector COWBCPXGVAR(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA54F7B0", Offset = "0xA54E7B0", VA = "0x18A54F7B0")]
		private static void RVRLKBKVRBO(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA54FAB0", Offset = "0xA54EAB0", VA = "0x18A54FAB0")]
		private static void YSBRJFJFOSZ(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA54EBF0", Offset = "0xA54DBF0", VA = "0x18A54EBF0")]
		private static ulong JUGXCTCJRMM(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA550190", Offset = "0xA54F190", VA = "0x18A550190")]
		private static void ZEIFQTUAIZA(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA54F2C0", Offset = "0xA54E2C0", VA = "0x18A54F2C0")]
		private static bool NEQXIEEDMWN(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA54F920", Offset = "0xA54E920", VA = "0x18A54F920")]
		private static DiyFp WJQBZCWBWZM(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA54EC80", Offset = "0xA54DC80", VA = "0x18A54EC80")]
		private static bool MPTZRDTMFKY(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA54F690", Offset = "0xA54E690", VA = "0x18A54F690")]
		private static bool RTWRSBOYVDW(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA54FDA0", Offset = "0xA54EDA0", VA = "0x18A54FDA0")]
		public static double? YVOZOGBBHCE(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA54FEC0", Offset = "0xA54EEC0", VA = "0x18A54FEC0")]
		public static float? YVZNITOVZYW(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class EXDRWPDZEXH
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] KGWZXFHJPWF;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] DWSTWIRXFUA;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] TFZPYSCGQLL;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] OABHEXCQYXZ;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int TYGLGVDFOKL;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] RELCFUBTVLT;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int IEODXFMEGEN;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA547550", Offset = "0xA546550", VA = "0x18A547550")]
		private static byte[] PDKKJSIZGWI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA548620", Offset = "0xA547620", VA = "0x18A548620")]
		public static bool WCQLFWLWIRJ(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA547120", Offset = "0xA546120", VA = "0x18A547120")]
		public static bool MTOWNRQHWKS(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA546F70", Offset = "0xA545F70", VA = "0x18A546F70")]
		private static bool HFDGVGZJLFV(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA547280", Offset = "0xA546280", VA = "0x18A547280")]
		private static bool NYSADAGGKQO(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA548760", Offset = "0xA547760", VA = "0x18A548760")]
		private static bool ZKHTXZOKYQT(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA5470B0", Offset = "0xA5460B0", VA = "0x18A5470B0")]
		private static bool JNYBASSPSMZ(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA547260", Offset = "0xA546260", VA = "0x18A547260")]
		private static double NNPYCQOCSUI(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA547630", Offset = "0xA546630", VA = "0x18A547630")]
		private static double VLVNYLGGEQC(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class AVOCAZDEOKU<a> : AAZMAJKQBQQ<a[]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly CFWGMFCGTFE<a> ENBPLTHTULH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour PFFBQFKRDAL;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1959A90", Offset = "0x1958A90", VA = "0x181959A90")]
		public AVOCAZDEOKU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
		public AVOCAZDEOKU(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x73257A0", Offset = "0x73247A0", VA = "0x1873257A0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7325050", Offset = "0x7324050", VA = "0x187325050", Slot = "5")]
		public a[] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class YJPLQKWFUON<a> : AAZMAJKQBQQ<ArraySegment<a>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly CFWGMFCGTFE<a> ENBPLTHTULH;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x50D9810", Offset = "0x50D8810", VA = "0x1850D9810", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x50D93A0", Offset = "0x50D83A0", VA = "0x1850D93A0", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class VJIWKOAPLHV<a> : AAZMAJKQBQQ<List<a>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour PFFBQFKRDAL;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1959A90", Offset = "0x1958A90", VA = "0x181959A90")]
		public VJIWKOAPLHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
		public VJIWKOAPLHV(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8027C50", Offset = "0x8026C50", VA = "0x188027C50", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8025110", Offset = "0x8024110", VA = "0x188025110", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class JLBPBMLDBLX<a, b, c, d> : AAZMAJKQBQQ<d>, OUOPVATJLZR where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x66FB060", Offset = "0x66FA060", VA = "0x1866FB060", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x66F9500", Offset = "0x66F8500", VA = "0x1866F9500", Slot = "5")]
		public d Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c RUNQPUHUUNX(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		protected JLBPBMLDBLX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class JLGVYTFAKXG<a, b, c> : JLBPBMLDBLX<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x62D57E0", Offset = "0x62D47E0", VA = "0x1862D57E0", Slot = "6")]
		protected override IEnumerator<a> RUNQPUHUUNX(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		protected JLGVYTFAKXG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class JLMCVZYXUIP<a, b> : JLGVYTFAKXG<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD5A620", Offset = "0xD59620", VA = "0x180D5A620", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class DQRVYLWBLQN<a, b> : JLMCVZYXUIP<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x53BB8A0", Offset = "0x53BA8A0", VA = "0x1853BB8A0", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x53BB730", Offset = "0x53BA730", VA = "0x1853BB730", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class HEVCZYJCCCM<a> : JLBPBMLDBLX<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x650BF90", Offset = "0x650AF90", VA = "0x18650BF90", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD5A620", Offset = "0xD59620", VA = "0x180D5A620", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x650BF30", Offset = "0x650AF30", VA = "0x18650BF30", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5715020", Offset = "0x5714020", VA = "0x185715020", Slot = "6")]
		protected override LinkedList<a>.Enumerator RUNQPUHUUNX(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class TCDCJGUPXQB<a> : JLBPBMLDBLX<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD300", Offset = "0x4EDC300", VA = "0x184EDD300", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD3F0", Offset = "0x4EDC3F0", VA = "0x184EDD3F0", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x62D6200", Offset = "0x62D5200", VA = "0x1862D6200", Slot = "6")]
		protected override Queue<a>.Enumerator RUNQPUHUUNX(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xD5A620", Offset = "0xD59620", VA = "0x180D5A620", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class CMTSFVDEUET<a> : JLBPBMLDBLX<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5084270", Offset = "0x5083270", VA = "0x185084270", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x50844C0", Offset = "0x50834C0", VA = "0x1850844C0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x5084500", Offset = "0x5083500", VA = "0x185084500", Slot = "6")]
		protected override Stack<a>.Enumerator RUNQPUHUUNX(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x5084350", Offset = "0x5083350", VA = "0x185084350", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class FQQMQXLQVIT<a> : JLBPBMLDBLX<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x62D6110", Offset = "0x62D5110", VA = "0x1862D6110", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xD5A620", Offset = "0xD59620", VA = "0x180D5A620", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x62D6150", Offset = "0x62D5150", VA = "0x1862D6150", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x62D61B0", Offset = "0x62D51B0", VA = "0x1862D61B0", Slot = "6")]
		protected override HashSet<a>.Enumerator RUNQPUHUUNX(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x62D62B0", Offset = "0x62D52B0", VA = "0x1862D62B0")]
		public FQQMQXLQVIT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class PDAHKTXGJKV<a> : JLGVYTFAKXG<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5084270", Offset = "0x5083270", VA = "0x185084270", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7533E30", Offset = "0x7532E30", VA = "0x187533E30", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7533ED0", Offset = "0x7532ED0", VA = "0x187533ED0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class VVNHOHWQYOC<a> : JLGVYTFAKXG<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD300", Offset = "0x4EDC300", VA = "0x184EDD300", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD3F0", Offset = "0x4EDC3F0", VA = "0x184EDD3F0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xD5A620", Offset = "0xD59620", VA = "0x180D5A620", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class BEFPWJUVHHE<a> : JLGVYTFAKXG<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD300", Offset = "0x4EDC300", VA = "0x184EDD300", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD3F0", Offset = "0x4EDC3F0", VA = "0x184EDD3F0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xD5A620", Offset = "0xD59620", VA = "0x180D5A620", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class GMKYJBLDUSY<a> : JLGVYTFAKXG<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x50DA520", Offset = "0x50D9520", VA = "0x1850DA520", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x50844C0", Offset = "0x50834C0", VA = "0x1850844C0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x63D1BB0", Offset = "0x63D0BB0", VA = "0x1863D1BB0", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x63D1C20", Offset = "0x63D0C20", VA = "0x1863D1C20")]
		public GMKYJBLDUSY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class BSHTXLAJYDO<a, b> : AAZMAJKQBQQ<IGrouping<a, b>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x4F0CD30", Offset = "0x4F0BD30", VA = "0x184F0CD30", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x4F0C9C0", Offset = "0x4F0B9C0", VA = "0x184F0C9C0", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class JZWFAJRSVKN<a, b> : AAZMAJKQBQQ<ILookup<a, b>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x674D260", Offset = "0x674C260", VA = "0x18674D260", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x674CF00", Offset = "0x674BF00", VA = "0x18674CF00", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class HVRACORBRYB<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a QMCRYWZIPRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> TSSFHGSGARF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8660", Offset = "0x4ED7660", VA = "0x184ED8660", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6526FB0", Offset = "0x6525FB0", VA = "0x186526FB0")]
		public HVRACORBRYB(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x6526EB0", Offset = "0x6525EB0", VA = "0x186526EB0", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6526F80", Offset = "0x6525F80", VA = "0x186526F80", Slot = "6")]
		private IEnumerator YIRXJWVWWXR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class ZSWINUSNNPU<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> FSZJYQPNVEQ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x5149BE0", Offset = "0x5148BE0", VA = "0x185149BE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public ZSWINUSNNPU(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5149A40", Offset = "0x5148A40", VA = "0x185149A40", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x5149B30", Offset = "0x5148B30", VA = "0x185149B30", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x5149B30", Offset = "0x5148B30", VA = "0x185149B30", Slot = "7")]
		private IEnumerator YIRXJWVWWXR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class LMVRKCZHIHJ<a> : AAZMAJKQBQQ<a>, OUOPVATJLZR where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x6962ED0", Offset = "0x6961ED0", VA = "0x186962ED0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x6962CB0", Offset = "0x6961CB0", VA = "0x186962CB0", Slot = "5")]
		public a Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public LMVRKCZHIHJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class TRYJMWARYNN : AAZMAJKQBQQ<IEnumerable>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly AAZMAJKQBQQ<IEnumerable> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA5570D0", Offset = "0xA5560D0", VA = "0x18A5570D0", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA556EC0", Offset = "0xA555EC0", VA = "0x18A556EC0", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public TRYJMWARYNN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class NURBUFNSJKZ : AAZMAJKQBQQ<ICollection>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly AAZMAJKQBQQ<ICollection> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA551910", Offset = "0xA550910", VA = "0x18A551910", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA551700", Offset = "0xA550700", VA = "0x18A551700", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public NURBUFNSJKZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class CBOUHTYYZMV : AAZMAJKQBQQ<IList>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly AAZMAJKQBQQ<IList> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA5450B0", Offset = "0xA5440B0", VA = "0x18A5450B0", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA544EA0", Offset = "0xA543EA0", VA = "0x18A544EA0", Slot = "5")]
		public IList Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public CBOUHTYYZMV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class FVEGUNOIOJW<a> : JLMCVZYXUIP<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD300", Offset = "0x4EDC300", VA = "0x184EDD300", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x508F9A0", Offset = "0x508E9A0", VA = "0x18508F9A0", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class CYJRPVGKEHU<a> : JLGVYTFAKXG<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD300", Offset = "0x4EDC300", VA = "0x184EDD300", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x508F9A0", Offset = "0x508E9A0", VA = "0x18508F9A0", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x508F930", Offset = "0x508E930", VA = "0x18508F930", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class YMQCNTCRELC<a> : JLGVYTFAKXG<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x50DA480", Offset = "0x50D9480", VA = "0x1850DA480", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x50844C0", Offset = "0x50834C0", VA = "0x1850844C0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x50DA680", Offset = "0x50D9680", VA = "0x1850DA680", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x50DA700", Offset = "0x50D9700", VA = "0x1850DA700")]
		public YMQCNTCRELC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class JSCTTFWESUQ<a> : JLGVYTFAKXG<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x50DA480", Offset = "0x50D9480", VA = "0x1850DA480", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x50844C0", Offset = "0x50834C0", VA = "0x1850844C0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x63D1BB0", Offset = "0x63D0BB0", VA = "0x1863D1BB0", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x63D1C20", Offset = "0x63D0C20", VA = "0x1863D1C20")]
		public JSCTTFWESUQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class HENGWWTXAWQ<a> : JLGVYTFAKXG<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x62D6020", Offset = "0x62D5020", VA = "0x1862D6020", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xD5A620", Offset = "0xD59620", VA = "0x180D5A620", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x650BF30", Offset = "0x650AF30", VA = "0x18650BF30", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class JKUAMCQQBZW<a> : JLMCVZYXUIP<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD300", Offset = "0x4EDC300", VA = "0x184EDD300", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD3F0", Offset = "0x4EDC3F0", VA = "0x184EDD3F0", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class WHQIDCKDQPZ<a> : JLMCVZYXUIP<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD300", Offset = "0x4EDC300", VA = "0x184EDD300", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD3F0", Offset = "0x4EDC3F0", VA = "0x184EDD3F0", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class GHBFYOHYRQW<a> : JLGVYTFAKXG<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5084270", Offset = "0x5083270", VA = "0x185084270", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x50844C0", Offset = "0x50834C0", VA = "0x1850844C0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x63CA230", Offset = "0x63C9230", VA = "0x1863CA230", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class FSEAKFCMYDF
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
		[Cpp2IlInjected.Address(RVA = "0xA549AD0", Offset = "0xA548AD0", VA = "0x18A549AD0")]
		public static DateTime AAVJJOONPZB(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA54A030", Offset = "0xA549030", VA = "0x18A54A030")]
		public static bool UDQPIYRQXLU(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA549B90", Offset = "0xA548B90", VA = "0x18A549B90")]
		public static bool CLXOYGVRGLE(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA549E20", Offset = "0xA548E20", VA = "0x18A549E20")]
		public static bool CLXOYGVRGLE(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA54A1E0", Offset = "0xA5491E0", VA = "0x18A54A1E0")]
		public static bool ZBZYEOGSVIE(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class TYATNZHHDCH : AAZMAJKQBQQ<DateTime>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly AAZMAJKQBQQ<DateTime> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xA558750", Offset = "0xA557750", VA = "0x18A558750", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA5581D0", Offset = "0xA5571D0", VA = "0x18A5581D0", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA558350", Offset = "0xA557350", VA = "0x18A558350")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public TYATNZHHDCH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class TGSWEHBVCXQ : AAZMAJKQBQQ<DateTimeOffset>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly AAZMAJKQBQQ<DateTimeOffset> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA554BF0", Offset = "0xA553BF0", VA = "0x18A554BF0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA5547A0", Offset = "0xA5537A0", VA = "0x18A5547A0", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA554810", Offset = "0xA553810", VA = "0x18A554810")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public TGSWEHBVCXQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class TXOQQQKQUIX : AAZMAJKQBQQ<TimeSpan>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly AAZMAJKQBQQ<TimeSpan> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] ENNBUHYUQYT;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA557AB0", Offset = "0xA556AB0", VA = "0x18A557AB0", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA557640", Offset = "0xA556640", VA = "0x18A557640", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA5576C0", Offset = "0xA5566C0", VA = "0x18A5576C0")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public TXOQQQKQUIX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class FLUPSBGZHWC<a, b, c, d, e> : AAZMAJKQBQQ<e>, OUOPVATJLZR where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x62CFB10", Offset = "0x62CEB10", VA = "0x1862CFB10", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x62CEEB0", Offset = "0x62CDEB0", VA = "0x1862CEEB0", Slot = "5")]
		public e Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d RUNQPUHUUNX(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		protected FLUPSBGZHWC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class FLZWPIAWRHL<a, b, c, d> : FLUPSBGZHWC<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x62D57E0", Offset = "0x62D47E0", VA = "0x1862D57E0", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> RUNQPUHUUNX(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x53BB3D0", Offset = "0x53BA3D0", VA = "0x1853BB3D0")]
		protected FLZWPIAWRHL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class FKPAIMRPDGA<a, b, c> : FLZWPIAWRHL<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xD5A620", Offset = "0xD59620", VA = "0x180D5A620", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class KRVMBVHNCJQ<a, b> : FLUPSBGZHWC<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6865DE0", Offset = "0x6864DE0", VA = "0x186865DE0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xD5A620", Offset = "0xD59620", VA = "0x180D5A620", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6865F00", Offset = "0x6864F00", VA = "0x186865F00", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6866010", Offset = "0x6865010", VA = "0x186866010", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator RUNQPUHUUNX(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6866140", Offset = "0x6865140", VA = "0x186866140")]
		public KRVMBVHNCJQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class FQYFWZIXNZQ<a, b, c> : FKPAIMRPDGA<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x62D62D0", Offset = "0x62D52D0", VA = "0x1862D62D0", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x62D64C0", Offset = "0x62D54C0", VA = "0x1862D64C0", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class SBHVYJIDLVB<a, b> : FLZWPIAWRHL<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x4F22C40", Offset = "0x4F21C40", VA = "0x184F22C40", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x4F22DB0", Offset = "0x4F21DB0", VA = "0x184F22DB0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xD5A620", Offset = "0xD59620", VA = "0x180D5A620", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class BZZWVZNAUIZ<a, b> : FKPAIMRPDGA<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x4F22C40", Offset = "0x4F21C40", VA = "0x184F22C40", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x4F22DB0", Offset = "0x4F21DB0", VA = "0x184F22DB0", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class VBISTCPHWWN<a, b> : FLUPSBGZHWC<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x4F22C40", Offset = "0x4F21C40", VA = "0x184F22C40", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xD5A620", Offset = "0xD59620", VA = "0x180D5A620", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x4F22DB0", Offset = "0x4F21DB0", VA = "0x184F22DB0", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x80170A0", Offset = "0x80160A0", VA = "0x1880170A0", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator RUNQPUHUUNX(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class RPUZXRICPYA<a, b> : FLZWPIAWRHL<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x4F22C40", Offset = "0x4F21C40", VA = "0x184F22C40", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x78310A0", Offset = "0x78300A0", VA = "0x1878310A0", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7831110", Offset = "0x7830110", VA = "0x187831110", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class OJSZZNUDGIB<a, b> : FLZWPIAWRHL<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x73ECCC0", Offset = "0x73EBCC0", VA = "0x1873ECCC0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD5A620", Offset = "0xD59620", VA = "0x180D5A620", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x73ECD00", Offset = "0x73EBD00", VA = "0x1873ECD00", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x73ECDC0", Offset = "0x73EBDC0", VA = "0x1873ECDC0")]
		public OJSZZNUDGIB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class LJYCMRRTXVP<a, b> : FKPAIMRPDGA<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6935790", Offset = "0x6934790", VA = "0x186935790", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x4F22DB0", Offset = "0x4F21DB0", VA = "0x184F22DB0", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class CHETTBDTTFZ<a> : AAZMAJKQBQQ<a>, OUOPVATJLZR where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x5082E20", Offset = "0x5081E20", VA = "0x185082E20", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x5082BF0", Offset = "0x5081BF0", VA = "0x185082BF0", Slot = "5")]
		public a Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public CHETTBDTTFZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class PJNOUXHLGPH : AAZMAJKQBQQ<IDictionary>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly AAZMAJKQBQQ<IDictionary> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA551FA0", Offset = "0xA550FA0", VA = "0x18A551FA0", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA551DC0", Offset = "0xA550DC0", VA = "0x18A551DC0", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public PJNOUXHLGPH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class ZYMKMMQXOTZ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA55E4B0", Offset = "0xA55D4B0", VA = "0x18A55E4B0")]
		public static object HIQFSPUYNXV(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA55DC90", Offset = "0xA55CC90", VA = "0x18A55DC90")]
		public static object FIFRYGVPFQK(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class LMNLSHRBTCA<a> : AAZMAJKQBQQ<a>, OUOPVATJLZR, LTKGVGMANFH<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class CCYEXJECMVG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type RHTSDVZKJJA;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CCYEXJECMVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x5033D50", Offset = "0x5032D50", VA = "0x185033D50")]
			internal bool DQWMIRKXFEL(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class CDDLUPXZWGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string FKNRIIGPNAQ;

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CDDLUPXZWGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x5034DA0", Offset = "0x5033DA0", VA = "0x185034DA0")]
			internal bool DQRFLKQZVTC(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class CDISRWRXFRY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> ROERVLKYNID;

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CDISRWRXFRY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x5035550", Offset = "0x5034550", VA = "0x185035550")]
			internal void DRHADEYRYBD(JsonWriter a, a b, BYGWYMIDFLH c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class CDNZPDLUPDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> WBGSQXMNIPQ;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CDNZPDLUPDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x5036000", Offset = "0x5035000", VA = "0x185036000")]
			internal a DRBTFYEUOPU(JsonReader a, BYGWYMIDFLH b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly BTAXCVOTERJ<a> ETOPLNIDSOI;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> EJYVCXSCCWW;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> IKECCKXPMBQ;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> IJYCNTOGLQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool FNASDOVKIOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> JHDJOFFZCVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> VBVVXZAFBMQ;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x693C640", Offset = "0x693B640", VA = "0x18693C640")]
		static LMNLSHRBTCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x69491A0", Offset = "0x69481A0", VA = "0x1869491A0")]
		public LMNLSHRBTCA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x693AC20", Offset = "0x6939C20", VA = "0x18693AC20", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6938660", Offset = "0x6937660", VA = "0x186938660", Slot = "5")]
		public a Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6939C40", Offset = "0x6938C40", VA = "0x186939C40", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, a b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x69394A0", Offset = "0x69384A0", VA = "0x1869394A0", Slot = "7")]
		public a NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class YMALYWWAKCE<a> : AAZMAJKQBQQ<a[,]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x50DA180", Offset = "0x50D9180", VA = "0x1850DA180", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x50D9DD0", Offset = "0x50D8DD0", VA = "0x1850D9DD0", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public YMALYWWAKCE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class ZEFIZBJTIAK<a> : AAZMAJKQBQQ<a[,,]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5137830", Offset = "0x5136830", VA = "0x185137830", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5137330", Offset = "0x5136330", VA = "0x185137330", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public ZEFIZBJTIAK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class LSAESXZQBQW<a> : AAZMAJKQBQQ<a[,,,]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6973460", Offset = "0x6972460", VA = "0x186973460", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6972E20", Offset = "0x6971E20", VA = "0x186972E20", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public LSAESXZQBQW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class OFDERTJGBHC<a> : AAZMAJKQBQQ<a?>, OUOPVATJLZR where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x73E81C0", Offset = "0x73E71C0", VA = "0x1873E81C0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x73E7B50", Offset = "0x73E6B50", VA = "0x1873E7B50", Slot = "5")]
		public a? Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public OFDERTJGBHC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class QAFKPFIOMMO<a> : AAZMAJKQBQQ<a?>, OUOPVATJLZR where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly AAZMAJKQBQQ<a> ZPIMSGFTAQJ;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		public QAFKPFIOMMO(AAZMAJKQBQQ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x77337E0", Offset = "0x77327E0", VA = "0x1877337E0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7732CE0", Offset = "0x7731CE0", VA = "0x187732CE0", Slot = "5")]
		public a? Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class JKCCYUZVFNX : AAZMAJKQBQQ<sbyte>, OUOPVATJLZR, LTKGVGMANFH<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly JKCCYUZVFNX HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA54D530", Offset = "0xA54C530", VA = "0x18A54D530", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA54D390", Offset = "0xA54C390", VA = "0x18A54D390", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA54D420", Offset = "0xA54C420", VA = "0x18A54D420", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, sbyte b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA54D3A0", Offset = "0xA54C3A0", VA = "0x18A54D3A0", Slot = "7")]
		public sbyte NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public JKCCYUZVFNX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class SXPVXONDPHK : AAZMAJKQBQQ<sbyte?>, OUOPVATJLZR, LTKGVGMANFH<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly SXPVXONDPHK HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA554100", Offset = "0xA553100", VA = "0x18A554100", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA553E60", Offset = "0xA552E60", VA = "0x18A553E60", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA553FA0", Offset = "0xA552FA0", VA = "0x18A553FA0", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, sbyte? b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA553ED0", Offset = "0xA552ED0", VA = "0x18A553ED0", Slot = "7")]
		public sbyte? NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public SXPVXONDPHK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class EIHUGSDZDME : AAZMAJKQBQQ<sbyte[]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly EIHUGSDZDME HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA546CD0", Offset = "0xA545CD0", VA = "0x18A546CD0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA546B90", Offset = "0xA545B90", VA = "0x18A546B90", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public EIHUGSDZDME()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class HNLEJJYNJJM : AAZMAJKQBQQ<short>, OUOPVATJLZR, LTKGVGMANFH<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly HNLEJJYNJJM HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xA54AF40", Offset = "0xA549F40", VA = "0x18A54AF40", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA54ADA0", Offset = "0xA549DA0", VA = "0x18A54ADA0", Slot = "5")]
		public short Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA54AE30", Offset = "0xA549E30", VA = "0x18A54AE30", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, short b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA54ADB0", Offset = "0xA549DB0", VA = "0x18A54ADB0", Slot = "7")]
		public short NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public HNLEJJYNJJM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class HBNACLAMXKX : AAZMAJKQBQQ<short?>, OUOPVATJLZR, LTKGVGMANFH<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly HBNACLAMXKX HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA54AC40", Offset = "0xA549C40", VA = "0x18A54AC40", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA54A9A0", Offset = "0xA5499A0", VA = "0x18A54A9A0", Slot = "5")]
		public short? Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA54AAE0", Offset = "0xA549AE0", VA = "0x18A54AAE0", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, short? b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA54AA10", Offset = "0xA549A10", VA = "0x18A54AA10", Slot = "7")]
		public short? NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public HBNACLAMXKX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class SODAROMLZBL : AAZMAJKQBQQ<short[]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly SODAROMLZBL HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA553BC0", Offset = "0xA552BC0", VA = "0x18A553BC0", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA553A80", Offset = "0xA552A80", VA = "0x18A553A80", Slot = "5")]
		public short[] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public SODAROMLZBL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class NESTYZKHZMQ : AAZMAJKQBQQ<int>, OUOPVATJLZR, LTKGVGMANFH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly NESTYZKHZMQ HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA551600", Offset = "0xA550600", VA = "0x18A551600", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA551460", Offset = "0xA550460", VA = "0x18A551460", Slot = "5")]
		public int Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA5514F0", Offset = "0xA5504F0", VA = "0x18A5514F0", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, int b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA551470", Offset = "0xA550470", VA = "0x18A551470", Slot = "7")]
		public int NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public NESTYZKHZMQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class DBRSGYEYGSJ : AAZMAJKQBQQ<int?>, OUOPVATJLZR, LTKGVGMANFH<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly DBRSGYEYGSJ HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xA545A80", Offset = "0xA544A80", VA = "0x18A545A80", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA5457E0", Offset = "0xA5447E0", VA = "0x18A5457E0", Slot = "5")]
		public int? Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA545920", Offset = "0xA544920", VA = "0x18A545920", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, int? b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA545850", Offset = "0xA544850", VA = "0x18A545850", Slot = "7")]
		public int? NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public DBRSGYEYGSJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class BAHMJYWVOIP : AAZMAJKQBQQ<int[]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly BAHMJYWVOIP HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA544C00", Offset = "0xA543C00", VA = "0x18A544C00", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA544AC0", Offset = "0xA543AC0", VA = "0x18A544AC0", Slot = "5")]
		public int[] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public BAHMJYWVOIP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class IYKVVGGMTGV : AAZMAJKQBQQ<long>, OUOPVATJLZR, LTKGVGMANFH<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly IYKVVGGMTGV HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA54D2C0", Offset = "0xA54C2C0", VA = "0x18A54D2C0", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA54D1A0", Offset = "0xA54C1A0", VA = "0x18A54D1A0", Slot = "5")]
		public long Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA54D1F0", Offset = "0xA54C1F0", VA = "0x18A54D1F0", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, long b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA54D1B0", Offset = "0xA54C1B0", VA = "0x18A54D1B0", Slot = "7")]
		public long NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public IYKVVGGMTGV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class IVSEYGCFZOI : AAZMAJKQBQQ<long?>, OUOPVATJLZR, LTKGVGMANFH<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly IVSEYGCFZOI HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xA54D070", Offset = "0xA54C070", VA = "0x18A54D070", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA54CE00", Offset = "0xA54BE00", VA = "0x18A54CE00", Slot = "5")]
		public long? Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA54CF40", Offset = "0xA54BF40", VA = "0x18A54CF40", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, long? b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA54CE90", Offset = "0xA54BE90", VA = "0x18A54CE90", Slot = "7")]
		public long? NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public IVSEYGCFZOI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class WFBMOHCKZEM : AAZMAJKQBQQ<long[]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly WFBMOHCKZEM HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA55B040", Offset = "0xA55A040", VA = "0x18A55B040", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA55AF00", Offset = "0xA559F00", VA = "0x18A55AF00", Slot = "5")]
		public long[] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public WFBMOHCKZEM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class XBZLDKSYFSK : AAZMAJKQBQQ<byte>, OUOPVATJLZR, LTKGVGMANFH<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly XBZLDKSYFSK HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA55B600", Offset = "0xA55A600", VA = "0x18A55B600", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA55B460", Offset = "0xA55A460", VA = "0x18A55B460", Slot = "5")]
		public byte Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA55B4F0", Offset = "0xA55A4F0", VA = "0x18A55B4F0", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, byte b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA55B470", Offset = "0xA55A470", VA = "0x18A55B470", Slot = "7")]
		public byte NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public XBZLDKSYFSK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class MYGOTMDJXGR : AAZMAJKQBQQ<byte?>, OUOPVATJLZR, LTKGVGMANFH<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly MYGOTMDJXGR HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA550C80", Offset = "0xA54FC80", VA = "0x18A550C80", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA5509E0", Offset = "0xA54F9E0", VA = "0x18A5509E0", Slot = "5")]
		public byte? Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA550B20", Offset = "0xA54FB20", VA = "0x18A550B20", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, byte? b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA550A50", Offset = "0xA54FA50", VA = "0x18A550A50", Slot = "7")]
		public byte? NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public MYGOTMDJXGR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class UIESMOXJNOF : AAZMAJKQBQQ<ushort>, OUOPVATJLZR, LTKGVGMANFH<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly UIESMOXJNOF HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA559EF0", Offset = "0xA558EF0", VA = "0x18A559EF0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA559D50", Offset = "0xA558D50", VA = "0x18A559D50", Slot = "5")]
		public ushort Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA559DE0", Offset = "0xA558DE0", VA = "0x18A559DE0", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, ushort b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA559D60", Offset = "0xA558D60", VA = "0x18A559D60", Slot = "7")]
		public ushort NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public UIESMOXJNOF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class JXGENAFZKJM : AAZMAJKQBQQ<ushort?>, OUOPVATJLZR, LTKGVGMANFH<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly JXGENAFZKJM HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA54D8D0", Offset = "0xA54C8D0", VA = "0x18A54D8D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA54D630", Offset = "0xA54C630", VA = "0x18A54D630", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA54D770", Offset = "0xA54C770", VA = "0x18A54D770", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, ushort? b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA54D6A0", Offset = "0xA54C6A0", VA = "0x18A54D6A0", Slot = "7")]
		public ushort? NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public JXGENAFZKJM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class DQPOIQJGVDG : AAZMAJKQBQQ<ushort[]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly DQPOIQJGVDG HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA545EB0", Offset = "0xA544EB0", VA = "0x18A545EB0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA545D70", Offset = "0xA544D70", VA = "0x18A545D70", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public DQPOIQJGVDG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class SNOGJSICPNB : AAZMAJKQBQQ<uint>, OUOPVATJLZR, LTKGVGMANFH<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly SNOGJSICPNB HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA553980", Offset = "0xA552980", VA = "0x18A553980", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA5537E0", Offset = "0xA5527E0", VA = "0x18A5537E0", Slot = "5")]
		public uint Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA553870", Offset = "0xA552870", VA = "0x18A553870", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, uint b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA5537F0", Offset = "0xA5527F0", VA = "0x18A5537F0", Slot = "7")]
		public uint NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public SNOGJSICPNB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class AVLATJQQWXS : AAZMAJKQBQQ<uint?>, OUOPVATJLZR, LTKGVGMANFH<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly AVLATJQQWXS HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA544960", Offset = "0xA543960", VA = "0x18A544960", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA5446C0", Offset = "0xA5436C0", VA = "0x18A5446C0", Slot = "5")]
		public uint? Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA544800", Offset = "0xA543800", VA = "0x18A544800", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, uint? b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA544730", Offset = "0xA543730", VA = "0x18A544730", Slot = "7")]
		public uint? NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public AVLATJQQWXS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class UWIFGKDNBIC : AAZMAJKQBQQ<uint[]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly UWIFGKDNBIC HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA55A130", Offset = "0xA559130", VA = "0x18A55A130", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA559FF0", Offset = "0xA558FF0", VA = "0x18A559FF0", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public UWIFGKDNBIC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class UCFJQLIMQEG : AAZMAJKQBQQ<ulong>, OUOPVATJLZR, LTKGVGMANFH<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly UCFJQLIMQEG HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xA559C80", Offset = "0xA558C80", VA = "0x18A559C80", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA559B60", Offset = "0xA558B60", VA = "0x18A559B60", Slot = "5")]
		public ulong Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA559BB0", Offset = "0xA558BB0", VA = "0x18A559BB0", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, ulong b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xA559B70", Offset = "0xA558B70", VA = "0x18A559B70", Slot = "7")]
		public ulong NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public UCFJQLIMQEG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class ROYOHDHGYHD : AAZMAJKQBQQ<ulong?>, OUOPVATJLZR, LTKGVGMANFH<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly ROYOHDHGYHD HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xA5536B0", Offset = "0xA5526B0", VA = "0x18A5536B0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA553440", Offset = "0xA552440", VA = "0x18A553440", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA553580", Offset = "0xA552580", VA = "0x18A553580", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, ulong? b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA5534D0", Offset = "0xA5524D0", VA = "0x18A5534D0", Slot = "7")]
		public ulong? NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public ROYOHDHGYHD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class PZLTEVQXKTH : AAZMAJKQBQQ<ulong[]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly PZLTEVQXKTH HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xA552740", Offset = "0xA551740", VA = "0x18A552740", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA552600", Offset = "0xA551600", VA = "0x18A552600", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public PZLTEVQXKTH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class WLLOZIMAILS : AAZMAJKQBQQ<float>, OUOPVATJLZR, LTKGVGMANFH<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly WLLOZIMAILS HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA55B390", Offset = "0xA55A390", VA = "0x18A55B390", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA55B270", Offset = "0xA55A270", VA = "0x18A55B270", Slot = "5")]
		public float Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA55B2C0", Offset = "0xA55A2C0", VA = "0x18A55B2C0", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, float b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA55B280", Offset = "0xA55A280", VA = "0x18A55B280", Slot = "7")]
		public float NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public WLLOZIMAILS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class KDSTGEVYXBZ : AAZMAJKQBQQ<float?>, OUOPVATJLZR, LTKGVGMANFH<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly KDSTGEVYXBZ HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xA54E080", Offset = "0xA54D080", VA = "0x18A54E080", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA54DE50", Offset = "0xA54CE50", VA = "0x18A54DE50", Slot = "5")]
		public float? Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA54DF60", Offset = "0xA54CF60", VA = "0x18A54DF60", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, float? b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA54DEC0", Offset = "0xA54CEC0", VA = "0x18A54DEC0", Slot = "7")]
		public float? NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public KDSTGEVYXBZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class NBEZPYMJCFB : AAZMAJKQBQQ<float[]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly NBEZPYMJCFB HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xA5510D0", Offset = "0xA5500D0", VA = "0x18A5510D0", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA550F90", Offset = "0xA54FF90", VA = "0x18A550F90", Slot = "5")]
		public float[] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public NBEZPYMJCFB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class ZJIAQEPBGZV : AAZMAJKQBQQ<double>, OUOPVATJLZR, LTKGVGMANFH<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly ZJIAQEPBGZV HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xA55DBC0", Offset = "0xA55CBC0", VA = "0x18A55DBC0", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA55DAA0", Offset = "0xA55CAA0", VA = "0x18A55DAA0", Slot = "5")]
		public double Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA55DAF0", Offset = "0xA55CAF0", VA = "0x18A55DAF0", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, double b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA55DAB0", Offset = "0xA55CAB0", VA = "0x18A55DAB0", Slot = "7")]
		public double NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public ZJIAQEPBGZV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class LMWFCDOURXW : AAZMAJKQBQQ<double?>, OUOPVATJLZR, LTKGVGMANFH<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly LMWFCDOURXW HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA54E5D0", Offset = "0xA54D5D0", VA = "0x18A54E5D0", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA54E360", Offset = "0xA54D360", VA = "0x18A54E360", Slot = "5")]
		public double? Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA54E4A0", Offset = "0xA54D4A0", VA = "0x18A54E4A0", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, double? b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA54E3F0", Offset = "0xA54D3F0", VA = "0x18A54E3F0", Slot = "7")]
		public double? NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public LMWFCDOURXW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class VFVLAIAMUPI : AAZMAJKQBQQ<double[]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly VFVLAIAMUPI HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA55A510", Offset = "0xA559510", VA = "0x18A55A510", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA55A3D0", Offset = "0xA5593D0", VA = "0x18A55A3D0", Slot = "5")]
		public double[] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public VFVLAIAMUPI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class MLMRMQXYMFO : AAZMAJKQBQQ<bool>, OUOPVATJLZR, LTKGVGMANFH<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly MLMRMQXYMFO HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA5504B0", Offset = "0xA54F4B0", VA = "0x18A5504B0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA550390", Offset = "0xA54F390", VA = "0x18A550390", Slot = "5")]
		public bool Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA5503E0", Offset = "0xA54F3E0", VA = "0x18A5503E0", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, bool b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA5503A0", Offset = "0xA54F3A0", VA = "0x18A5503A0", Slot = "7")]
		public bool NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public MLMRMQXYMFO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class GPZBFWNSFEF : AAZMAJKQBQQ<bool?>, OUOPVATJLZR, LTKGVGMANFH<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly GPZBFWNSFEF HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA54A640", Offset = "0xA549640", VA = "0x18A54A640", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA54A410", Offset = "0xA549410", VA = "0x18A54A410", Slot = "5")]
		public bool? Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xA54A520", Offset = "0xA549520", VA = "0x18A54A520", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, bool? b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA54A480", Offset = "0xA549480", VA = "0x18A54A480", Slot = "7")]
		public bool? NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public GPZBFWNSFEF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class QNPXHRVZYZR : AAZMAJKQBQQ<bool[]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly QNPXHRVZYZR HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA552F00", Offset = "0xA551F00", VA = "0x18A552F00", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA552DC0", Offset = "0xA551DC0", VA = "0x18A552DC0", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public QNPXHRVZYZR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class VIGYEBFAKZP : AAZMAJKQBQQ<byte[]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly AAZMAJKQBQQ<byte[]> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA55A900", Offset = "0xA559900", VA = "0x18A55A900", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA55A890", Offset = "0xA559890", VA = "0x18A55A890", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public VIGYEBFAKZP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class MPAAQWBAVEY : AAZMAJKQBQQ<ArraySegment<byte>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly AAZMAJKQBQQ<ArraySegment<byte>> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA550840", Offset = "0xA54F840", VA = "0x18A550840", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA550770", Offset = "0xA54F770", VA = "0x18A550770", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public MPAAQWBAVEY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class HXIPOSYZMLC : AAZMAJKQBQQ<string>, OUOPVATJLZR, LTKGVGMANFH<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly AAZMAJKQBQQ<string> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xA54B200", Offset = "0xA54A200", VA = "0x18A54B200", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA54B190", Offset = "0xA54A190", VA = "0x18A54B190", Slot = "5")]
		public string Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA54B1A0", Offset = "0xA54A1A0", VA = "0x18A54B1A0", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, string b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA54B190", Offset = "0xA54A190", VA = "0x18A54B190", Slot = "7")]
		public string NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public HXIPOSYZMLC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class TRBKGGECOEL : AAZMAJKQBQQ<string[]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly TRBKGGECOEL HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA556C90", Offset = "0xA555C90", VA = "0x18A556C90", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA556B40", Offset = "0xA555B40", VA = "0x18A556B40", Slot = "5")]
		public string[] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public TRBKGGECOEL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class HRIJACBCGKI : AAZMAJKQBQQ<char>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly HRIJACBCGKI HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA54B070", Offset = "0xA54A070", VA = "0x18A54B070", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA54B040", Offset = "0xA54A040", VA = "0x18A54B040", Slot = "5")]
		public char Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public HRIJACBCGKI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class EAXYCMCONLN : AAZMAJKQBQQ<char?>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly EAXYCMCONLN HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA546A20", Offset = "0xA545A20", VA = "0x18A546A20", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA546960", Offset = "0xA545960", VA = "0x18A546960", Slot = "5")]
		public char? Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public EAXYCMCONLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class QFRJCTJAKFF : AAZMAJKQBQQ<char[]>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly QFRJCTJAKFF HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA552B00", Offset = "0xA551B00", VA = "0x18A552B00", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA552970", Offset = "0xA551970", VA = "0x18A552970", Slot = "5")]
		public char[] Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public QFRJCTJAKFF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class VPZKZANYKPN : AAZMAJKQBQQ<Guid>, OUOPVATJLZR, LTKGVGMANFH<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly AAZMAJKQBQQ<Guid> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA55AC80", Offset = "0xA559C80", VA = "0x18A55AC80", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA55AA30", Offset = "0xA559A30", VA = "0x18A55AA30", Slot = "5")]
		public Guid Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA55AB00", Offset = "0xA559B00", VA = "0x18A55AB00", Slot = "6")]
		public void REKKNCEGHLB(JsonWriter a, Guid b, BYGWYMIDFLH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA55AA90", Offset = "0xA559A90", VA = "0x18A55AA90", Slot = "7")]
		public Guid NSZSFBQLWOX(JsonReader a, BYGWYMIDFLH b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public VPZKZANYKPN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class KBNTECIXMXP : AAZMAJKQBQQ<decimal>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly AAZMAJKQBQQ<decimal> HPUTZVWRNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool JOAOWHMRTCF;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x889ABD0", Offset = "0x8899BD0", VA = "0x18889ABD0")]
		public KBNTECIXMXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xFE7480", Offset = "0xFE6480", VA = "0x180FE7480")]
		public KBNTECIXMXP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA54DC00", Offset = "0xA54CC00", VA = "0x18A54DC00", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA54DA30", Offset = "0xA54CA30", VA = "0x18A54DA30", Slot = "5")]
		public decimal Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class YIJEDLAGBUK : AAZMAJKQBQQ<Uri>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly AAZMAJKQBQQ<Uri> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA55D950", Offset = "0xA55C950", VA = "0x18A55D950", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA55D8D0", Offset = "0xA55C8D0", VA = "0x18A55D8D0", Slot = "5")]
		public Uri Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public YIJEDLAGBUK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class MYXFBWEVNOM : AAZMAJKQBQQ<Version>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly AAZMAJKQBQQ<Version> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA550E60", Offset = "0xA54FE60", VA = "0x18A550E60", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA550DE0", Offset = "0xA54FDE0", VA = "0x18A550DE0", Slot = "5")]
		public Version Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public MYXFBWEVNOM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class CMFIQFKMJEW<a, b> : AAZMAJKQBQQ<KeyValuePair<a, b>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5083990", Offset = "0x5082990", VA = "0x185083990", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5083490", Offset = "0x5082490", VA = "0x185083490", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class DNVIJFVKZJC : AAZMAJKQBQQ<StringBuilder>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly AAZMAJKQBQQ<StringBuilder> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA545C60", Offset = "0xA544C60", VA = "0x18A545C60", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA545BE0", Offset = "0xA544BE0", VA = "0x18A545BE0", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public DNVIJFVKZJC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class TKDNZFOUICQ : AAZMAJKQBQQ<BitArray>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly AAZMAJKQBQQ<BitArray> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA555810", Offset = "0xA554810", VA = "0x18A555810", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA5556F0", Offset = "0xA5546F0", VA = "0x18A5556F0", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public TKDNZFOUICQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class CZIGMSCKFCQ : AAZMAJKQBQQ<Type>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly CZIGMSCKFCQ HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex IJKMRLEFZPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool KJEHTOHQBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool NMPSKEEKCIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool MLCYLJYDEWD;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA5457B0", Offset = "0xA5447B0", VA = "0x18A5457B0")]
		public CZIGMSCKFCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x98638C0", Offset = "0x98628C0", VA = "0x1898638C0")]
		public CZIGMSCKFCQ(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5455D0", Offset = "0xA5445D0", VA = "0x18A5455D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5454C0", Offset = "0xA5444C0", VA = "0x18A5454C0", Slot = "5")]
		public Type Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class TSEFPENIHZG : AAZMAJKQBQQ<BigInteger>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly AAZMAJKQBQQ<BigInteger> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA557500", Offset = "0xA556500", VA = "0x18A557500", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA557450", Offset = "0xA556450", VA = "0x18A557450", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public TSEFPENIHZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class GXHICHAYUAI : AAZMAJKQBQQ<Complex>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly AAZMAJKQBQQ<Complex> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA54A800", Offset = "0xA549800", VA = "0x18A54A800", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA54A770", Offset = "0xA549770", VA = "0x18A54A770", Slot = "5")]
		public Complex Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public GXHICHAYUAI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class MHLAYZZGYJQ : AAZMAJKQBQQ<ExpandoObject>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly AAZMAJKQBQQ<ExpandoObject> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA54E930", Offset = "0xA54D930", VA = "0x18A54E930", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA54E700", Offset = "0xA54D700", VA = "0x18A54E700", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public MHLAYZZGYJQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class DSCXDOZFLFH<a> : AAZMAJKQBQQ<Lazy<a>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x53BE490", Offset = "0x53BD490", VA = "0x1853BE490", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x53BE280", Offset = "0x53BD280", VA = "0x1853BE280", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class MNCJHCDTWJX : AAZMAJKQBQQ<Task>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly AAZMAJKQBQQ<Task> HPUTZVWRNHB;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task HPSAJQRIIRY;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA550630", Offset = "0xA54F630", VA = "0x18A550630", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA550580", Offset = "0xA54F580", VA = "0x18A550580", Slot = "5")]
		public Task Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public MNCJHCDTWJX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class WTIVWHYABLH<a> : AAZMAJKQBQQ<Task<a>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x87312A0", Offset = "0x87302A0", VA = "0x1887312A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x87310A0", Offset = "0x87300A0", VA = "0x1887310A0", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class FZLOVSZTRWL<a> : AAZMAJKQBQQ<ValueTask<a>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x62ED670", Offset = "0x62EC670", VA = "0x1862ED670", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x62ED4C0", Offset = "0x62EC4C0", VA = "0x1862ED4C0", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class PBWQSYWKVKJ<a> : AAZMAJKQBQQ<Tuple<a>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x752E4A0", Offset = "0x752D4A0", VA = "0x18752E4A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x752E1B0", Offset = "0x752D1B0", VA = "0x18752E1B0", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class PBGWBEOSTCI<a, b> : AAZMAJKQBQQ<Tuple<a, b>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x752B5C0", Offset = "0x752A5C0", VA = "0x18752B5C0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x752B170", Offset = "0x752A170", VA = "0x18752B170", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class PBMCYLIQCNR<a, b, c> : AAZMAJKQBQQ<Tuple<a, b, c>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x752C0B0", Offset = "0x752B0B0", VA = "0x18752C0B0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x752BB20", Offset = "0x752AB20", VA = "0x18752BB20", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class PCMLKTECXSK<a, b, c, d> : AAZMAJKQBQQ<Tuple<a, b, c, d>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7531D10", Offset = "0x7530D10", VA = "0x187531D10", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7531620", Offset = "0x7530620", VA = "0x187531620", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class PCRSHZYAHDT<a, b, c, d, e> : AAZMAJKQBQQ<Tuple<a, b, c, d, e>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7532DC0", Offset = "0x7531DC0", VA = "0x187532DC0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7532560", Offset = "0x7531560", VA = "0x187532560", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class PCBXQFQIEVS<a, b, c, d, e, f> : AAZMAJKQBQQ<Tuple<a, b, c, d, e, f>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x752F280", Offset = "0x752E280", VA = "0x18752F280", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x752E890", Offset = "0x752D890", VA = "0x18752E890", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class PCHENMKFOHB<a, b, c, d, e, f, g> : AAZMAJKQBQQ<Tuple<a, b, c, d, e, f, g>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7530950", Offset = "0x752F950", VA = "0x187530950", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x752FDD0", Offset = "0x752EDD0", VA = "0x18752FDD0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class PABGRPZIOMG<a, b, c, d, e, f, g, h> : AAZMAJKQBQQ<Tuple<a, b, c, d, e, f, g, h>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x75293E0", Offset = "0x75283E0", VA = "0x1875293E0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x75286F0", Offset = "0x75276F0", VA = "0x1875286F0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class QAUFABABSAA<a> : AAZMAJKQBQQ<ValueTuple<a>>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7734000", Offset = "0x7733000", VA = "0x187734000", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x7733BD0", Offset = "0x7732BD0", VA = "0x187733BD0", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class QBJZRVHTUIB<a, b> : AAZMAJKQBQQ<(a, b)>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x7735740", Offset = "0x7734740", VA = "0x187735740", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x7735230", Offset = "0x7734230", VA = "0x187735230", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class QBESUONWKWS<a, b, c> : AAZMAJKQBQQ<(a, b, c)>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x7734AC0", Offset = "0x7733AC0", VA = "0x187734AC0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x7734420", Offset = "0x7733420", VA = "0x187734420", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class QBUNMIVONET<a, b, c, d> : AAZMAJKQBQQ<(a, b, c, d)>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7737A60", Offset = "0x7736A60", VA = "0x187737A60", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x77371F0", Offset = "0x77361F0", VA = "0x1877371F0", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class QBPGPCBRDTK<a, b, c, d, e> : AAZMAJKQBQQ<(a, b, c, d, e)>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x77366F0", Offset = "0x77356F0", VA = "0x1877366F0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x7735CF0", Offset = "0x7734CF0", VA = "0x187735CF0", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class QCFBGWJJGBL<a, b, c, d, e, f> : AAZMAJKQBQQ<(a, b, c, d, e, f)>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x777A050", Offset = "0x7779050", VA = "0x18777A050", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7779430", Offset = "0x7778430", VA = "0x187779430", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class QBZUJPPLWQC<a, b, c, d, e, f, g> : AAZMAJKQBQQ<(a, b, c, d, e, f, g)>, OUOPVATJLZR
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x77785E0", Offset = "0x77775E0", VA = "0x1877785E0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x7777800", Offset = "0x7776800", VA = "0x187777800", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class QCPPBJXDYYD<a, b, c, d, e, f, g, h> : AAZMAJKQBQQ<ValueTuple<a, b, c, d, e, f, g, h>>, OUOPVATJLZR where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] NAVPJWUEZNW;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly EKGFJVGXTUY QPBZDHSGXFU;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x777BC70", Offset = "0x777AC70", VA = "0x18777BC70", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, BYGWYMIDFLH formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x777ACE0", Offset = "0x7779CE0", VA = "0x18777ACE0", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, BYGWYMIDFLH formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class LGBHORGFQEQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] CJTHPHTRYHO;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly EKGFJVGXTUY LPZTDMTVOCB;

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xA54E1B0", Offset = "0xA54D1B0", VA = "0x18A54E1B0")]
		static LGBHORGFQEQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class RHKTDWWXMJM
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] GAINCSAGJOB;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly EKGFJVGXTUY WXFKVFLIRKM;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xA553290", Offset = "0xA552290", VA = "0x18A553290")]
		static RHKTDWWXMJM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class FNZAXLFRGBQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] NGALVBIHQHG;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly EKGFJVGXTUY LEUMSPMXNPX;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] NGQGMVPZSPH;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly EKGFJVGXTUY LEESAVFFLHW;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] NGKZPOWCJDY;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly EKGFJVGXTUY LEJYYBZCUTF;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] NFKRDHAPNZF;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly EKGFJVGXTUY LFKHKJUPPXY;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] NFFKGAGSENW;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly EKGFJVGXTUY LFPOHQOMZJH;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] NFVEXUOKGVX;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly EKGFJVGXTUY LEZTPWGUXBG;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] NFPYANUMXKO;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly EKGFJVGXTUY LFFANDASGMP;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] NEPPOFZACFV;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly EKGFJVGXTUY LGFIZKWFBRI;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xA548AF0", Offset = "0xA547AF0", VA = "0x18A548AF0")]
		static FNZAXLFRGBQ()
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
