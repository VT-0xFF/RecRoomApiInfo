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
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, DAAAJKHFHWQ resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, DAAAJKHFHWQ resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface NPBHYFEKIHM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface UAJNQMCKSSZ<a> : NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, DAAAJKHFHWQ formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface YAABEUOLKLS<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XQXQXLLXTOQ(JsonWriter a, a b, DAAAJKHFHWQ c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b);
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
	public static class JRXQVYJIHIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x39B3E30", Offset = "0x39B2C30", VA = "0x1839B3E30")]
		public static string ToJsonString<T>(this UAJNQMCKSSZ<T> formatter, T value, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		UAJNQMCKSSZ<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class WBCWRJSTKZL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3E84D20", Offset = "0x3E83B20", VA = "0x183E84D20")]
		public static UAJNQMCKSSZ<a> UKWQERTTWDO<a>(this DAAAJKHFHWQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x90F55D0", Offset = "0x90F43D0", VA = "0x1890F55D0")]
		public static object PSMPBJKKNXY(this DAAAJKHFHWQ a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x90E65D0", Offset = "0x90E53D0", VA = "0x1890E65D0")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class CBNTLRWQCTK
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] BGIPDVHAKRB;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] ZJOZAEZEIGC;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] AFENLPANZKX;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] HTGSCNYRYCK;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] WOGVTOTTDVH;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] TYIMPSEPMKQ;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] GPLEYMKJOQO;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] IWTOBFVZCDJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class MZXDRPJHNFZ : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x90EFBC0", Offset = "0x90EE9C0", VA = "0x1890EFBC0")]
				public MZXDRPJHNFZ(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x90EFAA0", Offset = "0x90EE8A0", VA = "0x1890EFAA0")]
				public MZXDRPJHNFZ TIHQEOECWVV(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class EQTWBWCJSBW
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] KRYFJTCOODX;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] JGSNIEPYIZE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private MZXDRPJHNFZ start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private MZXDRPJHNFZ end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x90F0690", Offset = "0x90EF490", VA = "0x1890F0690")]
			public void TIHQEOECWVV([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x90F0550", Offset = "0x90EF350", VA = "0x1890F0550")]
			public void TIHQEOECWVV(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x90F0420", Offset = "0x90EF220", VA = "0x1890F0420")]
			public ReadOnlySequence<byte> NNMFGKXLNYE()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x90F0270", Offset = "0x90EF070", VA = "0x1890F0270")]
			private void BDIINRBBIEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x90F07A0", Offset = "0x90EF5A0", VA = "0x1890F07A0")]
			private void WATHRAALZPU([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x90EDBA0", Offset = "0x90EC9A0", VA = "0x1890EDBA0")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x90EBC20", Offset = "0x90EAA20", VA = "0x1890EBC20")]
		private JsonParsingException HJGWEHMZUYO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x90ECA50", Offset = "0x90EB850", VA = "0x1890ECA50")]
		private JsonParsingException NYIYEAMROUN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x90EC660", Offset = "0x90EB460", VA = "0x1890EC660")]
		public void KIVFYIMBMDG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x90EC440", Offset = "0x90EB240", VA = "0x1890EC440")]
		public JsonToken JQBVDOVDQFT()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x90ED720", Offset = "0x90EC520", VA = "0x1890ED720")]
		public void YLWYTCQBSSF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x90ED2E0", Offset = "0x90EC0E0", VA = "0x1890ED2E0")]
		private bool WXXVZFNDWXJ(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x90ED340", Offset = "0x90EC140", VA = "0x1890ED340")]
		private bool WXXVZFNDWXJ(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x90EB5B0", Offset = "0x90EA3B0", VA = "0x1890EB5B0")]
		private void GHUOIIIWOMK(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x90ECB60", Offset = "0x90EB960", VA = "0x1890ECB60")]
		public bool PYOJGPPEXQG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x90EAC30", Offset = "0x90E9A30", VA = "0x1890EAC30")]
		public void BOGRCEQLITC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x90EB250", Offset = "0x90EA050", VA = "0x1890EB250")]
		public bool EEPGUVJTICF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x90EB660", Offset = "0x90EA460", VA = "0x1890EB660")]
		public void GJQSEPPEVYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x90ECE30", Offset = "0x90EBC30", VA = "0x1890ECE30")]
		public void UDPBROWWPAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x90EAA70", Offset = "0x90E9870", VA = "0x1890EAA70")]
		public bool AXYPZHQSSYT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x90ECC90", Offset = "0x90EBA90", VA = "0x1890ECC90")]
		public void RFCNAPIXFJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x90EC650", Offset = "0x90EB450", VA = "0x1890EC650")]
		public void JZEHESJCXAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x90EDA70", Offset = "0x90EC870", VA = "0x1890EDA70")]
		public bool ZGMOSTKMLSG(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x90EC310", Offset = "0x90EB110", VA = "0x1890EC310")]
		public bool IETZXANTBCQ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x90EA990", Offset = "0x90E9790", VA = "0x1890EA990")]
		public bool AWMKHYTDHOD(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x90EB740", Offset = "0x90EA540", VA = "0x1890EB740")]
		private ReadOnlySequence<byte> HAOHCXZSHCM()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x90ED3A0", Offset = "0x90EC1A0", VA = "0x1890ED3A0")]
		private ReadOnlySequence<byte> XFTRZJFDKOP()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x90EC120", Offset = "0x90EAF20", VA = "0x1890EC120")]
		private void HLWNNMMBPRB(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x90ECE40", Offset = "0x90EBC40", VA = "0x1890ECE40")]
		private void UFSFCWBJUDY(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x90EC760", Offset = "0x90EB560", VA = "0x1890EC760")]
		private void NNRUZHWOGIN(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x90ED610", Offset = "0x90EC410", VA = "0x1890ED610")]
		private void XNVCHAMZBXW(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x90E26D0", Offset = "0x90E14D0", VA = "0x1890E26D0")]
		private static int AWUSEJQZIFF(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x90EB670", Offset = "0x90EA470", VA = "0x1890EB670")]
		public ReadOnlySequence<byte> GPPZPBRNWLH()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x90EAF90", Offset = "0x90E9D90", VA = "0x1890EAF90")]
		public string CZQCNHNNSPY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x90EB2A0", Offset = "0x90EA0A0", VA = "0x1890EB2A0")]
		public string EIRGTJSYSNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x90EB430", Offset = "0x90EA230", VA = "0x1890EB430")]
		public ReadOnlySequence<byte> EWZSZBNWHZB()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x90ECD50", Offset = "0x90EBB50", VA = "0x1890ECD50")]
		public ReadOnlySequence<byte> TFKGOELNWRC()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x90EB2E0", Offset = "0x90EA0E0", VA = "0x1890EB2E0")]
		public bool EMOXTBPCODD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x90EAAC0", Offset = "0x90E98C0", VA = "0x1890EAAC0")]
		private void BLSIDGLORCN(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x90ED040", Offset = "0x90EBE40", VA = "0x1890ED040")]
		public void UMMEVCMFPYD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x90EB010", Offset = "0x90E9E10", VA = "0x1890EB010")]
		private void EEBZBLQVOZC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x90EAEE0", Offset = "0x90E9CE0", VA = "0x1890EAEE0")]
		public sbyte CZCJIVWENMW()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x90EC6B0", Offset = "0x90EB4B0", VA = "0x1890EC6B0")]
		public short KQOIIWCNISP()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x90ED950", Offset = "0x90EC750", VA = "0x1890ED950")]
		public int YNAIUAJDVQZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x90ECC20", Offset = "0x90EBA20", VA = "0x1890ECC20")]
		public long QOXFUORASIO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x90ED050", Offset = "0x90EBE50", VA = "0x1890ED050")]
		public byte UXSQDIBNWON()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x90EB500", Offset = "0x90EA300", VA = "0x1890EB500")]
		public ushort EZDIXTLGIMY()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x90ECCA0", Offset = "0x90EBAA0", VA = "0x1890ECCA0")]
		public uint RZJARSXGMLI()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x90EDA00", Offset = "0x90EC800", VA = "0x1890EDA00")]
		public ulong ZBPNBBYIKQJ()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x90EC3A0", Offset = "0x90EB1A0", VA = "0x1890EC3A0")]
		public float JAJIBMKFASH()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x90EDB00", Offset = "0x90EC900", VA = "0x1890EDB00")]
		public double ZRHTJHOQOLQ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x90ED100", Offset = "0x90EBF00", VA = "0x1890ED100")]
		public ReadOnlySequence<byte> VXRPRCTZMBZ()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x90EAC40", Offset = "0x90E9A40", VA = "0x1890EAC40")]
		private void CEGEYCIQYPT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class JsonParsingException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string ActualChar
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB880F0", Offset = "0xB86EF0", VA = "0x180B880F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x90EA930", Offset = "0x90E9730", VA = "0x1890EA930")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x90EA8B0", Offset = "0x90E96B0", VA = "0x1890EA8B0")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class DFFMKAWPATD
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class TLHPDGPQATQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] KRYFJTCOODX;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x90F0990", Offset = "0x90EF790", VA = "0x1890F0990")]
			public static byte[] HLBSDEVPSLJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static DAAAJKHFHWQ GQCYWSHGWGG;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] BHTYQBBYBVH;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] VWMAMBMMAHP;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static DAAAJKHFHWQ EHDOJBFCVAG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x90E49A0", Offset = "0x90E37A0", VA = "0x1890E49A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x90E4A90", Offset = "0x90E3890", VA = "0x1890E4A90")]
		public static void IHUMFVWDYEM(DAAAJKHFHWQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x37A2C20", Offset = "0x37A1A20", VA = "0x1837A2C20")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x37A2DE0", Offset = "0x37A1BE0", VA = "0x1837A2DE0")]
		public static byte[] Serialize<T>(T value, DAAAJKHFHWQ resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x37A3620", Offset = "0x37A2420", VA = "0x1837A3620")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x37A34A0", Offset = "0x37A22A0", VA = "0x1837A34A0")]
		public static string ToJsonString<T>(T value, DAAAJKHFHWQ resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x37A2740", Offset = "0x37A1540", VA = "0x1837A2740")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x37A23A0", Offset = "0x37A11A0", VA = "0x1837A23A0")]
		public static T Deserialize<T>(string json, DAAAJKHFHWQ resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x37A2670", Offset = "0x37A1470", VA = "0x1837A2670")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x37A25A0", Offset = "0x37A13A0", VA = "0x1837A25A0")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, DAAAJKHFHWQ resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x37A1FC0", Offset = "0x37A0DC0", VA = "0x1837A1FC0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x37A21D0", Offset = "0x37A0FD0", VA = "0x1837A21D0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, DAAAJKHFHWQ resolver)
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
		public int WGHIJZZRNKL
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xF7C730", Offset = "0xF7B530", VA = "0x180F7C730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x90EE9B0", Offset = "0x90ED7B0", VA = "0x1890EE9B0")]
		public void KIVFYIMBMDG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x90EED60", Offset = "0x90EDB60", VA = "0x1890EED60")]
		public static byte[] ROBNFPDKFYP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x90EDF40", Offset = "0x90ECD40", VA = "0x1890EDF40")]
		public static byte[] GEDAAXOYDKL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x90EE1C0", Offset = "0x90ECFC0", VA = "0x1890EE1C0")]
		public static byte[] IJHCYOTUILN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x90EDDC0", Offset = "0x90ECBC0", VA = "0x1890EDDC0")]
		public static byte[] FAXBJRPACKR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2A277A0", Offset = "0x2A265A0", VA = "0x182A277A0")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x90EE080", Offset = "0x90ECE80", VA = "0x1890EE080")]
		public ArraySegment<byte> HLBSDEVPSLJ()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x90EEA30", Offset = "0x90ED830", VA = "0x1890EEA30")]
		public byte[] KYSMXBAXZWU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x90EEEF0", Offset = "0x90EDCF0", VA = "0x1890EEEF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x90EEC40", Offset = "0x90EDA40", VA = "0x1890EEC40")]
		public void NCUUHYOAZGB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x90EEE40", Offset = "0x90EDC40", VA = "0x1890EEE40")]
		public void SGQBCDUIIRK(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x90EEC50", Offset = "0x90EDA50", VA = "0x1890EEC50")]
		public void PPZPFPEHTLQ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4090CF0", Offset = "0x408FAF0", VA = "0x184090CF0")]
		public void YGCYEHKGFMQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4090CA0", Offset = "0x408FAA0", VA = "0x184090CA0")]
		public void WLQOZUFREUU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x90EEC90", Offset = "0x90EDA90", VA = "0x1890EEC90")]
		public void QHSBOXUTFHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x90EED10", Offset = "0x90EDB10", VA = "0x1890EED10")]
		public void QTZSOSEPXEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4090C50", Offset = "0x408FA50", VA = "0x184090C50")]
		public void PTKUVKIOXMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x52F4080", Offset = "0x52F2E80", VA = "0x1852F4080")]
		public void QSPHHQUNMWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x90EE120", Offset = "0x90ECF20", VA = "0x1890EE120")]
		public void HXVBNRBRRTC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x90EEEA0", Offset = "0x90EDCA0", VA = "0x1890EEEA0")]
		public void TUKSZNELDPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4090BB0", Offset = "0x408F9B0", VA = "0x184090BB0")]
		public void FADPHSYVVQP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7A65010", Offset = "0x7A63E10", VA = "0x187A65010")]
		public void FRYJFQGZHPY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x90EDD40", Offset = "0x90ECB40", VA = "0x1890EDD40")]
		public void BQZRNRZITWK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x90EEBC0", Offset = "0x90ED9C0", VA = "0x1890EEBC0")]
		public void LRUJBFIVGLJ(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x90EE940", Offset = "0x90ED740", VA = "0x1890EE940")]
		public void JJVYSPZABXG(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x90EF040", Offset = "0x90EDE40", VA = "0x1890EF040")]
		public void WXCTMMUVRKJ(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x90EE350", Offset = "0x90ED150", VA = "0x1890EE350")]
		public void JCGWFKRKBYT(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x90EDD10", Offset = "0x90ECB10", VA = "0x1890EDD10")]
		public void BACLITRHRXK(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x90EE9C0", Offset = "0x90ED7C0", VA = "0x1890EE9C0")]
		public void KOGOONLPNIN(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x90EEFD0", Offset = "0x90EDDD0", VA = "0x1890EEFD0")]
		public void VLPNGHCMWHS(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x90EE2E0", Offset = "0x90ED0E0", VA = "0x1890EE2E0")]
		public void ILVFAGONAGC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x90EECE0", Offset = "0x90EDAE0", VA = "0x1890EECE0")]
		public void QNZPWXOPKHL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x90EE3C0", Offset = "0x90ED1C0", VA = "0x1890EE3C0")]
		public void JHMWJPYDWYT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x90EEF50", Offset = "0x90EDD50", VA = "0x1890EEF50")]
		private static bool VLFWZNWQONN(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x90EE060", Offset = "0x90ECE60", VA = "0x1890EE060")]
		private static byte GLFBRXSOVZH(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x90E2790", Offset = "0x90E1590", VA = "0x1890E2790")]
		private static void ZSLFBUUPKYW(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class BUUHETELWNZ : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x4961020", Offset = "0x495FE20", VA = "0x184961020")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private BUUHETELWNZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class BIKYVTESODW : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x4967A60", Offset = "0x4966860", VA = "0x184967A60")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class GFKGXUMJGMS
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> NBICHNCUSOH;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x90E6630", Offset = "0x90E5430", VA = "0x1890E6630")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private BIKYVTESODW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class BGSNOLEMQGM : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x496C640", Offset = "0x496B440", VA = "0x18496C640")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly BGSNOLEMQGM GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool XTZDYOKTYBW;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static NPBHYFEKIHM[] QNWPAIBSQKE;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static DAAAJKHFHWQ[] LFIATJMCHGG;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private BGSNOLEMQGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x90E3F00", Offset = "0x90E2D00", VA = "0x1890E3F00")]
		public static void PUOFOOQAOVA(params DAAAJKHFHWQ[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x90E3FD0", Offset = "0x90E2DD0", VA = "0x1890E3FD0")]
		public static void PUOFOOQAOVA(params NPBHYFEKIHM[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x90E3CA0", Offset = "0x90E2AA0", VA = "0x1890E3CA0")]
		public static void HQLUAIXZRYW(NPBHYFEKIHM[] a, DAAAJKHFHWQ[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class IGKSOWYRCDZ : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x4963870", Offset = "0x4962670", VA = "0x184963870")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private IGKSOWYRCDZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class GFQLBHUKQGY
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly DAAAJKHFHWQ GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly DAAAJKHFHWQ MLYLDYPFTWF;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class QHFTBGCQKFS
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly DAAAJKHFHWQ GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly DAAAJKHFHWQ YLECTUMAPJV;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly DAAAJKHFHWQ MHPISZQXMOV;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly DAAAJKHFHWQ ROSLWTYWZWO;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly DAAAJKHFHWQ LPINVJYEMJW;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly DAAAJKHFHWQ ZNQGAQRMTHA;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly DAAAJKHFHWQ DWANBAKZLWL;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly DAAAJKHFHWQ UMIJXIVIVTF;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly DAAAJKHFHWQ IVNJFRXTFWV;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly DAAAJKHFHWQ TGEAMMJWXCS;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly DAAAJKHFHWQ WNOQPDGRFGU;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly DAAAJKHFHWQ KUDFTIGLPSO;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class TUVKMDCMUKF
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> NBICHNCUSOH;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x90F0A70", Offset = "0x90EF870", VA = "0x1890F0A70")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x90F0A30", Offset = "0x90EF830", VA = "0x1890F0A30")]
		private static object EDIJNJIAYYM(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class QIFHSYWBBRH : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x49655D0", Offset = "0x49643D0", VA = "0x1849655D0")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private QIFHSYWBBRH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class RXGTCDRXTSU : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x4968C80", Offset = "0x4967A80", VA = "0x184968C80")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private RXGTCDRXTSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class HWEOTGUCYWI
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly DAAAJKHFHWQ[] IYHEFSLXATX;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class JCVGWZRCAJZ : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4964510", Offset = "0x4963310", VA = "0x184964510")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class DJXCHERSKRF : DAAAJKHFHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class EJXCIMZDRXS<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x49616B0", Offset = "0x49604B0", VA = "0x1849616B0")]
				static EJXCIMZDRXS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly DAAAJKHFHWQ[] LFIATJMCHGG;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			private DJXCHERSKRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
			public UAJNQMCKSSZ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly UAJNQMCKSSZ<object> IIIJDIHDOQF;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private JCVGWZRCAJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class ANQDOWISXRC : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x4969EF0", Offset = "0x4968CF0", VA = "0x184969EF0")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class DJXCHERSKRF : DAAAJKHFHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class EJXCIMZDRXS<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x4960150", Offset = "0x495EF50", VA = "0x184960150")]
				static EJXCIMZDRXS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly DAAAJKHFHWQ[] LFIATJMCHGG;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			private DJXCHERSKRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
			public UAJNQMCKSSZ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly UAJNQMCKSSZ<object> IIIJDIHDOQF;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private ANQDOWISXRC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class PHMGUMBGRNI : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x496C340", Offset = "0x496B140", VA = "0x18496C340")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class DJXCHERSKRF : DAAAJKHFHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class EJXCIMZDRXS<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x4960D60", Offset = "0x495FB60", VA = "0x184960D60")]
				static EJXCIMZDRXS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly DAAAJKHFHWQ[] LFIATJMCHGG;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			private DJXCHERSKRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
			public UAJNQMCKSSZ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly UAJNQMCKSSZ<object> IIIJDIHDOQF;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private PHMGUMBGRNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class JHFBPBSAUTD : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x496C040", Offset = "0x496AE40", VA = "0x18496C040")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class DJXCHERSKRF : DAAAJKHFHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class EJXCIMZDRXS<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x4967900", Offset = "0x4966700", VA = "0x184967900")]
				static EJXCIMZDRXS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly DAAAJKHFHWQ[] LFIATJMCHGG;

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			private DJXCHERSKRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
			public UAJNQMCKSSZ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly UAJNQMCKSSZ<object> IIIJDIHDOQF;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private JHFBPBSAUTD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class CKAMCNHTENJ : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x496ACE0", Offset = "0x4969AE0", VA = "0x18496ACE0")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class DJXCHERSKRF : DAAAJKHFHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class EJXCIMZDRXS<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x4963A60", Offset = "0x4962860", VA = "0x184963A60")]
				static EJXCIMZDRXS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly DAAAJKHFHWQ[] LFIATJMCHGG;

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			private DJXCHERSKRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
			public UAJNQMCKSSZ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly UAJNQMCKSSZ<object> IIIJDIHDOQF;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private CKAMCNHTENJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class FDZOSHCGHZX : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x4967300", Offset = "0x4966100", VA = "0x184967300")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class DJXCHERSKRF : DAAAJKHFHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class EJXCIMZDRXS<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

				[Cpp2IlInjected.Token(Token = "0x60000DE")]
				[Cpp2IlInjected.Address(RVA = "0x496D0C0", Offset = "0x496BEC0", VA = "0x18496D0C0")]
				static EJXCIMZDRXS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly DAAAJKHFHWQ[] LFIATJMCHGG;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			private DJXCHERSKRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
			public UAJNQMCKSSZ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly UAJNQMCKSSZ<object> IIIJDIHDOQF;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private FDZOSHCGHZX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class DVXYJBBSHHW : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x4966090", Offset = "0x4964E90", VA = "0x184966090")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class DJXCHERSKRF : DAAAJKHFHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class EJXCIMZDRXS<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x496A1F0", Offset = "0x4968FF0", VA = "0x18496A1F0")]
				static EJXCIMZDRXS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly DAAAJKHFHWQ[] LFIATJMCHGG;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			private DJXCHERSKRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
			public UAJNQMCKSSZ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly UAJNQMCKSSZ<object> IIIJDIHDOQF;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private DVXYJBBSHHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class UJLCIWXKOSQ : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x4969260", Offset = "0x4968060", VA = "0x184969260")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class DJXCHERSKRF : DAAAJKHFHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class EJXCIMZDRXS<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x4960EC0", Offset = "0x495FCC0", VA = "0x184960EC0")]
				static EJXCIMZDRXS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly DAAAJKHFHWQ[] LFIATJMCHGG;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			private DJXCHERSKRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
			public UAJNQMCKSSZ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly UAJNQMCKSSZ<object> IIIJDIHDOQF;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private UJLCIWXKOSQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class MCRSHQVPZGS : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x4962110", Offset = "0x4960F10", VA = "0x184962110")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class DJXCHERSKRF : DAAAJKHFHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class EJXCIMZDRXS<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x49629F0", Offset = "0x49617F0", VA = "0x1849629F0")]
				static EJXCIMZDRXS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly DAAAJKHFHWQ[] LFIATJMCHGG;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			private DJXCHERSKRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
			public UAJNQMCKSSZ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly UAJNQMCKSSZ<object> IIIJDIHDOQF;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private MCRSHQVPZGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class MYTIXYUSWCB : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x4961E10", Offset = "0x4960C10", VA = "0x184961E10")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class DJXCHERSKRF : DAAAJKHFHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class EJXCIMZDRXS<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x496B8E0", Offset = "0x496A6E0", VA = "0x18496B8E0")]
				static EJXCIMZDRXS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly DAAAJKHFHWQ[] LFIATJMCHGG;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			private DJXCHERSKRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
			public UAJNQMCKSSZ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly UAJNQMCKSSZ<object> IIIJDIHDOQF;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private MYTIXYUSWCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class MDTRMZYMJRJ : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x496B2E0", Offset = "0x496A0E0", VA = "0x18496B2E0")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class DJXCHERSKRF : DAAAJKHFHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class EJXCIMZDRXS<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x49608B0", Offset = "0x495F6B0", VA = "0x1849608B0")]
				static EJXCIMZDRXS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly DAAAJKHFHWQ[] LFIATJMCHGG;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			private DJXCHERSKRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
			public UAJNQMCKSSZ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly UAJNQMCKSSZ<object> IIIJDIHDOQF;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private MDTRMZYMJRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class AWEFJSIFVVL : DAAAJKHFHWQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class EJXCIMZDRXS<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x495FE50", Offset = "0x495EC50", VA = "0x18495FE50")]
			static EJXCIMZDRXS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class DJXCHERSKRF : DAAAJKHFHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class EJXCIMZDRXS<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly UAJNQMCKSSZ<a> GQBEQHYNJGD;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x4961550", Offset = "0x4960350", VA = "0x184961550")]
				static EJXCIMZDRXS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly DAAAJKHFHWQ[] LFIATJMCHGG;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			private DJXCHERSKRF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
			public UAJNQMCKSSZ<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly DAAAJKHFHWQ GUIRZRNRSLG;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly UAJNQMCKSSZ<object> IIIJDIHDOQF;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		private AWEFJSIFVVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3292E20", Offset = "0x3291C20", VA = "0x183292E20", Slot = "4")]
		public UAJNQMCKSSZ<T> GetFormatter<T>()
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

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x59533F0", Offset = "0x59521F0", VA = "0x1859533F0")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x59530F0", Offset = "0x5951EF0", VA = "0x1859530F0")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5953360", Offset = "0x5952160", VA = "0x185953360")]
		public T[] CGTPUCJMRRV()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class DZSIIVSBUMN<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int IMXGBJWYVCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object XKVFPWHRFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int CVPZGQUGLTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] DHHBSMFKMWO;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4315950", Offset = "0x4314750", VA = "0x184315950")]
		public DZSIIVSBUMN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4315280", Offset = "0x4314080", VA = "0x184315280")]
		public a[] OZSPSKCGAQM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4315710", Offset = "0x4314510", VA = "0x184315710")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class VIRUOWKNFEZ : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class VDAJYWQSWGB : IComparable<VDAJYWQSWGB>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class JBCLLNCHLJL : IEnumerable<VDAJYWQSWGB>, IEnumerable, IEnumerator<VDAJYWQSWGB>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int YSBBACYODYD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private VDAJYWQSWGB QSNUDDCEMPO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int DQRPPGNAYPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public VDAJYWQSWGB WFAEFPOXIOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int ZTWVKUQIWZR;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private VDAJYWQSWGB FTIKWSJOGQW
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object OXAJVRVSDJL
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
				[DebuggerHidden]
				public JBCLLNCHLJL(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
				[DebuggerHidden]
				private void HQYJSAUBZEC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x90EA710", Offset = "0x90E9510", VA = "0x1890EA710", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x90EA630", Offset = "0x90E9430", VA = "0x1890EA630", Slot = "10")]
				[DebuggerHidden]
				private void EYXYBZSNHNN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x90EA670", Offset = "0x90E9470", VA = "0x1890EA670", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<VDAJYWQSWGB> LODXMTZYRER()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x90EA670", Offset = "0x90E9470", VA = "0x1890EA670", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator UYQUPSIMXFE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly VDAJYWQSWGB[] RFDFOEOZBXH;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] UPQVARBBHBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong DCXGLLCDHCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int REKHREVTQMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string NNRDCOAVAZZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private VDAJYWQSWGB[] PTRXQYACUMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] JIHNJKCRLMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int GDMCUOBENXU;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x90F40F0", Offset = "0x90F2EF0", VA = "0x1890F40F0")]
			public VDAJYWQSWGB(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x90F3BA0", Offset = "0x90F29A0", VA = "0x1890F3BA0")]
			public VDAJYWQSWGB Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x90F3B40", Offset = "0x90F2940", VA = "0x1890F3B40")]
			public VDAJYWQSWGB Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x90F3E50", Offset = "0x90F2C50", VA = "0x1890F3E50")]
			public VDAJYWQSWGB RAVFCNTZBYX(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x90F3FC0", Offset = "0x90F2DC0", VA = "0x1890F3FC0")]
			internal static int YHKQPYFNMCW(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x90F3DA0", Offset = "0x90F2BA0", VA = "0x1890F3DA0", Slot = "4")]
			public int CompareTo(VDAJYWQSWGB other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x90F3DD0", Offset = "0x90F2BD0", VA = "0x1890F3DD0")]
			[IteratorStateMachine(typeof(JBCLLNCHLJL))]
			public IEnumerable<VDAJYWQSWGB> HVAESWGBRJN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class LPIVIHMAUOL : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<VDAJYWQSWGB> PTRXQYACUMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<VDAJYWQSWGB> ZCLEIPFFBPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<VDAJYWQSWGB> ZQJSAWQBUYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private VDAJYWQSWGB VALYEBVZFIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> ZQUFVKDWNVD;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> XFGMXNBGAYA
			{
				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x90EF8A0", Offset = "0x90EE6A0", VA = "0x1890EF8A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xBED780", Offset = "0xBEC580", VA = "0x180BED780")]
			[DebuggerHidden]
			public LPIVIHMAUOL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x90EF1B0", Offset = "0x90EDFB0", VA = "0x1890EF1B0", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x90EF3A0", Offset = "0x90EE1A0", VA = "0x1890EF3A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x90EF300", Offset = "0x90EE100", VA = "0x1890EF300")]
			private void LKISUJFCFYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x90EF350", Offset = "0x90EE150", VA = "0x1890EF350")]
			private void LKYNMDMUIGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x90EF170", Offset = "0x90EDF70", VA = "0x1890EF170", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x90EF800", Offset = "0x90EE600", VA = "0x1890EF800", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> RPHPSWHKANJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x90EF800", Offset = "0x90EE600", VA = "0x1890EF800", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly VDAJYWQSWGB BSGUJACPZOT;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x90F49F0", Offset = "0x90F37F0", VA = "0x1890F49F0")]
		public VIRUOWKNFEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x90F4480", Offset = "0x90F3280", VA = "0x1890F4480")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x90F4660", Offset = "0x90F3460", VA = "0x1890F4660")]
		public bool DBGOVWLVGUF(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x90F47D0", Offset = "0x90F35D0", VA = "0x1890F47D0")]
		public bool KIUNOZBRBJK([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x90F48E0", Offset = "0x90F36E0", VA = "0x1890F48E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x90F41A0", Offset = "0x90F2FA0", VA = "0x1890F41A0")]
		private static void ASLUJROKEJG(IEnumerable<VDAJYWQSWGB> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x90F4770", Offset = "0x90F3570", VA = "0x1890F4770", Slot = "5")]
		private IEnumerator UYQUPSIMXFE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x90F4770", Offset = "0x90F3570", VA = "0x1890F4770", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x90F4970", Offset = "0x90F3770", VA = "0x1890F4970")]
		[IteratorStateMachine(typeof(LPIVIHMAUOL))]
		private static IEnumerable<KeyValuePair<string, int>> UGCFMEXKQGX(IEnumerable<VDAJYWQSWGB> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class UOVETYZWKVU
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo RGBDEPPPBVL;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x90F3340", Offset = "0x90F2140", VA = "0x1890F3340")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x90F34F0", Offset = "0x90F22F0", VA = "0x1890F34F0")]
		public static ulong XQYXEMZFJUR(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class BLTBYATTMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x90E4460", Offset = "0x90E3260", VA = "0x1890E4460")]
		public static void NCUUHYOAZGB(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x90E4340", Offset = "0x90E3140", VA = "0x1890E4340")]
		public static void JEQFLQUGAAN(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x90E4200", Offset = "0x90E3000", VA = "0x1890E4200")]
		public static byte[] BVWLAMYLMMW(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class HCSLPQWISPQ<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x4A693B0", Offset = "0x4A681B0", VA = "0x184A693B0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class IJFTUBUHJMW : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public HCSLPQWISPQ<a> WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] ZQJSAWQBUYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int ZQOYYDJZEJU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] ZQUFVKDWNVD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int ZQZMSQXTXGM;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> AGKGAVJIALZ
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xBED410", Offset = "0xBEC210", VA = "0x180BED410", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x50F45E0", Offset = "0x50F33E0", VA = "0x1850F45E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
			[DebuggerHidden]
			public IJFTUBUHJMW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x52D9330", Offset = "0x52D8130", VA = "0x1852D9330", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x3F770A0", Offset = "0x3F75EA0", VA = "0x183F770A0", Slot = "8")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] MLZGECKZZAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong FZRNIWTFPTG;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool BNAADYZNEKN;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x51EDDF0", Offset = "0x51ECBF0", VA = "0x1851EDDF0")]
		public HCSLPQWISPQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x51EDEE0", Offset = "0x51ECCE0", VA = "0x1851EDEE0")]
		public HCSLPQWISPQ(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x51DC570", Offset = "0x51DB370", VA = "0x1851DC570")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x51E5BC0", Offset = "0x51E49C0", VA = "0x1851E5BC0")]
		private bool FOEHUJTCNMO(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x51DD800", Offset = "0x51DC600", VA = "0x1851DD800")]
		public bool DBGOVWLVGUF([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x51E9B00", Offset = "0x51E8900", VA = "0x1851E9B00")]
		private static ulong MWXZLWNBLRN([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x51ED7D0", Offset = "0x51EC5D0", VA = "0x1851ED7D0")]
		private static ulong MWXZLWNBLRN([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x51E9090", Offset = "0x51E7E90", VA = "0x1851E9090")]
		private static int LCAASZIAYYB(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x51E8E50", Offset = "0x51E7C50", VA = "0x1851E8E50", Slot = "4")]
		[IteratorStateMachine(typeof(HCSLPQWISPQ<>.IJFTUBUHJMW))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x51EDB10", Offset = "0x51EC910", VA = "0x1851EDB10", Slot = "5")]
		private IEnumerator UYQUPSIMXFE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class LSCXHKCGADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x39F1BE0", Offset = "0x39F09E0", VA = "0x1839F1BE0")]
		public static Func<a> XSMLRKVVKHT<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x39F1CD0", Offset = "0x39F0AD0", VA = "0x1839F1CD0")]
		private static c ZPNONFZVCPM<c>(this object a)
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

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x90E8F50", Offset = "0x90E7D50", VA = "0x1890E8F50")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x90E8F60", Offset = "0x90E7D60", VA = "0x1890E8F60")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x90E8DD0", Offset = "0x90E7BD0", VA = "0x1890E8DD0")]
		private static byte BROTXETFDPA(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x90E25C0", Offset = "0x90E13C0", VA = "0x1890E25C0")]
		private static byte TXBBBALWXAO(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x90E85D0", Offset = "0x90E73D0", VA = "0x1890E85D0")]
		public void BMAIBKUWEXE(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class AUTASXXNKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x90E2DE0", Offset = "0x90E1BE0", VA = "0x1890E2DE0")]
		public static bool EGIAZTWEFOK(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x90E3660", Offset = "0x90E2460", VA = "0x1890E3660")]
		public static bool TOFXRBJLQEP(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x90E2D20", Offset = "0x90E1B20", VA = "0x1890E2D20")]
		public static sbyte CZCJIVWENMW([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x90E33F0", Offset = "0x90E21F0", VA = "0x1890E33F0")]
		public static short KQOIIWCNISP([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x90E38C0", Offset = "0x90E26C0", VA = "0x1890E38C0")]
		public static int YNAIUAJDVQZ([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x90E34B0", Offset = "0x90E22B0", VA = "0x1890E34B0")]
		public static long QOXFUORASIO([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x90E3730", Offset = "0x90E2530", VA = "0x1890E3730")]
		public static bool XRCVJGTDAHZ(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x90E36D0", Offset = "0x90E24D0", VA = "0x1890E36D0")]
		public static byte UXSQDIBNWON([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x90E2FC0", Offset = "0x90E1DC0", VA = "0x1890E2FC0")]
		public static ushort EZDIXTLGIMY([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x90E3600", Offset = "0x90E2400", VA = "0x1890E3600")]
		public static uint RZJARSXGMLI([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x90E3A70", Offset = "0x90E2870", VA = "0x1890E3A70")]
		public static ulong ZBPNBBYIKQJ([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x90E3920", Offset = "0x90E2720", VA = "0x1890E3920")]
		public static bool YSLFUCZBNLM(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x90E3020", Offset = "0x90E1E20", VA = "0x1890E3020")]
		public static bool GIKAHISGVZC(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x90E31F0", Offset = "0x90E1FF0", VA = "0x1890E31F0")]
		public static bool JAHOGBGEMNA(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x90E3560", Offset = "0x90E2360", VA = "0x1890E3560")]
		public static bool RDNGXHMAHQU(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x90E3300", Offset = "0x90E2100", VA = "0x1890E3300")]
		public static float JAJIBMKFASH([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x90E3450", Offset = "0x90E2250", VA = "0x1890E3450")]
		public static bool PHKVDJEWGEI(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x90E3B20", Offset = "0x90E2920", VA = "0x1890E3B20")]
		public static double ZRHTJHOQOLQ([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x90E2D80", Offset = "0x90E1B80", VA = "0x1890E2D80")]
		public static bool DKOVAGIBSTD(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x90E1200", Offset = "0x90E0000", VA = "0x1890E1200")]
		public static int BACLITRHRXK(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x90E18B0", Offset = "0x90E06B0", VA = "0x1890E18B0")]
		public static int QNZPWXOPKHL(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x90E2DF0", Offset = "0x90E1BF0", VA = "0x1890E2DF0")]
		public static bool EMOXTBPCODD([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class SZZKSLGZXXG
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x90F01C0", Offset = "0x90EEFC0", VA = "0x1890F01C0")]
		public static bool IKVCOWYRGDU(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class HYBYZVSZTGD
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding VUWGSWSCYFG;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class DHZKTVETTBR
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x90E51D0", Offset = "0x90E3FD0", VA = "0x1890E51D0")]
		public static void FKPLTOXGWII(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x90E5240", Offset = "0x90E4040", VA = "0x1890E5240")]
		public static void FKUSQVREFTR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x90E52B0", Offset = "0x90E40B0", VA = "0x1890E52B0")]
		public static void FKZZOCLBPFA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x90E5320", Offset = "0x90E4120", VA = "0x1890E5320")]
		public static void FLFGLJEYYQJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x90E54E0", Offset = "0x90E42E0", VA = "0x1890E54E0")]
		public static void FNAQMSCBFOM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x90E5550", Offset = "0x90E4350", VA = "0x1890E5550")]
		public static void FNFXJYVYOZV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x90E5B40", Offset = "0x90E4940", VA = "0x1890E5B40")]
		public static void VFBIOHVVXPT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x90E5AD0", Offset = "0x90E48D0", VA = "0x1890E5AD0")]
		public static void VEWBRBBYOEK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x90E5A60", Offset = "0x90E4860", VA = "0x1890E5A60")]
		public static void VEQUTUIBETB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x90E59E0", Offset = "0x90E47E0", VA = "0x1890E59E0")]
		public static void VELNWNODVHS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x90E5960", Offset = "0x90E4760", VA = "0x1890E5960")]
		public static void VEGGZGUGLWJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x90E58E0", Offset = "0x90E46E0", VA = "0x1890E58E0")]
		public static void VEBACAAJCLA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x90E5860", Offset = "0x90E4660", VA = "0x1890E5860")]
		public static void VDVTETGLSZR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x90E57E0", Offset = "0x90E45E0", VA = "0x1890E57E0")]
		public static void VDQMHMMOJOI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x90E5760", Offset = "0x90E4560", VA = "0x1890E5760")]
		public static void VDLFKFSRACZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x90E56E0", Offset = "0x90E44E0", VA = "0x1890E56E0")]
		public static void VDFYMYYTQRQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x90E4D80", Offset = "0x90E3B80", VA = "0x1890E4D80")]
		public static void BZGAWRREXJA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x90E4E00", Offset = "0x90E3C00", VA = "0x1890E4E00")]
		public static void BZLHTYLCGUJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x90E4C80", Offset = "0x90E3A80", VA = "0x1890E4C80")]
		public static void BYVNCEDKEMI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x90E4D00", Offset = "0x90E3B00", VA = "0x1890E4D00")]
		public static void BZATZKXHNXR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x90E4FA0", Offset = "0x90E3DA0", VA = "0x1890E4FA0")]
		public static void CABCLSSUJCK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x90E5020", Offset = "0x90E3E20", VA = "0x1890E5020")]
		public static void CAGJIZMRSNT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x90E4E80", Offset = "0x90E3C80", VA = "0x1890E4E80")]
		public static void BZQORFEZQFS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x90E4F10", Offset = "0x90E3D10", VA = "0x1890E4F10")]
		public static void BZVVOLYWZRB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x90E50B0", Offset = "0x90E3EB0", VA = "0x1890E50B0")]
		public static void CAWEATUJUVU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x90E5140", Offset = "0x90E3F40", VA = "0x1890E5140")]
		public static void CBBKYAOHEHD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x90E5650", Offset = "0x90E4450", VA = "0x1890E5650")]
		public static void HZZHICAHBFB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x90E55C0", Offset = "0x90E43C0", VA = "0x1890E55C0")]
		public static void HZUAKVGJRTS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x90E5390", Offset = "0x90E4190", VA = "0x1890E5390")]
		public static void FLPUFWSTRNB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x90E5400", Offset = "0x90E4200", VA = "0x1890E5400")]
		public static void FLVBDDMRAYK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x90E5470", Offset = "0x90E4270", VA = "0x1890E5470")]
		public static void FMAIAKGOKJT(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class VMHMNMRKYZK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x90F4F60", Offset = "0x90F3D60", VA = "0x1890F4F60")]
		public static void FNAQMSCBFOM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x90F4FD0", Offset = "0x90F3DD0", VA = "0x1890F4FD0")]
		public static void FNFXJYVYOZV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x90F5560", Offset = "0x90F4360", VA = "0x1890F5560")]
		public static void VFBIOHVVXPT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x90F54F0", Offset = "0x90F42F0", VA = "0x1890F54F0")]
		public static void VEWBRBBYOEK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x90F5480", Offset = "0x90F4280", VA = "0x1890F5480")]
		public static void VEQUTUIBETB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x90F5410", Offset = "0x90F4210", VA = "0x1890F5410")]
		public static void VELNWNODVHS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x90F53A0", Offset = "0x90F41A0", VA = "0x1890F53A0")]
		public static void VEGGZGUGLWJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x90F5330", Offset = "0x90F4130", VA = "0x1890F5330")]
		public static void VEBACAAJCLA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x90F52C0", Offset = "0x90F40C0", VA = "0x1890F52C0")]
		public static void VDVTETGLSZR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x90F5240", Offset = "0x90F4040", VA = "0x1890F5240")]
		public static void VDQMHMMOJOI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x90F51C0", Offset = "0x90F3FC0", VA = "0x1890F51C0")]
		public static void VDLFKFSRACZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x90F5140", Offset = "0x90F3F40", VA = "0x1890F5140")]
		public static void VDFYMYYTQRQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x90F4B60", Offset = "0x90F3960", VA = "0x1890F4B60")]
		public static void BZGAWRREXJA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x90F4BE0", Offset = "0x90F39E0", VA = "0x1890F4BE0")]
		public static void BZLHTYLCGUJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x90F4A60", Offset = "0x90F3860", VA = "0x1890F4A60")]
		public static void BYVNCEDKEMI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x90F4AE0", Offset = "0x90F38E0", VA = "0x1890F4AE0")]
		public static void BZATZKXHNXR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x90F4D60", Offset = "0x90F3B60", VA = "0x1890F4D60")]
		public static void CABCLSSUJCK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x90F4DE0", Offset = "0x90F3BE0", VA = "0x1890F4DE0")]
		public static void CAGJIZMRSNT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x90F4C60", Offset = "0x90F3A60", VA = "0x1890F4C60")]
		public static void BZQORFEZQFS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x90F4CE0", Offset = "0x90F3AE0", VA = "0x1890F4CE0")]
		public static void BZVVOLYWZRB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x90F4E60", Offset = "0x90F3C60", VA = "0x1890F4E60")]
		public static void CAWEATUJUVU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x90F4EE0", Offset = "0x90F3CE0", VA = "0x1890F4EE0")]
		public static void CBBKYAOHEHD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x90F50C0", Offset = "0x90F3EC0", VA = "0x1890F50C0")]
		public static void HZZHICAHBFB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x90F5040", Offset = "0x90F3E40", VA = "0x1890F5040")]
		public static void HZUAKVGJRTS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x90E5390", Offset = "0x90E4190", VA = "0x1890E5390")]
		public static void FLPUFWSTRNB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x90E5400", Offset = "0x90E4200", VA = "0x1890E5400")]
		public static void FLVBDDMRAYK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x90E5470", Offset = "0x90E4270", VA = "0x1890E5470")]
		public static void FMAIAKGOKJT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x90E51D0", Offset = "0x90E3FD0", VA = "0x1890E51D0")]
		public static void FKPLTOXGWII(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x90E5240", Offset = "0x90E4040", VA = "0x1890E5240")]
		public static void FKUSQVREFTR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x90E52B0", Offset = "0x90E40B0", VA = "0x1890E52B0")]
		public static void FKZZOCLBPFA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x90E5320", Offset = "0x90E4120", VA = "0x1890E5320")]
		public static void FLFGLJEYYQJ(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class RALQRZYVOQO
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool BNAADYZNEKN;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x9105630", Offset = "0x9104430", VA = "0x189105630")]
		public static void SGQBCDUIIRK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x91055A0", Offset = "0x91043A0", VA = "0x1891055A0")]
		public static void SAQNILXAZER(JsonWriter a, byte[] b)
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

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x2AD1130", Offset = "0x2ACFF30", VA = "0x182AD1130")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x90F96D0", Offset = "0x90F84D0", VA = "0x1890F96D0")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x90F96C0", Offset = "0x90F84C0", VA = "0x1890F96C0")]
		public static DiyFp QHYQGHMODTD(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x90F95A0", Offset = "0x90F83A0", VA = "0x1890F95A0")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x90F9500", Offset = "0x90F8300", VA = "0x1890F9500")]
		public static DiyFp AHKUEZLBVVB(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x90F9680", Offset = "0x90F8480", VA = "0x1890F9680")]
		public void NAPAVLMVLXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x90F9630", Offset = "0x90F8430", VA = "0x1890F9630")]
		public static DiyFp NAPAVLMVLXI(DiyFp a)
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

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xDD8030", Offset = "0xDD6E30", VA = "0x180DD8030")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x9107F00", Offset = "0x9106D00", VA = "0x189107F00")]
		public void QGSBRRSKEAV(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9107D80", Offset = "0x9106B80", VA = "0x189107D80")]
		public void AZWMTJFWMWP(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9107D00", Offset = "0x9106B00", VA = "0x189107D00")]
		public void AKNTWILOXVL(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x9107C60", Offset = "0x9106A60", VA = "0x189107C60")]
		public void AKNTWILOXVL(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9107BE0", Offset = "0x91069E0", VA = "0x189107BE0")]
		public void AEVXNUINAEL(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x9107E00", Offset = "0x9106C00", VA = "0x189107E00")]
		public void NZUJZMWBJBU(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class ZZDQXWEWPNU
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
		private static byte[] TEOWCUIKSPZ;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] VZXKBBSVWXF;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] PVMVDTGDJMV;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] EHJSDHIGYQC;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags TBOPNNIWOET;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char IVKUCOAXQFX;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int JIVAGPOIZHF;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int ZIGUNZFXCHL;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] XCCNOBMBAHR;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x910EB00", Offset = "0x910D900", VA = "0x18910EB00")]
		private static byte[] JZJBAUXRXAN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x910E0E0", Offset = "0x910CEE0", VA = "0x18910E0E0")]
		private static byte[] GJNKXHMLVRP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x910FD40", Offset = "0x910EB40", VA = "0x18910FD40")]
		public static int ZEBHRTIUUAI(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x910FC20", Offset = "0x910EA20", VA = "0x18910FC20")]
		public static int ZEBHRTIUUAI(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x910DFF0", Offset = "0x910CDF0", VA = "0x18910DFF0")]
		private static bool FTPQVSRYIZG(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x910DF00", Offset = "0x910CD00", VA = "0x18910DF00")]
		private static void EQGQHRIMZDO(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x910E740", Offset = "0x910D540", VA = "0x18910E740")]
		private static bool IWEEPZNGDWS(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x910E2C0", Offset = "0x910D0C0", VA = "0x18910E2C0")]
		private static bool HREVEKBEPBU(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x910E1C0", Offset = "0x910CFC0", VA = "0x18910E1C0")]
		private static bool HODKBUNAIEJ(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x910EBD0", Offset = "0x910D9D0", VA = "0x18910EBD0")]
		private static bool MQENNTKKQXM(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x910EF80", Offset = "0x910DD80", VA = "0x18910EF80")]
		private static bool PHKHRSDSYEV(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x910F890", Offset = "0x910E690", VA = "0x18910F890")]
		private static void XQDNCHDOZPZ(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x910F450", Offset = "0x910E250", VA = "0x18910F450")]
		private static void WNEWBWFUMYH(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x910ED90", Offset = "0x910DB90", VA = "0x18910ED90")]
		private static bool NRZAGUSGEWS(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x90F9D00", Offset = "0x90F8B00", VA = "0x1890F9D00")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x90F9C60", Offset = "0x90F8A60", VA = "0x1890F9C60")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x90F9BC0", Offset = "0x90F89C0", VA = "0x1890F9BC0")]
		public DiyFp QJILIZJESHL()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x90F9730", Offset = "0x90F8530", VA = "0x1890F9730")]
		public DiyFp AWARLCCNRYW()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xB72140", Offset = "0xB70F40", VA = "0x180B72140")]
		public ulong YLYKXWEECWV()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x90F97B0", Offset = "0x90F85B0", VA = "0x1890F97B0")]
		public double BVDJFIZCYMD()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x90F99F0", Offset = "0x90F87F0", VA = "0x1890F99F0")]
		public double ILARNGGYLVZ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x90F9990", Offset = "0x90F8790", VA = "0x1890F9990")]
		public int EMMFBBVAJKM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x90F99C0", Offset = "0x90F87C0", VA = "0x1890F99C0")]
		public ulong GFKFXCEYUKS()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x90F9B80", Offset = "0x90F8980", VA = "0x1890F9B80")]
		public bool PFDLMQWFWBR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x90F96E0", Offset = "0x90F84E0", VA = "0x1890F96E0")]
		public bool AKMHQYIGPAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x90F9700", Offset = "0x90F8500", VA = "0x1890F9700")]
		public bool AOSCRIHMCFC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x90F9C30", Offset = "0x90F8A30", VA = "0x1890F9C30")]
		public bool WTOAMNFPNBZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x90F9830", Offset = "0x90F8630", VA = "0x1890F9830")]
		public int DWHQLDNSRTA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x90F9850", Offset = "0x90F8650", VA = "0x1890F9850")]
		public void EIAMBUZOAUU([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x90F9B20", Offset = "0x90F8920", VA = "0x1890F9B20")]
		public bool JEWVEZTCPQE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3E42C60", Offset = "0x3E41A60", VA = "0x183E42C60")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x90F9BA0", Offset = "0x90F89A0", VA = "0x1890F9BA0")]
		public static int PLWONMRAPXV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x90F9B70", Offset = "0x90F8970", VA = "0x1890F9B70")]
		public static double NPEXXDEVTXN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x90F9A90", Offset = "0x90F8890", VA = "0x1890F9A90")]
		public static ulong JCYGBVCPSBE(DiyFp a)
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

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x2D3A2B0", Offset = "0x2D390B0", VA = "0x182D3A2B0")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x9107B80", Offset = "0x9106980", VA = "0x189107B80")]
		public DiyFp QJILIZJESHL()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xDB2230", Offset = "0xDB1030", VA = "0x180DB2230")]
		public uint QQGMRNQVIUO()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9107AF0", Offset = "0x91068F0", VA = "0x189107AF0")]
		public int EMMFBBVAJKM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x9107B10", Offset = "0x9106910", VA = "0x189107B10")]
		public uint GFKFXCEYUKS()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9107B70", Offset = "0x9106970", VA = "0x189107B70")]
		public bool PFDLMQWFWBR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x91079C0", Offset = "0x91067C0", VA = "0x1891079C0")]
		public void EIAMBUZOAUU([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9107B30", Offset = "0x9106930", VA = "0x189107B30")]
		public bool JEWVEZTCPQE()
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

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x90F8900", Offset = "0x90F7700", VA = "0x1890F8900")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class VAXPKWRUSAP
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] VBIBCLJDPTC;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9109100", Offset = "0x9107F00", VA = "0x189109100")]
		public static void FFPBAMLBKDU(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9109210", Offset = "0x9108010", VA = "0x189109210")]
		public static void TDOVMUJEXOZ(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x910AC20", Offset = "0x9109A20", VA = "0x18910AC20")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5ACB3C0", Offset = "0x5ACA1C0", VA = "0x185ACB3C0")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D00020", Offset = "0x2CFEE20", VA = "0x182D00020")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x910ABC0", Offset = "0x91099C0", VA = "0x18910ABC0")]
		public Vector XMHKVHRGOJG(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class HZBFSXTLNJE
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] NVKEURXUFAM;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] XTYZCZWPVGP;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int AJVALILWJOC;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x90FF160", Offset = "0x90FDF60", VA = "0x1890FF160")]
		private static byte[] WPJUNBGZMGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x90FDC70", Offset = "0x90FCA70", VA = "0x1890FDC70")]
		private static Vector IJJULKPJGGK(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x90FE140", Offset = "0x90FCF40", VA = "0x1890FE140")]
		private static Vector NRHZPAHNNTI(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x90FDB50", Offset = "0x90FC950", VA = "0x1890FDB50")]
		private static void BQOJUGMKVGH(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x90FEE70", Offset = "0x90FDC70", VA = "0x1890FEE70")]
		private static void VIXWMTBWGQQ(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x90FDBE0", Offset = "0x90FC9E0", VA = "0x1890FDBE0")]
		private static ulong BSYJZTZKECN(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x90FE220", Offset = "0x90FD020", VA = "0x1890FE220")]
		private static void PFDRCTDAVWB(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x90FE9A0", Offset = "0x90FD7A0", VA = "0x1890FE9A0")]
		private static bool RCVGAQYFFCI(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x90FF240", Offset = "0x90FE040", VA = "0x1890FF240")]
		private static DiyFp XXERXXSTYAP(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x90FE360", Offset = "0x90FD160", VA = "0x1890FE360")]
		private static bool QXOZUDAGWHZ(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x90FED50", Offset = "0x90FDB50", VA = "0x1890FED50")]
		private static bool UUABUCVQBRX(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x90FE020", Offset = "0x90FCE20", VA = "0x1890FE020")]
		public static double? IYTNGTPKFGF(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x90FDD50", Offset = "0x90FCB50", VA = "0x1890FDD50")]
		public static float? IYIZMGBPMJN(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class JNJTEYALOYC
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] XHRFXYHNIVU;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] PVMVDTGDJMV;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] EHJSDHIGYQC;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] HDTBWEMAYWI;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int CSGOYUBIDAM;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] TMZIUZEWRBK;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int IYHLBAPMJJG;

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9101500", Offset = "0x9100300", VA = "0x189101500")]
		private static byte[] HLBSDEVPSLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x9102880", Offset = "0x9101680", VA = "0x189102880")]
		public static bool PHKVDJEWGEI(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9101330", Offset = "0x9100130", VA = "0x189101330")]
		public static bool DKOVAGIBSTD(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x9101200", Offset = "0x9100000", VA = "0x189101200")]
		private static bool AMYJDEHVHDY(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x91025C0", Offset = "0x91013C0", VA = "0x1891025C0")]
		private static bool PAQMSLXLGTP(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x91029C0", Offset = "0x91017C0", VA = "0x1891029C0")]
		private static bool VYEEZCKURRA(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9101470", Offset = "0x9100270", VA = "0x189101470")]
		private static bool GEICTJPWVXI(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x91014E0", Offset = "0x91002E0", VA = "0x1891014E0")]
		private static double GGIKAIBWQZL(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x91015E0", Offset = "0x91003E0", VA = "0x1891015E0")]
		private static double JFJUQSVTKTJ(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class AQIVVWSXSND<a> : UAJNQMCKSSZ<a[]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly DZSIIVSBUMN<a> IOONZSXWSQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour EXLRCRQGVPA;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x194CEF0", Offset = "0x194BCF0", VA = "0x18194CEF0")]
		public AQIVVWSXSND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
		public AQIVVWSXSND(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5686880", Offset = "0x5685680", VA = "0x185686880", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x5686540", Offset = "0x5685340", VA = "0x185686540", Slot = "5")]
		public a[] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class OSKIFJEFVHQ<a> : UAJNQMCKSSZ<ArraySegment<a>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly DZSIIVSBUMN<a> IOONZSXWSQC;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5C7D1D0", Offset = "0x5C7BFD0", VA = "0x185C7D1D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5C7CD60", Offset = "0x5C7BB60", VA = "0x185C7CD60", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class NDPQLHKCOUI<a> : UAJNQMCKSSZ<List<a>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour EXLRCRQGVPA;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x194CEF0", Offset = "0x194BCF0", VA = "0x18194CEF0")]
		public NDPQLHKCOUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAC2950", Offset = "0xAC1750", VA = "0x180AC2950")]
		public NDPQLHKCOUI(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x5ADE1C0", Offset = "0x5ADCFC0", VA = "0x185ADE1C0", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5ADC2E0", Offset = "0x5ADB0E0", VA = "0x185ADC2E0", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class ZQNSRFSBGQC<a, b, c, d> : UAJNQMCKSSZ<d>, NPBHYFEKIHM where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x4135100", Offset = "0x4133F00", VA = "0x184135100", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x4134720", Offset = "0x4133520", VA = "0x184134720", Slot = "5")]
		public d Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c JAVOUUNLMGK(d a);

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract b Create();

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void Add(b collection, int index, a value);

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract d Complete(b intermediateCollection);

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected ZQNSRFSBGQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class ZPNKEXWOLLJ<a, b, c> : ZQNSRFSBGQC<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x4131650", Offset = "0x4130450", VA = "0x184131650", Slot = "6")]
		protected override IEnumerator<a> JAVOUUNLMGK(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected ZPNKEXWOLLJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class ZPIDHRCRCAA<a, b> : ZPNKEXWOLLJ<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xB1F430", Offset = "0xB1E230", VA = "0x180B1F430", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class ZWCNLJUPEQE<a, b> : ZPIDHRCRCAA<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x41AF8D0", Offset = "0x41AE6D0", VA = "0x1841AF8D0", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x41AF760", Offset = "0x41AE560", VA = "0x1841AF760", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class YAEXXASETYX<a> : ZQNSRFSBGQC<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x409CB90", Offset = "0x409B990", VA = "0x18409CB90", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xB1F430", Offset = "0xB1E230", VA = "0x180B1F430", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x409CC80", Offset = "0x409BA80", VA = "0x18409CC80", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x409CCE0", Offset = "0x409BAE0", VA = "0x18409CCE0", Slot = "6")]
		protected override LinkedList<a>.Enumerator JAVOUUNLMGK(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class SINZSOCFBFA<a> : ZQNSRFSBGQC<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4139180", Offset = "0x4137F80", VA = "0x184139180", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x4139270", Offset = "0x4138070", VA = "0x184139270", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FFE0", Offset = "0x5E6EDE0", VA = "0x185E6FFE0", Slot = "6")]
		protected override Queue<a>.Enumerator JAVOUUNLMGK(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xB1F430", Offset = "0xB1E230", VA = "0x180B1F430", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class EZNIUARWUZM<a> : ZQNSRFSBGQC<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x40A83C0", Offset = "0x40A71C0", VA = "0x1840A83C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4A5E190", Offset = "0x4A5CF90", VA = "0x184A5E190", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x4A5E1D0", Offset = "0x4A5CFD0", VA = "0x184A5E1D0", Slot = "6")]
		protected override Stack<a>.Enumerator JAVOUUNLMGK(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x4A5E020", Offset = "0x4A5CE20", VA = "0x184A5E020", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class RCNJANOMPKS<a> : ZQNSRFSBGQC<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FE00", Offset = "0x5E6EC00", VA = "0x185E6FE00", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xB1F430", Offset = "0xB1E230", VA = "0x180B1F430", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FF30", Offset = "0x5E6ED30", VA = "0x185E6FF30", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FF90", Offset = "0x5E6ED90", VA = "0x185E6FF90", Slot = "6")]
		protected override HashSet<a>.Enumerator JAVOUUNLMGK(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5C39280", Offset = "0x5C38080", VA = "0x185C39280")]
		public RCNJANOMPKS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class YTEXWKHDVAS<a> : ZPNKEXWOLLJ<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x40A83C0", Offset = "0x40A71C0", VA = "0x1840A83C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x40A84A0", Offset = "0x40A72A0", VA = "0x1840A84A0", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x40A8540", Offset = "0x40A7340", VA = "0x1840A8540", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class ZUBJHRAJKBN<a> : ZPNKEXWOLLJ<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x4139180", Offset = "0x4137F80", VA = "0x184139180", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x4139270", Offset = "0x4138070", VA = "0x184139270", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xB1F430", Offset = "0xB1E230", VA = "0x180B1F430", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class ZZIXDBBNNUH<a> : ZPNKEXWOLLJ<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x4139180", Offset = "0x4137F80", VA = "0x184139180", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x4139270", Offset = "0x4138070", VA = "0x184139270", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xB1F430", Offset = "0xB1E230", VA = "0x180B1F430", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class ODFGEWXXFVX<a> : ZPNKEXWOLLJ<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5C65030", Offset = "0x5C63E30", VA = "0x185C65030", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x4A5E190", Offset = "0x4A5CF90", VA = "0x184A5E190", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5B44C40", Offset = "0x5B43A40", VA = "0x185B44C40", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5AC5590", Offset = "0x5AC4390", VA = "0x185AC5590")]
		public ODFGEWXXFVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class HYAOLTAONWJ<a, b> : UAJNQMCKSSZ<IGrouping<a, b>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x520D370", Offset = "0x520C170", VA = "0x18520D370", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x520D010", Offset = "0x520BE10", VA = "0x18520D010", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class VFUZVNKZKOM<a, b> : UAJNQMCKSSZ<ILookup<a, b>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x652C4D0", Offset = "0x652B2D0", VA = "0x18652C4D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x652C170", Offset = "0x652AF70", VA = "0x18652C170", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class RXCCOHZXEQU<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a NFCNRPBPDKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> KOJSEDWCJJA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x40A2FF0", Offset = "0x40A1DF0", VA = "0x1840A2FF0", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E8B0", Offset = "0x5E8D6B0", VA = "0x185E8E8B0")]
		public RXCCOHZXEQU(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E840", Offset = "0x5E8D640", VA = "0x185E8E840", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x53C2010", Offset = "0x53C0E10", VA = "0x1853C2010", Slot = "6")]
		private IEnumerator UYQUPSIMXFE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class YOEOREQOZGD<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> ZKHWQTROYYD;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x40A6270", Offset = "0x40A5070", VA = "0x1840A6270", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public YOEOREQOZGD(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x40A60D0", Offset = "0x40A4ED0", VA = "0x1840A60D0", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x40A61C0", Offset = "0x40A4FC0", VA = "0x1840A61C0", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x40A61C0", Offset = "0x40A4FC0", VA = "0x1840A61C0", Slot = "7")]
		private IEnumerator UYQUPSIMXFE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class GDKPTFVRQIA<a> : UAJNQMCKSSZ<a>, NPBHYFEKIHM where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5178C40", Offset = "0x5177A40", VA = "0x185178C40", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5178A10", Offset = "0x5177810", VA = "0x185178A10", Slot = "5")]
		public a Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GDKPTFVRQIA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class FMXZJUJUCDM : UAJNQMCKSSZ<IEnumerable>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly UAJNQMCKSSZ<IEnumerable> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x90FB330", Offset = "0x90FA130", VA = "0x1890FB330", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x90FB120", Offset = "0x90F9F20", VA = "0x1890FB120", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public FMXZJUJUCDM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class AQQNSRQJIRG : UAJNQMCKSSZ<ICollection>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly UAJNQMCKSSZ<ICollection> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x90F5EA0", Offset = "0x90F4CA0", VA = "0x1890F5EA0", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x90F5C90", Offset = "0x90F4A90", VA = "0x1890F5C90", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AQQNSRQJIRG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class BEFBRPNMYPO : UAJNQMCKSSZ<IList>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly UAJNQMCKSSZ<IList> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x90F7600", Offset = "0x90F6400", VA = "0x1890F7600", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x90F73F0", Offset = "0x90F61F0", VA = "0x1890F73F0", Slot = "5")]
		public IList Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public BEFBRPNMYPO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class BUDNFUFWWCL<a> : ZPIDHRCRCAA<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x4139180", Offset = "0x4137F80", VA = "0x184139180", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x641DE40", Offset = "0x641CC40", VA = "0x18641DE40", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class ULMTZHBNBQZ<a> : ZPNKEXWOLLJ<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x4139180", Offset = "0x4137F80", VA = "0x184139180", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x641DE40", Offset = "0x641CC40", VA = "0x18641DE40", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x641DDD0", Offset = "0x641CBD0", VA = "0x18641DDD0", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class WKDJKLDAJDH<a> : ZPNKEXWOLLJ<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x5B44BD0", Offset = "0x5B439D0", VA = "0x185B44BD0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x4A5E190", Offset = "0x4A5CF90", VA = "0x184A5E190", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x68F6FA0", Offset = "0x68F5DA0", VA = "0x1868F6FA0", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x68F70D0", Offset = "0x68F5ED0", VA = "0x1868F70D0")]
		public WKDJKLDAJDH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class NWPROPGAZDT<a> : ZPNKEXWOLLJ<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5B44BD0", Offset = "0x5B439D0", VA = "0x185B44BD0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x4A5E190", Offset = "0x4A5CF90", VA = "0x184A5E190", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5B44C40", Offset = "0x5B43A40", VA = "0x185B44C40", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x5AC5590", Offset = "0x5AC4390", VA = "0x185AC5590")]
		public NWPROPGAZDT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class BNAKRHSTTLZ<a> : ZPNKEXWOLLJ<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FE40", Offset = "0x5E6EC40", VA = "0x185E6FE40", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xB1F430", Offset = "0xB1E230", VA = "0x180B1F430", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x409CC80", Offset = "0x409BA80", VA = "0x18409CC80", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class LMSRTXWPKHP<a> : ZPIDHRCRCAA<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x4139180", Offset = "0x4137F80", VA = "0x184139180", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4139270", Offset = "0x4138070", VA = "0x184139270", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class IRPJZYWIKRA<a> : ZPIDHRCRCAA<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x4139180", Offset = "0x4137F80", VA = "0x184139180", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x4139270", Offset = "0x4138070", VA = "0x184139270", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class PXQRXYXLEWL<a> : ZPNKEXWOLLJ<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x40A83C0", Offset = "0x40A71C0", VA = "0x1840A83C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4A5E190", Offset = "0x4A5CF90", VA = "0x184A5E190", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5D719C0", Offset = "0x5D707C0", VA = "0x185D719C0", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class HFEQUQUYBPA
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

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x90FC3E0", Offset = "0x90FB1E0", VA = "0x1890FC3E0")]
		public static DateTime AIIKHCRDCQS(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x90FCB70", Offset = "0x90FB970", VA = "0x1890FCB70")]
		public static bool UYDJDPUCFRD(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x90FC6B0", Offset = "0x90FB4B0", VA = "0x1890FC6B0")]
		public static bool SCGDADJKVON(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x90FC4A0", Offset = "0x90FB2A0", VA = "0x1890FC4A0")]
		public static bool SCGDADJKVON(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x90FC940", Offset = "0x90FB740", VA = "0x1890FC940")]
		public static bool UXUSLUEJYLR(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class IJDYQHGCNZM : UAJNQMCKSSZ<DateTime>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly UAJNQMCKSSZ<DateTime> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x90FFA00", Offset = "0x90FE800", VA = "0x1890FFA00", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x90FF880", Offset = "0x90FE680", VA = "0x1890FF880", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x90FF480", Offset = "0x90FE280", VA = "0x1890FF480")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public IJDYQHGCNZM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class KSDLZQEMPNN : UAJNQMCKSSZ<DateTimeOffset>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly UAJNQMCKSSZ<DateTimeOffset> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x91039A0", Offset = "0x91027A0", VA = "0x1891039A0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9103930", Offset = "0x9102730", VA = "0x189103930", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9103550", Offset = "0x9102350", VA = "0x189103550")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public KSDLZQEMPNN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class XMCRNOXFVZI : UAJNQMCKSSZ<TimeSpan>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly UAJNQMCKSSZ<TimeSpan> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] EQYKHOCEUWS;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x910C2C0", Offset = "0x910B0C0", VA = "0x18910C2C0", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x910C240", Offset = "0x910B040", VA = "0x18910C240", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x910BE50", Offset = "0x910AC50", VA = "0x18910BE50")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public XMCRNOXFVZI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class WVKUYZVTPAZ<a, b, c, d, e> : UAJNQMCKSSZ<e>, NPBHYFEKIHM where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x690FA20", Offset = "0x690E820", VA = "0x18690FA20", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x690F010", Offset = "0x690DE10", VA = "0x18690F010", Slot = "5")]
		public e Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d JAVOUUNLMGK(e a);

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract c Create();

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void Add(c collection, int index, a key, b value);

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract e Complete(c intermediateCollection);

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected WVKUYZVTPAZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class WVFOBTBWFPQ<a, b, c, d> : WVKUYZVTPAZ<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x4131650", Offset = "0x4130450", VA = "0x184131650", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> JAVOUUNLMGK(d a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class WUFFPLGJKKX<a, b, c> : WVFOBTBWFPQ<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xB1F430", Offset = "0xB1E230", VA = "0x180B1F430", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class ZKRQBGNYVRD<a, b> : WVKUYZVTPAZ<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x412DD60", Offset = "0x412CB60", VA = "0x18412DD60", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xB1F430", Offset = "0xB1E230", VA = "0x180B1F430", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x412E030", Offset = "0x412CE30", VA = "0x18412E030", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x412E090", Offset = "0x412CE90", VA = "0x18412E090", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator JAVOUUNLMGK(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x412E210", Offset = "0x412D010", VA = "0x18412E210")]
		public ZKRQBGNYVRD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class VQOWDTUQJCP<a, b, c> : WUFFPLGJKKX<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x65781B0", Offset = "0x6576FB0", VA = "0x1865781B0", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x65783A0", Offset = "0x65771A0", VA = "0x1865783A0", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class CZLPMIYFESG<a, b> : WVFOBTBWFPQ<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3F848F0", Offset = "0x3F836F0", VA = "0x183F848F0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3F84A60", Offset = "0x3F83860", VA = "0x183F84A60", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB1F430", Offset = "0xB1E230", VA = "0x180B1F430", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class JQDZKFGTWIS<a, b> : WUFFPLGJKKX<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3F848F0", Offset = "0x3F836F0", VA = "0x183F848F0", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3F84A60", Offset = "0x3F83860", VA = "0x183F84A60", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class DNWSASMDLMO<a, b> : WVKUYZVTPAZ<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3F848F0", Offset = "0x3F836F0", VA = "0x183F848F0", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB1F430", Offset = "0xB1E230", VA = "0x180B1F430", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3F84A60", Offset = "0x3F83860", VA = "0x183F84A60", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x43052C0", Offset = "0x43040C0", VA = "0x1843052C0", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator JAVOUUNLMGK(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class TZZZOJAXIMH<a, b> : WVFOBTBWFPQ<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3F848F0", Offset = "0x3F836F0", VA = "0x183F848F0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6249A90", Offset = "0x6248890", VA = "0x186249A90", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6249B00", Offset = "0x6248900", VA = "0x186249B00", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class HVRAGZXHWIE<a, b> : WVFOBTBWFPQ<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3F848F0", Offset = "0x3F836F0", VA = "0x183F848F0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xB1F430", Offset = "0xB1E230", VA = "0x180B1F430", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x520B310", Offset = "0x520A110", VA = "0x18520B310", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class JTCZRDYFCWC<a, b> : WUFFPLGJKKX<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x53DBD60", Offset = "0x53DAB60", VA = "0x1853DBD60", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F84A60", Offset = "0x3F83860", VA = "0x183F84A60", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class IZGOYBPGFIU<a> : UAJNQMCKSSZ<a>, NPBHYFEKIHM where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x52F8C00", Offset = "0x52F7A00", VA = "0x1852F8C00", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x52F89C0", Offset = "0x52F77C0", VA = "0x1852F89C0", Slot = "5")]
		public a Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public IZGOYBPGFIU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class ASHVFLVSPEI : UAJNQMCKSSZ<IDictionary>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly UAJNQMCKSSZ<IDictionary> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x90F6A00", Offset = "0x90F5800", VA = "0x1890F6A00", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x90F6820", Offset = "0x90F5620", VA = "0x1890F6820", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ASHVFLVSPEI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class FGWWWKZBDBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x90F9F00", Offset = "0x90F8D00", VA = "0x1890F9F00")]
		public static object FUYMMSOTLXY(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x90FA6C0", Offset = "0x90F94C0", VA = "0x1890FA6C0")]
		public static object TOOHJBKJAGX(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class QKTQMQDSZPR<a> : UAJNQMCKSSZ<a>, NPBHYFEKIHM, YAABEUOLKLS<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class EERSQRFLGMR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type EJZIZZKTKKL;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EERSQRFLGMR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x49550F0", Offset = "0x4953EF0", VA = "0x1849550F0")]
			internal bool FMVQSMMDWAG(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class EEMLTKLNXBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string VIIOTPRLGZT;

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EEMLTKLNXBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x4954250", Offset = "0x4953050", VA = "0x184954250")]
			internal bool FNAXPTGBFLP(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class EEHEWDRQNPZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> CKDTWKPERKG;

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EEHEWDRQNPZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x4953EE0", Offset = "0x4952CE0", VA = "0x184953EE0")]
			internal void FMLCXYYJDDO(JsonWriter a, a b, DAAAJKHFHWQ c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class EEBXYWXTEEQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> AQEMZOMYOGL;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public EEBXYWXTEEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x4953020", Offset = "0x4951E20", VA = "0x184953020")]
			internal a FMQJVFSGMOX(JsonReader a, DAAAJKHFHWQ b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly HCSLPQWISPQ<a> AXICYAMMXJH;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> GEJJFUIVWUD;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> CWCXLCHVFQB;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> ABLWFROBBXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool RXBJHBEAREB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> XGFQQXTOTZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> VWWURLGJDJD;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAD20", Offset = "0x5DF9B20", VA = "0x185DFAD20")]
		static QKTQMQDSZPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E11E40", Offset = "0x5E10C40", VA = "0x185E11E40")]
		public QKTQMQDSZPR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE060", Offset = "0x5DECE60", VA = "0x185DEE060", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x5DEAC70", Offset = "0x5DE9A70", VA = "0x185DEAC70", Slot = "5")]
		public a Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x5DF1EB0", Offset = "0x5DF0CB0", VA = "0x185DF1EB0", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, a b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5DF1470", Offset = "0x5DF0270", VA = "0x185DF1470", Slot = "7")]
		public a WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class KPAAJWMHGRL<a> : UAJNQMCKSSZ<a[,]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x54C5760", Offset = "0x54C4560", VA = "0x1854C5760", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x54C53B0", Offset = "0x54C41B0", VA = "0x1854C53B0", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public KPAAJWMHGRL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class UKAFURHVRUH<a> : UAJNQMCKSSZ<a[,,]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6418750", Offset = "0x6417550", VA = "0x186418750", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6418250", Offset = "0x6417050", VA = "0x186418250", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public UKAFURHVRUH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class LELITDRLTZD<a> : UAJNQMCKSSZ<a[,,,]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x5586290", Offset = "0x5585090", VA = "0x185586290", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x5585C50", Offset = "0x5584A50", VA = "0x185585C50", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public LELITDRLTZD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class HPDKEVKVVEX<a> : UAJNQMCKSSZ<a?>, NPBHYFEKIHM where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5209460", Offset = "0x5208260", VA = "0x185209460", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5209320", Offset = "0x5208120", VA = "0x185209320", Slot = "5")]
		public a? Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public HPDKEVKVVEX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class IOPUYZHGOWB<a> : UAJNQMCKSSZ<a?>, NPBHYFEKIHM where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly UAJNQMCKSSZ<a> EYAGBSAPCGO;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xACD980", Offset = "0xACC780", VA = "0x180ACD980")]
		public IOPUYZHGOWB(UAJNQMCKSSZ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x52E8B50", Offset = "0x52E7950", VA = "0x1852E8B50", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x52E89D0", Offset = "0x52E77D0", VA = "0x1852E89D0", Slot = "5")]
		public a? Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class FMGBXIMWREU : UAJNQMCKSSZ<sbyte>, NPBHYFEKIHM, YAABEUOLKLS<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly FMGBXIMWREU GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x90FAE90", Offset = "0x90F9C90", VA = "0x1890FAE90", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x90FAE80", Offset = "0x90F9C80", VA = "0x1890FAE80", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x90FAFA0", Offset = "0x90F9DA0", VA = "0x1890FAFA0", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, sbyte b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x90FAF20", Offset = "0x90F9D20", VA = "0x1890FAF20", Slot = "7")]
		public sbyte WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public FMGBXIMWREU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class ZMHFGLXISPH : UAJNQMCKSSZ<sbyte?>, NPBHYFEKIHM, YAABEUOLKLS<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly ZMHFGLXISPH GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x910DB70", Offset = "0x910C970", VA = "0x18910DB70", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x910DB00", Offset = "0x910C900", VA = "0x18910DB00", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x910DD30", Offset = "0x910CB30", VA = "0x18910DD30", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, sbyte? b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x910DC60", Offset = "0x910CA60", VA = "0x18910DC60", Slot = "7")]
		public sbyte? WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ZMHFGLXISPH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class YNPUJUKASCX : UAJNQMCKSSZ<sbyte[]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly YNPUJUKASCX GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x910D6B0", Offset = "0x910C4B0", VA = "0x18910D6B0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x910D570", Offset = "0x910C370", VA = "0x18910D570", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public YNPUJUKASCX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class IXMSSUFTNLB : UAJNQMCKSSZ<short>, NPBHYFEKIHM, YAABEUOLKLS<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly IXMSSUFTNLB GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x9100630", Offset = "0x90FF430", VA = "0x189100630", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x9100620", Offset = "0x90FF420", VA = "0x189100620", Slot = "5")]
		public short Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x9100740", Offset = "0x90FF540", VA = "0x189100740", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, short b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x91006C0", Offset = "0x90FF4C0", VA = "0x1891006C0", Slot = "7")]
		public short WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public IXMSSUFTNLB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class RUOYATZHUYK : UAJNQMCKSSZ<short?>, NPBHYFEKIHM, YAABEUOLKLS<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly RUOYATZHUYK GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x91070E0", Offset = "0x9105EE0", VA = "0x1891070E0", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9107070", Offset = "0x9105E70", VA = "0x189107070", Slot = "5")]
		public short? Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x91072A0", Offset = "0x91060A0", VA = "0x1891072A0", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, short? b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x91071D0", Offset = "0x9105FD0", VA = "0x1891071D0", Slot = "7")]
		public short? WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public RUOYATZHUYK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class TSRHPCHDCCO : UAJNQMCKSSZ<short[]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly TSRHPCHDCCO GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x9108290", Offset = "0x9107090", VA = "0x189108290", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9108150", Offset = "0x9106F50", VA = "0x189108150", Slot = "5")]
		public short[] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public TSRHPCHDCCO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class VDAGMJLPIGN : UAJNQMCKSSZ<int>, NPBHYFEKIHM, YAABEUOLKLS<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly VDAGMJLPIGN GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x910A250", Offset = "0x9109050", VA = "0x18910A250", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x910A240", Offset = "0x9109040", VA = "0x18910A240", Slot = "5")]
		public int Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x910A360", Offset = "0x9109160", VA = "0x18910A360", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, int b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x910A2E0", Offset = "0x91090E0", VA = "0x18910A2E0", Slot = "7")]
		public int WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public VDAGMJLPIGN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class JHIWBAGNKCQ : UAJNQMCKSSZ<int?>, NPBHYFEKIHM, YAABEUOLKLS<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly JHIWBAGNKCQ GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x9100E70", Offset = "0x90FFC70", VA = "0x189100E70", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x9100E00", Offset = "0x90FFC00", VA = "0x189100E00", Slot = "5")]
		public int? Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x9101030", Offset = "0x90FFE30", VA = "0x189101030", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, int? b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9100F60", Offset = "0x90FFD60", VA = "0x189100F60", Slot = "7")]
		public int? WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public JHIWBAGNKCQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class BNKOYLUODLK : UAJNQMCKSSZ<int[]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly BNKOYLUODLK GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x90F7B60", Offset = "0x90F6960", VA = "0x1890F7B60", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x90F7A20", Offset = "0x90F6820", VA = "0x1890F7A20", Slot = "5")]
		public int[] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public BNKOYLUODLK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class JPVSZCQDENS : UAJNQMCKSSZ<long>, NPBHYFEKIHM, YAABEUOLKLS<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly JPVSZCQDENS GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x9102D40", Offset = "0x9101B40", VA = "0x189102D40", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x9102D30", Offset = "0x9101B30", VA = "0x189102D30", Slot = "5")]
		public long Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x9102DE0", Offset = "0x9101BE0", VA = "0x189102DE0", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, long b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x9102DA0", Offset = "0x9101BA0", VA = "0x189102DA0", Slot = "7")]
		public long WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public JPVSZCQDENS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class IYVCBVCOMOB : UAJNQMCKSSZ<long?>, NPBHYFEKIHM, YAABEUOLKLS<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly IYVCBVCOMOB GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9100950", Offset = "0x90FF750", VA = "0x189100950", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x91008C0", Offset = "0x90FF6C0", VA = "0x1891008C0", Slot = "5")]
		public long? Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9100AC0", Offset = "0x90FF8C0", VA = "0x189100AC0", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, long? b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9100A10", Offset = "0x90FF810", VA = "0x189100A10", Slot = "7")]
		public long? WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public IYVCBVCOMOB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class GCQYLFLYZFR : UAJNQMCKSSZ<long[]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly GCQYLFLYZFR GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x90FBF10", Offset = "0x90FAD10", VA = "0x1890FBF10", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x90FBDD0", Offset = "0x90FABD0", VA = "0x1890FBDD0", Slot = "5")]
		public long[] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GCQYLFLYZFR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class XQLTBUXDUPH : UAJNQMCKSSZ<byte>, NPBHYFEKIHM, YAABEUOLKLS<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly XQLTBUXDUPH GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x910C9E0", Offset = "0x910B7E0", VA = "0x18910C9E0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x910C9D0", Offset = "0x910B7D0", VA = "0x18910C9D0", Slot = "5")]
		public byte Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x910CAF0", Offset = "0x910B8F0", VA = "0x18910CAF0", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, byte b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x910CA70", Offset = "0x910B870", VA = "0x18910CA70", Slot = "7")]
		public byte WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public XQLTBUXDUPH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class JRGSSDTPKUK : UAJNQMCKSSZ<byte?>, NPBHYFEKIHM, YAABEUOLKLS<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly JRGSSDTPKUK GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x9102F90", Offset = "0x9101D90", VA = "0x189102F90", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x9102F20", Offset = "0x9101D20", VA = "0x189102F20", Slot = "5")]
		public byte? Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x9103150", Offset = "0x9101F50", VA = "0x189103150", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, byte? b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x9103080", Offset = "0x9101E80", VA = "0x189103080", Slot = "7")]
		public byte? WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public JRGSSDTPKUK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class GAVOWRIUGVA : UAJNQMCKSSZ<ushort>, NPBHYFEKIHM, YAABEUOLKLS<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly GAVOWRIUGVA GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x90FBB40", Offset = "0x90FA940", VA = "0x1890FBB40", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x90FBB30", Offset = "0x90FA930", VA = "0x1890FBB30", Slot = "5")]
		public ushort Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x90FBC50", Offset = "0x90FAA50", VA = "0x1890FBC50", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, ushort b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x90FBBD0", Offset = "0x90FA9D0", VA = "0x1890FBBD0", Slot = "7")]
		public ushort WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public GAVOWRIUGVA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class HRAKTAMSKSB : UAJNQMCKSSZ<ushort?>, NPBHYFEKIHM, YAABEUOLKLS<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly HRAKTAMSKSB GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x90FD7C0", Offset = "0x90FC5C0", VA = "0x1890FD7C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x90FD750", Offset = "0x90FC550", VA = "0x1890FD750", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x90FD980", Offset = "0x90FC780", VA = "0x1890FD980", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, ushort? b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x90FD8B0", Offset = "0x90FC6B0", VA = "0x1890FD8B0", Slot = "7")]
		public ushort? WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public HRAKTAMSKSB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class VPGYOAFKKDD : UAJNQMCKSSZ<ushort[]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly VPGYOAFKKDD GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x910A620", Offset = "0x9109420", VA = "0x18910A620", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x910A4E0", Offset = "0x91092E0", VA = "0x18910A4E0", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public VPGYOAFKKDD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class HAVRWLHDMFC : UAJNQMCKSSZ<uint>, NPBHYFEKIHM, YAABEUOLKLS<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly HAVRWLHDMFC GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x90FC150", Offset = "0x90FAF50", VA = "0x1890FC150", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x90FC140", Offset = "0x90FAF40", VA = "0x1890FC140", Slot = "5")]
		public uint Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x90FC260", Offset = "0x90FB060", VA = "0x1890FC260", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, uint b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x90FC1E0", Offset = "0x90FAFE0", VA = "0x1890FC1E0", Slot = "7")]
		public uint WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public HAVRWLHDMFC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class PIIPZAXROPZ : UAJNQMCKSSZ<uint?>, NPBHYFEKIHM, YAABEUOLKLS<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly PIIPZAXROPZ GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x9105020", Offset = "0x9103E20", VA = "0x189105020", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x9104FB0", Offset = "0x9103DB0", VA = "0x189104FB0", Slot = "5")]
		public uint? Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x91051E0", Offset = "0x9103FE0", VA = "0x1891051E0", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, uint? b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x9105110", Offset = "0x9103F10", VA = "0x189105110", Slot = "7")]
		public uint? WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public PIIPZAXROPZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class UXEJMHUACMX : UAJNQMCKSSZ<uint[]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly UXEJMHUACMX GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x9108E60", Offset = "0x9107C60", VA = "0x189108E60", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x9108D20", Offset = "0x9107B20", VA = "0x189108D20", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public UXEJMHUACMX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class BTOBNDQSTPT : UAJNQMCKSSZ<ulong>, NPBHYFEKIHM, YAABEUOLKLS<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly BTOBNDQSTPT GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x90F7E10", Offset = "0x90F6C10", VA = "0x1890F7E10", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x90F7E00", Offset = "0x90F6C00", VA = "0x1890F7E00", Slot = "5")]
		public ulong Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x90F7EB0", Offset = "0x90F6CB0", VA = "0x1890F7EB0", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, ulong b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x90F7E70", Offset = "0x90F6C70", VA = "0x1890F7E70", Slot = "7")]
		public ulong WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public BTOBNDQSTPT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class NLAQEYTWBPU : UAJNQMCKSSZ<ulong?>, NPBHYFEKIHM, YAABEUOLKLS<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly NLAQEYTWBPU GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x91046D0", Offset = "0x91034D0", VA = "0x1891046D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x9104640", Offset = "0x9103440", VA = "0x189104640", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x9104840", Offset = "0x9103640", VA = "0x189104840", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, ulong? b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x9104790", Offset = "0x9103590", VA = "0x189104790", Slot = "7")]
		public ulong? WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public NLAQEYTWBPU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class XXHHBGZYXQU : UAJNQMCKSSZ<ulong[]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly XXHHBGZYXQU GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x910CDB0", Offset = "0x910BBB0", VA = "0x18910CDB0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x910CC70", Offset = "0x910BA70", VA = "0x18910CC70", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public XXHHBGZYXQU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class SLEHEKNJIJB : UAJNQMCKSSZ<float>, NPBHYFEKIHM, YAABEUOLKLS<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly SLEHEKNJIJB GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x9107480", Offset = "0x9106280", VA = "0x189107480", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x9107470", Offset = "0x9106270", VA = "0x189107470", Slot = "5")]
		public float Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x9107520", Offset = "0x9106320", VA = "0x189107520", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, float b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x91074E0", Offset = "0x91062E0", VA = "0x1891074E0", Slot = "7")]
		public float WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public SLEHEKNJIJB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class YIPIZUVLPCI : UAJNQMCKSSZ<float?>, NPBHYFEKIHM, YAABEUOLKLS<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly YIPIZUVLPCI GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x910D050", Offset = "0x910BE50", VA = "0x18910D050", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x910CFE0", Offset = "0x910BDE0", VA = "0x18910CFE0", Slot = "5")]
		public float? Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x910D1B0", Offset = "0x910BFB0", VA = "0x18910D1B0", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, float? b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x910D110", Offset = "0x910BF10", VA = "0x18910D110", Slot = "7")]
		public float? WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public YIPIZUVLPCI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class ASCOGNSBKBQ : UAJNQMCKSSZ<float[]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly ASCOGNSBKBQ GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x90F6490", Offset = "0x90F5290", VA = "0x1890F6490", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x90F6350", Offset = "0x90F5150", VA = "0x1890F6350", Slot = "5")]
		public float[] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ASCOGNSBKBQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class AULHTUQCTQA : UAJNQMCKSSZ<double>, NPBHYFEKIHM, YAABEUOLKLS<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly AULHTUQCTQA GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x90F7080", Offset = "0x90F5E80", VA = "0x1890F7080", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x90F7070", Offset = "0x90F5E70", VA = "0x1890F7070", Slot = "5")]
		public double Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x90F7120", Offset = "0x90F5F20", VA = "0x1890F7120", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, double b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x90F70E0", Offset = "0x90F5EE0", VA = "0x1890F70E0", Slot = "7")]
		public double WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AULHTUQCTQA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class DIVOOLADSMH : UAJNQMCKSSZ<double?>, NPBHYFEKIHM, YAABEUOLKLS<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly DIVOOLADSMH GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x90F89A0", Offset = "0x90F77A0", VA = "0x1890F89A0", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x90F8910", Offset = "0x90F7710", VA = "0x1890F8910", Slot = "5")]
		public double? Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x90F8B10", Offset = "0x90F7910", VA = "0x1890F8B10", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, double? b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x90F8A60", Offset = "0x90F7860", VA = "0x1890F8A60", Slot = "7")]
		public double? WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public DIVOOLADSMH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class CCUNLGZOPYL : UAJNQMCKSSZ<double[]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly CCUNLGZOPYL GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x90F8130", Offset = "0x90F6F30", VA = "0x1890F8130", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x90F7FF0", Offset = "0x90F6DF0", VA = "0x1890F7FF0", Slot = "5")]
		public double[] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CCUNLGZOPYL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class EXDKYFFNOWZ : UAJNQMCKSSZ<bool>, NPBHYFEKIHM, YAABEUOLKLS<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly EXDKYFFNOWZ GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x90F9D20", Offset = "0x90F8B20", VA = "0x1890F9D20", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x90F9D10", Offset = "0x90F8B10", VA = "0x1890F9D10", Slot = "5")]
		public bool Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x90F9DC0", Offset = "0x90F8BC0", VA = "0x1890F9DC0", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, bool b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x90F9D80", Offset = "0x90F8B80", VA = "0x1890F9D80", Slot = "7")]
		public bool WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public EXDKYFFNOWZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class SSCLIKWMBSI : UAJNQMCKSSZ<bool?>, NPBHYFEKIHM, YAABEUOLKLS<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly SSCLIKWMBSI GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x91076D0", Offset = "0x91064D0", VA = "0x1891076D0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x9107660", Offset = "0x9106460", VA = "0x189107660", Slot = "5")]
		public bool? Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x9107830", Offset = "0x9106630", VA = "0x189107830", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, bool? b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x9107790", Offset = "0x9106590", VA = "0x189107790", Slot = "7")]
		public bool? WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public SSCLIKWMBSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class DKZNYGMRSDS : UAJNQMCKSSZ<bool[]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly DKZNYGMRSDS GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x90F9170", Offset = "0x90F7F70", VA = "0x1890F9170", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x90F9030", Offset = "0x90F7E30", VA = "0x1890F9030", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public DKZNYGMRSDS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class LOLUWURNHHG : UAJNQMCKSSZ<byte[]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly UAJNQMCKSSZ<byte[]> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x9104510", Offset = "0x9103310", VA = "0x189104510", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x91044A0", Offset = "0x91032A0", VA = "0x1891044A0", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public LOLUWURNHHG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class XARXASLFUPV : UAJNQMCKSSZ<ArraySegment<byte>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly UAJNQMCKSSZ<ArraySegment<byte>> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x910BCB0", Offset = "0x910AAB0", VA = "0x18910BCB0", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x910BBE0", Offset = "0x910A9E0", VA = "0x18910BBE0", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public XARXASLFUPV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class CZLZLRGXGOX : UAJNQMCKSSZ<string>, NPBHYFEKIHM, YAABEUOLKLS<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly UAJNQMCKSSZ<string> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x90F87D0", Offset = "0x90F75D0", VA = "0x1890F87D0", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x90F87C0", Offset = "0x90F75C0", VA = "0x1890F87C0", Slot = "5")]
		public string Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x90F8830", Offset = "0x90F7630", VA = "0x1890F8830", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, string b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x90F87C0", Offset = "0x90F75C0", VA = "0x1890F87C0", Slot = "7")]
		public string WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CZLZLRGXGOX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class DKZNVYLNOTM : UAJNQMCKSSZ<string[]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly DKZNVYLNOTM GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x90F8E00", Offset = "0x90F7C00", VA = "0x1890F8E00", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x90F8CB0", Offset = "0x90F7AB0", VA = "0x1890F8CB0", Slot = "5")]
		public string[] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public DKZNVYLNOTM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class FSZYGVMJKIT : UAJNQMCKSSZ<char>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly FSZYGVMJKIT GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x90FB6E0", Offset = "0x90FA4E0", VA = "0x1890FB6E0", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x90FB6B0", Offset = "0x90FA4B0", VA = "0x1890FB6B0", Slot = "5")]
		public char Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public FSZYGVMJKIT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class YKUBHHPDFUQ : UAJNQMCKSSZ<char?>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly YKUBHHPDFUQ GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x910D400", Offset = "0x910C200", VA = "0x18910D400", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x910D340", Offset = "0x910C140", VA = "0x18910D340", Slot = "5")]
		public char? Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public YKUBHHPDFUQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class HGOTQPBKWOG : UAJNQMCKSSZ<char[]>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly HGOTQPBKWOG GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x90FCEB0", Offset = "0x90FBCB0", VA = "0x1890FCEB0", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x90FCD20", Offset = "0x90FBB20", VA = "0x1890FCD20", Slot = "5")]
		public char[] Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public HGOTQPBKWOG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class PDWGWGYPYHG : UAJNQMCKSSZ<Guid>, NPBHYFEKIHM, YAABEUOLKLS<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly UAJNQMCKSSZ<Guid> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x9104BE0", Offset = "0x91039E0", VA = "0x189104BE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x9104B80", Offset = "0x9103980", VA = "0x189104B80", Slot = "5")]
		public Guid Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x9104DC0", Offset = "0x9103BC0", VA = "0x189104DC0", Slot = "6")]
		public void XQXQXLLXTOQ(JsonWriter a, Guid b, DAAAJKHFHWQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x9104D50", Offset = "0x9103B50", VA = "0x189104D50", Slot = "7")]
		public Guid WWZCFLWRBYE(JsonReader a, DAAAJKHFHWQ b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public PDWGWGYPYHG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class HMRIARINOGE : UAJNQMCKSSZ<decimal>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly UAJNQMCKSSZ<decimal> GUTFKAZYITC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool ZNBTCUFEBXA;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x749ED00", Offset = "0x749DB00", VA = "0x18749ED00")]
		public HMRIARINOGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xD542C0", Offset = "0xD530C0", VA = "0x180D542C0")]
		public HMRIARINOGE(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x90FD330", Offset = "0x90FC130", VA = "0x1890FD330", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x90FD160", Offset = "0x90FBF60", VA = "0x1890FD160", Slot = "5")]
		public decimal Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class HNKANHXVAKX : UAJNQMCKSSZ<Uri>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly UAJNQMCKSSZ<Uri> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x90FD600", Offset = "0x90FC400", VA = "0x1890FD600", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x90FD580", Offset = "0x90FC380", VA = "0x1890FD580", Slot = "5")]
		public Uri Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public HNKANHXVAKX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class ZIVMBDXGWFX : UAJNQMCKSSZ<Version>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly UAJNQMCKSSZ<Version> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x910D9D0", Offset = "0x910C7D0", VA = "0x18910D9D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x910D950", Offset = "0x910C750", VA = "0x18910D950", Slot = "5")]
		public Version Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public ZIVMBDXGWFX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class ZWNXWQIPNDX<a, b> : UAJNQMCKSSZ<KeyValuePair<a, b>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x41AFDE0", Offset = "0x41AEBE0", VA = "0x1841AFDE0", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x41AF8F0", Offset = "0x41AE6F0", VA = "0x1841AF8F0", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class AUXNPCRGHUZ : UAJNQMCKSSZ<StringBuilder>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly UAJNQMCKSSZ<StringBuilder> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x90F72E0", Offset = "0x90F60E0", VA = "0x1890F72E0", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x90F7260", Offset = "0x90F6060", VA = "0x1890F7260", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AUXNPCRGHUZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class CZINZKVJFQD : UAJNQMCKSSZ<BitArray>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly UAJNQMCKSSZ<BitArray> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x90F85D0", Offset = "0x90F73D0", VA = "0x1890F85D0", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x90F84B0", Offset = "0x90F72B0", VA = "0x1890F84B0", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public CZINZKVJFQD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class VWMVDMMAFHJ : UAJNQMCKSSZ<Type>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly VWMVDMMAFHJ GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex ISCJSQBFLHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool YEJYFZFDEYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool LCACNCYMMVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool AAEQDVSYBXI;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x910ABA0", Offset = "0x91099A0", VA = "0x18910ABA0")]
		public VWMVDMMAFHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x844B910", Offset = "0x844A710", VA = "0x18844B910")]
		public VWMVDMMAFHJ(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x910A9D0", Offset = "0x91097D0", VA = "0x18910A9D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x910A8C0", Offset = "0x91096C0", VA = "0x18910A8C0", Slot = "5")]
		public Type Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class TCWFHZZCGXV : UAJNQMCKSSZ<BigInteger>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly UAJNQMCKSSZ<BigInteger> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x9108010", Offset = "0x9106E10", VA = "0x189108010", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x9107F60", Offset = "0x9106D60", VA = "0x189107F60", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public TCWFHZZCGXV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class KIHLEYEPMGJ : UAJNQMCKSSZ<Complex>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly UAJNQMCKSSZ<Complex> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x91033B0", Offset = "0x91021B0", VA = "0x1891033B0", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x9103320", Offset = "0x9102120", VA = "0x189103320", Slot = "5")]
		public Complex Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public KIHLEYEPMGJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class FSZYXGTCHCT : UAJNQMCKSSZ<ExpandoObject>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly UAJNQMCKSSZ<ExpandoObject> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x90FBA30", Offset = "0x90FA830", VA = "0x1890FBA30", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x90FB800", Offset = "0x90FA600", VA = "0x1890FB800", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public FSZYXGTCHCT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class VCJJNWDWABA<a> : UAJNQMCKSSZ<Lazy<a>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x652AA30", Offset = "0x6529830", VA = "0x18652AA30", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x652A820", Offset = "0x6529620", VA = "0x18652A820", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class PTXQWQBCIIO : UAJNQMCKSSZ<Task>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly UAJNQMCKSSZ<Task> GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task KNBACIPSWRT;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x9105460", Offset = "0x9104260", VA = "0x189105460", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x91053B0", Offset = "0x91041B0", VA = "0x1891053B0", Slot = "5")]
		public Task Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public PTXQWQBCIIO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class UKPMTXOTYGE<a> : UAJNQMCKSSZ<Task<a>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x64191F0", Offset = "0x6417FF0", VA = "0x1864191F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x6419070", Offset = "0x6417E70", VA = "0x186419070", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class GOGHZCQXJZQ<a> : UAJNQMCKSSZ<ValueTask<a>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x51861D0", Offset = "0x5184FD0", VA = "0x1851861D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5185FA0", Offset = "0x5184DA0", VA = "0x185185FA0", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class EJIXTORTAYQ<a> : UAJNQMCKSSZ<Tuple<a>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x495EB30", Offset = "0x495D930", VA = "0x18495EB30", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x495E840", Offset = "0x495D640", VA = "0x18495E840", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class EJYSLIZLDGR<a, b> : UAJNQMCKSSZ<Tuple<a, b>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x4A0EE80", Offset = "0x4A0DC80", VA = "0x184A0EE80", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x4A0EA30", Offset = "0x4A0D830", VA = "0x184A0EA30", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class EJTLOCFNTVI<a, b, c> : UAJNQMCKSSZ<Tuple<a, b, c>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x495F4A0", Offset = "0x495E2A0", VA = "0x18495F4A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x495EF10", Offset = "0x495DD10", VA = "0x18495EF10", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class EKJGFWNFWDJ<a, b, c, d> : UAJNQMCKSSZ<Tuple<a, b, c, d>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x4A10CC0", Offset = "0x4A0FAC0", VA = "0x184A10CC0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x4A105D0", Offset = "0x4A0F3D0", VA = "0x184A105D0", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class EKDZIPTIMSA<a, b, c, d, e> : UAJNQMCKSSZ<Tuple<a, b, c, d, e>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x4A0FC20", Offset = "0x4A0EA20", VA = "0x184A0FC20", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x4A0F3C0", Offset = "0x4A0E1C0", VA = "0x184A0F3C0", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class EKTUAKBAPAB<a, b, c, d, e, f> : UAJNQMCKSSZ<Tuple<a, b, c, d, e, f>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x4A13720", Offset = "0x4A12520", VA = "0x184A13720", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x4A12D30", Offset = "0x4A11B30", VA = "0x184A12D30", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class EKONDDHDFOS<a, b, c, d, e, f, g> : UAJNQMCKSSZ<Tuple<a, b, c, d, e, f, g>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x4A12080", Offset = "0x4A10E80", VA = "0x184A12080", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x4A11500", Offset = "0x4A10300", VA = "0x184A11500", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class EHYBMTILMXF<a, b, c, d, e, f, g, h> : UAJNQMCKSSZ<Tuple<a, b, c, d, e, f, g, h>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x495D1E0", Offset = "0x495BFE0", VA = "0x18495D1E0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x495C4F0", Offset = "0x495B2F0", VA = "0x18495C4F0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class JKEJDVQPXYL<a> : UAJNQMCKSSZ<ValueTuple<a>>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x53CF570", Offset = "0x53CE370", VA = "0x1853CF570", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x53CF140", Offset = "0x53CDF40", VA = "0x1853CF140", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class JKJQBCKNHJU<a, b> : UAJNQMCKSSZ<(a, b)>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x53D03D0", Offset = "0x53CF1D0", VA = "0x1853D03D0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x53CFEC0", Offset = "0x53CECC0", VA = "0x1853CFEC0", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class JKOWYJEKQVD<a, b, c> : UAJNQMCKSSZ<(a, b, c)>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x53D0FE0", Offset = "0x53CFDE0", VA = "0x1853D0FE0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x53D0940", Offset = "0x53CF740", VA = "0x1853D0940", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class JJEARNVDCTS<a, b, c, d> : UAJNQMCKSSZ<(a, b, c, d)>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x53C9EF0", Offset = "0x53C8CF0", VA = "0x1853C9EF0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x53C9680", Offset = "0x53C8480", VA = "0x1853C9680", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class JJJHOUPAMFB<a, b, c, d, e> : UAJNQMCKSSZ<(a, b, c, d, e)>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x53CB1F0", Offset = "0x53C9FF0", VA = "0x1853CB1F0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x53CA7F0", Offset = "0x53C95F0", VA = "0x1853CA7F0", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class JJOOMBIXVQK<a, b, c, d, e, f> : UAJNQMCKSSZ<(a, b, c, d, e, f)>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x53CC8C0", Offset = "0x53CB6C0", VA = "0x1853CC8C0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x53CBCA0", Offset = "0x53CAAA0", VA = "0x1853CBCA0", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class JJTVJICVFBT<a, b, c, d, e, f, g> : UAJNQMCKSSZ<(a, b, c, d, e, f, g)>, NPBHYFEKIHM
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x53CE310", Offset = "0x53CD110", VA = "0x1853CE310", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x53CD530", Offset = "0x53CC330", VA = "0x1853CD530", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class JLPFKQZXLZW<a, b, c, d, e, f, g, h> : UAJNQMCKSSZ<ValueTuple<a, b, c, d, e, f, g, h>>, NPBHYFEKIHM where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] KDHDECVAGRJ;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly VIRUOWKNFEZ VNZSUDQDNOX;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x53D26A0", Offset = "0x53D14A0", VA = "0x1853D26A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, DAAAJKHFHWQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x53D1710", Offset = "0x53D0510", VA = "0x1853D1710", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, DAAAJKHFHWQ formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class PBMUURMZAHB
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] ICAODXGTGWN;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly VIRUOWKNFEZ XMYBUEFKLVO;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x91049E0", Offset = "0x91037E0", VA = "0x1891049E0")]
		static PBMUURMZAHB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class JEDCTWWAMRH
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] PWSOBKISWJK;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly VIRUOWKNFEZ LQCTHWOWWCJ;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x9100C60", Offset = "0x90FFA60", VA = "0x189100C60")]
		static JEDCTWWAMRH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class WRJLSZFJQEH
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] EEPXBZYZHSV;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly VIRUOWKNFEZ FHMQTCWYKJI;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] EEACKFRHFKU;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly VIRUOWKNFEZ FHHJVWDBAXZ;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] EEFJHMLEOWD;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly VIRUOWKNFEZ FHCCYPJDRMQ;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] EDPOPSDMMOC;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly VIRUOWKNFEZ FGWWBIPGIBH;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] EDUVMYXJVZL;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly VIRUOWKNFEZ FGRPEBVIYPY;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] EDFAVEPRTRK;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly VIRUOWKNFEZ FGMIGVBLPEP;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] EDKHSLJPDCT;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly VIRUOWKNFEZ FGHBJOHOFTG;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] ECUNARBXAUS;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly VIRUOWKNFEZ FGBUMHNQWHX;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x910AC60", Offset = "0x9109A60", VA = "0x18910AC60")]
		static WRJLSZFJQEH()
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
