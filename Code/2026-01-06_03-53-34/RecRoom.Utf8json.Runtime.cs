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
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAE09B0", Offset = "0xADF3B0", VA = "0x180AE09B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x378CE30", Offset = "0x378B830", VA = "0x18378CE30")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A82CE0", Offset = "0x3A816E0", VA = "0x183A82CE0")]
		public static DIBGAVKLOIB<a> BRDUOJSIBOI<a>(this KIVYKHMZUOQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8EA2350", Offset = "0x8EA0D50", VA = "0x188EA2350")]
		public static object GNHHCSJXKHA(this KIVYKHMZUOQ a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8E93A30", Offset = "0x8E92430", VA = "0x188E93A30")]
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
				[Cpp2IlInjected.Address(RVA = "0x8E96150", Offset = "0x8E94B50", VA = "0x188E96150")]
				public HJHYUUJCUHN(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x8E96030", Offset = "0x8E94A30", VA = "0x188E96030")]
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
			[Cpp2IlInjected.Address(RVA = "0x8EA1EA0", Offset = "0x8EA08A0", VA = "0x188EA1EA0")]
			public void EYJHJEGADCD([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8EA1D60", Offset = "0x8EA0760", VA = "0x188EA1D60")]
			public void EYJHJEGADCD(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8EA1C30", Offset = "0x8EA0630", VA = "0x188EA1C30")]
			public ReadOnlySequence<byte> CDRNPHFZKTO()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8EA1FB0", Offset = "0x8EA09B0", VA = "0x188EA1FB0")]
			private void QKNOMTDCXUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8EA2160", Offset = "0x8EA0B60", VA = "0x188EA2160")]
			private void WEBFTXISVOC([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8E9AF70", Offset = "0x8E99970", VA = "0x188E9AF70")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8E9A780", Offset = "0x8E99180", VA = "0x188E9A780")]
		private JsonParsingException XPMPTZQIMHM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8E99440", Offset = "0x8E97E40", VA = "0x188E99440")]
		private JsonParsingException QUQKISWCHFL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8E98FC0", Offset = "0x8E979C0", VA = "0x188E98FC0")]
		public JsonToken ORPKWIJDFLP()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8E982B0", Offset = "0x8E96CB0", VA = "0x188E982B0")]
		public void FXXANDUCGCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8E99550", Offset = "0x8E97F50", VA = "0x188E99550")]
		private bool RCZOURQYEWP(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8E995B0", Offset = "0x8E97FB0", VA = "0x188E995B0")]
		private bool RCZOURQYEWP(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8E99920", Offset = "0x8E98320", VA = "0x188E99920")]
		private void RNQVSPPVAJM(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8E98AF0", Offset = "0x8E974F0", VA = "0x188E98AF0")]
		public bool MMKKUQQUAOS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8E9AD50", Offset = "0x8E99750", VA = "0x188E9AD50")]
		public void YDYUTUXOPUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8E98720", Offset = "0x8E97120", VA = "0x188E98720")]
		public bool JCJJZIWISUV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8E98770", Offset = "0x8E97170", VA = "0x188E98770")]
		public void JXRQWAIAXQU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8E97DB0", Offset = "0x8E967B0", VA = "0x188E97DB0")]
		public void AXDBPLEJYSS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8E98120", Offset = "0x8E96B20", VA = "0x188E98120")]
		public bool DSLEMAVWNED()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8E9A770", Offset = "0x8E99170", VA = "0x188E9A770")]
		public void XAVMFFLPFHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8E98AE0", Offset = "0x8E974E0", VA = "0x188E98AE0")]
		public void MEEOZOSQRDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8E99B90", Offset = "0x8E98590", VA = "0x188E99B90")]
		public bool UFGCXIFUZUW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8E97EA0", Offset = "0x8E968A0", VA = "0x188E97EA0")]
		public bool DINDNFCSAKI(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8E98BB0", Offset = "0x8E975B0", VA = "0x188E98BB0")]
		public bool MWIHLCEBDFJ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8E99E10", Offset = "0x8E98810", VA = "0x188E99E10")]
		private ReadOnlySequence<byte> WGADPTGYZCQ()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8E991D0", Offset = "0x8E97BD0", VA = "0x188E991D0")]
		private ReadOnlySequence<byte> PMGOMAVVFYT()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8E99C20", Offset = "0x8E98620", VA = "0x188E99C20")]
		private void UILFMZUNRKL(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8E98780", Offset = "0x8E97180", VA = "0x188E98780")]
		private void KHDANJNRZFM(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8E98C90", Offset = "0x8E97690", VA = "0x188E98C90")]
		private void OMDXQDXHLWR(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8E999D0", Offset = "0x8E983D0", VA = "0x188E999D0")]
		private void RQKBHSNKLOE(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8E8FBB0", Offset = "0x8E8E5B0", VA = "0x188E8FBB0")]
		private static int SNOPCACEUMD(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8E98170", Offset = "0x8E96B70", VA = "0x188E98170")]
		public ReadOnlySequence<byte> EHMXPECJVYF()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8E9A640", Offset = "0x8E99040", VA = "0x188E9A640")]
		public string WPIQFNJPLYO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8E98F80", Offset = "0x8E97980", VA = "0x188E98F80")]
		public string OPTTNMOZHZH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8E9AC80", Offset = "0x8E99680", VA = "0x188E9AC80")]
		public ReadOnlySequence<byte> XWUSHTDCREX()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8E97DC0", Offset = "0x8E967C0", VA = "0x188E97DC0")]
		public ReadOnlySequence<byte> BSWREIOVSEI()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8E97FD0", Offset = "0x8E969D0", VA = "0x188E97FD0")]
		public bool DQPPZTXZPRH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8E9A2F0", Offset = "0x8E98CF0", VA = "0x188E9A2F0")]
		private void WLUGVXQIBEN(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8E99AE0", Offset = "0x8E984E0", VA = "0x188E99AE0")]
		public void SCUBDUFOFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8E984E0", Offset = "0x8E96EE0", VA = "0x188E984E0")]
		private void HVEHFPBJVGA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8E9AEC0", Offset = "0x8E998C0", VA = "0x188E9AEC0")]
		public sbyte ZNEOOUTGEBM()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8E9A6C0", Offset = "0x8E990C0", VA = "0x188E9A6C0")]
		public short WPVJYOXIPFJ()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8E98980", Offset = "0x8E97380", VA = "0x188E98980")]
		public int KKRHFRAUEQZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8E98240", Offset = "0x8E96C40", VA = "0x188E98240")]
		public long ENDLIZNWGUK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8E9AD60", Offset = "0x8E99760", VA = "0x188E9AD60")]
		public byte ZHRRQYZLOCB()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8E9AE10", Offset = "0x8E99810", VA = "0x188E9AE10")]
		public ushort ZIISGIMBRLC()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8E98A30", Offset = "0x8E97430", VA = "0x188E98A30")]
		public uint LNMUZGIQBZM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8E998B0", Offset = "0x8E982B0", VA = "0x188E998B0")]
		public ulong RLVSKYXDLPL()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8E99AF0", Offset = "0x8E984F0", VA = "0x188E99AF0")]
		public float TUKFSJYQWAX()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8E97F30", Offset = "0x8E96930", VA = "0x188E97F30")]
		public double DMFDPWEIUEC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8E9A460", Offset = "0x8E98E60", VA = "0x188E9A460")]
		public ReadOnlySequence<byte> WNEKIHOCCRN()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8E99610", Offset = "0x8E98010", VA = "0x188E99610")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4E90", Offset = "0xCF3890", VA = "0x180CF4E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8E97D50", Offset = "0x8E96750", VA = "0x188E97D50")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8E97CD0", Offset = "0x8E966D0", VA = "0x188E97CD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E90700", Offset = "0x8E8F100", VA = "0x188E90700")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E90490", Offset = "0x8E8EE90", VA = "0x188E90490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8E90420", Offset = "0x8E8EE20", VA = "0x188E90420")]
		public static void SRYJHIXVSDC(KIVYKHMZUOQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3471D10", Offset = "0x3470710", VA = "0x183471D10")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3471D80", Offset = "0x3470780", VA = "0x183471D80")]
		public static byte[] Serialize<T>(T value, KIVYKHMZUOQ resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3472300", Offset = "0x3470D00", VA = "0x183472300")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3472380", Offset = "0x3470D80", VA = "0x183472380")]
		public static string ToJsonString<T>(T value, KIVYKHMZUOQ resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3471830", Offset = "0x3470230", VA = "0x183471830")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3471560", Offset = "0x346FF60", VA = "0x183471560")]
		public static T Deserialize<T>(string json, KIVYKHMZUOQ resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x34716E0", Offset = "0x34700E0", VA = "0x1834716E0")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3471490", Offset = "0x346FE90", VA = "0x183471490")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, KIVYKHMZUOQ resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3470CC0", Offset = "0x346F6C0", VA = "0x183470CC0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3470EE0", Offset = "0x346F8E0", VA = "0x183470EE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCB4570", Offset = "0xCB2F70", VA = "0x180CB4570")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B6B0", Offset = "0x8E9A0B0", VA = "0x188E9B6B0")]
		public void RDJZODXJRLO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B330", Offset = "0x8E99D30", VA = "0x188E9B330")]
		public static byte[] ISZEYZDCVXN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B570", Offset = "0x8E99F70", VA = "0x188E9B570")]
		public static byte[] ODYEHCDECGD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8E9BFF0", Offset = "0x8E9A9F0", VA = "0x188E9BFF0")]
		public static byte[] VHZUBOECZLF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B6C0", Offset = "0x8E9A0C0", VA = "0x188E9B6C0")]
		public static byte[] ROMHQOIGKDD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2809E50", Offset = "0x2808850", VA = "0x182809E50")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8E9BF50", Offset = "0x8E9A950", VA = "0x188E9BF50")]
		public ArraySegment<byte> UJNOMWXTRTZ()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8E9C110", Offset = "0x8E9AB10", VA = "0x188E9C110")]
		public byte[] WICVOTYTNRS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8E9BEF0", Offset = "0x8E9A8F0", VA = "0x188E9BEF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B2D0", Offset = "0x8E99CD0", VA = "0x188E9B2D0")]
		public void HFYRASWLYEF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B0E0", Offset = "0x8E99AE0", VA = "0x188E9B0E0")]
		public void AXKGFYWJEJO(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B840", Offset = "0x8E9A240", VA = "0x188E9B840")]
		public void RQSUAZRGYQO(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE300", Offset = "0x3DDCD00", VA = "0x183DDE300")]
		public void DWKTPVNPLGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE4E0", Offset = "0x3DDCEE0", VA = "0x183DDE4E0")]
		public void TPKFVYCNGUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B2E0", Offset = "0x8E99CE0", VA = "0x188E9B2E0")]
		public void HWTPEZCNYKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE3F0", Offset = "0x3DDCDF0", VA = "0x183DDE3F0")]
		public void FQPGLCPDFXG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE490", Offset = "0x3DDCE90", VA = "0x183DDE490")]
		public void PRCXZDYOTPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE440", Offset = "0x3DDCE40", VA = "0x183DDE440")]
		public void FWDKSCKFXYI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B190", Offset = "0x8E99B90", VA = "0x188E9B190")]
		public void FJLGKRSCDGA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B140", Offset = "0x8E99B40", VA = "0x188E9B140")]
		public void EPWKATHXGMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3DDE530", Offset = "0x3DDCF30", VA = "0x183DDE530")]
		public void YLCSHMKZWYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x77A4140", Offset = "0x77A2B40", VA = "0x1877A4140")]
		public void HGZNEVUYFXE(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B4F0", Offset = "0x8E99EF0", VA = "0x188E9B4F0")]
		public void NGXORFQDREK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B8F0", Offset = "0x8E9A2F0", VA = "0x188E9B8F0")]
		public void SKLFIURFVBF(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8E9C2A0", Offset = "0x8E9ACA0", VA = "0x188E9C2A0")]
		public void XAADUUTADMY(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8E9C3C0", Offset = "0x8E9ADC0", VA = "0x188E9C3C0")]
		public void ZSWZKXZWMFT(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B480", Offset = "0x8E99E80", VA = "0x188E9B480")]
		public void MWIXNBSGLDR(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B2A0", Offset = "0x8E99CA0", VA = "0x188E9B2A0")]
		public void GRNNLAQZLOQ(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B410", Offset = "0x8E99E10", VA = "0x188E9B410")]
		public void MJLDAPWUGPP(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B230", Offset = "0x8E99C30", VA = "0x188E9B230")]
		public void FXJSADTBOPG(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B880", Offset = "0x8E9A280", VA = "0x188E9B880")]
		public void SCNUTBPPZDQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8E9C390", Offset = "0x8E9AD90", VA = "0x188E9C390")]
		public void YAWSEUEDITP(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B970", Offset = "0x8E9A370", VA = "0x188E9B970")]
		public void SUFCNMFQCSL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8E9C310", Offset = "0x8E9AD10", VA = "0x188E9C310")]
		private static bool XOFXGTYUSSX(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8E9B690", Offset = "0x8E9A090", VA = "0x188E9B690")]
		private static byte POBKLYKHJIN(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8E8FC70", Offset = "0x8E8E670", VA = "0x188E8FC70")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FD0860", Offset = "0x4FCF260", VA = "0x184FD0860")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private TRSZQFSWSPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FF2F90", Offset = "0x4FF1990", VA = "0x184FF2F90")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E90830", Offset = "0x8E8F230", VA = "0x188E90830")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private RHOEQZPBJYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FF1B10", Offset = "0x4FF0510", VA = "0x184FF1B10")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private SOVMYPVLFTC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8EA1A70", Offset = "0x8EA0470", VA = "0x188EA1A70")]
		public static void JIBLBJTHOBM(params KIVYKHMZUOQ[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8EA19A0", Offset = "0x8EA03A0", VA = "0x188EA19A0")]
		public static void JIBLBJTHOBM(params AZVSJTUQPQS[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8EA1740", Offset = "0x8EA0140", VA = "0x188EA1740")]
		public static void DXMNVYSUJKO(AZVSJTUQPQS[] a, KIVYKHMZUOQ[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FCDF30", Offset = "0x4FCC930", VA = "0x184FCDF30")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private LMTQPXUYVBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E9DAB0", Offset = "0x8E9C4B0", VA = "0x188E9DAB0")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8E9DA70", Offset = "0x8E9C470", VA = "0x188E9DA70")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FEBA80", Offset = "0x4FEA480", VA = "0x184FEBA80")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private LFCXJHMSISF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FE39C0", Offset = "0x4FE23C0", VA = "0x184FE39C0")]
			static IIPIMSLZYCM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private OSVHPPCAEWU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FC6480", Offset = "0x4FC4E80", VA = "0x184FC6480")]
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
				[Cpp2IlInjected.Address(RVA = "0x4FF3180", Offset = "0x4FF1B80", VA = "0x184FF3180")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private VPNYIQKSGKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FE7BA0", Offset = "0x4FE65A0", VA = "0x184FE7BA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4FD5470", Offset = "0x4FD3E70", VA = "0x184FD5470")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private ATWYGFMHQDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FC4210", Offset = "0x4FC2C10", VA = "0x184FC4210")]
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
				[Cpp2IlInjected.Address(RVA = "0x4FC9A10", Offset = "0x4FC8410", VA = "0x184FC9A10")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private ESXOGHVMMLU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FD5BD0", Offset = "0x4FD45D0", VA = "0x184FD5BD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4FFDF50", Offset = "0x4FFC950", VA = "0x184FFDF50")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private CNGSUIQQDSF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FCC2D0", Offset = "0x4FCACD0", VA = "0x184FCC2D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4FC6A80", Offset = "0x4FC5480", VA = "0x184FC6A80")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private DDIQZPNFYRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FF2350", Offset = "0x4FF0D50", VA = "0x184FF2350")]
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
				[Cpp2IlInjected.Address(RVA = "0x4FC3600", Offset = "0x4FC2000", VA = "0x184FC3600")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private YGFJOPDQFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FCAC50", Offset = "0x4FC9650", VA = "0x184FCAC50")]
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
				[Cpp2IlInjected.Address(RVA = "0x4FFBDC0", Offset = "0x4FFA7C0", VA = "0x184FFBDC0")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private UVXTYFNXGHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FEE590", Offset = "0x4FECF90", VA = "0x184FEE590")]
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
				[Cpp2IlInjected.Address(RVA = "0x4FFE510", Offset = "0x4FFCF10", VA = "0x184FFE510")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private MYGQJQWSOUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FDF200", Offset = "0x4FDDC00", VA = "0x184FDF200")]
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
				[Cpp2IlInjected.Address(RVA = "0x4FF6430", Offset = "0x4FF4E30", VA = "0x184FF6430")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private CAVBRFYPXTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FCA650", Offset = "0x4FC9050", VA = "0x184FCA650")]
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
				[Cpp2IlInjected.Address(RVA = "0x4FC85A0", Offset = "0x4FC6FA0", VA = "0x184FC85A0")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private ACSQAMQIOMZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FC4700", Offset = "0x4FC3100", VA = "0x184FC4700")]
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
				[Cpp2IlInjected.Address(RVA = "0x4FFEC30", Offset = "0x4FFD630", VA = "0x184FFEC30")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private AQAISTOEBQH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FF0CD0", Offset = "0x4FEF6D0", VA = "0x184FF0CD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x4FEEB90", Offset = "0x4FED590", VA = "0x184FEEB90")]
				static IIPIMSLZYCM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly KIVYKHMZUOQ GUPHEVFTUDK;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly KIVYKHMZUOQ[] YLCDHTZGPEG;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			private NQSYGKZNCJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		private FNMZKARDQYN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3052BC0", Offset = "0x30515C0", VA = "0x183052BC0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5801D60", Offset = "0x5800760", VA = "0x185801D60")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5801A60", Offset = "0x5800460", VA = "0x185801A60")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5801CD0", Offset = "0x58006D0", VA = "0x185801CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5904FB0", Offset = "0x59039B0", VA = "0x185904FB0")]
		public NOERAWRFVRD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x59048E0", Offset = "0x59032E0", VA = "0x1859048E0")]
		public a[] GPSVHSXROLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5904D70", Offset = "0x5903770", VA = "0x185904D70")]
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
					[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xD50190", Offset = "0xD4EB90", VA = "0x180D50190")]
				[DebuggerHidden]
				public UONZDGTPZSN(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "7")]
				[DebuggerHidden]
				private void QBKHVLXPXWS()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x8EA28B0", Offset = "0x8EA12B0", VA = "0x188EA28B0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x8EA2930", Offset = "0x8EA1330", VA = "0x188EA2930", Slot = "10")]
				[DebuggerHidden]
				private void VXYFNEQVOKT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x8EA2810", Offset = "0x8EA1210", VA = "0x188EA2810", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<PQICOSRUKMJ> HTROFGVPEXD()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x8EA2810", Offset = "0x8EA1210", VA = "0x188EA2810", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8EA0570", Offset = "0x8E9EF70", VA = "0x188EA0570")]
			public PQICOSRUKMJ(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8EA00A0", Offset = "0x8E9EAA0", VA = "0x188EA00A0")]
			public PQICOSRUKMJ Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8EA0040", Offset = "0x8E9EA40", VA = "0x188EA0040")]
			public PQICOSRUKMJ Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8EA0360", Offset = "0x8E9ED60", VA = "0x188EA0360")]
			public PQICOSRUKMJ HPYHWDXRTUT(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8EA02A0", Offset = "0x8E9ECA0", VA = "0x188EA02A0")]
			internal static int BBTKGQPEYVM(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8EA0330", Offset = "0x8E9ED30", VA = "0x188EA0330", Slot = "4")]
			public int CompareTo(PQICOSRUKMJ other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8E9FFC0", Offset = "0x8E9E9C0", VA = "0x188E9FFC0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x8E9C950", Offset = "0x8E9B350", VA = "0x188E9C950", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x1A39A70", Offset = "0x1A38470", VA = "0x181A39A70")]
			[DebuggerHidden]
			public KUORPSAXFMP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8E9C9A0", Offset = "0x8E9B3A0", VA = "0x188E9C9A0", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8E9C4F0", Offset = "0x8E9AEF0", VA = "0x188E9C4F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8E9CAF0", Offset = "0x8E9B4F0", VA = "0x188E9CAF0")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8E9CB40", Offset = "0x8E9B540", VA = "0x188E9CB40")]
			private void SONMORMKPTT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8E9CC30", Offset = "0x8E9B630", VA = "0x188E9CC30", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8E9CB90", Offset = "0x8E9B590", VA = "0x188E9CB90", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> TZORUKFUUSD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8E9CB90", Offset = "0x8E9B590", VA = "0x188E9CB90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA0E70", Offset = "0x8E9F870", VA = "0x188EA0E70")]
		public QBWQRZLRZND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8EA0620", Offset = "0x8E9F020", VA = "0x188EA0620")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8EA0800", Offset = "0x8E9F200", VA = "0x188EA0800")]
		public bool CIWAHGAOAZX(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8EA09F0", Offset = "0x8E9F3F0", VA = "0x188EA09F0")]
		public bool KVVWYNVJASI([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8EA0B00", Offset = "0x8E9F500", VA = "0x188EA0B00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8EA0B90", Offset = "0x8E9F590", VA = "0x188EA0B90")]
		private static void XHXXJMRYCEU(IEnumerable<PQICOSRUKMJ> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8EA0990", Offset = "0x8E9F390", VA = "0x188EA0990", Slot = "5")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8EA0990", Offset = "0x8E9F390", VA = "0x188EA0990", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8EA0910", Offset = "0x8E9F310", VA = "0x188EA0910")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA0EE0", Offset = "0x8E9F8E0", VA = "0x188EA0EE0")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8EA1090", Offset = "0x8E9FA90", VA = "0x188EA1090")]
		public static ulong QNRONUXGUYB(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class GESSGVAUFQG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8E93BD0", Offset = "0x8E925D0", VA = "0x188E93BD0")]
		public static void HFYRASWLYEF(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8E93D10", Offset = "0x8E92710", VA = "0x188E93D10")]
		public static void UPLGRUUCCAB(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8E93A90", Offset = "0x8E92490", VA = "0x188E93A90")]
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
			[Cpp2IlInjected.Address(RVA = "0x46FABD0", Offset = "0x46F95D0", VA = "0x1846FABD0", Slot = "3")]
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
				[Cpp2IlInjected.Address(RVA = "0xCAF6B0", Offset = "0xCAE0B0", VA = "0x180CAF6B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4DB1760", Offset = "0x4DB0160", VA = "0x184DB1760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
			[DebuggerHidden]
			public UEATFONUVHU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x61E9B70", Offset = "0x61E8570", VA = "0x1861E9B70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3D4A650", Offset = "0x3D49050", VA = "0x183D4A650", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D8FD90", Offset = "0x3D8E790", VA = "0x183D8FD90")]
		public CQWMVTINDBM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3D8FE80", Offset = "0x3D8E880", VA = "0x183D8FE80")]
		public CQWMVTINDBM(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3D7DCC0", Offset = "0x3D7C6C0", VA = "0x183D7DCC0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3D83490", Offset = "0x3D81E90", VA = "0x183D83490")]
		private bool IKBRVZRGWHI(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3D81C40", Offset = "0x3D80640", VA = "0x183D81C40")]
		public bool CIWAHGAOAZX([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3D8D520", Offset = "0x3D8BF20", VA = "0x183D8D520")]
		private static ulong KNRQTOAEPTN([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3D8D380", Offset = "0x3D8BD80", VA = "0x183D8D380")]
		private static ulong KNRQTOAEPTN([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3D8B0D0", Offset = "0x3D89AD0", VA = "0x183D8B0D0")]
		private static int IVRYDRCTCXP(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3D82980", Offset = "0x3D81380", VA = "0x183D82980", Slot = "4")]
		[IteratorStateMachine(typeof(CQWMVTINDBM<>.UEATFONUVHU))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3D8FC90", Offset = "0x3D8E690", VA = "0x183D8FC90", Slot = "5")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class NBHPOFJRYUP
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3861D20", Offset = "0x3860720", VA = "0x183861D20")]
		public static Func<a> COAEVSIVGZT<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3861E10", Offset = "0x3860810", VA = "0x183861E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E94880", Offset = "0x8E93280", VA = "0x188E94880")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8E94890", Offset = "0x8E93290", VA = "0x188E94890")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8E94700", Offset = "0x8E93100", VA = "0x188E94700")]
		private static byte VIKUNIOWFTU(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8E8E4B0", Offset = "0x8E8CEB0", VA = "0x188E8E4B0")]
		private static byte HFPPXKTDVBA(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8E93F00", Offset = "0x8E92900", VA = "0x188E93F00")]
		public void DKMXHPDZVPU(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class JDUYGTFQNQW
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8E961C0", Offset = "0x8E94BC0", VA = "0x188E961C0")]
		public static bool BWQNCEKOGBE(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8E969A0", Offset = "0x8E953A0", VA = "0x188E969A0")]
		public static bool OMFJGUDTDZN(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8E97050", Offset = "0x8E95A50", VA = "0x188E97050")]
		public static sbyte ZNEOOUTGEBM([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8E96D60", Offset = "0x8E95760", VA = "0x188E96D60")]
		public static short WPVJYOXIPFJ([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8E968E0", Offset = "0x8E952E0", VA = "0x188E968E0")]
		public static int KKRHFRAUEQZ([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8E96530", Offset = "0x8E94F30", VA = "0x188E96530")]
		public static long ENDLIZNWGUK([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8E96750", Offset = "0x8E95150", VA = "0x188E96750")]
		public static bool KCBTRUZFDST(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8E96F90", Offset = "0x8E95990", VA = "0x188E96F90")]
		public static byte ZHRRQYZLOCB([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8E96FF0", Offset = "0x8E959F0", VA = "0x188E96FF0")]
		public static ushort ZIISGIMBRLC([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8E96940", Offset = "0x8E95340", VA = "0x188E96940")]
		public static uint LNMUZGIQBZM([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8E96A10", Offset = "0x8E95410", VA = "0x188E96A10")]
		public static ulong RLVSKYXDLPL([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8E96AC0", Offset = "0x8E954C0", VA = "0x188E96AC0")]
		public static bool SOCUTSOJQWW(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8E96DC0", Offset = "0x8E957C0", VA = "0x188E96DC0")]
		public static bool YEFAINLGNRG(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8E965E0", Offset = "0x8E94FE0", VA = "0x188E965E0")]
		public static bool IDREVZQHKTQ(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8E96490", Offset = "0x8E94E90", VA = "0x188E96490")]
		public static bool EHKLCXSEYUU(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8E96C70", Offset = "0x8E95670", VA = "0x188E96C70")]
		public static float TUKFSJYQWAX([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8E96C10", Offset = "0x8E95610", VA = "0x188E96C10")]
		public static bool TTKVOYVEDDK(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8E961D0", Offset = "0x8E94BD0", VA = "0x188E961D0")]
		public static double DMFDPWEIUEC([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8E966F0", Offset = "0x8E950F0", VA = "0x188E966F0")]
		public static bool JKHUEAJXBFX(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8E8E710", Offset = "0x8E8D110", VA = "0x188E8E710")]
		public static int GRNNLAQZLOQ(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8E8EFC0", Offset = "0x8E8D9C0", VA = "0x188E8EFC0")]
		public static int YAWSEUEDITP(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8E962C0", Offset = "0x8E94CC0", VA = "0x188E962C0")]
		public static bool DQPPZTXZPRH([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class PGLVSPXYCNK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8E9D9C0", Offset = "0x8E9C3C0", VA = "0x188E9D9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E93370", Offset = "0x8E91D70", VA = "0x188E93370")]
		public static void UQVBEQERLCE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8E933E0", Offset = "0x8E91DE0", VA = "0x188E933E0")]
		public static void URAIBWYOUNN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8E93450", Offset = "0x8E91E50", VA = "0x188E93450")]
		public static void URFOZDSMDYW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8E934C0", Offset = "0x8E91EC0", VA = "0x188E934C0")]
		public static void URKVWKMJNKF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8E97BF0", Offset = "0x8E965F0", VA = "0x188E97BF0")]
		public static void URQCTRGGWVO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8E97C60", Offset = "0x8E96660", VA = "0x188E97C60")]
		public static void URVJQYAEGGX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8E97880", Offset = "0x8E96280", VA = "0x188E97880")]
		public static void TMMYMGYCUKV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8E97810", Offset = "0x8E96210", VA = "0x188E97810")]
		public static void TMHRPAEFKZM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8E977A0", Offset = "0x8E961A0", VA = "0x188E977A0")]
		public static void TMCKRTKIBOD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8E97720", Offset = "0x8E96120", VA = "0x188E97720")]
		public static void TLXDUMQKSCU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8E97A70", Offset = "0x8E96470", VA = "0x188E97A70")]
		public static void TNIABHZSGEF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8E979F0", Offset = "0x8E963F0", VA = "0x188E979F0")]
		public static void TNCTEBFUWSW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8E97970", Offset = "0x8E96370", VA = "0x188E97970")]
		public static void TMXMGULXNHN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8E978F0", Offset = "0x8E962F0", VA = "0x188E978F0")]
		public static void TMSFJNSADWE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8E97B70", Offset = "0x8E96570", VA = "0x188E97B70")]
		public static void TODBQJBHRXP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8E97AF0", Offset = "0x8E964F0", VA = "0x188E97AF0")]
		public static void TNXUTCHKIMG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8E973E0", Offset = "0x8E95DE0", VA = "0x188E973E0")]
		public static void ANEDKZGFKDE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8E97460", Offset = "0x8E95E60", VA = "0x188E97460")]
		public static void ANJKIGACTON(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8E972E0", Offset = "0x8E95CE0", VA = "0x188E972E0")]
		public static void AMTPQLSKRGM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8E97360", Offset = "0x8E95D60", VA = "0x188E97360")]
		public static void AMYWNSMIARV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8E971D0", Offset = "0x8E95BD0", VA = "0x188E971D0")]
		public static void AMJBVYEPYJU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8E97250", Offset = "0x8E95C50", VA = "0x188E97250")]
		public static void AMOITEYNHVD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8E970B0", Offset = "0x8E95AB0", VA = "0x188E970B0")]
		public static void ALYOBKQVFNC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8E97140", Offset = "0x8E95B40", VA = "0x188E97140")]
		public static void AMDUYRKSOYL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8E974E0", Offset = "0x8E95EE0", VA = "0x188E974E0")]
		public static void AOUGPBJKHPY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8E97570", Offset = "0x8E95F70", VA = "0x188E97570")]
		public static void AOZNMIDHRBH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8E97690", Offset = "0x8E96090", VA = "0x188E97690")]
		public static void GNXJWJPHNZF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8E97600", Offset = "0x8E96000", VA = "0x188E97600")]
		public static void GNSCZCVKENW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8E93220", Offset = "0x8E91C20", VA = "0x188E93220")]
		public static void UQFGMVWZIUD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8E93290", Offset = "0x8E91C90", VA = "0x188E93290")]
		public static void UQKNKCQWSFM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8E93300", Offset = "0x8E91D00", VA = "0x188E93300")]
		public static void UQPUHJKUBQV(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class DETUKZYERCY
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8E93530", Offset = "0x8E91F30", VA = "0x188E93530")]
		public static void URQCTRGGWVO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8E935A0", Offset = "0x8E91FA0", VA = "0x188E935A0")]
		public static void URVJQYAEGGX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8E92EE0", Offset = "0x8E918E0", VA = "0x188E92EE0")]
		public static void TMMYMGYCUKV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8E92E70", Offset = "0x8E91870", VA = "0x188E92E70")]
		public static void TMHRPAEFKZM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8E92E00", Offset = "0x8E91800", VA = "0x188E92E00")]
		public static void TMCKRTKIBOD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8E92D90", Offset = "0x8E91790", VA = "0x188E92D90")]
		public static void TLXDUMQKSCU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8E930B0", Offset = "0x8E91AB0", VA = "0x188E930B0")]
		public static void TNIABHZSGEF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8E93040", Offset = "0x8E91A40", VA = "0x188E93040")]
		public static void TNCTEBFUWSW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8E92FD0", Offset = "0x8E919D0", VA = "0x188E92FD0")]
		public static void TMXMGULXNHN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8E92F50", Offset = "0x8E91950", VA = "0x188E92F50")]
		public static void TMSFJNSADWE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8E931A0", Offset = "0x8E91BA0", VA = "0x188E931A0")]
		public static void TODBQJBHRXP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8E93120", Offset = "0x8E91B20", VA = "0x188E93120")]
		public static void TNXUTCHKIMG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8E92A90", Offset = "0x8E91490", VA = "0x188E92A90")]
		public static void ANEDKZGFKDE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8E92B10", Offset = "0x8E91510", VA = "0x188E92B10")]
		public static void ANJKIGACTON(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8E92990", Offset = "0x8E91390", VA = "0x188E92990")]
		public static void AMTPQLSKRGM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8E92A10", Offset = "0x8E91410", VA = "0x188E92A10")]
		public static void AMYWNSMIARV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8E92890", Offset = "0x8E91290", VA = "0x188E92890")]
		public static void AMJBVYEPYJU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8E92910", Offset = "0x8E91310", VA = "0x188E92910")]
		public static void AMOITEYNHVD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8E92790", Offset = "0x8E91190", VA = "0x188E92790")]
		public static void ALYOBKQVFNC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8E92810", Offset = "0x8E91210", VA = "0x188E92810")]
		public static void AMDUYRKSOYL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8E92B90", Offset = "0x8E91590", VA = "0x188E92B90")]
		public static void AOUGPBJKHPY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8E92C10", Offset = "0x8E91610", VA = "0x188E92C10")]
		public static void AOZNMIDHRBH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8E92D10", Offset = "0x8E91710", VA = "0x188E92D10")]
		public static void GNXJWJPHNZF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8E92C90", Offset = "0x8E91690", VA = "0x188E92C90")]
		public static void GNSCZCVKENW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8E93220", Offset = "0x8E91C20", VA = "0x188E93220")]
		public static void UQFGMVWZIUD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8E93290", Offset = "0x8E91C90", VA = "0x188E93290")]
		public static void UQKNKCQWSFM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8E93300", Offset = "0x8E91D00", VA = "0x188E93300")]
		public static void UQPUHJKUBQV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8E93370", Offset = "0x8E91D70", VA = "0x188E93370")]
		public static void UQVBEQERLCE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8E933E0", Offset = "0x8E91DE0", VA = "0x188E933E0")]
		public static void URAIBWYOUNN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8E93450", Offset = "0x8E91E50", VA = "0x188E93450")]
		public static void URFOZDSMDYW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8E934C0", Offset = "0x8E91EC0", VA = "0x188E934C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB9D50", Offset = "0x8EB8750", VA = "0x188EB9D50")]
		public static void AXKGFYWJEJO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8EBB750", Offset = "0x8EBA150", VA = "0x188EBB750")]
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
		[Cpp2IlInjected.Address(RVA = "0x28B5840", Offset = "0x28B4240", VA = "0x1828B5840")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6BE0", Offset = "0x8EA55E0", VA = "0x188EA6BE0")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6A10", Offset = "0x8EA5410", VA = "0x188EA6A10")]
		public static DiyFp KSQWTLAZSEB(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6AB0", Offset = "0x8EA54B0", VA = "0x188EA6AB0")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6B40", Offset = "0x8EA5540", VA = "0x188EA6B40")]
		public static DiyFp OVDZRWJUPGT(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6A70", Offset = "0x8EA5470", VA = "0x188EA6A70")]
		public void MWOEODIEXJY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6A20", Offset = "0x8EA5420", VA = "0x188EA6A20")]
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
		[Cpp2IlInjected.Address(RVA = "0xC40E00", Offset = "0xC3F800", VA = "0x180C40E00")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8EB58E0", Offset = "0x8EB42E0", VA = "0x188EB58E0")]
		public void TQQZWAXLNMN(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8EB5740", Offset = "0x8EB4140", VA = "0x188EB5740")]
		public void JZDRSWCEITZ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8EB57C0", Offset = "0x8EB41C0", VA = "0x188EB57C0")]
		public void SEVEQYAAJOF(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8EB5840", Offset = "0x8EB4240", VA = "0x188EB5840")]
		public void SEVEQYAAJOF(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8EB55C0", Offset = "0x8EB3FC0", VA = "0x188EB55C0")]
		public void CKOWWBZYXCX(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8EB5640", Offset = "0x8EB4040", VA = "0x188EB5640")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB20B0", Offset = "0x8EB0AB0", VA = "0x188EB20B0")]
		private static byte[] NVUHQHRYMHP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8EB1550", Offset = "0x8EAFF50", VA = "0x188EB1550")]
		private static byte[] JBVXURIPCCN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8EB1F90", Offset = "0x8EB0990", VA = "0x188EB1F90")]
		public static int KHIJLIKLCYM(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8EB1E70", Offset = "0x8EB0870", VA = "0x188EB1E70")]
		public static int KHIJLIKLCYM(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8EB1630", Offset = "0x8EB0030", VA = "0x188EB1630")]
		private static bool JDYJWAKKRAQ(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8EB1460", Offset = "0x8EAFE60", VA = "0x188EB1460")]
		private static void DMEEUADHJNG(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8EB1720", Offset = "0x8EB0120", VA = "0x188EB1720")]
		private static bool JVXPQVEMNPM(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8EB2280", Offset = "0x8EB0C80", VA = "0x188EB2280")]
		private static bool RCKVTLFNSLI(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8EB2180", Offset = "0x8EB0B80", VA = "0x188EB2180")]
		private static bool QMTPAKKUXJP(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8EB3010", Offset = "0x8EB1A10", VA = "0x188EB3010")]
		private static bool YVUTOOJGSDQ(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8EB2B40", Offset = "0x8EB1540", VA = "0x188EB2B40")]
		private static bool VCDGCXIEQXL(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8EB1AE0", Offset = "0x8EB04E0", VA = "0x188EB1AE0")]
		private static void KBYEEFJAATR(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8EB2700", Offset = "0x8EB1100", VA = "0x188EB2700")]
		private static void UXXWLOVFMTF(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8EB1270", Offset = "0x8EAFC70", VA = "0x188EB1270")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA7210", Offset = "0x8EA5C10", VA = "0x188EA7210")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7170", Offset = "0x8EA5B70", VA = "0x188EA7170")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6BF0", Offset = "0x8EA55F0", VA = "0x188EA6BF0")]
		public DiyFp DBNDNATKPRX()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8EA70F0", Offset = "0x8EA5AF0", VA = "0x188EA70F0")]
		public DiyFp ZWPGXJUGZDE()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xC00D70", Offset = "0xBFF770", VA = "0x180C00D70")]
		public ulong HLKFQHNUZAJ()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7010", Offset = "0x8EA5A10", VA = "0x188EA7010")]
		public double UGVIPTLXZJB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6E50", Offset = "0x8EA5850", VA = "0x188EA6E50")]
		public double GTNBXFWRUZZ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6EF0", Offset = "0x8EA58F0", VA = "0x188EA6EF0")]
		public int HYJCZELJGYQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6FE0", Offset = "0x8EA59E0", VA = "0x188EA6FE0")]
		public ulong QFJYJNNKIGG()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7090", Offset = "0x8EA5A90", VA = "0x188EA7090")]
		public bool VCZMSVPKPNJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6C60", Offset = "0x8EA5660", VA = "0x188EA6C60")]
		public bool DUZWABMFXRI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6F70", Offset = "0x8EA5970", VA = "0x188EA6F70")]
		public bool ICCNGHABSYQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8EA70B0", Offset = "0x8EA5AB0", VA = "0x188EA70B0")]
		public bool XBSXRAVROTV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6FC0", Offset = "0x8EA59C0", VA = "0x188EA6FC0")]
		public int PFZIKWYUKYG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6D10", Offset = "0x8EA5710", VA = "0x188EA6D10")]
		public void FZWCIELUSAY([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6F20", Offset = "0x8EA5920", VA = "0x188EA6F20")]
		public bool IBQNYUHZFQA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3BA1140", Offset = "0x3B9FB40", VA = "0x183BA1140")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6FA0", Offset = "0x8EA59A0", VA = "0x188EA6FA0")]
		public static int IGAGZBHYNZF(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8EA70E0", Offset = "0x8EA5AE0", VA = "0x188EA70E0")]
		public static double XQEZVOICMVR()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8EA6C80", Offset = "0x8EA5680", VA = "0x188EA6C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x15976C0", Offset = "0x15960C0", VA = "0x1815976C0")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8EB53A0", Offset = "0x8EB3DA0", VA = "0x188EB53A0")]
		public DiyFp DBNDNATKPRX()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xCB4390", Offset = "0xCB2D90", VA = "0x180CB4390")]
		public uint BGOVOGMNZLI()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8EB5530", Offset = "0x8EB3F30", VA = "0x188EB5530")]
		public int HYJCZELJGYQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8EB5590", Offset = "0x8EB3F90", VA = "0x188EB5590")]
		public uint QFJYJNNKIGG()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8EB55B0", Offset = "0x8EB3FB0", VA = "0x188EB55B0")]
		public bool VCZMSVPKPNJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8EB5400", Offset = "0x8EB3E00", VA = "0x188EB5400")]
		public void FZWCIELUSAY([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8EB5550", Offset = "0x8EB3F50", VA = "0x188EB5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA61A0", Offset = "0x8EA4BA0", VA = "0x188EA61A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAEA80", Offset = "0x8EAD480", VA = "0x188EAEA80")]
		public static void FTPHTWLBEBM(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8EAEB90", Offset = "0x8EAD590", VA = "0x188EAEB90")]
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
			[Cpp2IlInjected.Address(RVA = "0x8EB9B80", Offset = "0x8EB8580", VA = "0x188EB9B80")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x58E9490", Offset = "0x58E7E90", VA = "0x1858E9490")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2AE8780", Offset = "0x2AE7180", VA = "0x182AE8780")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8EB9B20", Offset = "0x8EB8520", VA = "0x188EB9B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA99C0", Offset = "0x8EA83C0", VA = "0x188EA99C0")]
		private static byte[] MLYVJSKAQKS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8EA9800", Offset = "0x8EA8200", VA = "0x188EA9800")]
		private static Vector KCNOHBKOZBM(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8EA98E0", Offset = "0x8EA82E0", VA = "0x188EA98E0")]
		private static Vector KPTTLHQYIHQ(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8EA93C0", Offset = "0x8EA7DC0", VA = "0x188EA93C0")]
		private static void FXBGBQINQRB(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8EA90D0", Offset = "0x8EA7AD0", VA = "0x188EA90D0")]
		private static void EXBJSJUWMWI(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8EA9040", Offset = "0x8EA7A40", VA = "0x188EA9040")]
		private static ulong BNYHGGANQZT(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8EAA020", Offset = "0x8EA8A20", VA = "0x188EAA020")]
		private static void SZDFBJKRGHP(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8EA9450", Offset = "0x8EA7E50", VA = "0x188EA9450")]
		private static bool FXCGPZZYVTK(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8EA9AA0", Offset = "0x8EA84A0", VA = "0x188EA9AA0")]
		private static DiyFp MSYMPZMXCZR(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8EAA160", Offset = "0x8EA8B60", VA = "0x188EAA160")]
		private static bool TRJSGQHPZGT(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8EAA7A0", Offset = "0x8EA91A0", VA = "0x188EAA7A0")]
		private static bool YACAPNQWBDP(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8EA9F00", Offset = "0x8EA8900", VA = "0x188EA9F00")]
		public static double? OTFQHNYRYHT(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8EA9C30", Offset = "0x8EA8630", VA = "0x188EA9C30")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB86A0", Offset = "0x8EB70A0", VA = "0x188EB86A0")]
		private static byte[] UJNOMWXTRTZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8EB8560", Offset = "0x8EB6F60", VA = "0x188EB8560")]
		public static bool TTKVOYVEDDK(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8EB80D0", Offset = "0x8EB6AD0", VA = "0x188EB80D0")]
		public static bool JKHUEAJXBFX(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8EB8780", Offset = "0x8EB7180", VA = "0x188EB8780")]
		private static bool WYADLBIVTLE(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8EB82A0", Offset = "0x8EB6CA0", VA = "0x188EB82A0")]
		private static bool PNWFVGICJAN(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8EB7FF0", Offset = "0x8EB69F0", VA = "0x188EB7FF0")]
		private static bool GJRVILLNXCK(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8EB8230", Offset = "0x8EB6C30", VA = "0x188EB8230")]
		private static bool OGZUIFAUQEW(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8EB8210", Offset = "0x8EB6C10", VA = "0x188EB8210")]
		private static double KKKUYVWMVAN(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8EB88B0", Offset = "0x8EB72B0", VA = "0x188EB88B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1682900", Offset = "0x1681300", VA = "0x181682900")]
		public XKGTOFEKFAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
		public XKGTOFEKFAN(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE610", Offset = "0x3DED010", VA = "0x183DEE610", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3DEDBA0", Offset = "0x3DEC5A0", VA = "0x183DEDBA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FF0BF0", Offset = "0x5FEF5F0", VA = "0x185FF0BF0", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF0780", Offset = "0x5FEF180", VA = "0x185FF0780", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1682900", Offset = "0x1681300", VA = "0x181682900")]
		public WWPIAWAQHBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAC34F0", Offset = "0xAC1EF0", VA = "0x180AC34F0")]
		public WWPIAWAQHBG(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6721B90", Offset = "0x6720590", VA = "0x186721B90", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x671E560", Offset = "0x671CF60", VA = "0x18671E560", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class SHRMYBUMUHI<a, b, c, d> : DIBGAVKLOIB<d>, AZVSJTUQPQS where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5EF83F0", Offset = "0x5EF6DF0", VA = "0x185EF83F0", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5EF65B0", Offset = "0x5EF4FB0", VA = "0x185EF65B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected SHRMYBUMUHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class SIHHPWCEWPJ<a, b, c> : SHRMYBUMUHI<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3DEFDC0", Offset = "0x3DEE7C0", VA = "0x183DEFDC0", Slot = "6")]
		protected override IEnumerator<a> CKEBFKHTHCC(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected SIHHPWCEWPJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class SICASPIHNEA<a, b> : SIHHPWCEWPJ<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xB18470", Offset = "0xB16E70", VA = "0x180B18470", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class IRGVWVLACFG<a, b> : SICASPIHNEA<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x5068400", Offset = "0x5066E00", VA = "0x185068400", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5068290", Offset = "0x5066C90", VA = "0x185068290", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class OBXSDCUZHBJ<a> : SHRMYBUMUHI<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5A25530", Offset = "0x5A23F30", VA = "0x185A25530", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xB18470", Offset = "0xB16E70", VA = "0x180B18470", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x52E62C0", Offset = "0x52E4CC0", VA = "0x1852E62C0", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x45E56C0", Offset = "0x45E40C0", VA = "0x1845E56C0", Slot = "6")]
		protected override LinkedList<a>.Enumerator CKEBFKHTHCC(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class JUNOAPBUEVY<a> : SHRMYBUMUHI<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3E46320", Offset = "0x3E44D20", VA = "0x183E46320", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4E42770", Offset = "0x4E41170", VA = "0x184E42770", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x4FB6290", Offset = "0x4FB4C90", VA = "0x184FB6290", Slot = "6")]
		protected override Queue<a>.Enumerator CKEBFKHTHCC(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xB18470", Offset = "0xB16E70", VA = "0x180B18470", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class LHMSAIYSPEW<a> : SHRMYBUMUHI<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x4076720", Offset = "0x4075120", VA = "0x184076720", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4076850", Offset = "0x4075250", VA = "0x184076850", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x539F630", Offset = "0x539E030", VA = "0x18539F630", Slot = "6")]
		protected override Stack<a>.Enumerator CKEBFKHTHCC(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x539F6E0", Offset = "0x539E0E0", VA = "0x18539F6E0", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class IBDZXIIWRSW<a> : SHRMYBUMUHI<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x4FB6200", Offset = "0x4FB4C00", VA = "0x184FB6200", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xB18470", Offset = "0xB16E70", VA = "0x180B18470", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x4FB6340", Offset = "0x4FB4D40", VA = "0x184FB6340", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4FB6240", Offset = "0x4FB4C40", VA = "0x184FB6240", Slot = "6")]
		protected override HashSet<a>.Enumerator CKEBFKHTHCC(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4FB63A0", Offset = "0x4FB4DA0", VA = "0x184FB63A0")]
		public IBDZXIIWRSW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class GOJMVUQCCPU<a> : SIHHPWCEWPJ<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x4076720", Offset = "0x4075120", VA = "0x184076720", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x4E407A0", Offset = "0x4E3F1A0", VA = "0x184E407A0", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x4E40840", Offset = "0x4E3F240", VA = "0x184E40840", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class GPKPKRVICLF<a> : SIHHPWCEWPJ<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3E46320", Offset = "0x3E44D20", VA = "0x183E46320", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x4E42770", Offset = "0x4E41170", VA = "0x184E42770", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB18470", Offset = "0xB16E70", VA = "0x180B18470", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class UPKRLMCLHML<a> : SIHHPWCEWPJ<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3E46320", Offset = "0x3E44D20", VA = "0x183E46320", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x4E42770", Offset = "0x4E41170", VA = "0x184E42770", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB18470", Offset = "0xB16E70", VA = "0x180B18470", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class JIXJNNLUCLL<a> : SIHHPWCEWPJ<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5174320", Offset = "0x5172D20", VA = "0x185174320", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x4076850", Offset = "0x4075250", VA = "0x184076850", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x4076830", Offset = "0x4075230", VA = "0x184076830", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x4076890", Offset = "0x4075290", VA = "0x184076890")]
		public JIXJNNLUCLL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class ABCPZDIKHDL<a, b> : DIBGAVKLOIB<IGrouping<a, b>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x53F15A0", Offset = "0x53EFFA0", VA = "0x1853F15A0", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x53F1240", Offset = "0x53EFC40", VA = "0x1853F1240", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class QLQGDMNVFEY<a, b> : DIBGAVKLOIB<ILookup<a, b>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5C48FC0", Offset = "0x5C479C0", VA = "0x185C48FC0", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5C48C50", Offset = "0x5C47650", VA = "0x185C48C50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E38DE0", Offset = "0x4E377E0", VA = "0x184E38DE0", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x4E38CC0", Offset = "0x4E376C0", VA = "0x184E38CC0")]
		public GHKBHWPGGAY(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x4E38C10", Offset = "0x4E37610", VA = "0x184E38C10", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x4E38C90", Offset = "0x4E37690", VA = "0x184E38C90", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x700F090", Offset = "0x700DA90", VA = "0x18700F090", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		public BMIUAHSYSFV(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x700EEF0", Offset = "0x700D8F0", VA = "0x18700EEF0", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x700EFE0", Offset = "0x700D9E0", VA = "0x18700EFE0", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x700EFE0", Offset = "0x700D9E0", VA = "0x18700EFE0", Slot = "7")]
		private IEnumerator WFEYQSZVQHA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class NRXHFGFOPOM<a> : DIBGAVKLOIB<a>, AZVSJTUQPQS where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5906380", Offset = "0x5904D80", VA = "0x185906380", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5906150", Offset = "0x5904B50", VA = "0x185906150", Slot = "5")]
		public a Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB7210", Offset = "0x8EB5C10", VA = "0x188EB7210", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8EB7000", Offset = "0x8EB5A00", VA = "0x188EB7000", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB77A0", Offset = "0x8EB61A0", VA = "0x188EB77A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8EB7590", Offset = "0x8EB5F90", VA = "0x188EB7590", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA65F0", Offset = "0x8EA4FF0", VA = "0x188EA65F0", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8EA63E0", Offset = "0x8EA4DE0", VA = "0x188EA63E0", Slot = "5")]
		public IList Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public DWGNSFYAWQI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class ARBZFXTTHMP<a> : SICASPIHNEA<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3E46320", Offset = "0x3E44D20", VA = "0x183E46320", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x3E46480", Offset = "0x3E44E80", VA = "0x183E46480", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class ZFPTSBBUDKB<a> : SIHHPWCEWPJ<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3E46320", Offset = "0x3E44D20", VA = "0x183E46320", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x3E46480", Offset = "0x3E44E80", VA = "0x183E46480", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x3E46410", Offset = "0x3E44E10", VA = "0x183E46410", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class VTSOXOKESSZ<a> : SIHHPWCEWPJ<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x40766E0", Offset = "0x40750E0", VA = "0x1840766E0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x4076850", Offset = "0x4075250", VA = "0x184076850", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6360B50", Offset = "0x635F550", VA = "0x186360B50", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6360C80", Offset = "0x635F680", VA = "0x186360C80")]
		public VTSOXOKESSZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class DYBSRXHTWUB<a> : SIHHPWCEWPJ<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x40766E0", Offset = "0x40750E0", VA = "0x1840766E0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x4076850", Offset = "0x4075250", VA = "0x184076850", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x4076830", Offset = "0x4075230", VA = "0x184076830", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x4076890", Offset = "0x4075290", VA = "0x184076890")]
		public DYBSRXHTWUB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class KXXDEZZHXQT<a> : SIHHPWCEWPJ<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4FB6110", Offset = "0x4FB4B10", VA = "0x184FB6110", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xB18470", Offset = "0xB16E70", VA = "0x180B18470", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x52E62C0", Offset = "0x52E4CC0", VA = "0x1852E62C0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class ORKNWOZKMRP<a> : SICASPIHNEA<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3E46320", Offset = "0x3E44D20", VA = "0x183E46320", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x4E42770", Offset = "0x4E41170", VA = "0x184E42770", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class PMGPTHMOQUG<a> : SICASPIHNEA<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3E46320", Offset = "0x3E44D20", VA = "0x183E46320", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x4E42770", Offset = "0x4E41170", VA = "0x184E42770", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class FAIBGRQMGTN<a> : SIHHPWCEWPJ<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x4076720", Offset = "0x4075120", VA = "0x184076720", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x4076850", Offset = "0x4075250", VA = "0x184076850", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4CF5BF0", Offset = "0x4CF45F0", VA = "0x184CF5BF0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB4F00", Offset = "0x8EB3900", VA = "0x188EB4F00")]
		public static DateTime NFYLEIFIMHY(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8EB4FC0", Offset = "0x8EB39C0", VA = "0x188EB4FC0")]
		public static bool VQWFVJWULBH(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8EB4C70", Offset = "0x8EB3670", VA = "0x188EB4C70")]
		public static bool LZYGSZTNBOJ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8EB4A60", Offset = "0x8EB3460", VA = "0x188EB4A60")]
		public static bool LZYGSZTNBOJ(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8EB5170", Offset = "0x8EB3B70", VA = "0x188EB5170")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA3800", Offset = "0x8EA2200", VA = "0x188EA3800", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8EA3680", Offset = "0x8EA2080", VA = "0x188EA3680", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8EA3280", Offset = "0x8EA1C80", VA = "0x188EA3280")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA5160", Offset = "0x8EA3B60", VA = "0x188EA5160", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8EA4D10", Offset = "0x8EA3710", VA = "0x188EA4D10", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8EA4D80", Offset = "0x8EA3780", VA = "0x188EA4D80")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAE370", Offset = "0x8EACD70", VA = "0x188EAE370", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8EAE2F0", Offset = "0x8EACCF0", VA = "0x188EAE2F0", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8EADF00", Offset = "0x8EAC900", VA = "0x188EADF00")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public LDXBFFOUKLU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class XOWVVJTTUFX<a, b, c, d, e> : DIBGAVKLOIB<e>, AZVSJTUQPQS where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x3DF0230", Offset = "0x3DEEC30", VA = "0x183DF0230", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x3DEFE50", Offset = "0x3DEE850", VA = "0x183DEFE50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected XOWVVJTTUFX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class XOROYCZWKUO<a, b, c, d> : XOWVVJTTUFX<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3DEFDC0", Offset = "0x3DEE7C0", VA = "0x183DEFDC0", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> CKEBFKHTHCC(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x3DEFE30", Offset = "0x3DEE830", VA = "0x183DEFE30")]
		protected XOROYCZWKUO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class XPHJPXHONCP<a, b, c> : XOROYCZWKUO<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xB18470", Offset = "0xB16E70", VA = "0x180B18470", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class OHOUSGVWJBX<a, b> : XOWVVJTTUFX<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3780", Offset = "0x5AB2180", VA = "0x185AB3780", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xB18470", Offset = "0xB16E70", VA = "0x180B18470", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3A80", Offset = "0x5AB2480", VA = "0x185AB3A80", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x5AB38F0", Offset = "0x5AB22F0", VA = "0x185AB38F0", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator CKEBFKHTHCC(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x53DC300", Offset = "0x53DAD00", VA = "0x1853DC300")]
		public OHOUSGVWJBX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class AFBVZUTZJDZ<a, b, c> : XPHJPXHONCP<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x53F8470", Offset = "0x53F6E70", VA = "0x1853F8470", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x53F8660", Offset = "0x53F7060", VA = "0x1853F8660", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class FLLEYVCTBCG<a, b> : XOROYCZWKUO<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x4CF9090", Offset = "0x4CF7A90", VA = "0x184CF9090", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x4CF9200", Offset = "0x4CF7C00", VA = "0x184CF9200", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB18470", Offset = "0xB16E70", VA = "0x180B18470", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class JLFMTROKQTI<a, b> : XPHJPXHONCP<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x4CF9090", Offset = "0x4CF7A90", VA = "0x184CF9090", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x4CF9200", Offset = "0x4CF7C00", VA = "0x184CF9200", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class UDGGTVKSNVY<a, b> : XOWVVJTTUFX<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x4CF9090", Offset = "0x4CF7A90", VA = "0x184CF9090", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB18470", Offset = "0xB16E70", VA = "0x180B18470", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x4CF9200", Offset = "0x4CF7C00", VA = "0x184CF9200", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x61E7C60", Offset = "0x61E6660", VA = "0x1861E7C60", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator CKEBFKHTHCC(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class MOQISVOZDRV<a, b> : XOROYCZWKUO<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x4CF9090", Offset = "0x4CF7A90", VA = "0x184CF9090", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5883A70", Offset = "0x5882470", VA = "0x185883A70", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x5883AE0", Offset = "0x58824E0", VA = "0x185883AE0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class ANSKKCDNIQI<a, b> : XOROYCZWKUO<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x53FBA40", Offset = "0x53FA440", VA = "0x1853FBA40", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xB18470", Offset = "0xB16E70", VA = "0x180B18470", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x53FBA80", Offset = "0x53FA480", VA = "0x1853FBA80", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x53FBB40", Offset = "0x53FA540", VA = "0x1853FBB40")]
		public ANSKKCDNIQI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class RXJCEWQTWYC<a, b> : XPHJPXHONCP<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x5CB4630", Offset = "0x5CB3030", VA = "0x185CB4630", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x4CF9200", Offset = "0x4CF7C00", VA = "0x184CF9200", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class XAAAZXBYGGA<a> : DIBGAVKLOIB<a>, AZVSJTUQPQS where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3DE03B0", Offset = "0x3DDEDB0", VA = "0x183DE03B0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3DE0180", Offset = "0x3DDEB80", VA = "0x183DE0180", Slot = "5")]
		public a Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EBC3D0", Offset = "0x8EBADD0", VA = "0x188EBC3D0", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8EBC1F0", Offset = "0x8EBABF0", VA = "0x188EBC1F0", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public YNMVOQXSHSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class GELXODEBWQU
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8EA8880", Offset = "0x8EA7280", VA = "0x188EA8880")]
		public static object XPDPZANXUEW(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8EA80C0", Offset = "0x8EA6AC0", VA = "0x188EA80C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public FVTRMYHTPKV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x4D0D0A0", Offset = "0x4D0BAA0", VA = "0x184D0D0A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public FVOKPRNWFZM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x4D0B0C0", Offset = "0x4D09AC0", VA = "0x184D0B0C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public FVJDSKTYWOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x4D0A650", Offset = "0x4D09050", VA = "0x184D0A650")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public FVDWVEABNCU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x4D0A0E0", Offset = "0x4D08AE0", VA = "0x184D0A0E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4ED9160", Offset = "0x4ED7B60", VA = "0x184ED9160")]
		static HTOQVGVVGQP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x4EE7C20", Offset = "0x4EE6620", VA = "0x184EE7C20")]
		public HTOQVGVVGQP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x4ED14F0", Offset = "0x4ECFEF0", VA = "0x184ED14F0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x4ECD800", Offset = "0x4ECC200", VA = "0x184ECD800", Slot = "5")]
		public a Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x4ED2730", Offset = "0x4ED1130", VA = "0x184ED2730", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, a b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x4ECFBD0", Offset = "0x4ECE5D0", VA = "0x184ECFBD0", Slot = "7")]
		public a LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class GPYOUSVTFHX<a> : DIBGAVKLOIB<a[,]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x4E43110", Offset = "0x4E41B10", VA = "0x184E43110", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x4E42D60", Offset = "0x4E41760", VA = "0x184E42D60", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public GPYOUSVTFHX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class SUAFPOMXAEP<a> : DIBGAVKLOIB<a[,,]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5F085A0", Offset = "0x5F06FA0", VA = "0x185F085A0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x5F080A0", Offset = "0x5F06AA0", VA = "0x185F080A0", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public SUAFPOMXAEP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class VWJDNIKSVQJ<a> : DIBGAVKLOIB<a[,,,]>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6364120", Offset = "0x6362B20", VA = "0x186364120", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6363AE0", Offset = "0x63624E0", VA = "0x186363AE0", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public VWJDNIKSVQJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class EQUCOFEWHGX<a> : DIBGAVKLOIB<a?>, AZVSJTUQPQS where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x46D1EB0", Offset = "0x46D08B0", VA = "0x1846D1EB0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x46D1C00", Offset = "0x46D0600", VA = "0x1846D1C00", Slot = "5")]
		public a? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		public VAFGWCFUQFX(DIBGAVKLOIB<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x6346920", Offset = "0x6345320", VA = "0x186346920", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x63459B0", Offset = "0x63443B0", VA = "0x1863459B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EACD80", Offset = "0x8EAB780", VA = "0x188EACD80", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8EACCF0", Offset = "0x8EAB6F0", VA = "0x188EACCF0", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8EACE10", Offset = "0x8EAB810", VA = "0x188EACE10", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, sbyte b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8EACD00", Offset = "0x8EAB700", VA = "0x188EACD00", Slot = "7")]
		public sbyte LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB0FB0", Offset = "0x8EAF9B0", VA = "0x188EB0FB0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8EB0E70", Offset = "0x8EAF870", VA = "0x188EB0E70", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8EB10A0", Offset = "0x8EAFAA0", VA = "0x188EB10A0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, sbyte? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8EB0EE0", Offset = "0x8EAF8E0", VA = "0x188EB0EE0", Slot = "7")]
		public sbyte? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA7360", Offset = "0x8EA5D60", VA = "0x188EA7360", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7220", Offset = "0x8EA5C20", VA = "0x188EA7220", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB3DF0", Offset = "0x8EB27F0", VA = "0x188EB3DF0", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8EB3D60", Offset = "0x8EB2760", VA = "0x188EB3D60", Slot = "5")]
		public short Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8EB3E80", Offset = "0x8EB2880", VA = "0x188EB3E80", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, short b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8EB3D70", Offset = "0x8EB2770", VA = "0x188EB3D70", Slot = "7")]
		public short LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB5DF0", Offset = "0x8EB47F0", VA = "0x188EB5DF0", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8EB5CB0", Offset = "0x8EB46B0", VA = "0x188EB5CB0", Slot = "5")]
		public short? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8EB5EE0", Offset = "0x8EB48E0", VA = "0x188EB5EE0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, short? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8EB5D20", Offset = "0x8EB4720", VA = "0x188EB5D20", Slot = "7")]
		public short? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB07A0", Offset = "0x8EAF1A0", VA = "0x188EB07A0", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8EB0660", Offset = "0x8EAF060", VA = "0x188EB0660", Slot = "5")]
		public short[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAAFA0", Offset = "0x8EA99A0", VA = "0x188EAAFA0", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8EAAF10", Offset = "0x8EA9910", VA = "0x188EAAF10", Slot = "5")]
		public int Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8EAB030", Offset = "0x8EA9A30", VA = "0x188EAB030", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, int b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8EAAF20", Offset = "0x8EA9920", VA = "0x188EAAF20", Slot = "7")]
		public int LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAAC50", Offset = "0x8EA9650", VA = "0x188EAAC50", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8EAAB10", Offset = "0x8EA9510", VA = "0x188EAAB10", Slot = "5")]
		public int? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8EAAD40", Offset = "0x8EA9740", VA = "0x188EAAD40", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, int? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8EAAB80", Offset = "0x8EA9580", VA = "0x188EAAB80", Slot = "7")]
		public int? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB6D60", Offset = "0x8EB5760", VA = "0x188EB6D60", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8EB6C20", Offset = "0x8EB5620", VA = "0x188EB6C20", Slot = "5")]
		public int[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB4620", Offset = "0x8EB3020", VA = "0x188EB4620", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8EB45D0", Offset = "0x8EB2FD0", VA = "0x188EB45D0", Slot = "5")]
		public long Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8EB4680", Offset = "0x8EB3080", VA = "0x188EB4680", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, long b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8EB45E0", Offset = "0x8EB2FE0", VA = "0x188EB45E0", Slot = "7")]
		public long LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA5DA0", Offset = "0x8EA47A0", VA = "0x188EA5DA0", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8EA5C60", Offset = "0x8EA4660", VA = "0x188EA5C60", Slot = "5")]
		public long? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8EA5E60", Offset = "0x8EA4860", VA = "0x188EA5E60", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, long? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8EA5CF0", Offset = "0x8EA46F0", VA = "0x188EA5CF0", Slot = "7")]
		public long? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAD750", Offset = "0x8EAC150", VA = "0x188EAD750", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8EAD610", Offset = "0x8EAC010", VA = "0x188EAD610", Slot = "5")]
		public long[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB4850", Offset = "0x8EB3250", VA = "0x188EB4850", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8EB47C0", Offset = "0x8EB31C0", VA = "0x188EB47C0", Slot = "5")]
		public byte Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8EB48E0", Offset = "0x8EB32E0", VA = "0x188EB48E0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, byte b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8EB47D0", Offset = "0x8EB31D0", VA = "0x188EB47D0", Slot = "7")]
		public byte LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA4560", Offset = "0x8EA2F60", VA = "0x188EA4560", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8EA4420", Offset = "0x8EA2E20", VA = "0x188EA4420", Slot = "5")]
		public byte? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8EA4650", Offset = "0x8EA3050", VA = "0x188EA4650", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, byte? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8EA4490", Offset = "0x8EA2E90", VA = "0x188EA4490", Slot = "7")]
		public byte? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAD400", Offset = "0x8EABE00", VA = "0x188EAD400", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8EAD370", Offset = "0x8EABD70", VA = "0x188EAD370", Slot = "5")]
		public ushort Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8EAD490", Offset = "0x8EABE90", VA = "0x188EAD490", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, ushort b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8EAD380", Offset = "0x8EABD80", VA = "0x188EAD380", Slot = "7")]
		public ushort LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAFD00", Offset = "0x8EAE700", VA = "0x188EAFD00", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFBC0", Offset = "0x8EAE5C0", VA = "0x188EAFBC0", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFDF0", Offset = "0x8EAE7F0", VA = "0x188EAFDF0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, ushort? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFC30", Offset = "0x8EAE630", VA = "0x188EAFC30", Slot = "7")]
		public ushort? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB6980", Offset = "0x8EB5380", VA = "0x188EB6980", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8EB6840", Offset = "0x8EB5240", VA = "0x188EB6840", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EBB8B0", Offset = "0x8EBA2B0", VA = "0x188EBB8B0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8EBB820", Offset = "0x8EBA220", VA = "0x188EBB820", Slot = "5")]
		public uint Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8EBB940", Offset = "0x8EBA340", VA = "0x188EBB940", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, uint b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8EBB830", Offset = "0x8EBA230", VA = "0x188EBB830", Slot = "7")]
		public uint LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EBBC00", Offset = "0x8EBA600", VA = "0x188EBBC00", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8EBBAC0", Offset = "0x8EBA4C0", VA = "0x188EBBAC0", Slot = "5")]
		public uint? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x8EBBCF0", Offset = "0x8EBA6F0", VA = "0x188EBBCF0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, uint? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8EBBB30", Offset = "0x8EBA530", VA = "0x188EBBB30", Slot = "7")]
		public uint? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB4330", Offset = "0x8EB2D30", VA = "0x188EB4330", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8EB41F0", Offset = "0x8EB2BF0", VA = "0x188EB41F0", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA30E0", Offset = "0x8EA1AE0", VA = "0x188EA30E0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8EA3090", Offset = "0x8EA1A90", VA = "0x188EA3090", Slot = "5")]
		public ulong Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8EA3140", Offset = "0x8EA1B40", VA = "0x188EA3140", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, ulong b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8EA30A0", Offset = "0x8EA1AA0", VA = "0x188EA30A0", Slot = "7")]
		public ulong LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB7D90", Offset = "0x8EB6790", VA = "0x188EB7D90", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x8EB7C50", Offset = "0x8EB6650", VA = "0x188EB7C50", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8EB7E50", Offset = "0x8EB6850", VA = "0x188EB7E50", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, ulong? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8EB7CE0", Offset = "0x8EB66E0", VA = "0x188EB7CE0", Slot = "7")]
		public ulong? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB5A80", Offset = "0x8EB4480", VA = "0x188EB5A80", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8EB5940", Offset = "0x8EB4340", VA = "0x188EB5940", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB4050", Offset = "0x8EB2A50", VA = "0x188EB4050", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8EB4000", Offset = "0x8EB2A00", VA = "0x188EB4000", Slot = "5")]
		public float Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8EB40B0", Offset = "0x8EB2AB0", VA = "0x188EB40B0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, float b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x8EB4010", Offset = "0x8EB2A10", VA = "0x188EB4010", Slot = "7")]
		public float LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAC8B0", Offset = "0x8EAB2B0", VA = "0x188EAC8B0", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8EAC7A0", Offset = "0x8EAB1A0", VA = "0x188EAC7A0", Slot = "5")]
		public float? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x8EAC970", Offset = "0x8EAB370", VA = "0x188EAC970", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, float? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8EAC810", Offset = "0x8EAB210", VA = "0x188EAC810", Slot = "7")]
		public float? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB02D0", Offset = "0x8EAECD0", VA = "0x188EB02D0", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8EB0190", Offset = "0x8EAEB90", VA = "0x188EB0190", Slot = "5")]
		public float[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA4B70", Offset = "0x8EA3570", VA = "0x188EA4B70", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8EA4B20", Offset = "0x8EA3520", VA = "0x188EA4B20", Slot = "5")]
		public double Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8EA4BD0", Offset = "0x8EA35D0", VA = "0x188EA4BD0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, double b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8EA4B30", Offset = "0x8EA3530", VA = "0x188EA4B30", Slot = "7")]
		public double LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EBD1C0", Offset = "0x8EBBBC0", VA = "0x188EBD1C0", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8EBD080", Offset = "0x8EBBA80", VA = "0x188EBD080", Slot = "5")]
		public double? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8EBD280", Offset = "0x8EBBC80", VA = "0x188EBD280", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, double? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8EBD110", Offset = "0x8EBBB10", VA = "0x188EBD110", Slot = "7")]
		public double? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAB2F0", Offset = "0x8EA9CF0", VA = "0x188EAB2F0", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8EAB1B0", Offset = "0x8EA9BB0", VA = "0x188EAB1B0", Slot = "5")]
		public double[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EACFE0", Offset = "0x8EAB9E0", VA = "0x188EACFE0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8EACF90", Offset = "0x8EAB990", VA = "0x188EACF90", Slot = "5")]
		public bool Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8EAD040", Offset = "0x8EABA40", VA = "0x188EAD040", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, bool b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8EACFA0", Offset = "0x8EAB9A0", VA = "0x188EACFA0", Slot = "7")]
		public bool LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB3820", Offset = "0x8EB2220", VA = "0x188EB3820", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8EB3710", Offset = "0x8EB2110", VA = "0x188EB3710", Slot = "5")]
		public bool? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8EB38E0", Offset = "0x8EB22E0", VA = "0x188EB38E0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, bool? b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x8EB3780", Offset = "0x8EB2180", VA = "0x188EB3780", Slot = "7")]
		public bool? LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA7D30", Offset = "0x8EA6730", VA = "0x188EA7D30", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7BF0", Offset = "0x8EA65F0", VA = "0x188EA7BF0", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAA9E0", Offset = "0x8EA93E0", VA = "0x188EAA9E0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x8EAA970", Offset = "0x8EA9370", VA = "0x188EAA970", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA7A50", Offset = "0x8EA6450", VA = "0x188EA7A50", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7980", Offset = "0x8EA6380", VA = "0x188EA7980", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAD990", Offset = "0x8EAC390", VA = "0x188EAD990", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8EAD980", Offset = "0x8EAC380", VA = "0x188EAD980", Slot = "5")]
		public string Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8EAD9F0", Offset = "0x8EAC3F0", VA = "0x188EAD9F0", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, string b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8EAD980", Offset = "0x8EAC380", VA = "0x188EAD980", Slot = "7")]
		public string LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA7750", Offset = "0x8EA6150", VA = "0x188EA7750", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x8EA7600", Offset = "0x8EA6000", VA = "0x188EA7600", Slot = "5")]
		public string[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB3C40", Offset = "0x8EB2640", VA = "0x188EB3C40", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8EB3C10", Offset = "0x8EB2610", VA = "0x188EB3C10", Slot = "5")]
		public char Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EBCF10", Offset = "0x8EBB910", VA = "0x188EBCF10", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x8EBCE50", Offset = "0x8EBB850", VA = "0x188EBCE50", Slot = "5")]
		public char? Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EADC50", Offset = "0x8EAC650", VA = "0x188EADC50", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8EADAC0", Offset = "0x8EAC4C0", VA = "0x188EADAC0", Slot = "5")]
		public char[] Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB0B10", Offset = "0x8EAF510", VA = "0x188EB0B10", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8EB0A40", Offset = "0x8EAF440", VA = "0x188EB0A40", Slot = "5")]
		public Guid Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8EB0C80", Offset = "0x8EAF680", VA = "0x188EB0C80", Slot = "6")]
		public void UFQCICPOHWU(JsonWriter a, Guid b, KIVYKHMZUOQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8EB0AA0", Offset = "0x8EAF4A0", VA = "0x188EB0AA0", Slot = "7")]
		public Guid LBFIUGYRULO(JsonReader a, KIVYKHMZUOQ b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72ABF10", Offset = "0x72AA910", VA = "0x1872ABF10")]
		public ZFHCGTFBQBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xDA29F0", Offset = "0xDA13F0", VA = "0x180DA29F0")]
		public ZFHCGTFBQBK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8EBCC00", Offset = "0x8EBB600", VA = "0x188EBCC00", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x8EBCA30", Offset = "0x8EBB430", VA = "0x188EBCA30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB0040", Offset = "0x8EAEA40", VA = "0x188EB0040", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFFC0", Offset = "0x8EAE9C0", VA = "0x188EAFFC0", Slot = "5")]
		public Uri Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAB6F0", Offset = "0x8EAA0F0", VA = "0x188EAB6F0", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x8EAB670", Offset = "0x8EAA070", VA = "0x188EAB670", Slot = "5")]
		public Version Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public INOZISJRRWF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class WQZVYRXSTFP<a, b> : DIBGAVKLOIB<KeyValuePair<a, b>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x671C600", Offset = "0x671B000", VA = "0x18671C600", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x671C110", Offset = "0x671AB10", VA = "0x18671C110", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB9C40", Offset = "0x8EB8640", VA = "0x188EB9C40", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8EB9BC0", Offset = "0x8EB85C0", VA = "0x188EB9BC0", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB3520", Offset = "0x8EB1F20", VA = "0x188EB3520", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8EB3400", Offset = "0x8EB1E00", VA = "0x188EB3400", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA4B00", Offset = "0x8EA3500", VA = "0x188EA4B00")]
		public AZJFDLHJBCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8203930", Offset = "0x8202330", VA = "0x188203930")]
		public AZJFDLHJBCH(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8EA4930", Offset = "0x8EA3330", VA = "0x188EA4930", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x8EA4820", Offset = "0x8EA3220", VA = "0x188EA4820", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EACBB0", Offset = "0x8EAB5B0", VA = "0x188EACBB0", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8EACB00", Offset = "0x8EAB500", VA = "0x188EACB00", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA6240", Offset = "0x8EA4C40", VA = "0x188EA6240", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8EA61B0", Offset = "0x8EA4BB0", VA = "0x188EA61B0", Slot = "5")]
		public Complex Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EBC0F0", Offset = "0x8EBAAF0", VA = "0x188EBC0F0", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8EBBEC0", Offset = "0x8EBA8C0", VA = "0x188EBBEC0", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public YGHSNDBBFQL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class IXKJPXVVHLE<a> : DIBGAVKLOIB<Lazy<a>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x506C9B0", Offset = "0x506B3B0", VA = "0x18506C9B0", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x506C7A0", Offset = "0x506B1A0", VA = "0x18506C7A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAD230", Offset = "0x8EABC30", VA = "0x188EAD230", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8EAD180", Offset = "0x8EABB80", VA = "0x188EAD180", Slot = "5")]
		public Task Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		public KFXMIWBKARI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class MJRDBXQPIVC<a> : DIBGAVKLOIB<Task<a>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x5882CA0", Offset = "0x58816A0", VA = "0x185882CA0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x5882AA0", Offset = "0x58814A0", VA = "0x185882AA0", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, KIVYKHMZUOQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class PAIYOXHGOLU<a> : DIBGAVKLOIB<ValueTask<a>>, AZVSJTUQPQS
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5B85370", Offset = "0x5B83D70", VA = "0x185B85370", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5B85140", Offset = "0x5B83B40", VA = "0x185B85140", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E1CCE0", Offset = "0x3E1B6E0", VA = "0x183E1CCE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x3E1C9F0", Offset = "0x3E1B3F0", VA = "0x183E1C9F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E1E150", Offset = "0x3E1CB50", VA = "0x183E1E150", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x3E1DD00", Offset = "0x3E1C700", VA = "0x183E1DD00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E1D650", Offset = "0x3E1C050", VA = "0x183E1D650", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D0C0", Offset = "0x3E1BAC0", VA = "0x183E1D0C0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E19460", Offset = "0x3E17E60", VA = "0x183E19460", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x3E18D70", Offset = "0x3E17770", VA = "0x183E18D70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E183C0", Offset = "0x3E16DC0", VA = "0x183E183C0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x3E17B60", Offset = "0x3E16560", VA = "0x183E17B60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E1BEC0", Offset = "0x3E1A8C0", VA = "0x183E1BEC0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B4D0", Offset = "0x3E19ED0", VA = "0x183E1B4D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E1A820", Offset = "0x3E19220", VA = "0x183E1A820", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x3E19CA0", Offset = "0x3E186A0", VA = "0x183E19CA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E16CB0", Offset = "0x3E156B0", VA = "0x183E16CB0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x3E15FC0", Offset = "0x3E149C0", VA = "0x183E15FC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x590B580", Offset = "0x5909F80", VA = "0x18590B580", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x590B150", Offset = "0x5909B50", VA = "0x18590B150", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x590BF90", Offset = "0x590A990", VA = "0x18590BF90", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x590BA80", Offset = "0x590A480", VA = "0x18590BA80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x590D580", Offset = "0x590BF80", VA = "0x18590D580", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x590CEE0", Offset = "0x590B8E0", VA = "0x18590CEE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x590E7C0", Offset = "0x590D1C0", VA = "0x18590E7C0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x590DF50", Offset = "0x590C950", VA = "0x18590DF50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x590FAF0", Offset = "0x590E4F0", VA = "0x18590FAF0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x590F0F0", Offset = "0x590DAF0", VA = "0x18590F0F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5911390", Offset = "0x590FD90", VA = "0x185911390", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x5910770", Offset = "0x590F170", VA = "0x185910770", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5912FE0", Offset = "0x59119E0", VA = "0x185912FE0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x5912200", Offset = "0x5910C00", VA = "0x185912200", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5914DB0", Offset = "0x59137B0", VA = "0x185914DB0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, KIVYKHMZUOQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x5913E20", Offset = "0x5912820", VA = "0x185913E20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EB3A70", Offset = "0x8EB2470", VA = "0x188EB3A70")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EA6000", Offset = "0x8EA4A00", VA = "0x188EA6000")]
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
		[Cpp2IlInjected.Address(RVA = "0x8EAB820", Offset = "0x8EAA220", VA = "0x188EAB820")]
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
