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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18210", VA = "0x180D19810")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, DAMCVOXAVIT resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, DAMCVOXAVIT resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface FTQIUPACWHD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface SIWYLIGCSZE<a> : FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, DAMCVOXAVIT formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface BJQAYWLOALJ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MZTTPORNZCZ(JsonWriter a, a b, DAMCVOXAVIT c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b);
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
	public static class PDOHFCIOYAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3D8EE30", Offset = "0x3D8D830", VA = "0x183D8EE30")]
		public static string ToJsonString<T>(this SIWYLIGCSZE<T> formatter, T value, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		SIWYLIGCSZE<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class GDDEYYNPELO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3AD4970", Offset = "0x3AD3370", VA = "0x183AD4970")]
		public static SIWYLIGCSZE<a> EVFDGDBKNGX<a>(this DAMCVOXAVIT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3500", Offset = "0xA3D1F00", VA = "0x18A3D3500")]
		public static object DLEXLAFLEKL(this DAMCVOXAVIT a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA3D34A0", Offset = "0xA3D1EA0", VA = "0x18A3D34A0")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class TXIROMOTBVH
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] CYLOQNCUWNW;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] KYJQYHFHOSN;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] TXNHUYDMLYK;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] DPOEIDNNOCN;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] SSNZREONXLK;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] TJRENHWDXOT;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] IVXYBROCGPB;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] TTPCFIXMRSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class BRDCAVKNDPU : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0xA3D29F0", Offset = "0xA3D13F0", VA = "0x18A3D29F0")]
				public BRDCAVKNDPU(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xA3D28D0", Offset = "0xA3D12D0", VA = "0x18A3D28D0")]
				public BRDCAVKNDPU FLYXUGEVGZO(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class UXDWZYNLITT
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] XBUPHSRNKOO;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] KUHHKPSURPL;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private BRDCAVKNDPU start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private BRDCAVKNDPU end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA3DD280", Offset = "0xA3DBC80", VA = "0x18A3DD280")]
			public void FLYXUGEVGZO([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA3DD140", Offset = "0xA3DBB40", VA = "0x18A3DD140")]
			public void FLYXUGEVGZO(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA3DD730", Offset = "0xA3DC130", VA = "0x18A3DD730")]
			public ReadOnlySequence<byte> YZISAFOAUMH()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA3DD580", Offset = "0xA3DBF80", VA = "0x18A3DD580")]
			private void RXEQWLLIJTR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA3DD390", Offset = "0xA3DBD90", VA = "0x18A3DD390")]
			private void OHPJAPKTQYR([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA7A0", Offset = "0xA3D91A0", VA = "0x18A3DA7A0")]
		public JsonReader([In] ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA630", Offset = "0xA3D9030", VA = "0x18A3DA630")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8EC0", Offset = "0xA3D78C0", VA = "0x18A3D8EC0")]
		private JsonParsingException OPKLQCUPKHP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9990", Offset = "0xA3D8390", VA = "0x18A3D9990")]
		private JsonParsingException QMOEWITGZAA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7B60", Offset = "0xA3D6560", VA = "0x18A3D7B60")]
		public JsonToken CSNLQLJSGGI()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9AA0", Offset = "0xA3D84A0", VA = "0x18A3D9AA0")]
		public void QNQPGLWUZNQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8600", Offset = "0xA3D7000", VA = "0x18A3D8600")]
		private bool KBZSGVXGJFW(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8660", Offset = "0xA3D7060", VA = "0x18A3D8660")]
		private bool KBZSGVXGJFW(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA160", Offset = "0xA3D8B60", VA = "0x18A3DA160")]
		private void VNMGZQHFIRX(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8160", Offset = "0xA3D6B60", VA = "0x18A3D8160")]
		public bool FNTSIVZMTSJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA620", Offset = "0xA3D9020", VA = "0x18A3DA620")]
		public void ZWUBWBKLEVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7FA0", Offset = "0xA3D69A0", VA = "0x18A3D7FA0")]
		public bool EAIEFSTWDEG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA2C0", Offset = "0xA3D8CC0", VA = "0x18A3DA2C0")]
		public void WWBEGQUCYUP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA610", Offset = "0xA3D9010", VA = "0x18A3DA610")]
		public void ZQAAKZLPFHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9770", Offset = "0xA3D8170", VA = "0x18A3D9770")]
		public bool PMXOTEGVQVE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9760", Offset = "0xA3D8160", VA = "0x18A3D9760")]
		public void PMUJMJSQICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9D40", Offset = "0xA3D8740", VA = "0x18A3D9D40")]
		public void RWYKTWKRXNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA4D0", Offset = "0xA3D8ED0", VA = "0x18A3DA4D0")]
		public bool XZSEAACUZEZ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA3D87A0", Offset = "0xA3D71A0", VA = "0x18A3D87A0")]
		public bool KZFDBXNXHBK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7890", Offset = "0xA3D6290", VA = "0x18A3D7890")]
		public bool CBJTASTWZYN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA3D77B0", Offset = "0xA3D61B0", VA = "0x18A3D77B0")]
		public bool BZYSGTOCXIM(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9280", Offset = "0xA3D7C80", VA = "0x18A3D9280")]
		private ReadOnlySequence<byte> PKTUJKMPITD()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7540", Offset = "0xA3D5F40", VA = "0x18A3D7540")]
		private ReadOnlySequence<byte> ABPPPBKKZRG()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9D50", Offset = "0xA3D8750", VA = "0x18A3D9D50")]
		private void SSDGNPKZNXW(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA2D0", Offset = "0xA3D8CD0", VA = "0x18A3DA2D0")]
		private void XBGZLMVVDRR(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8BD0", Offset = "0xA3D75D0", VA = "0x18A3D8BD0")]
		private void OMFGSUQEZPQ(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D82C0", Offset = "0xA3D6CC0", VA = "0x18A3D82C0")]
		private void ILLSEQHTFWN(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF540", Offset = "0xA3CDF40", VA = "0x18A3CF540")]
		private static int VPTVHUSHHSM(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8530", Offset = "0xA3D6F30", VA = "0x18A3D8530")]
		public ReadOnlySequence<byte> KAYTKWXNXAU()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D97C0", Offset = "0xA3D81C0", VA = "0x18A3D97C0")]
		public string QFVYWTTUAVD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7D80", Offset = "0xA3D6780", VA = "0x18A3D7D80")]
		public string DKNZYERCFAS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9FE0", Offset = "0xA3D89E0", VA = "0x18A3D9FE0")]
		public ReadOnlySequence<byte> TCHGRTDGGWM()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA3D86C0", Offset = "0xA3D70C0", VA = "0x18A3D86C0")]
		public ReadOnlySequence<byte> KSTVKDEVSUX()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9840", Offset = "0xA3D8240", VA = "0x18A3D9840")]
		public bool QMNAEQAXVXO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7FF0", Offset = "0xA3D69F0", VA = "0x18A3D7FF0")]
		private void FJGQFMYCKNM(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7D70", Offset = "0xA3D6770", VA = "0x18A3D7D70")]
		public void DCFGWKCJYXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7920", Offset = "0xA3D6320", VA = "0x18A3D7920")]
		private void CKEDLYMMREB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8480", Offset = "0xA3D6E80", VA = "0x18A3D8480")]
		public sbyte JLPJIIAADLV()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA210", Offset = "0xA3D8C10", VA = "0x18A3DA210")]
		public short VXOTNNBTSKS()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA3D83D0", Offset = "0xA3D6DD0", VA = "0x18A3D83D0")]
		public int IYZEXPSYLZC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9210", Offset = "0xA3D7C10", VA = "0x18A3D9210")]
		public long OYDDYJJBHIL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA0B0", Offset = "0xA3D8AB0", VA = "0x18A3DA0B0")]
		public byte TSTMKJJZOGS()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8B20", Offset = "0xA3D7520", VA = "0x18A3D8B20")]
		public ushort MEXSHCNGMSP()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA560", Offset = "0xA3D8F60", VA = "0x18A3DA560")]
		public uint ZHYGVHHQDTT()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9CD0", Offset = "0xA3D86D0", VA = "0x18A3D9CD0")]
		public ulong RJVDVVPNALI()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9F40", Offset = "0xA3D8940", VA = "0x18A3D9F40")]
		public float SWKJZCTJFKA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8220", Offset = "0xA3D6C20", VA = "0x18A3D8220")]
		public double IGVWFQGZTKR()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7DC0", Offset = "0xA3D67C0", VA = "0x18A3D7DC0")]
		public ReadOnlySequence<byte> DPZQMKWOFJY()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8880", Offset = "0xA3D7280", VA = "0x18A3D8880")]
		private void LSUJTJSGCMA()
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
			[Cpp2IlInjected.Address(RVA = "0xF94180", Offset = "0xF92B80", VA = "0x180F94180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D74E0", Offset = "0xA3D5EE0", VA = "0x18A3D74E0")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7460", Offset = "0xA3D5E60", VA = "0x18A3D7460")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class ZUNPSXZSIFU
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class GPAFVCBDCLD
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] XBUPHSRNKOO;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA3D3650", Offset = "0xA3D2050", VA = "0x18A3D3650")]
			public static byte[] RFEOBKQVUCK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static DAMCVOXAVIT GWJVPGSRJHZ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] WJGGGZQOUOK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] LPKKKNHASHG;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static DAMCVOXAVIT OCMGGHPHJWT
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA3E3D80", Offset = "0xA3E2780", VA = "0x18A3E3D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E39E0", Offset = "0xA3E23E0", VA = "0x18A3E39E0")]
		public static void AVULLZQETHJ(DAMCVOXAVIT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4139010", Offset = "0x4137A10", VA = "0x184139010")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4138EA0", Offset = "0x41378A0", VA = "0x184138EA0")]
		public static byte[] Serialize<T>(T value, DAMCVOXAVIT resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4139480", Offset = "0x4137E80", VA = "0x184139480")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4139500", Offset = "0x4137F00", VA = "0x184139500")]
		public static string ToJsonString<T>(T value, DAMCVOXAVIT resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x41389B0", Offset = "0x41373B0", VA = "0x1841389B0")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4138610", Offset = "0x4137010", VA = "0x184138610")]
		public static T Deserialize<T>(string json, DAMCVOXAVIT resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4138860", Offset = "0x4137260", VA = "0x184138860")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4138790", Offset = "0x4137190", VA = "0x184138790")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, DAMCVOXAVIT resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4137E40", Offset = "0x4136840", VA = "0x184137E40")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4138060", Offset = "0x4136A60", VA = "0x184138060")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, DAMCVOXAVIT resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E3A50", Offset = "0xA3E2450", VA = "0x18A3E3A50")]
		public static byte[] GZCWOYIYPXG(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E3E80", Offset = "0xA3E2880", VA = "0x18A3E3E80")]
		private static void ZBTONCWQIDG(JsonReader a, JsonWriter b, int c)
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
		public int QODYXWZZBDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xF519C0", Offset = "0xF503C0", VA = "0x180F519C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBC40", Offset = "0xA3DA640", VA = "0x18A3DBC40")]
		public void ZPRGVMWZVON(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB490", Offset = "0xA3D9E90", VA = "0x18A3DB490")]
		public static byte[] PALYWSCLOYA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAC60", Offset = "0xA3D9660", VA = "0x18A3DAC60")]
		public static byte[] IWDWOCDYQTG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAD80", Offset = "0xA3D9780", VA = "0x18A3DAD80")]
		public static byte[] MZONKNCPPLQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB970", Offset = "0xA3DA370", VA = "0x18A3DB970")]
		public static byte[] UXBTEUKJUZU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2ABF090", Offset = "0x2ABDA90", VA = "0x182ABF090")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB5C0", Offset = "0xA3D9FC0", VA = "0x18A3DB5C0")]
		public ArraySegment<byte> RFEOBKQVUCK()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB780", Offset = "0xA3DA180", VA = "0x18A3DB780")]
		public byte[] TQDVZYWKNBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB910", Offset = "0xA3DA310", VA = "0x18A3DB910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA9C0", Offset = "0xA3D93C0", VA = "0x18A3DA9C0")]
		public void BOYVYBEOXUG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF6A0", Offset = "0xA3CE0A0", VA = "0x18A3CF6A0")]
		public void YATYGCKFXDN(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBBE0", Offset = "0xA3DA5E0", VA = "0x18A3DBBE0")]
		public void YATYGCKFXDN(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAA40", Offset = "0xA3D9440", VA = "0x18A3DAA40")]
		public void COSLPYNLOTP(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x50F1CA0", Offset = "0x50F06A0", VA = "0x1850F1CA0")]
		public void EWGJYZORQFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x50F1DE0", Offset = "0x50F07E0", VA = "0x1850F1DE0")]
		public void ZDVSVIROIDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x50F1D90", Offset = "0x50F0790", VA = "0x1850F1D90")]
		public void WYDISBLMBVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x50B8350", Offset = "0x50B6D50", VA = "0x1850B8350")]
		public void JFEVLLQCQPV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x50F1D40", Offset = "0x50F0740", VA = "0x1850F1D40")]
		public void WVNPDKTPZFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x50F1CF0", Offset = "0x50F06F0", VA = "0x1850F1CF0")]
		public void USIKBLHLQRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB660", Offset = "0xA3DA060", VA = "0x18A3DB660")]
		public void RHEIQXUDGZD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA3DABA0", Offset = "0xA3D95A0", VA = "0x18A3DABA0")]
		public void GLLOYVLGAFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x50B83A0", Offset = "0x50B6DA0", VA = "0x1850B83A0")]
		public void UQGTNQKXKVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8CA0810", Offset = "0x8C9F210", VA = "0x188CA0810")]
		public void VSYNUZKVTPT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBAF0", Offset = "0xA3DA4F0", VA = "0x18A3DBAF0")]
		public void VECXDAXSHSX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB700", Offset = "0xA3DA100", VA = "0x18A3DB700")]
		public void SNKEXRHLSLU(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA9D0", Offset = "0xA3D93D0", VA = "0x18A3DA9D0")]
		public void CFHFTKPLEPP(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAEA0", Offset = "0xA3D98A0", VA = "0x18A3DAEA0")]
		public void OCQFJZTXFII(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA950", Offset = "0xA3D9350", VA = "0x18A3DA950")]
		public void ABHVMPDRZXQ(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAAF0", Offset = "0xA3D94F0", VA = "0x18A3DAAF0")]
		public void GGDFOQEYZMR(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAA80", Offset = "0xA3D9480", VA = "0x18A3DAA80")]
		public void DWHRYDZTFHM(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA3DABF0", Offset = "0xA3D95F0", VA = "0x18A3DABF0")]
		public void IDPTWURPAXR(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBB70", Offset = "0xA3DA570", VA = "0x18A3DBB70")]
		public void VFAFGXITUMB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB590", Offset = "0xA3D9F90", VA = "0x18A3DB590")]
		public void QAXVHFICSMS(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAF10", Offset = "0xA3D9910", VA = "0x18A3DAF10")]
		public void OYTEHOFQISW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAB20", Offset = "0xA3D9520", VA = "0x18A3DAB20")]
		private static bool GGWQMLFQQNG(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB570", Offset = "0xA3D9F70", VA = "0x18A3DB570")]
		private static byte PISLHJJNXJQ(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF600", Offset = "0xA3CE000", VA = "0x18A3CF600")]
		private static void LMLRJCYVNVF(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class BOSJKBCESTW : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7E65CE0", Offset = "0x7E646E0", VA = "0x187E65CE0")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private BOSJKBCESTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class YFCWTPBHYQZ : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7E66500", Offset = "0x7E64F00", VA = "0x187E66500")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class TIFCNYYLBXZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> AIWOTTNUMZW;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA3DD860", Offset = "0xA3DC260", VA = "0x18A3DD860")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private YFCWTPBHYQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class JTAXZIGBSBT : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7E72B50", Offset = "0x7E71550", VA = "0x187E72B50")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly JTAXZIGBSBT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool OLSBIOWBGFT;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static FTQIUPACWHD[] MVMMTPRYOCT;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static DAMCVOXAVIT[] OJMVGDMTQRZ;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private JTAXZIGBSBT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7270", Offset = "0xA3D5C70", VA = "0x18A3D7270")]
		public static void SIFQFAPRLAF(params DAMCVOXAVIT[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7190", Offset = "0xA3D5B90", VA = "0x18A3D7190")]
		public static void SIFQFAPRLAF(params FTQIUPACWHD[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6F10", Offset = "0xA3D5910", VA = "0x18A3D6F10")]
		public static void QZQMCVKKUYT(FTQIUPACWHD[] a, DAMCVOXAVIT[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class TZJEGYDIGNK : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7E64890", Offset = "0x7E63290", VA = "0x187E64890")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private TZJEGYDIGNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class MDNUQHCXQQD
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly DAMCVOXAVIT FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly DAMCVOXAVIT UJWJDWWUSGU;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class GXMDKXOGJDB
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly DAMCVOXAVIT FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly DAMCVOXAVIT QIGUXQVJMYS;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly DAMCVOXAVIT RUGPMOYRMKQ;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly DAMCVOXAVIT RQBMJOLEYTN;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly DAMCVOXAVIT ZNDFEKXZHQT;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly DAMCVOXAVIT HKKYJFXZCHH;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly DAMCVOXAVIT BYNDGMTAMHK;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly DAMCVOXAVIT DXQQRIWSJTI;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly DAMCVOXAVIT CMPYDZYUVVW;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly DAMCVOXAVIT SVVYIBCSPOT;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly DAMCVOXAVIT ZYUNTZRKCTR;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly DAMCVOXAVIT HWCGYURJXKF;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class YLNFWXDBQEC
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> AIWOTTNUMZW;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0F60", Offset = "0xA3DF960", VA = "0x18A3E0F60")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0F20", Offset = "0xA3DF920", VA = "0x18A3E0F20")]
		private static object BZSLSCFANPV(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class RSTPNRZRMEM : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7E72420", Offset = "0x7E70E20", VA = "0x187E72420")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private RSTPNRZRMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class NIKLXSRRLMR : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7E7DB90", Offset = "0x7E7C590", VA = "0x187E7DB90")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private NIKLXSRRLMR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class ALESYVVFHJZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly DAMCVOXAVIT[] GSVAGTKSYCM;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class ZFIKTGSCFLI : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7E62690", Offset = "0x7E61090", VA = "0x187E62690")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class DQSIZCTSEUC : DAMCVOXAVIT
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class VYHUHSXXKDJ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x7E7CF20", Offset = "0x7E7B920", VA = "0x187E7CF20")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
			public SIWYLIGCSZE<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly SIWYLIGCSZE<object> FLBDJTWPUFG;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private ZFIKTGSCFLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class RDLBUKLIQAF : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7E6D660", Offset = "0x7E6C060", VA = "0x187E6D660")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class DQSIZCTSEUC : DAMCVOXAVIT
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class VYHUHSXXKDJ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x7E68170", Offset = "0x7E66B70", VA = "0x187E68170")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
			public SIWYLIGCSZE<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly SIWYLIGCSZE<object> FLBDJTWPUFG;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private RDLBUKLIQAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class IVRFGESEPWP : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7E650B0", Offset = "0x7E63AB0", VA = "0x187E650B0")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class DQSIZCTSEUC : DAMCVOXAVIT
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class VYHUHSXXKDJ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x7E67450", Offset = "0x7E65E50", VA = "0x187E67450")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
			public SIWYLIGCSZE<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly SIWYLIGCSZE<object> FLBDJTWPUFG;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private IVRFGESEPWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class SMXEEBKVYDC : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7E6B290", Offset = "0x7E69C90", VA = "0x187E6B290")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class DQSIZCTSEUC : DAMCVOXAVIT
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class VYHUHSXXKDJ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x7E7EA50", Offset = "0x7E7D450", VA = "0x187E7EA50")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
			public SIWYLIGCSZE<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly SIWYLIGCSZE<object> FLBDJTWPUFG;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private SMXEEBKVYDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class WRKOFHXVRPK : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7E5E950", Offset = "0x7E5D350", VA = "0x187E5E950")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class DQSIZCTSEUC : DAMCVOXAVIT
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class VYHUHSXXKDJ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x7E776E0", Offset = "0x7E760E0", VA = "0x187E776E0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
			public SIWYLIGCSZE<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly SIWYLIGCSZE<object> FLBDJTWPUFG;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private WRKOFHXVRPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class YUERIHRJQIC : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7E6C900", Offset = "0x7E6B300", VA = "0x187E6C900")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class DQSIZCTSEUC : DAMCVOXAVIT
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class VYHUHSXXKDJ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x7E719F0", Offset = "0x7E703F0", VA = "0x187E719F0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
			public SIWYLIGCSZE<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly SIWYLIGCSZE<object> FLBDJTWPUFG;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private YUERIHRJQIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class JEQTSYEHESH : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7E7AAB0", Offset = "0x7E794B0", VA = "0x187E7AAB0")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class DQSIZCTSEUC : DAMCVOXAVIT
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class VYHUHSXXKDJ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x7E75890", Offset = "0x7E74290", VA = "0x187E75890")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
			public SIWYLIGCSZE<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly SIWYLIGCSZE<object> FLBDJTWPUFG;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private JEQTSYEHESH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class AWDASIWFECJ : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7E67D10", Offset = "0x7E66710", VA = "0x187E67D10")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class DQSIZCTSEUC : DAMCVOXAVIT
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class VYHUHSXXKDJ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x7E64430", Offset = "0x7E62E30", VA = "0x187E64430")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
			public SIWYLIGCSZE<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly SIWYLIGCSZE<object> FLBDJTWPUFG;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private AWDASIWFECJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class SOJEEDDBDYT : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7E6C300", Offset = "0x7E6AD00", VA = "0x187E6C300")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class DQSIZCTSEUC : DAMCVOXAVIT
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class VYHUHSXXKDJ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x7E6AE30", Offset = "0x7E69830", VA = "0x187E6AE30")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
			public SIWYLIGCSZE<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly SIWYLIGCSZE<object> FLBDJTWPUFG;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private SOJEEDDBDYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class JHLIFCYVJLO : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7E7C360", Offset = "0x7E7AD60", VA = "0x187E7C360")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class DQSIZCTSEUC : DAMCVOXAVIT
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class VYHUHSXXKDJ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x7E71890", Offset = "0x7E70290", VA = "0x187E71890")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
			public SIWYLIGCSZE<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly SIWYLIGCSZE<object> FLBDJTWPUFG;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private JHLIFCYVJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class QGJXXJIVLAY : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7E7CC20", Offset = "0x7E7B620", VA = "0x187E7CC20")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class DQSIZCTSEUC : DAMCVOXAVIT
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class VYHUHSXXKDJ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x7E68BC0", Offset = "0x7E675C0", VA = "0x187E68BC0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
			public SIWYLIGCSZE<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly SIWYLIGCSZE<object> FLBDJTWPUFG;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private QGJXXJIVLAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class VGEOCQDOXDA : DAMCVOXAVIT
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class VYHUHSXXKDJ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7E6B8D0", Offset = "0x7E6A2D0", VA = "0x187E6B8D0")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class DQSIZCTSEUC : DAMCVOXAVIT
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class VYHUHSXXKDJ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly SIWYLIGCSZE<a> COOLNYPHBJQ;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x7E7B630", Offset = "0x7E7A030", VA = "0x187E7B630")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
			public SIWYLIGCSZE<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly SIWYLIGCSZE<object> FLBDJTWPUFG;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		private VGEOCQDOXDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3369450", Offset = "0x3367E50", VA = "0x183369450", Slot = "4")]
		public SIWYLIGCSZE<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x73AB120", Offset = "0x73A9B20", VA = "0x1873AB120")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x73AAE30", Offset = "0x73A9830", VA = "0x1873AAE30")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x73AB090", Offset = "0x73A9A90", VA = "0x1873AB090")]
		public T[] PEQGZCFKKEC()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class JNDZRHAEOYY<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int SNMXYHXWUPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object SXZDPRKMSQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int PMHRBJOKSGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] LVKXEIMTUML;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x668C700", Offset = "0x668B100", VA = "0x18668C700")]
		public JNDZRHAEOYY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x668C350", Offset = "0x668AD50", VA = "0x18668C350")]
		public a[] FSVKAQWAHGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x668C580", Offset = "0x668AF80", VA = "0x18668C580")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class IWXXPKAIOHU : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class QCUOBCAAXYO : IComparable<QCUOBCAAXYO>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class QTDPWIJFRFI : IEnumerable<QCUOBCAAXYO>, IEnumerable, IEnumerator<QCUOBCAAXYO>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int NSYFVIOVDQI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private QCUOBCAAXYO PGYMGSMZHLZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int DQGTEBFWJSV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public QCUOBCAAXYO DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int LPBUJELINTU;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private QCUOBCAAXYO RNHJNLYLNKD
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object RTHQPUQEOJM
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
				[DebuggerHidden]
				public QTDPWIJFRFI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "7")]
				[DebuggerHidden]
				private void PEABEYBFILL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xA3DCE70", Offset = "0xA3DB870", VA = "0x18A3DCE70", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xA3DCE30", Offset = "0xA3DB830", VA = "0x18A3DCE30", Slot = "10")]
				[DebuggerHidden]
				private void KTHCATTUQZC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xA3DCD90", Offset = "0xA3DB790", VA = "0x18A3DCD90", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<QCUOBCAAXYO> ZYCODUSOIBG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0xA3DCD90", Offset = "0xA3DB790", VA = "0x18A3DCD90", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator IEVKUCCAWWZ()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly QCUOBCAAXYO[] TPTGCQBKXHM;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] IOYZJPLNQTL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong OTIUDMTTUGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int YMGSSSXYISN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string QHVHPGACLKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private QCUOBCAAXYO[] QVRUSNSYPGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] NAOITRPTPJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int YGGWGOVCADB;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA3DCC30", Offset = "0xA3DB630", VA = "0x18A3DCC30")]
			public QCUOBCAAXYO(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA3DC670", Offset = "0xA3DB070", VA = "0x18A3DC670")]
			public QCUOBCAAXYO Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA3DC870", Offset = "0xA3DB270", VA = "0x18A3DC870")]
			public QCUOBCAAXYO Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA3DC900", Offset = "0xA3DB300", VA = "0x18A3DC900")]
			public QCUOBCAAXYO WSOVNWLHWKE(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA3DCA70", Offset = "0xA3DB470", VA = "0x18A3DCA70")]
			internal static int ZEWQILPOBHP(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA3DC8D0", Offset = "0xA3DB2D0", VA = "0x18A3DC8D0", Slot = "4")]
			public int CompareTo(QCUOBCAAXYO other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xA3DCB00", Offset = "0xA3DB500", VA = "0x18A3DCB00")]
			[IteratorStateMachine(typeof(QTDPWIJFRFI))]
			public IEnumerable<QCUOBCAAXYO> ZXFAPFPWIWS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class BHNCOYLJVZC : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int DQGTEBFWJSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<QCUOBCAAXYO> QVRUSNSYPGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<QCUOBCAAXYO> USXRZZVHNDX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<QCUOBCAAXYO> MOIGOWZIHVC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private QCUOBCAAXYO JCZKPCEMAIV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> MOSUJKNDARU;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> CACGZXJPXQV
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87230", VA = "0x180D88830", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000139")]
				[Cpp2IlInjected.Address(RVA = "0xA3D20E0", Offset = "0xA3D0AE0", VA = "0x18A3D20E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1D01620", Offset = "0x1D00020", VA = "0x181D01620")]
			[DebuggerHidden]
			public BHNCOYLJVZC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xA3D2670", Offset = "0xA3D1070", VA = "0x18A3D2670", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xA3D2210", Offset = "0xA3D0C10", VA = "0x18A3D2210", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xA3D2810", Offset = "0xA3D1210", VA = "0x18A3D2810")]
			private void SYBUDUAVPHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA3D27C0", Offset = "0xA3D11C0", VA = "0x18A3D27C0")]
			private void SXLZLZTDMZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA3D21D0", Offset = "0xA3D0BD0", VA = "0x18A3D21D0", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xA3D2130", Offset = "0xA3D0B30", VA = "0x18A3D2130", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> LIWFJBPWEJQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xA3D2130", Offset = "0xA3D0B30", VA = "0x18A3D2130", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly QCUOBCAAXYO CNBVPAWZDFC;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6D60", Offset = "0xA3D5760", VA = "0x18A3D6D60")]
		public IWXXPKAIOHU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6510", Offset = "0xA3D4F10", VA = "0x18A3D6510")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6C50", Offset = "0xA3D5650", VA = "0x18A3D6C50")]
		public bool XXTFUCBFMWE(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6A30", Offset = "0xA3D5430", VA = "0x18A3D6A30")]
		public bool KAPYJGGLHZX([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6BC0", Offset = "0xA3D55C0", VA = "0x18A3D6BC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D66F0", Offset = "0xA3D50F0", VA = "0x18A3D66F0")]
		private static void BNKMEFXPNUP(IEnumerable<QCUOBCAAXYO> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D69D0", Offset = "0xA3D53D0", VA = "0x18A3D69D0", Slot = "5")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA3D69D0", Offset = "0xA3D53D0", VA = "0x18A3D69D0", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6B40", Offset = "0xA3D5540", VA = "0x18A3D6B40")]
		[IteratorStateMachine(typeof(BHNCOYLJVZC))]
		private static IEnumerable<KeyValuePair<string, int>> LKIDDAYYLFM(IEnumerable<QCUOBCAAXYO> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class NZVEQQQJGOZ
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo VNIYLDZSYNY;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBE70", Offset = "0xA3DA870", VA = "0x18A3DBE70")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC020", Offset = "0xA3DAA20", VA = "0x18A3DC020")]
		public static ulong YNJQWKSFLWG(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class ZOBCOVTPSON
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E3640", Offset = "0xA3E2040", VA = "0x18A3E3640")]
		public static void BOYVYBEOXUG(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA3E3780", Offset = "0xA3E2180", VA = "0x18A3E3780")]
		public static void DTCLZVHUUSO(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA3E38A0", Offset = "0xA3E22A0", VA = "0x18A3E38A0")]
		public static byte[] MLJRRCAVREX(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class GJAZTNDCOEJ<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x5B64A50", Offset = "0x5B63450", VA = "0x185B64A50", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class TOKOGRCFVHL : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public GJAZTNDCOEJ<a> DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] MOIGOWZIHVC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int MOYBGRHAKDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] MOSUJKNDARU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int MPIPBEUVCZV;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> NBABBBEFPYI
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87230", VA = "0x180D88830", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0x64CEA90", Offset = "0x64CD490", VA = "0x1864CEA90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8BC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public TOKOGRCFVHL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x7A91B10", Offset = "0x7A90510", VA = "0x187A91B10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC7F0", Offset = "0x4FAB1F0", VA = "0x184FAC7F0", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] BYLWCLCVNXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong GUIYXWIZWUL;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool GCMUOMPDQQM;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x63814A0", Offset = "0x637FEA0", VA = "0x1863814A0")]
		public GJAZTNDCOEJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x63813B0", Offset = "0x637FDB0", VA = "0x1863813B0")]
		public GJAZTNDCOEJ(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x636E660", Offset = "0x636D060", VA = "0x18636E660")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x637A570", Offset = "0x6378F70", VA = "0x18637A570")]
		private bool TGUQGNFSDNT(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6381180", Offset = "0x637FB80", VA = "0x186381180")]
		public bool XXTFUCBFMWE([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x63706A0", Offset = "0x636F0A0", VA = "0x1863706A0")]
		private static ulong RDQINKRNWMA([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x636FE80", Offset = "0x636E880", VA = "0x18636FE80")]
		private static ulong RDQINKRNWMA([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x636F6D0", Offset = "0x636E0D0", VA = "0x18636F6D0")]
		private static int DYHMBHBQQKM(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x636F700", Offset = "0x636E100", VA = "0x18636F700", Slot = "4")]
		[IteratorStateMachine(typeof(GJAZTNDCOEJ<>.TOKOGRCFVHL))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x636F9F0", Offset = "0x636E3F0", VA = "0x18636F9F0", Slot = "5")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class YUSZSNVMGXG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x41320C0", Offset = "0x4130AC0", VA = "0x1841320C0")]
		public static Func<a> FCDBGKKNOUO<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x41321B0", Offset = "0x4130BB0", VA = "0x1841321B0")]
		private static c TOHGUZXQKKX<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0xA3D4570", Offset = "0xA3D2F70", VA = "0x18A3D4570")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4580", Offset = "0xA3D2F80", VA = "0x18A3D4580")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3B80", Offset = "0xA3D2580", VA = "0x18A3D3B80")]
		private static byte QWUXDBCZCPZ(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF200", Offset = "0xA3CDC00", VA = "0x18A3CF200")]
		private static byte TMXDXPOKJRN(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3C20", Offset = "0xA3D2620", VA = "0x18A3D3C20")]
		public void SQIRBZBNMTZ(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class WQVHUIFMQBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0C30", Offset = "0xA3DF630", VA = "0x18A3E0C30")]
		public static bool VOJPVMUFSBP(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0CA0", Offset = "0xA3DF6A0", VA = "0x18A3E0CA0")]
		public static bool ZCKOIPCTLCM(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E02A0", Offset = "0xA3DECA0", VA = "0x18A3E02A0")]
		public static sbyte JLPJIIAADLV([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0C40", Offset = "0xA3DF640", VA = "0x18A3E0C40")]
		public static short VXOTNNBTSKS([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0070", Offset = "0xA3DEA70", VA = "0x18A3E0070")]
		public static int IYZEXPSYLZC([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0470", Offset = "0xA3DEE70", VA = "0x18A3E0470")]
		public static long OYDDYJJBHIL([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA3E08F0", Offset = "0xA3DF2F0", VA = "0x18A3E08F0")]
		public static bool RPDDHHHFIMA(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0B70", Offset = "0xA3DF570", VA = "0x18A3E0B70")]
		public static byte TSTMKJJZOGS([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0300", Offset = "0xA3DED00", VA = "0x18A3E0300")]
		public static ushort MEXSHCNGMSP([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0D10", Offset = "0xA3DF710", VA = "0x18A3E0D10")]
		public static uint ZHYGVHHQDTT([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0840", Offset = "0xA3DF240", VA = "0x18A3E0840")]
		public static ulong RJVDVVPNALI([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA3E06F0", Offset = "0xA3DF0F0", VA = "0x18A3E06F0")]
		public static bool RDBANDGTVTV(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA3E00D0", Offset = "0xA3DEAD0", VA = "0x18A3E00D0")]
		public static bool JLHEMNPLICD(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0360", Offset = "0xA3DED60", VA = "0x18A3E0360")]
		public static bool MHXNYYLSDTB(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0D70", Offset = "0xA3DF770", VA = "0x18A3E0D70")]
		public static bool ZMDHGBKTIDX(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0A80", Offset = "0xA3DF480", VA = "0x18A3E0A80")]
		public static float SWKJZCTJFKA([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFF20", Offset = "0xA3DE920", VA = "0x18A3DFF20")]
		public static bool HMQLUZJZQKB(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFF80", Offset = "0xA3DE980", VA = "0x18A3DFF80")]
		public static double IGVWFQGZTKR([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0BD0", Offset = "0xA3DF5D0", VA = "0x18A3E0BD0")]
		public static bool TWFMGDNTYUU(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFB60", Offset = "0xA3CE560", VA = "0x18A3CFB60")]
		public static int GGDFOQEYZMR(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA3D02C0", Offset = "0xA3CECC0", VA = "0x18A3D02C0")]
		public static int QAXVHFICSMS(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0520", Offset = "0xA3DEF20", VA = "0x18A3E0520")]
		public static bool QMNAEQAXVXO([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class ZUOUZTOVACX
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4970", Offset = "0xA3E3370", VA = "0x18A3E4970")]
		public static bool GSWUYIBYNPL(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class CQJQXHYVUFK
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding GBVAGEYZDZJ;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class AETZQJQTSLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA3D10B0", Offset = "0xA3CFAB0", VA = "0x18A3D10B0")]
		public static void AMWTCLCPSIB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1040", Offset = "0xA3CFA40", VA = "0x18A3D1040")]
		public static void AMRMFEISIWS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0FD0", Offset = "0xA3CF9D0", VA = "0x18A3D0FD0")]
		public static void AMMFHXOUZLJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0F60", Offset = "0xA3CF960", VA = "0x18A3D0F60")]
		public static void AMGYKQUXQAA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0EF0", Offset = "0xA3CF8F0", VA = "0x18A3D0EF0")]
		public static void AMBRNKBAGOR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0E80", Offset = "0xA3CF880", VA = "0x18A3D0E80")]
		public static void ALWKQDHCXDI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1AD0", Offset = "0xA3D04D0", VA = "0x18A3D1AD0")]
		public static void YGCIMNHIKKS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1B40", Offset = "0xA3D0540", VA = "0x18A3D1B40")]
		public static void YGHPJUBFTWB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D19E0", Offset = "0xA3D03E0", VA = "0x18A3D19E0")]
		public static void YFRURZTNROA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1A50", Offset = "0xA3D0450", VA = "0x18A3D1A50")]
		public static void YFXBPGNLAZJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1CB0", Offset = "0xA3D06B0", VA = "0x18A3D1CB0")]
		public static void YGXKBOIXWEC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1D30", Offset = "0xA3D0730", VA = "0x18A3D1D30")]
		public static void YHCQYVCVFPL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1BB0", Offset = "0xA3D05B0", VA = "0x18A3D1BB0")]
		public static void YGMWHAVDDHK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1C30", Offset = "0xA3D0630", VA = "0x18A3D1C30")]
		public static void YGSDEHPAMST(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA3D18E0", Offset = "0xA3D02E0", VA = "0x18A3D18E0")]
		public static void YEMFILEDMXY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1960", Offset = "0xA3D0360", VA = "0x18A3D1960")]
		public static void YERMFRYAWJH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1740", Offset = "0xA3D0140", VA = "0x18A3D1740")]
		public static void RFLDNUZFUSJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA3D16C0", Offset = "0xA3D00C0", VA = "0x18A3D16C0")]
		public static void RFFWQOFILHA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1640", Offset = "0xA3D0040", VA = "0x18A3D1640")]
		public static void RFAPTHLLBVR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA3D15C0", Offset = "0xA3CFFC0", VA = "0x18A3D15C0")]
		public static void REVIWARNSKI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1540", Offset = "0xA3CFF40", VA = "0x18A3D1540")]
		public static void REQBYTXQIYZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA3D14B0", Offset = "0xA3CFEB0", VA = "0x18A3D14B0")]
		public static void REKVBNDSZNQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1420", Offset = "0xA3CFE20", VA = "0x18A3D1420")]
		public static void REFOEGJVQCH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1390", Offset = "0xA3CFD90", VA = "0x18A3D1390")]
		public static void REAHGZPYGQY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1850", Offset = "0xA3D0250", VA = "0x18A3D1850")]
		public static void RHBGRXCKSFD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D17C0", Offset = "0xA3D01C0", VA = "0x18A3D17C0")]
		public static void RGVZUQINITU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1270", Offset = "0xA3CFC70", VA = "0x18A3D1270")]
		public static void KETYPCRDFAA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1300", Offset = "0xA3CFD00", VA = "0x18A3D1300")]
		public static void KEZFMJLAOLJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1200", Offset = "0xA3CFC00", VA = "0x18A3D1200")]
		public static void ANMNUFKHUQC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1190", Offset = "0xA3CFB90", VA = "0x18A3D1190")]
		public static void ANHGWYQKLET(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1120", Offset = "0xA3CFB20", VA = "0x18A3D1120")]
		public static void ANBZZRWNBTK(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class IBGZLTFRYGX
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5970", Offset = "0xA3D4370", VA = "0x18A3D5970")]
		public static void AMBRNKBAGOR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5900", Offset = "0xA3D4300", VA = "0x18A3D5900")]
		public static void ALWKQDHCXDI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA3D61C0", Offset = "0xA3D4BC0", VA = "0x18A3D61C0")]
		public static void YGCIMNHIKKS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6230", Offset = "0xA3D4C30", VA = "0x18A3D6230")]
		public static void YGHPJUBFTWB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA3D60E0", Offset = "0xA3D4AE0", VA = "0x18A3D60E0")]
		public static void YFRURZTNROA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6150", Offset = "0xA3D4B50", VA = "0x18A3D6150")]
		public static void YFXBPGNLAZJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6390", Offset = "0xA3D4D90", VA = "0x18A3D6390")]
		public static void YGXKBOIXWEC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6400", Offset = "0xA3D4E00", VA = "0x18A3D6400")]
		public static void YHCQYVCVFPL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D62A0", Offset = "0xA3D4CA0", VA = "0x18A3D62A0")]
		public static void YGMWHAVDDHK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6310", Offset = "0xA3D4D10", VA = "0x18A3D6310")]
		public static void YGSDEHPAMST(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5FE0", Offset = "0xA3D49E0", VA = "0x18A3D5FE0")]
		public static void YEMFILEDMXY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6060", Offset = "0xA3D4A60", VA = "0x18A3D6060")]
		public static void YERMFRYAWJH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5E60", Offset = "0xA3D4860", VA = "0x18A3D5E60")]
		public static void RFLDNUZFUSJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5DE0", Offset = "0xA3D47E0", VA = "0x18A3D5DE0")]
		public static void RFFWQOFILHA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5D60", Offset = "0xA3D4760", VA = "0x18A3D5D60")]
		public static void RFAPTHLLBVR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5CE0", Offset = "0xA3D46E0", VA = "0x18A3D5CE0")]
		public static void REVIWARNSKI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5C60", Offset = "0xA3D4660", VA = "0x18A3D5C60")]
		public static void REQBYTXQIYZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5BE0", Offset = "0xA3D45E0", VA = "0x18A3D5BE0")]
		public static void REKVBNDSZNQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5B60", Offset = "0xA3D4560", VA = "0x18A3D5B60")]
		public static void REFOEGJVQCH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5AE0", Offset = "0xA3D44E0", VA = "0x18A3D5AE0")]
		public static void REAHGZPYGQY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5F60", Offset = "0xA3D4960", VA = "0x18A3D5F60")]
		public static void RHBGRXCKSFD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5EE0", Offset = "0xA3D48E0", VA = "0x18A3D5EE0")]
		public static void RGVZUQINITU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA3D59E0", Offset = "0xA3D43E0", VA = "0x18A3D59E0")]
		public static void KETYPCRDFAA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5A60", Offset = "0xA3D4460", VA = "0x18A3D5A60")]
		public static void KEZFMJLAOLJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1200", Offset = "0xA3CFC00", VA = "0x18A3D1200")]
		public static void ANMNUFKHUQC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1190", Offset = "0xA3CFB90", VA = "0x18A3D1190")]
		public static void ANHGWYQKLET(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1120", Offset = "0xA3CFB20", VA = "0x18A3D1120")]
		public static void ANBZZRWNBTK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA3D10B0", Offset = "0xA3CFAB0", VA = "0x18A3D10B0")]
		public static void AMWTCLCPSIB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1040", Offset = "0xA3CFA40", VA = "0x18A3D1040")]
		public static void AMRMFEISIWS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0FD0", Offset = "0xA3CF9D0", VA = "0x18A3D0FD0")]
		public static void AMMFHXOUZLJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0F60", Offset = "0xA3CF960", VA = "0x18A3D0F60")]
		public static void AMGYKQUXQAA(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class DCAAJPHTFUV
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool GCMUOMPDQQM;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA3E64C0", Offset = "0xA3E4EC0", VA = "0x18A3E64C0")]
		public static void YATYGCKFXDN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6430", Offset = "0xA3E4E30", VA = "0x18A3E6430")]
		public static void NXMFAUPWGAS(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x2B66480", Offset = "0x2B64E80", VA = "0x182B66480")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8660", Offset = "0xA3E7060", VA = "0x18A3E8660")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA3E85C0", Offset = "0xA3E6FC0", VA = "0x18A3E85C0")]
		public static DiyFp NDFBLMLLIBG(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8530", Offset = "0xA3E6F30", VA = "0x18A3E8530")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8670", Offset = "0xA3E7070", VA = "0x18A3E8670")]
		public static DiyFp TPVZOLFKNJA(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA3E85D0", Offset = "0xA3E6FD0", VA = "0x18A3E85D0")]
		public void OWMQPELAPEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8610", Offset = "0xA3E7010", VA = "0x18A3E8610")]
		public static DiyFp OWMQPELAPEX(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xDA7AE0", Offset = "0xDA64E0", VA = "0x180DA7AE0")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF6A0", Offset = "0xA3CE0A0", VA = "0x18A3CF6A0")]
		public void LDRCVCQYFGS(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5F10", Offset = "0xA3F4910", VA = "0x18A3F5F10")]
		public void TDSUJNBWVJI(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5CF0", Offset = "0xA3F46F0", VA = "0x18A3F5CF0")]
		public void NLCJPDWUIQS(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5D70", Offset = "0xA3F4770", VA = "0x18A3F5D70")]
		public void NLCJPDWUIQS(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5C70", Offset = "0xA3F4670", VA = "0x18A3F5C70")]
		public void GIOCSCRAQFG(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5E10", Offset = "0xA3F4810", VA = "0x18A3F5E10")]
		public void OSMTYUVHJIT(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class YGYFUEPDOFV
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
		private static byte[] WQPUCDBMEVS;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] VTLNQYJDEPW;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] EFCWJJIHIAW;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] QBURFJSDIJB;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags HOZPAMYCHTK;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char BBENINBSBRK;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int SRQDATADFNC;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int ECRIENFIZDC;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] YZKVMMSUSVU;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB650", Offset = "0xA3FA050", VA = "0x18A3FB650")]
		private static byte[] FWNNSKPMQKU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBEF0", Offset = "0xA3FA8F0", VA = "0x18A3FBEF0")]
		private static byte[] MZCHJIVFTQM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA3FC450", Offset = "0xA3FAE50", VA = "0x18A3FC450")]
		public static int SHZWPQEXDJR(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA3FC570", Offset = "0xA3FAF70", VA = "0x18A3FC570")]
		public static int SHZWPQEXDJR(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB560", Offset = "0xA3F9F60", VA = "0x18A3FB560")]
		private static bool CIEQDIJXBOR(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA3FD050", Offset = "0xA3FBA50", VA = "0x18A3FD050")]
		private static void ZQGUCYKALAR(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA3FCAC0", Offset = "0xA3FB4C0", VA = "0x18A3FCAC0")]
		private static bool UQATIZCDKWZ(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBFD0", Offset = "0xA3FA9D0", VA = "0x18A3FBFD0")]
		private static bool NGBZYXHTBPH(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBC00", Offset = "0xA3FA600", VA = "0x18A3FBC00")]
		private static bool KIFIMJOZLFQ(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA3FCE80", Offset = "0xA3FB880", VA = "0x18A3FCE80")]
		private static bool WFRLCEPEQBB(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB720", Offset = "0xA3FA120", VA = "0x18A3FB720")]
		private static bool JCPGGFTIGEC(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB1C0", Offset = "0xA3F9BC0", VA = "0x18A3FB1C0")]
		private static void CEQNANPQQDI(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA3FC690", Offset = "0xA3FB090", VA = "0x18A3FC690")]
		private static void SZFDIICEVNI(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBD00", Offset = "0xA3FA700", VA = "0x18A3FBD00")]
		private static bool MVUIDRVFBAD(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0xA3E8D30", Offset = "0xA3E7730", VA = "0x18A3E8D30")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8C90", Offset = "0xA3E7690", VA = "0x18A3E8C90")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8870", Offset = "0xA3E7270", VA = "0x18A3E8870")]
		public DiyFp OLRQSXBPVYY()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8B70", Offset = "0xA3E7570", VA = "0x18A3E8B70")]
		public DiyFp XRBAUCRREBB()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xEC8090", Offset = "0xEC6A90", VA = "0x180EC8090")]
		public ulong EPKJPDGBJAW()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA3E87A0", Offset = "0xA3E71A0", VA = "0x18A3E87A0")]
		public double LYNVVELNLVG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8BF0", Offset = "0xA3E75F0", VA = "0x18A3E8BF0")]
		public double YWJGNRTLTWY()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8820", Offset = "0xA3E7220", VA = "0x18A3E8820")]
		public int MDFCBRKDJWP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA3E88E0", Offset = "0xA3E72E0", VA = "0x18A3E88E0")]
		public ulong OMKKAFBBBET()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8850", Offset = "0xA3E7250", VA = "0x18A3E8850")]
		public bool NVOTYDGKBCU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8780", Offset = "0xA3E7180", VA = "0x18A3E8780")]
		public bool LCYINCICDJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8910", Offset = "0xA3E7310", VA = "0x18A3E8910")]
		public bool OXSATOSWZYB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8940", Offset = "0xA3E7340", VA = "0x18A3E8940")]
		public bool RDMNCQSFEYQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8760", Offset = "0xA3E7160", VA = "0x18A3E8760")]
		public int IZSBBSQJQGN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8990", Offset = "0xA3E7390", VA = "0x18A3E8990")]
		public void UQAFJKUUSRF([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8710", Offset = "0xA3E7110", VA = "0x18A3E8710")]
		public bool HBDBEAQPUYR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x40975F0", Offset = "0x4095FF0", VA = "0x1840975F0")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8970", Offset = "0xA3E7370", VA = "0x18A3E8970")]
		public static int UNRGVRYYECQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8AD0", Offset = "0xA3E74D0", VA = "0x18A3E8AD0")]
		public static double VEFYCKVYYLG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8AE0", Offset = "0xA3E74E0", VA = "0x18A3E8AE0")]
		public static ulong XONALKEFRRV(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x185B540", Offset = "0x1859F40", VA = "0x18185B540")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5AC0", Offset = "0xA3F44C0", VA = "0x18A3F5AC0")]
		public DiyFp OLRQSXBPVYY()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF4FFA0", VA = "0x180F515A0")]
		public uint JTMTOVGSLAF()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5A90", Offset = "0xA3F4490", VA = "0x18A3F5A90")]
		public int MDFCBRKDJWP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5B20", Offset = "0xA3F4520", VA = "0x18A3F5B20")]
		public uint OMKKAFBBBET()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5AB0", Offset = "0xA3F44B0", VA = "0x18A3F5AB0")]
		public bool NVOTYDGKBCU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5B40", Offset = "0xA3F4540", VA = "0x18A3F5B40")]
		public void UQAFJKUUSRF([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5A50", Offset = "0xA3F4450", VA = "0x18A3F5A50")]
		public bool HBDBEAQPUYR()
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
		[Cpp2IlInjected.Address(RVA = "0xA3E6420", Offset = "0xA3E4E20", VA = "0x18A3E6420")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class JKUYLUWKAMM
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] OIYCIHYLJPX;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA3EC460", Offset = "0xA3EAE60", VA = "0x18A3EC460")]
		public static void TEYTNTDWNBH(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA3EC390", Offset = "0xA3EAD90", VA = "0x18A3EC390")]
		public static void LAUBXXMASBI(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0xA3F9E40", Offset = "0xA3F8840", VA = "0x18A3F9E40")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4EC00C0", Offset = "0x4EBEAC0", VA = "0x184EC00C0")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D9CB80", Offset = "0x2D9B580", VA = "0x182D9CB80")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9DE0", Offset = "0xA3F87E0", VA = "0x18A3F9DE0")]
		public Vector GFBQCOPSUMB(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class TBIJJBOCRYB
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] ISZHTBGACCX;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] APLBTBDLUCK;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int YJUVZGROWCD;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7120", Offset = "0xA3F5B20", VA = "0x18A3F7120")]
		private static byte[] NSIDEIVIFPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6A30", Offset = "0xA3F5430", VA = "0x18A3F6A30")]
		private static Vector HJLULWKCGWB(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7040", Offset = "0xA3F5A40", VA = "0x18A3F7040")]
		private static Vector LKMXXTCUDPJ(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5F90", Offset = "0xA3F4990", VA = "0x18A3F5F90")]
		private static void CRICBKEOPLA(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA3F74B0", Offset = "0xA3F5EB0", VA = "0x18A3F74B0")]
		private static void USITOEJEENZ(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA3F77A0", Offset = "0xA3F61A0", VA = "0x18A3F77A0")]
		private static ulong WQBOPEUQIJU(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6B10", Offset = "0xA3F5510", VA = "0x18A3F6B10")]
		private static void ISJPICPPDEU(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6660", Offset = "0xA3F5060", VA = "0x18A3F6660")]
		private static bool HALNADLEMWD(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7320", Offset = "0xA3F5D20", VA = "0x18A3F7320")]
		private static DiyFp QBMEMGLVDJW(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6020", Offset = "0xA3F4A20", VA = "0x18A3F6020")]
		private static bool DXMLJCXIPMK(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7200", Offset = "0xA3F5C00", VA = "0x18A3F7200")]
		private static bool OUSGZSWXZSW(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6F20", Offset = "0xA3F5920", VA = "0x18A3F6F20")]
		public static double? LCNXAWIEFQW(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6C50", Offset = "0xA3F5650", VA = "0x18A3F6C50")]
		public static float? LCDJGIUJMUE(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class LIZTHIMHROH
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] SPPQCDSNYIP;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] EFCWJJIHIAW;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] QBURFJSDIJB;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] ITXKXTGRARD;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int LBYUUQAMXHD;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] BNUCCGAISJN;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int CYDVIXNZXKX;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE570", Offset = "0xA3ECF70", VA = "0x18A3EE570")]
		private static byte[] RFEOBKQVUCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE280", Offset = "0xA3ECC80", VA = "0x18A3EE280")]
		public static bool HMQLUZJZQKB(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA3EF640", Offset = "0xA3EE040", VA = "0x18A3EF640")]
		public static bool TWFMGDNTYUU(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE3C0", Offset = "0xA3ECDC0", VA = "0x18A3EE3C0")]
		private static bool JERMVPHOXWN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA3EDED0", Offset = "0xA3EC8D0", VA = "0x18A3EDED0")]
		private static bool DWZCFKOZQKU(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE1A0", Offset = "0xA3ECBA0", VA = "0x18A3EE1A0")]
		private static bool GOOPAUOHQRD(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE500", Offset = "0xA3ECF00", VA = "0x18A3EE500")]
		private static bool OKFATYQCRWL(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA3EF780", Offset = "0xA3EE180", VA = "0x18A3EF780")]
		private static double URQEDAHXGHU(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE650", Offset = "0xA3ED050", VA = "0x18A3EE650")]
		private static double RUGUUYOAQWU(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class JUXOAULBIPU<a> : SIWYLIGCSZE<a[]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly JNDZRHAEOYY<a> ZFELGETKACX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour BVEYSCLIKIR;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x194B260", Offset = "0x1949C60", VA = "0x18194B260")]
		public JUXOAULBIPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8BC0", VA = "0x180CFA1C0")]
		public JUXOAULBIPU(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x668F230", Offset = "0x668DC30", VA = "0x18668F230", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x668EC00", Offset = "0x668D600", VA = "0x18668EC00", Slot = "5")]
		public a[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class YLBQPXDVAGX<a> : SIWYLIGCSZE<ArraySegment<a>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly JNDZRHAEOYY<a> ZFELGETKACX;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x510EFA0", Offset = "0x510D9A0", VA = "0x18510EFA0", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x510EB50", Offset = "0x510D550", VA = "0x18510EB50", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class EBSYDKWIMJX<a> : SIWYLIGCSZE<List<a>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour BVEYSCLIKIR;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x194B260", Offset = "0x1949C60", VA = "0x18194B260")]
		public EBSYDKWIMJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8BC0", VA = "0x180CFA1C0")]
		public EBSYDKWIMJX(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x5B332B0", Offset = "0x5B31CB0", VA = "0x185B332B0", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5B31090", Offset = "0x5B2FA90", VA = "0x185B31090", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class OEYCPIUWIVB<a, b, c, d> : SIWYLIGCSZE<d>, FTQIUPACWHD where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x72A3D10", Offset = "0x72A2710", VA = "0x1872A3D10", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x72A1F00", Offset = "0x72A0900", VA = "0x1872A1F00", Slot = "5")]
		public d Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c KOPILVVEUSX(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		protected OEYCPIUWIVB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class OFYLBQQJDZU<a, b, c> : OEYCPIUWIVB<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x511E750", Offset = "0x511D150", VA = "0x18511E750", Slot = "6")]
		protected override IEnumerator<a> KOPILVVEUSX(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		protected OFYLBQQJDZU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class OGDRYXKGNLD<a, b> : OFYLBQQJDZU<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52D60", VA = "0x180D54360", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class CURNIDPDHPZ<a, b> : OGDRYXKGNLD<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x50DE160", Offset = "0x50DCB60", VA = "0x1850DE160", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x50DE000", Offset = "0x50DCA00", VA = "0x1850DE000", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class YCFIUGTYVWS<a> : OEYCPIUWIVB<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5107A20", Offset = "0x5106420", VA = "0x185107A20", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52D60", VA = "0x180D54360", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5105910", Offset = "0x5104310", VA = "0x185105910", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5107B00", Offset = "0x5106500", VA = "0x185107B00", Slot = "6")]
		protected override LinkedList<a>.Enumerator KOPILVVEUSX(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class FSDYKXWLZXJ<a> : OEYCPIUWIVB<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x50C11F0", Offset = "0x50BFBF0", VA = "0x1850C11F0", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x50D6C30", Offset = "0x50D5630", VA = "0x1850D6C30", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x50D6D40", Offset = "0x50D5740", VA = "0x1850D6D40", Slot = "6")]
		protected override Queue<a>.Enumerator KOPILVVEUSX(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52D60", VA = "0x180D54360", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class PHZNJIKDTKZ<a> : OEYCPIUWIVB<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5105780", Offset = "0x5104180", VA = "0x185105780", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x51058A0", Offset = "0x51042A0", VA = "0x1851058A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x73C90C0", Offset = "0x73C7AC0", VA = "0x1873C90C0", Slot = "6")]
		protected override Stack<a>.Enumerator KOPILVVEUSX(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x73C8F60", Offset = "0x73C7960", VA = "0x1873C8F60", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class CCWKVJANHGZ<a> : OEYCPIUWIVB<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x50D6BF0", Offset = "0x50D55F0", VA = "0x1850D6BF0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52D60", VA = "0x180D54360", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x50D6C90", Offset = "0x50D5690", VA = "0x1850D6C90", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x50D6CF0", Offset = "0x50D56F0", VA = "0x1850D6CF0", Slot = "6")]
		protected override HashSet<a>.Enumerator KOPILVVEUSX(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x50D6DF0", Offset = "0x50D57F0", VA = "0x1850D6DF0")]
		public CCWKVJANHGZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class MRIZIRBPOTF<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5105780", Offset = "0x5104180", VA = "0x185105780", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6F1AB20", Offset = "0x6F19520", VA = "0x186F1AB20", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6F1ABB0", Offset = "0x6F195B0", VA = "0x186F1ABB0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class AKIALGTZETW<a> : OFYLBQQJDZU<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x50C11F0", Offset = "0x50BFBF0", VA = "0x1850C11F0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x50D6C30", Offset = "0x50D5630", VA = "0x1850D6C30", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52D60", VA = "0x180D54360", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class DUNRGYGRTRO<a> : OFYLBQQJDZU<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x50C11F0", Offset = "0x50BFBF0", VA = "0x1850C11F0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x50D6C30", Offset = "0x50D5630", VA = "0x1850D6C30", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52D60", VA = "0x180D54360", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class XVBXFQKYPWK<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5105760", Offset = "0x5104160", VA = "0x185105760", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x51058A0", Offset = "0x51042A0", VA = "0x1851058A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5105880", Offset = "0x5104280", VA = "0x185105880", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x51058D0", Offset = "0x51042D0", VA = "0x1851058D0")]
		public XVBXFQKYPWK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class ERWVWGVHYIO<a, b> : SIWYLIGCSZE<IGrouping<a, b>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5B445F0", Offset = "0x5B42FF0", VA = "0x185B445F0", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5B442A0", Offset = "0x5B42CA0", VA = "0x185B442A0", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class NQDEVIZKWIX<a, b> : SIWYLIGCSZE<ILookup<a, b>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7157A80", Offset = "0x7156480", VA = "0x187157A80", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7157740", Offset = "0x7156140", VA = "0x187157740", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class FVHJGXOXKNV<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a YVOBJQTFQPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> SCSWIWYPUZP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x4EBD030", Offset = "0x4EBBA30", VA = "0x184EBD030", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x62912B0", Offset = "0x628FCB0", VA = "0x1862912B0")]
		public FVHJGXOXKNV(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x6291220", Offset = "0x628FC20", VA = "0x186291220", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6291290", Offset = "0x628FC90", VA = "0x186291290", Slot = "6")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class UVCUHMQAMTS<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> MQKIIGRNUZA;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x744A640", Offset = "0x7449040", VA = "0x18744A640", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9680", VA = "0x180CFAC80")]
		public UVCUHMQAMTS(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7D53950", Offset = "0x7D52350", VA = "0x187D53950", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7D53A40", Offset = "0x7D52440", VA = "0x187D53A40", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7D53A40", Offset = "0x7D52440", VA = "0x187D53A40", Slot = "7")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class EIESYTSNAXX<a> : SIWYLIGCSZE<a>, FTQIUPACWHD where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D8A0", Offset = "0x5B3C2A0", VA = "0x185B3D8A0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D690", Offset = "0x5B3C090", VA = "0x185B3D690", Slot = "5")]
		public a Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public EIESYTSNAXX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class LOHCULONVJD : SIWYLIGCSZE<IEnumerable>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly SIWYLIGCSZE<IEnumerable> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA3F0590", Offset = "0xA3EEF90", VA = "0x18A3F0590", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA3F0390", Offset = "0xA3EED90", VA = "0x18A3F0390", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public LOHCULONVJD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class NFWXZOHWDKD : SIWYLIGCSZE<ICollection>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly SIWYLIGCSZE<ICollection> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA3F2E20", Offset = "0xA3F1820", VA = "0x18A3F2E20", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA3F2C20", Offset = "0xA3F1620", VA = "0x18A3F2C20", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public NFWXZOHWDKD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class UYZNONPCLXJ : SIWYLIGCSZE<IList>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly SIWYLIGCSZE<IList> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA3F95D0", Offset = "0xA3F7FD0", VA = "0x18A3F95D0", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA3F93D0", Offset = "0xA3F7DD0", VA = "0x18A3F93D0", Slot = "5")]
		public IList Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public UYZNONPCLXJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class ISQLWTQOINY<a> : OGDRYXKGNLD<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x50C11F0", Offset = "0x50BFBF0", VA = "0x1850C11F0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x50C1340", Offset = "0x50BFD40", VA = "0x1850C1340", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class XIGAZGFZNKI<a> : OFYLBQQJDZU<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x50C11F0", Offset = "0x50BFBF0", VA = "0x1850C11F0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x50C1340", Offset = "0x50BFD40", VA = "0x1850C1340", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x50C12D0", Offset = "0x50BFCD0", VA = "0x1850C12D0", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class QYSJHRFJWOO<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7645B30", Offset = "0x7644530", VA = "0x187645B30", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x51058A0", Offset = "0x51042A0", VA = "0x1851058A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7645C70", Offset = "0x7644670", VA = "0x187645C70", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7645D50", Offset = "0x7644750", VA = "0x187645D50")]
		public QYSJHRFJWOO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class UKMSYSBEUGG<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7645B30", Offset = "0x7644530", VA = "0x187645B30", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x51058A0", Offset = "0x51042A0", VA = "0x1851058A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5105880", Offset = "0x5104280", VA = "0x185105880", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x51058D0", Offset = "0x51042D0", VA = "0x1851058D0")]
		public UKMSYSBEUGG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class XVQZNSOIQOC<a> : OFYLBQQJDZU<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x50D6B10", Offset = "0x50D5510", VA = "0x1850D6B10", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52D60", VA = "0x180D54360", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5105910", Offset = "0x5104310", VA = "0x185105910", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class HEQUEODQKFY<a> : OGDRYXKGNLD<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x50C11F0", Offset = "0x50BFBF0", VA = "0x1850C11F0", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x50D6C30", Offset = "0x50D5630", VA = "0x1850D6C30", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class HSBYWJLGWOZ<a> : OGDRYXKGNLD<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x50C11F0", Offset = "0x50BFBF0", VA = "0x1850C11F0", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x50D6C30", Offset = "0x50D5630", VA = "0x1850D6C30", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class OQAGYTZJWUE<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5105780", Offset = "0x5104180", VA = "0x185105780", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x51058A0", Offset = "0x51042A0", VA = "0x1851058A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x72BBCA0", Offset = "0x72BA6A0", VA = "0x1872BBCA0", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class LJPANXMKKJP
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
		[Cpp2IlInjected.Address(RVA = "0xA3EFA50", Offset = "0xA3EE450", VA = "0x18A3EFA50")]
		public static DateTime CZBFEHPZCNX(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA3F01E0", Offset = "0xA3EEBE0", VA = "0x18A3F01E0")]
		public static bool UGHJVOYTCCQ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA3EFF50", Offset = "0xA3EE950", VA = "0x18A3EFF50")]
		public static bool SLLITBHFYMQ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA3EFD40", Offset = "0xA3EE740", VA = "0x18A3EFD40")]
		public static bool SLLITBHFYMQ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA3EFB10", Offset = "0xA3EE510", VA = "0x18A3EFB10")]
		public static bool MCKLIRZZJBA(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class ZMCREXEXJEJ : SIWYLIGCSZE<DateTime>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly SIWYLIGCSZE<DateTime> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xA3FE950", Offset = "0xA3FD350", VA = "0x18A3FE950", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA3FE7D0", Offset = "0xA3FD1D0", VA = "0x18A3FE7D0", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA3FE3D0", Offset = "0xA3FCDD0", VA = "0x18A3FE3D0")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public ZMCREXEXJEJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class FBEQYYPUOAM : SIWYLIGCSZE<DateTimeOffset>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly SIWYLIGCSZE<DateTimeOffset> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA040", Offset = "0xA3E8A40", VA = "0x18A3EA040", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9FD0", Offset = "0xA3E89D0", VA = "0x18A3E9FD0", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9BF0", Offset = "0xA3E85F0", VA = "0x18A3E9BF0")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public FBEQYYPUOAM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class LWOTWDLHJTL : SIWYLIGCSZE<TimeSpan>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly SIWYLIGCSZE<TimeSpan> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] QQTGXJKSIDX;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA3F0D80", Offset = "0xA3EF780", VA = "0x18A3F0D80", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA3F0910", Offset = "0xA3EF310", VA = "0x18A3F0910", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA3F0990", Offset = "0xA3EF390", VA = "0x18A3F0990")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public LWOTWDLHJTL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class YRZVEYBVBPW<a, b, c, d, e> : SIWYLIGCSZE<e>, FTQIUPACWHD where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x51195E0", Offset = "0x5117FE0", VA = "0x1851195E0", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x51172D0", Offset = "0x5115CD0", VA = "0x1851172D0", Slot = "5")]
		public e Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d KOPILVVEUSX(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		protected YRZVEYBVBPW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class YSFCCEVSLBF<a, b, c, d> : YRZVEYBVBPW<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x511E750", Offset = "0x511D150", VA = "0x18511E750", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> KOPILVVEUSX(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		protected YSFCCEVSLBF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class YTFKOMRFGFY<a, b, c> : YSFCCEVSLBF<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52D60", VA = "0x180D54360", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class QFFOMNTBXSE<a, b> : YRZVEYBVBPW<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x75B7120", Offset = "0x75B5B20", VA = "0x1875B7120", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52D60", VA = "0x180D54360", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x75B7260", Offset = "0x75B5C60", VA = "0x1875B7260", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x75B7440", Offset = "0x75B5E40", VA = "0x1875B7440", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator KOPILVVEUSX(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6926AD0", Offset = "0x69254D0", VA = "0x186926AD0")]
		public QFFOMNTBXSE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class HTUCKIMVSZC<a, b, c> : YTFKOMRFGFY<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x647E2D0", Offset = "0x647CCD0", VA = "0x18647E2D0", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x647E4B0", Offset = "0x647CEB0", VA = "0x18647E4B0", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class TOBOOWOHLGF<a, b> : YSFCCEVSLBF<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x5B440E0", Offset = "0x5B42AE0", VA = "0x185B440E0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x5B44240", Offset = "0x5B42C40", VA = "0x185B44240", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52D60", VA = "0x180D54360", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class EQRIYKCIEML<a, b> : YTFKOMRFGFY<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x5B440E0", Offset = "0x5B42AE0", VA = "0x185B440E0", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x5B44240", Offset = "0x5B42C40", VA = "0x185B44240", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class WKXUFCTVGHJ<a, b> : YRZVEYBVBPW<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5B440E0", Offset = "0x5B42AE0", VA = "0x185B440E0", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52D60", VA = "0x180D54360", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x5B44240", Offset = "0x5B42C40", VA = "0x185B44240", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x85D0D30", Offset = "0x85CF730", VA = "0x1885D0D30", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator KOPILVVEUSX(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class KGDVETFFARI<a, b> : YSFCCEVSLBF<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x5B440E0", Offset = "0x5B42AE0", VA = "0x185B440E0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x679C800", Offset = "0x679B200", VA = "0x18679C800", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x679C870", Offset = "0x679B270", VA = "0x18679C870", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class TTRTTWFGOSH<a, b> : YSFCCEVSLBF<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7A94080", Offset = "0x7A92A80", VA = "0x187A94080", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52D60", VA = "0x180D54360", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7A940C0", Offset = "0x7A92AC0", VA = "0x187A940C0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x50D6DF0", Offset = "0x50D57F0", VA = "0x1850D6DF0")]
		public TTRTTWFGOSH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class VUUTMEFNWXV<a, b> : YTFKOMRFGFY<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C660", Offset = "0x7E5B060", VA = "0x187E5C660", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5B44240", Offset = "0x5B42C40", VA = "0x185B44240", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class AMUPBFVWXRD<a> : SIWYLIGCSZE<a>, FTQIUPACWHD where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x71C6590", Offset = "0x71C4F90", VA = "0x1871C6590", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x71C6360", Offset = "0x71C4D60", VA = "0x1871C6360", Slot = "5")]
		public a Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public AMUPBFVWXRD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class OKJJYNQBJIP : SIWYLIGCSZE<IDictionary>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly SIWYLIGCSZE<IDictionary> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3B70", Offset = "0xA3F2570", VA = "0x18A3F3B70", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3990", Offset = "0xA3F2390", VA = "0x18A3F3990", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public OKJJYNQBJIP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class ZEIJJVOQRQR
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA3FDBB0", Offset = "0xA3FC5B0", VA = "0x18A3FDBB0")]
		public static object NDYJBYOQEKR(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA3FD390", Offset = "0xA3FBD90", VA = "0x18A3FD390")]
		public static object GFUXVGFJZII(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class BCNCIISCJMG<a> : SIWYLIGCSZE<a>, FTQIUPACWHD, BJQAYWLOALJ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class LZUZORPWDSO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type MGNXNPFUFWI;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public LZUZORPWDSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x68B4030", Offset = "0x68B2A30", VA = "0x1868B4030")]
			internal bool MLHFPGYLZBP(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class MAAGLYJTNDX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string CYEEYWCMPFA;

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public MAAGLYJTNDX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x6EB5A80", Offset = "0x6EB4480", VA = "0x186EB5A80")]
			internal bool MLBYSAEOPQG(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class LZKLUECBKVW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> TSMACLSNVKV;

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public LZKLUECBKVW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x687B040", Offset = "0x6879A40", VA = "0x18687B040")]
			internal void MKWRUTKRGEX(JsonWriter a, a b, DAMCVOXAVIT c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class LZPSRKVYUHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> IBZPWVXMZMY;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public LZPSRKVYUHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x68B2550", Offset = "0x68B0F50", VA = "0x1868B2550")]
			internal a MKRKXMQTWTO(JsonReader a, DAMCVOXAVIT b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly GJAZTNDCOEJ<a> ABEGFLFPLNI;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> PXHKITJQZXC;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> WNHAGOQEZEU;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> FYTDSROTCQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool POFCTAZKJEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> NQRRASMQTXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> PCWIZPYOTJE;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x4EDA5D0", Offset = "0x4ED8FD0", VA = "0x184EDA5D0")]
		static BCNCIISCJMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x4EDE770", Offset = "0x4EDD170", VA = "0x184EDE770")]
		public BCNCIISCJMG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x4EC7A60", Offset = "0x4EC6460", VA = "0x184EC7A60", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x4EC4110", Offset = "0x4EC2B10", VA = "0x184EC4110", Slot = "5")]
		public a Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x4EC6A70", Offset = "0x4EC5470", VA = "0x184EC6A70", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, a b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x4EC8CD0", Offset = "0x4EC76D0", VA = "0x184EC8CD0", Slot = "7")]
		public a UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class SQMCJSOUFWW<a> : SIWYLIGCSZE<a[,]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x792C5C0", Offset = "0x792AFC0", VA = "0x18792C5C0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x792C230", Offset = "0x792AC30", VA = "0x18792C230", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public SQMCJSOUFWW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class EKZGYWDPDFO<a> : SIWYLIGCSZE<a[,,]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5B41A20", Offset = "0x5B40420", VA = "0x185B41A20", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5B41550", Offset = "0x5B3FF50", VA = "0x185B41550", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public EKZGYWDPDFO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class MJTNKZFFIUQ<a> : SIWYLIGCSZE<a[,,,]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C9E0", Offset = "0x6F0B3E0", VA = "0x186F0C9E0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C3E0", Offset = "0x6F0ADE0", VA = "0x186F0C3E0", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public MJTNKZFFIUQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class PYLZZAJYZTA<a> : SIWYLIGCSZE<a?>, FTQIUPACWHD where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x73D21A0", Offset = "0x73D0BA0", VA = "0x1873D21A0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x73D1EF0", Offset = "0x73D08F0", VA = "0x1873D1EF0", Slot = "5")]
		public a? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public PYLZZAJYZTA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class IGFYBIBAAWY<a> : SIWYLIGCSZE<a?>, FTQIUPACWHD where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly SIWYLIGCSZE<a> YZBHMHTFNSH;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9680", VA = "0x180CFAC80")]
		public IGFYBIBAAWY(SIWYLIGCSZE<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x658EBB0", Offset = "0x658D5B0", VA = "0x18658EBB0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x658D900", Offset = "0x658C300", VA = "0x18658D900", Slot = "5")]
		public a? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class UDYWWEPTORV : SIWYLIGCSZE<sbyte>, FTQIUPACWHD, BJQAYWLOALJ<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly UDYWWEPTORV FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8C40", Offset = "0xA3F7640", VA = "0x18A3F8C40", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8B20", Offset = "0xA3F7520", VA = "0x18A3F8B20", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8B30", Offset = "0xA3F7530", VA = "0x18A3F8B30", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, sbyte b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8CD0", Offset = "0xA3F76D0", VA = "0x18A3F8CD0", Slot = "7")]
		public sbyte UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public UDYWWEPTORV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class ONMHQLGOMPQ : SIWYLIGCSZE<sbyte?>, FTQIUPACWHD, BJQAYWLOALJ<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly ONMHQLGOMPQ FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA3F43A0", Offset = "0xA3F2DA0", VA = "0x18A3F43A0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA3F41D0", Offset = "0xA3F2BD0", VA = "0x18A3F41D0", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4240", Offset = "0xA3F2C40", VA = "0x18A3F4240", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, sbyte? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4490", Offset = "0xA3F2E90", VA = "0x18A3F4490", Slot = "7")]
		public sbyte? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public ONMHQLGOMPQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class UYXFYOWLSCK : SIWYLIGCSZE<sbyte[]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly UYXFYOWLSCK FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9130", Offset = "0xA3F7B30", VA = "0x18A3F9130", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8FF0", Offset = "0xA3F79F0", VA = "0x18A3F8FF0", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public UYXFYOWLSCK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class NFFQZVRWYTW : SIWYLIGCSZE<short>, FTQIUPACWHD, BJQAYWLOALJ<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly NFFQZVRWYTW FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xA3F2AA0", Offset = "0xA3F14A0", VA = "0x18A3F2AA0", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA3F2980", Offset = "0xA3F1380", VA = "0x18A3F2980", Slot = "5")]
		public short Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA3F2990", Offset = "0xA3F1390", VA = "0x18A3F2990", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, short b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA3F2B30", Offset = "0xA3F1530", VA = "0x18A3F2B30", Slot = "7")]
		public short UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public NFFQZVRWYTW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class IGOHLMZLWEZ : SIWYLIGCSZE<short?>, FTQIUPACWHD, BJQAYWLOALJ<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly IGOHLMZLWEZ FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA3EBA10", Offset = "0xA3EA410", VA = "0x18A3EBA10", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB840", Offset = "0xA3EA240", VA = "0x18A3EB840", Slot = "5")]
		public short? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB8B0", Offset = "0xA3EA2B0", VA = "0x18A3EB8B0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, short? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA3EBB00", Offset = "0xA3EA500", VA = "0x18A3EBB00", Slot = "7")]
		public short? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public IGOHLMZLWEZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class JBXSUOXJCWD : SIWYLIGCSZE<short[]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly JBXSUOXJCWD FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA3EBD80", Offset = "0xA3EA780", VA = "0x18A3EBD80", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA3EBC40", Offset = "0xA3EA640", VA = "0x18A3EBC40", Slot = "5")]
		public short[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public JBXSUOXJCWD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class LGSTCAVIHJE : SIWYLIGCSZE<int>, FTQIUPACWHD, BJQAYWLOALJ<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly LGSTCAVIHJE FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED930", Offset = "0xA3EC330", VA = "0x18A3ED930", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED810", Offset = "0xA3EC210", VA = "0x18A3ED810", Slot = "5")]
		public int Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED820", Offset = "0xA3EC220", VA = "0x18A3ED820", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, int b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED9C0", Offset = "0xA3EC3C0", VA = "0x18A3ED9C0", Slot = "7")]
		public int UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public LGSTCAVIHJE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class GIAEKFSDQVR : SIWYLIGCSZE<int?>, FTQIUPACWHD, BJQAYWLOALJ<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly GIAEKFSDQVR FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB300", Offset = "0xA3E9D00", VA = "0x18A3EB300", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB130", Offset = "0xA3E9B30", VA = "0x18A3EB130", Slot = "5")]
		public int? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB1A0", Offset = "0xA3E9BA0", VA = "0x18A3EB1A0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, int? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB3F0", Offset = "0xA3E9DF0", VA = "0x18A3EB3F0", Slot = "7")]
		public int? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public GIAEKFSDQVR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class TPCCJHBYNFT : SIWYLIGCSZE<int[]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly TPCCJHBYNFT FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7EA0", Offset = "0xA3F68A0", VA = "0x18A3F7EA0", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7D60", Offset = "0xA3F6760", VA = "0x18A3F7D60", Slot = "5")]
		public int[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public TPCCJHBYNFT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class BAMCKUJMNYL : SIWYLIGCSZE<long>, FTQIUPACWHD, BJQAYWLOALJ<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly BAMCKUJMNYL FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5770", Offset = "0xA3E4170", VA = "0x18A3E5770", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5690", Offset = "0xA3E4090", VA = "0x18A3E5690", Slot = "5")]
		public long Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA3E56A0", Offset = "0xA3E40A0", VA = "0x18A3E56A0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, long b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA3E57D0", Offset = "0xA3E41D0", VA = "0x18A3E57D0", Slot = "7")]
		public long UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public BAMCKUJMNYL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class DHMWHZCFEVA : SIWYLIGCSZE<long?>, FTQIUPACWHD, BJQAYWLOALJ<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly DHMWHZCFEVA FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8120", Offset = "0xA3E6B20", VA = "0x18A3E8120", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7F60", Offset = "0xA3E6960", VA = "0x18A3E7F60", Slot = "5")]
		public long? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7FF0", Offset = "0xA3E69F0", VA = "0x18A3E7FF0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, long? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E81E0", Offset = "0xA3E6BE0", VA = "0x18A3E81E0", Slot = "7")]
		public long? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public DHMWHZCFEVA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class JHYTWECZJZY : SIWYLIGCSZE<long[]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly JHYTWECZJZY FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA3EC160", Offset = "0xA3EAB60", VA = "0x18A3EC160", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA3EC020", Offset = "0xA3EAA20", VA = "0x18A3EC020", Slot = "5")]
		public long[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public JHYTWECZJZY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class CTTZRTHRXQY : SIWYLIGCSZE<byte>, FTQIUPACWHD, BJQAYWLOALJ<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly CTTZRTHRXQY FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA3E62A0", Offset = "0xA3E4CA0", VA = "0x18A3E62A0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6180", Offset = "0xA3E4B80", VA = "0x18A3E6180", Slot = "5")]
		public byte Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6190", Offset = "0xA3E4B90", VA = "0x18A3E6190", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, byte b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6330", Offset = "0xA3E4D30", VA = "0x18A3E6330", Slot = "7")]
		public byte UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public CTTZRTHRXQY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class QEKITHOVHVF : SIWYLIGCSZE<byte?>, FTQIUPACWHD, BJQAYWLOALJ<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly QEKITHOVHVF FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4DC0", Offset = "0xA3F37C0", VA = "0x18A3F4DC0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4BF0", Offset = "0xA3F35F0", VA = "0x18A3F4BF0", Slot = "5")]
		public byte? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4C60", Offset = "0xA3F3660", VA = "0x18A3F4C60", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, byte? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4EB0", Offset = "0xA3F38B0", VA = "0x18A3F4EB0", Slot = "7")]
		public byte? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public QEKITHOVHVF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class PBIFANHUJLB : SIWYLIGCSZE<ushort>, FTQIUPACWHD, BJQAYWLOALJ<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly PBIFANHUJLB FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4A70", Offset = "0xA3F3470", VA = "0x18A3F4A70", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4950", Offset = "0xA3F3350", VA = "0x18A3F4950", Slot = "5")]
		public ushort Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4960", Offset = "0xA3F3360", VA = "0x18A3F4960", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, ushort b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4B00", Offset = "0xA3F3500", VA = "0x18A3F4B00", Slot = "7")]
		public ushort UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public PBIFANHUJLB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class FLRLFPHSIMU : SIWYLIGCSZE<ushort?>, FTQIUPACWHD, BJQAYWLOALJ<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly FLRLFPHSIMU FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA3EAD10", Offset = "0xA3E9710", VA = "0x18A3EAD10", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA3EAB40", Offset = "0xA3E9540", VA = "0x18A3EAB40", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA3EABB0", Offset = "0xA3E95B0", VA = "0x18A3EABB0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, ushort? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA3EAE00", Offset = "0xA3E9800", VA = "0x18A3EAE00", Slot = "7")]
		public ushort? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public FLRLFPHSIMU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class WTUSLCJIHWC : SIWYLIGCSZE<ushort[]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly WTUSLCJIHWC FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA3A0", Offset = "0xA3F8DA0", VA = "0x18A3FA3A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA260", Offset = "0xA3F8C60", VA = "0x18A3FA260", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public WTUSLCJIHWC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class TFBNDGSQAPD : SIWYLIGCSZE<uint>, FTQIUPACWHD, BJQAYWLOALJ<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly TFBNDGSQAPD FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7A10", Offset = "0xA3F6410", VA = "0x18A3F7A10", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA3F78F0", Offset = "0xA3F62F0", VA = "0x18A3F78F0", Slot = "5")]
		public uint Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7900", Offset = "0xA3F6300", VA = "0x18A3F7900", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, uint b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7AA0", Offset = "0xA3F64A0", VA = "0x18A3F7AA0", Slot = "7")]
		public uint UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public TFBNDGSQAPD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class VIJTSKAQGHU : SIWYLIGCSZE<uint?>, FTQIUPACWHD, BJQAYWLOALJ<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly VIJTSKAQGHU FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9BB0", Offset = "0xA3F85B0", VA = "0x18A3F9BB0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA3F99E0", Offset = "0xA3F83E0", VA = "0x18A3F99E0", Slot = "5")]
		public uint? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9A50", Offset = "0xA3F8450", VA = "0x18A3F9A50", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, uint? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9CA0", Offset = "0xA3F86A0", VA = "0x18A3F9CA0", Slot = "7")]
		public uint? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public VIJTSKAQGHU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class ELZIBGUVUXO : SIWYLIGCSZE<uint[]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly ELZIBGUVUXO FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E92D0", Offset = "0xA3E7CD0", VA = "0x18A3E92D0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9190", Offset = "0xA3E7B90", VA = "0x18A3E9190", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public ELZIBGUVUXO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class FYZTYONFMKY : SIWYLIGCSZE<ulong>, FTQIUPACWHD, BJQAYWLOALJ<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly FYZTYONFMKY FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB020", Offset = "0xA3E9A20", VA = "0x18A3EB020", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA3EAF40", Offset = "0xA3E9940", VA = "0x18A3EAF40", Slot = "5")]
		public ulong Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA3EAF50", Offset = "0xA3E9950", VA = "0x18A3EAF50", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, ulong b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB080", Offset = "0xA3E9A80", VA = "0x18A3EB080", Slot = "7")]
		public ulong UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public FYZTYONFMKY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class AJVXOUVBTNR : SIWYLIGCSZE<ulong?>, FTQIUPACWHD, BJQAYWLOALJ<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly AJVXOUVBTNR FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5300", Offset = "0xA3E3D00", VA = "0x18A3E5300", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5140", Offset = "0xA3E3B40", VA = "0x18A3E5140", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E51D0", Offset = "0xA3E3BD0", VA = "0x18A3E51D0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, ulong? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E53C0", Offset = "0xA3E3DC0", VA = "0x18A3E53C0", Slot = "7")]
		public ulong? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public AJVXOUVBTNR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class MFOBYFANQNF : SIWYLIGCSZE<ulong[]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly MFOBYFANQNF FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xA3F2750", Offset = "0xA3F1150", VA = "0x18A3F2750", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA3F2610", Offset = "0xA3F1010", VA = "0x18A3F2610", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public MFOBYFANQNF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class WTFMMNLWDXI : SIWYLIGCSZE<float>, FTQIUPACWHD, BJQAYWLOALJ<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly WTFMMNLWDXI FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA150", Offset = "0xA3F8B50", VA = "0x18A3FA150", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA070", Offset = "0xA3F8A70", VA = "0x18A3FA070", Slot = "5")]
		public float Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA080", Offset = "0xA3F8A80", VA = "0x18A3FA080", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, float b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA1B0", Offset = "0xA3F8BB0", VA = "0x18A3FA1B0", Slot = "7")]
		public float UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public WTFMMNLWDXI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class WXEUCTEBNSZ : SIWYLIGCSZE<float?>, FTQIUPACWHD, BJQAYWLOALJ<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly WXEUCTEBNSZ FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xA3FAB30", Offset = "0xA3F9530", VA = "0x18A3FAB30", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA9A0", Offset = "0xA3F93A0", VA = "0x18A3FA9A0", Slot = "5")]
		public float? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA3FAA10", Offset = "0xA3F9410", VA = "0x18A3FAA10", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, float? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA3FABF0", Offset = "0xA3F95F0", VA = "0x18A3FABF0", Slot = "7")]
		public float? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public WXEUCTEBNSZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class CSOVJBXPMFP : SIWYLIGCSZE<float[]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly CSOVJBXPMFP FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5DF0", Offset = "0xA3E47F0", VA = "0x18A3E5DF0", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5CB0", Offset = "0xA3E46B0", VA = "0x18A3E5CB0", Slot = "5")]
		public float[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public CSOVJBXPMFP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class WOGBHFIESZL : SIWYLIGCSZE<double>, FTQIUPACWHD, BJQAYWLOALJ<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly WOGBHFIESZL FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9F60", Offset = "0xA3F8960", VA = "0x18A3F9F60", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9E80", Offset = "0xA3F8880", VA = "0x18A3F9E80", Slot = "5")]
		public double Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9E90", Offset = "0xA3F8890", VA = "0x18A3F9E90", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, double b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9FC0", Offset = "0xA3F89C0", VA = "0x18A3F9FC0", Slot = "7")]
		public double UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public WOGBHFIESZL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class RWTWUMZENOG : SIWYLIGCSZE<double?>, FTQIUPACWHD, BJQAYWLOALJ<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly RWTWUMZENOG FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5680", Offset = "0xA3F4080", VA = "0x18A3F5680", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA3F54C0", Offset = "0xA3F3EC0", VA = "0x18A3F54C0", Slot = "5")]
		public double? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5550", Offset = "0xA3F3F50", VA = "0x18A3F5550", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, double? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5740", Offset = "0xA3F4140", VA = "0x18A3F5740", Slot = "7")]
		public double? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public RWTWUMZENOG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class YDPEWRGBAIQ : SIWYLIGCSZE<double[]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly YDPEWRGBAIQ FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA3FAE40", Offset = "0xA3F9840", VA = "0x18A3FAE40", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA3FAD00", Offset = "0xA3F9700", VA = "0x18A3FAD00", Slot = "5")]
		public double[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public YDPEWRGBAIQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class SKIWXNPENEO : SIWYLIGCSZE<bool>, FTQIUPACWHD, BJQAYWLOALJ<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly SKIWXNPENEO FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5940", Offset = "0xA3F4340", VA = "0x18A3F5940", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5860", Offset = "0xA3F4260", VA = "0x18A3F5860", Slot = "5")]
		public bool Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5870", Offset = "0xA3F4270", VA = "0x18A3F5870", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, bool b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA3F59A0", Offset = "0xA3F43A0", VA = "0x18A3F59A0", Slot = "7")]
		public bool UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public SKIWXNPENEO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class WUWDIQEPEFB : SIWYLIGCSZE<bool?>, FTQIUPACWHD, BJQAYWLOALJ<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly WUWDIQEPEFB FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA7D0", Offset = "0xA3F91D0", VA = "0x18A3FA7D0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA640", Offset = "0xA3F9040", VA = "0x18A3FA640", Slot = "5")]
		public bool? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA6B0", Offset = "0xA3F90B0", VA = "0x18A3FA6B0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, bool? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA890", Offset = "0xA3F9290", VA = "0x18A3FA890", Slot = "7")]
		public bool? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public WUWDIQEPEFB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class FAELZQCOXRT : SIWYLIGCSZE<bool[]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly FAELZQCOXRT FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9860", Offset = "0xA3E8260", VA = "0x18A3E9860", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9720", Offset = "0xA3E8120", VA = "0x18A3E9720", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public FAELZQCOXRT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class QYBSRLPNKLJ : SIWYLIGCSZE<byte[]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly SIWYLIGCSZE<byte[]> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5060", Offset = "0xA3F3A60", VA = "0x18A3F5060", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4FF0", Offset = "0xA3F39F0", VA = "0x18A3F4FF0", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public QYBSRLPNKLJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class NRAQBJYKYKO : SIWYLIGCSZE<ArraySegment<byte>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly SIWYLIGCSZE<ArraySegment<byte>> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA3F37F0", Offset = "0xA3F21F0", VA = "0x18A3F37F0", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3720", Offset = "0xA3F2120", VA = "0x18A3F3720", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public NRAQBJYKYKO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class NHPKYVYTDSO : SIWYLIGCSZE<string>, FTQIUPACWHD, BJQAYWLOALJ<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly SIWYLIGCSZE<string> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3340", Offset = "0xA3F1D40", VA = "0x18A3F3340", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA3F32D0", Offset = "0xA3F1CD0", VA = "0x18A3F32D0", Slot = "5")]
		public string Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA3F32E0", Offset = "0xA3F1CE0", VA = "0x18A3F32E0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, string b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA3F32D0", Offset = "0xA3F1CD0", VA = "0x18A3F32D0", Slot = "7")]
		public string UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public NHPKYVYTDSO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class OZCIFPWEAVL : SIWYLIGCSZE<string[]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly OZCIFPWEAVL FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4720", Offset = "0xA3F3120", VA = "0x18A3F4720", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA3F45D0", Offset = "0xA3F2FD0", VA = "0x18A3F45D0", Slot = "5")]
		public string[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public OZCIFPWEAVL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class KZFPVZWWSMK : SIWYLIGCSZE<char>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly KZFPVZWWSMK FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED500", Offset = "0xA3EBF00", VA = "0x18A3ED500", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED4D0", Offset = "0xA3EBED0", VA = "0x18A3ED4D0", Slot = "5")]
		public char Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public KZFPVZWWSMK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class UGJLPRWGTDL : SIWYLIGCSZE<char?>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly UGJLPRWGTDL FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8E80", Offset = "0xA3F7880", VA = "0x18A3F8E80", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8DC0", Offset = "0xA3F77C0", VA = "0x18A3F8DC0", Slot = "5")]
		public char? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public UGJLPRWGTDL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class EKKFQJKZZVL : SIWYLIGCSZE<char[]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly EKKFQJKZZVL FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8ED0", Offset = "0xA3E78D0", VA = "0x18A3E8ED0", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8D40", Offset = "0xA3E7740", VA = "0x18A3E8D40", Slot = "5")]
		public char[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public EKKFQJKZZVL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class CGZGOAJFEVT : SIWYLIGCSZE<Guid>, FTQIUPACWHD, BJQAYWLOALJ<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly SIWYLIGCSZE<Guid> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5A60", Offset = "0xA3E4460", VA = "0x18A3E5A60", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5880", Offset = "0xA3E4280", VA = "0x18A3E5880", Slot = "5")]
		public Guid Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA3E58E0", Offset = "0xA3E42E0", VA = "0x18A3E58E0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, Guid b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5BD0", Offset = "0xA3E45D0", VA = "0x18A3E5BD0", Slot = "7")]
		public Guid UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public CGZGOAJFEVT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class LGZZBEJMDPZ : SIWYLIGCSZE<decimal>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly SIWYLIGCSZE<decimal> FYIBPTBKDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool UGQLUUXNJIP;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x873E0C0", Offset = "0x873CAC0", VA = "0x18873E0C0")]
		public LGZZBEJMDPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xFE13B0", Offset = "0xFDFDB0", VA = "0x180FE13B0")]
		public LGZZBEJMDPZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA3EDC80", Offset = "0xA3EC680", VA = "0x18A3EDC80", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA3EDAB0", Offset = "0xA3EC4B0", VA = "0x18A3EDAB0", Slot = "5")]
		public decimal Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class TONINDHZJAA : SIWYLIGCSZE<Uri>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly SIWYLIGCSZE<Uri> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7C10", Offset = "0xA3F6610", VA = "0x18A3F7C10", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7B90", Offset = "0xA3F6590", VA = "0x18A3F7B90", Slot = "5")]
		public Uri Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public TONINDHZJAA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class BACTIQQTCAK : SIWYLIGCSZE<Version>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly SIWYLIGCSZE<Version> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5560", Offset = "0xA3E3F60", VA = "0x18A3E5560", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA3E54E0", Offset = "0xA3E3EE0", VA = "0x18A3E54E0", Slot = "5")]
		public Version Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public BACTIQQTCAK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class PMEMPOFRJHW<a, b> : SIWYLIGCSZE<KeyValuePair<a, b>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x73C9EA0", Offset = "0x73C88A0", VA = "0x1873C9EA0", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x73C99D0", Offset = "0x73C83D0", VA = "0x1873C99D0", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class LXDLUUFFILU : SIWYLIGCSZE<StringBuilder>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly SIWYLIGCSZE<StringBuilder> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA3F1520", Offset = "0xA3EFF20", VA = "0x18A3F1520", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA3F14A0", Offset = "0xA3EFEA0", VA = "0x18A3F14A0", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public LXDLUUFFILU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class NIXMDSYLZLM : SIWYLIGCSZE<BitArray>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly SIWYLIGCSZE<BitArray> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3530", Offset = "0xA3F1F30", VA = "0x18A3F3530", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3F3410", Offset = "0xA3F1E10", VA = "0x18A3F3410", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public NIXMDSYLZLM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class HNHWNRTEVHE : SIWYLIGCSZE<Type>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly HNHWNRTEVHE FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex NSJQSMHAPPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool GJMDXBSYZIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool CFRFAJKRSHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool EMEEMKEMIGJ;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB820", Offset = "0xA3EA220", VA = "0x18A3EB820")]
		public HNHWNRTEVHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x9702B10", Offset = "0x9701510", VA = "0x189702B10")]
		public HNHWNRTEVHE(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB640", Offset = "0xA3EA040", VA = "0x18A3EB640", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB530", Offset = "0xA3E9F30", VA = "0x18A3EB530", Slot = "5")]
		public Type Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class TPDGJMDTDNY : SIWYLIGCSZE<BigInteger>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly SIWYLIGCSZE<BigInteger> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA3F81F0", Offset = "0xA3F6BF0", VA = "0x18A3F81F0", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8140", Offset = "0xA3F6B40", VA = "0x18A3F8140", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public TPDGJMDTDNY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class DRUKTPOVRWS : SIWYLIGCSZE<Complex>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly SIWYLIGCSZE<Complex> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8390", Offset = "0xA3E6D90", VA = "0x18A3E8390", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA3E8300", Offset = "0xA3E6D00", VA = "0x18A3E8300", Slot = "5")]
		public Complex Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public DRUKTPOVRWS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class REFYSPUHCSI : SIWYLIGCSZE<ExpandoObject>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly SIWYLIGCSZE<ExpandoObject> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA3F53C0", Offset = "0xA3F3DC0", VA = "0x18A3F53C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5190", Offset = "0xA3F3B90", VA = "0x18A3F5190", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public REFYSPUHCSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class JEFVNEDXVNJ<a> : SIWYLIGCSZE<Lazy<a>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x6685860", Offset = "0x6684260", VA = "0x186685860", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x66856E0", Offset = "0x66840E0", VA = "0x1866856E0", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class LAHSWZNPFEH : SIWYLIGCSZE<Task>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly SIWYLIGCSZE<Task> FYIBPTBKDJH;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task QQNIMLZDOPC;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED6D0", Offset = "0xA3EC0D0", VA = "0x18A3ED6D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED620", Offset = "0xA3EC020", VA = "0x18A3ED620", Slot = "5")]
		public Task Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public LAHSWZNPFEH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class GEZYKBESAHJ<a> : SIWYLIGCSZE<Task<a>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x6367030", Offset = "0x6365A30", VA = "0x186367030", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x6366EC0", Offset = "0x63658C0", VA = "0x186366EC0", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class OHTMBYMOPZD<a> : SIWYLIGCSZE<ValueTask<a>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x72AA340", Offset = "0x72A8D40", VA = "0x1872AA340", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x72AA1A0", Offset = "0x72A8BA0", VA = "0x1872AA1A0", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class XJHNJIMHFKT<a> : SIWYLIGCSZE<Tuple<a>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x50C3B30", Offset = "0x50C2530", VA = "0x1850C3B30", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x50C3860", Offset = "0x50C2260", VA = "0x1850C3860", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class XJMUGPGEOWC<a, b> : SIWYLIGCSZE<Tuple<a, b>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x50C4910", Offset = "0x50C3310", VA = "0x1850C4910", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x50C44F0", Offset = "0x50C2EF0", VA = "0x1850C44F0", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class XJSBDWABYHL<a, b, c> : SIWYLIGCSZE<Tuple<a, b, c>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x50C7270", Offset = "0x50C5C70", VA = "0x1850C7270", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x50C6D10", Offset = "0x50C5710", VA = "0x1850C6D10", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class XJXIBCTZHSU<a, b, c, d> : SIWYLIGCSZE<Tuple<a, b, c, d>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x50C7FA0", Offset = "0x50C69A0", VA = "0x1850C7FA0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x50C78F0", Offset = "0x50C62F0", VA = "0x1850C78F0", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class XKCOYJNWRED<a, b, c, d, e> : SIWYLIGCSZE<Tuple<a, b, c, d, e>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x50C8F90", Offset = "0x50C7990", VA = "0x1850C8F90", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x50C8790", Offset = "0x50C7190", VA = "0x1850C8790", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class XKHVVQHUAPM<a, b, c, d, e, f> : SIWYLIGCSZE<Tuple<a, b, c, d, e, f>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x50CA270", Offset = "0x50C8C70", VA = "0x1850CA270", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x50C98E0", Offset = "0x50C82E0", VA = "0x1850C98E0", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class XKNCSXBRKAV<a, b, c, d, e, f, g> : SIWYLIGCSZE<Tuple<a, b, c, d, e, f, g>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x50CC440", Offset = "0x50CAE40", VA = "0x1850CC440", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x50CB930", Offset = "0x50CA330", VA = "0x1850CB930", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class XKSJQDVOTME<a, b, c, d, e, f, g, h> : SIWYLIGCSZE<Tuple<a, b, c, d, e, f, g, h>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x50CDCE0", Offset = "0x50CC6E0", VA = "0x1850CDCE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x50CD070", Offset = "0x50CBA70", VA = "0x1850CD070", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class GSVOVLHNUIC<a> : SIWYLIGCSZE<ValueTuple<a>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x63DD4A0", Offset = "0x63DBEA0", VA = "0x1863DD4A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x63DD090", Offset = "0x63DBA90", VA = "0x1863DD090", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class GSQHYENQKWT<a, b> : SIWYLIGCSZE<(a, b)>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x63DCB40", Offset = "0x63DB540", VA = "0x1863DCB40", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x63DC660", Offset = "0x63DB060", VA = "0x1863DC660", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class GSLBAXTTBLK<a, b, c> : SIWYLIGCSZE<(a, b, c)>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x63DBF70", Offset = "0x63DA970", VA = "0x1863DBF70", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x63DB900", Offset = "0x63DA300", VA = "0x1863DB900", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class GSFUDQZVSAB<a, b, c, d> : SIWYLIGCSZE<(a, b, c, d)>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x63DB050", Offset = "0x63D9A50", VA = "0x1863DB050", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x63DA820", Offset = "0x63D9220", VA = "0x1863DA820", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class GSANGKFYIOS<a, b, c, d, e> : SIWYLIGCSZE<(a, b, c, d, e)>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x63D9DD0", Offset = "0x63D87D0", VA = "0x1863D9DD0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x63D9420", Offset = "0x63D7E20", VA = "0x1863D9420", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class GRVGJDMAZDJ<a, b, c, d, e, f> : SIWYLIGCSZE<(a, b, c, d, e, f)>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x63D8820", Offset = "0x63D7220", VA = "0x1863D8820", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x63D7C60", Offset = "0x63D6660", VA = "0x1863D7C60", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class GRPZLWSDPSA<a, b, c, d, e, f, g> : SIWYLIGCSZE<(a, b, c, d, e, f, g)>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x63D60E0", Offset = "0x63D4AE0", VA = "0x1863D60E0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x63D5380", Offset = "0x63D3D80", VA = "0x1863D5380", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class GRKSOPYGGGR<a, b, c, d, e, f, g, h> : SIWYLIGCSZE<ValueTuple<a, b, c, d, e, f, g, h>>, FTQIUPACWHD where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] UYGECNZNHMO;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly IWXXPKAIOHU FCJMKWNSKXG;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x63D43A0", Offset = "0x63D2DA0", VA = "0x1863D43A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x63D3480", Offset = "0x63D1E80", VA = "0x1863D3480", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class EPHMEGKHCQO
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] PPJKXYJMVZI;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly IWXXPKAIOHU ESUIVIMBVSH;

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9570", Offset = "0xA3E7F70", VA = "0x18A3E9570")]
		static EPHMEGKHCQO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class AGHLNBICEOQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] HYQWNVRIDJV;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly IWXXPKAIOHU DKUNGRPQAOK;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4F90", Offset = "0xA3E3990", VA = "0x18A3E4F90")]
		static AGHLNBICEOQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class MAPHCHHKMXK
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] WJUKDGIFFJM;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly IWXXPKAIOHU XCYUZCDENFJ;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] WJPDFZOHVYD;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly IWXXPKAIOHU XDEBWIXBWQS;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] WJJWISUKMMU;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly IWXXPKAIOHU XDJITPQZGCB;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] WJEPLMANDBL;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly IWXXPKAIOHU XBYMMUHRSAQ;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] WIZIOFGPTQC;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly IWXXPKAIOHU XCDTKBBPBLZ;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] WIUBQYMSKET;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly IWXXPKAIOHU XCJAHHVMKXI;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] WIOUTRSVATK;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly IWXXPKAIOHU XCOHEOPJUIR;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] WLPUEPFHMHP;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly IWXXPKAIOHU XEJRFXMMBGU;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xA3F1630", Offset = "0xA3F0030", VA = "0x18A3F1630")]
		static MAPHCHHKMXK()
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
