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
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xA974E0", Offset = "0xA960E0", VA = "0x180A974E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, ROQGPFJHMXC resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, ROQGPFJHMXC resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface KMSROFZLDAO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface YBQFBVYECUF<a> : KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, ROQGPFJHMXC formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface OGKQHBQDQPC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HOFPHNZTDHW(JsonWriter a, a b, ROQGPFJHMXC c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b);
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
	public static class ZAYWUAHWOHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3C041D0", Offset = "0x3C02DD0", VA = "0x183C041D0")]
		public static string ToJsonString<T>(this YBQFBVYECUF<T> formatter, T value, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		YBQFBVYECUF<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class PVHATIXSQQF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x38D6ED0", Offset = "0x38D5AD0", VA = "0x1838D6ED0")]
		public static YBQFBVYECUF<a> DFWOZEFCAWQ<a>(this ROQGPFJHMXC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8D33A00", Offset = "0x8D32600", VA = "0x188D33A00")]
		public static object RQEYIDEBPWC(this ROQGPFJHMXC a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8D271A0", Offset = "0x8D25DA0", VA = "0x188D271A0")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class CQCMZNXUIWE
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] TWCOOOTVBAH;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] RWIFIABAWHA;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] TRUVGHBTKTZ;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] THQDCUIKXKG;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] NHSSZFUFOMV;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] JDLMSMVWDCM;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] TZYWHTEJGCK;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] CTMATJBCKZV;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class KSZRJLFCDRB : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x8D31060", Offset = "0x8D2FC60", VA = "0x188D31060")]
				public KSZRJLFCDRB(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x8D30F40", Offset = "0x8D2FB40", VA = "0x188D30F40")]
				public KSZRJLFCDRB PWSCGZPCIMX(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class SAZNOPVXTBC
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] FKXOIJLYYFL;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] PLCYPTFPCTQ;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private KSZRJLFCDRB start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private KSZRJLFCDRB end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8D36100", Offset = "0x8D34D00", VA = "0x188D36100")]
			public void PWSCGZPCIMX([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8D35FC0", Offset = "0x8D34BC0", VA = "0x188D35FC0")]
			public void PWSCGZPCIMX(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8D36210", Offset = "0x8D34E10", VA = "0x188D36210")]
			public ReadOnlySequence<byte> SSREQBLPEHS()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8D35E10", Offset = "0x8D34A10", VA = "0x188D35E10")]
			private void IBBQIJYTGWG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8D35C20", Offset = "0x8D34820", VA = "0x188D35C20")]
			private void FKDIADUROPA([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F910", Offset = "0x8D2E510", VA = "0x188D2F910")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E800", Offset = "0x8D2D400", VA = "0x188D2E800")]
		private JsonParsingException PVRSHAFASBU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D4E0", Offset = "0x8D2C0E0", VA = "0x188D2D4E0")]
		private JsonParsingException HDGNWYBXBON(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8D2DA30", Offset = "0x8D2C630", VA = "0x188D2DA30")]
		public JsonToken JUABKRRWZBP()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8D2CF80", Offset = "0x8D2BB80", VA = "0x188D2CF80")]
		public void EROULKKABEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D1B0", Offset = "0x8D2BDB0", VA = "0x188D2D1B0")]
		private bool EZLGLBKOCZN(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D210", Offset = "0x8D2BE10", VA = "0x188D2D210")]
		private bool EZLGLBKOCZN(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F570", Offset = "0x8D2E170", VA = "0x188D2F570")]
		private void XQANWOWCHDA(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F620", Offset = "0x8D2E220", VA = "0x188D2F620")]
		public bool XRVHJHYIIZY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8D2ED00", Offset = "0x8D2D900", VA = "0x188D2ED00")]
		public void QFYGBZUIJFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8D2C750", Offset = "0x8D2B350", VA = "0x188D2C750")]
		public bool BICZBIWRIIZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D5F0", Offset = "0x8D2C1F0", VA = "0x188D2D5F0")]
		public void HUWURTDVSXO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8D2C900", Offset = "0x8D2B500", VA = "0x188D2C900")]
		public void CLXJUTSMUQC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F6E0", Offset = "0x8D2E2E0", VA = "0x188D2F6E0")]
		public bool YKQDUPQYNLZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F090", Offset = "0x8D2DC90", VA = "0x188D2F090")]
		public void TBOCEEHGIHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E240", Offset = "0x8D2CE40", VA = "0x188D2E240")]
		public void MQEEOAXDSHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F300", Offset = "0x8D2DF00", VA = "0x188D2F300")]
		public bool WIYDTBVNXHM(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8D2ED10", Offset = "0x8D2D910", VA = "0x188D2ED10")]
		public bool QMEUFJAKTDW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E4F0", Offset = "0x8D2D0F0", VA = "0x188D2E4F0")]
		public bool NOWEUPJIXHB(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8D2C9C0", Offset = "0x8D2B5C0", VA = "0x188D2C9C0")]
		private ReadOnlySequence<byte> DPSVHKXQZYI()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8D2DC40", Offset = "0x8D2C840", VA = "0x188D2DC40")]
		private ReadOnlySequence<byte> KBGWILMXNKL()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D2F0", Offset = "0x8D2BEF0", VA = "0x188D2D2F0")]
		private void GBWJYLBWZZB(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E040", Offset = "0x8D2CC40", VA = "0x188D2E040")]
		private void LHLHTZOUTIC(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8D2EDA0", Offset = "0x8D2D9A0", VA = "0x188D2EDA0")]
		private void QVIRGVTCDPD(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D6D0", Offset = "0x8D2C2D0", VA = "0x188D2D6D0")]
		private void IYJDFIZIPRC(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8D24FC0", Offset = "0x8D23BC0", VA = "0x188D24FC0")]
		private static int CNQSVOMACTJ(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E730", Offset = "0x8D2D330", VA = "0x188D2E730")]
		public ReadOnlySequence<byte> PGFHPEPPYXH()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D270", Offset = "0x8D2BE70", VA = "0x188D2D270")]
		public string FSLWBXVESQW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8D2CEA0", Offset = "0x8D2BAA0", VA = "0x188D2CEA0")]
		public string DQRXMXNRLSB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D600", Offset = "0x8D2C200", VA = "0x188D2D600")]
		public ReadOnlySequence<byte> IBMRLTTGKLR()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8D2DEB0", Offset = "0x8D2CAB0", VA = "0x188D2DEB0")]
		public ReadOnlySequence<byte> KEAJGARQWQU()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F0A0", Offset = "0x8D2DCA0", VA = "0x188D2F0A0")]
		public bool TBVVHFBWOYR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F390", Offset = "0x8D2DF90", VA = "0x188D2F390")]
		private void WWENZXFZXIR(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8D2DA20", Offset = "0x8D2C620", VA = "0x188D2DA20")]
		public void JRAFWRGVJYL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D7E0", Offset = "0x8D2C3E0", VA = "0x188D2D7E0")]
		private void JMGLUZETYCQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8D2DF90", Offset = "0x8D2CB90", VA = "0x188D2DF90")]
		public sbyte KVZSOZGNTGC()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E5D0", Offset = "0x8D2D1D0", VA = "0x188D2E5D0")]
		public short OUSERTSUPHJ()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8D2C910", Offset = "0x8D2B510", VA = "0x188D2C910")]
		public int CREFCXZLCFT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F1F0", Offset = "0x8D2DDF0", VA = "0x188D2F1F0")]
		public long UTBCDMHHYXI()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8D2C850", Offset = "0x8D2B450", VA = "0x188D2C850")]
		public byte CKSOHTVNDFT()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8D2C7A0", Offset = "0x8D2B3A0", VA = "0x188D2C7A0")]
		public ushort CFBYYVBINCI()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E680", Offset = "0x8D2D280", VA = "0x188D2E680")]
		public uint PFHQSUNIRAS()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F500", Offset = "0x8D2E100", VA = "0x188D2F500")]
		public ulong XHMBPLNLBCB()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8D2CEE0", Offset = "0x8D2BAE0", VA = "0x188D2CEE0")]
		public float ECACNXCCMYD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F260", Offset = "0x8D2DE60", VA = "0x188D2F260")]
		public double VXMCXXTRVSW()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8D2F730", Offset = "0x8D2E330", VA = "0x188D2F730")]
		public ReadOnlySequence<byte> YNXWEUZJDMP()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8D2E250", Offset = "0x8D2CE50", VA = "0x188D2E250")]
		private void MUXBSEVGYUB()
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
			[Cpp2IlInjected.Address(RVA = "0xCAD0A0", Offset = "0xCABCA0", VA = "0x180CAD0A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8D2C6F0", Offset = "0x8D2B2F0", VA = "0x188D2C6F0")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8D2C670", Offset = "0x8D2B270", VA = "0x188D2C670")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class OTQSRSVCJAV
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class DXEAHDBEIMW
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] FKXOIJLYYFL;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8D26E00", Offset = "0x8D25A00", VA = "0x188D26E00")]
			public static byte[] UYYWXPLQXVZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static ROQGPFJHMXC WSHTUPOACIS;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] QNULJCBJIYF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] IPKRVSZWSXX;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static ROQGPFJHMXC MQSTSHTXRYO
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8D32460", Offset = "0x8D31060", VA = "0x188D32460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8D32560", Offset = "0x8D31160", VA = "0x188D32560")]
		public static void XVIGQGOGDCM(ROQGPFJHMXC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x38B22D0", Offset = "0x38B0ED0", VA = "0x1838B22D0")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x38B2150", Offset = "0x38B0D50", VA = "0x1838B2150")]
		public static byte[] Serialize<T>(T value, ROQGPFJHMXC resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x38B28E0", Offset = "0x38B14E0", VA = "0x1838B28E0")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x38B2760", Offset = "0x38B1360", VA = "0x1838B2760")]
		public static string ToJsonString<T>(T value, ROQGPFJHMXC resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x38B1A00", Offset = "0x38B0600", VA = "0x1838B1A00")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x38B1BD0", Offset = "0x38B07D0", VA = "0x1838B1BD0")]
		public static T Deserialize<T>(string json, ROQGPFJHMXC resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x38B1D50", Offset = "0x38B0950", VA = "0x1838B1D50")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x38B1930", Offset = "0x38B0530", VA = "0x1838B1930")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, ROQGPFJHMXC resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x38B10E0", Offset = "0x38AFCE0", VA = "0x1838B10E0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x38B1300", Offset = "0x38AFF00", VA = "0x1838B1300")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, ROQGPFJHMXC resolver)
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
		public int DPEXXYLLEWX
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xC6D5D0", Offset = "0xC6C1D0", VA = "0x180C6D5D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FCB0", Offset = "0x8D2E8B0", VA = "0x188D2FCB0")]
		public void FATSLLRMZKE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FE70", Offset = "0x8D2EA70", VA = "0x188D2FE70")]
		public static byte[] NDLXVEYBKZJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8D30010", Offset = "0x8D2EC10", VA = "0x188D30010")]
		public static byte[] RSMVZDGEFYH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8D30420", Offset = "0x8D2F020", VA = "0x188D30420")]
		public static byte[] XAACOIZTVOD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8D306D0", Offset = "0x8D2F2D0", VA = "0x188D306D0")]
		public static byte[] ZVBCYWLLASB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x27EB360", Offset = "0x27E9F60", VA = "0x1827EB360")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8D302E0", Offset = "0x8D2EEE0", VA = "0x188D302E0")]
		public ArraySegment<byte> UYYWXPLQXVZ()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8D30540", Offset = "0x8D2F140", VA = "0x188D30540")]
		public byte[] YTUZKVFFKNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8D30210", Offset = "0x8D2EE10", VA = "0x188D30210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FE00", Offset = "0x8D2EA00", VA = "0x188D2FE00")]
		public void JPCTCYPBFNT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FDA0", Offset = "0x8D2E9A0", VA = "0x188D2FDA0")]
		public void IPIWNMYAXAY(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FFD0", Offset = "0x8D2EBD0", VA = "0x188D2FFD0")]
		public void ODSDXVLZZDY(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3CC87A0", Offset = "0x3CC73A0", VA = "0x183CC87A0")]
		public void MOKAIZFJWFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3CC87F0", Offset = "0x3CC73F0", VA = "0x183CC87F0")]
		public void UHNKRIGXEQM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FBF0", Offset = "0x8D2E7F0", VA = "0x188D2FBF0")]
		public void EDMSBUQQFRO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FA80", Offset = "0x8D2E680", VA = "0x188D2FA80")]
		public void ANWEJVLPZUA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8750", Offset = "0x3CC7350", VA = "0x183CC8750")]
		public void IQBEBGWOZQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4C5F000", Offset = "0x4C5DC00", VA = "0x184C5F000")]
		public void LHLRRFHQHBS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8D30380", Offset = "0x8D2EF80", VA = "0x188D30380")]
		public void VKEFMJFBJMI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4D88800", Offset = "0x4D87400", VA = "0x184D88800")]
		public void MPZLLOSISHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3CC8840", Offset = "0x3CC7440", VA = "0x183CC8840")]
		public void VYBXBBMQJIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7649380", Offset = "0x7647F80", VA = "0x187649380")]
		public void WEZFWLUFBNU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FB70", Offset = "0x8D2E770", VA = "0x188D2FB70")]
		public void DCSQDNPYCFY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FAD0", Offset = "0x8D2E6D0", VA = "0x188D2FAD0")]
		public void BHDGBBRYPJB(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FCC0", Offset = "0x8D2E8C0", VA = "0x188D2FCC0")]
		public void HQVYMTEHLXG(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FD30", Offset = "0x8D2E930", VA = "0x188D2FD30")]
		public void ILRPOHHNVIN(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8D30270", Offset = "0x8D2EE70", VA = "0x188D30270")]
		public void UQVSHFECFWX(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FE40", Offset = "0x8D2EA40", VA = "0x188D2FE40")]
		public void MORHKODZVVO(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8D301A0", Offset = "0x8D2EDA0", VA = "0x188D301A0")]
		public void SQNMFLRKLHH(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8D30130", Offset = "0x8D2ED30", VA = "0x188D30130")]
		public void RYVQNPKMUAA(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FC40", Offset = "0x8D2E840", VA = "0x188D2FC40")]
		public void EZBIHOWMXYK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FE10", Offset = "0x8D2EA10", VA = "0x188D2FE10")]
		public void MBHUQXXOWDL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8D30850", Offset = "0x8D2F450", VA = "0x188D30850")]
		public void ZVELYGGVFBN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FF50", Offset = "0x8D2EB50", VA = "0x188D2FF50")]
		private static bool NYQEZFMOYVV(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8D2FB50", Offset = "0x8D2E750", VA = "0x188D2FB50")]
		private static byte CLBUWKHHZCF(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D252B0", Offset = "0x8D23EB0", VA = "0x188D252B0")]
		private static void LFQYGTZNMRU(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class OOUXKPFZUYT : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6512C10", Offset = "0x6511810", VA = "0x186512C10")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private OOUXKPFZUYT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class EGUMVBMAIGA : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x650B480", Offset = "0x650A080", VA = "0x18650B480")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class QGMTCOLPKWO
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> JNJDEGZTFVN;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8D33B50", Offset = "0x8D32750", VA = "0x188D33B50")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private EGUMVBMAIGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class MVRLMCUCCJW : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6520430", Offset = "0x651F030", VA = "0x186520430")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly MVRLMCUCCJW PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool QPOECXZPMIQ;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static KMSROFZLDAO[] ADDUIZGKBKA;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static ROQGPFJHMXC[] KQTUIOPQBGO;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private MVRLMCUCCJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8D31A50", Offset = "0x8D30650", VA = "0x188D31A50")]
		public static void OGBNJYRINGK(params ROQGPFJHMXC[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8D31970", Offset = "0x8D30570", VA = "0x188D31970")]
		public static void OGBNJYRINGK(params KMSROFZLDAO[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8D31B30", Offset = "0x8D30730", VA = "0x188D31B30")]
		public static void UFURJVPXKIS(KMSROFZLDAO[] a, ROQGPFJHMXC[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class AWHWRJQBZOP : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6514E60", Offset = "0x6513A60", VA = "0x186514E60")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private AWHWRJQBZOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class JKDYGOYLHJW
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly ROQGPFJHMXC YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly ROQGPFJHMXC DEJPGQHCCRT;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class OFEATOFBSBS
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly ROQGPFJHMXC YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly ROQGPFJHMXC BXNNSUDXUYD;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly ROQGPFJHMXC AQCMVETWOGF;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly ROQGPFJHMXC MEPZYXGUSQG;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly ROQGPFJHMXC UNETFRQCXEM;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly ROQGPFJHMXC ENFRFDTMDHQ;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly ROQGPFJHMXC YUNJNZXZWSH;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly ROQGPFJHMXC KIHVBUMHBKH;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly ROQGPFJHMXC SFPOGPMGWAV;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly ROQGPFJHMXC GHHGPFLWJFM;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly ROQGPFJHMXC YVWUECVMDWE;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly ROQGPFJHMXC UNWFWRBWZXM;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class HZHOTIBRVUV
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> JNJDEGZTFVN;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8D29EA0", Offset = "0x8D28AA0", VA = "0x188D29EA0")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8D2BB20", Offset = "0x8D2A720", VA = "0x188D2BB20")]
		private static object LZEOPEEWWDW(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class IGDHGJPAYQN : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x650B660", Offset = "0x650A260", VA = "0x18650B660")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private IGDHGJPAYQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class BHJABDTJMAE : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x652ED30", Offset = "0x652D930", VA = "0x18652ED30")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private BHJABDTJMAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class FCVBCHJQLPC
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly ROQGPFJHMXC[] CJNJIDQPJNP;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class LUNIZCGNTLB : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6520970", Offset = "0x651F570", VA = "0x186520970")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class TAXQVLGLRFZ : ROQGPFJHMXC
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class WQMDBYQOYKQ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x6517220", Offset = "0x6515E20", VA = "0x186517220")]
				static WQMDBYQOYKQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly ROQGPFJHMXC PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly ROQGPFJHMXC[] KQTUIOPQBGO;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			private TAXQVLGLRFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
			public YBQFBVYECUF<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly YBQFBVYECUF<object> WYEZXNAIOMF;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private LUNIZCGNTLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class USZHPNNEECE : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6531A80", Offset = "0x6530680", VA = "0x186531A80")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class TAXQVLGLRFZ : ROQGPFJHMXC
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class WQMDBYQOYKQ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x6516F60", Offset = "0x6515B60", VA = "0x186516F60")]
				static WQMDBYQOYKQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly ROQGPFJHMXC PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly ROQGPFJHMXC[] KQTUIOPQBGO;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			private TAXQVLGLRFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
			public YBQFBVYECUF<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly YBQFBVYECUF<object> WYEZXNAIOMF;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private USZHPNNEECE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class SEBWAQOTFBI : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6539510", Offset = "0x6538110", VA = "0x186539510")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class TAXQVLGLRFZ : ROQGPFJHMXC
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class WQMDBYQOYKQ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x651F870", Offset = "0x651E470", VA = "0x18651F870")]
				static WQMDBYQOYKQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly ROQGPFJHMXC PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly ROQGPFJHMXC[] KQTUIOPQBGO;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			private TAXQVLGLRFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
			public YBQFBVYECUF<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly YBQFBVYECUF<object> WYEZXNAIOMF;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private SEBWAQOTFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class BTQQTGAQHAV : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x652D9F0", Offset = "0x652C5F0", VA = "0x18652D9F0")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class TAXQVLGLRFZ : ROQGPFJHMXC
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class WQMDBYQOYKQ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x6533EF0", Offset = "0x6532AF0", VA = "0x186533EF0")]
				static WQMDBYQOYKQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly ROQGPFJHMXC PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly ROQGPFJHMXC[] KQTUIOPQBGO;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			private TAXQVLGLRFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
			public YBQFBVYECUF<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly YBQFBVYECUF<object> WYEZXNAIOMF;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private BTQQTGAQHAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class HXEYSHDLWZZ : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6534470", Offset = "0x6533070", VA = "0x186534470")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class TAXQVLGLRFZ : ROQGPFJHMXC
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class WQMDBYQOYKQ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x6516E00", Offset = "0x6515A00", VA = "0x186516E00")]
				static WQMDBYQOYKQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly ROQGPFJHMXC PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly ROQGPFJHMXC[] KQTUIOPQBGO;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			private TAXQVLGLRFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
			public YBQFBVYECUF<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly YBQFBVYECUF<object> WYEZXNAIOMF;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private HXEYSHDLWZZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class NUSIXHFPDHT : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x6509820", Offset = "0x6508420", VA = "0x186509820")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class TAXQVLGLRFZ : ROQGPFJHMXC
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class WQMDBYQOYKQ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x6532DF0", Offset = "0x65319F0", VA = "0x186532DF0")]
				static WQMDBYQOYKQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly ROQGPFJHMXC PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly ROQGPFJHMXC[] KQTUIOPQBGO;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			private TAXQVLGLRFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
			public YBQFBVYECUF<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly YBQFBVYECUF<object> WYEZXNAIOMF;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private NUSIXHFPDHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class QJRPLYPPAVO : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6514520", Offset = "0x6513120", VA = "0x186514520")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class TAXQVLGLRFZ : ROQGPFJHMXC
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class WQMDBYQOYKQ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x6524A50", Offset = "0x6523650", VA = "0x186524A50")]
				static WQMDBYQOYKQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly ROQGPFJHMXC PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly ROQGPFJHMXC[] KQTUIOPQBGO;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			private TAXQVLGLRFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
			public YBQFBVYECUF<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly YBQFBVYECUF<object> WYEZXNAIOMF;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private QJRPLYPPAVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class UHGIDAGMLRG : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x652FE20", Offset = "0x652EA20", VA = "0x18652FE20")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class TAXQVLGLRFZ : ROQGPFJHMXC
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class WQMDBYQOYKQ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0x65341B0", Offset = "0x6532DB0", VA = "0x1865341B0")]
				static WQMDBYQOYKQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly ROQGPFJHMXC PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly ROQGPFJHMXC[] KQTUIOPQBGO;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			private TAXQVLGLRFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
			public YBQFBVYECUF<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly YBQFBVYECUF<object> WYEZXNAIOMF;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private UHGIDAGMLRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class ZHAYIHBFXTI : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x6516500", Offset = "0x6515100", VA = "0x186516500")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class TAXQVLGLRFZ : ROQGPFJHMXC
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class WQMDBYQOYKQ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x65377F0", Offset = "0x65363F0", VA = "0x1865377F0")]
				static WQMDBYQOYKQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly ROQGPFJHMXC PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly ROQGPFJHMXC[] KQTUIOPQBGO;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			private TAXQVLGLRFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
			public YBQFBVYECUF<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly YBQFBVYECUF<object> WYEZXNAIOMF;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private ZHAYIHBFXTI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class DSECWSINHWN : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x650C1F0", Offset = "0x650ADF0", VA = "0x18650C1F0")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class TAXQVLGLRFZ : ROQGPFJHMXC
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class WQMDBYQOYKQ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x65170C0", Offset = "0x6515CC0", VA = "0x1865170C0")]
				static WQMDBYQOYKQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly ROQGPFJHMXC PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly ROQGPFJHMXC[] KQTUIOPQBGO;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			private TAXQVLGLRFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
			public YBQFBVYECUF<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly YBQFBVYECUF<object> WYEZXNAIOMF;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private DSECWSINHWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class KAHXYIFVZUT : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6532F50", Offset = "0x6531B50", VA = "0x186532F50")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class TAXQVLGLRFZ : ROQGPFJHMXC
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class WQMDBYQOYKQ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x652EA00", Offset = "0x652D600", VA = "0x18652EA00")]
				static WQMDBYQOYKQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly ROQGPFJHMXC PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly ROQGPFJHMXC[] KQTUIOPQBGO;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			private TAXQVLGLRFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
			public YBQFBVYECUF<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly YBQFBVYECUF<object> WYEZXNAIOMF;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private KAHXYIFVZUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class ICUJQTAUTWR : ROQGPFJHMXC
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class WQMDBYQOYKQ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x652D120", Offset = "0x652BD20", VA = "0x18652D120")]
			static WQMDBYQOYKQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class TAXQVLGLRFZ : ROQGPFJHMXC
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class WQMDBYQOYKQ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly YBQFBVYECUF<a> GGAHIBHDJWT;

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x6511D10", Offset = "0x6510910", VA = "0x186511D10")]
				static WQMDBYQOYKQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly ROQGPFJHMXC PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly ROQGPFJHMXC[] KQTUIOPQBGO;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			private TAXQVLGLRFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
			public YBQFBVYECUF<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly ROQGPFJHMXC PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly YBQFBVYECUF<object> WYEZXNAIOMF;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		private ICUJQTAUTWR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x304F200", Offset = "0x304DE00", VA = "0x18304F200", Slot = "4")]
		public YBQFBVYECUF<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x55458C0", Offset = "0x55444C0", VA = "0x1855458C0")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x55455D0", Offset = "0x55441D0", VA = "0x1855455D0")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5545830", Offset = "0x5544430", VA = "0x185545830")]
		public T[] NQDZUZNOKVJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class XKOVIPSUEMF<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int FJHBGEMYZJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object GBSJWTWIGCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int GYQTBABAQUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] CBZMFFCKEGO;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3DCAA50", Offset = "0x3DC9650", VA = "0x183DCAA50")]
		public XKOVIPSUEMF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3DCA5E0", Offset = "0x3DC91E0", VA = "0x183DCA5E0")]
		public a[] PKSBHVLMMMU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3DCA810", Offset = "0x3DC9410", VA = "0x183DCA810")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class YCFEOKPOEBD : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class PAHUEYPYKHH : IComparable<PAHUEYPYKHH>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class ABPPFOROISV : IEnumerable<PAHUEYPYKHH>, IEnumerable, IEnumerator<PAHUEYPYKHH>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int VIUVMRSCWZN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private PAHUEYPYKHH VWMVUJJYLQY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int FTPEWITHWYC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public PAHUEYPYKHH BIVSZSMQJUR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int DHBHAJRDLPJ;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private PAHUEYPYKHH IIHRKHPLYEO
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object JGIILLOFTSJ
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0xA98C80", Offset = "0xA97880", VA = "0x180A98C80", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xD18690", Offset = "0xD17290", VA = "0x180D18690")]
				[DebuggerHidden]
				public ABPPFOROISV(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "7")]
				[DebuggerHidden]
				private void YZDXQKWRCHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x8D25850", Offset = "0x8D24450", VA = "0x188D25850", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x8D258D0", Offset = "0x8D244D0", VA = "0x188D258D0", Slot = "10")]
				[DebuggerHidden]
				private void XHCIYLVFRPR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x8D257B0", Offset = "0x8D243B0", VA = "0x188D257B0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<PAHUEYPYKHH> DYPYXKNFBWF()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x8D257B0", Offset = "0x8D243B0", VA = "0x188D257B0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator VDVERRYCFPI()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly PAHUEYPYKHH[] CVXUQWCLWCV;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] GBAANOOUDGY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong GBMCKJFKCKS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int KBCQUAEOSXO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string OVXDKKSJNBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private PAHUEYPYKHH[] ZOPGOSXRPXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] MZGXVMSSABA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int JMQLFWTJZBI;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8D32D20", Offset = "0x8D31920", VA = "0x188D32D20")]
			public PAHUEYPYKHH(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8D327C0", Offset = "0x8D313C0", VA = "0x188D327C0")]
			public PAHUEYPYKHH Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8D32760", Offset = "0x8D31360", VA = "0x188D32760")]
			public PAHUEYPYKHH Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8D329F0", Offset = "0x8D315F0", VA = "0x188D329F0")]
			public PAHUEYPYKHH ISHGGNGCJXJ(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8D32B60", Offset = "0x8D31760", VA = "0x188D32B60")]
			internal static int MDMBCGPMFWC(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8D329C0", Offset = "0x8D315C0", VA = "0x188D329C0", Slot = "4")]
			public int CompareTo(PAHUEYPYKHH other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8D32BF0", Offset = "0x8D317F0", VA = "0x188D32BF0")]
			[IteratorStateMachine(typeof(ABPPFOROISV))]
			public IEnumerable<PAHUEYPYKHH> NEJUUHVXKHN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class XGXUGQJDSCT : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int FTPEWITHWYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<PAHUEYPYKHH> ZOPGOSXRPXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<PAHUEYPYKHH> ZJZUKTHFXZI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<PAHUEYPYKHH> KYBQTQIMGAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private PAHUEYPYKHH VCWZCBJWUWC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> KYMEODWGYXD;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> XRLRRAFBDSI
			{
				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0xC666D0", Offset = "0xC652D0", VA = "0x180C666D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x8D37140", Offset = "0x8D35D40", VA = "0x188D37140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x19F4860", Offset = "0x19F3460", VA = "0x1819F4860")]
			[DebuggerHidden]
			public XGXUGQJDSCT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8D37770", Offset = "0x8D36370", VA = "0x188D37770", Slot = "7")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8D37230", Offset = "0x8D35E30", VA = "0x188D37230", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8D37190", Offset = "0x8D35D90", VA = "0x188D37190")]
			private void LSRJDRRKPDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8D371E0", Offset = "0x8D35DE0", VA = "0x188D371E0")]
			private void LTHDVLZCRLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8D37730", Offset = "0x8D36330", VA = "0x188D37730", Slot = "10")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8D37690", Offset = "0x8D36290", VA = "0x188D37690", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> OOXSWADMYTN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8D37690", Offset = "0x8D36290", VA = "0x188D37690", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator VDVERRYCFPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly PAHUEYPYKHH CEBPHRDGBWL;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8D38110", Offset = "0x8D36D10", VA = "0x188D38110")]
		public YCFEOKPOEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8D378C0", Offset = "0x8D364C0", VA = "0x188D378C0")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8D37AA0", Offset = "0x8D366A0", VA = "0x188D37AA0")]
		public bool CLNAOHYEVON(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8D37F70", Offset = "0x8D36B70", VA = "0x188D37F70")]
		public bool SSTQTWWBQAY([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8D38080", Offset = "0x8D36C80", VA = "0x188D38080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8D37BB0", Offset = "0x8D367B0", VA = "0x188D37BB0")]
		private static void GDKVKDSXDIM(IEnumerable<PAHUEYPYKHH> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8D37E90", Offset = "0x8D36A90", VA = "0x188D37E90", Slot = "5")]
		private IEnumerator VDVERRYCFPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8D37E90", Offset = "0x8D36A90", VA = "0x188D37E90", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8D37EF0", Offset = "0x8D36AF0", VA = "0x188D37EF0")]
		[IteratorStateMachine(typeof(XGXUGQJDSCT))]
		private static IEnumerable<KeyValuePair<string, int>> PHFLJDYESRB(IEnumerable<PAHUEYPYKHH> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class MQWZZTZSJMS
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo DPUPYJFYVNT;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8D31170", Offset = "0x8D2FD70", VA = "0x188D31170")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8D31320", Offset = "0x8D2FF20", VA = "0x188D31320")]
		public static ulong YTPQXLRXUGR(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class ZWROWQMSJES
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8D383E0", Offset = "0x8D36FE0", VA = "0x188D383E0")]
		public static void JPCTCYPBFNT(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8D38520", Offset = "0x8D37120", VA = "0x188D38520")]
		public static void WQPIIWANARL(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8D382A0", Offset = "0x8D36EA0", VA = "0x188D382A0")]
		public static byte[] BUWFOXCSSKK(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class KTAIIECQAEG<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x469DF00", Offset = "0x469CB00", VA = "0x18469DF00", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class SLWPVWHDKUC : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int VIUVMRSCWZN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> VWMVUJJYLQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public KTAIIECQAEG<a> BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] KYBQTQIMGAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int KYGXQXCJPLU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] KYMEODWGYXD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int KYRLLKQEIIM;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> QWWBKOBAAGL
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xC666D0", Offset = "0xC652D0", VA = "0x180C666D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object JGIILLOFTSJ
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0x4D42550", Offset = "0x4D41150", VA = "0x184D42550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
			[DebuggerHidden]
			public SLWPVWHDKUC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
			[DebuggerHidden]
			private void YZDXQKWRCHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x5D0A3A0", Offset = "0x5D08FA0", VA = "0x185D0A3A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3CCB5C0", Offset = "0x3CCA1C0", VA = "0x183CCB5C0", Slot = "8")]
			[DebuggerHidden]
			private void XHCIYLVFRPR()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] OUBTHYMYZYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong JZRVNLWBSMQ;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool HWYCMPYTRHX;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5187B80", Offset = "0x5186780", VA = "0x185187B80")]
		public KTAIIECQAEG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5187A90", Offset = "0x5186690", VA = "0x185187A90")]
		public KTAIIECQAEG(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5182D00", Offset = "0x5181900", VA = "0x185182D00")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5185B70", Offset = "0x5184770", VA = "0x185185B70")]
		private bool RUVTJMOBIVA(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5183CB0", Offset = "0x51828B0", VA = "0x185183CB0")]
		public bool CLNAOHYEVON([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5186F70", Offset = "0x5185B70", VA = "0x185186F70")]
		private static ulong YVCEMYKBLMP([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5186DD0", Offset = "0x51859D0", VA = "0x185186DD0")]
		private static ulong YVCEMYKBLMP([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5184030", Offset = "0x5182C30", VA = "0x185184030")]
		private static int KCLXKQUHZTX(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5183F10", Offset = "0x5182B10", VA = "0x185183F10", Slot = "4")]
		[IteratorStateMachine(typeof(KTAIIECQAEG<>.SLWPVWHDKUC))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5186480", Offset = "0x5185080", VA = "0x185186480", Slot = "5")]
		private IEnumerator VDVERRYCFPI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class MBTBGUUQHOT
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x37AA8C0", Offset = "0x37A94C0", VA = "0x1837AA8C0")]
		public static Func<a> NLXVZMOVPYF<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x37AA9B0", Offset = "0x37A95B0", VA = "0x1837AA9B0")]
		private static c OSNKXOUAIIS<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0x8D27BF0", Offset = "0x8D267F0", VA = "0x188D27BF0")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8D27C00", Offset = "0x8D26800", VA = "0x188D27C00")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8D27200", Offset = "0x8D25E00", VA = "0x188D27200")]
		private static byte POZJDCVLYVQ(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8D24E10", Offset = "0x8D23A10", VA = "0x188D24E10")]
		private static byte BQLNVKUUMJA(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8D272A0", Offset = "0x8D25EA0", VA = "0x188D272A0")]
		public void UOCKZOMHYDE(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class ASEAKIXIJNQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8D25CF0", Offset = "0x8D248F0", VA = "0x188D25CF0")]
		public static bool LGAHUVOLDLY(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8D25B80", Offset = "0x8D24780", VA = "0x188D25B80")]
		public static bool IBWSAAACZNJ(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8D25C90", Offset = "0x8D24890", VA = "0x188D25C90")]
		public static sbyte KVZSOZGNTGC([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8D25D00", Offset = "0x8D24900", VA = "0x188D25D00")]
		public static short OUSERTSUPHJ([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8D259D0", Offset = "0x8D245D0", VA = "0x188D259D0")]
		public static int CREFCXZLCFT([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8D26350", Offset = "0x8D24F50", VA = "0x188D26350")]
		public static long UTBCDMHHYXI([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8D25DC0", Offset = "0x8D249C0", VA = "0x188D25DC0")]
		public static bool PJVWLJGTBJB(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8D25970", Offset = "0x8D24570", VA = "0x188D25970")]
		public static byte CKSOHTVNDFT([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8D25910", Offset = "0x8D24510", VA = "0x188D25910")]
		public static ushort CFBYYVBINCI([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8D25D60", Offset = "0x8D24960", VA = "0x188D25D60")]
		public static uint PFHQSUNIRAS([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8D26750", Offset = "0x8D25350", VA = "0x188D26750")]
		public static ulong XHMBPLNLBCB([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8D26600", Offset = "0x8D25200", VA = "0x188D26600")]
		public static bool XGHOJFLPGWK(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8D25FB0", Offset = "0x8D24BB0", VA = "0x188D25FB0")]
		public static bool SQJXGJUOKLK(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8D26400", Offset = "0x8D25000", VA = "0x188D26400")]
		public static bool VEIANILAVBU(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8D25BF0", Offset = "0x8D247F0", VA = "0x188D25BF0")]
		public static bool IEAMDOARLFK(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8D25A30", Offset = "0x8D24630", VA = "0x188D25A30")]
		public static float ECACNXCCMYD([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8D25B20", Offset = "0x8D24720", VA = "0x188D25B20")]
		public static bool FUANIHOOCMY(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8D26510", Offset = "0x8D25110", VA = "0x188D26510")]
		public static double VXMCXXTRVSW([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8D25F50", Offset = "0x8D24B50", VA = "0x188D25F50")]
		public static bool RXNJRMBWZKJ(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8D244B0", Offset = "0x8D230B0", VA = "0x188D244B0")]
		public static int MORHKODZVVO(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8D23AF0", Offset = "0x8D226F0", VA = "0x188D23AF0")]
		public static int MBHUQXXOWDL(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8D26180", Offset = "0x8D24D80", VA = "0x188D26180")]
		public static bool TBVVHFBWOYR([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class DQREGIUDKZG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8D26CB0", Offset = "0x8D258B0", VA = "0x188D26CB0")]
		public static bool AQFWBGYQPLY(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class YZPZQASZUNZ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding BEVKBISBBHG;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class PDQXDWFWXVB
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8D28F80", Offset = "0x8D27B80", VA = "0x188D28F80")]
		public static void JNRIVWWLLHG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8D28FF0", Offset = "0x8D27BF0", VA = "0x188D28FF0")]
		public static void JNWPTDQIUSP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8D29060", Offset = "0x8D27C60", VA = "0x188D29060")]
		public static void JOBWQKKGEDY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8D290D0", Offset = "0x8D27CD0", VA = "0x188D290D0")]
		public static void JOHDNREDNPH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8D32DE0", Offset = "0x8D319E0", VA = "0x188D32DE0")]
		public static void JQCNPABFUNK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8D32E50", Offset = "0x8D31A50", VA = "0x188D32E50")]
		public static void JQHUMGVDDYT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8D33320", Offset = "0x8D31F20", VA = "0x188D33320")]
		public static void LWLOXLJUTQB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8D332B0", Offset = "0x8D31EB0", VA = "0x188D332B0")]
		public static void LWGIAEPXKES(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8D33240", Offset = "0x8D31E40", VA = "0x188D33240")]
		public static void LWBBCXWAATJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8D331C0", Offset = "0x8D31DC0", VA = "0x188D331C0")]
		public static void LVVUFRCCRIA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8D33140", Offset = "0x8D31D40", VA = "0x188D33140")]
		public static void LVQNIKIFHWR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8D330C0", Offset = "0x8D31CC0", VA = "0x188D330C0")]
		public static void LVLGLDOHYLI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8D33040", Offset = "0x8D31C40", VA = "0x188D33040")]
		public static void LVFZNWUKOZZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8D32FC0", Offset = "0x8D31BC0", VA = "0x188D32FC0")]
		public static void LVASQQANFOQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8D32F40", Offset = "0x8D31B40", VA = "0x188D32F40")]
		public static void LUVLTJGPWDH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8D32EC0", Offset = "0x8D31AC0", VA = "0x188D32EC0")]
		public static void LUQEWCMSMRY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8D33490", Offset = "0x8D32090", VA = "0x188D33490")]
		public static void SQQHFVFDTJI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8D33510", Offset = "0x8D32110", VA = "0x188D33510")]
		public static void SQVODBZBCUR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8D33390", Offset = "0x8D31F90", VA = "0x188D33390")]
		public static void SQFTLHRJAMQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8D33410", Offset = "0x8D32010", VA = "0x188D33410")]
		public static void SQLAIOLGJXZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8D336B0", Offset = "0x8D322B0", VA = "0x188D336B0")]
		public static void SRLIUWGTFCS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8D33730", Offset = "0x8D32330", VA = "0x188D33730")]
		public static void SRQPSDAQOOB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8D33590", Offset = "0x8D32190", VA = "0x188D33590")]
		public static void SRAVAISYMGA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8D33620", Offset = "0x8D32220", VA = "0x188D33620")]
		public static void SRGBXPMVVRJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8D337C0", Offset = "0x8D323C0", VA = "0x188D337C0")]
		public static void SSGKJXIIQWC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8D33850", Offset = "0x8D32450", VA = "0x188D33850")]
		public static void SSLRHECGAHL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8D33970", Offset = "0x8D32570", VA = "0x188D33970")]
		public static void ZRHMENNGJBR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8D338E0", Offset = "0x8D324E0", VA = "0x188D338E0")]
		public static void ZRCFHGTIZQI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8D29140", Offset = "0x8D27D40", VA = "0x188D29140")]
		public static void JORRIERYGLZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8D291B0", Offset = "0x8D27DB0", VA = "0x188D291B0")]
		public static void JOWYFLLVPXI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8D29220", Offset = "0x8D27E20", VA = "0x188D29220")]
		public static void JPCFCSFSZIR(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class HHYYXNSODSU
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8D29290", Offset = "0x8D27E90", VA = "0x188D29290")]
		public static void JQCNPABFUNK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8D29300", Offset = "0x8D27F00", VA = "0x188D29300")]
		public static void JQHUMGVDDYT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8D29790", Offset = "0x8D28390", VA = "0x188D29790")]
		public static void LWLOXLJUTQB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8D29720", Offset = "0x8D28320", VA = "0x188D29720")]
		public static void LWGIAEPXKES(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8D296B0", Offset = "0x8D282B0", VA = "0x188D296B0")]
		public static void LWBBCXWAATJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8D29640", Offset = "0x8D28240", VA = "0x188D29640")]
		public static void LVVUFRCCRIA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8D295D0", Offset = "0x8D281D0", VA = "0x188D295D0")]
		public static void LVQNIKIFHWR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8D29560", Offset = "0x8D28160", VA = "0x188D29560")]
		public static void LVLGLDOHYLI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8D294F0", Offset = "0x8D280F0", VA = "0x188D294F0")]
		public static void LVFZNWUKOZZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8D29470", Offset = "0x8D28070", VA = "0x188D29470")]
		public static void LVASQQANFOQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8D293F0", Offset = "0x8D27FF0", VA = "0x188D293F0")]
		public static void LUVLTJGPWDH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8D29370", Offset = "0x8D27F70", VA = "0x188D29370")]
		public static void LUQEWCMSMRY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8D29900", Offset = "0x8D28500", VA = "0x188D29900")]
		public static void SQQHFVFDTJI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8D29980", Offset = "0x8D28580", VA = "0x188D29980")]
		public static void SQVODBZBCUR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8D29800", Offset = "0x8D28400", VA = "0x188D29800")]
		public static void SQFTLHRJAMQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8D29880", Offset = "0x8D28480", VA = "0x188D29880")]
		public static void SQLAIOLGJXZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8D29B00", Offset = "0x8D28700", VA = "0x188D29B00")]
		public static void SRLIUWGTFCS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8D29B80", Offset = "0x8D28780", VA = "0x188D29B80")]
		public static void SRQPSDAQOOB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8D29A00", Offset = "0x8D28600", VA = "0x188D29A00")]
		public static void SRAVAISYMGA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D29A80", Offset = "0x8D28680", VA = "0x188D29A80")]
		public static void SRGBXPMVVRJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8D29C00", Offset = "0x8D28800", VA = "0x188D29C00")]
		public static void SSGKJXIIQWC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8D29C80", Offset = "0x8D28880", VA = "0x188D29C80")]
		public static void SSLRHECGAHL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8D29D80", Offset = "0x8D28980", VA = "0x188D29D80")]
		public static void ZRHMENNGJBR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8D29D00", Offset = "0x8D28900", VA = "0x188D29D00")]
		public static void ZRCFHGTIZQI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8D29140", Offset = "0x8D27D40", VA = "0x188D29140")]
		public static void JORRIERYGLZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D291B0", Offset = "0x8D27DB0", VA = "0x188D291B0")]
		public static void JOWYFLLVPXI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D29220", Offset = "0x8D27E20", VA = "0x188D29220")]
		public static void JPCFCSFSZIR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8D28F80", Offset = "0x8D27B80", VA = "0x188D28F80")]
		public static void JNRIVWWLLHG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8D28FF0", Offset = "0x8D27BF0", VA = "0x188D28FF0")]
		public static void JNWPTDQIUSP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8D29060", Offset = "0x8D27C60", VA = "0x188D29060")]
		public static void JOBWQKKGEDY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D290D0", Offset = "0x8D27CD0", VA = "0x188D290D0")]
		public static void JOHDNREDNPH(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class NCMGCSWNICC
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool HWYCMPYTRHX;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8D41260", Offset = "0x8D3FE60", VA = "0x188D41260")]
		public static void IPIWNMYAXAY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D42CB0", Offset = "0x8D418B0", VA = "0x188D42CB0")]
		public static void JESKAPYCNYJ(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x2890DF0", Offset = "0x288F9F0", VA = "0x182890DF0")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A800", Offset = "0x8D39400", VA = "0x188D3A800")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A810", Offset = "0x8D39410", VA = "0x188D3A810")]
		public static DiyFp VPZRCBVUUDP(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A6D0", Offset = "0x8D392D0", VA = "0x188D3A6D0")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A760", Offset = "0x8D39360", VA = "0x188D3A760")]
		public static DiyFp RWWDCLTJSDR(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A820", Offset = "0x8D39420", VA = "0x188D3A820")]
		public void YJIFNQTRYSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A860", Offset = "0x8D39460", VA = "0x188D3A860")]
		public static DiyFp YJIFNQTRYSW(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xBF8830", Offset = "0xBF7430", VA = "0x180BF8830")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8D47BA0", Offset = "0x8D467A0", VA = "0x188D47BA0")]
		public void IITMNSMTWOJ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8D47D80", Offset = "0x8D46980", VA = "0x188D47D80")]
		public void UIYADLRMSQT(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8D47EA0", Offset = "0x8D46AA0", VA = "0x188D47EA0")]
		public void XXKXESZTCMR(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8D47E00", Offset = "0x8D46A00", VA = "0x188D47E00")]
		public void XXKXESZTCMR(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8D47D00", Offset = "0x8D46900", VA = "0x188D47D00")]
		public void NBHDPOAKEQL(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8D47C00", Offset = "0x8D46800", VA = "0x188D47C00")]
		public void LCCJPILHTJM(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class WFVAZOCLZWK
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
		private static byte[] JGJDAHXCXMT;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] SYYRYYKTJTB;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] WGOWNLRURCR;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] QTNLHDAOZAO;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags CKYERWENPMX;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char CIDKFBCIGQJ;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int JIBBLFIERZB;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int NFLHAISGHYF;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] FFJDEYCCLGH;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8D4BD20", Offset = "0x8D4A920", VA = "0x188D4BD20")]
		private static byte[] VWZAPTGLOXL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B0B0", Offset = "0x8D49CB0", VA = "0x188D4B0B0")]
		private static byte[] NHQHPRILHUJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8D4A500", Offset = "0x8D49100", VA = "0x188D4A500")]
		public static int DDAKDXOBEMY(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8D4A3E0", Offset = "0x8D48FE0", VA = "0x188D4A3E0")]
		public static int DDAKDXOBEMY(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B290", Offset = "0x8D49E90", VA = "0x188D4B290")]
		private static bool QZWYLOJDHGQ(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8D4BDF0", Offset = "0x8D4A9F0", VA = "0x188D4BDF0")]
		private static void XDNPOFPGYPK(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D4A620", Offset = "0x8D49220", VA = "0x188D4A620")]
		private static bool DFNICTHLPCS(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D49F60", Offset = "0x8D48B60", VA = "0x188D49F60")]
		private static bool CQQIYXQSMHU(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B190", Offset = "0x8D49D90", VA = "0x188D4B190")]
		private static bool OKRGDKMQBFL(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B380", Offset = "0x8D49F80", VA = "0x188D4B380")]
		private static bool SWTTXHETZAG(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8D4A9E0", Offset = "0x8D495E0", VA = "0x188D4A9E0")]
		private static bool DROSUWOKCKR(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B550", Offset = "0x8D4A150", VA = "0x188D4B550")]
		private static void TVMUJGBQOGP(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B8F0", Offset = "0x8D4A4F0", VA = "0x188D4B8F0")]
		private static void VDEPHLDTSQX(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AEC0", Offset = "0x8D49AC0", VA = "0x188D4AEC0")]
		private static bool EGAHQQHKEFM(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0x8D3AED0", Offset = "0x8D39AD0", VA = "0x188D3AED0")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AE30", Offset = "0x8D39A30", VA = "0x188D3AE30")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A960", Offset = "0x8D39560", VA = "0x188D3A960")]
		public DiyFp COTKBNLXKTL()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AB60", Offset = "0x8D39760", VA = "0x188D3AB60")]
		public DiyFp NNGHKDKHXTA()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xBB8ED0", Offset = "0xBB7AD0", VA = "0x180BB8ED0")]
		public ulong JDMZMAYXQGV()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AC10", Offset = "0x8D39810", VA = "0x188D3AC10")]
		public double SKASTOPIGCP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A9D0", Offset = "0x8D395D0", VA = "0x188D3A9D0")]
		public double ENLKGPLYXRR()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8D3ABE0", Offset = "0x8D397E0", VA = "0x188D3ABE0")]
		public int PAUZLWOPHZW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AAB0", Offset = "0x8D396B0", VA = "0x188D3AAB0")]
		public ulong HYOHAEUJCIW()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AA70", Offset = "0x8D39670", VA = "0x188D3AA70")]
		public bool EQEZUVMTOCX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AA90", Offset = "0x8D39690", VA = "0x188D3AA90")]
		public bool FIZGOWAUPMO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AC90", Offset = "0x8D39890", VA = "0x188D3AC90")]
		public bool SYBCWKBIWGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AAE0", Offset = "0x8D396E0", VA = "0x188D3AAE0")]
		public bool MNFQEKCFSZF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A8B0", Offset = "0x8D394B0", VA = "0x188D3A8B0")]
		public int ANBUEYACFSK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D3ACD0", Offset = "0x8D398D0", VA = "0x188D3ACD0")]
		public void XGWXHRIYFKU([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AB10", Offset = "0x8D39710", VA = "0x188D3AB10")]
		public bool MNGYNBKWYBG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3B9D000", Offset = "0x3B9BC00", VA = "0x183B9D000")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AE10", Offset = "0x8D39A10", VA = "0x188D3AE10")]
		public static int XINTWMGQRJZ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8D3ACC0", Offset = "0x8D398C0", VA = "0x188D3ACC0")]
		public static double THJTHJXBVOP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A8D0", Offset = "0x8D394D0", VA = "0x188D3A8D0")]
		public static ulong CDABXTRDXMS(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x1558EE0", Offset = "0x1557AE0", VA = "0x181558EE0")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D47980", Offset = "0x8D46580", VA = "0x188D47980")]
		public DiyFp COTKBNLXKTL()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xC6CF70", Offset = "0xC6BB70", VA = "0x180C6CF70")]
		public uint BHVBFSLOWEO()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8D47A50", Offset = "0x8D46650", VA = "0x188D47A50")]
		public int PAUZLWOPHZW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8D479F0", Offset = "0x8D465F0", VA = "0x188D479F0")]
		public uint HYOHAEUJCIW()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8D479E0", Offset = "0x8D465E0", VA = "0x188D479E0")]
		public bool EQEZUVMTOCX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8D47A70", Offset = "0x8D46670", VA = "0x188D47A70")]
		public void XGWXHRIYFKU([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8D47A10", Offset = "0x8D46610", VA = "0x188D47A10")]
		public bool MNGYNBKWYBG()
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
		[Cpp2IlInjected.Address(RVA = "0x8D39E30", Offset = "0x8D38A30", VA = "0x188D39E30")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class WYMVWZBXSCT
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] VOGSTNOAHCU;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8D4DD30", Offset = "0x8D4C930", VA = "0x188D4DD30")]
		public static void ODIOQVSDYKW(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8D4DC60", Offset = "0x8D4C860", VA = "0x188D4DC60")]
		public static void HIEVZCJLOXL(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0x8D49F20", Offset = "0x8D48B20", VA = "0x188D49F20")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5766040", Offset = "0x5764C40", VA = "0x185766040")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2AC6D80", Offset = "0x2AC5980", VA = "0x182AC6D80")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8D49EC0", Offset = "0x8D48AC0", VA = "0x188D49EC0")]
		public Vector HXOQRRZOGWE(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class PSGACOGSXBU
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] QVRDNKDXGWE;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] TMVMHVHVYWT;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int XRYVVPFYQRY;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8D46D20", Offset = "0x8D45920", VA = "0x188D46D20")]
		private static byte[] QBODAYMBCJY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8D457D0", Offset = "0x8D443D0", VA = "0x188D457D0")]
		private static Vector ATVIUPASGBE(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8D46E00", Offset = "0x8D45A00", VA = "0x188D46E00")]
		private static Vector QGZZSAHBWOW(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D463B0", Offset = "0x8D44FB0", VA = "0x188D463B0")]
		private static void LTYQEIKFYBV(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8D458B0", Offset = "0x8D444B0", VA = "0x188D458B0")]
		private static void BGAVVMCMYTK(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8D461E0", Offset = "0x8D44DE0", VA = "0x188D461E0")]
		private static ulong CWHJANITQYZ(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8D46270", Offset = "0x8D44E70", VA = "0x188D46270")]
		private static void DYMAEELPZBL(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8D46440", Offset = "0x8D45040", VA = "0x188D46440")]
		private static bool LUPNUPMTGKU(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8D46EE0", Offset = "0x8D45AE0", VA = "0x188D46EE0")]
		private static DiyFp SUOHMEOTUJF(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8D45BA0", Offset = "0x8D447A0", VA = "0x188D45BA0")]
		private static bool CTXPTLPNBPF(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8D46810", Offset = "0x8D45410", VA = "0x188D46810")]
		private static bool MAXKNUTNQJT(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8D46C00", Offset = "0x8D45800", VA = "0x188D46C00")]
		public static double? OUVJUJTLUMV(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8D46930", Offset = "0x8D45530", VA = "0x188D46930")]
		public static float? OUKVZWFRBQD(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class LRZJCOOVQQK
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] KHRUUVNANZQ;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] WGOWNLRURCR;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] QTNLHDAOZAO;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] PDFFMPMVSCQ;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int WGNJLEBGJEM;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] NVQTMETZHDG;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int CBUJKUPBWTW;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8D40160", Offset = "0x8D3ED60", VA = "0x188D40160")]
		private static byte[] UYYWXPLQXVZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FD90", Offset = "0x8D3E990", VA = "0x188D3FD90")]
		public static bool FUANIHOOCMY(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8D40020", Offset = "0x8D3EC20", VA = "0x188D40020")]
		public static bool RXNJRMBWZKJ(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8D40530", Offset = "0x8D3F130", VA = "0x188D40530")]
		private static bool ZBZXUQMUZAG(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8D40240", Offset = "0x8D3EE40", VA = "0x188D40240")]
		private static bool XFVAOGVCUWB(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FED0", Offset = "0x8D3EAD0", VA = "0x188D3FED0")]
		private static bool NBVLFHYYXFQ(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FFB0", Offset = "0x8D3EBB0", VA = "0x188D3FFB0")]
		private static bool QPGEJDVMZWS(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8D40510", Offset = "0x8D3F110", VA = "0x188D40510")]
		private static double YDFNEPUYYIV(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8D3EDA0", Offset = "0x8D3D9A0", VA = "0x188D3EDA0")]
		private static double CMXKVGWVQTB(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class IZDUCTEGZEJ<a> : YBQFBVYECUF<a[]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly XKOVIPSUEMF<a> RTAIIBSBVWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour RSVDSXDKEBQ;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x164B4C0", Offset = "0x164A0C0", VA = "0x18164B4C0")]
		public IZDUCTEGZEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
		public IZDUCTEGZEJ(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x4FB4DB0", Offset = "0x4FB39B0", VA = "0x184FB4DB0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x4FB4760", Offset = "0x4FB3360", VA = "0x184FB4760", Slot = "5")]
		public a[] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class AMIMBJEVOFQ<a> : YBQFBVYECUF<ArraySegment<a>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly XKOVIPSUEMF<a> RTAIIBSBVWC;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5307C10", Offset = "0x5306810", VA = "0x185307C10", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x53077C0", Offset = "0x53063C0", VA = "0x1853077C0", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class CDSDOWHNMXK<a> : YBQFBVYECUF<List<a>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour RSVDSXDKEBQ;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x164B4C0", Offset = "0x164A0C0", VA = "0x18164B4C0")]
		public CDSDOWHNMXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAA1F30", Offset = "0xAA0B30", VA = "0x180AA1F30")]
		public CDSDOWHNMXK(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3CD20C0", Offset = "0x3CD0CC0", VA = "0x183CD20C0", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0810", Offset = "0x3CCF410", VA = "0x183CD0810", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class KRXZDUENMZQ<a, b, c, d> : YBQFBVYECUF<d>, KMSROFZLDAO where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5181C30", Offset = "0x5180830", VA = "0x185181C30", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x51809F0", Offset = "0x517F5F0", VA = "0x1851809F0", Slot = "5")]
		public d Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c TLHDAFGBUVU(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		protected KRXZDUENMZQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class KQXQRMJARUX<a, b, c> : KRXZDUENMZQ<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x4C69410", Offset = "0x4C68010", VA = "0x184C69410", Slot = "6")]
		protected override IEnumerator<a> TLHDAFGBUVU(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		protected KQXQRMJARUX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class KQSJUFPDIJO<a, b> : KQXQRMJARUX<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xAF79E0", Offset = "0xAF65E0", VA = "0x180AF79E0", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class PJNTBKWPGBS<a, b> : KQSJUFPDIJO<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x59C6940", Offset = "0x59C5540", VA = "0x1859C6940", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x59C67E0", Offset = "0x59C53E0", VA = "0x1859C67E0", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class CXEMDSXHJAX<a> : KRXZDUENMZQ<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3CFCEC0", Offset = "0x3CFBAC0", VA = "0x183CFCEC0", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xAF79E0", Offset = "0xAF65E0", VA = "0x180AF79E0", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3CFCFB0", Offset = "0x3CFBBB0", VA = "0x183CFCFB0", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x3CFD010", Offset = "0x3CFBC10", VA = "0x183CFD010", Slot = "6")]
		protected override LinkedList<a>.Enumerator TLHDAFGBUVU(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class UKEEUJZZCRE<a> : KRXZDUENMZQ<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3DD21F0", Offset = "0x3DD0DF0", VA = "0x183DD21F0", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3DD22D0", Offset = "0x3DD0ED0", VA = "0x183DD22D0", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x579E6C0", Offset = "0x579D2C0", VA = "0x18579E6C0", Slot = "6")]
		protected override Queue<a>.Enumerator TLHDAFGBUVU(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xAF79E0", Offset = "0xAF65E0", VA = "0x180AF79E0", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class RLMPWUNWQCC<a> : KRXZDUENMZQ<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x52767D0", Offset = "0x52753D0", VA = "0x1852767D0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530D3E0", VA = "0x18530E7E0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x5ABF960", Offset = "0x5ABE560", VA = "0x185ABF960", Slot = "6")]
		protected override Stack<a>.Enumerator TLHDAFGBUVU(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5ABF800", Offset = "0x5ABE400", VA = "0x185ABF800", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class NOTOJJZUHHA<a> : KRXZDUENMZQ<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x579E620", Offset = "0x579D220", VA = "0x18579E620", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xAF79E0", Offset = "0xAF65E0", VA = "0x180AF79E0", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x579E660", Offset = "0x579D260", VA = "0x18579E660", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x579E770", Offset = "0x579D370", VA = "0x18579E770", Slot = "6")]
		protected override HashSet<a>.Enumerator TLHDAFGBUVU(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4EFF9B0", Offset = "0x4EFE5B0", VA = "0x184EFF9B0")]
		public NOTOJJZUHHA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class LOSBCZDKIJU<a> : KQXQRMJARUX<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x52767D0", Offset = "0x52753D0", VA = "0x1852767D0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x52768B0", Offset = "0x52754B0", VA = "0x1852768B0", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5276940", Offset = "0x5275540", VA = "0x185276940", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class XYFMWXSQVYD<a> : KQXQRMJARUX<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3DD21F0", Offset = "0x3DD0DF0", VA = "0x183DD21F0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3DD22D0", Offset = "0x3DD0ED0", VA = "0x183DD22D0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xAF79E0", Offset = "0xAF65E0", VA = "0x180AF79E0", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class KDIKQMCVEDF<a> : KQXQRMJARUX<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3DD21F0", Offset = "0x3DD0DF0", VA = "0x183DD21F0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3DD22D0", Offset = "0x3DD0ED0", VA = "0x183DD22D0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xAF79E0", Offset = "0xAF65E0", VA = "0x180AF79E0", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class VTODPGTFQHX<a> : KQXQRMJARUX<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x57AFFF0", Offset = "0x57AEBF0", VA = "0x1857AFFF0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530D3E0", VA = "0x18530E7E0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5706090", Offset = "0x5704C90", VA = "0x185706090", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3E99490", Offset = "0x3E98090", VA = "0x183E99490")]
		public VTODPGTFQHX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class FHLDIJPWTXX<a, b> : YBQFBVYECUF<IGrouping<a, b>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x4C69060", Offset = "0x4C67C60", VA = "0x184C69060", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x4C68D10", Offset = "0x4C67910", VA = "0x184C68D10", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class WHTZVIYCOFO<a, b> : YBQFBVYECUF<ILookup<a, b>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x64C00F0", Offset = "0x64BECF0", VA = "0x1864C00F0", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x64BFDA0", Offset = "0x64BE9A0", VA = "0x1864BFDA0", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class SRVLOPKVHHC<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a QDRJQNEVYTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> WRWJQWMTOJU;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x3E9A8B0", Offset = "0x3E994B0", VA = "0x183E9A8B0", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5D19F00", Offset = "0x5D18B00", VA = "0x185D19F00")]
		public SRVLOPKVHHC(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5D19E30", Offset = "0x5D18A30", VA = "0x185D19E30", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x505D440", Offset = "0x505C040", VA = "0x18505D440", Slot = "6")]
		private IEnumerator VDVERRYCFPI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class RFIERWANVIX<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> KRRHTMUXJXR;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x5ABE9F0", Offset = "0x5ABD5F0", VA = "0x185ABE9F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public RFIERWANVIX(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5ABE860", Offset = "0x5ABD460", VA = "0x185ABE860", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x5ABE950", Offset = "0x5ABD550", VA = "0x185ABE950", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5ABE950", Offset = "0x5ABD550", VA = "0x185ABE950", Slot = "7")]
		private IEnumerator VDVERRYCFPI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class KLJOPKYQQHC<a> : YBQFBVYECUF<a>, KMSROFZLDAO where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5162A60", Offset = "0x5161660", VA = "0x185162A60", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5162840", Offset = "0x5161440", VA = "0x185162840", Slot = "5")]
		public a Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public KLJOPKYQQHC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class PBLCKLLRAQK : YBQFBVYECUF<IEnumerable>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly YBQFBVYECUF<IEnumerable> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8D44D30", Offset = "0x8D43930", VA = "0x188D44D30", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8D44B20", Offset = "0x8D43720", VA = "0x188D44B20", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public PBLCKLLRAQK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class ZICVLQXBOPC : YBQFBVYECUF<ICollection>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly YBQFBVYECUF<ICollection> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8D51130", Offset = "0x8D4FD30", VA = "0x188D51130", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8D50F20", Offset = "0x8D4FB20", VA = "0x188D50F20", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public ZICVLQXBOPC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class ZCSJDXKEMYU : YBQFBVYECUF<IList>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly YBQFBVYECUF<IList> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8D50860", Offset = "0x8D4F460", VA = "0x188D50860", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8D50650", Offset = "0x8D4F250", VA = "0x188D50650", Slot = "5")]
		public IList Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public ZCSJDXKEMYU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class OMZOAQXJOQX<a> : KQSJUFPDIJO<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD21F0", Offset = "0x3DD0DF0", VA = "0x183DD21F0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x58D3790", Offset = "0x58D2390", VA = "0x1858D3790", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class TEKGQOIXKCR<a> : KQXQRMJARUX<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD21F0", Offset = "0x3DD0DF0", VA = "0x183DD21F0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x58D3790", Offset = "0x58D2390", VA = "0x1858D3790", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5E18A50", Offset = "0x5E17650", VA = "0x185E18A50", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class NYOFQPIMJLX<a> : KQXQRMJARUX<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5706020", Offset = "0x5704C20", VA = "0x185706020", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530D3E0", VA = "0x18530E7E0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x57B00F0", Offset = "0x57AECF0", VA = "0x1857B00F0", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x57B01B0", Offset = "0x57AEDB0", VA = "0x1857B01B0")]
		public NYOFQPIMJLX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class MJZYBMWKROV<a> : KQXQRMJARUX<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5706020", Offset = "0x5704C20", VA = "0x185706020", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530D3E0", VA = "0x18530E7E0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5706090", Offset = "0x5704C90", VA = "0x185706090", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3E99490", Offset = "0x3E98090", VA = "0x183E99490")]
		public MJZYBMWKROV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class BJPIWPKLQUL<a> : KQXQRMJARUX<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x579E530", Offset = "0x579D130", VA = "0x18579E530", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xAF79E0", Offset = "0xAF65E0", VA = "0x180AF79E0", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x3CFCFB0", Offset = "0x3CFBBB0", VA = "0x183CFCFB0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class IHAQSKNYIBL<a> : KQSJUFPDIJO<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD21F0", Offset = "0x3DD0DF0", VA = "0x183DD21F0", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD22D0", Offset = "0x3DD0ED0", VA = "0x183DD22D0", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class AIUWNYLQKKW<a> : KQSJUFPDIJO<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD21F0", Offset = "0x3DD0DF0", VA = "0x183DD21F0", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3DD22D0", Offset = "0x3DD0ED0", VA = "0x183DD22D0", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class ASFVDIWAJLN<a> : KQXQRMJARUX<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x52767D0", Offset = "0x52753D0", VA = "0x1852767D0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x530E7E0", Offset = "0x530D3E0", VA = "0x18530E7E0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x530E680", Offset = "0x530D280", VA = "0x18530E680", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class BBKKIOZXQVQ
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
		[Cpp2IlInjected.Address(RVA = "0x8D397D0", Offset = "0x8D383D0", VA = "0x188D397D0")]
		public static DateTime LSWWHRJCSSW(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8D39620", Offset = "0x8D38220", VA = "0x188D39620")]
		public static bool KFIZHCHLEER(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8D39180", Offset = "0x8D37D80", VA = "0x188D39180")]
		public static bool DPJZVDUTAWJ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8D39410", Offset = "0x8D38010", VA = "0x188D39410")]
		public static bool DPJZVDUTAWJ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8D39890", Offset = "0x8D38490", VA = "0x188D39890")]
		public static bool SQTVPASECOT(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class ZYSHQARUSRY : YBQFBVYECUF<DateTime>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly YBQFBVYECUF<DateTime> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8D52650", Offset = "0x8D51250", VA = "0x188D52650", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8D524D0", Offset = "0x8D510D0", VA = "0x188D524D0", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8D520D0", Offset = "0x8D50CD0", VA = "0x188D520D0")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public ZYSHQARUSRY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class NYCFYRKLPUP : YBQFBVYECUF<DateTimeOffset>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly YBQFBVYECUF<DateTimeOffset> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8D43D80", Offset = "0x8D42980", VA = "0x188D43D80", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8D43D10", Offset = "0x8D42910", VA = "0x188D43D10", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8D43930", Offset = "0x8D42530", VA = "0x188D43930")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public NYCFYRKLPUP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class EVPQKUVNONM : YBQFBVYECUF<TimeSpan>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly YBQFBVYECUF<TimeSpan> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] OTQQDKLARES;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B7A0", Offset = "0x8D3A3A0", VA = "0x188D3B7A0", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B330", Offset = "0x8D39F30", VA = "0x188D3B330", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B3B0", Offset = "0x8D39FB0", VA = "0x188D3B3B0")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public EVPQKUVNONM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class FIRQTNZWSNT<a, b, c, d, e> : YBQFBVYECUF<e>, KMSROFZLDAO where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x4C6FDB0", Offset = "0x4C6E9B0", VA = "0x184C6FDB0", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x4C69B60", Offset = "0x4C68760", VA = "0x184C69B60", Slot = "5")]
		public e Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d TLHDAFGBUVU(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		protected FIRQTNZWSNT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class FIMJWHFZJCK<a, b, c, d> : FIRQTNZWSNT<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x4C69410", Offset = "0x4C68010", VA = "0x184C69410", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> TLHDAFGBUVU(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		protected FIMJWHFZJCK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class FHMBJZKMNXR<a, b, c> : FIMJWHFZJCK<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xAF79E0", Offset = "0xAF65E0", VA = "0x180AF79E0", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class UEFWOWZWODL<a, b> : FIRQTNZWSNT<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6024A90", Offset = "0x6023690", VA = "0x186024A90", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xAF79E0", Offset = "0xAF65E0", VA = "0x180AF79E0", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6024C10", Offset = "0x6023810", VA = "0x186024C10", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6024CD0", Offset = "0x60238D0", VA = "0x186024CD0", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator TLHDAFGBUVU(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x52B2F20", Offset = "0x52B1B20", VA = "0x1852B2F20")]
		public UEFWOWZWODL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class KGJZLEABVZR<a, b, c> : FHMBJZKMNXR<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5159110", Offset = "0x5157D10", VA = "0x185159110", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x51592F0", Offset = "0x5157EF0", VA = "0x1851592F0", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class VVJIOJNQQEK<a, b> : FIMJWHFZJCK<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0170", Offset = "0x3DBED70", VA = "0x183DC0170", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3DC02E0", Offset = "0x3DBEEE0", VA = "0x183DC02E0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xAF79E0", Offset = "0xAF65E0", VA = "0x180AF79E0", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class LEOWZGGFHXI<a, b> : FHMBJZKMNXR<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0170", Offset = "0x3DBED70", VA = "0x183DC0170", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC02E0", Offset = "0x3DBEEE0", VA = "0x183DC02E0", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class XDQQGDYYSNA<a, b> : FIRQTNZWSNT<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0170", Offset = "0x3DBED70", VA = "0x183DC0170", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xAF79E0", Offset = "0xAF65E0", VA = "0x180AF79E0", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC02E0", Offset = "0x3DBEEE0", VA = "0x183DC02E0", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0340", Offset = "0x3DBEF40", VA = "0x183DC0340", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator TLHDAFGBUVU(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class YVJREOXYUGL<a, b> : FIMJWHFZJCK<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3DC0170", Offset = "0x3DBED70", VA = "0x183DC0170", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3E46EA0", Offset = "0x3E45AA0", VA = "0x183E46EA0", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3E46F10", Offset = "0x3E45B10", VA = "0x183E46F10", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class IAYOZGXQPTK<a, b> : FIMJWHFZJCK<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x4EFF8B0", Offset = "0x4EFE4B0", VA = "0x184EFF8B0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xAF79E0", Offset = "0xAF65E0", VA = "0x180AF79E0", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x4EFF8F0", Offset = "0x4EFE4F0", VA = "0x184EFF8F0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x4EFF9B0", Offset = "0x4EFE5B0", VA = "0x184EFF9B0")]
		public IAYOZGXQPTK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class TCAUEVOSSGK<a, b> : FHMBJZKMNXR<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E14D00", Offset = "0x5E13900", VA = "0x185E14D00", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3DC02E0", Offset = "0x3DBEEE0", VA = "0x183DC02E0", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class GMNFDGUGIVW<a> : YBQFBVYECUF<a>, KMSROFZLDAO where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x4D956F0", Offset = "0x4D942F0", VA = "0x184D956F0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x4D954C0", Offset = "0x4D940C0", VA = "0x184D954C0", Slot = "5")]
		public a Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public GMNFDGUGIVW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class WHRAPRYAEHW : YBQFBVYECUF<IDictionary>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly YBQFBVYECUF<IDictionary> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D4C310", Offset = "0x8D4AF10", VA = "0x188D4C310", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8D4C130", Offset = "0x8D4AD30", VA = "0x188D4C130", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public WHRAPRYAEHW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class LIEDEIWLHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8D3E560", Offset = "0x8D3D160", VA = "0x188D3E560")]
		public static object VLQWJYLCICO(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DD20", Offset = "0x8D3C920", VA = "0x188D3DD20")]
		public static object JCBVIULKTWD(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class GWDUTVVUHBF<a> : YBQFBVYECUF<a>, KMSROFZLDAO, OGKQHBQDQPC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class OIJSTNCODXH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type TYTIIADQMLB;

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public OIJSTNCODXH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x58C7020", Offset = "0x58C5C20", VA = "0x1858C7020")]
			internal bool BZEHPUFDFVI(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class OIELWGIQULY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string TWEHWYMSEAN;

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public OIELWGIQULY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x58C6A00", Offset = "0x58C5600", VA = "0x1858C6A00")]
			internal bool BZJONAZAPGR(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class OHZEYZOTLAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> ORXCAAGXMCS;

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public OHZEYZOTLAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x58C64D0", Offset = "0x58C50D0", VA = "0x1858C64D0")]
			internal void BYTTVGRIMYQ(JsonWriter a, a b, ROQGPFJHMXC c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class OHTYBSUWBPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> UBPTIGXJVFB;

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public OHTYBSUWBPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x58C5FA0", Offset = "0x58C4BA0", VA = "0x1858C5FA0")]
			internal a BYZASNLFWJZ(JsonReader a, ROQGPFJHMXC b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly KTAIIECQAEG<a> XZOBQYXCMPH;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> QHBQEWKLGQL;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> FOBIVRXVFOF;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> BZUJLBOSMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool MAEBRUKMDRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> UTJHEBORMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> NXFWXBHNZQV;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x4DA2020", Offset = "0x4DA0C20", VA = "0x184DA2020")]
		static GWDUTVVUHBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x4DAD4A0", Offset = "0x4DAC0A0", VA = "0x184DAD4A0")]
		public GWDUTVVUHBF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x4DA1D40", Offset = "0x4DA0940", VA = "0x184DA1D40", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x4D9EDE0", Offset = "0x4D9D9E0", VA = "0x184D9EDE0", Slot = "5")]
		public a Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x4DA0EE0", Offset = "0x4D9FAE0", VA = "0x184DA0EE0", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, a b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x4DA0180", Offset = "0x4D9ED80", VA = "0x184DA0180", Slot = "7")]
		public a GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class JQPKMQXVOFT<a> : YBQFBVYECUF<a[,]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x50682D0", Offset = "0x5066ED0", VA = "0x1850682D0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5067F40", Offset = "0x5066B40", VA = "0x185067F40", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public JQPKMQXVOFT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class OTAJXXEESID<a> : YBQFBVYECUF<a[,,]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5910540", Offset = "0x590F140", VA = "0x185910540", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x5910070", Offset = "0x590EC70", VA = "0x185910070", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public OTAJXXEESID()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class TOKMMEYNAWN<a> : YBQFBVYECUF<a[,,,]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E42890", Offset = "0x5E41490", VA = "0x185E42890", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E42290", Offset = "0x5E40E90", VA = "0x185E42290", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public TOKMMEYNAWN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class XMJNYWZSYRR<a> : YBQFBVYECUF<a?>, KMSROFZLDAO where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x3DCBC90", Offset = "0x3DCA890", VA = "0x183DCBC90", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x3DCBA20", Offset = "0x3DCA620", VA = "0x183DCBA20", Slot = "5")]
		public a? Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public XMJNYWZSYRR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class VAJLSFWNASJ<a> : YBQFBVYECUF<a?>, KMSROFZLDAO where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly YBQFBVYECUF<a> UXPHLMGLQGG;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xA9A4F0", Offset = "0xA990F0", VA = "0x180A9A4F0")]
		public VAJLSFWNASJ(YBQFBVYECUF<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x613A880", Offset = "0x6139480", VA = "0x18613A880", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x613A450", Offset = "0x6139050", VA = "0x18613A450", Slot = "5")]
		public a? Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class DPZUJZLXMCU : YBQFBVYECUF<sbyte>, KMSROFZLDAO, OGKQHBQDQPC<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly DPZUJZLXMCU YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D39FE0", Offset = "0x8D38BE0", VA = "0x188D39FE0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D39E40", Offset = "0x8D38A40", VA = "0x188D39E40", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8D39ED0", Offset = "0x8D38AD0", VA = "0x188D39ED0", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, sbyte b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8D39E50", Offset = "0x8D38A50", VA = "0x188D39E50", Slot = "7")]
		public sbyte GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public DPZUJZLXMCU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class DVAIVSETZAZ : YBQFBVYECUF<sbyte?>, KMSROFZLDAO, OGKQHBQDQPC<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly DVAIVSETZAZ YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A570", Offset = "0x8D39170", VA = "0x188D3A570", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A2D0", Offset = "0x8D38ED0", VA = "0x188D3A2D0", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A410", Offset = "0x8D39010", VA = "0x188D3A410", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, sbyte? b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A340", Offset = "0x8D38F40", VA = "0x188D3A340", Slot = "7")]
		public sbyte? GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public DVAIVSETZAZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class TSTRROUHCDV : YBQFBVYECUF<sbyte[]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly TSTRROUHCDV YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8D48060", Offset = "0x8D46C60", VA = "0x188D48060", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8D47F20", Offset = "0x8D46B20", VA = "0x188D47F20", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public TSTRROUHCDV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class LUOREDEEOID : YBQFBVYECUF<short>, KMSROFZLDAO, OGKQHBQDQPC<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly LUOREDEEOID YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8D40DF0", Offset = "0x8D3F9F0", VA = "0x188D40DF0", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8D40C50", Offset = "0x8D3F850", VA = "0x188D40C50", Slot = "5")]
		public short Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8D40CE0", Offset = "0x8D3F8E0", VA = "0x188D40CE0", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, short b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D40C60", Offset = "0x8D3F860", VA = "0x188D40C60", Slot = "7")]
		public short GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public LUOREDEEOID()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class SRRUIFKITPQ : YBQFBVYECUF<short?>, KMSROFZLDAO, OGKQHBQDQPC<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly SRRUIFKITPQ YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8D47820", Offset = "0x8D46420", VA = "0x188D47820", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8D47580", Offset = "0x8D46180", VA = "0x188D47580", Slot = "5")]
		public short? Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8D476C0", Offset = "0x8D462C0", VA = "0x188D476C0", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, short? b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8D475F0", Offset = "0x8D461F0", VA = "0x188D475F0", Slot = "7")]
		public short? GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public SRRUIFKITPQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class YEVUIEAQGNY : YBQFBVYECUF<short[]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly YEVUIEAQGNY YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8D4FFD0", Offset = "0x8D4EBD0", VA = "0x188D4FFD0", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8D4FE90", Offset = "0x8D4EA90", VA = "0x188D4FE90", Slot = "5")]
		public short[] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public YEVUIEAQGNY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class ONCEYPUOSGN : YBQFBVYECUF<int>, KMSROFZLDAO, OGKQHBQDQPC<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly ONCEYPUOSGN YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8D44A20", Offset = "0x8D43620", VA = "0x188D44A20", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8D44880", Offset = "0x8D43480", VA = "0x188D44880", Slot = "5")]
		public int Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8D44910", Offset = "0x8D43510", VA = "0x188D44910", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, int b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8D44890", Offset = "0x8D43490", VA = "0x188D44890", Slot = "7")]
		public int GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public ONCEYPUOSGN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class JWOKVHSULNG : YBQFBVYECUF<int?>, KMSROFZLDAO, OGKQHBQDQPC<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly JWOKVHSULNG YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D9D0", Offset = "0x8D3C5D0", VA = "0x188D3D9D0", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D730", Offset = "0x8D3C330", VA = "0x188D3D730", Slot = "5")]
		public int? Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D870", Offset = "0x8D3C470", VA = "0x188D3D870", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, int? b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D7A0", Offset = "0x8D3C3A0", VA = "0x188D3D7A0", Slot = "7")]
		public int? GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public JWOKVHSULNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class YPRHCZAOENC : YBQFBVYECUF<int[]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly YPRHCZAOENC YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8D503B0", Offset = "0x8D4EFB0", VA = "0x188D503B0", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8D50270", Offset = "0x8D4EE70", VA = "0x188D50270", Slot = "5")]
		public int[] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public YPRHCZAOENC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class DRJETFKXQNS : YBQFBVYECUF<long>, KMSROFZLDAO, OGKQHBQDQPC<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly DRJETFKXQNS YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A200", Offset = "0x8D38E00", VA = "0x188D3A200", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A0E0", Offset = "0x8D38CE0", VA = "0x188D3A0E0", Slot = "5")]
		public long Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A130", Offset = "0x8D38D30", VA = "0x188D3A130", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, long b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8D3A0F0", Offset = "0x8D38CF0", VA = "0x188D3A0F0", Slot = "7")]
		public long GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public DRJETFKXQNS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class NTZXVHNCMCZ : YBQFBVYECUF<long?>, KMSROFZLDAO, OGKQHBQDQPC<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly NTZXVHNCMCZ YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x8D43800", Offset = "0x8D42400", VA = "0x188D43800", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8D43590", Offset = "0x8D42190", VA = "0x188D43590", Slot = "5")]
		public long? Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8D436D0", Offset = "0x8D422D0", VA = "0x188D436D0", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, long? b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8D43620", Offset = "0x8D42220", VA = "0x188D43620", Slot = "7")]
		public long? GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public NTZXVHNCMCZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class LVCZNYXFOKD : YBQFBVYECUF<long[]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly LVCZNYXFOKD YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8D41030", Offset = "0x8D3FC30", VA = "0x188D41030", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8D40EF0", Offset = "0x8D3FAF0", VA = "0x188D40EF0", Slot = "5")]
		public long[] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public LVCZNYXFOKD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class ZWCAZCRSUIV : YBQFBVYECUF<byte>, KMSROFZLDAO, OGKQHBQDQPC<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly ZWCAZCRSUIV YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8D51FD0", Offset = "0x8D50BD0", VA = "0x188D51FD0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8D51E30", Offset = "0x8D50A30", VA = "0x188D51E30", Slot = "5")]
		public byte Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8D51EC0", Offset = "0x8D50AC0", VA = "0x188D51EC0", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, byte b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8D51E40", Offset = "0x8D50A40", VA = "0x188D51E40", Slot = "7")]
		public byte GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public ZWCAZCRSUIV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class ZITZKATSKBQ : YBQFBVYECUF<byte?>, KMSROFZLDAO, OGKQHBQDQPC<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly ZITZKATSKBQ YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8D51880", Offset = "0x8D50480", VA = "0x188D51880", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8D515E0", Offset = "0x8D501E0", VA = "0x188D515E0", Slot = "5")]
		public byte? Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8D51720", Offset = "0x8D50320", VA = "0x188D51720", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, byte? b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8D51650", Offset = "0x8D50250", VA = "0x188D51650", Slot = "7")]
		public byte? GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public ZITZKATSKBQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class EBGWUWWAFEO : YBQFBVYECUF<ushort>, KMSROFZLDAO, OGKQHBQDQPC<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly EBGWUWWAFEO YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B080", Offset = "0x8D39C80", VA = "0x188D3B080", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AEE0", Offset = "0x8D39AE0", VA = "0x188D3AEE0", Slot = "5")]
		public ushort Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AF70", Offset = "0x8D39B70", VA = "0x188D3AF70", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, ushort b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8D3AEF0", Offset = "0x8D39AF0", VA = "0x188D3AEF0", Slot = "7")]
		public ushort GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public EBGWUWWAFEO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class XGCMYHDQOCB : YBQFBVYECUF<ushort?>, KMSROFZLDAO, OGKQHBQDQPC<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly XGCMYHDQOCB YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F040", Offset = "0x8D4DC40", VA = "0x188D4F040", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EDA0", Offset = "0x8D4D9A0", VA = "0x188D4EDA0", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EEE0", Offset = "0x8D4DAE0", VA = "0x188D4EEE0", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, ushort? b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EE10", Offset = "0x8D4DA10", VA = "0x188D4EE10", Slot = "7")]
		public ushort? GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public XGCMYHDQOCB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class PHFNMWXCNSB : YBQFBVYECUF<ushort[]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly PHFNMWXCNSB YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x8D451F0", Offset = "0x8D43DF0", VA = "0x188D451F0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8D450B0", Offset = "0x8D43CB0", VA = "0x188D450B0", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public PHFNMWXCNSB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class ZDHXSQAEZXS : YBQFBVYECUF<uint>, KMSROFZLDAO, OGKQHBQDQPC<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly ZDHXSQAEZXS YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8D50E20", Offset = "0x8D4FA20", VA = "0x188D50E20", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8D50C80", Offset = "0x8D4F880", VA = "0x188D50C80", Slot = "5")]
		public uint Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8D50D10", Offset = "0x8D4F910", VA = "0x188D50D10", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, uint b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8D50C90", Offset = "0x8D4F890", VA = "0x188D50C90", Slot = "7")]
		public uint GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public ZDHXSQAEZXS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class VVDNTTLYDLF : YBQFBVYECUF<uint?>, KMSROFZLDAO, OGKQHBQDQPC<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly VVDNTTLYDLF YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8D49890", Offset = "0x8D48490", VA = "0x188D49890", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8D495F0", Offset = "0x8D481F0", VA = "0x188D495F0", Slot = "5")]
		public uint? Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x8D49730", Offset = "0x8D48330", VA = "0x188D49730", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, uint? b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8D49660", Offset = "0x8D48260", VA = "0x188D49660", Slot = "7")]
		public uint? GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public VVDNTTLYDLF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class NPCPDMHNDGH : YBQFBVYECUF<uint[]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly NPCPDMHNDGH YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x8D430C0", Offset = "0x8D41CC0", VA = "0x188D430C0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8D42F80", Offset = "0x8D41B80", VA = "0x188D42F80", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public NPCPDMHNDGH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class PQYJMEINBNH : YBQFBVYECUF<ulong>, KMSROFZLDAO, OGKQHBQDQPC<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly PQYJMEINBNH YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8D45700", Offset = "0x8D44300", VA = "0x188D45700", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8D455E0", Offset = "0x8D441E0", VA = "0x188D455E0", Slot = "5")]
		public ulong Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8D45630", Offset = "0x8D44230", VA = "0x188D45630", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, ulong b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8D455F0", Offset = "0x8D441F0", VA = "0x188D455F0", Slot = "7")]
		public ulong GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public PQYJMEINBNH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class HHYAHDNHVIC : YBQFBVYECUF<ulong?>, KMSROFZLDAO, OGKQHBQDQPC<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly HHYAHDNHVIC YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CA60", Offset = "0x8D3B660", VA = "0x188D3CA60", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C7F0", Offset = "0x8D3B3F0", VA = "0x188D3C7F0", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C930", Offset = "0x8D3B530", VA = "0x188D3C930", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, ulong? b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C880", Offset = "0x8D3B480", VA = "0x188D3C880", Slot = "7")]
		public ulong? GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public HHYAHDNHVIC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class CYKWQYXXMZO : YBQFBVYECUF<ulong[]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly CYKWQYXXMZO YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8D39C00", Offset = "0x8D38800", VA = "0x188D39C00", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8D39AC0", Offset = "0x8D386C0", VA = "0x188D39AC0", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public CYKWQYXXMZO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class NNQXRUXSVHJ : YBQFBVYECUF<float>, KMSROFZLDAO, OGKQHBQDQPC<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly NNQXRUXSVHJ YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8D42EB0", Offset = "0x8D41AB0", VA = "0x188D42EB0", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8D42D90", Offset = "0x8D41990", VA = "0x188D42D90", Slot = "5")]
		public float Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8D42DE0", Offset = "0x8D419E0", VA = "0x188D42DE0", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, float b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x8D42DA0", Offset = "0x8D419A0", VA = "0x188D42DA0", Slot = "7")]
		public float GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public NNQXRUXSVHJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class HOBASHCECPC : YBQFBVYECUF<float?>, KMSROFZLDAO, OGKQHBQDQPC<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly HOBASHCECPC YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CDC0", Offset = "0x8D3B9C0", VA = "0x188D3CDC0", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CB90", Offset = "0x8D3B790", VA = "0x188D3CB90", Slot = "5")]
		public float? Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CCA0", Offset = "0x8D3B8A0", VA = "0x188D3CCA0", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, float? b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CC00", Offset = "0x8D3B800", VA = "0x188D3CC00", Slot = "7")]
		public float? GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public HOBASHCECPC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class UDVQGVDOWRY : YBQFBVYECUF<float[]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly UDVQGVDOWRY YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8D48C30", Offset = "0x8D47830", VA = "0x188D48C30", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8D48AF0", Offset = "0x8D476F0", VA = "0x188D48AF0", Slot = "5")]
		public float[] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public UDVQGVDOWRY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class UOTSQVSOGCQ : YBQFBVYECUF<double>, KMSROFZLDAO, OGKQHBQDQPC<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly UOTSQVSOGCQ YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8D490E0", Offset = "0x8D47CE0", VA = "0x188D490E0", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8D48FC0", Offset = "0x8D47BC0", VA = "0x188D48FC0", Slot = "5")]
		public double Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8D49010", Offset = "0x8D47C10", VA = "0x188D49010", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, double b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8D48FD0", Offset = "0x8D47BD0", VA = "0x188D48FD0", Slot = "7")]
		public double GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public UOTSQVSOGCQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class GLAHIQDPGHZ : YBQFBVYECUF<double?>, KMSROFZLDAO, OGKQHBQDQPC<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly GLAHIQDPGHZ YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C4D0", Offset = "0x8D3B0D0", VA = "0x188D3C4D0", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C260", Offset = "0x8D3AE60", VA = "0x188D3C260", Slot = "5")]
		public double? Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C3A0", Offset = "0x8D3AFA0", VA = "0x188D3C3A0", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, double? b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C2F0", Offset = "0x8D3AEF0", VA = "0x188D3C2F0", Slot = "7")]
		public double? GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public GLAHIQDPGHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class IBZLVRRMJGX : YBQFBVYECUF<double[]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly IBZLVRRMJGX YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D030", Offset = "0x8D3BC30", VA = "0x188D3D030", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8D3CEF0", Offset = "0x8D3BAF0", VA = "0x188D3CEF0", Slot = "5")]
		public double[] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public IBZLVRRMJGX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class GGJZHJIPWSR : YBQFBVYECUF<bool>, KMSROFZLDAO, OGKQHBQDQPC<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly GGJZHJIPWSR YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C190", Offset = "0x8D3AD90", VA = "0x188D3C190", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C070", Offset = "0x8D3AC70", VA = "0x188D3C070", Slot = "5")]
		public bool Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C0C0", Offset = "0x8D3ACC0", VA = "0x188D3C0C0", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, bool b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C080", Offset = "0x8D3AC80", VA = "0x188D3C080", Slot = "7")]
		public bool GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public GGJZHJIPWSR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class YDKOKJAKLDG : YBQFBVYECUF<bool?>, KMSROFZLDAO, OGKQHBQDQPC<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly YDKOKJAKLDG YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8D4FD60", Offset = "0x8D4E960", VA = "0x188D4FD60", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8D4FB30", Offset = "0x8D4E730", VA = "0x188D4FB30", Slot = "5")]
		public bool? Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8D4FC40", Offset = "0x8D4E840", VA = "0x188D4FC40", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, bool? b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x8D4FBA0", Offset = "0x8D4E7A0", VA = "0x188D4FBA0", Slot = "7")]
		public bool? GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public YDKOKJAKLDG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class VWLMDWZRHFK : YBQFBVYECUF<bool[]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly VWLMDWZRHFK YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x8D49B30", Offset = "0x8D48730", VA = "0x188D49B30", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x8D499F0", Offset = "0x8D485F0", VA = "0x188D499F0", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public VWLMDWZRHFK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class XKRJWAOUFGQ : YBQFBVYECUF<byte[]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly YBQFBVYECUF<byte[]> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F440", Offset = "0x8D4E040", VA = "0x188D4F440", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F3D0", Offset = "0x8D4DFD0", VA = "0x188D4F3D0", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public XKRJWAOUFGQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class UUUOYNXBYOP : YBQFBVYECUF<ArraySegment<byte>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly YBQFBVYECUF<ArraySegment<byte>> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x8D49450", Offset = "0x8D48050", VA = "0x188D49450", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x8D49380", Offset = "0x8D47F80", VA = "0x188D49380", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public UUUOYNXBYOP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class ZUVECFYVUWP : YBQFBVYECUF<string>, KMSROFZLDAO, OGKQHBQDQPC<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly YBQFBVYECUF<string> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8D51D60", Offset = "0x8D50960", VA = "0x188D51D60", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8D51CF0", Offset = "0x8D508F0", VA = "0x188D51CF0", Slot = "5")]
		public string Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8D51D00", Offset = "0x8D50900", VA = "0x188D51D00", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, string b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8D51CF0", Offset = "0x8D508F0", VA = "0x188D51CF0", Slot = "7")]
		public string GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public ZUVECFYVUWP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class ICUOQAWQFXQ : YBQFBVYECUF<string[]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly ICUOQAWQFXQ YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D500", Offset = "0x8D3C100", VA = "0x188D3D500", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x8D3D3B0", Offset = "0x8D3BFB0", VA = "0x188D3D3B0", Slot = "5")]
		public string[] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public ICUOQAWQFXQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class PNYTEMWOENR : YBQFBVYECUF<char>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly PNYTEMWOENR YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8D454C0", Offset = "0x8D440C0", VA = "0x188D454C0", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8D45490", Offset = "0x8D44090", VA = "0x188D45490", Slot = "5")]
		public char Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public PNYTEMWOENR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class XJPUPUBOLKU : YBQFBVYECUF<char?>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly XJPUPUBOLKU YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F260", Offset = "0x8D4DE60", VA = "0x188D4F260", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F1A0", Offset = "0x8D4DDA0", VA = "0x188D4F1A0", Slot = "5")]
		public char? Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public XJPUPUBOLKU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class QVNHZYZYVYG : YBQFBVYECUF<char[]>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly QVNHZYZYVYG YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D472C0", Offset = "0x8D45EC0", VA = "0x188D472C0", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D47130", Offset = "0x8D45D30", VA = "0x188D47130", Slot = "5")]
		public char[] Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public QVNHZYZYVYG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class XSKKEIDSXQI : YBQFBVYECUF<Guid>, KMSROFZLDAO, OGKQHBQDQPC<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly YBQFBVYECUF<Guid> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F7C0", Offset = "0x8D4E3C0", VA = "0x188D4F7C0", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F570", Offset = "0x8D4E170", VA = "0x188D4F570", Slot = "5")]
		public Guid Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F640", Offset = "0x8D4E240", VA = "0x188D4F640", Slot = "6")]
		public void HOFPHNZTDHW(JsonWriter a, Guid b, ROQGPFJHMXC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F5D0", Offset = "0x8D4E1D0", VA = "0x188D4F5D0", Slot = "7")]
		public Guid GVPAFDQXSFO(JsonReader a, ROQGPFJHMXC b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public XSKKEIDSXQI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class AZUYIKHOOUQ : YBQFBVYECUF<decimal>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly YBQFBVYECUF<decimal> YNAVUHJMGMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool EKBHKRHHATE;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x714BB60", Offset = "0x714A760", VA = "0x18714BB60")]
		public AZUYIKHOOUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xD7C7B0", Offset = "0xD7B3B0", VA = "0x180D7C7B0")]
		public AZUYIKHOOUQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8D38F30", Offset = "0x8D37B30", VA = "0x188D38F30", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x8D38D60", Offset = "0x8D37960", VA = "0x188D38D60", Slot = "5")]
		public decimal Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class UQGZAIYRBFV : YBQFBVYECUF<Uri>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly YBQFBVYECUF<Uri> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8D49230", Offset = "0x8D47E30", VA = "0x188D49230", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8D491B0", Offset = "0x8D47DB0", VA = "0x188D491B0", Slot = "5")]
		public Uri Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public UQGZAIYRBFV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class EGHPMNNDTBT : YBQFBVYECUF<Version>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly YBQFBVYECUF<Version> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B200", Offset = "0x8D39E00", VA = "0x188D3B200", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x8D3B180", Offset = "0x8D39D80", VA = "0x188D3B180", Slot = "5")]
		public Version Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public EGHPMNNDTBT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class NIKOTOUOUDT<a, b> : YBQFBVYECUF<KeyValuePair<a, b>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5798FA0", Offset = "0x5797BA0", VA = "0x185798FA0", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5798AD0", Offset = "0x57976D0", VA = "0x185798AD0", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class XXOSXVTFXFX : YBQFBVYECUF<StringBuilder>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly YBQFBVYECUF<StringBuilder> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8D4FA20", Offset = "0x8D4E620", VA = "0x188D4FA20", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8D4F9A0", Offset = "0x8D4E5A0", VA = "0x188D4F9A0", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public XXOSXVTFXFX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class WTKVBLAYKUP : YBQFBVYECUF<BitArray>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly YBQFBVYECUF<BitArray> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D4DA70", Offset = "0x8D4C670", VA = "0x188D4DA70", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D4D950", Offset = "0x8D4C550", VA = "0x188D4D950", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public WTKVBLAYKUP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class ZTDFDEYFZFV : YBQFBVYECUF<Type>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ZTDFDEYFZFV YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex UPKFHEVNRYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool XCPQYAHCAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool CECUPSUTHWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool FNCTRAYMKSW;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8D51CD0", Offset = "0x8D508D0", VA = "0x188D51CD0")]
		public ZTDFDEYFZFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x80892A0", Offset = "0x8087EA0", VA = "0x1880892A0")]
		public ZTDFDEYFZFV(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8D51AF0", Offset = "0x8D506F0", VA = "0x188D51AF0", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x8D519E0", Offset = "0x8D505E0", VA = "0x188D519E0", Slot = "5")]
		public Type Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class HFFROEFADUP : YBQFBVYECUF<BigInteger>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly YBQFBVYECUF<BigInteger> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C6B0", Offset = "0x8D3B2B0", VA = "0x188D3C6B0", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D3C600", Offset = "0x8D3B200", VA = "0x188D3C600", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public HFFROEFADUP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class NSYVXMRCWQF : YBQFBVYECUF<Complex>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly YBQFBVYECUF<Complex> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8D433F0", Offset = "0x8D41FF0", VA = "0x188D433F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8D43360", Offset = "0x8D41F60", VA = "0x188D43360", Slot = "5")]
		public Complex Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public NSYVXMRCWQF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class LUKCKAPWGXF : YBQFBVYECUF<ExpandoObject>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly YBQFBVYECUF<ExpandoObject> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8D40B50", Offset = "0x8D3F750", VA = "0x188D40B50", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D40920", Offset = "0x8D3F520", VA = "0x188D40920", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public LUKCKAPWGXF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class CRVWBSRIMXU<a> : YBQFBVYECUF<Lazy<a>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x3CFB130", Offset = "0x3CF9D30", VA = "0x183CFB130", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x3CFAF40", Offset = "0x3CF9B40", VA = "0x183CFAF40", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class JZRMGXPMRDM : YBQFBVYECUF<Task>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly YBQFBVYECUF<Task> YNAVUHJMGMQ;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task VHGCZRKOFDD;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DBE0", Offset = "0x8D3C7E0", VA = "0x188D3DBE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8D3DB30", Offset = "0x8D3C730", VA = "0x188D3DB30", Slot = "5")]
		public Task Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public JZRMGXPMRDM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class TLTPRWUZITS<a> : YBQFBVYECUF<Task<a>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E387A0", Offset = "0x5E373A0", VA = "0x185E387A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E38630", Offset = "0x5E37230", VA = "0x185E38630", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class KZKYPZTXKJM<a> : YBQFBVYECUF<ValueTask<a>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x519BFC0", Offset = "0x519ABC0", VA = "0x18519BFC0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x519BDA0", Offset = "0x519A9A0", VA = "0x18519BDA0", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class EJMBJXYAZNC<a> : YBQFBVYECUF<Tuple<a>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x466C680", Offset = "0x466B280", VA = "0x18466C680", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x466C3B0", Offset = "0x466AFB0", VA = "0x18466C3B0", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class EKBWBSFTBVD<a, b> : YBQFBVYECUF<Tuple<a, b>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x466DA60", Offset = "0x466C660", VA = "0x18466DA60", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x466D640", Offset = "0x466C240", VA = "0x18466D640", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class EJWPELLVSJU<a, b, c> : YBQFBVYECUF<Tuple<a, b, c>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x466CFC0", Offset = "0x466BBC0", VA = "0x18466CFC0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x466CA50", Offset = "0x466B650", VA = "0x18466CA50", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class EKMJWFTNURV<a, b, c, d> : YBQFBVYECUF<Tuple<a, b, c, d>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x466F7B0", Offset = "0x466E3B0", VA = "0x18466F7B0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x466F0F0", Offset = "0x466DCF0", VA = "0x18466F0F0", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class EKHCYYZQLGM<a, b, c, d, e> : YBQFBVYECUF<Tuple<a, b, c, d, e>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x466E790", Offset = "0x466D390", VA = "0x18466E790", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x466DF80", Offset = "0x466CB80", VA = "0x18466DF80", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class EKWXQTHINON<a, b, c, d, e, f> : YBQFBVYECUF<Tuple<a, b, c, d, e, f>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x46720B0", Offset = "0x4670CB0", VA = "0x1846720B0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x4671710", Offset = "0x4670310", VA = "0x184671710", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class EKRQTMNLEDE<a, b, c, d, e, f, g> : YBQFBVYECUF<Tuple<a, b, c, d, e, f, g>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x4670AD0", Offset = "0x466F6D0", VA = "0x184670AD0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x466FFB0", Offset = "0x466EBB0", VA = "0x18466FFB0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class EIBFDCOTLLR<a, b, c, d, e, f, g, h> : YBQFBVYECUF<Tuple<a, b, c, d, e, f, g, h>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x466B5A0", Offset = "0x466A1A0", VA = "0x18466B5A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x466A910", Offset = "0x4669510", VA = "0x18466A910", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class WKCNMWONMNV<a> : YBQFBVYECUF<ValueTuple<a>>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x64C6000", Offset = "0x64C4C00", VA = "0x1864C6000", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x64C5BE0", Offset = "0x64C47E0", VA = "0x1864C5BE0", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class WKHUKDIKVZE<a, b> : YBQFBVYECUF<(a, b)>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x64C7340", Offset = "0x64C5F40", VA = "0x1864C7340", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x64C6E50", Offset = "0x64C5A50", VA = "0x1864C6E50", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class WKNBHKCIFKN<a, b, c> : YBQFBVYECUF<(a, b, c)>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x64C8060", Offset = "0x64C6C60", VA = "0x1864C8060", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x64C79F0", Offset = "0x64C65F0", VA = "0x1864C79F0", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class WJCFAOTARJC<a, b, c, d> : YBQFBVYECUF<(a, b, c, d)>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x64C0B30", Offset = "0x64BF730", VA = "0x1864C0B30", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x64C02F0", Offset = "0x64BEEF0", VA = "0x1864C02F0", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class WJHLXVMYAUL<a, b, c, d, e> : YBQFBVYECUF<(a, b, c, d, e)>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x64C1DE0", Offset = "0x64C09E0", VA = "0x1864C1DE0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x64C1420", Offset = "0x64C0020", VA = "0x1864C1420", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class WJMSVCGVKFU<a, b, c, d, e, f> : YBQFBVYECUF<(a, b, c, d, e, f)>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x64C3440", Offset = "0x64C2040", VA = "0x1864C3440", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x64C2870", Offset = "0x64C1470", VA = "0x1864C2870", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class WJRZSJASTRD<a, b, c, d, e, f, g> : YBQFBVYECUF<(a, b, c, d, e, f, g)>, KMSROFZLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x64C4E00", Offset = "0x64C3A00", VA = "0x1864C4E00", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x64C4080", Offset = "0x64C2C80", VA = "0x1864C4080", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class WLNJTRXVAPG<a, b, c, d, e, f, g, h> : YBQFBVYECUF<ValueTuple<a, b, c, d, e, f, g, h>>, KMSROFZLDAO where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] UIJVCMPQJAH;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly YCFEOKPOEBD ZGHRWNQBKUH;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x64CBE00", Offset = "0x64CAA00", VA = "0x1864CBE00", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, ROQGPFJHMXC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x64CAED0", Offset = "0x64C9AD0", VA = "0x1864CAED0", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, ROQGPFJHMXC formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class FWULTBQQPBZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] TGWLNMQJBKZ;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly YCFEOKPOEBD YWNYPRLHIAE;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8D3BEC0", Offset = "0x8D3AAC0", VA = "0x188D3BEC0")]
		static FWULTBQQPBZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class AGBEYOZVWOF
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] DNTNQLLEINK;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly YCFEOKPOEBD AISYRRJFQXH;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x8D38BB0", Offset = "0x8D377B0", VA = "0x188D38BB0")]
		static AGBEYOZVWOF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class WKKNREUFJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] NKKJSZLTFHL;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly YCFEOKPOEBD OLYBVHFMDPI;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] NJUPBFEBCZK;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly YCFEOKPOEBD OLSUYALOUDZ;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] NJZVYLXYMKT;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly YCFEOKPOEBD OLNOATRRKSQ;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] NJKBGRQGKCS;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly YCFEOKPOEBD OLIHDMXUBHH;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] NJPIDYKDTOB;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly YCFEOKPOEBD OLDAGGDWRVY;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] NIZNMECLRGA;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly YCFEOKPOEBD OKXTIZJZIKP;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] NJEUJKWJARJ;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly YCFEOKPOEBD OKSMLSQBYZG;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] NIOZRQOQYJI;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly YCFEOKPOEBD OKNFOLWEPNX;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x8D4C970", Offset = "0x8D4B570", VA = "0x188D4C970")]
		static WKKNREUFJFJ()
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
