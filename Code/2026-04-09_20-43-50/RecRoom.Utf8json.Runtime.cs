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
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD34A60", Offset = "0xD33A60", VA = "0x180D34A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DA6510", Offset = "0x3DA5510", VA = "0x183DA6510")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AED890", Offset = "0x3AEC890", VA = "0x183AED890")]
		public static SIWYLIGCSZE<a> EVFDGDBKNGX<a>(this DAMCVOXAVIT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA576430", Offset = "0xA575430", VA = "0x18A576430")]
		public static object DLEXLAFLEKL(this DAMCVOXAVIT a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA5763D0", Offset = "0xA5753D0", VA = "0x18A5763D0")]
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
				[Cpp2IlInjected.Address(RVA = "0xA575920", Offset = "0xA574920", VA = "0x18A575920")]
				public BRDCAVKNDPU(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xA575800", Offset = "0xA574800", VA = "0x18A575800")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5801C0", Offset = "0xA57F1C0", VA = "0x18A5801C0")]
			public void FLYXUGEVGZO([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA580080", Offset = "0xA57F080", VA = "0x18A580080")]
			public void FLYXUGEVGZO(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA580670", Offset = "0xA57F670", VA = "0x18A580670")]
			public ReadOnlySequence<byte> YZISAFOAUMH()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA5804C0", Offset = "0xA57F4C0", VA = "0x18A5804C0")]
			private void RXEQWLLIJTR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA5802D0", Offset = "0xA57F2D0", VA = "0x18A5802D0")]
			private void OHPJAPKTQYR([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA57D6E0", Offset = "0xA57C6E0", VA = "0x18A57D6E0")]
		public JsonReader([In] ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA57D570", Offset = "0xA57C570", VA = "0x18A57D570")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA57BDF0", Offset = "0xA57ADF0", VA = "0x18A57BDF0")]
		private JsonParsingException OPKLQCUPKHP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA57C8D0", Offset = "0xA57B8D0", VA = "0x18A57C8D0")]
		private JsonParsingException QMOEWITGZAA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA57AA90", Offset = "0xA579A90", VA = "0x18A57AA90")]
		public JsonToken CSNLQLJSGGI()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA57C9E0", Offset = "0xA57B9E0", VA = "0x18A57C9E0")]
		public void QNQPGLWUZNQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA57B530", Offset = "0xA57A530", VA = "0x18A57B530")]
		private bool KBZSGVXGJFW(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA57B590", Offset = "0xA57A590", VA = "0x18A57B590")]
		private bool KBZSGVXGJFW(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA57D0A0", Offset = "0xA57C0A0", VA = "0x18A57D0A0")]
		private void VNMGZQHFIRX(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA57B090", Offset = "0xA57A090", VA = "0x18A57B090")]
		public bool FNTSIVZMTSJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA57D560", Offset = "0xA57C560", VA = "0x18A57D560")]
		public void ZWUBWBKLEVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA57AED0", Offset = "0xA579ED0", VA = "0x18A57AED0")]
		public bool EAIEFSTWDEG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA57D200", Offset = "0xA57C200", VA = "0x18A57D200")]
		public void WWBEGQUCYUP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA57D550", Offset = "0xA57C550", VA = "0x18A57D550")]
		public void ZQAAKZLPFHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA57C6B0", Offset = "0xA57B6B0", VA = "0x18A57C6B0")]
		public bool PMXOTEGVQVE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA57C6A0", Offset = "0xA57B6A0", VA = "0x18A57C6A0")]
		public void PMUJMJSQICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA57CC80", Offset = "0xA57BC80", VA = "0x18A57CC80")]
		public void RWYKTWKRXNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA57D410", Offset = "0xA57C410", VA = "0x18A57D410")]
		public bool XZSEAACUZEZ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA57B6D0", Offset = "0xA57A6D0", VA = "0x18A57B6D0")]
		public bool KZFDBXNXHBK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA57A7C0", Offset = "0xA5797C0", VA = "0x18A57A7C0")]
		public bool CBJTASTWZYN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA57A6E0", Offset = "0xA5796E0", VA = "0x18A57A6E0")]
		public bool BZYSGTOCXIM(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA57C1B0", Offset = "0xA57B1B0", VA = "0x18A57C1B0")]
		private ReadOnlySequence<byte> PKTUJKMPITD()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA57A470", Offset = "0xA579470", VA = "0x18A57A470")]
		private ReadOnlySequence<byte> ABPPPBKKZRG()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA57CC90", Offset = "0xA57BC90", VA = "0x18A57CC90")]
		private void SSDGNPKZNXW(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA57D210", Offset = "0xA57C210", VA = "0x18A57D210")]
		private void XBGZLMVVDRR(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA57BB00", Offset = "0xA57AB00", VA = "0x18A57BB00")]
		private void OMFGSUQEZPQ(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA57B1F0", Offset = "0xA57A1F0", VA = "0x18A57B1F0")]
		private void ILLSEQHTFWN(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA572470", Offset = "0xA571470", VA = "0x18A572470")]
		private static int VPTVHUSHHSM(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA57B460", Offset = "0xA57A460", VA = "0x18A57B460")]
		public ReadOnlySequence<byte> KAYTKWXNXAU()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA57C700", Offset = "0xA57B700", VA = "0x18A57C700")]
		public string QFVYWTTUAVD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA57ACB0", Offset = "0xA579CB0", VA = "0x18A57ACB0")]
		public string DKNZYERCFAS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA57CF20", Offset = "0xA57BF20", VA = "0x18A57CF20")]
		public ReadOnlySequence<byte> TCHGRTDGGWM()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA57B5F0", Offset = "0xA57A5F0", VA = "0x18A57B5F0")]
		public ReadOnlySequence<byte> KSTVKDEVSUX()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA57C780", Offset = "0xA57B780", VA = "0x18A57C780")]
		public bool QMNAEQAXVXO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA57AF20", Offset = "0xA579F20", VA = "0x18A57AF20")]
		private void FJGQFMYCKNM(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA57ACA0", Offset = "0xA579CA0", VA = "0x18A57ACA0")]
		public void DCFGWKCJYXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA57A850", Offset = "0xA579850", VA = "0x18A57A850")]
		private void CKEDLYMMREB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA57B3B0", Offset = "0xA57A3B0", VA = "0x18A57B3B0")]
		public sbyte JLPJIIAADLV()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA57D150", Offset = "0xA57C150", VA = "0x18A57D150")]
		public short VXOTNNBTSKS()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA57B300", Offset = "0xA57A300", VA = "0x18A57B300")]
		public int IYZEXPSYLZC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA57C140", Offset = "0xA57B140", VA = "0x18A57C140")]
		public long OYDDYJJBHIL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA57CFF0", Offset = "0xA57BFF0", VA = "0x18A57CFF0")]
		public byte TSTMKJJZOGS()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA57BA50", Offset = "0xA57AA50", VA = "0x18A57BA50")]
		public ushort MEXSHCNGMSP()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA57D4A0", Offset = "0xA57C4A0", VA = "0x18A57D4A0")]
		public uint ZHYGVHHQDTT()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA57CC10", Offset = "0xA57BC10", VA = "0x18A57CC10")]
		public ulong RJVDVVPNALI()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA57CE80", Offset = "0xA57BE80", VA = "0x18A57CE80")]
		public float SWKJZCTJFKA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA57B150", Offset = "0xA57A150", VA = "0x18A57B150")]
		public double IGVWFQGZTKR()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA57ACF0", Offset = "0xA579CF0", VA = "0x18A57ACF0")]
		public ReadOnlySequence<byte> DPZQMKWOFJY()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA57B7B0", Offset = "0xA57A7B0", VA = "0x18A57B7B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xFAFAD0", Offset = "0xFAEAD0", VA = "0x180FAFAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA57A410", Offset = "0xA579410", VA = "0x18A57A410")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA57A390", Offset = "0xA579390", VA = "0x18A57A390")]
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
			[Cpp2IlInjected.Address(RVA = "0xA576580", Offset = "0xA575580", VA = "0x18A576580")]
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
			[Cpp2IlInjected.Address(RVA = "0xA586CC0", Offset = "0xA585CC0", VA = "0x18A586CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA586920", Offset = "0xA585920", VA = "0x18A586920")]
		public static void AVULLZQETHJ(DAMCVOXAVIT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x41557A0", Offset = "0x41547A0", VA = "0x1841557A0")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4155630", Offset = "0x4154630", VA = "0x184155630")]
		public static byte[] Serialize<T>(T value, DAMCVOXAVIT resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4155C10", Offset = "0x4154C10", VA = "0x184155C10")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4155C90", Offset = "0x4154C90", VA = "0x184155C90")]
		public static string ToJsonString<T>(T value, DAMCVOXAVIT resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4155140", Offset = "0x4154140", VA = "0x184155140")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4154DA0", Offset = "0x4153DA0", VA = "0x184154DA0")]
		public static T Deserialize<T>(string json, DAMCVOXAVIT resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4154FF0", Offset = "0x4153FF0", VA = "0x184154FF0")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4154F20", Offset = "0x4153F20", VA = "0x184154F20")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, DAMCVOXAVIT resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x41545D0", Offset = "0x41535D0", VA = "0x1841545D0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x41547F0", Offset = "0x41537F0", VA = "0x1841547F0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, DAMCVOXAVIT resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA586990", Offset = "0xA585990", VA = "0x18A586990")]
		public static byte[] GZCWOYIYPXG(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA586DC0", Offset = "0xA585DC0", VA = "0x18A586DC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF6D330", Offset = "0xF6C330", VA = "0x180F6D330")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA57EB80", Offset = "0xA57DB80", VA = "0x18A57EB80")]
		public void ZPRGVMWZVON(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA57E3D0", Offset = "0xA57D3D0", VA = "0x18A57E3D0")]
		public static byte[] PALYWSCLOYA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA57DBA0", Offset = "0xA57CBA0", VA = "0x18A57DBA0")]
		public static byte[] IWDWOCDYQTG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA57DCC0", Offset = "0xA57CCC0", VA = "0x18A57DCC0")]
		public static byte[] MZONKNCPPLQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA57E8B0", Offset = "0xA57D8B0", VA = "0x18A57E8B0")]
		public static byte[] UXBTEUKJUZU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2AD63C0", Offset = "0x2AD53C0", VA = "0x182AD63C0")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA57E500", Offset = "0xA57D500", VA = "0x18A57E500")]
		public ArraySegment<byte> RFEOBKQVUCK()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA57E6C0", Offset = "0xA57D6C0", VA = "0x18A57E6C0")]
		public byte[] TQDVZYWKNBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA57E850", Offset = "0xA57D850", VA = "0x18A57E850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA57D900", Offset = "0xA57C900", VA = "0x18A57D900")]
		public void BOYVYBEOXUG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA5725D0", Offset = "0xA5715D0", VA = "0x18A5725D0")]
		public void YATYGCKFXDN(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA57EB20", Offset = "0xA57DB20", VA = "0x18A57EB20")]
		public void YATYGCKFXDN(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA57D980", Offset = "0xA57C980", VA = "0x18A57D980")]
		public void COSLPYNLOTP(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5143F10", Offset = "0x5142F10", VA = "0x185143F10")]
		public void EWGJYZORQFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5144050", Offset = "0x5143050", VA = "0x185144050")]
		public void ZDVSVIROIDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5144000", Offset = "0x5143000", VA = "0x185144000")]
		public void WYDISBLMBVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5108A00", Offset = "0x5107A00", VA = "0x185108A00")]
		public void JFEVLLQCQPV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5143FB0", Offset = "0x5142FB0", VA = "0x185143FB0")]
		public void WVNPDKTPZFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5143F60", Offset = "0x5142F60", VA = "0x185143F60")]
		public void USIKBLHLQRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA57E5A0", Offset = "0xA57D5A0", VA = "0x18A57E5A0")]
		public void RHEIQXUDGZD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA57DAE0", Offset = "0xA57CAE0", VA = "0x18A57DAE0")]
		public void GLLOYVLGAFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5108A50", Offset = "0x5107A50", VA = "0x185108A50")]
		public void UQGTNQKXKVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8E40830", Offset = "0x8E3F830", VA = "0x188E40830")]
		public void VSYNUZKVTPT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA57EA30", Offset = "0xA57DA30", VA = "0x18A57EA30")]
		public void VECXDAXSHSX(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA57E640", Offset = "0xA57D640", VA = "0x18A57E640")]
		public void SNKEXRHLSLU(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA57D910", Offset = "0xA57C910", VA = "0x18A57D910")]
		public void CFHFTKPLEPP(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA57DDE0", Offset = "0xA57CDE0", VA = "0x18A57DDE0")]
		public void OCQFJZTXFII(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA57D890", Offset = "0xA57C890", VA = "0x18A57D890")]
		public void ABHVMPDRZXQ(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA57DA30", Offset = "0xA57CA30", VA = "0x18A57DA30")]
		public void GGDFOQEYZMR(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA57D9C0", Offset = "0xA57C9C0", VA = "0x18A57D9C0")]
		public void DWHRYDZTFHM(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA57DB30", Offset = "0xA57CB30", VA = "0x18A57DB30")]
		public void IDPTWURPAXR(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA57EAB0", Offset = "0xA57DAB0", VA = "0x18A57EAB0")]
		public void VFAFGXITUMB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA57E4D0", Offset = "0xA57D4D0", VA = "0x18A57E4D0")]
		public void QAXVHFICSMS(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA57DE50", Offset = "0xA57CE50", VA = "0x18A57DE50")]
		public void OYTEHOFQISW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA57DA60", Offset = "0xA57CA60", VA = "0x18A57DA60")]
		private static bool GGWQMLFQQNG(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA57E4B0", Offset = "0xA57D4B0", VA = "0x18A57E4B0")]
		private static byte PISLHJJNXJQ(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA572530", Offset = "0xA571530", VA = "0x18A572530")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD63B0", Offset = "0x7FD53B0", VA = "0x187FD63B0")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private BOSJKBCESTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD6C00", Offset = "0x7FD5C00", VA = "0x187FD6C00")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5807A0", Offset = "0xA57F7A0", VA = "0x18A5807A0")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private YFCWTPBHYQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FE37A0", Offset = "0x7FE27A0", VA = "0x187FE37A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private JTAXZIGBSBT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA57A1A0", Offset = "0xA5791A0", VA = "0x18A57A1A0")]
		public static void SIFQFAPRLAF(params DAMCVOXAVIT[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA57A0C0", Offset = "0xA5790C0", VA = "0x18A57A0C0")]
		public static void SIFQFAPRLAF(params FTQIUPACWHD[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA579E40", Offset = "0xA578E40", VA = "0x18A579E40")]
		public static void QZQMCVKKUYT(FTQIUPACWHD[] a, DAMCVOXAVIT[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD4ED0", Offset = "0x7FD3ED0", VA = "0x187FD4ED0")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private TZJEGYDIGNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA583EA0", Offset = "0xA582EA0", VA = "0x18A583EA0")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA583E60", Offset = "0xA582E60", VA = "0x18A583E60")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FE3040", Offset = "0x7FE2040", VA = "0x187FE3040")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private RSTPNRZRMEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FEEC80", Offset = "0x7FEDC80", VA = "0x187FEEC80")]
			static VYHUHSXXKDJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly DAMCVOXAVIT UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private NIKLXSRRLMR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD2BF0", Offset = "0x7FD1BF0", VA = "0x187FD2BF0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FEDFB0", Offset = "0x7FECFB0", VA = "0x187FEDFB0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private ZFIKTGSCFLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FDE090", Offset = "0x7FDD090", VA = "0x187FDE090")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FD8940", Offset = "0x7FD7940", VA = "0x187FD8940")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private RDLBUKLIQAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD5730", Offset = "0x7FD4730", VA = "0x187FD5730")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FD7BC0", Offset = "0x7FD6BC0", VA = "0x187FD7BC0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private IVRFGESEPWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FDBBC0", Offset = "0x7FDABC0", VA = "0x187FDBBC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FEFBB0", Offset = "0x7FEEBB0", VA = "0x187FEFBB0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private SMXEEBKVYDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FCED40", Offset = "0x7FCDD40", VA = "0x187FCED40")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FE8520", Offset = "0x7FE7520", VA = "0x187FE8520")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private WRKOFHXVRPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FDD2C0", Offset = "0x7FDC2C0", VA = "0x187FDD2C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FE25D0", Offset = "0x7FE15D0", VA = "0x187FE25D0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private YUERIHRJQIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FEBA40", Offset = "0x7FEAA40", VA = "0x187FEBA40")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FE6600", Offset = "0x7FE5600", VA = "0x187FE6600")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private JEQTSYEHESH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FD84C0", Offset = "0x7FD74C0", VA = "0x187FD84C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FD4A50", Offset = "0x7FD3A50", VA = "0x187FD4A50")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private AWDASIWFECJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FDCCA0", Offset = "0x7FDBCA0", VA = "0x187FDCCA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FDB740", Offset = "0x7FDA740", VA = "0x187FDB740")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private SOJEEDDBDYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FED3A0", Offset = "0x7FEC3A0", VA = "0x187FED3A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FE2460", Offset = "0x7FE1460", VA = "0x187FE2460")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private JHLIFCYVJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FEDCA0", Offset = "0x7FECCA0", VA = "0x187FEDCA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FD93F0", Offset = "0x7FD83F0", VA = "0x187FD93F0")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private QGJXXJIVLAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7FDC230", Offset = "0x7FDB230", VA = "0x187FDC230")]
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
				[Cpp2IlInjected.Address(RVA = "0x7FEC600", Offset = "0x7FEB600", VA = "0x187FEC600")]
				static VYHUHSXXKDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly DAMCVOXAVIT UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly DAMCVOXAVIT[] OJMVGDMTQRZ;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			private DQSIZCTSEUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		private VGEOCQDOXDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x337FF60", Offset = "0x337EF60", VA = "0x18337FF60", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x74E07F0", Offset = "0x74DF7F0", VA = "0x1874E07F0")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x74E04F0", Offset = "0x74DF4F0", VA = "0x1874E04F0")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x74E0760", Offset = "0x74DF760", VA = "0x1874E0760")]
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
		[Cpp2IlInjected.Address(RVA = "0x676B030", Offset = "0x676A030", VA = "0x18676B030")]
		public JNDZRHAEOYY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x676AC70", Offset = "0x6769C70", VA = "0x18676AC70")]
		public a[] FSVKAQWAHGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x676AEB0", Offset = "0x6769EB0", VA = "0x18676AEB0")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
				[DebuggerHidden]
				public QTDPWIJFRFI(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "7")]
				[DebuggerHidden]
				private void PEABEYBFILL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xA57FDB0", Offset = "0xA57EDB0", VA = "0x18A57FDB0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xA57FD70", Offset = "0xA57ED70", VA = "0x18A57FD70", Slot = "10")]
				[DebuggerHidden]
				private void KTHCATTUQZC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xA57FCD0", Offset = "0xA57ECD0", VA = "0x18A57FCD0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<QCUOBCAAXYO> ZYCODUSOIBG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0xA57FCD0", Offset = "0xA57ECD0", VA = "0x18A57FCD0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA57FB70", Offset = "0xA57EB70", VA = "0x18A57FB70")]
			public QCUOBCAAXYO(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA57F5B0", Offset = "0xA57E5B0", VA = "0x18A57F5B0")]
			public QCUOBCAAXYO Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA57F7B0", Offset = "0xA57E7B0", VA = "0x18A57F7B0")]
			public QCUOBCAAXYO Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA57F840", Offset = "0xA57E840", VA = "0x18A57F840")]
			public QCUOBCAAXYO WSOVNWLHWKE(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA57F9B0", Offset = "0xA57E9B0", VA = "0x18A57F9B0")]
			internal static int ZEWQILPOBHP(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA57F810", Offset = "0xA57E810", VA = "0x18A57F810", Slot = "4")]
			public int CompareTo(QCUOBCAAXYO other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xA57FA40", Offset = "0xA57EA40", VA = "0x18A57FA40")]
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
				[Cpp2IlInjected.Address(RVA = "0xDA3D20", Offset = "0xDA2D20", VA = "0x180DA3D20", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA575010", Offset = "0xA574010", VA = "0x18A575010", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1D1DB60", Offset = "0x1D1CB60", VA = "0x181D1DB60")]
			[DebuggerHidden]
			public BHNCOYLJVZC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xA5755A0", Offset = "0xA5745A0", VA = "0x18A5755A0", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xA575140", Offset = "0xA574140", VA = "0x18A575140", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xA575740", Offset = "0xA574740", VA = "0x18A575740")]
			private void SYBUDUAVPHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA5756F0", Offset = "0xA5746F0", VA = "0x18A5756F0")]
			private void SXLZLZTDMZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA575100", Offset = "0xA574100", VA = "0x18A575100", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xA575060", Offset = "0xA574060", VA = "0x18A575060", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> LIWFJBPWEJQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xA575060", Offset = "0xA574060", VA = "0x18A575060", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA579C90", Offset = "0xA578C90", VA = "0x18A579C90")]
		public IWXXPKAIOHU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA579440", Offset = "0xA578440", VA = "0x18A579440")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA579B80", Offset = "0xA578B80", VA = "0x18A579B80")]
		public bool XXTFUCBFMWE(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA579960", Offset = "0xA578960", VA = "0x18A579960")]
		public bool KAPYJGGLHZX([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA579AF0", Offset = "0xA578AF0", VA = "0x18A579AF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA579620", Offset = "0xA578620", VA = "0x18A579620")]
		private static void BNKMEFXPNUP(IEnumerable<QCUOBCAAXYO> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA579900", Offset = "0xA578900", VA = "0x18A579900", Slot = "5")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA579900", Offset = "0xA578900", VA = "0x18A579900", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA579A70", Offset = "0xA578A70", VA = "0x18A579A70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA57EDB0", Offset = "0xA57DDB0", VA = "0x18A57EDB0")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA57EF60", Offset = "0xA57DF60", VA = "0x18A57EF60")]
		public static ulong YNJQWKSFLWG(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class ZOBCOVTPSON
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA586580", Offset = "0xA585580", VA = "0x18A586580")]
		public static void BOYVYBEOXUG(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA5866C0", Offset = "0xA5856C0", VA = "0x18A5866C0")]
		public static void DTCLZVHUUSO(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA5867E0", Offset = "0xA5857E0", VA = "0x18A5867E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5BF9E10", Offset = "0x5BF8E10", VA = "0x185BF9E10", Slot = "3")]
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
				[Cpp2IlInjected.Address(RVA = "0xDA3D20", Offset = "0xDA2D20", VA = "0x180DA3D20", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x65A28E0", Offset = "0x65A18E0", VA = "0x1865A28E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
			[DebuggerHidden]
			public TOKOGRCFVHL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x7BEC8F0", Offset = "0x7BEB8F0", VA = "0x187BEC8F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x644A2D0", Offset = "0x64492D0", VA = "0x18644A2D0")]
		public GJAZTNDCOEJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x644A1E0", Offset = "0x64491E0", VA = "0x18644A1E0")]
		public GJAZTNDCOEJ(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6436ED0", Offset = "0x6435ED0", VA = "0x186436ED0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x64431B0", Offset = "0x64421B0", VA = "0x1864431B0")]
		private bool TGUQGNFSDNT(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6449F90", Offset = "0x6448F90", VA = "0x186449F90")]
		public bool XXTFUCBFMWE([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6438F80", Offset = "0x6437F80", VA = "0x186438F80")]
		private static ulong RDQINKRNWMA([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6438760", Offset = "0x6437760", VA = "0x186438760")]
		private static ulong RDQINKRNWMA([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6437F70", Offset = "0x6436F70", VA = "0x186437F70")]
		private static int DYHMBHBQQKM(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6437FA0", Offset = "0x6436FA0", VA = "0x186437FA0", Slot = "4")]
		[IteratorStateMachine(typeof(GJAZTNDCOEJ<>.TOKOGRCFVHL))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x64382B0", Offset = "0x64372B0", VA = "0x1864382B0", Slot = "5")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class YUSZSNVMGXG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x414E850", Offset = "0x414D850", VA = "0x18414E850")]
		public static Func<a> FCDBGKKNOUO<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x414E940", Offset = "0x414D940", VA = "0x18414E940")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5774A0", Offset = "0xA5764A0", VA = "0x18A5774A0")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA5774B0", Offset = "0xA5764B0", VA = "0x18A5774B0")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA576AB0", Offset = "0xA575AB0", VA = "0x18A576AB0")]
		private static byte QWUXDBCZCPZ(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA572130", Offset = "0xA571130", VA = "0x18A572130")]
		private static byte TMXDXPOKJRN(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA576B50", Offset = "0xA575B50", VA = "0x18A576B50")]
		public void SQIRBZBNMTZ(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class WQVHUIFMQBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA583B70", Offset = "0xA582B70", VA = "0x18A583B70")]
		public static bool VOJPVMUFSBP(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA583BE0", Offset = "0xA582BE0", VA = "0x18A583BE0")]
		public static bool ZCKOIPCTLCM(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA5831E0", Offset = "0xA5821E0", VA = "0x18A5831E0")]
		public static sbyte JLPJIIAADLV([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA583B80", Offset = "0xA582B80", VA = "0x18A583B80")]
		public static short VXOTNNBTSKS([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA582FB0", Offset = "0xA581FB0", VA = "0x18A582FB0")]
		public static int IYZEXPSYLZC([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA5833B0", Offset = "0xA5823B0", VA = "0x18A5833B0")]
		public static long OYDDYJJBHIL([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA583830", Offset = "0xA582830", VA = "0x18A583830")]
		public static bool RPDDHHHFIMA(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA583AB0", Offset = "0xA582AB0", VA = "0x18A583AB0")]
		public static byte TSTMKJJZOGS([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA583240", Offset = "0xA582240", VA = "0x18A583240")]
		public static ushort MEXSHCNGMSP([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA583C50", Offset = "0xA582C50", VA = "0x18A583C50")]
		public static uint ZHYGVHHQDTT([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA583780", Offset = "0xA582780", VA = "0x18A583780")]
		public static ulong RJVDVVPNALI([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA583630", Offset = "0xA582630", VA = "0x18A583630")]
		public static bool RDBANDGTVTV(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA583010", Offset = "0xA582010", VA = "0x18A583010")]
		public static bool JLHEMNPLICD(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA5832A0", Offset = "0xA5822A0", VA = "0x18A5832A0")]
		public static bool MHXNYYLSDTB(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA583CB0", Offset = "0xA582CB0", VA = "0x18A583CB0")]
		public static bool ZMDHGBKTIDX(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA5839C0", Offset = "0xA5829C0", VA = "0x18A5839C0")]
		public static float SWKJZCTJFKA([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA582E60", Offset = "0xA581E60", VA = "0x18A582E60")]
		public static bool HMQLUZJZQKB(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA582EC0", Offset = "0xA581EC0", VA = "0x18A582EC0")]
		public static double IGVWFQGZTKR([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA583B10", Offset = "0xA582B10", VA = "0x18A583B10")]
		public static bool TWFMGDNTYUU(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA572A90", Offset = "0xA571A90", VA = "0x18A572A90")]
		public static int GGDFOQEYZMR(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA5731F0", Offset = "0xA5721F0", VA = "0x18A5731F0")]
		public static int QAXVHFICSMS(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA583460", Offset = "0xA582460", VA = "0x18A583460")]
		public static bool QMNAEQAXVXO([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class ZUOUZTOVACX
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA5878B0", Offset = "0xA5868B0", VA = "0x18A5878B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA573FE0", Offset = "0xA572FE0", VA = "0x18A573FE0")]
		public static void AMWTCLCPSIB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA573F70", Offset = "0xA572F70", VA = "0x18A573F70")]
		public static void AMRMFEISIWS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA573F00", Offset = "0xA572F00", VA = "0x18A573F00")]
		public static void AMMFHXOUZLJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA573E90", Offset = "0xA572E90", VA = "0x18A573E90")]
		public static void AMGYKQUXQAA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA573E20", Offset = "0xA572E20", VA = "0x18A573E20")]
		public static void AMBRNKBAGOR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA573DB0", Offset = "0xA572DB0", VA = "0x18A573DB0")]
		public static void ALWKQDHCXDI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA574A00", Offset = "0xA573A00", VA = "0x18A574A00")]
		public static void YGCIMNHIKKS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA574A70", Offset = "0xA573A70", VA = "0x18A574A70")]
		public static void YGHPJUBFTWB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA574910", Offset = "0xA573910", VA = "0x18A574910")]
		public static void YFRURZTNROA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA574980", Offset = "0xA573980", VA = "0x18A574980")]
		public static void YFXBPGNLAZJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA574BE0", Offset = "0xA573BE0", VA = "0x18A574BE0")]
		public static void YGXKBOIXWEC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA574C60", Offset = "0xA573C60", VA = "0x18A574C60")]
		public static void YHCQYVCVFPL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA574AE0", Offset = "0xA573AE0", VA = "0x18A574AE0")]
		public static void YGMWHAVDDHK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA574B60", Offset = "0xA573B60", VA = "0x18A574B60")]
		public static void YGSDEHPAMST(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA574810", Offset = "0xA573810", VA = "0x18A574810")]
		public static void YEMFILEDMXY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA574890", Offset = "0xA573890", VA = "0x18A574890")]
		public static void YERMFRYAWJH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA574670", Offset = "0xA573670", VA = "0x18A574670")]
		public static void RFLDNUZFUSJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA5745F0", Offset = "0xA5735F0", VA = "0x18A5745F0")]
		public static void RFFWQOFILHA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA574570", Offset = "0xA573570", VA = "0x18A574570")]
		public static void RFAPTHLLBVR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA5744F0", Offset = "0xA5734F0", VA = "0x18A5744F0")]
		public static void REVIWARNSKI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA574470", Offset = "0xA573470", VA = "0x18A574470")]
		public static void REQBYTXQIYZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA5743E0", Offset = "0xA5733E0", VA = "0x18A5743E0")]
		public static void REKVBNDSZNQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA574350", Offset = "0xA573350", VA = "0x18A574350")]
		public static void REFOEGJVQCH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA5742C0", Offset = "0xA5732C0", VA = "0x18A5742C0")]
		public static void REAHGZPYGQY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA574780", Offset = "0xA573780", VA = "0x18A574780")]
		public static void RHBGRXCKSFD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA5746F0", Offset = "0xA5736F0", VA = "0x18A5746F0")]
		public static void RGVZUQINITU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA5741A0", Offset = "0xA5731A0", VA = "0x18A5741A0")]
		public static void KETYPCRDFAA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA574230", Offset = "0xA573230", VA = "0x18A574230")]
		public static void KEZFMJLAOLJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA574130", Offset = "0xA573130", VA = "0x18A574130")]
		public static void ANMNUFKHUQC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA5740C0", Offset = "0xA5730C0", VA = "0x18A5740C0")]
		public static void ANHGWYQKLET(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA574050", Offset = "0xA573050", VA = "0x18A574050")]
		public static void ANBZZRWNBTK(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class IBGZLTFRYGX
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA5788A0", Offset = "0xA5778A0", VA = "0x18A5788A0")]
		public static void AMBRNKBAGOR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA578830", Offset = "0xA577830", VA = "0x18A578830")]
		public static void ALWKQDHCXDI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA5790F0", Offset = "0xA5780F0", VA = "0x18A5790F0")]
		public static void YGCIMNHIKKS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA579160", Offset = "0xA578160", VA = "0x18A579160")]
		public static void YGHPJUBFTWB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA579010", Offset = "0xA578010", VA = "0x18A579010")]
		public static void YFRURZTNROA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA579080", Offset = "0xA578080", VA = "0x18A579080")]
		public static void YFXBPGNLAZJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA5792C0", Offset = "0xA5782C0", VA = "0x18A5792C0")]
		public static void YGXKBOIXWEC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA579330", Offset = "0xA578330", VA = "0x18A579330")]
		public static void YHCQYVCVFPL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA5791D0", Offset = "0xA5781D0", VA = "0x18A5791D0")]
		public static void YGMWHAVDDHK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA579240", Offset = "0xA578240", VA = "0x18A579240")]
		public static void YGSDEHPAMST(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA578F10", Offset = "0xA577F10", VA = "0x18A578F10")]
		public static void YEMFILEDMXY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA578F90", Offset = "0xA577F90", VA = "0x18A578F90")]
		public static void YERMFRYAWJH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA578D90", Offset = "0xA577D90", VA = "0x18A578D90")]
		public static void RFLDNUZFUSJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA578D10", Offset = "0xA577D10", VA = "0x18A578D10")]
		public static void RFFWQOFILHA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA578C90", Offset = "0xA577C90", VA = "0x18A578C90")]
		public static void RFAPTHLLBVR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA578C10", Offset = "0xA577C10", VA = "0x18A578C10")]
		public static void REVIWARNSKI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA578B90", Offset = "0xA577B90", VA = "0x18A578B90")]
		public static void REQBYTXQIYZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA578B10", Offset = "0xA577B10", VA = "0x18A578B10")]
		public static void REKVBNDSZNQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA578A90", Offset = "0xA577A90", VA = "0x18A578A90")]
		public static void REFOEGJVQCH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA578A10", Offset = "0xA577A10", VA = "0x18A578A10")]
		public static void REAHGZPYGQY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA578E90", Offset = "0xA577E90", VA = "0x18A578E90")]
		public static void RHBGRXCKSFD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA578E10", Offset = "0xA577E10", VA = "0x18A578E10")]
		public static void RGVZUQINITU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA578910", Offset = "0xA577910", VA = "0x18A578910")]
		public static void KETYPCRDFAA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA578990", Offset = "0xA577990", VA = "0x18A578990")]
		public static void KEZFMJLAOLJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA574130", Offset = "0xA573130", VA = "0x18A574130")]
		public static void ANMNUFKHUQC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5740C0", Offset = "0xA5730C0", VA = "0x18A5740C0")]
		public static void ANHGWYQKLET(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA574050", Offset = "0xA573050", VA = "0x18A574050")]
		public static void ANBZZRWNBTK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA573FE0", Offset = "0xA572FE0", VA = "0x18A573FE0")]
		public static void AMWTCLCPSIB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA573F70", Offset = "0xA572F70", VA = "0x18A573F70")]
		public static void AMRMFEISIWS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA573F00", Offset = "0xA572F00", VA = "0x18A573F00")]
		public static void AMMFHXOUZLJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA573E90", Offset = "0xA572E90", VA = "0x18A573E90")]
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
		[Cpp2IlInjected.Address(RVA = "0xA589400", Offset = "0xA588400", VA = "0x18A589400")]
		public static void YATYGCKFXDN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA589370", Offset = "0xA588370", VA = "0x18A589370")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B7D880", Offset = "0x2B7C880", VA = "0x182B7D880")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA58B5A0", Offset = "0xA58A5A0", VA = "0x18A58B5A0")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA58B500", Offset = "0xA58A500", VA = "0x18A58B500")]
		public static DiyFp NDFBLMLLIBG(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA58B470", Offset = "0xA58A470", VA = "0x18A58B470")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA58B5B0", Offset = "0xA58A5B0", VA = "0x18A58B5B0")]
		public static DiyFp TPVZOLFKNJA(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA58B510", Offset = "0xA58A510", VA = "0x18A58B510")]
		public void OWMQPELAPEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA58B550", Offset = "0xA58A550", VA = "0x18A58B550")]
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
		[Cpp2IlInjected.Address(RVA = "0xDC3070", Offset = "0xDC2070", VA = "0x180DC3070")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA5725D0", Offset = "0xA5715D0", VA = "0x18A5725D0")]
		public void LDRCVCQYFGS(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA598E70", Offset = "0xA597E70", VA = "0x18A598E70")]
		public void TDSUJNBWVJI(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA598C50", Offset = "0xA597C50", VA = "0x18A598C50")]
		public void NLCJPDWUIQS(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA598CD0", Offset = "0xA597CD0", VA = "0x18A598CD0")]
		public void NLCJPDWUIQS(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA598BD0", Offset = "0xA597BD0", VA = "0x18A598BD0")]
		public void GIOCSCRAQFG(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA598D70", Offset = "0xA597D70", VA = "0x18A598D70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59E5C0", Offset = "0xA59D5C0", VA = "0x18A59E5C0")]
		private static byte[] FWNNSKPMQKU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA59EE60", Offset = "0xA59DE60", VA = "0x18A59EE60")]
		private static byte[] MZCHJIVFTQM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA59F3C0", Offset = "0xA59E3C0", VA = "0x18A59F3C0")]
		public static int SHZWPQEXDJR(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA59F4E0", Offset = "0xA59E4E0", VA = "0x18A59F4E0")]
		public static int SHZWPQEXDJR(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA59E4D0", Offset = "0xA59D4D0", VA = "0x18A59E4D0")]
		private static bool CIEQDIJXBOR(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA59FFC0", Offset = "0xA59EFC0", VA = "0x18A59FFC0")]
		private static void ZQGUCYKALAR(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA59FA30", Offset = "0xA59EA30", VA = "0x18A59FA30")]
		private static bool UQATIZCDKWZ(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA59EF40", Offset = "0xA59DF40", VA = "0x18A59EF40")]
		private static bool NGBZYXHTBPH(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA59EB70", Offset = "0xA59DB70", VA = "0x18A59EB70")]
		private static bool KIFIMJOZLFQ(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA59FDF0", Offset = "0xA59EDF0", VA = "0x18A59FDF0")]
		private static bool WFRLCEPEQBB(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA59E690", Offset = "0xA59D690", VA = "0x18A59E690")]
		private static bool JCPGGFTIGEC(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA59E130", Offset = "0xA59D130", VA = "0x18A59E130")]
		private static void CEQNANPQQDI(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA59F600", Offset = "0xA59E600", VA = "0x18A59F600")]
		private static void SZFDIICEVNI(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA59EC70", Offset = "0xA59DC70", VA = "0x18A59EC70")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58BC70", Offset = "0xA58AC70", VA = "0x18A58BC70")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA58BBD0", Offset = "0xA58ABD0", VA = "0x18A58BBD0")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA58B7B0", Offset = "0xA58A7B0", VA = "0x18A58B7B0")]
		public DiyFp OLRQSXBPVYY()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA58BAB0", Offset = "0xA58AAB0", VA = "0x18A58BAB0")]
		public DiyFp XRBAUCRREBB()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xEE3900", Offset = "0xEE2900", VA = "0x180EE3900")]
		public ulong EPKJPDGBJAW()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA58B6E0", Offset = "0xA58A6E0", VA = "0x18A58B6E0")]
		public double LYNVVELNLVG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA58BB30", Offset = "0xA58AB30", VA = "0x18A58BB30")]
		public double YWJGNRTLTWY()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA58B760", Offset = "0xA58A760", VA = "0x18A58B760")]
		public int MDFCBRKDJWP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA58B820", Offset = "0xA58A820", VA = "0x18A58B820")]
		public ulong OMKKAFBBBET()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA58B790", Offset = "0xA58A790", VA = "0x18A58B790")]
		public bool NVOTYDGKBCU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA58B6C0", Offset = "0xA58A6C0", VA = "0x18A58B6C0")]
		public bool LCYINCICDJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA58B850", Offset = "0xA58A850", VA = "0x18A58B850")]
		public bool OXSATOSWZYB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xA58B880", Offset = "0xA58A880", VA = "0x18A58B880")]
		public bool RDMNCQSFEYQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA58B6A0", Offset = "0xA58A6A0", VA = "0x18A58B6A0")]
		public int IZSBBSQJQGN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA58B8D0", Offset = "0xA58A8D0", VA = "0x18A58B8D0")]
		public void UQAFJKUUSRF([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA58B650", Offset = "0xA58A650", VA = "0x18A58B650")]
		public bool HBDBEAQPUYR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x40B4010", Offset = "0x40B3010", VA = "0x1840B4010")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA58B8B0", Offset = "0xA58A8B0", VA = "0x18A58B8B0")]
		public static int UNRGVRYYECQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA58BA10", Offset = "0xA58AA10", VA = "0x18A58BA10")]
		public static double VEFYCKVYYLG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA58BA20", Offset = "0xA58AA20", VA = "0x18A58BA20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1877460", Offset = "0x1876460", VA = "0x181877460")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA598A20", Offset = "0xA597A20", VA = "0x18A598A20")]
		public DiyFp OLRQSXBPVYY()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xF6CF10", Offset = "0xF6BF10", VA = "0x180F6CF10")]
		public uint JTMTOVGSLAF()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA5989F0", Offset = "0xA5979F0", VA = "0x18A5989F0")]
		public int MDFCBRKDJWP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA598A80", Offset = "0xA597A80", VA = "0x18A598A80")]
		public uint OMKKAFBBBET()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA598A10", Offset = "0xA597A10", VA = "0x18A598A10")]
		public bool NVOTYDGKBCU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA598AA0", Offset = "0xA597AA0", VA = "0x18A598AA0")]
		public void UQAFJKUUSRF([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA5989B0", Offset = "0xA5979B0", VA = "0x18A5989B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA589360", Offset = "0xA588360", VA = "0x18A589360")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58F3A0", Offset = "0xA58E3A0", VA = "0x18A58F3A0")]
		public static void TEYTNTDWNBH(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA58F2D0", Offset = "0xA58E2D0", VA = "0x18A58F2D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA59CDB0", Offset = "0xA59BDB0", VA = "0x18A59CDB0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4F071F0", Offset = "0x4F061F0", VA = "0x184F071F0")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3F50", Offset = "0x2DB2F50", VA = "0x182DB3F50")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA59CD50", Offset = "0xA59BD50", VA = "0x18A59CD50")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59A080", Offset = "0xA599080", VA = "0x18A59A080")]
		private static byte[] NSIDEIVIFPN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA599990", Offset = "0xA598990", VA = "0x18A599990")]
		private static Vector HJLULWKCGWB(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA599FA0", Offset = "0xA598FA0", VA = "0x18A599FA0")]
		private static Vector LKMXXTCUDPJ(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA598EF0", Offset = "0xA597EF0", VA = "0x18A598EF0")]
		private static void CRICBKEOPLA(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA59A410", Offset = "0xA599410", VA = "0x18A59A410")]
		private static void USITOEJEENZ(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA59A700", Offset = "0xA599700", VA = "0x18A59A700")]
		private static ulong WQBOPEUQIJU(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA599A70", Offset = "0xA598A70", VA = "0x18A599A70")]
		private static void ISJPICPPDEU(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA5995C0", Offset = "0xA5985C0", VA = "0x18A5995C0")]
		private static bool HALNADLEMWD(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA59A280", Offset = "0xA599280", VA = "0x18A59A280")]
		private static DiyFp QBMEMGLVDJW(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA598F80", Offset = "0xA597F80", VA = "0x18A598F80")]
		private static bool DXMLJCXIPMK(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA59A160", Offset = "0xA599160", VA = "0x18A59A160")]
		private static bool OUSGZSWXZSW(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA599E80", Offset = "0xA598E80", VA = "0x18A599E80")]
		public static double? LCNXAWIEFQW(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA599BB0", Offset = "0xA598BB0", VA = "0x18A599BB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5914B0", Offset = "0xA5904B0", VA = "0x18A5914B0")]
		private static byte[] RFEOBKQVUCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA5911C0", Offset = "0xA5901C0", VA = "0x18A5911C0")]
		public static bool HMQLUZJZQKB(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA592580", Offset = "0xA591580", VA = "0x18A592580")]
		public static bool TWFMGDNTYUU(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA591300", Offset = "0xA590300", VA = "0x18A591300")]
		private static bool JERMVPHOXWN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA590E10", Offset = "0xA58FE10", VA = "0x18A590E10")]
		private static bool DWZCFKOZQKU(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA5910E0", Offset = "0xA5900E0", VA = "0x18A5910E0")]
		private static bool GOOPAUOHQRD(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA591440", Offset = "0xA590440", VA = "0x18A591440")]
		private static bool OKFATYQCRWL(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA5926C0", Offset = "0xA5916C0", VA = "0x18A5926C0")]
		private static double URQEDAHXGHU(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA591590", Offset = "0xA590590", VA = "0x18A591590")]
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
		[Cpp2IlInjected.Address(RVA = "0x1967320", Offset = "0x1966320", VA = "0x181967320")]
		public JUXOAULBIPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
		public JUXOAULBIPU(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x676DBF0", Offset = "0x676CBF0", VA = "0x18676DBF0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x676D590", Offset = "0x676C590", VA = "0x18676D590", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5162180", Offset = "0x5161180", VA = "0x185162180", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x5161D10", Offset = "0x5160D10", VA = "0x185161D10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1967320", Offset = "0x1966320", VA = "0x181967320")]
		public EBSYDKWIMJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xD152E0", Offset = "0xD142E0", VA = "0x180D152E0")]
		public EBSYDKWIMJX(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x5BC73B0", Offset = "0x5BC63B0", VA = "0x185BC73B0", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5BC5050", Offset = "0x5BC4050", VA = "0x185BC5050", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class OEYCPIUWIVB<a, b, c, d> : SIWYLIGCSZE<d>, FTQIUPACWHD where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x73D1A60", Offset = "0x73D0A60", VA = "0x1873D1A60", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x73CFC20", Offset = "0x73CEC20", VA = "0x1873CFC20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		protected OEYCPIUWIVB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class OFYLBQQJDZU<a, b, c> : OEYCPIUWIVB<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5172010", Offset = "0x5171010", VA = "0x185172010", Slot = "6")]
		protected override IEnumerator<a> KOPILVVEUSX(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		protected OFYLBQQJDZU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class OGDRYXKGNLD<a, b> : OFYLBQQJDZU<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD6F780", Offset = "0xD6E780", VA = "0x180D6F780", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class CURNIDPDHPZ<a, b> : OGDRYXKGNLD<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x512FBD0", Offset = "0x512EBD0", VA = "0x18512FBD0", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x512FA60", Offset = "0x512EA60", VA = "0x18512FA60", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class YCFIUGTYVWS<a> : OEYCPIUWIVB<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x515A830", Offset = "0x5159830", VA = "0x18515A830", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD6F780", Offset = "0xD6E780", VA = "0x180D6F780", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5158600", Offset = "0x5157600", VA = "0x185158600", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x515A920", Offset = "0x5159920", VA = "0x18515A920", Slot = "6")]
		protected override LinkedList<a>.Enumerator KOPILVVEUSX(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class FSDYKXWLZXJ<a> : OEYCPIUWIVB<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x5111CF0", Offset = "0x5110CF0", VA = "0x185111CF0", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x5128350", Offset = "0x5127350", VA = "0x185128350", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5128460", Offset = "0x5127460", VA = "0x185128460", Slot = "6")]
		protected override Queue<a>.Enumerator KOPILVVEUSX(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xD6F780", Offset = "0xD6E780", VA = "0x180D6F780", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class PHZNJIKDTKZ<a> : OEYCPIUWIVB<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5158450", Offset = "0x5157450", VA = "0x185158450", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5158580", Offset = "0x5157580", VA = "0x185158580", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x74FF890", Offset = "0x74FE890", VA = "0x1874FF890", Slot = "6")]
		protected override Stack<a>.Enumerator KOPILVVEUSX(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x74FF720", Offset = "0x74FE720", VA = "0x1874FF720", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class CCWKVJANHGZ<a> : OEYCPIUWIVB<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5128310", Offset = "0x5127310", VA = "0x185128310", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xD6F780", Offset = "0xD6E780", VA = "0x180D6F780", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x51283B0", Offset = "0x51273B0", VA = "0x1851283B0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x5128410", Offset = "0x5127410", VA = "0x185128410", Slot = "6")]
		protected override HashSet<a>.Enumerator KOPILVVEUSX(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x5128510", Offset = "0x5127510", VA = "0x185128510")]
		public CCWKVJANHGZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class MRIZIRBPOTF<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5158450", Offset = "0x5157450", VA = "0x185158450", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x702F820", Offset = "0x702E820", VA = "0x18702F820", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x702F8C0", Offset = "0x702E8C0", VA = "0x18702F8C0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class AKIALGTZETW<a> : OFYLBQQJDZU<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x5111CF0", Offset = "0x5110CF0", VA = "0x185111CF0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5128350", Offset = "0x5127350", VA = "0x185128350", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xD6F780", Offset = "0xD6E780", VA = "0x180D6F780", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class DUNRGYGRTRO<a> : OFYLBQQJDZU<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5111CF0", Offset = "0x5110CF0", VA = "0x185111CF0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5128350", Offset = "0x5127350", VA = "0x185128350", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xD6F780", Offset = "0xD6E780", VA = "0x180D6F780", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class XVBXFQKYPWK<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5158420", Offset = "0x5157420", VA = "0x185158420", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5158580", Offset = "0x5157580", VA = "0x185158580", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5158560", Offset = "0x5157560", VA = "0x185158560", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x51585C0", Offset = "0x51575C0", VA = "0x1851585C0")]
		public XVBXFQKYPWK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class ERWVWGVHYIO<a, b> : SIWYLIGCSZE<IGrouping<a, b>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5BD8D80", Offset = "0x5BD7D80", VA = "0x185BD8D80", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5BD8A10", Offset = "0x5BD7A10", VA = "0x185BD8A10", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class NQDEVIZKWIX<a, b> : SIWYLIGCSZE<ILookup<a, b>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x727D530", Offset = "0x727C530", VA = "0x18727D530", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x727D1D0", Offset = "0x727C1D0", VA = "0x18727D1D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F03FB0", Offset = "0x4F02FB0", VA = "0x184F03FB0", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6354FA0", Offset = "0x6353FA0", VA = "0x186354FA0")]
		public FVHJGXOXKNV(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x6354F00", Offset = "0x6353F00", VA = "0x186354F00", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6354F70", Offset = "0x6353F70", VA = "0x186354F70", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7584160", Offset = "0x7583160", VA = "0x187584160", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public UVCUHMQAMTS(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7EBF900", Offset = "0x7EBE900", VA = "0x187EBF900", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7EBF9F0", Offset = "0x7EBE9F0", VA = "0x187EBF9F0", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7EBF9F0", Offset = "0x7EBE9F0", VA = "0x187EBF9F0", Slot = "7")]
		private IEnumerator IEVKUCCAWWZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class EIESYTSNAXX<a> : SIWYLIGCSZE<a>, FTQIUPACWHD where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5BD1CC0", Offset = "0x5BD0CC0", VA = "0x185BD1CC0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5BD1AA0", Offset = "0x5BD0AA0", VA = "0x185BD1AA0", Slot = "5")]
		public a Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5934E0", Offset = "0xA5924E0", VA = "0x18A5934E0", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA5932D0", Offset = "0xA5922D0", VA = "0x18A5932D0", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA595D80", Offset = "0xA594D80", VA = "0x18A595D80", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA595B70", Offset = "0xA594B70", VA = "0x18A595B70", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59C540", Offset = "0xA59B540", VA = "0x18A59C540", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA59C330", Offset = "0xA59B330", VA = "0x18A59C330", Slot = "5")]
		public IList Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public UYZNONPCLXJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class ISQLWTQOINY<a> : OGDRYXKGNLD<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5111CF0", Offset = "0x5110CF0", VA = "0x185111CF0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x5111E50", Offset = "0x5110E50", VA = "0x185111E50", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class XIGAZGFZNKI<a> : OFYLBQQJDZU<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x5111CF0", Offset = "0x5110CF0", VA = "0x185111CF0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x5111E50", Offset = "0x5110E50", VA = "0x185111E50", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5111DE0", Offset = "0x5110DE0", VA = "0x185111DE0", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class QYSJHRFJWOO<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x778ACB0", Offset = "0x7789CB0", VA = "0x18778ACB0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5158580", Offset = "0x5157580", VA = "0x185158580", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x778AE10", Offset = "0x7789E10", VA = "0x18778AE10", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x778AF00", Offset = "0x7789F00", VA = "0x18778AF00")]
		public QYSJHRFJWOO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class UKMSYSBEUGG<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x778ACB0", Offset = "0x7789CB0", VA = "0x18778ACB0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5158580", Offset = "0x5157580", VA = "0x185158580", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5158560", Offset = "0x5157560", VA = "0x185158560", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x51585C0", Offset = "0x51575C0", VA = "0x1851585C0")]
		public UKMSYSBEUGG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class XVQZNSOIQOC<a> : OFYLBQQJDZU<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5128220", Offset = "0x5127220", VA = "0x185128220", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xD6F780", Offset = "0xD6E780", VA = "0x180D6F780", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5158600", Offset = "0x5157600", VA = "0x185158600", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class HEQUEODQKFY<a> : OGDRYXKGNLD<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5111CF0", Offset = "0x5110CF0", VA = "0x185111CF0", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5128350", Offset = "0x5127350", VA = "0x185128350", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class HSBYWJLGWOZ<a> : OGDRYXKGNLD<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5111CF0", Offset = "0x5110CF0", VA = "0x185111CF0", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5128350", Offset = "0x5127350", VA = "0x185128350", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class OQAGYTZJWUE<a> : OFYLBQQJDZU<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5158450", Offset = "0x5157450", VA = "0x185158450", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x5158580", Offset = "0x5157580", VA = "0x185158580", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x73EA570", Offset = "0x73E9570", VA = "0x1873EA570", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0xA592990", Offset = "0xA591990", VA = "0x18A592990")]
		public static DateTime CZBFEHPZCNX(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA593120", Offset = "0xA592120", VA = "0x18A593120")]
		public static bool UGHJVOYTCCQ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA592E90", Offset = "0xA591E90", VA = "0x18A592E90")]
		public static bool SLLITBHFYMQ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA592C80", Offset = "0xA591C80", VA = "0x18A592C80")]
		public static bool SLLITBHFYMQ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA592A50", Offset = "0xA591A50", VA = "0x18A592A50")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5A18C0", Offset = "0xA5A08C0", VA = "0x18A5A18C0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA5A1740", Offset = "0xA5A0740", VA = "0x18A5A1740", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA5A1340", Offset = "0xA5A0340", VA = "0x18A5A1340")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58CF80", Offset = "0xA58BF80", VA = "0x18A58CF80", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA58CF10", Offset = "0xA58BF10", VA = "0x18A58CF10", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA58CB30", Offset = "0xA58BB30", VA = "0x18A58CB30")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA593CD0", Offset = "0xA592CD0", VA = "0x18A593CD0", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA593860", Offset = "0xA592860", VA = "0x18A593860", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA5938E0", Offset = "0xA5928E0", VA = "0x18A5938E0")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public LWOTWDLHJTL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class YRZVEYBVBPW<a, b, c, d, e> : SIWYLIGCSZE<e>, FTQIUPACWHD where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x516CCB0", Offset = "0x516BCB0", VA = "0x18516CCB0", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x516A8D0", Offset = "0x51698D0", VA = "0x18516A8D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		protected YRZVEYBVBPW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class YSFCCEVSLBF<a, b, c, d> : YRZVEYBVBPW<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5172010", Offset = "0x5171010", VA = "0x185172010", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> KOPILVVEUSX(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		protected YSFCCEVSLBF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class YTFKOMRFGFY<a, b, c> : YSFCCEVSLBF<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xD6F780", Offset = "0xD6E780", VA = "0x180D6F780", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class QFFOMNTBXSE<a, b> : YRZVEYBVBPW<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x76F7440", Offset = "0x76F6440", VA = "0x1876F7440", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xD6F780", Offset = "0xD6E780", VA = "0x180D6F780", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x76F7580", Offset = "0x76F6580", VA = "0x1876F7580", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x76F7760", Offset = "0x76F6760", VA = "0x1876F7760", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator KOPILVVEUSX(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6A148A0", Offset = "0x6A138A0", VA = "0x186A148A0")]
		public QFFOMNTBXSE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class HTUCKIMVSZC<a, b, c> : YTFKOMRFGFY<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x654F040", Offset = "0x654E040", VA = "0x18654F040", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x654F230", Offset = "0x654E230", VA = "0x18654F230", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class TOBOOWOHLGF<a, b> : YSFCCEVSLBF<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x5BD8840", Offset = "0x5BD7840", VA = "0x185BD8840", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x5BD89B0", Offset = "0x5BD79B0", VA = "0x185BD89B0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xD6F780", Offset = "0xD6E780", VA = "0x180D6F780", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class EQRIYKCIEML<a, b> : YTFKOMRFGFY<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x5BD8840", Offset = "0x5BD7840", VA = "0x185BD8840", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x5BD89B0", Offset = "0x5BD79B0", VA = "0x185BD89B0", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class WKXUFCTVGHJ<a, b> : YRZVEYBVBPW<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5BD8840", Offset = "0x5BD7840", VA = "0x185BD8840", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xD6F780", Offset = "0xD6E780", VA = "0x180D6F780", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x5BD89B0", Offset = "0x5BD79B0", VA = "0x185BD89B0", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x876E9E0", Offset = "0x876D9E0", VA = "0x18876E9E0", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator KOPILVVEUSX(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class KGDVETFFARI<a, b> : YSFCCEVSLBF<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x5BD8840", Offset = "0x5BD7840", VA = "0x185BD8840", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6880FA0", Offset = "0x687FFA0", VA = "0x186880FA0", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6881010", Offset = "0x6880010", VA = "0x186881010", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class TTRTTWFGOSH<a, b> : YSFCCEVSLBF<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7BEEF30", Offset = "0x7BEDF30", VA = "0x187BEEF30", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD6F780", Offset = "0xD6E780", VA = "0x180D6F780", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BEEF70", Offset = "0x7BEDF70", VA = "0x187BEEF70", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x5128510", Offset = "0x5127510", VA = "0x185128510")]
		public TTRTTWFGOSH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class VUUTMEFNWXV<a, b> : YTFKOMRFGFY<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7FCC9D0", Offset = "0x7FCB9D0", VA = "0x187FCC9D0", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5BD89B0", Offset = "0x5BD79B0", VA = "0x185BD89B0", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class AMUPBFVWXRD<a> : SIWYLIGCSZE<a>, FTQIUPACWHD where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x72EDDB0", Offset = "0x72ECDB0", VA = "0x1872EDDB0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x72EDB80", Offset = "0x72ECB80", VA = "0x1872EDB80", Slot = "5")]
		public a Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA596AD0", Offset = "0xA595AD0", VA = "0x18A596AD0", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA5968F0", Offset = "0xA5958F0", VA = "0x18A5968F0", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public OKJJYNQBJIP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class ZEIJJVOQRQR
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA5A0B20", Offset = "0xA59FB20", VA = "0x18A5A0B20")]
		public static object NDYJBYOQEKR(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA5A0300", Offset = "0xA59F300", VA = "0x18A5A0300")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public LZUZORPWDSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x699E650", Offset = "0x699D650", VA = "0x18699E650")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MAAGLYJTNDX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7090", Offset = "0x6FC6090", VA = "0x186FC7090")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public LZKLUECBKVW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x6963540", Offset = "0x6962540", VA = "0x186963540")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public LZPSRKVYUHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x699CA90", Offset = "0x699BA90", VA = "0x18699CA90")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F23F30", Offset = "0x4F22F30", VA = "0x184F23F30")]
		static BCNCIISCJMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x4F293E0", Offset = "0x4F283E0", VA = "0x184F293E0")]
		public BCNCIISCJMG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x4F0F6F0", Offset = "0x4F0E6F0", VA = "0x184F0F6F0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x4F0B660", Offset = "0x4F0A660", VA = "0x184F0B660", Slot = "5")]
		public a Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x4F0E410", Offset = "0x4F0D410", VA = "0x184F0E410", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, a b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x4F10BD0", Offset = "0x4F0FBD0", VA = "0x184F10BD0", Slot = "7")]
		public a UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class SQMCJSOUFWW<a> : SIWYLIGCSZE<a[,]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7A80E90", Offset = "0x7A7FE90", VA = "0x187A80E90", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7A80AE0", Offset = "0x7A7FAE0", VA = "0x187A80AE0", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public SQMCJSOUFWW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class EKZGYWDPDFO<a> : SIWYLIGCSZE<a[,,]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5BD5FF0", Offset = "0x5BD4FF0", VA = "0x185BD5FF0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5BD5AF0", Offset = "0x5BD4AF0", VA = "0x185BD5AF0", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public EKZGYWDPDFO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class MJTNKZFFIUQ<a> : SIWYLIGCSZE<a[,,,]>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x70211D0", Offset = "0x70201D0", VA = "0x1870211D0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7020B90", Offset = "0x701FB90", VA = "0x187020B90", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public MJTNKZFFIUQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class PYLZZAJYZTA<a> : SIWYLIGCSZE<a?>, FTQIUPACWHD where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7508D30", Offset = "0x7507D30", VA = "0x187508D30", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7508A60", Offset = "0x7507A60", VA = "0x187508A60", Slot = "5")]
		public a? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xD15DA0", Offset = "0xD14DA0", VA = "0x180D15DA0")]
		public IGFYBIBAAWY(SIWYLIGCSZE<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6666DD0", Offset = "0x6665DD0", VA = "0x186666DD0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x6665B00", Offset = "0x6664B00", VA = "0x186665B00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59BBA0", Offset = "0xA59ABA0", VA = "0x18A59BBA0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA59BA80", Offset = "0xA59AA80", VA = "0x18A59BA80", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA59BA90", Offset = "0xA59AA90", VA = "0x18A59BA90", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, sbyte b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA59BC30", Offset = "0xA59AC30", VA = "0x18A59BC30", Slot = "7")]
		public sbyte UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA597300", Offset = "0xA596300", VA = "0x18A597300", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA597130", Offset = "0xA596130", VA = "0x18A597130", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA5971A0", Offset = "0xA5961A0", VA = "0x18A5971A0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, sbyte? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA5973F0", Offset = "0xA5963F0", VA = "0x18A5973F0", Slot = "7")]
		public sbyte? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59C090", Offset = "0xA59B090", VA = "0x18A59C090", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA59BF50", Offset = "0xA59AF50", VA = "0x18A59BF50", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5959F0", Offset = "0xA5949F0", VA = "0x18A5959F0", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA5958D0", Offset = "0xA5948D0", VA = "0x18A5958D0", Slot = "5")]
		public short Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA5958E0", Offset = "0xA5948E0", VA = "0x18A5958E0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, short b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA595A80", Offset = "0xA594A80", VA = "0x18A595A80", Slot = "7")]
		public short UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58E950", Offset = "0xA58D950", VA = "0x18A58E950", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA58E780", Offset = "0xA58D780", VA = "0x18A58E780", Slot = "5")]
		public short? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA58E7F0", Offset = "0xA58D7F0", VA = "0x18A58E7F0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, short? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA58EA40", Offset = "0xA58DA40", VA = "0x18A58EA40", Slot = "7")]
		public short? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58ECC0", Offset = "0xA58DCC0", VA = "0x18A58ECC0", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA58EB80", Offset = "0xA58DB80", VA = "0x18A58EB80", Slot = "5")]
		public short[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA590870", Offset = "0xA58F870", VA = "0x18A590870", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA590750", Offset = "0xA58F750", VA = "0x18A590750", Slot = "5")]
		public int Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA590760", Offset = "0xA58F760", VA = "0x18A590760", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, int b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA590900", Offset = "0xA58F900", VA = "0x18A590900", Slot = "7")]
		public int UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58E240", Offset = "0xA58D240", VA = "0x18A58E240", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA58E070", Offset = "0xA58D070", VA = "0x18A58E070", Slot = "5")]
		public int? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA58E0E0", Offset = "0xA58D0E0", VA = "0x18A58E0E0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, int? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA58E330", Offset = "0xA58D330", VA = "0x18A58E330", Slot = "7")]
		public int? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59AE00", Offset = "0xA599E00", VA = "0x18A59AE00", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA59ACC0", Offset = "0xA599CC0", VA = "0x18A59ACC0", Slot = "5")]
		public int[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5886B0", Offset = "0xA5876B0", VA = "0x18A5886B0", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA5885D0", Offset = "0xA5875D0", VA = "0x18A5885D0", Slot = "5")]
		public long Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA5885E0", Offset = "0xA5875E0", VA = "0x18A5885E0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, long b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA588710", Offset = "0xA587710", VA = "0x18A588710", Slot = "7")]
		public long UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58B060", Offset = "0xA58A060", VA = "0x18A58B060", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA58AEA0", Offset = "0xA589EA0", VA = "0x18A58AEA0", Slot = "5")]
		public long? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA58AF30", Offset = "0xA589F30", VA = "0x18A58AF30", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, long? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA58B120", Offset = "0xA58A120", VA = "0x18A58B120", Slot = "7")]
		public long? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58F0A0", Offset = "0xA58E0A0", VA = "0x18A58F0A0", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA58EF60", Offset = "0xA58DF60", VA = "0x18A58EF60", Slot = "5")]
		public long[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5891E0", Offset = "0xA5881E0", VA = "0x18A5891E0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA5890C0", Offset = "0xA5880C0", VA = "0x18A5890C0", Slot = "5")]
		public byte Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA5890D0", Offset = "0xA5880D0", VA = "0x18A5890D0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, byte b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA589270", Offset = "0xA588270", VA = "0x18A589270", Slot = "7")]
		public byte UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA597D20", Offset = "0xA596D20", VA = "0x18A597D20", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA597B50", Offset = "0xA596B50", VA = "0x18A597B50", Slot = "5")]
		public byte? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA597BC0", Offset = "0xA596BC0", VA = "0x18A597BC0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, byte? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA597E10", Offset = "0xA596E10", VA = "0x18A597E10", Slot = "7")]
		public byte? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5979D0", Offset = "0xA5969D0", VA = "0x18A5979D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA5978B0", Offset = "0xA5968B0", VA = "0x18A5978B0", Slot = "5")]
		public ushort Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA5978C0", Offset = "0xA5968C0", VA = "0x18A5978C0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, ushort b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA597A60", Offset = "0xA596A60", VA = "0x18A597A60", Slot = "7")]
		public ushort UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58DC50", Offset = "0xA58CC50", VA = "0x18A58DC50", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA58DA80", Offset = "0xA58CA80", VA = "0x18A58DA80", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA58DAF0", Offset = "0xA58CAF0", VA = "0x18A58DAF0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, ushort? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA58DD40", Offset = "0xA58CD40", VA = "0x18A58DD40", Slot = "7")]
		public ushort? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59D310", Offset = "0xA59C310", VA = "0x18A59D310", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA59D1D0", Offset = "0xA59C1D0", VA = "0x18A59D1D0", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59A970", Offset = "0xA599970", VA = "0x18A59A970", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA59A850", Offset = "0xA599850", VA = "0x18A59A850", Slot = "5")]
		public uint Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA59A860", Offset = "0xA599860", VA = "0x18A59A860", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, uint b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA59AA00", Offset = "0xA599A00", VA = "0x18A59AA00", Slot = "7")]
		public uint UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59CB20", Offset = "0xA59BB20", VA = "0x18A59CB20", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA59C950", Offset = "0xA59B950", VA = "0x18A59C950", Slot = "5")]
		public uint? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA59C9C0", Offset = "0xA59B9C0", VA = "0x18A59C9C0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, uint? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA59CC10", Offset = "0xA59BC10", VA = "0x18A59CC10", Slot = "7")]
		public uint? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58C210", Offset = "0xA58B210", VA = "0x18A58C210", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA58C0D0", Offset = "0xA58B0D0", VA = "0x18A58C0D0", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58DF60", Offset = "0xA58CF60", VA = "0x18A58DF60", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA58DE80", Offset = "0xA58CE80", VA = "0x18A58DE80", Slot = "5")]
		public ulong Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA58DE90", Offset = "0xA58CE90", VA = "0x18A58DE90", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, ulong b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xA58DFC0", Offset = "0xA58CFC0", VA = "0x18A58DFC0", Slot = "7")]
		public ulong UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA588240", Offset = "0xA587240", VA = "0x18A588240", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA588080", Offset = "0xA587080", VA = "0x18A588080", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA588110", Offset = "0xA587110", VA = "0x18A588110", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, ulong? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA588300", Offset = "0xA587300", VA = "0x18A588300", Slot = "7")]
		public ulong? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5956A0", Offset = "0xA5946A0", VA = "0x18A5956A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA595560", Offset = "0xA594560", VA = "0x18A595560", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59D0C0", Offset = "0xA59C0C0", VA = "0x18A59D0C0", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA59CFE0", Offset = "0xA59BFE0", VA = "0x18A59CFE0", Slot = "5")]
		public float Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA59CFF0", Offset = "0xA59BFF0", VA = "0x18A59CFF0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, float b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA59D120", Offset = "0xA59C120", VA = "0x18A59D120", Slot = "7")]
		public float UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59DAA0", Offset = "0xA59CAA0", VA = "0x18A59DAA0", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA59D910", Offset = "0xA59C910", VA = "0x18A59D910", Slot = "5")]
		public float? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA59D980", Offset = "0xA59C980", VA = "0x18A59D980", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, float? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA59DB60", Offset = "0xA59CB60", VA = "0x18A59DB60", Slot = "7")]
		public float? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA588D30", Offset = "0xA587D30", VA = "0x18A588D30", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA588BF0", Offset = "0xA587BF0", VA = "0x18A588BF0", Slot = "5")]
		public float[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59CED0", Offset = "0xA59BED0", VA = "0x18A59CED0", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA59CDF0", Offset = "0xA59BDF0", VA = "0x18A59CDF0", Slot = "5")]
		public double Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA59CE00", Offset = "0xA59BE00", VA = "0x18A59CE00", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, double b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA59CF30", Offset = "0xA59BF30", VA = "0x18A59CF30", Slot = "7")]
		public double UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5985E0", Offset = "0xA5975E0", VA = "0x18A5985E0", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA598420", Offset = "0xA597420", VA = "0x18A598420", Slot = "5")]
		public double? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA5984B0", Offset = "0xA5974B0", VA = "0x18A5984B0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, double? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA5986A0", Offset = "0xA5976A0", VA = "0x18A5986A0", Slot = "7")]
		public double? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59DDB0", Offset = "0xA59CDB0", VA = "0x18A59DDB0", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA59DC70", Offset = "0xA59CC70", VA = "0x18A59DC70", Slot = "5")]
		public double[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5988A0", Offset = "0xA5978A0", VA = "0x18A5988A0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA5987C0", Offset = "0xA5977C0", VA = "0x18A5987C0", Slot = "5")]
		public bool Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA5987D0", Offset = "0xA5977D0", VA = "0x18A5987D0", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, bool b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA598900", Offset = "0xA597900", VA = "0x18A598900", Slot = "7")]
		public bool UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59D740", Offset = "0xA59C740", VA = "0x18A59D740", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA59D5B0", Offset = "0xA59C5B0", VA = "0x18A59D5B0", Slot = "5")]
		public bool? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xA59D620", Offset = "0xA59C620", VA = "0x18A59D620", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, bool? b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA59D800", Offset = "0xA59C800", VA = "0x18A59D800", Slot = "7")]
		public bool? UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58C7A0", Offset = "0xA58B7A0", VA = "0x18A58C7A0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA58C660", Offset = "0xA58B660", VA = "0x18A58C660", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA597FC0", Offset = "0xA596FC0", VA = "0x18A597FC0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA597F50", Offset = "0xA596F50", VA = "0x18A597F50", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA596750", Offset = "0xA595750", VA = "0x18A596750", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA596680", Offset = "0xA595680", VA = "0x18A596680", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5962A0", Offset = "0xA5952A0", VA = "0x18A5962A0", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA596230", Offset = "0xA595230", VA = "0x18A596230", Slot = "5")]
		public string Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA596240", Offset = "0xA595240", VA = "0x18A596240", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, string b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA596230", Offset = "0xA595230", VA = "0x18A596230", Slot = "7")]
		public string UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA597680", Offset = "0xA596680", VA = "0x18A597680", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA597530", Offset = "0xA596530", VA = "0x18A597530", Slot = "5")]
		public string[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA590440", Offset = "0xA58F440", VA = "0x18A590440", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA590410", Offset = "0xA58F410", VA = "0x18A590410", Slot = "5")]
		public char Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59BDE0", Offset = "0xA59ADE0", VA = "0x18A59BDE0", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA59BD20", Offset = "0xA59AD20", VA = "0x18A59BD20", Slot = "5")]
		public char? Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58BE10", Offset = "0xA58AE10", VA = "0x18A58BE10", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA58BC80", Offset = "0xA58AC80", VA = "0x18A58BC80", Slot = "5")]
		public char[] Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5889A0", Offset = "0xA5879A0", VA = "0x18A5889A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5887C0", Offset = "0xA5877C0", VA = "0x18A5887C0", Slot = "5")]
		public Guid Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA588820", Offset = "0xA587820", VA = "0x18A588820", Slot = "6")]
		public void MZTTPORNZCZ(JsonWriter a, Guid b, DAMCVOXAVIT c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA588B10", Offset = "0xA587B10", VA = "0x18A588B10", Slot = "7")]
		public Guid UEWNPDQPGYJ(JsonReader a, DAMCVOXAVIT b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0x88DD810", Offset = "0x88DC810", VA = "0x1888DD810")]
		public LGZZBEJMDPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xFFCE70", Offset = "0xFFBE70", VA = "0x180FFCE70")]
		public LGZZBEJMDPZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA590BC0", Offset = "0xA58FBC0", VA = "0x18A590BC0", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA5909F0", Offset = "0xA58F9F0", VA = "0x18A5909F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59AB70", Offset = "0xA599B70", VA = "0x18A59AB70", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA59AAF0", Offset = "0xA599AF0", VA = "0x18A59AAF0", Slot = "5")]
		public Uri Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5884A0", Offset = "0xA5874A0", VA = "0x18A5884A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA588420", Offset = "0xA587420", VA = "0x18A588420", Slot = "5")]
		public Version Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public BACTIQQTCAK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class PMEMPOFRJHW<a, b> : SIWYLIGCSZE<KeyValuePair<a, b>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x75006C0", Offset = "0x74FF6C0", VA = "0x1875006C0", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x75001C0", Offset = "0x74FF1C0", VA = "0x1875001C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA594470", Offset = "0xA593470", VA = "0x18A594470", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA5943F0", Offset = "0xA5933F0", VA = "0x18A5943F0", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA596490", Offset = "0xA595490", VA = "0x18A596490", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA596370", Offset = "0xA595370", VA = "0x18A596370", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58E760", Offset = "0xA58D760", VA = "0x18A58E760")]
		public HNHWNRTEVHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x98A5A40", Offset = "0x98A4A40", VA = "0x1898A5A40")]
		public HNHWNRTEVHE(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA58E580", Offset = "0xA58D580", VA = "0x18A58E580", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA58E470", Offset = "0xA58D470", VA = "0x18A58E470", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA59B150", Offset = "0xA59A150", VA = "0x18A59B150", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA59B0A0", Offset = "0xA59A0A0", VA = "0x18A59B0A0", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58B2D0", Offset = "0xA58A2D0", VA = "0x18A58B2D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA58B240", Offset = "0xA58A240", VA = "0x18A58B240", Slot = "5")]
		public Complex Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
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
		[Cpp2IlInjected.Address(RVA = "0xA598320", Offset = "0xA597320", VA = "0x18A598320", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA5980F0", Offset = "0xA5970F0", VA = "0x18A5980F0", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public REFYSPUHCSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class JEFVNEDXVNJ<a> : SIWYLIGCSZE<Lazy<a>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x6763E20", Offset = "0x6762E20", VA = "0x186763E20", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x6763C80", Offset = "0x6762C80", VA = "0x186763C80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA590610", Offset = "0xA58F610", VA = "0x18A590610", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA590560", Offset = "0xA58F560", VA = "0x18A590560", Slot = "5")]
		public Task Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public LAHSWZNPFEH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class GEZYKBESAHJ<a> : SIWYLIGCSZE<Task<a>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x642F780", Offset = "0x642E780", VA = "0x18642F780", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x642F600", Offset = "0x642E600", VA = "0x18642F600", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, DAMCVOXAVIT formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class OHTMBYMOPZD<a> : SIWYLIGCSZE<ValueTask<a>>, FTQIUPACWHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x73D8340", Offset = "0x73D7340", VA = "0x1873D8340", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x73D8190", Offset = "0x73D7190", VA = "0x1873D8190", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5114760", Offset = "0x5113760", VA = "0x185114760", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x5114470", Offset = "0x5113470", VA = "0x185114470", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x51155D0", Offset = "0x51145D0", VA = "0x1851155D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x5115180", Offset = "0x5114180", VA = "0x185115180", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5117FB0", Offset = "0x5116FB0", VA = "0x185117FB0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5117A20", Offset = "0x5116A20", VA = "0x185117A20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5118D70", Offset = "0x5117D70", VA = "0x185118D70", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5118680", Offset = "0x5117680", VA = "0x185118680", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5119E20", Offset = "0x5118E20", VA = "0x185119E20", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x51195C0", Offset = "0x51185C0", VA = "0x1851195C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x511B1E0", Offset = "0x511A1E0", VA = "0x18511B1E0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x511A7F0", Offset = "0x51197F0", VA = "0x18511A7F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x511D4F0", Offset = "0x511C4F0", VA = "0x18511D4F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x511C970", Offset = "0x511B970", VA = "0x18511C970", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x511EEB0", Offset = "0x511DEB0", VA = "0x18511EEB0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x511E1C0", Offset = "0x511D1C0", VA = "0x18511E1C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A8F50", Offset = "0x64A7F50", VA = "0x1864A8F50", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x64A8B20", Offset = "0x64A7B20", VA = "0x1864A8B20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A8590", Offset = "0x64A7590", VA = "0x1864A8590", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x64A8080", Offset = "0x64A7080", VA = "0x1864A8080", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A7940", Offset = "0x64A6940", VA = "0x1864A7940", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x64A72A0", Offset = "0x64A62A0", VA = "0x1864A72A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A6980", Offset = "0x64A5980", VA = "0x1864A6980", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x64A6110", Offset = "0x64A5110", VA = "0x1864A6110", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A5640", Offset = "0x64A4640", VA = "0x1864A5640", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x64A4C40", Offset = "0x64A3C40", VA = "0x1864A4C40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A3FB0", Offset = "0x64A2FB0", VA = "0x1864A3FB0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x64A3390", Offset = "0x64A2390", VA = "0x1864A3390", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A1750", Offset = "0x64A0750", VA = "0x1864A1750", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x64A0970", Offset = "0x649F970", VA = "0x1864A0970", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x649F8D0", Offset = "0x649E8D0", VA = "0x18649F8D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, DAMCVOXAVIT formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x649E940", Offset = "0x649D940", VA = "0x18649E940", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA58C4B0", Offset = "0xA58B4B0", VA = "0x18A58C4B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA587ED0", Offset = "0xA586ED0", VA = "0x18A587ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA594580", Offset = "0xA593580", VA = "0x18A594580")]
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
