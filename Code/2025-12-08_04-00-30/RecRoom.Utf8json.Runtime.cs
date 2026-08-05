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
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, KIVYKHMZUOQ resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, KIVYKHMZUOQ resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface AZVSJTUQPQS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface DIBGAVKLOIB<a> : AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, KIVYKHMZUOQ formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface UTAUQVHKHHS<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UFQCICPOHWU(JsonWriter a, a b, KIVYKHMZUOQ c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b);
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
	public static class MGUKJECSNDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x37737D0", Offset = "0x3771FD0", VA = "0x1837737D0")]
		public static string ToJsonString<T>(this DIBGAVKLOIB<T> formatter, T value, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		DIBGAVKLOIB<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class TPAUSZDIOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3A6AEA0", Offset = "0x3A696A0", VA = "0x183A6AEA0")]
		public static DIBGAVKLOIB<a> BRDUOJSIBOI<a>(this KIVYKHMZUOQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8D9FFF0", Offset = "0x8D9E7F0", VA = "0x188D9FFF0")]
		public static object GNHHCSJXKHA(this KIVYKHMZUOQ a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8D91690", Offset = "0x8D8FE90", VA = "0x188D91690")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class EBCTTILAPGE
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] QRJHQDOHDJJ;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] OQHXFMVXILE;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] WFMTLTJBNKL;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] IJVDPIDOKUK;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] RJPMSGTIQTL;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] TRSXJXYJQSM;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] QKNMPOVFESG;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] MWCGDRPLKJR;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class HJHYUUJCUHN : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x8D93DB0", Offset = "0x8D925B0", VA = "0x188D93DB0")]
				public HJHYUUJCUHN(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x8D93C90", Offset = "0x8D92490", VA = "0x188D93C90")]
				public HJHYUUJCUHN EYJHJEGADCD(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class QGTUSCHLBUI
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] OXZAQMYQHWR;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] FCBCMNFFMES;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private HJHYUUJCUHN start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private HJHYUUJCUHN end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8D9FB40", Offset = "0x8D9E340", VA = "0x188D9FB40")]
			public void EYJHJEGADCD([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8D9FA00", Offset = "0x8D9E200", VA = "0x188D9FA00")]
			public void EYJHJEGADCD(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8D9F8D0", Offset = "0x8D9E0D0", VA = "0x188D9F8D0")]
			public ReadOnlySequence<byte> CDRNPHFZKTO()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8D9FC50", Offset = "0x8D9E450", VA = "0x188D9FC50")]
			private void QKNOMTDCXUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8D9FE00", Offset = "0x8D9E600", VA = "0x188D9FE00")]
			private void WEBFTXISVOC([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8D98BD0", Offset = "0x8D973D0", VA = "0x188D98BD0")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8D983E0", Offset = "0x8D96BE0", VA = "0x188D983E0")]
		private JsonParsingException XPMPTZQIMHM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D970A0", Offset = "0x8D958A0", VA = "0x188D970A0")]
		private JsonParsingException QUQKISWCHFL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8D96C20", Offset = "0x8D95420", VA = "0x188D96C20")]
		public JsonToken ORPKWIJDFLP()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8D95F10", Offset = "0x8D94710", VA = "0x188D95F10")]
		public void FXXANDUCGCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8D971B0", Offset = "0x8D959B0", VA = "0x188D971B0")]
		private bool RCZOURQYEWP(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8D97210", Offset = "0x8D95A10", VA = "0x188D97210")]
		private bool RCZOURQYEWP(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8D97580", Offset = "0x8D95D80", VA = "0x188D97580")]
		private void RNQVSPPVAJM(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8D96750", Offset = "0x8D94F50", VA = "0x188D96750")]
		public bool MMKKUQQUAOS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8D989B0", Offset = "0x8D971B0", VA = "0x188D989B0")]
		public void YDYUTUXOPUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8D96380", Offset = "0x8D94B80", VA = "0x188D96380")]
		public bool JCJJZIWISUV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8D963D0", Offset = "0x8D94BD0", VA = "0x188D963D0")]
		public void JXRQWAIAXQU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8D95A10", Offset = "0x8D94210", VA = "0x188D95A10")]
		public void AXDBPLEJYSS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8D95D80", Offset = "0x8D94580", VA = "0x188D95D80")]
		public bool DSLEMAVWNED()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8D983D0", Offset = "0x8D96BD0", VA = "0x188D983D0")]
		public void XAVMFFLPFHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8D96740", Offset = "0x8D94F40", VA = "0x188D96740")]
		public void MEEOZOSQRDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8D977F0", Offset = "0x8D95FF0", VA = "0x188D977F0")]
		public bool UFGCXIFUZUW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8D95B00", Offset = "0x8D94300", VA = "0x188D95B00")]
		public bool DINDNFCSAKI(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D96810", Offset = "0x8D95010", VA = "0x188D96810")]
		public bool MWIHLCEBDFJ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8D97A70", Offset = "0x8D96270", VA = "0x188D97A70")]
		private ReadOnlySequence<byte> WGADPTGYZCQ()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8D96E30", Offset = "0x8D95630", VA = "0x188D96E30")]
		private ReadOnlySequence<byte> PMGOMAVVFYT()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8D97880", Offset = "0x8D96080", VA = "0x188D97880")]
		private void UILFMZUNRKL(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8D963E0", Offset = "0x8D94BE0", VA = "0x188D963E0")]
		private void KHDANJNRZFM(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8D968F0", Offset = "0x8D950F0", VA = "0x188D968F0")]
		private void OMDXQDXHLWR(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8D97630", Offset = "0x8D95E30", VA = "0x188D97630")]
		private void RQKBHSNKLOE(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8D8D810", Offset = "0x8D8C010", VA = "0x188D8D810")]
		private static int SNOPCACEUMD(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D95DD0", Offset = "0x8D945D0", VA = "0x188D95DD0")]
		public ReadOnlySequence<byte> EHMXPECJVYF()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D982A0", Offset = "0x8D96AA0", VA = "0x188D982A0")]
		public string WPIQFNJPLYO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8D96BE0", Offset = "0x8D953E0", VA = "0x188D96BE0")]
		public string OPTTNMOZHZH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8D988E0", Offset = "0x8D970E0", VA = "0x188D988E0")]
		public ReadOnlySequence<byte> XWUSHTDCREX()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8D95A20", Offset = "0x8D94220", VA = "0x188D95A20")]
		public ReadOnlySequence<byte> BSWREIOVSEI()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8D95C30", Offset = "0x8D94430", VA = "0x188D95C30")]
		public bool DQPPZTXZPRH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8D97F50", Offset = "0x8D96750", VA = "0x188D97F50")]
		private void WLUGVXQIBEN(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8D97740", Offset = "0x8D95F40", VA = "0x188D97740")]
		public void SCUBDUFOFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8D96140", Offset = "0x8D94940", VA = "0x188D96140")]
		private void HVEHFPBJVGA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8D98B20", Offset = "0x8D97320", VA = "0x188D98B20")]
		public sbyte ZNEOOUTGEBM()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8D98320", Offset = "0x8D96B20", VA = "0x188D98320")]
		public short WPVJYOXIPFJ()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8D965E0", Offset = "0x8D94DE0", VA = "0x188D965E0")]
		public int KKRHFRAUEQZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8D95EA0", Offset = "0x8D946A0", VA = "0x188D95EA0")]
		public long ENDLIZNWGUK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8D989C0", Offset = "0x8D971C0", VA = "0x188D989C0")]
		public byte ZHRRQYZLOCB()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8D98A70", Offset = "0x8D97270", VA = "0x188D98A70")]
		public ushort ZIISGIMBRLC()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8D96690", Offset = "0x8D94E90", VA = "0x188D96690")]
		public uint LNMUZGIQBZM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8D97510", Offset = "0x8D95D10", VA = "0x188D97510")]
		public ulong RLVSKYXDLPL()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8D97750", Offset = "0x8D95F50", VA = "0x188D97750")]
		public float TUKFSJYQWAX()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8D95B90", Offset = "0x8D94390", VA = "0x188D95B90")]
		public double DMFDPWEIUEC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8D980C0", Offset = "0x8D968C0", VA = "0x188D980C0")]
		public ReadOnlySequence<byte> WNEKIHOCCRN()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8D97270", Offset = "0x8D95A70", VA = "0x188D97270")]
		private void REAMFYWHZZX()
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
			[Cpp2IlInjected.Address(RVA = "0xCDDAD0", Offset = "0xCDC2D0", VA = "0x180CDDAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8D959B0", Offset = "0x8D941B0", VA = "0x188D959B0")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8D95930", Offset = "0x8D94130", VA = "0x188D95930")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class CGGKNSPJXFH
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class CKWMPNPIWJA
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] OXZAQMYQHWR;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8D8E360", Offset = "0x8D8CB60", VA = "0x188D8E360")]
			public static byte[] UJNOMWXTRTZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static KIVYKHMZUOQ MDDEVFCVUOC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] XCCLDTKDUIZ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] YDUUQPWZQDT;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static KIVYKHMZUOQ FNRSRQKASJU
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8D8E0F0", Offset = "0x8D8C8F0", VA = "0x188D8E0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E080", Offset = "0x8D8C880", VA = "0x188D8E080")]
		public static void SRYJHIXVSDC(KIVYKHMZUOQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3456430", Offset = "0x3454C30", VA = "0x183456430")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x34564A0", Offset = "0x3454CA0", VA = "0x1834564A0")]
		public static byte[] Serialize<T>(T value, KIVYKHMZUOQ resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3456A10", Offset = "0x3455210", VA = "0x183456A10")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3456A90", Offset = "0x3455290", VA = "0x183456A90")]
		public static string ToJsonString<T>(T value, KIVYKHMZUOQ resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3455F30", Offset = "0x3454730", VA = "0x183455F30")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3455C60", Offset = "0x3454460", VA = "0x183455C60")]
		public static T Deserialize<T>(string json, KIVYKHMZUOQ resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3455DE0", Offset = "0x34545E0", VA = "0x183455DE0")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3455B90", Offset = "0x3454390", VA = "0x183455B90")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, KIVYKHMZUOQ resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x34553D0", Offset = "0x3453BD0", VA = "0x1834553D0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x34555E0", Offset = "0x3453DE0", VA = "0x1834555E0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, KIVYKHMZUOQ resolver)
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
		public int CNJXTOVQZVR
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xC9D230", Offset = "0xC9BA30", VA = "0x180C9D230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8D99310", Offset = "0x8D97B10", VA = "0x188D99310")]
		public void RDJZODXJRLO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8D98F90", Offset = "0x8D97790", VA = "0x188D98F90")]
		public static byte[] ISZEYZDCVXN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8D991D0", Offset = "0x8D979D0", VA = "0x188D991D0")]
		public static byte[] ODYEHCDECGD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8D99C50", Offset = "0x8D98450", VA = "0x188D99C50")]
		public static byte[] VHZUBOECZLF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8D99320", Offset = "0x8D97B20", VA = "0x188D99320")]
		public static byte[] ROMHQOIGKDD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x27F76B0", Offset = "0x27F5EB0", VA = "0x1827F76B0")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8D99BB0", Offset = "0x8D983B0", VA = "0x188D99BB0")]
		public ArraySegment<byte> UJNOMWXTRTZ()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8D99D70", Offset = "0x8D98570", VA = "0x188D99D70")]
		public byte[] WICVOTYTNRS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8D99B50", Offset = "0x8D98350", VA = "0x188D99B50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8D98F30", Offset = "0x8D97730", VA = "0x188D98F30")]
		public void HFYRASWLYEF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8D98D40", Offset = "0x8D97540", VA = "0x188D98D40")]
		public void AXKGFYWJEJO(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8D994A0", Offset = "0x8D97CA0", VA = "0x188D994A0")]
		public void RQSUAZRGYQO(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3DC21B0", Offset = "0x3DC09B0", VA = "0x183DC21B0")]
		public void DWKTPVNPLGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2390", Offset = "0x3DC0B90", VA = "0x183DC2390")]
		public void TPKFVYCNGUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8D98F40", Offset = "0x8D97740", VA = "0x188D98F40")]
		public void HWTPEZCNYKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3DC22A0", Offset = "0x3DC0AA0", VA = "0x183DC22A0")]
		public void FQPGLCPDFXG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3DC2340", Offset = "0x3DC0B40", VA = "0x183DC2340")]
		public void PRCXZDYOTPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC22F0", Offset = "0x3DC0AF0", VA = "0x183DC22F0")]
		public void FWDKSCKFXYI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8D98DF0", Offset = "0x8D975F0", VA = "0x188D98DF0")]
		public void FJLGKRSCDGA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8D98DA0", Offset = "0x8D975A0", VA = "0x188D98DA0")]
		public void EPWKATHXGMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3DC23E0", Offset = "0x3DC0BE0", VA = "0x183DC23E0")]
		public void YLCSHMKZWYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x76A0630", Offset = "0x769EE30", VA = "0x1876A0630")]
		public void HGZNEVUYFXE(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8D99150", Offset = "0x8D97950", VA = "0x188D99150")]
		public void NGXORFQDREK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D99550", Offset = "0x8D97D50", VA = "0x188D99550")]
		public void SKLFIURFVBF(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8D99F00", Offset = "0x8D98700", VA = "0x188D99F00")]
		public void XAADUUTADMY(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8D9A020", Offset = "0x8D98820", VA = "0x188D9A020")]
		public void ZSWZKXZWMFT(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8D990E0", Offset = "0x8D978E0", VA = "0x188D990E0")]
		public void MWIXNBSGLDR(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8D98F00", Offset = "0x8D97700", VA = "0x188D98F00")]
		public void GRNNLAQZLOQ(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8D99070", Offset = "0x8D97870", VA = "0x188D99070")]
		public void MJLDAPWUGPP(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8D98E90", Offset = "0x8D97690", VA = "0x188D98E90")]
		public void FXJSADTBOPG(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8D994E0", Offset = "0x8D97CE0", VA = "0x188D994E0")]
		public void SCNUTBPPZDQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8D99FF0", Offset = "0x8D987F0", VA = "0x188D99FF0")]
		public void YAWSEUEDITP(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8D995D0", Offset = "0x8D97DD0", VA = "0x188D995D0")]
		public void SUFCNMFQCSL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8D99F70", Offset = "0x8D98770", VA = "0x188D99F70")]
		private static bool XOFXGTYUSSX(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8D992F0", Offset = "0x8D97AF0", VA = "0x188D992F0")]
		private static byte POBKLYKHJIN(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D8D8D0", Offset = "0x8D8C0D0", VA = "0x188D8D8D0")]
		private static void BQRUZIDEPMG(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class TRSZQFSWSPZ : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x4F56B50", Offset = "0x4F55350", VA = "0x184F56B50")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private TRSZQFSWSPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class RHOEQZPBJYM : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x4F783F0", Offset = "0x4F76BF0", VA = "0x184F783F0")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class CPLCULTANDU
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> OTMUJCAALJZ;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8D8E490", Offset = "0x8D8CC90", VA = "0x188D8E490")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private RHOEQZPBJYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class SOVMYPVLFTC : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x4F76FE0", Offset = "0x4F757E0", VA = "0x184F76FE0")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly SOVMYPVLFTC GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool FTNYDZAHXXK;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static AZVSJTUQPQS[] AWMRDLCWLII;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static KIVYKHMZUOQ[] YLCDHTZGPEG;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private SOVMYPVLFTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8D9F710", Offset = "0x8D9DF10", VA = "0x188D9F710")]
		public static void JIBLBJTHOBM(params KIVYKHMZUOQ[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8D9F640", Offset = "0x8D9DE40", VA = "0x188D9F640")]
		public static void JIBLBJTHOBM(params AZVSJTUQPQS[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8D9F3E0", Offset = "0x8D9DBE0", VA = "0x188D9F3E0")]
		public static void DXMNVYSUJKO(AZVSJTUQPQS[] a, KIVYKHMZUOQ[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class LMTQPXUYVBF : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x4F54340", Offset = "0x4F52B40", VA = "0x184F54340")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private LMTQPXUYVBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class GTNLGONCDWQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly KIVYKHMZUOQ WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly KIVYKHMZUOQ PPGXPEMJBKR;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class HIPGJCPGMAA
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly KIVYKHMZUOQ WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly KIVYKHMZUOQ GKVRSACOTYT;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly KIVYKHMZUOQ KUDKQAMAELH;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly KIVYKHMZUOQ BQDMXIJSZQW;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly KIVYKHMZUOQ CBDXPXTYJNO;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly KIVYKHMZUOQ XEVFIWCWPZI;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly KIVYKHMZUOQ NZIEJSTOECL;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly KIVYKHMZUOQ YIDQHKGKVWD;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly KIVYKHMZUOQ UTOCDWJZGZX;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly KIVYKHMZUOQ TLRWPKHXEIO;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly KIVYKHMZUOQ NDGZGEBEWBW;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly KIVYKHMZUOQ XRPMLXNCDBU;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class PNLNZZHTTNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> OTMUJCAALJZ;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8D9B710", Offset = "0x8D99F10", VA = "0x188D9B710")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8D9B6D0", Offset = "0x8D99ED0", VA = "0x188D9B6D0")]
		private static object GHNFYTAJAEQ(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class LFCXJHMSISF : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x4F711E0", Offset = "0x4F6F9E0", VA = "0x184F711E0")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private LFCXJHMSISF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class OSVHPPCAEWU : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x4F69450", Offset = "0x4F67C50", VA = "0x184F69450")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private OSVHPPCAEWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class KXICCCCWELC
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly KIVYKHMZUOQ[] IBTMDBJEDOR;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class VPNYIQKSGKD : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x4F4CB70", Offset = "0x4F4B370", VA = "0x184F4CB70")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class NQSYGKZNCJR : KIVYKHMZUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class IIPIMSLZYCM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x4F785D0", Offset = "0x4F76DD0", VA = "0x184F785D0")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
			public DIBGAVKLOIB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly DIBGAVKLOIB<object> HODHEWGOQRX;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private VPNYIQKSGKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class ATWYGFMHQDO : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x4F6D4A0", Offset = "0x4F6BCA0", VA = "0x184F6D4A0")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class NQSYGKZNCJR : KIVYKHMZUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class IIPIMSLZYCM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x4F5B530", Offset = "0x4F59D30", VA = "0x184F5B530")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
			public DIBGAVKLOIB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly DIBGAVKLOIB<object> HODHEWGOQRX;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private ATWYGFMHQDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class ESXOGHVMMLU : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x4F4AA00", Offset = "0x4F49200", VA = "0x184F4AA00")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class NQSYGKZNCJR : KIVYKHMZUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class IIPIMSLZYCM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x4F4FFC0", Offset = "0x4F4E7C0", VA = "0x184F4FFC0")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
			public DIBGAVKLOIB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly DIBGAVKLOIB<object> HODHEWGOQRX;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private ESXOGHVMMLU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class CNGSUIQQDSF : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x4F5BC60", Offset = "0x4F5A460", VA = "0x184F5BC60")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class NQSYGKZNCJR : KIVYKHMZUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class IIPIMSLZYCM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x4F82F10", Offset = "0x4F81710", VA = "0x184F82F10")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
			public DIBGAVKLOIB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly DIBGAVKLOIB<object> HODHEWGOQRX;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private CNGSUIQQDSF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class DDIQZPNFYRN : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x4F52790", Offset = "0x4F50F90", VA = "0x184F52790")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class NQSYGKZNCJR : KIVYKHMZUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class IIPIMSLZYCM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x4F4D150", Offset = "0x4F4B950", VA = "0x184F4D150")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
			public DIBGAVKLOIB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly DIBGAVKLOIB<object> HODHEWGOQRX;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private DDIQZPNFYRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class YGFJOPDQFNL : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x4F77800", Offset = "0x4F76000", VA = "0x184F77800")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class NQSYGKZNCJR : KIVYKHMZUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class IIPIMSLZYCM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x4F49E50", Offset = "0x4F48650", VA = "0x184F49E50")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
			public DIBGAVKLOIB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly DIBGAVKLOIB<object> HODHEWGOQRX;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private YGFJOPDQFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class UVXTYFNXGHO : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x4F51190", Offset = "0x4F4F990", VA = "0x184F51190")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class NQSYGKZNCJR : KIVYKHMZUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class IIPIMSLZYCM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x4F80E60", Offset = "0x4F7F660", VA = "0x184F80E60")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
			public DIBGAVKLOIB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly DIBGAVKLOIB<object> HODHEWGOQRX;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private UVXTYFNXGHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class MYGQJQWSOUQ : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x4F73BD0", Offset = "0x4F723D0", VA = "0x184F73BD0")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class NQSYGKZNCJR : KIVYKHMZUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class IIPIMSLZYCM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0x4F834A0", Offset = "0x4F81CA0", VA = "0x184F834A0")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
			public DIBGAVKLOIB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly DIBGAVKLOIB<object> HODHEWGOQRX;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private MYGQJQWSOUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class CAVBRFYPXTU : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x4F64E80", Offset = "0x4F63680", VA = "0x184F64E80")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class NQSYGKZNCJR : KIVYKHMZUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class IIPIMSLZYCM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x4F7B700", Offset = "0x4F79F00", VA = "0x184F7B700")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
			public DIBGAVKLOIB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly DIBGAVKLOIB<object> HODHEWGOQRX;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private CAVBRFYPXTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class ACSQAMQIOMZ : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x4F50BB0", Offset = "0x4F4F3B0", VA = "0x184F50BB0")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class NQSYGKZNCJR : KIVYKHMZUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class IIPIMSLZYCM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x4F4EBD0", Offset = "0x4F4D3D0", VA = "0x184F4EBD0")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
			public DIBGAVKLOIB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly DIBGAVKLOIB<object> HODHEWGOQRX;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private ACSQAMQIOMZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class AQAISTOEBQH : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x4F4AED0", Offset = "0x4F496D0", VA = "0x184F4AED0")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class NQSYGKZNCJR : KIVYKHMZUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class IIPIMSLZYCM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x4F83B80", Offset = "0x4F82380", VA = "0x184F83B80")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
			public DIBGAVKLOIB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly DIBGAVKLOIB<object> HODHEWGOQRX;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private AQAISTOEBQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class FNMZKARDQYN : KIVYKHMZUOQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class IIPIMSLZYCM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4F76200", Offset = "0x4F74A00", VA = "0x184F76200")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class NQSYGKZNCJR : KIVYKHMZUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class IIPIMSLZYCM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly DIBGAVKLOIB<a> POYRXTDAMXZ;

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x4F741B0", Offset = "0x4F729B0", VA = "0x184F741B0")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
			public DIBGAVKLOIB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly DIBGAVKLOIB<object> HODHEWGOQRX;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		private FNMZKARDQYN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x303D1F0", Offset = "0x303B9F0", VA = "0x18303D1F0", Slot = "4")]
		public DIBGAVKLOIB<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x5754A50", Offset = "0x5753250", VA = "0x185754A50")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5754760", Offset = "0x5752F60", VA = "0x185754760")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x57549C0", Offset = "0x57531C0", VA = "0x1857549C0")]
		public T[] XISWSVSRCTJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class NOERAWRFVRD<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int BOSKTEJSTHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object CEDUXILMDPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int SPLEGEZJYLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] CGYOVPBUYNM;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5851E80", Offset = "0x5850680", VA = "0x185851E80")]
		public NOERAWRFVRD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x58517D0", Offset = "0x584FFD0", VA = "0x1858517D0")]
		public a[] GPSVHSXROLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5851C40", Offset = "0x5850440", VA = "0x185851C40")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class QBWQRZLRZND : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class PQICOSRUKMJ : IComparable<PQICOSRUKMJ>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class UONZDGTPZSN : IEnumerable<PQICOSRUKMJ>, IEnumerable, IEnumerator<PQICOSRUKMJ>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int ILQFHFJYACP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private PQICOSRUKMJ YDRMGGSTAGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int XJERYWNBAAG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public PQICOSRUKMJ VIXLAPAPYNX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int WKECKAKFPAL;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private PQICOSRUKMJ SMYTXSUKHLI
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object IDRIDRBRWXH
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xD38BD0", Offset = "0xD373D0", VA = "0x180D38BD0")]
				[DebuggerHidden]
				public UONZDGTPZSN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "7")]
				[DebuggerHidden]
				private void QBKHVLXPXWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x8DA0550", Offset = "0x8D9ED50", VA = "0x188DA0550", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x8DA05D0", Offset = "0x8D9EDD0", VA = "0x188DA05D0", Slot = "10")]
				[DebuggerHidden]
				private void VXYFNEQVOKT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x8DA04B0", Offset = "0x8D9ECB0", VA = "0x188DA04B0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<PQICOSRUKMJ> HTROFGVPEXD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x8DA04B0", Offset = "0x8D9ECB0", VA = "0x188DA04B0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator WFEYQSZVQHA()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly PQICOSRUKMJ[] APJJAVUGHTT;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] ZWLHMAUQZMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong XQUUXFGLFNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int GJDRZFRFPRC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string XYRROFQGHSX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private PQICOSRUKMJ[] ORXACVLDEAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] SFLFDCHOPFY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int OEFEHKOYSMS;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8D9E200", Offset = "0x8D9CA00", VA = "0x188D9E200")]
			public PQICOSRUKMJ(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8D9DD30", Offset = "0x8D9C530", VA = "0x188D9DD30")]
			public PQICOSRUKMJ Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8D9DCD0", Offset = "0x8D9C4D0", VA = "0x188D9DCD0")]
			public PQICOSRUKMJ Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8D9DFF0", Offset = "0x8D9C7F0", VA = "0x188D9DFF0")]
			public PQICOSRUKMJ HPYHWDXRTUT(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8D9DF30", Offset = "0x8D9C730", VA = "0x188D9DF30")]
			internal static int BBTKGQPEYVM(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8D9DFC0", Offset = "0x8D9C7C0", VA = "0x188D9DFC0", Slot = "4")]
			public int CompareTo(PQICOSRUKMJ other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8D9DC50", Offset = "0x8D9C450", VA = "0x188D9DC50")]
			[IteratorStateMachine(typeof(UONZDGTPZSN))]
			public IEnumerable<PQICOSRUKMJ> AYBRUNUVFKP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class KUORPSAXFMP : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<PQICOSRUKMJ> ORXACVLDEAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<PQICOSRUKMJ> MEPVBVKXHEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<PQICOSRUKMJ> RECIBZUSAYP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private PQICOSRUKMJ TMQDLQPUQOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> REMVWNIMTVH;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> OXEDCWZSPGU
			{
				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0xC98390", Offset = "0xC96B90", VA = "0x180C98390", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x8D9A5B0", Offset = "0x8D98DB0", VA = "0x188D9A5B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x1A228E0", Offset = "0x1A210E0", VA = "0x181A228E0")]
			[DebuggerHidden]
			public KUORPSAXFMP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8D9A600", Offset = "0x8D98E00", VA = "0x188D9A600", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8D9A150", Offset = "0x8D98950", VA = "0x188D9A150", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8D9A750", Offset = "0x8D98F50", VA = "0x188D9A750")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8D9A7A0", Offset = "0x8D98FA0", VA = "0x188D9A7A0")]
			private void SONMORMKPTT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8D9A890", Offset = "0x8D99090", VA = "0x188D9A890", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8D9A7F0", Offset = "0x8D98FF0", VA = "0x188D9A7F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> TZORUKFUUSD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8D9A7F0", Offset = "0x8D98FF0", VA = "0x188D9A7F0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly PQICOSRUKMJ OQYAWLRTKSL;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8D9EB00", Offset = "0x8D9D300", VA = "0x188D9EB00")]
		public QBWQRZLRZND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E2B0", Offset = "0x8D9CAB0", VA = "0x188D9E2B0")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E490", Offset = "0x8D9CC90", VA = "0x188D9E490")]
		public bool CIWAHGAOAZX(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E680", Offset = "0x8D9CE80", VA = "0x188D9E680")]
		public bool KVVWYNVJASI([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E790", Offset = "0x8D9CF90", VA = "0x188D9E790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E820", Offset = "0x8D9D020", VA = "0x188D9E820")]
		private static void XHXXJMRYCEU(IEnumerable<PQICOSRUKMJ> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E620", Offset = "0x8D9CE20", VA = "0x188D9E620", Slot = "5")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E620", Offset = "0x8D9CE20", VA = "0x188D9E620", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E5A0", Offset = "0x8D9CDA0", VA = "0x188D9E5A0")]
		[IteratorStateMachine(typeof(KUORPSAXFMP))]
		private static IEnumerable<KeyValuePair<string, int>> GGSGJTYDYBN(IEnumerable<PQICOSRUKMJ> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class RGMMRIIZHBE
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo KBWLMFTJJIR;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8D9EB70", Offset = "0x8D9D370", VA = "0x188D9EB70")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8D9ED20", Offset = "0x8D9D520", VA = "0x188D9ED20")]
		public static ulong QNRONUXGUYB(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class GESSGVAUFQG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8D91830", Offset = "0x8D90030", VA = "0x188D91830")]
		public static void HFYRASWLYEF(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8D91970", Offset = "0x8D90170", VA = "0x188D91970")]
		public static void UPLGRUUCCAB(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8D916F0", Offset = "0x8D8FEF0", VA = "0x188D916F0")]
		public static byte[] DXSXUMMJNWC(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class CQWMVTINDBM<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x46AB020", Offset = "0x46A9820", VA = "0x1846AB020", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class UEATFONUVHU : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public CQWMVTINDBM<a> VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] RECIBZUSAYP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int REHOZGOPKJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] REMVWNIMTVH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int RDBZPRZFFTW;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> IQZHJXOIXZN
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xC98390", Offset = "0xC96B90", VA = "0x180C98390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0x4D45130", Offset = "0x4D43930", VA = "0x184D45130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public UEATFONUVHU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x61036D0", Offset = "0x6101ED0", VA = "0x1861036D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3D305A0", Offset = "0x3D2EDA0", VA = "0x183D305A0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] TJPNLZWBFDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong SYKNGZRBIQU;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool SOMDILXFRDL;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3D751A0", Offset = "0x3D739A0", VA = "0x183D751A0")]
		public CQWMVTINDBM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3D75290", Offset = "0x3D73A90", VA = "0x183D75290")]
		public CQWMVTINDBM(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3D63600", Offset = "0x3D61E00", VA = "0x183D63600")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3D68C60", Offset = "0x3D67460", VA = "0x183D68C60")]
		private bool IKBRVZRGWHI(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3D67480", Offset = "0x3D65C80", VA = "0x183D67480")]
		public bool CIWAHGAOAZX([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3D72A30", Offset = "0x3D71230", VA = "0x183D72A30")]
		private static ulong KNRQTOAEPTN([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3D72890", Offset = "0x3D71090", VA = "0x183D72890")]
		private static ulong KNRQTOAEPTN([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3D706E0", Offset = "0x3D6EEE0", VA = "0x183D706E0")]
		private static int IVRYDRCTCXP(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3D68170", Offset = "0x3D66970", VA = "0x183D68170", Slot = "4")]
		[IteratorStateMachine(typeof(CQWMVTINDBM<>.UEATFONUVHU))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3D750B0", Offset = "0x3D738B0", VA = "0x183D750B0", Slot = "5")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class NBHPOFJRYUP
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3846490", Offset = "0x3844C90", VA = "0x183846490")]
		public static Func<a> COAEVSIVGZT<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3846580", Offset = "0x3844D80", VA = "0x183846580")]
		private static c JBUQGRXLJZI<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0x8D924E0", Offset = "0x8D90CE0", VA = "0x188D924E0")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8D924F0", Offset = "0x8D90CF0", VA = "0x188D924F0")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8D92360", Offset = "0x8D90B60", VA = "0x188D92360")]
		private static byte VIKUNIOWFTU(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8D8C110", Offset = "0x8D8A910", VA = "0x188D8C110")]
		private static byte HFPPXKTDVBA(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8D91B60", Offset = "0x8D90360", VA = "0x188D91B60")]
		public void DKMXHPDZVPU(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class JDUYGTFQNQW
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8D93E20", Offset = "0x8D92620", VA = "0x188D93E20")]
		public static bool BWQNCEKOGBE(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8D94600", Offset = "0x8D92E00", VA = "0x188D94600")]
		public static bool OMFJGUDTDZN(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8D94CB0", Offset = "0x8D934B0", VA = "0x188D94CB0")]
		public static sbyte ZNEOOUTGEBM([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8D949C0", Offset = "0x8D931C0", VA = "0x188D949C0")]
		public static short WPVJYOXIPFJ([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8D94540", Offset = "0x8D92D40", VA = "0x188D94540")]
		public static int KKRHFRAUEQZ([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8D94190", Offset = "0x8D92990", VA = "0x188D94190")]
		public static long ENDLIZNWGUK([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8D943B0", Offset = "0x8D92BB0", VA = "0x188D943B0")]
		public static bool KCBTRUZFDST(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8D94BF0", Offset = "0x8D933F0", VA = "0x188D94BF0")]
		public static byte ZHRRQYZLOCB([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8D94C50", Offset = "0x8D93450", VA = "0x188D94C50")]
		public static ushort ZIISGIMBRLC([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8D945A0", Offset = "0x8D92DA0", VA = "0x188D945A0")]
		public static uint LNMUZGIQBZM([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8D94670", Offset = "0x8D92E70", VA = "0x188D94670")]
		public static ulong RLVSKYXDLPL([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8D94720", Offset = "0x8D92F20", VA = "0x188D94720")]
		public static bool SOCUTSOJQWW(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8D94A20", Offset = "0x8D93220", VA = "0x188D94A20")]
		public static bool YEFAINLGNRG(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8D94240", Offset = "0x8D92A40", VA = "0x188D94240")]
		public static bool IDREVZQHKTQ(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8D940F0", Offset = "0x8D928F0", VA = "0x188D940F0")]
		public static bool EHKLCXSEYUU(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8D948D0", Offset = "0x8D930D0", VA = "0x188D948D0")]
		public static float TUKFSJYQWAX([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8D94870", Offset = "0x8D93070", VA = "0x188D94870")]
		public static bool TTKVOYVEDDK(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8D93E30", Offset = "0x8D92630", VA = "0x188D93E30")]
		public static double DMFDPWEIUEC([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8D94350", Offset = "0x8D92B50", VA = "0x188D94350")]
		public static bool JKHUEAJXBFX(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8D8C370", Offset = "0x8D8AB70", VA = "0x188D8C370")]
		public static int GRNNLAQZLOQ(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8D8CC20", Offset = "0x8D8B420", VA = "0x188D8CC20")]
		public static int YAWSEUEDITP(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8D93F20", Offset = "0x8D92720", VA = "0x188D93F20")]
		public static bool DQPPZTXZPRH([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class PGLVSPXYCNK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8D9B620", Offset = "0x8D99E20", VA = "0x188D9B620")]
		public static bool XEAYSATTCZU(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class BTYLWZGCBEL
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding ASQUHOOVMYE;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class JJPENAZLQRZ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8D90FD0", Offset = "0x8D8F7D0", VA = "0x188D90FD0")]
		public static void UQVBEQERLCE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8D91040", Offset = "0x8D8F840", VA = "0x188D91040")]
		public static void URAIBWYOUNN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8D910B0", Offset = "0x8D8F8B0", VA = "0x188D910B0")]
		public static void URFOZDSMDYW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8D91120", Offset = "0x8D8F920", VA = "0x188D91120")]
		public static void URKVWKMJNKF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8D95850", Offset = "0x8D94050", VA = "0x188D95850")]
		public static void URQCTRGGWVO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8D958C0", Offset = "0x8D940C0", VA = "0x188D958C0")]
		public static void URVJQYAEGGX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8D954E0", Offset = "0x8D93CE0", VA = "0x188D954E0")]
		public static void TMMYMGYCUKV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8D95470", Offset = "0x8D93C70", VA = "0x188D95470")]
		public static void TMHRPAEFKZM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8D95400", Offset = "0x8D93C00", VA = "0x188D95400")]
		public static void TMCKRTKIBOD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8D95380", Offset = "0x8D93B80", VA = "0x188D95380")]
		public static void TLXDUMQKSCU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8D956D0", Offset = "0x8D93ED0", VA = "0x188D956D0")]
		public static void TNIABHZSGEF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8D95650", Offset = "0x8D93E50", VA = "0x188D95650")]
		public static void TNCTEBFUWSW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8D955D0", Offset = "0x8D93DD0", VA = "0x188D955D0")]
		public static void TMXMGULXNHN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8D95550", Offset = "0x8D93D50", VA = "0x188D95550")]
		public static void TMSFJNSADWE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8D957D0", Offset = "0x8D93FD0", VA = "0x188D957D0")]
		public static void TODBQJBHRXP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8D95750", Offset = "0x8D93F50", VA = "0x188D95750")]
		public static void TNXUTCHKIMG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8D95040", Offset = "0x8D93840", VA = "0x188D95040")]
		public static void ANEDKZGFKDE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8D950C0", Offset = "0x8D938C0", VA = "0x188D950C0")]
		public static void ANJKIGACTON(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8D94F40", Offset = "0x8D93740", VA = "0x188D94F40")]
		public static void AMTPQLSKRGM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8D94FC0", Offset = "0x8D937C0", VA = "0x188D94FC0")]
		public static void AMYWNSMIARV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8D94E30", Offset = "0x8D93630", VA = "0x188D94E30")]
		public static void AMJBVYEPYJU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8D94EB0", Offset = "0x8D936B0", VA = "0x188D94EB0")]
		public static void AMOITEYNHVD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8D94D10", Offset = "0x8D93510", VA = "0x188D94D10")]
		public static void ALYOBKQVFNC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8D94DA0", Offset = "0x8D935A0", VA = "0x188D94DA0")]
		public static void AMDUYRKSOYL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8D95140", Offset = "0x8D93940", VA = "0x188D95140")]
		public static void AOUGPBJKHPY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8D951D0", Offset = "0x8D939D0", VA = "0x188D951D0")]
		public static void AOZNMIDHRBH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8D952F0", Offset = "0x8D93AF0", VA = "0x188D952F0")]
		public static void GNXJWJPHNZF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8D95260", Offset = "0x8D93A60", VA = "0x188D95260")]
		public static void GNSCZCVKENW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8D90E80", Offset = "0x8D8F680", VA = "0x188D90E80")]
		public static void UQFGMVWZIUD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8D90EF0", Offset = "0x8D8F6F0", VA = "0x188D90EF0")]
		public static void UQKNKCQWSFM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8D90F60", Offset = "0x8D8F760", VA = "0x188D90F60")]
		public static void UQPUHJKUBQV(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class DETUKZYERCY
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8D91190", Offset = "0x8D8F990", VA = "0x188D91190")]
		public static void URQCTRGGWVO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8D91200", Offset = "0x8D8FA00", VA = "0x188D91200")]
		public static void URVJQYAEGGX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8D90B40", Offset = "0x8D8F340", VA = "0x188D90B40")]
		public static void TMMYMGYCUKV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8D90AD0", Offset = "0x8D8F2D0", VA = "0x188D90AD0")]
		public static void TMHRPAEFKZM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8D90A60", Offset = "0x8D8F260", VA = "0x188D90A60")]
		public static void TMCKRTKIBOD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8D909F0", Offset = "0x8D8F1F0", VA = "0x188D909F0")]
		public static void TLXDUMQKSCU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8D90D10", Offset = "0x8D8F510", VA = "0x188D90D10")]
		public static void TNIABHZSGEF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8D90CA0", Offset = "0x8D8F4A0", VA = "0x188D90CA0")]
		public static void TNCTEBFUWSW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8D90C30", Offset = "0x8D8F430", VA = "0x188D90C30")]
		public static void TMXMGULXNHN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8D90BB0", Offset = "0x8D8F3B0", VA = "0x188D90BB0")]
		public static void TMSFJNSADWE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8D90E00", Offset = "0x8D8F600", VA = "0x188D90E00")]
		public static void TODBQJBHRXP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8D90D80", Offset = "0x8D8F580", VA = "0x188D90D80")]
		public static void TNXUTCHKIMG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8D906F0", Offset = "0x8D8EEF0", VA = "0x188D906F0")]
		public static void ANEDKZGFKDE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8D90770", Offset = "0x8D8EF70", VA = "0x188D90770")]
		public static void ANJKIGACTON(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8D905F0", Offset = "0x8D8EDF0", VA = "0x188D905F0")]
		public static void AMTPQLSKRGM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8D90670", Offset = "0x8D8EE70", VA = "0x188D90670")]
		public static void AMYWNSMIARV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8D904F0", Offset = "0x8D8ECF0", VA = "0x188D904F0")]
		public static void AMJBVYEPYJU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8D90570", Offset = "0x8D8ED70", VA = "0x188D90570")]
		public static void AMOITEYNHVD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8D903F0", Offset = "0x8D8EBF0", VA = "0x188D903F0")]
		public static void ALYOBKQVFNC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D90470", Offset = "0x8D8EC70", VA = "0x188D90470")]
		public static void AMDUYRKSOYL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8D907F0", Offset = "0x8D8EFF0", VA = "0x188D907F0")]
		public static void AOUGPBJKHPY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8D90870", Offset = "0x8D8F070", VA = "0x188D90870")]
		public static void AOZNMIDHRBH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8D90970", Offset = "0x8D8F170", VA = "0x188D90970")]
		public static void GNXJWJPHNZF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8D908F0", Offset = "0x8D8F0F0", VA = "0x188D908F0")]
		public static void GNSCZCVKENW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8D90E80", Offset = "0x8D8F680", VA = "0x188D90E80")]
		public static void UQFGMVWZIUD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D90EF0", Offset = "0x8D8F6F0", VA = "0x188D90EF0")]
		public static void UQKNKCQWSFM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D90F60", Offset = "0x8D8F760", VA = "0x188D90F60")]
		public static void UQPUHJKUBQV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8D90FD0", Offset = "0x8D8F7D0", VA = "0x188D90FD0")]
		public static void UQVBEQERLCE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8D91040", Offset = "0x8D8F840", VA = "0x188D91040")]
		public static void URAIBWYOUNN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8D910B0", Offset = "0x8D8F8B0", VA = "0x188D910B0")]
		public static void URFOZDSMDYW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D91120", Offset = "0x8D8F920", VA = "0x188D91120")]
		public static void URKVWKMJNKF(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class WPGKZAPSUSW
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool SOMDILXFRDL;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7A10", Offset = "0x8DB6210", VA = "0x188DB7A10")]
		public static void AXKGFYWJEJO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8DB9410", Offset = "0x8DB7C10", VA = "0x188DB9410")]
		public static void LMJNWCCTOZX(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x28A3050", Offset = "0x28A1850", VA = "0x1828A3050")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4860", Offset = "0x8DA3060", VA = "0x188DA4860")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4690", Offset = "0x8DA2E90", VA = "0x188DA4690")]
		public static DiyFp KSQWTLAZSEB(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4730", Offset = "0x8DA2F30", VA = "0x188DA4730")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8DA47C0", Offset = "0x8DA2FC0", VA = "0x188DA47C0")]
		public static DiyFp OVDZRWJUPGT(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8DA46F0", Offset = "0x8DA2EF0", VA = "0x188DA46F0")]
		public void MWOEODIEXJY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8DA46A0", Offset = "0x8DA2EA0", VA = "0x188DA46A0")]
		public static DiyFp MWOEODIEXJY(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xC29C20", Offset = "0xC28420", VA = "0x180C29C20")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3560", Offset = "0x8DB1D60", VA = "0x188DB3560")]
		public void TQQZWAXLNMN(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8DB33C0", Offset = "0x8DB1BC0", VA = "0x188DB33C0")]
		public void JZDRSWCEITZ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3440", Offset = "0x8DB1C40", VA = "0x188DB3440")]
		public void SEVEQYAAJOF(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8DB34C0", Offset = "0x8DB1CC0", VA = "0x188DB34C0")]
		public void SEVEQYAAJOF(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3240", Offset = "0x8DB1A40", VA = "0x188DB3240")]
		public void CKOWWBZYXCX(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8DB32C0", Offset = "0x8DB1AC0", VA = "0x188DB32C0")]
		public void DANZYNOELQC(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class OQERVUEKYDY
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
		private static byte[] HOMMBYNKNFF;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] TLUNKENOHZB;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] RKYSDGPGGCB;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] LRJWRNSJVVQ;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags NQOPVZUVBWH;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char JGISIOXROLH;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int EZXKHLLGXUH;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int SDPZFOYRCOJ;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] ELPBUHFYYGP;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8DAFD30", Offset = "0x8DAE530", VA = "0x188DAFD30")]
		private static byte[] NVUHQHRYMHP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8DAF1D0", Offset = "0x8DAD9D0", VA = "0x188DAF1D0")]
		private static byte[] JBVXURIPCCN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8DAFC10", Offset = "0x8DAE410", VA = "0x188DAFC10")]
		public static int KHIJLIKLCYM(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8DAFAF0", Offset = "0x8DAE2F0", VA = "0x188DAFAF0")]
		public static int KHIJLIKLCYM(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8DAF2B0", Offset = "0x8DADAB0", VA = "0x188DAF2B0")]
		private static bool JDYJWAKKRAQ(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8DAF0E0", Offset = "0x8DAD8E0", VA = "0x188DAF0E0")]
		private static void DMEEUADHJNG(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8DAF3A0", Offset = "0x8DADBA0", VA = "0x188DAF3A0")]
		private static bool JVXPQVEMNPM(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8DAFF00", Offset = "0x8DAE700", VA = "0x188DAFF00")]
		private static bool RCKVTLFNSLI(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8DAFE00", Offset = "0x8DAE600", VA = "0x188DAFE00")]
		private static bool QMTPAKKUXJP(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8DB0C90", Offset = "0x8DAF490", VA = "0x188DB0C90")]
		private static bool YVUTOOJGSDQ(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8DB07C0", Offset = "0x8DAEFC0", VA = "0x188DB07C0")]
		private static bool VCDGCXIEQXL(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8DAF760", Offset = "0x8DADF60", VA = "0x188DAF760")]
		private static void KBYEEFJAATR(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8DB0380", Offset = "0x8DAEB80", VA = "0x188DB0380")]
		private static void UXXWLOVFMTF(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8DAEEF0", Offset = "0x8DAD6F0", VA = "0x188DAEEF0")]
		private static bool DAMCXHNRMKO(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0x8DA4E90", Offset = "0x8DA3690", VA = "0x188DA4E90")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4DF0", Offset = "0x8DA35F0", VA = "0x188DA4DF0")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4870", Offset = "0x8DA3070", VA = "0x188DA4870")]
		public DiyFp DBNDNATKPRX()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4D70", Offset = "0x8DA3570", VA = "0x188DA4D70")]
		public DiyFp ZWPGXJUGZDE()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xBE9B80", Offset = "0xBE8380", VA = "0x180BE9B80")]
		public ulong HLKFQHNUZAJ()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4C90", Offset = "0x8DA3490", VA = "0x188DA4C90")]
		public double UGVIPTLXZJB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4AD0", Offset = "0x8DA32D0", VA = "0x188DA4AD0")]
		public double GTNBXFWRUZZ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4B70", Offset = "0x8DA3370", VA = "0x188DA4B70")]
		public int HYJCZELJGYQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4C60", Offset = "0x8DA3460", VA = "0x188DA4C60")]
		public ulong QFJYJNNKIGG()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4D10", Offset = "0x8DA3510", VA = "0x188DA4D10")]
		public bool VCZMSVPKPNJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8DA48E0", Offset = "0x8DA30E0", VA = "0x188DA48E0")]
		public bool DUZWABMFXRI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4BF0", Offset = "0x8DA33F0", VA = "0x188DA4BF0")]
		public bool ICCNGHABSYQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4D30", Offset = "0x8DA3530", VA = "0x188DA4D30")]
		public bool XBSXRAVROTV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4C40", Offset = "0x8DA3440", VA = "0x188DA4C40")]
		public int PFZIKWYUKYG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4990", Offset = "0x8DA3190", VA = "0x188DA4990")]
		public void FZWCIELUSAY([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4BA0", Offset = "0x8DA33A0", VA = "0x188DA4BA0")]
		public bool IBQNYUHZFQA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3B8A090", Offset = "0x3B88890", VA = "0x183B8A090")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4C20", Offset = "0x8DA3420", VA = "0x188DA4C20")]
		public static int IGAGZBHYNZF(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4D60", Offset = "0x8DA3560", VA = "0x188DA4D60")]
		public static double XQEZVOICMVR()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4900", Offset = "0x8DA3100", VA = "0x188DA4900")]
		public static ulong EFPIXCEMHPY(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x157FE40", Offset = "0x157E640", VA = "0x18157FE40")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3020", Offset = "0x8DB1820", VA = "0x188DB3020")]
		public DiyFp DBNDNATKPRX()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xC9D050", Offset = "0xC9B850", VA = "0x180C9D050")]
		public uint BGOVOGMNZLI()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8DB31B0", Offset = "0x8DB19B0", VA = "0x188DB31B0")]
		public int HYJCZELJGYQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3210", Offset = "0x8DB1A10", VA = "0x188DB3210")]
		public uint QFJYJNNKIGG()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3230", Offset = "0x8DB1A30", VA = "0x188DB3230")]
		public bool VCZMSVPKPNJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3080", Offset = "0x8DB1880", VA = "0x188DB3080")]
		public void FZWCIELUSAY([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8DB31D0", Offset = "0x8DB19D0", VA = "0x188DB31D0")]
		public bool IBQNYUHZFQA()
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
		[Cpp2IlInjected.Address(RVA = "0x8DA3E40", Offset = "0x8DA2640", VA = "0x188DA3E40")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class LJWXLUQZJJF
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] ZDSLOYNQGVG;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8DAC700", Offset = "0x8DAAF00", VA = "0x188DAC700")]
		public static void FTPHTWLBEBM(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8DAC810", Offset = "0x8DAB010", VA = "0x188DAC810")]
		public static void IIJJJBROHGV(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0x8DB7840", Offset = "0x8DB6040", VA = "0x188DB7840")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5836D20", Offset = "0x5835520", VA = "0x185836D20")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6670", Offset = "0x2AD4E70", VA = "0x182AD6670")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8DB77E0", Offset = "0x8DB5FE0", VA = "0x188DB77E0")]
		public Vector GQVYEMVXNHS(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class HDLUCMNSMXQ
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] FTSPDIVYWKY;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] ENQMQQDLVTZ;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int PKQIAKYDHPE;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7640", Offset = "0x8DA5E40", VA = "0x188DA7640")]
		private static byte[] MLYVJSKAQKS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7480", Offset = "0x8DA5C80", VA = "0x188DA7480")]
		private static Vector KCNOHBKOZBM(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7560", Offset = "0x8DA5D60", VA = "0x188DA7560")]
		private static Vector KPTTLHQYIHQ(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7040", Offset = "0x8DA5840", VA = "0x188DA7040")]
		private static void FXBGBQINQRB(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8DA6D50", Offset = "0x8DA5550", VA = "0x188DA6D50")]
		private static void EXBJSJUWMWI(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8DA6CC0", Offset = "0x8DA54C0", VA = "0x188DA6CC0")]
		private static ulong BNYHGGANQZT(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7CA0", Offset = "0x8DA64A0", VA = "0x188DA7CA0")]
		private static void SZDFBJKRGHP(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8DA70D0", Offset = "0x8DA58D0", VA = "0x188DA70D0")]
		private static bool FXCGPZZYVTK(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7720", Offset = "0x8DA5F20", VA = "0x188DA7720")]
		private static DiyFp MSYMPZMXCZR(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7DE0", Offset = "0x8DA65E0", VA = "0x188DA7DE0")]
		private static bool TRJSGQHPZGT(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8420", Offset = "0x8DA6C20", VA = "0x188DA8420")]
		private static bool YACAPNQWBDP(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7B80", Offset = "0x8DA6380", VA = "0x188DA7B80")]
		public static double? OTFQHNYRYHT(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8DA78B0", Offset = "0x8DA60B0", VA = "0x188DA78B0")]
		public static float? OSVCNAKXFLB(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class VKUGWGJDBDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] EJYHAFBJMVY;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] RKYSDGPGGCB;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] LRJWRNSJVVQ;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] XEOTUZWLVBS;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int BNURRENIWSI;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] KDXZKGWWYOY;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int XUHWIDTGFKA;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8DB6360", Offset = "0x8DB4B60", VA = "0x188DB6360")]
		private static byte[] UJNOMWXTRTZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8DB6220", Offset = "0x8DB4A20", VA = "0x188DB6220")]
		public static bool TTKVOYVEDDK(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5D90", Offset = "0x8DB4590", VA = "0x188DB5D90")]
		public static bool JKHUEAJXBFX(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8DB6440", Offset = "0x8DB4C40", VA = "0x188DB6440")]
		private static bool WYADLBIVTLE(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5F60", Offset = "0x8DB4760", VA = "0x188DB5F60")]
		private static bool PNWFVGICJAN(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5CB0", Offset = "0x8DB44B0", VA = "0x188DB5CB0")]
		private static bool GJRVILLNXCK(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5EF0", Offset = "0x8DB46F0", VA = "0x188DB5EF0")]
		private static bool OGZUIFAUQEW(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5ED0", Offset = "0x8DB46D0", VA = "0x188DB5ED0")]
		private static double KKKUYVWMVAN(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8DB6570", Offset = "0x8DB4D70", VA = "0x188DB6570")]
		private static double ZNSNWVDTZZN(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class XKGTOFEKFAN<a> : DIBGAVKLOIB<a[]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly NOERAWRFVRD<a> BKBJNCYOJXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour SONVFFNKGNU;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x166AEF0", Offset = "0x16696F0", VA = "0x18166AEF0")]
		public XKGTOFEKFAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
		public XKGTOFEKFAN(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD1FB0", Offset = "0x3DD07B0", VA = "0x183DD1FB0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD1570", Offset = "0x3DCFD70", VA = "0x183DD1570", Slot = "5")]
		public a[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class TNBIYGYNHJI<a> : DIBGAVKLOIB<ArraySegment<a>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly NOERAWRFVRD<a> BKBJNCYOJXM;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5F16B80", Offset = "0x5F15380", VA = "0x185F16B80", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5F16740", Offset = "0x5F14F40", VA = "0x185F16740", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class WWPIAWAQHBG<a> : DIBGAVKLOIB<List<a>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour SONVFFNKGNU;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x166AEF0", Offset = "0x16696F0", VA = "0x18166AEF0")]
		public WWPIAWAQHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
		public WWPIAWAQHBG(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6622740", Offset = "0x6620F40", VA = "0x186622740", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x661F2C0", Offset = "0x661DAC0", VA = "0x18661F2C0", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class SHRMYBUMUHI<a, b, c, d> : DIBGAVKLOIB<d>, AZVSJTUQPQS where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5E22B50", Offset = "0x5E21350", VA = "0x185E22B50", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5E20D40", Offset = "0x5E1F540", VA = "0x185E20D40", Slot = "5")]
		public d Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c CKEBFKHTHCC(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		protected SHRMYBUMUHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class SIHHPWCEWPJ<a, b, c> : SHRMYBUMUHI<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3DD36A0", Offset = "0x3DD1EA0", VA = "0x183DD36A0", Slot = "6")]
		protected override IEnumerator<a> CKEBFKHTHCC(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		protected SIHHPWCEWPJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class SICASPIHNEA<a, b> : SIHHPWCEWPJ<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xB012C0", Offset = "0xAFFAC0", VA = "0x180B012C0", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class IRGVWVLACFG<a, b> : SICASPIHNEA<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x4FEA710", Offset = "0x4FE8F10", VA = "0x184FEA710", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4FEA5B0", Offset = "0x4FE8DB0", VA = "0x184FEA5B0", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class OBXSDCUZHBJ<a> : SHRMYBUMUHI<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x596B810", Offset = "0x596A010", VA = "0x18596B810", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xB012C0", Offset = "0xAFFAC0", VA = "0x180B012C0", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5257560", Offset = "0x5255D60", VA = "0x185257560", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x459C360", Offset = "0x459AB60", VA = "0x18459C360", Slot = "6")]
		protected override LinkedList<a>.Enumerator CKEBFKHTHCC(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class JUNOAPBUEVY<a> : SHRMYBUMUHI<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3E27B20", Offset = "0x3E26320", VA = "0x183E27B20", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4DD2C30", Offset = "0x4DD1430", VA = "0x184DD2C30", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x4F3CF80", Offset = "0x4F3B780", VA = "0x184F3CF80", Slot = "6")]
		protected override Queue<a>.Enumerator CKEBFKHTHCC(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xB012C0", Offset = "0xAFFAC0", VA = "0x180B012C0", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class LHMSAIYSPEW<a> : SHRMYBUMUHI<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x404CC10", Offset = "0x404B410", VA = "0x18404CC10", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x404CD40", Offset = "0x404B540", VA = "0x18404CD40", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x530DD20", Offset = "0x530C520", VA = "0x18530DD20", Slot = "6")]
		protected override Stack<a>.Enumerator CKEBFKHTHCC(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x530DDD0", Offset = "0x530C5D0", VA = "0x18530DDD0", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class IBDZXIIWRSW<a> : SHRMYBUMUHI<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x4F3CEF0", Offset = "0x4F3B6F0", VA = "0x184F3CEF0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xB012C0", Offset = "0xAFFAC0", VA = "0x180B012C0", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x4F3D030", Offset = "0x4F3B830", VA = "0x184F3D030", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4F3CF30", Offset = "0x4F3B730", VA = "0x184F3CF30", Slot = "6")]
		protected override HashSet<a>.Enumerator CKEBFKHTHCC(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4F3D090", Offset = "0x4F3B890", VA = "0x184F3D090")]
		public IBDZXIIWRSW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class GOJMVUQCCPU<a> : SIHHPWCEWPJ<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x404CC10", Offset = "0x404B410", VA = "0x18404CC10", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x4DD0DA0", Offset = "0x4DCF5A0", VA = "0x184DD0DA0", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x4DD0E30", Offset = "0x4DCF630", VA = "0x184DD0E30", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class GPKPKRVICLF<a> : SIHHPWCEWPJ<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3E27B20", Offset = "0x3E26320", VA = "0x183E27B20", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x4DD2C30", Offset = "0x4DD1430", VA = "0x184DD2C30", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB012C0", Offset = "0xAFFAC0", VA = "0x180B012C0", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class UPKRLMCLHML<a> : SIHHPWCEWPJ<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3E27B20", Offset = "0x3E26320", VA = "0x183E27B20", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x4DD2C30", Offset = "0x4DD1430", VA = "0x184DD2C30", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB012C0", Offset = "0xAFFAC0", VA = "0x180B012C0", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class JIXJNNLUCLL<a> : SIHHPWCEWPJ<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x50EFFE0", Offset = "0x50EE7E0", VA = "0x1850EFFE0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x404CD40", Offset = "0x404B540", VA = "0x18404CD40", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x404CD20", Offset = "0x404B520", VA = "0x18404CD20", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x404CD70", Offset = "0x404B570", VA = "0x18404CD70")]
		public JIXJNNLUCLL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class ABCPZDIKHDL<a, b> : DIBGAVKLOIB<IGrouping<a, b>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x535DFF0", Offset = "0x535C7F0", VA = "0x18535DFF0", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x535DCA0", Offset = "0x535C4A0", VA = "0x18535DCA0", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class QLQGDMNVFEY<a, b> : DIBGAVKLOIB<ILookup<a, b>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5B807C0", Offset = "0x5B7EFC0", VA = "0x185B807C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5B80470", Offset = "0x5B7EC70", VA = "0x185B80470", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class GHKBHWPGGAY<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a UWHDEJCLXLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> ZEXLFFITBGK;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x4DC9830", Offset = "0x4DC8030", VA = "0x184DC9830", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x4DC9720", Offset = "0x4DC7F20", VA = "0x184DC9720")]
		public GHKBHWPGGAY(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x4DC9690", Offset = "0x4DC7E90", VA = "0x184DC9690", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x4DC9700", Offset = "0x4DC7F00", VA = "0x184DC9700", Slot = "6")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class BMIUAHSYSFV<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> JUGSBFLMEHJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x6F0F460", Offset = "0x6F0DC60", VA = "0x186F0F460", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public BMIUAHSYSFV(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F2D0", Offset = "0x6F0DAD0", VA = "0x186F0F2D0", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F3C0", Offset = "0x6F0DBC0", VA = "0x186F0F3C0", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F3C0", Offset = "0x6F0DBC0", VA = "0x186F0F3C0", Slot = "7")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class NRXHFGFOPOM<a> : DIBGAVKLOIB<a>, AZVSJTUQPQS where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5853210", Offset = "0x5851A10", VA = "0x185853210", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5853000", Offset = "0x5851800", VA = "0x185853000", Slot = "5")]
		public a Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public NRXHFGFOPOM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class UYCDCGNXINM : DIBGAVKLOIB<IEnumerable>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly DIBGAVKLOIB<IEnumerable> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8DB4EE0", Offset = "0x8DB36E0", VA = "0x188DB4EE0", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8DB4CE0", Offset = "0x8DB34E0", VA = "0x188DB4CE0", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public UYCDCGNXINM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class VGXZFZFJHKE : DIBGAVKLOIB<ICollection>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly DIBGAVKLOIB<ICollection> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5460", Offset = "0x8DB3C60", VA = "0x188DB5460", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5260", Offset = "0x8DB3A60", VA = "0x188DB5260", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public VGXZFZFJHKE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class DWGNSFYAWQI : DIBGAVKLOIB<IList>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly DIBGAVKLOIB<IList> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4280", Offset = "0x8DA2A80", VA = "0x188DA4280", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4080", Offset = "0x8DA2880", VA = "0x188DA4080", Slot = "5")]
		public IList Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public DWGNSFYAWQI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class ARBZFXTTHMP<a> : SICASPIHNEA<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3E27B20", Offset = "0x3E26320", VA = "0x183E27B20", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3E27C70", Offset = "0x3E26470", VA = "0x183E27C70", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class ZFPTSBBUDKB<a> : SIHHPWCEWPJ<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3E27B20", Offset = "0x3E26320", VA = "0x183E27B20", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3E27C70", Offset = "0x3E26470", VA = "0x183E27C70", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3E27C00", Offset = "0x3E26400", VA = "0x183E27C00", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class VTSOXOKESSZ<a> : SIHHPWCEWPJ<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x404CBD0", Offset = "0x404B3D0", VA = "0x18404CBD0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x404CD40", Offset = "0x404B540", VA = "0x18404CD40", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6274060", Offset = "0x6272860", VA = "0x186274060", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6274180", Offset = "0x6272980", VA = "0x186274180")]
		public VTSOXOKESSZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class DYBSRXHTWUB<a> : SIHHPWCEWPJ<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x404CBD0", Offset = "0x404B3D0", VA = "0x18404CBD0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x404CD40", Offset = "0x404B540", VA = "0x18404CD40", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x404CD20", Offset = "0x404B520", VA = "0x18404CD20", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x404CD70", Offset = "0x404B570", VA = "0x18404CD70")]
		public DYBSRXHTWUB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class KXXDEZZHXQT<a> : SIHHPWCEWPJ<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4F3CE00", Offset = "0x4F3B600", VA = "0x184F3CE00", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xB012C0", Offset = "0xAFFAC0", VA = "0x180B012C0", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5257560", Offset = "0x5255D60", VA = "0x185257560", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class ORKNWOZKMRP<a> : SICASPIHNEA<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3E27B20", Offset = "0x3E26320", VA = "0x183E27B20", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x4DD2C30", Offset = "0x4DD1430", VA = "0x184DD2C30", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class PMGPTHMOQUG<a> : SICASPIHNEA<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3E27B20", Offset = "0x3E26320", VA = "0x183E27B20", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x4DD2C30", Offset = "0x4DD1430", VA = "0x184DD2C30", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class FAIBGRQMGTN<a> : SIHHPWCEWPJ<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x404CC10", Offset = "0x404B410", VA = "0x18404CC10", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x404CD40", Offset = "0x404B540", VA = "0x18404CD40", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4C8D350", Offset = "0x4C8BB50", VA = "0x184C8D350", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class SQLSRTYGQOK
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
		[Cpp2IlInjected.Address(RVA = "0x8DB2B80", Offset = "0x8DB1380", VA = "0x188DB2B80")]
		public static DateTime NFYLEIFIMHY(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2C40", Offset = "0x8DB1440", VA = "0x188DB2C40")]
		public static bool VQWFVJWULBH(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8DB28F0", Offset = "0x8DB10F0", VA = "0x188DB28F0")]
		public static bool LZYGSZTNBOJ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8DB26E0", Offset = "0x8DB0EE0", VA = "0x188DB26E0")]
		public static bool LZYGSZTNBOJ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2DF0", Offset = "0x8DB15F0", VA = "0x188DB2DF0")]
		public static bool YJYWQSULDIX(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class ACGTFSTUKTQ : DIBGAVKLOIB<DateTime>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly DIBGAVKLOIB<DateTime> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8DA14A0", Offset = "0x8D9FCA0", VA = "0x188DA14A0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8DA1320", Offset = "0x8D9FB20", VA = "0x188DA1320", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0F20", Offset = "0x8D9F720", VA = "0x188DA0F20")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public ACGTFSTUKTQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class BLAAVWNCTML : DIBGAVKLOIB<DateTimeOffset>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly DIBGAVKLOIB<DateTimeOffset> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8DA2E00", Offset = "0x8DA1600", VA = "0x188DA2E00", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8DA29B0", Offset = "0x8DA11B0", VA = "0x188DA29B0", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8DA2A20", Offset = "0x8DA1220", VA = "0x188DA2A20")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public BLAAVWNCTML()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class LDXBFFOUKLU : DIBGAVKLOIB<TimeSpan>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly DIBGAVKLOIB<TimeSpan> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] WUDJSGGXVNM;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8DABFF0", Offset = "0x8DAA7F0", VA = "0x188DABFF0", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8DABF70", Offset = "0x8DAA770", VA = "0x188DABF70", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8DABB80", Offset = "0x8DAA380", VA = "0x188DABB80")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public LDXBFFOUKLU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class XOWVVJTTUFX<a, b, c, d, e> : DIBGAVKLOIB<e>, AZVSJTUQPQS where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3B00", Offset = "0x3DD2300", VA = "0x183DD3B00", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3730", Offset = "0x3DD1F30", VA = "0x183DD3730", Slot = "5")]
		public e Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d CKEBFKHTHCC(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		protected XOWVVJTTUFX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class XOROYCZWKUO<a, b, c, d> : XOWVVJTTUFX<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3DD36A0", Offset = "0x3DD1EA0", VA = "0x183DD36A0", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> CKEBFKHTHCC(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3DD3710", Offset = "0x3DD1F10", VA = "0x183DD3710")]
		protected XOROYCZWKUO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class XPHJPXHONCP<a, b, c> : XOROYCZWKUO<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xB012C0", Offset = "0xAFFAC0", VA = "0x180B012C0", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class OHOUSGVWJBX<a, b> : XOWVVJTTUFX<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x59F43F0", Offset = "0x59F2BF0", VA = "0x1859F43F0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xB012C0", Offset = "0xAFFAC0", VA = "0x180B012C0", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x59F46E0", Offset = "0x59F2EE0", VA = "0x1859F46E0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x59F4560", Offset = "0x59F2D60", VA = "0x1859F4560", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator CKEBFKHTHCC(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x53496A0", Offset = "0x5347EA0", VA = "0x1853496A0")]
		public OHOUSGVWJBX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class AFBVZUTZJDZ<a, b, c> : XPHJPXHONCP<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5364C70", Offset = "0x5363470", VA = "0x185364C70", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5364E50", Offset = "0x5363650", VA = "0x185364E50", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class FLLEYVCTBCG<a, b> : XOROYCZWKUO<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x4C90520", Offset = "0x4C8ED20", VA = "0x184C90520", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x4C90690", Offset = "0x4C8EE90", VA = "0x184C90690", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB012C0", Offset = "0xAFFAC0", VA = "0x180B012C0", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class JLFMTROKQTI<a, b> : XPHJPXHONCP<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x4C90520", Offset = "0x4C8ED20", VA = "0x184C90520", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x4C90690", Offset = "0x4C8EE90", VA = "0x184C90690", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class UDGGTVKSNVY<a, b> : XOWVVJTTUFX<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x4C90520", Offset = "0x4C8ED20", VA = "0x184C90520", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB012C0", Offset = "0xAFFAC0", VA = "0x180B012C0", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x4C90690", Offset = "0x4C8EE90", VA = "0x184C90690", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x61018A0", Offset = "0x61000A0", VA = "0x1861018A0", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator CKEBFKHTHCC(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class MOQISVOZDRV<a, b> : XOROYCZWKUO<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x4C90520", Offset = "0x4C8ED20", VA = "0x184C90520", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x57D32D0", Offset = "0x57D1AD0", VA = "0x1857D32D0", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x57D3340", Offset = "0x57D1B40", VA = "0x1857D3340", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class ANSKKCDNIQI<a, b> : XOROYCZWKUO<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x5368110", Offset = "0x5366910", VA = "0x185368110", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xB012C0", Offset = "0xAFFAC0", VA = "0x180B012C0", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x5368150", Offset = "0x5366950", VA = "0x185368150", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x5368210", Offset = "0x5366A10", VA = "0x185368210")]
		public ANSKKCDNIQI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class RXJCEWQTWYC<a, b> : XPHJPXHONCP<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9110", Offset = "0x5BE7910", VA = "0x185BE9110", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x4C90690", Offset = "0x4C8EE90", VA = "0x184C90690", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class XAAAZXBYGGA<a> : DIBGAVKLOIB<a>, AZVSJTUQPQS where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3DC41B0", Offset = "0x3DC29B0", VA = "0x183DC41B0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3F80", Offset = "0x3DC2780", VA = "0x183DC3F80", Slot = "5")]
		public a Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public XAAAZXBYGGA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class YNMVOQXSHSI : DIBGAVKLOIB<IDictionary>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly DIBGAVKLOIB<IDictionary> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8DBA090", Offset = "0x8DB8890", VA = "0x188DBA090", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8DB9EB0", Offset = "0x8DB86B0", VA = "0x188DB9EB0", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public YNMVOQXSHSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class GELXODEBWQU
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8DA6500", Offset = "0x8DA4D00", VA = "0x188DA6500")]
		public static object XPDPZANXUEW(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8DA5D40", Offset = "0x8DA4540", VA = "0x188DA5D40")]
		public static object VMEWGAJEMTR(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class HTOQVGVVGQP<a> : DIBGAVKLOIB<a>, AZVSJTUQPQS, UTAUQVHKHHS<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class FVTRMYHTPKV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type PUQVJDXVEJZ;

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public FVTRMYHTPKV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x4CA3D40", Offset = "0x4CA2540", VA = "0x184CA3D40")]
			internal bool NKVYFJIMENI(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class FVOKPRNWFZM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string QBQRFWROJHX;

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public FVOKPRNWFZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x4CA1E40", Offset = "0x4CA0640", VA = "0x184CA1E40")]
			internal bool NLBFCQCJNYR(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class FVJDSKTYWOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> PLHOYQQVJGS;

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public FVJDSKTYWOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x4CA1420", Offset = "0x4C9FC20", VA = "0x184CA1420")]
			internal void NKLKKVURLQQ(JsonWriter a, a b, KIVYKHMZUOQ c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class FVDWVEABNCU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> AHACFAJTMTV;

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public FVDWVEABNCU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x4CA0E90", Offset = "0x4C9F690", VA = "0x184CA0E90")]
			internal a NKQRICOOVBZ(JsonReader a, KIVYKHMZUOQ b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly CQWMVTINDBM<a> RCPACFLCGAR;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> VXXSRKWHNNZ;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> TPVQLQHCOWN;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> AYACDPLWWAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool SSGKSKSJJYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> HFFUAABMTQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> XKMSBTPWDKN;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x4E64880", Offset = "0x4E63080", VA = "0x184E64880")]
		static HTOQVGVVGQP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x4E72BC0", Offset = "0x4E713C0", VA = "0x184E72BC0")]
		public HTOQVGVVGQP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x4E5CF70", Offset = "0x4E5B770", VA = "0x184E5CF70", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x4E593B0", Offset = "0x4E57BB0", VA = "0x184E593B0", Slot = "5")]
		public a Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x4E5E120", Offset = "0x4E5C920", VA = "0x184E5E120", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, a b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x4E5B740", Offset = "0x4E59F40", VA = "0x184E5B740", Slot = "7")]
		public a LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class GPYOUSVTFHX<a> : DIBGAVKLOIB<a[,]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x4DD35A0", Offset = "0x4DD1DA0", VA = "0x184DD35A0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x4DD3210", Offset = "0x4DD1A10", VA = "0x184DD3210", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public GPYOUSVTFHX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class SUAFPOMXAEP<a> : DIBGAVKLOIB<a[,,]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E32900", Offset = "0x5E31100", VA = "0x185E32900", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E32430", Offset = "0x5E30C30", VA = "0x185E32430", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public SUAFPOMXAEP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class VWJDNIKSVQJ<a> : DIBGAVKLOIB<a[,,,]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x62774F0", Offset = "0x6275CF0", VA = "0x1862774F0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6276EF0", Offset = "0x62756F0", VA = "0x186276EF0", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public VWJDNIKSVQJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class EQUCOFEWHGX<a> : DIBGAVKLOIB<a?>, AZVSJTUQPQS where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x4683300", Offset = "0x4681B00", VA = "0x184683300", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x4683060", Offset = "0x4681860", VA = "0x184683060", Slot = "5")]
		public a? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public EQUCOFEWHGX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class VAFGWCFUQFX<a> : DIBGAVKLOIB<a?>, AZVSJTUQPQS where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly DIBGAVKLOIB<a> UZIZNFXPGUO;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE900", Offset = "0xAAD100", VA = "0x180AAE900")]
		public VAFGWCFUQFX(DIBGAVKLOIB<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x625A480", Offset = "0x6258C80", VA = "0x18625A480", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x6259560", Offset = "0x6257D60", VA = "0x186259560", Slot = "5")]
		public a? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class JZBCKEYGZDK : DIBGAVKLOIB<sbyte>, AZVSJTUQPQS, UTAUQVHKHHS<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly JZBCKEYGZDK WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8DAAA00", Offset = "0x8DA9200", VA = "0x188DAAA00", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8DAA970", Offset = "0x8DA9170", VA = "0x188DAA970", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8DAAA90", Offset = "0x8DA9290", VA = "0x188DAAA90", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, sbyte b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8DAA980", Offset = "0x8DA9180", VA = "0x188DAA980", Slot = "7")]
		public sbyte LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public JZBCKEYGZDK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class OLJHXRMCGKV : DIBGAVKLOIB<sbyte?>, AZVSJTUQPQS, UTAUQVHKHHS<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly OLJHXRMCGKV WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8DAEC30", Offset = "0x8DAD430", VA = "0x188DAEC30", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8DAEAF0", Offset = "0x8DAD2F0", VA = "0x188DAEAF0", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8DAED20", Offset = "0x8DAD520", VA = "0x188DAED20", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, sbyte? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8DAEB60", Offset = "0x8DAD360", VA = "0x188DAEB60", Slot = "7")]
		public sbyte? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public OLJHXRMCGKV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class ECEKMVJRFTN : DIBGAVKLOIB<sbyte[]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly ECEKMVJRFTN WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4FE0", Offset = "0x8DA37E0", VA = "0x188DA4FE0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4EA0", Offset = "0x8DA36A0", VA = "0x188DA4EA0", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public ECEKMVJRFTN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class RJPZDVYGYTR : DIBGAVKLOIB<short>, AZVSJTUQPQS, UTAUQVHKHHS<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly RJPZDVYGYTR WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1A70", Offset = "0x8DB0270", VA = "0x188DB1A70", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8DB19E0", Offset = "0x8DB01E0", VA = "0x188DB19E0", Slot = "5")]
		public short Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1B00", Offset = "0x8DB0300", VA = "0x188DB1B00", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, short b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8DB19F0", Offset = "0x8DB01F0", VA = "0x188DB19F0", Slot = "7")]
		public short LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public RJPZDVYGYTR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class TWSSPWYPXWG : DIBGAVKLOIB<short?>, AZVSJTUQPQS, UTAUQVHKHHS<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly TWSSPWYPXWG WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3A70", Offset = "0x8DB2270", VA = "0x188DB3A70", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3930", Offset = "0x8DB2130", VA = "0x188DB3930", Slot = "5")]
		public short? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3B60", Offset = "0x8DB2360", VA = "0x188DB3B60", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, short? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8DB39A0", Offset = "0x8DB21A0", VA = "0x188DB39A0", Slot = "7")]
		public short? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public TWSSPWYPXWG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class NTALBYZLXDM : DIBGAVKLOIB<short[]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly NTALBYZLXDM WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8DAE420", Offset = "0x8DACC20", VA = "0x188DAE420", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8DAE2E0", Offset = "0x8DACAE0", VA = "0x188DAE2E0", Slot = "5")]
		public short[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public NTALBYZLXDM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class IBBSZNBKART : DIBGAVKLOIB<int>, AZVSJTUQPQS, UTAUQVHKHHS<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly IBBSZNBKART WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8C20", Offset = "0x8DA7420", VA = "0x188DA8C20", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8B90", Offset = "0x8DA7390", VA = "0x188DA8B90", Slot = "5")]
		public int Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8CB0", Offset = "0x8DA74B0", VA = "0x188DA8CB0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, int b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8BA0", Offset = "0x8DA73A0", VA = "0x188DA8BA0", Slot = "7")]
		public int LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public IBBSZNBKART()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class HXXBTZIBXBC : DIBGAVKLOIB<int?>, AZVSJTUQPQS, UTAUQVHKHHS<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly HXXBTZIBXBC WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8DA88D0", Offset = "0x8DA70D0", VA = "0x188DA88D0", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8790", Offset = "0x8DA6F90", VA = "0x188DA8790", Slot = "5")]
		public int? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8DA89C0", Offset = "0x8DA71C0", VA = "0x188DA89C0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, int? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8800", Offset = "0x8DA7000", VA = "0x188DA8800", Slot = "7")]
		public int? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public HXXBTZIBXBC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class USJWGHLXXKQ : DIBGAVKLOIB<int[]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly USJWGHLXXKQ WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8DB4A40", Offset = "0x8DB3240", VA = "0x188DB4A40", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8DB4900", Offset = "0x8DB3100", VA = "0x188DB4900", Slot = "5")]
		public int[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public USJWGHLXXKQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class RUXGZRWAGRG : DIBGAVKLOIB<long>, AZVSJTUQPQS, UTAUQVHKHHS<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly RUXGZRWAGRG WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8DB22A0", Offset = "0x8DB0AA0", VA = "0x188DB22A0", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2250", Offset = "0x8DB0A50", VA = "0x188DB2250", Slot = "5")]
		public long Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2300", Offset = "0x8DB0B00", VA = "0x188DB2300", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, long b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2260", Offset = "0x8DB0A60", VA = "0x188DB2260", Slot = "7")]
		public long LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public RUXGZRWAGRG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class BOLCJZZXLTX : DIBGAVKLOIB<long?>, AZVSJTUQPQS, UTAUQVHKHHS<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly BOLCJZZXLTX WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3A40", Offset = "0x8DA2240", VA = "0x188DA3A40", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3900", Offset = "0x8DA2100", VA = "0x188DA3900", Slot = "5")]
		public long? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3B00", Offset = "0x8DA2300", VA = "0x188DA3B00", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, long? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3990", Offset = "0x8DA2190", VA = "0x188DA3990", Slot = "7")]
		public long? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public BOLCJZZXLTX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class KKNMFSKFQVR : DIBGAVKLOIB<long[]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly KKNMFSKFQVR WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB3D0", Offset = "0x8DA9BD0", VA = "0x188DAB3D0", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB290", Offset = "0x8DA9A90", VA = "0x188DAB290", Slot = "5")]
		public long[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public KKNMFSKFQVR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class RZGQADYGLUV : DIBGAVKLOIB<byte>, AZVSJTUQPQS, UTAUQVHKHHS<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly RZGQADYGLUV WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8DB24D0", Offset = "0x8DB0CD0", VA = "0x188DB24D0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2440", Offset = "0x8DB0C40", VA = "0x188DB2440", Slot = "5")]
		public byte Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2560", Offset = "0x8DB0D60", VA = "0x188DB2560", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, byte b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2450", Offset = "0x8DB0C50", VA = "0x188DB2450", Slot = "7")]
		public byte LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public RZGQADYGLUV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class APYRVSUZUXY : DIBGAVKLOIB<byte?>, AZVSJTUQPQS, UTAUQVHKHHS<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly APYRVSUZUXY WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8DA2200", Offset = "0x8DA0A00", VA = "0x188DA2200", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8DA20C0", Offset = "0x8DA08C0", VA = "0x188DA20C0", Slot = "5")]
		public byte? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8DA22F0", Offset = "0x8DA0AF0", VA = "0x188DA22F0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, byte? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA2130", Offset = "0x8DA0930", VA = "0x188DA2130", Slot = "7")]
		public byte? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public APYRVSUZUXY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class KKKBLRWGEWC : DIBGAVKLOIB<ushort>, AZVSJTUQPQS, UTAUQVHKHHS<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly KKKBLRWGEWC WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB080", Offset = "0x8DA9880", VA = "0x188DAB080", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8DAAFF0", Offset = "0x8DA97F0", VA = "0x188DAAFF0", Slot = "5")]
		public ushort Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB110", Offset = "0x8DA9910", VA = "0x188DAB110", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, ushort b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB000", Offset = "0x8DA9800", VA = "0x188DAB000", Slot = "7")]
		public ushort LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public KKKBLRWGEWC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class LJYKHWXMSIZ : DIBGAVKLOIB<ushort?>, AZVSJTUQPQS, UTAUQVHKHHS<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly LJYKHWXMSIZ WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8DAD980", Offset = "0x8DAC180", VA = "0x188DAD980", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8DAD840", Offset = "0x8DAC040", VA = "0x188DAD840", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8DADA70", Offset = "0x8DAC270", VA = "0x188DADA70", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, ushort? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8DAD8B0", Offset = "0x8DAC0B0", VA = "0x188DAD8B0", Slot = "7")]
		public ushort? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public LJYKHWXMSIZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class URBLEOWPUIN : DIBGAVKLOIB<ushort[]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly URBLEOWPUIN WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x8DB4660", Offset = "0x8DB2E60", VA = "0x188DB4660", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8DB4520", Offset = "0x8DB2D20", VA = "0x188DB4520", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public URBLEOWPUIN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class WTFTWLKDUQA : DIBGAVKLOIB<uint>, AZVSJTUQPQS, UTAUQVHKHHS<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly WTFTWLKDUQA WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8DB9570", Offset = "0x8DB7D70", VA = "0x188DB9570", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8DB94E0", Offset = "0x8DB7CE0", VA = "0x188DB94E0", Slot = "5")]
		public uint Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8DB9600", Offset = "0x8DB7E00", VA = "0x188DB9600", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, uint b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8DB94F0", Offset = "0x8DB7CF0", VA = "0x188DB94F0", Slot = "7")]
		public uint LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public WTFTWLKDUQA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class XZUSVXAQBPB : DIBGAVKLOIB<uint?>, AZVSJTUQPQS, UTAUQVHKHHS<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly XZUSVXAQBPB WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8DB98C0", Offset = "0x8DB80C0", VA = "0x188DB98C0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8DB9780", Offset = "0x8DB7F80", VA = "0x188DB9780", Slot = "5")]
		public uint? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x8DB99B0", Offset = "0x8DB81B0", VA = "0x188DB99B0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, uint? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8DB97F0", Offset = "0x8DB7FF0", VA = "0x188DB97F0", Slot = "7")]
		public uint? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public XZUSVXAQBPB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class RNCIMXPDPWL : DIBGAVKLOIB<uint[]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly RNCIMXPDPWL WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1FB0", Offset = "0x8DB07B0", VA = "0x188DB1FB0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1E70", Offset = "0x8DB0670", VA = "0x188DB1E70", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public RNCIMXPDPWL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class ACFPGCTMUOV : DIBGAVKLOIB<ulong>, AZVSJTUQPQS, UTAUQVHKHHS<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly ACFPGCTMUOV WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0D80", Offset = "0x8D9F580", VA = "0x188DA0D80", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0D30", Offset = "0x8D9F530", VA = "0x188DA0D30", Slot = "5")]
		public ulong Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0DE0", Offset = "0x8D9F5E0", VA = "0x188DA0DE0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, ulong b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0D40", Offset = "0x8D9F540", VA = "0x188DA0D40", Slot = "7")]
		public ulong LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public ACFPGCTMUOV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class VIQWJAAITXY : DIBGAVKLOIB<ulong?>, AZVSJTUQPQS, UTAUQVHKHHS<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly VIQWJAAITXY WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5A50", Offset = "0x8DB4250", VA = "0x188DB5A50", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5910", Offset = "0x8DB4110", VA = "0x188DB5910", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5B10", Offset = "0x8DB4310", VA = "0x188DB5B10", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, ulong? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8DB59A0", Offset = "0x8DB41A0", VA = "0x188DB59A0", Slot = "7")]
		public ulong? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public VIQWJAAITXY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class TULXZXAVUSI : DIBGAVKLOIB<ulong[]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly TULXZXAVUSI WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3700", Offset = "0x8DB1F00", VA = "0x188DB3700", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8DB35C0", Offset = "0x8DB1DC0", VA = "0x188DB35C0", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public TULXZXAVUSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class RLOBSVYILLN : DIBGAVKLOIB<float>, AZVSJTUQPQS, UTAUQVHKHHS<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly RLOBSVYILLN WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1CD0", Offset = "0x8DB04D0", VA = "0x188DB1CD0", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1C80", Offset = "0x8DB0480", VA = "0x188DB1C80", Slot = "5")]
		public float Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1D30", Offset = "0x8DB0530", VA = "0x188DB1D30", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, float b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1C90", Offset = "0x8DB0490", VA = "0x188DB1C90", Slot = "7")]
		public float LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public RLOBSVYILLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class IWHFLUHEDCE : DIBGAVKLOIB<float?>, AZVSJTUQPQS, UTAUQVHKHHS<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly IWHFLUHEDCE WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x8DAA530", Offset = "0x8DA8D30", VA = "0x188DAA530", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8DAA420", Offset = "0x8DA8C20", VA = "0x188DAA420", Slot = "5")]
		public float? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x8DAA5F0", Offset = "0x8DA8DF0", VA = "0x188DAA5F0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, float? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8DAA490", Offset = "0x8DA8C90", VA = "0x188DAA490", Slot = "7")]
		public float? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public IWHFLUHEDCE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class MNTKFGSMQYW : DIBGAVKLOIB<float[]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly MNTKFGSMQYW WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8DADF50", Offset = "0x8DAC750", VA = "0x188DADF50", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8DADE10", Offset = "0x8DAC610", VA = "0x188DADE10", Slot = "5")]
		public float[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public MNTKFGSMQYW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class BKWQFXCVBCY : DIBGAVKLOIB<double>, AZVSJTUQPQS, UTAUQVHKHHS<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly BKWQFXCVBCY WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8DA2810", Offset = "0x8DA1010", VA = "0x188DA2810", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8DA27C0", Offset = "0x8DA0FC0", VA = "0x188DA27C0", Slot = "5")]
		public double Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8DA2870", Offset = "0x8DA1070", VA = "0x188DA2870", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, double b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8DA27D0", Offset = "0x8DA0FD0", VA = "0x188DA27D0", Slot = "7")]
		public double LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public BKWQFXCVBCY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class ZWQGWPPIJYH : DIBGAVKLOIB<double?>, AZVSJTUQPQS, UTAUQVHKHHS<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly ZWQGWPPIJYH WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8DBAE80", Offset = "0x8DB9680", VA = "0x188DBAE80", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8DBAD40", Offset = "0x8DB9540", VA = "0x188DBAD40", Slot = "5")]
		public double? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8DBAF40", Offset = "0x8DB9740", VA = "0x188DBAF40", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, double? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8DBADD0", Offset = "0x8DB95D0", VA = "0x188DBADD0", Slot = "7")]
		public double? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public ZWQGWPPIJYH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class IHPHTWQCVJN : DIBGAVKLOIB<double[]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly IHPHTWQCVJN WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8F70", Offset = "0x8DA7770", VA = "0x188DA8F70", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8E30", Offset = "0x8DA7630", VA = "0x188DA8E30", Slot = "5")]
		public double[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public IHPHTWQCVJN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class KAXTSPOBSXT : DIBGAVKLOIB<bool>, AZVSJTUQPQS, UTAUQVHKHHS<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly KAXTSPOBSXT WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8DAAC60", Offset = "0x8DA9460", VA = "0x188DAAC60", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8DAAC10", Offset = "0x8DA9410", VA = "0x188DAAC10", Slot = "5")]
		public bool Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8DAACC0", Offset = "0x8DA94C0", VA = "0x188DAACC0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, bool b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8DAAC20", Offset = "0x8DA9420", VA = "0x188DAAC20", Slot = "7")]
		public bool LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public KAXTSPOBSXT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class PJQFLLEOLII : DIBGAVKLOIB<bool?>, AZVSJTUQPQS, UTAUQVHKHHS<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly PJQFLLEOLII WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8DB14A0", Offset = "0x8DAFCA0", VA = "0x188DB14A0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1390", Offset = "0x8DAFB90", VA = "0x188DB1390", Slot = "5")]
		public bool? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1560", Offset = "0x8DAFD60", VA = "0x188DB1560", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, bool? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1400", Offset = "0x8DAFC00", VA = "0x188DB1400", Slot = "7")]
		public bool? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public PJQFLLEOLII()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class GCZSMHPKFKU : DIBGAVKLOIB<bool[]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly GCZSMHPKFKU WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x8DA59B0", Offset = "0x8DA41B0", VA = "0x188DA59B0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA5870", Offset = "0x8DA4070", VA = "0x188DA5870", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public GCZSMHPKFKU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class HRXNIBIVHLK : DIBGAVKLOIB<byte[]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly DIBGAVKLOIB<byte[]> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8660", Offset = "0x8DA6E60", VA = "0x188DA8660", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x8DA85F0", Offset = "0x8DA6DF0", VA = "0x188DA85F0", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public HRXNIBIVHLK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class FAVKWTSARCP : DIBGAVKLOIB<ArraySegment<byte>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly DIBGAVKLOIB<ArraySegment<byte>> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x8DA56D0", Offset = "0x8DA3ED0", VA = "0x188DA56D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x8DA5600", Offset = "0x8DA3E00", VA = "0x188DA5600", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public FAVKWTSARCP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class KVIDOGJMZKH : DIBGAVKLOIB<string>, AZVSJTUQPQS, UTAUQVHKHHS<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly DIBGAVKLOIB<string> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB610", Offset = "0x8DA9E10", VA = "0x188DAB610", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB600", Offset = "0x8DA9E00", VA = "0x188DAB600", Slot = "5")]
		public string Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB670", Offset = "0x8DA9E70", VA = "0x188DAB670", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, string b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB600", Offset = "0x8DA9E00", VA = "0x188DAB600", Slot = "7")]
		public string LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public KVIDOGJMZKH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class EZJSEQKWANM : DIBGAVKLOIB<string[]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly EZJSEQKWANM WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8DA53D0", Offset = "0x8DA3BD0", VA = "0x188DA53D0", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x8DA5280", Offset = "0x8DA3A80", VA = "0x188DA5280", Slot = "5")]
		public string[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public EZJSEQKWANM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class PZZIKHHVDDV : DIBGAVKLOIB<char>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly PZZIKHHVDDV WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8DB18C0", Offset = "0x8DB00C0", VA = "0x188DB18C0", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1890", Offset = "0x8DB0090", VA = "0x188DB1890", Slot = "5")]
		public char Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public PZZIKHHVDDV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class ZILHIWGOQOM : DIBGAVKLOIB<char?>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly ZILHIWGOQOM WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8DBABD0", Offset = "0x8DB93D0", VA = "0x188DBABD0", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x8DBAB10", Offset = "0x8DB9310", VA = "0x188DBAB10", Slot = "5")]
		public char? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public ZILHIWGOQOM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class LBCJGAKBJRQ : DIBGAVKLOIB<char[]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly LBCJGAKBJRQ WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB8D0", Offset = "0x8DAA0D0", VA = "0x188DAB8D0", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB740", Offset = "0x8DA9F40", VA = "0x188DAB740", Slot = "5")]
		public char[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public LBCJGAKBJRQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class OFBTTRZIDUM : DIBGAVKLOIB<Guid>, AZVSJTUQPQS, UTAUQVHKHHS<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly DIBGAVKLOIB<Guid> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8DAE790", Offset = "0x8DACF90", VA = "0x188DAE790", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8DAE6C0", Offset = "0x8DACEC0", VA = "0x188DAE6C0", Slot = "5")]
		public Guid Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8DAE900", Offset = "0x8DAD100", VA = "0x188DAE900", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, Guid b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8DAE720", Offset = "0x8DACF20", VA = "0x188DAE720", Slot = "7")]
		public Guid LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public OFBTTRZIDUM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class ZFHCGTFBQBK : DIBGAVKLOIB<decimal>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly DIBGAVKLOIB<decimal> WUXFTMOSJKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool MIDEMDRFOJU;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x71A7630", Offset = "0x71A5E30", VA = "0x1871A7630")]
		public ZFHCGTFBQBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xD8B460", Offset = "0xD89C60", VA = "0x180D8B460")]
		public ZFHCGTFBQBK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8DBA8C0", Offset = "0x8DB90C0", VA = "0x188DBA8C0", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x8DBA6F0", Offset = "0x8DB8EF0", VA = "0x188DBA6F0", Slot = "5")]
		public decimal Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class LMAKDJWEIEP : DIBGAVKLOIB<Uri>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly DIBGAVKLOIB<Uri> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8DADCC0", Offset = "0x8DAC4C0", VA = "0x188DADCC0", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8DADC40", Offset = "0x8DAC440", VA = "0x188DADC40", Slot = "5")]
		public Uri Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public LMAKDJWEIEP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class INOZISJRRWF : DIBGAVKLOIB<Version>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly DIBGAVKLOIB<Version> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8DA9370", Offset = "0x8DA7B70", VA = "0x188DA9370", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x8DA92F0", Offset = "0x8DA7AF0", VA = "0x188DA92F0", Slot = "5")]
		public Version Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public INOZISJRRWF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class WQZVYRXSTFP<a, b> : DIBGAVKLOIB<KeyValuePair<a, b>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x661D4A0", Offset = "0x661BCA0", VA = "0x18661D4A0", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x661CFD0", Offset = "0x661B7D0", VA = "0x18661CFD0", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class WGTMTDCLKTD : DIBGAVKLOIB<StringBuilder>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly DIBGAVKLOIB<StringBuilder> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7900", Offset = "0x8DB6100", VA = "0x188DB7900", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7880", Offset = "0x8DB6080", VA = "0x188DB7880", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public WGTMTDCLKTD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class OVZCXPWCIZB : DIBGAVKLOIB<BitArray>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly DIBGAVKLOIB<BitArray> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8DB11A0", Offset = "0x8DAF9A0", VA = "0x188DB11A0", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1080", Offset = "0x8DAF880", VA = "0x188DB1080", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public OVZCXPWCIZB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class AZJFDLHJBCH : DIBGAVKLOIB<Type>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly AZJFDLHJBCH WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex NKJGMIUOZQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool GXSVMJBVXPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool TSWCWTYVMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool DAFXCDVRMRU;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8DA27A0", Offset = "0x8DA0FA0", VA = "0x188DA27A0")]
		public AZJFDLHJBCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x80FFA30", Offset = "0x80FE230", VA = "0x1880FFA30")]
		public AZJFDLHJBCH(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8DA25D0", Offset = "0x8DA0DD0", VA = "0x188DA25D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x8DA24C0", Offset = "0x8DA0CC0", VA = "0x188DA24C0", Slot = "5")]
		public Type Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class JWCWQIVHORN : DIBGAVKLOIB<BigInteger>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly DIBGAVKLOIB<BigInteger> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8DAA830", Offset = "0x8DA9030", VA = "0x188DAA830", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8DAA780", Offset = "0x8DA8F80", VA = "0x188DAA780", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public JWCWQIVHORN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class DPTUFBPZEYR : DIBGAVKLOIB<Complex>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly DIBGAVKLOIB<Complex> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3EE0", Offset = "0x8DA26E0", VA = "0x188DA3EE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3E50", Offset = "0x8DA2650", VA = "0x188DA3E50", Slot = "5")]
		public Complex Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public DPTUFBPZEYR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class YGHSNDBBFQL : DIBGAVKLOIB<ExpandoObject>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly DIBGAVKLOIB<ExpandoObject> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8DB9DB0", Offset = "0x8DB85B0", VA = "0x188DB9DB0", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8DB9B80", Offset = "0x8DB8380", VA = "0x188DB9B80", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public YGHSNDBBFQL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class IXKJPXVVHLE<a> : DIBGAVKLOIB<Lazy<a>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x4FEEA70", Offset = "0x4FED270", VA = "0x184FEEA70", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x4FEE880", Offset = "0x4FED080", VA = "0x184FEE880", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class KFXMIWBKARI : DIBGAVKLOIB<Task>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly DIBGAVKLOIB<Task> WUXFTMOSJKM;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task QZLDUJDFIFP;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8DAAEB0", Offset = "0x8DA96B0", VA = "0x188DAAEB0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8DAAE00", Offset = "0x8DA9600", VA = "0x188DAAE00", Slot = "5")]
		public Task Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public KFXMIWBKARI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class MJRDBXQPIVC<a> : DIBGAVKLOIB<Task<a>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x57D2530", Offset = "0x57D0D30", VA = "0x1857D2530", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x57D2340", Offset = "0x57D0B40", VA = "0x1857D2340", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class PAIYOXHGOLU<a> : DIBGAVKLOIB<ValueTask<a>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5ABF0B0", Offset = "0x5ABD8B0", VA = "0x185ABF0B0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5ABEE90", Offset = "0x5ABD690", VA = "0x185ABEE90", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class YUHYCPXRRGM<a> : DIBGAVKLOIB<Tuple<a>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF210", Offset = "0x3DFDA10", VA = "0x183DFF210", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x3DFEF40", Offset = "0x3DFD740", VA = "0x183DFEF40", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class YUXSUKFJTON<a, b> : DIBGAVKLOIB<Tuple<a, b>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x3E005C0", Offset = "0x3DFEDC0", VA = "0x183E005C0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x3E001A0", Offset = "0x3DFE9A0", VA = "0x183E001A0", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class YUSLXDLMKDE<a, b, c> : DIBGAVKLOIB<Tuple<a, b, c>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFB30", Offset = "0x3DFE330", VA = "0x183DFFB30", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF5D0", Offset = "0x3DFDDD0", VA = "0x183DFF5D0", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class YTSDKVPZOYL<a, b, c, d> : DIBGAVKLOIB<Tuple<a, b, c, d>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x3DFBBE0", Offset = "0x3DFA3E0", VA = "0x183DFBBE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x3DFB520", Offset = "0x3DF9D20", VA = "0x183DFB520", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class YTMWNOWCFNC<a, b, c, d, e> : DIBGAVKLOIB<Tuple<a, b, c, d, e>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x3DFABE0", Offset = "0x3DF93E0", VA = "0x183DFABE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x3DFA3D0", Offset = "0x3DF8BD0", VA = "0x183DFA3D0", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class YUCRFJDUHVD<a, b, c, d, e, f> : DIBGAVKLOIB<Tuple<a, b, c, d, e, f>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x3DFE490", Offset = "0x3DFCC90", VA = "0x183DFE490", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x3DFDB00", Offset = "0x3DFC300", VA = "0x183DFDB00", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class YTXKICJWYJU<a, b, c, d, e, f, g> : DIBGAVKLOIB<Tuple<a, b, c, d, e, f, g>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x3DFCEE0", Offset = "0x3DFB6E0", VA = "0x183DFCEE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x3DFC3C0", Offset = "0x3DFABC0", VA = "0x183DFC3C0", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class YSXBVUOKDFB<a, b, c, d, e, f, g, h> : DIBGAVKLOIB<Tuple<a, b, c, d, e, f, g, h>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x3DF95E0", Offset = "0x3DF7DE0", VA = "0x183DF95E0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x3DF8950", Offset = "0x3DF7150", VA = "0x183DF8950", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class NVVUOASYWNJ<a> : DIBGAVKLOIB<ValueTuple<a>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x5858250", Offset = "0x5856A50", VA = "0x185858250", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x5857E30", Offset = "0x5856630", VA = "0x185857E30", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class NWBBLHMWFYS<a, b> : DIBGAVKLOIB<(a, b)>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5858C10", Offset = "0x5857410", VA = "0x185858C10", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5858720", Offset = "0x5856F20", VA = "0x185858720", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class NWGIIOGTPKB<a, b, c> : DIBGAVKLOIB<(a, b, c)>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x585A170", Offset = "0x5858970", VA = "0x18585A170", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x5859B00", Offset = "0x5858300", VA = "0x185859B00", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class NWLPFVAQYVK<a, b, c, d> : DIBGAVKLOIB<(a, b, c, d)>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x585B330", Offset = "0x5859B30", VA = "0x18585B330", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x585AAF0", Offset = "0x58592F0", VA = "0x18585AAF0", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class NWQWDBUOIGT<a, b, c, d, e> : DIBGAVKLOIB<(a, b, c, d, e)>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x585C5D0", Offset = "0x585ADD0", VA = "0x18585C5D0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x585BC10", Offset = "0x585A410", VA = "0x18585BC10", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class NWWDAIOLRSC<a, b, c, d, e, f> : DIBGAVKLOIB<(a, b, c, d, e, f)>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x585DDB0", Offset = "0x585C5B0", VA = "0x18585DDB0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x585D1E0", Offset = "0x585B9E0", VA = "0x18585D1E0", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class NXBJXPIJBDL<a, b, c, d, e, f, g> : DIBGAVKLOIB<(a, b, c, d, e, f, g)>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x585F900", Offset = "0x585E100", VA = "0x18585F900", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x585EB90", Offset = "0x585D390", VA = "0x18585EB90", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class NXGQUWCGKOU<a, b, c, d, e, f, g, h> : DIBGAVKLOIB<ValueTuple<a, b, c, d, e, f, g, h>>, AZVSJTUQPQS where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] VFPYZGXPKLZ;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly QBWQRZLRZND JPNUUMQDIDV;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x58615E0", Offset = "0x585FDE0", VA = "0x1858615E0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x58606B0", Offset = "0x585EEB0", VA = "0x1858606B0", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class PRVUCTIUQAT
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] PMBTACBUJYR;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly QBWQRZLRZND PFEPJPVPVOA;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8DB16F0", Offset = "0x8DAFEF0", VA = "0x188DB16F0")]
		static PRVUCTIUQAT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class BWVJEUWECZL
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] BVJMJBLKKUI;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly QBWQRZLRZND DIPEXDTYSXD;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3CA0", Offset = "0x8DA24A0", VA = "0x188DA3CA0")]
		static BWVJEUWECZL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class IVVLVVQTCMT
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] ECRXRVJZMPL;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly QBWQRZLRZND NYCGYPEXUHA;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] ECCDABCHKHK;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly QBWQRZLRZND NXXABILAKVR;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] ECHJXHWETST;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly QBWQRZLRZND NXRTEBRDBKI;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] EDHSJPRROXM;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly QBWQRZLRZND NZCPKXAKPLT;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] EDMZGWLOYIV;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly QBWQRZLRZND NYXINQGNGAK;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] ECXEPCDWWAU;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly QBWQRZLRZND NYSBQJMPWPB;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] EDCLMIXUFMD;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly QBWQRZLRZND NYMUTCSSNDS;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] EECTYQTHAQW;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly QBWQRZLRZND NWRKRTVQGFP;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x8DA94A0", Offset = "0x8DA7CA0", VA = "0x188DA94A0")]
		static IVVLVVQTCMT()
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
