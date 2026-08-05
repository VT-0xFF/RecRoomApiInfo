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
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xAA0FA0", Offset = "0xA9FDA0", VA = "0x180AA0FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object[] Arguments
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
		public JsonFormatterAttribute(Type formatterType)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate void JsonSerializeAction<T>(JsonWriter writer, T value, HYIETNPQWTC resolver);
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate T JsonDeserializeFunc<T>(JsonReader reader, HYIETNPQWTC resolver);
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface PMICCMHTWMS
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface LCJZQSSKXYB<a> : PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Serialize(JsonWriter writer, a value, HYIETNPQWTC formatterResolver);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface FZWAPUBRNSY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RYESLTGKTSY(JsonWriter a, a b, HYIETNPQWTC c);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		a VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b);
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
	public static class WMXEYFMXQHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3E97BC0", Offset = "0x3E969C0", VA = "0x183E97BC0")]
		public static string ToJsonString<T>(this LCJZQSSKXYB<T> formatter, T value, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LCJZQSSKXYB<T> GetFormatter<T>();
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class QAGSMCTIPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C25FF0", Offset = "0x3C24DF0", VA = "0x183C25FF0")]
		public static LCJZQSSKXYB<a> RIXYCIGEPTK<a>(this HYIETNPQWTC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC1B0", Offset = "0x8FEAFB0", VA = "0x188FEC1B0")]
		public static object NVNDURGGWAS(this HYIETNPQWTC a, Type b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FormatterNotRegisteredException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8FE2E30", Offset = "0x8FE1C30", VA = "0x188FE2E30")]
		public FormatterNotRegisteredException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public ref struct JsonReader
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class LPZLCEFEYLK
		{
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly byte[] WPJJGHBOHEX;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly byte[] ZYWPVXWBDWW;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly byte[] MKPQNSSBVIT;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly byte[] HBGGIXJTFHM;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly byte[] WWLHIQVKOEF;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly byte[] JKQTKONOXLK;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly byte[] ZKXTVZIYVGG;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly byte[] RNQSDBGYOXR;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private ref struct StringSegmentReaderContext
		{
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			private sealed class BQARJCMLZKP : ReadOnlySequenceSegment<byte>
			{
				[Cpp2IlInjected.Token(Token = "0x6000048")]
				[Cpp2IlInjected.Address(RVA = "0x8FE2110", Offset = "0x8FE0F10", VA = "0x188FE2110")]
				public BQARJCMLZKP(ReadOnlyMemory<byte> a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000049")]
				[Cpp2IlInjected.Address(RVA = "0x8FE1FF0", Offset = "0x8FE0DF0", VA = "0x188FE1FF0")]
				public BQARJCMLZKP ZTZHIHIKODR(ReadOnlyMemory<byte> a)
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			private static class QQSKTGMQIPC
			{
				[Cpp2IlInjected.Token(Token = "0x4000013")]
				[ThreadStatic]
				public static byte[] QADITXBINGF;

				[Cpp2IlInjected.Token(Token = "0x4000014")]
				[ThreadStatic]
				public static char[] LJSQTDIDWMO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			private BQARJCMLZKP start;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private BQARJCMLZKP end;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int bufferOffset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int utf8CharBufferOffset;

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x8FED490", Offset = "0x8FEC290", VA = "0x188FED490")]
			public void ZTZHIHIKODR([In] ReadOnlySequence<byte> sequence)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8FED5A0", Offset = "0x8FEC3A0", VA = "0x188FED5A0")]
			public void ZTZHIHIKODR(char a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8FECFC0", Offset = "0x8FEBDC0", VA = "0x188FECFC0")]
			public ReadOnlySequence<byte> PXHOLSHDYHK()
			{
				return default(ReadOnlySequence<byte>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8FED0F0", Offset = "0x8FEBEF0", VA = "0x188FED0F0")]
			private void UTIGVJHZEVQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8FED2A0", Offset = "0x8FEC0A0", VA = "0x188FED2A0")]
			private void XHKPURZHJBY([In] ReadOnlyMemory<byte> memory)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private SequenceReader<byte> memorySequenceReader;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8200", Offset = "0x8FE7000", VA = "0x188FE8200")]
		public JsonReader([In] ReadOnlySequence<byte> memorySequence)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6430", Offset = "0x8FE5230", VA = "0x188FE6430")]
		private JsonParsingException JDQPSDFCXRY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7DF0", Offset = "0x8FE6BF0", VA = "0x188FE7DF0")]
		private JsonParsingException XRIZVDVMUQN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7430", Offset = "0x8FE6230", VA = "0x188FE7430")]
		public void RLMMWOXKEOY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6B30", Offset = "0x8FE5930", VA = "0x188FE6B30")]
		public JsonToken KMGAQOMOALH()
		{
			return default(JsonToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8FE5200", Offset = "0x8FE4000", VA = "0x188FE5200")]
		public void DDBCYRBBDBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7FD0", Offset = "0x8FE6DD0", VA = "0x188FE7FD0")]
		private bool YXHJOJRABEL(ReadOnlySpan<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8030", Offset = "0x8FE6E30", VA = "0x188FE8030")]
		private bool YXHJOJRABEL(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7380", Offset = "0x8FE6180", VA = "0x188FE7380")]
		private void QVQQDLTAMQS(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7C90", Offset = "0x8FE6A90", VA = "0x188FE7C90")]
		public bool UCMQHCRDBOS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6930", Offset = "0x8FE5730", VA = "0x188FE6930")]
		public void JVANFHBYYIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE5A90", Offset = "0x8FE4890", VA = "0x188FE5A90")]
		public bool FPDRDQWGYQZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE5A80", Offset = "0x8FE4880", VA = "0x188FE5A80")]
		public void EXLGIHBRAIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7D50", Offset = "0x8FE6B50", VA = "0x188FE7D50")]
		public void UVFYPZXJJLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8FE5A30", Offset = "0x8FE4830", VA = "0x188FE5A30")]
		public bool EUMLNMWMFMX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8090", Offset = "0x8FE6E90", VA = "0x188FE8090")]
		public void ZKRRNEBTOIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8FE51F0", Offset = "0x8FE3FF0", VA = "0x188FE51F0")]
		public void CWTFQSYDAHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8FE4FF0", Offset = "0x8FE3DF0", VA = "0x188FE4FF0")]
		public bool BCPJBKRJWIO(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7D60", Offset = "0x8FE6B60", VA = "0x188FE7D60")]
		public bool VXNHIGGOWEI(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6940", Offset = "0x8FE5740", VA = "0x188FE6940")]
		public bool JYBZAJRABIX(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8FE5CD0", Offset = "0x8FE4AD0", VA = "0x188FE5CD0")]
		private ReadOnlySequence<byte> GBWGOORLBQI()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7640", Offset = "0x8FE6440", VA = "0x188FE7640")]
		private ReadOnlySequence<byte> SMWLTCKJGFB()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8FE5AE0", Offset = "0x8FE48E0", VA = "0x188FE5AE0")]
		private void GBBZIYZHPNB(StringSegmentReaderContext a, [In] SequencePosition begin)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7A90", Offset = "0x8FE6890", VA = "0x188FE7A90")]
		private void TIJSXBFWUNU(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE5430", Offset = "0x8FE4230", VA = "0x188FE5430")]
		private void DSHZKPOLEFD(StringSegmentReaderContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6A20", Offset = "0x8FE5820", VA = "0x188FE6A20")]
		private void KCKBLVVHZHO(StringSegmentReaderContext a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE02A0", Offset = "0x8FDF0A0", VA = "0x188FE02A0")]
		private static int TLJIWXKDJSH(byte a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE5720", Offset = "0x8FE4520", VA = "0x188FE5720")]
		public ReadOnlySequence<byte> EGLETTKEIJD()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7F50", Offset = "0x8FE6D50", VA = "0x188FE7F50")]
		public string YOIIYVTMQBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7F10", Offset = "0x8FE6D10", VA = "0x188FE7F10")]
		public string YJNQWXEUUBX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8FE5120", Offset = "0x8FE3F20", VA = "0x188FE5120")]
		public ReadOnlySequence<byte> CMRUCOAFNQD()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6EA0", Offset = "0x8FE5CA0", VA = "0x188FE6EA0")]
		public ReadOnlySequence<byte> LQIGVPWZZFW()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8FE74F0", Offset = "0x8FE62F0", VA = "0x188FE74F0")]
		public bool SDRECSOKXBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8FE62C0", Offset = "0x8FE50C0", VA = "0x188FE62C0")]
		private void IZUCHCIGNAJ(JsonToken a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7F00", Offset = "0x8FE6D00", VA = "0x188FE7F00")]
		public void XYTLMELPWEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8FE57F0", Offset = "0x8FE45F0", VA = "0x188FE57F0")]
		private void EPIOHTOYZOE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6F80", Offset = "0x8FE5D80", VA = "0x188FE6F80")]
		public sbyte LWGNMMJCQZQ()
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6DF0", Offset = "0x8FE5BF0", VA = "0x188FE6DF0")]
		public short LJGKYXUXBFV()
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8FE80A0", Offset = "0x8FE6EA0", VA = "0x188FE80A0")]
		public int ZMEYAKOHEDH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7480", Offset = "0x8FE6280", VA = "0x188FE7480")]
		public long ROBVAYWEAUW()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6D40", Offset = "0x8FE5B40", VA = "0x188FE6D40")]
		public byte KZDYTGCIYVP()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE7030", Offset = "0x8FE5E30", VA = "0x188FE7030")]
		public ushort MPXBXGXLRHG()
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8150", Offset = "0x8FE6F50", VA = "0x188FE8150")]
		public uint ZQCTRGJLVFQ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE6250", Offset = "0x8FE5050", VA = "0x188FE6250")]
		public ulong HLURXOWUPHX()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE61B0", Offset = "0x8FE4FB0", VA = "0x188FE61B0")]
		public float GLFFWIJPPCT()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8FE5080", Offset = "0x8FE3E80", VA = "0x188FE5080")]
		public double BXFOFTLUPEK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8FE78B0", Offset = "0x8FE66B0", VA = "0x188FE78B0")]
		public ReadOnlySequence<byte> TBUOGDGAIXN()
		{
			return default(ReadOnlySequence<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8FE70E0", Offset = "0x8FE5EE0", VA = "0x188FE70E0")]
		private void NCMKBXBMNWB()
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
			[Cpp2IlInjected.Address(RVA = "0xBDB150", Offset = "0xBD9F50", VA = "0x180BDB150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE4F90", Offset = "0x8FE3D90", VA = "0x188FE4F90")]
		public JsonParsingException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE4F10", Offset = "0x8FE3D10", VA = "0x188FE4F10")]
		public JsonParsingException(string message, string actualChar)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class CHVFORQQWKV
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private static class VUMFYRGYSBU
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			[ThreadStatic]
			private static byte[] QADITXBINGF;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8FF0DA0", Offset = "0x8FEFBA0", VA = "0x188FF0DA0")]
			public static byte[] FFBCRXQSUIP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static HYIETNPQWTC LFAVKGBJBAW;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static readonly byte[][] DBRNQOFHNIZ;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly byte[] RQAPNCBXLXD;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static HYIETNPQWTC KPYEXKIOYRI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8FE2220", Offset = "0x8FE1020", VA = "0x188FE2220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE2320", Offset = "0x8FE1120", VA = "0x188FE2320")]
		public static void ZXFLZFRNVRO(HYIETNPQWTC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x36DF8B0", Offset = "0x36DE6B0", VA = "0x1836DF8B0")]
		public static byte[] Serialize<T>(T obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x36DF730", Offset = "0x36DE530", VA = "0x1836DF730")]
		public static byte[] Serialize<T>(T value, HYIETNPQWTC resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x36DFFB0", Offset = "0x36DEDB0", VA = "0x1836DFFB0")]
		public static string ToJsonString<T>(T value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x36E0170", Offset = "0x36DEF70", VA = "0x1836E0170")]
		public static string ToJsonString<T>(T value, HYIETNPQWTC resolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x36DF240", Offset = "0x36DE040", VA = "0x1836DF240")]
		public static T Deserialize<T>(string json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x36DEF70", Offset = "0x36DDD70", VA = "0x1836DEF70")]
		public static T Deserialize<T>(string json, HYIETNPQWTC resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x36DF170", Offset = "0x36DDF70", VA = "0x1836DF170")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x36DEEA0", Offset = "0x36DDCA0", VA = "0x1836DEEA0")]
		public static T Deserialize<T>([In] ReadOnlyMemory<byte> json, HYIETNPQWTC resolver)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x36DE130", Offset = "0x36DCF30", VA = "0x1836DE130")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x36DDF60", Offset = "0x36DCD60", VA = "0x1836DDF60")]
		public static T Deserialize<T>([In] ReadOnlySequence<byte> json, HYIETNPQWTC resolver)
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
		public int VDOZFFKAXAH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xFCEE90", Offset = "0xFCDC90", VA = "0x180FCEE90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8FA0", Offset = "0x8FE7DA0", VA = "0x188FE8FA0")]
		public void RLMMWOXKEOY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8FE9530", Offset = "0x8FE8330", VA = "0x188FE9530")]
		public static byte[] SBAWIZLCAJB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8E40", Offset = "0x8FE7C40", VA = "0x188FE8E40")]
		public static byte[] PUSUPPSKNGT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8CB0", Offset = "0x8FE7AB0", VA = "0x188FE8CB0")]
		public static byte[] MYSMYAOOKNZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8570", Offset = "0x8FE7370", VA = "0x188FE8570")]
		public static byte[] DGUALFZTHPL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2A56FC0", Offset = "0x2A55DC0", VA = "0x182A56FC0")]
		public JsonWriter(byte[] initialBuffer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8940", Offset = "0x8FE7740", VA = "0x188FE8940")]
		public ArraySegment<byte> FFBCRXQSUIP()
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8FE86F0", Offset = "0x8FE74F0", VA = "0x188FE86F0")]
		public byte[] DHUZCCWRNOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8FE9680", Offset = "0x8FE8480", VA = "0x188FE9680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8FE84C0", Offset = "0x8FE72C0", VA = "0x188FE84C0")]
		public void CVKXASIXHIF(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8A10", Offset = "0x8FE7810", VA = "0x188FE8A10")]
		public void HJCRMWQFWZC(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8F60", Offset = "0x8FE7D60", VA = "0x188FE8F60")]
		public void QTPMWCEDCGO(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x41667A0", Offset = "0x41655A0", VA = "0x1841667A0")]
		public void QCGECTROCKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4166750", Offset = "0x4165550", VA = "0x184166750")]
		public void AYALBPJLKWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8BF0", Offset = "0x8FE79F0", VA = "0x188FE8BF0")]
		public void LDBPOOTNAYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE88F0", Offset = "0x8FE76F0", VA = "0x188FE88F0")]
		public void EUFNJWJYPYA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x41667F0", Offset = "0x41655F0", VA = "0x1841667F0")]
		public void QIBFHXRLFGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5582440", Offset = "0x5581240", VA = "0x185582440")]
		public void OQGYBOKDEVW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8FE84D0", Offset = "0x8FE72D0", VA = "0x188FE84D0")]
		public void DDOQIKRDRYI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8470", Offset = "0x8FE7270", VA = "0x188FE8470")]
		public void COULFOWYPPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x41666B0", Offset = "0x41654B0", VA = "0x1841666B0")]
		public void ARZCWBFANZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7934D90", Offset = "0x7933B90", VA = "0x187934D90")]
		public void LRGCSVSDKMS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8A70", Offset = "0x8FE7870", VA = "0x188FE8A70")]
		public void IFOTPWDYTVM(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8B70", Offset = "0x8FE7970", VA = "0x188FE8B70")]
		public void KZITBNBDGXJ(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8880", Offset = "0x8FE7680", VA = "0x188FE8880")]
		public void DLLMSXGMSMY(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8FE83E0", Offset = "0x8FE71E0", VA = "0x188FE83E0")]
		public void BOKOVZWKYSN(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8DD0", Offset = "0x8FE7BD0", VA = "0x188FE8DD0")]
		public void NNCEYPGFTHV(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE89E0", Offset = "0x8FE77E0", VA = "0x188FE89E0")]
		public void FRKGSGSWZFO(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE9610", Offset = "0x8FE8410", VA = "0x188FE9610")]
		public void TDVDIBDECUR(sbyte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8370", Offset = "0x8FE7170", VA = "0x188FE8370")]
		public void APDZMXSSFSQ(short a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8C40", Offset = "0x8FE7A40", VA = "0x188FE8C40")]
		public void MPLSTPFRXUS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE96E0", Offset = "0x8FE84E0", VA = "0x188FE96E0")]
		public void ULDQZXTARWZ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8FB0", Offset = "0x8FE7DB0", VA = "0x188FE8FB0")]
		public void RVFRQJZKHRV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8AF0", Offset = "0x8FE78F0", VA = "0x188FE8AF0")]
		private static bool JTENQGBUMUX(char a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8FE8450", Offset = "0x8FE7250", VA = "0x188FE8450")]
		private static byte CFEXLUDDDPT(int a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8FE0360", Offset = "0x8FDF160", VA = "0x188FE0360")]
		private static void FVEMRRQODRI(string a, int b, int c, byte[] d, int e)
		{
		}
	}
}
namespace Utf8Json.Resolvers
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class GBAFPISABUX : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6768100", Offset = "0x6766F00", VA = "0x186768100")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private GBAFPISABUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public sealed class GGOAMRQIFDS : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6765350", Offset = "0x6764150", VA = "0x186765350")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal static class VSCVIAEUALU
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private static readonly Dictionary<Type, object> PTHTXJFPGTV;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8FEEE20", Offset = "0x8FEDC20", VA = "0x188FEEE20")]
			internal static object GetFormatter(Type t)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private GGOAMRQIFDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class KJMTRLDLXPG : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6763820", Offset = "0x6762620", VA = "0x186763820")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly KJMTRLDLXPG VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool SNTDEWQLDCY;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private static PMICCMHTWMS[] EMMNFYJHBIE;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static HYIETNPQWTC[] FHQSVNIIYLY;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private KJMTRLDLXPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8FE9A60", Offset = "0x8FE8860", VA = "0x188FE9A60")]
		public static void IPFDCTVTWHM(params HYIETNPQWTC[] resolvers)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8FE9B40", Offset = "0x8FE8940", VA = "0x188FE9B40")]
		public static void IPFDCTVTWHM(params PMICCMHTWMS[] formatters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8FE97E0", Offset = "0x8FE85E0", VA = "0x188FE97E0")]
		public static void EGSEQOAIVRM(PMICCMHTWMS[] a, HYIETNPQWTC[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public sealed class HSJMDGSORNJ : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x676CB90", Offset = "0x676B990", VA = "0x18676CB90")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private HSJMDGSORNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class LQSKVMLSVQI
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly HYIETNPQWTC SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly HYIETNPQWTC VURBYTNIMRT;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class BOYOIGFZHRW
	{
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly HYIETNPQWTC SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly HYIETNPQWTC OBQWVKLDITN;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly HYIETNPQWTC BZTWDDMITWJ;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly HYIETNPQWTC LOMLGNCOCSK;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly HYIETNPQWTC MCCACSOCUII;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly HYIETNPQWTC FMNGODICILM;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly HYIETNPQWTC MKSNCRURYFJ;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly HYIETNPQWTC WCKFDBPUQGT;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly HYIETNPQWTC EAYFYARFGLH;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly HYIETNPQWTC MHCKFPSOORY;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly HYIETNPQWTC DBGSPDSMDKE;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly HYIETNPQWTC ZGSJFEQPKXI;
	}
}
namespace Utf8Json.Resolvers.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	internal static class YVRDEBTPHXX
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static readonly Dictionary<Type, Type> PTHTXJFPGTV;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8FF2430", Offset = "0x8FF1230", VA = "0x188FF2430")]
		internal static object GetFormatter(Type t)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8FF23F0", Offset = "0x8FF11F0", VA = "0x188FF23F0")]
		private static object DRPGLBCUHRO(Type a, Type[] b, params object[] arguments)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal sealed class CPPVLFQJWBL : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x6766990", Offset = "0x6765790", VA = "0x186766990")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private CPPVLFQJWBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal sealed class JXOFXVTYJBW : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x676ED10", Offset = "0x676DB10", VA = "0x18676ED10")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private JXOFXVTYJBW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	internal static class YMFNYRJTPAY
	{
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		internal static readonly HYIETNPQWTC[] OTIPXDPTDQB;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	internal sealed class KQDTUYABHCT : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6767570", Offset = "0x6766370", VA = "0x186767570")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private sealed class UKYPWFBYCHR : HYIETNPQWTC
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			private static class WIUXWKXAZWM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

				[Cpp2IlInjected.Token(Token = "0x60000B6")]
				[Cpp2IlInjected.Address(RVA = "0x676A040", Offset = "0x6768E40", VA = "0x18676A040")]
				static WIUXWKXAZWM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly HYIETNPQWTC VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private static readonly HYIETNPQWTC[] FHQSVNIIYLY;

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			private UKYPWFBYCHR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
			public LCJZQSSKXYB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private static readonly LCJZQSSKXYB<object> WMMNKGMXMYF;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private KQDTUYABHCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	internal sealed class QIDTHNAVRUM : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x676E730", Offset = "0x676D530", VA = "0x18676E730")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		private sealed class UKYPWFBYCHR : HYIETNPQWTC
		{
			[Cpp2IlInjected.Token(Token = "0x2000031")]
			private static class WIUXWKXAZWM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

				[Cpp2IlInjected.Token(Token = "0x60000BE")]
				[Cpp2IlInjected.Address(RVA = "0x6767410", Offset = "0x6766210", VA = "0x186767410")]
				static WIUXWKXAZWM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly HYIETNPQWTC VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly HYIETNPQWTC[] FHQSVNIIYLY;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			private UKYPWFBYCHR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
			public LCJZQSSKXYB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static readonly LCJZQSSKXYB<object> WMMNKGMXMYF;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private QIDTHNAVRUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	internal sealed class BVPDLVOCRQC : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6765C70", Offset = "0x6764A70", VA = "0x186765C70")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class UKYPWFBYCHR : HYIETNPQWTC
		{
			[Cpp2IlInjected.Token(Token = "0x2000035")]
			private static class WIUXWKXAZWM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

				[Cpp2IlInjected.Token(Token = "0x60000C6")]
				[Cpp2IlInjected.Address(RVA = "0x676CD70", Offset = "0x676BB70", VA = "0x18676CD70")]
				static WIUXWKXAZWM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly HYIETNPQWTC VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private static readonly HYIETNPQWTC[] FHQSVNIIYLY;

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			private UKYPWFBYCHR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
			public LCJZQSSKXYB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static readonly LCJZQSSKXYB<object> WMMNKGMXMYF;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private BVPDLVOCRQC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class EJHOZWGPMRH : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x676EA20", Offset = "0x676D820", VA = "0x18676EA20")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		private sealed class UKYPWFBYCHR : HYIETNPQWTC
		{
			[Cpp2IlInjected.Token(Token = "0x2000039")]
			private static class WIUXWKXAZWM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

				[Cpp2IlInjected.Token(Token = "0x60000CE")]
				[Cpp2IlInjected.Address(RVA = "0x6764CD0", Offset = "0x6763AD0", VA = "0x186764CD0")]
				static WIUXWKXAZWM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly HYIETNPQWTC VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private static readonly HYIETNPQWTC[] FHQSVNIIYLY;

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			private UKYPWFBYCHR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
			public LCJZQSSKXYB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly LCJZQSSKXYB<object> WMMNKGMXMYF;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private EJHOZWGPMRH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class GPCXHXIDNSL : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x676D320", Offset = "0x676C120", VA = "0x18676D320")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private sealed class UKYPWFBYCHR : HYIETNPQWTC
		{
			[Cpp2IlInjected.Token(Token = "0x200003D")]
			private static class WIUXWKXAZWM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

				[Cpp2IlInjected.Token(Token = "0x60000D6")]
				[Cpp2IlInjected.Address(RVA = "0x676E180", Offset = "0x676CF80", VA = "0x18676E180")]
				static WIUXWKXAZWM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly HYIETNPQWTC VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly HYIETNPQWTC[] FHQSVNIIYLY;

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			private UKYPWFBYCHR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
			public LCJZQSSKXYB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static readonly LCJZQSSKXYB<object> WMMNKGMXMYF;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private GPCXHXIDNSL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal sealed class TNPTABOHECJ : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6769D50", Offset = "0x6768B50", VA = "0x186769D50")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private sealed class UKYPWFBYCHR : HYIETNPQWTC
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private static class WIUXWKXAZWM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

				[Cpp2IlInjected.Token(Token = "0x60000DE")]
				[Cpp2IlInjected.Address(RVA = "0x6764E30", Offset = "0x6763C30", VA = "0x186764E30")]
				static WIUXWKXAZWM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly HYIETNPQWTC VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private static readonly HYIETNPQWTC[] FHQSVNIIYLY;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			private UKYPWFBYCHR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
			public LCJZQSSKXYB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly LCJZQSSKXYB<object> WMMNKGMXMYF;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private TNPTABOHECJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal sealed class TKWNQSHBOLC : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6766250", Offset = "0x6765050", VA = "0x186766250")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		private sealed class UKYPWFBYCHR : HYIETNPQWTC
		{
			[Cpp2IlInjected.Token(Token = "0x2000045")]
			private static class WIUXWKXAZWM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

				[Cpp2IlInjected.Token(Token = "0x60000E6")]
				[Cpp2IlInjected.Address(RVA = "0x676B110", Offset = "0x6769F10", VA = "0x18676B110")]
				static WIUXWKXAZWM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly HYIETNPQWTC VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly HYIETNPQWTC[] FHQSVNIIYLY;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			private UKYPWFBYCHR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
			public LCJZQSSKXYB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly LCJZQSSKXYB<object> WMMNKGMXMYF;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private TKWNQSHBOLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	internal sealed class LWCPWTZXVTK : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x6765F60", Offset = "0x6764D60", VA = "0x186765F60")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class UKYPWFBYCHR : HYIETNPQWTC
		{
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			private static class WIUXWKXAZWM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0x676BF70", Offset = "0x676AD70", VA = "0x18676BF70")]
				static WIUXWKXAZWM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly HYIETNPQWTC VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private static readonly HYIETNPQWTC[] FHQSVNIIYLY;

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			private UKYPWFBYCHR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
			public LCJZQSSKXYB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly LCJZQSSKXYB<object> WMMNKGMXMYF;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private LWCPWTZXVTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	internal sealed class HXSERKGVVLY : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x676B560", Offset = "0x676A360", VA = "0x18676B560")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private sealed class UKYPWFBYCHR : HYIETNPQWTC
		{
			[Cpp2IlInjected.Token(Token = "0x200004D")]
			private static class WIUXWKXAZWM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0x6769BF0", Offset = "0x67689F0", VA = "0x186769BF0")]
				static WIUXWKXAZWM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly HYIETNPQWTC VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private static readonly HYIETNPQWTC[] FHQSVNIIYLY;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			private UKYPWFBYCHR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
			public LCJZQSSKXYB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private static readonly LCJZQSSKXYB<object> WMMNKGMXMYF;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private HXSERKGVVLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	internal sealed class WUHIYCUIAIV : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x676DE90", Offset = "0x676CC90", VA = "0x18676DE90")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class UKYPWFBYCHR : HYIETNPQWTC
		{
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private static class WIUXWKXAZWM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x676C0D0", Offset = "0x676AED0", VA = "0x18676C0D0")]
				static WIUXWKXAZWM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public static readonly HYIETNPQWTC VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private static readonly HYIETNPQWTC[] FHQSVNIIYLY;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			private UKYPWFBYCHR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
			public LCJZQSSKXYB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static readonly LCJZQSSKXYB<object> WMMNKGMXMYF;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private WUHIYCUIAIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class KQDHTXERELJ : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x676CED0", Offset = "0x676BCD0", VA = "0x18676CED0")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private sealed class UKYPWFBYCHR : HYIETNPQWTC
		{
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private static class WIUXWKXAZWM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x676C520", Offset = "0x676B320", VA = "0x18676C520")]
				static WIUXWKXAZWM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly HYIETNPQWTC VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private static readonly HYIETNPQWTC[] FHQSVNIIYLY;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			private UKYPWFBYCHR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
			public LCJZQSSKXYB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private static readonly LCJZQSSKXYB<object> WMMNKGMXMYF;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private KQDHTXERELJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal sealed class ZIRCCBQYYWF : HYIETNPQWTC
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		private static class WIUXWKXAZWM<a>
		{
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x676C230", Offset = "0x676B030", VA = "0x18676C230")]
			static WIUXWKXAZWM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		private sealed class UKYPWFBYCHR : HYIETNPQWTC
		{
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private static class WIUXWKXAZWM<a>
			{
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly LCJZQSSKXYB<a> VUXGTBLFXWD;

				[Cpp2IlInjected.Token(Token = "0x600010E")]
				[Cpp2IlInjected.Address(RVA = "0x6767FA0", Offset = "0x6766DA0", VA = "0x186767FA0")]
				static WIUXWKXAZWM()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly HYIETNPQWTC VDCQJFYBFAQ;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private static readonly HYIETNPQWTC[] FHQSVNIIYLY;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			private UKYPWFBYCHR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
			public LCJZQSSKXYB<T> GetFormatter<T>()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public static readonly HYIETNPQWTC VDCQJFYBFAQ;

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private static readonly LCJZQSSKXYB<object> WMMNKGMXMYF;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		private ZIRCCBQYYWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3633300", Offset = "0x3632100", VA = "0x183633300", Slot = "4")]
		public LCJZQSSKXYB<T> GetFormatter<T>()
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
		[Cpp2IlInjected.Address(RVA = "0x58D69B0", Offset = "0x58D57B0", VA = "0x1858D69B0")]
		public ArrayBuffer(int initialSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x58D66D0", Offset = "0x58D54D0", VA = "0x1858D66D0")]
		public void Add(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x58D6920", Offset = "0x58D5720", VA = "0x1858D6920")]
		public T[] HRIEGNNCWDF()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class YNUOIPBFZWN<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly int QWAJJLASDYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly object ETAQBIXELXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int VEJGVBBERIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private a[][] SEJSLTTXZYG;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x41117E0", Offset = "0x41105E0", VA = "0x1841117E0")]
		public YNUOIPBFZWN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x41115B0", Offset = "0x41103B0", VA = "0x1841115B0")]
		public a[] SXUDZOUMPQI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x41111F0", Offset = "0x410FFF0", VA = "0x1841111F0")]
		public void Return(a[] array)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class TKCLJZAOTYZ : IEnumerable<KeyValuePair<string, int>>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		private class MCOUUZWJDEB : IComparable<MCOUUZWJDEB>
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			[CompilerGenerated]
			private sealed class PLWVZTCJNDX : IEnumerable<MCOUUZWJDEB>, IEnumerable, IEnumerator<MCOUUZWJDEB>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				private int DPSIYUGFINN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				private MCOUUZWJDEB KPVEVSUGXYQ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				private int SNADUNBHBXY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public MCOUUZWJDEB SVDPBWSVAHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				private int AHISCSJYWTV;

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				private MCOUUZWJDEB JMXUQUQGCRU
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				private object SQVTSFKREWF
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000126")]
				[Cpp2IlInjected.Address(RVA = "0xB50450", Offset = "0xB4F250", VA = "0x180B50450")]
				[DebuggerHidden]
				public PLWVZTCJNDX(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "7")]
				[DebuggerHidden]
				private void DUPJTQKNSZU()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000128")]
				[Cpp2IlInjected.Address(RVA = "0x8FEC090", Offset = "0x8FEAE90", VA = "0x188FEC090", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600012A")]
				[Cpp2IlInjected.Address(RVA = "0x8FEC050", Offset = "0x8FEAE50", VA = "0x188FEC050", Slot = "10")]
				[DebuggerHidden]
				private void KJSXTMSAUIL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600012C")]
				[Cpp2IlInjected.Address(RVA = "0x8FEC110", Offset = "0x8FEAF10", VA = "0x188FEC110", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<MCOUUZWJDEB> SAGKGQQKUGJ()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600012D")]
				[Cpp2IlInjected.Address(RVA = "0x8FEC110", Offset = "0x8FEAF10", VA = "0x188FEC110", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator WAAULASRGHE()
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private static readonly MCOUUZWJDEB[] NFEEUCFXPKZ;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private static readonly ulong[] YQXZTTSIBIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ulong UWPCMRAPJZQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int XDXPKJAQNFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public string CBVIHHFHAJR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private MCOUUZWJDEB[] XFBCTSKWJUL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private ulong[] GXNWXFTKBAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private int YTWIRFOBDMK;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB810", Offset = "0x8FEA610", VA = "0x188FEB810")]
			public MCOUUZWJDEB(ulong a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB2B0", Offset = "0x8FEA0B0", VA = "0x188FEB2B0")]
			public MCOUUZWJDEB Add(ulong key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB250", Offset = "0x8FEA050", VA = "0x188FEB250")]
			public MCOUUZWJDEB Add(ulong key, int value, string originalKey)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB570", Offset = "0x8FEA370", VA = "0x188FEB570")]
			public MCOUUZWJDEB OTJFSWACJUP(SequenceReader<byte> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB4E0", Offset = "0x8FEA2E0", VA = "0x188FEB4E0")]
			internal static int LKLGHBNYKLU(ulong[] a, int b, int c, ulong d)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB4B0", Offset = "0x8FEA2B0", VA = "0x188FEB4B0", Slot = "4")]
			public int CompareTo(MCOUUZWJDEB other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB6E0", Offset = "0x8FEA4E0", VA = "0x188FEB6E0")]
			[IteratorStateMachine(typeof(PLWVZTCJNDX))]
			public IEnumerable<MCOUUZWJDEB> REQHIWEJGZR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class MXFKCPOCSNV : IEnumerable<KeyValuePair<string, int>>, IEnumerable, IEnumerator<KeyValuePair<string, int>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private KeyValuePair<string, int> KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private int SNADUNBHBXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private IEnumerable<MCOUUZWJDEB> XFBCTSKWJUL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IEnumerable<MCOUUZWJDEB> MNYNPOTDDMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private IEnumerator<MCOUUZWJDEB> RSQQLXOAUXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private MCOUUZWJDEB VBQVDJMGGTA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private IEnumerator<KeyValuePair<string, int>> RTBEGLBVNTX;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private KeyValuePair<string, int> MTLQPFOMBXO
			{
				[Cpp2IlInjected.Token(Token = "0x6000133")]
				[Cpp2IlInjected.Address(RVA = "0xC580B0", Offset = "0xC56EB0", VA = "0x180C580B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, int>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x8FEBF60", Offset = "0x8FEAD60", VA = "0x188FEBF60", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xC58160", Offset = "0xC56F60", VA = "0x180C58160")]
			[DebuggerHidden]
			public MXFKCPOCSNV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB970", Offset = "0x8FEA770", VA = "0x188FEB970", Slot = "7")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8FEBB00", Offset = "0x8FEA900", VA = "0x188FEBB00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8FEBFB0", Offset = "0x8FEADB0", VA = "0x188FEBFB0")]
			private void XVTZRJOPNYU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8FEC000", Offset = "0x8FEAE00", VA = "0x188FEC000")]
			private void XWJUJDWHQGV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8FEBAC0", Offset = "0x8FEA8C0", VA = "0x188FEBAC0", Slot = "10")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB8D0", Offset = "0x8FEA6D0", VA = "0x188FEB8D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KeyValuePair<string, int>> BFJMTFGIPKT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x8FEB8D0", Offset = "0x8FEA6D0", VA = "0x188FEB8D0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly MCOUUZWJDEB DSTQIKJKEHN;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8FEDF30", Offset = "0x8FECD30", VA = "0x188FEDF30")]
		public TKCLJZAOTYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8FED6E0", Offset = "0x8FEC4E0", VA = "0x188FED6E0")]
		public void Add(byte[] bytes, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8FED920", Offset = "0x8FEC720", VA = "0x188FED920")]
		public bool HHYTRHIEAWJ(ReadOnlySequence<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8FEDE20", Offset = "0x8FECC20", VA = "0x188FEDE20")]
		public bool WODATVJMTWA([In] ReadOnlySequence<byte> key, [Out] int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8FEDD90", Offset = "0x8FECB90", VA = "0x188FEDD90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8FEDA30", Offset = "0x8FEC830", VA = "0x188FEDA30")]
		private static void LXINWAMEGTC(IEnumerable<MCOUUZWJDEB> a, StringBuilder b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8FED8C0", Offset = "0x8FEC6C0", VA = "0x188FED8C0", Slot = "5")]
		private IEnumerator WAAULASRGHE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8FED8C0", Offset = "0x8FEC6C0", VA = "0x188FED8C0", Slot = "4")]
		public IEnumerator<KeyValuePair<string, int>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8FEDD10", Offset = "0x8FECB10", VA = "0x188FEDD10")]
		[IteratorStateMachine(typeof(MXFKCPOCSNV))]
		private static IEnumerable<KeyValuePair<string, int>> NWLXZGMDADV(IEnumerable<MCOUUZWJDEB> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class FXRGQJWVAPY
	{
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public static readonly MethodInfo LZRXFRRZOWV;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8FE2630", Offset = "0x8FE1430", VA = "0x188FE2630")]
		public unsafe static ulong GetKey(byte* p, int rest)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8FE27E0", Offset = "0x8FE15E0", VA = "0x188FE27E0")]
		public static ulong IZCBSMSGMAN(SequenceReader<byte> a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class YIDXCZAKDKG
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1DD0", Offset = "0x8FF0BD0", VA = "0x188FF1DD0")]
		public static void CVKXASIXHIF(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1F10", Offset = "0x8FF0D10", VA = "0x188FF1F10")]
		public static void EBBFGVQKYMN(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8FF2030", Offset = "0x8FF0E30", VA = "0x188FF2030")]
		public static byte[] JEHJDJZNZQS(byte[] a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	internal class MTAUEDYTFRA<a> : IEnumerable<KeyValuePair<string, a>>, IEnumerable
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
			[Cpp2IlInjected.Address(RVA = "0x49713C0", Offset = "0x49701C0", VA = "0x1849713C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class GNATZFRYYYS : IEnumerator<KeyValuePair<string, a>>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private KeyValuePair<string, a> KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public MTAUEDYTFRA<a> SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private Entry[][] RSQQLXOAUXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private int RSVXJEHYEIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private Entry[] RTBEGLBVNTX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int RTGLDRVSXFG;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private KeyValuePair<string, a> FIIZSXFMJPF
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xC580B0", Offset = "0xC56EB0", VA = "0x180C580B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<string, a>);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0x4FF3B20", Offset = "0x4FF2920", VA = "0x184FF3B20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
			[DebuggerHidden]
			public GNATZFRYYYS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "5")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x50AAA20", Offset = "0x50A9820", VA = "0x1850AAA20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x402B990", Offset = "0x402A790", VA = "0x18402B990", Slot = "8")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entry[][] BCDSIKYTKVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly ulong AITIFYCASQY;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static readonly bool CYNGXIXYIVP;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x599BBE0", Offset = "0x599A9E0", VA = "0x18599BBE0")]
		public MTAUEDYTFRA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x599BCC0", Offset = "0x599AAC0", VA = "0x18599BCC0")]
		public MTAUEDYTFRA(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x59993E0", Offset = "0x59981E0", VA = "0x1859993E0")]
		public void Add(byte[] key, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5999E70", Offset = "0x5998C70", VA = "0x185999E70")]
		private bool IPJHOKQMBHI(byte[] a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5999AD0", Offset = "0x59988D0", VA = "0x185999AD0")]
		public bool HHYTRHIEAWJ([In] ReadOnlySequence<byte> key, [Out] a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x599B5A0", Offset = "0x599A3A0", VA = "0x18599B5A0")]
		private static ulong YYBEAEVAIYT([In] ReadOnlyMemory<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x599B9E0", Offset = "0x599A7E0", VA = "0x18599B9E0")]
		private static ulong YYBEAEVAIYT([In] ReadOnlySequence<byte> x)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x599B150", Offset = "0x5999F50", VA = "0x18599B150")]
		private static int YCAFECMPTUN(int a, float b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5999600", Offset = "0x5998400", VA = "0x185999600", Slot = "4")]
		[IteratorStateMachine(typeof(MTAUEDYTFRA<>.GNATZFRYYYS))]
		public IEnumerator<KeyValuePair<string, a>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x599B030", Offset = "0x5999E30", VA = "0x18599B030", Slot = "5")]
		private IEnumerator WAAULASRGHE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal static class GODIOJCSQEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x38F4BC0", Offset = "0x38F39C0", VA = "0x1838F4BC0")]
		public static Func<a> SMQYYRRIVVL<a>(this a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x38F4B00", Offset = "0x38F3900", VA = "0x1838F4B00")]
		private static c LFHVJTKRTFU<c>(this object a)
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
		[Cpp2IlInjected.Address(RVA = "0x8FE3A00", Offset = "0x8FE2800", VA = "0x188FE3A00")]
		public GuidBits([In] Guid value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8FE3A10", Offset = "0x8FE2810", VA = "0x188FE3A10")]
		public GuidBits([In] ReadOnlySequence<byte> utf8string)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8FE3870", Offset = "0x8FE2670", VA = "0x188FE3870")]
		private static byte XHDXCEAGLJM(ReadOnlySpan<byte> a, int b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8FE00F0", Offset = "0x8FDEEF0", VA = "0x188FE00F0")]
		private static byte RRYBECQALNU(byte a)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8FE3010", Offset = "0x8FE1E10", VA = "0x188FE3010")]
		public void GYOQNYAFVSC(byte[] a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class XUWLOPLQOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1D00", Offset = "0x8FF0B00", VA = "0x188FF1D00")]
		public static bool TVNSPSXLEZQ(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8FF0FD0", Offset = "0x8FEFDD0", VA = "0x188FF0FD0")]
		public static bool DULSNWHNXTF(byte a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1410", Offset = "0x8FF0210", VA = "0x188FF1410")]
		public static sbyte LWGNMMJCQZQ([In] ReadOnlySequence<byte> bytes)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8FF13B0", Offset = "0x8FF01B0", VA = "0x188FF13B0")]
		public static short LJGKYXUXBFV([In] ReadOnlySequence<byte> bytes)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1D10", Offset = "0x8FF0B10", VA = "0x188FF1D10")]
		public static int ZMEYAKOHEDH([In] ReadOnlySequence<byte> bytes)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1A80", Offset = "0x8FF0880", VA = "0x188FF1A80")]
		public static long ROBVAYWEAUW([In] ReadOnlySequence<byte> bytes)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8FF14D0", Offset = "0x8FF02D0", VA = "0x188FF14D0")]
		public static bool NTYRJNHEYQP(SequenceReader<byte> a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1350", Offset = "0x8FF0150", VA = "0x188FF1350")]
		public static byte KZDYTGCIYVP([In] ReadOnlySequence<byte> bytes)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1470", Offset = "0x8FF0270", VA = "0x188FF1470")]
		public static ushort MPXBXGXLRHG([In] ReadOnlySequence<byte> bytes)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1D70", Offset = "0x8FF0B70", VA = "0x188FF1D70")]
		public static uint ZQCTRGJLVFQ([In] ReadOnlySequence<byte> bytes)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1240", Offset = "0x8FF0040", VA = "0x188FF1240")]
		public static ulong HLURXOWUPHX([In] ReadOnlySequence<byte> bytes)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1660", Offset = "0x8FF0460", VA = "0x188FF1660")]
		public static bool OLHNMRQKGWK(SequenceReader<byte> a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8FF17B0", Offset = "0x8FF05B0", VA = "0x188FF17B0")]
		public static bool ORJEJSBICRW(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1130", Offset = "0x8FEFF30", VA = "0x188FF1130")]
		public static bool GRFSBRRLQMK(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1980", Offset = "0x8FF0780", VA = "0x188FF1980")]
		public static bool PYIRUTXZNEU(SequenceReader<byte> a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1040", Offset = "0x8FEFE40", VA = "0x188FF1040")]
		public static float GLFFWIJPPCT([In] ReadOnlySequence<byte> bytes)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1A20", Offset = "0x8FF0820", VA = "0x188FF1A20")]
		public static bool QGUMBAOMPDW(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8FF0EE0", Offset = "0x8FEFCE0", VA = "0x188FF0EE0")]
		public static double BXFOFTLUPEK([In] ReadOnlySequence<byte> bytes)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8FF12F0", Offset = "0x8FF00F0", VA = "0x188FF12F0")]
		public static bool HMUBGLARJOB(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE0840", Offset = "0x8FDF640", VA = "0x188FE0840")]
		public static int FRKGSGSWZFO(byte[] a, int b, ulong c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE11A0", Offset = "0x8FDFFA0", VA = "0x188FE11A0")]
		public static int ULDQZXTARWZ(byte[] a, int b, long c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8FF1B30", Offset = "0x8FF0930", VA = "0x188FF1B30")]
		public static bool SDRECSOKXBL([In] ReadOnlySequence<byte> bytes)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal static class KJTCJBSIRFC
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE9D30", Offset = "0x8FE8B30", VA = "0x188FE9D30")]
		public static bool BMGEDWEWWOW(this TypeInfo a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal static class VDJUHCCLFRF
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public static readonly Encoding PUGWBENOKVW;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class RXIHBBZFGYX
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA490", Offset = "0x8FE9290", VA = "0x188FEA490")]
		public static void PCWZDWZLVZC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA500", Offset = "0x8FE9300", VA = "0x188FEA500")]
		public static void PDCGBDTJFKL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA570", Offset = "0x8FE9370", VA = "0x188FEA570")]
		public static void PDHMYKNGOVU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA5E0", Offset = "0x8FE93E0", VA = "0x188FEA5E0")]
		public static void PDMTVRHDYHD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC870", Offset = "0x8FEB670", VA = "0x188FEC870")]
		public static void PCBXOVXWKFS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC8E0", Offset = "0x8FEB6E0", VA = "0x188FEC8E0")]
		public static void PCHEMCRTTRB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC700", Offset = "0x8FEB500", VA = "0x188FEC700")]
		public static void MIMVIIJYIMN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC690", Offset = "0x8FEB490", VA = "0x188FEC690")]
		public static void MIHOLBQAZBE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC620", Offset = "0x8FEB420", VA = "0x188FEC620")]
		public static void MICHNUWDPPV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC5A0", Offset = "0x8FEB3A0", VA = "0x188FEC5A0")]
		public static void MHXAQOCGGEM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC520", Offset = "0x8FEB320", VA = "0x188FEC520")]
		public static void MHRTTHIIWTD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC4A0", Offset = "0x8FEB2A0", VA = "0x188FEC4A0")]
		public static void MHMMWAOLNHU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC420", Offset = "0x8FEB220", VA = "0x188FEC420")]
		public static void MHHFYTUODWL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC3A0", Offset = "0x8FEB1A0", VA = "0x188FEC3A0")]
		public static void MHBZBNAQULC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC7F0", Offset = "0x8FEB5F0", VA = "0x188FEC7F0")]
		public static void MKCYMKNDFZH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC770", Offset = "0x8FEB570", VA = "0x188FEC770")]
		public static void MJXRPDTFWNY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8FECB70", Offset = "0x8FEB970", VA = "0x188FECB70")]
		public static void SJGBTSTAMIO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8FECBF0", Offset = "0x8FEB9F0", VA = "0x188FECBF0")]
		public static void SJLIQZMXVTX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8FECA70", Offset = "0x8FEB870", VA = "0x188FECA70")]
		public static void SIVNZFFFTLW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8FECAF0", Offset = "0x8FEB8F0", VA = "0x188FECAF0")]
		public static void SJAUWLZDCXF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8FECD90", Offset = "0x8FEBB90", VA = "0x188FECD90")]
		public static void SKBDITUPYBY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8FECE10", Offset = "0x8FEBC10", VA = "0x188FECE10")]
		public static void SKGKGAONHNH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8FECC70", Offset = "0x8FEBA70", VA = "0x188FECC70")]
		public static void SJQPOGGVFFG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8FECD00", Offset = "0x8FEBB00", VA = "0x188FECD00")]
		public static void SJVWLNASOQP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC950", Offset = "0x8FEB750", VA = "0x188FEC950")]
		public static void SHPYPQPVOVU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8FEC9E0", Offset = "0x8FEB7E0", VA = "0x188FEC9E0")]
		public static void SHVFMXJSYHD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8FECF30", Offset = "0x8FEBD30", VA = "0x188FECF30")]
		public static void ZJXGSLBDCAX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8FECEA0", Offset = "0x8FEBCA0", VA = "0x188FECEA0")]
		public static void ZJRZVEHFSPO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA650", Offset = "0x8FE9450", VA = "0x188FEA650")]
		public static void PDXHQEUYRDV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA6C0", Offset = "0x8FE94C0", VA = "0x188FEA6C0")]
		public static void PECONLOWAPE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA730", Offset = "0x8FE9530", VA = "0x188FEA730")]
		public static void PEHVKSITKAN(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class KVBURSYDITW
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA3B0", Offset = "0x8FE91B0", VA = "0x188FEA3B0")]
		public static void PCBXOVXWKFS(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA420", Offset = "0x8FE9220", VA = "0x188FEA420")]
		public static void PCHEMCRTTRB(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA240", Offset = "0x8FE9040", VA = "0x188FEA240")]
		public static void MIMVIIJYIMN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA1D0", Offset = "0x8FE8FD0", VA = "0x188FEA1D0")]
		public static void MIHOLBQAZBE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA160", Offset = "0x8FE8F60", VA = "0x188FEA160")]
		public static void MICHNUWDPPV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA0F0", Offset = "0x8FE8EF0", VA = "0x188FEA0F0")]
		public static void MHXAQOCGGEM(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA080", Offset = "0x8FE8E80", VA = "0x188FEA080")]
		public static void MHRTTHIIWTD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA010", Offset = "0x8FE8E10", VA = "0x188FEA010")]
		public static void MHMMWAOLNHU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8FE9FA0", Offset = "0x8FE8DA0", VA = "0x188FE9FA0")]
		public static void MHHFYTUODWL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x8FE9F20", Offset = "0x8FE8D20", VA = "0x188FE9F20")]
		public static void MHBZBNAQULC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA330", Offset = "0x8FE9130", VA = "0x188FEA330")]
		public static void MKCYMKNDFZH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA2B0", Offset = "0x8FE90B0", VA = "0x188FEA2B0")]
		public static void MJXRPDTFWNY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA9A0", Offset = "0x8FE97A0", VA = "0x188FEA9A0")]
		public static void SJGBTSTAMIO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8FEAA20", Offset = "0x8FE9820", VA = "0x188FEAA20")]
		public static void SJLIQZMXVTX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA8A0", Offset = "0x8FE96A0", VA = "0x188FEA8A0")]
		public static void SIVNZFFFTLW(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA920", Offset = "0x8FE9720", VA = "0x188FEA920")]
		public static void SJAUWLZDCXF(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x8FEABA0", Offset = "0x8FE99A0", VA = "0x188FEABA0")]
		public static void SKBDITUPYBY(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8FEAC20", Offset = "0x8FE9A20", VA = "0x188FEAC20")]
		public static void SKGKGAONHNH(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8FEAAA0", Offset = "0x8FE98A0", VA = "0x188FEAAA0")]
		public static void SJQPOGGVFFG(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8FEAB20", Offset = "0x8FE9920", VA = "0x188FEAB20")]
		public static void SJVWLNASOQP(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA7A0", Offset = "0x8FE95A0", VA = "0x188FEA7A0")]
		public static void SHPYPQPVOVU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA820", Offset = "0x8FE9620", VA = "0x188FEA820")]
		public static void SHVFMXJSYHD(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8FEAD20", Offset = "0x8FE9B20", VA = "0x188FEAD20")]
		public static void ZJXGSLBDCAX(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8FEACA0", Offset = "0x8FE9AA0", VA = "0x188FEACA0")]
		public static void ZJRZVEHFSPO(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA650", Offset = "0x8FE9450", VA = "0x188FEA650")]
		public static void PDXHQEUYRDV(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA6C0", Offset = "0x8FE94C0", VA = "0x188FEA6C0")]
		public static void PECONLOWAPE(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA730", Offset = "0x8FE9530", VA = "0x188FEA730")]
		public static void PEHVKSITKAN(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA490", Offset = "0x8FE9290", VA = "0x188FEA490")]
		public static void PCWZDWZLVZC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA500", Offset = "0x8FE9300", VA = "0x188FEA500")]
		public static void PDCGBDTJFKL(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA570", Offset = "0x8FE9370", VA = "0x188FEA570")]
		public static void PDHMYKNGOVU(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8FEA5E0", Offset = "0x8FE93E0", VA = "0x188FEA5E0")]
		public static void PDMTVRHDYHD(JsonWriter a, byte[] b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class TBJNBVHAVBY
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public static readonly bool CYNGXIXYIVP;

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x9002330", Offset = "0x9001130", VA = "0x189002330")]
		public static void HJCRMWQFWZC(JsonWriter a, byte[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9003D80", Offset = "0x9002B80", VA = "0x189003D80")]
		public static void TNQBBCFTVNX(JsonWriter a, byte[] b)
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
		[Cpp2IlInjected.Address(RVA = "0x2B02A00", Offset = "0x2B01800", VA = "0x182B02A00")]
		public DiyFp(ulong significand, int exponent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6870", Offset = "0x8FF5670", VA = "0x188FF6870")]
		public void Subtract(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6730", Offset = "0x8FF5530", VA = "0x188FF6730")]
		public static DiyFp LJAJBIKOREJ(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6740", Offset = "0x8FF5540", VA = "0x188FF6740")]
		public void Multiply(DiyFp other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8FF67D0", Offset = "0x8FF55D0", VA = "0x188FF67D0")]
		public static DiyFp OBEXNJACPVJ(DiyFp a, DiyFp b)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8FF66F0", Offset = "0x8FF54F0", VA = "0x188FF66F0")]
		public void BBRTCSKXIXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8FF66A0", Offset = "0x8FF54A0", VA = "0x188FF66A0")]
		public static DiyFp BBRTCSKXIXM(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0xE190C0", Offset = "0xE17EC0", VA = "0x180E190C0")]
		public StringBuilder(byte[] buffer, int position)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x90022D0", Offset = "0x90010D0", VA = "0x1890022D0")]
		public void XGKYECJDNGF(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9002250", Offset = "0x9001050", VA = "0x189002250")]
		public void SQCUSLJWVEH(byte[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9002050", Offset = "0x9000E50", VA = "0x189002050")]
		public void BNRJFPGEHIV(byte[] a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x9001FB0", Offset = "0x9000DB0", VA = "0x189001FB0")]
		public void BNRJFPGEHIV(byte[] a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x90021D0", Offset = "0x9000FD0", VA = "0x1890021D0")]
		public void SFORXZBSZFN(byte a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x90020D0", Offset = "0x9000ED0", VA = "0x1890020D0")]
		public void GUAOOZXFENI(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	internal static class UJVZOKVOTRE
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
		private static byte[] ITNTHSXINYL;

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[ThreadStatic]
		private static byte[] JKHVFDCOSUT;

		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private static readonly byte[] LFBNXCNSSIJ;

		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private static readonly byte[] RJMBAOBZMIC;

		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private static readonly Flags SCZGURLVUZJ;

		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private static readonly char WYLNKMXRVCJ;

		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private static readonly int MEJXSDXHEXZ;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly int GDAHOFBFIUZ;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly uint[] FWSFRNPPZBB;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x90057A0", Offset = "0x90045A0", VA = "0x1890057A0")]
		private static byte[] GXZTOLJTCPD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9005210", Offset = "0x9004010", VA = "0x189005210")]
		private static byte[] DVWQJYRRNUJ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x9005A90", Offset = "0x9004890", VA = "0x189005A90")]
		public static int LCWJNSQMAWE(byte[] a, int b, float c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x9005970", Offset = "0x9004770", VA = "0x189005970")]
		public static int LCWJNSQMAWE(byte[] a, int b, double c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x90056B0", Offset = "0x90044B0", VA = "0x1890056B0")]
		private static bool GKOWOIMNXHO(byte[] a, int b, ulong c, ulong d, ulong e, ulong f, ulong g)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x9005BB0", Offset = "0x90049B0", VA = "0x189005BB0")]
		private static void OHJXHXHPMWE(uint a, int b, [Out] uint c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x90052F0", Offset = "0x90040F0", VA = "0x1890052F0")]
		private static bool FQJPROFKETE(DiyFp a, DiyFp b, DiyFp c, byte[] d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9005E70", Offset = "0x9004C70", VA = "0x189005E70")]
		private static bool SCBKCCLZWLU(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9005870", Offset = "0x9004670", VA = "0x189005870")]
		private static bool JWWFKTTILBT(double a, FastDtoaMode b, byte[] c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x9005CA0", Offset = "0x9004AA0", VA = "0x189005CA0")]
		private static bool QCUFZHDPZQO(double a, StringBuilder b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x9006720", Offset = "0x9005520", VA = "0x189006720")]
		private static bool VZOJQDKUVBH(double a, StringBuilder b, DtoaMode c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x9004E70", Offset = "0x9003C70", VA = "0x189004E70")]
		private static void DPDUYAHEVVV(byte[] a, int b, int c, int d, StringBuilder e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x90062F0", Offset = "0x90050F0", VA = "0x1890062F0")]
		private static void TIHXCBVFTSH(byte[] a, int b, int c, StringBuilder d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x9004C80", Offset = "0x9003A80", VA = "0x189004C80")]
		private static bool CPXBMTKWAKS(double a, DtoaMode b, int c, byte[] d, [Out] bool e, [Out] int f, [Out] int g)
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
		[Cpp2IlInjected.Address(RVA = "0x8FF6EA0", Offset = "0x8FF5CA0", VA = "0x188FF6EA0")]
		public Double(double d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6E00", Offset = "0x8FF5C00", VA = "0x188FF6E00")]
		public Double(DiyFp d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6A80", Offset = "0x8FF5880", VA = "0x188FF6A80")]
		public DiyFp JIRFHZJBSGF()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6900", Offset = "0x8FF5700", VA = "0x188FF6900")]
		public DiyFp DCVSNBTPLAG()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xBB6870", Offset = "0xBB5670", VA = "0x180BB6870")]
		public ulong PUPXWMIZHBT()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6880", Offset = "0x8FF5680", VA = "0x188FF6880")]
		public double AKJXALKGNVN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6980", Offset = "0x8FF5780", VA = "0x188FF6980")]
		public double DECNRWFVDTN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6BD0", Offset = "0x8FF59D0", VA = "0x188FF6BD0")]
		public int PPDMTIAZGOQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6AF0", Offset = "0x8FF58F0", VA = "0x188FF6AF0")]
		public ulong JUUFEZOSEWC()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6A40", Offset = "0x8FF5840", VA = "0x188FF6A40")]
		public bool GFVEXVDTIVJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6A20", Offset = "0x8FF5820", VA = "0x188FF6A20")]
		public bool FYMBZNOMBGK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6D40", Offset = "0x8FF5B40", VA = "0x188FF6D40")]
		public bool UWQUHVLTOUM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6BA0", Offset = "0x8FF59A0", VA = "0x188FF6BA0")]
		public bool ONFYXRQGLUD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6B80", Offset = "0x8FF5980", VA = "0x188FF6B80")]
		public int LIVDYEOXVYO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6C00", Offset = "0x8FF5A00", VA = "0x188FF6C00")]
		public void PVISZTIHJXS([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6B20", Offset = "0x8FF5920", VA = "0x188FF6B20")]
		public bool KOWPJGNURWY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x3E54490", Offset = "0x3E53290", VA = "0x183E54490")]
		public double value()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6A60", Offset = "0x8FF5860", VA = "0x188FF6A60")]
		public static int GNITVUHZUPR(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6B70", Offset = "0x8FF5970", VA = "0x188FF6B70")]
		public static double KWPBUSSJMLZ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6D70", Offset = "0x8FF5B70", VA = "0x188FF6D70")]
		public static ulong UZVZHCQCNZI(DiyFp a)
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
		[Cpp2IlInjected.Address(RVA = "0x2D6CB10", Offset = "0x2D6B910", VA = "0x182D6CB10")]
		public Single(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x9001DA0", Offset = "0x9000BA0", VA = "0x189001DA0")]
		public DiyFp JIRFHZJBSGF()
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0xD93760", Offset = "0xD92560", VA = "0x180D93760")]
		public uint HSLMZVIWXAK()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9001E60", Offset = "0x9000C60", VA = "0x189001E60")]
		public int PPDMTIAZGOQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x9001E00", Offset = "0x9000C00", VA = "0x189001E00")]
		public uint JUUFEZOSEWC()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x9001D90", Offset = "0x9000B90", VA = "0x189001D90")]
		public bool GFVEXVDTIVJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x9001E80", Offset = "0x9000C80", VA = "0x189001E80")]
		public void PVISZTIHJXS([Out] DiyFp a, [Out] DiyFp b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9001E20", Offset = "0x9000C20", VA = "0x189001E20")]
		public bool KOWPJGNURWY()
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
		[Cpp2IlInjected.Address(RVA = "0x8FF6690", Offset = "0x8FF5490", VA = "0x188FF6690")]
		public CachedPower(ulong significand, short binary_exponent, short decimal_exponent)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	internal static class LCLWMSUHMUP
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private static readonly CachedPower[] OXUWHEXIXLC;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8FFB370", Offset = "0x8FFA170", VA = "0x188FFB370")]
		public static void YDFQGRLKBPA(int a, int b, [Out] DiyFp c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8FFB2A0", Offset = "0x8FFA0A0", VA = "0x188FFB2A0")]
		public static void TPREGXKENEN(int a, [Out] DiyFp b, [Out] int c)
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
			[Cpp2IlInjected.Address(RVA = "0x90081D0", Offset = "0x9006FD0", VA = "0x1890081D0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5A08DC0", Offset = "0x5A07BC0", VA = "0x185A08DC0")]
		public Vector(byte[] bytes, int start, int length)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2D349B0", Offset = "0x2D337B0", VA = "0x182D349B0")]
		public int length()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9008170", Offset = "0x9006F70", VA = "0x189008170")]
		public Vector DYRWRMPYYOE(int a, int b)
		{
			return default(Vector);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	internal static class ZCMQIXMWUDE
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ThreadStatic]
		private static byte[] XDGUQJTTJUU;

		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static readonly double[] MQKYCKTWQHZ;

		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static readonly int TNOBXFLGZXQ;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x900C8E0", Offset = "0x900B6E0", VA = "0x18900C8E0")]
		private static byte[] EBOCBZJWLNM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x900D5A0", Offset = "0x900C3A0", VA = "0x18900D5A0")]
		private static Vector ZEPMKPPGZZQ(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x900CA50", Offset = "0x900B850", VA = "0x18900CA50")]
		private static Vector MZYYIYJAOMK(Vector a)
		{
			return default(Vector);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x900C9C0", Offset = "0x900B7C0", VA = "0x18900C9C0")]
		private static void MBELBTYEPFR(Vector a, int b, byte[] c, [Out] int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x900CC70", Offset = "0x900BA70", VA = "0x18900CC70")]
		private static void TESKUVQJEHC(Vector a, int b, byte[] c, int d, [Out] Vector e, [Out] int f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x900C850", Offset = "0x900B650", VA = "0x18900C850")]
		private static ulong DUBZBMDRAYB(Vector a, [Out] int b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x900CB30", Offset = "0x900B930", VA = "0x18900CB30")]
		private static void OFLNYZHXYOV(Vector a, [Out] DiyFp b, [Out] int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x900C480", Offset = "0x900B280", VA = "0x18900C480")]
		private static bool DLGADRYEBPW(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x900C2F0", Offset = "0x900B0F0", VA = "0x18900C2F0")]
		private static DiyFp DEGUSENYZJB(int a)
		{
			return default(DiyFp);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x900CF60", Offset = "0x900BD60", VA = "0x18900CF60")]
		private static bool TWXMQXGMDFB(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x900D680", Offset = "0x900C480", VA = "0x18900D680")]
		private static bool ZIBQUTQHUYF(Vector a, int b, [Out] double c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x900C1D0", Offset = "0x900AFD0", VA = "0x18900C1D0")]
		public static double? BSPMFPBQNQZ(Vector a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x900BF00", Offset = "0x900AD00", VA = "0x18900BF00")]
		public static float? BSEYLBNVUUH(Vector a, int b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class ZFVCTYEAQES
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[ThreadStatic]
		private static byte[] RLOFFEKNPWG;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static readonly byte[] LFBNXCNSSIJ;

		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private static readonly byte[] RJMBAOBZMIC;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly byte[] MVVFWAOOPIQ;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly int ZDRHLQKZBVS;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly ushort[] BBHBWXLZWZW;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly int NPTWAWEFRUY;

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x900D860", Offset = "0x900C660", VA = "0x18900D860")]
		private static byte[] FFBCRXQSUIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x900DDD0", Offset = "0x900CBD0", VA = "0x18900DDD0")]
		public static bool QGUMBAOMPDW(SequenceReader<byte> a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x900D940", Offset = "0x900C740", VA = "0x18900D940")]
		public static bool HMUBGLARJOB(SequenceReader<byte> a, [Out] double b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x900DF10", Offset = "0x900CD10", VA = "0x18900DF10")]
		private static bool WVQIJIHKSES(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x900DAA0", Offset = "0x900C8A0", VA = "0x18900DAA0")]
		private static bool JVBNRKKQJMZ(SequenceReader<byte> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x900E050", Offset = "0x900CE50", VA = "0x18900E050")]
		private static bool XQFGCENBFDM(SequenceReader<byte> a, byte[] b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x900DD60", Offset = "0x900CB60", VA = "0x18900DD60")]
		private static bool PRBBNHTQRTI(SequenceReader<byte> a, byte[] b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x900DA80", Offset = "0x900C880", VA = "0x18900DA80")]
		private static double IJGUZDVAQNL(bool a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x900E130", Offset = "0x900CF30", VA = "0x18900E130")]
		private static double XYXHOXWXBYT(SequenceReader<byte> a, bool b, [Out] int c)
		{
			return default(double);
		}
	}
}
namespace Utf8Json.Formatters
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class OQQLAFSVTCV<a> : LCJZQSSKXYB<a[]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly YNUOIPBFZWN<a> OUBZBETCOPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly CollectionDeserializeToBehaviour OGMXIDAUYNQ;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x19A7560", Offset = "0x19A6360", VA = "0x1819A7560")]
		public OQQLAFSVTCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
		public OQQLAFSVTCV(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5B60D20", Offset = "0x5B5FB20", VA = "0x185B60D20", Slot = "4")]
		public void Serialize(JsonWriter writer, a[] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x5B60320", Offset = "0x5B5F120", VA = "0x185B60320", Slot = "5")]
		public a[] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class JQVVMONINIG<a> : LCJZQSSKXYB<ArraySegment<a>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private static readonly YNUOIPBFZWN<a> OUBZBETCOPU;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x52B9CD0", Offset = "0x52B8AD0", VA = "0x1852B9CD0", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<a> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x52B9890", Offset = "0x52B8690", VA = "0x1852B9890", Slot = "5")]
		public ArraySegment<a> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(ArraySegment<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class WNHPGBRZTGA<a> : LCJZQSSKXYB<List<a>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly CollectionDeserializeToBehaviour OGMXIDAUYNQ;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x19A7560", Offset = "0x19A6360", VA = "0x1819A7560")]
		public WNHPGBRZTGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0xAA3550", Offset = "0xAA2350", VA = "0x180AA3550")]
		public WNHPGBRZTGA(CollectionDeserializeToBehaviour a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6815330", Offset = "0x6814130", VA = "0x186815330", Slot = "4")]
		public void Serialize(JsonWriter writer, List<a> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6811DE0", Offset = "0x6810BE0", VA = "0x186811DE0", Slot = "5")]
		public List<a> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public abstract class ZZVSXXOTQAS<a, b, c, d> : LCJZQSSKXYB<d>, PMICCMHTWMS where c : IEnumerator<a> where d : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x4185C40", Offset = "0x4184A40", VA = "0x184185C40", Slot = "4")]
		public void Serialize(JsonWriter writer, d value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x41853B0", Offset = "0x41841B0", VA = "0x1841853B0", Slot = "5")]
		public d Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract c JIGWWFBSKOS(d a);

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
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected ZZVSXXOTQAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public abstract class ZYVKLPTGUVZ<a, b, c> : ZZVSXXOTQAS<a, b, IEnumerator<a>, c> where c : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x417FCE0", Offset = "0x417EAE0", VA = "0x18417FCE0", Slot = "6")]
		protected override IEnumerator<a> JIGWWFBSKOS(c a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected ZYVKLPTGUVZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public abstract class ZYQDOIZJLKQ<a, b> : ZYVKLPTGUVZ<a, b, b> where b : class, IEnumerable<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xAFDFA0", Offset = "0xAFCDA0", VA = "0x180AFDFA0", Slot = "9")]
		protected sealed override b Complete(b intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class YCCTNKLZXDC<a, b> : ZYQDOIZJLKQ<a, b> where b : class, ICollection<a>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x40ACA10", Offset = "0x40AB810", VA = "0x1840ACA10", Slot = "7")]
		protected override b Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x40AC8B0", Offset = "0x40AB6B0", VA = "0x1840AC8B0", Slot = "8")]
		protected override void Add(b collection, int index, a value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class ZRIUSHOGSGH<a> : ZZVSXXOTQAS<a, LinkedList<a>, LinkedList<a>.Enumerator, LinkedList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4169BA0", Offset = "0x41689A0", VA = "0x184169BA0", Slot = "8")]
		protected override void Add(LinkedList<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0xAFDFA0", Offset = "0xAFCDA0", VA = "0x180AFDFA0", Slot = "9")]
		protected override LinkedList<a> Complete(LinkedList<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x4169C80", Offset = "0x4168A80", VA = "0x184169C80", Slot = "7")]
		protected override LinkedList<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x409D110", Offset = "0x409BF10", VA = "0x18409D110", Slot = "6")]
		protected override LinkedList<a>.Enumerator JIGWWFBSKOS(LinkedList<a> a)
		{
			return default(LinkedList<a>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class SMZGSJWKKZU<a> : ZZVSXXOTQAS<a, Queue<a>, Queue<a>.Enumerator, Queue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x51EB6B0", Offset = "0x51EA4B0", VA = "0x1851EB6B0", Slot = "8")]
		protected override void Add(Queue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F920", Offset = "0x4F3E720", VA = "0x184F3F920", Slot = "7")]
		protected override Queue<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x4F3FA30", Offset = "0x4F3E830", VA = "0x184F3FA30", Slot = "6")]
		protected override Queue<a>.Enumerator JIGWWFBSKOS(Queue<a> a)
		{
			return default(Queue<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xAFDFA0", Offset = "0xAFCDA0", VA = "0x180AFDFA0", Slot = "9")]
		protected override Queue<a> Complete(Queue<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class HJREWZBQEXY<a> : ZZVSXXOTQAS<a, ArrayBuffer<a>, Stack<a>.Enumerator, Stack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x4031DD0", Offset = "0x4030BD0", VA = "0x184031DD0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x417D950", Offset = "0x417C750", VA = "0x18417D950", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5101300", Offset = "0x5100100", VA = "0x185101300", Slot = "6")]
		protected override Stack<a>.Enumerator JIGWWFBSKOS(Stack<a> a)
		{
			return default(Stack<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x51011A0", Offset = "0x50FFFA0", VA = "0x1851011A0", Slot = "9")]
		protected override Stack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class FUXAAIRUHDQ<a> : ZZVSXXOTQAS<a, HashSet<a>, HashSet<a>.Enumerator, HashSet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F8E0", Offset = "0x4F3E6E0", VA = "0x184F3F8E0", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0xAFDFA0", Offset = "0xAFCDA0", VA = "0x180AFDFA0", Slot = "9")]
		protected override HashSet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F980", Offset = "0x4F3E780", VA = "0x184F3F980", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F9E0", Offset = "0x4F3E7E0", VA = "0x184F3F9E0", Slot = "6")]
		protected override HashSet<a>.Enumerator JIGWWFBSKOS(HashSet<a> a)
		{
			return default(HashSet<a>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x4F3FAE0", Offset = "0x4F3E8E0", VA = "0x184F3FAE0")]
		public FUXAAIRUHDQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public sealed class CLENQOFKYKS<a> : ZYVKLPTGUVZ<a, ArrayBuffer<a>, ReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x4031DD0", Offset = "0x4030BD0", VA = "0x184031DD0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x4031EA0", Offset = "0x4030CA0", VA = "0x184031EA0", Slot = "9")]
		protected override ReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x4031F30", Offset = "0x4030D30", VA = "0x184031F30", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class RFVJEUIQCDZ<a> : ZYVKLPTGUVZ<a, List<a>, IList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x51EB6B0", Offset = "0x51EA4B0", VA = "0x1851EB6B0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F920", Offset = "0x4F3E720", VA = "0x184F3F920", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xAFDFA0", Offset = "0xAFCDA0", VA = "0x180AFDFA0", Slot = "9")]
		protected override IList<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public sealed class VDMGRMMMXOL<a> : ZYVKLPTGUVZ<a, List<a>, ICollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x51EB6B0", Offset = "0x51EA4B0", VA = "0x1851EB6B0", Slot = "8")]
		protected override void Add(List<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F920", Offset = "0x4F3E720", VA = "0x184F3F920", Slot = "7")]
		protected override List<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0xAFDFA0", Offset = "0xAFCDA0", VA = "0x180AFDFA0", Slot = "9")]
		protected override ICollection<a> Complete(List<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class SEIXTIQYVNX<a> : ZYVKLPTGUVZ<a, ArrayBuffer<a>, IEnumerable<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x50AC780", Offset = "0x50AB580", VA = "0x1850AC780", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x417D950", Offset = "0x417C750", VA = "0x18417D950", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x417D930", Offset = "0x417C730", VA = "0x18417D930", Slot = "9")]
		protected override IEnumerable<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x548A0E0", Offset = "0x5488EE0", VA = "0x18548A0E0")]
		public SEIXTIQYVNX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public sealed class AHQTMZKPORH<a, b> : LCJZQSSKXYB<IGrouping<a, b>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5589DC0", Offset = "0x5588BC0", VA = "0x185589DC0", Slot = "4")]
		public void Serialize(JsonWriter writer, IGrouping<a, b> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5589A80", Offset = "0x5588880", VA = "0x185589A80", Slot = "5")]
		public IGrouping<a, b> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class DIKVGNFFNJK<a, b> : LCJZQSSKXYB<ILookup<a, b>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x432B8E0", Offset = "0x432A6E0", VA = "0x18432B8E0", Slot = "4")]
		public void Serialize(JsonWriter writer, ILookup<a, b> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x432B5A0", Offset = "0x432A3A0", VA = "0x18432B5A0", Slot = "5")]
		public ILookup<a, b> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class DPSXYKITLJG<a, b> : IGrouping<a, b>, IEnumerable<b>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private readonly a KUJVGNBDNRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly IEnumerable<b> DUWZPLPNRCW;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a Key
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x432E1D0", Offset = "0x432CFD0", VA = "0x18432E1D0", Slot = "4")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x432E0C0", Offset = "0x432CEC0", VA = "0x18432E0C0")]
		public DPSXYKITLJG(a a, IEnumerable<b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x432E030", Offset = "0x432CE30", VA = "0x18432E030", Slot = "5")]
		public IEnumerator<b> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x432E0A0", Offset = "0x432CEA0", VA = "0x18432E0A0", Slot = "6")]
		private IEnumerator WAAULASRGHE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class JOJHPUXCKNR<a, b> : ILookup<a, b>, IEnumerable<IGrouping<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private readonly Dictionary<a, IGrouping<a, b>> XZVNBVSPHEP;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IEnumerable<b> this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x52B97B0", Offset = "0x52B85B0", VA = "0x1852B97B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public JOJHPUXCKNR(Dictionary<a, IGrouping<a, b>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x52B9630", Offset = "0x52B8430", VA = "0x1852B9630", Slot = "5")]
		public bool Contains(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x52B9710", Offset = "0x52B8510", VA = "0x1852B9710", Slot = "6")]
		public IEnumerator<IGrouping<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x52B9710", Offset = "0x52B8510", VA = "0x1852B9710", Slot = "7")]
		private IEnumerator WAAULASRGHE()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public sealed class KGIGRTJZSTS<a> : LCJZQSSKXYB<a>, PMICCMHTWMS where a : class, IList, new()
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x53B1BE0", Offset = "0x53B09E0", VA = "0x1853B1BE0", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x53B19C0", Offset = "0x53B07C0", VA = "0x1853B19C0", Slot = "5")]
		public a Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public KGIGRTJZSTS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class MKDVQTPKFCC : LCJZQSSKXYB<IEnumerable>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public static readonly LCJZQSSKXYB<IEnumerable> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8FFD580", Offset = "0x8FFC380", VA = "0x188FFD580", Slot = "4")]
		public void Serialize(JsonWriter writer, IEnumerable value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8FFD370", Offset = "0x8FFC170", VA = "0x188FFD370", Slot = "5")]
		public IEnumerable Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public MKDVQTPKFCC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public sealed class MXCMYNPHBCQ : LCJZQSSKXYB<ICollection>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly LCJZQSSKXYB<ICollection> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8FFDB10", Offset = "0x8FFC910", VA = "0x188FFDB10", Slot = "4")]
		public void Serialize(JsonWriter writer, ICollection value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8FFD900", Offset = "0x8FFC700", VA = "0x188FFD900", Slot = "5")]
		public ICollection Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public MXCMYNPHBCQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class JCFNRUUNYKA : LCJZQSSKXYB<IList>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public static readonly LCJZQSSKXYB<IList> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8FFA800", Offset = "0x8FF9600", VA = "0x188FFA800", Slot = "4")]
		public void Serialize(JsonWriter writer, IList value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x8FFA5F0", Offset = "0x8FF93F0", VA = "0x188FFA5F0", Slot = "5")]
		public IList Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public JCFNRUUNYKA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public sealed class IRGKFIVCNGP<a> : ZYQDOIZJLKQ<a, ObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x51EB6B0", Offset = "0x51EA4B0", VA = "0x1851EB6B0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x51EB790", Offset = "0x51EA590", VA = "0x1851EB790", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class OGXUPDRXAPP<a> : ZYVKLPTGUVZ<a, ObservableCollection<a>, ReadOnlyObservableCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x51EB6B0", Offset = "0x51EA4B0", VA = "0x1851EB6B0", Slot = "8")]
		protected override void Add(ObservableCollection<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x51EB790", Offset = "0x51EA590", VA = "0x1851EB790", Slot = "7")]
		protected override ObservableCollection<a> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5B59280", Offset = "0x5B58080", VA = "0x185B59280", Slot = "9")]
		protected override ReadOnlyObservableCollection<a> Complete(ObservableCollection<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public sealed class GOCUFTETWLT<a> : ZYVKLPTGUVZ<a, ArrayBuffer<a>, IReadOnlyList<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x417D8C0", Offset = "0x417C6C0", VA = "0x18417D8C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x417D950", Offset = "0x417C750", VA = "0x18417D950", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x50AC900", Offset = "0x50AB700", VA = "0x1850AC900", Slot = "9")]
		protected override IReadOnlyList<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x50AC9A0", Offset = "0x50AB7A0", VA = "0x1850AC9A0")]
		public GOCUFTETWLT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public sealed class ZTOEXKVOOXP<a> : ZYVKLPTGUVZ<a, ArrayBuffer<a>, IReadOnlyCollection<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x417D8C0", Offset = "0x417C6C0", VA = "0x18417D8C0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x417D950", Offset = "0x417C750", VA = "0x18417D950", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x417D930", Offset = "0x417C730", VA = "0x18417D930", Slot = "9")]
		protected override IReadOnlyCollection<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ZTOEXKVOOXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public sealed class EFUPAHTWRMH<a> : ZYVKLPTGUVZ<a, HashSet<a>, ISet<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x492A950", Offset = "0x4929750", VA = "0x18492A950", Slot = "8")]
		protected override void Add(HashSet<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xAFDFA0", Offset = "0xAFCDA0", VA = "0x180AFDFA0", Slot = "9")]
		protected override ISet<a> Complete(HashSet<a> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x4169C80", Offset = "0x4168A80", VA = "0x184169C80", Slot = "7")]
		protected override HashSet<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class WEIKKFYZOOB<a> : ZYQDOIZJLKQ<a, ConcurrentBag<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x51EB6B0", Offset = "0x51EA4B0", VA = "0x1851EB6B0", Slot = "8")]
		protected override void Add(ConcurrentBag<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F920", Offset = "0x4F3E720", VA = "0x184F3F920", Slot = "7")]
		protected override ConcurrentBag<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class TOSUUCVHIBI<a> : ZYQDOIZJLKQ<a, ConcurrentQueue<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x51EB6B0", Offset = "0x51EA4B0", VA = "0x1851EB6B0", Slot = "8")]
		protected override void Add(ConcurrentQueue<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F920", Offset = "0x4F3E720", VA = "0x184F3F920", Slot = "7")]
		protected override ConcurrentQueue<a> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public sealed class TNVVPSSMVYT<a> : ZYVKLPTGUVZ<a, ArrayBuffer<a>, ConcurrentStack<a>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x4031DD0", Offset = "0x4030BD0", VA = "0x184031DD0", Slot = "8")]
		protected override void Add(ArrayBuffer<a> collection, int index, a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x417D950", Offset = "0x417C750", VA = "0x18417D950", Slot = "7")]
		protected override ArrayBuffer<a> Create()
		{
			return default(ArrayBuffer<a>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x60F9F40", Offset = "0x60F8D40", VA = "0x1860F9F40", Slot = "9")]
		protected override ConcurrentStack<a> Complete(ArrayBuffer<a> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class UWXZKLOKICO
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
		[Cpp2IlInjected.Address(RVA = "0x90071A0", Offset = "0x9005FA0", VA = "0x1890071A0")]
		public static DateTime KBBCGYKSOMK(DateTime a)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9006FF0", Offset = "0x9005DF0", VA = "0x189006FF0")]
		public static bool BQHEVJIIVTX(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f, [Out] int g, [Out] int h)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9007690", Offset = "0x9006490", VA = "0x189007690")]
		public static bool UKXQYOBMYCB(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9007480", Offset = "0x9006280", VA = "0x189007480")]
		public static bool UKXQYOBMYCB(SequenceReader<byte> a, [Out] int b, [Out] int c, [Out] int d, [Out] int e, [Out] int f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9007260", Offset = "0x9006060", VA = "0x189007260")]
		public static bool PLDYSBXPYPR(SequenceReader<byte> a, [Out] TimeSpan? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class YNZWWTAEVHY : LCJZQSSKXYB<DateTime>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public static readonly LCJZQSSKXYB<DateTime> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x900AFD0", Offset = "0x9009DD0", VA = "0x18900AFD0", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTime value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x900AA50", Offset = "0x9009850", VA = "0x18900AA50", Slot = "5")]
		public DateTime Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x900ABD0", Offset = "0x90099D0", VA = "0x18900ABD0")]
		private static DateTime Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTime);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public YNZWWTAEVHY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class RCGBJAMJSAD : LCJZQSSKXYB<DateTimeOffset>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public static readonly LCJZQSSKXYB<DateTimeOffset> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8FFFF50", Offset = "0x8FFED50", VA = "0x188FFFF50", Slot = "4")]
		public void Serialize(JsonWriter writer, DateTimeOffset value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8FFFEE0", Offset = "0x8FFECE0", VA = "0x188FFFEE0", Slot = "5")]
		public DateTimeOffset Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8FFFB00", Offset = "0x8FFE900", VA = "0x188FFFB00")]
		private DateTimeOffset Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(DateTimeOffset);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public RCGBJAMJSAD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class LHMSTWANGTI : LCJZQSSKXYB<TimeSpan>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public static readonly LCJZQSSKXYB<TimeSpan> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static byte[] YOJWQZIHAOS;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8FFC850", Offset = "0x8FFB650", VA = "0x188FFC850", Slot = "4")]
		public void Serialize(JsonWriter writer, TimeSpan value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8FFC3E0", Offset = "0x8FFB1E0", VA = "0x188FFC3E0", Slot = "5")]
		public TimeSpan Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8FFC460", Offset = "0x8FFB260", VA = "0x188FFC460")]
		private static TimeSpan Deserialize([In] ReadOnlySequence<byte> bytes)
		{
			return default(TimeSpan);
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public LHMSTWANGTI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class MOEEOUEUXVX<a, b, c, d, e> : LCJZQSSKXYB<e>, PMICCMHTWMS where d : IEnumerator<KeyValuePair<a, b>> where e : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5992240", Offset = "0x5991040", VA = "0x185992240", Slot = "4")]
		public void Serialize(JsonWriter writer, e value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x598E600", Offset = "0x598D400", VA = "0x18598E600", Slot = "5")]
		public e Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract d JIGWWFBSKOS(e a);

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
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		protected MOEEOUEUXVX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public abstract class MNYXRNKXOKO<a, b, c, d> : MOEEOUEUXVX<a, b, c, IEnumerator<KeyValuePair<a, b>>, d> where d : class, IEnumerable<KeyValuePair<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x417FCE0", Offset = "0x417EAE0", VA = "0x18417FCE0", Slot = "6")]
		protected override IEnumerator<KeyValuePair<a, b>> JIGWWFBSKOS(d a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public abstract class MMYPFFPKTFV<a, b, c> : MNYXRNKXOKO<a, b, c, c> where c : class, IDictionary<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xAFDFA0", Offset = "0xAFCDA0", VA = "0x180AFDFA0", Slot = "9")]
		protected override c Complete(c intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class XMEJMYRZQIR<a, b> : MOEEOUEUXVX<a, b, Dictionary<a, b>, Dictionary<a, b>.Enumerator, Dictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x409CAE0", Offset = "0x409B8E0", VA = "0x18409CAE0", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xAFDFA0", Offset = "0xAFCDA0", VA = "0x180AFDFA0", Slot = "9")]
		protected override Dictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x409CE20", Offset = "0x409BC20", VA = "0x18409CE20", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x409D0B0", Offset = "0x409BEB0", VA = "0x18409D0B0", Slot = "6")]
		protected override Dictionary<a, b>.Enumerator JIGWWFBSKOS(Dictionary<a, b> a)
		{
			return default(Dictionary<a, b>.Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x409D220", Offset = "0x409C020", VA = "0x18409D220")]
		public XMEJMYRZQIR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class XJZVXVALUGL<a, b, c> : MMYPFFPKTFV<a, b, c> where c : class, IDictionary<a, b>, new()
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x40996B0", Offset = "0x40984B0", VA = "0x1840996B0", Slot = "8")]
		protected override void Add(c collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x4099810", Offset = "0x4098610", VA = "0x184099810", Slot = "7")]
		protected override c Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public sealed class YMPHXIPAXEG<a, b> : MNYXRNKXOKO<a, b, Dictionary<a, b>, IDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x409CB40", Offset = "0x409B940", VA = "0x18409CB40", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x409CE80", Offset = "0x409BC80", VA = "0x18409CE80", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xAFDFA0", Offset = "0xAFCDA0", VA = "0x180AFDFA0", Slot = "9")]
		protected override IDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class HEFJAQVXTHA<a, b> : MMYPFFPKTFV<a, b, SortedList<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x409CB40", Offset = "0x409B940", VA = "0x18409CB40", Slot = "8")]
		protected override void Add(SortedList<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x409CE80", Offset = "0x409BC80", VA = "0x18409CE80", Slot = "7")]
		protected override SortedList<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public sealed class OATKKHDVNMO<a, b> : MOEEOUEUXVX<a, b, SortedDictionary<a, b>, SortedDictionary<a, b>.Enumerator, SortedDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x409CB40", Offset = "0x409B940", VA = "0x18409CB40", Slot = "8")]
		protected override void Add(SortedDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xAFDFA0", Offset = "0xAFCDA0", VA = "0x180AFDFA0", Slot = "9")]
		protected override SortedDictionary<a, b> Complete(SortedDictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x409CE80", Offset = "0x409BC80", VA = "0x18409CE80", Slot = "7")]
		protected override SortedDictionary<a, b> Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x5B55600", Offset = "0x5B54400", VA = "0x185B55600", Slot = "6")]
		protected override SortedDictionary<a, b>.Enumerator JIGWWFBSKOS(SortedDictionary<a, b> a)
		{
			return default(SortedDictionary<a, b>.Enumerator);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class HKHCSTDDJTV<a, b> : MNYXRNKXOKO<a, b, Dictionary<a, b>, ReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x409CB40", Offset = "0x409B940", VA = "0x18409CB40", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x51013B0", Offset = "0x51001B0", VA = "0x1851013B0", Slot = "9")]
		protected override ReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x5101420", Offset = "0x5100220", VA = "0x185101420", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class EALITEBFFGU<a, b> : MNYXRNKXOKO<a, b, Dictionary<a, b>, IReadOnlyDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x409CB40", Offset = "0x409B940", VA = "0x18409CB40", Slot = "8")]
		protected override void Add(Dictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xAFDFA0", Offset = "0xAFCDA0", VA = "0x180AFDFA0", Slot = "9")]
		protected override IReadOnlyDictionary<a, b> Complete(Dictionary<a, b> intermediateCollection)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x4923940", Offset = "0x4922740", VA = "0x184923940", Slot = "7")]
		protected override Dictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class GVGOZCVHWOK<a, b> : MMYPFFPKTFV<a, b, ConcurrentDictionary<a, b>>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x50B28D0", Offset = "0x50B16D0", VA = "0x1850B28D0", Slot = "8")]
		protected override void Add(ConcurrentDictionary<a, b> collection, int index, a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x409CE80", Offset = "0x409BC80", VA = "0x18409CE80", Slot = "7")]
		protected override ConcurrentDictionary<a, b> Create()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public sealed class ACKLSSPMMJW<a> : LCJZQSSKXYB<a>, PMICCMHTWMS where a : class, IDictionary, new()
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5584620", Offset = "0x5583420", VA = "0x185584620", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x55843E0", Offset = "0x55831E0", VA = "0x1855843E0", Slot = "5")]
		public a Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ACKLSSPMMJW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class VZYCIQHPPJW : LCJZQSSKXYB<IDictionary>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public static readonly LCJZQSSKXYB<IDictionary> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x9007B00", Offset = "0x9006900", VA = "0x189007B00", Slot = "4")]
		public void Serialize(JsonWriter writer, IDictionary value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x9007920", Offset = "0x9006720", VA = "0x189007920", Slot = "5")]
		public IDictionary Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public VZYCIQHPPJW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public static class HONEPVWNZCQ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8FF8A60", Offset = "0x8FF7860", VA = "0x188FF8A60")]
		public static object EUUYGBTMSQC(Type a, [Out] bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x8FF9280", Offset = "0x8FF8080", VA = "0x188FF9280")]
		public static object QGXHUOQLMVZ(Type a, [Out] bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class YEXGITLXEKH<a> : LCJZQSSKXYB<a>, PMICCMHTWMS, FZWAPUBRNSY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		[CompilerGenerated]
		private sealed class OPUURPABOAR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Type BZOQAXHJQMH;

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public OPUURPABOAR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x5B5E370", Offset = "0x5B5D170", VA = "0x185B5E370")]
			internal bool IXQARPZOCWK(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private sealed class OPPNUIGEEPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public string YUJDFROXJAZ;

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public OPPNUIGEEPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x5B5E1C0", Offset = "0x5B5CFC0", VA = "0x185B5E1C0")]
			internal bool IXVHOWTLMHT(FieldInfo a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class OPKGXBMGVDZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JsonSerializeAction<object> NOEKYBAKOPI;

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public OPKGXBMGVDZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x5B5D830", Offset = "0x5B5C630", VA = "0x185B5D830")]
			internal void IXFMXCLTJZS(JsonWriter a, a b, HYIETNPQWTC c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class OPEZZUSJLSQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JsonDeserializeFunc<object> WSNOQYZWTJB;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public OPEZZUSJLSQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x5B5CFA0", Offset = "0x5B5BDA0", VA = "0x185B5CFA0")]
			internal a IXKTUJFQTLB(JsonReader a, HYIETNPQWTC b)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private static readonly MTAUEDYTFRA<a> GLLNJNHHWWJ;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private static readonly Dictionary<a, string> XCFNIILNRRN;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private static readonly JsonSerializeAction<a> IYUZDZXLVNH;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private static readonly JsonDeserializeFunc<a> XUBNXRDCDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly bool VSBAFDXTNEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly JsonSerializeAction<a> BSXQJDILPZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private readonly JsonDeserializeFunc<a> FYBVXQMGEUB;

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x40D1C50", Offset = "0x40D0A50", VA = "0x1840D1C50")]
		static YEXGITLXEKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x40E5F60", Offset = "0x40E4D60", VA = "0x1840E5F60")]
		public YEXGITLXEKH(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x40C3110", Offset = "0x40C1F10", VA = "0x1840C3110", Slot = "4")]
		public void Serialize(JsonWriter writer, a value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x40BD4C0", Offset = "0x40BC2C0", VA = "0x1840BD4C0", Slot = "5")]
		public a Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x40C2C60", Offset = "0x40C1A60", VA = "0x1840C2C60", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, a b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x40C62F0", Offset = "0x40C50F0", VA = "0x1840C62F0", Slot = "7")]
		public a VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class SNXEZHZPVJX<a> : LCJZQSSKXYB<a[,]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5FFB140", Offset = "0x5FF9F40", VA = "0x185FFB140", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x5FFADB0", Offset = "0x5FF9BB0", VA = "0x185FFADB0", Slot = "5")]
		public a[,] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public SNXEZHZPVJX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public sealed class NNYBYQMKDNF<a> : LCJZQSSKXYB<a[,,]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5A2EBF0", Offset = "0x5A2D9F0", VA = "0x185A2EBF0", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5A2E730", Offset = "0x5A2D530", VA = "0x185A2E730", Slot = "5")]
		public a[,,] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public NNYBYQMKDNF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class WAXXTDMHLYF<a> : LCJZQSSKXYB<a[,,,]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x6758B30", Offset = "0x6757930", VA = "0x186758B30", Slot = "4")]
		public void Serialize(JsonWriter writer, a[,,,] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6758540", Offset = "0x6757340", VA = "0x186758540", Slot = "5")]
		public a[,,,] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public WAXXTDMHLYF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public sealed class INMQAYOGAEL<a> : LCJZQSSKXYB<a?>, PMICCMHTWMS where a : struct
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x51E9870", Offset = "0x51E8670", VA = "0x1851E9870", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x51E9180", Offset = "0x51E7F80", VA = "0x1851E9180", Slot = "5")]
		public a? Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public INMQAYOGAEL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public sealed class NSJPAULRIQV<a> : LCJZQSSKXYB<a?>, PMICCMHTWMS where a : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly LCJZQSSKXYB<a> OEGKRUAGDQG;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public NSJPAULRIQV(LCJZQSSKXYB<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x5A3D4E0", Offset = "0x5A3C2E0", VA = "0x185A3D4E0", Slot = "4")]
		public void Serialize(JsonWriter writer, a? value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5A3D360", Offset = "0x5A3C160", VA = "0x185A3D360", Slot = "5")]
		public a? Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public sealed class GKAOFCABARW : LCJZQSSKXYB<sbyte>, PMICCMHTWMS, FZWAPUBRNSY<sbyte>
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly GKAOFCABARW SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8FF8420", Offset = "0x8FF7220", VA = "0x188FF8420", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8FF8300", Offset = "0x8FF7100", VA = "0x188FF8300", Slot = "5")]
		public sbyte Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8FF8310", Offset = "0x8FF7110", VA = "0x188FF8310", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, sbyte b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8FF84B0", Offset = "0x8FF72B0", VA = "0x188FF84B0", Slot = "7")]
		public sbyte VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public GKAOFCABARW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public sealed class XTRFXZUDDWN : LCJZQSSKXYB<sbyte?>, PMICCMHTWMS, FZWAPUBRNSY<sbyte?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly XTRFXZUDDWN SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x9008D70", Offset = "0x9007B70", VA = "0x189008D70", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte? value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x9008BA0", Offset = "0x90079A0", VA = "0x189008BA0", Slot = "5")]
		public sbyte? Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x9008C10", Offset = "0x9007A10", VA = "0x189008C10", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, sbyte? b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x9008E60", Offset = "0x9007C60", VA = "0x189008E60", Slot = "7")]
		public sbyte? VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public XTRFXZUDDWN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public sealed class ABJCOMCBZOD : LCJZQSSKXYB<sbyte[]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly ABJCOMCBZOD SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8FF50F0", Offset = "0x8FF3EF0", VA = "0x188FF50F0", Slot = "4")]
		public void Serialize(JsonWriter writer, sbyte[] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8FF4FB0", Offset = "0x8FF3DB0", VA = "0x188FF4FB0", Slot = "5")]
		public sbyte[] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ABJCOMCBZOD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public sealed class OVXCWUDTTWD : LCJZQSSKXYB<short>, PMICCMHTWMS, FZWAPUBRNSY<short>
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly OVXCWUDTTWD SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8FFEA50", Offset = "0x8FFD850", VA = "0x188FFEA50", Slot = "4")]
		public void Serialize(JsonWriter writer, short value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE930", Offset = "0x8FFD730", VA = "0x188FFE930", Slot = "5")]
		public short Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE940", Offset = "0x8FFD740", VA = "0x188FFE940", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, short b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8FFEAE0", Offset = "0x8FFD8E0", VA = "0x188FFEAE0", Slot = "7")]
		public short VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return default(short);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public OVXCWUDTTWD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public sealed class PRLVLYPHBOS : LCJZQSSKXYB<short?>, PMICCMHTWMS, FZWAPUBRNSY<short?>
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly PRLVLYPHBOS SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8FFEDA0", Offset = "0x8FFDBA0", VA = "0x188FFEDA0", Slot = "4")]
		public void Serialize(JsonWriter writer, short? value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8FFEBD0", Offset = "0x8FFD9D0", VA = "0x188FFEBD0", Slot = "5")]
		public short? Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8FFEC40", Offset = "0x8FFDA40", VA = "0x188FFEC40", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, short? b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8FFEE90", Offset = "0x8FFDC90", VA = "0x188FFEE90", Slot = "7")]
		public short? VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public PRLVLYPHBOS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class XYQZCERHPRM : LCJZQSSKXYB<short[]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly XYQZCERHPRM SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x90090E0", Offset = "0x9007EE0", VA = "0x1890090E0", Slot = "4")]
		public void Serialize(JsonWriter writer, short[] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9008FA0", Offset = "0x9007DA0", VA = "0x189008FA0", Slot = "5")]
		public short[] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public XYQZCERHPRM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public sealed class SZQKZNOPLAF : LCJZQSSKXYB<int>, PMICCMHTWMS, FZWAPUBRNSY<int>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly SZQKZNOPLAF SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x9001C10", Offset = "0x9000A10", VA = "0x189001C10", Slot = "4")]
		public void Serialize(JsonWriter writer, int value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9001AF0", Offset = "0x90008F0", VA = "0x189001AF0", Slot = "5")]
		public int Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x9001B00", Offset = "0x9000900", VA = "0x189001B00", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, int b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x9001CA0", Offset = "0x9000AA0", VA = "0x189001CA0", Slot = "7")]
		public int VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public SZQKZNOPLAF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class FHGRQLAGBHC : LCJZQSSKXYB<int?>, PMICCMHTWMS, FZWAPUBRNSY<int?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly FHGRQLAGBHC SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8FF7BA0", Offset = "0x8FF69A0", VA = "0x188FF7BA0", Slot = "4")]
		public void Serialize(JsonWriter writer, int? value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8FF79D0", Offset = "0x8FF67D0", VA = "0x188FF79D0", Slot = "5")]
		public int? Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8FF7A40", Offset = "0x8FF6840", VA = "0x188FF7A40", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, int? b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8FF7C90", Offset = "0x8FF6A90", VA = "0x188FF7C90", Slot = "7")]
		public int? VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public FHGRQLAGBHC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public sealed class INWBUQEAQCI : LCJZQSSKXYB<int[]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly INWBUQEAQCI SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x8FF9FE0", Offset = "0x8FF8DE0", VA = "0x188FF9FE0", Slot = "4")]
		public void Serialize(JsonWriter writer, int[] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8FF9EA0", Offset = "0x8FF8CA0", VA = "0x188FF9EA0", Slot = "5")]
		public int[] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public INWBUQEAQCI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public sealed class FTORUVJEWWA : LCJZQSSKXYB<long>, PMICCMHTWMS, FZWAPUBRNSY<long>
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly FTORUVJEWWA SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8FF8000", Offset = "0x8FF6E00", VA = "0x188FF8000", Slot = "4")]
		public void Serialize(JsonWriter writer, long value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8FF7F20", Offset = "0x8FF6D20", VA = "0x188FF7F20", Slot = "5")]
		public long Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8FF7F30", Offset = "0x8FF6D30", VA = "0x188FF7F30", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, long b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8FF8060", Offset = "0x8FF6E60", VA = "0x188FF8060", Slot = "7")]
		public long VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public FTORUVJEWWA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public sealed class QXICIWFZMEV : LCJZQSSKXYB<long?>, PMICCMHTWMS, FZWAPUBRNSY<long?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly QXICIWFZMEV SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x8FFF920", Offset = "0x8FFE720", VA = "0x188FFF920", Slot = "4")]
		public void Serialize(JsonWriter writer, long? value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x8FFF760", Offset = "0x8FFE560", VA = "0x188FFF760", Slot = "5")]
		public long? Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8FFF7F0", Offset = "0x8FFE5F0", VA = "0x188FFF7F0", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, long? b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8FFF9E0", Offset = "0x8FFE7E0", VA = "0x188FFF9E0", Slot = "7")]
		public long? VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public QXICIWFZMEV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public sealed class QHKVROJSLRZ : LCJZQSSKXYB<long[]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly QHKVROJSLRZ SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x8FFF110", Offset = "0x8FFDF10", VA = "0x188FFF110", Slot = "4")]
		public void Serialize(JsonWriter writer, long[] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8FFEFD0", Offset = "0x8FFDDD0", VA = "0x188FFEFD0", Slot = "5")]
		public long[] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public QHKVROJSLRZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public sealed class KFMJOLRYDXL : LCJZQSSKXYB<byte>, PMICCMHTWMS, FZWAPUBRNSY<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly KFMJOLRYDXL SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8FFAD40", Offset = "0x8FF9B40", VA = "0x188FFAD40", Slot = "4")]
		public void Serialize(JsonWriter writer, byte value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8FFAC20", Offset = "0x8FF9A20", VA = "0x188FFAC20", Slot = "5")]
		public byte Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x8FFAC30", Offset = "0x8FF9A30", VA = "0x188FFAC30", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, byte b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8FFADD0", Offset = "0x8FF9BD0", VA = "0x188FFADD0", Slot = "7")]
		public byte VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public KFMJOLRYDXL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public sealed class LYNBRQBXNMG : LCJZQSSKXYB<byte?>, PMICCMHTWMS, FZWAPUBRNSY<byte?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly LYNBRQBXNMG SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8FFD140", Offset = "0x8FFBF40", VA = "0x188FFD140", Slot = "4")]
		public void Serialize(JsonWriter writer, byte? value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8FFCF70", Offset = "0x8FFBD70", VA = "0x188FFCF70", Slot = "5")]
		public byte? Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8FFCFE0", Offset = "0x8FFBDE0", VA = "0x188FFCFE0", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, byte? b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8FFD230", Offset = "0x8FFC030", VA = "0x188FFD230", Slot = "7")]
		public byte? VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public LYNBRQBXNMG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public sealed class YCNTCIPLEZA : LCJZQSSKXYB<ushort>, PMICCMHTWMS, FZWAPUBRNSY<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly YCNTCIPLEZA SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x90098F0", Offset = "0x90086F0", VA = "0x1890098F0", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x90097D0", Offset = "0x90085D0", VA = "0x1890097D0", Slot = "5")]
		public ushort Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x90097E0", Offset = "0x90085E0", VA = "0x1890097E0", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, ushort b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x9009980", Offset = "0x9008780", VA = "0x189009980", Slot = "7")]
		public ushort VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public YCNTCIPLEZA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public sealed class XGZAFBENNIJ : LCJZQSSKXYB<ushort?>, PMICCMHTWMS, FZWAPUBRNSY<ushort?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly XGZAFBENNIJ SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x9008970", Offset = "0x9007770", VA = "0x189008970", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort? value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x90087A0", Offset = "0x90075A0", VA = "0x1890087A0", Slot = "5")]
		public ushort? Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x9008810", Offset = "0x9007610", VA = "0x189008810", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, ushort? b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x9008A60", Offset = "0x9007860", VA = "0x189008A60", Slot = "7")]
		public ushort? VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public XGZAFBENNIJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public sealed class KOVIYVPXODT : LCJZQSSKXYB<ushort[]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly KOVIYVPXODT SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8FFB000", Offset = "0x8FF9E00", VA = "0x188FFB000", Slot = "4")]
		public void Serialize(JsonWriter writer, ushort[] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x8FFAEC0", Offset = "0x8FF9CC0", VA = "0x188FFAEC0", Slot = "5")]
		public ushort[] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public KOVIYVPXODT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public sealed class SEKWRRZCKGA : LCJZQSSKXYB<uint>, PMICCMHTWMS, FZWAPUBRNSY<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly SEKWRRZCKGA SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x9001780", Offset = "0x9000580", VA = "0x189001780", Slot = "4")]
		public void Serialize(JsonWriter writer, uint value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x9001660", Offset = "0x9000460", VA = "0x189001660", Slot = "5")]
		public uint Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9001670", Offset = "0x9000470", VA = "0x189001670", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, uint b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9001810", Offset = "0x9000610", VA = "0x189001810", Slot = "7")]
		public uint VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public SEKWRRZCKGA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public sealed class IKBYCOTRQSL : LCJZQSSKXYB<uint?>, PMICCMHTWMS, FZWAPUBRNSY<uint?>
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly IKBYCOTRQSL SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8FF9C70", Offset = "0x8FF8A70", VA = "0x188FF9C70", Slot = "4")]
		public void Serialize(JsonWriter writer, uint? value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x8FF9AA0", Offset = "0x8FF88A0", VA = "0x188FF9AA0", Slot = "5")]
		public uint? Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8FF9B10", Offset = "0x8FF8910", VA = "0x188FF9B10", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, uint? b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x8FF9D60", Offset = "0x8FF8B60", VA = "0x188FF9D60", Slot = "7")]
		public uint? VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public IKBYCOTRQSL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public sealed class AYQMMFQCIFN : LCJZQSSKXYB<uint[]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly AYQMMFQCIFN SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x8FF5610", Offset = "0x8FF4410", VA = "0x188FF5610", Slot = "4")]
		public void Serialize(JsonWriter writer, uint[] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x8FF54D0", Offset = "0x8FF42D0", VA = "0x188FF54D0", Slot = "5")]
		public uint[] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public AYQMMFQCIFN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public sealed class WBWJRRTKKVT : LCJZQSSKXYB<ulong>, PMICCMHTWMS, FZWAPUBRNSY<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly WBWJRRTKKVT SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x90082F0", Offset = "0x90070F0", VA = "0x1890082F0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x9008210", Offset = "0x9007010", VA = "0x189008210", Slot = "5")]
		public ulong Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x9008220", Offset = "0x9007020", VA = "0x189008220", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, ulong b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x9008350", Offset = "0x9007150", VA = "0x189008350", Slot = "7")]
		public ulong VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public WBWJRRTKKVT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public sealed class WUOFJVXVIQO : LCJZQSSKXYB<ulong?>, PMICCMHTWMS, FZWAPUBRNSY<ulong?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly WUOFJVXVIQO SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x90085C0", Offset = "0x90073C0", VA = "0x1890085C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong? value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x9008400", Offset = "0x9007200", VA = "0x189008400", Slot = "5")]
		public ulong? Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x9008490", Offset = "0x9007290", VA = "0x189008490", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, ulong? b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x9008680", Offset = "0x9007480", VA = "0x189008680", Slot = "7")]
		public ulong? VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public WUOFJVXVIQO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	public sealed class ISMKKYRUFTW : LCJZQSSKXYB<ulong[]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly ISMKKYRUFTW SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8FFA3C0", Offset = "0x8FF91C0", VA = "0x188FFA3C0", Slot = "4")]
		public void Serialize(JsonWriter writer, ulong[] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x8FFA280", Offset = "0x8FF9080", VA = "0x188FFA280", Slot = "5")]
		public ulong[] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ISMKKYRUFTW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public sealed class ORLBGQCZMGH : LCJZQSSKXYB<float>, PMICCMHTWMS, FZWAPUBRNSY<float>
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly ORLBGQCZMGH SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE5B0", Offset = "0x8FFD3B0", VA = "0x188FFE5B0", Slot = "4")]
		public void Serialize(JsonWriter writer, float value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE4D0", Offset = "0x8FFD2D0", VA = "0x188FFE4D0", Slot = "5")]
		public float Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE4E0", Offset = "0x8FFD2E0", VA = "0x188FFE4E0", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, float b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE610", Offset = "0x8FFD410", VA = "0x188FFE610", Slot = "7")]
		public float VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ORLBGQCZMGH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public sealed class NAPVBQNBKEQ : LCJZQSSKXYB<float?>, PMICCMHTWMS, FZWAPUBRNSY<float?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly NAPVBQNBKEQ SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE150", Offset = "0x8FFCF50", VA = "0x188FFE150", Slot = "4")]
		public void Serialize(JsonWriter writer, float? value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x8FFDFC0", Offset = "0x8FFCDC0", VA = "0x188FFDFC0", Slot = "5")]
		public float? Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE030", Offset = "0x8FFCE30", VA = "0x188FFE030", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, float? b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE210", Offset = "0x8FFD010", VA = "0x188FFE210", Slot = "7")]
		public float? VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public NAPVBQNBKEQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public sealed class RROJMGLPEES : LCJZQSSKXYB<float[]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly RROJMGLPEES SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x9000F50", Offset = "0x8FFFD50", VA = "0x189000F50", Slot = "4")]
		public void Serialize(JsonWriter writer, float[] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x9000E10", Offset = "0x8FFFC10", VA = "0x189000E10", Slot = "5")]
		public float[] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public RROJMGLPEES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public sealed class CJEKZQICBQQ : LCJZQSSKXYB<double>, PMICCMHTWMS, FZWAPUBRNSY<double>
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly CJEKZQICBQQ SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6580", Offset = "0x8FF5380", VA = "0x188FF6580", Slot = "4")]
		public void Serialize(JsonWriter writer, double value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8FF64A0", Offset = "0x8FF52A0", VA = "0x188FF64A0", Slot = "5")]
		public double Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8FF64B0", Offset = "0x8FF52B0", VA = "0x188FF64B0", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, double b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8FF65E0", Offset = "0x8FF53E0", VA = "0x188FF65E0", Slot = "7")]
		public double VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public CJEKZQICBQQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public sealed class BBYGAGUREDB : LCJZQSSKXYB<double?>, PMICCMHTWMS, FZWAPUBRNSY<double?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly BBYGAGUREDB SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x8FF5A70", Offset = "0x8FF4870", VA = "0x188FF5A70", Slot = "4")]
		public void Serialize(JsonWriter writer, double? value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8FF58B0", Offset = "0x8FF46B0", VA = "0x188FF58B0", Slot = "5")]
		public double? Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8FF5940", Offset = "0x8FF4740", VA = "0x188FF5940", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, double? b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x8FF5B30", Offset = "0x8FF4930", VA = "0x188FF5B30", Slot = "7")]
		public double? VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public BBYGAGUREDB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public sealed class EMIPYFPKCZN : LCJZQSSKXYB<double[]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly EMIPYFPKCZN SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6FF0", Offset = "0x8FF5DF0", VA = "0x188FF6FF0", Slot = "4")]
		public void Serialize(JsonWriter writer, double[] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6EB0", Offset = "0x8FF5CB0", VA = "0x188FF6EB0", Slot = "5")]
		public double[] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public EMIPYFPKCZN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	public sealed class SKFTCEGFTQJ : LCJZQSSKXYB<bool>, PMICCMHTWMS, FZWAPUBRNSY<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly SKFTCEGFTQJ SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x90019E0", Offset = "0x90007E0", VA = "0x1890019E0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x9001900", Offset = "0x9000700", VA = "0x189001900", Slot = "5")]
		public bool Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x9001910", Offset = "0x9000710", VA = "0x189001910", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, bool b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x9001A40", Offset = "0x9000840", VA = "0x189001A40", Slot = "7")]
		public bool VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public SKFTCEGFTQJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	public sealed class UHYJNBZBUVO : LCJZQSSKXYB<bool?>, PMICCMHTWMS, FZWAPUBRNSY<bool?>
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly UHYJNBZBUVO SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x9004AB0", Offset = "0x90038B0", VA = "0x189004AB0", Slot = "4")]
		public void Serialize(JsonWriter writer, bool? value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x9004920", Offset = "0x9003720", VA = "0x189004920", Slot = "5")]
		public bool? Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x9004990", Offset = "0x9003790", VA = "0x189004990", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, bool? b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x9004B70", Offset = "0x9003970", VA = "0x189004B70", Slot = "7")]
		public bool? VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public UHYJNBZBUVO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public sealed class BYKTDJKJJJS : LCJZQSSKXYB<bool[]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly BYKTDJKJJJS SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x8FF5F40", Offset = "0x8FF4D40", VA = "0x188FF5F40", Slot = "4")]
		public void Serialize(JsonWriter writer, bool[] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x8FF5E00", Offset = "0x8FF4C00", VA = "0x188FF5E00", Slot = "5")]
		public bool[] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public BYKTDJKJJJS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public sealed class UWHQAEDLUYA : LCJZQSSKXYB<byte[]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly LCJZQSSKXYB<byte[]> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x9006EC0", Offset = "0x9005CC0", VA = "0x189006EC0", Slot = "4")]
		public void Serialize(JsonWriter writer, byte[] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x9006E50", Offset = "0x9005C50", VA = "0x189006E50", Slot = "5")]
		public byte[] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public UWHQAEDLUYA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	public sealed class OSLZKGJQTZF : LCJZQSSKXYB<ArraySegment<byte>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly LCJZQSSKXYB<ArraySegment<byte>> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE790", Offset = "0x8FFD590", VA = "0x188FFE790", Slot = "4")]
		public void Serialize(JsonWriter writer, ArraySegment<byte> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE6C0", Offset = "0x8FFD4C0", VA = "0x188FFE6C0", Slot = "5")]
		public ArraySegment<byte> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public OSLZKGJQTZF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	public sealed class ASLOCFFHOCH : LCJZQSSKXYB<string>, PMICCMHTWMS, FZWAPUBRNSY<string>
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly LCJZQSSKXYB<string> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8FF5400", Offset = "0x8FF4200", VA = "0x188FF5400", Slot = "4")]
		public void Serialize(JsonWriter writer, string value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8FF5390", Offset = "0x8FF4190", VA = "0x188FF5390", Slot = "5")]
		public string Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8FF53A0", Offset = "0x8FF41A0", VA = "0x188FF53A0", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, string b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8FF5390", Offset = "0x8FF4190", VA = "0x188FF5390", Slot = "7")]
		public string VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ASLOCFFHOCH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	public sealed class SDBFIQGQSUC : LCJZQSSKXYB<string[]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly SDBFIQGQSUC SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x9001430", Offset = "0x9000230", VA = "0x189001430", Slot = "4")]
		public void Serialize(JsonWriter writer, string[] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x90012E0", Offset = "0x90000E0", VA = "0x1890012E0", Slot = "5")]
		public string[] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public SDBFIQGQSUC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	public sealed class FLUCNTVQCZJ : LCJZQSSKXYB<char>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly FLUCNTVQCZJ SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x8FF7E00", Offset = "0x8FF6C00", VA = "0x188FF7E00", Slot = "4")]
		public void Serialize(JsonWriter writer, char value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8FF7DD0", Offset = "0x8FF6BD0", VA = "0x188FF7DD0", Slot = "5")]
		public char Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(char);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public FLUCNTVQCZJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public sealed class RKBYUNSBPIY : LCJZQSSKXYB<char?>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly RKBYUNSBPIY SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x9000CA0", Offset = "0x8FFFAA0", VA = "0x189000CA0", Slot = "4")]
		public void Serialize(JsonWriter writer, char? value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x9000BE0", Offset = "0x8FFF9E0", VA = "0x189000BE0", Slot = "5")]
		public char? Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public RKBYUNSBPIY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	public sealed class YBFHLDJXUEC : LCJZQSSKXYB<char[]>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly YBFHLDJXUEC SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x9009510", Offset = "0x9008310", VA = "0x189009510", Slot = "4")]
		public void Serialize(JsonWriter writer, char[] value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x9009380", Offset = "0x9008180", VA = "0x189009380", Slot = "5")]
		public char[] Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public YBFHLDJXUEC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public sealed class ENSWOJAOUBS : LCJZQSSKXYB<Guid>, PMICCMHTWMS, FZWAPUBRNSY<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly LCJZQSSKXYB<Guid> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x8FF7550", Offset = "0x8FF6350", VA = "0x188FF7550", Slot = "4")]
		public void Serialize(JsonWriter writer, Guid value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8FF7370", Offset = "0x8FF6170", VA = "0x188FF7370", Slot = "5")]
		public Guid Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8FF73D0", Offset = "0x8FF61D0", VA = "0x188FF73D0", Slot = "6")]
		public void RYESLTGKTSY(JsonWriter a, Guid b, HYIETNPQWTC c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x8FF76C0", Offset = "0x8FF64C0", VA = "0x188FF76C0", Slot = "7")]
		public Guid VHBHJWRSLTO(JsonReader a, HYIETNPQWTC b)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ENSWOJAOUBS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public sealed class QOHPRDPPYOU : LCJZQSSKXYB<decimal>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly LCJZQSSKXYB<decimal> SNTFEPMFQUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private readonly bool TRSHIWGHWHM;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7369970", Offset = "0x7368770", VA = "0x187369970")]
		public QOHPRDPPYOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xDAA7A0", Offset = "0xDA95A0", VA = "0x180DAA7A0")]
		public QOHPRDPPYOU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8FFF510", Offset = "0x8FFE310", VA = "0x188FFF510", Slot = "4")]
		public void Serialize(JsonWriter writer, decimal value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8FFF340", Offset = "0x8FFE140", VA = "0x188FFF340", Slot = "5")]
		public decimal Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(decimal);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	public sealed class BYSYUPAHNGT : LCJZQSSKXYB<Uri>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly LCJZQSSKXYB<Uri> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x8FF6350", Offset = "0x8FF5150", VA = "0x188FF6350", Slot = "4")]
		public void Serialize(JsonWriter writer, Uri value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8FF62D0", Offset = "0x8FF50D0", VA = "0x188FF62D0", Slot = "5")]
		public Uri Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public BYSYUPAHNGT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public sealed class HKFSNYKNVBD : LCJZQSSKXYB<Version>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly LCJZQSSKXYB<Version> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x8FF8620", Offset = "0x8FF7420", VA = "0x188FF8620", Slot = "4")]
		public void Serialize(JsonWriter writer, Version value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8FF85A0", Offset = "0x8FF73A0", VA = "0x188FF85A0", Slot = "5")]
		public Version Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public HKFSNYKNVBD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public sealed class QSFNHCPOGSN<a, b> : LCJZQSSKXYB<KeyValuePair<a, b>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5D0B100", Offset = "0x5D09F00", VA = "0x185D0B100", Slot = "4")]
		public void Serialize(JsonWriter writer, KeyValuePair<a, b> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5D0AC40", Offset = "0x5D09A40", VA = "0x185D0AC40", Slot = "5")]
		public KeyValuePair<a, b> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(KeyValuePair<a, b>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	public sealed class RJQBQJDHYOB : LCJZQSSKXYB<StringBuilder>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly LCJZQSSKXYB<StringBuilder> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x9000AD0", Offset = "0x8FFF8D0", VA = "0x189000AD0", Slot = "4")]
		public void Serialize(JsonWriter writer, StringBuilder value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x9000A50", Offset = "0x8FFF850", VA = "0x189000A50", Slot = "5")]
		public StringBuilder Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public RJQBQJDHYOB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public sealed class YWPVKXTRBYL : LCJZQSSKXYB<BitArray>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly LCJZQSSKXYB<BitArray> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x900BD10", Offset = "0x900AB10", VA = "0x18900BD10", Slot = "4")]
		public void Serialize(JsonWriter writer, BitArray value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x900BBF0", Offset = "0x900A9F0", VA = "0x18900BBF0", Slot = "5")]
		public BitArray Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public YWPVKXTRBYL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	public sealed class HKNUSVTJKED : LCJZQSSKXYB<Type>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly HKNUSVTJKED SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly Regex ITYHHWZOYLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool KILOGWHTKGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool CDBKYZAXFJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool CJQROJEVCCG;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x8FF8A40", Offset = "0x8FF7840", VA = "0x188FF8A40")]
		public HKNUSVTJKED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x833D280", Offset = "0x833C080", VA = "0x18833D280")]
		public HKNUSVTJKED(bool a, bool b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8FF8860", Offset = "0x8FF7660", VA = "0x188FF8860", Slot = "4")]
		public void Serialize(JsonWriter writer, Type value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8FF8750", Offset = "0x8FF7550", VA = "0x188FF8750", Slot = "5")]
		public Type Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	public sealed class ZFWYATTDEBJ : LCJZQSSKXYB<BigInteger>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly LCJZQSSKXYB<BigInteger> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x900F460", Offset = "0x900E260", VA = "0x18900F460", Slot = "4")]
		public void Serialize(JsonWriter writer, BigInteger value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x900F3B0", Offset = "0x900E1B0", VA = "0x18900F3B0", Slot = "5")]
		public BigInteger Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(BigInteger);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ZFWYATTDEBJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	public sealed class EXGUUHLYUXP : LCJZQSSKXYB<Complex>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly LCJZQSSKXYB<Complex> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x8FF7830", Offset = "0x8FF6630", VA = "0x188FF7830", Slot = "4")]
		public void Serialize(JsonWriter writer, Complex value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8FF77A0", Offset = "0x8FF65A0", VA = "0x188FF77A0", Slot = "5")]
		public Complex Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(Complex);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public EXGUUHLYUXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	public sealed class TYTZMNWKIPV : LCJZQSSKXYB<ExpandoObject>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly LCJZQSSKXYB<ExpandoObject> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x9004090", Offset = "0x9002E90", VA = "0x189004090", Slot = "4")]
		public void Serialize(JsonWriter writer, ExpandoObject value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x9003E60", Offset = "0x9002C60", VA = "0x189003E60", Slot = "5")]
		public ExpandoObject Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public TYTZMNWKIPV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public sealed class ETCOISAYAJI<a> : LCJZQSSKXYB<Lazy<a>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x4954AF0", Offset = "0x49538F0", VA = "0x184954AF0", Slot = "4")]
		public void Serialize(JsonWriter writer, Lazy<a> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x4954900", Offset = "0x4953700", VA = "0x184954900", Slot = "5")]
		public Lazy<a> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	public sealed class FUHWNEQKGZE : LCJZQSSKXYB<Task>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly LCJZQSSKXYB<Task> SNTFEPMFQUI;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private static readonly Task PNPIRHKBFYB;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8FF81C0", Offset = "0x8FF6FC0", VA = "0x188FF81C0", Slot = "4")]
		public void Serialize(JsonWriter writer, Task value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8FF8110", Offset = "0x8FF6F10", VA = "0x188FF8110", Slot = "5")]
		public Task Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public FUHWNEQKGZE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	public sealed class PAHDSOTRXRC<a> : LCJZQSSKXYB<Task<a>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C16F70", Offset = "0x5C15D70", VA = "0x185C16F70", Slot = "4")]
		public void Serialize(JsonWriter writer, Task<a> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x5C16D80", Offset = "0x5C15B80", VA = "0x185C16D80", Slot = "5")]
		public Task<a> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	public sealed class RNBTSOUKTJI<a> : LCJZQSSKXYB<ValueTask<a>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x5D47950", Offset = "0x5D46750", VA = "0x185D47950", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTask<a> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x5D47730", Offset = "0x5D46530", VA = "0x185D47730", Slot = "5")]
		public ValueTask<a> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(ValueTask<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	public sealed class MICNCDLRULK<a> : LCJZQSSKXYB<Tuple<a>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5931150", Offset = "0x592FF50", VA = "0x185931150", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x5930E90", Offset = "0x592FC90", VA = "0x185930E90", Slot = "5")]
		public Tuple<a> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	public sealed class MISHTXTJWTL<a, b> : LCJZQSSKXYB<Tuple<a, b>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x59324D0", Offset = "0x59312D0", VA = "0x1859324D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x59320C0", Offset = "0x5930EC0", VA = "0x1859320C0", Slot = "5")]
		public Tuple<a, b> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	public sealed class MINAWQZMNIC<a, b, c> : LCJZQSSKXYB<Tuple<a, b, c>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x5931A50", Offset = "0x5930850", VA = "0x185931A50", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x5931510", Offset = "0x5930310", VA = "0x185931510", Slot = "5")]
		public Tuple<a, b, c> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	public sealed class MJCVOLHEPQD<a, b, c, d> : LCJZQSSKXYB<Tuple<a, b, c, d>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x5934190", Offset = "0x5932F90", VA = "0x185934190", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x5933B00", Offset = "0x5932900", VA = "0x185933B00", Slot = "5")]
		public Tuple<a, b, c, d> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public sealed class MIXORENHGEU<a, b, c, d, e> : LCJZQSSKXYB<Tuple<a, b, c, d, e>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x59331D0", Offset = "0x5931FD0", VA = "0x1859331D0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x59329E0", Offset = "0x59317E0", VA = "0x1859329E0", Slot = "5")]
		public Tuple<a, b, c, d, e> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public sealed class MJNJIYUZIMV<a, b, c, d, e, f> : LCJZQSSKXYB<Tuple<a, b, c, d, e, f>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x59369B0", Offset = "0x59357B0", VA = "0x1859369B0", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5936040", Offset = "0x5934E40", VA = "0x185936040", Slot = "5")]
		public Tuple<a, b, c, d, e, f> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public sealed class MJICLSBBZBM<a, b, c, d, e, f, g> : LCJZQSSKXYB<Tuple<a, b, c, d, e, f, g>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x5935440", Offset = "0x5934240", VA = "0x185935440", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x5934960", Offset = "0x5933760", VA = "0x185934960", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public sealed class MJXXDMIUBJN<a, b, c, d, e, f, g, h> : LCJZQSSKXYB<Tuple<a, b, c, d, e, f, g, h>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x5938080", Offset = "0x5936E80", VA = "0x185938080", Slot = "4")]
		public void Serialize(JsonWriter writer, Tuple<a, b, c, d, e, f, g, h> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x5937440", Offset = "0x5936240", VA = "0x185937440", Slot = "5")]
		public Tuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public sealed class FCBTIRWWIDZ<a> : LCJZQSSKXYB<ValueTuple<a>>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x4F2E8B0", Offset = "0x4F2D6B0", VA = "0x184F2E8B0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x4F2E4A0", Offset = "0x4F2D2A0", VA = "0x184F2E4A0", Slot = "5")]
		public ValueTuple<a> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(ValueTuple<a>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public sealed class FCHAFYQTRPI<a, b> : LCJZQSSKXYB<(a, b)>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x4F2F150", Offset = "0x4F2DF50", VA = "0x184F2F150", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b) value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x4F2EC70", Offset = "0x4F2DA70", VA = "0x184F2EC70", Slot = "5")]
		public (a, b) Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default((a, b));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public sealed class FCMHDFKRBAR<a, b, c> : LCJZQSSKXYB<(a, b, c)>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x4F2FCF0", Offset = "0x4F2EAF0", VA = "0x184F2FCF0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c) value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x4F2F690", Offset = "0x4F2E490", VA = "0x184F2F690", Slot = "5")]
		public (a, b, c) Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default((a, b, c));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public sealed class FBBKWKBJMZG<a, b, c, d> : LCJZQSSKXYB<(a, b, c, d)>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x4F290E0", Offset = "0x4F27EE0", VA = "0x184F290E0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d) value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x4F288C0", Offset = "0x4F276C0", VA = "0x184F288C0", Slot = "5")]
		public (a, b, c, d) Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default((a, b, c, d));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public sealed class FBGRTQVGWKP<a, b, c, d, e> : LCJZQSSKXYB<(a, b, c, d, e)>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x4F2A300", Offset = "0x4F29100", VA = "0x184F2A300", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e) value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x4F29970", Offset = "0x4F28770", VA = "0x184F29970", Slot = "5")]
		public (a, b, c, d, e) Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default((a, b, c, d, e));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public sealed class FBLYQXPEFVY<a, b, c, d, e, f> : LCJZQSSKXYB<(a, b, c, d, e, f)>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x4F2B8D0", Offset = "0x4F2A6D0", VA = "0x184F2B8D0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f) value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x4F2AD30", Offset = "0x4F29B30", VA = "0x184F2AD30", Slot = "5")]
		public (a, b, c, d, e, f) Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default((a, b, c, d, e, f));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	public sealed class FBRFOEJBPHH<a, b, c, d, e, f, g> : LCJZQSSKXYB<(a, b, c, d, e, f, g)>, PMICCMHTWMS
	{
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x4F2D1E0", Offset = "0x4F2BFE0", VA = "0x184F2D1E0", Slot = "4")]
		public void Serialize(JsonWriter writer, (a, b, c, d, e, f, g) value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x4F2C4A0", Offset = "0x4F2B2A0", VA = "0x184F2C4A0", Slot = "5")]
		public (a, b, c, d, e, f, g) Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default((a, b, c, d, e, f, g));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	public sealed class FAGJHIZUBFW<a, b, c, d, e, f, g, h> : LCJZQSSKXYB<ValueTuple<a, b, c, d, e, f, g, h>>, PMICCMHTWMS where h : struct
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private static readonly byte[][] NVECHISXHAP;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static readonly TKCLJZAOTYZ CAYAUAREPAL;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x4F270A0", Offset = "0x4F25EA0", VA = "0x184F270A0", Slot = "4")]
		public void Serialize(JsonWriter writer, ValueTuple<a, b, c, d, e, f, g, h> value, HYIETNPQWTC formatterResolver)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x4F261B0", Offset = "0x4F24FB0", VA = "0x184F261B0", Slot = "5")]
		public ValueTuple<a, b, c, d, e, f, g, h> Deserialize(JsonReader reader, HYIETNPQWTC formatterResolver)
		{
			return default(ValueTuple<a, b, c, d, e, f, g, h>);
		}
	}
}
namespace Utf8Json.Formatters.Internal
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	internal static class NFHZLHKBGYX
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		internal static readonly byte[][] DGRZWVTINMF;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		internal static readonly TKCLJZAOTYZ MMGIPJMYJXK;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x8FFE320", Offset = "0x8FFD120", VA = "0x188FFE320")]
		static NFHZLHKBGYX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	internal static class BJZMRUZOGQR
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly byte[][] VEZJXOEMFXK;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly TKCLJZAOTYZ BRFJMWEOMIN;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8FF5C50", Offset = "0x8FF4A50", VA = "0x188FF5C50")]
		static BJZMRUZOGQR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	internal static class YLQHDBVKHPN
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly byte[][] LKLSWVHWMOZ;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly TKCLJZAOTYZ BUJEZASWWNY;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		internal static readonly byte[][] LJVYFBAEKGY;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		internal static readonly TKCLJZAOTYZ BUDYBTYZNCP;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		internal static readonly byte[][] LKBFCHUBTSH;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		internal static readonly TKCLJZAOTYZ BTYRENFCDRG;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly byte[][] LJLKKNMJRKG;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly TKCLJZAOTYZ BTTKHGLEUFX;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly byte[][] LJQRHUGHAVP;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		internal static readonly TKCLJZAOTYZ BTODJZRHKUO;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		internal static readonly byte[][] LJAWPZYOYNO;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		internal static readonly TKCLJZAOTYZ BTIWMSXKBJF;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static readonly byte[][] LJGDNGSMHYX;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly TKCLJZAOTYZ BTDPPMDMRXW;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly byte[][] LLWPDQREAQK;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly TKCLJZAOTYZ BWEPAJPZDMB;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x9009A70", Offset = "0x9008870", VA = "0x189009A70")]
		static YLQHDBVKHPN()
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
