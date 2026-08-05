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
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, OITOBEOPOJQ resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, OITOBEOPOJQ resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface GCGOPXTOFSI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface NIBWNXHPRYX<a> : GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, OITOBEOPOJQ formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JOKLBKLJATY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SGRPUHLOOZQ(JsonWriter a, a b, OITOBEOPOJQ c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a EZVABOESJGC(JsonReader a, OITOBEOPOJQ b);
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
	public static class SOBJSNKEDVD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3FEA600", Offset = "0x3FE9200", VA = "0x183FEA600")]
		public static string ToJsonString<T>(this NIBWNXHPRYX<T> formatter, T value, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NIBWNXHPRYX<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class QMBOKDMYOBV
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3F0ABD0", Offset = "0x3F097D0", VA = "0x183F0ABD0")]
		public static NIBWNXHPRYX<a> RTYCCMNIXQC<a>(this OITOBEOPOJQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x95B6A40", Offset = "0x95B5640", VA = "0x1895B6A40")]
		public static object XRIZXWUMHYE(this OITOBEOPOJQ a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x95ADD90", Offset = "0x95AC990", VA = "0x1895ADD90")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class SWUGHLXFHTQ
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] AUVCZBQTAXH;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] VJLVSAYBYZW;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] AQNEQIQOHCR;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] LBYCMWPHACM;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] RPQDNVOYQWT;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] XCQCUQOQWPY;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] SIBVVXIEGMQ;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] KQQBTIECBQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class TQAFPBFKLDP : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x95B8F70", Offset = "0x95B7B70", VA = "0x1895B8F70")]
				public TQAFPBFKLDP(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x95B8E50", Offset = "0x95B7A50", VA = "0x1895B8E50")]
				public TQAFPBFKLDP LXGOPHQEQBX(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class ZVQHPLXQIHE
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] ECHOXEISYYL;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] QTMREIXINEU;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private TQAFPBFKLDP start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private TQAFPBFKLDP end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x95B8A20", Offset = "0x95B7620", VA = "0x1895B8A20")]
			public void LXGOPHQEQBX([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x95B88E0", Offset = "0x95B74E0", VA = "0x1895B88E0")]
			public void LXGOPHQEQBX(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x95B8B30", Offset = "0x95B7730", VA = "0x1895B8B30")]
			public ReadOnlySequence<byte> SBJHABZEWMC()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x95B8730", Offset = "0x95B7330", VA = "0x1895B8730")]
			private void CPOECSKWPEU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x95B8C60", Offset = "0x95B7860", VA = "0x1895B8C60")]
			private void SWXLJNPSXXC([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x95B3D60", Offset = "0x95B2960", VA = "0x1895B3D60")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x95B1200", Offset = "0x95AFE00", VA = "0x1895B1200")]
		private JsonParsingException EYPTJJDRKTC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x95B0B50", Offset = "0x95AF750", VA = "0x1895B0B50")]
		private JsonParsingException CUFZCOILIAP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x95B3A70", Offset = "0x95B2670", VA = "0x1895B3A70")]
		public void URLVYXVJMHE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x95B37B0", Offset = "0x95B23B0", VA = "0x1895B37B0")]
		public JsonToken UCCSUUNAPIT()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x95B1740", Offset = "0x95B0340", VA = "0x1895B1740")]
		public void FHPUWYGOYKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x95B1BC0", Offset = "0x95B07C0", VA = "0x1895B1BC0")]
		private bool GTIUOESCSGR(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x95B1B60", Offset = "0x95B0760", VA = "0x1895B1B60")]
		private bool GTIUOESCSGR(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x95B0F50", Offset = "0x95AFB50", VA = "0x1895B0F50")]
		private void DWPMQKNOPLW(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x95B2500", Offset = "0x95B1100", VA = "0x1895B2500")]
		public bool OHXFCUGISZS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x95B1C20", Offset = "0x95B0820", VA = "0x1895B1C20")]
		public void HBRKFSJXSDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x95B1CE0", Offset = "0x95B08E0", VA = "0x1895B1CE0")]
		public bool IUQMUVWZRHJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x95B37A0", Offset = "0x95B23A0", VA = "0x1895B37A0")]
		public void TOIJEMCBKRU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x95B2FB0", Offset = "0x95B1BB0", VA = "0x1895B2FB0")]
		public void RILTTSMBGIY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x95B21B0", Offset = "0x95B0DB0", VA = "0x1895B21B0")]
		public bool LULYOEAYRJT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x95B3CB0", Offset = "0x95B28B0", VA = "0x1895B3CB0")]
		public void ZFOMAEHFHNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x95B3CA0", Offset = "0x95B28A0", VA = "0x1895B3CA0")]
		public void YSCQQPVDBBW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x95B2FC0", Offset = "0x95B1BC0", VA = "0x1895B2FC0")]
		public bool RIQVAWGUZBC(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x95B3C00", Offset = "0x95B2800", VA = "0x1895B3C00")]
		public bool WUGAKOBJALQ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x95B2420", Offset = "0x95B1020", VA = "0x1895B2420")]
		public bool OBHCTGNYFVX(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x95B2820", Offset = "0x95B1420", VA = "0x1895B2820")]
		private ReadOnlySequence<byte> PQMHPXWGTFE()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x95B3240", Offset = "0x95B1E40", VA = "0x1895B3240")]
		private ReadOnlySequence<byte> TKMKFQZHCKJ()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x95B1970", Offset = "0x95B0570", VA = "0x1895B1970")]
		private void GIQVURVRAIN(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x95B1000", Offset = "0x95AFC00", VA = "0x1895B1000")]
		private void DXBGGCKCQSM(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x95B34B0", Offset = "0x95B20B0", VA = "0x1895B34B0")]
		private void TLJZVPQNOKD(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x95B25C0", Offset = "0x95B11C0", VA = "0x1895B25C0")]
		private void OPBMUAETTWC(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x95A8570", Offset = "0x95A7170", VA = "0x1895A8570")]
		private static int KKMTUUODNPT(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x95B3B30", Offset = "0x95B2730", VA = "0x1895B3B30")]
		public ReadOnlySequence<byte> WUENATYHTLJ()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x95B3050", Offset = "0x95B1C50", VA = "0x1895B3050")]
		public string SGYIHNXQSAQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x95B1700", Offset = "0x95B0300", VA = "0x1895B1700")]
		public string FBZNANTYLDR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x95B22A0", Offset = "0x95B0EA0", VA = "0x1895B22A0")]
		public ReadOnlySequence<byte> NPLREHBSJXL()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x95B26D0", Offset = "0x95B12D0", VA = "0x1895B26D0")]
		public ReadOnlySequence<byte> ORNBDKDEUPU()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x95B2E60", Offset = "0x95B1A60", VA = "0x1895B2E60")]
		public bool QYQBPFHFLVJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x95B30D0", Offset = "0x95B1CD0", VA = "0x1895B30D0")]
		private void TIJDBTUNBPF(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x95B3C90", Offset = "0x95B2890", VA = "0x1895B3C90")]
		public void XUPZGWBAUQJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x95B0C60", Offset = "0x95AF860", VA = "0x1895B0C60")]
		private void CXPLGGSMXCC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x95B2D00", Offset = "0x95B1900", VA = "0x1895B2D00")]
		public sbyte QKIVAXDGRAU()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x95B2DB0", Offset = "0x95B19B0", VA = "0x1895B2DB0")]
		public short QXWOXSHYTOZ()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x95B0EA0", Offset = "0x95AFAA0", VA = "0x1895B0EA0")]
		public int DWMDNPQUAAP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x95B3AC0", Offset = "0x95B26C0", VA = "0x1895B3AC0")]
		public long WAUFHHDLFYI()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x95B2370", Offset = "0x95B0F70", VA = "0x1895B2370")]
		public byte NRUWZNHPIIX()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x95B39C0", Offset = "0x95B25C0", VA = "0x1895B39C0")]
		public ushort UMUOIOFYOTM()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x95B1C30", Offset = "0x95B0830", VA = "0x1895B1C30")]
		public uint HMOWOOTYKVC()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x95B27B0", Offset = "0x95B13B0", VA = "0x1895B27B0")]
		public ulong PJBWJYIWQQT()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x95B3CC0", Offset = "0x95B28C0", VA = "0x1895B3CC0")]
		public float ZPPKOAOEUXT()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x95B2200", Offset = "0x95B0E00", VA = "0x1895B2200")]
		public double MCWONZLYVEM()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x95B1D30", Offset = "0x95B0930", VA = "0x1895B1D30")]
		public ReadOnlySequence<byte> JNLBBLRUFCZ()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x95B1F10", Offset = "0x95B0B10", VA = "0x1895B1F10")]
		private void LJRZVJYOERV()
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
			[Cpp2IlInjected.Address(RVA = "0xBD4170", Offset = "0xBD2D70", VA = "0x180BD4170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x95B0AF0", Offset = "0x95AF6F0", VA = "0x1895B0AF0")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x95B0A70", Offset = "0x95AF670", VA = "0x1895B0A70")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class UQGFAYNXBED
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class HMEXQITXNYI
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] ECHOXEISYYL;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x95AFB70", Offset = "0x95AE770", VA = "0x1895AFB70")]
			public static byte[] QJERGNPZXRP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static OITOBEOPOJQ ASJWCEMIIUM;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] IZQPSYAJTHB;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] LTPLPCMAFFF;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static OITOBEOPOJQ PKOVHJQVLIQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x95B9D70", Offset = "0x95B8970", VA = "0x1895B9D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x95B9D00", Offset = "0x95B8900", VA = "0x1895B9D00")]
		public static void GCXZUVOGPBA(OITOBEOPOJQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4145DC0", Offset = "0x41449C0", VA = "0x184145DC0")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4145C50", Offset = "0x4144850", VA = "0x184145C50")]
		public static byte[] Serialize<T>(T value, OITOBEOPOJQ resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4146620", Offset = "0x4145220", VA = "0x184146620")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x41464B0", Offset = "0x41450B0", VA = "0x1841464B0")]
		public static string ToJsonString<T>(T value, OITOBEOPOJQ resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4145760", Offset = "0x4144360", VA = "0x184145760")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x41453C0", Offset = "0x4143FC0", VA = "0x1841453C0")]
		public static T Deserialize<T>(string json, OITOBEOPOJQ resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4145540", Offset = "0x4144140", VA = "0x184145540")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4145610", Offset = "0x4144210", VA = "0x184145610")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, OITOBEOPOJQ resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x41451B0", Offset = "0x4143DB0", VA = "0x1841451B0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4144FE0", Offset = "0x4143BE0", VA = "0x184144FE0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, OITOBEOPOJQ resolver)
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
		public int ZVVORMWAVYZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xFD5810", Offset = "0xFD4410", VA = "0x180FD5810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x95B5030", Offset = "0x95B3C30", VA = "0x1895B5030")]
		public void URLVYXVJMHE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x95B4700", Offset = "0x95B3300", VA = "0x1895B4700")]
		public static byte[] DHJVUMOYEMB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x95B4EB0", Offset = "0x95B3AB0", VA = "0x1895B4EB0")]
		public static byte[] TWWXPSNJAKV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x95B5040", Offset = "0x95B3C40", VA = "0x1895B5040")]
		public static byte[] VCNOCGAWZFP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x95B4B50", Offset = "0x95B3750", VA = "0x1895B4B50")]
		public static byte[] OTQDYZXGMYP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C84B90", Offset = "0x7C83790", VA = "0x187C84B90")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x95B4D20", Offset = "0x95B3920", VA = "0x1895B4D20")]
		public ArraySegment<byte> QJERGNPZXRP()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x95B4530", Offset = "0x95B3130", VA = "0x1895B4530")]
		public byte[] CTFBBLXLHHA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x95B4FD0", Offset = "0x95B3BD0", VA = "0x1895B4FD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x95B49B0", Offset = "0x95B35B0", VA = "0x1895B49B0")]
		public void JRWAJWVLHBV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x95B4450", Offset = "0x95B3050", VA = "0x1895B4450")]
		public void CAYITKAVYVY(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x95B46C0", Offset = "0x95B32C0", VA = "0x1895B46C0")]
		public void DFEIJCJXTVO(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4481E90", Offset = "0x4480A90", VA = "0x184481E90")]
		public void MFGIYDDELIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4481D50", Offset = "0x4480950", VA = "0x184481D50")]
		public void CNETDPWWAFY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x95B4960", Offset = "0x95B3560", VA = "0x1895B4960")]
		public void JPPOUFUTDGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x95B4AD0", Offset = "0x95B36D0", VA = "0x1895B4AD0")]
		public void MWPLZQMDYGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4481E40", Offset = "0x4480A40", VA = "0x184481E40")]
		public void GLYSXZELCZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x58C7160", Offset = "0x58C5D60", VA = "0x1858C7160")]
		public void HGYQZEJSWKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x95B4A30", Offset = "0x95B3630", VA = "0x1895B4A30")]
		public void LMSANGPIBPE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x95B4CD0", Offset = "0x95B38D0", VA = "0x1895B4CD0")]
		public void OWQHNRYCTFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4481DA0", Offset = "0x44809A0", VA = "0x184481DA0")]
		public void GARDSBDZSNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7CA0", Offset = "0x7EE68A0", VA = "0x187EE7CA0")]
		public void UWELLBJIIUA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x95B44B0", Offset = "0x95B30B0", VA = "0x1895B44B0")]
		public void CPHGDTHFWCU(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x95B4DC0", Offset = "0x95B39C0", VA = "0x1895B4DC0")]
		public void QSLGAQKLIRP(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x95B51D0", Offset = "0x95B3DD0", VA = "0x1895B51D0")]
		public void WCCJJWNTXAC(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x95B48F0", Offset = "0x95B34F0", VA = "0x1895B48F0")]
		public void HIISEFFVIOH(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x95B5160", Offset = "0x95B3D60", VA = "0x1895B5160")]
		public void VEUSPJMLVMR(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x95B4B20", Offset = "0x95B3720", VA = "0x1895B4B20")]
		public void NGRPPXUISEG(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x95B49C0", Offset = "0x95B35C0", VA = "0x1895B49C0")]
		public void KFMGTRUBBPF(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x95B47E0", Offset = "0x95B33E0", VA = "0x1895B47E0")]
		public void DZUNVOOHAQW(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x95B4E40", Offset = "0x95B3A40", VA = "0x1895B4E40")]
		public void RUQLCQRSQCM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x95B5240", Offset = "0x95B3E40", VA = "0x1895B5240")]
		public void XAIYGKVOPOP(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x95B3ED0", Offset = "0x95B2AD0", VA = "0x1895B3ED0")]
		public void BBZLMTFLKZT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x95B4870", Offset = "0x95B3470", VA = "0x1895B4870")]
		private static bool GAECSPABEJP(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x95B4850", Offset = "0x95B3450", VA = "0x1895B4850")]
		private static byte EZROAGKTXOT(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x95A8630", Offset = "0x95A7230", VA = "0x1895A8630")]
		private static void LWICFLIXBGM(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class BMQCVHJGNTL : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x583BF10", Offset = "0x583AB10", VA = "0x18583BF10")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private BMQCVHJGNTL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class UGGYJLOETGC : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x582D4E0", Offset = "0x582C0E0", VA = "0x18582D4E0")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class VIKMLKFNWJG
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> LLRORJWMKNH;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x95BA0A0", Offset = "0x95B8CA0", VA = "0x1895BA0A0")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private UGGYJLOETGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class KVTGRPOVDRY : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x581EF50", Offset = "0x581DB50", VA = "0x18581EF50")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly KVTGRPOVDRY CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool EGMQKYTGBVM;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static GCGOPXTOFSI[] LEOJSJDZLPI;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static OITOBEOPOJQ[] BOTMUJJDGSM;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private KVTGRPOVDRY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x95B5D40", Offset = "0x95B4940", VA = "0x1895B5D40")]
		public static void Register(params OITOBEOPOJQ[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x95B5E20", Offset = "0x95B4A20", VA = "0x1895B5E20")]
		public static void Register(params GCGOPXTOFSI[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x95B5AC0", Offset = "0x95B46C0", VA = "0x1895B5AC0")]
		public static void FWAGDKLWWXO(GCGOPXTOFSI[] a, OITOBEOPOJQ[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class SXKNTNGPXTP : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x582F200", Offset = "0x582DE00", VA = "0x18582F200")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private SXKNTNGPXTP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class NGAGCXKRHLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly OITOBEOPOJQ ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly OITOBEOPOJQ WXALQTGVHAH;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class JJHTHJXVFHQ
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly OITOBEOPOJQ ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly OITOBEOPOJQ RDJDVBJGUQR;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly OITOBEOPOJQ YGGKSHEVRET;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly OITOBEOPOJQ BYCNSIYKGYA;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly OITOBEOPOJQ FWTRPNJHQRQ;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly OITOBEOPOJQ JMVHDDEGFVO;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly OITOBEOPOJQ VEICHZMVWYR;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly OITOBEOPOJQ KGFFKZQWTMB;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly OITOBEOPOJQ GYAYIFJPQRB;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly OITOBEOPOJQ HGHBCCIMZEY;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly OITOBEOPOJQ GBSLATPMPUC;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly OITOBEOPOJQ RWHNBDZYXGI;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class BUIPZJIGXZF
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> LLRORJWMKNH;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x95A9EC0", Offset = "0x95A8AC0", VA = "0x1895A9EC0")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x95ABB40", Offset = "0x95AA740", VA = "0x1895ABB40")]
		private static object JDJAIPWZQXM(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class JTKFWROOXOT : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x5839FE0", Offset = "0x5838BE0", VA = "0x185839FE0")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private JTKFWROOXOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class SZVRKYBLLWS : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x58251D0", Offset = "0x5823DD0", VA = "0x1858251D0")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private SZVRKYBLLWS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class TZKQDYXFGPQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly OITOBEOPOJQ[] GSVTOQKTUOX;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class XCOQNUEHXBD : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x5837500", Offset = "0x5836100", VA = "0x185837500")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class CHYYHUCNLPP : OITOBEOPOJQ
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class KJOXOVTUCLE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x5830140", Offset = "0x582ED40", VA = "0x185830140")]
				static KJOXOVTUCLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly OITOBEOPOJQ CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly OITOBEOPOJQ[] BOTMUJJDGSM;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private CHYYHUCNLPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
			public NIBWNXHPRYX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly NIBWNXHPRYX<object> ETMFRKJGXCH;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private XCOQNUEHXBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class YYTPFWINYLA : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x583F590", Offset = "0x583E190", VA = "0x18583F590")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class CHYYHUCNLPP : OITOBEOPOJQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class KJOXOVTUCLE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x58358A0", Offset = "0x58344A0", VA = "0x1858358A0")]
				static KJOXOVTUCLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly OITOBEOPOJQ CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly OITOBEOPOJQ[] BOTMUJJDGSM;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private CHYYHUCNLPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
			public NIBWNXHPRYX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly NIBWNXHPRYX<object> ETMFRKJGXCH;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private YYTPFWINYLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class NUHXMKYTXXC : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x581DC20", Offset = "0x581C820", VA = "0x18581DC20")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class CHYYHUCNLPP : OITOBEOPOJQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class KJOXOVTUCLE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x583CCF0", Offset = "0x583B8F0", VA = "0x18583CCF0")]
				static KJOXOVTUCLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly OITOBEOPOJQ CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly OITOBEOPOJQ[] BOTMUJJDGSM;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private CHYYHUCNLPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
			public NIBWNXHPRYX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly NIBWNXHPRYX<object> ETMFRKJGXCH;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private NUHXMKYTXXC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class XCYKYKHUCTF : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x583E6D0", Offset = "0x583D2D0", VA = "0x18583E6D0")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class CHYYHUCNLPP : OITOBEOPOJQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class KJOXOVTUCLE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x5836A60", Offset = "0x5835660", VA = "0x185836A60")]
				static KJOXOVTUCLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly OITOBEOPOJQ CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly OITOBEOPOJQ[] BOTMUJJDGSM;

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private CHYYHUCNLPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
			public NIBWNXHPRYX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly NIBWNXHPRYX<object> ETMFRKJGXCH;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private XCYKYKHUCTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class UEKKDMYOGKB : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x583C6F0", Offset = "0x583B2F0", VA = "0x18583C6F0")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class CHYYHUCNLPP : OITOBEOPOJQ
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class KJOXOVTUCLE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x5828B70", Offset = "0x5827770", VA = "0x185828B70")]
				static KJOXOVTUCLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly OITOBEOPOJQ CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly OITOBEOPOJQ[] BOTMUJJDGSM;

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private CHYYHUCNLPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
			public NIBWNXHPRYX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly NIBWNXHPRYX<object> ETMFRKJGXCH;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private UEKKDMYOGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class LAAULMIJUDZ : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x58353C0", Offset = "0x5833FC0", VA = "0x1858353C0")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class CHYYHUCNLPP : OITOBEOPOJQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class KJOXOVTUCLE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

				[Cpp2IlInjected.Token(Token = "0x60000DE")]
				[Cpp2IlInjected.Address(RVA = "0x583AEF0", Offset = "0x5839AF0", VA = "0x18583AEF0")]
				static KJOXOVTUCLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly OITOBEOPOJQ CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly OITOBEOPOJQ[] BOTMUJJDGSM;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private CHYYHUCNLPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
			public NIBWNXHPRYX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly NIBWNXHPRYX<object> ETMFRKJGXCH;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private LAAULMIJUDZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class SWRZKMMDDYS : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x581F490", Offset = "0x581E090", VA = "0x18581F490")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class CHYYHUCNLPP : OITOBEOPOJQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class KJOXOVTUCLE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x583C590", Offset = "0x583B190", VA = "0x18583C590")]
				static KJOXOVTUCLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly OITOBEOPOJQ CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly OITOBEOPOJQ[] BOTMUJJDGSM;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private CHYYHUCNLPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
			public NIBWNXHPRYX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly NIBWNXHPRYX<object> ETMFRKJGXCH;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private SWRZKMMDDYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class VFJDNPQQTLI : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x58234F0", Offset = "0x58220F0", VA = "0x1858234F0")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class CHYYHUCNLPP : OITOBEOPOJQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class KJOXOVTUCLE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x5821310", Offset = "0x581FF10", VA = "0x185821310")]
				static KJOXOVTUCLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly OITOBEOPOJQ CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly OITOBEOPOJQ[] BOTMUJJDGSM;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private CHYYHUCNLPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
			public NIBWNXHPRYX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly NIBWNXHPRYX<object> ETMFRKJGXCH;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private VFJDNPQQTLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class MSPYFFUYGBO : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x58305A0", Offset = "0x582F1A0", VA = "0x1858305A0")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class CHYYHUCNLPP : OITOBEOPOJQ
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class KJOXOVTUCLE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x5828410", Offset = "0x5827010", VA = "0x185828410")]
				static KJOXOVTUCLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly OITOBEOPOJQ CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly OITOBEOPOJQ[] BOTMUJJDGSM;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private CHYYHUCNLPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
			public NIBWNXHPRYX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly NIBWNXHPRYX<object> ETMFRKJGXCH;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private MSPYFFUYGBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class NOIEWCQTRFR : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x5836760", Offset = "0x5835360", VA = "0x185836760")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class CHYYHUCNLPP : OITOBEOPOJQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class KJOXOVTUCLE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x581D5E0", Offset = "0x581C1E0", VA = "0x18581D5E0")]
				static KJOXOVTUCLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly OITOBEOPOJQ CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly OITOBEOPOJQ[] BOTMUJJDGSM;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private CHYYHUCNLPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
			public NIBWNXHPRYX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly NIBWNXHPRYX<object> ETMFRKJGXCH;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private NOIEWCQTRFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class QHPEAUUKBJL : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x58276B0", Offset = "0x58262B0", VA = "0x1858276B0")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class CHYYHUCNLPP : OITOBEOPOJQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class KJOXOVTUCLE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x5831DD0", Offset = "0x58309D0", VA = "0x185831DD0")]
				static KJOXOVTUCLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly OITOBEOPOJQ CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly OITOBEOPOJQ[] BOTMUJJDGSM;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private CHYYHUCNLPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
			public NIBWNXHPRYX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly NIBWNXHPRYX<object> ETMFRKJGXCH;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private QHPEAUUKBJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class JJEZSBZFNRN : OITOBEOPOJQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class KJOXOVTUCLE<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x583B7B0", Offset = "0x583A3B0", VA = "0x18583B7B0")]
			static KJOXOVTUCLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class CHYYHUCNLPP : OITOBEOPOJQ
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class KJOXOVTUCLE<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly NIBWNXHPRYX<a> YIJSAMWNUNL;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x5825070", Offset = "0x5823C70", VA = "0x185825070")]
				static KJOXOVTUCLE()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly OITOBEOPOJQ CFGULCWBBYG;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly OITOBEOPOJQ[] BOTMUJJDGSM;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			private CHYYHUCNLPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
			public NIBWNXHPRYX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly OITOBEOPOJQ CFGULCWBBYG;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly NIBWNXHPRYX<object> ETMFRKJGXCH;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		private JJEZSBZFNRN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC120", VA = "0x1838FD520", Slot = "4")]
		public NIBWNXHPRYX<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x5ED3D20", Offset = "0x5ED2920", VA = "0x185ED3D20")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3A30", Offset = "0x5ED2630", VA = "0x185ED3A30")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3C90", Offset = "0x5ED2890", VA = "0x185ED3C90")]
		public T[] GNBJCPWCELL()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class AZNZPQLHIIH<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int PIPGSGNPFXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object QIQTMHYDWPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int DMPVJOPMYMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] PLGWKTIZRZS;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5C9E0C0", Offset = "0x5C9CCC0", VA = "0x185C9E0C0")]
		public AZNZPQLHIIH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5C9DE90", Offset = "0x5C9CA90", VA = "0x185C9DE90")]
		public a[] YNQJNTJSGXM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5C9DAD0", Offset = "0x5C9C6D0", VA = "0x185C9DAD0")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class JTROOOHVOOT : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class TVHDGMMTEGT : IComparable<TVHDGMMTEGT>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class PKMXMXEGKQD : IEnumerable<TVHDGMMTEGT>, IEnumerable, IEnumerator<TVHDGMMTEGT>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int JEOGOPMUBAR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private TVHDGMMTEGT DPUPDOXIACG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int RPOQDRFWNXK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public TVHDGMMTEGT VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int NAMOISTICOB;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private TVHDGMMTEGT DPDNZETDDDG
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object APIHCGBOWUL
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
				[DebuggerHidden]
				public PKMXMXEGKQD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
				[DebuggerHidden]
				private void YLGUCQLHQAY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x95B68E0", Offset = "0x95B54E0", VA = "0x1895B68E0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x95B6960", Offset = "0x95B5560", VA = "0x1895B6960", Slot = "10")]
				[DebuggerHidden]
				private void RALPBKOBMUN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x95B6840", Offset = "0x95B5440", VA = "0x1895B6840", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<TVHDGMMTEGT> KCUIZARYKXB()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x95B6840", Offset = "0x95B5440", VA = "0x1895B6840", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator ZFHLTDQPCLO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly TVHDGMMTEGT[] AYGLOTMESGX;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] CMFDNTSZSVQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong XHMXRIOSRQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int ZSNEVPBDVJU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string NOEGNVHAZCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TVHDGMMTEGT[] WBCOXYYTPOR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] PRHYBCJDBIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int OBEKLVUANDC;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x95B95A0", Offset = "0x95B81A0", VA = "0x1895B95A0")]
			public TVHDGMMTEGT(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x95B9040", Offset = "0x95B7C40", VA = "0x1895B9040")]
			public TVHDGMMTEGT Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x95B8FE0", Offset = "0x95B7BE0", VA = "0x1895B8FE0")]
			public TVHDGMMTEGT Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x95B9380", Offset = "0x95B7F80", VA = "0x1895B9380")]
			public TVHDGMMTEGT URFSFKEJCUZ(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x95B92F0", Offset = "0x95B7EF0", VA = "0x1895B92F0")]
			internal static int JXMRNYSCEAQ(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x95B9240", Offset = "0x95B7E40", VA = "0x1895B9240", Slot = "4")]
			public int CompareTo(TVHDGMMTEGT other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x95B9270", Offset = "0x95B7E70", VA = "0x1895B9270")]
			[IteratorStateMachine(typeof(PKMXMXEGKQD))]
			public IEnumerable<TVHDGMMTEGT> GWEDAOCZXSR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class KKRWQUAIOZL : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int RPOQDRFWNXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<TVHDGMMTEGT> WBCOXYYTPOR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<TVHDGMMTEGT> ABCSAXCJDEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<TVHDGMMTEGT> OKMXNYRHUZP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private TVHDGMMTEGT AJYGILQEZMQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> OKCJTLDNCCX;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> QZWMSERHTWO
			{
				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0xDF45B0", Offset = "0xDF31B0", VA = "0x180DF45B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x95B5340", Offset = "0x95B3F40", VA = "0x1895B5340", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x2C3E940", Offset = "0x2C3D540", VA = "0x182C3E940")]
			[DebuggerHidden]
			public KKRWQUAIOZL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x95B5970", Offset = "0x95B4570", VA = "0x1895B5970", Slot = "7")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x95B5390", Offset = "0x95B3F90", VA = "0x1895B5390", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x95B5840", Offset = "0x95B4440", VA = "0x1895B5840")]
			private void QCWGZBRZQOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x95B57F0", Offset = "0x95B43F0", VA = "0x1895B57F0")]
			private void QCRABUYCHCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x95B5890", Offset = "0x95B4490", VA = "0x1895B5890", Slot = "10")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x95B58D0", Offset = "0x95B44D0", VA = "0x1895B58D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> RENNTUCFIUR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x95B58D0", Offset = "0x95B44D0", VA = "0x1895B58D0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly TVHDGMMTEGT PPGZRRIGXVH;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x95B0A00", Offset = "0x95AF600", VA = "0x1895B0A00")]
		public JTROOOHVOOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x95B01B0", Offset = "0x95AEDB0", VA = "0x1895B01B0")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x95B03F0", Offset = "0x95AEFF0", VA = "0x1895B03F0")]
		public bool KCRQOJGIJUH(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x95B08F0", Offset = "0x95AF4F0", VA = "0x1895B08F0")]
		public bool WQAVVCEZLVI([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x95B0860", Offset = "0x95AF460", VA = "0x1895B0860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x95B0580", Offset = "0x95AF180", VA = "0x1895B0580")]
		private static void OUVEHKWKNRQ(IEnumerable<TVHDGMMTEGT> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x95B0390", Offset = "0x95AEF90", VA = "0x1895B0390", Slot = "5")]
		private IEnumerator ZFHLTDQPCLO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x95B0390", Offset = "0x95AEF90", VA = "0x1895B0390", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x95B0500", Offset = "0x95AF100", VA = "0x1895B0500")]
		[IteratorStateMachine(typeof(KKRWQUAIOZL))]
		private static IEnumerable<KeyValuePair<string, int>> ODCZLNWEABH(IEnumerable<TVHDGMMTEGT> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class SAKURFXJLHS
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo UYMKGIUPQCH;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x95B7A80", Offset = "0x95B6680", VA = "0x1895B7A80")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x95B7C30", Offset = "0x95B6830", VA = "0x1895B7C30")]
		public static ulong YFXKAAYUAKH(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class LJTOUWQZQAI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x95B6390", Offset = "0x95B4F90", VA = "0x1895B6390")]
		public static void JRWAJWVLHBV(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x95B6130", Offset = "0x95B4D30", VA = "0x1895B6130")]
		public static void AITIFYGOPGP(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x95B6250", Offset = "0x95B4E50", VA = "0x1895B6250")]
		public static byte[] JIMKPSXUDGU(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class EESRUOTGHZC<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x4D01650", Offset = "0x4D00250", VA = "0x184D01650", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class PKPHJHLIWDG : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public EESRUOTGHZC<a> VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] OKMXNYRHUZP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int OJXCWEJPSRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] OKCJTLDNCCX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int OLCSFSYZXHQ;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> MKYZJLGYJAV
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xDF45B0", Offset = "0xDF31B0", VA = "0x180DF45B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x5374CD0", Offset = "0x53738D0", VA = "0x185374CD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public PKPHJHLIWDG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x6180750", Offset = "0x617F350", VA = "0x186180750", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x4381FB0", Offset = "0x4380BB0", VA = "0x184381FB0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] IDAFKDTUHBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong RLBFQMELRJY;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool NNXSDPHBNZF;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4CB5410", Offset = "0x4CB4010", VA = "0x184CB5410")]
		public EESRUOTGHZC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4CB5320", Offset = "0x4CB3F20", VA = "0x184CB5320")]
		public EESRUOTGHZC(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4CAF0C0", Offset = "0x4CADCC0", VA = "0x184CAF0C0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x4CB1D00", Offset = "0x4CB0900", VA = "0x184CB1D00")]
		private bool MTDBFSIXXBK(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4CB0580", Offset = "0x4CAF180", VA = "0x184CB0580")]
		public bool KCRQOJGIJUH([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4CB48B0", Offset = "0x4CB34B0", VA = "0x184CB48B0")]
		private static ulong OQUKJAMLBZH([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4CB4710", Offset = "0x4CB3310", VA = "0x184CB4710")]
		private static ulong OQUKJAMLBZH([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4CAF610", Offset = "0x4CAE210", VA = "0x184CAF610")]
		private static int EWUQPRGMRQH(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4CAF640", Offset = "0x4CAE240", VA = "0x184CAF640", Slot = "4")]
		[IteratorStateMachine(typeof(EESRUOTGHZC<>.PKPHJHLIWDG))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4CB5110", Offset = "0x4CB3D10", VA = "0x184CB5110", Slot = "5")]
		private IEnumerator ZFHLTDQPCLO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class GMTQPEMJUBX
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3BC66F0", Offset = "0x3BC52F0", VA = "0x183BC66F0")]
		public static Func<a> DCLYYYCCDPN<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3BC67E0", Offset = "0x3BC53E0", VA = "0x183BC67E0")]
		private static c ULLOAQCQSSU<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0x95AE7E0", Offset = "0x95AD3E0", VA = "0x1895AE7E0")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x95AE7F0", Offset = "0x95AD3F0", VA = "0x1895AE7F0")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x95AE650", Offset = "0x95AD250", VA = "0x1895AE650")]
		private static byte XUSENQPOPLC(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x95A8460", Offset = "0x95A7060", VA = "0x1895A8460")]
		private static byte YNBQMLOULTO(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x95ADDF0", Offset = "0x95AC9F0", VA = "0x1895ADDF0")]
		public void XEFYRRLNBZG(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class RRFYGSZDBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x95B7230", Offset = "0x95B5E30", VA = "0x1895B7230")]
		public static bool QPVBKMCFMAI(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x95B7600", Offset = "0x95B6200", VA = "0x1895B7600")]
		public static bool TALKQXFECLP(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x95B71D0", Offset = "0x95B5DD0", VA = "0x1895B71D0")]
		public static sbyte QKIVAXDGRAU([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x95B7240", Offset = "0x95B5E40", VA = "0x1895B7240")]
		public static short QXWOXSHYTOZ([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x95B6C30", Offset = "0x95B5830", VA = "0x1895B6C30")]
		public static int DWMDNPQUAAP([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x95B7880", Offset = "0x95B6480", VA = "0x1895B7880")]
		public static long WAUFHHDLFYI([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x95B7470", Offset = "0x95B6070", VA = "0x1895B7470")]
		public static bool SNKMOIJYBYB(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x95B70C0", Offset = "0x95B5CC0", VA = "0x1895B70C0")]
		public static byte NRUWZNHPIIX([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x95B7670", Offset = "0x95B6270", VA = "0x1895B7670")]
		public static ushort UMUOIOFYOTM([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x95B6F70", Offset = "0x95B5B70", VA = "0x1895B6F70")]
		public static uint HMOWOOTYKVC([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x95B7120", Offset = "0x95B5D20", VA = "0x1895B7120")]
		public static ulong PJBWJYIWQQT([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x95B7730", Offset = "0x95B6330", VA = "0x1895B7730")]
		public static bool VZFMFDWPVYE(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x95B6DA0", Offset = "0x95B59A0", VA = "0x1895B6DA0")]
		public static bool HFCQLGQRHVU(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x95B6C90", Offset = "0x95B5890", VA = "0x1895B6C90")]
		public static bool GVJACKKMAHO(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x95B6B90", Offset = "0x95B5790", VA = "0x1895B6B90")]
		public static bool DMLSDFDRNWC(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x95B7990", Offset = "0x95B6590", VA = "0x1895B7990")]
		public static float ZPPKOAOEUXT([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x95B76D0", Offset = "0x95B62D0", VA = "0x1895B76D0")]
		public static bool VBBDYTWFIJM(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x95B6FD0", Offset = "0x95B5BD0", VA = "0x1895B6FD0")]
		public static double MCWONZLYVEM([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x95B7930", Offset = "0x95B6530", VA = "0x1895B7930")]
		public static bool YVUGCJGDDYH(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x95A86D0", Offset = "0x95A72D0", VA = "0x1895A86D0")]
		public static int NGRPPXUISEG(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x95A9030", Offset = "0x95A7C30", VA = "0x1895A9030")]
		public static int XAIYGKVOPOP(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x95B72A0", Offset = "0x95B5EA0", VA = "0x1895B72A0")]
		public static bool QYQBPFHFLVJ([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class LZHUMXOQEDA
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x95B64D0", Offset = "0x95B50D0", VA = "0x1895B64D0")]
		public static bool QYTLEYEBENS(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class LCAATRXFXTD
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding GNCZVMWAPFE;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class EZDIRQOOERH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x95ADBD0", Offset = "0x95AC7D0", VA = "0x1895ADBD0")]
		public static void XNUFRFYLYLM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x95ADC40", Offset = "0x95AC840", VA = "0x1895ADC40")]
		public static void XNZMOMSJHWV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x95ADAF0", Offset = "0x95AC6F0", VA = "0x1895ADAF0")]
		public static void XNJRWSKRFOU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x95ADB60", Offset = "0x95AC760", VA = "0x1895ADB60")]
		public static void XNOYTZEOPAD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x95ADCB0", Offset = "0x95AC8B0", VA = "0x1895ADCB0")]
		public static void XOPHGHABKEW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x95ADD20", Offset = "0x95AC920", VA = "0x1895ADD20")]
		public static void XOUODNTYTQF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x95ACFD0", Offset = "0x95ABBD0", VA = "0x1895ACFD0")]
		public static void CYQONYEJAEL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x95ACF60", Offset = "0x95ABB60", VA = "0x1895ACF60")]
		public static void CYLHQRKLQTC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x95AD0C0", Offset = "0x95ABCC0", VA = "0x1895AD0C0")]
		public static void CZBCILSDTBD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x95AD040", Offset = "0x95ABC40", VA = "0x1895AD040")]
		public static void CYVVLEYGJPU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x95AD1B0", Offset = "0x95ABDB0", VA = "0x1895AD1B0")]
		public static void CZLQCZFYLXV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x95AD130", Offset = "0x95ABD30", VA = "0x1895AD130")]
		public static void CZGJFSMBCMM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x95AD2B0", Offset = "0x95ABEB0", VA = "0x1895AD2B0")]
		public static void CZWDXMTTEUN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x95AD230", Offset = "0x95ABE30", VA = "0x1895AD230")]
		public static void CZQXAFZVVJE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x95ACEE0", Offset = "0x95ABAE0", VA = "0x1895ACEE0")]
		public static void CXALJWBECRR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x95ACE60", Offset = "0x95ABA60", VA = "0x1895ACE60")]
		public static void CWVEMPHGTGI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x95AD330", Offset = "0x95ABF30", VA = "0x1895AD330")]
		public static void HWQZRVGBFBK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x95AD3B0", Offset = "0x95ABFB0", VA = "0x1895AD3B0")]
		public static void HWWGPBZYOMT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x95AD430", Offset = "0x95AC030", VA = "0x1895AD430")]
		public static void HXBNMITVXYC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x95AD4B0", Offset = "0x95AC0B0", VA = "0x1895AD4B0")]
		public static void HXGUJPNTHJL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x95AD530", Offset = "0x95AC130", VA = "0x1895AD530")]
		public static void HXMBGWHQQUU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x95AD5B0", Offset = "0x95AC1B0", VA = "0x1895AD5B0")]
		public static void HXRIEDBOAGD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x95AD640", Offset = "0x95AC240", VA = "0x1895AD640")]
		public static void HXWPBJVLJRM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x95AD6D0", Offset = "0x95AC2D0", VA = "0x1895AD6D0")]
		public static void HYBVYQPITCV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x95AD760", Offset = "0x95AC360", VA = "0x1895AD760")]
		public static void HYHCVXJGCOE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x95AD7F0", Offset = "0x95AC3F0", VA = "0x1895AD7F0")]
		public static void HYMJTEDDLZN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x95AD910", Offset = "0x95AC510", VA = "0x1895AD910")]
		public static void OXIEQNODUTT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x95AD880", Offset = "0x95AC480", VA = "0x1895AD880")]
		public static void OXCXTGUGLIK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x95ADA80", Offset = "0x95AC680", VA = "0x1895ADA80")]
		public static void XNEKZLQTWDL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x95AD9A0", Offset = "0x95AC5A0", VA = "0x1895AD9A0")]
		public static void XMOQHRJBTVK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x95ADA10", Offset = "0x95AC610", VA = "0x1895ADA10")]
		public static void XMTXEYCZDGT(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class ZVAYRYNXCRY
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x95BCC90", Offset = "0x95BB890", VA = "0x1895BCC90")]
		public static void XOPHGHABKEW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x95BCD00", Offset = "0x95BB900", VA = "0x1895BCD00")]
		public static void XOUODNTYTQF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x95BC370", Offset = "0x95BAF70", VA = "0x1895BC370")]
		public static void CYQONYEJAEL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x95BC300", Offset = "0x95BAF00", VA = "0x1895BC300")]
		public static void CYLHQRKLQTC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x95BC450", Offset = "0x95BB050", VA = "0x1895BC450")]
		public static void CZBCILSDTBD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x95BC3E0", Offset = "0x95BAFE0", VA = "0x1895BC3E0")]
		public static void CYVVLEYGJPU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x95BC530", Offset = "0x95BB130", VA = "0x1895BC530")]
		public static void CZLQCZFYLXV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x95BC4C0", Offset = "0x95BB0C0", VA = "0x1895BC4C0")]
		public static void CZGJFSMBCMM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x95BC620", Offset = "0x95BB220", VA = "0x1895BC620")]
		public static void CZWDXMTTEUN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x95BC5A0", Offset = "0x95BB1A0", VA = "0x1895BC5A0")]
		public static void CZQXAFZVVJE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x95BC280", Offset = "0x95BAE80", VA = "0x1895BC280")]
		public static void CXALJWBECRR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x95BC200", Offset = "0x95BAE00", VA = "0x1895BC200")]
		public static void CWVEMPHGTGI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x95BC690", Offset = "0x95BB290", VA = "0x1895BC690")]
		public static void HWQZRVGBFBK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x95BC710", Offset = "0x95BB310", VA = "0x1895BC710")]
		public static void HWWGPBZYOMT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x95BC790", Offset = "0x95BB390", VA = "0x1895BC790")]
		public static void HXBNMITVXYC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x95BC810", Offset = "0x95BB410", VA = "0x1895BC810")]
		public static void HXGUJPNTHJL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x95BC890", Offset = "0x95BB490", VA = "0x1895BC890")]
		public static void HXMBGWHQQUU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x95BC910", Offset = "0x95BB510", VA = "0x1895BC910")]
		public static void HXRIEDBOAGD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x95BC990", Offset = "0x95BB590", VA = "0x1895BC990")]
		public static void HXWPBJVLJRM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x95BCA10", Offset = "0x95BB610", VA = "0x1895BCA10")]
		public static void HYBVYQPITCV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x95BCA90", Offset = "0x95BB690", VA = "0x1895BCA90")]
		public static void HYHCVXJGCOE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x95BCB10", Offset = "0x95BB710", VA = "0x1895BCB10")]
		public static void HYMJTEDDLZN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x95BCC10", Offset = "0x95BB810", VA = "0x1895BCC10")]
		public static void OXIEQNODUTT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x95BCB90", Offset = "0x95BB790", VA = "0x1895BCB90")]
		public static void OXCXTGUGLIK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x95ADA80", Offset = "0x95AC680", VA = "0x1895ADA80")]
		public static void XNEKZLQTWDL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x95AD9A0", Offset = "0x95AC5A0", VA = "0x1895AD9A0")]
		public static void XMOQHRJBTVK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x95ADA10", Offset = "0x95AC610", VA = "0x1895ADA10")]
		public static void XMTXEYCZDGT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x95ADBD0", Offset = "0x95AC7D0", VA = "0x1895ADBD0")]
		public static void XNUFRFYLYLM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x95ADC40", Offset = "0x95AC840", VA = "0x1895ADC40")]
		public static void XNZMOMSJHWV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x95ADAF0", Offset = "0x95AC6F0", VA = "0x1895ADAF0")]
		public static void XNJRWSKRFOU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x95ADB60", Offset = "0x95AC760", VA = "0x1895ADB60")]
		public static void XNOYTZEOPAD(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class RITTGCCFVVC
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool NNXSDPHBNZF;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x95CC5B0", Offset = "0x95CB1B0", VA = "0x1895CC5B0")]
		public static void CAYITKAVYVY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x95CE000", Offset = "0x95CCC00", VA = "0x1895CE000")]
		public static void JMLVKGACYRJ(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x2DBF770", Offset = "0x2DBE370", VA = "0x182DBF770")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x95BF1A0", Offset = "0x95BDDA0", VA = "0x1895BF1A0")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x95BF190", Offset = "0x95BDD90", VA = "0x1895BF190")]
		public static DiyFp OPGATWWEDOH(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x95BF100", Offset = "0x95BDD00", VA = "0x1895BF100")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x95BF060", Offset = "0x95BDC60", VA = "0x1895BF060")]
		public static DiyFp LQEWJZJLSLX(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x95BF020", Offset = "0x95BDC20", VA = "0x1895BF020")]
		public void HIQZHPHBIBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x95BEFD0", Offset = "0x95BDBD0", VA = "0x1895BEFD0")]
		public static DiyFp HIQZHPHBIBK(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xE01E80", Offset = "0xE00A80", VA = "0x180E01E80")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x95CF8F0", Offset = "0x95CE4F0", VA = "0x1895CF8F0")]
		public void UNGMLDVZPZN(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x95CF950", Offset = "0x95CE550", VA = "0x1895CF950")]
		public void VMNBBLVYLNX(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x95CF7D0", Offset = "0x95CE3D0", VA = "0x1895CF7D0")]
		public void THZCQXLWBAT(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x95CF850", Offset = "0x95CE450", VA = "0x1895CF850")]
		public void THZCQXLWBAT(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x95CF750", Offset = "0x95CE350", VA = "0x1895CF750")]
		public void QAFEVTQKJKZ(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x95CF650", Offset = "0x95CE250", VA = "0x1895CF650")]
		public void BOYCZYXFVBS(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class YSEBXPXNBCI
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
		private static byte[] UWYVLWWRYKB;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] POPVGNUURDH;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] TSBLRNLXEIP;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] NTCUXQWUQFG;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags AEUNAUIUQCF;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char AJOBOGOSJXF;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int JEZYYYTUHDD;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int TYDEFHNJXYT;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] HDZZSPUTAVT;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x95D6A50", Offset = "0x95D5650", VA = "0x1895D6A50")]
		private static byte[] XRPYAGOCHCH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x95D5130", Offset = "0x95D3D30", VA = "0x1895D5130")]
		private static byte[] ETTOXVUOULN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x95D5C60", Offset = "0x95D4860", VA = "0x1895D5C60")]
		public static int LXVIJLEMLMO(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x95D5D80", Offset = "0x95D4980", VA = "0x1895D5D80")]
		public static int LXVIJLEMLMO(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x95D64A0", Offset = "0x95D50A0", VA = "0x1895D64A0")]
		private static bool PVMHENAMFMW(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x95D5B70", Offset = "0x95D4770", VA = "0x1895D5B70")]
		private static void JFLOPUPRKRI(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x95D6590", Offset = "0x95D5190", VA = "0x1895D6590")]
		private static bool RBCXWNLZWNC(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x95D5210", Offset = "0x95D3E10", VA = "0x1895D5210")]
		private static bool FMMCVISSQRG(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x95D6950", Offset = "0x95D5550", VA = "0x1895D6950")]
		private static bool RGGOIGHFOAD(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x95D62D0", Offset = "0x95D4ED0", VA = "0x1895D62D0")]
		private static bool PTUBTCKBABO(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x95D5690", Offset = "0x95D4290", VA = "0x1895D5690")]
		private static bool INHKPYMRUIL(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x95D6B20", Offset = "0x95D5720", VA = "0x1895D6B20")]
		private static void XYJFUQRYAON(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x95D5EA0", Offset = "0x95D4AA0", VA = "0x1895D5EA0")]
		private static void NYBYTHYILUR(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x95D4F40", Offset = "0x95D3B40", VA = "0x1895D4F40")]
		private static bool BQOSMQIJTZG(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0x95BF7D0", Offset = "0x95BE3D0", VA = "0x1895BF7D0")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x95BF730", Offset = "0x95BE330", VA = "0x1895BF730")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x95BF1B0", Offset = "0x95BDDB0", VA = "0x1895BF1B0")]
		public DiyFp AXUIUBHSVQP()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x95BF310", Offset = "0x95BDF10", VA = "0x1895BF310")]
		public DiyFp IXVKFMZQNPK()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xBCBE40", Offset = "0xBCAA40", VA = "0x180BCBE40")]
		public ulong OOWUBUVWFUP()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x95BF220", Offset = "0x95BDE20", VA = "0x1895BF220")]
		public double EEGZGNLQODP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x95BF500", Offset = "0x95BE100", VA = "0x1895BF500")]
		public double SHSIBDIQXUB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x95BF4D0", Offset = "0x95BE0D0", VA = "0x1895BF4D0")]
		public int RYIVFEANMNM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x95BF4A0", Offset = "0x95BE0A0", VA = "0x1895BF4A0")]
		public ulong OPAHJVXDPJS()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x95BF2F0", Offset = "0x95BDEF0", VA = "0x1895BF2F0")]
		public bool HXNCYNXZSVP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x95BF2D0", Offset = "0x95BDED0", VA = "0x1895BF2D0")]
		public bool HKMIVKVOWQY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x95BF420", Offset = "0x95BE020", VA = "0x1895BF420")]
		public bool NHXIKMQKFQW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x95BF5A0", Offset = "0x95BE1A0", VA = "0x1895BF5A0")]
		public bool SOONLIRBBYB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x95BF2A0", Offset = "0x95BDEA0", VA = "0x1895BF2A0")]
		public int EJLFIPQUVXK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x95BF5F0", Offset = "0x95BE1F0", VA = "0x1895BF5F0")]
		public void YYVNZVCQWXY([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x95BF450", Offset = "0x95BE050", VA = "0x1895BF450")]
		public bool NZMCSOMUXHY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x416B630", Offset = "0x416A230", VA = "0x18416B630")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x95BF5D0", Offset = "0x95BE1D0", VA = "0x1895BF5D0")]
		public static int VOQZPUWNWHH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x95BF2C0", Offset = "0x95BDEC0", VA = "0x1895BF2C0")]
		public static double HHUAWRDXWUB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x95BF390", Offset = "0x95BDF90", VA = "0x1895BF390")]
		public static ulong MLXVGCPUUMY(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x302B1E0", Offset = "0x3029DE0", VA = "0x18302B1E0")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x95CF430", Offset = "0x95CE030", VA = "0x1895CF430")]
		public DiyFp AXUIUBHSVQP()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xCE0880", Offset = "0xCDF480", VA = "0x180CE0880")]
		public uint GSJUGLGXZYY()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x95CF500", Offset = "0x95CE100", VA = "0x1895CF500")]
		public int RYIVFEANMNM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x95CF4E0", Offset = "0x95CE0E0", VA = "0x1895CF4E0")]
		public uint OPAHJVXDPJS()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x95CF490", Offset = "0x95CE090", VA = "0x1895CF490")]
		public bool HXNCYNXZSVP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x95CF520", Offset = "0x95CE120", VA = "0x1895CF520")]
		public void YYVNZVCQWXY([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x95CF4A0", Offset = "0x95CE0A0", VA = "0x1895CF4A0")]
		public bool NZMCSOMUXHY()
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
		[Cpp2IlInjected.Address(RVA = "0x95BE4F0", Offset = "0x95BD0F0", VA = "0x1895BE4F0")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class PHNFQTFGIYR
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] SRTMWDGYLIO;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x95C8F50", Offset = "0x95C7B50", VA = "0x1895C8F50")]
		public static void KRIINQYXVPW(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x95C9060", Offset = "0x95C7C60", VA = "0x1895C9060")]
		public static void QULCVBTZSBJ(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0x95D1690", Offset = "0x95D0290", VA = "0x1895D1690")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5F33B00", Offset = "0x5F32700", VA = "0x185F33B00")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2FEC670", Offset = "0x2FEB270", VA = "0x182FEC670")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x95D1630", Offset = "0x95D0230", VA = "0x1895D1630")]
		public Vector UNMALVUOUYS(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class QFHZCOWJGEU
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] SKKOZQGLGSK;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] TGLQLKZTGYN;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int KVQYXIMODBC;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x95CAFF0", Offset = "0x95C9BF0", VA = "0x1895CAFF0")]
		private static byte[] GQLDGUJTFGI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x95CAF10", Offset = "0x95C9B10", VA = "0x1895CAF10")]
		private static Vector GNWYEIINDEM(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x95CAAB0", Offset = "0x95C96B0", VA = "0x1895CAAB0")]
		private static Vector BNANETPKJCE(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x95CB710", Offset = "0x95CA310", VA = "0x1895CB710")]
		private static void OBXDWMIHJCZ(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x95CAB90", Offset = "0x95C9790", VA = "0x1895CAB90")]
		private static void CIKGSSTSBWS(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x95CAE80", Offset = "0x95C9A80", VA = "0x1895CAE80")]
		private static ulong EYWIHBIIMJJ(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x95CBCB0", Offset = "0x95CA8B0", VA = "0x1895CBCB0")]
		private static void SUMXYQGQJYX(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x95CBF80", Offset = "0x95CAB80", VA = "0x1895CBF80")]
		private static bool XHYDOBDVVLI(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x95CBDF0", Offset = "0x95CA9F0", VA = "0x1895CBDF0")]
		private static DiyFp URBKHLFMQWF(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x95CB0D0", Offset = "0x95C9CD0", VA = "0x1895CB0D0")]
		private static bool GUEDTUNSHSJ(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x95CBB90", Offset = "0x95CA790", VA = "0x1895CBB90")]
		private static bool SFPGDGTQBOX(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x95CB7A0", Offset = "0x95CA3A0", VA = "0x1895CB7A0")]
		public static double? RNPFXRAUTQL(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x95CB8C0", Offset = "0x95CA4C0", VA = "0x1895CB8C0")]
		public static float? RNZTSEOPMND(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class LQVIXWGNOEA
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] IMCMALRZPYA;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] TSBLRNLXEIP;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] NTCUXQWUQFG;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] VFUHLHNIWXI;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int XXIPNRAVQJA;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] HJXLGVJVHBA;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int AUUEESUBFUG;

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x95C66D0", Offset = "0x95C52D0", VA = "0x1895C66D0")]
		private static byte[] QJERGNPZXRP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x95C68F0", Offset = "0x95C54F0", VA = "0x1895C68F0")]
		public static bool VBBDYTWFIJM(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x95C6B10", Offset = "0x95C5710", VA = "0x1895C6B10")]
		public static bool YVUGCJGDDYH(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x95C67B0", Offset = "0x95C53B0", VA = "0x1895C67B0")]
		private static bool TRRFSZIZVFC(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x95C6400", Offset = "0x95C5000", VA = "0x1895C6400")]
		private static bool HATLIDLVWXV(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x95C6A30", Offset = "0x95C5630", VA = "0x1895C6A30")]
		private static bool XSUCVDVNRTC(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x95C6C50", Offset = "0x95C5850", VA = "0x1895C6C50")]
		private static bool ZUURFZJWEUY(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x95C63E0", Offset = "0x95C4FE0", VA = "0x1895C63E0")]
		private static double DJHEFLTVSGH(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x95C53F0", Offset = "0x95C3FF0", VA = "0x1895C53F0")]
		private static double DJDCJAPHNJT(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class FFNSNPNVPRV<a> : NIBWNXHPRYX<a[]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly AZNZPQLHIIH<a> WQGVLHHNZQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour HEDZBZOYGII;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1A1AC80", Offset = "0x1A19880", VA = "0x181A1AC80")]
		public FFNSNPNVPRV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
		public FFNSNPNVPRV(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x52F5B10", Offset = "0x52F4710", VA = "0x1852F5B10", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x52F54E0", Offset = "0x52F40E0", VA = "0x1852F54E0", Slot = "5")]
		public a[] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class QDKSGQPOHAM<a> : NIBWNXHPRYX<ArraySegment<a>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly AZNZPQLHIIH<a> WQGVLHHNZQA;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x620AE90", Offset = "0x6209A90", VA = "0x18620AE90", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x620AA40", Offset = "0x6209640", VA = "0x18620AA40", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class RCCSJDFDDRQ<a> : NIBWNXHPRYX<List<a>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour HEDZBZOYGII;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1A1AC80", Offset = "0x1A19880", VA = "0x181A1AC80")]
		public RCCSJDFDDRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
		public RCCSJDFDDRQ(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x626E830", Offset = "0x626D430", VA = "0x18626E830", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x626B500", Offset = "0x626A100", VA = "0x18626B500", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class YPYNJYXLWEQ<a, b, c, d> : NIBWNXHPRYX<d>, GCGOPXTOFSI where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x448AB00", Offset = "0x4489700", VA = "0x18448AB00", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x448A610", Offset = "0x4489210", VA = "0x18448A610", Slot = "5")]
		public d Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c CLRSPMGLLXK(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected YPYNJYXLWEQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class YRJJQUGTKGB<a, b, c> : YPYNJYXLWEQ<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x448BE60", Offset = "0x448AA60", VA = "0x18448BE60", Slot = "6")]
		protected override IEnumerator<a> CLRSPMGLLXK(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected YRJJQUGTKGB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class YRECTNMWAUS<a, b> : YRJJQUGTKGB<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xB7C9B0", Offset = "0xB7B5B0", VA = "0x180B7C9B0", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class GZVFIPCWXNE<a, b> : YRECTNMWAUS<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5422F30", Offset = "0x5421B30", VA = "0x185422F30", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5422DD0", Offset = "0x54219D0", VA = "0x185422DD0", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class NWMHVGURYSF<a> : YPYNJYXLWEQ<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5F70750", Offset = "0x5F6F350", VA = "0x185F70750", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xB7C9B0", Offset = "0xB7B5B0", VA = "0x180B7C9B0", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4389AB0", Offset = "0x43886B0", VA = "0x184389AB0", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x4B94680", Offset = "0x4B93280", VA = "0x184B94680", Slot = "6")]
		protected override LinkedList<a>.Enumerator CLRSPMGLLXK(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class XBVJGVRCSHC<a> : YPYNJYXLWEQ<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x44108F0", Offset = "0x440F4F0", VA = "0x1844108F0", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x4410A80", Offset = "0x440F680", VA = "0x184410A80", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x44109D0", Offset = "0x440F5D0", VA = "0x1844109D0", Slot = "6")]
		protected override Queue<a>.Enumerator CLRSPMGLLXK(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xB7C9B0", Offset = "0xB7B5B0", VA = "0x180B7C9B0", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class RQUKGDVZQKM<a> : YPYNJYXLWEQ<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4394000", Offset = "0x4392C00", VA = "0x184394000", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x4394120", Offset = "0x4392D20", VA = "0x184394120", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6290110", Offset = "0x628ED10", VA = "0x186290110", Slot = "6")]
		protected override Stack<a>.Enumerator CLRSPMGLLXK(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x62901C0", Offset = "0x628EDC0", VA = "0x1862901C0", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class RKCBWLKAHAU<a> : YPYNJYXLWEQ<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6275C40", Offset = "0x6274840", VA = "0x186275C40", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xB7C9B0", Offset = "0xB7B5B0", VA = "0x180B7C9B0", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6275CD0", Offset = "0x62748D0", VA = "0x186275CD0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6275C80", Offset = "0x6274880", VA = "0x186275C80", Slot = "6")]
		protected override HashSet<a>.Enumerator CLRSPMGLLXK(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x60615F0", Offset = "0x60601F0", VA = "0x1860615F0")]
		public RKCBWLKAHAU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class OMMCFVLWGKU<a> : YRJJQUGTKGB<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x4394000", Offset = "0x4392C00", VA = "0x184394000", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x609F010", Offset = "0x609DC10", VA = "0x18609F010", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x609F0A0", Offset = "0x609DCA0", VA = "0x18609F0A0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class SROFTDPFRTH<a> : YRJJQUGTKGB<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x44108F0", Offset = "0x440F4F0", VA = "0x1844108F0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x4410A80", Offset = "0x440F680", VA = "0x184410A80", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xB7C9B0", Offset = "0xB7B5B0", VA = "0x180B7C9B0", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class NXWHQOHZKUF<a> : YRJJQUGTKGB<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x44108F0", Offset = "0x440F4F0", VA = "0x1844108F0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x4410A80", Offset = "0x440F680", VA = "0x184410A80", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xB7C9B0", Offset = "0xB7B5B0", VA = "0x180B7C9B0", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class UTGYEUTKTSH<a> : YRJJQUGTKGB<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6823AF0", Offset = "0x68226F0", VA = "0x186823AF0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x4394120", Offset = "0x4392D20", VA = "0x184394120", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x43940D0", Offset = "0x4392CD0", VA = "0x1843940D0", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x4394170", Offset = "0x4392D70", VA = "0x184394170")]
		public UTGYEUTKTSH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class MTEPEXCXSTZ<a, b> : NIBWNXHPRYX<IGrouping<a, b>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5EBC720", Offset = "0x5EBB320", VA = "0x185EBC720", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5EBC3D0", Offset = "0x5EBAFD0", VA = "0x185EBC3D0", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class WLPQIUOLEKK<a, b> : NIBWNXHPRYX<ILookup<a, b>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6D73040", Offset = "0x6D71C40", VA = "0x186D73040", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6D72CF0", Offset = "0x6D718F0", VA = "0x186D72CF0", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class XDQRKZYMQLU<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a NFHQLEPGVHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> RASBVFLBEWY;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x438BD40", Offset = "0x438A940", VA = "0x18438BD40", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x4411780", Offset = "0x4410380", VA = "0x184411780")]
		public XDQRKZYMQLU(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x4411690", Offset = "0x4410290", VA = "0x184411690", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x4411760", Offset = "0x4410360", VA = "0x184411760", Slot = "6")]
		private IEnumerator ZFHLTDQPCLO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class NYSHBWSTZJD<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> FGRCBPVLJDD;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x5F75380", Offset = "0x5F73F80", VA = "0x185F75380", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public NYSHBWSTZJD(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x5F751F0", Offset = "0x5F73DF0", VA = "0x185F751F0", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5F752E0", Offset = "0x5F73EE0", VA = "0x185F752E0", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5F752E0", Offset = "0x5F73EE0", VA = "0x185F752E0", Slot = "7")]
		private IEnumerator ZFHLTDQPCLO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class HPPKYXHECLM<a> : NIBWNXHPRYX<a>, GCGOPXTOFSI where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5475750", Offset = "0x5474350", VA = "0x185475750", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5475540", Offset = "0x5474140", VA = "0x185475540", Slot = "5")]
		public a Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public HPPKYXHECLM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class OHWSMPYDNWY : NIBWNXHPRYX<IEnumerable>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly NIBWNXHPRYX<IEnumerable> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x95C8BD0", Offset = "0x95C77D0", VA = "0x1895C8BD0", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x95C89C0", Offset = "0x95C75C0", VA = "0x1895C89C0", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public OHWSMPYDNWY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class TUCQFTTTUHI : NIBWNXHPRYX<ICollection>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly NIBWNXHPRYX<ICollection> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x95CFBE0", Offset = "0x95CE7E0", VA = "0x1895CFBE0", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x95CF9D0", Offset = "0x95CE5D0", VA = "0x1895CF9D0", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public TUCQFTTTUHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class HBOLLMRYDAG : NIBWNXHPRYX<IList>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly NIBWNXHPRYX<IList> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x95C1F50", Offset = "0x95C0B50", VA = "0x1895C1F50", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x95C1D40", Offset = "0x95C0940", VA = "0x1895C1D40", Slot = "5")]
		public IList Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public HBOLLMRYDAG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class KRWVKPJPEGB<a> : YRECTNMWAUS<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x44108F0", Offset = "0x440F4F0", VA = "0x1844108F0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x53F4290", Offset = "0x53F2E90", VA = "0x1853F4290", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class GAUQGDLZDYT<a> : YRJJQUGTKGB<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x44108F0", Offset = "0x440F4F0", VA = "0x1844108F0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x53F4290", Offset = "0x53F2E90", VA = "0x1853F4290", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x53F4220", Offset = "0x53F2E20", VA = "0x1853F4220", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class UTQFIHCOTZJ<a> : YRJJQUGTKGB<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x4393FC0", Offset = "0x4392BC0", VA = "0x184393FC0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x4394120", Offset = "0x4392D20", VA = "0x184394120", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6823DF0", Offset = "0x68229F0", VA = "0x186823DF0", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6823EB0", Offset = "0x6822AB0", VA = "0x186823EB0")]
		public UTQFIHCOTZJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class CITBAJTPTYP<a> : YRJJQUGTKGB<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x4393FC0", Offset = "0x4392BC0", VA = "0x184393FC0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x4394120", Offset = "0x4392D20", VA = "0x184394120", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x43940D0", Offset = "0x4392CD0", VA = "0x1843940D0", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x4394170", Offset = "0x4392D70", VA = "0x184394170")]
		public CITBAJTPTYP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class CBEPIFAGBCB<a> : YRJJQUGTKGB<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x43899D0", Offset = "0x43885D0", VA = "0x1843899D0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xB7C9B0", Offset = "0xB7B5B0", VA = "0x180B7C9B0", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x4389AB0", Offset = "0x43886B0", VA = "0x184389AB0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class TEXATEKNDNZ<a> : YRECTNMWAUS<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x44108F0", Offset = "0x440F4F0", VA = "0x1844108F0", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4410A80", Offset = "0x440F680", VA = "0x184410A80", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class AMPYTDIGVQI<a> : YRECTNMWAUS<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x44108F0", Offset = "0x440F4F0", VA = "0x1844108F0", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x4410A80", Offset = "0x440F680", VA = "0x184410A80", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class YYYRYZQZKMV<a> : YRJJQUGTKGB<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x4394000", Offset = "0x4392C00", VA = "0x184394000", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x4394120", Offset = "0x4392D20", VA = "0x184394120", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x448EE50", Offset = "0x448DA50", VA = "0x18448EE50", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class GQLYCCEAJZW
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
		[Cpp2IlInjected.Address(RVA = "0x95C1480", Offset = "0x95C0080", VA = "0x1895C1480")]
		public static DateTime KSFHXYBIIAY(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x95C12D0", Offset = "0x95BFED0", VA = "0x1895C12D0")]
		public static bool GIUYAAFJVHB(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x95C1040", Offset = "0x95BFC40", VA = "0x1895C1040")]
		public static bool ENYHAFQNWOD(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x95C0E30", Offset = "0x95BFA30", VA = "0x1895C0E30")]
		public static bool ENYHAFQNWOD(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x95C1540", Offset = "0x95C0140", VA = "0x1895C1540")]
		public static bool ZRHIKCSKXYV(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class IQYNESLDVQY : NIBWNXHPRYX<DateTime>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly NIBWNXHPRYX<DateTime> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x95C3170", Offset = "0x95C1D70", VA = "0x1895C3170", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x95C2BF0", Offset = "0x95C17F0", VA = "0x1895C2BF0", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x95C2D70", Offset = "0x95C1970", VA = "0x1895C2D70")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public IQYNESLDVQY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class WSQJGCWRCYV : NIBWNXHPRYX<DateTimeOffset>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly NIBWNXHPRYX<DateTimeOffset> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x95D20F0", Offset = "0x95D0CF0", VA = "0x1895D20F0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x95D2080", Offset = "0x95D0C80", VA = "0x1895D2080", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x95D1CA0", Offset = "0x95D08A0", VA = "0x1895D1CA0")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public WSQJGCWRCYV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class RVNELGHCOVG : NIBWNXHPRYX<TimeSpan>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly NIBWNXHPRYX<TimeSpan> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] NHLWSUGWNXC;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x95CE550", Offset = "0x95CD150", VA = "0x1895CE550", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x95CE4D0", Offset = "0x95CD0D0", VA = "0x1895CE4D0", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x95CE0E0", Offset = "0x95CCCE0", VA = "0x1895CE0E0")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RVNELGHCOVG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class WHBSPXWFRTN<a, b, c, d, e> : NIBWNXHPRYX<e>, GCGOPXTOFSI where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C920", Offset = "0x6D5B520", VA = "0x186D5C920", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6D59BC0", Offset = "0x6D587C0", VA = "0x186D59BC0", Slot = "5")]
		public e Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d CLRSPMGLLXK(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected WHBSPXWFRTN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class WGWLSRCIIIE<a, b, c, d> : WHBSPXWFRTN<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6D58A20", Offset = "0x6D57620", VA = "0x186D58A20", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> CLRSPMGLLXK(d a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class WGREVKIKYWV<a, b, c> : WGWLSRCIIIE<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xB7C9B0", Offset = "0xB7B5B0", VA = "0x180B7C9B0", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class QYYBVHYKAPB<a, b> : WHBSPXWFRTN<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6240C30", Offset = "0x623F830", VA = "0x186240C30", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xB7C9B0", Offset = "0xB7B5B0", VA = "0x180B7C9B0", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6240E80", Offset = "0x623FA80", VA = "0x186240E80", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6240E20", Offset = "0x623FA20", VA = "0x186240E20", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator CLRSPMGLLXK(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x5A13CE0", Offset = "0x5A128E0", VA = "0x185A13CE0")]
		public QYYBVHYKAPB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class TKJGNFJCYFP<a, b, c> : WGREVKIKYWV<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x65EBF90", Offset = "0x65EAB90", VA = "0x1865EBF90", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x65EC170", Offset = "0x65EAD70", VA = "0x1865EC170", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class HZEDDYBEYBC<a, b> : WGWLSRCIIIE<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x448E030", Offset = "0x448CC30", VA = "0x18448E030", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x448EDF0", Offset = "0x448D9F0", VA = "0x18448EDF0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB7C9B0", Offset = "0xB7B5B0", VA = "0x180B7C9B0", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class SJNWYLYBYOM<a, b> : WGREVKIKYWV<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x448E030", Offset = "0x448CC30", VA = "0x18448E030", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x448EDF0", Offset = "0x448D9F0", VA = "0x18448EDF0", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class KGJMOKSTGUM<a, b> : WHBSPXWFRTN<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x448E030", Offset = "0x448CC30", VA = "0x18448E030", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB7C9B0", Offset = "0xB7B5B0", VA = "0x180B7C9B0", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x448EDF0", Offset = "0x448D9F0", VA = "0x18448EDF0", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x5818450", Offset = "0x5817050", VA = "0x185818450", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator CLRSPMGLLXK(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class LDGEKGIODIF<a, b> : WGWLSRCIIIE<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x448E030", Offset = "0x448CC30", VA = "0x18448E030", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x597C720", Offset = "0x597B320", VA = "0x18597C720", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x597C790", Offset = "0x597B390", VA = "0x18597C790", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class YVXDZIUKVFU<a, b> : WGWLSRCIIIE<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x448E030", Offset = "0x448CC30", VA = "0x18448E030", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xB7C9B0", Offset = "0xB7B5B0", VA = "0x180B7C9B0", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x448E190", Offset = "0x448CD90", VA = "0x18448E190", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class YYHFFBSSHRS<a, b> : WGREVKIKYWV<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x448EC90", Offset = "0x448D890", VA = "0x18448EC90", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x448EDF0", Offset = "0x448D9F0", VA = "0x18448EDF0", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class KSDCKIVTJJY<a> : NIBWNXHPRYX<a>, GCGOPXTOFSI where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x58D1230", Offset = "0x58CFE30", VA = "0x1858D1230", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x58D0FF0", Offset = "0x58CFBF0", VA = "0x1858D0FF0", Slot = "5")]
		public a Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public KSDCKIVTJJY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class ZJQPHCUJRDM : NIBWNXHPRYX<IDictionary>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly NIBWNXHPRYX<IDictionary> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x95D72F0", Offset = "0x95D5EF0", VA = "0x1895D72F0", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x95D7110", Offset = "0x95D5D10", VA = "0x1895D7110", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ZJQPHCUJRDM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class YGPUVQWGFPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x95D4340", Offset = "0x95D2F40", VA = "0x1895D4340")]
		public static object NYBYXAAOUTW(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x95D3B20", Offset = "0x95D2720", VA = "0x1895D3B20")]
		public static object LWOOWABITGF(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class LMENUOEVZRD<a> : NIBWNXHPRYX<a>, GCGOPXTOFSI, JOKLBKLJATY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class CWLCWDGOHPR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type XWCGKVRHPNH;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWLCWDGOHPR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x43AFD50", Offset = "0x43AE950", VA = "0x1843AFD50")]
			internal bool CSRNCFKPRRC(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class CWFVYWMQYEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string MXCVSBCTDHZ;

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWFVYWMQYEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x43AF730", Offset = "0x43AE330", VA = "0x1843AF730")]
			internal bool CSWTZMENBCL(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class CWVQQQUJAMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> BFUZVJEIZEE;

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWVQQQUJAMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x43B25E0", Offset = "0x43B11E0", VA = "0x1843B25E0")]
			internal void CTCAWSYKKNU(JsonWriter a, a b, OITOBEOPOJQ c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class CWQJTKALRBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> GOMXTRNMHAF;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CWQJTKALRBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x43B1AE0", Offset = "0x43B06E0", VA = "0x1843B1AE0")]
			internal a CTHHTZSHTZD(JsonReader a, OITOBEOPOJQ b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly EESRUOTGHZC<a> BIKHSJRDVZV;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> FTARJQFRUFX;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> TOWDVIYJXKH;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> SQBGECHKRPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool QGDHEGTJACH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> BVZGQKOVJNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> YTSVWUSKXBN;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x59AC350", Offset = "0x59AAF50", VA = "0x1859AC350")]
		static LMENUOEVZRD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x59AE410", Offset = "0x59AD010", VA = "0x1859AE410")]
		public LMENUOEVZRD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x59A4910", Offset = "0x59A3510", VA = "0x1859A4910", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x59A1CA0", Offset = "0x59A08A0", VA = "0x1859A1CA0", Slot = "5")]
		public a Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x59A3F50", Offset = "0x59A2B50", VA = "0x1859A3F50", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, a b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x59A37E0", Offset = "0x59A23E0", VA = "0x1859A37E0", Slot = "7")]
		public a EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class KSCEPJRIFLF<a> : NIBWNXHPRYX<a[,]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x58D0D00", Offset = "0x58CF900", VA = "0x1858D0D00", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x58D0970", Offset = "0x58CF570", VA = "0x1858D0970", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public KSCEPJRIFLF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class ABTXIMOGKTL<a> : NIBWNXHPRYX<a[,,]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5C924B0", Offset = "0x5C910B0", VA = "0x185C924B0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5C91FE0", Offset = "0x5C90BE0", VA = "0x185C91FE0", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ABTXIMOGKTL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class AMUPVLPJOET<a> : NIBWNXHPRYX<a[,,,]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x5C98EC0", Offset = "0x5C97AC0", VA = "0x185C98EC0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x5C988C0", Offset = "0x5C974C0", VA = "0x185C988C0", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public AMUPVLPJOET()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class ZPTUEJSQKDH<a> : NIBWNXHPRYX<a?>, GCGOPXTOFSI where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x44AE450", Offset = "0x44AD050", VA = "0x1844AE450", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x44AE040", Offset = "0x44ACC40", VA = "0x1844AE040", Slot = "5")]
		public a? Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ZPTUEJSQKDH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class PSLCKSIFBYL<a> : NIBWNXHPRYX<a?>, GCGOPXTOFSI where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly NIBWNXHPRYX<a> PXUMYSHILVG;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public PSLCKSIFBYL(NIBWNXHPRYX<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x61888D0", Offset = "0x61874D0", VA = "0x1861888D0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x61882E0", Offset = "0x6186EE0", VA = "0x1861882E0", Slot = "5")]
		public a? Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class BAONLSVHXMS : NIBWNXHPRYX<sbyte>, GCGOPXTOFSI, JOKLBKLJATY<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly BAONLSVHXMS ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x95BD480", Offset = "0x95BC080", VA = "0x1895BD480", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x95BD2E0", Offset = "0x95BBEE0", VA = "0x1895BD2E0", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x95BD370", Offset = "0x95BBF70", VA = "0x1895BD370", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, sbyte b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x95BD2F0", Offset = "0x95BBEF0", VA = "0x1895BD2F0", Slot = "7")]
		public sbyte EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public BAONLSVHXMS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class XLQTPJGZLVV : NIBWNXHPRYX<sbyte?>, GCGOPXTOFSI, JOKLBKLJATY<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly XLQTPJGZLVV ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x95D3350", Offset = "0x95D1F50", VA = "0x1895D3350", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x95D30B0", Offset = "0x95D1CB0", VA = "0x1895D30B0", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x95D31F0", Offset = "0x95D1DF0", VA = "0x1895D31F0", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, sbyte? b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x95D3120", Offset = "0x95D1D20", VA = "0x1895D3120", Slot = "7")]
		public sbyte? EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public XLQTPJGZLVV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class LVBYFJJEEOJ : NIBWNXHPRYX<sbyte[]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly LVBYFJJEEOJ ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x95C70B0", Offset = "0x95C5CB0", VA = "0x1895C70B0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x95C6F70", Offset = "0x95C5B70", VA = "0x1895C6F70", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public LVBYFJJEEOJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class DQYRSHRSKCN : NIBWNXHPRYX<short>, GCGOPXTOFSI, JOKLBKLJATY<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly DQYRSHRSKCN ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x95BECE0", Offset = "0x95BD8E0", VA = "0x1895BECE0", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x95BEB40", Offset = "0x95BD740", VA = "0x1895BEB40", Slot = "5")]
		public short Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x95BEBD0", Offset = "0x95BD7D0", VA = "0x1895BEBD0", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, short b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x95BEB50", Offset = "0x95BD750", VA = "0x1895BEB50", Slot = "7")]
		public short EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public DQYRSHRSKCN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class CFXUFFIZFAM : NIBWNXHPRYX<short?>, GCGOPXTOFSI, JOKLBKLJATY<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly CFXUFFIZFAM ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x95BE030", Offset = "0x95BCC30", VA = "0x1895BE030", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x95BDD90", Offset = "0x95BC990", VA = "0x1895BDD90", Slot = "5")]
		public short? Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x95BDED0", Offset = "0x95BCAD0", VA = "0x1895BDED0", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, short? b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x95BDE00", Offset = "0x95BCA00", VA = "0x1895BDE00", Slot = "7")]
		public short? EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public CFXUFFIZFAM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class BXVDUAWMVRO : NIBWNXHPRYX<short[]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly BXVDUAWMVRO ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x95BDAF0", Offset = "0x95BC6F0", VA = "0x1895BDAF0", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x95BD9B0", Offset = "0x95BC5B0", VA = "0x1895BD9B0", Slot = "5")]
		public short[] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public BXVDUAWMVRO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class EBOHIKGDCEL : NIBWNXHPRYX<int>, GCGOPXTOFSI, JOKLBKLJATY<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly EBOHIKGDCEL ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x95BF980", Offset = "0x95BE580", VA = "0x1895BF980", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x95BF7E0", Offset = "0x95BE3E0", VA = "0x1895BF7E0", Slot = "5")]
		public int Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x95BF870", Offset = "0x95BE470", VA = "0x1895BF870", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, int b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x95BF7F0", Offset = "0x95BE3F0", VA = "0x1895BF7F0", Slot = "7")]
		public int EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public EBOHIKGDCEL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class NPCLTPIOIKS : NIBWNXHPRYX<int?>, GCGOPXTOFSI, JOKLBKLJATY<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly NPCLTPIOIKS ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x95C8460", Offset = "0x95C7060", VA = "0x1895C8460", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x95C81C0", Offset = "0x95C6DC0", VA = "0x1895C81C0", Slot = "5")]
		public int? Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x95C8300", Offset = "0x95C6F00", VA = "0x1895C8300", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, int? b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x95C8230", Offset = "0x95C6E30", VA = "0x1895C8230", Slot = "7")]
		public int? EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public NPCLTPIOIKS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class YPRIRILDPRM : NIBWNXHPRYX<int[]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly YPRIRILDPRM ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x95D4CA0", Offset = "0x95D38A0", VA = "0x1895D4CA0", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x95D4B60", Offset = "0x95D3760", VA = "0x1895D4B60", Slot = "5")]
		public int[] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public YPRIRILDPRM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class DTATJDEOFOS : NIBWNXHPRYX<long>, GCGOPXTOFSI, JOKLBKLJATY<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly DTATJDEOFOS ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x95BEF00", Offset = "0x95BDB00", VA = "0x1895BEF00", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x95BEDE0", Offset = "0x95BD9E0", VA = "0x1895BEDE0", Slot = "5")]
		public long Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x95BEE30", Offset = "0x95BDA30", VA = "0x1895BEE30", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, long b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x95BEDF0", Offset = "0x95BD9F0", VA = "0x1895BEDF0", Slot = "7")]
		public long EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public DTATJDEOFOS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class SQVOFZTAYBB : NIBWNXHPRYX<long?>, GCGOPXTOFSI, JOKLBKLJATY<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly SQVOFZTAYBB ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x95CF090", Offset = "0x95CDC90", VA = "0x1895CF090", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x95CEE20", Offset = "0x95CDA20", VA = "0x1895CEE20", Slot = "5")]
		public long? Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x95CEF60", Offset = "0x95CDB60", VA = "0x1895CEF60", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, long? b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x95CEEB0", Offset = "0x95CDAB0", VA = "0x1895CEEB0", Slot = "7")]
		public long? EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public SQVOFZTAYBB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class EWZOSQHVIVH : NIBWNXHPRYX<long[]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly EWZOSQHVIVH ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x95C04A0", Offset = "0x95BF0A0", VA = "0x1895C04A0", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x95C0360", Offset = "0x95BEF60", VA = "0x1895C0360", Slot = "5")]
		public long[] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public EWZOSQHVIVH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class KRYOMPZNRZN : NIBWNXHPRYX<byte>, GCGOPXTOFSI, JOKLBKLJATY<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly KRYOMPZNRZN ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x95C4F10", Offset = "0x95C3B10", VA = "0x1895C4F10", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x95C4D70", Offset = "0x95C3970", VA = "0x1895C4D70", Slot = "5")]
		public byte Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x95C4E00", Offset = "0x95C3A00", VA = "0x1895C4E00", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, byte b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x95C4D80", Offset = "0x95C3980", VA = "0x1895C4D80", Slot = "7")]
		public byte EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public KRYOMPZNRZN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class MUGEPDIZCSM : NIBWNXHPRYX<byte?>, GCGOPXTOFSI, JOKLBKLJATY<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly MUGEPDIZCSM ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x95C7CE0", Offset = "0x95C68E0", VA = "0x1895C7CE0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x95C7A40", Offset = "0x95C6640", VA = "0x1895C7A40", Slot = "5")]
		public byte? Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x95C7B80", Offset = "0x95C6780", VA = "0x1895C7B80", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, byte? b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x95C7AB0", Offset = "0x95C66B0", VA = "0x1895C7AB0", Slot = "7")]
		public byte? EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public MUGEPDIZCSM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class LMNDSFPIMSQ : NIBWNXHPRYX<ushort>, GCGOPXTOFSI, JOKLBKLJATY<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly LMNDSFPIMSQ ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x95C52F0", Offset = "0x95C3EF0", VA = "0x1895C52F0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x95C5150", Offset = "0x95C3D50", VA = "0x1895C5150", Slot = "5")]
		public ushort Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x95C51E0", Offset = "0x95C3DE0", VA = "0x1895C51E0", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, ushort b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x95C5160", Offset = "0x95C3D60", VA = "0x1895C5160", Slot = "7")]
		public ushort EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public LMNDSFPIMSQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class OBNPEKBALRB : NIBWNXHPRYX<ushort?>, GCGOPXTOFSI, JOKLBKLJATY<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly OBNPEKBALRB ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x95C8860", Offset = "0x95C7460", VA = "0x1895C8860", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x95C85C0", Offset = "0x95C71C0", VA = "0x1895C85C0", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x95C8700", Offset = "0x95C7300", VA = "0x1895C8700", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, ushort? b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x95C8630", Offset = "0x95C7230", VA = "0x1895C8630", Slot = "7")]
		public ushort? EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public OBNPEKBALRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class MGZNFDHXLCX : NIBWNXHPRYX<ushort[]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly MGZNFDHXLCX ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x95C7490", Offset = "0x95C6090", VA = "0x1895C7490", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x95C7350", Offset = "0x95C5F50", VA = "0x1895C7350", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public MGZNFDHXLCX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class IGRQIPKKLJU : NIBWNXHPRYX<uint>, GCGOPXTOFSI, JOKLBKLJATY<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly IGRQIPKKLJU ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x95C2900", Offset = "0x95C1500", VA = "0x1895C2900", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x95C2760", Offset = "0x95C1360", VA = "0x1895C2760", Slot = "5")]
		public uint Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x95C27F0", Offset = "0x95C13F0", VA = "0x1895C27F0", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, uint b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x95C2770", Offset = "0x95C1370", VA = "0x1895C2770", Slot = "7")]
		public uint EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public IGRQIPKKLJU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class HERUGQEGHPD : NIBWNXHPRYX<uint?>, GCGOPXTOFSI, JOKLBKLJATY<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly HERUGQEGHPD ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x95C2600", Offset = "0x95C1200", VA = "0x1895C2600", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x95C2360", Offset = "0x95C0F60", VA = "0x1895C2360", Slot = "5")]
		public uint? Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x95C24A0", Offset = "0x95C10A0", VA = "0x1895C24A0", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, uint? b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x95C23D0", Offset = "0x95C0FD0", VA = "0x1895C23D0", Slot = "7")]
		public uint? EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public HERUGQEGHPD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class WAVNMPRJHIV : NIBWNXHPRYX<uint[]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly WAVNMPRJHIV ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x95D1A00", Offset = "0x95D0600", VA = "0x1895D1A00", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x95D18C0", Offset = "0x95D04C0", VA = "0x1895D18C0", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public WAVNMPRJHIV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class WAPCQTANUGL : NIBWNXHPRYX<ulong>, GCGOPXTOFSI, JOKLBKLJATY<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly WAPCQTANUGL ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x95D17F0", Offset = "0x95D03F0", VA = "0x1895D17F0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x95D16D0", Offset = "0x95D02D0", VA = "0x1895D16D0", Slot = "5")]
		public ulong Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x95D1720", Offset = "0x95D0320", VA = "0x1895D1720", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, ulong b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x95D16E0", Offset = "0x95D02E0", VA = "0x1895D16E0", Slot = "7")]
		public ulong EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public WAPCQTANUGL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class PVSUAFCTNUM : NIBWNXHPRYX<ulong?>, GCGOPXTOFSI, JOKLBKLJATY<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly PVSUAFCTNUM ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x95CA300", Offset = "0x95C8F00", VA = "0x1895CA300", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x95CA090", Offset = "0x95C8C90", VA = "0x1895CA090", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x95CA1D0", Offset = "0x95C8DD0", VA = "0x1895CA1D0", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, ulong? b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x95CA120", Offset = "0x95C8D20", VA = "0x1895CA120", Slot = "7")]
		public ulong? EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public PVSUAFCTNUM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class VSYOMBPRPJQ : NIBWNXHPRYX<ulong[]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly VSYOMBPRPJQ ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x95D11D0", Offset = "0x95CFDD0", VA = "0x1895D11D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x95D1090", Offset = "0x95CFC90", VA = "0x1895D1090", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public VSYOMBPRPJQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class GIZMUJIULXP : NIBWNXHPRYX<float>, GCGOPXTOFSI, JOKLBKLJATY<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly GIZMUJIULXP ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x95C0D60", Offset = "0x95BF960", VA = "0x1895C0D60", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x95C0C40", Offset = "0x95BF840", VA = "0x1895C0C40", Slot = "5")]
		public float Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x95C0C90", Offset = "0x95BF890", VA = "0x1895C0C90", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, float b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x95C0C50", Offset = "0x95BF850", VA = "0x1895C0C50", Slot = "7")]
		public float EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public GIZMUJIULXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class XVQVSHGHDHU : NIBWNXHPRYX<float?>, GCGOPXTOFSI, JOKLBKLJATY<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly XVQVSHGHDHU ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x95D39F0", Offset = "0x95D25F0", VA = "0x1895D39F0", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x95D37C0", Offset = "0x95D23C0", VA = "0x1895D37C0", Slot = "5")]
		public float? Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x95D38D0", Offset = "0x95D24D0", VA = "0x1895D38D0", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, float? b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x95D3830", Offset = "0x95D2430", VA = "0x1895D3830", Slot = "7")]
		public float? EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public XVQVSHGHDHU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class QAIZPCLEKSY : NIBWNXHPRYX<float[]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly QAIZPCLEKSY ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x95CA570", Offset = "0x95C9170", VA = "0x1895CA570", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x95CA430", Offset = "0x95C9030", VA = "0x1895CA430", Slot = "5")]
		public float[] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public QAIZPCLEKSY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class FLAXEATNRNA : NIBWNXHPRYX<double>, GCGOPXTOFSI, JOKLBKLJATY<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly FLAXEATNRNA ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x95C0B70", Offset = "0x95BF770", VA = "0x1895C0B70", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x95C0A50", Offset = "0x95BF650", VA = "0x1895C0A50", Slot = "5")]
		public double Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x95C0AA0", Offset = "0x95BF6A0", VA = "0x1895C0AA0", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, double b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x95C0A60", Offset = "0x95BF660", VA = "0x1895C0A60", Slot = "7")]
		public double EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public FLAXEATNRNA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class GRBLMKCTOIJ : NIBWNXHPRYX<double?>, GCGOPXTOFSI, JOKLBKLJATY<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly GRBLMKCTOIJ ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x95C19E0", Offset = "0x95C05E0", VA = "0x1895C19E0", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x95C1770", Offset = "0x95C0370", VA = "0x1895C1770", Slot = "5")]
		public double? Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x95C18B0", Offset = "0x95C04B0", VA = "0x1895C18B0", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, double? b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x95C1800", Offset = "0x95C0400", VA = "0x1895C1800", Slot = "7")]
		public double? EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public GRBLMKCTOIJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class ENFGLFYROZL : NIBWNXHPRYX<double[]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly ENFGLFYROZL ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x95BFFE0", Offset = "0x95BEBE0", VA = "0x1895BFFE0", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x95BFEA0", Offset = "0x95BEAA0", VA = "0x1895BFEA0", Slot = "5")]
		public double[] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public ENFGLFYROZL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class IOQJQZFBXEX : NIBWNXHPRYX<bool>, GCGOPXTOFSI, JOKLBKLJATY<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly IOQJQZFBXEX ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x95C2B20", Offset = "0x95C1720", VA = "0x1895C2B20", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x95C2A00", Offset = "0x95C1600", VA = "0x1895C2A00", Slot = "5")]
		public bool Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x95C2A50", Offset = "0x95C1650", VA = "0x1895C2A50", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, bool b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x95C2A10", Offset = "0x95C1610", VA = "0x1895C2A10", Slot = "7")]
		public bool EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public IOQJQZFBXEX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class CUESOTEGWMO : NIBWNXHPRYX<bool?>, GCGOPXTOFSI, JOKLBKLJATY<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly CUESOTEGWMO ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x95BE3C0", Offset = "0x95BCFC0", VA = "0x1895BE3C0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x95BE190", Offset = "0x95BCD90", VA = "0x1895BE190", Slot = "5")]
		public bool? Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x95BE2A0", Offset = "0x95BCEA0", VA = "0x1895BE2A0", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, bool? b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x95BE200", Offset = "0x95BCE00", VA = "0x1895BE200", Slot = "7")]
		public bool? EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public CUESOTEGWMO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class VLVXWJTBUFA : NIBWNXHPRYX<bool[]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly VLVXWJTBUFA ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x95D0D00", Offset = "0x95CF900", VA = "0x1895D0D00", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x95D0BC0", Offset = "0x95CF7C0", VA = "0x1895D0BC0", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public VLVXWJTBUFA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class RCNQJOGGGAC : NIBWNXHPRYX<byte[]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly NIBWNXHPRYX<byte[]> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x95CC480", Offset = "0x95CB080", VA = "0x1895CC480", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x95CC410", Offset = "0x95CB010", VA = "0x1895CC410", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public RCNQJOGGGAC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class SRJKTWIVNXD : NIBWNXHPRYX<ArraySegment<byte>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly NIBWNXHPRYX<ArraySegment<byte>> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x95CF290", Offset = "0x95CDE90", VA = "0x1895CF290", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x95CF1C0", Offset = "0x95CDDC0", VA = "0x1895CF1C0", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public SRJKTWIVNXD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class LEZDJFDGDRX : NIBWNXHPRYX<string>, GCGOPXTOFSI, JOKLBKLJATY<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly NIBWNXHPRYX<string> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x95C5080", Offset = "0x95C3C80", VA = "0x1895C5080", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x95C5010", Offset = "0x95C3C10", VA = "0x1895C5010", Slot = "5")]
		public string Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x95C5020", Offset = "0x95C3C20", VA = "0x1895C5020", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, string b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x95C5010", Offset = "0x95C3C10", VA = "0x1895C5010", Slot = "7")]
		public string EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public LEZDJFDGDRX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class FGUVLUKEYFG : NIBWNXHPRYX<string[]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly FGUVLUKEYFG ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x95C0820", Offset = "0x95BF420", VA = "0x1895C0820", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x95C06D0", Offset = "0x95BF2D0", VA = "0x1895C06D0", Slot = "5")]
		public string[] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public FGUVLUKEYFG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class UQTDDPJZWHX : NIBWNXHPRYX<char>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly UQTDDPJZWHX ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x95D08B0", Offset = "0x95CF4B0", VA = "0x1895D08B0", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x95D0880", Offset = "0x95CF480", VA = "0x1895D0880", Slot = "5")]
		public char Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public UQTDDPJZWHX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class GSCCNRIWZUC : NIBWNXHPRYX<char?>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly GSCCNRIWZUC ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x95C1BD0", Offset = "0x95C07D0", VA = "0x1895C1BD0", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x95C1B10", Offset = "0x95C0710", VA = "0x1895C1B10", Slot = "5")]
		public char? Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public GSCCNRIWZUC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class DCBJPECSHEU : NIBWNXHPRYX<char[]>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly DCBJPECSHEU ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x95BE690", Offset = "0x95BD290", VA = "0x1895BE690", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x95BE500", Offset = "0x95BD100", VA = "0x1895BE500", Slot = "5")]
		public char[] Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public DCBJPECSHEU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class BRFGSFVRPMO : NIBWNXHPRYX<Guid>, GCGOPXTOFSI, JOKLBKLJATY<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly NIBWNXHPRYX<Guid> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x95BD7D0", Offset = "0x95BC3D0", VA = "0x1895BD7D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x95BD580", Offset = "0x95BC180", VA = "0x1895BD580", Slot = "5")]
		public Guid Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x95BD650", Offset = "0x95BC250", VA = "0x1895BD650", Slot = "6")]
		public void SGRPUHLOOZQ(JsonWriter a, Guid b, OITOBEOPOJQ c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x95BD5E0", Offset = "0x95BC1E0", VA = "0x1895BD5E0", Slot = "7")]
		public Guid EZVABOESJGC(JsonReader a, OITOBEOPOJQ b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public BRFGSFVRPMO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class EKKQXXLQOEK : NIBWNXHPRYX<decimal>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly NIBWNXHPRYX<decimal> ERMGBLVPTJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool TRPYVRJZJQY;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x78E4220", Offset = "0x78E2E20", VA = "0x1878E4220")]
		public EKKQXXLQOEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xDC26B0", Offset = "0xDC12B0", VA = "0x180DC26B0")]
		public EKKQXXLQOEK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x95BFC50", Offset = "0x95BE850", VA = "0x1895BFC50", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x95BFA80", Offset = "0x95BE680", VA = "0x1895BFA80", Slot = "5")]
		public decimal Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class MXBATGDFZTT : NIBWNXHPRYX<Uri>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly NIBWNXHPRYX<Uri> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x95C7EC0", Offset = "0x95C6AC0", VA = "0x1895C7EC0", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x95C7E40", Offset = "0x95C6A40", VA = "0x1895C7E40", Slot = "5")]
		public Uri Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public MXBATGDFZTT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class QBEOCMHWMRR : NIBWNXHPRYX<Version>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly NIBWNXHPRYX<Version> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x95CA980", Offset = "0x95C9580", VA = "0x1895CA980", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x95CA900", Offset = "0x95C9500", VA = "0x1895CA900", Slot = "5")]
		public Version Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public QBEOCMHWMRR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class JIASGIVKLWT<a, b> : NIBWNXHPRYX<KeyValuePair<a, b>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5676CD0", Offset = "0x56758D0", VA = "0x185676CD0", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5676800", Offset = "0x5675400", VA = "0x185676800", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class XHUMXKEXEJB : NIBWNXHPRYX<StringBuilder>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly NIBWNXHPRYX<StringBuilder> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x95D2FA0", Offset = "0x95D1BA0", VA = "0x1895D2FA0", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x95D2F20", Offset = "0x95D1B20", VA = "0x1895D2F20", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public XHUMXKEXEJB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class XTLNPYBXEWZ : NIBWNXHPRYX<BitArray>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly NIBWNXHPRYX<BitArray> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x95D35D0", Offset = "0x95D21D0", VA = "0x1895D35D0", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x95D34B0", Offset = "0x95D20B0", VA = "0x1895D34B0", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public XTLNPYBXEWZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class MSNQVLDHFYB : NIBWNXHPRYX<Type>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly MSNQVLDHFYB ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex ODVWVHNAYXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool TULQPIVZABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool DXUGJDUPYCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool VJZUYCNFPKE;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x95C7A20", Offset = "0x95C6620", VA = "0x1895C7A20")]
		public MSNQVLDHFYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x88A92B0", Offset = "0x88A7EB0", VA = "0x1888A92B0")]
		public MSNQVLDHFYB(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x95C7840", Offset = "0x95C6440", VA = "0x1895C7840", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x95C7730", Offset = "0x95C6330", VA = "0x1895C7730", Slot = "5")]
		public Type Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class DHUOYMWHZKB : NIBWNXHPRYX<BigInteger>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly NIBWNXHPRYX<BigInteger> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x95BEA00", Offset = "0x95BD600", VA = "0x1895BEA00", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x95BE950", Offset = "0x95BD550", VA = "0x1895BE950", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public DHUOYMWHZKB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class VXTQTUAHOED : NIBWNXHPRYX<Complex>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly NIBWNXHPRYX<Complex> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x95D1490", Offset = "0x95D0090", VA = "0x1895D1490", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x95D1400", Offset = "0x95D0000", VA = "0x1895D1400", Slot = "5")]
		public Complex Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public VXTQTUAHOED()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class XEGLUSORAFP : NIBWNXHPRYX<ExpandoObject>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly NIBWNXHPRYX<ExpandoObject> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x95D2E20", Offset = "0x95D1A20", VA = "0x1895D2E20", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x95D2BF0", Offset = "0x95D17F0", VA = "0x1895D2BF0", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public XEGLUSORAFP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class HLNWDUJWIVW<a> : NIBWNXHPRYX<Lazy<a>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5474E10", Offset = "0x5473A10", VA = "0x185474E10", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5474C20", Offset = "0x5473820", VA = "0x185474C20", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class UXAKYKMGUWI : NIBWNXHPRYX<Task>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly NIBWNXHPRYX<Task> ERMGBLVPTJQ;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task JYHJWQYMATB;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x95D0A80", Offset = "0x95CF680", VA = "0x1895D0A80", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x95D09D0", Offset = "0x95CF5D0", VA = "0x1895D09D0", Slot = "5")]
		public Task Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public UXAKYKMGUWI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class WANUMJGKGRY<a> : NIBWNXHPRYX<Task<a>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x6D23600", Offset = "0x6D22200", VA = "0x186D23600", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x6D23410", Offset = "0x6D22010", VA = "0x186D23410", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class SJGNIDHIDOY<a> : NIBWNXHPRYX<ValueTask<a>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x64F3450", Offset = "0x64F2050", VA = "0x1864F3450", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x64F3230", Offset = "0x64F1E30", VA = "0x1864F3230", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class UZNVKZYIGEO<a> : NIBWNXHPRYX<Tuple<a>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x68394B0", Offset = "0x68380B0", VA = "0x1868394B0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x68391E0", Offset = "0x6837DE0", VA = "0x1868391E0", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class UZIONTEKWTF<a, b> : NIBWNXHPRYX<Tuple<a, b>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x6837DC0", Offset = "0x68369C0", VA = "0x186837DC0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x68379A0", Offset = "0x68365A0", VA = "0x1868379A0", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class UZDHQMKNNHW<a, b, c> : NIBWNXHPRYX<Tuple<a, b, c>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x6836690", Offset = "0x6835290", VA = "0x186836690", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x6836130", Offset = "0x6834D30", VA = "0x186836130", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class VAODXHTVBJH<a, b, c, d> : NIBWNXHPRYX<Tuple<a, b, c, d>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x692EA80", Offset = "0x692D680", VA = "0x18692EA80", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x692E3D0", Offset = "0x692CFD0", VA = "0x18692E3D0", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class VAIXAAZXRXY<a, b, c, d, e> : NIBWNXHPRYX<Tuple<a, b, c, d, e>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x692DA80", Offset = "0x692C680", VA = "0x18692DA80", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x692D280", Offset = "0x692BE80", VA = "0x18692D280", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class VADQCUGAIMP<a, b, c, d, e, f> : NIBWNXHPRYX<Tuple<a, b, c, d, e, f>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x692C7C0", Offset = "0x692B3C0", VA = "0x18692C7C0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x692BE30", Offset = "0x692AA30", VA = "0x18692BE30", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class UZYJFNMCZBG<a, b, c, d, e, f, g> : NIBWNXHPRYX<Tuple<a, b, c, d, e, f, g>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x683A390", Offset = "0x6838F90", VA = "0x18683A390", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x6839880", Offset = "0x6838480", VA = "0x186839880", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class UYCZEEPASDD<a, b, c, d, e, f, g, h> : NIBWNXHPRYX<Tuple<a, b, c, d, e, f, g, h>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x6834BD0", Offset = "0x68337D0", VA = "0x186834BD0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x6833F60", Offset = "0x6832B60", VA = "0x186833F60", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class OQUNGZBRSZD<a> : NIBWNXHPRYX<ValueTuple<a>>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x60A9320", Offset = "0x60A7F20", VA = "0x1860A9320", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x60A8F10", Offset = "0x60A7B10", VA = "0x1860A8F10", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class OQESPETZQRC<a, b> : NIBWNXHPRYX<(a, b)>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x60A6F90", Offset = "0x60A5B90", VA = "0x1860A6F90", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x60A6AB0", Offset = "0x60A56B0", VA = "0x1860A6AB0", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class OQJZMLNXACL<a, b, c> : NIBWNXHPRYX<(a, b, c)>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x60A7B50", Offset = "0x60A6750", VA = "0x1860A7B50", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x60A74E0", Offset = "0x60A60E0", VA = "0x1860A74E0", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class OPUEURGEXUK<a, b, c, d> : NIBWNXHPRYX<(a, b, c, d)>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x60A4E00", Offset = "0x60A3A00", VA = "0x1860A4E00", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x60A45D0", Offset = "0x60A31D0", VA = "0x1860A45D0", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class OPZLRYACHFT<a, b, c, d, e> : NIBWNXHPRYX<(a, b, c, d, e)>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x60A6060", Offset = "0x60A4C60", VA = "0x1860A6060", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x60A56B0", Offset = "0x60A42B0", VA = "0x1860A56B0", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class OPJRADSKEXS<a, b, c, d, e, f> : NIBWNXHPRYX<(a, b, c, d, e, f)>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x60A1EC0", Offset = "0x60A0AC0", VA = "0x1860A1EC0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x60A1300", Offset = "0x609FF00", VA = "0x1860A1300", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class OPOXXKMHOJB<a, b, c, d, e, f, g> : NIBWNXHPRYX<(a, b, c, d, e, f, g)>, GCGOPXTOFSI
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x60A3820", Offset = "0x60A2420", VA = "0x1860A3820", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x60A2AC0", Offset = "0x60A16C0", VA = "0x1860A2AC0", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class OOZDFQEPMBA<a, b, c, d, e, f, g, h> : NIBWNXHPRYX<ValueTuple<a, b, c, d, e, f, g, h>>, GCGOPXTOFSI where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] LTAOEIQETPD;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly JTROOOHVOOT XBQHZYVDZNH;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x60A03C0", Offset = "0x609EFC0", VA = "0x1860A03C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, OITOBEOPOJQ formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x609F4A0", Offset = "0x609E0A0", VA = "0x18609F4A0", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, OITOBEOPOJQ formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class NCEICNMABZL
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] UZEFPOEKZTV;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly JTROOOHVOOT HRRWVYAJEYK;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x95C8010", Offset = "0x95C6C10", VA = "0x1895C8010")]
		static NCEICNMABZL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class SMJMZPLOWTN
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] XMDUCQAJZQO;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly JTROOOHVOOT YJWRFDQBPNV;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x95CEC70", Offset = "0x95CD870", VA = "0x1895CEC70")]
		static SMJMZPLOWTN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class JHRIVGBRJMF
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] HHZVMJFVSGD;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly JTROOOHVOOT MLQUJNFPDWM;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] HIFCJPZTBRM;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly JTROOOHVOOT MMGPBHNHGEN;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] HIKJGWTQLCV;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly JTROOOHVOOT MMBIEATJWTE;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] HGZNABKIXBK;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly JTROOOHVOOT MLAZRSXXBOL;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] HHETXIEGGMT;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly JTROOOHVOOT MKVSUMDZSDC;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] HHKAUOYDPYC;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly JTROOOHVOOT MLLNMGLRULD;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] HHPHRVSAZJL;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly JTROOOHVOOT MLGGOZRUKZU;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] HJKRTEPDGHO;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly JTROOOHVOOT MNMEKWCRKUP;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x95C3D90", Offset = "0x95C2990", VA = "0x1895C3D90")]
		static JHRIVGBRJMF()
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
