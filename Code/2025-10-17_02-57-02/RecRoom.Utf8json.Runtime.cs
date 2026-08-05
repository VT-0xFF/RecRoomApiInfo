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
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, CKTJJUOJSNN resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, CKTJJUOJSNN resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface GGASJLLNBGR
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface IGIJDGNWSCS<a> : GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, CKTJJUOJSNN formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface CBEIQCICYGT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZJRLWUBCWZP(JsonWriter a, a b, CKTJJUOJSNN c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b);
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
	public static class RDKAEDMBLFA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3C3CF00", Offset = "0x3C3B500", VA = "0x183C3CF00")]
		public static string ToJsonString<T>(this IGIJDGNWSCS<T> formatter, T value, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IGIJDGNWSCS<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class ERLZYPTGWHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x37F81B0", Offset = "0x37F67B0", VA = "0x1837F81B0")]
		public static IGIJDGNWSCS<a> DJRWCFNNNYT<a>(this CKTJJUOJSNN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x905F830", Offset = "0x905DE30", VA = "0x18905F830")]
		public static object DWIVIWDIRQL(this CKTJJUOJSNN a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x905FA30", Offset = "0x905E030", VA = "0x18905FA30")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class AJPIBUTPGCZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] HKIWYGGJQVO;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] CKWIGQYVLIF;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] QEJQTCPDOHI;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] NYCLTQWEXOR;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] VYYSFMFZLLC;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] LUGJQRVNRXZ;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] TDDMGSNCWUH;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] MPJOGXDIYOO;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class NLOWEZZOFGG : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x9069810", Offset = "0x9067E10", VA = "0x189069810")]
				public NLOWEZZOFGG(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x90696F0", Offset = "0x9067CF0", VA = "0x1890696F0")]
				public NLOWEZZOFGG MWSUSSABYVG(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class JCNCSFMSPDH
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] CMLDZKLDREO;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] HKASIQSUXRH;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private NLOWEZZOFGG start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private NLOWEZZOFGG end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x9070060", Offset = "0x906E660", VA = "0x189070060")]
			public void MWSUSSABYVG([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9070170", Offset = "0x906E770", VA = "0x189070170")]
			public void MWSUSSABYVG(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x906FF30", Offset = "0x906E530", VA = "0x18906FF30")]
			public ReadOnlySequence<byte> IWHBMSWDBPV()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x90702B0", Offset = "0x906E8B0", VA = "0x1890702B0")]
			private void SFQLZLMYPYP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x9070460", Offset = "0x906EA60", VA = "0x189070460")]
			private void UADZZRHOQWV([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9067460", Offset = "0x9065A60", VA = "0x189067460")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9066900", Offset = "0x9064F00", VA = "0x189066900")]
		private JsonParsingException RSXTYRZNGPX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9066E50", Offset = "0x9065450", VA = "0x189066E50")]
		private JsonParsingException SJXDAYKQPTC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9067020", Offset = "0x9065620", VA = "0x189067020")]
		public void UAUKMIIVCKZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x90666F0", Offset = "0x9064CF0", VA = "0x1890666F0")]
		public JsonToken RFTFARKFICI()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9064B20", Offset = "0x9063120", VA = "0x189064B20")]
		public void EXJMFTFGTYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9065900", Offset = "0x9063F00", VA = "0x189065900")]
		private bool MGIAGDOJXAQ(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9065960", Offset = "0x9063F60", VA = "0x189065960")]
		private bool MGIAGDOJXAQ(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9064250", Offset = "0x9062850", VA = "0x189064250")]
		private void AQOFXHDZTRD(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9065A30", Offset = "0x9064030", VA = "0x189065A30")]
		public bool NFJPCOIRGDT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9067150", Offset = "0x9065750", VA = "0x189067150")]
		public void UNXGISOMSYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9066E00", Offset = "0x9065400", VA = "0x189066E00")]
		public bool RYDLUNXQARI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9066F60", Offset = "0x9065560", VA = "0x189066F60")]
		public void TTKUQBWNIVV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9065280", Offset = "0x9063880", VA = "0x189065280")]
		public void HPVAYKUKWUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x90666A0", Offset = "0x9064CA0", VA = "0x1890666A0")]
		public bool QNWGMKVSIFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9064590", Offset = "0x9062B90", VA = "0x189064590")]
		public void CLXUDEDOYAR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9066690", Offset = "0x9064C90", VA = "0x189066690")]
		public void QJTVEFOFRJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9064A90", Offset = "0x9063090", VA = "0x189064A90")]
		public bool ENJABDQGGFT(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9065870", Offset = "0x9063E70", VA = "0x189065870")]
		public bool LNXJQAXTFJT(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9064300", Offset = "0x9062900", VA = "0x189064300")]
		public bool AUTJTSQMXQE(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9066110", Offset = "0x9064710", VA = "0x189066110")]
		private ReadOnlySequence<byte> PWMSQRGKHAF()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9064E20", Offset = "0x9063420", VA = "0x189064E20")]
		private ReadOnlySequence<byte> GPRJYDDWMUE()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9065090", Offset = "0x9063690", VA = "0x189065090")]
		private void GSAWYIXJMXS(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9065D90", Offset = "0x9064390", VA = "0x189065D90")]
		private void OXMAMFRGCJV(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x90647A0", Offset = "0x9062DA0", VA = "0x1890647A0")]
		private void EBCOIYEJSWG(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9065520", Offset = "0x9063B20", VA = "0x189065520")]
		private void JYYLINTFBJH(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x905E730", Offset = "0x905CD30", VA = "0x18905E730")]
		private static int FGOONCAPCUE(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9064D50", Offset = "0x9063350", VA = "0x189064D50")]
		public ReadOnlySequence<byte> FIIYNTDZKJG()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x90671D0", Offset = "0x90657D0", VA = "0x1890671D0")]
		public string VTLIOZZACOZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x90643E0", Offset = "0x90629E0", VA = "0x1890643E0")]
		public string BILRUMPUWGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9066040", Offset = "0x9064640", VA = "0x189066040")]
		public ReadOnlySequence<byte> PSGPGIMVIBG()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9067070", Offset = "0x9065670", VA = "0x189067070")]
		public ReadOnlySequence<byte> ULOVADKUXTN()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9067310", Offset = "0x9065910", VA = "0x189067310")]
		public bool ZRJSPEXQFWI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9064420", Offset = "0x9062A20", VA = "0x189064420")]
		private void CBIWGTBJTSW(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9067300", Offset = "0x9065900", VA = "0x189067300")]
		public void YUMIJCGHKRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9065630", Offset = "0x9063C30", VA = "0x189065630")]
		private void LKJSTZFFHAR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9064650", Offset = "0x9062C50", VA = "0x189064650")]
		public sbyte DNYRGBHRFTN()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9066F70", Offset = "0x9065570", VA = "0x189066F70")]
		public short TXVDLELZIBM()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9065290", Offset = "0x9063890", VA = "0x189065290")]
		public int HSRASGPKXNC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x90659C0", Offset = "0x9063FC0", VA = "0x1890659C0")]
		public long MYJNWATGWZF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9067250", Offset = "0x9065850", VA = "0x189067250")]
		public byte WDALXYULWBM()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9065F90", Offset = "0x9064590", VA = "0x189065F90")]
		public ushort PJGMVKXIHAP()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x90645A0", Offset = "0x9062BA0", VA = "0x1890645A0")]
		public uint DFSNGPDYTYZ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9067160", Offset = "0x9065760", VA = "0x189067160")]
		public ulong VHPKHDLVQQO()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9064700", Offset = "0x9062D00", VA = "0x189064700")]
		public float DVIJGFOUMHC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x90665F0", Offset = "0x9064BF0", VA = "0x1890665F0")]
		public double PYVFPKCDJEN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9065340", Offset = "0x9063940", VA = "0x189065340")]
		public ReadOnlySequence<byte> IPQHBZSLOEG()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9065AF0", Offset = "0x90640F0", VA = "0x189065AF0")]
		private void NUGDZLYNLZK()
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
			[Cpp2IlInjected.Address(RVA = "0xBD1340", Offset = "0xBCF940", VA = "0x180BD1340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x90641F0", Offset = "0x90627F0", VA = "0x1890641F0")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9064170", Offset = "0x9062770", VA = "0x189064170")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class GAWCDWYNMQW
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class OIOXRVOSDUF
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] CMLDZKLDREO;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x906B9E0", Offset = "0x9069FE0", VA = "0x18906B9E0")]
			public static byte[] ITMPCJJXFEK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static CKTJJUOJSNN ZYNDLDBECSX;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] MJKJWCISJSG;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] ZTABXVNWKYU;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static CKTJJUOJSNN ORXQGZOYNHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x905FB00", Offset = "0x905E100", VA = "0x18905FB00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x905FA90", Offset = "0x905E090", VA = "0x18905FA90")]
		public static void MKZQPVPVRMP(CKTJJUOJSNN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x38DEC90", Offset = "0x38DD290", VA = "0x1838DEC90")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x38DEB20", Offset = "0x38DD120", VA = "0x1838DEB20")]
		public static byte[] Serialize<T>(T value, CKTJJUOJSNN resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x38DF270", Offset = "0x38DD870", VA = "0x1838DF270")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x38DF100", Offset = "0x38DD700", VA = "0x1838DF100")]
		public static string ToJsonString<T>(T value, CKTJJUOJSNN resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x38DE620", Offset = "0x38DCC20", VA = "0x1838DE620")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x38DE3D0", Offset = "0x38DC9D0", VA = "0x1838DE3D0")]
		public static T Deserialize<T>(string json, CKTJJUOJSNN resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x38DE550", Offset = "0x38DCB50", VA = "0x1838DE550")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x38DE280", Offset = "0x38DC880", VA = "0x1838DE280")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, CKTJJUOJSNN resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x38DD530", Offset = "0x38DBB30", VA = "0x1838DD530")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x38DD360", Offset = "0x38DB960", VA = "0x1838DD360")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, CKTJJUOJSNN resolver)
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
		public int JHDFIPUZNHQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xFD4DE0", Offset = "0xFD33E0", VA = "0x180FD4DE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9068080", Offset = "0x9066680", VA = "0x189068080")]
		public void UAUKMIIVCKZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x90688B0", Offset = "0x9066EB0", VA = "0x1890688B0")]
		public static byte[] ZELURXALZOA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x90676E0", Offset = "0x9065CE0", VA = "0x1890676E0")]
		public static byte[] DDBAJKFKHJG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9067F00", Offset = "0x9066500", VA = "0x189067F00")]
		public static byte[] SCAJGTHQGVQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9067C70", Offset = "0x9066270", VA = "0x189067C70")]
		public static byte[] MYQLGNZFRRY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2A47120", Offset = "0x2A45720", VA = "0x182A47120")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9067990", Offset = "0x9065F90", VA = "0x189067990")]
		public ArraySegment<byte> ITMPCJJXFEK()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9067A60", Offset = "0x9066060", VA = "0x189067A60")]
		public byte[] KIIDGOSZJQV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9068020", Offset = "0x9066620", VA = "0x189068020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9068680", Offset = "0x9066C80", VA = "0x189068680")]
		public void ULLOLHXVYXE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9067800", Offset = "0x9065E00", VA = "0x189067800")]
		public void EHQJFHXGIOL(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9068870", Offset = "0x9066E70", VA = "0x189068870")]
		public void YBFECBLKQVD(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x49227D0", Offset = "0x4920DD0", VA = "0x1849227D0")]
		public void DLNUWAEPWAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4922820", Offset = "0x4920E20", VA = "0x184922820")]
		public void LOETTMGPYCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9068820", Offset = "0x9066E20", VA = "0x189068820")]
		public void YAZBWBULMYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9067E60", Offset = "0x9066460", VA = "0x189067E60")]
		public void RJAWXJDZGHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4922870", Offset = "0x4920E70", VA = "0x184922870")]
		public void UHAOTHXSEQT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x51C2F70", Offset = "0x51C1570", VA = "0x1851C2F70")]
		public void GMSALKLHNAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9068780", Offset = "0x9066D80", VA = "0x189068780")]
		public void VLSZOJUKNCN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9067EB0", Offset = "0x90664B0", VA = "0x189067EB0")]
		public void RQVIXNICWKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x90678D0", Offset = "0x9065ED0", VA = "0x1890678D0")]
		public void ILHBIUZYKSO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x79CE370", Offset = "0x79CC970", VA = "0x1879CE370")]
		public void NZTJCTOUTXD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9068690", Offset = "0x9066C90", VA = "0x189068690")]
		public void VBLLQOVSDZJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9068990", Offset = "0x9066F90", VA = "0x189068990")]
		public void ZVCWBYORWNY(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9068710", Offset = "0x9066D10", VA = "0x189068710")]
		public void VGQBLVASRZH(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9067DF0", Offset = "0x90663F0", VA = "0x189067DF0")]
		public void QTGLXCASXUI(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9067670", Offset = "0x9065C70", VA = "0x189067670")]
		public void CYKOPZXHIIS(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9067A30", Offset = "0x9066030", VA = "0x189067A30")]
		public void IWTMBSLURYR(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x90675D0", Offset = "0x9065BD0", VA = "0x1890675D0")]
		public void BAJTWABLACK(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9068610", Offset = "0x9066C10", VA = "0x189068610")]
		public void UJFSWLFVJFJ(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9067860", Offset = "0x9065E60", VA = "0x189067860")]
		public void IEBQDNJGYQZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9067640", Offset = "0x9065C40", VA = "0x189067640")]
		public void CGNUGVWJAUK(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9068090", Offset = "0x9066690", VA = "0x189068090")]
		public void UGFNLOMIPTY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9067BF0", Offset = "0x90661F0", VA = "0x189067BF0")]
		private static bool LHHHKJRKRDO(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9067970", Offset = "0x9065F70", VA = "0x189067970")]
		private static byte IMDLXVPAIXQ(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x905E7F0", Offset = "0x905CDF0", VA = "0x18905E7F0")]
		private static void EDIVCIDXGHV(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class SHNKBGMYVIA : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6148F90", Offset = "0x6147590", VA = "0x186148F90")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private SHNKBGMYVIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class MWNNPXMHMTD : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x61573C0", Offset = "0x61559C0", VA = "0x1861573C0")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class NMPJBIGFNGL
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> JFAUKSZLOFW;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9069880", Offset = "0x9067E80", VA = "0x189069880")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private MWNNPXMHMTD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class WEFPPIXDJBP : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6159850", Offset = "0x6157E50", VA = "0x186159850")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly WEFPPIXDJBP ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool JJBRVIFLPKF;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static GGASJLLNBGR[] HUVPJKSUBPN;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static CKTJJUOJSNN[] NJSFDMQUFOD;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private WEFPPIXDJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9071370", Offset = "0x906F970", VA = "0x189071370")]
		public static void KQPXXDZDTRT(params CKTJJUOJSNN[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x90712A0", Offset = "0x906F8A0", VA = "0x1890712A0")]
		public static void KQPXXDZDTRT(params GGASJLLNBGR[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9071040", Offset = "0x906F640", VA = "0x189071040")]
		public static void HHYXFFLWVQX(GGASJLLNBGR[] a, CKTJJUOJSNN[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class ELSJAVYSFWM : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x61672A0", Offset = "0x61658A0", VA = "0x1861672A0")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private ELSJAVYSFWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class JPWUBMAAAJZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly CKTJJUOJSNN AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly CKTJJUOJSNN DBXFVVOSXBK;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class BQZJSEHAQJB
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly CKTJJUOJSNN AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly CKTJJUOJSNN FOAFHTKCRWS;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly CKTJJUOJSNN TCAQWJKUOSY;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly CKTJJUOJSNN LLXJVYFQCSH;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly CKTJJUOJSNN MRJMWWEZVWH;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly CKTJJUOJSNN EUCNHNSMMFD;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly CKTJJUOJSNN SMWJQPAUBKA;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly CKTJJUOJSNN SZOHDNLYLRM;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly CKTJJUOJSNN DQBVERUESKY;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly CKTJJUOJSNN BXHLIKWOTKT;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly CKTJJUOJSNN HLECJPCHGDB;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly CKTJJUOJSNN LULVHPLSQPP;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class PLZECOTUUWO
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> JFAUKSZLOFW;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x906C730", Offset = "0x906AD30", VA = "0x18906C730")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x906C6F0", Offset = "0x906ACF0", VA = "0x18906C6F0")]
		private static object CUOMCJLEGBV(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class CEGDLVQDOYE : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6130F90", Offset = "0x612F590", VA = "0x186130F90")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private CEGDLVQDOYE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class BABBCTTVRWN : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x613F300", Offset = "0x613D900", VA = "0x18613F300")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private BABBCTTVRWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class NZTJYNTLLIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly CKTJJUOJSNN[] CGGXKYXUAKU;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class YIQPKZMUKES : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6162840", Offset = "0x6160E40", VA = "0x186162840")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class SRMHVDQBTHY : CKTJJUOJSNN
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class TKYHWQPCRYL<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x6140D20", Offset = "0x613F320", VA = "0x186140D20")]
				static TKYHWQPCRYL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly CKTJJUOJSNN ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly CKTJJUOJSNN[] NJSFDMQUFOD;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private SRMHVDQBTHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
			public IGIJDGNWSCS<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly IGIJDGNWSCS<object> LVNVXWWILLO;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private YIQPKZMUKES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class SWTUQGHFOOB : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x61575A0", Offset = "0x6155BA0", VA = "0x1861575A0")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class SRMHVDQBTHY : CKTJJUOJSNN
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class TKYHWQPCRYL<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x6137660", Offset = "0x6135C60", VA = "0x186137660")]
				static TKYHWQPCRYL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly CKTJJUOJSNN ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly CKTJJUOJSNN[] NJSFDMQUFOD;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private SRMHVDQBTHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
			public IGIJDGNWSCS<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly IGIJDGNWSCS<object> LVNVXWWILLO;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private SWTUQGHFOOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class BIZZFKEVMKT : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x613D770", Offset = "0x613BD70", VA = "0x18613D770")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class SRMHVDQBTHY : CKTJJUOJSNN
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class TKYHWQPCRYL<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x613FD00", Offset = "0x613E300", VA = "0x18613FD00")]
				static TKYHWQPCRYL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly CKTJJUOJSNN ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly CKTJJUOJSNN[] NJSFDMQUFOD;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private SRMHVDQBTHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
			public IGIJDGNWSCS<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly IGIJDGNWSCS<object> LVNVXWWILLO;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private BIZZFKEVMKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class NLOEXYLVING : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x613C4F0", Offset = "0x613AAF0", VA = "0x18613C4F0")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class SRMHVDQBTHY : CKTJJUOJSNN
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class TKYHWQPCRYL<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x615F020", Offset = "0x615D620", VA = "0x18615F020")]
				static TKYHWQPCRYL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly CKTJJUOJSNN ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly CKTJJUOJSNN[] NJSFDMQUFOD;

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private SRMHVDQBTHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
			public IGIJDGNWSCS<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly IGIJDGNWSCS<object> LVNVXWWILLO;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private NLOEXYLVING()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class OVWGFFUHEJC : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x615A310", Offset = "0x6158910", VA = "0x18615A310")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class SRMHVDQBTHY : CKTJJUOJSNN
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class TKYHWQPCRYL<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x613A1C0", Offset = "0x61387C0", VA = "0x18613A1C0")]
				static TKYHWQPCRYL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly CKTJJUOJSNN ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly CKTJJUOJSNN[] NJSFDMQUFOD;

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private SRMHVDQBTHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
			public IGIJDGNWSCS<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly IGIJDGNWSCS<object> LVNVXWWILLO;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private OVWGFFUHEJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class WFKTHDNDUDM : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x616D2E0", Offset = "0x616B8E0", VA = "0x18616D2E0")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class SRMHVDQBTHY : CKTJJUOJSNN
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class TKYHWQPCRYL<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

				[Cpp2IlInjected.Token(Token = "0x60000DE")]
				[Cpp2IlInjected.Address(RVA = "0x6153E30", Offset = "0x6152430", VA = "0x186153E30")]
				static TKYHWQPCRYL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly CKTJJUOJSNN ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly CKTJJUOJSNN[] NJSFDMQUFOD;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private SRMHVDQBTHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
			public IGIJDGNWSCS<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly IGIJDGNWSCS<object> LVNVXWWILLO;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private WFKTHDNDUDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class DCMGCORJYIT : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6154690", Offset = "0x6152C90", VA = "0x186154690")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class SRMHVDQBTHY : CKTJJUOJSNN
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class TKYHWQPCRYL<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x61625A0", Offset = "0x6160BA0", VA = "0x1861625A0")]
				static TKYHWQPCRYL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly CKTJJUOJSNN ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly CKTJJUOJSNN[] NJSFDMQUFOD;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private SRMHVDQBTHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
			public IGIJDGNWSCS<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly IGIJDGNWSCS<object> LVNVXWWILLO;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private DCMGCORJYIT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class BGJBSUMFELH : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x61582E0", Offset = "0x61568E0", VA = "0x1861582E0")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class SRMHVDQBTHY : CKTJJUOJSNN
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class TKYHWQPCRYL<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x6142260", Offset = "0x6140860", VA = "0x186142260")]
				static TKYHWQPCRYL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly CKTJJUOJSNN ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly CKTJJUOJSNN[] NJSFDMQUFOD;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private SRMHVDQBTHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
			public IGIJDGNWSCS<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly IGIJDGNWSCS<object> LVNVXWWILLO;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private BGJBSUMFELH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class AKFRXHXAEZF : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6132600", Offset = "0x6130C00", VA = "0x186132600")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class SRMHVDQBTHY : CKTJJUOJSNN
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class TKYHWQPCRYL<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x615CD80", Offset = "0x615B380", VA = "0x18615CD80")]
				static TKYHWQPCRYL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly CKTJJUOJSNN ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly CKTJJUOJSNN[] NJSFDMQUFOD;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private SRMHVDQBTHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
			public IGIJDGNWSCS<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly IGIJDGNWSCS<object> LVNVXWWILLO;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private AKFRXHXAEZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class VEKXRWCNZDW : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x614B550", Offset = "0x6149B50", VA = "0x18614B550")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class SRMHVDQBTHY : CKTJJUOJSNN
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class TKYHWQPCRYL<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x6137340", Offset = "0x6135940", VA = "0x186137340")]
				static TKYHWQPCRYL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly CKTJJUOJSNN ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly CKTJJUOJSNN[] NJSFDMQUFOD;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private SRMHVDQBTHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
			public IGIJDGNWSCS<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly IGIJDGNWSCS<object> LVNVXWWILLO;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private VEKXRWCNZDW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class XEOXQOKJAMU : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x613A920", Offset = "0x6138F20", VA = "0x18613A920")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class SRMHVDQBTHY : CKTJJUOJSNN
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class TKYHWQPCRYL<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x613E830", Offset = "0x613CE30", VA = "0x18613E830")]
				static TKYHWQPCRYL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly CKTJJUOJSNN ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly CKTJJUOJSNN[] NJSFDMQUFOD;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private SRMHVDQBTHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
			public IGIJDGNWSCS<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly IGIJDGNWSCS<object> LVNVXWWILLO;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private XEOXQOKJAMU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class BDPNQQTNWVA : CKTJJUOJSNN
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class TKYHWQPCRYL<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x616C7D0", Offset = "0x616ADD0", VA = "0x18616C7D0")]
			static TKYHWQPCRYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class SRMHVDQBTHY : CKTJJUOJSNN
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class TKYHWQPCRYL<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly IGIJDGNWSCS<a> VNOKRTYVSXY;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x6164050", Offset = "0x6162650", VA = "0x186164050")]
				static TKYHWQPCRYL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly CKTJJUOJSNN ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly CKTJJUOJSNN[] NJSFDMQUFOD;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private SRMHVDQBTHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
			public IGIJDGNWSCS<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly CKTJJUOJSNN ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly IGIJDGNWSCS<object> LVNVXWWILLO;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		private BDPNQQTNWVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x32A0B70", Offset = "0x329F170", VA = "0x1832A0B70", Slot = "4")]
		public IGIJDGNWSCS<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x59AE880", Offset = "0x59ACE80", VA = "0x1859AE880")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x59AE590", Offset = "0x59ACB90", VA = "0x1859AE590")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x59AE7F0", Offset = "0x59ACDF0", VA = "0x1859AE7F0")]
		public T[] QQZVJXILBMW()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class LBMTFAYQPGA<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int EXXORQQCSXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object JSVJSGBYUWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int RQNIDISRYME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] OSXUPFBTYCH;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5467880", Offset = "0x5465E80", VA = "0x185467880")]
		public LBMTFAYQPGA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5467290", Offset = "0x5465890", VA = "0x185467290")]
		public a[] HEQWBIOGYMT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5467700", Offset = "0x5465D00", VA = "0x185467700")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class QWGCVROHGSW : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class TGJLCHNWXLI : IComparable<TGJLCHNWXLI>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class XBJIJVBOGYW : IEnumerable<TGJLCHNWXLI>, IEnumerable, IEnumerator<TGJLCHNWXLI>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int AEMBTWPORMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private TGJLCHNWXLI MVWPOXUKILF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int NVRLJVISCMF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public TGJLCHNWXLI CDTALOACOKM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int HAOYDNHAFWO;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private TGJLCHNWXLI BYIKCDUMLFN
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object HLWKSVCMTHU
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xB597F0", Offset = "0xB57DF0", VA = "0x180B597F0")]
				[DebuggerHidden]
				public XBJIJVBOGYW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "7")]
				[DebuggerHidden]
				private void CJOOGEZDZDP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x9071660", Offset = "0x906FC60", VA = "0x189071660", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x90716E0", Offset = "0x906FCE0", VA = "0x1890716E0", Slot = "10")]
				[DebuggerHidden]
				private void VIZWRAVZEQM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x90715C0", Offset = "0x906FBC0", VA = "0x1890715C0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<TGJLCHNWXLI> PMREWCHJPBK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x90715C0", Offset = "0x906FBC0", VA = "0x1890715C0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator MZPFIUHPQEF()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly TGJLCHNWXLI[] TURZKVMKZWW;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] OIDYIGVOZGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong SSZWFWYFAPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int HOYELULZOXT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string HZJLKWZYNUS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TGJLCHNWXLI[] NNRGOFNCRNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] ZSVKLGJLRAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int ZYZGCKPXBNJ;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9070C00", Offset = "0x906F200", VA = "0x189070C00")]
			public TGJLCHNWXLI(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x90706B0", Offset = "0x906ECB0", VA = "0x1890706B0")]
			public TGJLCHNWXLI Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9070650", Offset = "0x906EC50", VA = "0x189070650")]
			public TGJLCHNWXLI Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x90708E0", Offset = "0x906EEE0", VA = "0x1890708E0")]
			public TGJLCHNWXLI FXLVYVKMKKU(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x9070AD0", Offset = "0x906F0D0", VA = "0x189070AD0")]
			internal static int OYDKBYMMTNT(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x90708B0", Offset = "0x906EEB0", VA = "0x1890708B0", Slot = "4")]
			public int CompareTo(TGJLCHNWXLI other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x9070A50", Offset = "0x906F050", VA = "0x189070A50")]
			[IteratorStateMachine(typeof(XBJIJVBOGYW))]
			public IEnumerable<TGJLCHNWXLI> IYBWTXJHWKS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class LCCHTYSNSWU : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<TGJLCHNWXLI> NNRGOFNCRNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<TGJLCHNWXLI> TJGBJKRKLXH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<TGJLCHNWXLI> TPFONUYPLCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private TGJLCHNWXLI ARZKGVGQEDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> TPQCIIMKDYS;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> QXHDFTAVTWR
			{
				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0xC5F3C0", Offset = "0xC5D9C0", VA = "0x180C5F3C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x9068C20", Offset = "0x9067220", VA = "0x189068C20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xC5F770", Offset = "0xC5DD70", VA = "0x180C5F770")]
			[DebuggerHidden]
			public LCCHTYSNSWU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x9068AD0", Offset = "0x90670D0", VA = "0x189068AD0", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x9068DB0", Offset = "0x90673B0", VA = "0x189068DB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x9068CC0", Offset = "0x90672C0", VA = "0x189068CC0")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x9068C70", Offset = "0x9067270", VA = "0x189068C70")]
			private void KOSXCWUKUNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x9069210", Offset = "0x9067810", VA = "0x189069210", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x9068D10", Offset = "0x9067310", VA = "0x189068D10", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> VFPEFMKDPDQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x9068D10", Offset = "0x9067310", VA = "0x189068D10", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly TGJLCHNWXLI UPYDKJXZEYI;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x906F4C0", Offset = "0x906DAC0", VA = "0x18906F4C0")]
		public QWGCVROHGSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x906EC70", Offset = "0x906D270", VA = "0x18906EC70")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x906F3B0", Offset = "0x906D9B0", VA = "0x18906F3B0")]
		public bool ZKJFYFPTSEI(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x906EEB0", Offset = "0x906D4B0", VA = "0x18906EEB0")]
		public bool HCDGKMVNZFP([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x906F040", Offset = "0x906D640", VA = "0x18906F040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x906F0D0", Offset = "0x906D6D0", VA = "0x18906F0D0")]
		private static void ZCBGHSJFUKP(IEnumerable<TGJLCHNWXLI> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x906EE50", Offset = "0x906D450", VA = "0x18906EE50", Slot = "5")]
		private IEnumerator MZPFIUHPQEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x906EE50", Offset = "0x906D450", VA = "0x18906EE50", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x906EFC0", Offset = "0x906D5C0", VA = "0x18906EFC0")]
		[IteratorStateMachine(typeof(LCCHTYSNSWU))]
		private static IEnumerable<KeyValuePair<string, int>> MXTIQFBOTFE(IEnumerable<TGJLCHNWXLI> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class HEYZKMOXLQZ
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo ZWBQUNDEKHU;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9062970", Offset = "0x9060F70", VA = "0x189062970")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9062B20", Offset = "0x9061120", VA = "0x189062B20")]
		public static ulong LQBELQKNJDE(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class LUWOZAOAXRL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x90694B0", Offset = "0x9067AB0", VA = "0x1890694B0")]
		public static void ULLOLHXVYXE(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9069390", Offset = "0x9067990", VA = "0x189069390")]
		public static void POXRICYDIIC(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9069250", Offset = "0x9067850", VA = "0x189069250")]
		public static byte[] JSKEOGOJZQH(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class AXHJXHUCJVL<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x4959E20", Offset = "0x4958420", VA = "0x184959E20", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class GDIMLICIUHP : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public AXHJXHUCJVL<a> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] TPFONUYPLCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int TPVJFPGHNKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] TPQCIIMKDYS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int TQFXACUCGGT;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> MXANPCSGJQQ
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xC5F3C0", Offset = "0xC5D9C0", VA = "0x180C5F3C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x4FDD4A0", Offset = "0x4FDBAA0", VA = "0x184FDD4A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public GDIMLICIUHP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x505CEB0", Offset = "0x505B4B0", VA = "0x18505CEB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] AQKJTUJFXXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong JPLSXQHRHGL;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool ACWDDTLVCJC;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x56CC020", Offset = "0x56CA620", VA = "0x1856CC020")]
		public AXHJXHUCJVL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x56CC110", Offset = "0x56CA710", VA = "0x1856CC110")]
		public AXHJXHUCJVL(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x56BD4D0", Offset = "0x56BBAD0", VA = "0x1856BD4D0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x56C8490", Offset = "0x56C6A90", VA = "0x1856C8490")]
		private bool ZXXQYEBPZNL(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x56C2ED0", Offset = "0x56C14D0", VA = "0x1856C2ED0")]
		public bool ZKJFYFPTSEI([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x56BFF40", Offset = "0x56BE540", VA = "0x1856BFF40")]
		private static ulong IIEVEQJWKHC([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x56BE9A0", Offset = "0x56BCFA0", VA = "0x1856BE9A0")]
		private static ulong IIEVEQJWKHC([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x56BE620", Offset = "0x56BCC20", VA = "0x1856BE620")]
		private static int ELBPDZRBYUY(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x56BE650", Offset = "0x56BCC50", VA = "0x1856BE650", Slot = "4")]
		[IteratorStateMachine(typeof(AXHJXHUCJVL<>.GDIMLICIUHP))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x56C2400", Offset = "0x56C0A00", VA = "0x1856C2400", Slot = "5")]
		private IEnumerator MZPFIUHPQEF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class ZUIUYFUTKZC
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7750", Offset = "0x3EF5D50", VA = "0x183EF7750")]
		public static Func<a> EDUXPSCFXEC<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7840", Offset = "0x3EF5E40", VA = "0x183EF7840")]
		private static c ELJQHONXDBN<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0x90606F0", Offset = "0x905ECF0", VA = "0x1890606F0")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9060700", Offset = "0x905ED00", VA = "0x189060700")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9060570", Offset = "0x905EB70", VA = "0x189060570")]
		private static byte SLACCWFOPWP(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x905D300", Offset = "0x905B900", VA = "0x18905D300")]
		private static byte ZGGURPXAULV(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x905FD70", Offset = "0x905E370", VA = "0x18905FD70")]
		public void GYNQACGGPQL(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class HBZBPGIUJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9061A80", Offset = "0x9060080", VA = "0x189061A80")]
		public static bool CCOPHONXHQN(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9061EB0", Offset = "0x90604B0", VA = "0x189061EB0")]
		public static bool OQNXTISDZOU(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9061AF0", Offset = "0x90600F0", VA = "0x189061AF0")]
		public static sbyte DNYRGBHRFTN([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9062390", Offset = "0x9060990", VA = "0x189062390")]
		public static short TXVDLELZIBM([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9061C40", Offset = "0x9060240", VA = "0x189061C40")]
		public static int HSRASGPKXNC([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9061DA0", Offset = "0x90603A0", VA = "0x189061DA0")]
		public static long MYJNWATGWZF([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9062500", Offset = "0x9060B00", VA = "0x189062500")]
		public static bool WQFZXTGOLVK(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x90624A0", Offset = "0x9060AA0", VA = "0x1890624A0")]
		public static byte WDALXYULWBM([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9061F20", Offset = "0x9060520", VA = "0x189061F20")]
		public static ushort PJGMVKXIHAP([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9061A90", Offset = "0x9060090", VA = "0x189061A90")]
		public static uint DFSNGPDYTYZ([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x90623F0", Offset = "0x90609F0", VA = "0x1890623F0")]
		public static ulong VHPKHDLVQQO([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9062070", Offset = "0x9060670", VA = "0x189062070")]
		public static bool QHBPWSIETED(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x90621C0", Offset = "0x90607C0", VA = "0x1890621C0")]
		public static bool SOACCHAZUKL(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9062690", Offset = "0x9060C90", VA = "0x189062690")]
		public static bool XXLQAXKUJZF(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9061CA0", Offset = "0x90602A0", VA = "0x189061CA0")]
		public static bool IFCLCNBMNGF(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9061B50", Offset = "0x9060150", VA = "0x189061B50")]
		public static float DVIJGFOUMHC([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9061E50", Offset = "0x9060450", VA = "0x189061E50")]
		public static bool OCLUGXJPQSZ(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9061F80", Offset = "0x9060580", VA = "0x189061F80")]
		public static double PYVFPKCDJEN([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9061D40", Offset = "0x9060340", VA = "0x189061D40")]
		public static bool JPBTEKZYCPO(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x905DDD0", Offset = "0x905C3D0", VA = "0x18905DDD0")]
		public static int IWTMBSLURYR(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x905D410", Offset = "0x905BA10", VA = "0x18905D410")]
		public static int CGNUGVWJAUK(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x90627A0", Offset = "0x9060DA0", VA = "0x1890627A0")]
		public static bool ZRJSPEXQFWI([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class FUDFQLXCFCD
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x905F980", Offset = "0x905DF80", VA = "0x18905F980")]
		public static bool AFUHMETWHEJ(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class OQZLDTPKKNS
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding DTTUAWKYQSL;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class HKYPNMYDUSA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x90632C0", Offset = "0x90618C0", VA = "0x1890632C0")]
		public static void ENFVOPLYFOJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9063250", Offset = "0x9061850", VA = "0x189063250")]
		public static void ENAORISAWDA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x90631E0", Offset = "0x90617E0", VA = "0x1890631E0")]
		public static void EMVHUBYDMRR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9063170", Offset = "0x9061770", VA = "0x189063170")]
		public static void EMQAWVEGDGI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x90634F0", Offset = "0x9061AF0", VA = "0x1890634F0")]
		public static void EPRAHSQSOUN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9063480", Offset = "0x9061A80", VA = "0x189063480")]
		public static void EPLTKLWVFJE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9063CC0", Offset = "0x90622C0", VA = "0x189063CC0")]
		public static void TCVGZIPNDQC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9063D30", Offset = "0x9062330", VA = "0x189063D30")]
		public static void TDANWPJKNBL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9063BD0", Offset = "0x90621D0", VA = "0x189063BD0")]
		public static void TCKTEVBSKTK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9063C40", Offset = "0x9062240", VA = "0x189063C40")]
		public static void TCQACBVPUET(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9063EA0", Offset = "0x90624A0", VA = "0x189063EA0")]
		public static void TDQIOJRCPJM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9063F20", Offset = "0x9062520", VA = "0x189063F20")]
		public static void TDVPLQKZYUV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9063DA0", Offset = "0x90623A0", VA = "0x189063DA0")]
		public static void TDFUTWDHWMU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9063E20", Offset = "0x9062420", VA = "0x189063E20")]
		public static void TDLBRCXFFYD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9063FA0", Offset = "0x90625A0", VA = "0x189063FA0")]
		public static void TELKDKSSBCW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9064020", Offset = "0x9062620", VA = "0x189064020")]
		public static void TEQRARMPKOF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9063B50", Offset = "0x9062150", VA = "0x189063B50")]
		public static void MIQOQYUEDWV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9063AD0", Offset = "0x90620D0", VA = "0x189063AD0")]
		public static void MILHTSAGULM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9063A50", Offset = "0x9062050", VA = "0x189063A50")]
		public static void MIGAWLGJLAD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x90639D0", Offset = "0x9061FD0", VA = "0x1890639D0")]
		public static void MIATZEMMBOU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9063950", Offset = "0x9061F50", VA = "0x189063950")]
		public static void MHVNBXSOSDL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x90638C0", Offset = "0x9061EC0", VA = "0x1890638C0")]
		public static void MHQGEQYRISC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9063830", Offset = "0x9061E30", VA = "0x189063830")]
		public static void MHKZHKETZGT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x90637A0", Offset = "0x9061DA0", VA = "0x1890637A0")]
		public static void MHFSKDKWPVK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9063710", Offset = "0x9061D10", VA = "0x189063710")]
		public static void MHALMWQZGKB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9063680", Offset = "0x9061C80", VA = "0x189063680")]
		public static void MGVEPPXBWYS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9063560", Offset = "0x9061B60", VA = "0x189063560")]
		public static void FHZJSGMBOEM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x90635F0", Offset = "0x9061BF0", VA = "0x1890635F0")]
		public static void FIEQPNFYXPV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9063410", Offset = "0x9061A10", VA = "0x189063410")]
		public static void ENVQGJTQHWK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x90633A0", Offset = "0x90619A0", VA = "0x1890633A0")]
		public static void ENQJJCZSYLB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9063330", Offset = "0x9061930", VA = "0x189063330")]
		public static void ENLCLWFVOZS(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class PHLPIWNCANR
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x906BBF0", Offset = "0x906A1F0", VA = "0x18906BBF0")]
		public static void EPRAHSQSOUN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x906BB80", Offset = "0x906A180", VA = "0x18906BB80")]
		public static void EPLTKLWVFJE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x906C340", Offset = "0x906A940", VA = "0x18906C340")]
		public static void TCVGZIPNDQC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x906C3B0", Offset = "0x906A9B0", VA = "0x18906C3B0")]
		public static void TDANWPJKNBL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x906C260", Offset = "0x906A860", VA = "0x18906C260")]
		public static void TCKTEVBSKTK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x906C2D0", Offset = "0x906A8D0", VA = "0x18906C2D0")]
		public static void TCQACBVPUET(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x906C510", Offset = "0x906AB10", VA = "0x18906C510")]
		public static void TDQIOJRCPJM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x906C580", Offset = "0x906AB80", VA = "0x18906C580")]
		public static void TDVPLQKZYUV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x906C420", Offset = "0x906AA20", VA = "0x18906C420")]
		public static void TDFUTWDHWMU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x906C490", Offset = "0x906AA90", VA = "0x18906C490")]
		public static void TDLBRCXFFYD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x906C5F0", Offset = "0x906ABF0", VA = "0x18906C5F0")]
		public static void TELKDKSSBCW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x906C670", Offset = "0x906AC70", VA = "0x18906C670")]
		public static void TEQRARMPKOF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x906C1E0", Offset = "0x906A7E0", VA = "0x18906C1E0")]
		public static void MIQOQYUEDWV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x906C160", Offset = "0x906A760", VA = "0x18906C160")]
		public static void MILHTSAGULM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x906C0E0", Offset = "0x906A6E0", VA = "0x18906C0E0")]
		public static void MIGAWLGJLAD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x906C060", Offset = "0x906A660", VA = "0x18906C060")]
		public static void MIATZEMMBOU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x906BFE0", Offset = "0x906A5E0", VA = "0x18906BFE0")]
		public static void MHVNBXSOSDL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x906BF60", Offset = "0x906A560", VA = "0x18906BF60")]
		public static void MHQGEQYRISC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x906BEE0", Offset = "0x906A4E0", VA = "0x18906BEE0")]
		public static void MHKZHKETZGT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x906BE60", Offset = "0x906A460", VA = "0x18906BE60")]
		public static void MHFSKDKWPVK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x906BDE0", Offset = "0x906A3E0", VA = "0x18906BDE0")]
		public static void MHALMWQZGKB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x906BD60", Offset = "0x906A360", VA = "0x18906BD60")]
		public static void MGVEPPXBWYS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x906BC60", Offset = "0x906A260", VA = "0x18906BC60")]
		public static void FHZJSGMBOEM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x906BCE0", Offset = "0x906A2E0", VA = "0x18906BCE0")]
		public static void FIEQPNFYXPV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x9063410", Offset = "0x9061A10", VA = "0x189063410")]
		public static void ENVQGJTQHWK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x90633A0", Offset = "0x90619A0", VA = "0x1890633A0")]
		public static void ENQJJCZSYLB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x9063330", Offset = "0x9061930", VA = "0x189063330")]
		public static void ENLCLWFVOZS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x90632C0", Offset = "0x90618C0", VA = "0x1890632C0")]
		public static void ENFVOPLYFOJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9063250", Offset = "0x9061850", VA = "0x189063250")]
		public static void ENAORISAWDA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x90631E0", Offset = "0x90617E0", VA = "0x1890631E0")]
		public static void EMVHUBYDMRR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x9063170", Offset = "0x9061770", VA = "0x189063170")]
		public static void EMQAWVEGDGI(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class BGMBRZTIKPT
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool ACWDDTLVCJC;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x90721B0", Offset = "0x90707B0", VA = "0x1890721B0")]
		public static void EHQJFHXGIOL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9073BB0", Offset = "0x90721B0", VA = "0x189073BB0")]
		public static void TWRILAHTGDE(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x2AEE0E0", Offset = "0x2AEC6E0", VA = "0x182AEE0E0")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x90752F0", Offset = "0x90738F0", VA = "0x1890752F0")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x90751B0", Offset = "0x90737B0", VA = "0x1890751B0")]
		public static DiyFp INGSGPNIOHS(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x90751C0", Offset = "0x90737C0", VA = "0x1890751C0")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x9075250", Offset = "0x9073850", VA = "0x189075250")]
		public static DiyFp OJTYEUBFDWW(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9075300", Offset = "0x9073900", VA = "0x189075300")]
		public void VXJJYZPCEID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9075340", Offset = "0x9073940", VA = "0x189075340")]
		public static DiyFp VXJJYZPCEID(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xE1EEC0", Offset = "0xE1D4C0", VA = "0x180E1EEC0")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x90843C0", Offset = "0x90829C0", VA = "0x1890843C0")]
		public void OXWXLTWLUBY(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x90840A0", Offset = "0x90826A0", VA = "0x1890840A0")]
		public void JTDRYYFGQBE(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9084340", Offset = "0x9082940", VA = "0x189084340")]
		public void MXEOBNQDPHQ(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x90842A0", Offset = "0x90828A0", VA = "0x1890842A0")]
		public void MXEOBNQDPHQ(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9084120", Offset = "0x9082720", VA = "0x189084120")]
		public void MGHPIVHXHDO(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x90841A0", Offset = "0x90827A0", VA = "0x1890841A0")]
		public void MRTBCIBCZVB(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class UFRXAJGGIQP
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
		private static byte[] ZOQHXWEWBDK;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] AWTGKEIVBOE;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] OIOPXZFZFPE;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] QBZPTVIPFXZ;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags XKFWZZOOESY;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char ZYSHWCKYFCI;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int ZYSDWAXWHGA;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int CYCXWUNZFEI;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] SFIPCSKXVIK;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9086020", Offset = "0x9084620", VA = "0x189086020")]
		private static byte[] BOUHZXTKUOU(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9086E00", Offset = "0x9085400", VA = "0x189086E00")]
		private static byte[] MFQBFDJACRW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x90862B0", Offset = "0x90848B0", VA = "0x1890862B0")]
		public static int GPCRVCUOFAT(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x90863D0", Offset = "0x90849D0", VA = "0x1890863D0")]
		public static int GPCRVCUOFAT(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x9087740", Offset = "0x9085D40", VA = "0x189087740")]
		private static bool XNEEYZMAPCR(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x9087460", Offset = "0x9085A60", VA = "0x189087460")]
		private static void STGIIPFULPD(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9087BC0", Offset = "0x90861C0", VA = "0x189087BC0")]
		private static bool ZVZTLCGUPKN(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9086FE0", Offset = "0x90855E0", VA = "0x189086FE0")]
		private static bool PZWCXBBYEMZ(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9086EE0", Offset = "0x90854E0", VA = "0x189086EE0")]
		private static bool NNEYXSZPKMW(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x90860F0", Offset = "0x90846F0", VA = "0x1890860F0")]
		private static bool EASRUCMVMWP(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x9086930", Offset = "0x9084F30", VA = "0x189086930")]
		private static bool LGGQCSQIHRE(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9087830", Offset = "0x9085E30", VA = "0x189087830")]
		private static void ZPSYHLOGSCC(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x90864F0", Offset = "0x9084AF0", VA = "0x1890864F0")]
		private static void IPBAQZOUYNU(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x9087550", Offset = "0x9085B50", VA = "0x189087550")]
		private static bool XASEIBZGJTV(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0x90759B0", Offset = "0x9073FB0", VA = "0x1890759B0")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9075910", Offset = "0x9073F10", VA = "0x189075910")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x9075800", Offset = "0x9073E00", VA = "0x189075800")]
		public DiyFp VFZACDLFUFS()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x9075690", Offset = "0x9073C90", VA = "0x189075690")]
		public DiyFp LVDEBYSIDBV()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
		public ulong NNREVUTDYQC()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x9075610", Offset = "0x9073C10", VA = "0x189075610")]
		public double KHWOLWPAOEE()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x9075870", Offset = "0x9073E70", VA = "0x189075870")]
		public double XSUHLSEKJGA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x9075710", Offset = "0x9073D10", VA = "0x189075710")]
		public int NMAXWYBOEXJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x90757D0", Offset = "0x9073DD0", VA = "0x1890757D0")]
		public ulong PZWOEWUIBSH()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x90754F0", Offset = "0x9073AF0", VA = "0x1890754F0")]
		public bool DWDHWCOAWSI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x9075390", Offset = "0x9073990", VA = "0x189075390")]
		public bool BKIEQEZKUQL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x90755E0", Offset = "0x9073BE0", VA = "0x1890755E0")]
		public bool KBQNOWRHWHX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x9075560", Offset = "0x9073B60", VA = "0x189075560")]
		public bool FNHUPPHGIYQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x9075590", Offset = "0x9073B90", VA = "0x189075590")]
		public int GTHXFSJRAWF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x90753B0", Offset = "0x90739B0", VA = "0x1890753B0")]
		public void DCRTHQVXHOP([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x9075510", Offset = "0x9073B10", VA = "0x189075510")]
		public bool EHMXEGWDJKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3E76710", Offset = "0x3E74D10", VA = "0x183E76710")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x90755C0", Offset = "0x9073BC0", VA = "0x1890755C0")]
		public static int JNVPXFANZQA(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x90755B0", Offset = "0x9073BB0", VA = "0x1890755B0")]
		public static double HUXBPKSQCTG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x9075740", Offset = "0x9073D40", VA = "0x189075740")]
		public static ulong NMXRIXZGHST(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x2D563B0", Offset = "0x2D549B0", VA = "0x182D563B0")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x9084040", Offset = "0x9082640", VA = "0x189084040")]
		public DiyFp VFZACDLFUFS()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xD991D0", Offset = "0xD977D0", VA = "0x180D991D0")]
		public uint TLFASMGBWMR()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9084000", Offset = "0x9082600", VA = "0x189084000")]
		public int NMAXWYBOEXJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x9084020", Offset = "0x9082620", VA = "0x189084020")]
		public uint PZWOEWUIBSH()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9083FB0", Offset = "0x90825B0", VA = "0x189083FB0")]
		public bool DWDHWCOAWSI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9083E80", Offset = "0x9082480", VA = "0x189083E80")]
		public void DCRTHQVXHOP([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9083FC0", Offset = "0x90825C0", VA = "0x189083FC0")]
		public bool EHMXEGWDJKB()
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
		[Cpp2IlInjected.Address(RVA = "0x90749C0", Offset = "0x9072FC0", VA = "0x1890749C0")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class NHBSRTGVGPW
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] WHUITGDHERP;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x907D160", Offset = "0x907B760", VA = "0x18907D160")]
		public static void PMWOSOWEIZD(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x907D270", Offset = "0x907B870", VA = "0x18907D270")]
		public static void YCXXUBJMDZM(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0x90892E0", Offset = "0x90878E0", VA = "0x1890892E0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5A58450", Offset = "0x5A56A50", VA = "0x185A58450")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D22060", Offset = "0x2D20660", VA = "0x182D22060")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9089280", Offset = "0x9087880", VA = "0x189089280")]
		public Vector NTFVPLQIIUJ(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class GVLBOFTZCHH
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] AGHECPKZVSL;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] MCYHIEMPPAK;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int OGQTONAMWZV;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x9078030", Offset = "0x9076630", VA = "0x189078030")]
		private static byte[] DECZGGQSZNJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9078650", Offset = "0x9076C50", VA = "0x189078650")]
		private static Vector FYCWCOULTYJ(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9077F50", Offset = "0x9076550", VA = "0x189077F50")]
		private static Vector BXASTZIEOET(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9078A20", Offset = "0x9077020", VA = "0x189078A20")]
		private static void QLNVWACHXUG(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9078730", Offset = "0x9076D30", VA = "0x189078730")]
		private static void OQOSIHVZWNB(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9079100", Offset = "0x9077700", VA = "0x189079100")]
		private static ulong ZNXWNERYMSS(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x9078FC0", Offset = "0x90775C0", VA = "0x189078FC0")]
		private static void YQLJDZHFPKQ(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x9078110", Offset = "0x9076710", VA = "0x189078110")]
		private static bool DNSGZOFJGYX(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x90784C0", Offset = "0x9076AC0", VA = "0x1890784C0")]
		private static DiyFp EVKUIDXQPBG(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9077910", Offset = "0x9075F10", VA = "0x189077910")]
		private static bool BRHQKAWQZQS(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9078EA0", Offset = "0x90774A0", VA = "0x189078EA0")]
		private static bool SUXFBUUMXWW(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9078D80", Offset = "0x9077380", VA = "0x189078D80")]
		public static double? RDLEQQBFLHI(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x9078AB0", Offset = "0x90770B0", VA = "0x189078AB0")]
		public static float? RDAQWCNKSKQ(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class OGEIPRASAYX
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] FGVKNJSZFLV;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] OIOPXZFZFPE;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] QBZPTVIPFXZ;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] HOUXYBJQDEZ;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int IZSJLAOSGKR;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] KPPYZCLVXWX;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int GFWXCDDAUVF;

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x907F310", Offset = "0x907D910", VA = "0x18907F310")]
		private static byte[] ITMPCJJXFEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x907F610", Offset = "0x907DC10", VA = "0x18907F610")]
		public static bool OCLUGXJPQSZ(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x907F3F0", Offset = "0x907D9F0", VA = "0x18907F3F0")]
		public static bool JPBTEKZYCPO(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x907F750", Offset = "0x907DD50", VA = "0x18907F750")]
		private static bool VLIUATDFDFX(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x907F880", Offset = "0x907DE80", VA = "0x18907F880")]
		private static bool ZDACUQTKAPC(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x907F530", Offset = "0x907DB30", VA = "0x18907F530")]
		private static bool LEKYOQBCIAN(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x907F2A0", Offset = "0x907D8A0", VA = "0x18907F2A0")]
		private static bool HCZRDHCIIHN(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x907F280", Offset = "0x907D880", VA = "0x18907F280")]
		private static double FAAHLJVHSCO(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x907E2A0", Offset = "0x907C8A0", VA = "0x18907E2A0")]
		private static double CHBSTPPJORO(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class HWCTMMITTQG<a> : IGIJDGNWSCS<a[]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly LBMTFAYQPGA<a> MCKHLJJIMQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour EFRXVBXVLPX;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x199F770", Offset = "0x199DD70", VA = "0x18199F770")]
		public HWCTMMITTQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
		public HWCTMMITTQG(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5129FE0", Offset = "0x51285E0", VA = "0x185129FE0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x51295A0", Offset = "0x5127BA0", VA = "0x1851295A0", Slot = "5")]
		public a[] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class EGNNINUOFHZ<a> : IGIJDGNWSCS<ArraySegment<a>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly LBMTFAYQPGA<a> MCKHLJJIMQD;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x492C8D0", Offset = "0x492AED0", VA = "0x18492C8D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x492C490", Offset = "0x492AA90", VA = "0x18492C490", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class RPMPVDIIHRT<a> : IGIJDGNWSCS<List<a>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour EFRXVBXVLPX;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x199F770", Offset = "0x199DD70", VA = "0x18199F770")]
		public RPMPVDIIHRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
		public RPMPVDIIHRT(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x5D63D60", Offset = "0x5D62360", VA = "0x185D63D60", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5D618D0", Offset = "0x5D5FED0", VA = "0x185D618D0", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class LRTVQIZBZFN<a, b, c, d> : IGIJDGNWSCS<d>, GGASJLLNBGR where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5480100", Offset = "0x547E700", VA = "0x185480100", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x547FA40", Offset = "0x547E040", VA = "0x18547FA40", Slot = "5")]
		public d Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c TUQXUJLRGDF(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected LRTVQIZBZFN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class LSUECQUOUKG<a, b, c> : LRTVQIZBZFN<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x51CDF50", Offset = "0x51CC550", VA = "0x1851CDF50", Slot = "6")]
		protected override IEnumerator<a> TUQXUJLRGDF(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5079620", Offset = "0x5077C20", VA = "0x185079620")]
		protected LSUECQUOUKG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class LSZKZXOMDVP<a, b> : LSUECQUOUKG<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xB07D20", Offset = "0xB06320", VA = "0x180B07D20", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class WJTKQSCWZEP<a, b> : LSZKZXOMDVP<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x685C7C0", Offset = "0x685ADC0", VA = "0x18685C7C0", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x685C660", Offset = "0x685AC60", VA = "0x18685C660", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class KANLVTUZBEW<a> : LRTVQIZBZFN<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x53A97F0", Offset = "0x53A7DF0", VA = "0x1853A97F0", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xB07D20", Offset = "0xB06320", VA = "0x180B07D20", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x40DF9B0", Offset = "0x40DDFB0", VA = "0x1840DF9B0", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x48558C0", Offset = "0x4853EC0", VA = "0x1848558C0", Slot = "6")]
		protected override LinkedList<a>.Enumerator TUQXUJLRGDF(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class BGBXKDGVBLJ<a> : LRTVQIZBZFN<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x431AA40", Offset = "0x4319040", VA = "0x18431AA40", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x59CE7E0", Offset = "0x59CCDE0", VA = "0x1859CE7E0", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5C93B30", Offset = "0x5C92130", VA = "0x185C93B30", Slot = "6")]
		protected override Queue<a>.Enumerator TUQXUJLRGDF(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xB07D20", Offset = "0xB06320", VA = "0x180B07D20", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class PEUYONKZZXX<a> : LRTVQIZBZFN<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x410B130", Offset = "0x4109730", VA = "0x18410B130", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x410B2A0", Offset = "0x41098A0", VA = "0x18410B2A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5C7D260", Offset = "0x5C7B860", VA = "0x185C7D260", Slot = "6")]
		protected override Stack<a>.Enumerator TUQXUJLRGDF(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x5C7D100", Offset = "0x5C7B700", VA = "0x185C7D100", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class PZVDCJSEREV<a> : LRTVQIZBZFN<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5C93A40", Offset = "0x5C92040", VA = "0x185C93A40", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xB07D20", Offset = "0xB06320", VA = "0x180B07D20", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x5C93A80", Offset = "0x5C92080", VA = "0x185C93A80", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x5C93AE0", Offset = "0x5C920E0", VA = "0x185C93AE0", Slot = "6")]
		protected override HashSet<a>.Enumerator TUQXUJLRGDF(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5B79DF0", Offset = "0x5B783F0", VA = "0x185B79DF0")]
		public PZVDCJSEREV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class KOKZFOCFBDR<a> : LSUECQUOUKG<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x410B130", Offset = "0x4109730", VA = "0x18410B130", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x53B1080", Offset = "0x53AF680", VA = "0x1853B1080", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x53B1110", Offset = "0x53AF710", VA = "0x1853B1110", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class WJRHJZHRBNG<a> : LSUECQUOUKG<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x431AA40", Offset = "0x4319040", VA = "0x18431AA40", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x59CE7E0", Offset = "0x59CCDE0", VA = "0x1859CE7E0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xB07D20", Offset = "0xB06320", VA = "0x180B07D20", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class MJOBIHAIVRW<a> : LSUECQUOUKG<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x431AA40", Offset = "0x4319040", VA = "0x18431AA40", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x59CE7E0", Offset = "0x59CCDE0", VA = "0x1859CE7E0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xB07D20", Offset = "0xB06320", VA = "0x180B07D20", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class RNZVCSIQMGO<a> : LSUECQUOUKG<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x51DDE90", Offset = "0x51DC490", VA = "0x1851DDE90", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x410B2A0", Offset = "0x41098A0", VA = "0x18410B2A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x410B250", Offset = "0x4109850", VA = "0x18410B250", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x410B2F0", Offset = "0x41098F0", VA = "0x18410B2F0")]
		public RNZVCSIQMGO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class NFQEGIUWHNA<a, b> : IGIJDGNWSCS<IGrouping<a, b>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5A71D80", Offset = "0x5A70380", VA = "0x185A71D80", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5A71A30", Offset = "0x5A70030", VA = "0x185A71A30", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class NJKWJCKWGSL<a, b> : IGIJDGNWSCS<ILookup<a, b>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5A73630", Offset = "0x5A71C30", VA = "0x185A73630", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5A732E0", Offset = "0x5A718E0", VA = "0x185A732E0", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class KRCDLQUUKDJ<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a PYMENAUFSNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> NFDVDUQXEUJ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x4111690", Offset = "0x410FC90", VA = "0x184111690", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x53B1710", Offset = "0x53AFD10", VA = "0x1853B1710")]
		public KRCDLQUUKDJ(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x53B16A0", Offset = "0x53AFCA0", VA = "0x1853B16A0", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x52A90C0", Offset = "0x52A76C0", VA = "0x1852A90C0", Slot = "6")]
		private IEnumerator MZPFIUHPQEF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class HEQBKLKZERG<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> KJDMOCEUVMO;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x511D170", Offset = "0x511B770", VA = "0x18511D170", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public HEQBKLKZERG(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x511CFE0", Offset = "0x511B5E0", VA = "0x18511CFE0", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x511D0D0", Offset = "0x511B6D0", VA = "0x18511D0D0", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x511D0D0", Offset = "0x511B6D0", VA = "0x18511D0D0", Slot = "7")]
		private IEnumerator MZPFIUHPQEF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class VYPCBGQVYND<a> : IGIJDGNWSCS<a>, GGASJLLNBGR where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x6526D10", Offset = "0x6525310", VA = "0x186526D10", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x6526B00", Offset = "0x6525100", VA = "0x186526B00", Slot = "5")]
		public a Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public VYPCBGQVYND()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class HBTBPDODHYN : IGIJDGNWSCS<IEnumerable>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly IGIJDGNWSCS<IEnumerable> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9079440", Offset = "0x9077A40", VA = "0x189079440", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9079240", Offset = "0x9077840", VA = "0x189079240", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public HBTBPDODHYN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class SPKDXKHEPYP : IGIJDGNWSCS<ICollection>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly IGIJDGNWSCS<ICollection> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x90832F0", Offset = "0x90818F0", VA = "0x1890832F0", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x90830F0", Offset = "0x90816F0", VA = "0x1890830F0", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public SPKDXKHEPYP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class ZSEYHAMXOQT : IGIJDGNWSCS<IList>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly IGIJDGNWSCS<IList> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x908AA30", Offset = "0x9089030", VA = "0x18908AA30", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x908A830", Offset = "0x9088E30", VA = "0x18908A830", Slot = "5")]
		public IList Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ZSEYHAMXOQT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class PWMONPXJLMW<a> : LSZKZXOMDVP<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x431AA40", Offset = "0x4319040", VA = "0x18431AA40", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x431AB90", Offset = "0x4319190", VA = "0x18431AB90", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class DOOHQZBXEZO<a> : LSUECQUOUKG<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x431AA40", Offset = "0x4319040", VA = "0x18431AA40", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x431AB90", Offset = "0x4319190", VA = "0x18431AB90", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x431AB20", Offset = "0x4319120", VA = "0x18431AB20", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class ISEZOMUFJIW<a> : LSUECQUOUKG<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x410B210", Offset = "0x4109810", VA = "0x18410B210", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x410B2A0", Offset = "0x41098A0", VA = "0x18410B2A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x51DDF30", Offset = "0x51DC530", VA = "0x1851DDF30", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x51DE090", Offset = "0x51DC690", VA = "0x1851DE090")]
		public ISEZOMUFJIW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class CPIHRHBGMJQ<a> : LSUECQUOUKG<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x410B210", Offset = "0x4109810", VA = "0x18410B210", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x410B2A0", Offset = "0x41098A0", VA = "0x18410B2A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x410B250", Offset = "0x4109850", VA = "0x18410B250", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x410B2F0", Offset = "0x41098F0", VA = "0x18410B2F0")]
		public CPIHRHBGMJQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class ZMRLDVJUUAG<a> : LSUECQUOUKG<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x40DF8C0", Offset = "0x40DDEC0", VA = "0x1840DF8C0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xB07D20", Offset = "0xB06320", VA = "0x180B07D20", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x40DF9B0", Offset = "0x40DDFB0", VA = "0x1840DF9B0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class TBGXMZSUTOS<a> : LSZKZXOMDVP<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x431AA40", Offset = "0x4319040", VA = "0x18431AA40", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x59CE7E0", Offset = "0x59CCDE0", VA = "0x1859CE7E0", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class MQFMKJGVGOJ<a> : LSZKZXOMDVP<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x431AA40", Offset = "0x4319040", VA = "0x18431AA40", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x59CE7E0", Offset = "0x59CCDE0", VA = "0x1859CE7E0", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class MNOYPMNVVSE<a> : LSUECQUOUKG<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x410B130", Offset = "0x4109730", VA = "0x18410B130", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x410B2A0", Offset = "0x41098A0", VA = "0x18410B2A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x59D4F10", Offset = "0x59D3510", VA = "0x1859D4F10", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class YNWKJYFGCCN
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
		[Cpp2IlInjected.Address(RVA = "0x908A170", Offset = "0x9088770", VA = "0x18908A170")]
		public static DateTime MHBUCFKIZSJ(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9089FC0", Offset = "0x90885C0", VA = "0x189089FC0")]
		public static bool JHRTZWRCSLG(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9089B20", Offset = "0x9088120", VA = "0x189089B20")]
		public static bool GLCGZDSUKIQ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9089DB0", Offset = "0x90883B0", VA = "0x189089DB0")]
		public static bool GLCGZDSUKIQ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x908A230", Offset = "0x9088830", VA = "0x18908A230")]
		public static bool RYPIBFWBYMO(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class LKHBSVWCQKR : IGIJDGNWSCS<DateTime>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly IGIJDGNWSCS<DateTime> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x907BAD0", Offset = "0x907A0D0", VA = "0x18907BAD0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x907B950", Offset = "0x9079F50", VA = "0x18907B950", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x907B550", Offset = "0x9079B50", VA = "0x18907B550")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public LKHBSVWCQKR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class GRGKHTAIOCQ : IGIJDGNWSCS<DateTimeOffset>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly IGIJDGNWSCS<DateTimeOffset> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9076E10", Offset = "0x9075410", VA = "0x189076E10", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9076DA0", Offset = "0x90753A0", VA = "0x189076DA0", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x90769C0", Offset = "0x9074FC0", VA = "0x1890769C0")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public GRGKHTAIOCQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class PJQIBRGNVKN : IGIJDGNWSCS<TimeSpan>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly IGIJDGNWSCS<TimeSpan> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] NQOCFHBVKMF;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x9081140", Offset = "0x907F740", VA = "0x189081140", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x9080CD0", Offset = "0x907F2D0", VA = "0x189080CD0", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x9080D50", Offset = "0x907F350", VA = "0x189080D50")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public PJQIBRGNVKN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class IAHXLUEGRGQ<a, b, c, d, e> : IGIJDGNWSCS<e>, GGASJLLNBGR where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x51CCE10", Offset = "0x51CB410", VA = "0x1851CCE10", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x51C8F80", Offset = "0x51C7580", VA = "0x1851C8F80", Slot = "5")]
		public e Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d TUQXUJLRGDF(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected IAHXLUEGRGQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class IANEJAYEARZ<a, b, c, d> : IAHXLUEGRGQ<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x51CDF50", Offset = "0x51CC550", VA = "0x1851CDF50", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> TUQXUJLRGDF(d a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class IBNMVITQVWS<a, b, c> : IANEJAYEARZ<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xB07D20", Offset = "0xB06320", VA = "0x180B07D20", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class NIOHZUVMXEA<a, b> : IAHXLUEGRGQ<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5A729A0", Offset = "0x5A70FA0", VA = "0x185A729A0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xB07D20", Offset = "0xB06320", VA = "0x180B07D20", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5A72AC0", Offset = "0x5A710C0", VA = "0x185A72AC0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x5A72BD0", Offset = "0x5A711D0", VA = "0x185A72BD0", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator TUQXUJLRGDF(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x54B8C20", Offset = "0x54B7220", VA = "0x1854B8C20")]
		public NIOHZUVMXEA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class GTKNQAWFXRW<a, b, c> : IBNMVITQVWS<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x50744F0", Offset = "0x5072AF0", VA = "0x1850744F0", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x50746D0", Offset = "0x5072CD0", VA = "0x1850746D0", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class MVGPYKGTMFT<a, b> : IANEJAYEARZ<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x408AD50", Offset = "0x4089350", VA = "0x18408AD50", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x4321AE0", Offset = "0x43200E0", VA = "0x184321AE0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB07D20", Offset = "0xB06320", VA = "0x180B07D20", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class JHNJYAOEQSH<a, b> : IBNMVITQVWS<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x408AD50", Offset = "0x4089350", VA = "0x18408AD50", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x4321AE0", Offset = "0x43200E0", VA = "0x184321AE0", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class DZNWTJXUYLZ<a, b> : IAHXLUEGRGQ<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x408AD50", Offset = "0x4089350", VA = "0x18408AD50", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB07D20", Offset = "0xB06320", VA = "0x180B07D20", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x4321AE0", Offset = "0x43200E0", VA = "0x184321AE0", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x4321B40", Offset = "0x4320140", VA = "0x184321B40", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator TUQXUJLRGDF(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class XQXFACJIDRM<a, b> : IANEJAYEARZ<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x408AD50", Offset = "0x4089350", VA = "0x18408AD50", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x408AEC0", Offset = "0x40894C0", VA = "0x18408AEC0", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x408AF30", Offset = "0x4089530", VA = "0x18408AF30", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class JUIXTVRCVNF<a, b> : IANEJAYEARZ<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x408AD50", Offset = "0x4089350", VA = "0x18408AD50", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xB07D20", Offset = "0xB06320", VA = "0x180B07D20", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x52C32C0", Offset = "0x52C18C0", VA = "0x1852C32C0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class GBERETKAJZF<a, b> : IBNMVITQVWS<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x50591B0", Offset = "0x50577B0", VA = "0x1850591B0", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x4321AE0", Offset = "0x43200E0", VA = "0x184321AE0", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class QDDFLNDJLPH<a> : IGIJDGNWSCS<a>, GGASJLLNBGR where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5CFA820", Offset = "0x5CF8E20", VA = "0x185CFA820", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x5CFA5F0", Offset = "0x5CF8BF0", VA = "0x185CFA5F0", Slot = "5")]
		public a Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public QDDFLNDJLPH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class PBEXJPMIYJJ : IGIJDGNWSCS<IDictionary>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly IGIJDGNWSCS<IDictionary> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x9080670", Offset = "0x907EC70", VA = "0x189080670", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x9080490", Offset = "0x907EA90", VA = "0x189080490", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public PBEXJPMIYJJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class ZUJVAXZCFSF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x908AE40", Offset = "0x9089440", VA = "0x18908AE40")]
		public static object FECSDLWWXFP(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x908B620", Offset = "0x9089C20", VA = "0x18908B620")]
		public static object VULGLEPUANK(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class MUYRWRXRGTM<a> : IGIJDGNWSCS<a>, GGASJLLNBGR, CBEIQCICYGT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class RPGDRVSGBNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type FOEYAZCVXNK;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public RPGDRVSGBNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x5D60150", Offset = "0x5D5E750", VA = "0x185D60150")]
			internal bool NNAYMYDQUGR(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class RPLKPCMDKYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string CXFTMEPEFFA;

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public RPLKPCMDKYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x5D61280", Offset = "0x5D5F880", VA = "0x185D61280")]
			internal bool NMVRPRJTKVI(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class ROVPXIELIQI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> YWOEGWIXJZX;

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public ROVPXIELIQI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x5D4E300", Offset = "0x5D4C900", VA = "0x185D4E300")]
			internal void NMQKSKPWBJZ(JsonWriter a, a b, CKTJJUOJSNN c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class RPAWUOYISBR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> CFDYKYVIHRG;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public RPAWUOYISBR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x5D4EAB0", Offset = "0x5D4D0B0", VA = "0x185D4EAB0")]
			internal a NMLDVDVYRYQ(JsonReader a, CKTJJUOJSNN b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly AXHJXHUCJVL<a> GQAJQQKHBUS;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> VGSDENJRGFC;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> ZCOQDKBANVS;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> UKGYHUFRDYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool XGMHONKCXLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> LUMUQUGFFBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> EONKRBQTEXE;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x59ED8F0", Offset = "0x59EBEF0", VA = "0x1859ED8F0")]
		static MUYRWRXRGTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x59F2A00", Offset = "0x59F1000", VA = "0x1859F2A00")]
		public MUYRWRXRGTM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x59DE5B0", Offset = "0x59DCBB0", VA = "0x1859DE5B0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x59DD8F0", Offset = "0x59DBEF0", VA = "0x1859DD8F0", Slot = "5")]
		public a Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x59DFD30", Offset = "0x59DE330", VA = "0x1859DFD30", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, a b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x59DA890", Offset = "0x59D8E90", VA = "0x1859DA890", Slot = "7")]
		public a DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class ETLKMUAKZWO<a> : IGIJDGNWSCS<a[,]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x493A760", Offset = "0x4938D60", VA = "0x18493A760", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x493A3D0", Offset = "0x49389D0", VA = "0x18493A3D0", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ETLKMUAKZWO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class TZUMGNENAKQ<a> : IGIJDGNWSCS<a[,,]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x61E6130", Offset = "0x61E4730", VA = "0x1861E6130", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x61E5C60", Offset = "0x61E4260", VA = "0x1861E5C60", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public TZUMGNENAKQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class UWKWEVNMHXW<a> : IGIJDGNWSCS<a[,,,]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x63C5080", Offset = "0x63C3680", VA = "0x1863C5080", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x63C4A80", Offset = "0x63C3080", VA = "0x1863C4A80", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public UWKWEVNMHXW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class YWKDFAKSNKS<a> : IGIJDGNWSCS<a?>, GGASJLLNBGR where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x40B65F0", Offset = "0x40B4BF0", VA = "0x1840B65F0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x40B6110", Offset = "0x40B4710", VA = "0x1840B6110", Slot = "5")]
		public a? Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public YWKDFAKSNKS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class VXPKRLHPZQA<a> : IGIJDGNWSCS<a?>, GGASJLLNBGR where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly IGIJDGNWSCS<a> EHIECQDNWCL;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		public VXPKRLHPZQA(IGIJDGNWSCS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6526420", Offset = "0x6524A20", VA = "0x186526420", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x65252C0", Offset = "0x65238C0", VA = "0x1865252C0", Slot = "5")]
		public a? Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class URXCTDPHIMH : IGIJDGNWSCS<sbyte>, GGASJLLNBGR, CBEIQCICYGT<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly URXCTDPHIMH AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x9088240", Offset = "0x9086840", VA = "0x189088240", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x9088230", Offset = "0x9086830", VA = "0x189088230", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x90882D0", Offset = "0x90868D0", VA = "0x1890882D0", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, sbyte b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x90881B0", Offset = "0x90867B0", VA = "0x1890881B0", Slot = "7")]
		public sbyte DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public URXCTDPHIMH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class HZDCUVUMZFI : IGIJDGNWSCS<sbyte?>, GGASJLLNBGR, CBEIQCICYGT<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly HZDCUVUMZFI AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9079900", Offset = "0x9077F00", VA = "0x189079900", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9079890", Offset = "0x9077E90", VA = "0x189079890", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x90799F0", Offset = "0x9077FF0", VA = "0x1890799F0", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, sbyte? b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x90797C0", Offset = "0x9077DC0", VA = "0x1890797C0", Slot = "7")]
		public sbyte? DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public HZDCUVUMZFI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class ITJPYOUGWQO : IGIJDGNWSCS<sbyte[]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly ITJPYOUGWQO AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x9079EF0", Offset = "0x90784F0", VA = "0x189079EF0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x9079DB0", Offset = "0x90783B0", VA = "0x189079DB0", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ITJPYOUGWQO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class MFJCECVXTNG : IGIJDGNWSCS<short>, GGASJLLNBGR, CBEIQCICYGT<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly MFJCECVXTNG AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x907CB20", Offset = "0x907B120", VA = "0x18907CB20", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x907CB10", Offset = "0x907B110", VA = "0x18907CB10", Slot = "5")]
		public short Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x907CBB0", Offset = "0x907B1B0", VA = "0x18907CBB0", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, short b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x907CA90", Offset = "0x907B090", VA = "0x18907CA90", Slot = "7")]
		public short DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public MFJCECVXTNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class DFGTQHPHMJH : IGIJDGNWSCS<short?>, GGASJLLNBGR, CBEIQCICYGT<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly DFGTQHPHMJH AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x9074B10", Offset = "0x9073110", VA = "0x189074B10", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x9074AA0", Offset = "0x90730A0", VA = "0x189074AA0", Slot = "5")]
		public short? Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x9074C00", Offset = "0x9073200", VA = "0x189074C00", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, short? b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x90749D0", Offset = "0x9072FD0", VA = "0x1890749D0", Slot = "7")]
		public short? DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public DFGTQHPHMJH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class SXAQXPFTWGL : IGIJDGNWSCS<short[]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly SXAQXPFTWGL AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x90838E0", Offset = "0x9081EE0", VA = "0x1890838E0", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x90837A0", Offset = "0x9081DA0", VA = "0x1890837A0", Slot = "5")]
		public short[] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public SXAQXPFTWGL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class DHAFBMRCAQC : IGIJDGNWSCS<int>, GGASJLLNBGR, CBEIQCICYGT<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly DHAFBMRCAQC AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x9074E60", Offset = "0x9073460", VA = "0x189074E60", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9074E50", Offset = "0x9073450", VA = "0x189074E50", Slot = "5")]
		public int Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x9074EF0", Offset = "0x90734F0", VA = "0x189074EF0", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, int b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x9074DD0", Offset = "0x90733D0", VA = "0x189074DD0", Slot = "7")]
		public int DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public DHAFBMRCAQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class AVNXSLHLCBJ : IGIJDGNWSCS<int?>, GGASJLLNBGR, CBEIQCICYGT<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly AVNXSLHLCBJ AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x9071EF0", Offset = "0x90704F0", VA = "0x189071EF0", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x9071E80", Offset = "0x9070480", VA = "0x189071E80", Slot = "5")]
		public int? Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x9071FE0", Offset = "0x90705E0", VA = "0x189071FE0", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, int? b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9071DB0", Offset = "0x90703B0", VA = "0x189071DB0", Slot = "7")]
		public int? DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public AVNXSLHLCBJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class WGIAXZBGLAV : IGIJDGNWSCS<int[]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly WGIAXZBGLAV AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x9089460", Offset = "0x9087A60", VA = "0x189089460", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x9089320", Offset = "0x9087920", VA = "0x189089320", Slot = "5")]
		public int[] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public WGIAXZBGLAV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class FDJFFWIIIAH : IGIJDGNWSCS<long>, GGASJLLNBGR, CBEIQCICYGT<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly FDJFFWIIIAH AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x9076320", Offset = "0x9074920", VA = "0x189076320", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x9076310", Offset = "0x9074910", VA = "0x189076310", Slot = "5")]
		public long Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x9076380", Offset = "0x9074980", VA = "0x189076380", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, long b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x90762D0", Offset = "0x90748D0", VA = "0x1890762D0", Slot = "7")]
		public long DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public FDJFFWIIIAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class VIYHCJKHIXU : IGIJDGNWSCS<long?>, GGASJLLNBGR, CBEIQCICYGT<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly VIYHCJKHIXU AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9088970", Offset = "0x9086F70", VA = "0x189088970", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x90888E0", Offset = "0x9086EE0", VA = "0x1890888E0", Slot = "5")]
		public long? Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9088A30", Offset = "0x9087030", VA = "0x189088A30", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, long? b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9088830", Offset = "0x9086E30", VA = "0x189088830", Slot = "7")]
		public long? DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public VIYHCJKHIXU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class BWGBBRJWIXA : IGIJDGNWSCS<long[]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly BWGBBRJWIXA AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x9073DC0", Offset = "0x90723C0", VA = "0x189073DC0", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x9073C80", Offset = "0x9072280", VA = "0x189073C80", Slot = "5")]
		public long[] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public BWGBBRJWIXA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class UBQMCPVUAWI : IGIJDGNWSCS<byte>, GGASJLLNBGR, CBEIQCICYGT<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly UBQMCPVUAWI AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x9084E90", Offset = "0x9083490", VA = "0x189084E90", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x9084E80", Offset = "0x9083480", VA = "0x189084E80", Slot = "5")]
		public byte Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x9084F20", Offset = "0x9083520", VA = "0x189084F20", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, byte b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x9084E00", Offset = "0x9083400", VA = "0x189084E00", Slot = "7")]
		public byte DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public UBQMCPVUAWI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class CUYEQWETCID : IGIJDGNWSCS<byte?>, GGASJLLNBGR, CBEIQCICYGT<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly CUYEQWETCID AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x9074700", Offset = "0x9072D00", VA = "0x189074700", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x9074690", Offset = "0x9072C90", VA = "0x189074690", Slot = "5")]
		public byte? Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x90747F0", Offset = "0x9072DF0", VA = "0x1890747F0", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, byte? b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x90745C0", Offset = "0x9072BC0", VA = "0x1890745C0", Slot = "7")]
		public byte? DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public CUYEQWETCID()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class PYVIADNTYGH : IGIJDGNWSCS<ushort>, GGASJLLNBGR, CBEIQCICYGT<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly PYVIADNTYGH AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x9082170", Offset = "0x9080770", VA = "0x189082170", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x9082160", Offset = "0x9080760", VA = "0x189082160", Slot = "5")]
		public ushort Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x9082200", Offset = "0x9080800", VA = "0x189082200", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, ushort b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x90820E0", Offset = "0x90806E0", VA = "0x1890820E0", Slot = "7")]
		public ushort DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public PYVIADNTYGH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class JGSCDIYXDTS : IGIJDGNWSCS<ushort?>, GGASJLLNBGR, CBEIQCICYGT<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly JGSCDIYXDTS AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x907A500", Offset = "0x9078B00", VA = "0x18907A500", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x907A490", Offset = "0x9078A90", VA = "0x18907A490", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x907A5F0", Offset = "0x9078BF0", VA = "0x18907A5F0", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, ushort? b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x907A3C0", Offset = "0x90789C0", VA = "0x18907A3C0", Slot = "7")]
		public ushort? DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public JGSCDIYXDTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class KVLVSXKNGWG : IGIJDGNWSCS<ushort[]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly KVLVSXKNGWG AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x907B0C0", Offset = "0x90796C0", VA = "0x18907B0C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x907AF80", Offset = "0x9079580", VA = "0x18907AF80", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public KVLVSXKNGWG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class RXJLBKVCDPP : IGIJDGNWSCS<uint>, GGASJLLNBGR, CBEIQCICYGT<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly RXJLBKVCDPP AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x9082EE0", Offset = "0x90814E0", VA = "0x189082EE0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x9082ED0", Offset = "0x90814D0", VA = "0x189082ED0", Slot = "5")]
		public uint Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9082F70", Offset = "0x9081570", VA = "0x189082F70", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, uint b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9082E50", Offset = "0x9081450", VA = "0x189082E50", Slot = "7")]
		public uint DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RXJLBKVCDPP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class KFFRHVDNZSK : IGIJDGNWSCS<uint?>, GGASJLLNBGR, CBEIQCICYGT<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly KFFRHVDNZSK AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x907ACC0", Offset = "0x90792C0", VA = "0x18907ACC0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x907AC50", Offset = "0x9079250", VA = "0x18907AC50", Slot = "5")]
		public uint? Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x907ADB0", Offset = "0x90793B0", VA = "0x18907ADB0", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, uint? b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x907AB80", Offset = "0x9079180", VA = "0x18907AB80", Slot = "7")]
		public uint? DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public KFFRHVDNZSK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class VGGTXQMPNSU : IGIJDGNWSCS<uint[]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly VGGTXQMPNSU AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x9088590", Offset = "0x9086B90", VA = "0x189088590", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x9088450", Offset = "0x9086A50", VA = "0x189088450", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public VGGTXQMPNSU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class LHCQPRRDIIE : IGIJDGNWSCS<ulong>, GGASJLLNBGR, CBEIQCICYGT<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly LHCQPRRDIIE AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x907B3B0", Offset = "0x90799B0", VA = "0x18907B3B0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x907B3A0", Offset = "0x90799A0", VA = "0x18907B3A0", Slot = "5")]
		public ulong Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x907B410", Offset = "0x9079A10", VA = "0x18907B410", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, ulong b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x907B360", Offset = "0x9079960", VA = "0x18907B360", Slot = "7")]
		public ulong DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public LHCQPRRDIIE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class ZYZAQORSGHR : IGIJDGNWSCS<ulong?>, GGASJLLNBGR, CBEIQCICYGT<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly ZYZAQORSGHR AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x908BF40", Offset = "0x908A540", VA = "0x18908BF40", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x908BEB0", Offset = "0x908A4B0", VA = "0x18908BEB0", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x908C000", Offset = "0x908A600", VA = "0x18908C000", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, ulong? b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x908BE00", Offset = "0x908A400", VA = "0x18908BE00", Slot = "7")]
		public ulong? DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ZYZAQORSGHR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class PMCZXZMCXQL : IGIJDGNWSCS<ulong[]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly PMCZXZMCXQL AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x9081990", Offset = "0x907FF90", VA = "0x189081990", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x9081850", Offset = "0x907FE50", VA = "0x189081850", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public PMCZXZMCXQL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class IOMICRFZZAW : IGIJDGNWSCS<float>, GGASJLLNBGR, CBEIQCICYGT<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly IOMICRFZZAW AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x9079C10", Offset = "0x9078210", VA = "0x189079C10", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x9079C00", Offset = "0x9078200", VA = "0x189079C00", Slot = "5")]
		public float Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x9079C70", Offset = "0x9078270", VA = "0x189079C70", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, float b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x9079BC0", Offset = "0x90781C0", VA = "0x189079BC0", Slot = "7")]
		public float DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public IOMICRFZZAW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class CLMIXDBJQON : IGIJDGNWSCS<float?>, GGASJLLNBGR, CBEIQCICYGT<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly CLMIXDBJQON AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x9074100", Offset = "0x9072700", VA = "0x189074100", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x9074090", Offset = "0x9072690", VA = "0x189074090", Slot = "5")]
		public float? Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x90741C0", Offset = "0x90727C0", VA = "0x1890741C0", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, float? b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x9073FF0", Offset = "0x90725F0", VA = "0x189073FF0", Slot = "7")]
		public float? DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public CLMIXDBJQON()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class EOTDVPEGMEJ : IGIJDGNWSCS<float[]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly EOTDVPEGMEJ AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x9075F40", Offset = "0x9074540", VA = "0x189075F40", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x9075E00", Offset = "0x9074400", VA = "0x189075E00", Slot = "5")]
		public float[] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public EOTDVPEGMEJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class PSPRHZOLMCZ : IGIJDGNWSCS<double>, GGASJLLNBGR, CBEIQCICYGT<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly PSPRHZOLMCZ AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x9081F40", Offset = "0x9080540", VA = "0x189081F40", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x9081F30", Offset = "0x9080530", VA = "0x189081F30", Slot = "5")]
		public double Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x9081FA0", Offset = "0x90805A0", VA = "0x189081FA0", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, double b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x9081EF0", Offset = "0x90804F0", VA = "0x189081EF0", Slot = "7")]
		public double DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public PSPRHZOLMCZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class LTCNRDTYPSO : IGIJDGNWSCS<double?>, GGASJLLNBGR, CBEIQCICYGT<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly LTCNRDTYPSO AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x907C830", Offset = "0x907AE30", VA = "0x18907C830", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x907C7A0", Offset = "0x907ADA0", VA = "0x18907C7A0", Slot = "5")]
		public double? Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x907C8F0", Offset = "0x907AEF0", VA = "0x18907C8F0", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, double? b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x907C6F0", Offset = "0x907ACF0", VA = "0x18907C6F0", Slot = "7")]
		public double? DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public LTCNRDTYPSO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class VSKDTCQBPCI : IGIJDGNWSCS<double[]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly VSKDTCQBPCI AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x9088F00", Offset = "0x9087500", VA = "0x189088F00", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x9088DC0", Offset = "0x90873C0", VA = "0x189088DC0", Slot = "5")]
		public double[] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public VSKDTCQBPCI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class KELLEMTYTQG : IGIJDGNWSCS<bool>, GGASJLLNBGR, CBEIQCICYGT<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly KELLEMTYTQG AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x907A9E0", Offset = "0x9078FE0", VA = "0x18907A9E0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x907A9D0", Offset = "0x9078FD0", VA = "0x18907A9D0", Slot = "5")]
		public bool Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x907AA40", Offset = "0x9079040", VA = "0x18907AA40", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, bool b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x907A990", Offset = "0x9078F90", VA = "0x18907A990", Slot = "7")]
		public bool DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public KELLEMTYTQG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class GCUKJISFSRJ : IGIJDGNWSCS<bool?>, GGASJLLNBGR, CBEIQCICYGT<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly GCUKJISFSRJ AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x90765D0", Offset = "0x9074BD0", VA = "0x1890765D0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x9076560", Offset = "0x9074B60", VA = "0x189076560", Slot = "5")]
		public bool? Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x9076690", Offset = "0x9074C90", VA = "0x189076690", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, bool? b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x90764C0", Offset = "0x9074AC0", VA = "0x1890764C0", Slot = "7")]
		public bool? DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public GCUKJISFSRJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class RBUKEKFYQOF : IGIJDGNWSCS<bool[]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly RBUKEKFYQOF AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x9082970", Offset = "0x9080F70", VA = "0x189082970", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x9082830", Offset = "0x9080E30", VA = "0x189082830", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RBUKEKFYQOF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class ZPCBGXHGQOD : IGIJDGNWSCS<byte[]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly IGIJDGNWSCS<byte[]> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x908A700", Offset = "0x9088D00", VA = "0x18908A700", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x908A690", Offset = "0x9088C90", VA = "0x18908A690", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ZPCBGXHGQOD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class CLWGWCYOKIS : IGIJDGNWSCS<ArraySegment<byte>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly IGIJDGNWSCS<ArraySegment<byte>> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x9074420", Offset = "0x9072A20", VA = "0x189074420", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x9074350", Offset = "0x9072950", VA = "0x189074350", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public CLWGWCYOKIS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class DRPMBGNTNCO : IGIJDGNWSCS<string>, GGASJLLNBGR, CBEIQCICYGT<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly IGIJDGNWSCS<string> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x9075080", Offset = "0x9073680", VA = "0x189075080", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x9075070", Offset = "0x9073670", VA = "0x189075070", Slot = "5")]
		public string Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x90750E0", Offset = "0x90736E0", VA = "0x1890750E0", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, string b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x9075070", Offset = "0x9073670", VA = "0x189075070", Slot = "7")]
		public string DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public DRPMBGNTNCO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class OOTORYSCEOZ : IGIJDGNWSCS<string[]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly OOTORYSCEOZ AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x907FF20", Offset = "0x907E520", VA = "0x18907FF20", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x907FDD0", Offset = "0x907E3D0", VA = "0x18907FDD0", Slot = "5")]
		public string[] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public OOTORYSCEOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class RITGLEGCHKS : IGIJDGNWSCS<char>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly RITGLEGCHKS AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x9082D30", Offset = "0x9081330", VA = "0x189082D30", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x9082D00", Offset = "0x9081300", VA = "0x189082D00", Slot = "5")]
		public char Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public RITGLEGCHKS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class YOEHAVGQSZL : IGIJDGNWSCS<char?>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly YOEHAVGQSZL AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x908A520", Offset = "0x9088B20", VA = "0x18908A520", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x908A460", Offset = "0x9088A60", VA = "0x18908A460", Slot = "5")]
		public char? Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public YOEHAVGQSZL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class EOKMSCDPUBP : IGIJDGNWSCS<char[]>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly EOKMSCDPUBP AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x9075B50", Offset = "0x9074150", VA = "0x189075B50", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x90759C0", Offset = "0x9073FC0", VA = "0x1890759C0", Slot = "5")]
		public char[] Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public EOKMSCDPUBP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class MRMBTKAEEPP : IGIJDGNWSCS<Guid>, GGASJLLNBGR, CBEIQCICYGT<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly IGIJDGNWSCS<Guid> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x907CE00", Offset = "0x907B400", VA = "0x18907CE00", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x907CDA0", Offset = "0x907B3A0", VA = "0x18907CDA0", Slot = "5")]
		public Guid Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x907CF70", Offset = "0x907B570", VA = "0x18907CF70", Slot = "6")]
		public void ZJRLWUBCWZP(JsonWriter a, Guid b, CKTJJUOJSNN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x907CD30", Offset = "0x907B330", VA = "0x18907CD30", Slot = "7")]
		public Guid DKROIQOLIFH(JsonReader a, CKTJJUOJSNN b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public MRMBTKAEEPP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class YNJJKSZBKUL : IGIJDGNWSCS<decimal>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly IGIJDGNWSCS<decimal> AMLVLGFTEOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool CWAMSFJVRAX;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x74075E0", Offset = "0x7405BE0", VA = "0x1874075E0")]
		public YNJJKSZBKUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xD992D0", Offset = "0xD978D0", VA = "0x180D992D0")]
		public YNJJKSZBKUL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x90898D0", Offset = "0x9087ED0", VA = "0x1890898D0", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x9089700", Offset = "0x9087D00", VA = "0x189089700", Slot = "5")]
		public decimal Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class KAZQLFRVBFW : IGIJDGNWSCS<Uri>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly IGIJDGNWSCS<Uri> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x907A840", Offset = "0x9078E40", VA = "0x18907A840", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x907A7C0", Offset = "0x9078DC0", VA = "0x18907A7C0", Slot = "5")]
		public Uri Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public KAZQLFRVBFW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class OQBJLVGARWC : IGIJDGNWSCS<Version>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly IGIJDGNWSCS<Version> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x9080360", Offset = "0x907E960", VA = "0x189080360", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x90802E0", Offset = "0x907E8E0", VA = "0x1890802E0", Slot = "5")]
		public Version Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public OQBJLVGARWC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class LHHBIUPNBXO<a, b> : IGIJDGNWSCS<KeyValuePair<a, b>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x547B0C0", Offset = "0x54796C0", VA = "0x18547B0C0", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x547ABF0", Offset = "0x54791F0", VA = "0x18547ABF0", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class OPRGUPGTVVE : IGIJDGNWSCS<StringBuilder>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly IGIJDGNWSCS<StringBuilder> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x90801D0", Offset = "0x907E7D0", VA = "0x1890801D0", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x9080150", Offset = "0x907E750", VA = "0x189080150", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public OPRGUPGTVVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class QKHHCHWFOOS : IGIJDGNWSCS<BitArray>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly IGIJDGNWSCS<BitArray> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x90824A0", Offset = "0x9080AA0", VA = "0x1890824A0", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x9082380", Offset = "0x9080980", VA = "0x189082380", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public QKHHCHWFOOS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class SYRUHHQZJNI : IGIJDGNWSCS<Type>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly SYRUHHQZJNI AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex MURPIHNZEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool RJTKSQPGOLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool WQFNUAORAZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool ACTMBDNKVBP;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x9083E60", Offset = "0x9082460", VA = "0x189083E60")]
		public SYRUHHQZJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x83C9700", Offset = "0x83C7D00", VA = "0x1883C9700")]
		public SYRUHHQZJNI(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x9083C90", Offset = "0x9082290", VA = "0x189083C90", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x9083B80", Offset = "0x9082180", VA = "0x189083B80", Slot = "5")]
		public Type Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class UAKLUETJCYW : IGIJDGNWSCS<BigInteger>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly IGIJDGNWSCS<BigInteger> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x9084CC0", Offset = "0x90832C0", VA = "0x189084CC0", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x9084C10", Offset = "0x9083210", VA = "0x189084C10", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public UAKLUETJCYW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class JFRQURDWKBA : IGIJDGNWSCS<Complex>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly IGIJDGNWSCS<Complex> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x907A220", Offset = "0x9078820", VA = "0x18907A220", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x907A190", Offset = "0x9078790", VA = "0x18907A190", Slot = "5")]
		public Complex Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public JFRQURDWKBA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class PRZSEEWIFNO : IGIJDGNWSCS<ExpandoObject>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly IGIJDGNWSCS<ExpandoObject> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x9081DF0", Offset = "0x90803F0", VA = "0x189081DF0", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x9081BC0", Offset = "0x90801C0", VA = "0x189081BC0", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public PRZSEEWIFNO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class HOCXZVMJQEP<a> : IGIJDGNWSCS<Lazy<a>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5122510", Offset = "0x5120B10", VA = "0x185122510", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5122390", Offset = "0x5120990", VA = "0x185122390", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class VKMFAVOCISP : IGIJDGNWSCS<Task>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly IGIJDGNWSCS<Task> AMLVLGFTEOB;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task INZOHGUVELK;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x9088C80", Offset = "0x9087280", VA = "0x189088C80", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x9088BD0", Offset = "0x90871D0", VA = "0x189088BD0", Slot = "5")]
		public Task Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public VKMFAVOCISP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class KHXECQPXJSX<a> : IGIJDGNWSCS<Task<a>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x53AEA00", Offset = "0x53AD000", VA = "0x1853AEA00", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x53AE810", Offset = "0x53ACE10", VA = "0x1853AE810", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class GLRLCKRCJBD<a> : IGIJDGNWSCS<ValueTask<a>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x506E720", Offset = "0x506CD20", VA = "0x18506E720", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x506E500", Offset = "0x506CB00", VA = "0x18506E500", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class QZYNGAAIUHV<a> : IGIJDGNWSCS<Tuple<a>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AF30", Offset = "0x5D19530", VA = "0x185D1AF30", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AC60", Offset = "0x5D19260", VA = "0x185D1AC60", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class RADUDGUGDTE<a, b> : IGIJDGNWSCS<Tuple<a, b>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D28820", Offset = "0x5D26E20", VA = "0x185D28820", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x5D28400", Offset = "0x5D26A00", VA = "0x185D28400", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class RAJBANODNEN<a, b, c> : IGIJDGNWSCS<Tuple<a, b, c>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x5D29290", Offset = "0x5D27890", VA = "0x185D29290", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D28D30", Offset = "0x5D27330", VA = "0x185D28D30", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class RAOHXUIAWPW<a, b, c, d> : IGIJDGNWSCS<Tuple<a, b, c, d>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x5D29FC0", Offset = "0x5D285C0", VA = "0x185D29FC0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x5D29900", Offset = "0x5D27F00", VA = "0x185D29900", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class RATOVBBYGBF<a, b, c, d, e> : IGIJDGNWSCS<Tuple<a, b, c, d, e>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B4A0", Offset = "0x5D29AA0", VA = "0x185D2B4A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5D2AC90", Offset = "0x5D29290", VA = "0x185D2AC90", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class RAYVSHVVPMO<a, b, c, d, e, f> : IGIJDGNWSCS<Tuple<a, b, c, d, e, f>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D2C770", Offset = "0x5D2AD70", VA = "0x185D2C770", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BDE0", Offset = "0x5D2A3E0", VA = "0x185D2BDE0", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class RBECPOPSYXX<a, b, c, d, e, f, g> : IGIJDGNWSCS<Tuple<a, b, c, d, e, f, g>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x5D2DD40", Offset = "0x5D2C340", VA = "0x185D2DD40", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D220", Offset = "0x5D2B820", VA = "0x185D2D220", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class QYDDERDGNJS<a, b, c, d, e, f, g, h> : IGIJDGNWSCS<Tuple<a, b, c, d, e, f, g, h>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D08CE0", Offset = "0x5D072E0", VA = "0x185D08CE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D08050", Offset = "0x5D06650", VA = "0x185D08050", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class HCKEFJLCVUW<a> : IGIJDGNWSCS<ValueTuple<a>>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x5119DB0", Offset = "0x51183B0", VA = "0x185119DB0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x5119990", Offset = "0x5117F90", VA = "0x185119990", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class HCEXICRFMJN<a, b> : IGIJDGNWSCS<(a, b)>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x5119430", Offset = "0x5117A30", VA = "0x185119430", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5118F40", Offset = "0x5117540", VA = "0x185118F40", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class HBZQKVXICYE<a, b, c> : IGIJDGNWSCS<(a, b, c)>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x5118830", Offset = "0x5116E30", VA = "0x185118830", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x51181C0", Offset = "0x51167C0", VA = "0x1851181C0", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class HBUJNPDKTMV<a, b, c, d> : IGIJDGNWSCS<(a, b, c, d)>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x510B2C0", Offset = "0x51098C0", VA = "0x18510B2C0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x510AA80", Offset = "0x5109080", VA = "0x18510AA80", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class HBPCQIJNKBM<a, b, c, d, e> : IGIJDGNWSCS<(a, b, c, d, e)>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x50E3CF0", Offset = "0x50E22F0", VA = "0x1850E3CF0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x50E3330", Offset = "0x50E1930", VA = "0x1850E3330", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class HBJVTBPQAQD<a, b, c, d, e, f> : IGIJDGNWSCS<(a, b, c, d, e, f)>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x50E2740", Offset = "0x50E0D40", VA = "0x1850E2740", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x50E1B70", Offset = "0x50E0170", VA = "0x1850E1B70", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class HBEOVUVSREU<a, b, c, d, e, f, g> : IGIJDGNWSCS<(a, b, c, d, e, f, g)>, GGASJLLNBGR
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x50D7590", Offset = "0x50D5B90", VA = "0x1850D7590", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x50D6820", Offset = "0x50D4E20", VA = "0x1850D6820", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class HEFOGSIFCSZ<a, b, c, d, e, f, g, h> : IGIJDGNWSCS<ValueTuple<a, b, c, d, e, f, g, h>>, GGASJLLNBGR where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] EGMRVGKGYOG;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly QWGCVROHGSW RNTIZLORXHC;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x511B560", Offset = "0x5119B60", VA = "0x18511B560", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, CKTJJUOJSNN formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x511A630", Offset = "0x5118C30", VA = "0x18511A630", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, CKTJJUOJSNN formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class GCXZGWPAYFU
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] BAFECBOHBJI;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly QWGCVROHGSW WHMBNYYXBQT;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x9076820", Offset = "0x9074E20", VA = "0x189076820")]
		static GCXZGWPAYFU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class QMJEPMGGHEQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] TXZPLXENSAT;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly QWGCVROHGSW WKWSBATGZFI;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x9082690", Offset = "0x9080C90", VA = "0x189082690")]
		static QMJEPMGGHEQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class UEBXMNGIJRK
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] MAGFADAPBEG;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly QWGCVROHGSW LPHVBNZLAMX;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] MAAYCWGRRSX;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly QWGCVROHGSW LPNBYUTIJYG;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] LZVRFPMUIHO;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly QWGCVROHGSW LPSIWBNFTJP;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] LZQKIISWYWF;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly QWGCVROHGSW LOHMPGDYFIE;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] LZLDLBYZPKW;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly QWGCVROHGSW LOMTMMXVOTN;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] LZFWNVFCFZN;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly QWGCVROHGSW LOSAJTRSYEW;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] LZAPQOLEWOE;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly QWGCVROHGSW LOXHHALQHQF;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] LYVITHRHNCV;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly QWGCVROHGSW LNMLAFCITOU;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x90850A0", Offset = "0x90836A0", VA = "0x1890850A0")]
		static UEBXMNGIJRK()
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
