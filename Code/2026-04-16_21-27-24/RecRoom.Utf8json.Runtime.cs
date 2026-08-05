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
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xCE77C0", Offset = "0xCE65C0", VA = "0x180CE77C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, PUYXSHPJLHM resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, PUYXSHPJLHM resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface GSCBNOMCLYY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface NSYRGRINYUX<a> : GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, PUYXSHPJLHM formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface XVTXOBOXPXQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void UWIGGGXULCG(JsonWriter a, a b, PUYXSHPJLHM c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b);
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
	public static class DTMIGPRFPVH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x38DB270", Offset = "0x38DA070", VA = "0x1838DB270")]
		public static string ToJsonString<T>(this NSYRGRINYUX<T> formatter, T value, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NSYRGRINYUX<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class FKVCIDLILUH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5270", Offset = "0x3AA4070", VA = "0x183AA5270")]
		public static NSYRGRINYUX<a> FVAAMOUCAVA<a>(this PUYXSHPJLHM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA3BBFD0", Offset = "0xA3BADD0", VA = "0x18A3BBFD0")]
		public static object OPJTBAFUNIY(this PUYXSHPJLHM a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC1C0", Offset = "0xA3BAFC0", VA = "0x18A3BC1C0")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class ISTAVZEXOAG
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] FNHZVKNTSOF;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] JNFWMGXCMGQ;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] FQGYULNQFVX;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] YJNHFBJJKZK;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] AJNSCFPBTXZ;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] VZKPWJXVMAC;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] CLTBBWEKVRO;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] RPQYUDLGQYV;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class REEFIKXMCTH : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0xA3C9670", Offset = "0xA3C8470", VA = "0x18A3C9670")]
				public REEFIKXMCTH(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xA3C9550", Offset = "0xA3C8350", VA = "0x18A3C9550")]
				public REEFIKXMCTH QNXJNWRYKZL(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class RCLVWFWNXLM
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] WKXKOCQWTZJ;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] YJVJBPHHWXW;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private REEFIKXMCTH start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private REEFIKXMCTH end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA3C9C20", Offset = "0xA3C8A20", VA = "0x18A3C9C20")]
			public void QNXJNWRYKZL([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA3C9D30", Offset = "0xA3C8B30", VA = "0x18A3C9D30")]
			public void QNXJNWRYKZL(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA3C9900", Offset = "0xA3C8700", VA = "0x18A3C9900")]
			public ReadOnlySequence<byte> LVSMVTZOBCO()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA3C9750", Offset = "0xA3C8550", VA = "0x18A3C9750")]
			private void EIKIEMMJPVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA3C9A30", Offset = "0xA3C8830", VA = "0x18A3C9A30")]
			private void LYFBIYCYTRC([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5C30", Offset = "0xA3C4A30", VA = "0x18A3C5C30")]
		public JsonReader([In] ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5AC0", Offset = "0xA3C48C0", VA = "0x18A3C5AC0")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2DB0", Offset = "0xA3C1BB0", VA = "0x18A3C2DB0")]
		private JsonParsingException BWHTXEPHCEM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA3C29D0", Offset = "0xA3C17D0", VA = "0x18A3C29D0")]
		private JsonParsingException ANEHVJRZHMX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA3C37C0", Offset = "0xA3C25C0", VA = "0x18A3C37C0")]
		public JsonToken KBPBJDQMSPV()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA3C3100", Offset = "0xA3C1F00", VA = "0x18A3C3100")]
		public void BYYHJSUARPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4AB0", Offset = "0xA3C38B0", VA = "0x18A3C4AB0")]
		private bool TZMBIPIMUYZ(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4B10", Offset = "0xA3C3910", VA = "0x18A3C4B10")]
		private bool TZMBIPIMUYZ(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5440", Offset = "0xA3C4240", VA = "0x18A3C5440")]
		private void XSONAYUYQPG(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4310", Offset = "0xA3C3110", VA = "0x18A3C4310")]
		public bool RKLGMIQEOAA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C37A0", Offset = "0xA3C25A0", VA = "0x18A3C37A0")]
		public void JENHOANKATY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4610", Offset = "0xA3C3410", VA = "0x18A3C4610")]
		public bool RNTFAVMFLKP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C3470", Offset = "0xA3C2270", VA = "0x18A3C3470")]
		public void GJRUAOQUUYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4090", Offset = "0xA3C2E90", VA = "0x18A3C4090")]
		public void QOMBKYNJJOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5A70", Offset = "0xA3C4870", VA = "0x18A3C5A70")]
		public bool ZMCCTYOIWFD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA3C33D0", Offset = "0xA3C21D0", VA = "0x18A3C33D0")]
		public void ENFKXBALIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA3C33E0", Offset = "0xA3C21E0", VA = "0x18A3C33E0")]
		public void FDQUYOYVYTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA3C46A0", Offset = "0xA3C34A0", VA = "0x18A3C46A0")]
		public bool TGUKMANZAFK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA3C39D0", Offset = "0xA3C27D0", VA = "0x18A3C39D0")]
		public bool KUEQPKJXTAH(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA3C59E0", Offset = "0xA3C47E0", VA = "0x18A3C59E0")]
		public bool YYLCETMXPNE(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4C90", Offset = "0xA3C3A90", VA = "0x18A3C4C90")]
		public bool VYQRRWDUSJP(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4F60", Offset = "0xA3C3D60", VA = "0x18A3C4F60")]
		private ReadOnlySequence<byte> WNJHNYQTHLE()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA3C40A0", Offset = "0xA3C2EA0", VA = "0x18A3C40A0")]
		private ReadOnlySequence<byte> QUABNUZDBHH()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4D70", Offset = "0xA3C3B70", VA = "0x18A3C4D70")]
		private void WDNJDTTYXDP(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C54F0", Offset = "0xA3C42F0", VA = "0x18A3C54F0")]
		private void YALEPQHEJWE(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C56F0", Offset = "0xA3C44F0", VA = "0x18A3C56F0")]
		private void YJFLCWQSKOX(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C3690", Offset = "0xA3C2490", VA = "0x18A3C3690")]
		private void IVIHWDQLGJE(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA3B9230", Offset = "0xA3B8030", VA = "0x18A3B9230")]
		private static int QCICDZCDGLL(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C3FC0", Offset = "0xA3C2DC0", VA = "0x18A3C3FC0")]
		public ReadOnlySequence<byte> ORTLPUYPRGX()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C33F0", Offset = "0xA3C21F0", VA = "0x18A3C33F0")]
		public string FZCCFRHFRYI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4660", Offset = "0xA3C3460", VA = "0x18A3C4660")]
		public string RXHLIFIHGCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2AE0", Offset = "0xA3C18E0", VA = "0x18A3C2AE0")]
		public ReadOnlySequence<byte> AQYHIITYZWZ()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4730", Offset = "0xA3C3530", VA = "0x18A3C4730")]
		public ReadOnlySequence<byte> TOFXOZBOSPI()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2C60", Offset = "0xA3C1A60", VA = "0x18A3C2C60")]
		public bool BQSQAMWZITN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA3C3AB0", Offset = "0xA3C28B0", VA = "0x18A3C3AB0")]
		private void LOVSHEPGTPB(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA3C37B0", Offset = "0xA3C25B0", VA = "0x18A3C37B0")]
		public void JWMLRAHHJUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA3C43D0", Offset = "0xA3C31D0", VA = "0x18A3C43D0")]
		private void RMKPNNFRZEC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA3C3480", Offset = "0xA3C2280", VA = "0x18A3C3480")]
		public sbyte HLPURFSMSLO()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA3C3F10", Offset = "0xA3C2D10", VA = "0x18A3C3F10")]
		public short OOWOQPQNOAV()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2BB0", Offset = "0xA3C19B0", VA = "0x18A3C2BB0")]
		public int ASKOFLJXBCL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4C20", Offset = "0xA3C3A20", VA = "0x18A3C4C20")]
		public long UNPEDKIQBNK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C3530", Offset = "0xA3C2330", VA = "0x18A3C3530")]
		public byte HZUHYQXJVSD()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4B70", Offset = "0xA3C3970", VA = "0x18A3C4B70")]
		public ushort TZYEEDTTRSW()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C35E0", Offset = "0xA3C23E0", VA = "0x18A3C35E0")]
		public uint IBGOBOJYXDO()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C3C20", Offset = "0xA3C2A20", VA = "0x18A3C3C20")]
		public ulong NAMOPABBGQP()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C3E70", Offset = "0xA3C2C70", VA = "0x18A3C3E70")]
		public float NWTDFUZJVLD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA3C3330", Offset = "0xA3C2130", VA = "0x18A3C3330")]
		public double CQMEFQLEVDC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA3C3C90", Offset = "0xA3C2A90", VA = "0x18A3C3C90")]
		public ReadOnlySequence<byte> NJYXZCXJXNX()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA3C4810", Offset = "0xA3C3610", VA = "0x18A3C4810")]
		private void TWAWASHAUSX()
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
			[Cpp2IlInjected.Address(RVA = "0xF8DEC0", Offset = "0xF8CCC0", VA = "0x180F8DEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2970", Offset = "0xA3C1770", VA = "0x18A3C2970")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C28F0", Offset = "0xA3C16F0", VA = "0x18A3C28F0")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class ULOHAZDUCMT
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class VYMTVVABQZO
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] WKXKOCQWTZJ;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA3CB670", Offset = "0xA3CA470", VA = "0x18A3CB670")]
			public static byte[] FLXSSTPZSVP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static PUYXSHPJLHM BPKHLYYZKWM;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] BVTVTFRABLF;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] UKJJCBHLEEH;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static PUYXSHPJLHM RCYYZUJFOEA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA3CA250", Offset = "0xA3C9050", VA = "0x18A3CA250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA3CACB0", Offset = "0xA3C9AB0", VA = "0x18A3CACB0")]
		public static void MYSWNECCNPI(PUYXSHPJLHM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x408B730", Offset = "0x408A530", VA = "0x18408B730")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x408B5C0", Offset = "0x408A3C0", VA = "0x18408B5C0")]
		public static byte[] Serialize<T>(T value, PUYXSHPJLHM resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x408BD10", Offset = "0x408AB10", VA = "0x18408BD10")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x408BBA0", Offset = "0x408A9A0", VA = "0x18408BBA0")]
		public static string ToJsonString<T>(T value, PUYXSHPJLHM resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x408AE00", Offset = "0x4089C00", VA = "0x18408AE00")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x408AFD0", Offset = "0x4089DD0", VA = "0x18408AFD0")]
		public static T Deserialize<T>(string json, PUYXSHPJLHM resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x408AD30", Offset = "0x4089B30", VA = "0x18408AD30")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x408B1D0", Offset = "0x4089FD0", VA = "0x18408B1D0")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, PUYXSHPJLHM resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x408A730", Offset = "0x4089530", VA = "0x18408A730")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x408A560", Offset = "0x4089360", VA = "0x18408A560")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, PUYXSHPJLHM resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA3CAD20", Offset = "0xA3C9B20", VA = "0x18A3CAD20")]
		public static byte[] OTRCZIXPGMT(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA350", Offset = "0xA3C9150", VA = "0x18A3CA350")]
		private static void HKYRMOWPGZR(JsonReader a, JsonWriter b, int c)
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
		public int JRCDBTMEMUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xF43220", Offset = "0xF42020", VA = "0x180F43220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6AE0", Offset = "0xA3C58E0", VA = "0x18A3C6AE0")]
		public void VWBLLVSZWRM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6A00", Offset = "0xA3C5800", VA = "0x18A3C6A00")]
		public static byte[] VHOMEHNBDMZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6410", Offset = "0xA3C5210", VA = "0x18A3C6410")]
		public static byte[] NGRPLMUVKYV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6280", Offset = "0xA3C5080", VA = "0x18A3C6280")]
		public static byte[] KVQSVHFTGUB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA3C67A0", Offset = "0xA3C55A0", VA = "0x18A3C67A0")]
		public static byte[] SZSMYLFHJAX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2AB33B0", Offset = "0x2AB21B0", VA = "0x182AB33B0")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6070", Offset = "0xA3C4E70", VA = "0x18A3C6070")]
		public ArraySegment<byte> FLXSSTPZSVP()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5EB0", Offset = "0xA3C4CB0", VA = "0x18A3C5EB0")]
		public byte[] CMKKVMDHXMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C69A0", Offset = "0xA3C57A0", VA = "0x18A3C69A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6190", Offset = "0xA3C4F90", VA = "0x18A3C6190")]
		public void IUVCFOTPUBN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA3B92F0", Offset = "0xA3B80F0", VA = "0x18A3B92F0")]
		public void BDOKWSZCPRQ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5E50", Offset = "0xA3C4C50", VA = "0x18A3C5E50")]
		public void BDOKWSZCPRQ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6240", Offset = "0xA3C5040", VA = "0x18A3C6240")]
		public void JOLPHVWXWBO(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4E92D30", Offset = "0x4E91B30", VA = "0x184E92D30")]
		public void JUWEMKXEEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4E92CE0", Offset = "0x4E91AE0", VA = "0x184E92CE0")]
		public void BZZYLRTCCRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x511CAB0", Offset = "0x511B8B0", VA = "0x18511CAB0")]
		public void FIPJVNQHNEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x511CBA0", Offset = "0x511B9A0", VA = "0x18511CBA0")]
		public void TFLWAPGKQLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4E92D80", Offset = "0x4E91B80", VA = "0x184E92D80")]
		public void QXIXEYOQQII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x511CA60", Offset = "0x511B860", VA = "0x18511CA60")]
		public void BECHOJJLCPY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6530", Offset = "0xA3C5330", VA = "0x18A3C6530")]
		public void NXTESYKDEPU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA3C66B0", Offset = "0xA3C54B0", VA = "0x18A3C66B0")]
		public void QWDNROPQIEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4E92DD0", Offset = "0x4E91BD0", VA = "0x184E92DD0")]
		public void XXTYTZNTRXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8C88F10", Offset = "0x8C87D10", VA = "0x188C88F10")]
		public void XFNBROEJVQA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6700", Offset = "0xA3C5500", VA = "0x18A3C6700")]
		public void SYIYCWFXPEA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6110", Offset = "0xA3C4F10", VA = "0x18A3C6110")]
		public void HXLEGCUWDTD(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6640", Offset = "0xA3C5440", VA = "0x18A3C6640")]
		public void PHVJALDVLQW(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5DE0", Offset = "0xA3C4BE0", VA = "0x18A3C5DE0")]
		public void BCZVYXIZWKL(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C65D0", Offset = "0xA3C53D0", VA = "0x18A3C65D0")]
		public void PEIFWHZFBVD(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6210", Offset = "0xA3C5010", VA = "0x18A3C6210")]
		public void JAHXJHZNNZM(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C63A0", Offset = "0xA3C51A0", VA = "0x18A3C63A0")]
		public void MRTFEVRUCUT(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA3C61A0", Offset = "0xA3C4FA0", VA = "0x18A3C61A0")]
		public void IZJSEXFBYHU(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6AF0", Offset = "0xA3C58F0", VA = "0x18A3C6AF0")]
		public void VZEAKXTBUJK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6040", Offset = "0xA3C4E40", VA = "0x18A3C6040")]
		public void DVRAGHIAAFB(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6B60", Offset = "0xA3C5960", VA = "0x18A3C6B60")]
		public void ZUQIIUYABXP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6920", Offset = "0xA3C5720", VA = "0x18A3C6920")]
		private static bool TNUGTUEEZXL(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6780", Offset = "0xA3C5580", VA = "0x18A3C6780")]
		private static byte SZDZLVVLDHF(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA3B9350", Offset = "0xA3B8150", VA = "0x18A3B9350")]
		private static void UKDSWPBSUYQ(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class ZHYTGXXULKB : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7D0A750", Offset = "0x7D09550", VA = "0x187D0A750")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private ZHYTGXXULKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class IJMSKCCMIZU : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7D198F0", Offset = "0x7D186F0", VA = "0x187D198F0")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class DSLBALFNEJC
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> HSKJOHOKVNX;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA3BA050", Offset = "0xA3B8E50", VA = "0x18A3BA050")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private IJMSKCCMIZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class YLYLNTXNQQK : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x7CFCA70", Offset = "0x7CFB870", VA = "0x187CFCA70")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly YLYLNTXNQQK GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool MHMRDMQVAWC;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static GSCBNOMCLYY[] NARERNPECEG;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static PUYXSHPJLHM[] CWWIGTOYNGU;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private YLYLNTXNQQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC120", Offset = "0xA3CAF20", VA = "0x18A3CC120")]
		public static void CBYRPQCEVDS(params PUYXSHPJLHM[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC040", Offset = "0xA3CAE40", VA = "0x18A3CC040")]
		public static void CBYRPQCEVDS(params GSCBNOMCLYY[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC200", Offset = "0xA3CB000", VA = "0x18A3CC200")]
		public static void HBMUKNUDITC(GSCBNOMCLYY[] a, PUYXSHPJLHM[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class SXXJGDAARCN : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7D0B720", Offset = "0x7D0A520", VA = "0x187D0B720")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private SXXJGDAARCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class TSQFFHRZAXY
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly PUYXSHPJLHM DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly PUYXSHPJLHM SSMSHILTIEP;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class VIGNYLVAFMS
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly PUYXSHPJLHM DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly PUYXSHPJLHM HHOZMOEIHEZ;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly PUYXSHPJLHM KNFMAZIMNKT;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly PUYXSHPJLHM KTGIDNHLBMY;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly PUYXSHPJLHM INFPFQAKELA;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly PUYXSHPJLHM AYARAWNSBNC;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly PUYXSHPJLHM HTZNNQIIGLH;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly PUYXSHPJLHM XMMVXHHREYB;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly PUYXSHPJLHM LGLHKLWKUIP;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly PUYXSHPJLHM FVTZYPSSNXG;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly PUYXSHPJLHM WHLEMNLOZAG;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly PUYXSHPJLHM KSESJTGGURS;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class GIBWGFQQVNZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> HSKJOHOKVNX;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA3BC220", Offset = "0xA3BB020", VA = "0x18A3BC220")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3BDEA0", Offset = "0xA3BCCA0", VA = "0x18A3BDEA0")]
		private static object KJUXIVAUYUO(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class IGRPEEAVINF : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7D0A180", Offset = "0x7D08F80", VA = "0x187D0A180")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private IGRPEEAVINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class WMOQQIHKWFU : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x7D07AF0", Offset = "0x7D068F0", VA = "0x187D07AF0")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private WMOQQIHKWFU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class AFBASQYPMJY
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly PUYXSHPJLHM[] OUBBJBNSIUX;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class BEELBHOVDWF : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7CF7A00", Offset = "0x7CF6800", VA = "0x187CF7A00")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class KWVMJDMIPUR : PUYXSHPJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class USZXIMEOVJY<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x7D288A0", Offset = "0x7D276A0", VA = "0x187D288A0")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
			public NSYRGRINYUX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly NSYRGRINYUX<object> ZNCDKCJMNIX;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private BEELBHOVDWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class YVNWJMCJVLQ : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7D00D20", Offset = "0x7CFFB20", VA = "0x187D00D20")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class KWVMJDMIPUR : PUYXSHPJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class USZXIMEOVJY<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

				[Cpp2IlInjected.Token(Token = "0x60000C2")]
				[Cpp2IlInjected.Address(RVA = "0x7CEF0A0", Offset = "0x7CEDEA0", VA = "0x187CEF0A0")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
			public NSYRGRINYUX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly NSYRGRINYUX<object> ZNCDKCJMNIX;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private YVNWJMCJVLQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class FMZWKTKBARW : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7D00550", Offset = "0x7CFF350", VA = "0x187D00550")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class KWVMJDMIPUR : PUYXSHPJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class USZXIMEOVJY<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

				[Cpp2IlInjected.Token(Token = "0x60000CA")]
				[Cpp2IlInjected.Address(RVA = "0x7CEE8C0", Offset = "0x7CED6C0", VA = "0x187CEE8C0")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
			public NSYRGRINYUX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly NSYRGRINYUX<object> ZNCDKCJMNIX;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private FMZWKTKBARW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class MKOPYZCVIOD : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7D29210", Offset = "0x7D28010", VA = "0x187D29210")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class KWVMJDMIPUR : PUYXSHPJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class USZXIMEOVJY<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x7CF7020", Offset = "0x7CF5E20", VA = "0x187CF7020")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
			public NSYRGRINYUX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly NSYRGRINYUX<object> ZNCDKCJMNIX;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private MKOPYZCVIOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class IDKBOKBMSIZ : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7D24E70", Offset = "0x7D23C70", VA = "0x187D24E70")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class KWVMJDMIPUR : PUYXSHPJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class USZXIMEOVJY<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

				[Cpp2IlInjected.Token(Token = "0x60000DA")]
				[Cpp2IlInjected.Address(RVA = "0x7D04220", Offset = "0x7D03020", VA = "0x187D04220")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
			public NSYRGRINYUX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly NSYRGRINYUX<object> ZNCDKCJMNIX;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private IDKBOKBMSIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class NWLLTJMNANR : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7D22070", Offset = "0x7D20E70", VA = "0x187D22070")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class KWVMJDMIPUR : PUYXSHPJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class USZXIMEOVJY<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

				[Cpp2IlInjected.Token(Token = "0x60000E2")]
				[Cpp2IlInjected.Address(RVA = "0x7D15C70", Offset = "0x7D14A70", VA = "0x187D15C70")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
			public NSYRGRINYUX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly NSYRGRINYUX<object> ZNCDKCJMNIX;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private NWLLTJMNANR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class KQMFUILLPBM : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7D22BB0", Offset = "0x7D219B0", VA = "0x187D22BB0")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class KWVMJDMIPUR : PUYXSHPJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class USZXIMEOVJY<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

				[Cpp2IlInjected.Token(Token = "0x60000EA")]
				[Cpp2IlInjected.Address(RVA = "0x7D10250", Offset = "0x7D0F050", VA = "0x187D10250")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
			public NSYRGRINYUX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly NSYRGRINYUX<object> ZNCDKCJMNIX;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private KQMFUILLPBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class IPZFNYGXPUS : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x7CEE040", Offset = "0x7CECE40", VA = "0x187CEE040")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class KWVMJDMIPUR : PUYXSHPJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class USZXIMEOVJY<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

				[Cpp2IlInjected.Token(Token = "0x60000F2")]
				[Cpp2IlInjected.Address(RVA = "0x7D18C10", Offset = "0x7D17A10", VA = "0x187D18C10")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
			public NSYRGRINYUX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly NSYRGRINYUX<object> ZNCDKCJMNIX;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private IPZFNYGXPUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class ZMQQAOECLHC : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7D09E80", Offset = "0x7D08C80", VA = "0x187D09E80")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class KWVMJDMIPUR : PUYXSHPJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class USZXIMEOVJY<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

				[Cpp2IlInjected.Token(Token = "0x60000FA")]
				[Cpp2IlInjected.Address(RVA = "0x7CF6430", Offset = "0x7CF5230", VA = "0x187CF6430")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
			public NSYRGRINYUX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly NSYRGRINYUX<object> ZNCDKCJMNIX;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private ZMQQAOECLHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class ZZTZUNYYTKT : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7D0C8D0", Offset = "0x7D0B6D0", VA = "0x187D0C8D0")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class KWVMJDMIPUR : PUYXSHPJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class USZXIMEOVJY<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x7CEE760", Offset = "0x7CED560", VA = "0x187CEE760")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
			public NSYRGRINYUX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly NSYRGRINYUX<object> ZNCDKCJMNIX;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private ZZTZUNYYTKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class OKAPNIGFUGB : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7D1F4C0", Offset = "0x7D1E2C0", VA = "0x187D1F4C0")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class KWVMJDMIPUR : PUYXSHPJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class USZXIMEOVJY<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x7CEDEE0", Offset = "0x7CECCE0", VA = "0x187CEDEE0")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
			public NSYRGRINYUX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly NSYRGRINYUX<object> ZNCDKCJMNIX;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private OKAPNIGFUGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class ZBJYYSGAWDB : PUYXSHPJLHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class USZXIMEOVJY<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x7CFC610", Offset = "0x7CFB410", VA = "0x187CFC610")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class KWVMJDMIPUR : PUYXSHPJLHM
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class USZXIMEOVJY<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly NSYRGRINYUX<a> JRPQZMTKFJT;

				[Cpp2IlInjected.Token(Token = "0x6000112")]
				[Cpp2IlInjected.Address(RVA = "0x7D000F0", Offset = "0x7CFEEF0", VA = "0x187D000F0")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
			public NSYRGRINYUX<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly NSYRGRINYUX<object> ZNCDKCJMNIX;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		private ZBJYYSGAWDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3360880", Offset = "0x335F680", VA = "0x183360880", Slot = "4")]
		public NSYRGRINYUX<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x745D030", Offset = "0x745BE30", VA = "0x18745D030")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x745CD40", Offset = "0x745BB40", VA = "0x18745CD40")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x745CFA0", Offset = "0x745BDA0", VA = "0x18745CFA0")]
		public T[] GVVLPKOYPSV()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class EHPIEBGKRUX<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int HFGITQICKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object GSFHBUDUELA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int ALPNKJZOFUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] BFPQLJDGPTK;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5AF20D0", Offset = "0x5AF0ED0", VA = "0x185AF20D0")]
		public EHPIEBGKRUX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5AF1D20", Offset = "0x5AF0B20", VA = "0x185AF1D20")]
		public a[] CQAUCMIHSTY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5AF1F50", Offset = "0x5AF0D50", VA = "0x185AF1F50")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class WLUILRKAMKX : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class QYOKFPUHNYX : IComparable<QYOKFPUHNYX>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class NIJCBOTCFAD : IEnumerable<QYOKFPUHNYX>, IEnumerable, IEnumerator<QYOKFPUHNYX>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int AKEYILDVZEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private QYOKFPUHNYX OCEUOVLOMMW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int AYLQLTGRUAA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public QYOKFPUHNYX XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int GQKQQFHGMTL;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private QYOKFPUHNYX HJZIEJILZFW
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object ELQJLQJBXAL
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
				[DebuggerHidden]
				public NIJCBOTCFAD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "7")]
				[DebuggerHidden]
				private void QRJGYHJVBJO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xA3C8430", Offset = "0xA3C7230", VA = "0x18A3C8430", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xA3C8550", Offset = "0xA3C7350", VA = "0x18A3C8550", Slot = "10")]
				[DebuggerHidden]
				private void QWPEWWNKZVD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xA3C84B0", Offset = "0xA3C72B0", VA = "0x18A3C84B0", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<QYOKFPUHNYX> OKECQXEFAUL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0xA3C84B0", Offset = "0xA3C72B0", VA = "0x18A3C84B0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator UJBMGYABLAM()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly QYOKFPUHNYX[] LTNTJLVSDVZ;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] WMJINWWEOIW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong XVKQGRWDPTO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int PGGBLURLEPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string IKUQEKARZCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private QYOKFPUHNYX[] PCOSWSGTLTD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] RVLBRKPNSOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int ZWFILALYVRC;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA3C8C90", Offset = "0xA3C7A90", VA = "0x18A3C8C90")]
			public QYOKFPUHNYX(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA3C8730", Offset = "0xA3C7530", VA = "0x18A3C8730")]
			public QYOKFPUHNYX Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA3C86D0", Offset = "0xA3C74D0", VA = "0x18A3C86D0")]
			public QYOKFPUHNYX Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA3C89E0", Offset = "0xA3C77E0", VA = "0x18A3C89E0")]
			public QYOKFPUHNYX JITHPHEZQCZ(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA3C8B50", Offset = "0xA3C7950", VA = "0x18A3C8B50")]
			internal static int MPNOZZBDLVO(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA3C89B0", Offset = "0xA3C77B0", VA = "0x18A3C89B0", Slot = "4")]
			public int CompareTo(QYOKFPUHNYX other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xA3C8930", Offset = "0xA3C7730", VA = "0x18A3C8930")]
			[IteratorStateMachine(typeof(NIJCBOTCFAD))]
			public IEnumerable<QYOKFPUHNYX> BIOLGOTVRBX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class LLMDGPZJIIJ : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<QYOKFPUHNYX> PCOSWSGTLTD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<QYOKFPUHNYX> BIPCZMLZDIU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<QYOKFPUHNYX> ULWCKXMDKCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private QYOKFPUHNYX QPEIITLLBIU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> ULLOQJYIRFJ;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> EVAFWXQFGEK
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0xD7BBF0", Offset = "0xD7A9F0", VA = "0x180D7BBF0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000139")]
				[Cpp2IlInjected.Address(RVA = "0xA3C7C10", Offset = "0xA3C6A10", VA = "0x18A3C7C10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1D13E20", Offset = "0x1D12C20", VA = "0x181D13E20")]
			[DebuggerHidden]
			public LLMDGPZJIIJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xA3C8160", Offset = "0xA3C6F60", VA = "0x18A3C8160", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xA3C7C60", Offset = "0xA3C6A60", VA = "0x18A3C7C60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xA3C8340", Offset = "0xA3C7140", VA = "0x18A3C8340")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA3C82F0", Offset = "0xA3C70F0", VA = "0x18A3C82F0")]
			private void RHHWHJORETB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA3C82B0", Offset = "0xA3C70B0", VA = "0x18A3C82B0", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xA3C80C0", Offset = "0xA3C6EC0", VA = "0x18A3C80C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> OHIDLCUYPLL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xA3C80C0", Offset = "0xA3C6EC0", VA = "0x18A3C80C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly QYOKFPUHNYX NEXPSVAOOPT;

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA3CBF60", Offset = "0xA3CAD60", VA = "0x18A3CBF60")]
		public WLUILRKAMKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA3CB790", Offset = "0xA3CA590", VA = "0x18A3CB790")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA3CBE50", Offset = "0xA3CAC50", VA = "0x18A3CBE50")]
		public bool YOABBVTNACT(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA3CB9D0", Offset = "0xA3CA7D0", VA = "0x18A3CB9D0")]
		public bool HNGZAMRTXLY([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA3CBDC0", Offset = "0xA3CABC0", VA = "0x18A3CBDC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA3CBAE0", Offset = "0xA3CA8E0", VA = "0x18A3CBAE0")]
		private static void ISCLWUBYPBE(IEnumerable<QYOKFPUHNYX> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA3CB970", Offset = "0xA3CA770", VA = "0x18A3CB970", Slot = "5")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA3CB970", Offset = "0xA3CA770", VA = "0x18A3CB970", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA3CB710", Offset = "0xA3CA510", VA = "0x18A3CB710")]
		[IteratorStateMachine(typeof(LLMDGPZJIIJ))]
		private static IEnumerable<KeyValuePair<string, int>> AGURRWSXGAF(IEnumerable<QYOKFPUHNYX> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class RCMCHOARAFO
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo LYOYGPXHGYP;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C8D50", Offset = "0xA3C7B50", VA = "0x18A3C8D50")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C8F00", Offset = "0xA3C7D00", VA = "0x18A3C8F00")]
		public static ulong WDWTRYMXCNN(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class CXMPLBKGVZG
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA3B9D70", Offset = "0xA3B8B70", VA = "0x18A3B9D70")]
		public static void IUVCFOTPUBN(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA3B9EB0", Offset = "0xA3B8CB0", VA = "0x18A3B9EB0")]
		public static void PQSYHSGSNMP(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA3B9C30", Offset = "0xA3B8A30", VA = "0x18A3B9C30")]
		public static byte[] FGQYMRUPOXS(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class ZMCSPKAKPFO<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x5B72F10", Offset = "0x5B71D10", VA = "0x185B72F10", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class HICNJKSIRBK : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public ZMCSPKAKPFO<a> XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] ULWCKXMDKCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int ULGHTDELHUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] ULLOQJYIRFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int UKVTYPQQOXI;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> VDBZLDWCJVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xD7BBF0", Offset = "0xD7A9F0", VA = "0x180D7BBF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000153")]
				[Cpp2IlInjected.Address(RVA = "0x646E340", Offset = "0x646D140", VA = "0x18646E340", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
			[DebuggerHidden]
			public HICNJKSIRBK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x646EFB0", Offset = "0x646DDB0", VA = "0x18646EFB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "8")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] EJSKMCVVRGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong LQMYWACXLPQ;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool EJJCVEGJATZ;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5119AA0", Offset = "0x51188A0", VA = "0x185119AA0")]
		public ZMCSPKAKPFO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x51199B0", Offset = "0x51187B0", VA = "0x1851199B0")]
		public ZMCSPKAKPFO(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x51076D0", Offset = "0x51064D0", VA = "0x1851076D0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x510C9C0", Offset = "0x510B7C0", VA = "0x18510C9C0")]
		private bool OZJVNAPFSVK(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5111AD0", Offset = "0x51108D0", VA = "0x185111AD0")]
		public bool YOABBVTNACT([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5116090", Offset = "0x5114E90", VA = "0x185116090")]
		private static ulong YQSPDFVQJJT([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5117150", Offset = "0x5115F50", VA = "0x185117150")]
		private static ulong YQSPDFVQJJT([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5110D60", Offset = "0x510FB60", VA = "0x185110D60")]
		private static int QAFOSCCHNBR(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5107CD0", Offset = "0x5106AD0", VA = "0x185107CD0", Slot = "4")]
		[IteratorStateMachine(typeof(ZMCSPKAKPFO<>.HICNJKSIRBK))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5110D90", Offset = "0x510FB90", VA = "0x185110D90", Slot = "5")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class IDAQJQPKYWZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3AEAEB0", Offset = "0x3AE9CB0", VA = "0x183AEAEB0")]
		public static Func<a> ZNPZXNPRBWD<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3AEADF0", Offset = "0x3AE9BF0", VA = "0x183AEADF0")]
		private static c XQAXVZDDKIE<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0xA3BF1F0", Offset = "0xA3BDFF0", VA = "0x18A3BF1F0")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA3BF200", Offset = "0xA3BE000", VA = "0x18A3BF200")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA3BF060", Offset = "0xA3BDE60", VA = "0x18A3BF060")]
		private static byte WTKCFYLSTVC(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA3B7B30", Offset = "0xA3B6930", VA = "0x18A3B7B30")]
		private static byte TBLJMQIVUEM(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA3BE800", Offset = "0xA3BD600", VA = "0x18A3BE800")]
		public void JMVJVIOJCPK(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class IVJRCFTDKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2870", Offset = "0xA3C1670", VA = "0x18A3C2870")]
		public static bool YMRDCFJLEQM(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2880", Offset = "0xA3C1680", VA = "0x18A3C2880")]
		public static bool ZWOXWGPDNEV(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C22D0", Offset = "0xA3C10D0", VA = "0x18A3C22D0")]
		public static sbyte HLPURFSMSLO([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C25F0", Offset = "0xA3C13F0", VA = "0x18A3C25F0")]
		public static short OOWOQPQNOAV([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1A60", Offset = "0xA3C0860", VA = "0x18A3C1A60")]
		public static int ASKOFLJXBCL([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA3C27C0", Offset = "0xA3C15C0", VA = "0x18A3C27C0")]
		public static long UNPEDKIQBNK([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2140", Offset = "0xA3C0F40", VA = "0x18A3C2140")]
		public static bool DZSMYMBTAPT(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2330", Offset = "0xA3C1130", VA = "0x18A3C2330")]
		public static byte HZUHYQXJVSD([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2760", Offset = "0xA3C1560", VA = "0x18A3C2760")]
		public static ushort TZYEEDTTRSW([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2390", Offset = "0xA3C1190", VA = "0x18A3C2390")]
		public static uint IBGOBOJYXDO([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2450", Offset = "0xA3C1250", VA = "0x18A3C2450")]
		public static ulong NAMOPABBGQP([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1E20", Offset = "0xA3C0C20", VA = "0x18A3C1E20")]
		public static bool DDHEUHVIZOM(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1F70", Offset = "0xA3C0D70", VA = "0x18A3C1F70")]
		public static bool DKGIKASZWPA(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2650", Offset = "0xA3C1450", VA = "0x18A3C2650")]
		public static bool RIACILAJRPW(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1AC0", Offset = "0xA3C08C0", VA = "0x18A3C1AC0")]
		public static bool ATIXMJBFLBQ(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C2500", Offset = "0xA3C1300", VA = "0x18A3C2500")]
		public static float NWTDFUZJVLD([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1A00", Offset = "0xA3C0800", VA = "0x18A3C1A00")]
		public static bool AESFSSYASVY(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1D30", Offset = "0xA3C0B30", VA = "0x18A3C1D30")]
		public static double CQMEFQLEVDC([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C23F0", Offset = "0xA3C11F0", VA = "0x18A3C23F0")]
		public static bool JHRVCOEUYPB(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA3B87F0", Offset = "0xA3B75F0", VA = "0x18A3B87F0")]
		public static int JAHXJHZNNZM(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA3B7E30", Offset = "0xA3B6C30", VA = "0x18A3B7E30")]
		public static int DVRAGHIAAFB(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1B60", Offset = "0xA3C0960", VA = "0x18A3C1B60")]
		public static bool BQSQAMWZITN([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class AXFUPIAKRAW
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA3B9AE0", Offset = "0xA3B88E0", VA = "0x18A3B9AE0")]
		public static bool LSLARCROJRS(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class DOBOWKTFZAF
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding RCHRPDIVOLQ;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class HIMEVSLUFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA3C11A0", Offset = "0xA3BFFA0", VA = "0x18A3C11A0")]
		public static void RIMAEXIULJA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1210", Offset = "0xA3C0010", VA = "0x18A3C1210")]
		public static void RIRHCECRUUJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA3C10C0", Offset = "0xA3BFEC0", VA = "0x18A3C10C0")]
		public static void RIBMKJUZSMI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1130", Offset = "0xA3BFF30", VA = "0x18A3C1130")]
		public static void RIGTHQOXBXR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA3C13D0", Offset = "0xA3C01D0", VA = "0x18A3C13D0")]
		public static void RKXEYANOUPE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1440", Offset = "0xA3C0240", VA = "0x18A3C1440")]
		public static void RLCLVHHMEAN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C07F0", Offset = "0xA3BF5F0", VA = "0x18A3C07F0")]
		public static void ABPJZEVVKEX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0780", Offset = "0xA3BF580", VA = "0x18A3C0780")]
		public static void ABKDBYBYATO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C08E0", Offset = "0xA3BF6E0", VA = "0x18A3C08E0")]
		public static void ABZXTSJQDBP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0860", Offset = "0xA3BF660", VA = "0x18A3C0860")]
		public static void ABUQWLPSTQG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0600", Offset = "0xA3BF400", VA = "0x18A3C0600")]
		public static void AAUIKDUFYLN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0580", Offset = "0xA3BF380", VA = "0x18A3C0580")]
		public static void AAPBMXAIPAE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0700", Offset = "0xA3BF500", VA = "0x18A3C0700")]
		public static void ABEWERIARIF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0680", Offset = "0xA3BF480", VA = "0x18A3C0680")]
		public static void AAZPHKODHWW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA3C09D0", Offset = "0xA3BF7D0", VA = "0x18A3C09D0")]
		public static void ADFNDGZAHRR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0950", Offset = "0xA3BF750", VA = "0x18A3C0950")]
		public static void ADAGGAFCYGI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0DA0", Offset = "0xA3BFBA0", VA = "0x18A3C0DA0")]
		public static void GGAGGSJHQXG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0E20", Offset = "0xA3BFC20", VA = "0x18A3C0E20")]
		public static void GGFNDZDFAIP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0EA0", Offset = "0xA3BFCA0", VA = "0x18A3C0EA0")]
		public static void GGKUBFXCJTY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0F20", Offset = "0xA3BFD20", VA = "0x18A3C0F20")]
		public static void GGQAYMQZTFH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0B70", Offset = "0xA3BF970", VA = "0x18A3C0B70")]
		public static void GFFERRHSFDW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0BF0", Offset = "0xA3BF9F0", VA = "0x18A3C0BF0")]
		public static void GFKLOYBPOPF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0C80", Offset = "0xA3BFA80", VA = "0x18A3C0C80")]
		public static void GFPSMEVMYAO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0D10", Offset = "0xA3BFB10", VA = "0x18A3C0D10")]
		public static void GFUZJLPKHLX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0A50", Offset = "0xA3BF850", VA = "0x18A3C0A50")]
		public static void GEKDCQGCTKM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0AE0", Offset = "0xA3BF8E0", VA = "0x18A3C0AE0")]
		public static void GEPJZXAACVV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1030", Offset = "0xA3BFE30", VA = "0x18A3C1030")]
		public static void NGRLFKRKGPP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0FA0", Offset = "0xA3BFDA0", VA = "0x18A3C0FA0")]
		public static void NGMEIDXMXEG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1360", Offset = "0xA3C0160", VA = "0x18A3C1360")]
		public static void RJMIRFEHGNT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1280", Offset = "0xA3C0080", VA = "0x18A3C1280")]
		public static void RIWNZKWPEFS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA3C12F0", Offset = "0xA3C00F0", VA = "0x18A3C12F0")]
		public static void RJBUWRQMNRB(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class ZKJBWGTRBRQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD1D0", Offset = "0xA3CBFD0", VA = "0x18A3CD1D0")]
		public static void RKXEYANOUPE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD240", Offset = "0xA3CC040", VA = "0x18A3CD240")]
		public static void RLCLVHHMEAN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC980", Offset = "0xA3CB780", VA = "0x18A3CC980")]
		public static void ABPJZEVVKEX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC910", Offset = "0xA3CB710", VA = "0x18A3CC910")]
		public static void ABKDBYBYATO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCA60", Offset = "0xA3CB860", VA = "0x18A3CCA60")]
		public static void ABZXTSJQDBP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC9F0", Offset = "0xA3CB7F0", VA = "0x18A3CC9F0")]
		public static void ABUQWLPSTQG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC7B0", Offset = "0xA3CB5B0", VA = "0x18A3CC7B0")]
		public static void AAUIKDUFYLN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC740", Offset = "0xA3CB540", VA = "0x18A3CC740")]
		public static void AAPBMXAIPAE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC8A0", Offset = "0xA3CB6A0", VA = "0x18A3CC8A0")]
		public static void ABEWERIARIF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA3CC820", Offset = "0xA3CB620", VA = "0x18A3CC820")]
		public static void AAZPHKODHWW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCB50", Offset = "0xA3CB950", VA = "0x18A3CCB50")]
		public static void ADFNDGZAHRR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCAD0", Offset = "0xA3CB8D0", VA = "0x18A3CCAD0")]
		public static void ADAGGAFCYGI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCED0", Offset = "0xA3CBCD0", VA = "0x18A3CCED0")]
		public static void GGAGGSJHQXG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCF50", Offset = "0xA3CBD50", VA = "0x18A3CCF50")]
		public static void GGFNDZDFAIP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCFD0", Offset = "0xA3CBDD0", VA = "0x18A3CCFD0")]
		public static void GGKUBFXCJTY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD050", Offset = "0xA3CBE50", VA = "0x18A3CD050")]
		public static void GGQAYMQZTFH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCCD0", Offset = "0xA3CBAD0", VA = "0x18A3CCCD0")]
		public static void GFFERRHSFDW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCD50", Offset = "0xA3CBB50", VA = "0x18A3CCD50")]
		public static void GFKLOYBPOPF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCDD0", Offset = "0xA3CBBD0", VA = "0x18A3CCDD0")]
		public static void GFPSMEVMYAO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCE50", Offset = "0xA3CBC50", VA = "0x18A3CCE50")]
		public static void GFUZJLPKHLX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCBD0", Offset = "0xA3CB9D0", VA = "0x18A3CCBD0")]
		public static void GEKDCQGCTKM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA3CCC50", Offset = "0xA3CBA50", VA = "0x18A3CCC50")]
		public static void GEPJZXAACVV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD150", Offset = "0xA3CBF50", VA = "0x18A3CD150")]
		public static void NGRLFKRKGPP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD0D0", Offset = "0xA3CBED0", VA = "0x18A3CD0D0")]
		public static void NGMEIDXMXEG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1360", Offset = "0xA3C0160", VA = "0x18A3C1360")]
		public static void RJMIRFEHGNT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1280", Offset = "0xA3C0080", VA = "0x18A3C1280")]
		public static void RIWNZKWPEFS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA3C12F0", Offset = "0xA3C00F0", VA = "0x18A3C12F0")]
		public static void RJBUWRQMNRB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA3C11A0", Offset = "0xA3BFFA0", VA = "0x18A3C11A0")]
		public static void RIMAEXIULJA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1210", Offset = "0xA3C0010", VA = "0x18A3C1210")]
		public static void RIRHCECRUUJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA3C10C0", Offset = "0xA3BFEC0", VA = "0x18A3C10C0")]
		public static void RIBMKJUZSMI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1130", Offset = "0xA3BFF30", VA = "0x18A3C1130")]
		public static void RIGTHQOXBXR(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class ERYEIJTCIVC
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool EJJCVEGJATZ;

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA3D07C0", Offset = "0xA3CF5C0", VA = "0x18A3D07C0")]
		public static void BDOKWSZCPRQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2210", Offset = "0xA3D1010", VA = "0x18A3D2210")]
		public static void VPEUSTKLYFF(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x2B5E450", Offset = "0x2B5D250", VA = "0x182B5E450")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFF90", Offset = "0xA3CED90", VA = "0x18A3CFF90")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFDC0", Offset = "0xA3CEBC0", VA = "0x18A3CFDC0")]
		public static DiyFp GIBMSNZVJUP(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFE60", Offset = "0xA3CEC60", VA = "0x18A3CFE60")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFEF0", Offset = "0xA3CECF0", VA = "0x18A3CFEF0")]
		public static DiyFp QMWYAGCYAXD(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFE20", Offset = "0xA3CEC20", VA = "0x18A3CFE20")]
		public void LIXENUXBODC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFDD0", Offset = "0xA3CEBD0", VA = "0x18A3CFDD0")]
		public static DiyFp LIXENUXBODC(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xD9EB20", Offset = "0xD9D920", VA = "0x180D9EB20")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA3B92F0", Offset = "0xA3B80F0", VA = "0x18A3B92F0")]
		public void UCXRDEDUKNV(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0B60", Offset = "0xA3DF960", VA = "0x18A3E0B60")]
		public void ZASZTTDCDUV(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0A40", Offset = "0xA3DF840", VA = "0x18A3E0A40")]
		public void OSFGPPFGXOT(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0AC0", Offset = "0xA3DF8C0", VA = "0x18A3E0AC0")]
		public void OSFGPPFGXOT(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA3E08C0", Offset = "0xA3DF6C0", VA = "0x18A3E08C0")]
		public void DDJZCXUQWUF(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0940", Offset = "0xA3DF740", VA = "0x18A3E0940")]
		public void GBVRHPONOSA(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class GHONDDRWZJG
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
		private static byte[] DOQYTJAFOVH;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] QJOOJLRUFYZ;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] YGMMEPCPLFN;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] FYDEISUKUWQ;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags PQDEMQOXUQV;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char DUSOBPMOJQH;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int ZFBESPSCEXL;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int POCUCYFMDNF;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] FZVAXNOAJBT;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5B70", Offset = "0xA3D4970", VA = "0x18A3D5B70")]
		private static byte[] NODOMCNXSHN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5A90", Offset = "0xA3D4890", VA = "0x18A3D5A90")]
		private static byte[] KUOXMXNLVBZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA3D57A0", Offset = "0xA3D45A0", VA = "0x18A3D57A0")]
		public static int GXRVNCFILNA(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5680", Offset = "0xA3D4480", VA = "0x18A3D5680")]
		public static int GXRVNCFILNA(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5D30", Offset = "0xA3D4B30", VA = "0x18A3D5D30")]
		private static bool XVMKTZTZRCO(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5C40", Offset = "0xA3D4A40", VA = "0x18A3D5C40")]
		private static void VOJSRKLYZYK(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA3D50D0", Offset = "0xA3D3ED0", VA = "0x18A3D50D0")]
		private static bool GINSHDMMUQY(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3FA0", Offset = "0xA3D2DA0", VA = "0x18A3D3FA0")]
		private static bool AEQTBVWNYME(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5E20", Offset = "0xA3D4C20", VA = "0x18A3D5E20")]
		private static bool YPCQFAZTVNB(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA3D58C0", Offset = "0xA3D46C0", VA = "0x18A3D58C0")]
		private static bool HZKZAZBMHXK(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4850", Offset = "0xA3D3650", VA = "0x18A3D4850")]
		private static bool DUDBIAUTXOP(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4D30", Offset = "0xA3D3B30", VA = "0x18A3D4D30")]
		private static void FEVNJNGUKDH(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA3D4420", Offset = "0xA3D3220", VA = "0x18A3D4420")]
		private static void DHMYKCEEADT(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA3D5490", Offset = "0xA3D4290", VA = "0x18A3D5490")]
		private static bool GXGQYQGUBGY(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0xA3D05C0", Offset = "0xA3CF3C0", VA = "0x18A3D05C0")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0520", Offset = "0xA3CF320", VA = "0x18A3D0520")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0340", Offset = "0xA3CF140", VA = "0x18A3D0340")]
		public DiyFp OKKTKLJSMOT()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA3D03E0", Offset = "0xA3CF1E0", VA = "0x18A3D03E0")]
		public DiyFp RZIVHDLSHQU()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xEBF7B0", Offset = "0xEBE5B0", VA = "0x180EBF7B0")]
		public ulong JPRXLXYUYVF()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA3D02A0", Offset = "0xA3CF0A0", VA = "0x18A3D02A0")]
		public double MXMALVTTNMF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA3D01D0", Offset = "0xA3CEFD0", VA = "0x18A3D01D0")]
		public double EWBXBEEOIBH()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA3D03B0", Offset = "0xA3CF1B0", VA = "0x18A3D03B0")]
		public int OZBHFAQPXPA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0460", Offset = "0xA3CF260", VA = "0x18A3D0460")]
		public ulong SRHTTYYUAUM()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA3D04E0", Offset = "0xA3CF2E0", VA = "0x18A3D04E0")]
		public bool ZUYQGAGZABT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0500", Offset = "0xA3CF300", VA = "0x18A3D0500")]
		public bool ZVGASTSIHRG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0270", Offset = "0xA3CF070", VA = "0x18A3D0270")]
		public bool KVVUNHYUYHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0490", Offset = "0xA3CF290", VA = "0x18A3D0490")]
		public bool VBHAZEFUZJL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA3D04C0", Offset = "0xA3CF2C0", VA = "0x18A3D04C0")]
		public int VDINVYNRFYM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFFB0", Offset = "0xA3CEDB0", VA = "0x18A3CFFB0")]
		public void APZGEVCAXAW([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0180", Offset = "0xA3CEF80", VA = "0x18A3D0180")]
		public bool ENVAPDCXNWW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x4095210", Offset = "0x4094010", VA = "0x184095210")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0320", Offset = "0xA3CF120", VA = "0x18A3D0320")]
		public static int NKAPPIQZZSR(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFFA0", Offset = "0xA3CEDA0", VA = "0x18A3CFFA0")]
		public static double APFHFZZDUNT()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA3D00F0", Offset = "0xA3CEEF0", VA = "0x18A3D00F0")]
		public static ulong BSHAEGCLYGA(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x1853DE0", Offset = "0x1852BE0", VA = "0x181853DE0")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0810", Offset = "0xA3DF610", VA = "0x18A3E0810")]
		public DiyFp OKKTKLJSMOT()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xF430D0", Offset = "0xF41ED0", VA = "0x180F430D0")]
		public uint EJZKIDUYZJC()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0870", Offset = "0xA3DF670", VA = "0x18A3E0870")]
		public int OZBHFAQPXPA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0890", Offset = "0xA3DF690", VA = "0x18A3E0890")]
		public uint SRHTTYYUAUM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA3E08B0", Offset = "0xA3DF6B0", VA = "0x18A3E08B0")]
		public bool ZUYQGAGZABT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA3E06A0", Offset = "0xA3DF4A0", VA = "0x18A3E06A0")]
		public void APZGEVCAXAW([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA3E07D0", Offset = "0xA3DF5D0", VA = "0x18A3E07D0")]
		public bool ENVAPDCXNWW()
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
		[Cpp2IlInjected.Address(RVA = "0xA3CF180", Offset = "0xA3CDF80", VA = "0x18A3CF180")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class PVAAHIJINXD
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] BJWFYVIZHRQ;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD650", Offset = "0xA3DC450", VA = "0x18A3DD650")]
		public static void TMLDUYXXWKI(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD580", Offset = "0xA3DC380", VA = "0x18A3DD580")]
		public static void GSARXPHHRBR(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0xA3E5AC0", Offset = "0xA3E48C0", VA = "0x18A3E5AC0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4EAC780", Offset = "0x4EAB580", VA = "0x184EAC780")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2D946C0", Offset = "0x2D934C0", VA = "0x182D946C0")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5A60", Offset = "0xA3E4860", VA = "0x18A3E5A60")]
		public Vector BONVSOKVZFI(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class LWXSFYGYJUU
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] PSJLJZYGCRI;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] PPVEVKQRGMJ;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int ZRXLHKYBGRS;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9F30", Offset = "0xA3D8D30", VA = "0x18A3D9F30")]
		private static byte[] UDUHHUOMVSE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9430", Offset = "0xA3D8230", VA = "0x18A3D9430")]
		private static Vector HFZCHWKUBKM(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAA40", Offset = "0xA3D9840", VA = "0x18A3DAA40")]
		private static Vector ZLYEEPMUSIQ(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA3D93A0", Offset = "0xA3D81A0", VA = "0x18A3D93A0")]
		private static void EKWBQJOVPAJ(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9730", Offset = "0xA3D8530", VA = "0x18A3D9730")]
		private static void KMCTVDBIHZQ(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9510", Offset = "0xA3D8310", VA = "0x18A3D9510")]
		private static ulong HLRHDYFSQTR(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9DF0", Offset = "0xA3D8BF0", VA = "0x18A3D9DF0")]
		private static void QGKCQZYWNQT(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9A20", Offset = "0xA3D8820", VA = "0x18A3D9A20")]
		private static bool MARMKPNSAMG(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA3D95A0", Offset = "0xA3D83A0", VA = "0x18A3D95A0")]
		private static DiyFp JCSGVIYYTYB(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA010", Offset = "0xA3D8E10", VA = "0x18A3DA010")]
		private static bool UONGYNQGBHL(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9280", Offset = "0xA3D8080", VA = "0x18A3D9280")]
		private static bool CSSFGRCOFHR(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA650", Offset = "0xA3D9450", VA = "0x18A3DA650")]
		public static double? URPOTRQMYFJ(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA3DA770", Offset = "0xA3D9570", VA = "0x18A3DA770")]
		public static float? USACOFEHRCB(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class UBHLQXAGKFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] GRNOBKRZQHS;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] YGMMEPCPLFN;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] FYDEISUKUWQ;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] MCJLIGRWGES;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int RPQKOBNTTRY;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] OVMLLQMLUFY;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int UKOPLYJVQJU;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA3E31C0", Offset = "0xA3E1FC0", VA = "0x18A3E31C0")]
		private static byte[] FLXSSTPZSVP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2ED0", Offset = "0xA3E1CD0", VA = "0x18A3E2ED0")]
		public static bool AESFSSYASVY(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA3E32A0", Offset = "0xA3E20A0", VA = "0x18A3E32A0")]
		public static bool JHRVCOEUYPB(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA3E3080", Offset = "0xA3E1E80", VA = "0x18A3E3080")]
		private static bool DSBVLANEDWM(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA3E43D0", Offset = "0xA3E31D0", VA = "0x18A3E43D0")]
		private static bool MWKUFZBWWLR(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA3E46C0", Offset = "0xA3E34C0", VA = "0x18A3E46C0")]
		private static bool UZGDAATHHAU(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E3010", Offset = "0xA3E1E10", VA = "0x18A3E3010")]
		private static bool BTHEMVGQZXK(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E46A0", Offset = "0xA3E34A0", VA = "0x18A3E46A0")]
		private static double SWNZXZPYLHF(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E33E0", Offset = "0xA3E21E0", VA = "0x18A3E33E0")]
		private static double LNNTJQTESPP(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class AQBIZZPHDTF<a> : NSYRGRINYUX<a[]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly EHPIEBGKRUX<a> QVNRWWKOQSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour ABAGMCOFZSM;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1943D40", Offset = "0x1942B40", VA = "0x181943D40")]
		public AQBIZZPHDTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
		public AQBIZZPHDTF(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x71BC9D0", Offset = "0x71BB7D0", VA = "0x1871BC9D0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x71BC6A0", Offset = "0x71BB4A0", VA = "0x1871BC6A0", Slot = "5")]
		public a[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class KAQNUXKQTCE<a> : NSYRGRINYUX<ArraySegment<a>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly EHPIEBGKRUX<a> QVNRWWKOQSM;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6767020", Offset = "0x6765E20", VA = "0x186767020", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6766BD0", Offset = "0x67659D0", VA = "0x186766BD0", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class WYZVYJCVPWK<a> : NSYRGRINYUX<List<a>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour ABAGMCOFZSM;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1943D40", Offset = "0x1942B40", VA = "0x181943D40")]
		public WYZVYJCVPWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
		public WYZVYJCVPWK(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x85C15D0", Offset = "0x85C03D0", VA = "0x1885C15D0", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x85BDA30", Offset = "0x85BC830", VA = "0x1885BDA30", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class XFSYBCEWMWQ<a, b, c, d> : NSYRGRINYUX<d>, GSCBNOMCLYY where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x507EB50", Offset = "0x507D950", VA = "0x18507EB50", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x507D020", Offset = "0x507BE20", VA = "0x18507D020", Slot = "5")]
		public d Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c ZTZTLJRSSMY(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		protected XFSYBCEWMWQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class XFNRDVKZDLH<a, b, c> : XFSYBCEWMWQ<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x507CFB0", Offset = "0x507BDB0", VA = "0x18507CFB0", Slot = "6")]
		protected override IEnumerator<a> ZTZTLJRSSMY(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		protected XFNRDVKZDLH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class XFIKGORBTZY<a, b> : XFNRDVKZDLH<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD4BC60", Offset = "0xD4AA60", VA = "0x180D4BC60", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class AOIUZWMULZY<a, b> : XFIKGORBTZY<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x71BC110", Offset = "0x71BAF10", VA = "0x1871BC110", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x71BBFB0", Offset = "0x71BADB0", VA = "0x1871BBFB0", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class RHAWOLBQHXL<a> : XFSYBCEWMWQ<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7627530", Offset = "0x7626330", VA = "0x187627530", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD4BC60", Offset = "0xD4AA60", VA = "0x180D4BC60", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5093240", Offset = "0x5092040", VA = "0x185093240", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5093070", Offset = "0x5091E70", VA = "0x185093070", Slot = "6")]
		protected override LinkedList<a>.Enumerator ZTZTLJRSSMY(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class KZUNMEGHBTK<a> : XFSYBCEWMWQ<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x62A5D00", Offset = "0x62A4B00", VA = "0x1862A5D00", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x62A5DE0", Offset = "0x62A4BE0", VA = "0x1862A5DE0", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x67ABCF0", Offset = "0x67AAAF0", VA = "0x1867ABCF0", Slot = "6")]
		protected override Queue<a>.Enumerator ZTZTLJRSSMY(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xD4BC60", Offset = "0xD4AA60", VA = "0x180D4BC60", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class GRGNQCWFNEA<a> : XFSYBCEWMWQ<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x638A4A0", Offset = "0x63892A0", VA = "0x18638A4A0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x638A6D0", Offset = "0x63894D0", VA = "0x18638A6D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x638A700", Offset = "0x6389500", VA = "0x18638A700", Slot = "6")]
		protected override Stack<a>.Enumerator ZTZTLJRSSMY(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x638A570", Offset = "0x6389370", VA = "0x18638A570", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class MNOSSMAHTZG<a> : XFSYBCEWMWQ<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6ED7400", Offset = "0x6ED6200", VA = "0x186ED7400", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xD4BC60", Offset = "0xD4AA60", VA = "0x180D4BC60", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6ED7440", Offset = "0x6ED6240", VA = "0x186ED7440", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6ED74A0", Offset = "0x6ED62A0", VA = "0x186ED74A0", Slot = "6")]
		protected override HashSet<a>.Enumerator ZTZTLJRSSMY(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x62A2480", Offset = "0x62A1280", VA = "0x1862A2480")]
		public MNOSSMAHTZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class OEMNVVYIDYQ<a> : XFNRDVKZDLH<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x638A4A0", Offset = "0x63892A0", VA = "0x18638A4A0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7294BA0", Offset = "0x72939A0", VA = "0x187294BA0", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7294C30", Offset = "0x7293A30", VA = "0x187294C30", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class THLUZTZOWQV<a> : XFNRDVKZDLH<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x62A5D00", Offset = "0x62A4B00", VA = "0x1862A5D00", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x62A5DE0", Offset = "0x62A4BE0", VA = "0x1862A5DE0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xD4BC60", Offset = "0xD4AA60", VA = "0x180D4BC60", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class PSISEAWPMAZ<a> : XFNRDVKZDLH<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x62A5D00", Offset = "0x62A4B00", VA = "0x1862A5D00", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x62A5DE0", Offset = "0x62A4BE0", VA = "0x1862A5DE0", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xD4BC60", Offset = "0xD4AA60", VA = "0x180D4BC60", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class TNHTQQWURAH<a> : XFNRDVKZDLH<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x63919E0", Offset = "0x63907E0", VA = "0x1863919E0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x638A6D0", Offset = "0x63894D0", VA = "0x18638A6D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7A1A1B0", Offset = "0x7A18FB0", VA = "0x187A1A1B0", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6EEDBB0", Offset = "0x6EEC9B0", VA = "0x186EEDBB0")]
		public TNHTQQWURAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class FQQXLEMMEHF<a, b> : NSYRGRINYUX<IGrouping<a, b>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x62A8E80", Offset = "0x62A7C80", VA = "0x1862A8E80", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x62A8B30", Offset = "0x62A7930", VA = "0x1862A8B30", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class ZSBXQNCZSGW<a, b> : NSYRGRINYUX<ILookup<a, b>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5122040", Offset = "0x5120E40", VA = "0x185122040", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x5121D00", Offset = "0x5120B00", VA = "0x185121D00", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class QKXAKNWXUHQ<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a APYHZOACXVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> PERNOGOIGCM;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x4EAA7A0", Offset = "0x4EA95A0", VA = "0x184EAA7A0", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x75F44F0", Offset = "0x75F32F0", VA = "0x1875F44F0")]
		public QKXAKNWXUHQ(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x75F4480", Offset = "0x75F3280", VA = "0x1875F4480", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6652350", Offset = "0x6651150", VA = "0x186652350", Slot = "6")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class ACXRCQWLNLD<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> MCUWDIZANFL;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x71B6B90", Offset = "0x71B5990", VA = "0x1871B6B90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public ACXRCQWLNLD(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x71B6A00", Offset = "0x71B5800", VA = "0x1871B6A00", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x71B6AF0", Offset = "0x71B58F0", VA = "0x1871B6AF0", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x71B6AF0", Offset = "0x71B58F0", VA = "0x1871B6AF0", Slot = "7")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class HKTUKWNRKBM<a> : NSYRGRINYUX<a>, GSCBNOMCLYY where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x6472670", Offset = "0x6471470", VA = "0x186472670", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x6472460", Offset = "0x6471260", VA = "0x186472460", Slot = "5")]
		public a Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public HKTUKWNRKBM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class FJFIXUGTBQQ : NSYRGRINYUX<IEnumerable>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly NSYRGRINYUX<IEnumerable> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2FD0", Offset = "0xA3D1DD0", VA = "0x18A3D2FD0", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2DD0", Offset = "0xA3D1BD0", VA = "0x18A3D2DD0", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public FJFIXUGTBQQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class DEXFCSYJCMK : NSYRGRINYUX<ICollection>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly NSYRGRINYUX<ICollection> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF390", Offset = "0xA3CE190", VA = "0x18A3CF390", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF190", Offset = "0xA3CDF90", VA = "0x18A3CF190", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public DEXFCSYJCMK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class IUFKOHNZJKW : NSYRGRINYUX<IList>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly NSYRGRINYUX<IList> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D81A0", Offset = "0xA3D6FA0", VA = "0x18A3D81A0", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7FA0", Offset = "0xA3D6DA0", VA = "0x18A3D7FA0", Slot = "5")]
		public IList Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public IUFKOHNZJKW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class KSJRICNYUGV<a> : XFIKGORBTZY<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x62A5D00", Offset = "0x62A4B00", VA = "0x1862A5D00", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6472400", Offset = "0x6471200", VA = "0x186472400", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class HINFBSBMXIP<a> : XFNRDVKZDLH<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x62A5D00", Offset = "0x62A4B00", VA = "0x1862A5D00", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6472400", Offset = "0x6471200", VA = "0x186472400", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6472390", Offset = "0x6471190", VA = "0x186472390", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class GYCVLSUUKDN<a> : XFNRDVKZDLH<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6391A00", Offset = "0x6390800", VA = "0x186391A00", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x638A6D0", Offset = "0x63894D0", VA = "0x18638A6D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6391BA0", Offset = "0x63909A0", VA = "0x186391BA0", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6391BE0", Offset = "0x63909E0", VA = "0x186391BE0")]
		public GYCVLSUUKDN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class WKUUWCZFPVJ<a> : XFNRDVKZDLH<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6391A00", Offset = "0x6390800", VA = "0x186391A00", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x638A6D0", Offset = "0x63894D0", VA = "0x18638A6D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7A1A1B0", Offset = "0x7A18FB0", VA = "0x187A1A1B0", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6EEDBB0", Offset = "0x6EEC9B0", VA = "0x186EEDBB0")]
		public WKUUWCZFPVJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class XZTHNUYXOEV<a> : XFNRDVKZDLH<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5093160", Offset = "0x5091F60", VA = "0x185093160", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xD4BC60", Offset = "0xD4AA60", VA = "0x180D4BC60", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5093240", Offset = "0x5092040", VA = "0x185093240", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class FPQHQTYDVTR<a> : XFIKGORBTZY<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x62A5D00", Offset = "0x62A4B00", VA = "0x1862A5D00", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x62A5DE0", Offset = "0x62A4BE0", VA = "0x1862A5DE0", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class MISEMUHJIBO<a> : XFIKGORBTZY<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x62A5D00", Offset = "0x62A4B00", VA = "0x1862A5D00", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x62A5DE0", Offset = "0x62A4BE0", VA = "0x1862A5DE0", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class TODVRRSSCEJ<a> : XFNRDVKZDLH<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x638A4A0", Offset = "0x63892A0", VA = "0x18638A4A0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x638A6D0", Offset = "0x63894D0", VA = "0x18638A6D0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7A1D4A0", Offset = "0x7A1C2A0", VA = "0x187A1D4A0", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class UHMUWXUVRHW
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
		[Cpp2IlInjected.Address(RVA = "0xA3E4A50", Offset = "0xA3E3850", VA = "0x18A3E4A50")]
		public static DateTime CLECIKWEIEE(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4FB0", Offset = "0xA3E3DB0", VA = "0x18A3E4FB0")]
		public static bool RJABZSSOWBV(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4B10", Offset = "0xA3E3910", VA = "0x18A3E4B10")]
		public static bool EYUUEPKIPWD(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E4DA0", Offset = "0xA3E3BA0", VA = "0x18A3E4DA0")]
		public static bool EYUUEPKIPWD(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5160", Offset = "0xA3E3F60", VA = "0x18A3E5160")]
		public static bool WMWBAQSKNHT(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class TBBKXENEYMQ : NSYRGRINYUX<DateTime>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly NSYRGRINYUX<DateTime> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1160", Offset = "0xA3DFF60", VA = "0x18A3E1160", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0FE0", Offset = "0xA3DFDE0", VA = "0x18A3E0FE0", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0BE0", Offset = "0xA3DF9E0", VA = "0x18A3E0BE0")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public TBBKXENEYMQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class HJKODOSTGFP : NSYRGRINYUX<DateTimeOffset>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly NSYRGRINYUX<DateTimeOffset> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6A20", Offset = "0xA3D5820", VA = "0x18A3D6A20", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA3D65D0", Offset = "0xA3D53D0", VA = "0x18A3D65D0", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6640", Offset = "0xA3D5440", VA = "0x18A3D6640")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public HJKODOSTGFP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class QFQDQNNWGSI : NSYRGRINYUX<TimeSpan>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly NSYRGRINYUX<TimeSpan> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] DJVERBLEBNK;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA3DF400", Offset = "0xA3DE200", VA = "0x18A3DF400", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA3DEF90", Offset = "0xA3DDD90", VA = "0x18A3DEF90", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA3DF010", Offset = "0xA3DDE10", VA = "0x18A3DF010")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public QFQDQNNWGSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class HDVPOODZCZZ<a, b, c, d, e> : NSYRGRINYUX<e>, GSCBNOMCLYY where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6469130", Offset = "0x6467F30", VA = "0x186469130", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6463B20", Offset = "0x6462920", VA = "0x186463B20", Slot = "5")]
		public e Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d ZTZTLJRSSMY(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		protected HDVPOODZCZZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class HDQIRHKBTOQ<a, b, c, d> : HDVPOODZCZZ<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x507CFB0", Offset = "0x507BDB0", VA = "0x18507CFB0", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> ZTZTLJRSSMY(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		protected HDQIRHKBTOQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class HFBEYCTJHQB<a, b, c> : HDQIRHKBTOQ<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xD4BC60", Offset = "0xD4AA60", VA = "0x180D4BC60", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class XZGOGEVBZDJ<a, b> : HDVPOODZCZZ<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5092AE0", Offset = "0x50918E0", VA = "0x185092AE0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xD4BC60", Offset = "0xD4AA60", VA = "0x180D4BC60", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5092D20", Offset = "0x5091B20", VA = "0x185092D20", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5093010", Offset = "0x5091E10", VA = "0x185093010", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator ZTZTLJRSSMY(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x5093120", Offset = "0x5091F20", VA = "0x185093120")]
		public XZGOGEVBZDJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class ARLAGXIGPON<a, b, c> : HFBEYCTJHQB<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x71BD550", Offset = "0x71BC350", VA = "0x1871BD550", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x71BD730", Offset = "0x71BC530", VA = "0x1871BD730", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class IOZNQSOOVMM<a, b> : HDQIRHKBTOQ<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x5092BC0", Offset = "0x50919C0", VA = "0x185092BC0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x5092EA0", Offset = "0x5091CA0", VA = "0x185092EA0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xD4BC60", Offset = "0xD4AA60", VA = "0x180D4BC60", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class HYMQFUDYJMA<a, b> : HFBEYCTJHQB<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x5092BC0", Offset = "0x50919C0", VA = "0x185092BC0", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x5092EA0", Offset = "0x5091CA0", VA = "0x185092EA0", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class OJDVLHSWCOM<a, b> : HDVPOODZCZZ<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5092BC0", Offset = "0x50919C0", VA = "0x185092BC0", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xD4BC60", Offset = "0xD4AA60", VA = "0x180D4BC60", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x5092EA0", Offset = "0x5091CA0", VA = "0x185092EA0", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7299370", Offset = "0x7298170", VA = "0x187299370", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator ZTZTLJRSSMY(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class QZLINXEVERD<a, b> : HDQIRHKBTOQ<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x5092BC0", Offset = "0x50919C0", VA = "0x185092BC0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7600320", Offset = "0x75FF120", VA = "0x187600320", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7600390", Offset = "0x75FF190", VA = "0x187600390", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class FGQYOTVYFLM<a, b> : HDQIRHKBTOQ<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x62A2380", Offset = "0x62A1180", VA = "0x1862A2380", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD4BC60", Offset = "0xD4AA60", VA = "0x180D4BC60", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x62A23C0", Offset = "0x62A11C0", VA = "0x1862A23C0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x62A2480", Offset = "0x62A1280", VA = "0x1862A2480")]
		public FGQYOTVYFLM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class HLUCTYUOAUM<a, b> : HFBEYCTJHQB<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6472A10", Offset = "0x6471810", VA = "0x186472A10", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5092EA0", Offset = "0x5091CA0", VA = "0x185092EA0", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class ZZTKWJVAYKO<a> : NSYRGRINYUX<a>, GSCBNOMCLYY where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x51314C0", Offset = "0x51302C0", VA = "0x1851314C0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x5131290", Offset = "0x5130090", VA = "0x185131290", Slot = "5")]
		public a Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public ZZTKWJVAYKO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class KHYRFAPDIZI : NSYRGRINYUX<IDictionary>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly NSYRGRINYUX<IDictionary> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8980", Offset = "0xA3D7780", VA = "0x18A3D8980", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA3D87A0", Offset = "0xA3D75A0", VA = "0x18A3D87A0", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public KHYRFAPDIZI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class BFLYZCLGGMW
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDCD0", Offset = "0xA3CCAD0", VA = "0x18A3CDCD0")]
		public static object HGQXVVOKXTG(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA3CE4F0", Offset = "0xA3CD2F0", VA = "0x18A3CE4F0")]
		public static object OVABNZRRKLL(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class YVUGLMBYFMJ<a> : NSYRGRINYUX<a>, GSCBNOMCLYY, XVTXOBOXPXQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class FXRJPUNQTQT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type XIFUWJIDDEF;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FXRJPUNQTQT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x62AF9F0", Offset = "0x62AE7F0", VA = "0x1862AF9F0")]
			internal bool YVIUNJZXECY(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class FXMCSNTTKFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string MPQODAJQAZF;

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FXMCSNTTKFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x62ADB30", Offset = "0x62AC930", VA = "0x1862ADB30")]
			internal bool YVOBKQTUNOH(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class FYBXKIBLMNL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> THHZBAPCDUQ;

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FYBXKIBLMNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x62B03D0", Offset = "0x62AF1D0", VA = "0x1862B03D0")]
			internal void YVTIHXNRWZQ(JsonWriter a, a b, PUYXSHPJLHM c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class FXWQNBHODCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> RWKVUZFFWHP;

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public FXWQNBHODCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x62AFE30", Offset = "0x62AEC30", VA = "0x1862AFE30")]
			internal a YVYPFEHPGKZ(JsonReader a, PUYXSHPJLHM b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly ZMCSPKAKPFO<a> FDDZDACHKPZ;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> VZSUYWRDVIZ;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> ZWHFCITBYBJ;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> CCKGSWPHREM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool BJCBIPEGRET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> DTOIXBVJCZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> QEENWDXLULB;

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x50B3510", Offset = "0x50B2310", VA = "0x1850B3510")]
		static YVUGLMBYFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x50CCE30", Offset = "0x50CBC30", VA = "0x1850CCE30")]
		public YVUGLMBYFMJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x50AAC80", Offset = "0x50A9A80", VA = "0x1850AAC80", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x50A6AB0", Offset = "0x50A58B0", VA = "0x1850A6AB0", Slot = "5")]
		public a Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x50AD430", Offset = "0x50AC230", VA = "0x1850AD430", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, a b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x50A9A50", Offset = "0x50A8850", VA = "0x1850A9A50", Slot = "7")]
		public a NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class BFGVSVBEQRZ<a> : NSYRGRINYUX<a[,]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x4EB4210", Offset = "0x4EB3010", VA = "0x184EB4210", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x4EB3E80", Offset = "0x4EB2C80", VA = "0x184EB3E80", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public BFGVSVBEQRZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class JULBKVAPDVH<a> : NSYRGRINYUX<a[,,]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x6678450", Offset = "0x6677250", VA = "0x186678450", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x6677F80", Offset = "0x6676D80", VA = "0x186677F80", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public JULBKVAPDVH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class UKYDGMBEVCH<a> : NSYRGRINYUX<a[,,,]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7CD8280", Offset = "0x7CD7080", VA = "0x187CD8280", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7CD7C80", Offset = "0x7CD6A80", VA = "0x187CD7C80", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public UKYDGMBEVCH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class BXCMUEZDJIN<a> : NSYRGRINYUX<a?>, GSCBNOMCLYY where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x4EDDBD0", Offset = "0x4EDC9D0", VA = "0x184EDDBD0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x4EDD8B0", Offset = "0x4EDC6B0", VA = "0x184EDD8B0", Slot = "5")]
		public a? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public BXCMUEZDJIN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class LXJMRFJVIUD<a> : NSYRGRINYUX<a?>, GSCBNOMCLYY where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly NSYRGRINYUX<a> AQURPREWUMA;

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		public LXJMRFJVIUD(NSYRGRINYUX<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x68C8D10", Offset = "0x68C7B10", VA = "0x1868C8D10", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x68C85B0", Offset = "0x68C73B0", VA = "0x1868C85B0", Slot = "5")]
		public a? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class CWUHSRJANZU : NSYRGRINYUX<sbyte>, GSCBNOMCLYY, XVTXOBOXPXQ<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly CWUHSRJANZU DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA3CEF70", Offset = "0xA3CDD70", VA = "0x18A3CEF70", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA3CEEE0", Offset = "0xA3CDCE0", VA = "0x18A3CEEE0", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF000", Offset = "0xA3CDE00", VA = "0x18A3CF000", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, sbyte b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA3CEEF0", Offset = "0xA3CDCF0", VA = "0x18A3CEEF0", Slot = "7")]
		public sbyte NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public CWUHSRJANZU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class ZVQAPDZUNIL : NSYRGRINYUX<sbyte?>, GSCBNOMCLYY, XVTXOBOXPXQ<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly ZVQAPDZUNIL DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7830", Offset = "0xA3E6630", VA = "0x18A3E7830", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA3E76F0", Offset = "0xA3E64F0", VA = "0x18A3E76F0", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7920", Offset = "0xA3E6720", VA = "0x18A3E7920", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, sbyte? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7760", Offset = "0xA3E6560", VA = "0x18A3E7760", Slot = "7")]
		public sbyte? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public ZVQAPDZUNIL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class ZAKKHHNJKXL : NSYRGRINYUX<sbyte[]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly ZAKKHHNJKXL DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA3E71B0", Offset = "0xA3E5FB0", VA = "0x18A3E71B0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7070", Offset = "0xA3E5E70", VA = "0x18A3E7070", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public ZAKKHHNJKXL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class HKRQUMOTONT : NSYRGRINYUX<short>, GSCBNOMCLYY, XVTXOBOXPXQ<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly HKRQUMOTONT DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xA3D75B0", Offset = "0xA3D63B0", VA = "0x18A3D75B0", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7520", Offset = "0xA3D6320", VA = "0x18A3D7520", Slot = "5")]
		public short Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7640", Offset = "0xA3D6440", VA = "0x18A3D7640", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, short b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7530", Offset = "0xA3D6330", VA = "0x18A3D7530", Slot = "7")]
		public short NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public HKRQUMOTONT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class WLIGBZKWBCM : NSYRGRINYUX<short?>, GSCBNOMCLYY, XVTXOBOXPXQ<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly WLIGBZKWBCM DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6220", Offset = "0xA3E5020", VA = "0x18A3E6220", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA3E60E0", Offset = "0xA3E4EE0", VA = "0x18A3E60E0", Slot = "5")]
		public short? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6310", Offset = "0xA3E5110", VA = "0x18A3E6310", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, short? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6150", Offset = "0xA3E4F50", VA = "0x18A3E6150", Slot = "7")]
		public short? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public WLIGBZKWBCM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class FLKMSIPCLOI : NSYRGRINYUX<short[]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly FLKMSIPCLOI DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3830", Offset = "0xA3D2630", VA = "0x18A3D3830", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA3D36F0", Offset = "0xA3D24F0", VA = "0x18A3D36F0", Slot = "5")]
		public short[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public FLKMSIPCLOI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class OHNLSGLNSPR : NSYRGRINYUX<int>, GSCBNOMCLYY, XVTXOBOXPXQ<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly OHNLSGLNSPR DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBC00", Offset = "0xA3DAA00", VA = "0x18A3DBC00", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBB70", Offset = "0xA3DA970", VA = "0x18A3DBB70", Slot = "5")]
		public int Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBC90", Offset = "0xA3DAA90", VA = "0x18A3DBC90", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, int b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBB80", Offset = "0xA3DA980", VA = "0x18A3DBB80", Slot = "7")]
		public int NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public OHNLSGLNSPR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class RFQVRTHXCBA : NSYRGRINYUX<int?>, GSCBNOMCLYY, XVTXOBOXPXQ<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly RFQVRTHXCBA DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0060", Offset = "0xA3DEE60", VA = "0x18A3E0060", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFF20", Offset = "0xA3DED20", VA = "0x18A3DFF20", Slot = "5")]
		public int? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0150", Offset = "0xA3DEF50", VA = "0x18A3E0150", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, int? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFF90", Offset = "0xA3DED90", VA = "0x18A3DFF90", Slot = "7")]
		public int? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public RFQVRTHXCBA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class TFGWKIKRSJM : NSYRGRINYUX<int[]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly TFGWKIKRSJM DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1EC0", Offset = "0xA3E0CC0", VA = "0x18A3E1EC0", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA3E1D80", Offset = "0xA3E0B80", VA = "0x18A3E1D80", Slot = "5")]
		public int[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public TFGWKIKRSJM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class FFLHWVTLWQG : NSYRGRINYUX<long>, GSCBNOMCLYY, XVTXOBOXPXQ<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly FFLHWVTLWQG DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2530", Offset = "0xA3D1330", VA = "0x18A3D2530", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA3D24E0", Offset = "0xA3D12E0", VA = "0x18A3D24E0", Slot = "5")]
		public long Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2590", Offset = "0xA3D1390", VA = "0x18A3D2590", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, long b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA3D24F0", Offset = "0xA3D12F0", VA = "0x18A3D24F0", Slot = "7")]
		public long NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public FFLHWVTLWQG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class FJPWPTIPSWT : NSYRGRINYUX<long?>, GSCBNOMCLYY, XVTXOBOXPXQ<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly FJPWPTIPSWT DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3490", Offset = "0xA3D2290", VA = "0x18A3D3490", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3350", Offset = "0xA3D2150", VA = "0x18A3D3350", Slot = "5")]
		public long? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3550", Offset = "0xA3D2350", VA = "0x18A3D3550", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, long? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D33E0", Offset = "0xA3D21E0", VA = "0x18A3D33E0", Slot = "7")]
		public long? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public FJPWPTIPSWT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class PRVSCQNSHRX : NSYRGRINYUX<long[]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly PRVSCQNSHRX DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD350", Offset = "0xA3DC150", VA = "0x18A3DD350", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA3DD210", Offset = "0xA3DC010", VA = "0x18A3DD210", Slot = "5")]
		public long[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public PRVSCQNSHRX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class LTQCKEUKBBR : NSYRGRINYUX<byte>, GSCBNOMCLYY, XVTXOBOXPXQ<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly LTQCKEUKBBR DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9070", Offset = "0xA3D7E70", VA = "0x18A3D9070", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8FE0", Offset = "0xA3D7DE0", VA = "0x18A3D8FE0", Slot = "5")]
		public byte Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA3D9100", Offset = "0xA3D7F00", VA = "0x18A3D9100", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, byte b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8FF0", Offset = "0xA3D7DF0", VA = "0x18A3D8FF0", Slot = "7")]
		public byte NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public LTQCKEUKBBR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class QRIAQXJDXKU : NSYRGRINYUX<byte?>, GSCBNOMCLYY, XVTXOBOXPXQ<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly QRIAQXJDXKU DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFC60", Offset = "0xA3DEA60", VA = "0x18A3DFC60", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFB20", Offset = "0xA3DE920", VA = "0x18A3DFB20", Slot = "5")]
		public byte? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFD50", Offset = "0xA3DEB50", VA = "0x18A3DFD50", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, byte? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DFB90", Offset = "0xA3DE990", VA = "0x18A3DFB90", Slot = "7")]
		public byte? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public QRIAQXJDXKU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class ZVHUPKPAFIM : NSYRGRINYUX<ushort>, GSCBNOMCLYY, XVTXOBOXPXQ<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly ZVHUPKPAFIM DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA3E74E0", Offset = "0xA3E62E0", VA = "0x18A3E74E0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7450", Offset = "0xA3E6250", VA = "0x18A3E7450", Slot = "5")]
		public ushort Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7570", Offset = "0xA3E6370", VA = "0x18A3E7570", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, ushort b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7460", Offset = "0xA3E6260", VA = "0x18A3E7460", Slot = "7")]
		public ushort NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public ZVHUPKPAFIM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class HMWFXZSOFOT : NSYRGRINYUX<ushort?>, GSCBNOMCLYY, XVTXOBOXPXQ<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly HMWFXZSOFOT DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7CE0", Offset = "0xA3D6AE0", VA = "0x18A3D7CE0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7BA0", Offset = "0xA3D69A0", VA = "0x18A3D7BA0", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7DD0", Offset = "0xA3D6BD0", VA = "0x18A3D7DD0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, ushort? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7C10", Offset = "0xA3D6A10", VA = "0x18A3D7C10", Slot = "7")]
		public ushort? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public HMWFXZSOFOT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class HLXAUTVNHTB : NSYRGRINYUX<ushort[]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly HLXAUTVNHTB DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D7900", Offset = "0xA3D6700", VA = "0x18A3D7900", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D77C0", Offset = "0xA3D65C0", VA = "0x18A3D77C0", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public HLXAUTVNHTB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class WELGNLPJPXU : NSYRGRINYUX<uint>, GSCBNOMCLYY, XVTXOBOXPXQ<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly WELGNLPJPXU DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5D20", Offset = "0xA3E4B20", VA = "0x18A3E5D20", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5C90", Offset = "0xA3E4A90", VA = "0x18A3E5C90", Slot = "5")]
		public uint Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5DB0", Offset = "0xA3E4BB0", VA = "0x18A3E5DB0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, uint b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5CA0", Offset = "0xA3E4AA0", VA = "0x18A3E5CA0", Slot = "7")]
		public uint NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public WELGNLPJPXU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class QDMAADDVVEF : NSYRGRINYUX<uint?>, GSCBNOMCLYY, XVTXOBOXPXQ<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly QDMAADDVVEF DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA3DECD0", Offset = "0xA3DDAD0", VA = "0x18A3DECD0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA3DEB90", Offset = "0xA3DD990", VA = "0x18A3DEB90", Slot = "5")]
		public uint? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DEDC0", Offset = "0xA3DDBC0", VA = "0x18A3DEDC0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, uint? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DEC00", Offset = "0xA3DDA00", VA = "0x18A3DEC00", Slot = "7")]
		public uint? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public QDMAADDVVEF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class DLNSSHXGCPX : NSYRGRINYUX<uint[]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly DLNSSHXGCPX DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF980", Offset = "0xA3CE780", VA = "0x18A3CF980", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA3CF840", Offset = "0xA3CE640", VA = "0x18A3CF840", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public DLNSSHXGCPX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class YRZDWIAQEAT : NSYRGRINYUX<ulong>, GSCBNOMCLYY, XVTXOBOXPXQ<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly YRZDWIAQEAT DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6ED0", Offset = "0xA3E5CD0", VA = "0x18A3E6ED0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6E80", Offset = "0xA3E5C80", VA = "0x18A3E6E80", Slot = "5")]
		public ulong Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6F30", Offset = "0xA3E5D30", VA = "0x18A3E6F30", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, ulong b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6E90", Offset = "0xA3E5C90", VA = "0x18A3E6E90", Slot = "7")]
		public ulong NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public YRZDWIAQEAT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class MYDQZXBATKU : NSYRGRINYUX<ulong?>, GSCBNOMCLYY, XVTXOBOXPXQ<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly MYDQZXBATKU DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB3D0", Offset = "0xA3DA1D0", VA = "0x18A3DB3D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB290", Offset = "0xA3DA090", VA = "0x18A3DB290", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB490", Offset = "0xA3DA290", VA = "0x18A3DB490", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, ulong? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB320", Offset = "0xA3DA120", VA = "0x18A3DB320", Slot = "7")]
		public ulong? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public MYDQZXBATKU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class APYTYUUXCRA : NSYRGRINYUX<ulong[]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly APYTYUUXCRA DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xA3CDAA0", Offset = "0xA3CC8A0", VA = "0x18A3CDAA0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA3CD960", Offset = "0xA3CC760", VA = "0x18A3CD960", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public APYTYUUXCRA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class FEWBUOZCVGN : NSYRGRINYUX<float>, GSCBNOMCLYY, XVTXOBOXPXQ<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly FEWBUOZCVGN DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2340", Offset = "0xA3D1140", VA = "0x18A3D2340", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA3D22F0", Offset = "0xA3D10F0", VA = "0x18A3D22F0", Slot = "5")]
		public float Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA3D23A0", Offset = "0xA3D11A0", VA = "0x18A3D23A0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, float b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2300", Offset = "0xA3D1100", VA = "0x18A3D2300", Slot = "7")]
		public float NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public FEWBUOZCVGN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class VLBEBSOFMZY : NSYRGRINYUX<float?>, GSCBNOMCLYY, XVTXOBOXPXQ<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly VLBEBSOFMZY DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xA3E56D0", Offset = "0xA3E44D0", VA = "0x18A3E56D0", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA3E55C0", Offset = "0xA3E43C0", VA = "0x18A3E55C0", Slot = "5")]
		public float? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5790", Offset = "0xA3E4590", VA = "0x18A3E5790", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, float? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5630", Offset = "0xA3E4430", VA = "0x18A3E5630", Slot = "7")]
		public float? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public VLBEBSOFMZY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class FYZDNEJETRS : NSYRGRINYUX<float[]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly FYZDNEJETRS DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3C10", Offset = "0xA3D2A10", VA = "0x18A3D3C10", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D3AD0", Offset = "0xA3D28D0", VA = "0x18A3D3AD0", Slot = "5")]
		public float[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public FYZDNEJETRS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class GRWJQMVNYXU : NSYRGRINYUX<double>, GSCBNOMCLYY, XVTXOBOXPXQ<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly GRWJQMVNYXU DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xA3D61C0", Offset = "0xA3D4FC0", VA = "0x18A3D61C0", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6170", Offset = "0xA3D4F70", VA = "0x18A3D6170", Slot = "5")]
		public double Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6220", Offset = "0xA3D5020", VA = "0x18A3D6220", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, double b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6180", Offset = "0xA3D4F80", VA = "0x18A3D6180", Slot = "7")]
		public double NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public GRWJQMVNYXU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class FFUKHQULEFD : NSYRGRINYUX<double?>, GSCBNOMCLYY, XVTXOBOXPXQ<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly FFUKHQULEFD DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2B70", Offset = "0xA3D1970", VA = "0x18A3D2B70", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2A30", Offset = "0xA3D1830", VA = "0x18A3D2A30", Slot = "5")]
		public double? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2C30", Offset = "0xA3D1A30", VA = "0x18A3D2C30", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, double? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2AC0", Offset = "0xA3D18C0", VA = "0x18A3D2AC0", Slot = "7")]
		public double? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public FFUKHQULEFD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class MTLRTQWZXNL : NSYRGRINYUX<double[]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly MTLRTQWZXNL DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAF10", Offset = "0xA3D9D10", VA = "0x18A3DAF10", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DADD0", Offset = "0xA3D9BD0", VA = "0x18A3DADD0", Slot = "5")]
		public double[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public MTLRTQWZXNL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class JNLTACXPVIT : NSYRGRINYUX<bool>, GSCBNOMCLYY, XVTXOBOXPXQ<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly JNLTACXPVIT DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8600", Offset = "0xA3D7400", VA = "0x18A3D8600", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA3D85B0", Offset = "0xA3D73B0", VA = "0x18A3D85B0", Slot = "5")]
		public bool Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA3D8660", Offset = "0xA3D7460", VA = "0x18A3D8660", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, bool b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA3D85C0", Offset = "0xA3D73C0", VA = "0x18A3D85C0", Slot = "7")]
		public bool NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public JNLTACXPVIT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class FFMKYJHIYCG : NSYRGRINYUX<bool?>, GSCBNOMCLYY, XVTXOBOXPXQ<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly FFMKYJHIYCG DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA3D27E0", Offset = "0xA3D15E0", VA = "0x18A3D27E0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA3D26D0", Offset = "0xA3D14D0", VA = "0x18A3D26D0", Slot = "5")]
		public bool? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xA3D28A0", Offset = "0xA3D16A0", VA = "0x18A3D28A0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, bool? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA3D2740", Offset = "0xA3D1540", VA = "0x18A3D2740", Slot = "7")]
		public bool? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public FFMKYJHIYCG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class QAXABEUHFJY : NSYRGRINYUX<bool[]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly QAXABEUHFJY DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA3DE800", Offset = "0xA3DD600", VA = "0x18A3DE800", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA3DE6C0", Offset = "0xA3DD4C0", VA = "0x18A3DE6C0", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public QAXABEUHFJY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class DQTGCKIOOQG : NSYRGRINYUX<byte[]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly NSYRGRINYUX<byte[]> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFC90", Offset = "0xA3CEA90", VA = "0x18A3CFC90", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA3CFC20", Offset = "0xA3CEA20", VA = "0x18A3CFC20", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public DQTGCKIOOQG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class GVQFLZCFWIR : NSYRGRINYUX<ArraySegment<byte>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly NSYRGRINYUX<ArraySegment<byte>> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6430", Offset = "0xA3D5230", VA = "0x18A3D6430", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA3D6360", Offset = "0xA3D5160", VA = "0x18A3D6360", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public GVQFLZCFWIR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class VVBBVNZITKR : NSYRGRINYUX<string>, GSCBNOMCLYY, XVTXOBOXPXQ<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly NSYRGRINYUX<string> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5930", Offset = "0xA3E4730", VA = "0x18A3E5930", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5920", Offset = "0xA3E4720", VA = "0x18A3E5920", Slot = "5")]
		public string Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5990", Offset = "0xA3E4790", VA = "0x18A3E5990", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, string b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5920", Offset = "0xA3E4720", VA = "0x18A3E5920", Slot = "7")]
		public string NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public VVBBVNZITKR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class RZYFMFUBYEU : NSYRGRINYUX<string[]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly RZYFMFUBYEU DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0470", Offset = "0xA3DF270", VA = "0x18A3E0470", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA3E0320", Offset = "0xA3DF120", VA = "0x18A3E0320", Slot = "5")]
		public string[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public RZYFMFUBYEU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class TQNDIUPORWJ : NSYRGRINYUX<char>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly TQNDIUPORWJ DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2190", Offset = "0xA3E0F90", VA = "0x18A3E2190", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2160", Offset = "0xA3E0F60", VA = "0x18A3E2160", Slot = "5")]
		public char Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public TQNDIUPORWJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class NHOSJXHTWUC : NSYRGRINYUX<char?>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly NHOSJXHTWUC DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB6F0", Offset = "0xA3DA4F0", VA = "0x18A3DB6F0", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB630", Offset = "0xA3DA430", VA = "0x18A3DB630", Slot = "5")]
		public char? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public NHOSJXHTWUC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class ZXVYZEADBWE : NSYRGRINYUX<char[]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly ZXVYZEADBWE DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7C80", Offset = "0xA3E6A80", VA = "0x18A3E7C80", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA3E7AF0", Offset = "0xA3E68F0", VA = "0x18A3E7AF0", Slot = "5")]
		public char[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public ZXVYZEADBWE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class TRAEHJSZTPE : NSYRGRINYUX<Guid>, GSCBNOMCLYY, XVTXOBOXPXQ<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly NSYRGRINYUX<Guid> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2380", Offset = "0xA3E1180", VA = "0x18A3E2380", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA3E22B0", Offset = "0xA3E10B0", VA = "0x18A3E22B0", Slot = "5")]
		public Guid Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA3E24F0", Offset = "0xA3E12F0", VA = "0x18A3E24F0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, Guid b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA3E2310", Offset = "0xA3E1110", VA = "0x18A3E2310", Slot = "7")]
		public Guid NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public TRAEHJSZTPE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class PCWHJNIXQIW : NSYRGRINYUX<decimal>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly NSYRGRINYUX<decimal> DOFDCVCRMAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool EINNIIOYOKE;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8726670", Offset = "0x8725470", VA = "0x188726670")]
		public PCWHJNIXQIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xFED840", Offset = "0xFEC640", VA = "0x180FED840")]
		public PCWHJNIXQIW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA3DCFC0", Offset = "0xA3DBDC0", VA = "0x18A3DCFC0", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA3DCDF0", Offset = "0xA3DBBF0", VA = "0x18A3DCDF0", Slot = "5")]
		public decimal Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class CHSAACTLKRP : NSYRGRINYUX<Uri>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly NSYRGRINYUX<Uri> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA3CED90", Offset = "0xA3CDB90", VA = "0x18A3CED90", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA3CED10", Offset = "0xA3CDB10", VA = "0x18A3CED10", Slot = "5")]
		public Uri Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public CHSAACTLKRP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class WHNVWMGSUHJ : NSYRGRINYUX<Version>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly NSYRGRINYUX<Version> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5FB0", Offset = "0xA3E4DB0", VA = "0x18A3E5FB0", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5F30", Offset = "0xA3E4D30", VA = "0x18A3E5F30", Slot = "5")]
		public Version Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public WHNVWMGSUHJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class HHQBDBARGJV<a, b> : NSYRGRINYUX<KeyValuePair<a, b>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x646DED0", Offset = "0x646CCD0", VA = "0x18646DED0", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x646DA00", Offset = "0x646C800", VA = "0x18646DA00", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class WCJYCPUTGNN : NSYRGRINYUX<StringBuilder>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly NSYRGRINYUX<StringBuilder> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5B80", Offset = "0xA3E4980", VA = "0x18A3E5B80", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5B00", Offset = "0xA3E4900", VA = "0x18A3E5B00", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public WCJYCPUTGNN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class OGGOEKZOXVT : NSYRGRINYUX<BitArray>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly NSYRGRINYUX<BitArray> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB980", Offset = "0xA3DA780", VA = "0x18A3DB980", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3DB860", Offset = "0xA3DA660", VA = "0x18A3DB860", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public OGGOEKZOXVT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class YAPTJBYXVVL : NSYRGRINYUX<Type>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly YAPTJBYXVVL DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex BITEBSKUTBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool BDONXUSLISW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool ZMFWPTDAIUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool JHAKDQRAXKY;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6980", Offset = "0xA3E5780", VA = "0x18A3E6980")]
		public YAPTJBYXVVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x96EC010", Offset = "0x96EAE10", VA = "0x1896EC010")]
		public YAPTJBYXVVL(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA3E67A0", Offset = "0xA3E55A0", VA = "0x18A3E67A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6690", Offset = "0xA3E5490", VA = "0x18A3E6690", Slot = "5")]
		public Type Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class MLPBIPZUSJL : NSYRGRINYUX<BigInteger>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly NSYRGRINYUX<BigInteger> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA3DAC90", Offset = "0xA3D9A90", VA = "0x18A3DAC90", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA3DABE0", Offset = "0xA3D99E0", VA = "0x18A3DABE0", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public MLPBIPZUSJL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class VJPHJSCUOIX : NSYRGRINYUX<Complex>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly NSYRGRINYUX<Complex> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5420", Offset = "0xA3E4220", VA = "0x18A3E5420", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA3E5390", Offset = "0xA3E4190", VA = "0x18A3E5390", Slot = "5")]
		public Complex Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public VJPHJSCUOIX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class YKYXYZWQHYJ : NSYRGRINYUX<ExpandoObject>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly NSYRGRINYUX<ExpandoObject> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6D80", Offset = "0xA3E5B80", VA = "0x18A3E6D80", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA3E6B50", Offset = "0xA3E5950", VA = "0x18A3E6B50", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public YKYXYZWQHYJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class HOOZCKBZDSU<a> : NSYRGRINYUX<Lazy<a>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x64744E0", Offset = "0x64732E0", VA = "0x1864744E0", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x64742F0", Offset = "0x64730F0", VA = "0x1864742F0", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class ERRZUEMSNEE : NSYRGRINYUX<Task>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly NSYRGRINYUX<Task> DOFDCVCRMAS;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task QEHSXWMYYRB;

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0680", Offset = "0xA3CF480", VA = "0x18A3D0680", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA3D05D0", Offset = "0xA3CF3D0", VA = "0x18A3D05D0", Slot = "5")]
		public Task Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public ERRZUEMSNEE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class OLVNIKOIRQC<a> : NSYRGRINYUX<Task<a>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x729B6D0", Offset = "0x729A4D0", VA = "0x18729B6D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x729B4E0", Offset = "0x729A2E0", VA = "0x18729B4E0", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class FKVQJZYKRUA<a> : NSYRGRINYUX<ValueTask<a>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x62A3350", Offset = "0x62A2150", VA = "0x1862A3350", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x62A31B0", Offset = "0x62A1FB0", VA = "0x1862A31B0", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class JMXKYTHRAVY<a> : NSYRGRINYUX<Tuple<a>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x666FA70", Offset = "0x666E870", VA = "0x18666FA70", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x666F7A0", Offset = "0x666E5A0", VA = "0x18666F7A0", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class JMSEBMNTRKP<a, b> : NSYRGRINYUX<Tuple<a, b>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x666F280", Offset = "0x666E080", VA = "0x18666F280", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x666EE60", Offset = "0x666DC60", VA = "0x18666EE60", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class JMMXEFTWHZG<a, b, c> : NSYRGRINYUX<Tuple<a, b, c>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x666E7E0", Offset = "0x666D5E0", VA = "0x18666E7E0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x666E280", Offset = "0x666D080", VA = "0x18666E280", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class JMHQGYZYYNX<a, b, c, d> : NSYRGRINYUX<Tuple<a, b, c, d>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x666DA90", Offset = "0x666C890", VA = "0x18666DA90", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x666D3E0", Offset = "0x666C1E0", VA = "0x18666D3E0", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class JMCJJSGBPCO<a, b, c, d, e> : NSYRGRINYUX<Tuple<a, b, c, d, e>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x666CA90", Offset = "0x666B890", VA = "0x18666CA90", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x666C290", Offset = "0x666B090", VA = "0x18666C290", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class JLXCMLMEFRF<a, b, c, d, e, f> : NSYRGRINYUX<Tuple<a, b, c, d, e, f>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x666B7D0", Offset = "0x666A5D0", VA = "0x18666B7D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x666AE40", Offset = "0x6669C40", VA = "0x18666AE40", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class JLRVPESGWFW<a, b, c, d, e, f, g> : NSYRGRINYUX<Tuple<a, b, c, d, e, f, g>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x666A210", Offset = "0x6669010", VA = "0x18666A210", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x6669700", Offset = "0x6668500", VA = "0x186669700", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class JOSVACETHUB<a, b, c, d, e, f, g, h> : NSYRGRINYUX<Tuple<a, b, c, d, e, f, g, h>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x6675980", Offset = "0x6674780", VA = "0x186675980", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x6674D10", Offset = "0x6673B10", VA = "0x186674D10", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class EXBLNCMMSQR<a> : NSYRGRINYUX<ValueTuple<a>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x5B51370", Offset = "0x5B50170", VA = "0x185B51370", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x5B50F60", Offset = "0x5B4FD60", VA = "0x185B50F60", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class EWLQVIEUQIQ<a, b> : NSYRGRINYUX<(a, b)>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x5B4FCB0", Offset = "0x5B4EAB0", VA = "0x185B4FCB0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5B4F7D0", Offset = "0x5B4E5D0", VA = "0x185B4F7D0", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class EWQXSOYRZTZ<a, b, c> : NSYRGRINYUX<(a, b, c)>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x5B50870", Offset = "0x5B4F670", VA = "0x185B50870", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x5B50200", Offset = "0x5B4F000", VA = "0x185B50200", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class EXRGEWUEUYS<a, b, c, d> : NSYRGRINYUX<(a, b, c, d)>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5B55230", Offset = "0x5B54030", VA = "0x185B55230", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5B54A00", Offset = "0x5B53800", VA = "0x185B54A00", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class EXWNCDOCEKB<a, b, c, d, e> : NSYRGRINYUX<(a, b, c, d, e)>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5B56490", Offset = "0x5B55290", VA = "0x185B56490", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x5B55AE0", Offset = "0x5B548E0", VA = "0x185B55AE0", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class EXGSKJGKCCA<a, b, c, d, e, f> : NSYRGRINYUX<(a, b, c, d, e, f)>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x5B522F0", Offset = "0x5B510F0", VA = "0x185B522F0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x5B51730", Offset = "0x5B50530", VA = "0x185B51730", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class EXLZHQAHLNJ<a, b, c, d, e, f, g> : NSYRGRINYUX<(a, b, c, d, e, f, g)>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x5B53C50", Offset = "0x5B52A50", VA = "0x185B53C50", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x5B52EF0", Offset = "0x5B51CF0", VA = "0x185B52EF0", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class EYMHTXVUGSC<a, b, c, d, e, f, g, h> : NSYRGRINYUX<ValueTuple<a, b, c, d, e, f, g, h>>, GSCBNOMCLYY where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] RJEWVQOPUNP;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly WLUILRKAMKX NEVDAWWBIMJ;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5B583B0", Offset = "0x5B571B0", VA = "0x185B583B0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x5B57490", Offset = "0x5B56290", VA = "0x185B57490", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class YDFEUBTHVFH
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] VSPYSPMVDGL;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly WLUILRKAMKX LWGEOYANGKC;

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xA3E69A0", Offset = "0xA3E57A0", VA = "0x18A3E69A0")]
		static YDFEUBTHVFH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class WUFHIQCPBOP
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] TSULNZNEIAO;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly WLUILRKAMKX KDGTOEEPDZR;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xA3E64E0", Offset = "0xA3E52E0", VA = "0x18A3E64E0")]
		static WUFHIQCPBOP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class OTSULVWWSNL
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] XAZJAMXXNEP;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly WLUILRKAMKX NAGQXLCONKA;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] XBEPXTRUWPY;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly WLUILRKAMKX NAWLPFKGPSB;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] XBJWVALSGBH;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly WLUILRKAMKX NARERYQJGGS;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] XBPDSHFPPMQ;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly WLUILRKAMKX NBGZJSYBIOT;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] XBUKPNZMYXZ;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly WLUILRKAMKX NBBSMMEDZDK;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] XBZRMUTKIJI;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly WLUILRKAMKX NBRNEGLWBLL;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] XCEYKBNHRUR;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly WLUILRKAMKX NBMGGZRYSAC;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] XCKFHIHFBGA;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly WLUILRKAMKX MYVUQPTGZIP;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xA3DBE10", Offset = "0xA3DAC10", VA = "0x18A3DBE10")]
		static OTSULVWWSNL()
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
