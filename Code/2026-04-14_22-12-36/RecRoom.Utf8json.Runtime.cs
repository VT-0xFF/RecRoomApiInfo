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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D90520", Offset = "0x3D8F120", VA = "0x183D90520")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AD6060", Offset = "0x3AD4C60", VA = "0x183AD6060")]
		public static SIWYLIGCSZE<a> EVFDGDBKNGX<a>(this DAMCVOXAVIT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4FB0", Offset = "0xA3D3BB0", VA = "0x18A3D4FB0")]
		public static object DLEXLAFLEKL(this DAMCVOXAVIT a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4F50", Offset = "0xA3D3B50", VA = "0x18A3D4F50")]
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
				[Cpp2IlInjected.Address(RVA = "0xA3D44A0", Offset = "0xA3D30A0", VA = "0x18A3D44A0")]
				public BRDCAVKNDPU(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xA3D4380", Offset = "0xA3D2F80", VA = "0x18A3D4380")]
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
			[Cpp2IlInjected.Address(RVA = "0xA3DED30", Offset = "0xA3DD930", VA = "0x18A3DED30")]
			public void FLYXUGEVGZO([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA3DEBF0", Offset = "0xA3DD7F0", VA = "0x18A3DEBF0")]
			public void FLYXUGEVGZO(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA3DF1E0", Offset = "0xA3DDDE0", VA = "0x18A3DF1E0")]
			public ReadOnlySequence<byte> YZISAFOAUMH()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA3DF030", Offset = "0xA3DDC30", VA = "0x18A3DF030")]
			private void RXEQWLLIJTR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA3DEE40", Offset = "0xA3DDA40", VA = "0x18A3DEE40")]
			private void OHPJAPKTQYR([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC250", Offset = "0xA3DAE50", VA = "0x18A3DC250")]
		public JsonReader([In] ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC0E0", Offset = "0xA3DACE0", VA = "0x18A3DC0E0")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA970", Offset = "0xA3D9570", VA = "0x18A3DA970")]
		private JsonParsingException OPKLQCUPKHP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB440", Offset = "0xA3DA040", VA = "0x18A3DB440")]
		private JsonParsingException QMOEWITGZAA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9610", Offset = "0xA3D8210", VA = "0x18A3D9610")]
		public JsonToken CSNLQLJSGGI()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB550", Offset = "0xA3DA150", VA = "0x18A3DB550")]
		public void QNQPGLWUZNQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA0B0", Offset = "0xA3D8CB0", VA = "0x18A3DA0B0")]
		private bool KBZSGVXGJFW(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA110", Offset = "0xA3D8D10", VA = "0x18A3DA110")]
		private bool KBZSGVXGJFW(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBC10", Offset = "0xA3DA810", VA = "0x18A3DBC10")]
		private void VNMGZQHFIRX(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9C10", Offset = "0xA3D8810", VA = "0x18A3D9C10")]
		public bool FNTSIVZMTSJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC0D0", Offset = "0xA3DACD0", VA = "0x18A3DC0D0")]
		public void ZWUBWBKLEVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9A50", Offset = "0xA3D8650", VA = "0x18A3D9A50")]
		public bool EAIEFSTWDEG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBD70", Offset = "0xA3DA970", VA = "0x18A3DBD70")]
		public void WWBEGQUCYUP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC0C0", Offset = "0xA3DACC0", VA = "0x18A3DC0C0")]
		public void ZQAAKZLPFHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB220", Offset = "0xA3D9E20", VA = "0x18A3DB220")]
		public bool PMXOTEGVQVE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB210", Offset = "0xA3D9E10", VA = "0x18A3DB210")]
		public void PMUJMJSQICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB7F0", Offset = "0xA3DA3F0", VA = "0x18A3DB7F0")]
		public void RWYKTWKRXNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBF80", Offset = "0xA3DAB80", VA = "0x18A3DBF80")]
		public bool XZSEAACUZEZ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA250", Offset = "0xA3D8E50", VA = "0x18A3DA250")]
		public bool KZFDBXNXHBK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9340", Offset = "0xA3D7F40", VA = "0x18A3D9340")]
		public bool CBJTASTWZYN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9260", Offset = "0xA3D7E60", VA = "0x18A3D9260")]
		public bool BZYSGTOCXIM(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAD30", Offset = "0xA3D9930", VA = "0x18A3DAD30")]
		private ReadOnlySequence<byte> PKTUJKMPITD()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8FF0", Offset = "0xA3D7BF0", VA = "0x18A3D8FF0")]
		private ReadOnlySequence<byte> ABPPPBKKZRG()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB800", Offset = "0xA3DA400", VA = "0x18A3DB800")]
		private void SSDGNPKZNXW(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBD80", Offset = "0xA3DA980", VA = "0x18A3DBD80")]
		private void XBGZLMVVDRR(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA680", Offset = "0xA3D9280", VA = "0x18A3DA680")]
		private void OMFGSUQEZPQ(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9D70", Offset = "0xA3D8970", VA = "0x18A3D9D70")]
		private void ILLSEQHTFWN(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0FF0", Offset = "0xA3CFBF0", VA = "0x18A3D0FF0")]
		private static int VPTVHUSHHSM(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9FE0", Offset = "0xA3D8BE0", VA = "0x18A3D9FE0")]
		public ReadOnlySequence<byte> KAYTKWXNXAU()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB270", Offset = "0xA3D9E70", VA = "0x18A3DB270")]
		public string QFVYWTTUAVD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9830", Offset = "0xA3D8430", VA = "0x18A3D9830")]
		public string DKNZYERCFAS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBA90", Offset = "0xA3DA690", VA = "0x18A3DBA90")]
		public ReadOnlySequence<byte> TCHGRTDGGWM()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA170", Offset = "0xA3D8D70", VA = "0x18A3DA170")]
		public ReadOnlySequence<byte> KSTVKDEVSUX()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB2F0", Offset = "0xA3D9EF0", VA = "0x18A3DB2F0")]
		public bool QMNAEQAXVXO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9AA0", Offset = "0xA3D86A0", VA = "0x18A3D9AA0")]
		private void FJGQFMYCKNM(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9820", Offset = "0xA3D8420", VA = "0x18A3D9820")]
		public void DCFGWKCJYXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA3D93D0", Offset = "0xA3D7FD0", VA = "0x18A3D93D0")]
		private void CKEDLYMMREB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9F30", Offset = "0xA3D8B30", VA = "0x18A3D9F30")]
		public sbyte JLPJIIAADLV()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBCC0", Offset = "0xA3DA8C0", VA = "0x18A3DBCC0")]
		public short VXOTNNBTSKS()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9E80", Offset = "0xA3D8A80", VA = "0x18A3D9E80")]
		public int IYZEXPSYLZC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DACC0", Offset = "0xA3D98C0", VA = "0x18A3DACC0")]
		public long OYDDYJJBHIL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBB60", Offset = "0xA3DA760", VA = "0x18A3DBB60")]
		public byte TSTMKJJZOGS()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA5D0", Offset = "0xA3D91D0", VA = "0x18A3DA5D0")]
		public ushort MEXSHCNGMSP()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC010", Offset = "0xA3DAC10", VA = "0x18A3DC010")]
		public uint ZHYGVHHQDTT()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB780", Offset = "0xA3DA380", VA = "0x18A3DB780")]
		public ulong RJVDVVPNALI()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB9F0", Offset = "0xA3DA5F0", VA = "0x18A3DB9F0")]
		public float SWKJZCTJFKA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9CD0", Offset = "0xA3D88D0", VA = "0x18A3D9CD0")]
		public double IGVWFQGZTKR()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9870", Offset = "0xA3D8470", VA = "0x18A3D9870")]
		public ReadOnlySequence<byte> DPZQMKWOFJY()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA330", Offset = "0xA3D8F30", VA = "0x18A3DA330")]
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
			[Cpp2IlInjected.Address(RVA = "0xF94180", Offset = "0xF92D80", VA = "0x180F94180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8F90", Offset = "0xA3D7B90", VA = "0x18A3D8F90")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8F10", Offset = "0xA3D7B10", VA = "0x18A3D8F10")]
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
			[Cpp2IlInjected.Address(RVA = "0xA3D5100", Offset = "0xA3D3D00", VA = "0x18A3D5100")]
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
			[Cpp2IlInjected.Address(RVA = "0xA3E5830", Offset = "0xA3E4430", VA = "0x18A3E5830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5490", Offset = "0xA3E4090", VA = "0x18A3E5490")]
		public static void AVULLZQETHJ(DAMCVOXAVIT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x413A700", Offset = "0x4139300", VA = "0x18413A700")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x413A590", Offset = "0x4139190", VA = "0x18413A590")]
		public static byte[] Serialize<T>(T value, DAMCVOXAVIT resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x413AB70", Offset = "0x4139770", VA = "0x18413AB70")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x413ABF0", Offset = "0x41397F0", VA = "0x18413ABF0")]
		public static string ToJsonString<T>(T value, DAMCVOXAVIT resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x413A0A0", Offset = "0x4138CA0", VA = "0x18413A0A0")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4139D00", Offset = "0x4138900", VA = "0x184139D00")]
		public static T Deserialize<T>(string json, DAMCVOXAVIT resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4139F50", Offset = "0x4138B50", VA = "0x184139F50")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4139E80", Offset = "0x4138A80", VA = "0x184139E80")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, DAMCVOXAVIT resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4139530", Offset = "0x4138130", VA = "0x184139530")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4139750", Offset = "0x4138350", VA = "0x184139750")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, DAMCVOXAVIT resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5500", Offset = "0xA3E4100", VA = "0x18A3E5500")]
		public static byte[] GZCWOYIYPXG(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5930", Offset = "0xA3E4530", VA = "0x18A3E5930")]
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
			[Cpp2IlInjected.Address(RVA = "0xF519C0", Offset = "0xF505C0", VA = "0x180F519C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD6F0", Offset = "0xA3DC2F0", VA = "0x18A3DD6F0")]
		public void ZPRGVMWZVON(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA3DCF40", Offset = "0xA3DBB40", VA = "0x18A3DCF40")]
		public static byte[] PALYWSCLOYA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC710", Offset = "0xA3DB310", VA = "0x18A3DC710")]
		public static byte[] IWDWOCDYQTG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC830", Offset = "0xA3DB430", VA = "0x18A3DC830")]
		public static byte[] MZONKNCPPLQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD420", Offset = "0xA3DC020", VA = "0x18A3DD420")]
		public static byte[] UXBTEUKJUZU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2AC0320", Offset = "0x2ABEF20", VA = "0x182AC0320")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD070", Offset = "0xA3DBC70", VA = "0x18A3DD070")]
		public ArraySegment<byte> RFEOBKQVUCK()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD230", Offset = "0xA3DBE30", VA = "0x18A3DD230")]
		public byte[] TQDVZYWKNBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD3C0", Offset = "0xA3DBFC0", VA = "0x18A3DD3C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC470", Offset = "0xA3DB070", VA = "0x18A3DC470")]
		public void BOYVYBEOXUG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1150", Offset = "0xA3CFD50", VA = "0x18A3D1150")]
		public void YATYGCKFXDN(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD690", Offset = "0xA3DC290", VA = "0x18A3DD690")]
		public void YATYGCKFXDN(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC4F0", Offset = "0xA3DB0F0", VA = "0x18A3DC4F0")]
		public void COSLPYNLOTP(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x50F3420", Offset = "0x50F2020", VA = "0x1850F3420")]
		public void EWGJYZORQFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x50F3560", Offset = "0x50F2160", VA = "0x1850F3560")]
		public void ZDVSVIROIDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x50F3510", Offset = "0x50F2110", VA = "0x1850F3510")]
		public void WYDISBLMBVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x50B9A40", Offset = "0x50B8640", VA = "0x1850B9A40")]
		public void JFEVLLQCQPV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x50F34C0", Offset = "0x50F20C0", VA = "0x1850F34C0")]
		public void WVNPDKTPZFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x50F3470", Offset = "0x50F2070", VA = "0x1850F3470")]
		public void USIKBLHLQRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD110", Offset = "0xA3DBD10", VA = "0x18A3DD110")]
		public void RHEIQXUDGZD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC650", Offset = "0xA3DB250", VA = "0x18A3DC650")]
		public void GLLOYVLGAFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x50B9A90", Offset = "0x50B8690", VA = "0x1850B9A90")]
		public void UQGTNQKXKVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8CA1F80", Offset = "0x8CA0B80", VA = "0x188CA1F80")]
		public void VSYNUZKVTPT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD5A0", Offset = "0xA3DC1A0", VA = "0x18A3DD5A0")]
		public void VECXDAXSHSX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD1B0", Offset = "0xA3DBDB0", VA = "0x18A3DD1B0")]
		public void SNKEXRHLSLU(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC480", Offset = "0xA3DB080", VA = "0x18A3DC480")]
		public void CFHFTKPLEPP(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC950", Offset = "0xA3DB550", VA = "0x18A3DC950")]
		public void OCQFJZTXFII(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC400", Offset = "0xA3DB000", VA = "0x18A3DC400")]
		public void ABHVMPDRZXQ(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC5A0", Offset = "0xA3DB1A0", VA = "0x18A3DC5A0")]
		public void GGDFOQEYZMR(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC530", Offset = "0xA3DB130", VA = "0x18A3DC530")]
		public void DWHRYDZTFHM(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC6A0", Offset = "0xA3DB2A0", VA = "0x18A3DC6A0")]
		public void IDPTWURPAXR(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD620", Offset = "0xA3DC220", VA = "0x18A3DD620")]
		public void VFAFGXITUMB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD040", Offset = "0xA3DBC40", VA = "0x18A3DD040")]
		public void QAXVHFICSMS(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC9C0", Offset = "0xA3DB5C0", VA = "0x18A3DC9C0")]
		public void OYTEHOFQISW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA3DC5D0", Offset = "0xA3DB1D0", VA = "0x18A3DC5D0")]
		private static bool GGWQMLFQQNG(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD020", Offset = "0xA3DBC20", VA = "0x18A3DD020")]
		private static byte PISLHJJNXJQ(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA3D10B0", Offset = "0xA3CFCB0", VA = "0x18A3D10B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E67460", Offset = "0x7E66060", VA = "0x187E67460")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private BOSJKBCESTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E67C80", Offset = "0x7E66880", VA = "0x187E67C80")]
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
			[Cpp2IlInjected.Address(RVA = "0xA3DF310", Offset = "0xA3DDF10", VA = "0x18A3DF310")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private YFCWTPBHYQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E742D0", Offset = "0x7E72ED0", VA = "0x187E742D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private JTAXZIGBSBT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8D20", Offset = "0xA3D7920", VA = "0x18A3D8D20")]
		public static void SIFQFAPRLAF(params DAMCVOXAVIT[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8C40", Offset = "0xA3D7840", VA = "0x18A3D8C40")]
		public static void SIFQFAPRLAF(params FTQIUPACWHD[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA3D89C0", Offset = "0xA3D75C0", VA = "0x18A3D89C0")]
		public static void QZQMCVKKUYT(FTQIUPACWHD[] a, DAMCVOXAVIT[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E66010", Offset = "0x7E64C10", VA = "0x187E66010")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private TZJEGYDIGNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3E2A10", Offset = "0xA3E1610", VA = "0x18A3E2A10")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3E29D0", Offset = "0xA3E15D0", VA = "0x18A3E29D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E73BA0", Offset = "0x7E727A0", VA = "0x187E73BA0")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private RSTPNRZRMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E7F310", Offset = "0x7E7DF10", VA = "0x187E7F310")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private NIKLXSRRLMR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E63E10", Offset = "0x7E62A10", VA = "0x187E63E10")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E7E6A0", Offset = "0x7E7D2A0", VA = "0x187E7E6A0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private ZFIKTGSCFLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E6EDE0", Offset = "0x7E6D9E0", VA = "0x187E6EDE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E698F0", Offset = "0x7E684F0", VA = "0x187E698F0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private RDLBUKLIQAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E66830", Offset = "0x7E65430", VA = "0x187E66830")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E68BD0", Offset = "0x7E677D0", VA = "0x187E68BD0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private IVRFGESEPWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E6CA10", Offset = "0x7E6B610", VA = "0x187E6CA10")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E801D0", Offset = "0x7E7EDD0", VA = "0x187E801D0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private SMXEEBKVYDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E600D0", Offset = "0x7E5ECD0", VA = "0x187E600D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E78E60", Offset = "0x7E77A60", VA = "0x187E78E60")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private WRKOFHXVRPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E6E080", Offset = "0x7E6CC80", VA = "0x187E6E080")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E73170", Offset = "0x7E71D70", VA = "0x187E73170")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private YUERIHRJQIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E7C230", Offset = "0x7E7AE30", VA = "0x187E7C230")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E77010", Offset = "0x7E75C10", VA = "0x187E77010")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private JEQTSYEHESH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E69490", Offset = "0x7E68090", VA = "0x187E69490")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E65BB0", Offset = "0x7E647B0", VA = "0x187E65BB0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private AWDASIWFECJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E6DA80", Offset = "0x7E6C680", VA = "0x187E6DA80")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E6C5B0", Offset = "0x7E6B1B0", VA = "0x187E6C5B0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private SOJEEDDBDYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E7DAE0", Offset = "0x7E7C6E0", VA = "0x187E7DAE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E73010", Offset = "0x7E71C10", VA = "0x187E73010")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private JHLIFCYVJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E7E3A0", Offset = "0x7E7CFA0", VA = "0x187E7E3A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E6A340", Offset = "0x7E68F40", VA = "0x187E6A340")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private QGJXXJIVLAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E6D050", Offset = "0x7E6BC50", VA = "0x187E6D050")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E7CDB0", Offset = "0x7E7B9B0", VA = "0x187E7CDB0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		private VGEOCQDOXDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x336A6E0", Offset = "0x33692E0", VA = "0x18336A6E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x73AC8A0", Offset = "0x73AB4A0", VA = "0x1873AC8A0")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x73AC5B0", Offset = "0x73AB1B0", VA = "0x1873AC5B0")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x73AC810", Offset = "0x73AB410", VA = "0x1873AC810")]
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
		[Cpp2IlInjected.Address(RVA = "0x668DE80", Offset = "0x668CA80", VA = "0x18668DE80")]
		public JNDZRHAEOYY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x668DAD0", Offset = "0x668C6D0", VA = "0x18668DAD0")]
		public a[] FSVKAQWAHGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x668DD00", Offset = "0x668C900", VA = "0x18668DD00")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
				[DebuggerHidden]
				public QTDPWIJFRFI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "7")]
				[DebuggerHidden]
				private void PEABEYBFILL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xA3DE920", Offset = "0xA3DD520", VA = "0x18A3DE920", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xA3DE8E0", Offset = "0xA3DD4E0", VA = "0x18A3DE8E0", Slot = "10")]
				[DebuggerHidden]
				private void KTHCATTUQZC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xA3DE840", Offset = "0xA3DD440", VA = "0x18A3DE840", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<QCUOBCAAXYO> ZYCODUSOIBG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0xA3DE840", Offset = "0xA3DD440", VA = "0x18A3DE840", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA3DE6E0", Offset = "0xA3DD2E0", VA = "0x18A3DE6E0")]
			public QCUOBCAAXYO(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA3DE120", Offset = "0xA3DCD20", VA = "0x18A3DE120")]
			public QCUOBCAAXYO Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA3DE320", Offset = "0xA3DCF20", VA = "0x18A3DE320")]
			public QCUOBCAAXYO Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA3DE3B0", Offset = "0xA3DCFB0", VA = "0x18A3DE3B0")]
			public QCUOBCAAXYO WSOVNWLHWKE(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA3DE520", Offset = "0xA3DD120", VA = "0x18A3DE520")]
			internal static int ZEWQILPOBHP(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA3DE380", Offset = "0xA3DCF80", VA = "0x18A3DE380", Slot = "4")]
			public int CompareTo(QCUOBCAAXYO other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xA3DE5B0", Offset = "0xA3DD1B0", VA = "0x18A3DE5B0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87430", VA = "0x180D88830", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA3D3B90", Offset = "0xA3D2790", VA = "0x18A3D3B90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1D02EC0", Offset = "0x1D01AC0", VA = "0x181D02EC0")]
			[DebuggerHidden]
			public BHNCOYLJVZC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xA3D4120", Offset = "0xA3D2D20", VA = "0x18A3D4120", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xA3D3CC0", Offset = "0xA3D28C0", VA = "0x18A3D3CC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xA3D42C0", Offset = "0xA3D2EC0", VA = "0x18A3D42C0")]
			private void SYBUDUAVPHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA3D4270", Offset = "0xA3D2E70", VA = "0x18A3D4270")]
			private void SXLZLZTDMZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA3D3C80", Offset = "0xA3D2880", VA = "0x18A3D3C80", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xA3D3BE0", Offset = "0xA3D27E0", VA = "0x18A3D3BE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> LIWFJBPWEJQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xA3D3BE0", Offset = "0xA3D27E0", VA = "0x18A3D3BE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3D8810", Offset = "0xA3D7410", VA = "0x18A3D8810")]
		public IWXXPKAIOHU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7FC0", Offset = "0xA3D6BC0", VA = "0x18A3D7FC0")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8700", Offset = "0xA3D7300", VA = "0x18A3D8700")]
		public bool XXTFUCBFMWE(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D84E0", Offset = "0xA3D70E0", VA = "0x18A3D84E0")]
		public bool KAPYJGGLHZX([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8670", Offset = "0xA3D7270", VA = "0x18A3D8670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D81A0", Offset = "0xA3D6DA0", VA = "0x18A3D81A0")]
		private static void BNKMEFXPNUP(IEnumerable<QCUOBCAAXYO> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8480", Offset = "0xA3D7080", VA = "0x18A3D8480", Slot = "5")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8480", Offset = "0xA3D7080", VA = "0x18A3D8480", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA3D85F0", Offset = "0xA3D71F0", VA = "0x18A3D85F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3DD920", Offset = "0xA3DC520", VA = "0x18A3DD920")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DDAD0", Offset = "0xA3DC6D0", VA = "0x18A3DDAD0")]
		public static ulong YNJQWKSFLWG(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class ZOBCOVTPSON
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E50F0", Offset = "0xA3E3CF0", VA = "0x18A3E50F0")]
		public static void BOYVYBEOXUG(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5230", Offset = "0xA3E3E30", VA = "0x18A3E5230")]
		public static void DTCLZVHUUSO(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5350", Offset = "0xA3E3F50", VA = "0x18A3E5350")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B661D0", Offset = "0x5B64DD0", VA = "0x185B661D0", Slot = "3")]
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
				[Cpp2IlInjected.Address(RVA = "0xD88830", Offset = "0xD87430", VA = "0x180D88830", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x64D0210", Offset = "0x64CEE10", VA = "0x1864D0210", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public TOKOGRCFVHL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x7A93290", Offset = "0x7A91E90", VA = "0x187A93290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6382C20", Offset = "0x6381820", VA = "0x186382C20")]
		public GJAZTNDCOEJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6382B30", Offset = "0x6381730", VA = "0x186382B30")]
		public GJAZTNDCOEJ(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x636FDE0", Offset = "0x636E9E0", VA = "0x18636FDE0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x637BCF0", Offset = "0x637A8F0", VA = "0x18637BCF0")]
		private bool TGUQGNFSDNT(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6382900", Offset = "0x6381500", VA = "0x186382900")]
		public bool XXTFUCBFMWE([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6371E20", Offset = "0x6370A20", VA = "0x186371E20")]
		private static ulong RDQINKRNWMA([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6371600", Offset = "0x6370200", VA = "0x186371600")]
		private static ulong RDQINKRNWMA([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6370E50", Offset = "0x636FA50", VA = "0x186370E50")]
		private static int DYHMBHBQQKM(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6370E80", Offset = "0x636FA80", VA = "0x186370E80", Slot = "4")]
		[IteratorStateMachine(typeof(GJAZTNDCOEJ<>.TOKOGRCFVHL))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6371170", Offset = "0x636FD70", VA = "0x186371170", Slot = "5")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class YUSZSNVMGXG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x41337B0", Offset = "0x41323B0", VA = "0x1841337B0")]
		public static Func<a> FCDBGKKNOUO<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x41338A0", Offset = "0x41324A0", VA = "0x1841338A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3D6020", Offset = "0xA3D4C20", VA = "0x18A3D6020")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6030", Offset = "0xA3D4C30", VA = "0x18A3D6030")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5630", Offset = "0xA3D4230", VA = "0x18A3D5630")]
		private static byte QWUXDBCZCPZ(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0CB0", Offset = "0xA3CF8B0", VA = "0x18A3D0CB0")]
		private static byte TMXDXPOKJRN(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D56D0", Offset = "0xA3D42D0", VA = "0x18A3D56D0")]
		public void SQIRBZBNMTZ(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class WQVHUIFMQBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E26E0", Offset = "0xA3E12E0", VA = "0x18A3E26E0")]
		public static bool VOJPVMUFSBP(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2750", Offset = "0xA3E1350", VA = "0x18A3E2750")]
		public static bool ZCKOIPCTLCM(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1D50", Offset = "0xA3E0950", VA = "0x18A3E1D50")]
		public static sbyte JLPJIIAADLV([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E26F0", Offset = "0xA3E12F0", VA = "0x18A3E26F0")]
		public static short VXOTNNBTSKS([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1B20", Offset = "0xA3E0720", VA = "0x18A3E1B20")]
		public static int IYZEXPSYLZC([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1F20", Offset = "0xA3E0B20", VA = "0x18A3E1F20")]
		public static long OYDDYJJBHIL([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA3E23A0", Offset = "0xA3E0FA0", VA = "0x18A3E23A0")]
		public static bool RPDDHHHFIMA(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2620", Offset = "0xA3E1220", VA = "0x18A3E2620")]
		public static byte TSTMKJJZOGS([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1DB0", Offset = "0xA3E09B0", VA = "0x18A3E1DB0")]
		public static ushort MEXSHCNGMSP([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA3E27C0", Offset = "0xA3E13C0", VA = "0x18A3E27C0")]
		public static uint ZHYGVHHQDTT([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA3E22F0", Offset = "0xA3E0EF0", VA = "0x18A3E22F0")]
		public static ulong RJVDVVPNALI([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA3E21A0", Offset = "0xA3E0DA0", VA = "0x18A3E21A0")]
		public static bool RDBANDGTVTV(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1B80", Offset = "0xA3E0780", VA = "0x18A3E1B80")]
		public static bool JLHEMNPLICD(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1E10", Offset = "0xA3E0A10", VA = "0x18A3E1E10")]
		public static bool MHXNYYLSDTB(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2820", Offset = "0xA3E1420", VA = "0x18A3E2820")]
		public static bool ZMDHGBKTIDX(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2530", Offset = "0xA3E1130", VA = "0x18A3E2530")]
		public static float SWKJZCTJFKA([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E19D0", Offset = "0xA3E05D0", VA = "0x18A3E19D0")]
		public static bool HMQLUZJZQKB(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1A30", Offset = "0xA3E0630", VA = "0x18A3E1A30")]
		public static double IGVWFQGZTKR([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2680", Offset = "0xA3E1280", VA = "0x18A3E2680")]
		public static bool TWFMGDNTYUU(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1610", Offset = "0xA3D0210", VA = "0x18A3D1610")]
		public static int GGDFOQEYZMR(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1D70", Offset = "0xA3D0970", VA = "0x18A3D1D70")]
		public static int QAXVHFICSMS(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1FD0", Offset = "0xA3E0BD0", VA = "0x18A3E1FD0")]
		public static bool QMNAEQAXVXO([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class ZUOUZTOVACX
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6420", Offset = "0xA3E5020", VA = "0x18A3E6420")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3D2B60", Offset = "0xA3D1760", VA = "0x18A3D2B60")]
		public static void AMWTCLCPSIB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2AF0", Offset = "0xA3D16F0", VA = "0x18A3D2AF0")]
		public static void AMRMFEISIWS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2A80", Offset = "0xA3D1680", VA = "0x18A3D2A80")]
		public static void AMMFHXOUZLJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2A10", Offset = "0xA3D1610", VA = "0x18A3D2A10")]
		public static void AMGYKQUXQAA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA3D29A0", Offset = "0xA3D15A0", VA = "0x18A3D29A0")]
		public static void AMBRNKBAGOR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2930", Offset = "0xA3D1530", VA = "0x18A3D2930")]
		public static void ALWKQDHCXDI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3580", Offset = "0xA3D2180", VA = "0x18A3D3580")]
		public static void YGCIMNHIKKS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D35F0", Offset = "0xA3D21F0", VA = "0x18A3D35F0")]
		public static void YGHPJUBFTWB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3490", Offset = "0xA3D2090", VA = "0x18A3D3490")]
		public static void YFRURZTNROA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3500", Offset = "0xA3D2100", VA = "0x18A3D3500")]
		public static void YFXBPGNLAZJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3760", Offset = "0xA3D2360", VA = "0x18A3D3760")]
		public static void YGXKBOIXWEC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D37E0", Offset = "0xA3D23E0", VA = "0x18A3D37E0")]
		public static void YHCQYVCVFPL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3660", Offset = "0xA3D2260", VA = "0x18A3D3660")]
		public static void YGMWHAVDDHK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA3D36E0", Offset = "0xA3D22E0", VA = "0x18A3D36E0")]
		public static void YGSDEHPAMST(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3390", Offset = "0xA3D1F90", VA = "0x18A3D3390")]
		public static void YEMFILEDMXY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3410", Offset = "0xA3D2010", VA = "0x18A3D3410")]
		public static void YERMFRYAWJH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA3D31F0", Offset = "0xA3D1DF0", VA = "0x18A3D31F0")]
		public static void RFLDNUZFUSJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3170", Offset = "0xA3D1D70", VA = "0x18A3D3170")]
		public static void RFFWQOFILHA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA3D30F0", Offset = "0xA3D1CF0", VA = "0x18A3D30F0")]
		public static void RFAPTHLLBVR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3070", Offset = "0xA3D1C70", VA = "0x18A3D3070")]
		public static void REVIWARNSKI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2FF0", Offset = "0xA3D1BF0", VA = "0x18A3D2FF0")]
		public static void REQBYTXQIYZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2F60", Offset = "0xA3D1B60", VA = "0x18A3D2F60")]
		public static void REKVBNDSZNQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2ED0", Offset = "0xA3D1AD0", VA = "0x18A3D2ED0")]
		public static void REFOEGJVQCH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2E40", Offset = "0xA3D1A40", VA = "0x18A3D2E40")]
		public static void REAHGZPYGQY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3300", Offset = "0xA3D1F00", VA = "0x18A3D3300")]
		public static void RHBGRXCKSFD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3270", Offset = "0xA3D1E70", VA = "0x18A3D3270")]
		public static void RGVZUQINITU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2D20", Offset = "0xA3D1920", VA = "0x18A3D2D20")]
		public static void KETYPCRDFAA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2DB0", Offset = "0xA3D19B0", VA = "0x18A3D2DB0")]
		public static void KEZFMJLAOLJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2CB0", Offset = "0xA3D18B0", VA = "0x18A3D2CB0")]
		public static void ANMNUFKHUQC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2C40", Offset = "0xA3D1840", VA = "0x18A3D2C40")]
		public static void ANHGWYQKLET(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2BD0", Offset = "0xA3D17D0", VA = "0x18A3D2BD0")]
		public static void ANBZZRWNBTK(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class IBGZLTFRYGX
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7420", Offset = "0xA3D6020", VA = "0x18A3D7420")]
		public static void AMBRNKBAGOR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA3D73B0", Offset = "0xA3D5FB0", VA = "0x18A3D73B0")]
		public static void ALWKQDHCXDI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7C70", Offset = "0xA3D6870", VA = "0x18A3D7C70")]
		public static void YGCIMNHIKKS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7CE0", Offset = "0xA3D68E0", VA = "0x18A3D7CE0")]
		public static void YGHPJUBFTWB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7B90", Offset = "0xA3D6790", VA = "0x18A3D7B90")]
		public static void YFRURZTNROA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7C00", Offset = "0xA3D6800", VA = "0x18A3D7C00")]
		public static void YFXBPGNLAZJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7E40", Offset = "0xA3D6A40", VA = "0x18A3D7E40")]
		public static void YGXKBOIXWEC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7EB0", Offset = "0xA3D6AB0", VA = "0x18A3D7EB0")]
		public static void YHCQYVCVFPL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7D50", Offset = "0xA3D6950", VA = "0x18A3D7D50")]
		public static void YGMWHAVDDHK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7DC0", Offset = "0xA3D69C0", VA = "0x18A3D7DC0")]
		public static void YGSDEHPAMST(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7A90", Offset = "0xA3D6690", VA = "0x18A3D7A90")]
		public static void YEMFILEDMXY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7B10", Offset = "0xA3D6710", VA = "0x18A3D7B10")]
		public static void YERMFRYAWJH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7910", Offset = "0xA3D6510", VA = "0x18A3D7910")]
		public static void RFLDNUZFUSJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7890", Offset = "0xA3D6490", VA = "0x18A3D7890")]
		public static void RFFWQOFILHA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7810", Offset = "0xA3D6410", VA = "0x18A3D7810")]
		public static void RFAPTHLLBVR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7790", Offset = "0xA3D6390", VA = "0x18A3D7790")]
		public static void REVIWARNSKI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7710", Offset = "0xA3D6310", VA = "0x18A3D7710")]
		public static void REQBYTXQIYZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7690", Offset = "0xA3D6290", VA = "0x18A3D7690")]
		public static void REKVBNDSZNQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7610", Offset = "0xA3D6210", VA = "0x18A3D7610")]
		public static void REFOEGJVQCH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7590", Offset = "0xA3D6190", VA = "0x18A3D7590")]
		public static void REAHGZPYGQY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7A10", Offset = "0xA3D6610", VA = "0x18A3D7A10")]
		public static void RHBGRXCKSFD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7990", Offset = "0xA3D6590", VA = "0x18A3D7990")]
		public static void RGVZUQINITU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7490", Offset = "0xA3D6090", VA = "0x18A3D7490")]
		public static void KETYPCRDFAA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7510", Offset = "0xA3D6110", VA = "0x18A3D7510")]
		public static void KEZFMJLAOLJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2CB0", Offset = "0xA3D18B0", VA = "0x18A3D2CB0")]
		public static void ANMNUFKHUQC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2C40", Offset = "0xA3D1840", VA = "0x18A3D2C40")]
		public static void ANHGWYQKLET(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2BD0", Offset = "0xA3D17D0", VA = "0x18A3D2BD0")]
		public static void ANBZZRWNBTK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2B60", Offset = "0xA3D1760", VA = "0x18A3D2B60")]
		public static void AMWTCLCPSIB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2AF0", Offset = "0xA3D16F0", VA = "0x18A3D2AF0")]
		public static void AMRMFEISIWS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2A80", Offset = "0xA3D1680", VA = "0x18A3D2A80")]
		public static void AMMFHXOUZLJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2A10", Offset = "0xA3D1610", VA = "0x18A3D2A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3E7F70", Offset = "0xA3E6B70", VA = "0x18A3E7F70")]
		public static void YATYGCKFXDN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7EE0", Offset = "0xA3E6AE0", VA = "0x18A3E7EE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B67710", Offset = "0x2B66310", VA = "0x182B67710")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA110", Offset = "0xA3E8D10", VA = "0x18A3EA110")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA070", Offset = "0xA3E8C70", VA = "0x18A3EA070")]
		public static DiyFp NDFBLMLLIBG(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9FE0", Offset = "0xA3E8BE0", VA = "0x18A3E9FE0")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA120", Offset = "0xA3E8D20", VA = "0x18A3EA120")]
		public static DiyFp TPVZOLFKNJA(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA080", Offset = "0xA3E8C80", VA = "0x18A3EA080")]
		public void OWMQPELAPEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA0C0", Offset = "0xA3E8CC0", VA = "0x18A3EA0C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xDA7AE0", Offset = "0xDA66E0", VA = "0x180DA7AE0")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA3D1150", Offset = "0xA3CFD50", VA = "0x18A3D1150")]
		public void LDRCVCQYFGS(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA3F79C0", Offset = "0xA3F65C0", VA = "0x18A3F79C0")]
		public void TDSUJNBWVJI(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA3F77A0", Offset = "0xA3F63A0", VA = "0x18A3F77A0")]
		public void NLCJPDWUIQS(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7820", Offset = "0xA3F6420", VA = "0x18A3F7820")]
		public void NLCJPDWUIQS(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7720", Offset = "0xA3F6320", VA = "0x18A3F7720")]
		public void GIOCSCRAQFG(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA3F78C0", Offset = "0xA3F64C0", VA = "0x18A3F78C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3FD100", Offset = "0xA3FBD00", VA = "0x18A3FD100")]
		private static byte[] FWNNSKPMQKU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA3FD9A0", Offset = "0xA3FC5A0", VA = "0x18A3FD9A0")]
		private static byte[] MZCHJIVFTQM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA3FDF00", Offset = "0xA3FCB00", VA = "0x18A3FDF00")]
		public static int SHZWPQEXDJR(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA3FE020", Offset = "0xA3FCC20", VA = "0x18A3FE020")]
		public static int SHZWPQEXDJR(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA3FD010", Offset = "0xA3FBC10", VA = "0x18A3FD010")]
		private static bool CIEQDIJXBOR(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA3FEB00", Offset = "0xA3FD700", VA = "0x18A3FEB00")]
		private static void ZQGUCYKALAR(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA3FE570", Offset = "0xA3FD170", VA = "0x18A3FE570")]
		private static bool UQATIZCDKWZ(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3FDA80", Offset = "0xA3FC680", VA = "0x18A3FDA80")]
		private static bool NGBZYXHTBPH(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA3FD6B0", Offset = "0xA3FC2B0", VA = "0x18A3FD6B0")]
		private static bool KIFIMJOZLFQ(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA3FE930", Offset = "0xA3FD530", VA = "0x18A3FE930")]
		private static bool WFRLCEPEQBB(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA3FD1D0", Offset = "0xA3FBDD0", VA = "0x18A3FD1D0")]
		private static bool JCPGGFTIGEC(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA3FCC70", Offset = "0xA3FB870", VA = "0x18A3FCC70")]
		private static void CEQNANPQQDI(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA3FE140", Offset = "0xA3FCD40", VA = "0x18A3FE140")]
		private static void SZFDIICEVNI(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA3FD7B0", Offset = "0xA3FC3B0", VA = "0x18A3FD7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3EA7E0", Offset = "0xA3E93E0", VA = "0x18A3EA7E0")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA740", Offset = "0xA3E9340", VA = "0x18A3EA740")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA320", Offset = "0xA3E8F20", VA = "0x18A3EA320")]
		public DiyFp OLRQSXBPVYY()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA620", Offset = "0xA3E9220", VA = "0x18A3EA620")]
		public DiyFp XRBAUCRREBB()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xEC8090", Offset = "0xEC6C90", VA = "0x180EC8090")]
		public ulong EPKJPDGBJAW()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA250", Offset = "0xA3E8E50", VA = "0x18A3EA250")]
		public double LYNVVELNLVG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA6A0", Offset = "0xA3E92A0", VA = "0x18A3EA6A0")]
		public double YWJGNRTLTWY()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA2D0", Offset = "0xA3E8ED0", VA = "0x18A3EA2D0")]
		public int MDFCBRKDJWP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA390", Offset = "0xA3E8F90", VA = "0x18A3EA390")]
		public ulong OMKKAFBBBET()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA300", Offset = "0xA3E8F00", VA = "0x18A3EA300")]
		public bool NVOTYDGKBCU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA230", Offset = "0xA3E8E30", VA = "0x18A3EA230")]
		public bool LCYINCICDJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA3C0", Offset = "0xA3E8FC0", VA = "0x18A3EA3C0")]
		public bool OXSATOSWZYB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA3F0", Offset = "0xA3E8FF0", VA = "0x18A3EA3F0")]
		public bool RDMNCQSFEYQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA210", Offset = "0xA3E8E10", VA = "0x18A3EA210")]
		public int IZSBBSQJQGN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA440", Offset = "0xA3E9040", VA = "0x18A3EA440")]
		public void UQAFJKUUSRF([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA1C0", Offset = "0xA3E8DC0", VA = "0x18A3EA1C0")]
		public bool HBDBEAQPUYR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4098CE0", Offset = "0x40978E0", VA = "0x184098CE0")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA420", Offset = "0xA3E9020", VA = "0x18A3EA420")]
		public static int UNRGVRYYECQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA580", Offset = "0xA3E9180", VA = "0x18A3EA580")]
		public static double VEFYCKVYYLG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA590", Offset = "0xA3E9190", VA = "0x18A3EA590")]
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
		[Cpp2IlInjected.Address(RVA = "0x185CDE0", Offset = "0x185B9E0", VA = "0x18185CDE0")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7570", Offset = "0xA3F6170", VA = "0x18A3F7570")]
		public DiyFp OLRQSXBPVYY()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF501A0", VA = "0x180F515A0")]
		public uint JTMTOVGSLAF()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7540", Offset = "0xA3F6140", VA = "0x18A3F7540")]
		public int MDFCBRKDJWP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA3F75D0", Offset = "0xA3F61D0", VA = "0x18A3F75D0")]
		public uint OMKKAFBBBET()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7560", Offset = "0xA3F6160", VA = "0x18A3F7560")]
		public bool NVOTYDGKBCU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA3F75F0", Offset = "0xA3F61F0", VA = "0x18A3F75F0")]
		public void UQAFJKUUSRF([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7500", Offset = "0xA3F6100", VA = "0x18A3F7500")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3E7ED0", Offset = "0xA3E6AD0", VA = "0x18A3E7ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3EDF10", Offset = "0xA3ECB10", VA = "0x18A3EDF10")]
		public static void TEYTNTDWNBH(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA3EDE40", Offset = "0xA3ECA40", VA = "0x18A3EDE40")]
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
			[Cpp2IlInjected.Address(RVA = "0xA3FB8F0", Offset = "0xA3FA4F0", VA = "0x18A3FB8F0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4EC17B0", Offset = "0x4EC03B0", VA = "0x184EC17B0")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D9DE10", Offset = "0x2D9CA10", VA = "0x182D9DE10")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB890", Offset = "0xA3FA490", VA = "0x18A3FB890")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F8BD0", Offset = "0xA3F77D0", VA = "0x18A3F8BD0")]
		private static byte[] NSIDEIVIFPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA3F84E0", Offset = "0xA3F70E0", VA = "0x18A3F84E0")]
		private static Vector HJLULWKCGWB(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8AF0", Offset = "0xA3F76F0", VA = "0x18A3F8AF0")]
		private static Vector LKMXXTCUDPJ(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7A40", Offset = "0xA3F6640", VA = "0x18A3F7A40")]
		private static void CRICBKEOPLA(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8F60", Offset = "0xA3F7B60", VA = "0x18A3F8F60")]
		private static void USITOEJEENZ(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9250", Offset = "0xA3F7E50", VA = "0x18A3F9250")]
		private static ulong WQBOPEUQIJU(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA3F85C0", Offset = "0xA3F71C0", VA = "0x18A3F85C0")]
		private static void ISJPICPPDEU(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8110", Offset = "0xA3F6D10", VA = "0x18A3F8110")]
		private static bool HALNADLEMWD(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8DD0", Offset = "0xA3F79D0", VA = "0x18A3F8DD0")]
		private static DiyFp QBMEMGLVDJW(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7AD0", Offset = "0xA3F66D0", VA = "0x18A3F7AD0")]
		private static bool DXMLJCXIPMK(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8CB0", Offset = "0xA3F78B0", VA = "0x18A3F8CB0")]
		private static bool OUSGZSWXZSW(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA3F89D0", Offset = "0xA3F75D0", VA = "0x18A3F89D0")]
		public static double? LCNXAWIEFQW(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA3F8700", Offset = "0xA3F7300", VA = "0x18A3F8700")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F0020", Offset = "0xA3EEC20", VA = "0x18A3F0020")]
		private static byte[] RFEOBKQVUCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA3EFD30", Offset = "0xA3EE930", VA = "0x18A3EFD30")]
		public static bool HMQLUZJZQKB(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA3F10F0", Offset = "0xA3EFCF0", VA = "0x18A3F10F0")]
		public static bool TWFMGDNTYUU(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA3EFE70", Offset = "0xA3EEA70", VA = "0x18A3EFE70")]
		private static bool JERMVPHOXWN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA3EF980", Offset = "0xA3EE580", VA = "0x18A3EF980")]
		private static bool DWZCFKOZQKU(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA3EFC50", Offset = "0xA3EE850", VA = "0x18A3EFC50")]
		private static bool GOOPAUOHQRD(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA3EFFB0", Offset = "0xA3EEBB0", VA = "0x18A3EFFB0")]
		private static bool OKFATYQCRWL(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA3F1230", Offset = "0xA3EFE30", VA = "0x18A3F1230")]
		private static double URQEDAHXGHU(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA3F0100", Offset = "0xA3EED00", VA = "0x18A3F0100")]
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
		[Cpp2IlInjected.Address(RVA = "0x194CB00", Offset = "0x194B700", VA = "0x18194CB00")]
		public JUXOAULBIPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
		public JUXOAULBIPU(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x66909B0", Offset = "0x668F5B0", VA = "0x1866909B0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6690380", Offset = "0x668EF80", VA = "0x186690380", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5110720", Offset = "0x510F320", VA = "0x185110720", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x51102D0", Offset = "0x510EED0", VA = "0x1851102D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x194CB00", Offset = "0x194B700", VA = "0x18194CB00")]
		public EBSYDKWIMJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
		public EBSYDKWIMJX(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x5B34A30", Offset = "0x5B33630", VA = "0x185B34A30", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5B32810", Offset = "0x5B31410", VA = "0x185B32810", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class OEYCPIUWIVB<a, b, c, d> : SIWYLIGCSZE<d>, FTQIUPACWHD where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x72A5490", Offset = "0x72A4090", VA = "0x1872A5490", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x72A3680", Offset = "0x72A2280", VA = "0x1872A3680", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected OEYCPIUWIVB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class OFYLBQQJDZU<a, b, c> : OEYCPIUWIVB<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x511FED0", Offset = "0x511EAD0", VA = "0x18511FED0", Slot = "6")]
		protected override IEnumerator<a> KOPILVVEUSX(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected OFYLBQQJDZU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class OGDRYXKGNLD<a, b> : OFYLBQQJDZU<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52F60", VA = "0x180D54360", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class CURNIDPDHPZ<a, b> : OGDRYXKGNLD<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x50DF8E0", Offset = "0x50DE4E0", VA = "0x1850DF8E0", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x50DF780", Offset = "0x50DE380", VA = "0x1850DF780", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class YCFIUGTYVWS<a> : OEYCPIUWIVB<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x51091A0", Offset = "0x5107DA0", VA = "0x1851091A0", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52F60", VA = "0x180D54360", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5107090", Offset = "0x5105C90", VA = "0x185107090", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5109280", Offset = "0x5107E80", VA = "0x185109280", Slot = "6")]
		protected override LinkedList<a>.Enumerator KOPILVVEUSX(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class FSDYKXWLZXJ<a> : OEYCPIUWIVB<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x50C28E0", Offset = "0x50C14E0", VA = "0x1850C28E0", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x50D83B0", Offset = "0x50D6FB0", VA = "0x1850D83B0", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x50D84C0", Offset = "0x50D70C0", VA = "0x1850D84C0", Slot = "6")]
		protected override Queue<a>.Enumerator KOPILVVEUSX(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52F60", VA = "0x180D54360", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class PHZNJIKDTKZ<a> : OEYCPIUWIVB<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5106F00", Offset = "0x5105B00", VA = "0x185106F00", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5107020", Offset = "0x5105C20", VA = "0x185107020", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x73CA840", Offset = "0x73C9440", VA = "0x1873CA840", Slot = "6")]
		protected override Stack<a>.Enumerator KOPILVVEUSX(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x73CA6E0", Offset = "0x73C92E0", VA = "0x1873CA6E0", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class CCWKVJANHGZ<a> : OEYCPIUWIVB<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x50D8370", Offset = "0x50D6F70", VA = "0x1850D8370", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52F60", VA = "0x180D54360", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x50D8410", Offset = "0x50D7010", VA = "0x1850D8410", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x50D8470", Offset = "0x50D7070", VA = "0x1850D8470", Slot = "6")]
		protected override HashSet<a>.Enumerator KOPILVVEUSX(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x50D8570", Offset = "0x50D7170", VA = "0x1850D8570")]
		public CCWKVJANHGZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class MRIZIRBPOTF<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5106F00", Offset = "0x5105B00", VA = "0x185106F00", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C2A0", Offset = "0x6F1AEA0", VA = "0x186F1C2A0", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C330", Offset = "0x6F1AF30", VA = "0x186F1C330", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class AKIALGTZETW<a> : OFYLBQQJDZU<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x50C28E0", Offset = "0x50C14E0", VA = "0x1850C28E0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x50D83B0", Offset = "0x50D6FB0", VA = "0x1850D83B0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52F60", VA = "0x180D54360", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class DUNRGYGRTRO<a> : OFYLBQQJDZU<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x50C28E0", Offset = "0x50C14E0", VA = "0x1850C28E0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x50D83B0", Offset = "0x50D6FB0", VA = "0x1850D83B0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52F60", VA = "0x180D54360", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class XVBXFQKYPWK<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5106EE0", Offset = "0x5105AE0", VA = "0x185106EE0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5107020", Offset = "0x5105C20", VA = "0x185107020", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5107000", Offset = "0x5105C00", VA = "0x185107000", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5107050", Offset = "0x5105C50", VA = "0x185107050")]
		public XVBXFQKYPWK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class ERWVWGVHYIO<a, b> : SIWYLIGCSZE<IGrouping<a, b>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5B45D70", Offset = "0x5B44970", VA = "0x185B45D70", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5B45A20", Offset = "0x5B44620", VA = "0x185B45A20", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class NQDEVIZKWIX<a, b> : SIWYLIGCSZE<ILookup<a, b>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7159200", Offset = "0x7157E00", VA = "0x187159200", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7158EC0", Offset = "0x7157AC0", VA = "0x187158EC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4EBE720", Offset = "0x4EBD320", VA = "0x184EBE720", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6292A30", Offset = "0x6291630", VA = "0x186292A30")]
		public FVHJGXOXKNV(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x62929A0", Offset = "0x62915A0", VA = "0x1862929A0", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6292A10", Offset = "0x6291610", VA = "0x186292A10", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x744BDC0", Offset = "0x744A9C0", VA = "0x18744BDC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public UVCUHMQAMTS(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7D550D0", Offset = "0x7D53CD0", VA = "0x187D550D0", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7D551C0", Offset = "0x7D53DC0", VA = "0x187D551C0", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7D551C0", Offset = "0x7D53DC0", VA = "0x187D551C0", Slot = "7")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class EIESYTSNAXX<a> : SIWYLIGCSZE<a>, FTQIUPACWHD where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5B3F020", Offset = "0x5B3DC20", VA = "0x185B3F020", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5B3EE10", Offset = "0x5B3DA10", VA = "0x185B3EE10", Slot = "5")]
		public a Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F2040", Offset = "0xA3F0C40", VA = "0x18A3F2040", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA3F1E40", Offset = "0xA3F0A40", VA = "0x18A3F1E40", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F48D0", Offset = "0xA3F34D0", VA = "0x18A3F48D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA3F46D0", Offset = "0xA3F32D0", VA = "0x18A3F46D0", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3FB080", Offset = "0xA3F9C80", VA = "0x18A3FB080", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA3FAE80", Offset = "0xA3F9A80", VA = "0x18A3FAE80", Slot = "5")]
		public IList Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public UYZNONPCLXJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class ISQLWTQOINY<a> : OGDRYXKGNLD<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x50C28E0", Offset = "0x50C14E0", VA = "0x1850C28E0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x50C2A30", Offset = "0x50C1630", VA = "0x1850C2A30", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class XIGAZGFZNKI<a> : OFYLBQQJDZU<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x50C28E0", Offset = "0x50C14E0", VA = "0x1850C28E0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x50C2A30", Offset = "0x50C1630", VA = "0x1850C2A30", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x50C29C0", Offset = "0x50C15C0", VA = "0x1850C29C0", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class QYSJHRFJWOO<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x76472B0", Offset = "0x7645EB0", VA = "0x1876472B0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5107020", Offset = "0x5105C20", VA = "0x185107020", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x76473F0", Offset = "0x7645FF0", VA = "0x1876473F0", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x76474D0", Offset = "0x76460D0", VA = "0x1876474D0")]
		public QYSJHRFJWOO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class UKMSYSBEUGG<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x76472B0", Offset = "0x7645EB0", VA = "0x1876472B0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5107020", Offset = "0x5105C20", VA = "0x185107020", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5107000", Offset = "0x5105C00", VA = "0x185107000", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x5107050", Offset = "0x5105C50", VA = "0x185107050")]
		public UKMSYSBEUGG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class XVQZNSOIQOC<a> : OFYLBQQJDZU<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x50D8290", Offset = "0x50D6E90", VA = "0x1850D8290", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52F60", VA = "0x180D54360", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5107090", Offset = "0x5105C90", VA = "0x185107090", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class HEQUEODQKFY<a> : OGDRYXKGNLD<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x50C28E0", Offset = "0x50C14E0", VA = "0x1850C28E0", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x50D83B0", Offset = "0x50D6FB0", VA = "0x1850D83B0", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class HSBYWJLGWOZ<a> : OGDRYXKGNLD<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x50C28E0", Offset = "0x50C14E0", VA = "0x1850C28E0", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x50D83B0", Offset = "0x50D6FB0", VA = "0x1850D83B0", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class OQAGYTZJWUE<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5106F00", Offset = "0x5105B00", VA = "0x185106F00", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x5107020", Offset = "0x5105C20", VA = "0x185107020", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x72BD420", Offset = "0x72BC020", VA = "0x1872BD420", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F1500", Offset = "0xA3F0100", VA = "0x18A3F1500")]
		public static DateTime CZBFEHPZCNX(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA3F1C90", Offset = "0xA3F0890", VA = "0x18A3F1C90")]
		public static bool UGHJVOYTCCQ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA3F1A00", Offset = "0xA3F0600", VA = "0x18A3F1A00")]
		public static bool SLLITBHFYMQ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA3F17F0", Offset = "0xA3F03F0", VA = "0x18A3F17F0")]
		public static bool SLLITBHFYMQ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA3F15C0", Offset = "0xA3F01C0", VA = "0x18A3F15C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA400400", Offset = "0xA3FF000", VA = "0x18A400400", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA400280", Offset = "0xA3FEE80", VA = "0x18A400280", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA3FFE80", Offset = "0xA3FEA80", VA = "0x18A3FFE80")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3EBAF0", Offset = "0xA3EA6F0", VA = "0x18A3EBAF0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA3EBA80", Offset = "0xA3EA680", VA = "0x18A3EBA80", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB6A0", Offset = "0xA3EA2A0", VA = "0x18A3EB6A0")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F2830", Offset = "0xA3F1430", VA = "0x18A3F2830", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA3F23C0", Offset = "0xA3F0FC0", VA = "0x18A3F23C0", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA3F2440", Offset = "0xA3F1040", VA = "0x18A3F2440")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public LWOTWDLHJTL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class YRZVEYBVBPW<a, b, c, d, e> : SIWYLIGCSZE<e>, FTQIUPACWHD where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x511AD60", Offset = "0x5119960", VA = "0x18511AD60", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5118A50", Offset = "0x5117650", VA = "0x185118A50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected YRZVEYBVBPW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class YSFCCEVSLBF<a, b, c, d> : YRZVEYBVBPW<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x511FED0", Offset = "0x511EAD0", VA = "0x18511FED0", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> KOPILVVEUSX(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected YSFCCEVSLBF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class YTFKOMRFGFY<a, b, c> : YSFCCEVSLBF<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52F60", VA = "0x180D54360", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class QFFOMNTBXSE<a, b> : YRZVEYBVBPW<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x75B88A0", Offset = "0x75B74A0", VA = "0x1875B88A0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52F60", VA = "0x180D54360", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x75B89E0", Offset = "0x75B75E0", VA = "0x1875B89E0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x75B8BC0", Offset = "0x75B77C0", VA = "0x1875B8BC0", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator KOPILVVEUSX(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6928250", Offset = "0x6926E50", VA = "0x186928250")]
		public QFFOMNTBXSE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class HTUCKIMVSZC<a, b, c> : YTFKOMRFGFY<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x647FA50", Offset = "0x647E650", VA = "0x18647FA50", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x647FC30", Offset = "0x647E830", VA = "0x18647FC30", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class TOBOOWOHLGF<a, b> : YSFCCEVSLBF<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x5B45860", Offset = "0x5B44460", VA = "0x185B45860", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x5B459C0", Offset = "0x5B445C0", VA = "0x185B459C0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52F60", VA = "0x180D54360", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class EQRIYKCIEML<a, b> : YTFKOMRFGFY<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x5B45860", Offset = "0x5B44460", VA = "0x185B45860", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x5B459C0", Offset = "0x5B445C0", VA = "0x185B459C0", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class WKXUFCTVGHJ<a, b> : YRZVEYBVBPW<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5B45860", Offset = "0x5B44460", VA = "0x185B45860", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52F60", VA = "0x180D54360", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x5B459C0", Offset = "0x5B445C0", VA = "0x185B459C0", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x85D24B0", Offset = "0x85D10B0", VA = "0x1885D24B0", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator KOPILVVEUSX(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class KGDVETFFARI<a, b> : YSFCCEVSLBF<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x5B45860", Offset = "0x5B44460", VA = "0x185B45860", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x679DF80", Offset = "0x679CB80", VA = "0x18679DF80", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x679DFF0", Offset = "0x679CBF0", VA = "0x18679DFF0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class TTRTTWFGOSH<a, b> : YSFCCEVSLBF<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7A95800", Offset = "0x7A94400", VA = "0x187A95800", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD54360", Offset = "0xD52F60", VA = "0x180D54360", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7A95840", Offset = "0x7A94440", VA = "0x187A95840", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x50D8570", Offset = "0x50D7170", VA = "0x1850D8570")]
		public TTRTTWFGOSH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class VUUTMEFNWXV<a, b> : YTFKOMRFGFY<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7E5DDE0", Offset = "0x7E5C9E0", VA = "0x187E5DDE0", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5B459C0", Offset = "0x5B445C0", VA = "0x185B459C0", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class AMUPBFVWXRD<a> : SIWYLIGCSZE<a>, FTQIUPACWHD where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x71C7D10", Offset = "0x71C6910", VA = "0x1871C7D10", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x71C7AE0", Offset = "0x71C66E0", VA = "0x1871C7AE0", Slot = "5")]
		public a Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F5620", Offset = "0xA3F4220", VA = "0x18A3F5620", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5440", Offset = "0xA3F4040", VA = "0x18A3F5440", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public OKJJYNQBJIP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class ZEIJJVOQRQR
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA3FF660", Offset = "0xA3FE260", VA = "0x18A3FF660")]
		public static object NDYJBYOQEKR(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA3FEE40", Offset = "0xA3FDA40", VA = "0x18A3FEE40")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public LZUZORPWDSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x68B57B0", Offset = "0x68B43B0", VA = "0x1868B57B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public MAAGLYJTNDX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x6EB7200", Offset = "0x6EB5E00", VA = "0x186EB7200")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public LZKLUECBKVW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x687C7C0", Offset = "0x687B3C0", VA = "0x18687C7C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public LZPSRKVYUHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x68B3CD0", Offset = "0x68B28D0", VA = "0x1868B3CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EDBCC0", Offset = "0x4EDA8C0", VA = "0x184EDBCC0")]
		static BCNCIISCJMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x4EDFE60", Offset = "0x4EDEA60", VA = "0x184EDFE60")]
		public BCNCIISCJMG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x4EC9150", Offset = "0x4EC7D50", VA = "0x184EC9150", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x4EC5800", Offset = "0x4EC4400", VA = "0x184EC5800", Slot = "5")]
		public a Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x4EC8160", Offset = "0x4EC6D60", VA = "0x184EC8160", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, a b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x4ECA3C0", Offset = "0x4EC8FC0", VA = "0x184ECA3C0", Slot = "7")]
		public a UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class SQMCJSOUFWW<a> : SIWYLIGCSZE<a[,]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x792DD40", Offset = "0x792C940", VA = "0x18792DD40", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x792D9B0", Offset = "0x792C5B0", VA = "0x18792D9B0", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public SQMCJSOUFWW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class EKZGYWDPDFO<a> : SIWYLIGCSZE<a[,,]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5B431A0", Offset = "0x5B41DA0", VA = "0x185B431A0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5B42CD0", Offset = "0x5B418D0", VA = "0x185B42CD0", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public EKZGYWDPDFO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class MJTNKZFFIUQ<a> : SIWYLIGCSZE<a[,,,]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F0E160", Offset = "0x6F0CD60", VA = "0x186F0E160", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F0DB60", Offset = "0x6F0C760", VA = "0x186F0DB60", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public MJTNKZFFIUQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class PYLZZAJYZTA<a> : SIWYLIGCSZE<a?>, FTQIUPACWHD where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x73D3920", Offset = "0x73D2520", VA = "0x1873D3920", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x73D3670", Offset = "0x73D2270", VA = "0x1873D3670", Slot = "5")]
		public a? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFAC80", Offset = "0xCF9880", VA = "0x180CFAC80")]
		public IGFYBIBAAWY(SIWYLIGCSZE<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6590330", Offset = "0x658EF30", VA = "0x186590330", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x658F080", Offset = "0x658DC80", VA = "0x18658F080", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3FA6F0", Offset = "0xA3F92F0", VA = "0x18A3FA6F0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA5D0", Offset = "0xA3F91D0", VA = "0x18A3FA5D0", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA5E0", Offset = "0xA3F91E0", VA = "0x18A3FA5E0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, sbyte b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA780", Offset = "0xA3F9380", VA = "0x18A3FA780", Slot = "7")]
		public sbyte UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F5E50", Offset = "0xA3F4A50", VA = "0x18A3F5E50", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5C80", Offset = "0xA3F4880", VA = "0x18A3F5C80", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5CF0", Offset = "0xA3F48F0", VA = "0x18A3F5CF0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, sbyte? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA3F5F40", Offset = "0xA3F4B40", VA = "0x18A3F5F40", Slot = "7")]
		public sbyte? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3FABE0", Offset = "0xA3F97E0", VA = "0x18A3FABE0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA3FAAA0", Offset = "0xA3F96A0", VA = "0x18A3FAAA0", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F4550", Offset = "0xA3F3150", VA = "0x18A3F4550", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4430", Offset = "0xA3F3030", VA = "0x18A3F4430", Slot = "5")]
		public short Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4440", Offset = "0xA3F3040", VA = "0x18A3F4440", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, short b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA3F45E0", Offset = "0xA3F31E0", VA = "0x18A3F45E0", Slot = "7")]
		public short UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3ED4C0", Offset = "0xA3EC0C0", VA = "0x18A3ED4C0", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED2F0", Offset = "0xA3EBEF0", VA = "0x18A3ED2F0", Slot = "5")]
		public short? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED360", Offset = "0xA3EBF60", VA = "0x18A3ED360", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, short? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED5B0", Offset = "0xA3EC1B0", VA = "0x18A3ED5B0", Slot = "7")]
		public short? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3ED830", Offset = "0xA3EC430", VA = "0x18A3ED830", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED6F0", Offset = "0xA3EC2F0", VA = "0x18A3ED6F0", Slot = "5")]
		public short[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3EF3E0", Offset = "0xA3EDFE0", VA = "0x18A3EF3E0", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA3EF2C0", Offset = "0xA3EDEC0", VA = "0x18A3EF2C0", Slot = "5")]
		public int Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA3EF2D0", Offset = "0xA3EDED0", VA = "0x18A3EF2D0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, int b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA3EF470", Offset = "0xA3EE070", VA = "0x18A3EF470", Slot = "7")]
		public int UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3ECDB0", Offset = "0xA3EB9B0", VA = "0x18A3ECDB0", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA3ECBE0", Offset = "0xA3EB7E0", VA = "0x18A3ECBE0", Slot = "5")]
		public int? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA3ECC50", Offset = "0xA3EB850", VA = "0x18A3ECC50", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, int? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA3ECEA0", Offset = "0xA3EBAA0", VA = "0x18A3ECEA0", Slot = "7")]
		public int? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F9950", Offset = "0xA3F8550", VA = "0x18A3F9950", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9810", Offset = "0xA3F8410", VA = "0x18A3F9810", Slot = "5")]
		public int[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3E7220", Offset = "0xA3E5E20", VA = "0x18A3E7220", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7140", Offset = "0xA3E5D40", VA = "0x18A3E7140", Slot = "5")]
		public long Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7150", Offset = "0xA3E5D50", VA = "0x18A3E7150", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, long b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7280", Offset = "0xA3E5E80", VA = "0x18A3E7280", Slot = "7")]
		public long UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3E9BD0", Offset = "0xA3E87D0", VA = "0x18A3E9BD0", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9A10", Offset = "0xA3E8610", VA = "0x18A3E9A10", Slot = "5")]
		public long? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9AA0", Offset = "0xA3E86A0", VA = "0x18A3E9AA0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, long? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9C90", Offset = "0xA3E8890", VA = "0x18A3E9C90", Slot = "7")]
		public long? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3EDC10", Offset = "0xA3EC810", VA = "0x18A3EDC10", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA3EDAD0", Offset = "0xA3EC6D0", VA = "0x18A3EDAD0", Slot = "5")]
		public long[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3E7D50", Offset = "0xA3E6950", VA = "0x18A3E7D50", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7C30", Offset = "0xA3E6830", VA = "0x18A3E7C30", Slot = "5")]
		public byte Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7C40", Offset = "0xA3E6840", VA = "0x18A3E7C40", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, byte b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7DE0", Offset = "0xA3E69E0", VA = "0x18A3E7DE0", Slot = "7")]
		public byte UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F6870", Offset = "0xA3F5470", VA = "0x18A3F6870", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA3F66A0", Offset = "0xA3F52A0", VA = "0x18A3F66A0", Slot = "5")]
		public byte? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6710", Offset = "0xA3F5310", VA = "0x18A3F6710", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, byte? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6960", Offset = "0xA3F5560", VA = "0x18A3F6960", Slot = "7")]
		public byte? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F6520", Offset = "0xA3F5120", VA = "0x18A3F6520", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6400", Offset = "0xA3F5000", VA = "0x18A3F6400", Slot = "5")]
		public ushort Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6410", Offset = "0xA3F5010", VA = "0x18A3F6410", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, ushort b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA3F65B0", Offset = "0xA3F51B0", VA = "0x18A3F65B0", Slot = "7")]
		public ushort UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3EC7C0", Offset = "0xA3EB3C0", VA = "0x18A3EC7C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA3EC5F0", Offset = "0xA3EB1F0", VA = "0x18A3EC5F0", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA3EC660", Offset = "0xA3EB260", VA = "0x18A3EC660", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, ushort? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA3EC8B0", Offset = "0xA3EB4B0", VA = "0x18A3EC8B0", Slot = "7")]
		public ushort? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3FBE50", Offset = "0xA3FAA50", VA = "0x18A3FBE50", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBD10", Offset = "0xA3FA910", VA = "0x18A3FBD10", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F94C0", Offset = "0xA3F80C0", VA = "0x18A3F94C0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA3F93A0", Offset = "0xA3F7FA0", VA = "0x18A3F93A0", Slot = "5")]
		public uint Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA3F93B0", Offset = "0xA3F7FB0", VA = "0x18A3F93B0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, uint b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9550", Offset = "0xA3F8150", VA = "0x18A3F9550", Slot = "7")]
		public uint UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3FB660", Offset = "0xA3FA260", VA = "0x18A3FB660", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB490", Offset = "0xA3FA090", VA = "0x18A3FB490", Slot = "5")]
		public uint? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB500", Offset = "0xA3FA100", VA = "0x18A3FB500", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, uint? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB750", Offset = "0xA3FA350", VA = "0x18A3FB750", Slot = "7")]
		public uint? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3EAD80", Offset = "0xA3E9980", VA = "0x18A3EAD80", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA3EAC40", Offset = "0xA3E9840", VA = "0x18A3EAC40", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3ECAD0", Offset = "0xA3EB6D0", VA = "0x18A3ECAD0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA3EC9F0", Offset = "0xA3EB5F0", VA = "0x18A3EC9F0", Slot = "5")]
		public ulong Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA3ECA00", Offset = "0xA3EB600", VA = "0x18A3ECA00", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, ulong b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xA3ECB30", Offset = "0xA3EB730", VA = "0x18A3ECB30", Slot = "7")]
		public ulong UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3E6DB0", Offset = "0xA3E59B0", VA = "0x18A3E6DB0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6BF0", Offset = "0xA3E57F0", VA = "0x18A3E6BF0", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6C80", Offset = "0xA3E5880", VA = "0x18A3E6C80", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, ulong? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6E70", Offset = "0xA3E5A70", VA = "0x18A3E6E70", Slot = "7")]
		public ulong? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F4200", Offset = "0xA3F2E00", VA = "0x18A3F4200", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA3F40C0", Offset = "0xA3F2CC0", VA = "0x18A3F40C0", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3FBC00", Offset = "0xA3FA800", VA = "0x18A3FBC00", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBB20", Offset = "0xA3FA720", VA = "0x18A3FBB20", Slot = "5")]
		public float Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBB30", Offset = "0xA3FA730", VA = "0x18A3FBB30", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, float b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBC60", Offset = "0xA3FA860", VA = "0x18A3FBC60", Slot = "7")]
		public float UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3FC5E0", Offset = "0xA3FB1E0", VA = "0x18A3FC5E0", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA3FC450", Offset = "0xA3FB050", VA = "0x18A3FC450", Slot = "5")]
		public float? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA3FC4C0", Offset = "0xA3FB0C0", VA = "0x18A3FC4C0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, float? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA3FC6A0", Offset = "0xA3FB2A0", VA = "0x18A3FC6A0", Slot = "7")]
		public float? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3E78A0", Offset = "0xA3E64A0", VA = "0x18A3E78A0", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7760", Offset = "0xA3E6360", VA = "0x18A3E7760", Slot = "5")]
		public float[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3FBA10", Offset = "0xA3FA610", VA = "0x18A3FBA10", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB930", Offset = "0xA3FA530", VA = "0x18A3FB930", Slot = "5")]
		public double Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB940", Offset = "0xA3FA540", VA = "0x18A3FB940", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, double b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBA70", Offset = "0xA3FA670", VA = "0x18A3FBA70", Slot = "7")]
		public double UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F7130", Offset = "0xA3F5D30", VA = "0x18A3F7130", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6F70", Offset = "0xA3F5B70", VA = "0x18A3F6F70", Slot = "5")]
		public double? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7000", Offset = "0xA3F5C00", VA = "0x18A3F7000", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, double? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA3F71F0", Offset = "0xA3F5DF0", VA = "0x18A3F71F0", Slot = "7")]
		public double? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3FC8F0", Offset = "0xA3FB4F0", VA = "0x18A3FC8F0", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA3FC7B0", Offset = "0xA3FB3B0", VA = "0x18A3FC7B0", Slot = "5")]
		public double[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F73F0", Offset = "0xA3F5FF0", VA = "0x18A3F73F0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7310", Offset = "0xA3F5F10", VA = "0x18A3F7310", Slot = "5")]
		public bool Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7320", Offset = "0xA3F5F20", VA = "0x18A3F7320", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, bool b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA3F7450", Offset = "0xA3F6050", VA = "0x18A3F7450", Slot = "7")]
		public bool UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3FC280", Offset = "0xA3FAE80", VA = "0x18A3FC280", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA3FC0F0", Offset = "0xA3FACF0", VA = "0x18A3FC0F0", Slot = "5")]
		public bool? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xA3FC160", Offset = "0xA3FAD60", VA = "0x18A3FC160", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, bool? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA3FC340", Offset = "0xA3FAF40", VA = "0x18A3FC340", Slot = "7")]
		public bool? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3EB310", Offset = "0xA3E9F10", VA = "0x18A3EB310", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA3EB1D0", Offset = "0xA3E9DD0", VA = "0x18A3EB1D0", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F6B10", Offset = "0xA3F5710", VA = "0x18A3F6B10", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6AA0", Offset = "0xA3F56A0", VA = "0x18A3F6AA0", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F52A0", Offset = "0xA3F3EA0", VA = "0x18A3F52A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA3F51D0", Offset = "0xA3F3DD0", VA = "0x18A3F51D0", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F4DF0", Offset = "0xA3F39F0", VA = "0x18A3F4DF0", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4D80", Offset = "0xA3F3980", VA = "0x18A3F4D80", Slot = "5")]
		public string Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4D90", Offset = "0xA3F3990", VA = "0x18A3F4D90", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, string b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4D80", Offset = "0xA3F3980", VA = "0x18A3F4D80", Slot = "7")]
		public string UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F61D0", Offset = "0xA3F4DD0", VA = "0x18A3F61D0", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6080", Offset = "0xA3F4C80", VA = "0x18A3F6080", Slot = "5")]
		public string[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3EEFB0", Offset = "0xA3EDBB0", VA = "0x18A3EEFB0", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA3EEF80", Offset = "0xA3EDB80", VA = "0x18A3EEF80", Slot = "5")]
		public char Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3FA930", Offset = "0xA3F9530", VA = "0x18A3FA930", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA870", Offset = "0xA3F9470", VA = "0x18A3FA870", Slot = "5")]
		public char? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3EA980", Offset = "0xA3E9580", VA = "0x18A3EA980", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA3EA7F0", Offset = "0xA3E93F0", VA = "0x18A3EA7F0", Slot = "5")]
		public char[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3E7510", Offset = "0xA3E6110", VA = "0x18A3E7510", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7330", Offset = "0xA3E5F30", VA = "0x18A3E7330", Slot = "5")]
		public Guid Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7390", Offset = "0xA3E5F90", VA = "0x18A3E7390", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, Guid b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7680", Offset = "0xA3E6280", VA = "0x18A3E7680", Slot = "7")]
		public Guid UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0x873F840", Offset = "0x873E440", VA = "0x18873F840")]
		public LGZZBEJMDPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xFE13B0", Offset = "0xFDFFB0", VA = "0x180FE13B0")]
		public LGZZBEJMDPZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA3EF730", Offset = "0xA3EE330", VA = "0x18A3EF730", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA3EF560", Offset = "0xA3EE160", VA = "0x18A3EF560", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F96C0", Offset = "0xA3F82C0", VA = "0x18A3F96C0", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9640", Offset = "0xA3F8240", VA = "0x18A3F9640", Slot = "5")]
		public Uri Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3E7010", Offset = "0xA3E5C10", VA = "0x18A3E7010", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6F90", Offset = "0xA3E5B90", VA = "0x18A3E6F90", Slot = "5")]
		public Version Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public BACTIQQTCAK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class PMEMPOFRJHW<a, b> : SIWYLIGCSZE<KeyValuePair<a, b>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x73CB620", Offset = "0x73CA220", VA = "0x1873CB620", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x73CB150", Offset = "0x73C9D50", VA = "0x1873CB150", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F2FD0", Offset = "0xA3F1BD0", VA = "0x18A3F2FD0", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA3F2F50", Offset = "0xA3F1B50", VA = "0x18A3F2F50", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F4FE0", Offset = "0xA3F3BE0", VA = "0x18A3F4FE0", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4EC0", Offset = "0xA3F3AC0", VA = "0x18A3F4EC0", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3ED2D0", Offset = "0xA3EBED0", VA = "0x18A3ED2D0")]
		public HNHWNRTEVHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x97043D0", Offset = "0x9702FD0", VA = "0x1897043D0")]
		public HNHWNRTEVHE(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA3ED0F0", Offset = "0xA3EBCF0", VA = "0x18A3ED0F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA3ECFE0", Offset = "0xA3EBBE0", VA = "0x18A3ECFE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F9CA0", Offset = "0xA3F88A0", VA = "0x18A3F9CA0", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9BF0", Offset = "0xA3F87F0", VA = "0x18A3F9BF0", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3E9E40", Offset = "0xA3E8A40", VA = "0x18A3E9E40", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA3E9DB0", Offset = "0xA3E89B0", VA = "0x18A3E9DB0", Slot = "5")]
		public Complex Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F6E70", Offset = "0xA3F5A70", VA = "0x18A3F6E70", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA3F6C40", Offset = "0xA3F5840", VA = "0x18A3F6C40", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public REFYSPUHCSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class JEFVNEDXVNJ<a> : SIWYLIGCSZE<Lazy<a>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x6686FE0", Offset = "0x6685BE0", VA = "0x186686FE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x6686E60", Offset = "0x6685A60", VA = "0x186686E60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3EF180", Offset = "0xA3EDD80", VA = "0x18A3EF180", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA3EF0D0", Offset = "0xA3EDCD0", VA = "0x18A3EF0D0", Slot = "5")]
		public Task Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public LAHSWZNPFEH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class GEZYKBESAHJ<a> : SIWYLIGCSZE<Task<a>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x63687B0", Offset = "0x63673B0", VA = "0x1863687B0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x6368640", Offset = "0x6367240", VA = "0x186368640", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class OHTMBYMOPZD<a> : SIWYLIGCSZE<ValueTask<a>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x72ABAC0", Offset = "0x72AA6C0", VA = "0x1872ABAC0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x72AB920", Offset = "0x72AA520", VA = "0x1872AB920", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x50C5220", Offset = "0x50C3E20", VA = "0x1850C5220", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x50C4F50", Offset = "0x50C3B50", VA = "0x1850C4F50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x50C6000", Offset = "0x50C4C00", VA = "0x1850C6000", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x50C5BE0", Offset = "0x50C47E0", VA = "0x1850C5BE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x50C89F0", Offset = "0x50C75F0", VA = "0x1850C89F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x50C8490", Offset = "0x50C7090", VA = "0x1850C8490", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x50C9720", Offset = "0x50C8320", VA = "0x1850C9720", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x50C9070", Offset = "0x50C7C70", VA = "0x1850C9070", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x50CA710", Offset = "0x50C9310", VA = "0x1850CA710", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x50C9F10", Offset = "0x50C8B10", VA = "0x1850C9F10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x50CB9F0", Offset = "0x50CA5F0", VA = "0x1850CB9F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x50CB060", Offset = "0x50C9C60", VA = "0x1850CB060", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x50CDBC0", Offset = "0x50CC7C0", VA = "0x1850CDBC0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x50CD0B0", Offset = "0x50CBCB0", VA = "0x1850CD0B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x50CF460", Offset = "0x50CE060", VA = "0x1850CF460", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x50CE7F0", Offset = "0x50CD3F0", VA = "0x1850CE7F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63DEC20", Offset = "0x63DD820", VA = "0x1863DEC20", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x63DE810", Offset = "0x63DD410", VA = "0x1863DE810", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63DE2C0", Offset = "0x63DCEC0", VA = "0x1863DE2C0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x63DDDE0", Offset = "0x63DC9E0", VA = "0x1863DDDE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63DD6F0", Offset = "0x63DC2F0", VA = "0x1863DD6F0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x63DD080", Offset = "0x63DBC80", VA = "0x1863DD080", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63DC7D0", Offset = "0x63DB3D0", VA = "0x1863DC7D0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x63DBFA0", Offset = "0x63DABA0", VA = "0x1863DBFA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63DB550", Offset = "0x63DA150", VA = "0x1863DB550", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x63DABA0", Offset = "0x63D97A0", VA = "0x1863DABA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63D9FA0", Offset = "0x63D8BA0", VA = "0x1863D9FA0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x63D93E0", Offset = "0x63D7FE0", VA = "0x1863D93E0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63D7860", Offset = "0x63D6460", VA = "0x1863D7860", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x63D6B00", Offset = "0x63D5700", VA = "0x1863D6B00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x63D5B20", Offset = "0x63D4720", VA = "0x1863D5B20", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x63D4C00", Offset = "0x63D3800", VA = "0x1863D4C00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3EB020", Offset = "0xA3E9C20", VA = "0x18A3EB020")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3E6A40", Offset = "0xA3E5640", VA = "0x18A3E6A40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3F30E0", Offset = "0xA3F1CE0", VA = "0x18A3F30E0")]
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
