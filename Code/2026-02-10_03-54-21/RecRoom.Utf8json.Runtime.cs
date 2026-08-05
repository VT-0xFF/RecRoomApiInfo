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
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xABA430", Offset = "0xAB9630", VA = "0x180ABA430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, ROQIDLVCAVJ resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, ROQIDLVCAVJ resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface DTZLAYDSJYZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface OXTXAOMJJRM<a> : DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, ROQIDLVCAVJ formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface XNVOSUNREOX<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SKZCSLJGNWV(JsonWriter a, a b, ROQIDLVCAVJ c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b);
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
	public static class UBMXRQABQBQ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3BF96B0", Offset = "0x3BF88B0", VA = "0x183BF96B0")]
		public static string ToJsonString<T>(this OXTXAOMJJRM<T> formatter, T value, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OXTXAOMJJRM<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class ZJWTEEEGXAU
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C5B2F0", Offset = "0x3C5A4F0", VA = "0x183C5B2F0")]
		public static OXTXAOMJJRM<a> SYKIXIQQHKD<a>(this ROQIDLVCAVJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C610", Offset = "0x8F9B810", VA = "0x188F9C610")]
		public static object OCKZYMJHJPZ(this ROQIDLVCAVJ a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8F905C0", Offset = "0x8F8F7C0", VA = "0x188F905C0")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class IKHLHXDDXNL
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] UHZUYGZUJJG;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] IWAOVHDACTH;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] QLVAHDGKLDA;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] PCBZAIHGBKN;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] JXGUEZCNACM;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] MJPDVULSUVN;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] LITDNMTSOJB;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] JDQIGTHLNXE;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class CFKVWCXYQMC : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x8F8EA70", Offset = "0x8F8DC70", VA = "0x188F8EA70")]
				public CFKVWCXYQMC(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x8F8E950", Offset = "0x8F8DB50", VA = "0x188F8E950")]
				public CFKVWCXYQMC FHWKPNSHXXS(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class DTLFXIAGEIV
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] JGJJXRKBAHI;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] NWSJXNWMAFH;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private CFKVWCXYQMC start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private CFKVWCXYQMC end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8F9A420", Offset = "0x8F99620", VA = "0x188F9A420")]
			public void FHWKPNSHXXS([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8F9A2E0", Offset = "0x8F994E0", VA = "0x188F9A2E0")]
			public void FHWKPNSHXXS(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8F9A530", Offset = "0x8F99730", VA = "0x188F9A530")]
			public ReadOnlySequence<byte> KGCCZXJCLZF()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8F9A130", Offset = "0x8F99330", VA = "0x188F9A130")]
			private void BSLHTGYIHOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8F9A660", Offset = "0x8F99860", VA = "0x188F9A660")]
			private void XFVPHSKBXOV([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8F97450", Offset = "0x8F96650", VA = "0x188F97450")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8F95990", Offset = "0x8F94B90", VA = "0x188F95990")]
		private JsonParsingException NHRQHDUAKFH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8F96330", Offset = "0x8F95530", VA = "0x188F96330")]
		private JsonParsingException PZCURJMTEEY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8F956C0", Offset = "0x8F948C0", VA = "0x188F956C0")]
		public JsonToken LSFKPYMGGZW()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8F97220", Offset = "0x8F96420", VA = "0x188F97220")]
		public void YUKXONMMMGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8F96440", Offset = "0x8F95640", VA = "0x188F96440")]
		private bool QZSBVMQZCUQ(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8F964A0", Offset = "0x8F956A0", VA = "0x188F964A0")]
		private bool QZSBVMQZCUQ(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8F954B0", Offset = "0x8F946B0", VA = "0x188F954B0")]
		private void JSQYYNGITJH(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8F95F80", Offset = "0x8F95180", VA = "0x188F95F80")]
		public bool OPWMOKXHPSN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8F96CB0", Offset = "0x8F95EB0", VA = "0x188F96CB0")]
		public void VYUATPWWNEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8F951D0", Offset = "0x8F943D0", VA = "0x188F951D0")]
		public bool IVSYUPDNHPU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F95F70", Offset = "0x8F95170", VA = "0x188F95F70")]
		public void OPSHHIMWJTB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8F96C00", Offset = "0x8F95E00", VA = "0x188F96C00")]
		public void UXBFLBSVEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8F95560", Offset = "0x8F94760", VA = "0x188F95560")]
		public bool JUHDJNZLFAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8F97010", Offset = "0x8F96210", VA = "0x188F97010")]
		public void XCJSWUTFQTP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8F95980", Offset = "0x8F94B80", VA = "0x188F95980")]
		public void NHASPPKNEBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8F96A90", Offset = "0x8F95C90", VA = "0x188F96A90")]
		public bool UBFRJFAAOEB(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8F97190", Offset = "0x8F96390", VA = "0x188F97190")]
		public bool YFTIRXZNYDH(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8F96B20", Offset = "0x8F95D20", VA = "0x188F96B20")]
		public bool UVAESEFCDFW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8F965B0", Offset = "0x8F957B0", VA = "0x188F965B0")]
		private ReadOnlySequence<byte> SRYXZXSIIYV()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8F94290", Offset = "0x8F93490", VA = "0x188F94290")]
		private ReadOnlySequence<byte> BTTRVDFOMOM()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8F94D00", Offset = "0x8F93F00", VA = "0x188F94D00")]
		private void EIOXJIEXPOU(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8F948D0", Offset = "0x8F93AD0", VA = "0x188F948D0")]
		private void DJQPCVDNANB(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8F96040", Offset = "0x8F95240", VA = "0x188F96040")]
		private void PVBXFWPGKRE(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8F94500", Offset = "0x8F93700", VA = "0x188F94500")]
		private void BWHFNSXSDGB(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8F8A6E0", Offset = "0x8F898E0", VA = "0x188F8A6E0")]
		private static int IFRPKZLGKNG(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8F95EA0", Offset = "0x8F950A0", VA = "0x188F95EA0")]
		public ReadOnlySequence<byte> ONVYXENNJXC()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8F94610", Offset = "0x8F93810", VA = "0x188F94610")]
		public string CCTIULEFAZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8F94B80", Offset = "0x8F93D80", VA = "0x188F94B80")]
		public string DLOBGTPRWVQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8F94BC0", Offset = "0x8F93DC0", VA = "0x188F94BC0")]
		public ReadOnlySequence<byte> DXJDRHOJKUU()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8F94EF0", Offset = "0x8F940F0", VA = "0x188F94EF0")]
		public ReadOnlySequence<byte> FYHSKMBNGJZ()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8F94FD0", Offset = "0x8F941D0", VA = "0x188F94FD0")]
		public bool GCVLVVMFSMU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8F97020", Offset = "0x8F96220", VA = "0x188F97020")]
		private void XCTPHTSAZXQ(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8F95E90", Offset = "0x8F95090", VA = "0x188F95E90")]
		public void NZKYYQIDCKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8F94690", Offset = "0x8F93890", VA = "0x188F94690")]
		private void CJZBBHUQGGF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8F958D0", Offset = "0x8F94AD0", VA = "0x188F958D0")]
		public sbyte NDLTCEDODDZ()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8F95400", Offset = "0x8F94600", VA = "0x188F95400")]
		public short JLCGCFQVYRA()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8F96F60", Offset = "0x8F96160", VA = "0x188F96F60")]
		public int WKWOIGEVUSQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8F94C90", Offset = "0x8F93E90", VA = "0x188F94C90")]
		public long EHJODPTUAOH()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8F95120", Offset = "0x8F94320", VA = "0x188F95120")]
		public byte IBKEFSRBJLA()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8F94AD0", Offset = "0x8F93CD0", VA = "0x188F94AD0")]
		public ushort DLCWKNPEVMT()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8F96500", Offset = "0x8F95700", VA = "0x188F96500")]
		public uint RMLGHYFKAXL()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8F95650", Offset = "0x8F94850", VA = "0x188F95650")]
		public ulong LIKXUYFSNBU()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8F96C10", Offset = "0x8F95E10", VA = "0x188F96C10")]
		public float VGLYOMMCOGI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8F955B0", Offset = "0x8F947B0", VA = "0x188F955B0")]
		public double KFOERTBBCVL()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8F95220", Offset = "0x8F94420", VA = "0x188F95220")]
		public ReadOnlySequence<byte> JDEWNFRPTCC()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8F96CC0", Offset = "0x8F95EC0", VA = "0x188F96CC0")]
		private void WINRZWCAZIQ()
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
			[Cpp2IlInjected.Address(RVA = "0xD38C10", Offset = "0xD37E10", VA = "0x180D38C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8F94230", Offset = "0x8F93430", VA = "0x188F94230")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8F941B0", Offset = "0x8F933B0", VA = "0x188F941B0")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class YGGGFYUWRGK
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class VIZFDBTXMJD
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] JGJJXRKBAHI;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8F9B600", Offset = "0x8F9A800", VA = "0x188F9B600")]
			public static byte[] FBLVUJKAERI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static ROQIDLVCAVJ GVTSUIDNVHF;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] TQMJBSGXPVE;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] OCTUDREEOJG;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static ROQIDLVCAVJ NKPYOVPFQOD
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8F9B6A0", Offset = "0x8F9A8A0", VA = "0x188F9B6A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8F9B790", Offset = "0x8F9A990", VA = "0x188F9B790")]
		public static void RBZAJSRQWXB(ROQIDLVCAVJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3C50970", Offset = "0x3C4FB70", VA = "0x183C50970")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3C509E0", Offset = "0x3C4FBE0", VA = "0x183C509E0")]
		public static byte[] Serialize<T>(T value, ROQIDLVCAVJ resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3C50F50", Offset = "0x3C50150", VA = "0x183C50F50")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3C50FD0", Offset = "0x3C501D0", VA = "0x183C50FD0")]
		public static string ToJsonString<T>(T value, ROQIDLVCAVJ resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3C50320", Offset = "0x3C4F520", VA = "0x183C50320")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3C500D0", Offset = "0x3C4F2D0", VA = "0x183C500D0")]
		public static T Deserialize<T>(string json, ROQIDLVCAVJ resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3C50570", Offset = "0x3C4F770", VA = "0x183C50570")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3C50250", Offset = "0x3C4F450", VA = "0x183C50250")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, ROQIDLVCAVJ resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3C4FAE0", Offset = "0x3C4ECE0", VA = "0x183C4FAE0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3C4F910", Offset = "0x3C4EB10", VA = "0x183C4F910")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, ROQIDLVCAVJ resolver)
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
		public int WJFMANZFOBM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6DB0", VA = "0x180CF7BB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8F98140", Offset = "0x8F97340", VA = "0x188F98140")]
		public void UHLPNWSUGIZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8F97E90", Offset = "0x8F97090", VA = "0x188F97E90")]
		public static byte[] RWLWHRMECAM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8F98150", Offset = "0x8F97350", VA = "0x188F98150")]
		public static byte[] VBBKUTATXFK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8F976A0", Offset = "0x8F968A0", VA = "0x188F976A0")]
		public static byte[] CZCEUAJSUMG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8F97BD0", Offset = "0x8F96DD0", VA = "0x188F97BD0")]
		public static byte[] NOHBXFSEUMK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2848750", Offset = "0x2847950", VA = "0x182848750")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8F97840", Offset = "0x8F96A40", VA = "0x188F97840")]
		public ArraySegment<byte> FBLVUJKAERI()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8F97990", Offset = "0x8F96B90", VA = "0x188F97990")]
		public byte[] MPJYPEYJVAZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8F97FC0", Offset = "0x8F971C0", VA = "0x188F97FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8F978E0", Offset = "0x8F96AE0", VA = "0x188F978E0")]
		public void FVZMKIZMBBA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8F97B20", Offset = "0x8F96D20", VA = "0x188F97B20")]
		public void MTPNRXFPBTR(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8F97E50", Offset = "0x8F97050", VA = "0x188F97E50")]
		public void QEKJKTIQIEB(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A8F0", Offset = "0x3E69AF0", VA = "0x183E6A8F0")]
		public void YACWAHIHJIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A850", Offset = "0x3E69A50", VA = "0x183E6A850")]
		public void IIMLXWXHFQJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8F989B0", Offset = "0x8F97BB0", VA = "0x188F989B0")]
		public void XPCEVZSDYHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8F97F70", Offset = "0x8F97170", VA = "0x188F97F70")]
		public void THWWBRXZZBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3E6A8A0", Offset = "0x3E69AA0", VA = "0x183E6A8A0")]
		public void OIPDBMDXMPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3EDF580", Offset = "0x3EDE780", VA = "0x183EDF580")]
		public void KCJYKWIUANV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8F98390", Offset = "0x8F97590", VA = "0x188F98390")]
		public void XGSTKBBPFGR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8F97B80", Offset = "0x8F96D80", VA = "0x188F97B80")]
		public void NCWYOCWWWPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8F980A0", Offset = "0x8F972A0", VA = "0x188F980A0")]
		public void UEKFJVOPHLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x789E5B0", Offset = "0x789D7B0", VA = "0x18789E5B0")]
		public void KLOJNULZONH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8F977C0", Offset = "0x8F969C0", VA = "0x188F977C0")]
		public void DKDXYJLDGBJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8F98020", Offset = "0x8F97220", VA = "0x188F98020")]
		public void UBCJGEPOTUS(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8F98270", Offset = "0x8F97470", VA = "0x188F98270")]
		public void VRMPMZBITFL(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8F97630", Offset = "0x8F96830", VA = "0x188F97630")]
		public void CVIBRWKRYWM(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8F97DE0", Offset = "0x8F96FE0", VA = "0x188F97DE0")]
		public void PVNTLVWSCUW(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8F98360", Offset = "0x8F97560", VA = "0x188F98360")]
		public void WXUFVEXUAZX(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8F97920", Offset = "0x8F96B20", VA = "0x188F97920")]
		public void LXDZDNQHHKK(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8F975C0", Offset = "0x8F967C0", VA = "0x188F975C0")]
		public void BXWEWOZWJQH(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8F97D70", Offset = "0x8F96F70", VA = "0x188F97D70")]
		public void PUIFHTGMWOR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8F978F0", Offset = "0x8F96AF0", VA = "0x188F978F0")]
		public void HWFCIHOJTGG(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8F98430", Offset = "0x8F97630", VA = "0x188F98430")]
		public void XJKSKEOLXZA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8F982E0", Offset = "0x8F974E0", VA = "0x188F982E0")]
		private static bool WSOISQCIMBK(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8F97D50", Offset = "0x8F96F50", VA = "0x188F97D50")]
		private static byte OTNDVHKWYFQ(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8F8A9D0", Offset = "0x8F89BD0", VA = "0x188F8A9D0")]
		private static void POXPYRPODYL(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class ZBIPEZCHFWQ : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x671EED0", Offset = "0x671E0D0", VA = "0x18671EED0")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private ZBIPEZCHFWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class IZUUFASJVGF : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6714E80", Offset = "0x6714080", VA = "0x186714E80")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class AZIBXVREKJV
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> DTJWISZKFCM;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8F8C9D0", Offset = "0x8F8BBD0", VA = "0x188F8C9D0")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private IZUUFASJVGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class MUFEUNAXOEZ : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x672B990", Offset = "0x672AB90", VA = "0x18672B990")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly MUFEUNAXOEZ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool GTXZGWUPTZT;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static DTZLAYDSJYZ[] OCHVXXWYTKL;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static ROQIDLVCAVJ[] KZEQATUZIZV;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private MUFEUNAXOEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8F98E60", Offset = "0x8F98060", VA = "0x188F98E60")]
		public static void JUFURAKXVZP(params ROQIDLVCAVJ[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8F98D90", Offset = "0x8F97F90", VA = "0x188F98D90")]
		public static void JUFURAKXVZP(params DTZLAYDSJYZ[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8F98B30", Offset = "0x8F97D30", VA = "0x188F98B30")]
		public static void AUQMYYFKPBR(DTZLAYDSJYZ[] a, ROQIDLVCAVJ[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class LEEYEQFLYUA : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x671BF90", Offset = "0x671B190", VA = "0x18671BF90")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private LEEYEQFLYUA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class IHRAJMBZPET
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly ROQIDLVCAVJ XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly ROQIDLVCAVJ VSPLFMACRUI;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class HROSNAJKKIP
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly ROQIDLVCAVJ XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly ROQIDLVCAVJ IXRNVMDDPQK;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly ROQIDLVCAVJ DFNZPHAUCQA;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly ROQIDLVCAVJ XAXVYFQMGSL;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly ROQIDLVCAVJ CQPHWHEMEUD;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly ROQIDLVCAVJ QNANVMJJBZD;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly ROQIDLVCAVJ CQMKMNJQVIA;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly ROQIDLVCAVJ ONSAHKZYADI;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly ROQIDLVCAVJ MVMCGPOCBPG;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly ROQIDLVCAVJ RQTNCAQLZDV;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly ROQIDLVCAVJ FWIMQPFKREH;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly ROQIDLVCAVJ LPUWFWCXIVH;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class ZTVWRHWKLFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> DTJWISZKFCM;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C760", Offset = "0x8F9B960", VA = "0x188F9C760")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8F9E360", Offset = "0x8F9D560", VA = "0x188F9E360")]
		private static object SHQKAUUKWET(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class JFKPHHAJGFG : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x671D830", Offset = "0x671CA30", VA = "0x18671D830")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private JFKPHHAJGFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class RSTLTGWCJVL : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x6721340", Offset = "0x6720540", VA = "0x186721340")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private RSTLTGWCJVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class IEQWLDALBNV
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly ROQIDLVCAVJ[] RKGXKRNWUVK;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class CCCFTOXWGGS : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x672A210", Offset = "0x6729410", VA = "0x18672A210")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class TDDHIQMDYLY : ROQIDLVCAVJ
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class WCLSHKLJOVZ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x6720EE0", Offset = "0x67200E0", VA = "0x186720EE0")]
				static WCLSHKLJOVZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly ROQIDLVCAVJ DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly ROQIDLVCAVJ[] KZEQATUZIZV;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			private TDDHIQMDYLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
			public OXTXAOMJJRM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly OXTXAOMJJRM<object> HEUERSLVREI;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private CCCFTOXWGGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class USBXBEPCLBL : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6720660", Offset = "0x671F860", VA = "0x186720660")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class TDDHIQMDYLY : ROQIDLVCAVJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class WCLSHKLJOVZ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x6711010", Offset = "0x6710210", VA = "0x186711010")]
				static WCLSHKLJOVZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly ROQIDLVCAVJ DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly ROQIDLVCAVJ[] KZEQATUZIZV;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			private TDDHIQMDYLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
			public OXTXAOMJJRM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly OXTXAOMJJRM<object> HEUERSLVREI;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private USBXBEPCLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class QCKRNVGFMCP : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6712E80", Offset = "0x6712080", VA = "0x186712E80")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class TDDHIQMDYLY : ROQIDLVCAVJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class WCLSHKLJOVZ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x671CC70", Offset = "0x671BE70", VA = "0x18671CC70")]
				static WCLSHKLJOVZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly ROQIDLVCAVJ DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly ROQIDLVCAVJ[] KZEQATUZIZV;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			private TDDHIQMDYLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
			public OXTXAOMJJRM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly OXTXAOMJJRM<object> HEUERSLVREI;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private QCKRNVGFMCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class UESATDVEUWA : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x671DE00", Offset = "0x671D000", VA = "0x18671DE00")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class TDDHIQMDYLY : ROQIDLVCAVJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class WCLSHKLJOVZ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x67139A0", Offset = "0x6712BA0", VA = "0x1867139A0")]
				static WCLSHKLJOVZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly ROQIDLVCAVJ DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly ROQIDLVCAVJ[] KZEQATUZIZV;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			private TDDHIQMDYLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
			public OXTXAOMJJRM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly OXTXAOMJJRM<object> HEUERSLVREI;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private UESATDVEUWA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class DMSIRLOSBZK : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x672AD50", Offset = "0x6729F50", VA = "0x18672AD50")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class TDDHIQMDYLY : ROQIDLVCAVJ
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class WCLSHKLJOVZ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x6713540", Offset = "0x6712740", VA = "0x186713540")]
				static WCLSHKLJOVZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly ROQIDLVCAVJ DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly ROQIDLVCAVJ[] KZEQATUZIZV;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			private TDDHIQMDYLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
			public OXTXAOMJJRM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly OXTXAOMJJRM<object> HEUERSLVREI;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private DMSIRLOSBZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class SGOLXBHFVVQ : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x6723110", Offset = "0x6722310", VA = "0x186723110")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class TDDHIQMDYLY : ROQIDLVCAVJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class WCLSHKLJOVZ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x6720AC0", Offset = "0x671FCC0", VA = "0x186720AC0")]
				static WCLSHKLJOVZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly ROQIDLVCAVJ DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly ROQIDLVCAVJ[] KZEQATUZIZV;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			private TDDHIQMDYLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
			public OXTXAOMJJRM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly OXTXAOMJJRM<object> HEUERSLVREI;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private SGOLXBHFVVQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class VHGHEJFPUPB : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x671B500", Offset = "0x671A700", VA = "0x18671B500")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class TDDHIQMDYLY : ROQIDLVCAVJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class WCLSHKLJOVZ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x6714B50", Offset = "0x6713D50", VA = "0x186714B50")]
				static WCLSHKLJOVZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly ROQIDLVCAVJ DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly ROQIDLVCAVJ[] KZEQATUZIZV;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			private TDDHIQMDYLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
			public OXTXAOMJJRM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly OXTXAOMJJRM<object> HEUERSLVREI;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private VHGHEJFPUPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class ERBVRLEKWUJ : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6715B00", Offset = "0x6714D00", VA = "0x186715B00")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class TDDHIQMDYLY : ROQIDLVCAVJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class WCLSHKLJOVZ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0x67190B0", Offset = "0x67182B0", VA = "0x1867190B0")]
				static WCLSHKLJOVZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly ROQIDLVCAVJ DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly ROQIDLVCAVJ[] KZEQATUZIZV;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			private TDDHIQMDYLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
			public OXTXAOMJJRM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly OXTXAOMJJRM<object> HEUERSLVREI;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private ERBVRLEKWUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class EYSFKHNWILF : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x67250F0", Offset = "0x67242F0", VA = "0x1867250F0")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class TDDHIQMDYLY : ROQIDLVCAVJ
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class WCLSHKLJOVZ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x6718920", Offset = "0x6717B20", VA = "0x186718920")]
				static WCLSHKLJOVZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly ROQIDLVCAVJ DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly ROQIDLVCAVJ[] KZEQATUZIZV;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			private TDDHIQMDYLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
			public OXTXAOMJJRM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly OXTXAOMJJRM<object> HEUERSLVREI;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private EYSFKHNWILF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class PYCMDLTDCQE : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6714850", Offset = "0x6713A50", VA = "0x186714850")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class TDDHIQMDYLY : ROQIDLVCAVJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class WCLSHKLJOVZ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x6717E80", Offset = "0x6717080", VA = "0x186717E80")]
				static WCLSHKLJOVZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly ROQIDLVCAVJ DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly ROQIDLVCAVJ[] KZEQATUZIZV;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			private TDDHIQMDYLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
			public OXTXAOMJJRM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly OXTXAOMJJRM<object> HEUERSLVREI;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private PYCMDLTDCQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class GGZFZSOJOIA : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x67160C0", Offset = "0x67152C0", VA = "0x1867160C0")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class TDDHIQMDYLY : ROQIDLVCAVJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class WCLSHKLJOVZ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x6721910", Offset = "0x6720B10", VA = "0x186721910")]
				static WCLSHKLJOVZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly ROQIDLVCAVJ DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly ROQIDLVCAVJ[] KZEQATUZIZV;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			private TDDHIQMDYLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
			public OXTXAOMJJRM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly OXTXAOMJJRM<object> HEUERSLVREI;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private GGZFZSOJOIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class EAIWISSCYZM : ROQIDLVCAVJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class WCLSHKLJOVZ<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6723D10", Offset = "0x6722F10", VA = "0x186723D10")]
			static WCLSHKLJOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class TDDHIQMDYLY : ROQIDLVCAVJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class WCLSHKLJOVZ<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly OXTXAOMJJRM<a> TABAFMPRXDI;

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x670E8D0", Offset = "0x670DAD0", VA = "0x18670E8D0")]
				static WCLSHKLJOVZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly ROQIDLVCAVJ DZRVHNEPLID;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly ROQIDLVCAVJ[] KZEQATUZIZV;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			private TDDHIQMDYLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
			public OXTXAOMJJRM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly ROQIDLVCAVJ DZRVHNEPLID;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly OXTXAOMJJRM<object> HEUERSLVREI;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		private EAIWISSCYZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x30B9950", Offset = "0x30B8B50", VA = "0x1830B9950", Slot = "4")]
		public OXTXAOMJJRM<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x5843980", Offset = "0x5842B80", VA = "0x185843980")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5843690", Offset = "0x5842890", VA = "0x185843690")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x58438F0", Offset = "0x5842AF0", VA = "0x1858438F0")]
		public T[] MJIDFJYDGKS()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class MEMOUDGSCTW<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int PJEGRSOHWTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object DYTRYINWBYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int NMEELCHBFXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] CKQMRMMDLQL;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x589BA60", Offset = "0x589AC60", VA = "0x18589BA60")]
		public MEMOUDGSCTW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x589B760", Offset = "0x589A960", VA = "0x18589B760")]
		public a[] ULISYCNCXOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x589B390", Offset = "0x589A590", VA = "0x18589B390")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class DRWGAIIGMDI : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class JGNTSKQXCLA : IComparable<JGNTSKQXCLA>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class DKXCUJJQQSW : IEnumerable<JGNTSKQXCLA>, IEnumerable, IEnumerator<JGNTSKQXCLA>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int HDIOWKWRMCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private JGNTSKQXCLA HVLGGEUBMPZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int SQEAAJZHTMN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public JGNTSKQXCLA LQBDIDDTHZG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int RHIFHEGTOPM;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private JGNTSKQXCLA CPQRICXSLAL
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object CVJXXTOQWTE
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xDC8510", Offset = "0xDC7710", VA = "0x180DC8510")]
				[DebuggerHidden]
				public DKXCUJJQQSW(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "7")]
				[DebuggerHidden]
				private void JZSTYLGWFSV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x8F8EB80", Offset = "0x8F8DD80", VA = "0x188F8EB80", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x8F8EC00", Offset = "0x8F8DE00", VA = "0x188F8EC00", Slot = "10")]
				[DebuggerHidden]
				private void ZJSIHLTIANO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x8F8EAE0", Offset = "0x8F8DCE0", VA = "0x188F8EAE0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<JGNTSKQXCLA> JBLINIQFXJW()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x8F8EAE0", Offset = "0x8F8DCE0", VA = "0x188F8EAE0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator KRQKAOMZCCF()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly JGNTSKQXCLA[] TZZNMRXHSBY;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] BKFLGZELUTP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong WLDJEQTQAKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int LRBPAVAYBMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string LAEZKPBOYOW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private JGNTSKQXCLA[] EGOHYPHPTQO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] XSIIASRRAVT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int KBLEVYHOHYH;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8F93D60", Offset = "0x8F92F60", VA = "0x188F93D60")]
			public JGNTSKQXCLA(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8F93840", Offset = "0x8F92A40", VA = "0x188F93840")]
			public JGNTSKQXCLA Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8F93A40", Offset = "0x8F92C40", VA = "0x188F93A40")]
			public JGNTSKQXCLA Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8F93B50", Offset = "0x8F92D50", VA = "0x188F93B50")]
			public JGNTSKQXCLA WTKMCRHESKI(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8F937B0", Offset = "0x8F929B0", VA = "0x188F937B0")]
			internal static int AOWJHUCINHL(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8F93AA0", Offset = "0x8F92CA0", VA = "0x188F93AA0", Slot = "4")]
			public int CompareTo(JGNTSKQXCLA other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8F93AD0", Offset = "0x8F92CD0", VA = "0x188F93AD0")]
			[IteratorStateMachine(typeof(DKXCUJJQQSW))]
			public IEnumerable<JGNTSKQXCLA> QFHHVOVVWNY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class AFZZLOVRJRO : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<JGNTSKQXCLA> EGOHYPHPTQO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<JGNTSKQXCLA> WNKMBVRIZEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<JGNTSKQXCLA> XORIMGFAPUY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private JGNTSKQXCLA JAYZWNAIZVL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> XPBWGTSVIRQ;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> EWMOZSNUVZX
			{
				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0xB2F4C0", Offset = "0xB2E6C0", VA = "0x180B2F4C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x8F8C1E0", Offset = "0x8F8B3E0", VA = "0x188F8C1E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x1AA4D30", Offset = "0x1AA3F30", VA = "0x181AA4D30")]
			[DebuggerHidden]
			public AFZZLOVRJRO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8F8C230", Offset = "0x8F8B430", VA = "0x188F8C230", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8F8C420", Offset = "0x8F8B620", VA = "0x188F8C420", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8F8C8D0", Offset = "0x8F8BAD0", VA = "0x188F8C8D0")]
			private void RKOKQQOFJWR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8F8C880", Offset = "0x8F8BA80", VA = "0x188F8C880")]
			private void RJYPYWGNHOQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8F8C920", Offset = "0x8F8BB20", VA = "0x188F8C920", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8F8C380", Offset = "0x8F8B580", VA = "0x188F8C380", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> YFERYDAPFCW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8F8C380", Offset = "0x8F8B580", VA = "0x188F8C380", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly JGNTSKQXCLA OLVATFGKMBC;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F520", Offset = "0x8F8E720", VA = "0x188F8F520")]
		public DRWGAIIGMDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8F8ECD0", Offset = "0x8F8DED0", VA = "0x188F8ECD0")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F2A0", Offset = "0x8F8E4A0", VA = "0x188F8F2A0")]
		public bool GDGJFTLPVBG(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8F8EEB0", Offset = "0x8F8E0B0", VA = "0x188F8EEB0")]
		public bool DCOWRXBICJH([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F410", Offset = "0x8F8E610", VA = "0x188F8F410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8F8EFC0", Offset = "0x8F8E1C0", VA = "0x188F8EFC0")]
		private static void EMJPVOXRXIT(IEnumerable<JGNTSKQXCLA> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F3B0", Offset = "0x8F8E5B0", VA = "0x188F8F3B0", Slot = "5")]
		private IEnumerator KRQKAOMZCCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F3B0", Offset = "0x8F8E5B0", VA = "0x188F8F3B0", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F4A0", Offset = "0x8F8E6A0", VA = "0x188F8F4A0")]
		[IteratorStateMachine(typeof(AFZZLOVRJRO))]
		private static IEnumerable<KeyValuePair<string, int>> UZUMVKUTVRQ(IEnumerable<JGNTSKQXCLA> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class GPCXQUFBBUF
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo NAOSUWVACDI;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8F90760", Offset = "0x8F8F960", VA = "0x188F90760")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8F90910", Offset = "0x8F8FB10", VA = "0x188F90910")]
		public static ulong SMCDURGOFNM(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class JOQWXHJLPDT
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8F94070", Offset = "0x8F93270", VA = "0x188F94070")]
		public static void FVZMKIZMBBA(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8F93E10", Offset = "0x8F93010", VA = "0x188F93E10")]
		public static void BPSRMNFPRTU(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8F93F30", Offset = "0x8F93130", VA = "0x188F93F30")]
		public static byte[] FBCRJSOXBAT(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class DOBHUSIDDEJ<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x47338F0", Offset = "0x4732AF0", VA = "0x1847338F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class KGRVSAGRPXX : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public DOBHUSIDDEJ<a> LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] XORIMGFAPUY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int XPHDEAMSSCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] XPBWGTSVIRQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int XOBNULXINMX;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> GUZXUGYBXYE
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xB2F4C0", Offset = "0xB2E6C0", VA = "0x180B2F4C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0x4E1A940", Offset = "0x4E19B40", VA = "0x184E1A940", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xABE300", Offset = "0xABD500", VA = "0x180ABE300")]
			[DebuggerHidden]
			public KGRVSAGRPXX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "5")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x52052D0", Offset = "0x52044D0", VA = "0x1852052D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3D9CBF0", Offset = "0x3D9BDF0", VA = "0x183D9CBF0", Slot = "8")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] FOFRWFANQJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong TDJPTANQLET;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool QEHKWPKWUPK;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x408D3D0", Offset = "0x408C5D0", VA = "0x18408D3D0")]
		public DOBHUSIDDEJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x408D2E0", Offset = "0x408C4E0", VA = "0x18408D2E0")]
		public DOBHUSIDDEJ(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4084340", Offset = "0x4083540", VA = "0x184084340")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4086FA0", Offset = "0x40861A0", VA = "0x184086FA0")]
		private bool EEDJSLFGRCV(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x4088B70", Offset = "0x4087D70", VA = "0x184088B70")]
		public bool GDGJFTLPVBG([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x408A940", Offset = "0x4089B40", VA = "0x18408A940")]
		private static ulong GOMDFSWNDOE([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x408B1A0", Offset = "0x408A3A0", VA = "0x18408B1A0")]
		private static ulong GOMDFSWNDOE([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x408D250", Offset = "0x408C450", VA = "0x18408D250")]
		private static int SJDQHTOBPMI(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x408CF50", Offset = "0x408C150", VA = "0x18408CF50", Slot = "4")]
		[IteratorStateMachine(typeof(DOBHUSIDDEJ<>.KGRVSAGRPXX))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x408D070", Offset = "0x408C270", VA = "0x18408D070", Slot = "5")]
		private IEnumerator KRQKAOMZCCF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class CYASJLWBDNS
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3527590", Offset = "0x3526790", VA = "0x183527590")]
		public static Func<a> ELEHJKMZBMG<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3527680", Offset = "0x3526880", VA = "0x183527680")]
		private static c OKMKAVZIHHN<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0x8F918E0", Offset = "0x8F90AE0", VA = "0x188F918E0")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8F918F0", Offset = "0x8F90AF0", VA = "0x188F918F0")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8F90F60", Offset = "0x8F90160", VA = "0x188F90F60")]
		private static byte JQSDGCHQKHN(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8F8A530", Offset = "0x8F89730", VA = "0x188F8A530")]
		private static byte AOZUWJMSRNR(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8F91000", Offset = "0x8F90200", VA = "0x188F91000")]
		public void JXZWHOAGRCT(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class PYIBFQJFCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8F990B0", Offset = "0x8F982B0", VA = "0x188F990B0")]
		public static bool CCRVKGPSUXP(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8F99C10", Offset = "0x8F98E10", VA = "0x188F99C10")]
		public static bool RTPCWXAQMRW(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8F99AB0", Offset = "0x8F98CB0", VA = "0x188F99AB0")]
		public static sbyte NDLTCEDODDZ([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8F995D0", Offset = "0x8F987D0", VA = "0x188F995D0")]
		public static short JLCGCFQVYRA([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8F99E80", Offset = "0x8F99080", VA = "0x188F99E80")]
		public static int WKWOIGEVUSQ([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8F99120", Offset = "0x8F98320", VA = "0x188F99120")]
		public static long EHJODPTUAOH([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8F99720", Offset = "0x8F98920", VA = "0x188F99720")]
		public static bool KMKDCYFMEGY(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8F99570", Offset = "0x8F98770", VA = "0x188F99570")]
		public static byte IBKEFSRBJLA([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8F990C0", Offset = "0x8F982C0", VA = "0x188F990C0")]
		public static ushort DLCWKNPEVMT([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8F99BB0", Offset = "0x8F98DB0", VA = "0x188F99BB0")]
		public static uint RMLGHYFKAXL([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8F998B0", Offset = "0x8F98AB0", VA = "0x188F998B0")]
		public static ulong LIKXUYFSNBU([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8F99960", Offset = "0x8F98B60", VA = "0x188F99960")]
		public static bool MNBTUAIZKAT(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8F993A0", Offset = "0x8F985A0", VA = "0x188F993A0")]
		public static bool HOJGSXKDNVF(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8F99C80", Offset = "0x8F98E80", VA = "0x188F99C80")]
		public static bool UBWIHKQHFLN(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8F99B10", Offset = "0x8F98D10", VA = "0x188F99B10")]
		public static bool OUOZWWTKBJL(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8F99D90", Offset = "0x8F98F90", VA = "0x188F99D90")]
		public static float VGLYOMMCOGI([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8F99EE0", Offset = "0x8F990E0", VA = "0x188F99EE0")]
		public static bool YGDNUSOUBPP(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8F99630", Offset = "0x8F98830", VA = "0x188F99630")]
		public static double KFOERTBBCVL([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8F99F40", Offset = "0x8F99140", VA = "0x188F99F40")]
		public static bool ZINMLEVSXIM(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8F8B6E0", Offset = "0x8F8A8E0", VA = "0x188F8B6E0")]
		public static int WXUFVEXUAZX(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8F8AB20", Offset = "0x8F89D20", VA = "0x188F8AB20")]
		public static int HWFCIHOJTGG(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8F991D0", Offset = "0x8F983D0", VA = "0x188F991D0")]
		public static bool GCVLVVMFSMU([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class GEWNTAMMDHV
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8F90620", Offset = "0x8F8F820", VA = "0x188F90620")]
		public static bool XJYAOKJXAUB(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class AXTMBAMDLSA
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding TXIYFQKXAXN;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class YPIHWVLAJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FF10", Offset = "0x8F8F110", VA = "0x188F8FF10")]
		public static void TKJLSEJQDOF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FEA0", Offset = "0x8F8F0A0", VA = "0x188F8FEA0")]
		public static void TKEEUXPSUCW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FE30", Offset = "0x8F8F030", VA = "0x188F8FE30")]
		public static void TJYXXQVVKRN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FDC0", Offset = "0x8F8EFC0", VA = "0x188F8FDC0")]
		public static void TJTRAKBYBGE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C060", Offset = "0x8F9B260", VA = "0x188F9C060")]
		public static void THYGZBEVUIB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BFF0", Offset = "0x8F9B1F0", VA = "0x188F9BFF0")]
		public static void THTABUKYKWS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C4C0", Offset = "0x8F9B6C0", VA = "0x188F9C4C0")]
		public static void TZEFFQEMHNM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C530", Offset = "0x8F9B730", VA = "0x188F9C530")]
		public static void TZJMCWYJQYV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C3D0", Offset = "0x8F9B5D0", VA = "0x188F9C3D0")]
		public static void TYTRLCQROQU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C440", Offset = "0x8F9B640", VA = "0x188F9C440")]
		public static void TYYYIJKOYCD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C2D0", Offset = "0x8F9B4D0", VA = "0x188F9C2D0")]
		public static void TYJDQPCWVUC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C350", Offset = "0x8F9B550", VA = "0x188F9C350")]
		public static void TYOKNVWUFFL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C1D0", Offset = "0x8F9B3D0", VA = "0x188F9C1D0")]
		public static void TXYPWBPCCXK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C250", Offset = "0x8F9B450", VA = "0x188F9C250")]
		public static void TYDWTIIZMIT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C0D0", Offset = "0x8F9B2D0", VA = "0x188F9C0D0")]
		public static void TXOCBOBHKAS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8F9C150", Offset = "0x8F9B350", VA = "0x188F9C150")]
		public static void TXTIYUVETMB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BD40", Offset = "0x8F9AF40", VA = "0x188F9BD40")]
		public static void MYNAGXWJRVD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BCC0", Offset = "0x8F9AEC0", VA = "0x188F9BCC0")]
		public static void MYHTJRCMIJU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BC40", Offset = "0x8F9AE40", VA = "0x188F9BC40")]
		public static void MYCMMKIOYYL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BBC0", Offset = "0x8F9ADC0", VA = "0x188F9BBC0")]
		public static void MXXFPDORPNC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BF70", Offset = "0x8F9B170", VA = "0x188F9BF70")]
		public static void MZIBVYXZDON(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BEE0", Offset = "0x8F9B0E0", VA = "0x188F9BEE0")]
		public static void MZCUYSEBUDE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BE50", Offset = "0x8F9B050", VA = "0x188F9BE50")]
		public static void MYXOBLKEKRV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BDC0", Offset = "0x8F9AFC0", VA = "0x188F9BDC0")]
		public static void MYSHEEQHBGM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BB30", Offset = "0x8F9AD30", VA = "0x188F9BB30")]
		public static void MWWXCVTEUIJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BAA0", Offset = "0x8F9ACA0", VA = "0x188F9BAA0")]
		public static void MWRQFOZHKXA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8F9B980", Offset = "0x8F9AB80", VA = "0x188F9B980")]
		public static void GXTTVNNHNZC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8F9BA10", Offset = "0x8F9AC10", VA = "0x188F9BA10")]
		public static void GXZASUHEXKL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FD50", Offset = "0x8F8EF50", VA = "0x188F8FD50")]
		public static void TJJDFWODIJM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FCE0", Offset = "0x8F8EEE0", VA = "0x188F8FCE0")]
		public static void TJDWIPUFYYD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FC70", Offset = "0x8F8EE70", VA = "0x188F8FC70")]
		public static void TIYPLJAIPMU(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class DVAVAPOWIWL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FC00", Offset = "0x8F8EE00", VA = "0x188F8FC00")]
		public static void THYGZBEVUIB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FB90", Offset = "0x8F8ED90", VA = "0x188F8FB90")]
		public static void THTABUKYKWS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8F90330", Offset = "0x8F8F530", VA = "0x188F90330")]
		public static void TZEFFQEMHNM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8F903A0", Offset = "0x8F8F5A0", VA = "0x188F903A0")]
		public static void TZJMCWYJQYV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8F90250", Offset = "0x8F8F450", VA = "0x188F90250")]
		public static void TYTRLCQROQU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8F902C0", Offset = "0x8F8F4C0", VA = "0x188F902C0")]
		public static void TYYYIJKOYCD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8F90170", Offset = "0x8F8F370", VA = "0x188F90170")]
		public static void TYJDQPCWVUC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8F901E0", Offset = "0x8F8F3E0", VA = "0x188F901E0")]
		public static void TYOKNVWUFFL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8F90080", Offset = "0x8F8F280", VA = "0x188F90080")]
		public static void TXYPWBPCCXK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8F900F0", Offset = "0x8F8F2F0", VA = "0x188F900F0")]
		public static void TYDWTIIZMIT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FF80", Offset = "0x8F8F180", VA = "0x188F8FF80")]
		public static void TXOCBOBHKAS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8F90000", Offset = "0x8F8F200", VA = "0x188F90000")]
		public static void TXTIYUVETMB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F910", Offset = "0x8F8EB10", VA = "0x188F8F910")]
		public static void MYNAGXWJRVD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F890", Offset = "0x8F8EA90", VA = "0x188F8F890")]
		public static void MYHTJRCMIJU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F810", Offset = "0x8F8EA10", VA = "0x188F8F810")]
		public static void MYCMMKIOYYL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F790", Offset = "0x8F8E990", VA = "0x188F8F790")]
		public static void MXXFPDORPNC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FB10", Offset = "0x8F8ED10", VA = "0x188F8FB10")]
		public static void MZIBVYXZDON(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FA90", Offset = "0x8F8EC90", VA = "0x188F8FA90")]
		public static void MZCUYSEBUDE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FA10", Offset = "0x8F8EC10", VA = "0x188F8FA10")]
		public static void MYXOBLKEKRV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F990", Offset = "0x8F8EB90", VA = "0x188F8F990")]
		public static void MYSHEEQHBGM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F710", Offset = "0x8F8E910", VA = "0x188F8F710")]
		public static void MWWXCVTEUIJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F690", Offset = "0x8F8E890", VA = "0x188F8F690")]
		public static void MWRQFOZHKXA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F590", Offset = "0x8F8E790", VA = "0x188F8F590")]
		public static void GXTTVNNHNZC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F610", Offset = "0x8F8E810", VA = "0x188F8F610")]
		public static void GXZASUHEXKL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FD50", Offset = "0x8F8EF50", VA = "0x188F8FD50")]
		public static void TJJDFWODIJM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FCE0", Offset = "0x8F8EEE0", VA = "0x188F8FCE0")]
		public static void TJDWIPUFYYD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FC70", Offset = "0x8F8EE70", VA = "0x188F8FC70")]
		public static void TIYPLJAIPMU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FF10", Offset = "0x8F8F110", VA = "0x188F8FF10")]
		public static void TKJLSEJQDOF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FEA0", Offset = "0x8F8F0A0", VA = "0x188F8FEA0")]
		public static void TKEEUXPSUCW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FE30", Offset = "0x8F8F030", VA = "0x188F8FE30")]
		public static void TJYXXQVVKRN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8F8FDC0", Offset = "0x8F8EFC0", VA = "0x188F8FDC0")]
		public static void TJTRAKBYBGE(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class TPGCIPPDGGZ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool QEHKWPKWUPK;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8FB21B0", Offset = "0x8FB13B0", VA = "0x188FB21B0")]
		public static void MTPNRXFPBTR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3BB0", Offset = "0x8FB2DB0", VA = "0x188FB3BB0")]
		public static void UDMBCOAUOIW(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x28EEC50", Offset = "0x28EDE50", VA = "0x1828EEC50")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1640", Offset = "0x8FA0840", VA = "0x188FA1640")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1500", Offset = "0x8FA0700", VA = "0x188FA1500")]
		public static DiyFp AJVWZKEOVVO(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8FA15B0", Offset = "0x8FA07B0", VA = "0x188FA15B0")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1510", Offset = "0x8FA0710", VA = "0x188FA1510")]
		public static DiyFp CZJXVITQHZE(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1650", Offset = "0x8FA0850", VA = "0x188FA1650")]
		public void XLTYFPYWDZB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1690", Offset = "0x8FA0890", VA = "0x188FA1690")]
		public static DiyFp XLTYFPYWDZB(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xB4E9A0", Offset = "0xB4DBA0", VA = "0x180B4E9A0")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1AC0", Offset = "0x8FB0CC0", VA = "0x188FB1AC0")]
		public void WPDSXNTRCNM(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8FB18A0", Offset = "0x8FB0AA0", VA = "0x188FB18A0")]
		public void FZWZQZSTWJI(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8FB19A0", Offset = "0x8FB0BA0", VA = "0x188FB19A0")]
		public void QPHEYKFHAYG(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1A20", Offset = "0x8FB0C20", VA = "0x188FB1A20")]
		public void QPHEYKFHAYG(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1920", Offset = "0x8FB0B20", VA = "0x188FB1920")]
		public void JZXTGAZATVG(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1B20", Offset = "0x8FB0D20", VA = "0x188FB1B20")]
		public void XKUSNBHDFSD(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class UFVIHIKMABB
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
		private static byte[] IJMXHWLETOQ;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] EDFRXYNBFEM;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] DZMQYQSKJLA;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] WMPWQSFLQLZ;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags VPSBXOALVPO;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char TEQKRKDFTIY;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int ACWBALVYGJK;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int XWQELNPVAEI;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] SIMWGIKLJFM;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8FB64F0", Offset = "0x8FB56F0", VA = "0x188FB64F0")]
		private static byte[] TDPHIQCIUAM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8FB65C0", Offset = "0x8FB57C0", VA = "0x188FB65C0")]
		private static byte[] TMIGXCHBIIE(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8FB57D0", Offset = "0x8FB49D0", VA = "0x188FB57D0")]
		public static int IDNNQGWISJR(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8FB56B0", Offset = "0x8FB48B0", VA = "0x188FB56B0")]
		public static int IDNNQGWISJR(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8FB58F0", Offset = "0x8FB4AF0", VA = "0x188FB58F0")]
		private static bool IJXJJHTEXMZ(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8FB5D70", Offset = "0x8FB4F70", VA = "0x188FB5D70")]
		private static void JQCTUOQURCZ(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8FB6B20", Offset = "0x8FB5D20", VA = "0x188FB6B20")]
		private static bool WTGOSTDPEHD(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8FB66A0", Offset = "0x8FB58A0", VA = "0x188FB66A0")]
		private static bool UMJBJZWVBYZ(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8FB55B0", Offset = "0x8FB47B0", VA = "0x188FB55B0")]
		private static bool ICSKQLAACXM(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8FB6330", Offset = "0x8FB5530", VA = "0x188FB6330")]
		private static bool PORMETZAMNN(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8FB5E60", Offset = "0x8FB5060", VA = "0x188FB5E60")]
		private static bool PEQEQIMWKXY(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8FB59E0", Offset = "0x8FB4BE0", VA = "0x188FB59E0")]
		private static void IKLEKRCIFCK(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4F80", Offset = "0x8FB4180", VA = "0x188FB4F80")]
		private static void DXWWBOXICGO(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8FB53C0", Offset = "0x8FB45C0", VA = "0x188FB53C0")]
		private static bool HTRTKKTVWUD(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0x8FA1D00", Offset = "0x8FA0F00", VA = "0x188FA1D00")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1C60", Offset = "0x8FA0E60", VA = "0x188FA1C60")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1700", Offset = "0x8FA0900", VA = "0x188FA1700")]
		public DiyFp AMAHGKWCIIY()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1810", Offset = "0x8FA0A10", VA = "0x188FA1810")]
		public DiyFp CNNEYQRSFWH()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xC504B0", Offset = "0xC4F6B0", VA = "0x180C504B0")]
		public ulong QDAXNQQLRKW()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1B60", Offset = "0x8FA0D60", VA = "0x188FA1B60")]
		public double VBULVMBOGEI()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1770", Offset = "0x8FA0970", VA = "0x188FA1770")]
		public double BGHIRWYJTPC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8FA19F0", Offset = "0x8FA0BF0", VA = "0x188FA19F0")]
		public int UBTDIWIPCNR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1990", Offset = "0x8FA0B90", VA = "0x188FA1990")]
		public ulong JEIKNCVBAXV()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1890", Offset = "0x8FA0A90", VA = "0x188FA1890")]
		public bool DRXZCSURSFW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8FA19D0", Offset = "0x8FA0BD0", VA = "0x188FA19D0")]
		public bool RMGXCIVIXUD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1BE0", Offset = "0x8FA0DE0", VA = "0x188FA1BE0")]
		public bool ZHCFTZNSCRX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1960", Offset = "0x8FA0B60", VA = "0x188FA1960")]
		public bool GBVQODDJFKM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8FA18B0", Offset = "0x8FA0AB0", VA = "0x188FA18B0")]
		public int DXSLGZLYFSV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1A20", Offset = "0x8FA0C20", VA = "0x188FA1A20")]
		public void UVYPJZPTWJR([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1C10", Offset = "0x8FA0E10", VA = "0x188FA1C10")]
		public bool ZLUNGZTTCSB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3C019D0", Offset = "0x3C00BD0", VA = "0x183C019D0")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8FA16E0", Offset = "0x8FA08E0", VA = "0x188FA16E0")]
		public static int AETYUSGHDYM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8FA19C0", Offset = "0x8FA0BC0", VA = "0x188FA19C0")]
		public static double NBJIYESJWWE()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8FA18D0", Offset = "0x8FA0AD0", VA = "0x188FA18D0")]
		public static ulong FPZFBBFSDVJ(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x15F2A00", Offset = "0x15F1C00", VA = "0x1815F2A00")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1680", Offset = "0x8FB0880", VA = "0x188FB1680")]
		public DiyFp AMAHGKWCIIY()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xCF6C10", Offset = "0xCF5E10", VA = "0x180CF6C10")]
		public uint YBEANCIOUTH()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1710", Offset = "0x8FB0910", VA = "0x188FB1710")]
		public int UBTDIWIPCNR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8FB16F0", Offset = "0x8FB08F0", VA = "0x188FB16F0")]
		public uint JEIKNCVBAXV()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8FB16E0", Offset = "0x8FB08E0", VA = "0x188FB16E0")]
		public bool DRXZCSURSFW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1730", Offset = "0x8FB0930", VA = "0x188FB1730")]
		public void UVYPJZPTWJR([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1860", Offset = "0x8FB0A60", VA = "0x188FB1860")]
		public bool ZLUNGZTTCSB()
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
		[Cpp2IlInjected.Address(RVA = "0x8FA14F0", Offset = "0x8FA06F0", VA = "0x188FA14F0")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class HIURHKVZXEM
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] JJLSWODBIGB;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3670", Offset = "0x8FA2870", VA = "0x188FA3670")]
		public static void KZPWDGRBTRD(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8FA35A0", Offset = "0x8FA27A0", VA = "0x188FA35A0")]
		public static void ERRDAJMVWMO(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0x8FB7700", Offset = "0x8FB6900", VA = "0x188FB7700")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x59434B0", Offset = "0x59426B0", VA = "0x1859434B0")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B21810", Offset = "0x2B20A10", VA = "0x182B21810")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8FB76A0", Offset = "0x8FB68A0", VA = "0x188FB76A0")]
		public Vector LBTJWGABRGN(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class MDMZLHGLKQR
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] GROONHNEZWX;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] JESYVDNFSWW;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int GMXAAHCIVTJ;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA520", Offset = "0x8FA9720", VA = "0x188FAA520")]
		private static byte[] YZNCFYJBAAT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8FA97B0", Offset = "0x8FA89B0", VA = "0x188FA97B0")]
		private static Vector INBRUCDLRSJ(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA320", Offset = "0x8FA9520", VA = "0x188FAA320")]
		private static Vector WIQLGCCOFKH(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA290", Offset = "0x8FA9490", VA = "0x188FAA290")]
		private static void UUSUXKBDAPI(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9A20", Offset = "0x8FA8C20", VA = "0x188FA9A20")]
		private static void OHWAZFNQEJN(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA0C0", Offset = "0x8FA92C0", VA = "0x188FAA0C0")]
		private static ulong QLGQVGBWJWC(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA150", Offset = "0x8FA9350", VA = "0x188FAA150")]
		private static void UFERSTVPEGQ(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9D10", Offset = "0x8FA8F10", VA = "0x188FA9D10")]
		private static bool PDVEJZKRFMP(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9890", Offset = "0x8FA8A90", VA = "0x188FA9890")]
		private static DiyFp MYEJZPKQGLS(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8D80", Offset = "0x8FA7F80", VA = "0x188FA8D80")]
		private static bool AOLXVLTXCCO(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA400", Offset = "0x8FA9600", VA = "0x188FAA400")]
		private static bool XZRUSSZFZQW(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8FA9690", Offset = "0x8FA8890", VA = "0x188FA9690")]
		public static double? BEBNJUDDTDE(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8FA93C0", Offset = "0x8FA85C0", VA = "0x188FA93C0")]
		public static float? BDQZPGPJAGM(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class IHKDNNKVUDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] SRJBSVNEKZZ;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] DZMQYQSKJLA;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] WMPWQSFLQLZ;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] OOQMAKAGTBT;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int UHABZEGHQDL;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] UDIQXHRCEGP;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int FUWILHNJSUL;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4910", Offset = "0x8FA3B10", VA = "0x188FA4910")]
		private static byte[] FBLVUJKAERI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5EF0", Offset = "0x8FA50F0", VA = "0x188FA5EF0")]
		public static bool YGDNUSOUBPP(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6050", Offset = "0x8FA5250", VA = "0x188FA6050")]
		public static bool ZINMLEVSXIM(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5CE0", Offset = "0x8FA4EE0", VA = "0x188FA5CE0")]
		private static bool VAHUQDZUNLP(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8FA49F0", Offset = "0x8FA3BF0", VA = "0x188FA49F0")]
		private static bool GUWUADTEEIU(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8FA5E10", Offset = "0x8FA5010", VA = "0x188FA5E10")]
		private static bool XLSOVGCPAAB(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4CB0", Offset = "0x8FA3EB0", VA = "0x188FA4CB0")]
		private static bool LOKGIRCMBFR(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6030", Offset = "0x8FA5230", VA = "0x188FA6030")]
		private static double ZGRYUIGWRVA(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8FA4D20", Offset = "0x8FA3F20", VA = "0x188FA4D20")]
		private static double NQHEULAJMLW(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class NSMGVVJOEXI<a> : OXTXAOMJJRM<a[]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly MEMOUDGSCTW<a> BEGWWNDBWIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour IRVQVJTVOKJ;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x16E2150", Offset = "0x16E1350", VA = "0x1816E2150")]
		public NSMGVVJOEXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xABE300", Offset = "0xABD500", VA = "0x180ABE300")]
		public NSMGVVJOEXI(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x596D640", Offset = "0x596C840", VA = "0x18596D640", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x596CFD0", Offset = "0x596C1D0", VA = "0x18596CFD0", Slot = "5")]
		public a[] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class YHRROVEVLJR<a> : OXTXAOMJJRM<ArraySegment<a>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly MEMOUDGSCTW<a> BEGWWNDBWIH;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3E76AF0", Offset = "0x3E75CF0", VA = "0x183E76AF0", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3E76690", Offset = "0x3E75890", VA = "0x183E76690", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class ZBYHIWIREOR<a> : OXTXAOMJJRM<List<a>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour IRVQVJTVOKJ;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x16E2150", Offset = "0x16E1350", VA = "0x1816E2150")]
		public ZBYHIWIREOR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xABE300", Offset = "0xABD500", VA = "0x180ABE300")]
		public ZBYHIWIREOR(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE8E0", Offset = "0x3EDDAE0", VA = "0x183EDE8E0", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3EDD010", Offset = "0x3EDC210", VA = "0x183EDD010", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class XTVQGXEUPYD<a, b, c, d> : OXTXAOMJJRM<d>, DTZLAYDSJYZ where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3E6E290", Offset = "0x3E6D490", VA = "0x183E6E290", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3E6D7E0", Offset = "0x3E6C9E0", VA = "0x183E6D7E0", Slot = "5")]
		public d Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c QGJLIMSEHOP(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		protected XTVQGXEUPYD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class XTFVPCXCNQC<a, b, c> : XTVQGXEUPYD<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3E6CEB0", Offset = "0x3E6C0B0", VA = "0x183E6CEB0", Slot = "6")]
		protected override IEnumerator<a> QGJLIMSEHOP(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		protected XTFVPCXCNQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class XTLCMJQZXBL<a, b> : XTFVPCXCNQC<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xB19AC0", Offset = "0xB18CC0", VA = "0x180B19AC0", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class UTDVGWWSJQT<a, b> : XTLCMJQZXBL<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x627BC90", Offset = "0x627AE90", VA = "0x18627BC90", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x627BB20", Offset = "0x627AD20", VA = "0x18627BB20", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class QSQGBRDJDFA<a> : XTVQGXEUPYD<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3360", Offset = "0x5CC2560", VA = "0x185CC3360", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xB19AC0", Offset = "0xB18CC0", VA = "0x180B19AC0", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3450", Offset = "0x5CC2650", VA = "0x185CC3450", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x45F8190", Offset = "0x45F7390", VA = "0x1845F8190", Slot = "6")]
		protected override LinkedList<a>.Enumerator QGJLIMSEHOP(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class KOADBNFRARF<a> : XTVQGXEUPYD<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3E73670", Offset = "0x3E72870", VA = "0x183E73670", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3780", Offset = "0x3EE2980", VA = "0x183EE3780", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x521B610", Offset = "0x521A810", VA = "0x18521B610", Slot = "6")]
		protected override Queue<a>.Enumerator QGJLIMSEHOP(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xB19AC0", Offset = "0xB18CC0", VA = "0x180B19AC0", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class UTTKKEABURD<a> : XTVQGXEUPYD<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x4724A90", Offset = "0x4723C90", VA = "0x184724A90", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4724BC0", Offset = "0x4723DC0", VA = "0x184724BC0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x627C3A0", Offset = "0x627B5A0", VA = "0x18627C3A0", Slot = "6")]
		protected override Stack<a>.Enumerator QGJLIMSEHOP(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x627C230", Offset = "0x627B430", VA = "0x18627C230", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class KONMOSMEFUJ<a> : XTVQGXEUPYD<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x521B6C0", Offset = "0x521A8C0", VA = "0x18521B6C0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xB19AC0", Offset = "0xB18CC0", VA = "0x180B19AC0", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x521B7F0", Offset = "0x521A9F0", VA = "0x18521B7F0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x521B850", Offset = "0x521AA50", VA = "0x18521B850", Slot = "6")]
		protected override HashSet<a>.Enumerator QGJLIMSEHOP(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x50F1950", Offset = "0x50F0B50", VA = "0x1850F1950")]
		public KONMOSMEFUJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class VCKTDDLCVZJ<a> : XTFVPCXCNQC<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x4724A90", Offset = "0x4723C90", VA = "0x184724A90", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x638CB60", Offset = "0x638BD60", VA = "0x18638CB60", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x638CC00", Offset = "0x638BE00", VA = "0x18638CC00", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class MDHOUWKJDQM<a> : XTFVPCXCNQC<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3E73670", Offset = "0x3E72870", VA = "0x183E73670", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3780", Offset = "0x3EE2980", VA = "0x183EE3780", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB19AC0", Offset = "0xB18CC0", VA = "0x180B19AC0", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class ZYXZWIHHEQQ<a> : XTFVPCXCNQC<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3E73670", Offset = "0x3E72870", VA = "0x183E73670", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3780", Offset = "0x3EE2980", VA = "0x183EE3780", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB19AC0", Offset = "0xB18CC0", VA = "0x180B19AC0", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class SMKFBJENRJY<a> : XTFVPCXCNQC<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x50E85F0", Offset = "0x50E77F0", VA = "0x1850E85F0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x4724BC0", Offset = "0x4723DC0", VA = "0x184724BC0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x4724B70", Offset = "0x4723D70", VA = "0x184724B70", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x4724BF0", Offset = "0x4723DF0", VA = "0x184724BF0")]
		public SMKFBJENRJY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class TKNKIYDKMBY<a, b> : OXTXAOMJJRM<IGrouping<a, b>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x60757C0", Offset = "0x60749C0", VA = "0x1860757C0", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6075460", Offset = "0x6074660", VA = "0x186075460", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class LJCYDEAHZGL<a, b> : OXTXAOMJJRM<ILookup<a, b>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x537B670", Offset = "0x537A870", VA = "0x18537B670", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x537B310", Offset = "0x537A510", VA = "0x18537B310", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class OLCLTILTMLV<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a GNIQKUTBWSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> GSULOBCECMF;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x3D14500", Offset = "0x3D13700", VA = "0x183D14500", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5A88BD0", Offset = "0x5A87DD0", VA = "0x185A88BD0")]
		public OLCLTILTMLV(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5A88B60", Offset = "0x5A87D60", VA = "0x185A88B60", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x50D86F0", Offset = "0x50D78F0", VA = "0x1850D86F0", Slot = "6")]
		private IEnumerator KRQKAOMZCCF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class WTXHRMYSCYE<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> YBSRURXINVY;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x67B4790", Offset = "0x67B3990", VA = "0x1867B4790", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		public WTXHRMYSCYE(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x67B45F0", Offset = "0x67B37F0", VA = "0x1867B45F0", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x67B46E0", Offset = "0x67B38E0", VA = "0x1867B46E0", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x67B46E0", Offset = "0x67B38E0", VA = "0x1867B46E0", Slot = "7")]
		private IEnumerator KRQKAOMZCCF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class MTXCBCMWFMV<a> : OXTXAOMJJRM<a>, DTZLAYDSJYZ where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x58AEB70", Offset = "0x58ADD70", VA = "0x1858AEB70", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x58AE950", Offset = "0x58ADB50", VA = "0x1858AE950", Slot = "5")]
		public a Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public MTXCBCMWFMV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class TLNQEGLWGDX : OXTXAOMJJRM<IEnumerable>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly OXTXAOMJJRM<IEnumerable> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1E30", Offset = "0x8FB1030", VA = "0x188FB1E30", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8FB1C20", Offset = "0x8FB0E20", VA = "0x188FB1C20", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public TLNQEGLWGDX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class HBYMRJJSOAP : OXTXAOMJJRM<ICollection>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly OXTXAOMJJRM<ICollection> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2BF0", Offset = "0x8FA1DF0", VA = "0x188FA2BF0", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8FA29E0", Offset = "0x8FA1BE0", VA = "0x188FA29E0", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public HBYMRJJSOAP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class JIUDGFQFAGT : OXTXAOMJJRM<IList>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly OXTXAOMJJRM<IList> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6AC0", Offset = "0x8FA5CC0", VA = "0x188FA6AC0", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8FA68B0", Offset = "0x8FA5AB0", VA = "0x188FA68B0", Slot = "5")]
		public IList Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public JIUDGFQFAGT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class YBJYHAJJIRM<a> : XTLCMJQZXBL<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3E73670", Offset = "0x3E72870", VA = "0x183E73670", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3E73760", Offset = "0x3E72960", VA = "0x183E73760", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class GGKMSIGUBBW<a> : XTFVPCXCNQC<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3E73670", Offset = "0x3E72870", VA = "0x183E73670", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3E73760", Offset = "0x3E72960", VA = "0x183E73760", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x4EB1280", Offset = "0x4EB0480", VA = "0x184EB1280", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class JHJEWKQCUYW<a> : XTFVPCXCNQC<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x4724A50", Offset = "0x4723C50", VA = "0x184724A50", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x4724BC0", Offset = "0x4723DC0", VA = "0x184724BC0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x50E86E0", Offset = "0x50E78E0", VA = "0x1850E86E0", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x50E87C0", Offset = "0x50E79C0", VA = "0x1850E87C0")]
		public JHJEWKQCUYW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class EZJBBXGVJFI<a> : XTFVPCXCNQC<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x4724A50", Offset = "0x4723C50", VA = "0x184724A50", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x4724BC0", Offset = "0x4723DC0", VA = "0x184724BC0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x4724B70", Offset = "0x4723D70", VA = "0x184724B70", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x4724BF0", Offset = "0x4723DF0", VA = "0x184724BF0")]
		public EZJBBXGVJFI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class WZPJIOEBAYC<a> : XTFVPCXCNQC<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x521B700", Offset = "0x521A900", VA = "0x18521B700", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xB19AC0", Offset = "0xB18CC0", VA = "0x180B19AC0", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3450", Offset = "0x5CC2650", VA = "0x185CC3450", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class ZLUEOGHCWKK<a> : XTLCMJQZXBL<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3E73670", Offset = "0x3E72870", VA = "0x183E73670", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3780", Offset = "0x3EE2980", VA = "0x183EE3780", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class WECOQHJJQYB<a> : XTLCMJQZXBL<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3E73670", Offset = "0x3E72870", VA = "0x183E73670", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3780", Offset = "0x3EE2980", VA = "0x183EE3780", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class NODLDWYAQMY<a> : XTFVPCXCNQC<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x4724A90", Offset = "0x4723C90", VA = "0x184724A90", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x4724BC0", Offset = "0x4723DC0", VA = "0x184724BC0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5969300", Offset = "0x5968500", VA = "0x185969300", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class RZDRYJKIEOR
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
		[Cpp2IlInjected.Address(RVA = "0x8FB04F0", Offset = "0x8FAF6F0", VA = "0x188FB04F0")]
		public static DateTime DMKDVBTUNKN(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0A50", Offset = "0x8FAFC50", VA = "0x188FB0A50")]
		public static bool TPKQJCPKHRK(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8FB05B0", Offset = "0x8FAF7B0", VA = "0x188FB05B0")]
		public static bool QJUBUNTSXMA(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0840", Offset = "0x8FAFA40", VA = "0x188FB0840")]
		public static bool QJUBUNTSXMA(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0C00", Offset = "0x8FAFE00", VA = "0x188FB0C00")]
		public static bool XIDNQTULZLA(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class OTOAOPRADFL : OXTXAOMJJRM<DateTime>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly OXTXAOMJJRM<DateTime> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8FACD60", Offset = "0x8FABF60", VA = "0x188FACD60", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8FACBE0", Offset = "0x8FABDE0", VA = "0x188FACBE0", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC7E0", Offset = "0x8FAB9E0", VA = "0x188FAC7E0")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public OTOAOPRADFL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class KNUSHQSIWXK : OXTXAOMJJRM<DateTimeOffset>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly OXTXAOMJJRM<DateTimeOffset> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7720", Offset = "0x8FA6920", VA = "0x188FA7720", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA72D0", Offset = "0x8FA64D0", VA = "0x188FA72D0", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7340", Offset = "0x8FA6540", VA = "0x188FA7340")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public KNUSHQSIWXK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class RIBOVHHYXXP : OXTXAOMJJRM<TimeSpan>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly OXTXAOMJJRM<TimeSpan> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] ZVJLCURYLTH;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8FAFA80", Offset = "0x8FAEC80", VA = "0x188FAFA80", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8FAFA00", Offset = "0x8FAEC00", VA = "0x188FAFA00", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF610", Offset = "0x8FAE810", VA = "0x188FAF610")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public RIBOVHHYXXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class ZMRJCIUJZRG<a, b, c, d, e> : OXTXAOMJJRM<e>, DTZLAYDSJYZ where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB2A0", Offset = "0x3EEA4A0", VA = "0x183EEB2A0", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3EE5BF0", Offset = "0x3EE4DF0", VA = "0x183EE5BF0", Slot = "5")]
		public e Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d QGJLIMSEHOP(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		protected ZMRJCIUJZRG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class ZMWPZPOHJCP<a, b, c, d> : ZMRJCIUJZRG<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3E6CEB0", Offset = "0x3E6C0B0", VA = "0x183E6CEB0", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> QGJLIMSEHOP(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		protected ZMWPZPOHJCP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class ZMGVHVGPGUO<a, b, c> : ZMWPZPOHJCP<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xB19AC0", Offset = "0xB18CC0", VA = "0x180B19AC0", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class PJBQAOSRWIQ<a, b> : ZMRJCIUJZRG<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5BD0F10", Offset = "0x5BD0110", VA = "0x185BD0F10", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xB19AC0", Offset = "0xB18CC0", VA = "0x180B19AC0", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5BD1140", Offset = "0x5BD0340", VA = "0x185BD1140", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x5BD1370", Offset = "0x5BD0570", VA = "0x185BD1370", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator QGJLIMSEHOP(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x5407490", Offset = "0x5406690", VA = "0x185407490")]
		public PJBQAOSRWIQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class SRXBJHMMIAI<a, b, c> : ZMGVHVGPGUO<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5F80540", Offset = "0x5F7F740", VA = "0x185F80540", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5F80730", Offset = "0x5F7F930", VA = "0x185F80730", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class TZELAJKGUZP<a, b> : ZMWPZPOHJCP<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3EE37E0", Offset = "0x3EE29E0", VA = "0x183EE37E0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x4083A60", Offset = "0x4082C60", VA = "0x184083A60", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB19AC0", Offset = "0xB18CC0", VA = "0x180B19AC0", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class EKUSIAHTSMP<a, b> : ZMGVHVGPGUO<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3EE37E0", Offset = "0x3EE29E0", VA = "0x183EE37E0", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x4083A60", Offset = "0x4082C60", VA = "0x184083A60", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class HFPNTPGNLMH<a, b> : ZMRJCIUJZRG<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3EE37E0", Offset = "0x3EE29E0", VA = "0x183EE37E0", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB19AC0", Offset = "0xB18CC0", VA = "0x180B19AC0", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x4083A60", Offset = "0x4082C60", VA = "0x184083A60", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x4F11040", Offset = "0x4F10240", VA = "0x184F11040", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator QGJLIMSEHOP(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class ZMEWIVAPOVU<a, b> : ZMWPZPOHJCP<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3EE37E0", Offset = "0x3EE29E0", VA = "0x183EE37E0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3960", Offset = "0x3EE2B60", VA = "0x183EE3960", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3EE39D0", Offset = "0x3EE2BD0", VA = "0x183EE39D0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class JYLQECENUOL<a, b> : ZMWPZPOHJCP<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x50F1850", Offset = "0x50F0A50", VA = "0x1850F1850", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xB19AC0", Offset = "0xB18CC0", VA = "0x180B19AC0", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x50F1890", Offset = "0x50F0A90", VA = "0x1850F1890", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x50F1950", Offset = "0x50F0B50", VA = "0x1850F1950")]
		public JYLQECENUOL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class DNRLVYUGDEL<a, b> : ZMGVHVGPGUO<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x40838E0", Offset = "0x4082AE0", VA = "0x1840838E0", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x4083A60", Offset = "0x4082C60", VA = "0x184083A60", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class ENXTCOMPUNL<a> : OXTXAOMJJRM<a>, DTZLAYDSJYZ where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x4720570", Offset = "0x471F770", VA = "0x184720570", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x4720340", Offset = "0x471F540", VA = "0x184720340", Slot = "5")]
		public a Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public ENXTCOMPUNL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class LBNUSJEUWPZ : OXTXAOMJJRM<IDictionary>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly OXTXAOMJJRM<IDictionary> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8400", Offset = "0x8FA7600", VA = "0x188FA8400", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8220", Offset = "0x8FA7420", VA = "0x188FA8220", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public LBNUSJEUWPZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class NBJMOINJHZT
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8FAB4A0", Offset = "0x8FAA6A0", VA = "0x188FAB4A0")]
		public static object PWAINYTEYJP(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8FAACC0", Offset = "0x8FA9EC0", VA = "0x188FAACC0")]
		public static object BECHIGRDEJG(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class QIELFAIOXFY<a> : OXTXAOMJJRM<a>, DTZLAYDSJYZ, XNVOSUNREOX<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class PLYECEGTBAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type DXWBJUFYHAY;

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PLYECEGTBAG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x5BD4190", Offset = "0x5BD3390", VA = "0x185BD4190")]
			internal bool CQCZMGTFAHL(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class PMDKZLAQKLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string HJVONERWFXY;

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PMDKZLAQKLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x5BD5AF0", Offset = "0x5BD4CF0", VA = "0x185BD5AF0")]
			internal bool CPXSOZZHQWC(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class PLNQHQSYIDO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> FOTTAGLSOCV;

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PLNQHQSYIDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x5BD25D0", Offset = "0x5BD17D0", VA = "0x185BD25D0")]
			internal void CPSLRTFKHKT(JsonWriter a, a b, ROQIDLVCAVJ c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class PLSXEXMVROX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> ZZXXOVQXGIQ;

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public PLSXEXMVROX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x5BD30A0", Offset = "0x5BD22A0", VA = "0x185BD30A0")]
			internal a CPNEUMLMXZK(JsonReader a, ROQIDLVCAVJ b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly DOBHUSIDDEJ<a> PETPGYFYLNM;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> YOYSVGTTXTG;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> XVCREWJCZVO;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> VDEQBKUAKVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool JFUVTCUGVZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> VAMUDPUWLZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> RRJAQHSMEGK;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5C9DD60", Offset = "0x5C9CF60", VA = "0x185C9DD60")]
		static QIELFAIOXFY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x5CA9330", Offset = "0x5CA8530", VA = "0x185CA9330")]
		public QIELFAIOXFY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x5C8F2E0", Offset = "0x5C8E4E0", VA = "0x185C8F2E0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C8C570", Offset = "0x5C8B770", VA = "0x185C8C570", Slot = "5")]
		public a Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5C8CE90", Offset = "0x5C8C090", VA = "0x185C8CE90", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, a b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5C88FB0", Offset = "0x5C881B0", VA = "0x185C88FB0", Slot = "7")]
		public a AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class ASZTITVVCES<a> : OXTXAOMJJRM<a[,]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x5599D00", Offset = "0x5598F00", VA = "0x185599D00", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5599960", Offset = "0x5598B60", VA = "0x185599960", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public ASZTITVVCES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class GURPRBYCRSQ<a> : OXTXAOMJJRM<a[,,]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x4EC1ED0", Offset = "0x4EC10D0", VA = "0x184EC1ED0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x4EC19E0", Offset = "0x4EC0BE0", VA = "0x184EC19E0", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public GURPRBYCRSQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class NTJAKZXRBUY<a> : OXTXAOMJJRM<a[,,,]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x5975950", Offset = "0x5974B50", VA = "0x185975950", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x5975340", Offset = "0x5974540", VA = "0x185975340", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public NTJAKZXRBUY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class AMXSVZIABUK<a> : OXTXAOMJJRM<a?>, DTZLAYDSJYZ where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5591E80", Offset = "0x5591080", VA = "0x185591E80", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x5591910", Offset = "0x5590B10", VA = "0x185591910", Slot = "5")]
		public a? Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public AMXSVZIABUK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class XLYUYNGVCTK<a> : OXTXAOMJJRM<a?>, DTZLAYDSJYZ where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly OXTXAOMJJRM<a> BDLBGLYAINB;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		public XLYUYNGVCTK(OXTXAOMJJRM<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x3E64980", Offset = "0x3E63B80", VA = "0x183E64980", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x3E64450", Offset = "0x3E63650", VA = "0x183E64450", Slot = "5")]
		public a? Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class ONPIBHUEURB : OXTXAOMJJRM<sbyte>, DTZLAYDSJYZ, XNVOSUNREOX<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly ONPIBHUEURB XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC300", Offset = "0x8FAB500", VA = "0x188FAC300", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC1E0", Offset = "0x8FAB3E0", VA = "0x188FAC1E0", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC1F0", Offset = "0x8FAB3F0", VA = "0x188FAC1F0", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, sbyte b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC160", Offset = "0x8FAB360", VA = "0x188FAC160", Slot = "7")]
		public sbyte AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public ONPIBHUEURB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class UBACTEAHQGO : OXTXAOMJJRM<sbyte?>, DTZLAYDSJYZ, XNVOSUNREOX<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly UBACTEAHQGO XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4AB0", Offset = "0x8FB3CB0", VA = "0x188FB4AB0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8FB48E0", Offset = "0x8FB3AE0", VA = "0x188FB48E0", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4950", Offset = "0x8FB3B50", VA = "0x188FB4950", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, sbyte? b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4810", Offset = "0x8FB3A10", VA = "0x188FB4810", Slot = "7")]
		public sbyte? AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public UBACTEAHQGO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class ONYNYZVKFAO : OXTXAOMJJRM<sbyte[]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly ONYNYZVKFAO XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC540", Offset = "0x8FAB740", VA = "0x188FAC540", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8FAC400", Offset = "0x8FAB600", VA = "0x188FAC400", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public ONYNYZVKFAO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class YHCOTXHXIBG : OXTXAOMJJRM<short>, DTZLAYDSJYZ, XNVOSUNREOX<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly YHCOTXHXIBG XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8FB87D0", Offset = "0x8FB79D0", VA = "0x188FB87D0", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8FB86B0", Offset = "0x8FB78B0", VA = "0x188FB86B0", Slot = "5")]
		public short Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8FB86C0", Offset = "0x8FB78C0", VA = "0x188FB86C0", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, short b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8630", Offset = "0x8FB7830", VA = "0x188FB8630", Slot = "7")]
		public short AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public YHCOTXHXIBG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class AWUPSAQMJJH : OXTXAOMJJRM<short?>, DTZLAYDSJYZ, XNVOSUNREOX<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly AWUPSAQMJJH XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FA90", Offset = "0x8F9EC90", VA = "0x188F9FA90", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F8C0", Offset = "0x8F9EAC0", VA = "0x188F9F8C0", Slot = "5")]
		public short? Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F930", Offset = "0x8F9EB30", VA = "0x188F9F930", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, short? b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F7F0", Offset = "0x8F9E9F0", VA = "0x188F9F7F0", Slot = "7")]
		public short? AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public AWUPSAQMJJH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class CEBWPAPJYLV : OXTXAOMJJRM<short[]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly CEBWPAPJYLV XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0280", Offset = "0x8F9F480", VA = "0x188FA0280", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0140", Offset = "0x8F9F340", VA = "0x188FA0140", Slot = "5")]
		public short[] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public CEBWPAPJYLV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class JFTCTLFHWHQ : OXTXAOMJJRM<int>, DTZLAYDSJYZ, XNVOSUNREOX<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly JFTCTLFHWHQ XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8FA67B0", Offset = "0x8FA59B0", VA = "0x188FA67B0", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6690", Offset = "0x8FA5890", VA = "0x188FA6690", Slot = "5")]
		public int Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8FA66A0", Offset = "0x8FA58A0", VA = "0x188FA66A0", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, int b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6610", Offset = "0x8FA5810", VA = "0x188FA6610", Slot = "7")]
		public int AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public JFTCTLFHWHQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class JMAVBOMJAMX : OXTXAOMJJRM<int?>, DTZLAYDSJYZ, XNVOSUNREOX<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly JMAVBOMJAMX XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7170", Offset = "0x8FA6370", VA = "0x188FA7170", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6FA0", Offset = "0x8FA61A0", VA = "0x188FA6FA0", Slot = "5")]
		public int? Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8FA7010", Offset = "0x8FA6210", VA = "0x188FA7010", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, int? b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6ED0", Offset = "0x8FA60D0", VA = "0x188FA6ED0", Slot = "7")]
		public int? AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public JMAVBOMJAMX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class UQZOVRPUPHL : OXTXAOMJJRM<int[]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly UQZOVRPUPHL XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7250", Offset = "0x8FB6450", VA = "0x188FB7250", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7110", Offset = "0x8FB6310", VA = "0x188FB7110", Slot = "5")]
		public int[] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public UQZOVRPUPHL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class XKPHJRHIDOD : OXTXAOMJJRM<long>, DTZLAYDSJYZ, XNVOSUNREOX<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly XKPHJRHIDOD XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7CA0", Offset = "0x8FB6EA0", VA = "0x188FB7CA0", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7BC0", Offset = "0x8FB6DC0", VA = "0x188FB7BC0", Slot = "5")]
		public long Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7BD0", Offset = "0x8FB6DD0", VA = "0x188FB7BD0", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, long b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7B80", Offset = "0x8FB6D80", VA = "0x188FB7B80", Slot = "7")]
		public long AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public XKPHJRHIDOD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class ZOJWUQTCZVA : OXTXAOMJJRM<long?>, DTZLAYDSJYZ, XNVOSUNREOX<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly ZOJWUQTCZVA XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8ED0", Offset = "0x8FB80D0", VA = "0x188FB8ED0", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8D10", Offset = "0x8FB7F10", VA = "0x188FB8D10", Slot = "5")]
		public long? Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8DA0", Offset = "0x8FB7FA0", VA = "0x188FB8DA0", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, long? b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8C60", Offset = "0x8FB7E60", VA = "0x188FB8C60", Slot = "7")]
		public long? AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public ZOJWUQTCZVA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class UELPITIRGJY : OXTXAOMJJRM<long[]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly UELPITIRGJY XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4D50", Offset = "0x8FB3F50", VA = "0x188FB4D50", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4C10", Offset = "0x8FB3E10", VA = "0x188FB4C10", Slot = "5")]
		public long[] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public UELPITIRGJY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class ZVKROSUGTTG : OXTXAOMJJRM<byte>, DTZLAYDSJYZ, XNVOSUNREOX<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly ZVKROSUGTTG XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8FB94A0", Offset = "0x8FB86A0", VA = "0x188FB94A0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9380", Offset = "0x8FB8580", VA = "0x188FB9380", Slot = "5")]
		public byte Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9390", Offset = "0x8FB8590", VA = "0x188FB9390", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, byte b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9300", Offset = "0x8FB8500", VA = "0x188FB9300", Slot = "7")]
		public byte AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public ZVKROSUGTTG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class XSQUWXABSXZ : OXTXAOMJJRM<byte?>, DTZLAYDSJYZ, XNVOSUNREOX<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly XSQUWXABSXZ XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8010", Offset = "0x8FB7210", VA = "0x188FB8010", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7E40", Offset = "0x8FB7040", VA = "0x188FB7E40", Slot = "5")]
		public byte? Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7EB0", Offset = "0x8FB70B0", VA = "0x188FB7EB0", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, byte? b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7D70", Offset = "0x8FB6F70", VA = "0x188FB7D70", Slot = "7")]
		public byte? AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public XSQUWXABSXZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class CGBOJJVMIYX : OXTXAOMJJRM<ushort>, DTZLAYDSJYZ, XNVOSUNREOX<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly CGBOJJVMIYX XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA06C0", Offset = "0x8F9F8C0", VA = "0x188FA06C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA05A0", Offset = "0x8F9F7A0", VA = "0x188FA05A0", Slot = "5")]
		public ushort Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8FA05B0", Offset = "0x8F9F7B0", VA = "0x188FA05B0", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, ushort b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0520", Offset = "0x8F9F720", VA = "0x188FA0520", Slot = "7")]
		public ushort AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public CGBOJJVMIYX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class AZSAFOHRKLC : OXTXAOMJJRM<ushort?>, DTZLAYDSJYZ, XNVOSUNREOX<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly AZSAFOHRKLC XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FE90", Offset = "0x8F9F090", VA = "0x188F9FE90", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FCC0", Offset = "0x8F9EEC0", VA = "0x188F9FCC0", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FD30", Offset = "0x8F9EF30", VA = "0x188F9FD30", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, ushort? b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FBF0", Offset = "0x8F9EDF0", VA = "0x188F9FBF0", Slot = "7")]
		public ushort? AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public AZSAFOHRKLC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class MYIWFTCBJYK : OXTXAOMJJRM<ushort[]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly MYIWFTCBJYK XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA7F0", Offset = "0x8FA99F0", VA = "0x188FAA7F0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8FAA6B0", Offset = "0x8FA98B0", VA = "0x188FAA6B0", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public MYIWFTCBJYK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class RCYQLWGIFOV : OXTXAOMJJRM<uint>, DTZLAYDSJYZ, XNVOSUNREOX<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly RCYQLWGIFOV XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF510", Offset = "0x8FAE710", VA = "0x188FAF510", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF3F0", Offset = "0x8FAE5F0", VA = "0x188FAF3F0", Slot = "5")]
		public uint Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF400", Offset = "0x8FAE600", VA = "0x188FAF400", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, uint b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8FAF370", Offset = "0x8FAE570", VA = "0x188FAF370", Slot = "7")]
		public uint AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public RCYQLWGIFOV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class TXOWGWBWPHM : OXTXAOMJJRM<uint?>, DTZLAYDSJYZ, XNVOSUNREOX<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly TXOWGWBWPHM XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3F20", Offset = "0x8FB3120", VA = "0x188FB3F20", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3D50", Offset = "0x8FB2F50", VA = "0x188FB3D50", Slot = "5")]
		public uint? Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3DC0", Offset = "0x8FB2FC0", VA = "0x188FB3DC0", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, uint? b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8FB3C80", Offset = "0x8FB2E80", VA = "0x188FB3C80", Slot = "7")]
		public uint? AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public TXOWGWBWPHM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class ABGZIGOJGHK : OXTXAOMJJRM<uint[]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly ABGZIGOJGHK XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F360", Offset = "0x8F9E560", VA = "0x188F9F360", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F220", Offset = "0x8F9E420", VA = "0x188F9F220", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public ABGZIGOJGHK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class JCJUODJMPSA : OXTXAOMJJRM<ulong>, DTZLAYDSJYZ, XNVOSUNREOX<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly JCJUODJMPSA XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6540", Offset = "0x8FA5740", VA = "0x188FA6540", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6460", Offset = "0x8FA5660", VA = "0x188FA6460", Slot = "5")]
		public ulong Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6470", Offset = "0x8FA5670", VA = "0x188FA6470", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, ulong b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8FA6420", Offset = "0x8FA5620", VA = "0x188FA6420", Slot = "7")]
		public ulong AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public JCJUODJMPSA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class CUAIJZYPMIL : OXTXAOMJJRM<ulong?>, DTZLAYDSJYZ, XNVOSUNREOX<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly CUAIJZYPMIL XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0C20", Offset = "0x8F9FE20", VA = "0x188FA0C20", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0A60", Offset = "0x8F9FC60", VA = "0x188FA0A60", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0AF0", Offset = "0x8F9FCF0", VA = "0x188FA0AF0", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, ulong? b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8FA09B0", Offset = "0x8F9FBB0", VA = "0x188FA09B0", Slot = "7")]
		public ulong? AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public CUAIJZYPMIL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class EEEPFEMBFPB : OXTXAOMJJRM<ulong[]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly EEEPFEMBFPB XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1E50", Offset = "0x8FA1050", VA = "0x188FA1E50", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8FA1D10", Offset = "0x8FA0F10", VA = "0x188FA1D10", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public EEEPFEMBFPB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class YTPSNVIRVJI : OXTXAOMJJRM<float>, DTZLAYDSJYZ, XNVOSUNREOX<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly YTPSNVIRVJI XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB89F0", Offset = "0x8FB7BF0", VA = "0x188FB89F0", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8910", Offset = "0x8FB7B10", VA = "0x188FB8910", Slot = "5")]
		public float Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8920", Offset = "0x8FB7B20", VA = "0x188FB8920", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, float b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x8FB88D0", Offset = "0x8FB7AD0", VA = "0x188FB88D0", Slot = "7")]
		public float AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public YTPSNVIRVJI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class HHFHOVTJOOB : OXTXAOMJJRM<float?>, DTZLAYDSJYZ, XNVOSUNREOX<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly HHFHOVTJOOB XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3470", Offset = "0x8FA2670", VA = "0x188FA3470", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8FA32E0", Offset = "0x8FA24E0", VA = "0x188FA32E0", Slot = "5")]
		public float? Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3350", Offset = "0x8FA2550", VA = "0x188FA3350", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, float? b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8FA3240", Offset = "0x8FA2440", VA = "0x188FA3240", Slot = "7")]
		public float? AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public HHFHOVTJOOB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class QGZVQNTMPHT : OXTXAOMJJRM<float[]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly QGZVQNTMPHT XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8FADF20", Offset = "0x8FAD120", VA = "0x188FADF20", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8FADDE0", Offset = "0x8FACFE0", VA = "0x188FADDE0", Slot = "5")]
		public float[] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public QGZVQNTMPHT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class PTOMNXVYBGZ : OXTXAOMJJRM<double>, DTZLAYDSJYZ, XNVOSUNREOX<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly PTOMNXVYBGZ XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8FADD10", Offset = "0x8FACF10", VA = "0x188FADD10", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8FADC30", Offset = "0x8FACE30", VA = "0x188FADC30", Slot = "5")]
		public double Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8FADC40", Offset = "0x8FACE40", VA = "0x188FADC40", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, double b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8FADBF0", Offset = "0x8FACDF0", VA = "0x188FADBF0", Slot = "7")]
		public double AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public PTOMNXVYBGZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class FYJSVEFQUGG : OXTXAOMJJRM<double?>, DTZLAYDSJYZ, XNVOSUNREOX<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly FYJSVEFQUGG XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8FA22F0", Offset = "0x8FA14F0", VA = "0x188FA22F0", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2130", Offset = "0x8FA1330", VA = "0x188FA2130", Slot = "5")]
		public double? Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8FA21C0", Offset = "0x8FA13C0", VA = "0x188FA21C0", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, double? b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2080", Offset = "0x8FA1280", VA = "0x188FA2080", Slot = "7")]
		public double? AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public FYJSVEFQUGG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class YDTTQKBEGUM : OXTXAOMJJRM<double[]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly YDTTQKBEGUM XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8FB82B0", Offset = "0x8FB74B0", VA = "0x188FB82B0", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8170", Offset = "0x8FB7370", VA = "0x188FB8170", Slot = "5")]
		public double[] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public YDTTQKBEGUM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class CIGFFZCTIVU : OXTXAOMJJRM<bool>, DTZLAYDSJYZ, XNVOSUNREOX<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly CIGFFZCTIVU XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8FA08E0", Offset = "0x8F9FAE0", VA = "0x188FA08E0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0800", Offset = "0x8F9FA00", VA = "0x188FA0800", Slot = "5")]
		public bool Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0810", Offset = "0x8F9FA10", VA = "0x188FA0810", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, bool b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8FA07C0", Offset = "0x8F9F9C0", VA = "0x188FA07C0", Slot = "7")]
		public bool AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public CIGFFZCTIVU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class RSNLCIQJFGH : OXTXAOMJJRM<bool?>, DTZLAYDSJYZ, XNVOSUNREOX<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly RSNLCIQJFGH XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8FB03C0", Offset = "0x8FAF5C0", VA = "0x188FB03C0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0230", Offset = "0x8FAF430", VA = "0x188FB0230", Slot = "5")]
		public bool? Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8FB02A0", Offset = "0x8FAF4A0", VA = "0x188FB02A0", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, bool? b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0190", Offset = "0x8FAF390", VA = "0x188FB0190", Slot = "7")]
		public bool? AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public RSNLCIQJFGH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class SAMWGMAVKYV : OXTXAOMJJRM<bool[]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly SAMWGMAVKYV XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0F60", Offset = "0x8FB0160", VA = "0x188FB0F60", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0E20", Offset = "0x8FB0020", VA = "0x188FB0E20", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public SAMWGMAVKYV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class ZDUUEKGKGSX : OXTXAOMJJRM<byte[]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly OXTXAOMJJRM<byte[]> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8B30", Offset = "0x8FB7D30", VA = "0x188FB8B30", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x8FB8AC0", Offset = "0x8FB7CC0", VA = "0x188FB8AC0", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public ZDUUEKGKGSX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class OUIUHCFUAWK : OXTXAOMJJRM<ArraySegment<byte>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly OXTXAOMJJRM<ArraySegment<byte>> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x8FADA50", Offset = "0x8FACC50", VA = "0x188FADA50", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD980", Offset = "0x8FACB80", VA = "0x188FAD980", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public OUIUHCFUAWK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class QKESXRSVXSK : OXTXAOMJJRM<string>, DTZLAYDSJYZ, XNVOSUNREOX<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly OXTXAOMJJRM<string> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE320", Offset = "0x8FAD520", VA = "0x188FAE320", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE2B0", Offset = "0x8FAD4B0", VA = "0x188FAE2B0", Slot = "5")]
		public string Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE2C0", Offset = "0x8FAD4C0", VA = "0x188FAE2C0", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, string b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE2B0", Offset = "0x8FAD4B0", VA = "0x188FAE2B0", Slot = "7")]
		public string AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public QKESXRSVXSK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class CXMWQRPDGJX : OXTXAOMJJRM<string[]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly CXMWQRPDGJX XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0EA0", Offset = "0x8FA00A0", VA = "0x188FA0EA0", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0D50", Offset = "0x8F9FF50", VA = "0x188FA0D50", Slot = "5")]
		public string[] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public CXMWQRPDGJX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class BTVVXQOXNQS : OXTXAOMJJRM<char>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly BTVVXQOXNQS XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8FA0020", Offset = "0x8F9F220", VA = "0x188FA0020", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8F9FFF0", Offset = "0x8F9F1F0", VA = "0x188F9FFF0", Slot = "5")]
		public char Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public BTVVXQOXNQS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class HVOMXUTDJOR : OXTXAOMJJRM<char?>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly HVOMXUTDJOR XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8FA47A0", Offset = "0x8FA39A0", VA = "0x188FA47A0", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x8FA46E0", Offset = "0x8FA38E0", VA = "0x188FA46E0", Slot = "5")]
		public char? Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public HVOMXUTDJOR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class WJSBWLECNGF : OXTXAOMJJRM<char[]>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly WJSBWLECNGF XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8FB78D0", Offset = "0x8FB6AD0", VA = "0x188FB78D0", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7740", Offset = "0x8FB6940", VA = "0x188FB7740", Slot = "5")]
		public char[] Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public WJSBWLECNGF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class GQLJVPOHYRX : OXTXAOMJJRM<Guid>, DTZLAYDSJYZ, XNVOSUNREOX<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly OXTXAOMJJRM<Guid> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2800", Offset = "0x8FA1A00", VA = "0x188FA2800", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2620", Offset = "0x8FA1820", VA = "0x188FA2620", Slot = "5")]
		public Guid Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2680", Offset = "0x8FA1880", VA = "0x188FA2680", Slot = "6")]
		public void SKZCSLJGNWV(JsonWriter a, Guid b, ROQIDLVCAVJ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8FA25B0", Offset = "0x8FA17B0", VA = "0x188FA25B0", Slot = "7")]
		public Guid AQVEUYZTIKB(JsonReader a, ROQIDLVCAVJ b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public GQLJVPOHYRX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class CZNHBSKZCKT : OXTXAOMJJRM<decimal>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly OXTXAOMJJRM<decimal> XTXDOOBWSYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool LYMOGGBGPAT;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x736DDF0", Offset = "0x736CFF0", VA = "0x18736DDF0")]
		public CZNHBSKZCKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xD9D680", Offset = "0xD9C880", VA = "0x180D9D680")]
		public CZNHBSKZCKT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8FA12A0", Offset = "0x8FA04A0", VA = "0x188FA12A0", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x8FA10D0", Offset = "0x8FA02D0", VA = "0x188FA10D0", Slot = "5")]
		public decimal Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class NUFIKVAFNUM : OXTXAOMJJRM<Uri>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly OXTXAOMJJRM<Uri> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8FABD00", Offset = "0x8FAAF00", VA = "0x188FABD00", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8FABC80", Offset = "0x8FAAE80", VA = "0x188FABC80", Slot = "5")]
		public Uri Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public NUFIKVAFNUM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class UXPPYLJYPOO : OXTXAOMJJRM<Version>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly OXTXAOMJJRM<Version> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8FB7570", Offset = "0x8FB6770", VA = "0x188FB7570", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x8FB74F0", Offset = "0x8FB66F0", VA = "0x188FB74F0", Slot = "5")]
		public Version Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public UXPPYLJYPOO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class IKDSIRAXUHG<a, b> : OXTXAOMJJRM<KeyValuePair<a, b>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x4FFEE10", Offset = "0x4FFE010", VA = "0x184FFEE10", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x4FFE920", Offset = "0x4FFDB20", VA = "0x184FFE920", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class GOCWDDNOXEK : OXTXAOMJJRM<StringBuilder>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly OXTXAOMJJRM<StringBuilder> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8FA24A0", Offset = "0x8FA16A0", VA = "0x188FA24A0", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8FA2420", Offset = "0x8FA1620", VA = "0x188FA2420", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public GOCWDDNOXEK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class OAQBBBCFBCC : OXTXAOMJJRM<BitArray>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly OXTXAOMJJRM<BitArray> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8FABF70", Offset = "0x8FAB170", VA = "0x188FABF70", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8FABE50", Offset = "0x8FAB050", VA = "0x188FABE50", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public OAQBBBCFBCC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class ZUTQYBVYPRM : OXTXAOMJJRM<Type>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly ZUTQYBVYPRM XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex AXEOTRSWBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool BGORRVRIRNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool NNUCOIHAVAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool GAUJHEAXIDT;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8FB92E0", Offset = "0x8FB84E0", VA = "0x188FB92E0")]
		public ZUTQYBVYPRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x82EDD10", Offset = "0x82ECF10", VA = "0x1882EDD10")]
		public ZUTQYBVYPRM(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9110", Offset = "0x8FB8310", VA = "0x188FB9110", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x8FB9000", Offset = "0x8FB8200", VA = "0x188FB9000", Slot = "5")]
		public Type Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class AMYYOBHKXOK : OXTXAOMJJRM<BigInteger>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly OXTXAOMJJRM<BigInteger> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F6B0", Offset = "0x8F9E8B0", VA = "0x188F9F6B0", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8F9F600", Offset = "0x8F9E800", VA = "0x188F9F600", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public AMYYOBHKXOK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class MYUQTIWIQQW : OXTXAOMJJRM<Complex>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly OXTXAOMJJRM<Complex> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8FAAB20", Offset = "0x8FA9D20", VA = "0x188FAAB20", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8FAAA90", Offset = "0x8FA9C90", VA = "0x188FAAA90", Slot = "5")]
		public Complex Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public MYUQTIWIQQW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class LMNUSHTTNOY : OXTXAOMJJRM<ExpandoObject>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly OXTXAOMJJRM<ExpandoObject> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8C80", Offset = "0x8FA7E80", VA = "0x188FA8C80", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8FA8A50", Offset = "0x8FA7C50", VA = "0x188FA8A50", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public LMNUSHTTNOY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class HFQNNSQOTWL<a> : OXTXAOMJJRM<Lazy<a>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x4F112C0", Offset = "0x4F104C0", VA = "0x184F112C0", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x4F110B0", Offset = "0x4F102B0", VA = "0x184F110B0", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class SCDGZHVDIWL : OXTXAOMJJRM<Task>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly OXTXAOMJJRM<Task> XTXDOOBWSYJ;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task CPOOPOGCKZK;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8FB13A0", Offset = "0x8FB05A0", VA = "0x188FB13A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8FB12F0", Offset = "0x8FB04F0", VA = "0x188FB12F0", Slot = "5")]
		public Task Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public SCDGZHVDIWL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class PYAUOOBJDAP<a> : OXTXAOMJJRM<Task<a>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x5C1AAE0", Offset = "0x5C19CE0", VA = "0x185C1AAE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x5C1A8F0", Offset = "0x5C19AF0", VA = "0x185C1A8F0", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class QXMIWITEYKJ<a> : OXTXAOMJJRM<ValueTask<a>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5CCD800", Offset = "0x5CCCA00", VA = "0x185CCD800", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5CCD5E0", Offset = "0x5CCC7E0", VA = "0x185CCD5E0", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class PAUAHBYGIUX<a> : OXTXAOMJJRM<Tuple<a>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD320", Offset = "0x5BCC520", VA = "0x185BCD320", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD030", Offset = "0x5BCC230", VA = "0x185BCD030", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class PAZHEISDSGG<a, b> : OXTXAOMJJRM<Tuple<a, b>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x5BCDB50", Offset = "0x5BCCD50", VA = "0x185BCDB50", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x5BCD700", Offset = "0x5BCC900", VA = "0x185BCD700", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class PBEOBPMBBRP<a, b, c> : OXTXAOMJJRM<Tuple<a, b, c>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE610", Offset = "0x5BCD810", VA = "0x185BCE610", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x5BCE090", Offset = "0x5BCD290", VA = "0x185BCE090", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class OZTRUUCTNQE<a, b, c, d> : OXTXAOMJJRM<Tuple<a, b, c, d>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x5B1AD50", Offset = "0x5B19F50", VA = "0x185B1AD50", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x5B1A670", Offset = "0x5B19870", VA = "0x185B1A670", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class OZYYSAWQXBN<a, b, c, d, e> : OXTXAOMJJRM<Tuple<a, b, c, d, e>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5B1C050", Offset = "0x5B1B250", VA = "0x185B1C050", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5B1B800", Offset = "0x5B1AA00", VA = "0x185B1B800", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class PAEFPHQOGMW<a, b, c, d, e, f> : OXTXAOMJJRM<Tuple<a, b, c, d, e, f>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5BCAD20", Offset = "0x5BC9F20", VA = "0x185BCAD20", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5BCA340", Offset = "0x5BC9540", VA = "0x185BCA340", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class PAJMMOKLPYF<a, b, c, d, e, f, g> : OXTXAOMJJRM<Tuple<a, b, c, d, e, f, g>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x5BCC3A0", Offset = "0x5BCB5A0", VA = "0x185BCC3A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x5BCB830", Offset = "0x5BCAA30", VA = "0x185BCB830", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class PCEWNXHNWWI<a, b, c, d, e, f, g, h> : OXTXAOMJJRM<Tuple<a, b, c, d, e, f, g, h>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x5BCF9A0", Offset = "0x5BCEBA0", VA = "0x185BCF9A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x5BCECC0", Offset = "0x5BCDEC0", VA = "0x185BCECC0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class LCVDWHNDEDY<a> : OXTXAOMJJRM<ValueTuple<a>>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x5372850", Offset = "0x5371A50", VA = "0x185372850", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x5372420", Offset = "0x5371620", VA = "0x185372420", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class LCPWZATFUSP<a, b> : OXTXAOMJJRM<(a, b)>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5371E80", Offset = "0x5371080", VA = "0x185371E80", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5371980", Offset = "0x5370B80", VA = "0x185371980", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class LCKQBTZILHG<a, b, c> : OXTXAOMJJRM<(a, b, c)>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x5371230", Offset = "0x5370430", VA = "0x185371230", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x5370B90", Offset = "0x536FD90", VA = "0x185370B90", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class LDVMIPIPZIR<a, b, c, d> : OXTXAOMJJRM<(a, b, c, d)>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x537A0D0", Offset = "0x53792D0", VA = "0x18537A0D0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x5379870", Offset = "0x5378A70", VA = "0x185379870", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class LDQFLIOSPXI<a, b, c, d, e> : OXTXAOMJJRM<(a, b, c, d, e)>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x5378D90", Offset = "0x5377F90", VA = "0x185378D90", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x5378390", Offset = "0x5377590", VA = "0x185378390", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class LDKYOBUVGLZ<a, b, c, d, e, f> : OXTXAOMJJRM<(a, b, c, d, e, f)>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5377700", Offset = "0x5376900", VA = "0x185377700", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5376AF0", Offset = "0x5375CF0", VA = "0x185376AF0", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class LDFRQVAXXAQ<a, b, c, d, e, f, g> : OXTXAOMJJRM<(a, b, c, d, e, f, g)>, DTZLAYDSJYZ
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x5375CA0", Offset = "0x5374EA0", VA = "0x185375CA0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x5374EE0", Offset = "0x53740E0", VA = "0x185374EE0", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class LBKHPMDVQCN<a, b, c, d, e, f, g, h> : OXTXAOMJJRM<ValueTuple<a, b, c, d, e, f, g, h>>, DTZLAYDSJYZ where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] SCAVBVDXUHY;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly DRWGAIIGMDI TVRDTTLJNPO;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x536F850", Offset = "0x536EA50", VA = "0x18536F850", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, ROQIDLVCAVJ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x536E8D0", Offset = "0x536DAD0", VA = "0x18536E8D0", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, ROQIDLVCAVJ formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class SQWBMEIKXVE
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] FYPGQRLPXOC;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly DRWGAIIGMDI QVGDQADEVTR;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8FB14E0", Offset = "0x8FB06E0", VA = "0x188FB14E0")]
		static SQWBMEIKXVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class HEOFKVRCISU
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] VZRFTMVNAPJ;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly DRWGAIIGMDI FCGQLEISNRE;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x8FA30A0", Offset = "0x8FA22A0", VA = "0x188FA30A0")]
		static HEOFKVRCISU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class QPSBVYLQHVW
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] LNOTQYJLUMO;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly DRWGAIIGMDI OUUSDOCRIYL;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] LNJMTRPOLBF;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly DRWGAIIGMDI OUZZAUWOSJU;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] LNEFWKVRBPW;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly DRWGAIIGMDI OVFFYBQMBVD;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] LOPCDGEYPRH;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly DRWGAIIGMDI OVKMVIKJLGM;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] LOJVFZLBGFY;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly DRWGAIIGMDI OVPTSPEGURV;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] LOEOISRDWUP;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly DRWGAIIGMDI OVVAPVYEEDE;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] LNZHLLXGNJG;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly DRWGAIIGMDI OWAHNCSBNON;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] LMDXKDAEGLD;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly DRWGAIIGMDI OWFOKJLYWZW;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE3F0", Offset = "0x8FAD5F0", VA = "0x188FAE3F0")]
		static QPSBVYLQHVW()
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
