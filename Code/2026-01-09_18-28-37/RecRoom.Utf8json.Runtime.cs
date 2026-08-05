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
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAA4090", Offset = "0xAA3490", VA = "0x180AA4090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, MRQZQJMMYUF resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, MRQZQJMMYUF resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface JPRKJTPCIAD
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface KJREGAAUAOM<a> : JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, MRQZQJMMYUF formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface FZUZLTDZBCZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ULPRQKFEGCD(JsonWriter a, a b, MRQZQJMMYUF c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b);
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
	public static class LMZHZSCNQUI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x378FD40", Offset = "0x378F140", VA = "0x18378FD40")]
		public static string ToJsonString<T>(this KJREGAAUAOM<T> formatter, T value, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KJREGAAUAOM<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class YLPDNYABSAS
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C04C60", Offset = "0x3C04060", VA = "0x183C04C60")]
		public static KJREGAAUAOM<a> RUNZKYFEYPX<a>(this MRQZQJMMYUF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8D6FED0", Offset = "0x8D6F2D0", VA = "0x188D6FED0")]
		public static object GENIFLHSNAV(this MRQZQJMMYUF a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8D62230", Offset = "0x8D61630", VA = "0x188D62230")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class CJHSKNQAOVZ
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] ASHBOBEHETA;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] UHTUSJUJPHV;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] PUFDBMGQHSE;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] HCXRQXMFOPB;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] HTILQMVELTI;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] VJHGEMAFRKR;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] UTEQIELNVBX;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] NVDQTZXWCII;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class TJXESQDABJW : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x8D6E540", Offset = "0x8D6D940", VA = "0x188D6E540")]
				public TJXESQDABJW(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x8D6E420", Offset = "0x8D6D820", VA = "0x188D6E420")]
				public TJXESQDABJW PNLIYQTXWJM(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class HINSSGUVLJZ
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] HHLFCKBJOCY;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] KHNKMYTGGBB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private TJXESQDABJW start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TJXESQDABJW end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8D6DC80", Offset = "0x8D6D080", VA = "0x188D6DC80")]
			public void PNLIYQTXWJM([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8D6DD90", Offset = "0x8D6D190", VA = "0x188D6DD90")]
			public void PNLIYQTXWJM(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8D6DED0", Offset = "0x8D6D2D0", VA = "0x188D6DED0")]
			public ReadOnlySequence<byte> WVGTARAZPYJ()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8D6DAD0", Offset = "0x8D6CED0", VA = "0x188D6DAD0")]
			private void LWGXFZMNTHT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8D6D8E0", Offset = "0x8D6CCE0", VA = "0x188D6D8E0")]
			private void GOXEKGCFTJN([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8D6A120", Offset = "0x8D69520", VA = "0x188D6A120")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8D67820", Offset = "0x8D66C20", VA = "0x188D67820")]
		private JsonParsingException IBNNUFVNZYX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D68580", Offset = "0x8D67980", VA = "0x188D68580")]
		private JsonParsingException LFSRVNHARVU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8D68DF0", Offset = "0x8D681F0", VA = "0x188D68DF0")]
		public JsonToken PJNWSMDZCOG()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8D67530", Offset = "0x8D66930", VA = "0x188D67530")]
		public void GPMKRFKZXAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8D69880", Offset = "0x8D68C80", VA = "0x188D69880")]
		private bool WOQESPPMZUS(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8D698E0", Offset = "0x8D68CE0", VA = "0x188D698E0")]
		private bool WOQESPPMZUS(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8D69A10", Offset = "0x8D68E10", VA = "0x188D69A10")]
		private void YANLQUJPGYT(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8D68450", Offset = "0x8D67850", VA = "0x188D68450")]
		public bool KSGIWOYOBBB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8D67010", Offset = "0x8D66410", VA = "0x188D67010")]
		public void BXNSPLKGLJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8D68DA0", Offset = "0x8D681A0", VA = "0x188D68DA0")]
		public bool OQFOWODCBWA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8D697C0", Offset = "0x8D68BC0", VA = "0x188D697C0")]
		public void VVQAOIBJESZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8D68690", Offset = "0x8D67A90", VA = "0x188D68690")]
		public void LMIZCZFDRJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8D69200", Offset = "0x8D68600", VA = "0x188D69200")]
		public bool SZKEAFNWCXC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8D68BC0", Offset = "0x8D67FC0", VA = "0x188D68BC0")]
		public void NWSHZDTECMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8D67810", Offset = "0x8D66C10", VA = "0x188D67810")]
		public void HMFJIZJOSAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8D69250", Offset = "0x8D68650", VA = "0x188D69250")]
		public bool TAJWFYPMZMP(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8D683C0", Offset = "0x8D677C0", VA = "0x188D683C0")]
		public bool KLTCTJDRYVB(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D6A040", Offset = "0x8D69440", VA = "0x188D6A040")]
		public bool ZDJPVKMPRKO(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8D69AC0", Offset = "0x8D68EC0", VA = "0x188D69AC0")]
		private ReadOnlySequence<byte> YJHTFWBFCET()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8D67020", Offset = "0x8D66420", VA = "0x188D67020")]
		private ReadOnlySequence<byte> EUYANUEQESG()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8D67D20", Offset = "0x8D67120", VA = "0x188D67D20")]
		private void INEQETSGKFI(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8D67F10", Offset = "0x8D67310", VA = "0x188D67F10")]
		private void IVCMHSFELOV(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8D694D0", Offset = "0x8D688D0", VA = "0x188D694D0")]
		private void UIPCTOYUGGE(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8D672A0", Offset = "0x8D666A0", VA = "0x188D672A0")]
		private void FUZKSRZZBYP(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8D5D700", Offset = "0x8D5CB00", VA = "0x188D5D700")]
		private static int AKUMGYBWHKG(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D69940", Offset = "0x8D68D40", VA = "0x188D69940")]
		public ReadOnlySequence<byte> XKCTUMXNHWK()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8D692E0", Offset = "0x8D686E0", VA = "0x188D692E0")]
		public string TEHZBYUZCOX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8D68D60", Offset = "0x8D68160", VA = "0x188D68D60")]
		public string OOIEKEYVEUM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8D673B0", Offset = "0x8D667B0", VA = "0x188D673B0")]
		public ReadOnlySequence<byte> GLIRLVLBGBI()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8D68BD0", Offset = "0x8D67FD0", VA = "0x188D68BD0")]
		public ReadOnlySequence<byte> OGOLXAQIPRL()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8D69000", Offset = "0x8D68400", VA = "0x188D69000")]
		public bool SJDPGTKBUVI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8D69360", Offset = "0x8D68760", VA = "0x188D69360")]
		private void TYZCFFCFCJS(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8D67290", Offset = "0x8D66690", VA = "0x188D67290")]
		public void FTBVKERVIRW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8D68180", Offset = "0x8D67580", VA = "0x188D68180")]
		private void JXOOIUVRYMX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8D67480", Offset = "0x8D66880", VA = "0x188D67480")]
		public sbyte GMKPVIROYER()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8D68CB0", Offset = "0x8D680B0", VA = "0x188D68CB0")]
		public short OMTBKVHGTUM()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8D66F60", Offset = "0x8D66360", VA = "0x188D66F60")]
		public int BMYTEUTGXSW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8D68110", Offset = "0x8D67510", VA = "0x188D68110")]
		public long JPDEBLTJHUF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8D697D0", Offset = "0x8D68BD0", VA = "0x188D697D0")]
		public byte WJPLFAUAGAY()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8D67760", Offset = "0x8D66B60", VA = "0x188D67760")]
		public ushort GTXWEVRQXAN()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8D69150", Offset = "0x8D68550", VA = "0x188D69150")]
		public uint SZBYXTOFHOX()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8D68510", Offset = "0x8D67910", VA = "0x188D68510")]
		public ulong KWXOBCOCXNO()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8D686A0", Offset = "0x8D67AA0", VA = "0x188D686A0")]
		public float LNUUGAWDZMO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8D69FA0", Offset = "0x8D693A0", VA = "0x188D69FA0")]
		public double YLPYVVGVZKX()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8D689E0", Offset = "0x8D67DE0", VA = "0x188D689E0")]
		public ReadOnlySequence<byte> NMYNWCYJFJS()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8D68740", Offset = "0x8D67B40", VA = "0x188D68740")]
		private void MKHTYIKIEZQ()
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
			[Cpp2IlInjected.Address(RVA = "0xCE08E0", Offset = "0xCDFCE0", VA = "0x180CE08E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8D66F00", Offset = "0x8D66300", VA = "0x188D66F00")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8D66E80", Offset = "0x8D66280", VA = "0x188D66E80")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class SOPYLHRJYEQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class SQTMFZCFISP
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] HHLFCKBJOCY;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8D6D840", Offset = "0x8D6CC40", VA = "0x188D6D840")]
			public static byte[] SJMPSFWODBS()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static MRQZQJMMYUF AFPPTQAXBSB;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] RWBWXSYTGVG;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] RTRWFZKFETY;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static MRQZQJMMYUF UOFQGTVMAUZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8D6D5D0", Offset = "0x8D6C9D0", VA = "0x188D6D5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6D560", Offset = "0x8D6C960", VA = "0x188D6D560")]
		public static void NOFQPEGVJTH(MRQZQJMMYUF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3A03180", Offset = "0x3A02580", VA = "0x183A03180")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3A03010", Offset = "0x3A02410", VA = "0x183A03010")]
		public static byte[] Serialize<T>(T value, MRQZQJMMYUF resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3A03870", Offset = "0x3A02C70", VA = "0x183A03870")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3A03A30", Offset = "0x3A02E30", VA = "0x183A03A30")]
		public static string ToJsonString<T>(T value, MRQZQJMMYUF resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3A029E0", Offset = "0x3A01DE0", VA = "0x183A029E0")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3A02790", Offset = "0x3A01B90", VA = "0x183A02790")]
		public static T Deserialize<T>(string json, MRQZQJMMYUF resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3A02BB0", Offset = "0x3A01FB0", VA = "0x183A02BB0")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3A02910", Offset = "0x3A01D10", VA = "0x183A02910")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, MRQZQJMMYUF resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3A01FB0", Offset = "0x3A013B0", VA = "0x183A01FB0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3A021D0", Offset = "0x3A015D0", VA = "0x183A021D0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, MRQZQJMMYUF resolver)
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
		public int RQJDXGLAGNG
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xC9E840", Offset = "0xC9DC40", VA = "0x180C9E840")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6AFD0", Offset = "0x8D6A3D0", VA = "0x188D6AFD0")]
		public void MFBWOVONMRV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6AFE0", Offset = "0x8D6A3E0", VA = "0x188D6AFE0")]
		public static byte[] NFLHNRSGQXE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8D6A430", Offset = "0x8D69830", VA = "0x188D6A430")]
		public static byte[] CVOUZPMZCLQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8D6A290", Offset = "0x8D69690", VA = "0x188D6A290")]
		public static byte[] ASFYBUGKPJK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B0C0", Offset = "0x8D6A4C0", VA = "0x188D6B0C0")]
		public static byte[] NFNSRVBVRSM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x27FF720", Offset = "0x27FEB20", VA = "0x1827FF720")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B300", Offset = "0x8D6A700", VA = "0x188D6B300")]
		public ArraySegment<byte> SJMPSFWODBS()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8D6AD90", Offset = "0x8D6A190", VA = "0x188D6AD90")]
		public byte[] LXXNUNBRPEX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B3D0", Offset = "0x8D6A7D0", VA = "0x188D6B3D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8D6ACB0", Offset = "0x8D6A0B0", VA = "0x188D6ACB0")]
		public void KGCLGYSJNHG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8D6AF20", Offset = "0x8D6A320", VA = "0x188D6AF20")]
		public void LYHMCCBRPKB(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8D6ACE0", Offset = "0x8D6A0E0", VA = "0x188D6ACE0")]
		public void LNWFWJVIVXR(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3D9F150", Offset = "0x3D9E550", VA = "0x183D9F150")]
		public void ZNAHLFXYCIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3D9F010", Offset = "0x3D9E410", VA = "0x183D9F010")]
		public void BRXXRSIWUIT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B540", Offset = "0x8D6A940", VA = "0x188D6B540")]
		public void ZOIJITHOSBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6AF80", Offset = "0x8D6A380", VA = "0x188D6AF80")]
		public void MBEWGWFWEGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3D9F060", Offset = "0x3D9E460", VA = "0x183D9F060")]
		public void MXMYROJEZOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x57BCC40", Offset = "0x57BC040", VA = "0x1857BCC40")]
		public void PVCRRRJGHVD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B590", Offset = "0x8D6A990", VA = "0x188D6B590")]
		public void ZURHBPZLKYD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B240", Offset = "0x8D6A640", VA = "0x188D6B240")]
		public void PGBIQCMLHVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3D9F0B0", Offset = "0x3D9E4B0", VA = "0x183D9F0B0")]
		public void OONDQYZFWUU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x766F660", Offset = "0x766EA60", VA = "0x18766F660")]
		public void UWSTWXWNAXJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8D6A3B0", Offset = "0x8D697B0", VA = "0x188D6A3B0")]
		public void CBAVFFVPAFH(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D6A640", Offset = "0x8D69A40", VA = "0x188D6A640")]
		public void JMNGUHZESFG(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B4D0", Offset = "0x8D6A8D0", VA = "0x188D6B4D0")]
		public void ZFUEXQGCRGX(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B460", Offset = "0x8D6A860", VA = "0x188D6B460")]
		public void XRTVBSHBLIW(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8D6AD20", Offset = "0x8D6A120", VA = "0x188D6AD20")]
		public void LRMBVAUBTGU(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B3A0", Offset = "0x8D6A7A0", VA = "0x188D6B3A0")]
		public void TNZBQKIZZCL(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8D6A6C0", Offset = "0x8D69AC0", VA = "0x188D6A6C0")]
		public void JMZBXGBARPG(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B290", Offset = "0x8D6A690", VA = "0x188D6B290")]
		public void QYJAHPRLRXX(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6A550", Offset = "0x8D69950", VA = "0x188D6A550")]
		public void DDNDANOACMH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B430", Offset = "0x8D6A830", VA = "0x188D6B430")]
		public void VBISDWNXSKY(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6A730", Offset = "0x8D69B30", VA = "0x188D6A730")]
		public void JTAODDQKAJW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6A5C0", Offset = "0x8D699C0", VA = "0x188D6A5C0")]
		private static bool FRPLOZYGEQG(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8D6ACC0", Offset = "0x8D6A0C0", VA = "0x188D6ACC0")]
		private static byte LFRUZBDBFTW(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8D5D9F0", Offset = "0x8D5CDF0", VA = "0x188D5D9F0")]
		private static void WORCECOPWIV(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class FLXYPTDEUAS : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x46AD390", Offset = "0x46AC790", VA = "0x1846AD390")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private FLXYPTDEUAS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class WYPSZWESMOX : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x46A4480", Offset = "0x46A3880", VA = "0x1846A4480")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class GNQGSSQAEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> JBWGHSZSUZA;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8D62290", Offset = "0x8D61690", VA = "0x188D62290")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private WYPSZWESMOX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class VQGRDUPOTEL : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x46B0BE0", Offset = "0x46AFFE0", VA = "0x1846B0BE0")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly VQGRDUPOTEL ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool KLVSWCFGHWD;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static JPRKJTPCIAD[] RRQVKVQWFEZ;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static MRQZQJMMYUF[] VDICZIKUBLH;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private VQGRDUPOTEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6F010", Offset = "0x8D6E410", VA = "0x188D6F010")]
		public static void MKOAUOREKWX(params MRQZQJMMYUF[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6EF40", Offset = "0x8D6E340", VA = "0x188D6EF40")]
		public static void MKOAUOREKWX(params JPRKJTPCIAD[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8D6ECE0", Offset = "0x8D6E0E0", VA = "0x188D6ECE0")]
		public static void LCDIDLZIDZD(JPRKJTPCIAD[] a, MRQZQJMMYUF[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class MSFPBPOTJRU : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x46A33F0", Offset = "0x46A27F0", VA = "0x1846A33F0")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private MSFPBPOTJRU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class NVELNWORNIB
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly MRQZQJMMYUF HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly MRQZQJMMYUF HFQJMXNTNMW;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class TIWZLXUXUHP
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly MRQZQJMMYUF HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly MRQZQJMMYUF MQSOSASTNVO;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly MRQZQJMMYUF IISAKOZEJWW;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly MRQZQJMMYUF FCDXMBBKCUZ;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly MRQZQJMMYUF UXMAIDTWCQF;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly MRQZQJMMYUF EFTYUWGRHVV;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly MRQZQJMMYUF DBNZQTOZFMG;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly MRQZQJMMYUF ANJIZULVNNW;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly MRQZQJMMYUF DDPDLIIHQGK;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly MRQZQJMMYUF OIMLDPETBIF;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly MRQZQJMMYUF WHTOLGDSFMZ;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly MRQZQJMMYUF EPPARMUDYZR;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class DIFCNAJYNSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> JBWGHSZSUZA;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8D5E2A0", Offset = "0x8D5D6A0", VA = "0x188D5E2A0")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8D5FED0", Offset = "0x8D5F2D0", VA = "0x188D5FED0")]
		private static object WOEGITEVUHT(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class LLJODZWIVHM : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x46BAF50", Offset = "0x46BA350", VA = "0x1846BAF50")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private LLJODZWIVHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class ZZEFAFZVKYH : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x46AA1B0", Offset = "0x46A95B0", VA = "0x1846AA1B0")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private ZZEFAFZVKYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class WOIEUNFPTUZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly MRQZQJMMYUF[] ELUWBXUNMZA;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class MWQNKTREJDS : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x46A47B0", Offset = "0x46A3BB0", VA = "0x1846A47B0")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class VZOURYDRAZO : MRQZQJMMYUF
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class EENNWNAXBQF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x46ADB40", Offset = "0x46ACF40", VA = "0x1846ADB40")]
				static EENNWNAXBQF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly MRQZQJMMYUF ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly MRQZQJMMYUF[] VDICZIKUBLH;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			private VZOURYDRAZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
			public KJREGAAUAOM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly KJREGAAUAOM<object> DKTHZXEDILA;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private MWQNKTREJDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class DMKKXKPZWCT : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x46C2360", Offset = "0x46C1760", VA = "0x1846C2360")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class VZOURYDRAZO : MRQZQJMMYUF
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class EENNWNAXBQF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x46B3C40", Offset = "0x46B3040", VA = "0x1846B3C40")]
				static EENNWNAXBQF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly MRQZQJMMYUF ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly MRQZQJMMYUF[] VDICZIKUBLH;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			private VZOURYDRAZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
			public KJREGAAUAOM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly KJREGAAUAOM<object> DKTHZXEDILA;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private DMKKXKPZWCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class YRWJNOJTCVH : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x46B7700", Offset = "0x46B6B00", VA = "0x1846B7700")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class VZOURYDRAZO : MRQZQJMMYUF
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class EENNWNAXBQF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x46B7B40", Offset = "0x46B6F40", VA = "0x1846B7B40")]
				static EENNWNAXBQF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly MRQZQJMMYUF ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly MRQZQJMMYUF[] VDICZIKUBLH;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			private VZOURYDRAZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
			public KJREGAAUAOM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly KJREGAAUAOM<object> DKTHZXEDILA;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private YRWJNOJTCVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class YSZAICFCEUG : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x46C55E0", Offset = "0x46C49E0", VA = "0x1846C55E0")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class VZOURYDRAZO : MRQZQJMMYUF
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class EENNWNAXBQF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x46C34F0", Offset = "0x46C28F0", VA = "0x1846C34F0")]
				static EENNWNAXBQF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly MRQZQJMMYUF ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly MRQZQJMMYUF[] VDICZIKUBLH;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			private VZOURYDRAZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
			public KJREGAAUAOM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly KJREGAAUAOM<object> DKTHZXEDILA;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private YSZAICFCEUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class TYKJGEPFZTQ : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x46C14D0", Offset = "0x46C08D0", VA = "0x1846C14D0")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class VZOURYDRAZO : MRQZQJMMYUF
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class EENNWNAXBQF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x46B5DA0", Offset = "0x46B51A0", VA = "0x1846B5DA0")]
				static EENNWNAXBQF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly MRQZQJMMYUF ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly MRQZQJMMYUF[] VDICZIKUBLH;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			private VZOURYDRAZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
			public KJREGAAUAOM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly KJREGAAUAOM<object> DKTHZXEDILA;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private TYKJGEPFZTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class KREMXUICKYA : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x46AF0C0", Offset = "0x46AE4C0", VA = "0x1846AF0C0")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class VZOURYDRAZO : MRQZQJMMYUF
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class EENNWNAXBQF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x46AD9F0", Offset = "0x46ACDF0", VA = "0x1846AD9F0")]
				static EENNWNAXBQF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly MRQZQJMMYUF ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly MRQZQJMMYUF[] VDICZIKUBLH;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			private VZOURYDRAZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
			public KJREGAAUAOM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly KJREGAAUAOM<object> DKTHZXEDILA;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private KREMXUICKYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class HQPFMCEWOKZ : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x46B2B10", Offset = "0x46B1F10", VA = "0x1846B2B10")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class VZOURYDRAZO : MRQZQJMMYUF
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class EENNWNAXBQF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x46BA870", Offset = "0x46B9C70", VA = "0x1846BA870")]
				static EENNWNAXBQF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly MRQZQJMMYUF ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly MRQZQJMMYUF[] VDICZIKUBLH;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			private VZOURYDRAZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
			public KJREGAAUAOM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly KJREGAAUAOM<object> DKTHZXEDILA;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private HQPFMCEWOKZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class IQQIHRNRBLF : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x46A9840", Offset = "0x46A8C40", VA = "0x1846A9840")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class VZOURYDRAZO : MRQZQJMMYUF
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class EENNWNAXBQF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0x46B1AE0", Offset = "0x46B0EE0", VA = "0x1846B1AE0")]
				static EENNWNAXBQF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly MRQZQJMMYUF ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly MRQZQJMMYUF[] VDICZIKUBLH;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			private VZOURYDRAZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
			public KJREGAAUAOM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly KJREGAAUAOM<object> DKTHZXEDILA;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private IQQIHRNRBLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class POOGUNKVLMV : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x46B9DD0", Offset = "0x46B91D0", VA = "0x1846B9DD0")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class VZOURYDRAZO : MRQZQJMMYUF
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class EENNWNAXBQF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x46C5490", Offset = "0x46C4890", VA = "0x1846C5490")]
				static EENNWNAXBQF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly MRQZQJMMYUF ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly MRQZQJMMYUF[] VDICZIKUBLH;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			private VZOURYDRAZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
			public KJREGAAUAOM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly KJREGAAUAOM<object> DKTHZXEDILA;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private POOGUNKVLMV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class WLNATDLILVY : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x46BA0C0", Offset = "0x46B94C0", VA = "0x1846BA0C0")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class VZOURYDRAZO : MRQZQJMMYUF
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class EENNWNAXBQF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x46BACB0", Offset = "0x46BA0B0", VA = "0x1846BACB0")]
				static EENNWNAXBQF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly MRQZQJMMYUF ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly MRQZQJMMYUF[] VDICZIKUBLH;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			private VZOURYDRAZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
			public KJREGAAUAOM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly KJREGAAUAOM<object> DKTHZXEDILA;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private WLNATDLILVY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class GUFFPOQQZBE : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x46AABB0", Offset = "0x46A9FB0", VA = "0x1846AABB0")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class VZOURYDRAZO : MRQZQJMMYUF
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class EENNWNAXBQF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x46BC4A0", Offset = "0x46BB8A0", VA = "0x1846BC4A0")]
				static EENNWNAXBQF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly MRQZQJMMYUF ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly MRQZQJMMYUF[] VDICZIKUBLH;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			private VZOURYDRAZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
			public KJREGAAUAOM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly KJREGAAUAOM<object> DKTHZXEDILA;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private GUFFPOQQZBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class XURNJYRZRIE : MRQZQJMMYUF
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class EENNWNAXBQF<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x46C2DC0", Offset = "0x46C21C0", VA = "0x1846C2DC0")]
			static EENNWNAXBQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class VZOURYDRAZO : MRQZQJMMYUF
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class EENNWNAXBQF<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly KJREGAAUAOM<a> YWQFPNHFTUI;

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x46BB6F0", Offset = "0x46BAAF0", VA = "0x1846BB6F0")]
				static EENNWNAXBQF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly MRQZQJMMYUF ZOZTORXSSBL;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly MRQZQJMMYUF[] VDICZIKUBLH;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			private VZOURYDRAZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
			public KJREGAAUAOM<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly MRQZQJMMYUF ZOZTORXSSBL;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly KJREGAAUAOM<object> DKTHZXEDILA;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		private XURNJYRZRIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3569C70", Offset = "0x3569070", VA = "0x183569C70", Slot = "4")]
		public KJREGAAUAOM<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x5680F90", Offset = "0x5680390", VA = "0x185680F90")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5680CA0", Offset = "0x56800A0", VA = "0x185680CA0")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5680F00", Offset = "0x5680300", VA = "0x185680F00")]
		public T[] POWTEUXQYJK()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class GPJEFPYOAPQ<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int EIFPURISVZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object INFQGIZFKSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int RAJNLHVHZCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] JZCMHOLNHCV;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4E9CDF0", Offset = "0x4E9C1F0", VA = "0x184E9CDF0")]
		public GPJEFPYOAPQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4E9C740", Offset = "0x4E9BB40", VA = "0x184E9C740")]
		public a[] ILUSTXLLMJT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4E9CBB0", Offset = "0x4E9BFB0", VA = "0x184E9CBB0")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class DXUDCNSNQSU : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class IIUFNWXSMEA : IComparable<IIUFNWXSMEA>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class FTMQTTZSWCA : IEnumerable<IIUFNWXSMEA>, IEnumerable, IEnumerator<IIUFNWXSMEA>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int HEQVXHRXEOS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private IIUFNWXSMEA FKBMGWISUJL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int QYTMAKYNUQD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public IIUFNWXSMEA ZFLSXXSLHFA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int LPLBTFNQDEY;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private IIUFNWXSMEA AOIBPGPLPGB
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object HOQQBVEZJSM
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xD3EE90", Offset = "0xD3E290", VA = "0x180D3EE90")]
				[DebuggerHidden]
				public FTMQTTZSWCA(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "7")]
				[DebuggerHidden]
				private void HQQAIWMTMBV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x8D612C0", Offset = "0x8D606C0", VA = "0x188D612C0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x8D61280", Offset = "0x8D60680", VA = "0x188D61280", Slot = "10")]
				[DebuggerHidden]
				private void IWYQKYBWKKW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x8D611E0", Offset = "0x8D605E0", VA = "0x188D611E0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<IIUFNWXSMEA> AFIEKNYDRDM()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x8D611E0", Offset = "0x8D605E0", VA = "0x188D611E0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator KHITEENQWKX()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly IIUFNWXSMEA[] PEYBWHFUQPW;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] JWDKHWYHTRJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong YIPZDRXKCOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int MHEWXLBFLTJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string USRJXQPSKSU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private IIUFNWXSMEA[] CRFIBIHISSI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] PVSCSCEQSYH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int FSWFDEDBTSB;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8D66D40", Offset = "0x8D66140", VA = "0x188D66D40")]
			public IIUFNWXSMEA(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8D667F0", Offset = "0x8D65BF0", VA = "0x188D667F0")]
			public IIUFNWXSMEA Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8D66790", Offset = "0x8D65B90", VA = "0x188D66790")]
			public IIUFNWXSMEA Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8D66A20", Offset = "0x8D65E20", VA = "0x188D66A20")]
			public IIUFNWXSMEA LYDWZVFHBWK(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8D66C10", Offset = "0x8D66010", VA = "0x188D66C10")]
			internal static int OIWKRBNXPCD(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8D669F0", Offset = "0x8D65DF0", VA = "0x188D669F0", Slot = "4")]
			public int CompareTo(IIUFNWXSMEA other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8D66B90", Offset = "0x8D65F90", VA = "0x188D66B90")]
			[IteratorStateMachine(typeof(FTMQTTZSWCA))]
			public IEnumerable<IIUFNWXSMEA> OGJBZAKBZVK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class YPGIGYOFGVQ : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int QYTMAKYNUQD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<IIUFNWXSMEA> CRFIBIHISSI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<IIUFNWXSMEA> XJNDUQINHOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<IIUFNWXSMEA> DJOJRFZZVTY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private IIUFNWXSMEA HOTMWXUZUXJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> DJDVWSMFCXG;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> FIOLLMVOAED
			{
				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0xC97BF0", Offset = "0xC96FF0", VA = "0x180C97BF0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x8D70020", Offset = "0x8D6F420", VA = "0x188D70020", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x1A0A740", Offset = "0x1A09B40", VA = "0x181A0A740")]
			[DebuggerHidden]
			public YPGIGYOFGVQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8D70070", Offset = "0x8D6F470", VA = "0x188D70070", Slot = "7")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8D702A0", Offset = "0x8D6F6A0", VA = "0x188D702A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8D70700", Offset = "0x8D6FB00", VA = "0x188D70700")]
			private void UOGOWTTYZFR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8D70750", Offset = "0x8D6FB50", VA = "0x188D70750")]
			private void UOLVUANWIRA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8D701C0", Offset = "0x8D6F5C0", VA = "0x188D701C0", Slot = "10")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8D70200", Offset = "0x8D6F600", VA = "0x188D70200", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> XQDXKPGJAEU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8D70200", Offset = "0x8D6F600", VA = "0x188D70200", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KHITEENQWKX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly IIUFNWXSMEA BRWFJBTAWNM;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8D61100", Offset = "0x8D60500", VA = "0x188D61100")]
		public DXUDCNSNQSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8D608B0", Offset = "0x8D5FCB0", VA = "0x188D608B0")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8D60AF0", Offset = "0x8D5FEF0", VA = "0x188D60AF0")]
		public bool OEVDKWHYLOS(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8D60F60", Offset = "0x8D60360", VA = "0x188D60F60")]
		public bool TVNNHXCOARN([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8D61070", Offset = "0x8D60470", VA = "0x188D61070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8D60C00", Offset = "0x8D60000", VA = "0x188D60C00")]
		private static void QSLROQSZCLX(IEnumerable<IIUFNWXSMEA> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8D60A90", Offset = "0x8D5FE90", VA = "0x188D60A90", Slot = "5")]
		private IEnumerator KHITEENQWKX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8D60A90", Offset = "0x8D5FE90", VA = "0x188D60A90", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8D60EE0", Offset = "0x8D602E0", VA = "0x188D60EE0")]
		[IteratorStateMachine(typeof(YPGIGYOFGVQ))]
		private static IEnumerable<KeyValuePair<string, int>> TFHEIIYAAYU(IEnumerable<IIUFNWXSMEA> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class GXTDWUWBTAT
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo DRELKGVTGFO;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8D64650", Offset = "0x8D63A50", VA = "0x188D64650")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8D641F0", Offset = "0x8D635F0", VA = "0x188D641F0")]
		public static ulong FLVBESJGMYY(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class UUXDFETAHCH
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8D6EA60", Offset = "0x8D6DE60", VA = "0x188D6EA60")]
		public static void KGCLGYSJNHG(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8D6E940", Offset = "0x8D6DD40", VA = "0x188D6E940")]
		public static void CXNKGNZSTSQ(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6EBA0", Offset = "0x8D6DFA0", VA = "0x188D6EBA0")]
		public static byte[] VCWDXDRMLHD(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class CGYLDVJQURF<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x4777460", Offset = "0x4776860", VA = "0x184777460", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class EVMZHBMMOMD : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public CGYLDVJQURF<a> ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] DJOJRFZZVTY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int DJJCTZGCMIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] DJDVWSMFCXG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int DIYOZLSHTLX;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> XXNXSLIGIJY
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xC97BF0", Offset = "0xC96FF0", VA = "0x180C97BF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0x47579E0", Offset = "0x4756DE0", VA = "0x1847579E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
			[DebuggerHidden]
			public EVMZHBMMOMD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x4758AA0", Offset = "0x4757EA0", VA = "0x184758AA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3CC4DC0", Offset = "0x3CC41C0", VA = "0x183CC4DC0", Slot = "8")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] MMHXRWNIOVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong NHJBFRQTPBP;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool QSCLCXCAANA;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3750", Offset = "0x3CD2B50", VA = "0x183CD3750")]
		public CGYLDVJQURF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3CD3840", Offset = "0x3CD2C40", VA = "0x183CD3840")]
		public CGYLDVJQURF(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9540", Offset = "0x3CC8940", VA = "0x183CC9540")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3CCA380", Offset = "0x3CC9780", VA = "0x183CCA380")]
		private bool KSMYLFQFLEH(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2FA0", Offset = "0x3CD23A0", VA = "0x183CD2FA0")]
		public bool OEVDKWHYLOS([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3CD08C0", Offset = "0x3CCFCC0", VA = "0x183CD08C0")]
		private static ulong LAMIAXMNWCC([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3CCF720", Offset = "0x3CCEB20", VA = "0x183CCF720")]
		private static ulong LAMIAXMNWCC([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9B50", Offset = "0x3CC8F50", VA = "0x183CC9B50")]
		private static int CLMNEEFLQXI(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9B80", Offset = "0x3CC8F80", VA = "0x183CC9B80", Slot = "4")]
		[IteratorStateMachine(typeof(CGYLDVJQURF<>.EVMZHBMMOMD))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3CC9D30", Offset = "0x3CC9130", VA = "0x183CC9D30", Slot = "5")]
		private IEnumerator KHITEENQWKX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class TWEHLGMVIJM
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3A68B90", Offset = "0x3A67F90", VA = "0x183A68B90")]
		public static Func<a> GRDVPIAVTUM<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3A68C80", Offset = "0x3A68080", VA = "0x183A68C80")]
		private static c IVPXLXXUARL<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0x8D65370", Offset = "0x8D64770", VA = "0x188D65370")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8D65380", Offset = "0x8D64780", VA = "0x188D65380")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8D651F0", Offset = "0x8D645F0", VA = "0x188D651F0")]
		private static byte STIHZWYCHLL(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8D5D550", Offset = "0x8D5C950", VA = "0x188D5D550")]
		private static byte IIRUXBGAPVP(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8D649F0", Offset = "0x8D63DF0", VA = "0x188D649F0")]
		public void IYIBFQZDSVL(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class FXEVLUBFURL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8D61660", Offset = "0x8D60A60", VA = "0x188D61660")]
		public static bool HYMPKVHYNSL(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8D61530", Offset = "0x8D60930", VA = "0x188D61530")]
		public static bool GLEKOEWBOOK(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8D615A0", Offset = "0x8D609A0", VA = "0x188D615A0")]
		public static sbyte GMKPVIROYER([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8D61980", Offset = "0x8D60D80", VA = "0x188D61980")]
		public static short OMTBKVHGTUM([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8D61340", Offset = "0x8D60740", VA = "0x188D61340")]
		public static int BMYTEUTGXSW([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8D61670", Offset = "0x8D60A70", VA = "0x188D61670")]
		public static long JPDEBLTJHUF([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8D613A0", Offset = "0x8D607A0", VA = "0x188D613A0")]
		public static bool COUUQQCZLXY(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8D61FD0", Offset = "0x8D613D0", VA = "0x188D61FD0")]
		public static byte WJPLFAUAGAY([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8D61600", Offset = "0x8D60A00", VA = "0x188D61600")]
		public static ushort GTXWEVRQXAN([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8D61E20", Offset = "0x8D61220", VA = "0x188D61E20")]
		public static uint SZBYXTOFHOX([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8D617E0", Offset = "0x8D60BE0", VA = "0x188D617E0")]
		public static ulong KWXOBCOCXNO([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8D61E80", Offset = "0x8D61280", VA = "0x188D61E80")]
		public static bool UTCHPFRWSIV(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8D619E0", Offset = "0x8D60DE0", VA = "0x188D619E0")]
		public static bool QLZCBEAMKFL(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8D62120", Offset = "0x8D61520", VA = "0x188D62120")]
		public static bool ZRJYPOGZSWV(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8D61BB0", Offset = "0x8D60FB0", VA = "0x188D61BB0")]
		public static bool RMSQVWJNDQH(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8D61890", Offset = "0x8D60C90", VA = "0x188D61890")]
		public static float LNUUGAWDZMO([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8D61720", Offset = "0x8D60B20", VA = "0x188D61720")]
		public static bool JRBZDQKQAPB(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8D62030", Offset = "0x8D61430", VA = "0x188D62030")]
		public static double YLPYVVGVZKX([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8D61780", Offset = "0x8D60B80", VA = "0x188D61780")]
		public static bool JXJUANVOYRI(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8D5C390", Offset = "0x8D5B790", VA = "0x188D5C390")]
		public static int TNZBQKIZZCL(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8D5CB90", Offset = "0x8D5BF90", VA = "0x188D5CB90")]
		public static int VBISDWNXSKY(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8D61C50", Offset = "0x8D61050", VA = "0x188D61C50")]
		public static bool SJDPGTKBUVI([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class ACXHQJJXXKN
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8D5DEF0", Offset = "0x8D5D2F0", VA = "0x188D5DEF0")]
		public static bool NLLJPBLNZYX(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class QURUPTNVRJU
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding KYMYSIZVXZH;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class KKCWKMYXWVI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B990", Offset = "0x8D6AD90", VA = "0x188D6B990")]
		public static void AUYJDXUVJPF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B920", Offset = "0x8D6AD20", VA = "0x188D6B920")]
		public static void AUTCGRAYADW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BA70", Offset = "0x8D6AE70", VA = "0x188D6BA70")]
		public static void AVIWYLIQCLX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BA00", Offset = "0x8D6AE00", VA = "0x188D6BA00")]
		public static void AVDQBEOSTAO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B760", Offset = "0x8D6AB60", VA = "0x188D6B760")]
		public static void ASNEKUQBAJB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B6F0", Offset = "0x8D6AAF0", VA = "0x188D6B6F0")]
		public static void ASHXNNWDQXS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C130", Offset = "0x8D6B530", VA = "0x188D6C130")]
		public static void GBAMGPQSIFG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C1A0", Offset = "0x8D6B5A0", VA = "0x188D6C1A0")]
		public static void GBFTDWKPRQP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C210", Offset = "0x8D6B610", VA = "0x188D6C210")]
		public static void GBLABDENBBY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C280", Offset = "0x8D6B680", VA = "0x188D6C280")]
		public static void GBQGYJYKKNH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C300", Offset = "0x8D6B700", VA = "0x188D6C300")]
		public static void GBVNVQSHTYQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C380", Offset = "0x8D6B780", VA = "0x188D6C380")]
		public static void GCAUSXMFDJZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C400", Offset = "0x8D6B800", VA = "0x188D6C400")]
		public static void GCGBQEGCMVI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C480", Offset = "0x8D6B880", VA = "0x188D6C480")]
		public static void GCLINKZZWGR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C030", Offset = "0x8D6B430", VA = "0x188D6C030")]
		public static void FZKJCNNNKSM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C0B0", Offset = "0x8D6B4B0", VA = "0x188D6C0B0")]
		public static void FZPPZUHKUDV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BB60", Offset = "0x8D6AF60", VA = "0x188D6BB60")]
		public static void AWNOMKCGNJF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BAE0", Offset = "0x8D6AEE0", VA = "0x188D6BAE0")]
		public static void AWIHPDIJDXW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BC60", Offset = "0x8D6B060", VA = "0x188D6BC60")]
		public static void AWYCGXQBGFX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BBE0", Offset = "0x8D6AFE0", VA = "0x188D6BBE0")]
		public static void AWSVJQWDWUO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BD70", Offset = "0x8D6B170", VA = "0x188D6BD70")]
		public static void AXIQBLDVZCP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BCE0", Offset = "0x8D6B0E0", VA = "0x188D6BCE0")]
		public static void AXDJEEJYPRG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BE80", Offset = "0x8D6B280", VA = "0x188D6BE80")]
		public static void AXTDVYRQRZH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BDF0", Offset = "0x8D6B1F0", VA = "0x188D6BDF0")]
		public static void AXNWYRXTINY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BFA0", Offset = "0x8D6B3A0", VA = "0x188D6BFA0")]
		public static void AYDRQMFLKVZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BF10", Offset = "0x8D6B310", VA = "0x188D6BF10")]
		public static void AXYKTFLOBKQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C500", Offset = "0x8D6B900", VA = "0x188D6C500")]
		public static void UCIWEAGXNPY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C590", Offset = "0x8D6B990", VA = "0x188D6C590")]
		public static void UCODBHAUXBH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B7D0", Offset = "0x8D6ABD0", VA = "0x188D6B7D0")]
		public static void ATYARPZIOKM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B8B0", Offset = "0x8D6ACB0", VA = "0x188D6B8B0")]
		public static void AUNVJKHAQSN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B840", Offset = "0x8D6AC40", VA = "0x188D6B840")]
		public static void AUIOMDNDHHE(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class PINVIXOKUOZ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C960", Offset = "0x8D6BD60", VA = "0x188D6C960")]
		public static void ASNEKUQBAJB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C8F0", Offset = "0x8D6BCF0", VA = "0x188D6C8F0")]
		public static void ASHXNNWDQXS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CFD0", Offset = "0x8D6C3D0", VA = "0x188D6CFD0")]
		public static void GBAMGPQSIFG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8D6D040", Offset = "0x8D6C440", VA = "0x188D6D040")]
		public static void GBFTDWKPRQP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8D6D0B0", Offset = "0x8D6C4B0", VA = "0x188D6D0B0")]
		public static void GBLABDENBBY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8D6D120", Offset = "0x8D6C520", VA = "0x188D6D120")]
		public static void GBQGYJYKKNH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8D6D190", Offset = "0x8D6C590", VA = "0x188D6D190")]
		public static void GBVNVQSHTYQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8D6D200", Offset = "0x8D6C600", VA = "0x188D6D200")]
		public static void GCAUSXMFDJZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8D6D270", Offset = "0x8D6C670", VA = "0x188D6D270")]
		public static void GCGBQEGCMVI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8D6D2E0", Offset = "0x8D6C6E0", VA = "0x188D6D2E0")]
		public static void GCLINKZZWGR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CED0", Offset = "0x8D6C2D0", VA = "0x188D6CED0")]
		public static void FZKJCNNNKSM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CF50", Offset = "0x8D6C350", VA = "0x188D6CF50")]
		public static void FZPPZUHKUDV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CA50", Offset = "0x8D6BE50", VA = "0x188D6CA50")]
		public static void AWNOMKCGNJF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8D6C9D0", Offset = "0x8D6BDD0", VA = "0x188D6C9D0")]
		public static void AWIHPDIJDXW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CB50", Offset = "0x8D6BF50", VA = "0x188D6CB50")]
		public static void AWYCGXQBGFX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CAD0", Offset = "0x8D6BED0", VA = "0x188D6CAD0")]
		public static void AWSVJQWDWUO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CC50", Offset = "0x8D6C050", VA = "0x188D6CC50")]
		public static void AXIQBLDVZCP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CBD0", Offset = "0x8D6BFD0", VA = "0x188D6CBD0")]
		public static void AXDJEEJYPRG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CD50", Offset = "0x8D6C150", VA = "0x188D6CD50")]
		public static void AXTDVYRQRZH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CCD0", Offset = "0x8D6C0D0", VA = "0x188D6CCD0")]
		public static void AXNWYRXTINY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CE50", Offset = "0x8D6C250", VA = "0x188D6CE50")]
		public static void AYDRQMFLKVZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8D6CDD0", Offset = "0x8D6C1D0", VA = "0x188D6CDD0")]
		public static void AXYKTFLOBKQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8D6D360", Offset = "0x8D6C760", VA = "0x188D6D360")]
		public static void UCIWEAGXNPY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8D6D3E0", Offset = "0x8D6C7E0", VA = "0x188D6D3E0")]
		public static void UCODBHAUXBH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B7D0", Offset = "0x8D6ABD0", VA = "0x188D6B7D0")]
		public static void ATYARPZIOKM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B8B0", Offset = "0x8D6ACB0", VA = "0x188D6B8B0")]
		public static void AUNVJKHAQSN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B840", Offset = "0x8D6AC40", VA = "0x188D6B840")]
		public static void AUIOMDNDHHE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B990", Offset = "0x8D6AD90", VA = "0x188D6B990")]
		public static void AUYJDXUVJPF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8D6B920", Offset = "0x8D6AD20", VA = "0x188D6B920")]
		public static void AUTCGRAYADW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BA70", Offset = "0x8D6AE70", VA = "0x188D6BA70")]
		public static void AVIWYLIQCLX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BA00", Offset = "0x8D6AE00", VA = "0x188D6BA00")]
		public static void AVDQBEOSTAO(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class WHGYKDNXMYP
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool QSCLCXCAANA;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8D85070", Offset = "0x8D84470", VA = "0x188D85070")]
		public static void LYHMCCBRPKB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D86A70", Offset = "0x8D85E70", VA = "0x188D86A70")]
		public static void YCDOLOUGUEU(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x28A86F0", Offset = "0x28A7AF0", VA = "0x1828A86F0")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D76000", Offset = "0x8D75400", VA = "0x188D76000")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8D75F60", Offset = "0x8D75360", VA = "0x188D75F60")]
		public static DiyFp GANWIIDAGQG(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8D75F70", Offset = "0x8D75370", VA = "0x188D75F70")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8D760A0", Offset = "0x8D754A0", VA = "0x188D760A0")]
		public static DiyFp VQZWIWKUPDW(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8D76010", Offset = "0x8D75410", VA = "0x188D76010")]
		public void VPIFVOGCFWZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8D76050", Offset = "0x8D75450", VA = "0x188D76050")]
		public static DiyFp VPIFVOGCFWZ(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xC2A570", Offset = "0xC29970", VA = "0x180C2A570")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8D81010", Offset = "0x8D80410", VA = "0x188D81010")]
		public void ECFGTNXSRNG(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8D81070", Offset = "0x8D80470", VA = "0x188D81070")]
		public void JIZVEOWQQXO(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8D81270", Offset = "0x8D80670", VA = "0x188D81270")]
		public void VFERTDVEPXS(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x8D812F0", Offset = "0x8D806F0", VA = "0x188D812F0")]
		public void VFERTDVEPXS(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8D810F0", Offset = "0x8D804F0", VA = "0x188D810F0")]
		public void OGBUDOVCYQC(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x8D81170", Offset = "0x8D80570", VA = "0x188D81170")]
		public void OMYCCSKBKXL(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class UMLLYUKPCZP
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
		private static byte[] RURZJMDDFYC;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] UICLPWJVIXA;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] CGQLGHNJJWY;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] JTHDDAONAGJ;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags PSKTNFLCHIK;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char WJPYEGWWKES;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int OLVOYPSEBHI;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int UUGKKNNGKBM;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] BHTYXYBGHRS;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8D83BB0", Offset = "0x8D82FB0", VA = "0x188D83BB0")]
		private static byte[] PLZCARDUPRM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x8D82A60", Offset = "0x8D81E60", VA = "0x188D82A60")]
		private static byte[] EBSABCUULGC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8D83880", Offset = "0x8D82C80", VA = "0x188D83880")]
		public static int NMXZRRRUIDH(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8D839A0", Offset = "0x8D82DA0", VA = "0x188D839A0")]
		public static int NMXZRRRUIDH(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8D83AC0", Offset = "0x8D82EC0", VA = "0x188D83AC0")]
		private static bool PEFUHSVLRQD(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8D83C80", Offset = "0x8D83080", VA = "0x188D83C80")]
		private static void PMTIPBMHNIX(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D82FF0", Offset = "0x8D823F0", VA = "0x188D82FF0")]
		private static bool KGHEQVVYFEP(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D83D70", Offset = "0x8D83170", VA = "0x188D83D70")]
		private static bool XBGTUIBBCFZ(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8D82D00", Offset = "0x8D82100", VA = "0x188D82D00")]
		private static bool IUYECHOMDVG(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8D82B40", Offset = "0x8D81F40", VA = "0x188D82B40")]
		private static bool GDHQHWOOFFP(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8D833B0", Offset = "0x8D827B0", VA = "0x188D833B0")]
		private static bool KTNBPNSQMSI(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8D841F0", Offset = "0x8D835F0", VA = "0x188D841F0")]
		private static void ZWAINXJWPSQ(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8D82620", Offset = "0x8D81A20", VA = "0x188D82620")]
		private static void BCCOHRYKWRW(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x8D82E00", Offset = "0x8D82200", VA = "0x188D82E00")]
		private static bool JDHOBSXFTJT(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0x8D76760", Offset = "0x8D75B60", VA = "0x188D76760")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D766C0", Offset = "0x8D75AC0", VA = "0x188D766C0")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D76580", Offset = "0x8D75980", VA = "0x188D76580")]
		public DiyFp SAKQJVLYNMG()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8D76370", Offset = "0x8D75770", VA = "0x188D76370")]
		public DiyFp JOWHVMJPYEJ()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xBEF450", Offset = "0xBEE850", VA = "0x180BEF450")]
		public ulong FMTEPRJURAE()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8D761B0", Offset = "0x8D755B0", VA = "0x188D761B0")]
		public double GLSOWLYSVYO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8D76480", Offset = "0x8D75880", VA = "0x188D76480")]
		public double LWLAOGCFIEK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8D765F0", Offset = "0x8D759F0", VA = "0x188D765F0")]
		public int TEXGASIHLYR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8D76690", Offset = "0x8D75A90", VA = "0x188D76690")]
		public ulong XSSVQRKTTPL()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D76190", Offset = "0x8D75590", VA = "0x188D76190")]
		public bool FBIGZDVKKRU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8D76170", Offset = "0x8D75570", VA = "0x188D76170")]
		public bool DXGZDZDAFHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8D76140", Offset = "0x8D75540", VA = "0x188D76140")]
		public bool DBYQGXVUPAT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D76640", Offset = "0x8D75A40", VA = "0x188D76640")]
		public bool UCGFSXVGPVM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8D76620", Offset = "0x8D75A20", VA = "0x188D76620")]
		public int TQBEIYFWQSL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D76230", Offset = "0x8D75630", VA = "0x188D76230")]
		public void IKNHPRBXUTP([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8D76530", Offset = "0x8D75930", VA = "0x188D76530")]
		public bool OCKJVFZIKNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3B8D510", Offset = "0x3B8C910", VA = "0x183B8D510")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8D76670", Offset = "0x8D75A70", VA = "0x188D76670")]
		public static int UHOFZLRDWKC(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8D76520", Offset = "0x8D75920", VA = "0x188D76520")]
		public static double NEUWPLKLBEO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8D763F0", Offset = "0x8D757F0", VA = "0x188D763F0")]
		public static ulong KJFXQKZLUXL(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x1584180", Offset = "0x1583580", VA = "0x181584180")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D80F70", Offset = "0x8D80370", VA = "0x188D80F70")]
		public DiyFp SAKQJVLYNMG()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xC9E6F0", Offset = "0xC9DAF0", VA = "0x180C9E6F0")]
		public uint LLCCBJYIAQD()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8D80FD0", Offset = "0x8D803D0", VA = "0x188D80FD0")]
		public int TEXGASIHLYR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8D80FF0", Offset = "0x8D803F0", VA = "0x188D80FF0")]
		public uint XSSVQRKTTPL()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8D80DF0", Offset = "0x8D801F0", VA = "0x188D80DF0")]
		public bool FBIGZDVKKRU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8D80E00", Offset = "0x8D80200", VA = "0x188D80E00")]
		public void IKNHPRBXUTP([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x8D80F30", Offset = "0x8D80330", VA = "0x188D80F30")]
		public bool OCKJVFZIKNN()
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
		[Cpp2IlInjected.Address(RVA = "0x8D74C30", Offset = "0x8D74030", VA = "0x188D74C30")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class ADWNBARPCUC
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] RKYWYMNCPKT;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8D70F70", Offset = "0x8D70370", VA = "0x188D70F70")]
		public static void HFUMYWQSTJZ(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8D70EA0", Offset = "0x8D702A0", VA = "0x188D70EA0")]
		public static void EUETVTNKODK(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0x8D84E90", Offset = "0x8D84290", VA = "0x188D84E90")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x582F7D0", Offset = "0x582EBD0", VA = "0x18582F7D0")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBB10", Offset = "0x2ADAF10", VA = "0x182ADBB10")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8D84E30", Offset = "0x8D84230", VA = "0x188D84E30")]
		public Vector LGBWYAPBHPF(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class BONSPAKMJRN
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] LHVJHXRTOGZ;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] YADPGEOWVRS;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int GTUUWXEKHGJ;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8D73690", Offset = "0x8D72A90", VA = "0x188D73690")]
		private static byte[] UKWVBIPULLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8D735B0", Offset = "0x8D729B0", VA = "0x188D735B0")]
		private static Vector SBPVQDTZIQD(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8D72720", Offset = "0x8D71B20", VA = "0x188D72720")]
		private static Vector DUEXMFDGCAJ(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D73900", Offset = "0x8D72D00", VA = "0x188D73900")]
		private static void XBBTVPWUEDK(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8D72800", Offset = "0x8D71C00", VA = "0x188D72800")]
		private static void EQAGCJZIGFH(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8D72AF0", Offset = "0x8D71EF0", VA = "0x188D72AF0")]
		private static ulong IFCTSHTZVAA(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8D73D40", Offset = "0x8D73140", VA = "0x188D73D40")]
		private static void ZJUFNINYNJI(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8D73990", Offset = "0x8D72D90", VA = "0x188D73990")]
		private static bool XXLJYESODZH(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8D73770", Offset = "0x8D72B70", VA = "0x188D73770")]
		private static DiyFp VTMFIFRFGVQ(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x8D72F70", Offset = "0x8D72370", VA = "0x188D72F70")]
		private static bool PSPLKQHFEIE(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8D72600", Offset = "0x8D71A00", VA = "0x188D72600")]
		private static bool CLYPNFMHBYA(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8D72B80", Offset = "0x8D71F80", VA = "0x188D72B80")]
		public static double? OPVIBZUPFRK(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8D72CA0", Offset = "0x8D720A0", VA = "0x188D72CA0")]
		public static float? OQFVWNIJYOC(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class OCBUIOOXJAF
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] DZDRUPIAZWR;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] CGQLGHNJJWY;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] JTHDDAONAGJ;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] QDRMMYCUKIT;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int FHIISHTCETF;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] VFZQHAJXIGN;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int PUPZDLJYFOZ;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8D7DB70", Offset = "0x8D7CF70", VA = "0x188D7DB70")]
		private static byte[] SJMPSFWODBS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D400", Offset = "0x8D7C800", VA = "0x188D7D400")]
		public static bool JRBZDQKQAPB(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D540", Offset = "0x8D7C940", VA = "0x188D7D540")]
		public static bool JXJUANVOYRI(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D680", Offset = "0x8D7CA80", VA = "0x188D7D680")]
		private static bool MZKCLAFEXUL(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D7D0", Offset = "0x8D7CBD0", VA = "0x188D7D7D0")]
		private static bool PDZSPMXMOPE(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x8D7DA90", Offset = "0x8D7CE90", VA = "0x188D7DA90")]
		private static bool SHKVJJSVVBJ(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x8D7DC50", Offset = "0x8D7D050", VA = "0x188D7DC50")]
		private static bool XGTTJOJWNVP(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8D7D7B0", Offset = "0x8D7CBB0", VA = "0x188D7D7B0")]
		private static double PBQTKFPSIEU(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C420", Offset = "0x8D7B820", VA = "0x188D7C420")]
		private static double DSMAOJVOBQS(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class YEQGXGCQOGQ<a> : KJREGAAUAOM<a[]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly GPJEFPYOAPQ<a> VALSWENLRZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour QZFTXHELBSL;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x167B4D0", Offset = "0x167A8D0", VA = "0x18167B4D0")]
		public YEQGXGCQOGQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
		public YEQGXGCQOGQ(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x3E2B8A0", Offset = "0x3E2ACA0", VA = "0x183E2B8A0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x3E2B570", Offset = "0x3E2A970", VA = "0x183E2B570", Slot = "5")]
		public a[] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class KQRGBZGZQDX<a> : KJREGAAUAOM<ArraySegment<a>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly GPJEFPYOAPQ<a> VALSWENLRZL;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5271E60", Offset = "0x5271260", VA = "0x185271E60", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5271A20", Offset = "0x5270E20", VA = "0x185271A20", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class HFBZERBNLST<a> : KJREGAAUAOM<List<a>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour QZFTXHELBSL;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x167B4D0", Offset = "0x167A8D0", VA = "0x18167B4D0")]
		public HFBZERBNLST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
		public HFBZERBNLST(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x4F10290", Offset = "0x4F0F690", VA = "0x184F10290", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x4F0E420", Offset = "0x4F0D820", VA = "0x184F0E420", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class GMBUJSZTVVX<a, b, c, d> : KJREGAAUAOM<d>, JPRKJTPCIAD where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x4E97C40", Offset = "0x4E97040", VA = "0x184E97C40", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x4E95E30", Offset = "0x4E95230", VA = "0x184E95E30", Slot = "5")]
		public d Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c XUQUPGKBPPT(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		protected GMBUJSZTVVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class GKQYCXQMHUM<a, b, c> : GMBUJSZTVVX<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x4E95B10", Offset = "0x4E94F10", VA = "0x184E95B10", Slot = "6")]
		protected override IEnumerator<a> XUQUPGKBPPT(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		protected GKQYCXQMHUM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class GKWFAEKJRFV<a, b> : GKQYCXQMHUM<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xB05110", Offset = "0xB04510", VA = "0x180B05110", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class ZWAETZKIPFP<a, b> : GKWFAEKJRFV<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3F19F50", Offset = "0x3F19350", VA = "0x183F19F50", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3F19DF0", Offset = "0x3F191F0", VA = "0x183F19DF0", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class GIKPQFSTYGA<a> : GMBUJSZTVVX<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4E93A10", Offset = "0x4E92E10", VA = "0x184E93A10", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xB05110", Offset = "0xB04510", VA = "0x180B05110", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x4E93AF0", Offset = "0x4E92EF0", VA = "0x184E93AF0", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4602B10", Offset = "0x4601F10", VA = "0x184602B10", Slot = "6")]
		protected override LinkedList<a>.Enumerator XUQUPGKBPPT(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class THWXPNGXFSJ<a> : GMBUJSZTVVX<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4EA76E0", Offset = "0x4EA6AE0", VA = "0x184EA76E0", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x4F51160", Offset = "0x4F50560", VA = "0x184F51160", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x50EB870", Offset = "0x50EAC70", VA = "0x1850EB870", Slot = "6")]
		protected override Queue<a>.Enumerator XUQUPGKBPPT(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xB05110", Offset = "0xB04510", VA = "0x180B05110", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class MOAWLXHSXJB<a> : GMBUJSZTVVX<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x50E4850", Offset = "0x50E3C50", VA = "0x1850E4850", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x57D5ED0", Offset = "0x57D52D0", VA = "0x1857D5ED0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x57D5F00", Offset = "0x57D5300", VA = "0x1857D5F00", Slot = "6")]
		protected override Stack<a>.Enumerator XUQUPGKBPPT(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x57D5D70", Offset = "0x57D5170", VA = "0x1857D5D70", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class JNYBXLSBJJF<a> : GMBUJSZTVVX<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x50EB6F0", Offset = "0x50EAAF0", VA = "0x1850EB6F0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xB05110", Offset = "0xB04510", VA = "0x180B05110", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x50EB810", Offset = "0x50EAC10", VA = "0x1850EB810", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x50EB920", Offset = "0x50EAD20", VA = "0x1850EB920", Slot = "6")]
		protected override HashSet<a>.Enumerator XUQUPGKBPPT(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x50EB970", Offset = "0x50EAD70", VA = "0x1850EB970")]
		public JNYBXLSBJJF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class JNMYBDOJYMZ<a> : GKQYCXQMHUM<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x50E4850", Offset = "0x50E3C50", VA = "0x1850E4850", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x50E4920", Offset = "0x50E3D20", VA = "0x1850E4920", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x50E49B0", Offset = "0x50E3DB0", VA = "0x1850E49B0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class AXZNFORUBRM<a> : GKQYCXQMHUM<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x4EA76E0", Offset = "0x4EA6AE0", VA = "0x184EA76E0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x4F51160", Offset = "0x4F50560", VA = "0x184F51160", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB05110", Offset = "0xB04510", VA = "0x180B05110", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class BYPJDWJVRQW<a> : GKQYCXQMHUM<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x4EA76E0", Offset = "0x4EA6AE0", VA = "0x184EA76E0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x4F51160", Offset = "0x4F50560", VA = "0x184F51160", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB05110", Offset = "0xB04510", VA = "0x180B05110", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class RARLUFMDRDO<a> : GKQYCXQMHUM<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5B118A0", Offset = "0x5B10CA0", VA = "0x185B118A0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x57D5ED0", Offset = "0x57D52D0", VA = "0x1857D5ED0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5B118F0", Offset = "0x5B10CF0", VA = "0x185B118F0", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3CFA5F0", Offset = "0x3CF99F0", VA = "0x183CFA5F0")]
		public RARLUFMDRDO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class MPTKLZCNCNW<a, b> : KJREGAAUAOM<IGrouping<a, b>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x57D62F0", Offset = "0x57D56F0", VA = "0x1857D62F0", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x57D5FB0", Offset = "0x57D53B0", VA = "0x1857D5FB0", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class RTTUWKEPHJD<a, b> : KJREGAAUAOM<ILookup<a, b>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5B84940", Offset = "0x5B83D40", VA = "0x185B84940", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5B845F0", Offset = "0x5B839F0", VA = "0x185B845F0", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class QDLVHGCRBTP<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a OGKRXNXYGFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> LPSJIIQBTNV;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x3F1AB90", Offset = "0x3F19F90", VA = "0x183F1AB90", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5AC3EF0", Offset = "0x5AC32F0", VA = "0x185AC3EF0")]
		public QDLVHGCRBTP(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5AC3E80", Offset = "0x5AC3280", VA = "0x185AC3E80", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x50DCD80", Offset = "0x50DC180", VA = "0x1850DCD80", Slot = "6")]
		private IEnumerator KHITEENQWKX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class KWKFXLLJVYO<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> TWGALGQZFHG;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x5275C60", Offset = "0x5275060", VA = "0x185275C60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public KWKFXLLJVYO(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5275AD0", Offset = "0x5274ED0", VA = "0x185275AD0", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x5275BC0", Offset = "0x5274FC0", VA = "0x185275BC0", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5275BC0", Offset = "0x5274FC0", VA = "0x185275BC0", Slot = "7")]
		private IEnumerator KHITEENQWKX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class QWPXTWBHBVN<a> : KJREGAAUAOM<a>, JPRKJTPCIAD where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC370", Offset = "0x5AFB770", VA = "0x185AFC370", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5AFC160", Offset = "0x5AFB560", VA = "0x185AFC160", Slot = "5")]
		public a Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public QWPXTWBHBVN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class SIJJTLDDDZV : KJREGAAUAOM<IEnumerable>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly KJREGAAUAOM<IEnumerable> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8D80530", Offset = "0x8D7F930", VA = "0x188D80530", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8D80320", Offset = "0x8D7F720", VA = "0x188D80320", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public SIJJTLDDDZV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class UJIRUVOAYZT : KJREGAAUAOM<ICollection>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly KJREGAAUAOM<ICollection> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8D82170", Offset = "0x8D81570", VA = "0x188D82170", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8D81F60", Offset = "0x8D81360", VA = "0x188D81F60", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public UJIRUVOAYZT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class PBTPHJIARNP : KJREGAAUAOM<IList>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly KJREGAAUAOM<IList> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E7B0", Offset = "0x8D7DBB0", VA = "0x188D7E7B0", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E5A0", Offset = "0x8D7D9A0", VA = "0x188D7E5A0", Slot = "5")]
		public IList Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public PBTPHJIARNP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class GVGELRTHBGM<a> : GKWFAEKJRFV<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x4EA76E0", Offset = "0x4EA6AE0", VA = "0x184EA76E0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x4EA77C0", Offset = "0x4EA6BC0", VA = "0x184EA77C0", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class AUCNYOXMVVI<a> : GKQYCXQMHUM<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA76E0", Offset = "0x4EA6AE0", VA = "0x184EA76E0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x4EA77C0", Offset = "0x4EA6BC0", VA = "0x184EA77C0", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x54422B0", Offset = "0x54416B0", VA = "0x1854422B0", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class UBOBGGZJVDS<a> : GKQYCXQMHUM<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x60E6DB0", Offset = "0x60E61B0", VA = "0x1860E6DB0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x57D5ED0", Offset = "0x57D52D0", VA = "0x1857D5ED0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x60E6E90", Offset = "0x60E6290", VA = "0x1860E6E90", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x60E6F90", Offset = "0x60E6390", VA = "0x1860E6F90")]
		public UBOBGGZJVDS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class WJXIJNYRNTS<a> : GKQYCXQMHUM<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x60E6DB0", Offset = "0x60E61B0", VA = "0x1860E6DB0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x57D5ED0", Offset = "0x57D52D0", VA = "0x1857D5ED0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5B118F0", Offset = "0x5B10CF0", VA = "0x185B118F0", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x3CFA5F0", Offset = "0x3CF99F0", VA = "0x183CFA5F0")]
		public WJXIJNYRNTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class TDABVLYHDSA<a> : GKQYCXQMHUM<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x50EB730", Offset = "0x50EAB30", VA = "0x1850EB730", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xB05110", Offset = "0xB04510", VA = "0x180B05110", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x4E93AF0", Offset = "0x4E92EF0", VA = "0x184E93AF0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class JXQYUVGOGCE<a> : GKWFAEKJRFV<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x4EA76E0", Offset = "0x4EA6AE0", VA = "0x184EA76E0", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x4F51160", Offset = "0x4F50560", VA = "0x184F51160", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class HXFYJYUEOSP<a> : GKWFAEKJRFV<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA76E0", Offset = "0x4EA6AE0", VA = "0x184EA76E0", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x4F51160", Offset = "0x4F50560", VA = "0x184F51160", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class WDHFDCCTJLM<a> : GKQYCXQMHUM<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x50E4850", Offset = "0x50E3C50", VA = "0x1850E4850", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x57D5ED0", Offset = "0x57D52D0", VA = "0x1857D5ED0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x65B9120", Offset = "0x65B8520", VA = "0x1865B9120", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class QQBBAUFUXFZ
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
		[Cpp2IlInjected.Address(RVA = "0x8D7F250", Offset = "0x8D7E650", VA = "0x188D7F250")]
		public static DateTime GUWSBSDZTOT(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8D7F310", Offset = "0x8D7E710", VA = "0x188D7F310")]
		public static bool IZWSLEMCDTY(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8D7EDB0", Offset = "0x8D7E1B0", VA = "0x188D7EDB0")]
		public static bool DUKBDTCEQSK(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8D7F040", Offset = "0x8D7E440", VA = "0x188D7F040")]
		public static bool DUKBDTCEQSK(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8D7F4C0", Offset = "0x8D7E8C0", VA = "0x188D7F4C0")]
		public static bool PQDRKIOKDZO(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class MEOBZBUUMXN : KJREGAAUAOM<DateTime>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly KJREGAAUAOM<DateTime> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8D7AAE0", Offset = "0x8D79EE0", VA = "0x188D7AAE0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8D7A960", Offset = "0x8D79D60", VA = "0x188D7A960", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8D7A560", Offset = "0x8D79960", VA = "0x188D7A560")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public MEOBZBUUMXN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class YCJILNBILGK : KJREGAAUAOM<DateTimeOffset>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly KJREGAAUAOM<DateTimeOffset> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8D89580", Offset = "0x8D88980", VA = "0x188D89580", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8D89130", Offset = "0x8D88530", VA = "0x188D89130", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8D891A0", Offset = "0x8D885A0", VA = "0x188D891A0")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public YCJILNBILGK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class XPWKBLLQJTJ : KJREGAAUAOM<TimeSpan>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly KJREGAAUAOM<TimeSpan> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] LWKJINFTMJF;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8D88A20", Offset = "0x8D87E20", VA = "0x188D88A20", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8D889A0", Offset = "0x8D87DA0", VA = "0x188D889A0", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8D885B0", Offset = "0x8D879B0", VA = "0x188D885B0")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public XPWKBLLQJTJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class QIIKBRJYWMO<a, b, c, d, e> : KJREGAAUAOM<e>, JPRKJTPCIAD where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5ACA750", Offset = "0x5AC9B50", VA = "0x185ACA750", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5AC6E80", Offset = "0x5AC6280", VA = "0x185AC6E80", Slot = "5")]
		public e Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d XUQUPGKBPPT(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		protected QIIKBRJYWMO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class QINQYYDWFXX<a, b, c, d> : QIIKBRJYWMO<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x4E95B10", Offset = "0x4E94F10", VA = "0x184E95B10", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> XUQUPGKBPPT(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		protected QINQYYDWFXX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class QISXWEXTPJG<a, b, c> : QINQYYDWFXX<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xB05110", Offset = "0xB04510", VA = "0x180B05110", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class ILPXGTQIRTU<a, b> : QIIKBRJYWMO<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5015E40", Offset = "0x5015240", VA = "0x185015E40", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xB05110", Offset = "0xB04510", VA = "0x180B05110", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5016120", Offset = "0x5015520", VA = "0x185016120", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x50162F0", Offset = "0x50156F0", VA = "0x1850162F0", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator XUQUPGKBPPT(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x5016350", Offset = "0x5015750", VA = "0x185016350")]
		public ILPXGTQIRTU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class ZKZROPRHGVY<a, b, c> : QISXWEXTPJG<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x3EB0B50", Offset = "0x3EAFF50", VA = "0x183EB0B50", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x3EB0D30", Offset = "0x3EB0130", VA = "0x183EB0D30", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class HYWFAXISSSX<a, b> : QINQYYDWFXX<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A790", Offset = "0x3E39B90", VA = "0x183E3A790", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3E39FF0", Offset = "0x3E393F0", VA = "0x183E39FF0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB05110", Offset = "0xB04510", VA = "0x180B05110", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class AXVHTWPYDIZ<a, b> : QISXWEXTPJG<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A790", Offset = "0x3E39B90", VA = "0x183E3A790", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3E39FF0", Offset = "0x3E393F0", VA = "0x183E39FF0", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class YPDOOFAUMQV<a, b> : QIIKBRJYWMO<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A790", Offset = "0x3E39B90", VA = "0x183E3A790", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB05110", Offset = "0xB04510", VA = "0x180B05110", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3E39FF0", Offset = "0x3E393F0", VA = "0x183E39FF0", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A8F0", Offset = "0x3E39CF0", VA = "0x183E3A8F0", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator XUQUPGKBPPT(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class ZJLRIFYEJLO<a, b> : QINQYYDWFXX<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E3A790", Offset = "0x3E39B90", VA = "0x183E3A790", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x3EB0510", Offset = "0x3EAF910", VA = "0x183EB0510", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x3EB0580", Offset = "0x3EAF980", VA = "0x183EB0580", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class KQMLEHVLFLL<a, b> : QINQYYDWFXX<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x5271260", Offset = "0x5270660", VA = "0x185271260", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xB05110", Offset = "0xB04510", VA = "0x180B05110", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x5271300", Offset = "0x5270700", VA = "0x185271300", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x50EB970", Offset = "0x50EAD70", VA = "0x1850EB970")]
		public KQMLEHVLFLL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class YKJDJYBKMMZ<a, b> : QISXWEXTPJG<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x3E39E90", Offset = "0x3E39290", VA = "0x183E39E90", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3E39FF0", Offset = "0x3E393F0", VA = "0x183E39FF0", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class MLEITRJUEGH<a> : KJREGAAUAOM<a>, JPRKJTPCIAD where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x57CE240", Offset = "0x57CD640", VA = "0x1857CE240", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x57CE000", Offset = "0x57CD400", VA = "0x1857CE000", Slot = "5")]
		public a Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public MLEITRJUEGH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class MBDNCYOJKGV : KJREGAAUAOM<IDictionary>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly KJREGAAUAOM<IDictionary> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D79EF0", Offset = "0x8D792F0", VA = "0x188D79EF0", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x8D79D10", Offset = "0x8D79110", VA = "0x188D79D10", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public MBDNCYOJKGV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class DXCZKHHXCPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8D757A0", Offset = "0x8D74BA0", VA = "0x188D757A0")]
		public static object OCPGFLHIEHV(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D74FE0", Offset = "0x8D743E0", VA = "0x188D74FE0")]
		public static object DGNIAHINWDU(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class RBAWNPSFDTS<a> : KJREGAAUAOM<a>, JPRKJTPCIAD, FZUZLTDZBCZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class OMQYCOONSBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type TWRGICASDPA;

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public OMQYCOONSBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x5984F60", Offset = "0x5984360", VA = "0x185984F60")]
			internal bool IAAPRAQJQNR(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class OMWEZVILBMT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string MZHQLDOCZYE;

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public OMWEZVILBMT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x59866C0", Offset = "0x5985AC0", VA = "0x1859866C0")]
			internal bool HZVITTWMHCI(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class ONBLXCCIKYC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> WOUWAKPFZLB;

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public ONBLXCCIKYC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x5986CE0", Offset = "0x59860E0", VA = "0x185986CE0")]
			internal void IALDLOEEJKJ(JsonWriter a, a b, MRQZQJMMYUF c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class ONGSUIWFUJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> RYKMBSFJFRM;

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public ONGSUIWFUJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x5987D10", Offset = "0x5987110", VA = "0x185987D10")]
			internal a IAFWOHKGZZA(JsonReader a, MRQZQJMMYUF b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly CGYLDVJQURF<a> CSPPYNZAPOA;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> RCHSUQHKIVM;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> FDHSDACAIHI;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> LMWYONJPXLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool HBDYGERUFHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> PIRDQQBHQVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> IREIJPZQLZS;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5B1BE50", Offset = "0x5B1B250", VA = "0x185B1BE50")]
		static RBAWNPSFDTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x5B1EF00", Offset = "0x5B1E300", VA = "0x185B1EF00")]
		public RBAWNPSFDTS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x5B13EE0", Offset = "0x5B132E0", VA = "0x185B13EE0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x5B12B20", Offset = "0x5B11F20", VA = "0x185B12B20", Slot = "5")]
		public a Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5B148D0", Offset = "0x5B13CD0", VA = "0x185B148D0", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, a b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5B13350", Offset = "0x5B12750", VA = "0x185B13350", Slot = "7")]
		public a HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class BMFNCPBQPMY<a> : KJREGAAUAOM<a[,]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F1A0", Offset = "0x6E6E5A0", VA = "0x186E6F1A0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6E6EE10", Offset = "0x6E6E210", VA = "0x186E6EE10", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public BMFNCPBQPMY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class ONJDKZLACQW<a> : KJREGAAUAOM<a[,,]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5988A40", Offset = "0x5987E40", VA = "0x185988A40", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x5988570", Offset = "0x5987970", VA = "0x185988570", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public ONJDKZLACQW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class XHPEUKJKQHY<a> : KJREGAAUAOM<a[,,,]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x3DA0660", Offset = "0x3D9FA60", VA = "0x183DA0660", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x3DA0060", Offset = "0x3D9F460", VA = "0x183DA0060", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public XHPEUKJKQHY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class GEJHDIFHDVS<a> : KJREGAAUAOM<a?>, JPRKJTPCIAD where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x4E8C120", Offset = "0x4E8B520", VA = "0x184E8C120", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x4E8BD10", Offset = "0x4E8B110", VA = "0x184E8BD10", Slot = "5")]
		public a? Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public GEJHDIFHDVS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class GZAYZURCWJQ<a> : KJREGAAUAOM<a?>, JPRKJTPCIAD where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly KJREGAAUAOM<a> RYXDFCSXXDD;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		public GZAYZURCWJQ(KJREGAAUAOM<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x4EADBF0", Offset = "0x4EACFF0", VA = "0x184EADBF0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x4EACA90", Offset = "0x4EABE90", VA = "0x184EACA90", Slot = "5")]
		public a? Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class QRPLCWVJVVL : KJREGAAUAOM<sbyte>, JPRKJTPCIAD, FZUZLTDZBCZ<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly QRPLCWVJVVL HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8D7F780", Offset = "0x8D7EB80", VA = "0x188D7F780", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D7F6F0", Offset = "0x8D7EAF0", VA = "0x188D7F6F0", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8D7F810", Offset = "0x8D7EC10", VA = "0x188D7F810", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, sbyte b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8D7F700", Offset = "0x8D7EB00", VA = "0x188D7F700", Slot = "7")]
		public sbyte HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public QRPLCWVJVVL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class ZIIZLJVDRHW : KJREGAAUAOM<sbyte?>, JPRKJTPCIAD, FZUZLTDZBCZ<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly ZIIZLJVDRHW HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8D8ADE0", Offset = "0x8D8A1E0", VA = "0x188D8ADE0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8D8ACA0", Offset = "0x8D8A0A0", VA = "0x188D8ACA0", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8D8AED0", Offset = "0x8D8A2D0", VA = "0x188D8AED0", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, sbyte? b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8D8AD10", Offset = "0x8D8A110", VA = "0x188D8AD10", Slot = "7")]
		public sbyte? HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public ZIIZLJVDRHW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class GPGERHSYTCM : KJREGAAUAOM<sbyte[]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly GPGERHSYTCM HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8D76C10", Offset = "0x8D76010", VA = "0x188D76C10", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8D76AD0", Offset = "0x8D75ED0", VA = "0x188D76AD0", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public GPGERHSYTCM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class SVYAOCATALI : KJREGAAUAOM<short>, JPRKJTPCIAD, FZUZLTDZBCZ<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly SVYAOCATALI HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8D80940", Offset = "0x8D7FD40", VA = "0x188D80940", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8D808B0", Offset = "0x8D7FCB0", VA = "0x188D808B0", Slot = "5")]
		public short Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8D809D0", Offset = "0x8D7FDD0", VA = "0x188D809D0", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, short b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D808C0", Offset = "0x8D7FCC0", VA = "0x188D808C0", Slot = "7")]
		public short HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public SVYAOCATALI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class WJCUVHDADEP : KJREGAAUAOM<short?>, JPRKJTPCIAD, FZUZLTDZBCZ<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly WJCUVHDADEP HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8D86C80", Offset = "0x8D86080", VA = "0x188D86C80", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8D86B40", Offset = "0x8D85F40", VA = "0x188D86B40", Slot = "5")]
		public short? Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8D86D70", Offset = "0x8D86170", VA = "0x188D86D70", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, short? b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8D86BB0", Offset = "0x8D85FB0", VA = "0x188D86BB0", Slot = "7")]
		public short? HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public WJCUVHDADEP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class NBSXIVUHRIZ : KJREGAAUAOM<short[]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly NBSXIVUHRIZ HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8D7BF90", Offset = "0x8D7B390", VA = "0x188D7BF90", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8D7BE50", Offset = "0x8D7B250", VA = "0x188D7BE50", Slot = "5")]
		public short[] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public NBSXIVUHRIZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class AOAVAQSJFAM : KJREGAAUAOM<int>, JPRKJTPCIAD, FZUZLTDZBCZ<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly AOAVAQSJFAM HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8D723F0", Offset = "0x8D717F0", VA = "0x188D723F0", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8D72360", Offset = "0x8D71760", VA = "0x188D72360", Slot = "5")]
		public int Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8D72480", Offset = "0x8D71880", VA = "0x188D72480", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, int b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8D72370", Offset = "0x8D71770", VA = "0x188D72370", Slot = "7")]
		public int HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public AOAVAQSJFAM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class YNPKCLSLLOZ : KJREGAAUAOM<int?>, JPRKJTPCIAD, FZUZLTDZBCZ<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly YNPKCLSLLOZ HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A1C0", Offset = "0x8D895C0", VA = "0x188D8A1C0", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A080", Offset = "0x8D89480", VA = "0x188D8A080", Slot = "5")]
		public int? Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A2B0", Offset = "0x8D896B0", VA = "0x188D8A2B0", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, int? b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A0F0", Offset = "0x8D894F0", VA = "0x188D8A0F0", Slot = "7")]
		public int? HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public YNPKCLSLLOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class RFCEWIGBXFF : KJREGAAUAOM<int[]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly RFCEWIGBXFF HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8D7FAD0", Offset = "0x8D7EED0", VA = "0x188D7FAD0", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8D7F990", Offset = "0x8D7ED90", VA = "0x188D7F990", Slot = "5")]
		public int[] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public RFCEWIGBXFF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class ZITUYJNNSEZ : KJREGAAUAOM<long>, JPRKJTPCIAD, FZUZLTDZBCZ<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly ZITUYJNNSEZ HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B0F0", Offset = "0x8D8A4F0", VA = "0x188D8B0F0", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B0A0", Offset = "0x8D8A4A0", VA = "0x188D8B0A0", Slot = "5")]
		public long Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B150", Offset = "0x8D8A550", VA = "0x188D8B150", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, long b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B0B0", Offset = "0x8D8A4B0", VA = "0x188D8B0B0", Slot = "7")]
		public long HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public ZITUYJNNSEZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class XDUNUGABHIQ : KJREGAAUAOM<long?>, JPRKJTPCIAD, FZUZLTDZBCZ<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly XDUNUGABHIQ HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x8D87DB0", Offset = "0x8D871B0", VA = "0x188D87DB0", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8D87C70", Offset = "0x8D87070", VA = "0x188D87C70", Slot = "5")]
		public long? Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8D87E70", Offset = "0x8D87270", VA = "0x188D87E70", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, long? b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8D87D00", Offset = "0x8D87100", VA = "0x188D87D00", Slot = "7")]
		public long? HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public XDUNUGABHIQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class WQJGGXIMXQY : KJREGAAUAOM<long[]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly WQJGGXIMXQY HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8D87550", Offset = "0x8D86950", VA = "0x188D87550", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8D87410", Offset = "0x8D86810", VA = "0x188D87410", Slot = "5")]
		public long[] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public WQJGGXIMXQY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class JAWNMVQPCAO : KJREGAAUAOM<byte>, JPRKJTPCIAD, FZUZLTDZBCZ<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly JAWNMVQPCAO HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8D78B30", Offset = "0x8D77F30", VA = "0x188D78B30", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8D78AA0", Offset = "0x8D77EA0", VA = "0x188D78AA0", Slot = "5")]
		public byte Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8D78BC0", Offset = "0x8D77FC0", VA = "0x188D78BC0", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, byte b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x8D78AB0", Offset = "0x8D77EB0", VA = "0x188D78AB0", Slot = "7")]
		public byte HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public JAWNMVQPCAO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class SCYQWWWFCEF : KJREGAAUAOM<byte?>, JPRKJTPCIAD, FZUZLTDZBCZ<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly SCYQWWWFCEF HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8D80060", Offset = "0x8D7F460", VA = "0x188D80060", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8D7FF20", Offset = "0x8D7F320", VA = "0x188D7FF20", Slot = "5")]
		public byte? Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8D80150", Offset = "0x8D7F550", VA = "0x188D80150", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, byte? b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x8D7FF90", Offset = "0x8D7F390", VA = "0x188D7FF90", Slot = "7")]
		public byte? HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public SCYQWWWFCEF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class ZIEMEDYSJNT : KJREGAAUAOM<ushort>, JPRKJTPCIAD, FZUZLTDZBCZ<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly ZIEMEDYSJNT HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x8D8AA90", Offset = "0x8D89E90", VA = "0x188D8AA90", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x8D8AA00", Offset = "0x8D89E00", VA = "0x188D8AA00", Slot = "5")]
		public ushort Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x8D8AB20", Offset = "0x8D89F20", VA = "0x188D8AB20", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, ushort b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x8D8AA10", Offset = "0x8D89E10", VA = "0x188D8AA10", Slot = "7")]
		public ushort HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public ZIEMEDYSJNT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class BQAFLJJLPIO : KJREGAAUAOM<ushort?>, JPRKJTPCIAD, FZUZLTDZBCZ<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly BQAFLJJLPIO HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x8D74070", Offset = "0x8D73470", VA = "0x188D74070", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x8D73F30", Offset = "0x8D73330", VA = "0x188D73F30", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x8D74160", Offset = "0x8D73560", VA = "0x188D74160", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, ushort? b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x8D73FA0", Offset = "0x8D733A0", VA = "0x188D73FA0", Slot = "7")]
		public ushort? HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public BQAFLJJLPIO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class YSXONJNDYGI : KJREGAAUAOM<ushort[]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly YSXONJNDYGI HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A5C0", Offset = "0x8D899C0", VA = "0x188D8A5C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A480", Offset = "0x8D89880", VA = "0x188D8A480", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public YSXONJNDYGI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class SWAYAWTLIVZ : KJREGAAUAOM<uint>, JPRKJTPCIAD, FZUZLTDZBCZ<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly SWAYAWTLIVZ HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8D80BE0", Offset = "0x8D7FFE0", VA = "0x188D80BE0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8D80B50", Offset = "0x8D7FF50", VA = "0x188D80B50", Slot = "5")]
		public uint Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8D80C70", Offset = "0x8D80070", VA = "0x188D80C70", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, uint b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8D80B60", Offset = "0x8D7FF60", VA = "0x188D80B60", Slot = "7")]
		public uint HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public SWAYAWTLIVZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class HHHVAYVGFLS : KJREGAAUAOM<uint?>, JPRKJTPCIAD, FZUZLTDZBCZ<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly HHHVAYVGFLS HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8D76FF0", Offset = "0x8D763F0", VA = "0x188D76FF0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8D76EB0", Offset = "0x8D762B0", VA = "0x188D76EB0", Slot = "5")]
		public uint? Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x8D770E0", Offset = "0x8D764E0", VA = "0x188D770E0", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, uint? b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x8D76F20", Offset = "0x8D76320", VA = "0x188D76F20", Slot = "7")]
		public uint? HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public HHHVAYVGFLS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class TRWXHLYOHQO : KJREGAAUAOM<uint[]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly TRWXHLYOHQO HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x8D814D0", Offset = "0x8D808D0", VA = "0x188D814D0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8D81390", Offset = "0x8D80790", VA = "0x188D81390", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public TRWXHLYOHQO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class ODYWHFLJENY : KJREGAAUAOM<ulong>, JPRKJTPCIAD, FZUZLTDZBCZ<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly ODYWHFLJENY HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8D7DFA0", Offset = "0x8D7D3A0", VA = "0x188D7DFA0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8D7DF50", Offset = "0x8D7D350", VA = "0x188D7DF50", Slot = "5")]
		public ulong Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E000", Offset = "0x8D7D400", VA = "0x188D7E000", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, ulong b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8D7DF60", Offset = "0x8D7D360", VA = "0x188D7DF60", Slot = "7")]
		public ulong HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public ODYWHFLJENY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class DAZWXFRKZFX : KJREGAAUAOM<ulong?>, JPRKJTPCIAD, FZUZLTDZBCZ<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly DAZWXFRKZFX HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8D74D80", Offset = "0x8D74180", VA = "0x188D74D80", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x8D74C40", Offset = "0x8D74040", VA = "0x188D74C40", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8D74E40", Offset = "0x8D74240", VA = "0x188D74E40", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, ulong? b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8D74CD0", Offset = "0x8D740D0", VA = "0x188D74CD0", Slot = "7")]
		public ulong? HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public DAZWXFRKZFX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class XKJDVUSTYHD : KJREGAAUAOM<ulong[]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly XKJDVUSTYHD HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8D88380", Offset = "0x8D87780", VA = "0x188D88380", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x8D88240", Offset = "0x8D87640", VA = "0x188D88240", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public XKJDVUSTYHD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class OHADSLVAVDK : KJREGAAUAOM<float>, JPRKJTPCIAD, FZUZLTDZBCZ<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly OHADSLVAVDK HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E190", Offset = "0x8D7D590", VA = "0x188D7E190", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E140", Offset = "0x8D7D540", VA = "0x188D7E140", Slot = "5")]
		public float Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E1F0", Offset = "0x8D7D5F0", VA = "0x188D7E1F0", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, float b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E150", Offset = "0x8D7D550", VA = "0x188D7E150", Slot = "7")]
		public float HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public OHADSLVAVDK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class EXAKMQZNJBF : KJREGAAUAOM<float?>, JPRKJTPCIAD, FZUZLTDZBCZ<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly EXAKMQZNJBF HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x8D76880", Offset = "0x8D75C80", VA = "0x188D76880", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8D76770", Offset = "0x8D75B70", VA = "0x188D76770", Slot = "5")]
		public float? Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x8D76940", Offset = "0x8D75D40", VA = "0x188D76940", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, float? b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8D767E0", Offset = "0x8D75BE0", VA = "0x188D767E0", Slot = "7")]
		public float? HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public EXAKMQZNJBF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class CIBGGOWEEDZ : KJREGAAUAOM<float[]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly CIBGGOWEEDZ HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8D748A0", Offset = "0x8D73CA0", VA = "0x188D748A0", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8D74760", Offset = "0x8D73B60", VA = "0x188D74760", Slot = "5")]
		public float[] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public CIBGGOWEEDZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class NRGFNGGHOJJ : KJREGAAUAOM<double>, JPRKJTPCIAD, FZUZLTDZBCZ<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly NRGFNGGHOJJ HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C280", Offset = "0x8D7B680", VA = "0x188D7C280", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C230", Offset = "0x8D7B630", VA = "0x188D7C230", Slot = "5")]
		public double Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C2E0", Offset = "0x8D7B6E0", VA = "0x188D7C2E0", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, double b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C240", Offset = "0x8D7B640", VA = "0x188D7C240", Slot = "7")]
		public double HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public NRGFNGGHOJJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class IHNTRXGKJVO : KJREGAAUAOM<double?>, JPRKJTPCIAD, FZUZLTDZBCZ<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly IHNTRXGKJVO HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8D78650", Offset = "0x8D77A50", VA = "0x188D78650", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8D78510", Offset = "0x8D77910", VA = "0x188D78510", Slot = "5")]
		public double? Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8D78710", Offset = "0x8D77B10", VA = "0x188D78710", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, double? b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8D785A0", Offset = "0x8D779A0", VA = "0x188D785A0", Slot = "7")]
		public double? HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public IHNTRXGKJVO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class JORSKNUUHLA : KJREGAAUAOM<double[]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly JORSKNUUHLA HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8D78E80", Offset = "0x8D78280", VA = "0x188D78E80", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8D78D40", Offset = "0x8D78140", VA = "0x188D78D40", Slot = "5")]
		public double[] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public JORSKNUUHLA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class WVAKYDRAFMA : KJREGAAUAOM<bool>, JPRKJTPCIAD, FZUZLTDZBCZ<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly WVAKYDRAFMA HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x8D87AD0", Offset = "0x8D86ED0", VA = "0x188D87AD0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8D87A80", Offset = "0x8D86E80", VA = "0x188D87A80", Slot = "5")]
		public bool Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8D87B30", Offset = "0x8D86F30", VA = "0x188D87B30", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, bool b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8D87A90", Offset = "0x8D86E90", VA = "0x188D87A90", Slot = "7")]
		public bool HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public WVAKYDRAFMA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class UPPPAGJVRQB : KJREGAAUAOM<bool?>, JPRKJTPCIAD, FZUZLTDZBCZ<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly UPPPAGJVRQB HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x8D848C0", Offset = "0x8D83CC0", VA = "0x188D848C0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8D847B0", Offset = "0x8D83BB0", VA = "0x188D847B0", Slot = "5")]
		public bool? Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8D84980", Offset = "0x8D83D80", VA = "0x188D84980", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, bool? b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x8D84820", Offset = "0x8D83C20", VA = "0x188D84820", Slot = "7")]
		public bool? HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public UPPPAGJVRQB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class WOVYKLKIHZR : KJREGAAUAOM<bool[]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly WOVYKLKIHZR HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x8D87080", Offset = "0x8D86480", VA = "0x188D87080", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x8D86F40", Offset = "0x8D86340", VA = "0x188D86F40", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public WOVYKLKIHZR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class HJOCKFCWLTL : KJREGAAUAOM<byte[]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly KJREGAAUAOM<byte[]> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x8D77320", Offset = "0x8D76720", VA = "0x188D77320", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x8D772B0", Offset = "0x8D766B0", VA = "0x188D772B0", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public HJOCKFCWLTL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class OHUKPRJLZIE : KJREGAAUAOM<ArraySegment<byte>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly KJREGAAUAOM<ArraySegment<byte>> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E400", Offset = "0x8D7D800", VA = "0x188D7E400", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x8D7E330", Offset = "0x8D7D730", VA = "0x188D7E330", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public OHUKPRJLZIE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class ICDCAEVRRZG : KJREGAAUAOM<string>, JPRKJTPCIAD, FZUZLTDZBCZ<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly KJREGAAUAOM<string> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8D783E0", Offset = "0x8D777E0", VA = "0x188D783E0", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8D783D0", Offset = "0x8D777D0", VA = "0x188D783D0", Slot = "5")]
		public string Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8D78440", Offset = "0x8D77840", VA = "0x188D78440", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, string b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8D783D0", Offset = "0x8D777D0", VA = "0x188D783D0", Slot = "7")]
		public string HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public ICDCAEVRRZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class ANNLARVSDRB : KJREGAAUAOM<string[]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly ANNLARVSDRB HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8D72130", Offset = "0x8D71530", VA = "0x188D72130", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x8D71FE0", Offset = "0x8D713E0", VA = "0x188D71FE0", Slot = "5")]
		public string[] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public ANNLARVSDRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class VICHDFGTYQY : KJREGAAUAOM<char>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly VICHDFGTYQY HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8D84B40", Offset = "0x8D83F40", VA = "0x188D84B40", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8D84B10", Offset = "0x8D83F10", VA = "0x188D84B10", Slot = "5")]
		public char Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public VICHDFGTYQY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class XHXDIYEZZHJ : KJREGAAUAOM<char?>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly XHXDIYEZZHJ HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8D880D0", Offset = "0x8D874D0", VA = "0x188D880D0", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x8D88010", Offset = "0x8D87410", VA = "0x188D88010", Slot = "5")]
		public char? Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public XHXDIYEZZHJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class LFWGLHKGCHF : KJREGAAUAOM<char[]>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly LFWGLHKGCHF HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D79750", Offset = "0x8D78B50", VA = "0x188D79750", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8D795C0", Offset = "0x8D789C0", VA = "0x188D795C0", Slot = "5")]
		public char[] Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public LFWGLHKGCHF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class CBIHFSBPMIH : KJREGAAUAOM<Guid>, JPRKJTPCIAD, FZUZLTDZBCZ<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly KJREGAAUAOM<Guid> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8D74400", Offset = "0x8D73800", VA = "0x188D74400", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D74330", Offset = "0x8D73730", VA = "0x188D74330", Slot = "5")]
		public Guid Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8D74570", Offset = "0x8D73970", VA = "0x188D74570", Slot = "6")]
		public void ULPRQKFEGCD(JsonWriter a, Guid b, MRQZQJMMYUF c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8D74390", Offset = "0x8D73790", VA = "0x188D74390", Slot = "7")]
		public Guid HBBRSZNLRGH(JsonReader a, MRQZQJMMYUF b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public CBIHFSBPMIH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class MOBMVALQZAN : KJREGAAUAOM<decimal>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly KJREGAAUAOM<decimal> HGWXKXVBWLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool PJUVCGWPJCZ;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x7176670", Offset = "0x7175A70", VA = "0x187176670")]
		public MOBMVALQZAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xD8EFB0", Offset = "0xD8E3B0", VA = "0x180D8EFB0")]
		public MOBMVALQZAN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8D7BC00", Offset = "0x8D7B000", VA = "0x188D7BC00", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x8D7BA30", Offset = "0x8D7AE30", VA = "0x188D7BA30", Slot = "5")]
		public decimal Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class VOXVAKLHXPY : KJREGAAUAOM<Uri>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly KJREGAAUAOM<Uri> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8D84CE0", Offset = "0x8D840E0", VA = "0x188D84CE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8D84C60", Offset = "0x8D84060", VA = "0x188D84C60", Slot = "5")]
		public Uri Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public VOXVAKLHXPY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class RNLKLBIZPLW : KJREGAAUAOM<Version>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly KJREGAAUAOM<Version> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8D7FDF0", Offset = "0x8D7F1F0", VA = "0x188D7FDF0", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x8D7FD70", Offset = "0x8D7F170", VA = "0x188D7FD70", Slot = "5")]
		public Version Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public RNLKLBIZPLW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class PGHTORVYUGK<a, b> : KJREGAAUAOM<KeyValuePair<a, b>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5A45500", Offset = "0x5A44900", VA = "0x185A45500", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5A45040", Offset = "0x5A44440", VA = "0x185A45040", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class KMTHJDUNECA : KJREGAAUAOM<StringBuilder>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly KJREGAAUAOM<StringBuilder> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8D79280", Offset = "0x8D78680", VA = "0x188D79280", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8D79200", Offset = "0x8D78600", VA = "0x188D79200", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public KMTHJDUNECA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class LWSLEDCDYWE : KJREGAAUAOM<BitArray>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly KJREGAAUAOM<BitArray> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8D79B20", Offset = "0x8D78F20", VA = "0x188D79B20", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8D79A00", Offset = "0x8D78E00", VA = "0x188D79A00", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public LWSLEDCDYWE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class WRPYTZLUIZK : KJREGAAUAOM<Type>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly WRPYTZLUIZK HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex EURWMBOCBHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool GWXTOZCTSMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool PFERMINNJKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool SITZRSQJAJR;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8D87A60", Offset = "0x8D86E60", VA = "0x188D87A60")]
		public WRPYTZLUIZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x80D2320", Offset = "0x80D1720", VA = "0x1880D2320")]
		public WRPYTZLUIZK(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8D87890", Offset = "0x8D86C90", VA = "0x188D87890", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x8D87780", Offset = "0x8D86B80", VA = "0x188D87780", Slot = "5")]
		public Type Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class QBNAOKEGAPC : KJREGAAUAOM<BigInteger>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly KJREGAAUAOM<BigInteger> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8D7EC70", Offset = "0x8D7E070", VA = "0x188D7EC70", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D7EBC0", Offset = "0x8D7DFC0", VA = "0x188D7EBC0", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public QBNAOKEGAPC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class KPPTGPXWMXW : KJREGAAUAOM<Complex>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly KJREGAAUAOM<Complex> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8D79420", Offset = "0x8D78820", VA = "0x188D79420", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8D79390", Offset = "0x8D78790", VA = "0x188D79390", Slot = "5")]
		public Complex Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public KPPTGPXWMXW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class MFSZVAIWCUG : KJREGAAUAOM<ExpandoObject>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly KJREGAAUAOM<ExpandoObject> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8D7B930", Offset = "0x8D7AD30", VA = "0x188D7B930", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D7B700", Offset = "0x8D7AB00", VA = "0x188D7B700", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public MFSZVAIWCUG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class ELKXLOWQLOZ<a> : KJREGAAUAOM<Lazy<a>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x474F060", Offset = "0x474E460", VA = "0x18474F060", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x474EEE0", Offset = "0x474E2E0", VA = "0x18474EEE0", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class IRRJOUZYMVL : KJREGAAUAOM<Task>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly KJREGAAUAOM<Task> HGWXKXVBWLR;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task QLCRYBFPVYC;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D78960", Offset = "0x8D77D60", VA = "0x188D78960", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8D788B0", Offset = "0x8D77CB0", VA = "0x188D788B0", Slot = "5")]
		public Task Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public IRRJOUZYMVL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class EIFAJEOJRIZ<a> : KJREGAAUAOM<Task<a>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x4747530", Offset = "0x4746930", VA = "0x184747530", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x47473C0", Offset = "0x47467C0", VA = "0x1847473C0", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class ZWOUUFNKPHN<a> : KJREGAAUAOM<ValueTask<a>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x3F1A180", Offset = "0x3F19580", VA = "0x183F1A180", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x3F19F60", Offset = "0x3F19360", VA = "0x183F19F60", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class LQQZNNYSKWB<a> : KJREGAAUAOM<Tuple<a>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x532E7A0", Offset = "0x532DBA0", VA = "0x18532E7A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x532E4E0", Offset = "0x532D8E0", VA = "0x18532E4E0", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class LQBEVTRAIOA<a, b> : KJREGAAUAOM<Tuple<a, b>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x532D420", Offset = "0x532C820", VA = "0x18532D420", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x532D000", Offset = "0x532C400", VA = "0x18532D000", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class LQGLTAKXRZJ<a, b, c> : KJREGAAUAOM<Tuple<a, b, c>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x532DE80", Offset = "0x532D280", VA = "0x18532DE80", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x532D920", Offset = "0x532CD20", VA = "0x18532D920", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class LPQRBGDFPRI<a, b, c, d> : KJREGAAUAOM<Tuple<a, b, c, d>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x532B700", Offset = "0x532AB00", VA = "0x18532B700", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x532B050", Offset = "0x532A450", VA = "0x18532B050", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class LPVXYMXCZCR<a, b, c, d, e> : KJREGAAUAOM<Tuple<a, b, c, d, e>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x532C6D0", Offset = "0x532BAD0", VA = "0x18532C6D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x532BED0", Offset = "0x532B2D0", VA = "0x18532BED0", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class LPGDGSPKWUQ<a, b, c, d, e, f> : KJREGAAUAOM<Tuple<a, b, c, d, e, f>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5328EA0", Offset = "0x53282A0", VA = "0x185328EA0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5328520", Offset = "0x5327920", VA = "0x185328520", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class LPLKDZJIGFZ<a, b, c, d, e, f, g> : KJREGAAUAOM<Tuple<a, b, c, d, e, f, g>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x532A450", Offset = "0x5329850", VA = "0x18532A450", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x5329940", Offset = "0x5328D40", VA = "0x185329940", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class LSBVUJHZYXM<a, b, c, d, e, f, g, h> : KJREGAAUAOM<Tuple<a, b, c, d, e, f, g, h>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x5331270", Offset = "0x5330670", VA = "0x185331270", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x5330600", Offset = "0x532FA00", VA = "0x185330600", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class JPFMIPZJINS<a> : KJREGAAUAOM<ValueTuple<a>>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x50F1DA0", Offset = "0x50F11A0", VA = "0x1850F1DA0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x50F1990", Offset = "0x50F0D90", VA = "0x1850F1990", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class JPVHAKHBKVT<a, b> : KJREGAAUAOM<(a, b)>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x50F3CE0", Offset = "0x50F30E0", VA = "0x1850F3CE0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x50F3800", Offset = "0x50F2C00", VA = "0x1850F3800", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class JPQADDNEBKK<a, b, c> : KJREGAAUAOM<(a, b, c)>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x50F2F20", Offset = "0x50F2320", VA = "0x1850F2F20", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x50F28B0", Offset = "0x50F1CB0", VA = "0x1850F28B0", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class JOPRQVRRGFR<a, b, c, d> : KJREGAAUAOM<(a, b, c, d)>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x50EDD70", Offset = "0x50ED170", VA = "0x1850EDD70", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x50ED540", Offset = "0x50EC940", VA = "0x1850ED540", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class JOKKTOXTWUI<a, b, c, d, e> : KJREGAAUAOM<(a, b, c, d, e)>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x50EC6B0", Offset = "0x50EBAB0", VA = "0x1850EC6B0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x50EBD00", Offset = "0x50EB100", VA = "0x1850EBD00", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class JPAFLJFLZCJ<a, b, c, d, e, f> : KJREGAAUAOM<(a, b, c, d, e, f)>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x50F0CA0", Offset = "0x50F00A0", VA = "0x1850F0CA0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x50F00E0", Offset = "0x50EF4E0", VA = "0x1850F00E0", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class JOUYOCLOPRA<a, b, c, d, e, f, g> : KJREGAAUAOM<(a, b, c, d, e, f, g)>, JPRKJTPCIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x50EF360", Offset = "0x50EE760", VA = "0x1850EF360", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x50EE600", Offset = "0x50EDA00", VA = "0x1850EE600", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class JRAWJYWLPLV<a, b, c, d, e, f, g, h> : KJREGAAUAOM<ValueTuple<a, b, c, d, e, f, g, h>>, JPRKJTPCIAD where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] GLNMPLOHUWM;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly DXUDCNSNQSU OQCPRFCBICK;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x5123B30", Offset = "0x5122F30", VA = "0x185123B30", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, MRQZQJMMYUF formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x5122C10", Offset = "0x5122010", VA = "0x185122C10", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, MRQZQJMMYUF formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class WGILCVWUVYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] DMNUOBWIJRC;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly DXUDCNSNQSU WRPLOAZIVCB;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8D84ED0", Offset = "0x8D842D0", VA = "0x188D84ED0")]
		static WGILCVWUVYY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class ZBQNLUFNJAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] ZLHBJVTNLWF;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly DXUDCNSNQSU GJLAPSFIDTO;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A860", Offset = "0x8D89C60", VA = "0x188D8A860")]
		static ZBQNLUFNJAG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class HJPBLANOZJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] GSPHKCUCTMU;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly DXUDCNSNQSU VSSJLOJZYBD;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] GTFCBXBUVUV;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly DXUDCNSNQSU VSCOTUCHVTC;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] GSZVEQHXMJM;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly DXUDCNSNQSU VSHVRAWFFEL;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] GTPPWKPPORN;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly DXUDCNSNQSU VRSAZGONCWK;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] GTKIZDVSFGE;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly DXUDCNSNQSU VRXHWNIKMHT;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] GUADQYDKHOF;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly DXUDCNSNQSU VRHNETASJZS;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] GTUWTRJMYCW;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly DXUDCNSNQSU VRMUBZUPTLB;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] GRELDHKVFLJ;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly DXUDCNSNQSU VUDFSJTHMCO;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x8D77450", Offset = "0x8D76850", VA = "0x188D77450")]
		static HJPBLANOZJI()
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
