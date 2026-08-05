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
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
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
		[Cpp2IlInjected.Address(RVA = "0x3923B00", Offset = "0x3922500", VA = "0x183923B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AEBFF0", Offset = "0x3AEA9F0", VA = "0x183AEBFF0")]
		public static NSYRGRINYUX<a> FVAAMOUCAVA<a>(this PUYXSHPJLHM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA53F140", Offset = "0xA53DB40", VA = "0x18A53F140")]
		public static object OPJTBAFUNIY(this PUYXSHPJLHM a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA53F330", Offset = "0xA53DD30", VA = "0x18A53F330")]
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
				[Cpp2IlInjected.Address(RVA = "0xA54C7F0", Offset = "0xA54B1F0", VA = "0x18A54C7F0")]
				public REEFIKXMCTH(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0xA54C6D0", Offset = "0xA54B0D0", VA = "0x18A54C6D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA54CDA0", Offset = "0xA54B7A0", VA = "0x18A54CDA0")]
			public void QNXJNWRYKZL([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA54CEB0", Offset = "0xA54B8B0", VA = "0x18A54CEB0")]
			public void QNXJNWRYKZL(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA54CA80", Offset = "0xA54B480", VA = "0x18A54CA80")]
			public ReadOnlySequence<byte> LVSMVTZOBCO()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xA54C8D0", Offset = "0xA54B2D0", VA = "0x18A54C8D0")]
			private void EIKIEMMJPVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA54CBB0", Offset = "0xA54B5B0", VA = "0x18A54CBB0")]
			private void LYFBIYCYTRC([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA548DB0", Offset = "0xA5477B0", VA = "0x18A548DB0")]
		public JsonReader([In] ReadOnlyMemory<byte> memory)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA548C40", Offset = "0xA547640", VA = "0x18A548C40")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA545F20", Offset = "0xA544920", VA = "0x18A545F20")]
		private JsonParsingException BWHTXEPHCEM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA545B40", Offset = "0xA544540", VA = "0x18A545B40")]
		private JsonParsingException ANEHVJRZHMX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA546930", Offset = "0xA545330", VA = "0x18A546930")]
		public JsonToken KBPBJDQMSPV()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA546270", Offset = "0xA544C70", VA = "0x18A546270")]
		public void BYYHJSUARPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA547C20", Offset = "0xA546620", VA = "0x18A547C20")]
		private bool TZMBIPIMUYZ(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA547C80", Offset = "0xA546680", VA = "0x18A547C80")]
		private bool TZMBIPIMUYZ(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA5485C0", Offset = "0xA546FC0", VA = "0x18A5485C0")]
		private void XSONAYUYQPG(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA547480", Offset = "0xA545E80", VA = "0x18A547480")]
		public bool RKLGMIQEOAA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA546910", Offset = "0xA545310", VA = "0x18A546910")]
		public void JENHOANKATY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA547780", Offset = "0xA546180", VA = "0x18A547780")]
		public bool RNTFAVMFLKP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA5465E0", Offset = "0xA544FE0", VA = "0x18A5465E0")]
		public void GJRUAOQUUYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA547200", Offset = "0xA545C00", VA = "0x18A547200")]
		public void QOMBKYNJJOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA548BF0", Offset = "0xA5475F0", VA = "0x18A548BF0")]
		public bool ZMCCTYOIWFD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA546540", Offset = "0xA544F40", VA = "0x18A546540")]
		public void ENFKXBALIGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA546550", Offset = "0xA544F50", VA = "0x18A546550")]
		public void FDQUYOYVYTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA547810", Offset = "0xA546210", VA = "0x18A547810")]
		public bool TGUKMANZAFK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA546B40", Offset = "0xA545540", VA = "0x18A546B40")]
		public bool KUEQPKJXTAH(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA548B60", Offset = "0xA547560", VA = "0x18A548B60")]
		public bool YYLCETMXPNE(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA547E00", Offset = "0xA546800", VA = "0x18A547E00")]
		public bool VYQRRWDUSJP(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA5480D0", Offset = "0xA546AD0", VA = "0x18A5480D0")]
		private ReadOnlySequence<byte> WNJHNYQTHLE()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA547210", Offset = "0xA545C10", VA = "0x18A547210")]
		private ReadOnlySequence<byte> QUABNUZDBHH()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA547EE0", Offset = "0xA5468E0", VA = "0x18A547EE0")]
		private void WDNJDTTYXDP(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA548670", Offset = "0xA547070", VA = "0x18A548670")]
		private void YALEPQHEJWE(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA548870", Offset = "0xA547270", VA = "0x18A548870")]
		private void YJFLCWQSKOX(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA546800", Offset = "0xA545200", VA = "0x18A546800")]
		private void IVIHWDQLGJE(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA53C3A0", Offset = "0xA53ADA0", VA = "0x18A53C3A0")]
		private static int QCICDZCDGLL(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA547130", Offset = "0xA545B30", VA = "0x18A547130")]
		public ReadOnlySequence<byte> ORTLPUYPRGX()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA546560", Offset = "0xA544F60", VA = "0x18A546560")]
		public string FZCCFRHFRYI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA5477D0", Offset = "0xA5461D0", VA = "0x18A5477D0")]
		public string RXHLIFIHGCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA545C50", Offset = "0xA544650", VA = "0x18A545C50")]
		public ReadOnlySequence<byte> AQYHIITYZWZ()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA5478A0", Offset = "0xA5462A0", VA = "0x18A5478A0")]
		public ReadOnlySequence<byte> TOFXOZBOSPI()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA545DD0", Offset = "0xA5447D0", VA = "0x18A545DD0")]
		public bool BQSQAMWZITN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA546C20", Offset = "0xA545620", VA = "0x18A546C20")]
		private void LOVSHEPGTPB(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA546920", Offset = "0xA545320", VA = "0x18A546920")]
		public void JWMLRAHHJUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA547540", Offset = "0xA545F40", VA = "0x18A547540")]
		private void RMKPNNFRZEC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA5465F0", Offset = "0xA544FF0", VA = "0x18A5465F0")]
		public sbyte HLPURFSMSLO()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA547080", Offset = "0xA545A80", VA = "0x18A547080")]
		public short OOWOQPQNOAV()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA545D20", Offset = "0xA544720", VA = "0x18A545D20")]
		public int ASKOFLJXBCL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA547D90", Offset = "0xA546790", VA = "0x18A547D90")]
		public long UNPEDKIQBNK()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA5466A0", Offset = "0xA5450A0", VA = "0x18A5466A0")]
		public byte HZUHYQXJVSD()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA547CE0", Offset = "0xA5466E0", VA = "0x18A547CE0")]
		public ushort TZYEEDTTRSW()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA546750", Offset = "0xA545150", VA = "0x18A546750")]
		public uint IBGOBOJYXDO()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA546D90", Offset = "0xA545790", VA = "0x18A546D90")]
		public ulong NAMOPABBGQP()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA546FE0", Offset = "0xA5459E0", VA = "0x18A546FE0")]
		public float NWTDFUZJVLD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA5464A0", Offset = "0xA544EA0", VA = "0x18A5464A0")]
		public double CQMEFQLEVDC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA546E00", Offset = "0xA545800", VA = "0x18A546E00")]
		public ReadOnlySequence<byte> NJYXZCXJXNX()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA547980", Offset = "0xA546380", VA = "0x18A547980")]
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
			[Cpp2IlInjected.Address(RVA = "0xFCC250", Offset = "0xFCAC50", VA = "0x180FCC250")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA545AE0", Offset = "0xA5444E0", VA = "0x18A545AE0")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA545A60", Offset = "0xA544460", VA = "0x18A545A60")]
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
			[Cpp2IlInjected.Address(RVA = "0xA54E7F0", Offset = "0xA54D1F0", VA = "0x18A54E7F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA54D3D0", Offset = "0xA54BDD0", VA = "0x18A54D3D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA54DE30", Offset = "0xA54C830", VA = "0x18A54DE30")]
		public static void MYSWNECCNPI(PUYXSHPJLHM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x40DC0E0", Offset = "0x40DAAE0", VA = "0x1840DC0E0")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x40DBF60", Offset = "0x40DA960", VA = "0x1840DBF60")]
		public static byte[] Serialize<T>(T value, PUYXSHPJLHM resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x40DC6E0", Offset = "0x40DB0E0", VA = "0x1840DC6E0")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x40DC560", Offset = "0x40DAF60", VA = "0x1840DC560")]
		public static string ToJsonString<T>(T value, PUYXSHPJLHM resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x40DB7A0", Offset = "0x40DA1A0", VA = "0x1840DB7A0")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x40DB970", Offset = "0x40DA370", VA = "0x1840DB970")]
		public static T Deserialize<T>(string json, PUYXSHPJLHM resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x40DB6D0", Offset = "0x40DA0D0", VA = "0x1840DB6D0")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x40DBB70", Offset = "0x40DA570", VA = "0x1840DBB70")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, PUYXSHPJLHM resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x40DB0D0", Offset = "0x40D9AD0", VA = "0x1840DB0D0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x40DAF00", Offset = "0x40D9900", VA = "0x1840DAF00")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, PUYXSHPJLHM resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA54DEA0", Offset = "0xA54C8A0", VA = "0x18A54DEA0")]
		public static byte[] OTRCZIXPGMT(byte[] a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA54D4D0", Offset = "0xA54BED0", VA = "0x18A54D4D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF86E20", Offset = "0xF85820", VA = "0x180F86E20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA549C60", Offset = "0xA548660", VA = "0x18A549C60")]
		public void VWBLLVSZWRM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA549B80", Offset = "0xA548580", VA = "0x18A549B80")]
		public static byte[] VHOMEHNBDMZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA549590", Offset = "0xA547F90", VA = "0x18A549590")]
		public static byte[] NGRPLMUVKYV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA549400", Offset = "0xA547E00", VA = "0x18A549400")]
		public static byte[] KVQSVHFTGUB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA549920", Offset = "0xA548320", VA = "0x18A549920")]
		public static byte[] SZSMYLFHJAX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2AF10F0", Offset = "0x2AEFAF0", VA = "0x182AF10F0")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA5491F0", Offset = "0xA547BF0", VA = "0x18A5491F0")]
		public ArraySegment<byte> FLXSSTPZSVP()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA549030", Offset = "0xA547A30", VA = "0x18A549030")]
		public byte[] CMKKVMDHXMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA549B20", Offset = "0xA548520", VA = "0x18A549B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA549310", Offset = "0xA547D10", VA = "0x18A549310")]
		public void IUVCFOTPUBN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA53C460", Offset = "0xA53AE60", VA = "0x18A53C460")]
		public void BDOKWSZCPRQ(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA548FD0", Offset = "0xA5479D0", VA = "0x18A548FD0")]
		public void BDOKWSZCPRQ(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA5493C0", Offset = "0xA547DC0", VA = "0x18A5493C0")]
		public void JOLPHVWXWBO(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4EDBAD0", Offset = "0x4EDA4D0", VA = "0x184EDBAD0")]
		public void JUWEMKXEEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4EDBA80", Offset = "0x4EDA480", VA = "0x184EDBA80")]
		public void BZZYLRTCCRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5176E90", Offset = "0x5175890", VA = "0x185176E90")]
		public void FIPJVNQHNEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5176F80", Offset = "0x5175980", VA = "0x185176F80")]
		public void TFLWAPGKQLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4EDBB20", Offset = "0x4EDA520", VA = "0x184EDBB20")]
		public void QXIXEYOQQII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5176E40", Offset = "0x5175840", VA = "0x185176E40")]
		public void BECHOJJLCPY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA5496B0", Offset = "0xA5480B0", VA = "0x18A5496B0")]
		public void NXTESYKDEPU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA549830", Offset = "0xA548230", VA = "0x18A549830")]
		public void QWDNROPQIEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4EDBB70", Offset = "0x4EDA570", VA = "0x184EDBB70")]
		public void XXTYTZNTRXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8E08D00", Offset = "0x8E07700", VA = "0x188E08D00")]
		public void XFNBROEJVQA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA549880", Offset = "0xA548280", VA = "0x18A549880")]
		public void SYIYCWFXPEA(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA549290", Offset = "0xA547C90", VA = "0x18A549290")]
		public void HXLEGCUWDTD(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA5497C0", Offset = "0xA5481C0", VA = "0x18A5497C0")]
		public void PHVJALDVLQW(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA548F60", Offset = "0xA547960", VA = "0x18A548F60")]
		public void BCZVYXIZWKL(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA549750", Offset = "0xA548150", VA = "0x18A549750")]
		public void PEIFWHZFBVD(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA549390", Offset = "0xA547D90", VA = "0x18A549390")]
		public void JAHXJHZNNZM(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA549520", Offset = "0xA547F20", VA = "0x18A549520")]
		public void MRTFEVRUCUT(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA549320", Offset = "0xA547D20", VA = "0x18A549320")]
		public void IZJSEXFBYHU(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA549C70", Offset = "0xA548670", VA = "0x18A549C70")]
		public void VZEAKXTBUJK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA5491C0", Offset = "0xA547BC0", VA = "0x18A5491C0")]
		public void DVRAGHIAAFB(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA549CE0", Offset = "0xA5486E0", VA = "0x18A549CE0")]
		public void ZUQIIUYABXP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA549AA0", Offset = "0xA5484A0", VA = "0x18A549AA0")]
		private static bool TNUGTUEEZXL(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA549900", Offset = "0xA548300", VA = "0x18A549900")]
		private static byte SZDZLVVLDHF(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA53C4C0", Offset = "0xA53AEC0", VA = "0x18A53C4C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E5C110", Offset = "0x7E5AB10", VA = "0x187E5C110")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private ZHYTGXXULKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E6B8F0", Offset = "0x7E6A2F0", VA = "0x187E6B8F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA53D1C0", Offset = "0xA53BBC0", VA = "0x18A53D1C0")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private IJMSKCCMIZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E4DE60", Offset = "0x7E4C860", VA = "0x187E4DE60")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private YLYLNTXNQQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA54F2A0", Offset = "0xA54DCA0", VA = "0x18A54F2A0")]
		public static void CBYRPQCEVDS(params PUYXSHPJLHM[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA54F1C0", Offset = "0xA54DBC0", VA = "0x18A54F1C0")]
		public static void CBYRPQCEVDS(params GSCBNOMCLYY[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA54F380", Offset = "0xA54DD80", VA = "0x18A54F380")]
		public static void HBMUKNUDITC(GSCBNOMCLYY[] a, PUYXSHPJLHM[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E5D140", Offset = "0x7E5BB40", VA = "0x187E5D140")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private SXXJGDAARCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53F390", Offset = "0xA53DD90", VA = "0x18A53F390")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA541010", Offset = "0xA53FA10", VA = "0x18A541010")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E5BB20", Offset = "0x7E5A520", VA = "0x187E5BB20")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private IGRPEEAVINF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E593A0", Offset = "0x7E57DA0", VA = "0x187E593A0")]
			static USZXIMEOVJY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly PUYXSHPJLHM GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private WMOQQIHKWFU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E48BC0", Offset = "0x7E475C0", VA = "0x187E48BC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E7AEF0", Offset = "0x7E798F0", VA = "0x187E7AEF0")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private BEELBHOVDWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E522A0", Offset = "0x7E50CA0", VA = "0x187E522A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E3FEB0", Offset = "0x7E3E8B0", VA = "0x187E3FEB0")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private YVNWJMCJVLQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E51AA0", Offset = "0x7E504A0", VA = "0x187E51AA0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E3F690", Offset = "0x7E3E090", VA = "0x187E3F690")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private FMZWKTKBARW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E7B8B0", Offset = "0x7E7A2B0", VA = "0x187E7B8B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E48180", Offset = "0x7E46B80", VA = "0x187E48180")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private MKOPYZCVIOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E77350", Offset = "0x7E75D50", VA = "0x187E77350")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E55910", Offset = "0x7E54310", VA = "0x187E55910")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private IDKBOKBMSIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E74450", Offset = "0x7E72E50", VA = "0x187E74450")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E67AD0", Offset = "0x7E664D0", VA = "0x187E67AD0")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private NWLLTJMNANR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E74FC0", Offset = "0x7E739C0", VA = "0x187E74FC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E61E60", Offset = "0x7E60860", VA = "0x187E61E60")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private KQMFUILLPBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E3EDC0", Offset = "0x7E3D7C0", VA = "0x187E3EDC0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E6ABA0", Offset = "0x7E695A0", VA = "0x187E6ABA0")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private IPZFNYGXPUS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E5B810", Offset = "0x7E5A210", VA = "0x187E5B810")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E47530", Offset = "0x7E45F30", VA = "0x187E47530")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private ZMQQAOECLHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E5E360", Offset = "0x7E5CD60", VA = "0x187E5E360")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E3F520", Offset = "0x7E3DF20", VA = "0x187E3F520")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private ZZTZUNYYTKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E71770", Offset = "0x7E70170", VA = "0x187E71770")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E3EC50", Offset = "0x7E3D650", VA = "0x187E3EC50")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private OKAPNIGFUGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E4D9E0", Offset = "0x7E4C3E0", VA = "0x187E4D9E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x7E51620", Offset = "0x7E50020", VA = "0x187E51620")]
				static USZXIMEOVJY()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly PUYXSHPJLHM GFQGJWBHKJM;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly PUYXSHPJLHM[] CWWIGTOYNGU;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			private KWVMJDMIPUR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		private ZBJYYSGAWDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x33A2640", Offset = "0x33A1040", VA = "0x1833A2640", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x758C5B0", Offset = "0x758AFB0", VA = "0x18758C5B0")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x758C2B0", Offset = "0x758ACB0", VA = "0x18758C2B0")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x758C520", Offset = "0x758AF20", VA = "0x18758C520")]
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
		[Cpp2IlInjected.Address(RVA = "0x5B894F0", Offset = "0x5B87EF0", VA = "0x185B894F0")]
		public EHPIEBGKRUX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5B89130", Offset = "0x5B87B30", VA = "0x185B89130")]
		public a[] CQAUCMIHSTY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5B89370", Offset = "0x5B87D70", VA = "0x185B89370")]
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
					[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "6")]
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
					[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x1031740", Offset = "0x1030140", VA = "0x181031740")]
				[DebuggerHidden]
				public NIJCBOTCFAD(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "7")]
				[DebuggerHidden]
				private void QRJGYHJVBJO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0xA54B5B0", Offset = "0xA549FB0", VA = "0x18A54B5B0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012E")]
				[Cpp2IlInjected.Address(RVA = "0xA54B6D0", Offset = "0xA54A0D0", VA = "0x18A54B6D0", Slot = "10")]
				[DebuggerHidden]
				private void QWPEWWNKZVD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000130")]
				[Cpp2IlInjected.Address(RVA = "0xA54B630", Offset = "0xA54A030", VA = "0x18A54B630", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<QYOKFPUHNYX> OKECQXEFAUL()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000131")]
				[Cpp2IlInjected.Address(RVA = "0xA54B630", Offset = "0xA54A030", VA = "0x18A54B630", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0xA54BE10", Offset = "0xA54A810", VA = "0x18A54BE10")]
			public QYOKFPUHNYX(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xA54B8B0", Offset = "0xA54A2B0", VA = "0x18A54B8B0")]
			public QYOKFPUHNYX Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA54B850", Offset = "0xA54A250", VA = "0x18A54B850")]
			public QYOKFPUHNYX Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA54BB60", Offset = "0xA54A560", VA = "0x18A54BB60")]
			public QYOKFPUHNYX JITHPHEZQCZ(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA54BCD0", Offset = "0xA54A6D0", VA = "0x18A54BCD0")]
			internal static int MPNOZZBDLVO(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA54BB30", Offset = "0xA54A530", VA = "0x18A54BB30", Slot = "4")]
			public int CompareTo(QYOKFPUHNYX other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xA54BAB0", Offset = "0xA54A4B0", VA = "0x18A54BAB0")]
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
				[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xA54AD90", Offset = "0xA549790", VA = "0x18A54AD90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1D4C250", Offset = "0x1D4AC50", VA = "0x181D4C250")]
			[DebuggerHidden]
			public LLMDGPZJIIJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xA54B2E0", Offset = "0xA549CE0", VA = "0x18A54B2E0", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0xA54ADE0", Offset = "0xA5497E0", VA = "0x18A54ADE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xA54B4C0", Offset = "0xA549EC0", VA = "0x18A54B4C0")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA54B470", Offset = "0xA549E70", VA = "0x18A54B470")]
			private void RHHWHJORETB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA54B430", Offset = "0xA549E30", VA = "0x18A54B430", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xA54B240", Offset = "0xA549C40", VA = "0x18A54B240", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> OHIDLCUYPLL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xA54B240", Offset = "0xA549C40", VA = "0x18A54B240", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA54F0E0", Offset = "0xA54DAE0", VA = "0x18A54F0E0")]
		public WLUILRKAMKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA54E910", Offset = "0xA54D310", VA = "0x18A54E910")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA54EFD0", Offset = "0xA54D9D0", VA = "0x18A54EFD0")]
		public bool YOABBVTNACT(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA54EB50", Offset = "0xA54D550", VA = "0x18A54EB50")]
		public bool HNGZAMRTXLY([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA54EF40", Offset = "0xA54D940", VA = "0x18A54EF40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA54EC60", Offset = "0xA54D660", VA = "0x18A54EC60")]
		private static void ISCLWUBYPBE(IEnumerable<QYOKFPUHNYX> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA54EAF0", Offset = "0xA54D4F0", VA = "0x18A54EAF0", Slot = "5")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA54EAF0", Offset = "0xA54D4F0", VA = "0x18A54EAF0", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA54E890", Offset = "0xA54D290", VA = "0x18A54E890")]
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
		[Cpp2IlInjected.Address(RVA = "0xA54BED0", Offset = "0xA54A8D0", VA = "0x18A54BED0")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA54C080", Offset = "0xA54AA80", VA = "0x18A54C080")]
		public static ulong WDWTRYMXCNN(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class CXMPLBKGVZG
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA53CEE0", Offset = "0xA53B8E0", VA = "0x18A53CEE0")]
		public static void IUVCFOTPUBN(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA53D020", Offset = "0xA53BA20", VA = "0x18A53D020")]
		public static void PQSYHSGSNMP(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA53CDA0", Offset = "0xA53B7A0", VA = "0x18A53CDA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5C0E310", Offset = "0x5C0CD10", VA = "0x185C0E310", Slot = "3")]
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
				[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6535C90", Offset = "0x6534690", VA = "0x186535C90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
			[DebuggerHidden]
			public HICNJKSIRBK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x6536920", Offset = "0x6535320", VA = "0x186536920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4F23E00", Offset = "0x4F22800", VA = "0x184F23E00", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x5173CE0", Offset = "0x51726E0", VA = "0x185173CE0")]
		public ZMCSPKAKPFO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5173BF0", Offset = "0x51725F0", VA = "0x185173BF0")]
		public ZMCSPKAKPFO(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5161360", Offset = "0x515FD60", VA = "0x185161360")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5166790", Offset = "0x5165190", VA = "0x185166790")]
		private bool OZJVNAPFSVK(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x516B9F0", Offset = "0x516A3F0", VA = "0x18516B9F0")]
		public bool YOABBVTNACT([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5170160", Offset = "0x516EB60", VA = "0x185170160")]
		private static ulong YQSPDFVQJJT([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x51712A0", Offset = "0x516FCA0", VA = "0x1851712A0")]
		private static ulong YQSPDFVQJJT([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x516AC30", Offset = "0x5169630", VA = "0x18516AC30")]
		private static int QAFOSCCHNBR(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5161970", Offset = "0x5160370", VA = "0x185161970", Slot = "4")]
		[IteratorStateMachine(typeof(ZMCSPKAKPFO<>.HICNJKSIRBK))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x516AC60", Offset = "0x5169660", VA = "0x18516AC60", Slot = "5")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class IDAQJQPKYWZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x3B31C90", Offset = "0x3B30690", VA = "0x183B31C90")]
		public static Func<a> ZNPZXNPRBWD<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3B31BD0", Offset = "0x3B305D0", VA = "0x183B31BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA542360", Offset = "0xA540D60", VA = "0x18A542360")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA542370", Offset = "0xA540D70", VA = "0x18A542370")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA5421D0", Offset = "0xA540BD0", VA = "0x18A5421D0")]
		private static byte WTKCFYLSTVC(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA53ACA0", Offset = "0xA5396A0", VA = "0x18A53ACA0")]
		private static byte TBLJMQIVUEM(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA541970", Offset = "0xA540370", VA = "0x18A541970")]
		public void JMVJVIOJCPK(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class IVJRCFTDKAQ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA5459E0", Offset = "0xA5443E0", VA = "0x18A5459E0")]
		public static bool YMRDCFJLEQM(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA5459F0", Offset = "0xA5443F0", VA = "0x18A5459F0")]
		public static bool ZWOXWGPDNEV(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA545440", Offset = "0xA543E40", VA = "0x18A545440")]
		public static sbyte HLPURFSMSLO([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA545760", Offset = "0xA544160", VA = "0x18A545760")]
		public static short OOWOQPQNOAV([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA544BD0", Offset = "0xA5435D0", VA = "0x18A544BD0")]
		public static int ASKOFLJXBCL([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA545930", Offset = "0xA544330", VA = "0x18A545930")]
		public static long UNPEDKIQBNK([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA5452B0", Offset = "0xA543CB0", VA = "0x18A5452B0")]
		public static bool DZSMYMBTAPT(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA5454A0", Offset = "0xA543EA0", VA = "0x18A5454A0")]
		public static byte HZUHYQXJVSD([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA5458D0", Offset = "0xA5442D0", VA = "0x18A5458D0")]
		public static ushort TZYEEDTTRSW([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA545500", Offset = "0xA543F00", VA = "0x18A545500")]
		public static uint IBGOBOJYXDO([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA5455C0", Offset = "0xA543FC0", VA = "0x18A5455C0")]
		public static ulong NAMOPABBGQP([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA544F90", Offset = "0xA543990", VA = "0x18A544F90")]
		public static bool DDHEUHVIZOM(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA5450E0", Offset = "0xA543AE0", VA = "0x18A5450E0")]
		public static bool DKGIKASZWPA(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA5457C0", Offset = "0xA5441C0", VA = "0x18A5457C0")]
		public static bool RIACILAJRPW(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA544C30", Offset = "0xA543630", VA = "0x18A544C30")]
		public static bool ATIXMJBFLBQ(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA545670", Offset = "0xA544070", VA = "0x18A545670")]
		public static float NWTDFUZJVLD([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA544B70", Offset = "0xA543570", VA = "0x18A544B70")]
		public static bool AESFSSYASVY(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA544EA0", Offset = "0xA5438A0", VA = "0x18A544EA0")]
		public static double CQMEFQLEVDC([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA545560", Offset = "0xA543F60", VA = "0x18A545560")]
		public static bool JHRVCOEUYPB(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA53B960", Offset = "0xA53A360", VA = "0x18A53B960")]
		public static int JAHXJHZNNZM(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA53AFA0", Offset = "0xA5399A0", VA = "0x18A53AFA0")]
		public static int DVRAGHIAAFB(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA544CD0", Offset = "0xA5436D0", VA = "0x18A544CD0")]
		public static bool BQSQAMWZITN([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class AXFUPIAKRAW
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA53CC50", Offset = "0xA53B650", VA = "0x18A53CC50")]
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
		[Cpp2IlInjected.Address(RVA = "0xA544310", Offset = "0xA542D10", VA = "0x18A544310")]
		public static void RIMAEXIULJA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA544380", Offset = "0xA542D80", VA = "0x18A544380")]
		public static void RIRHCECRUUJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA544230", Offset = "0xA542C30", VA = "0x18A544230")]
		public static void RIBMKJUZSMI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA5442A0", Offset = "0xA542CA0", VA = "0x18A5442A0")]
		public static void RIGTHQOXBXR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA544540", Offset = "0xA542F40", VA = "0x18A544540")]
		public static void RKXEYANOUPE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA5445B0", Offset = "0xA542FB0", VA = "0x18A5445B0")]
		public static void RLCLVHHMEAN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA543960", Offset = "0xA542360", VA = "0x18A543960")]
		public static void ABPJZEVVKEX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA5438F0", Offset = "0xA5422F0", VA = "0x18A5438F0")]
		public static void ABKDBYBYATO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA543A50", Offset = "0xA542450", VA = "0x18A543A50")]
		public static void ABZXTSJQDBP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA5439D0", Offset = "0xA5423D0", VA = "0x18A5439D0")]
		public static void ABUQWLPSTQG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA543770", Offset = "0xA542170", VA = "0x18A543770")]
		public static void AAUIKDUFYLN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA5436F0", Offset = "0xA5420F0", VA = "0x18A5436F0")]
		public static void AAPBMXAIPAE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA543870", Offset = "0xA542270", VA = "0x18A543870")]
		public static void ABEWERIARIF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA5437F0", Offset = "0xA5421F0", VA = "0x18A5437F0")]
		public static void AAZPHKODHWW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA543B40", Offset = "0xA542540", VA = "0x18A543B40")]
		public static void ADFNDGZAHRR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA543AC0", Offset = "0xA5424C0", VA = "0x18A543AC0")]
		public static void ADAGGAFCYGI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA543F10", Offset = "0xA542910", VA = "0x18A543F10")]
		public static void GGAGGSJHQXG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA543F90", Offset = "0xA542990", VA = "0x18A543F90")]
		public static void GGFNDZDFAIP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA544010", Offset = "0xA542A10", VA = "0x18A544010")]
		public static void GGKUBFXCJTY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA544090", Offset = "0xA542A90", VA = "0x18A544090")]
		public static void GGQAYMQZTFH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA543CE0", Offset = "0xA5426E0", VA = "0x18A543CE0")]
		public static void GFFERRHSFDW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA543D60", Offset = "0xA542760", VA = "0x18A543D60")]
		public static void GFKLOYBPOPF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA543DF0", Offset = "0xA5427F0", VA = "0x18A543DF0")]
		public static void GFPSMEVMYAO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA543E80", Offset = "0xA542880", VA = "0x18A543E80")]
		public static void GFUZJLPKHLX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA543BC0", Offset = "0xA5425C0", VA = "0x18A543BC0")]
		public static void GEKDCQGCTKM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA543C50", Offset = "0xA542650", VA = "0x18A543C50")]
		public static void GEPJZXAACVV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA5441A0", Offset = "0xA542BA0", VA = "0x18A5441A0")]
		public static void NGRLFKRKGPP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA544110", Offset = "0xA542B10", VA = "0x18A544110")]
		public static void NGMEIDXMXEG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA5444D0", Offset = "0xA542ED0", VA = "0x18A5444D0")]
		public static void RJMIRFEHGNT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA5443F0", Offset = "0xA542DF0", VA = "0x18A5443F0")]
		public static void RIWNZKWPEFS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA544460", Offset = "0xA542E60", VA = "0x18A544460")]
		public static void RJBUWRQMNRB(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class ZKJBWGTRBRQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA550350", Offset = "0xA54ED50", VA = "0x18A550350")]
		public static void RKXEYANOUPE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA5503C0", Offset = "0xA54EDC0", VA = "0x18A5503C0")]
		public static void RLCLVHHMEAN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA54FB00", Offset = "0xA54E500", VA = "0x18A54FB00")]
		public static void ABPJZEVVKEX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA54FA90", Offset = "0xA54E490", VA = "0x18A54FA90")]
		public static void ABKDBYBYATO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA54FBE0", Offset = "0xA54E5E0", VA = "0x18A54FBE0")]
		public static void ABZXTSJQDBP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA54FB70", Offset = "0xA54E570", VA = "0x18A54FB70")]
		public static void ABUQWLPSTQG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA54F930", Offset = "0xA54E330", VA = "0x18A54F930")]
		public static void AAUIKDUFYLN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA54F8C0", Offset = "0xA54E2C0", VA = "0x18A54F8C0")]
		public static void AAPBMXAIPAE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA54FA20", Offset = "0xA54E420", VA = "0x18A54FA20")]
		public static void ABEWERIARIF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA54F9A0", Offset = "0xA54E3A0", VA = "0x18A54F9A0")]
		public static void AAZPHKODHWW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA54FCD0", Offset = "0xA54E6D0", VA = "0x18A54FCD0")]
		public static void ADFNDGZAHRR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA54FC50", Offset = "0xA54E650", VA = "0x18A54FC50")]
		public static void ADAGGAFCYGI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA550050", Offset = "0xA54EA50", VA = "0x18A550050")]
		public static void GGAGGSJHQXG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA5500D0", Offset = "0xA54EAD0", VA = "0x18A5500D0")]
		public static void GGFNDZDFAIP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA550150", Offset = "0xA54EB50", VA = "0x18A550150")]
		public static void GGKUBFXCJTY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xA5501D0", Offset = "0xA54EBD0", VA = "0x18A5501D0")]
		public static void GGQAYMQZTFH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA54FE50", Offset = "0xA54E850", VA = "0x18A54FE50")]
		public static void GFFERRHSFDW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA54FED0", Offset = "0xA54E8D0", VA = "0x18A54FED0")]
		public static void GFKLOYBPOPF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA54FF50", Offset = "0xA54E950", VA = "0x18A54FF50")]
		public static void GFPSMEVMYAO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA54FFD0", Offset = "0xA54E9D0", VA = "0x18A54FFD0")]
		public static void GFUZJLPKHLX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA54FD50", Offset = "0xA54E750", VA = "0x18A54FD50")]
		public static void GEKDCQGCTKM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA54FDD0", Offset = "0xA54E7D0", VA = "0x18A54FDD0")]
		public static void GEPJZXAACVV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA5502D0", Offset = "0xA54ECD0", VA = "0x18A5502D0")]
		public static void NGRLFKRKGPP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xA550250", Offset = "0xA54EC50", VA = "0x18A550250")]
		public static void NGMEIDXMXEG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA5444D0", Offset = "0xA542ED0", VA = "0x18A5444D0")]
		public static void RJMIRFEHGNT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5443F0", Offset = "0xA542DF0", VA = "0x18A5443F0")]
		public static void RIWNZKWPEFS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA544460", Offset = "0xA542E60", VA = "0x18A544460")]
		public static void RJBUWRQMNRB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA544310", Offset = "0xA542D10", VA = "0x18A544310")]
		public static void RIMAEXIULJA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA544380", Offset = "0xA542D80", VA = "0x18A544380")]
		public static void RIRHCECRUUJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA544230", Offset = "0xA542C30", VA = "0x18A544230")]
		public static void RIBMKJUZSMI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5442A0", Offset = "0xA542CA0", VA = "0x18A5442A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA553950", Offset = "0xA552350", VA = "0x18A553950")]
		public static void BDOKWSZCPRQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5553A0", Offset = "0xA553DA0", VA = "0x18A5553A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B9C320", Offset = "0x2B9AD20", VA = "0x182B9C320")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA553120", Offset = "0xA551B20", VA = "0x18A553120")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xA552F50", Offset = "0xA551950", VA = "0x18A552F50")]
		public static DiyFp GIBMSNZVJUP(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA552FF0", Offset = "0xA5519F0", VA = "0x18A552FF0")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA553080", Offset = "0xA551A80", VA = "0x18A553080")]
		public static DiyFp QMWYAGCYAXD(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA552FB0", Offset = "0xA5519B0", VA = "0x18A552FB0")]
		public void LIXENUXBODC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA552F60", Offset = "0xA551960", VA = "0x18A552F60")]
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
		[Cpp2IlInjected.Address(RVA = "0xDC8DF0", Offset = "0xDC77F0", VA = "0x180DC8DF0")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA53C460", Offset = "0xA53AE60", VA = "0x18A53C460")]
		public void UCXRDEDUKNV(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA563D20", Offset = "0xA562720", VA = "0x18A563D20")]
		public void ZASZTTDCDUV(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xA563C00", Offset = "0xA562600", VA = "0x18A563C00")]
		public void OSFGPPFGXOT(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xA563C80", Offset = "0xA562680", VA = "0x18A563C80")]
		public void OSFGPPFGXOT(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA563A80", Offset = "0xA562480", VA = "0x18A563A80")]
		public void DDJZCXUQWUF(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA563B00", Offset = "0xA562500", VA = "0x18A563B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA558D10", Offset = "0xA557710", VA = "0x18A558D10")]
		private static byte[] NODOMCNXSHN(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA558C30", Offset = "0xA557630", VA = "0x18A558C30")]
		private static byte[] KUOXMXNLVBZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA558940", Offset = "0xA557340", VA = "0x18A558940")]
		public static int GXRVNCFILNA(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA558820", Offset = "0xA557220", VA = "0x18A558820")]
		public static int GXRVNCFILNA(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA558ED0", Offset = "0xA5578D0", VA = "0x18A558ED0")]
		private static bool XVMKTZTZRCO(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xA558DE0", Offset = "0xA5577E0", VA = "0x18A558DE0")]
		private static void VOJSRKLYZYK(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA558270", Offset = "0xA556C70", VA = "0x18A558270")]
		private static bool GINSHDMMUQY(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA557140", Offset = "0xA555B40", VA = "0x18A557140")]
		private static bool AEQTBVWNYME(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA558FC0", Offset = "0xA5579C0", VA = "0x18A558FC0")]
		private static bool YPCQFAZTVNB(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA558A60", Offset = "0xA557460", VA = "0x18A558A60")]
		private static bool HZKZAZBMHXK(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA5579F0", Offset = "0xA5563F0", VA = "0x18A5579F0")]
		private static bool DUDBIAUTXOP(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA557ED0", Offset = "0xA5568D0", VA = "0x18A557ED0")]
		private static void FEVNJNGUKDH(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5575C0", Offset = "0xA555FC0", VA = "0x18A5575C0")]
		private static void DHMYKCEEADT(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA558630", Offset = "0xA557030", VA = "0x18A558630")]
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
		[Cpp2IlInjected.Address(RVA = "0xA553750", Offset = "0xA552150", VA = "0x18A553750")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5536B0", Offset = "0xA5520B0", VA = "0x18A5536B0")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA5534D0", Offset = "0xA551ED0", VA = "0x18A5534D0")]
		public DiyFp OKKTKLJSMOT()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA553570", Offset = "0xA551F70", VA = "0x18A553570")]
		public DiyFp RZIVHDLSHQU()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xEF9080", Offset = "0xEF7A80", VA = "0x180EF9080")]
		public ulong JPRXLXYUYVF()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xA553430", Offset = "0xA551E30", VA = "0x18A553430")]
		public double MXMALVTTNMF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA553360", Offset = "0xA551D60", VA = "0x18A553360")]
		public double EWBXBEEOIBH()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA553540", Offset = "0xA551F40", VA = "0x18A553540")]
		public int OZBHFAQPXPA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5535F0", Offset = "0xA551FF0", VA = "0x18A5535F0")]
		public ulong SRHTTYYUAUM()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0xA553670", Offset = "0xA552070", VA = "0x18A553670")]
		public bool ZUYQGAGZABT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA553690", Offset = "0xA552090", VA = "0x18A553690")]
		public bool ZVGASTSIHRG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA553400", Offset = "0xA551E00", VA = "0x18A553400")]
		public bool KVVUNHYUYHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xA553620", Offset = "0xA552020", VA = "0x18A553620")]
		public bool VBHAZEFUZJL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xA553650", Offset = "0xA552050", VA = "0x18A553650")]
		public int VDINVYNRFYM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA553140", Offset = "0xA551B40", VA = "0x18A553140")]
		public void APZGEVCAXAW([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0xA553310", Offset = "0xA551D10", VA = "0x18A553310")]
		public bool ENVAPDCXNWW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x40E5BF0", Offset = "0x40E45F0", VA = "0x1840E5BF0")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xA5534B0", Offset = "0xA551EB0", VA = "0x18A5534B0")]
		public static int NKAPPIQZZSR(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xA553130", Offset = "0xA551B30", VA = "0x18A553130")]
		public static double APFHFZZDUNT()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xA553280", Offset = "0xA551C80", VA = "0x18A553280")]
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
		[Cpp2IlInjected.Address(RVA = "0x188C340", Offset = "0x188AD40", VA = "0x18188C340")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xA5639D0", Offset = "0xA5623D0", VA = "0x18A5639D0")]
		public DiyFp OKKTKLJSMOT()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xF86CD0", Offset = "0xF856D0", VA = "0x180F86CD0")]
		public uint EJZKIDUYZJC()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xA563A30", Offset = "0xA562430", VA = "0x18A563A30")]
		public int OZBHFAQPXPA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xA563A50", Offset = "0xA562450", VA = "0x18A563A50")]
		public uint SRHTTYYUAUM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0xA563A70", Offset = "0xA562470", VA = "0x18A563A70")]
		public bool ZUYQGAGZABT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xA563860", Offset = "0xA562260", VA = "0x18A563860")]
		public void APZGEVCAXAW([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xA563990", Offset = "0xA562390", VA = "0x18A563990")]
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
		[Cpp2IlInjected.Address(RVA = "0xA552300", Offset = "0xA550D00", VA = "0x18A552300")]
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
		[Cpp2IlInjected.Address(RVA = "0xA560810", Offset = "0xA55F210", VA = "0x18A560810")]
		public static void TMLDUYXXWKI(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xA560740", Offset = "0xA55F140", VA = "0x18A560740")]
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
			[Cpp2IlInjected.Address(RVA = "0xA568C80", Offset = "0xA567680", VA = "0x18A568C80")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4EF7390", Offset = "0x4EF5D90", VA = "0x184EF7390")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2DD2830", Offset = "0x2DD1230", VA = "0x182DD2830")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xA568C20", Offset = "0xA567620", VA = "0x18A568C20")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55D0F0", Offset = "0xA55BAF0", VA = "0x18A55D0F0")]
		private static byte[] UDUHHUOMVSE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xA55C5F0", Offset = "0xA55AFF0", VA = "0x18A55C5F0")]
		private static Vector HFZCHWKUBKM(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xA55DC00", Offset = "0xA55C600", VA = "0x18A55DC00")]
		private static Vector ZLYEEPMUSIQ(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0xA55C560", Offset = "0xA55AF60", VA = "0x18A55C560")]
		private static void EKWBQJOVPAJ(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA55C8F0", Offset = "0xA55B2F0", VA = "0x18A55C8F0")]
		private static void KMCTVDBIHZQ(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA55C6D0", Offset = "0xA55B0D0", VA = "0x18A55C6D0")]
		private static ulong HLRHDYFSQTR(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xA55CFB0", Offset = "0xA55B9B0", VA = "0x18A55CFB0")]
		private static void QGKCQZYWNQT(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA55CBE0", Offset = "0xA55B5E0", VA = "0x18A55CBE0")]
		private static bool MARMKPNSAMG(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA55C760", Offset = "0xA55B160", VA = "0x18A55C760")]
		private static DiyFp JCSGVIYYTYB(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0xA55D1D0", Offset = "0xA55BBD0", VA = "0x18A55D1D0")]
		private static bool UONGYNQGBHL(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xA55C440", Offset = "0xA55AE40", VA = "0x18A55C440")]
		private static bool CSSFGRCOFHR(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xA55D810", Offset = "0xA55C210", VA = "0x18A55D810")]
		public static double? URPOTRQMYFJ(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0xA55D930", Offset = "0xA55C330", VA = "0x18A55D930")]
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
		[Cpp2IlInjected.Address(RVA = "0xA566380", Offset = "0xA564D80", VA = "0x18A566380")]
		private static byte[] FLXSSTPZSVP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xA566090", Offset = "0xA564A90", VA = "0x18A566090")]
		public static bool AESFSSYASVY(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA566460", Offset = "0xA564E60", VA = "0x18A566460")]
		public static bool JHRVCOEUYPB(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA566240", Offset = "0xA564C40", VA = "0x18A566240")]
		private static bool DSBVLANEDWM(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA567590", Offset = "0xA565F90", VA = "0x18A567590")]
		private static bool MWKUFZBWWLR(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA567880", Offset = "0xA566280", VA = "0x18A567880")]
		private static bool UZGDAATHHAU(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA5661D0", Offset = "0xA564BD0", VA = "0x18A5661D0")]
		private static bool BTHEMVGQZXK(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA567860", Offset = "0xA566260", VA = "0x18A567860")]
		private static double SWNZXZPYLHF(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xA5665A0", Offset = "0xA564FA0", VA = "0x18A5665A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x197C450", Offset = "0x197AE50", VA = "0x18197C450")]
		public AQBIZZPHDTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
		public AQBIZZPHDTF(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x72DE740", Offset = "0x72DD140", VA = "0x1872DE740", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x72DE400", Offset = "0x72DCE00", VA = "0x1872DE400", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6841420", Offset = "0x683FE20", VA = "0x186841420", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6840FB0", Offset = "0x683F9B0", VA = "0x186840FB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x197C450", Offset = "0x197AE50", VA = "0x18197C450")]
		public WYZVYJCVPWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
		public WYZVYJCVPWK(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x873F4B0", Offset = "0x873DEB0", VA = "0x18873F4B0", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x873B730", Offset = "0x873A130", VA = "0x18873B730", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class XFSYBCEWMWQ<a, b, c, d> : NSYRGRINYUX<d>, GSCBNOMCLYY where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x50D4010", Offset = "0x50D2A10", VA = "0x1850D4010", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x50D24B0", Offset = "0x50D0EB0", VA = "0x1850D24B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected XFSYBCEWMWQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class XFNRDVKZDLH<a, b, c> : XFSYBCEWMWQ<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x50D2440", Offset = "0x50D0E40", VA = "0x1850D2440", Slot = "6")]
		protected override IEnumerator<a> ZTZTLJRSSMY(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected XFNRDVKZDLH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class XFIKGORBTZY<a, b> : XFNRDVKZDLH<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xD75EB0", Offset = "0xD748B0", VA = "0x180D75EB0", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class AOIUZWMULZY<a, b> : XFIKGORBTZY<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x72DDE40", Offset = "0x72DC840", VA = "0x1872DDE40", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x72DDCD0", Offset = "0x72DC6D0", VA = "0x1872DDCD0", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class RHAWOLBQHXL<a> : XFSYBCEWMWQ<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7761000", Offset = "0x775FA00", VA = "0x187761000", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xD75EB0", Offset = "0xD748B0", VA = "0x180D75EB0", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x50E9D30", Offset = "0x50E8730", VA = "0x1850E9D30", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x50E9B50", Offset = "0x50E8550", VA = "0x1850E9B50", Slot = "6")]
		protected override LinkedList<a>.Enumerator ZTZTLJRSSMY(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class KZUNMEGHBTK<a> : XFSYBCEWMWQ<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6360980", Offset = "0x635F380", VA = "0x186360980", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6360A70", Offset = "0x635F470", VA = "0x186360A70", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6888470", Offset = "0x6886E70", VA = "0x186888470", Slot = "6")]
		protected override Queue<a>.Enumerator ZTZTLJRSSMY(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xD75EB0", Offset = "0xD748B0", VA = "0x180D75EB0", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class GRGNQCWFNEA<a> : XFSYBCEWMWQ<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x644A740", Offset = "0x6449140", VA = "0x18644A740", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x644A990", Offset = "0x6449390", VA = "0x18644A990", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x644A9D0", Offset = "0x64493D0", VA = "0x18644A9D0", Slot = "6")]
		protected override Stack<a>.Enumerator ZTZTLJRSSMY(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x644A820", Offset = "0x6449220", VA = "0x18644A820", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class MNOSSMAHTZG<a> : XFSYBCEWMWQ<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4090", Offset = "0x6FE2A90", VA = "0x186FE4090", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0xD75EB0", Offset = "0xD748B0", VA = "0x180D75EB0", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6FE40D0", Offset = "0x6FE2AD0", VA = "0x186FE40D0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6FE4130", Offset = "0x6FE2B30", VA = "0x186FE4130", Slot = "6")]
		protected override HashSet<a>.Enumerator ZTZTLJRSSMY(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x635CEC0", Offset = "0x635B8C0", VA = "0x18635CEC0")]
		public MNOSSMAHTZG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class OEMNVVYIDYQ<a> : XFNRDVKZDLH<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x644A740", Offset = "0x6449140", VA = "0x18644A740", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x73B7650", Offset = "0x73B6050", VA = "0x1873B7650", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x73B76F0", Offset = "0x73B60F0", VA = "0x1873B76F0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class THLUZTZOWQV<a> : XFNRDVKZDLH<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6360980", Offset = "0x635F380", VA = "0x186360980", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6360A70", Offset = "0x635F470", VA = "0x186360A70", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0xD75EB0", Offset = "0xD748B0", VA = "0x180D75EB0", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class PSISEAWPMAZ<a> : XFNRDVKZDLH<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6360980", Offset = "0x635F380", VA = "0x186360980", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6360A70", Offset = "0x635F470", VA = "0x186360A70", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0xD75EB0", Offset = "0xD748B0", VA = "0x180D75EB0", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class TNHTQQWURAH<a> : XFNRDVKZDLH<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6452120", Offset = "0x6450B20", VA = "0x186452120", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x644A990", Offset = "0x6449390", VA = "0x18644A990", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F6B0", Offset = "0x7B5E0B0", VA = "0x187B5F6B0", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAED0", Offset = "0x6FF98D0", VA = "0x186FFAED0")]
		public TNHTQQWURAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class FQQXLEMMEHF<a, b> : NSYRGRINYUX<IGrouping<a, b>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x6363C70", Offset = "0x6362670", VA = "0x186363C70", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6363900", Offset = "0x6362300", VA = "0x186363900", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class ZSBXQNCZSGW<a, b> : NSYRGRINYUX<ILookup<a, b>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x517C6A0", Offset = "0x517B0A0", VA = "0x18517C6A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x517C340", Offset = "0x517AD40", VA = "0x18517C340", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4EF5250", Offset = "0x4EF3C50", VA = "0x184EF5250", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x772C490", Offset = "0x772AE90", VA = "0x18772C490")]
		public QKXAKNWXUHQ(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x772C410", Offset = "0x772AE10", VA = "0x18772C410", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x67263B0", Offset = "0x6724DB0", VA = "0x1867263B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x72D8530", Offset = "0x72D6F30", VA = "0x1872D8530", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public ACXRCQWLNLD(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x72D8390", Offset = "0x72D6D90", VA = "0x1872D8390", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x72D8480", Offset = "0x72D6E80", VA = "0x1872D8480", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x72D8480", Offset = "0x72D6E80", VA = "0x1872D8480", Slot = "7")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class HKTUKWNRKBM<a> : NSYRGRINYUX<a>, GSCBNOMCLYY where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x653A2C0", Offset = "0x6538CC0", VA = "0x18653A2C0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x653A090", Offset = "0x6538A90", VA = "0x18653A090", Slot = "5")]
		public a Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA556170", Offset = "0xA554B70", VA = "0x18A556170", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xA555F60", Offset = "0xA554960", VA = "0x18A555F60", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA552520", Offset = "0xA550F20", VA = "0x18A552520", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA552310", Offset = "0xA550D10", VA = "0x18A552310", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55B350", Offset = "0xA559D50", VA = "0x18A55B350", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0xA55B140", Offset = "0xA559B40", VA = "0x18A55B140", Slot = "5")]
		public IList Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public IUFKOHNZJKW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class KSJRICNYUGV<a> : XFIKGORBTZY<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6360980", Offset = "0x635F380", VA = "0x186360980", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x653A030", Offset = "0x6538A30", VA = "0x18653A030", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class HINFBSBMXIP<a> : XFNRDVKZDLH<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6360980", Offset = "0x635F380", VA = "0x186360980", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x653A030", Offset = "0x6538A30", VA = "0x18653A030", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6539FC0", Offset = "0x65389C0", VA = "0x186539FC0", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class GYCVLSUUKDN<a> : XFNRDVKZDLH<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6452150", Offset = "0x6450B50", VA = "0x186452150", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x644A990", Offset = "0x6449390", VA = "0x18644A990", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6452300", Offset = "0x6450D00", VA = "0x186452300", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6452340", Offset = "0x6450D40", VA = "0x186452340")]
		public GYCVLSUUKDN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class WKUUWCZFPVJ<a> : XFNRDVKZDLH<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6452150", Offset = "0x6450B50", VA = "0x186452150", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x644A990", Offset = "0x6449390", VA = "0x18644A990", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F6B0", Offset = "0x7B5E0B0", VA = "0x187B5F6B0", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAED0", Offset = "0x6FF98D0", VA = "0x186FFAED0")]
		public WKUUWCZFPVJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class XZTHNUYXOEV<a> : XFNRDVKZDLH<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x50E9C40", Offset = "0x50E8640", VA = "0x1850E9C40", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xD75EB0", Offset = "0xD748B0", VA = "0x180D75EB0", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x50E9D30", Offset = "0x50E8730", VA = "0x1850E9D30", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class FPQHQTYDVTR<a> : XFIKGORBTZY<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6360980", Offset = "0x635F380", VA = "0x186360980", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6360A70", Offset = "0x635F470", VA = "0x186360A70", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class MISEMUHJIBO<a> : XFIKGORBTZY<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6360980", Offset = "0x635F380", VA = "0x186360980", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6360A70", Offset = "0x635F470", VA = "0x186360A70", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class TODVRRSSCEJ<a> : XFNRDVKZDLH<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x644A740", Offset = "0x6449140", VA = "0x18644A740", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x644A990", Offset = "0x6449390", VA = "0x18644A990", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7B62C30", Offset = "0x7B61630", VA = "0x187B62C30", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0xA567C10", Offset = "0xA566610", VA = "0x18A567C10")]
		public static DateTime CLECIKWEIEE(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA568170", Offset = "0xA566B70", VA = "0x18A568170")]
		public static bool RJABZSSOWBV(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA567CD0", Offset = "0xA5666D0", VA = "0x18A567CD0")]
		public static bool EYUUEPKIPWD(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA567F60", Offset = "0xA566960", VA = "0x18A567F60")]
		public static bool EYUUEPKIPWD(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA568320", Offset = "0xA566D20", VA = "0x18A568320")]
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
		[Cpp2IlInjected.Address(RVA = "0xA564320", Offset = "0xA562D20", VA = "0x18A564320", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA5641A0", Offset = "0xA562BA0", VA = "0x18A5641A0", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA563DA0", Offset = "0xA5627A0", VA = "0x18A563DA0")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA559BC0", Offset = "0xA5585C0", VA = "0x18A559BC0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA559770", Offset = "0xA558170", VA = "0x18A559770", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA5597E0", Offset = "0xA5581E0", VA = "0x18A5597E0")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5625C0", Offset = "0xA560FC0", VA = "0x18A5625C0", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xA562150", Offset = "0xA560B50", VA = "0x18A562150", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA5621D0", Offset = "0xA560BD0", VA = "0x18A5621D0")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public QFQDQNNWGSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class HDVPOODZCZZ<a, b, c, d, e> : NSYRGRINYUX<e>, GSCBNOMCLYY where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6530890", Offset = "0x652F290", VA = "0x186530890", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x652B030", Offset = "0x6529A30", VA = "0x18652B030", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected HDVPOODZCZZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class HDQIRHKBTOQ<a, b, c, d> : HDVPOODZCZZ<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x50D2440", Offset = "0x50D0E40", VA = "0x1850D2440", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> ZTZTLJRSSMY(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected HDQIRHKBTOQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class HFBEYCTJHQB<a, b, c> : HDQIRHKBTOQ<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xD75EB0", Offset = "0xD748B0", VA = "0x180D75EB0", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class XZGOGEVBZDJ<a, b> : HDVPOODZCZZ<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x50E95A0", Offset = "0x50E7FA0", VA = "0x1850E95A0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xD75EB0", Offset = "0xD748B0", VA = "0x180D75EB0", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x50E97F0", Offset = "0x50E81F0", VA = "0x1850E97F0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x50E9AE0", Offset = "0x50E84E0", VA = "0x1850E9AE0", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator ZTZTLJRSSMY(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x50E9C00", Offset = "0x50E8600", VA = "0x1850E9C00")]
		public XZGOGEVBZDJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class ARLAGXIGPON<a, b, c> : HFBEYCTJHQB<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x72DF310", Offset = "0x72DDD10", VA = "0x1872DF310", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x72DF500", Offset = "0x72DDF00", VA = "0x1872DF500", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class IOZNQSOOVMM<a, b> : HDQIRHKBTOQ<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x50E9680", Offset = "0x50E8080", VA = "0x1850E9680", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x50E9970", Offset = "0x50E8370", VA = "0x1850E9970", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xD75EB0", Offset = "0xD748B0", VA = "0x180D75EB0", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class HYMQFUDYJMA<a, b> : HFBEYCTJHQB<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x50E9680", Offset = "0x50E8080", VA = "0x1850E9680", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x50E9970", Offset = "0x50E8370", VA = "0x1850E9970", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class OJDVLHSWCOM<a, b> : HDVPOODZCZZ<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x50E9680", Offset = "0x50E8080", VA = "0x1850E9680", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xD75EB0", Offset = "0xD748B0", VA = "0x180D75EB0", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x50E9970", Offset = "0x50E8370", VA = "0x1850E9970", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x73BBFE0", Offset = "0x73BA9E0", VA = "0x1873BBFE0", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator ZTZTLJRSSMY(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class QZLINXEVERD<a, b> : HDQIRHKBTOQ<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x50E9680", Offset = "0x50E8080", VA = "0x1850E9680", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x77385D0", Offset = "0x7736FD0", VA = "0x1877385D0", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7738640", Offset = "0x7737040", VA = "0x187738640", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class FGQYOTVYFLM<a, b> : HDQIRHKBTOQ<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x635CDC0", Offset = "0x635B7C0", VA = "0x18635CDC0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xD75EB0", Offset = "0xD748B0", VA = "0x180D75EB0", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x635CE00", Offset = "0x635B800", VA = "0x18635CE00", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x635CEC0", Offset = "0x635B8C0", VA = "0x18635CEC0")]
		public FGQYOTVYFLM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class HLUCTYUOAUM<a, b> : HFBEYCTJHQB<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x653A670", Offset = "0x6539070", VA = "0x18653A670", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x50E9970", Offset = "0x50E8370", VA = "0x1850E9970", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class ZZTKWJVAYKO<a> : NSYRGRINYUX<a>, GSCBNOMCLYY where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x518C1E0", Offset = "0x518ABE0", VA = "0x18518C1E0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x518BFB0", Offset = "0x518A9B0", VA = "0x18518BFB0", Slot = "5")]
		public a Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55BB40", Offset = "0xA55A540", VA = "0x18A55BB40", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA55B960", Offset = "0xA55A360", VA = "0x18A55B960", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public KHYRFAPDIZI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class BFLYZCLGGMW
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA550E50", Offset = "0xA54F850", VA = "0x18A550E50")]
		public static object HGQXVVOKXTG(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA551670", Offset = "0xA550070", VA = "0x18A551670")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FXRJPUNQTQT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x636AB10", Offset = "0x6369510", VA = "0x18636AB10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FXMCSNTTKFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x6368B20", Offset = "0x6367520", VA = "0x186368B20")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FYBXKIBLMNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x636B520", Offset = "0x6369F20", VA = "0x18636B520")]
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
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public FXWQNBHODCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x636AF60", Offset = "0x6369960", VA = "0x18636AF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x510ABA0", Offset = "0x51095A0", VA = "0x18510ABA0")]
		static YVUGLMBYFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5125290", Offset = "0x5123C90", VA = "0x185125290")]
		public YVUGLMBYFMJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x5101EE0", Offset = "0x51008E0", VA = "0x185101EE0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x50FDB40", Offset = "0x50FC540", VA = "0x1850FDB40", Slot = "5")]
		public a Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x51047D0", Offset = "0x51031D0", VA = "0x1851047D0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, a b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5100C00", Offset = "0x50FF600", VA = "0x185100C00", Slot = "7")]
		public a NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class BFGVSVBEQRZ<a> : NSYRGRINYUX<a[,]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x4EFF1D0", Offset = "0x4EFDBD0", VA = "0x184EFF1D0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x4EFEE20", Offset = "0x4EFD820", VA = "0x184EFEE20", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public BFGVSVBEQRZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class JULBKVAPDVH<a> : NSYRGRINYUX<a[,,]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x674D860", Offset = "0x674C260", VA = "0x18674D860", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x674D360", Offset = "0x674BD60", VA = "0x18674D360", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public JULBKVAPDVH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class UKYDGMBEVCH<a> : NSYRGRINYUX<a[,,,]>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7E28480", Offset = "0x7E26E80", VA = "0x187E28480", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7E27E40", Offset = "0x7E26840", VA = "0x187E27E40", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public UKYDGMBEVCH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class BXCMUEZDJIN<a> : NSYRGRINYUX<a?>, GSCBNOMCLYY where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x4F295C0", Offset = "0x4F27FC0", VA = "0x184F295C0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x4F29290", Offset = "0x4F27C90", VA = "0x184F29290", Slot = "5")]
		public a? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		public LXJMRFJVIUD(NSYRGRINYUX<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x69AA350", Offset = "0x69A8D50", VA = "0x1869AA350", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x69A9BC0", Offset = "0x69A85C0", VA = "0x1869A9BC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5520F0", Offset = "0xA550AF0", VA = "0x18A5520F0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA552060", Offset = "0xA550A60", VA = "0x18A552060", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xA552180", Offset = "0xA550B80", VA = "0x18A552180", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, sbyte b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xA552070", Offset = "0xA550A70", VA = "0x18A552070", Slot = "7")]
		public sbyte NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA56A9F0", Offset = "0xA5693F0", VA = "0x18A56A9F0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA56A8B0", Offset = "0xA5692B0", VA = "0x18A56A8B0", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xA56AAE0", Offset = "0xA5694E0", VA = "0x18A56AAE0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, sbyte? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xA56A920", Offset = "0xA569320", VA = "0x18A56A920", Slot = "7")]
		public sbyte? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA56A370", Offset = "0xA568D70", VA = "0x18A56A370", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xA56A230", Offset = "0xA568C30", VA = "0x18A56A230", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55A750", Offset = "0xA559150", VA = "0x18A55A750", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0xA55A6C0", Offset = "0xA5590C0", VA = "0x18A55A6C0", Slot = "5")]
		public short Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0xA55A7E0", Offset = "0xA5591E0", VA = "0x18A55A7E0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, short b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0xA55A6D0", Offset = "0xA5590D0", VA = "0x18A55A6D0", Slot = "7")]
		public short NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5693E0", Offset = "0xA567DE0", VA = "0x18A5693E0", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA5692A0", Offset = "0xA567CA0", VA = "0x18A5692A0", Slot = "5")]
		public short? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA5694D0", Offset = "0xA567ED0", VA = "0x18A5694D0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, short? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA569310", Offset = "0xA567D10", VA = "0x18A569310", Slot = "7")]
		public short? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5569D0", Offset = "0xA5553D0", VA = "0x18A5569D0", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA556890", Offset = "0xA555290", VA = "0x18A556890", Slot = "5")]
		public short[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55EDC0", Offset = "0xA55D7C0", VA = "0x18A55EDC0", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0xA55ED30", Offset = "0xA55D730", VA = "0x18A55ED30", Slot = "5")]
		public int Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA55EE50", Offset = "0xA55D850", VA = "0x18A55EE50", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, int b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0xA55ED40", Offset = "0xA55D740", VA = "0x18A55ED40", Slot = "7")]
		public int NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA563220", Offset = "0xA561C20", VA = "0x18A563220", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA5630E0", Offset = "0xA561AE0", VA = "0x18A5630E0", Slot = "5")]
		public int? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xA563310", Offset = "0xA561D10", VA = "0x18A563310", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, int? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xA563150", Offset = "0xA561B50", VA = "0x18A563150", Slot = "7")]
		public int? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA565080", Offset = "0xA563A80", VA = "0x18A565080", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA564F40", Offset = "0xA563940", VA = "0x18A564F40", Slot = "5")]
		public int[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5556C0", Offset = "0xA5540C0", VA = "0x18A5556C0", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xA555670", Offset = "0xA554070", VA = "0x18A555670", Slot = "5")]
		public long Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA555720", Offset = "0xA554120", VA = "0x18A555720", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, long b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA555680", Offset = "0xA554080", VA = "0x18A555680", Slot = "7")]
		public long NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA556630", Offset = "0xA555030", VA = "0x18A556630", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA5564F0", Offset = "0xA554EF0", VA = "0x18A5564F0", Slot = "5")]
		public long? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA5566F0", Offset = "0xA5550F0", VA = "0x18A5566F0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, long? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA556580", Offset = "0xA554F80", VA = "0x18A556580", Slot = "7")]
		public long? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA560510", Offset = "0xA55EF10", VA = "0x18A560510", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA5603D0", Offset = "0xA55EDD0", VA = "0x18A5603D0", Slot = "5")]
		public long[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55C230", Offset = "0xA55AC30", VA = "0x18A55C230", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA55C1A0", Offset = "0xA55ABA0", VA = "0x18A55C1A0", Slot = "5")]
		public byte Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA55C2C0", Offset = "0xA55ACC0", VA = "0x18A55C2C0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, byte b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA55C1B0", Offset = "0xA55ABB0", VA = "0x18A55C1B0", Slot = "7")]
		public byte NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA562E20", Offset = "0xA561820", VA = "0x18A562E20", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA562CE0", Offset = "0xA5616E0", VA = "0x18A562CE0", Slot = "5")]
		public byte? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA562F10", Offset = "0xA561910", VA = "0x18A562F10", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, byte? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA562D50", Offset = "0xA561750", VA = "0x18A562D50", Slot = "7")]
		public byte? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA56A6A0", Offset = "0xA5690A0", VA = "0x18A56A6A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA56A610", Offset = "0xA569010", VA = "0x18A56A610", Slot = "5")]
		public ushort Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA56A730", Offset = "0xA569130", VA = "0x18A56A730", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, ushort b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xA56A620", Offset = "0xA569020", VA = "0x18A56A620", Slot = "7")]
		public ushort NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55AE80", Offset = "0xA559880", VA = "0x18A55AE80", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xA55AD40", Offset = "0xA559740", VA = "0x18A55AD40", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xA55AF70", Offset = "0xA559970", VA = "0x18A55AF70", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, ushort? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xA55ADB0", Offset = "0xA5597B0", VA = "0x18A55ADB0", Slot = "7")]
		public ushort? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55AAA0", Offset = "0xA5594A0", VA = "0x18A55AAA0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA55A960", Offset = "0xA559360", VA = "0x18A55A960", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA568EE0", Offset = "0xA5678E0", VA = "0x18A568EE0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA568E50", Offset = "0xA567850", VA = "0x18A568E50", Slot = "5")]
		public uint Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA568F70", Offset = "0xA567970", VA = "0x18A568F70", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, uint b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA568E60", Offset = "0xA567860", VA = "0x18A568E60", Slot = "7")]
		public uint NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA561E90", Offset = "0xA560890", VA = "0x18A561E90", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0xA561D50", Offset = "0xA560750", VA = "0x18A561D50", Slot = "5")]
		public uint? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xA561F80", Offset = "0xA560980", VA = "0x18A561F80", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, uint? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xA561DC0", Offset = "0xA5607C0", VA = "0x18A561DC0", Slot = "7")]
		public uint? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA552B10", Offset = "0xA551510", VA = "0x18A552B10", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA5529D0", Offset = "0xA5513D0", VA = "0x18A5529D0", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA56A090", Offset = "0xA568A90", VA = "0x18A56A090", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA56A040", Offset = "0xA568A40", VA = "0x18A56A040", Slot = "5")]
		public ulong Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA56A0F0", Offset = "0xA568AF0", VA = "0x18A56A0F0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, ulong b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xA56A050", Offset = "0xA568A50", VA = "0x18A56A050", Slot = "7")]
		public ulong NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55E590", Offset = "0xA55CF90", VA = "0x18A55E590", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA55E450", Offset = "0xA55CE50", VA = "0x18A55E450", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA55E650", Offset = "0xA55D050", VA = "0x18A55E650", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, ulong? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xA55E4E0", Offset = "0xA55CEE0", VA = "0x18A55E4E0", Slot = "7")]
		public ulong? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA550C20", Offset = "0xA54F620", VA = "0x18A550C20", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xA550AE0", Offset = "0xA54F4E0", VA = "0x18A550AE0", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5554D0", Offset = "0xA553ED0", VA = "0x18A5554D0", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA555480", Offset = "0xA553E80", VA = "0x18A555480", Slot = "5")]
		public float Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA555530", Offset = "0xA553F30", VA = "0x18A555530", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, float b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA555490", Offset = "0xA553E90", VA = "0x18A555490", Slot = "7")]
		public float NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA568890", Offset = "0xA567290", VA = "0x18A568890", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xA568780", Offset = "0xA567180", VA = "0x18A568780", Slot = "5")]
		public float? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xA568950", Offset = "0xA567350", VA = "0x18A568950", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, float? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA5687F0", Offset = "0xA5671F0", VA = "0x18A5687F0", Slot = "7")]
		public float? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA556DB0", Offset = "0xA5557B0", VA = "0x18A556DB0", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0xA556C70", Offset = "0xA555670", VA = "0x18A556C70", Slot = "5")]
		public float[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA559360", Offset = "0xA557D60", VA = "0x18A559360", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA559310", Offset = "0xA557D10", VA = "0x18A559310", Slot = "5")]
		public double Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA5593C0", Offset = "0xA557DC0", VA = "0x18A5593C0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, double b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA559320", Offset = "0xA557D20", VA = "0x18A559320", Slot = "7")]
		public double NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA555D00", Offset = "0xA554700", VA = "0x18A555D00", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA555BC0", Offset = "0xA5545C0", VA = "0x18A555BC0", Slot = "5")]
		public double? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA555DC0", Offset = "0xA5547C0", VA = "0x18A555DC0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, double? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA555C50", Offset = "0xA554650", VA = "0x18A555C50", Slot = "7")]
		public double? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55E0D0", Offset = "0xA55CAD0", VA = "0x18A55E0D0", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0xA55DF90", Offset = "0xA55C990", VA = "0x18A55DF90", Slot = "5")]
		public double[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55B7C0", Offset = "0xA55A1C0", VA = "0x18A55B7C0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA55B770", Offset = "0xA55A170", VA = "0x18A55B770", Slot = "5")]
		public bool Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA55B820", Offset = "0xA55A220", VA = "0x18A55B820", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, bool b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA55B780", Offset = "0xA55A180", VA = "0x18A55B780", Slot = "7")]
		public bool NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA555970", Offset = "0xA554370", VA = "0x18A555970", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xA555860", Offset = "0xA554260", VA = "0x18A555860", Slot = "5")]
		public bool? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xA555A30", Offset = "0xA554430", VA = "0x18A555A30", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, bool? b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xA5558D0", Offset = "0xA5542D0", VA = "0x18A5558D0", Slot = "7")]
		public bool? NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5619C0", Offset = "0xA5603C0", VA = "0x18A5619C0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xA561880", Offset = "0xA560280", VA = "0x18A561880", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA552E20", Offset = "0xA551820", VA = "0x18A552E20", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA552DB0", Offset = "0xA5517B0", VA = "0x18A552DB0", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5595D0", Offset = "0xA557FD0", VA = "0x18A5595D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA559500", Offset = "0xA557F00", VA = "0x18A559500", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA568AF0", Offset = "0xA5674F0", VA = "0x18A568AF0", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA568AE0", Offset = "0xA5674E0", VA = "0x18A568AE0", Slot = "5")]
		public string Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA568B50", Offset = "0xA567550", VA = "0x18A568B50", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, string b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA568AE0", Offset = "0xA5674E0", VA = "0x18A568AE0", Slot = "7")]
		public string NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA563630", Offset = "0xA562030", VA = "0x18A563630", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA5634E0", Offset = "0xA561EE0", VA = "0x18A5634E0", Slot = "5")]
		public string[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA565350", Offset = "0xA563D50", VA = "0x18A565350", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA565320", Offset = "0xA563D20", VA = "0x18A565320", Slot = "5")]
		public char Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55E8B0", Offset = "0xA55D2B0", VA = "0x18A55E8B0", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA55E7F0", Offset = "0xA55D1F0", VA = "0x18A55E7F0", Slot = "5")]
		public char? Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA56AE40", Offset = "0xA569840", VA = "0x18A56AE40", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA56ACB0", Offset = "0xA5696B0", VA = "0x18A56ACB0", Slot = "5")]
		public char[] Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA565540", Offset = "0xA563F40", VA = "0x18A565540", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA565470", Offset = "0xA563E70", VA = "0x18A565470", Slot = "5")]
		public Guid Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA5656B0", Offset = "0xA5640B0", VA = "0x18A5656B0", Slot = "6")]
		public void UWIGGGXULCG(JsonWriter a, Guid b, PUYXSHPJLHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5654D0", Offset = "0xA563ED0", VA = "0x18A5654D0", Slot = "7")]
		public Guid NQZPYZABCGC(JsonReader a, PUYXSHPJLHM b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x88A5EB0", Offset = "0x88A48B0", VA = "0x1888A5EB0")]
		public PCWHJNIXQIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x1012C60", Offset = "0x1011660", VA = "0x181012C60")]
		public PCWHJNIXQIW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xA560180", Offset = "0xA55EB80", VA = "0x18A560180", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xA55FFB0", Offset = "0xA55E9B0", VA = "0x18A55FFB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA551F10", Offset = "0xA550910", VA = "0x18A551F10", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xA551E90", Offset = "0xA550890", VA = "0x18A551E90", Slot = "5")]
		public Uri Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA569170", Offset = "0xA567B70", VA = "0x18A569170", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA5690F0", Offset = "0xA567AF0", VA = "0x18A5690F0", Slot = "5")]
		public Version Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public WHNVWMGSUHJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class HHQBDBARGJV<a, b> : NSYRGRINYUX<KeyValuePair<a, b>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x6535800", Offset = "0x6534200", VA = "0x186535800", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x6535300", Offset = "0x6533D00", VA = "0x186535300", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA568D40", Offset = "0xA567740", VA = "0x18A568D40", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA568CC0", Offset = "0xA5676C0", VA = "0x18A568CC0", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55EB40", Offset = "0xA55D540", VA = "0x18A55EB40", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA55EA20", Offset = "0xA55D420", VA = "0x18A55EA20", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA569B40", Offset = "0xA568540", VA = "0x18A569B40")]
		public YAPTJBYXVVL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x986D4E0", Offset = "0x986BEE0", VA = "0x18986D4E0")]
		public YAPTJBYXVVL(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA569960", Offset = "0xA568360", VA = "0x18A569960", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA569850", Offset = "0xA568250", VA = "0x18A569850", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55DE50", Offset = "0xA55C850", VA = "0x18A55DE50", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA55DDA0", Offset = "0xA55C7A0", VA = "0x18A55DDA0", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5685E0", Offset = "0xA566FE0", VA = "0x18A5685E0", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA568550", Offset = "0xA566F50", VA = "0x18A568550", Slot = "5")]
		public Complex Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xA569F40", Offset = "0xA568940", VA = "0x18A569F40", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA569D10", Offset = "0xA568710", VA = "0x18A569D10", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public YKYXYZWQHYJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class HOOZCKBZDSU<a> : NSYRGRINYUX<Lazy<a>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x653C240", Offset = "0x653AC40", VA = "0x18653C240", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x653C030", Offset = "0x653AA30", VA = "0x18653C030", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA553810", Offset = "0xA552210", VA = "0x18A553810", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA553760", Offset = "0xA552160", VA = "0x18A553760", Slot = "5")]
		public Task Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ERRZUEMSNEE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class OLVNIKOIRQC<a> : NSYRGRINYUX<Task<a>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x73BE400", Offset = "0x73BCE00", VA = "0x1873BE400", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x73BE200", Offset = "0x73BCC00", VA = "0x1873BE200", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, PUYXSHPJLHM formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class FKVQJZYKRUA<a> : NSYRGRINYUX<ValueTask<a>>, GSCBNOMCLYY
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x635DE10", Offset = "0x635C810", VA = "0x18635DE10", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x635DC60", Offset = "0x635C660", VA = "0x18635DC60", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6744AF0", Offset = "0x67434F0", VA = "0x186744AF0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x6744800", Offset = "0x6743200", VA = "0x186744800", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x67442A0", Offset = "0x6742CA0", VA = "0x1867442A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x6743E50", Offset = "0x6742850", VA = "0x186743E50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6743780", Offset = "0x6742180", VA = "0x186743780", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x67431F0", Offset = "0x6741BF0", VA = "0x1867431F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x67429A0", Offset = "0x67413A0", VA = "0x1867429A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x67422B0", Offset = "0x6740CB0", VA = "0x1867422B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x67418E0", Offset = "0x67402E0", VA = "0x1867418E0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x6741080", Offset = "0x673FA80", VA = "0x186741080", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6740530", Offset = "0x673EF30", VA = "0x186740530", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x673FB40", Offset = "0x673E540", VA = "0x18673FB40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x673EE70", Offset = "0x673D870", VA = "0x18673EE70", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x673E2F0", Offset = "0x673CCF0", VA = "0x18673E2F0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x674ABB0", Offset = "0x67495B0", VA = "0x18674ABB0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x6749EC0", Offset = "0x67488C0", VA = "0x186749EC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BEB8A0", Offset = "0x5BEA2A0", VA = "0x185BEB8A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x5BEB470", Offset = "0x5BE9E70", VA = "0x185BEB470", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BEA0F0", Offset = "0x5BE8AF0", VA = "0x185BEA0F0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9BE0", Offset = "0x5BE85E0", VA = "0x185BE9BE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BEAD20", Offset = "0x5BE9720", VA = "0x185BEAD20", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x5BEA680", Offset = "0x5BE9080", VA = "0x185BEA680", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BEFA00", Offset = "0x5BEE400", VA = "0x185BEFA00", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5BEF190", Offset = "0x5BEDB90", VA = "0x185BEF190", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BF0D20", Offset = "0x5BEF720", VA = "0x185BF0D20", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x5BF0320", Offset = "0x5BEED20", VA = "0x185BF0320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BEC8B0", Offset = "0x5BEB2B0", VA = "0x185BEC8B0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x5BEBC90", Offset = "0x5BEA690", VA = "0x185BEBC90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BEE330", Offset = "0x5BECD30", VA = "0x185BEE330", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x5BED550", Offset = "0x5BEBF50", VA = "0x185BED550", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x5BF2DB0", Offset = "0x5BF17B0", VA = "0x185BF2DB0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, PUYXSHPJLHM formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x5BF1E20", Offset = "0x5BF0820", VA = "0x185BF1E20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xA569B60", Offset = "0xA568560", VA = "0x18A569B60")]
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
		[Cpp2IlInjected.Address(RVA = "0xA5696A0", Offset = "0xA5680A0", VA = "0x18A5696A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA55EFD0", Offset = "0xA55D9D0", VA = "0x18A55EFD0")]
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
