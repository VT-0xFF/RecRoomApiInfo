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
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, DLUWFSZQQRW resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, DLUWFSZQQRW resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface NLVSGIAJTPY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface HQJLNSOHDQB<a> : NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, DLUWFSZQQRW formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface WRTQDWNXXJC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ENJQYJMDWMI(JsonWriter a, a b, DLUWFSZQQRW c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b);
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
	public static class CUIJHCQWASH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x34E7EE0", Offset = "0x34E6EE0", VA = "0x1834E7EE0")]
		public static string ToJsonString<T>(this HQJLNSOHDQB<T> formatter, T value, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		HQJLNSOHDQB<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class IJXYJFBJJTL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3781300", Offset = "0x3780300", VA = "0x183781300")]
		public static HQJLNSOHDQB<a> DNJQWBIVFCM<a>(this DLUWFSZQQRW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9002C90", Offset = "0x9001C90", VA = "0x189002C90")]
		public static object HBOYPUXSSVI(this DLUWFSZQQRW a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x90007A0", Offset = "0x8FFF7A0", VA = "0x1890007A0")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class CBEQTPWSWYI
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] AWIPNPQNJXR;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] PAROTXQDFYS;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] BUIGYPIRBYL;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] KFRGVAFZRXU;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] OJTKINBPSUF;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] EEFPHAIHSKY;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] HYIKCPTGFIK;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] APGJECLOYDJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class OBAJKKZUIMP : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x90097E0", Offset = "0x90087E0", VA = "0x1890097E0")]
				public OBAJKKZUIMP(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x90096C0", Offset = "0x90086C0", VA = "0x1890096C0")]
				public OBAJKKZUIMP OXOQTGKCIOD(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class XCVFNBHHGNO
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] SQJZSGPDUJL;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] PJKNMHNSUGS;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private OBAJKKZUIMP start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private OBAJKKZUIMP end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x900D680", Offset = "0x900C680", VA = "0x18900D680")]
			public void OXOQTGKCIOD([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x900D790", Offset = "0x900C790", VA = "0x18900D790")]
			public void OXOQTGKCIOD(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x900DA80", Offset = "0x900CA80", VA = "0x18900DA80")]
			public ReadOnlySequence<byte> WIJZGYMWIRG()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x900D8D0", Offset = "0x900C8D0", VA = "0x18900D8D0")]
			private void TTCKTCGKYOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x900D490", Offset = "0x900C490", VA = "0x18900D490")]
			private void IJOZQVYPGIW([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9007020", Offset = "0x9006020", VA = "0x189007020")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9005670", Offset = "0x9004670", VA = "0x189005670")]
		private JsonParsingException NMAJLMFEHKG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9003E60", Offset = "0x9002E60", VA = "0x189003E60")]
		private JsonParsingException AHPZFSYBLDT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9006B60", Offset = "0x9005B60", VA = "0x189006B60")]
		public JsonToken YFBZEJVTFZX()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9004930", Offset = "0x9003930", VA = "0x189004930")]
		public void ECCUKBABYCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9004FB0", Offset = "0x9003FB0", VA = "0x189004FB0")]
		private bool GUAVGJMACZN(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9004F50", Offset = "0x9003F50", VA = "0x189004F50")]
		private bool GUAVGJMACZN(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x90053E0", Offset = "0x90043E0", VA = "0x1890053E0")]
		private void KUDRPTYQGRY(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9005FF0", Offset = "0x9004FF0", VA = "0x189005FF0")]
		public bool SFAHDDVMCFY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x90042B0", Offset = "0x90032B0", VA = "0x1890042B0")]
		public void DQCWLAWECXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9006B10", Offset = "0x9005B10", VA = "0x189006B10")]
		public bool WWFNUOVUXVT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9004F30", Offset = "0x9003F30", VA = "0x189004F30")]
		public void GDMSWYAMHFW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9004F40", Offset = "0x9003F40", VA = "0x189004F40")]
		public void GDTFQHCIGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9005C20", Offset = "0x9004C20", VA = "0x189005C20")]
		public bool OFUIRRKQQXF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x90042C0", Offset = "0x90032C0", VA = "0x1890042C0")]
		public void DRFBRFBPDZA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9004E80", Offset = "0x9003E80", VA = "0x189004E80")]
		public void FFOKCEHXWIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x90055E0", Offset = "0x90045E0", VA = "0x1890055E0")]
		public bool NLZUQMPOQFE(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9006970", Offset = "0x9005970", VA = "0x189006970")]
		public bool WJVSXAQCPDW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9005F10", Offset = "0x9004F10", VA = "0x189005F10")]
		public bool SEFGVZCUNYP(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9006490", Offset = "0x9005490", VA = "0x189006490")]
		private ReadOnlySequence<byte> WCUMOHRSGAE()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9004B60", Offset = "0x9003B60", VA = "0x189004B60")]
		private ReadOnlySequence<byte> EQUZBTZBRGT()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x90051F0", Offset = "0x90041F0", VA = "0x1890051F0")]
		private void KKUIRGHIATB(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9004730", Offset = "0x9003730", VA = "0x189004730")]
		private void DXSATHEVRCO(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x90042D0", Offset = "0x90032D0", VA = "0x1890042D0")]
		private void DTYWBTTJQFL(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9006A00", Offset = "0x9005A00", VA = "0x189006A00")]
		private void WNHRCYQQTOA(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE060", Offset = "0x8FFD060", VA = "0x188FFE060")]
		private static int PGHYUFXKMYP(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9006170", Offset = "0x9005170", VA = "0x189006170")]
		public ReadOnlySequence<byte> ULCZOVUTDUJ()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9005010", Offset = "0x9004010", VA = "0x189005010")]
		public string GYKQTAEDUEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9003F70", Offset = "0x9002F70", VA = "0x189003F70")]
		public string AQCHBZZMGXL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9003FB0", Offset = "0x9002FB0", VA = "0x189003FB0")]
		public ReadOnlySequence<byte> AXZMQUMKCGT()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9004130", Offset = "0x9003130", VA = "0x189004130")]
		public ReadOnlySequence<byte> BUHFZALQKUM()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9005490", Offset = "0x9004490", VA = "0x189005490")]
		public bool MNBVQCEEXGR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x90045C0", Offset = "0x90035C0", VA = "0x1890045C0")]
		private void DVJRQWBCXYZ(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x90060B0", Offset = "0x90050B0", VA = "0x1890060B0")]
		public void STZOHLSKPFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9006DE0", Offset = "0x9005DE0", VA = "0x189006DE0")]
		private void ZNDKVMBPEWY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9005140", Offset = "0x9004140", VA = "0x189005140")]
		public sbyte ILADLQAPBIW()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x90060C0", Offset = "0x90050C0", VA = "0x1890060C0")]
		public short TIIYLHYFFJF()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9005090", Offset = "0x9004090", VA = "0x189005090")]
		public int HEUYWMEVSHP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9006D70", Offset = "0x9005D70", VA = "0x189006D70")]
		public long ZGRVXAMSOZE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9004DD0", Offset = "0x9003DD0", VA = "0x189004DD0")]
		public byte FAOGFZJFLMN()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9004080", Offset = "0x9003080", VA = "0x189004080")]
		public ushort BNEFGWZNYDK()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9005B70", Offset = "0x9004B70", VA = "0x189005B70")]
		public uint NNLYNOMNQFM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9006240", Offset = "0x9005240", VA = "0x189006240")]
		public ulong VPQJKFMQAGV()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9004E90", Offset = "0x9003E90", VA = "0x189004E90")]
		public float FRMGTXFINZV()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9004210", Offset = "0x9003210", VA = "0x189004210")]
		public double DQCHPAFGQAG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x90062B0", Offset = "0x90052B0", VA = "0x1890062B0")]
		public ReadOnlySequence<byte> VYEXVRUVGKX()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9005C70", Offset = "0x9004C70", VA = "0x189005C70")]
		private void OXZZICIDRMF()
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
			[Cpp2IlInjected.Address(RVA = "0xD2A390", Offset = "0xD29390", VA = "0x180D2A390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9003E00", Offset = "0x9002E00", VA = "0x189003E00")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9003D80", Offset = "0x9002D80", VA = "0x189003D80")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class MXUYMNODNEV
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class SBVPXNENSSK
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] SQJZSGPDUJL;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x900D3F0", Offset = "0x900C3F0", VA = "0x18900D3F0")]
			public static byte[] QSUFRAVHLJZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static DLUWFSZQQRW HDESNQTOUHU;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] UNOWGALOCQV;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] JXQNYDTMNQB;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static DLUWFSZQQRW RFRRFPTURRM
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9008980", Offset = "0x9007980", VA = "0x189008980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9008A70", Offset = "0x9007A70", VA = "0x189008A70")]
		public static void YRMQILFCPDC(DLUWFSZQQRW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x385C0F0", Offset = "0x385B0F0", VA = "0x18385C0F0")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x385C2B0", Offset = "0x385B2B0", VA = "0x18385C2B0")]
		public static byte[] Serialize<T>(T value, DLUWFSZQQRW resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x385C950", Offset = "0x385B950", VA = "0x18385C950")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x385CB10", Offset = "0x385BB10", VA = "0x18385CB10")]
		public static string ToJsonString<T>(T value, DLUWFSZQQRW resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x385B870", Offset = "0x385A870", VA = "0x18385B870")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x385BB10", Offset = "0x385AB10", VA = "0x18385BB10")]
		public static T Deserialize<T>(string json, DLUWFSZQQRW resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x385BC90", Offset = "0x385AC90", VA = "0x18385BC90")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x385BA40", Offset = "0x385AA40", VA = "0x18385BA40")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, DLUWFSZQQRW resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x385B090", Offset = "0x385A090", VA = "0x18385B090")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x385B2B0", Offset = "0x385A2B0", VA = "0x18385B2B0")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, DLUWFSZQQRW resolver)
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
		public int AGTMIWBKLGT
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCED200", Offset = "0xCEC200", VA = "0x180CED200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9007B10", Offset = "0x9006B10", VA = "0x189007B10")]
		public void UMJJIKHNKXW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9007470", Offset = "0x9006470", VA = "0x189007470")]
		public static byte[] HAWFQTCKFXZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9007930", Offset = "0x9006930", VA = "0x189007930")]
		public static byte[] TNXHOKZLZAP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9007610", Offset = "0x9006610", VA = "0x189007610")]
		public static byte[] LXJVQQPPRAP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9007BA0", Offset = "0x9006BA0", VA = "0x189007BA0")]
		public static byte[] VMGLHOGOZMB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2864AF0", Offset = "0x2863AF0", VA = "0x182864AF0")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9007820", Offset = "0x9006820", VA = "0x189007820")]
		public ArraySegment<byte> QSUFRAVHLJZ()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9007200", Offset = "0x9006200", VA = "0x189007200")]
		public byte[] ENNPBHLRULG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9007AB0", Offset = "0x9006AB0", VA = "0x189007AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9007550", Offset = "0x9006550", VA = "0x189007550")]
		public void JJUTANPXZLX(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9007A50", Offset = "0x9006A50", VA = "0x189007A50")]
		public void TQOXAQDXAGA(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9007560", Offset = "0x9006560", VA = "0x189007560")]
		public void KJCBMJARKFA(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3D35A10", Offset = "0x3D34A10", VA = "0x183D35A10")]
		public void GUDGMTEAEZS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3D35AB0", Offset = "0x3D34AB0", VA = "0x183D35AB0")]
		public void ISPFUPNJALO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9007E20", Offset = "0x9006E20", VA = "0x189007E20")]
		public void XKYADWZHZRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3D35BF0", Offset = "0x3D34BF0", VA = "0x183D35BF0")]
		public void ZXELZQCZVGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3D35A60", Offset = "0x3D34A60", VA = "0x183D35A60")]
		public void GYSXPUYDOIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3D35B00", Offset = "0x3D34B00", VA = "0x183D35B00")]
		public void NKUREOESKBW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9007E70", Offset = "0x9006E70", VA = "0x189007E70")]
		public void XMGEAZMNCZS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x550EB80", Offset = "0x550DB80", VA = "0x18550EB80")]
		public void DYFUKWZKXNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3D35970", Offset = "0x3D34970", VA = "0x183D35970")]
		public void GTPZWKYJPWL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7903280", Offset = "0x7902280", VA = "0x187903280")]
		public void AHAQLLIDQXU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x90077A0", Offset = "0x90067A0", VA = "0x1890077A0")]
		public void QDENBFXJVPQ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9007B20", Offset = "0x9006B20", VA = "0x189007B20")]
		public void USFIIBXWXPF(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x90075A0", Offset = "0x90065A0", VA = "0x1890075A0")]
		public void LDIJHHYNWDC(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x90078C0", Offset = "0x90068C0", VA = "0x1890078C0")]
		public void RIMJIHZDNPX(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9007390", Offset = "0x9006390", VA = "0x189007390")]
		public void ENOKONUSKAP(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9007DA0", Offset = "0x9006DA0", VA = "0x189007DA0")]
		public void WLJZRWUPZZG(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9007400", Offset = "0x9006400", VA = "0x189007400")]
		public void GOCDANWEMSV(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9007190", Offset = "0x9006190", VA = "0x189007190")]
		public void CYXLSOYWEQA(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9007730", Offset = "0x9006730", VA = "0x189007730")]
		public void OZFEZGLVWSC(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9007DD0", Offset = "0x9006DD0", VA = "0x189007DD0")]
		public void XBJPVXLYGTL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9007F10", Offset = "0x9006F10", VA = "0x189007F10")]
		public void ZTNOXTUFWKP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9007D20", Offset = "0x9006D20", VA = "0x189007D20")]
		private static bool VPSENHXUWJF(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9007E00", Offset = "0x9006E00", VA = "0x189007E00")]
		private static byte XBJYBRZWWBD(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE120", Offset = "0x8FFD120", VA = "0x188FFE120")]
		private static void LWEJZMRYJFQ(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class WXJSUTXFNDB : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x4188AE0", Offset = "0x4187AE0", VA = "0x184188AE0")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private WXJSUTXFNDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class OPAIMRQBCPW : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x418C480", Offset = "0x418B480", VA = "0x18418C480")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class WPUKUJALZPI
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> AYHFMSJLPIH;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x900E360", Offset = "0x900D360", VA = "0x18900E360")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private OPAIMRQBCPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class AWWTBNXXQSM : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x418A1B0", Offset = "0x41891B0", VA = "0x18418A1B0")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly AWWTBNXXQSM QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool VIVPRWRTACM;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static NLVSGIAJTPY[] SSEQXAFFMRG;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static DLUWFSZQQRW[] UTOYMETOWVU;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private AWWTBNXXQSM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE6B0", Offset = "0x8FFD6B0", VA = "0x188FFE6B0")]
		public static void BPSMAKIBARY(params DLUWFSZQQRW[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE780", Offset = "0x8FFD780", VA = "0x188FFE780")]
		public static void BPSMAKIBARY(params NLVSGIAJTPY[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE850", Offset = "0x8FFD850", VA = "0x188FFE850")]
		public static void HVXTHQAXLCK(NLVSGIAJTPY[] a, DLUWFSZQQRW[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class ZYAWTZOEYVV : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x41AC7D0", Offset = "0x41AB7D0", VA = "0x1841AC7D0")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private ZYAWTZOEYVV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class KRHJNWQVOWI
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly DLUWFSZQQRW GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly DLUWFSZQQRW DTQXVGSURIR;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class VXHVSTFCEVK
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly DLUWFSZQQRW GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly DLUWFSZQQRW TQPYCCCYNCT;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly DLUWFSZQQRW ESJMEWLULOB;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly DLUWFSZQQRW SPUWADZIMIO;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly DLUWFSZQQRW VKARHONSKRO;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly DLUWFSZQQRW ZXAUVUKGZZU;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly DLUWFSZQQRW BGHYMBIGIUD;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly DLUWFSZQQRW KNRLLRAGJRJ;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly DLUWFSZQQRW HBWRZVJPMEN;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly DLUWFSZQQRW HAFNJWCPCXM;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly DLUWFSZQQRW IGUZPZSVUUM;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly DLUWFSZQQRW WARVORBGSRU;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class OHYRUBLLDXP
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> AYHFMSJLPIH;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9009850", Offset = "0x9008850", VA = "0x189009850")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x900B450", Offset = "0x900A450", VA = "0x18900B450")]
		private static object TSRKSEXPMNS(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class BTQXXNQJOUF : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x41A70A0", Offset = "0x41A60A0", VA = "0x1841A70A0")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private BTQXXNQJOUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class KEUWXJDIXVO : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x419AB60", Offset = "0x4199B60", VA = "0x18419AB60")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private KEUWXJDIXVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class XJFZGKZLCCQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly DLUWFSZQQRW[] OIITMUBLDJP;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class RRPQXJGWCED : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x41904F0", Offset = "0x418F4F0", VA = "0x1841904F0")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class NMABSUKDLRJ : DLUWFSZQQRW
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class DCXWQXQGMOI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

				[Cpp2IlInjected.Token(Token = "0x60000B5")]
				[Cpp2IlInjected.Address(RVA = "0x419F0B0", Offset = "0x419E0B0", VA = "0x18419F0B0")]
				static DCXWQXQGMOI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly DLUWFSZQQRW QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly DLUWFSZQQRW[] UTOYMETOWVU;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			private NMABSUKDLRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
			public HQJLNSOHDQB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly HQJLNSOHDQB<object> BGLYOQVDWHP;

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private RRPQXJGWCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class MIMJLANBMRG : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x41ADD70", Offset = "0x41ACD70", VA = "0x1841ADD70")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class NMABSUKDLRJ : DLUWFSZQQRW
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class DCXWQXQGMOI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x4185030", Offset = "0x4184030", VA = "0x184185030")]
				static DCXWQXQGMOI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly DLUWFSZQQRW QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly DLUWFSZQQRW[] UTOYMETOWVU;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			private NMABSUKDLRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
			public HQJLNSOHDQB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly HQJLNSOHDQB<object> BGLYOQVDWHP;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private MIMJLANBMRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class AZOLPVYQXWG : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x41964B0", Offset = "0x41954B0", VA = "0x1841964B0")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class NMABSUKDLRJ : DLUWFSZQQRW
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class DCXWQXQGMOI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

				[Cpp2IlInjected.Token(Token = "0x60000C5")]
				[Cpp2IlInjected.Address(RVA = "0x41A6260", Offset = "0x41A5260", VA = "0x1841A6260")]
				static DCXWQXQGMOI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly DLUWFSZQQRW QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly DLUWFSZQQRW[] UTOYMETOWVU;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			private NMABSUKDLRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
			public HQJLNSOHDQB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly HQJLNSOHDQB<object> BGLYOQVDWHP;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private AZOLPVYQXWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class EWUYNECVMYZ : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x4191F70", Offset = "0x4190F70", VA = "0x184191F70")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class NMABSUKDLRJ : DLUWFSZQQRW
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class DCXWQXQGMOI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x419FF70", Offset = "0x419EF70", VA = "0x18419FF70")]
				static DCXWQXQGMOI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly DLUWFSZQQRW QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly DLUWFSZQQRW[] UTOYMETOWVU;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			private NMABSUKDLRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
			public HQJLNSOHDQB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly HQJLNSOHDQB<object> BGLYOQVDWHP;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private EWUYNECVMYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class TABUGLZRQHF : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x418ACD0", Offset = "0x4189CD0", VA = "0x18418ACD0")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class NMABSUKDLRJ : DLUWFSZQQRW
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class DCXWQXQGMOI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

				[Cpp2IlInjected.Token(Token = "0x60000D5")]
				[Cpp2IlInjected.Address(RVA = "0x4196910", Offset = "0x4195910", VA = "0x184196910")]
				static DCXWQXQGMOI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly DLUWFSZQQRW QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly DLUWFSZQQRW[] UTOYMETOWVU;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			private NMABSUKDLRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
			public HQJLNSOHDQB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly HQJLNSOHDQB<object> BGLYOQVDWHP;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private TABUGLZRQHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class LIHJRYVUKPP : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x417B3C0", Offset = "0x417A3C0", VA = "0x18417B3C0")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class NMABSUKDLRJ : DLUWFSZQQRW
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class DCXWQXQGMOI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x41852F0", Offset = "0x41842F0", VA = "0x1841852F0")]
				static DCXWQXQGMOI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly DLUWFSZQQRW QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly DLUWFSZQQRW[] UTOYMETOWVU;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			private NMABSUKDLRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
			public HQJLNSOHDQB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly HQJLNSOHDQB<object> BGLYOQVDWHP;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private LIHJRYVUKPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class MAYAYOTFXCA : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x41A5D70", Offset = "0x41A4D70", VA = "0x1841A5D70")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class NMABSUKDLRJ : DLUWFSZQQRW
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class DCXWQXQGMOI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x41B8020", Offset = "0x41B7020", VA = "0x1841B8020")]
				static DCXWQXQGMOI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly DLUWFSZQQRW QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly DLUWFSZQQRW[] UTOYMETOWVU;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			private NMABSUKDLRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
			public HQJLNSOHDQB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly HQJLNSOHDQB<object> BGLYOQVDWHP;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private MAYAYOTFXCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class IWOIIMIGSCQ : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x41A9CE0", Offset = "0x41A8CE0", VA = "0x1841A9CE0")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class NMABSUKDLRJ : DLUWFSZQQRW
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class DCXWQXQGMOI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

				[Cpp2IlInjected.Token(Token = "0x60000ED")]
				[Cpp2IlInjected.Address(RVA = "0x419B2A0", Offset = "0x419A2A0", VA = "0x18419B2A0")]
				static DCXWQXQGMOI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly DLUWFSZQQRW QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly DLUWFSZQQRW[] UTOYMETOWVU;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			private NMABSUKDLRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
			public HQJLNSOHDQB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly HQJLNSOHDQB<object> BGLYOQVDWHP;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private IWOIIMIGSCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class JBMGHAVACNQ : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x4194820", Offset = "0x4193820", VA = "0x184194820")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class NMABSUKDLRJ : DLUWFSZQQRW
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class DCXWQXQGMOI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

				[Cpp2IlInjected.Token(Token = "0x60000F5")]
				[Cpp2IlInjected.Address(RVA = "0x417F640", Offset = "0x417E640", VA = "0x18417F640")]
				static DCXWQXQGMOI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly DLUWFSZQQRW QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly DLUWFSZQQRW[] UTOYMETOWVU;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			private NMABSUKDLRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
			public HQJLNSOHDQB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly HQJLNSOHDQB<object> BGLYOQVDWHP;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private JBMGHAVACNQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class LRUNRMFDHQZ : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x4182E10", Offset = "0x4181E10", VA = "0x184182E10")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class NMABSUKDLRJ : DLUWFSZQQRW
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class DCXWQXQGMOI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x41B6C60", Offset = "0x41B5C60", VA = "0x1841B6C60")]
				static DCXWQXQGMOI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly DLUWFSZQQRW QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly DLUWFSZQQRW[] UTOYMETOWVU;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			private NMABSUKDLRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
			public HQJLNSOHDQB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly HQJLNSOHDQB<object> BGLYOQVDWHP;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private LRUNRMFDHQZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class ASROQJMXQEH : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x4185A10", Offset = "0x4184A10", VA = "0x184185A10")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class NMABSUKDLRJ : DLUWFSZQQRW
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class DCXWQXQGMOI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x4183DE0", Offset = "0x4182DE0", VA = "0x184183DE0")]
				static DCXWQXQGMOI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly DLUWFSZQQRW QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly DLUWFSZQQRW[] UTOYMETOWVU;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			private NMABSUKDLRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
			public HQJLNSOHDQB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly HQJLNSOHDQB<object> BGLYOQVDWHP;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private ASROQJMXQEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class BMIJRTOTNRD : DLUWFSZQQRW
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class DCXWQXQGMOI<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x41A1990", Offset = "0x41A0990", VA = "0x1841A1990")]
			static DCXWQXQGMOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class NMABSUKDLRJ : DLUWFSZQQRW
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class DCXWQXQGMOI<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly HQJLNSOHDQB<a> KNKAEZSKFIX;

				[Cpp2IlInjected.Token(Token = "0x600010D")]
				[Cpp2IlInjected.Address(RVA = "0x41B85E0", Offset = "0x41B75E0", VA = "0x1841B85E0")]
				static DCXWQXQGMOI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly DLUWFSZQQRW QSHZKWMVMOA;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly DLUWFSZQQRW[] UTOYMETOWVU;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			private NMABSUKDLRJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
			public HQJLNSOHDQB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly DLUWFSZQQRW QSHZKWMVMOA;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly HQJLNSOHDQB<object> BGLYOQVDWHP;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		private BMIJRTOTNRD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x30DC440", Offset = "0x30DB440", VA = "0x1830DC440", Slot = "4")]
		public HQJLNSOHDQB<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x5BC0EE0", Offset = "0x5BBFEE0", VA = "0x185BC0EE0")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5BC0DC0", Offset = "0x5BBFDC0", VA = "0x185BC0DC0")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5BC0E50", Offset = "0x5BBFE50", VA = "0x185BC0E50")]
		public T[] IZKBKGSGZLR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class FVHQRTSCZKF<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int LHOKTUOZQHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object LECKYHQIUOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int EGJQZYNDVNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] FOWIOSWULQO;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4F23240", Offset = "0x4F22240", VA = "0x184F23240")]
		public FVHQRTSCZKF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4F22F40", Offset = "0x4F21F40", VA = "0x184F22F40")]
		public a[] TQGTFOUUPIQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4F22B70", Offset = "0x4F21B70", VA = "0x184F22B70")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class RWOCKMJMAHX : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class YWXBHAYRBXD : IComparable<YWXBHAYRBXD>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class NNJLJLFLTNT : IEnumerable<YWXBHAYRBXD>, IEnumerable, IEnumerator<YWXBHAYRBXD>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int NNYUMBTASKT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private YWXBHAYRBXD GLROCXYMSEU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int CYUNKNWTKTU;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public YWXBHAYRBXD SULNKEFFSGR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int RRJFDMGHLWT;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private YWXBHAYRBXD WMAZRDGQBHU
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object OPJHDGDZAVH
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000125")]
				[Cpp2IlInjected.Address(RVA = "0xD9D550", Offset = "0xD9C550", VA = "0x180D9D550")]
				[DebuggerHidden]
				public NNJLJLFLTNT(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "7")]
				[DebuggerHidden]
				private void FQZHCUDIKGC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0x9009600", Offset = "0x9008600", VA = "0x189009600", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0x9009680", Offset = "0x9008680", VA = "0x189009680", Slot = "10")]
				[DebuggerHidden]
				private void SEWTXRYPVUP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012B")]
				[Cpp2IlInjected.Address(RVA = "0x9009560", Offset = "0x9008560", VA = "0x189009560", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<YWXBHAYRBXD> BERCTNOCEKJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x9009560", Offset = "0x9008560", VA = "0x189009560", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator HKYUJZELIWO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly YWXBHAYRBXD[] VEWKGPUOBLX;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] XHRHUFENVOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong QZQNBFORTMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int FNDQYUTZTLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string PQQMIGGBYNR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private YWXBHAYRBXD[] RELPKFTAEGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] KFLKGOIZSRQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int MLCEQSTIITQ;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x9010E60", Offset = "0x900FE60", VA = "0x189010E60")]
			public YWXBHAYRBXD(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x90108B0", Offset = "0x900F8B0", VA = "0x1890108B0")]
			public YWXBHAYRBXD Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x9010AB0", Offset = "0x900FAB0", VA = "0x189010AB0")]
			public YWXBHAYRBXD Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9010BC0", Offset = "0x900FBC0", VA = "0x189010BC0")]
			public YWXBHAYRBXD HKVXVTIPTPZ(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x9010D30", Offset = "0x900FD30", VA = "0x189010D30")]
			internal static int QNDPHIPZUCW(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x9010B10", Offset = "0x900FB10", VA = "0x189010B10", Slot = "4")]
			public int CompareTo(YWXBHAYRBXD other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x9010B40", Offset = "0x900FB40", VA = "0x189010B40")]
			[IteratorStateMachine(typeof(NNJLJLFLTNT))]
			public IEnumerable<YWXBHAYRBXD> GUDHLAPNCHN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class GMROPTCSAJN : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int CYUNKNWTKTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<YWXBHAYRBXD> RELPKFTAEGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<YWXBHAYRBXD> NSABEUDZWVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<YWXBHAYRBXD> NVXWRKLJBUP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private YWXBHAYRBXD YARDBOIVIKS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> NWIKLXZDURH;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> GGVSJAMERJC
			{
				[Cpp2IlInjected.Token(Token = "0x6000132")]
				[Cpp2IlInjected.Address(RVA = "0xCE16B0", Offset = "0xCE06B0", VA = "0x180CE16B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x9000800", Offset = "0x8FFF800", VA = "0x189000800", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x1A8A0D0", Offset = "0x1A890D0", VA = "0x181A8A0D0")]
			[DebuggerHidden]
			public GMROPTCSAJN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x9000850", Offset = "0x8FFF850", VA = "0x189000850", Slot = "7")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x9000A40", Offset = "0x8FFFA40", VA = "0x189000A40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x9000EA0", Offset = "0x8FFFEA0", VA = "0x189000EA0")]
			private void QJEWXGNEXZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x9000EF0", Offset = "0x8FFFEF0", VA = "0x189000EF0")]
			private void QJURPAUXAHT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x9000F40", Offset = "0x8FFFF40", VA = "0x189000F40", Slot = "10")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x90009A0", Offset = "0x8FFF9A0", VA = "0x1890009A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> ILAPXQQPQQD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x90009A0", Offset = "0x8FFF9A0", VA = "0x1890009A0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HKYUJZELIWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly YWXBHAYRBXD EQMHNAKVRHZ;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x900D380", Offset = "0x900C380", VA = "0x18900D380")]
		public RWOCKMJMAHX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x900CB30", Offset = "0x900BB30", VA = "0x18900CB30")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x900CD90", Offset = "0x900BD90", VA = "0x18900CD90")]
		public bool DVVDXLGNEBL(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x900D1E0", Offset = "0x900C1E0", VA = "0x18900D1E0")]
		public bool KWVKHOSDENW([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x900D2F0", Offset = "0x900C2F0", VA = "0x18900D2F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x900CF00", Offset = "0x900BF00", VA = "0x18900CF00")]
		private static void KTXIXZCTIFW(IEnumerable<YWXBHAYRBXD> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x900CEA0", Offset = "0x900BEA0", VA = "0x18900CEA0", Slot = "5")]
		private IEnumerator HKYUJZELIWO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x900CEA0", Offset = "0x900BEA0", VA = "0x18900CEA0", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x900CD10", Offset = "0x900BD10", VA = "0x18900CD10")]
		[IteratorStateMachine(typeof(GMROPTCSAJN))]
		private static IEnumerable<KeyValuePair<string, int>> BMSHCFBROML(IEnumerable<YWXBHAYRBXD> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class BUOCGBHAUSK
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo SLWWTTQZLMN;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8FFED30", Offset = "0x8FFDD30", VA = "0x188FFED30")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8FFEEE0", Offset = "0x8FFDEE0", VA = "0x188FFEEE0")]
		public static ulong ORGRNJACNFP(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class WSZEMZKWTVA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9010230", Offset = "0x900F230", VA = "0x189010230")]
		public static void JJUTANPXZLX(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x90104B0", Offset = "0x900F4B0", VA = "0x1890104B0")]
		public static void NSXRLLDMFVX(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9010370", Offset = "0x900F370", VA = "0x189010370")]
		public static byte[] NBSJRDQYMCS(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class ECYBCIFZQDY<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x48FBF20", Offset = "0x48FAF20", VA = "0x1848FBF20", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class HBIMIMXAZCC : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public ECYBCIFZQDY<a> SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] NVXWRKLJBUP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int NWDDORFGLFY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] NWIKLXZDURH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int NWNRJETBECQ;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> KPYPFAICWXJ
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xCE16B0", Offset = "0xCE06B0", VA = "0x180CE16B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0x4FD4560", Offset = "0x4FD3560", VA = "0x184FD4560", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public HBIMIMXAZCC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x50AC210", Offset = "0x50AB210", VA = "0x1850AC210", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x3D47630", Offset = "0x3D46630", VA = "0x183D47630", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] SGYPRMHJHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong ETKMCDGVKHC;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool VIKLVWKVWZP;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x48B0C20", Offset = "0x48AFC20", VA = "0x1848B0C20")]
		public ECYBCIFZQDY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x48B0D30", Offset = "0x48AFD30", VA = "0x1848B0D30")]
		public ECYBCIFZQDY(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x489D1A0", Offset = "0x489C1A0", VA = "0x18489D1A0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x48A7120", Offset = "0x48A6120", VA = "0x1848A7120")]
		private bool GLGTVVXKGNQ(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x489F5B0", Offset = "0x489E5B0", VA = "0x18489F5B0")]
		public bool DVVDXLGNEBL([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x48ACCF0", Offset = "0x48ABCF0", VA = "0x1848ACCF0")]
		private static ulong KURHVCKUCVB([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x48AC060", Offset = "0x48AB060", VA = "0x1848AC060")]
		private static ulong KURHVCKUCVB([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x48ABC00", Offset = "0x48AAC00", VA = "0x1848ABC00")]
		private static int JKOPXPFPZMN(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x48AB7B0", Offset = "0x48AA7B0", VA = "0x1848AB7B0", Slot = "4")]
		[IteratorStateMachine(typeof(ECYBCIFZQDY<>.HBIMIMXAZCC))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x48ABA20", Offset = "0x48AAA20", VA = "0x1848ABA20", Slot = "5")]
		private IEnumerator HKYUJZELIWO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class DWBZVVNQJAX
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x35EF170", Offset = "0x35EE170", VA = "0x1835EF170")]
		public static Func<a> AKMWPZSTIWV<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x35EF260", Offset = "0x35EE260", VA = "0x1835EF260")]
		private static c YXGQHICASMS<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0x9001900", Offset = "0x9000900", VA = "0x189001900")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9001910", Offset = "0x9000910", VA = "0x189001910")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9000F80", Offset = "0x8FFFF80", VA = "0x189000F80")]
		private static byte CTTOYTVXFKK(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8FFDD20", Offset = "0x8FFCD20", VA = "0x188FFDD20")]
		private static byte WFTMLVRVTSS(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9001020", Offset = "0x9000020", VA = "0x189001020")]
		public void VCPJVSQNYKO(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class CCYEDPNGBIS
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x90003D0", Offset = "0x8FFF3D0", VA = "0x1890003D0")]
		public static bool UVNLRSTNNNM(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8FFF880", Offset = "0x8FFE880", VA = "0x188FFF880")]
		public static bool CSAJWBIIHXN(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8FFFD80", Offset = "0x8FFED80", VA = "0x188FFFD80")]
		public static sbyte ILADLQAPBIW([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x90001E0", Offset = "0x8FFF1E0", VA = "0x1890001E0")]
		public static short TIIYLHYFFJF([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8FFFD20", Offset = "0x8FFED20", VA = "0x188FFFD20")]
		public static int HEUYWMEVSHP([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9000490", Offset = "0x8FFF490", VA = "0x189000490")]
		public static long ZGRVXAMSOZE([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9000240", Offset = "0x8FFF240", VA = "0x189000240")]
		public static bool TOIBLHQWSHJ(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8FFFB30", Offset = "0x8FFEB30", VA = "0x188FFFB30")]
		public static byte FAOGFZJFLMN([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8FFF820", Offset = "0x8FFE820", VA = "0x188FFF820")]
		public static ushort BNEFGWZNYDK([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9000010", Offset = "0x8FFF010", VA = "0x189000010")]
		public static uint NNLYNOMNQFM([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x90003E0", Offset = "0x8FFF3E0", VA = "0x1890003E0")]
		public static ulong VPQJKFMQAGV([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8FFF8F0", Offset = "0x8FFE8F0", VA = "0x188FFF8F0")]
		public static bool DPJPWCHRWVE(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9000540", Offset = "0x8FFF540", VA = "0x189000540")]
		public static bool ZRYGCDBBLAM(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9000070", Offset = "0x8FFF070", VA = "0x189000070")]
		public static bool SBQTJRHDHHI(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8FFFC80", Offset = "0x8FFEC80", VA = "0x188FFFC80")]
		public static bool GTCPJEVOJOA(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8FFFB90", Offset = "0x8FFEB90", VA = "0x188FFFB90")]
		public static float FRMGTXFINZV([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9000180", Offset = "0x8FFF180", VA = "0x189000180")]
		public static bool SXZGJXUPATS(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8FFFA40", Offset = "0x8FFEA40", VA = "0x188FFFA40")]
		public static double DQCHPAFGQAG([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8FFFDE0", Offset = "0x8FFEDE0", VA = "0x188FFFDE0")]
		public static bool JYDTJBZAARX(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8FFCB60", Offset = "0x8FFBB60", VA = "0x188FFCB60")]
		public static int WLJZRWUPZZG(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8FFD210", Offset = "0x8FFC210", VA = "0x188FFD210")]
		public static int XBJPVXLYGTL(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8FFFE40", Offset = "0x8FFEE40", VA = "0x188FFFE40")]
		public static bool MNBVQCEEXGR([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class KOLCWETEYQQ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x90085C0", Offset = "0x90075C0", VA = "0x1890085C0")]
		public static bool TGJVJWFKQLE(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class QYNCMLAJJWL
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding HDJCMEXOTLO;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class QLLPBHEYTRJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9003270", Offset = "0x9002270", VA = "0x189003270")]
		public static void HEBWIGWUQOE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x90032E0", Offset = "0x90022E0", VA = "0x1890032E0")]
		public static void HEHDFNQRZZN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9003350", Offset = "0x9002350", VA = "0x189003350")]
		public static void HEMKCUKPJKW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x90033C0", Offset = "0x90023C0", VA = "0x1890033C0")]
		public static void HERRABEMSWF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x900C2E0", Offset = "0x900B2E0", VA = "0x18900C2E0")]
		public static void HGNBBKBOZUI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x900C350", Offset = "0x900B350", VA = "0x18900C350")]
		public static void HGSHYQVMJFR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x900C270", Offset = "0x900B270", VA = "0x18900C270")]
		public static void BSLINHTEUBT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x900C200", Offset = "0x900B200", VA = "0x18900C200")]
		public static void BSGBQAZHKQK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x900C190", Offset = "0x900B190", VA = "0x18900C190")]
		public static void BSAUSUFKBFB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x900C110", Offset = "0x900B110", VA = "0x18900C110")]
		public static void BRVNVNLMRTS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x900C090", Offset = "0x900B090", VA = "0x18900C090")]
		public static void BRQGYGRPIIJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x900C010", Offset = "0x900B010", VA = "0x18900C010")]
		public static void BRLAAZXRYXA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x900BF90", Offset = "0x900AF90", VA = "0x18900BF90")]
		public static void BRFTDTDUPLR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x900BF10", Offset = "0x900AF10", VA = "0x18900BF10")]
		public static void BRAMGMJXGAI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x900BE90", Offset = "0x900AE90", VA = "0x18900BE90")]
		public static void BQVFJFPZWOZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x900BE10", Offset = "0x900AE10", VA = "0x18900BE10")]
		public static void BQPYLYWCNDQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x900C4C0", Offset = "0x900B4C0", VA = "0x18900C4C0")]
		public static void IMQAVRONTVA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x900C540", Offset = "0x900B540", VA = "0x18900C540")]
		public static void IMVHSYILDGJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x900C3C0", Offset = "0x900B3C0", VA = "0x18900C3C0")]
		public static void IMFNBEATAYI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x900C440", Offset = "0x900B440", VA = "0x18900C440")]
		public static void IMKTYKUQKJR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x900C6E0", Offset = "0x900B6E0", VA = "0x18900C6E0")]
		public static void INLCKSQDFOK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x900C760", Offset = "0x900B760", VA = "0x18900C760")]
		public static void INQJHZKAOZT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x900C5C0", Offset = "0x900B5C0", VA = "0x18900C5C0")]
		public static void INAOQFCIMRS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x900C650", Offset = "0x900B650", VA = "0x18900C650")]
		public static void INFVNLWFWDB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x900C7F0", Offset = "0x900B7F0", VA = "0x18900C7F0")]
		public static void IOGDZTRSRHU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x900C880", Offset = "0x900B880", VA = "0x18900C880")]
		public static void IOLKXALQATD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x900C9A0", Offset = "0x900B9A0", VA = "0x18900C9A0")]
		public static void PNHFUJWQJNJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x900C910", Offset = "0x900B910", VA = "0x18900C910")]
		public static void PNBYXDCTACA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9003430", Offset = "0x9002430", VA = "0x189003430")]
		public static void HFCEUOSHLSX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x90034A0", Offset = "0x90024A0", VA = "0x1890034A0")]
		public static void HFHLRVMEVEG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9003510", Offset = "0x9002510", VA = "0x189003510")]
		public static void HFMSPCGCEPP(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class IPTQUYRPZPC
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9003580", Offset = "0x9002580", VA = "0x189003580")]
		public static void HGNBBKBOZUI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x90035F0", Offset = "0x90025F0", VA = "0x1890035F0")]
		public static void HGSHYQVMJFR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9003200", Offset = "0x9002200", VA = "0x189003200")]
		public static void BSLINHTEUBT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9003190", Offset = "0x9002190", VA = "0x189003190")]
		public static void BSGBQAZHKQK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9003120", Offset = "0x9002120", VA = "0x189003120")]
		public static void BSAUSUFKBFB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x90030B0", Offset = "0x90020B0", VA = "0x1890030B0")]
		public static void BRVNVNLMRTS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x9003040", Offset = "0x9002040", VA = "0x189003040")]
		public static void BRQGYGRPIIJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9002FD0", Offset = "0x9001FD0", VA = "0x189002FD0")]
		public static void BRLAAZXRYXA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9002F60", Offset = "0x9001F60", VA = "0x189002F60")]
		public static void BRFTDTDUPLR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9002EE0", Offset = "0x9001EE0", VA = "0x189002EE0")]
		public static void BRAMGMJXGAI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x9002E60", Offset = "0x9001E60", VA = "0x189002E60")]
		public static void BQVFJFPZWOZ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9002DE0", Offset = "0x9001DE0", VA = "0x189002DE0")]
		public static void BQPYLYWCNDQ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9003760", Offset = "0x9002760", VA = "0x189003760")]
		public static void IMQAVRONTVA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x90037E0", Offset = "0x90027E0", VA = "0x1890037E0")]
		public static void IMVHSYILDGJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9003660", Offset = "0x9002660", VA = "0x189003660")]
		public static void IMFNBEATAYI(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x90036E0", Offset = "0x90026E0", VA = "0x1890036E0")]
		public static void IMKTYKUQKJR(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9003960", Offset = "0x9002960", VA = "0x189003960")]
		public static void INLCKSQDFOK(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x90039E0", Offset = "0x90029E0", VA = "0x1890039E0")]
		public static void INQJHZKAOZT(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9003860", Offset = "0x9002860", VA = "0x189003860")]
		public static void INAOQFCIMRS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x90038E0", Offset = "0x90028E0", VA = "0x1890038E0")]
		public static void INFVNLWFWDB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x9003A60", Offset = "0x9002A60", VA = "0x189003A60")]
		public static void IOGDZTRSRHU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x9003AE0", Offset = "0x9002AE0", VA = "0x189003AE0")]
		public static void IOLKXALQATD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x9003BE0", Offset = "0x9002BE0", VA = "0x189003BE0")]
		public static void PNHFUJWQJNJ(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9003B60", Offset = "0x9002B60", VA = "0x189003B60")]
		public static void PNBYXDCTACA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9003430", Offset = "0x9002430", VA = "0x189003430")]
		public static void HFCEUOSHLSX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x90034A0", Offset = "0x90024A0", VA = "0x1890034A0")]
		public static void HFHLRVMEVEG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x9003510", Offset = "0x9002510", VA = "0x189003510")]
		public static void HFMSPCGCEPP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x9003270", Offset = "0x9002270", VA = "0x189003270")]
		public static void HEBWIGWUQOE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x90032E0", Offset = "0x90022E0", VA = "0x1890032E0")]
		public static void HEHDFNQRZZN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9003350", Offset = "0x9002350", VA = "0x189003350")]
		public static void HEMKCUKPJKW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x90033C0", Offset = "0x90023C0", VA = "0x1890033C0")]
		public static void HERRABEMSWF(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class DYCOIZQJVYC
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool VIKLVWKVWZP;

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x9015E90", Offset = "0x9014E90", VA = "0x189015E90")]
		public static void TQOXAQDXAGA(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x9015E00", Offset = "0x9014E00", VA = "0x189015E00")]
		public static void QREOCSLYRDL(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x290A050", Offset = "0x2909050", VA = "0x18290A050")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9017AA0", Offset = "0x9016AA0", VA = "0x189017AA0")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x90178D0", Offset = "0x90168D0", VA = "0x1890178D0")]
		public static DiyFp JBJBYYFBHPT(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x9017A10", Offset = "0x9016A10", VA = "0x189017A10")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x90178E0", Offset = "0x90168E0", VA = "0x1890178E0")]
		public static DiyFp LTDQKIICLKP(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x90179D0", Offset = "0x90169D0", VA = "0x1890179D0")]
		public void MJSBXBXVSNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9017980", Offset = "0x9016980", VA = "0x189017980")]
		public static DiyFp MJSBXBXVSNA(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xB43010", Offset = "0xB42010", VA = "0x180B43010")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x90226C0", Offset = "0x90216C0", VA = "0x1890226C0")]
		public void MCDBKHVTWZL(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x9022720", Offset = "0x9021720", VA = "0x189022720")]
		public void OSYRTRHNKOP(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x90227A0", Offset = "0x90217A0", VA = "0x1890227A0")]
		public void SZUJIZHFDVD(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9022820", Offset = "0x9021820", VA = "0x189022820")]
		public void SZUJIZHFDVD(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x9022540", Offset = "0x9021540", VA = "0x189022540")]
		public void BNGBNSUPJJV(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x90225C0", Offset = "0x90215C0", VA = "0x1890225C0")]
		public void ITLDXCSUGAC(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class BSBAJBDUKHE
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
		private static byte[] VNYXFHIYVOX;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] LHBJYKDZGLN;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] GDKUCDOSSZH;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] KGPHIYHNFPA;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags NUGKXLRAGUT;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char MMYSMYDDNND;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int ZICOANIZLRR;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int BGRTVENSVUV;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] XHRYGRNWSTZ;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x9015170", Offset = "0x9014170", VA = "0x189015170")]
		private static byte[] TQFSZFEDMQZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x90155D0", Offset = "0x90145D0", VA = "0x1890155D0")]
		private static byte[] YXBOXHRVESZ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9014230", Offset = "0x9013230", VA = "0x189014230")]
		public static int MFRVPKRZXYU(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x9014350", Offset = "0x9013350", VA = "0x189014350")]
		public static int MFRVPKRZXYU(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x9013C80", Offset = "0x9012C80", VA = "0x189013C80")]
		private static bool DDTHSVENQOM(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x9013B90", Offset = "0x9012B90", VA = "0x189013B90")]
		private static void BMOHOIALFAU(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x9013D70", Offset = "0x9012D70", VA = "0x189013D70")]
		private static bool ECLNGWCZDWK(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9014470", Offset = "0x9013470", VA = "0x189014470")]
		private static bool MRGZYYMRPPQ(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9014130", Offset = "0x9013130", VA = "0x189014130")]
		private static bool HZXKFSVWVZD(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9014AE0", Offset = "0x9013AE0", VA = "0x189014AE0")]
		private static bool SJENRACTKKO(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x9014CA0", Offset = "0x9013CA0", VA = "0x189014CA0")]
		private static bool SWDWJEUAGBL(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x9015240", Offset = "0x9014240", VA = "0x189015240")]
		private static void XMTFTKDZQNZ(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9013750", Offset = "0x9012750", VA = "0x189013750")]
		private static void AMTNJHVEYTZ(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x90148F0", Offset = "0x90138F0", VA = "0x1890148F0")]
		private static bool PWORNREZYNU(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0x90180D0", Offset = "0x90170D0", VA = "0x1890180D0")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9018030", Offset = "0x9017030", VA = "0x189018030")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x9017DD0", Offset = "0x9016DD0", VA = "0x189017DD0")]
		public DiyFp TBZYQKYLOKF()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x9017EA0", Offset = "0x9016EA0", VA = "0x189017EA0")]
		public DiyFp YDYMVYTBCDE()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xC41C30", Offset = "0xC40C30", VA = "0x180C41C30")]
		public ulong EDUYFLXUTRD()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x9017AB0", Offset = "0x9016AB0", VA = "0x189017AB0")]
		public double BCBIKMXTWIL()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x9017F20", Offset = "0x9016F20", VA = "0x189017F20")]
		public double YGJUTVAITHF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x9017FC0", Offset = "0x9016FC0", VA = "0x189017FC0")]
		public int YLCWHFPYFUY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x9017D50", Offset = "0x9016D50", VA = "0x189017D50")]
		public ulong QBRZMTIMKLA()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x9017D30", Offset = "0x9016D30", VA = "0x189017D30")]
		public bool HIJTUXYLUQD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x9017E80", Offset = "0x9016E80", VA = "0x189017E80")]
		public bool WUAWAGZDUZQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x9018000", Offset = "0x9017000", VA = "0x189018000")]
		public bool YSHZHMKHKBC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x9017B30", Offset = "0x9016B30", VA = "0x189017B30")]
		public bool CYNBEOAXNRJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x9017E60", Offset = "0x9016E60", VA = "0x189017E60")]
		public int WEXZFAHYRPY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x9017BF0", Offset = "0x9016BF0", VA = "0x189017BF0")]
		public void GLHYOJVXYIE([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x9017D80", Offset = "0x9016D80", VA = "0x189017D80")]
		public bool SRPLQLOUPKA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3C17EB0", Offset = "0x3C16EB0", VA = "0x183C17EB0")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x9017E40", Offset = "0x9016E40", VA = "0x189017E40")]
		public static int TOYMUXPWACD(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x9017FF0", Offset = "0x9016FF0", VA = "0x189017FF0")]
		public static double YNSWUEFHIFN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x9017B60", Offset = "0x9016B60", VA = "0x189017B60")]
		public static ulong FDGHHFBWEQO(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x15EAB50", Offset = "0x15E9B50", VA = "0x1815EAB50")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x90224C0", Offset = "0x90214C0", VA = "0x1890224C0")]
		public DiyFp TBZYQKYLOKF()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xCEC5F0", Offset = "0xCEB5F0", VA = "0x180CEC5F0")]
		public uint WICZZDKLZOW()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x9022520", Offset = "0x9021520", VA = "0x189022520")]
		public int YLCWHFPYFUY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9022460", Offset = "0x9021460", VA = "0x189022460")]
		public uint QBRZMTIMKLA()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x9022450", Offset = "0x9021450", VA = "0x189022450")]
		public bool HIJTUXYLUQD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9022320", Offset = "0x9021320", VA = "0x189022320")]
		public void GLHYOJVXYIE([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9022480", Offset = "0x9021480", VA = "0x189022480")]
		public bool SRPLQLOUPKA()
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
		[Cpp2IlInjected.Address(RVA = "0x9015DF0", Offset = "0x9014DF0", VA = "0x189015DF0")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class MWZZYIYHQDB
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] MEQXZQGYOME;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x901E1A0", Offset = "0x901D1A0", VA = "0x18901E1A0")]
		public static void XCBIONKAORQ(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x901E0D0", Offset = "0x901D0D0", VA = "0x18901E0D0")]
		public static void PUUZLWPIDTH(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0x9027890", Offset = "0x9026890", VA = "0x189027890")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x3D41540", Offset = "0x3D40540", VA = "0x183D41540")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B3CF80", Offset = "0x2B3BF80", VA = "0x182B3CF80")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x9027830", Offset = "0x9026830", VA = "0x189027830")]
		public Vector QJXYBSCGCIA(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class XMUIGVSNCNI
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] YSTILYEHYXC;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] PWTEXVMYQHB;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int BNYIYUOHXMG;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x902A200", Offset = "0x9029200", VA = "0x18902A200")]
		private static byte[] WDSZPKMNJDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x9029C80", Offset = "0x9028C80", VA = "0x189029C80")]
		private static Vector PROAWWYADKG(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9029BA0", Offset = "0x9028BA0", VA = "0x189029BA0")]
		private static Vector NZRJHXJNBPA(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x9029B10", Offset = "0x9028B10", VA = "0x189029B10")]
		private static void MFIJMBUFUKL(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9029F10", Offset = "0x9028F10", VA = "0x189029F10")]
		private static void UDXWRWOPSFG(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9029D60", Offset = "0x9028D60", VA = "0x189029D60")]
		private static ulong QBGZJGKITLH(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9028E50", Offset = "0x9027E50", VA = "0x189028E50")]
		private static void FTJQEGLKPYV(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x9028F90", Offset = "0x9027F90", VA = "0x189028F90")]
		private static bool IOCSGCHUQWM(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x9029340", Offset = "0x9028340", VA = "0x189029340")]
		private static DiyFp JLGHLQRRXKP(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x90294D0", Offset = "0x90284D0", VA = "0x1890294D0")]
		private static bool KUKANZBDNIL(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9029DF0", Offset = "0x9028DF0", VA = "0x189029DF0")]
		private static bool TNRWYZGIDJP(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9028D30", Offset = "0x9027D30", VA = "0x189028D30")]
		public static double? EAYPYODPXPL(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x9028A60", Offset = "0x9027A60", VA = "0x189028A60")]
		public static float? EAOCEAPVEST(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class VHIVFXVOTOK
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] RCCWNWISFEC;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] GDKUCDOSSZH;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] KGPHIYHNFPA;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] OEUUNQWXKDW;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int HACKFAWURKA;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] DCUHKBMVCPC;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int XHRBSASNVYY;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x9025E30", Offset = "0x9024E30", VA = "0x189025E30")]
		private static byte[] QSUFRAVHLJZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x9025F10", Offset = "0x9024F10", VA = "0x189025F10")]
		public static bool SXZGJXUPATS(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x90259C0", Offset = "0x90249C0", VA = "0x1890259C0")]
		public static bool JYDTJBZAARX(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x9025890", Offset = "0x9024890", VA = "0x189025890")]
		private static bool JJRSXYUIOOW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x9025B00", Offset = "0x9024B00", VA = "0x189025B00")]
		private static bool MOLNMLBGUAN(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x90257B0", Offset = "0x90247B0", VA = "0x1890257B0")]
		private static bool DWSSEPLMSCS(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x9025DC0", Offset = "0x9024DC0", VA = "0x189025DC0")]
		private static bool PBXANAOMSEC(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x9026050", Offset = "0x9025050", VA = "0x189026050")]
		private static double WRKSXEIEJIB(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x9026070", Offset = "0x9025070", VA = "0x189026070")]
		private static double ZCTGRWHFFNJ(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class UXHHGEYJKDX<a> : HQJLNSOHDQB<a[]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly FVHQRTSCZKF<a> HUBOULMJPWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour FYNXGVSGYBA;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x16E2050", Offset = "0x16E1050", VA = "0x1816E2050")]
		public UXHHGEYJKDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
		public UXHHGEYJKDX(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x63E5AE0", Offset = "0x63E4AE0", VA = "0x1863E5AE0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x63E57A0", Offset = "0x63E47A0", VA = "0x1863E57A0", Slot = "5")]
		public a[] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class KSFNHCFAQOG<a> : HQJLNSOHDQB<ArraySegment<a>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly FVHQRTSCZKF<a> HUBOULMJPWK;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5463060", Offset = "0x5462060", VA = "0x185463060", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5462BF0", Offset = "0x5461BF0", VA = "0x185462BF0", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class CILIKRGUMNW<a> : HQJLNSOHDQB<List<a>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour FYNXGVSGYBA;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x16E2050", Offset = "0x16E1050", VA = "0x1816E2050")]
		public CILIKRGUMNW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
		public CILIKRGUMNW(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD590", Offset = "0x3ECC590", VA = "0x183ECD590", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x3ECD370", Offset = "0x3ECC370", VA = "0x183ECD370", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class BHYQMXIYCUS<a, b, c, d> : HQJLNSOHDQB<d>, NLVSGIAJTPY where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x3D4E5C0", Offset = "0x3D4D5C0", VA = "0x183D4E5C0", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3D4D710", Offset = "0x3D4C710", VA = "0x183D4D710", Slot = "5")]
		public d Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c WAOGCSOTXXU(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		protected BHYQMXIYCUS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class BGYIAPNLHPZ<a, b, c> : BHYQMXIYCUS<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AE70", Offset = "0x3D49E70", VA = "0x183D4AE70", Slot = "6")]
		protected override IEnumerator<a> WAOGCSOTXXU(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		protected BGYIAPNLHPZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class BGTBDITNYEQ<a, b> : BGYIAPNLHPZ<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xB316F0", Offset = "0xB306F0", VA = "0x180B316F0", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class PHNFAXZZPUQ<a, b> : BGTBDITNYEQ<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x5DBF0B0", Offset = "0x5DBE0B0", VA = "0x185DBF0B0", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5DBEFB0", Offset = "0x5DBDFB0", VA = "0x185DBEFB0", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class FNZMGVGLBVV<a> : BHYQMXIYCUS<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4F111C0", Offset = "0x4F101C0", VA = "0x184F111C0", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0xB316F0", Offset = "0xB306F0", VA = "0x180B316F0", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x4F112B0", Offset = "0x4F102B0", VA = "0x184F112B0", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x471BB20", Offset = "0x471AB20", VA = "0x18471BB20", Slot = "6")]
		protected override LinkedList<a>.Enumerator WAOGCSOTXXU(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class WLHPZDUHINE<a> : BHYQMXIYCUS<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x3E99490", Offset = "0x3E98490", VA = "0x183E99490", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x3E99580", Offset = "0x3E98580", VA = "0x183E99580", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x3F31790", Offset = "0x3F30790", VA = "0x183F31790", Slot = "6")]
		protected override Queue<a>.Enumerator WAOGCSOTXXU(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xB316F0", Offset = "0xB306F0", VA = "0x180B316F0", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class HCYFAOEGGHI<a> : BHYQMXIYCUS<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x3F439B0", Offset = "0x3F429B0", VA = "0x183F439B0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4F10EC0", Offset = "0x4F0FEC0", VA = "0x184F10EC0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x50AD880", Offset = "0x50AC880", VA = "0x1850AD880", Slot = "6")]
		protected override Stack<a>.Enumerator WAOGCSOTXXU(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x50AD710", Offset = "0x50AC710", VA = "0x1850AD710", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class YZDRRDXFYCG<a> : BHYQMXIYCUS<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x3F315B0", Offset = "0x3F305B0", VA = "0x183F315B0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xB316F0", Offset = "0xB306F0", VA = "0x180B316F0", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3F316E0", Offset = "0x3F306E0", VA = "0x183F316E0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3F31740", Offset = "0x3F30740", VA = "0x183F31740", Slot = "6")]
		protected override HashSet<a>.Enumerator WAOGCSOTXXU(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3E93B40", Offset = "0x3E92B40", VA = "0x183E93B40")]
		public YZDRRDXFYCG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class ZKODPPXBGMG<a> : BGYIAPNLHPZ<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x3F439B0", Offset = "0x3F429B0", VA = "0x183F439B0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x3F43A90", Offset = "0x3F42A90", VA = "0x183F43A90", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3F43B30", Offset = "0x3F42B30", VA = "0x183F43B30", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class XNNQRSTETRB<a> : BGYIAPNLHPZ<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x3E99490", Offset = "0x3E98490", VA = "0x183E99490", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x3E99580", Offset = "0x3E98580", VA = "0x183E99580", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xB316F0", Offset = "0xB306F0", VA = "0x180B316F0", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class DQXKOIWDLSD<a> : BGYIAPNLHPZ<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x3E99490", Offset = "0x3E98490", VA = "0x183E99490", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x3E99580", Offset = "0x3E98580", VA = "0x183E99580", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0xB316F0", Offset = "0xB306F0", VA = "0x180B316F0", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class UKUQGRWJZQJ<a> : BGYIAPNLHPZ<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x4F10C70", Offset = "0x4F0FC70", VA = "0x184F10C70", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x4F10EC0", Offset = "0x4F0FEC0", VA = "0x184F10EC0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x50B39F0", Offset = "0x50B29F0", VA = "0x1850B39F0", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x50B3A10", Offset = "0x50B2A10", VA = "0x1850B3A10")]
		public UKUQGRWJZQJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class LDHOCMMWLPH<a, b> : HQJLNSOHDQB<IGrouping<a, b>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x551B700", Offset = "0x551A700", VA = "0x18551B700", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x551B3A0", Offset = "0x551A3A0", VA = "0x18551B3A0", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class YURDCNVVWII<a, b> : HQJLNSOHDQB<ILookup<a, b>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x3F2F9A0", Offset = "0x3F2E9A0", VA = "0x183F2F9A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x3F2F640", Offset = "0x3F2E640", VA = "0x183F2F640", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class DZBZZRILOBC<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a MFGYHTMRNRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> IILYSRHNZCO;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x3D3F0F0", Offset = "0x3D3E0F0", VA = "0x183D3F0F0", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x423A180", Offset = "0x4239180", VA = "0x18423A180")]
		public DZBZZRILOBC(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x423A0E0", Offset = "0x42390E0", VA = "0x18423A0E0", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x423A150", Offset = "0x4239150", VA = "0x18423A150", Slot = "6")]
		private IEnumerator HKYUJZELIWO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class JJKWPSJOZGT<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> WBUNYGHQMQT;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x52AF840", Offset = "0x52AE840", VA = "0x1852AF840", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public JJKWPSJOZGT(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x52AF6A0", Offset = "0x52AE6A0", VA = "0x1852AF6A0", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x52AF790", Offset = "0x52AE790", VA = "0x1852AF790", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x52AF790", Offset = "0x52AE790", VA = "0x1852AF790", Slot = "7")]
		private IEnumerator HKYUJZELIWO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class ZHQSHKHHEJG<a> : HQJLNSOHDQB<a>, NLVSGIAJTPY where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B540", Offset = "0x3F3A540", VA = "0x183F3B540", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B320", Offset = "0x3F3A320", VA = "0x183F3B320", Slot = "5")]
		public a Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public ZHQSHKHHEJG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class BMKBPWLYLOK : HQJLNSOHDQB<IEnumerable>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly HQJLNSOHDQB<IEnumerable> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x90133D0", Offset = "0x90123D0", VA = "0x1890133D0", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x90131C0", Offset = "0x90121C0", VA = "0x1890131C0", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public BMKBPWLYLOK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class PSGUGWKHSHS : HQJLNSOHDQB<ICollection>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly HQJLNSOHDQB<ICollection> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x901FCE0", Offset = "0x901ECE0", VA = "0x18901FCE0", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x901FAD0", Offset = "0x901EAD0", VA = "0x18901FAD0", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public PSGUGWKHSHS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class ZXPPTXYDLAA : HQJLNSOHDQB<IList>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly HQJLNSOHDQB<IList> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x902B460", Offset = "0x902A460", VA = "0x18902B460", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x902B250", Offset = "0x902A250", VA = "0x18902B250", Slot = "5")]
		public IList Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public ZXPPTXYDLAA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class SCLCLFBKNIT<a> : BGTBDITNYEQ<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x3E99490", Offset = "0x3E98490", VA = "0x183E99490", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x5185770", Offset = "0x5184770", VA = "0x185185770", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class IGZOLQFXXAR<a> : BGYIAPNLHPZ<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x3E99490", Offset = "0x3E98490", VA = "0x183E99490", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x5185770", Offset = "0x5184770", VA = "0x185185770", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5185700", Offset = "0x5184700", VA = "0x185185700", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class FMVQBWGYFLX<a> : BGYIAPNLHPZ<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x4F10CD0", Offset = "0x4F0FCD0", VA = "0x184F10CD0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x4F10EC0", Offset = "0x4F0FEC0", VA = "0x184F10EC0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x4F10DD0", Offset = "0x4F0FDD0", VA = "0x184F10DD0", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x4F10F00", Offset = "0x4F0FF00", VA = "0x184F10F00")]
		public FMVQBWGYFLX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class HHCWZWJBEMF<a> : BGYIAPNLHPZ<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x4F10CD0", Offset = "0x4F0FCD0", VA = "0x184F10CD0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x4F10EC0", Offset = "0x4F0FEC0", VA = "0x184F10EC0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x50B39F0", Offset = "0x50B29F0", VA = "0x1850B39F0", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x50B3A10", Offset = "0x50B2A10", VA = "0x1850B3A10")]
		public HHCWZWJBEMF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class AORLJHDLYUL<a> : BGYIAPNLHPZ<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x3F315F0", Offset = "0x3F305F0", VA = "0x183F315F0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xB316F0", Offset = "0xB306F0", VA = "0x180B316F0", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x4F112B0", Offset = "0x4F102B0", VA = "0x184F112B0", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class JRIJHHGHLWF<a> : BGTBDITNYEQ<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x3E99490", Offset = "0x3E98490", VA = "0x183E99490", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x3E99580", Offset = "0x3E98580", VA = "0x183E99580", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class UUDBKTSSPJM<a> : BGTBDITNYEQ<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x3E99490", Offset = "0x3E98490", VA = "0x183E99490", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3E99580", Offset = "0x3E98580", VA = "0x183E99580", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class UVBVRXWKIJF<a> : BGYIAPNLHPZ<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x3F439B0", Offset = "0x3F429B0", VA = "0x183F439B0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x4F10EC0", Offset = "0x4F0FEC0", VA = "0x184F10EC0", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x63E3380", Offset = "0x63E2380", VA = "0x1863E3380", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class MSNTGLJRRUG
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
		[Cpp2IlInjected.Address(RVA = "0x901DC30", Offset = "0x901CC30", VA = "0x18901DC30")]
		public static DateTime PGGBJNKOXQW(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x901DCF0", Offset = "0x901CCF0", VA = "0x18901DCF0")]
		public static bool VFNLOCZCAGF(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x901D9A0", Offset = "0x901C9A0", VA = "0x18901D9A0")]
		public static bool MPEAMJNBZLT(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x901D790", Offset = "0x901C790", VA = "0x18901D790")]
		public static bool MPEAMJNBZLT(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x901DEA0", Offset = "0x901CEA0", VA = "0x18901DEA0")]
		public static bool YOJDSIUCTBB(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class TEUCVOJFYSO : HQJLNSOHDQB<DateTime>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly HQJLNSOHDQB<DateTime> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9023240", Offset = "0x9022240", VA = "0x189023240", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9022CC0", Offset = "0x9021CC0", VA = "0x189022CC0", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9022E40", Offset = "0x9021E40", VA = "0x189022E40")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public TEUCVOJFYSO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class QJYYMGGEULN : HQJLNSOHDQB<DateTimeOffset>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly HQJLNSOHDQB<DateTimeOffset> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x90205E0", Offset = "0x901F5E0", VA = "0x1890205E0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9020190", Offset = "0x901F190", VA = "0x189020190", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9020200", Offset = "0x901F200", VA = "0x189020200")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public QJYYMGGEULN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class WISTWQIIWAG : HQJLNSOHDQB<TimeSpan>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly HQJLNSOHDQB<TimeSpan> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] QPWKGFHZGEG;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x9028160", Offset = "0x9027160", VA = "0x189028160", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x90280E0", Offset = "0x90270E0", VA = "0x1890280E0", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x9027CF0", Offset = "0x9026CF0", VA = "0x189027CF0")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public WISTWQIIWAG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class KMKDSVLPCPH<a, b, c, d, e> : HQJLNSOHDQB<e>, NLVSGIAJTPY where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x545CFB0", Offset = "0x545BFB0", VA = "0x18545CFB0", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x54579F0", Offset = "0x54569F0", VA = "0x1854579F0", Slot = "5")]
		public e Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d WAOGCSOTXXU(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		protected KMKDSVLPCPH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class KMEWVORRTDY<a, b, c, d> : KMKDSVLPCPH<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AE70", Offset = "0x3D49E70", VA = "0x183D4AE70", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> WAOGCSOTXXU(d a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		protected KMEWVORRTDY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class KLEOJGWEXZF<a, b, c> : KMEWVORRTDY<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xB316F0", Offset = "0xB306F0", VA = "0x180B316F0", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class METNDAQNTOB<a, b> : KMKDSVLPCPH<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5A87940", Offset = "0x5A86940", VA = "0x185A87940", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xB316F0", Offset = "0xB306F0", VA = "0x180B316F0", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5A87A00", Offset = "0x5A86A00", VA = "0x185A87A00", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x5A87C30", Offset = "0x5A86C30", VA = "0x185A87C30", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator WAOGCSOTXXU(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x55E15B0", Offset = "0x55E05B0", VA = "0x1855E15B0")]
		public METNDAQNTOB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class MEKCKQUBMBV<a, b, c> : KLEOJGWEXZF<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5A7E6F0", Offset = "0x5A7D6F0", VA = "0x185A7E6F0", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5A7E8F0", Offset = "0x5A7D8F0", VA = "0x185A7E8F0", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class DCPOUFQGKPU<a, b> : KMEWVORRTDY<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x3E938D0", Offset = "0x3E928D0", VA = "0x183E938D0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B970", Offset = "0x3F3A970", VA = "0x183F3B970", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xB316F0", Offset = "0xB306F0", VA = "0x180B316F0", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class VOWKHRUFHOC<a, b> : KLEOJGWEXZF<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3E938D0", Offset = "0x3E928D0", VA = "0x183E938D0", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B970", Offset = "0x3F3A970", VA = "0x183F3B970", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class ZIHGRQGHPIG<a, b> : KMKDSVLPCPH<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x3E938D0", Offset = "0x3E928D0", VA = "0x183E938D0", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB316F0", Offset = "0xB306F0", VA = "0x180B316F0", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B970", Offset = "0x3F3A970", VA = "0x183F3B970", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B9D0", Offset = "0x3F3A9D0", VA = "0x183F3B9D0", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator WAOGCSOTXXU(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class AMKEMYNCHKX<a, b> : KMEWVORRTDY<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E938D0", Offset = "0x3E928D0", VA = "0x183E938D0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x58B5990", Offset = "0x58B4990", VA = "0x1858B5990", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x58B5A00", Offset = "0x58B4A00", VA = "0x1858B5A00", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class XGUYSHFVZOM<a, b> : KMEWVORRTDY<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x3E93A40", Offset = "0x3E92A40", VA = "0x183E93A40", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xB316F0", Offset = "0xB306F0", VA = "0x180B316F0", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x3E93AE0", Offset = "0x3E92AE0", VA = "0x183E93AE0", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E93B40", Offset = "0x3E92B40", VA = "0x183E93B40")]
		public XGUYSHFVZOM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class IDYDJMNPEIG<a, b> : KLEOJGWEXZF<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x51824B0", Offset = "0x51814B0", VA = "0x1851824B0", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B970", Offset = "0x3F3A970", VA = "0x183F3B970", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class BNHHQNOVMCM<a> : HQJLNSOHDQB<a>, NLVSGIAJTPY where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D53490", Offset = "0x3D52490", VA = "0x183D53490", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x3D53250", Offset = "0x3D52250", VA = "0x183D53250", Slot = "5")]
		public a Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public BNHHQNOVMCM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class MBNUYIPHTJO : HQJLNSOHDQB<IDictionary>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly HQJLNSOHDQB<IDictionary> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x901CA30", Offset = "0x901BA30", VA = "0x18901CA30", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x901C850", Offset = "0x901B850", VA = "0x18901C850", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public MBNUYIPHTJO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class ATBXTSWFWLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x9011CB0", Offset = "0x9010CB0", VA = "0x189011CB0")]
		public static object YXEHJAIPICG(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x90114F0", Offset = "0x90104F0", VA = "0x1890114F0")]
		public static object OGOTWWESCXN(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class LJETHUIORXR<a> : HQJLNSOHDQB<a>, NLVSGIAJTPY, WRTQDWNXXJC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class NMXMBBMJYRH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type HIEWDZSZCDR;

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public NMXMBBMJYRH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x5B668A0", Offset = "0x5B658A0", VA = "0x185B668A0")]
			internal bool ANKLXGXEJZY(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class NMSFDUSMPFY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string YFIIRJVULXL;

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public NMSFDUSMPFY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x5B66280", Offset = "0x5B65280", VA = "0x185B66280")]
			internal bool ANPSUNRBTLH(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class NMMYGNYPFUP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> LIHJAYPYUUW;

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public NMMYGNYPFUP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x5B65E80", Offset = "0x5B64E80", VA = "0x185B65E80")]
			internal void AMZYCTJJRDG(JsonWriter a, a b, DLUWFSZQQRW c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class NMHRJHERWJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> QMMFSQJKFBR;

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public NMHRJHERWJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x5B65650", Offset = "0x5B64650", VA = "0x185B65650")]
			internal a ANFFAADHAOP(JsonReader a, DLUWFSZQQRW b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly ECYBCIFZQDY<a> ZYPGGJWOBZP;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> YPSOFIJXKOP;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> AHIDAGTRWYN;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> MEUBCJWASTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool VBTUWMBJMXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> YXJCRILUKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> WNJWPQMHINX;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x55254F0", Offset = "0x55244F0", VA = "0x1855254F0")]
		static LJETHUIORXR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x552A920", Offset = "0x5529920", VA = "0x18552A920")]
		public LJETHUIORXR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x551F780", Offset = "0x551E780", VA = "0x18551F780", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x551D0A0", Offset = "0x551C0A0", VA = "0x18551D0A0", Slot = "5")]
		public a Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x551EC20", Offset = "0x551DC20", VA = "0x18551EC20", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, a b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x551FF40", Offset = "0x551EF40", VA = "0x18551FF40", Slot = "7")]
		public a YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class THSFAADXKNT<a> : HQJLNSOHDQB<a[,]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x61D42D0", Offset = "0x61D32D0", VA = "0x1861D42D0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x61D3F20", Offset = "0x61D2F20", VA = "0x1861D3F20", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public THSFAADXKNT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class HASXUCLFVHJ<a> : HQJLNSOHDQB<a[,,]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x50AA420", Offset = "0x50A9420", VA = "0x1850AA420", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x50A9F20", Offset = "0x50A8F20", VA = "0x1850A9F20", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public HASXUCLFVHJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class SVSNVBDYPIF<a> : HQJLNSOHDQB<a[,,,]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x60EF460", Offset = "0x60EE460", VA = "0x1860EF460", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x60EEE20", Offset = "0x60EDE20", VA = "0x1860EEE20", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public SVSNVBDYPIF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class RYESOGKLMID<a> : HQJLNSOHDQB<a?>, NLVSGIAJTPY where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5510", Offset = "0x5EA4510", VA = "0x185EA5510", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5060", Offset = "0x5EA4060", VA = "0x185EA5060", Slot = "5")]
		public a? Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public RYESOGKLMID()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class PQWEGDQFAXX<a> : HQJLNSOHDQB<a?>, NLVSGIAJTPY where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly HQJLNSOHDQB<a> KAAHUFXABEO;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xACF730", Offset = "0xACE730", VA = "0x180ACF730")]
		public PQWEGDQFAXX(HQJLNSOHDQB<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5DCE0A0", Offset = "0x5DCD0A0", VA = "0x185DCE0A0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5DCDB10", Offset = "0x5DCCB10", VA = "0x185DCDB10", Slot = "5")]
		public a? Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class NKMRLHOOEYA : HQJLNSOHDQB<sbyte>, NLVSGIAJTPY, WRTQDWNXXJC<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly NKMRLHOOEYA GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x901F5D0", Offset = "0x901E5D0", VA = "0x18901F5D0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x901F4B0", Offset = "0x901E4B0", VA = "0x18901F4B0", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x901F4C0", Offset = "0x901E4C0", VA = "0x18901F4C0", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, sbyte b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x901F660", Offset = "0x901E660", VA = "0x18901F660", Slot = "7")]
		public sbyte YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public NKMRLHOOEYA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class VDTMWQPSXHT : HQJLNSOHDQB<sbyte?>, NLVSGIAJTPY, WRTQDWNXXJC<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly VDTMWQPSXHT GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9025580", Offset = "0x9024580", VA = "0x189025580", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x90253B0", Offset = "0x90243B0", VA = "0x1890253B0", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x9025420", Offset = "0x9024420", VA = "0x189025420", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, sbyte? b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x9025670", Offset = "0x9024670", VA = "0x189025670", Slot = "7")]
		public sbyte? YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public VDTMWQPSXHT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class IAMOUWTNAIL : HQJLNSOHDQB<sbyte[]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly IAMOUWTNAIL GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x901B240", Offset = "0x901A240", VA = "0x18901B240", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x901B100", Offset = "0x901A100", VA = "0x18901B100", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public IAMOUWTNAIL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class BGEMWERUMET : HQJLNSOHDQB<short>, NLVSGIAJTPY, WRTQDWNXXJC<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly BGEMWERUMET GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x9013040", Offset = "0x9012040", VA = "0x189013040", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x9012F20", Offset = "0x9011F20", VA = "0x189012F20", Slot = "5")]
		public short Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x9012F30", Offset = "0x9011F30", VA = "0x189012F30", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, short b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x90130D0", Offset = "0x90120D0", VA = "0x1890130D0", Slot = "7")]
		public short YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public BGEMWERUMET()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class XRQWFSABSOW : HQJLNSOHDQB<short?>, NLVSGIAJTPY, WRTQDWNXXJC<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly XRQWFSABSOW GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x902A560", Offset = "0x9029560", VA = "0x18902A560", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x902A390", Offset = "0x9029390", VA = "0x18902A390", Slot = "5")]
		public short? Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x902A400", Offset = "0x9029400", VA = "0x18902A400", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, short? b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x902A650", Offset = "0x9029650", VA = "0x18902A650", Slot = "7")]
		public short? YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public XRQWFSABSOW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class RDKYLMHVPMG : HQJLNSOHDQB<short[]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly RDKYLMHVPMG GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x90213C0", Offset = "0x90203C0", VA = "0x1890213C0", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x9021280", Offset = "0x9020280", VA = "0x189021280", Slot = "5")]
		public short[] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public RDKYLMHVPMG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class BUFNXBWQIBX : HQJLNSOHDQB<int>, NLVSGIAJTPY, WRTQDWNXXJC<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly BUFNXBWQIBX GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9015A00", Offset = "0x9014A00", VA = "0x189015A00", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x90158E0", Offset = "0x90148E0", VA = "0x1890158E0", Slot = "5")]
		public int Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x90158F0", Offset = "0x90148F0", VA = "0x1890158F0", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, int b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x9015A90", Offset = "0x9014A90", VA = "0x189015A90", Slot = "7")]
		public int YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public BUFNXBWQIBX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class ZSWWDITLIOA : HQJLNSOHDQB<int?>, NLVSGIAJTPY, WRTQDWNXXJC<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly ZSWWDITLIOA GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x902A960", Offset = "0x9029960", VA = "0x18902A960", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x902A790", Offset = "0x9029790", VA = "0x18902A790", Slot = "5")]
		public int? Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x902A800", Offset = "0x9029800", VA = "0x18902A800", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, int? b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x902AA50", Offset = "0x9029A50", VA = "0x18902AA50", Slot = "7")]
		public int? YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public ZSWWDITLIOA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class GSFCFBMMVMY : HQJLNSOHDQB<int[]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly GSFCFBMMVMY GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x901A060", Offset = "0x9019060", VA = "0x18901A060", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x9019F20", Offset = "0x9018F20", VA = "0x189019F20", Slot = "5")]
		public int[] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public GSFCFBMMVMY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class ZUYAGACGLOE : HQJLNSOHDQB<long>, NLVSGIAJTPY, WRTQDWNXXJC<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly ZUYAGACGLOE GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x902B140", Offset = "0x902A140", VA = "0x18902B140", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x902B060", Offset = "0x902A060", VA = "0x18902B060", Slot = "5")]
		public long Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x902B070", Offset = "0x902A070", VA = "0x18902B070", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, long b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x902B1A0", Offset = "0x902A1A0", VA = "0x18902B1A0", Slot = "7")]
		public long YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public ZUYAGACGLOE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class UNHCLIAPEYV : HQJLNSOHDQB<long?>, NLVSGIAJTPY, WRTQDWNXXJC<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly UNHCLIAPEYV GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x90251D0", Offset = "0x90241D0", VA = "0x1890251D0", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9025010", Offset = "0x9024010", VA = "0x189025010", Slot = "5")]
		public long? Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x90250A0", Offset = "0x90240A0", VA = "0x1890250A0", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, long? b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x9025290", Offset = "0x9024290", VA = "0x189025290", Slot = "7")]
		public long? YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public UNHCLIAPEYV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class FBDSUUHFDBJ : HQJLNSOHDQB<long[]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly FBDSUUHFDBJ GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x9018450", Offset = "0x9017450", VA = "0x189018450", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x9018310", Offset = "0x9017310", VA = "0x189018310", Slot = "5")]
		public long[] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public FBDSUUHFDBJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class MYPKYEOVESZ : HQJLNSOHDQB<byte>, NLVSGIAJTPY, WRTQDWNXXJC<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly MYPKYEOVESZ GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x901F330", Offset = "0x901E330", VA = "0x18901F330", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x901F210", Offset = "0x901E210", VA = "0x18901F210", Slot = "5")]
		public byte Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x901F220", Offset = "0x901E220", VA = "0x18901F220", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, byte b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x901F3C0", Offset = "0x901E3C0", VA = "0x18901F3C0", Slot = "7")]
		public byte YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public MYPKYEOVESZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class RQQMWPISIYC : HQJLNSOHDQB<byte?>, NLVSGIAJTPY, WRTQDWNXXJC<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly RQQMWPISIYC GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x9021830", Offset = "0x9020830", VA = "0x189021830", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x9021660", Offset = "0x9020660", VA = "0x189021660", Slot = "5")]
		public byte? Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x90216D0", Offset = "0x90206D0", VA = "0x1890216D0", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, byte? b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x9021920", Offset = "0x9020920", VA = "0x189021920", Slot = "7")]
		public byte? YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public RQQMWPISIYC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class IVORNWAVROC : HQJLNSOHDQB<ushort>, NLVSGIAJTPY, WRTQDWNXXJC<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly IVORNWAVROC GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x901B600", Offset = "0x901A600", VA = "0x18901B600", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x901B4E0", Offset = "0x901A4E0", VA = "0x18901B4E0", Slot = "5")]
		public ushort Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x901B4F0", Offset = "0x901A4F0", VA = "0x18901B4F0", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, ushort b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x901B690", Offset = "0x901A690", VA = "0x18901B690", Slot = "7")]
		public ushort YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public IVORNWAVROC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class GYPVXFHLCNL : HQJLNSOHDQB<ushort?>, NLVSGIAJTPY, WRTQDWNXXJC<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly GYPVXFHLCNL GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x901A4D0", Offset = "0x90194D0", VA = "0x18901A4D0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x901A300", Offset = "0x9019300", VA = "0x18901A300", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x901A370", Offset = "0x9019370", VA = "0x18901A370", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, ushort? b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x901A5C0", Offset = "0x90195C0", VA = "0x18901A5C0", Slot = "7")]
		public ushort? YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public GYPVXFHLCNL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class AYWLFVAKMAZ : HQJLNSOHDQB<ushort[]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly AYWLFVAKMAZ GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x9012C80", Offset = "0x9011C80", VA = "0x189012C80", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x9012B40", Offset = "0x9011B40", VA = "0x189012B40", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public AYWLFVAKMAZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class FHSKHMLHVIQ : HQJLNSOHDQB<uint>, NLVSGIAJTPY, WRTQDWNXXJC<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly FHSKHMLHVIQ GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x9019870", Offset = "0x9018870", VA = "0x189019870", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9019750", Offset = "0x9018750", VA = "0x189019750", Slot = "5")]
		public uint Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9019760", Offset = "0x9018760", VA = "0x189019760", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, uint b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x9019900", Offset = "0x9018900", VA = "0x189019900", Slot = "7")]
		public uint YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public FHSKHMLHVIQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class TDNMYZKAQZF : HQJLNSOHDQB<uint?>, NLVSGIAJTPY, WRTQDWNXXJC<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly TDNMYZKAQZF GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x9022A90", Offset = "0x9021A90", VA = "0x189022A90", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x90228C0", Offset = "0x90218C0", VA = "0x1890228C0", Slot = "5")]
		public uint? Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x9022930", Offset = "0x9021930", VA = "0x189022930", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, uint? b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x9022B80", Offset = "0x9021B80", VA = "0x189022B80", Slot = "7")]
		public uint? YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public TDNMYZKAQZF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class SBKACQMJHVR : HQJLNSOHDQB<uint[]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly SBKACQMJHVR GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x9021BA0", Offset = "0x9020BA0", VA = "0x189021BA0", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x9021A60", Offset = "0x9020A60", VA = "0x189021A60", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public SBKACQMJHVR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class UAQXDPPEIWJ : HQJLNSOHDQB<ulong>, NLVSGIAJTPY, WRTQDWNXXJC<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly UAQXDPPEIWJ GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x9024F00", Offset = "0x9023F00", VA = "0x189024F00", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x9024E20", Offset = "0x9023E20", VA = "0x189024E20", Slot = "5")]
		public ulong Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x9024E30", Offset = "0x9023E30", VA = "0x189024E30", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, ulong b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x9024F60", Offset = "0x9023F60", VA = "0x189024F60", Slot = "7")]
		public ulong YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public UAQXDPPEIWJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class SGECJVZMJSW : HQJLNSOHDQB<ulong?>, NLVSGIAJTPY, WRTQDWNXXJC<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly SGECJVZMJSW GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x9022000", Offset = "0x9021000", VA = "0x189022000", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x9021E40", Offset = "0x9020E40", VA = "0x189021E40", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x9021ED0", Offset = "0x9020ED0", VA = "0x189021ED0", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, ulong? b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x90220C0", Offset = "0x90210C0", VA = "0x1890220C0", Slot = "7")]
		public ulong? YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public SGECJVZMJSW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class KLMIXBKTGKM : HQJLNSOHDQB<ulong[]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly KLMIXBKTGKM GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x901BFF0", Offset = "0x901AFF0", VA = "0x18901BFF0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x901BEB0", Offset = "0x901AEB0", VA = "0x18901BEB0", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public KLMIXBKTGKM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class XJRPVNIXRCT : HQJLNSOHDQB<float>, NLVSGIAJTPY, WRTQDWNXXJC<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly XJRPVNIXRCT GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x9028950", Offset = "0x9027950", VA = "0x189028950", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x9028870", Offset = "0x9027870", VA = "0x189028870", Slot = "5")]
		public float Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x9028880", Offset = "0x9027880", VA = "0x189028880", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, float b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x90289B0", Offset = "0x90279B0", VA = "0x1890289B0", Slot = "7")]
		public float YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public XJRPVNIXRCT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class TTPLOZCFEIY : HQJLNSOHDQB<float?>, NLVSGIAJTPY, WRTQDWNXXJC<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly TTPLOZCFEIY GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x90244C0", Offset = "0x90234C0", VA = "0x1890244C0", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x9024330", Offset = "0x9023330", VA = "0x189024330", Slot = "5")]
		public float? Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x90243A0", Offset = "0x90233A0", VA = "0x1890243A0", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, float? b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x9024580", Offset = "0x9023580", VA = "0x189024580", Slot = "7")]
		public float? YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public TTPLOZCFEIY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class TNUJKVVVQXM : HQJLNSOHDQB<float[]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly TNUJKVVVQXM GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x9023FA0", Offset = "0x9022FA0", VA = "0x189023FA0", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x9023E60", Offset = "0x9022E60", VA = "0x189023E60", Slot = "5")]
		public float[] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public TNUJKVVVQXM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class GCXAFDBFBSM : HQJLNSOHDQB<double>, NLVSGIAJTPY, WRTQDWNXXJC<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly GCXAFDBFBSM GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x9019C70", Offset = "0x9018C70", VA = "0x189019C70", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x9019B90", Offset = "0x9018B90", VA = "0x189019B90", Slot = "5")]
		public double Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x9019BA0", Offset = "0x9018BA0", VA = "0x189019BA0", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, double b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x9019CD0", Offset = "0x9018CD0", VA = "0x189019CD0", Slot = "7")]
		public double YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public GCXAFDBFBSM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class ATVNGRPUPVR : HQJLNSOHDQB<double?>, NLVSGIAJTPY, WRTQDWNXXJC<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly ATVNGRPUPVR GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x9012960", Offset = "0x9011960", VA = "0x189012960", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x90127A0", Offset = "0x90117A0", VA = "0x1890127A0", Slot = "5")]
		public double? Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x9012830", Offset = "0x9011830", VA = "0x189012830", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, double? b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x9012A20", Offset = "0x9011A20", VA = "0x189012A20", Slot = "7")]
		public double? YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public ATVNGRPUPVR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class HIQCNFNWLPF : HQJLNSOHDQB<double[]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly HIQCNFNWLPF GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x901AA70", Offset = "0x9019A70", VA = "0x18901AA70", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x901A930", Offset = "0x9019930", VA = "0x18901A930", Slot = "5")]
		public double[] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public HIQCNFNWLPF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class MROIHXTHSTH : HQJLNSOHDQB<bool>, NLVSGIAJTPY, WRTQDWNXXJC<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly MROIHXTHSTH GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x901D680", Offset = "0x901C680", VA = "0x18901D680", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x901D5A0", Offset = "0x901C5A0", VA = "0x18901D5A0", Slot = "5")]
		public bool Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x901D5B0", Offset = "0x901C5B0", VA = "0x18901D5B0", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, bool b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x901D6E0", Offset = "0x901C6E0", VA = "0x18901D6E0", Slot = "7")]
		public bool YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public MROIHXTHSTH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class MOWGKEJUMOU : HQJLNSOHDQB<bool?>, NLVSGIAJTPY, WRTQDWNXXJC<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly MOWGKEJUMOU GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x901D3D0", Offset = "0x901C3D0", VA = "0x18901D3D0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x901D240", Offset = "0x901C240", VA = "0x18901D240", Slot = "5")]
		public bool? Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x901D2B0", Offset = "0x901C2B0", VA = "0x18901D2B0", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, bool? b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x901D490", Offset = "0x901C490", VA = "0x18901D490", Slot = "7")]
		public bool? YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public MOWGKEJUMOU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class ZUOKKQRXOMY : HQJLNSOHDQB<bool[]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly ZUOKKQRXOMY GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x902ACD0", Offset = "0x9029CD0", VA = "0x18902ACD0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x902AB90", Offset = "0x9029B90", VA = "0x18902AB90", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public ZUOKKQRXOMY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class QWAYTZPTEII : HQJLNSOHDQB<byte[]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly HQJLNSOHDQB<byte[]> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x9021150", Offset = "0x9020150", VA = "0x189021150", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x90210E0", Offset = "0x90200E0", VA = "0x1890210E0", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public QWAYTZPTEII()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class BURDMZZMSGP : HQJLNSOHDQB<ArraySegment<byte>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly HQJLNSOHDQB<ArraySegment<byte>> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x9015C50", Offset = "0x9014C50", VA = "0x189015C50", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x9015B80", Offset = "0x9014B80", VA = "0x189015B80", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public BURDMZZMSGP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class SWNJBYEVWLV : HQJLNSOHDQB<string>, NLVSGIAJTPY, WRTQDWNXXJC<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly HQJLNSOHDQB<string> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x9022250", Offset = "0x9021250", VA = "0x189022250", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x90221E0", Offset = "0x90211E0", VA = "0x1890221E0", Slot = "5")]
		public string Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x90221F0", Offset = "0x90211F0", VA = "0x1890221F0", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, string b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x90221E0", Offset = "0x90211E0", VA = "0x1890221E0", Slot = "7")]
		public string YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public SWNJBYEVWLV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class OHSMUVUGZLY : HQJLNSOHDQB<string[]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly OHSMUVUGZLY GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x901F8A0", Offset = "0x901E8A0", VA = "0x18901F8A0", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x901F750", Offset = "0x901E750", VA = "0x18901F750", Slot = "5")]
		public string[] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public OHSMUVUGZLY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class FHBKKMGASRR : HQJLNSOHDQB<char>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly FHBKKMGASRR GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x9019630", Offset = "0x9018630", VA = "0x189019630", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x9019600", Offset = "0x9018600", VA = "0x189019600", Slot = "5")]
		public char Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public FHBKKMGASRR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class HFZCQULYVDC : HQJLNSOHDQB<char?>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly HFZCQULYVDC GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x901A7C0", Offset = "0x90197C0", VA = "0x18901A7C0", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x901A700", Offset = "0x9019700", VA = "0x18901A700", Slot = "5")]
		public char? Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public HFZCQULYVDC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class LKVWNVZWOZI : HQJLNSOHDQB<char[]>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly LKVWNVZWOZI GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x901C3B0", Offset = "0x901B3B0", VA = "0x18901C3B0", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x901C220", Offset = "0x901B220", VA = "0x18901C220", Slot = "5")]
		public char[] Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public LKVWNVZWOZI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class JLWNMDVRBSE : HQJLNSOHDQB<Guid>, NLVSGIAJTPY, WRTQDWNXXJC<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly HQJLNSOHDQB<Guid> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x901BC60", Offset = "0x901AC60", VA = "0x18901BC60", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x901BA80", Offset = "0x901AA80", VA = "0x18901BA80", Slot = "5")]
		public Guid Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x901BAE0", Offset = "0x901AAE0", VA = "0x18901BAE0", Slot = "6")]
		public void ENJQYJMDWMI(JsonWriter a, Guid b, DLUWFSZQQRW c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x901BDD0", Offset = "0x901ADD0", VA = "0x18901BDD0", Slot = "7")]
		public Guid YPJXNJGNRVS(JsonReader a, DLUWFSZQQRW b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public JLWNMDVRBSE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class WIMKGVMIDDG : HQJLNSOHDQB<decimal>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly HQJLNSOHDQB<decimal> GOGYEQDLKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool WXLFBATOJGK;

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x73D2F60", Offset = "0x73D1F60", VA = "0x1873D2F60")]
		public WIMKGVMIDDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xDB07B0", Offset = "0xDAF7B0", VA = "0x180DB07B0")]
		public WIMKGVMIDDG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x9027AA0", Offset = "0x9026AA0", VA = "0x189027AA0", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x90278D0", Offset = "0x90268D0", VA = "0x1890278D0", Slot = "5")]
		public decimal Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class VKNDAZTYKFZ : HQJLNSOHDQB<Uri>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly HQJLNSOHDQB<Uri> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x9027360", Offset = "0x9026360", VA = "0x189027360", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x90272E0", Offset = "0x90262E0", VA = "0x1890272E0", Slot = "5")]
		public Uri Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public VKNDAZTYKFZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class MMMOPIIBTWB : HQJLNSOHDQB<Version>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly HQJLNSOHDQB<Version> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x901D110", Offset = "0x901C110", VA = "0x18901D110", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x901D090", Offset = "0x901C090", VA = "0x18901D090", Slot = "5")]
		public Version Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public MMMOPIIBTWB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class XUZCXXQNKGF<a, b> : HQJLNSOHDQB<KeyValuePair<a, b>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x3F056D0", Offset = "0x3F046D0", VA = "0x183F056D0", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x3F051E0", Offset = "0x3F041E0", VA = "0x183F051E0", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class VNKMUBALQIV : HQJLNSOHDQB<StringBuilder>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly HQJLNSOHDQB<StringBuilder> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x9027530", Offset = "0x9026530", VA = "0x189027530", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x90274B0", Offset = "0x90264B0", VA = "0x1890274B0", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public VNKMUBALQIV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class HVEDOCWHFJZ : HQJLNSOHDQB<BitArray>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly HQJLNSOHDQB<BitArray> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x901AF10", Offset = "0x9019F10", VA = "0x18901AF10", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x901ADF0", Offset = "0x9019DF0", VA = "0x18901ADF0", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public HVEDOCWHFJZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class JDCASLYDLLR : HQJLNSOHDQB<Type>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly JDCASLYDLLR GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex VJRAPOAGEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool YMRVAWINIUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool MGSQHVJKFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool CPIWONSDJIW;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x901BA60", Offset = "0x901AA60", VA = "0x18901BA60")]
		public JDCASLYDLLR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8357950", Offset = "0x8356950", VA = "0x188357950")]
		public JDCASLYDLLR(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x901B890", Offset = "0x901A890", VA = "0x18901B890", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x901B780", Offset = "0x901A780", VA = "0x18901B780", Slot = "5")]
		public Type Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class VXILOKYIJUX : HQJLNSOHDQB<BigInteger>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly HQJLNSOHDQB<BigInteger> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x90276F0", Offset = "0x90266F0", VA = "0x1890276F0", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x9027640", Offset = "0x9026640", VA = "0x189027640", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public VXILOKYIJUX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class ESTXWSHQNKF : HQJLNSOHDQB<Complex>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly HQJLNSOHDQB<Complex> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x9018170", Offset = "0x9017170", VA = "0x189018170", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x90180E0", Offset = "0x90170E0", VA = "0x1890180E0", Slot = "5")]
		public Complex Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public ESTXWSHQNKF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class ATDVFENHZJN : HQJLNSOHDQB<ExpandoObject>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly HQJLNSOHDQB<ExpandoObject> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x90126A0", Offset = "0x90116A0", VA = "0x1890126A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x9012470", Offset = "0x9011470", VA = "0x189012470", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public ATDVFENHZJN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class OFWBHFNGIKW<a> : HQJLNSOHDQB<Lazy<a>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5CA24A0", Offset = "0x5CA14A0", VA = "0x185CA24A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x5CA2290", Offset = "0x5CA1290", VA = "0x185CA2290", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class LXXXGHZRVBY : HQJLNSOHDQB<Task>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly HQJLNSOHDQB<Task> GOGYEQDLKEI;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task SBQLPUGHSKB;

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x901C710", Offset = "0x901B710", VA = "0x18901C710", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x901C660", Offset = "0x901B660", VA = "0x18901C660", Slot = "5")]
		public Task Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public LXXXGHZRVBY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class WMZHDWGXDOI<a> : HQJLNSOHDQB<Task<a>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x6869E30", Offset = "0x6868E30", VA = "0x186869E30", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x6869C30", Offset = "0x6868C30", VA = "0x186869C30", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class PELFGCPZTPM<a> : HQJLNSOHDQB<ValueTask<a>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD830", Offset = "0x5DBC830", VA = "0x185DBD830", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DBD600", Offset = "0x5DBC600", VA = "0x185DBD600", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class ZIJZGXWEJKA<a> : HQJLNSOHDQB<Tuple<a>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x3F3BD30", Offset = "0x3F3AD30", VA = "0x183F3BD30", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x3F3BA40", Offset = "0x3F3AA40", VA = "0x183F3BA40", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class ZIZTYSDWLSB<a, b> : HQJLNSOHDQB<Tuple<a, b>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x3F3D1A0", Offset = "0x3F3C1A0", VA = "0x183F3D1A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x3F3CD50", Offset = "0x3F3BD50", VA = "0x183F3CD50", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class ZIUNBLJZCGS<a, b, c> : HQJLNSOHDQB<Tuple<a, b, c>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C6A0", Offset = "0x3F3B6A0", VA = "0x183F3C6A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C110", Offset = "0x3F3B110", VA = "0x183F3C110", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class ZJKHTFRREOT<a, b, c, d> : HQJLNSOHDQB<Tuple<a, b, c, d>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F3EFE0", Offset = "0x3F3DFE0", VA = "0x183F3EFE0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E8F0", Offset = "0x3F3D8F0", VA = "0x183F3E8F0", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class ZJFAVYXTVDK<a, b, c, d, e> : HQJLNSOHDQB<Tuple<a, b, c, d, e>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F3DF40", Offset = "0x3F3CF40", VA = "0x183F3DF40", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x3F3D6E0", Offset = "0x3F3C6E0", VA = "0x183F3D6E0", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class ZJUVNTFLXLL<a, b, c, d, e, f> : HQJLNSOHDQB<Tuple<a, b, c, d, e, f>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x3F42270", Offset = "0x3F41270", VA = "0x183F42270", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x3F41880", Offset = "0x3F40880", VA = "0x183F41880", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class ZJPOQMLOOAC<a, b, c, d, e, f, g> : HQJLNSOHDQB<Tuple<a, b, c, d, e, f, g>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x3F403A0", Offset = "0x3F3F3A0", VA = "0x183F403A0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x3F3F820", Offset = "0x3F3E820", VA = "0x183F3F820", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class ZGZDACMWVIP<a, b, c, d, e, f, g, h> : HQJLNSOHDQB<Tuple<a, b, c, d, e, f, g, h>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x3F39510", Offset = "0x3F38510", VA = "0x183F39510", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x3F38820", Offset = "0x3F37820", VA = "0x183F38820", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class UJRMFXLQMWT<a> : HQJLNSOHDQB<ValueTuple<a>>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x63D06A0", Offset = "0x63CF6A0", VA = "0x1863D06A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x63D0270", Offset = "0x63CF270", VA = "0x1863D0270", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class UJWTDEFNWIC<a, b> : HQJLNSOHDQB<(a, b)>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x63D25F0", Offset = "0x63D15F0", VA = "0x1863D25F0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x63D20E0", Offset = "0x63D10E0", VA = "0x1863D20E0", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class UKCAAKZLFTL<a, b, c> : HQJLNSOHDQB<(a, b, c)>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x63D3230", Offset = "0x63D2230", VA = "0x1863D3230", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x63D2B90", Offset = "0x63D1B90", VA = "0x1863D2B90", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class UIRDTPQDRSA<a, b, c, d> : HQJLNSOHDQB<(a, b, c, d)>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x63C3FE0", Offset = "0x63C2FE0", VA = "0x1863C3FE0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x63C3770", Offset = "0x63C2770", VA = "0x1863C3770", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class UIWKQWKBBDJ<a, b, c, d, e> : HQJLNSOHDQB<(a, b, c, d, e)>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x63C52E0", Offset = "0x63C42E0", VA = "0x1863C52E0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x63C48E0", Offset = "0x63C38E0", VA = "0x1863C48E0", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class UJBRODDYKOS<a, b, c, d, e, f> : HQJLNSOHDQB<(a, b, c, d, e, f)>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x63CD9A0", Offset = "0x63CC9A0", VA = "0x1863CD9A0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x63CCD80", Offset = "0x63CBD80", VA = "0x1863CCD80", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class UJGYLJXVUAB<a, b, c, d, e, f, g> : HQJLNSOHDQB<(a, b, c, d, e, f, g)>, NLVSGIAJTPY
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x63CF420", Offset = "0x63CE420", VA = "0x1863CF420", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x63CE640", Offset = "0x63CD640", VA = "0x1863CE640", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class ULCIMSUYAYE<a, b, c, d, e, f, g, h> : HQJLNSOHDQB<ValueTuple<a, b, c, d, e, f, g, h>>, NLVSGIAJTPY where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] EGJFKCSLCED;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly RWOCKMJMAHX CHRIFOQCCVV;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x63D5510", Offset = "0x63D4510", VA = "0x1863D5510", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, DLUWFSZQQRW formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x63D4580", Offset = "0x63D3580", VA = "0x1863D4580", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, DLUWFSZQQRW formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class GJJRMPJNIRN
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] ZRSAVFWEPYN;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly RWOCKMJMAHX ZVABFLMFXAY;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x9019D80", Offset = "0x9018D80", VA = "0x189019D80")]
		static GJJRMPJNIRN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class GAGYSUVUKDL
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] HENPBDUJRZG;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly RWOCKMJMAHX NVWAZWTPRUR;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x90199F0", Offset = "0x90189F0", VA = "0x1890199F0")]
		static GAGYSUVUKDL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class FFASTZVHEAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] QLRTTJKXXQZ;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly RWOCKMJMAHX UZHCTUKXXSS;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] QLBZBPDFVIY;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly RWOCKMJMAHX UZBVWNRAOHJ;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] QLHFYVXDEUH;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly RWOCKMJMAHX UYWOZGXDEWA;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] QKRLHBPLCMG;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly RWOCKMJMAHX UYRICADFVKR;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] QKWSEIJILXP;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly RWOCKMJMAHX UYMBETJILZI;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] QKGXMOBQJPO;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly RWOCKMJMAHX UYGUHMPLCNZ;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] QKMEJUVNTAX;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly RWOCKMJMAHX UYBNKFVNTCQ;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] QJWJSANVQSW;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly RWOCKMJMAHX UXWGMZBQJRH;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x9018680", Offset = "0x9017680", VA = "0x189018680")]
		static FFASTZVHEAP()
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
