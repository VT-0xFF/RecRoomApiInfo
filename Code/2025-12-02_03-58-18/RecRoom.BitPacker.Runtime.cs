using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_BitPacker_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x808DE20", Offset = "0x808CA20", VA = "0x18808DE20", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class BitPacker : IDisposable
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct IntFloatType
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public uint AsUInt;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public float AsFloat;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int LRWSXXZLXNO = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int GTVGKCFTJIS = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int KDMONPMUKYT = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] GNLWJXGTACO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string MAAYLYKJZAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream XBMVMWBCCQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool OHJRRKVAXEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> FKXOIJLYYFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int EPBIDAUIELB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int TEKTSVPICVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] ULIFWINNTXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int ZKKVNAZXXZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int MGDRXIFXGSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int GHCXHEPYGGF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool ZBNAQJJVFAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x131CEF0", Offset = "0x131BAF0", VA = "0x18131CEF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x808C080", Offset = "0x808AC80", VA = "0x18808C080")]
		public static int SPKBFBMDZMG(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x808A890", Offset = "0x8089490", VA = "0x18808A890")]
		public static uint CZGKVHAZGSQ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x808CE30", Offset = "0x808BA30", VA = "0x18808CE30")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x808AA00", Offset = "0x8089600", VA = "0x18808AA00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x808B2B0", Offset = "0x8089EB0", VA = "0x18808B2B0")]
		public void HPJYZKCRQBV(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x808AA70", Offset = "0x8089670", VA = "0x18808AA70")]
		private void FGJHQFVYYDQ([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x808B650", Offset = "0x808A250", VA = "0x18808B650")]
		public int KGYBOAUWPFR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x808B630", Offset = "0x808A230", VA = "0x18808B630")]
		public int KGYBOAUWPFR([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x808C9B0", Offset = "0x808B5B0", VA = "0x18808C9B0")]
		public int YSINSSIKDSK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x808BBA0", Offset = "0x808A7A0", VA = "0x18808BBA0")]
		public int QMNKBLFLKIY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x808B990", Offset = "0x808A590", VA = "0x18808B990")]
		public void QLSKKWFCXFV(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x808BAC0", Offset = "0x808A6C0", VA = "0x18808BAC0")]
		public void QLSKKWFCXFV(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x808B9E0", Offset = "0x808A5E0", VA = "0x18808B9E0")]
		public void QLSKKWFCXFV(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x808B1C0", Offset = "0x8089DC0", VA = "0x18808B1C0")]
		private void HIXEOSOSMZY(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x808C9D0", Offset = "0x808B5D0", VA = "0x18808C9D0")]
		public void YXRYRKUFLPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x808BFA0", Offset = "0x808ABA0", VA = "0x18808BFA0")]
		public void RQKANQGXNKU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x808A8B0", Offset = "0x80894B0", VA = "0x18808A8B0")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x808BE50", Offset = "0x808AA50", VA = "0x18808BE50")]
		public void ROMASJOVCCX(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x808A250", Offset = "0x8088E50", VA = "0x18808A250")]
		public Guid BUAQKXUKJUS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x808A220", Offset = "0x8088E20", VA = "0x18808A220")]
		public void AJJHAVIJFSW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x808B7C0", Offset = "0x808A3C0", VA = "0x18808B7C0")]
		public bool LKQGYRWFVLV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x808C890", Offset = "0x808B490", VA = "0x18808C890")]
		public void WZRCABQEJBV(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x808C440", Offset = "0x808B040", VA = "0x18808C440")]
		public int TGYSKHKXILO(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x808B380", Offset = "0x8089F80", VA = "0x18808B380")]
		public void HQVYMTEHLXG(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x808B670", Offset = "0x808A270", VA = "0x18808B670")]
		public void KWVLCGFZCFU(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x808A640", Offset = "0x8089240", VA = "0x18808A640")]
		public byte CKSOHTVNDFT(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x808C800", Offset = "0x808B400", VA = "0x18808C800")]
		public uint UYKJGSQMDQX(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x808BC30", Offset = "0x808A830", VA = "0x18808BC30")]
		public void QXVBQFVSBKA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x808C940", Offset = "0x808B540", VA = "0x18808C940")]
		public void YPISGODZEZP(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x808B7F0", Offset = "0x808A3F0", VA = "0x18808B7F0")]
		public int NYDGMSLLJSR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x808CB70", Offset = "0x808B770", VA = "0x18808CB70")]
		public long ZRCRBEUZFZY()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x70BCE30", Offset = "0x70BBA30", VA = "0x1870BCE30")]
		private static uint WKLKRDKIFIE(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x709A250", Offset = "0x7098E50", VA = "0x18709A250")]
		private static int FTRHQRWVNIA(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x808A630", Offset = "0x8089230", VA = "0x18808A630")]
		private static ulong CJPJRXALARN(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x808B7E0", Offset = "0x808A3E0", VA = "0x18808B7E0")]
		private static long NQEHMBLTTDR(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x808C930", Offset = "0x808B530", VA = "0x18808C930")]
		public void YKGIKKVJICL(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x808A340", Offset = "0x8088F40", VA = "0x18808A340")]
		public void BWRJDHKQJCI(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x808C880", Offset = "0x808B480", VA = "0x18808C880")]
		public uint VWZTXPMKTBK()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x808C390", Offset = "0x808AF90", VA = "0x18808C390")]
		public ulong TCKNYWUREXL()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x808B3A0", Offset = "0x8089FA0", VA = "0x18808B3A0")]
		public void JVBYWYLZFVU(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x808B710", Offset = "0x808A310", VA = "0x18808B710")]
		public float KZHBDWBCMST(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x808A920", Offset = "0x8089520", VA = "0x18808A920")]
		private void DYLPGTWZAWW(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x808C9E0", Offset = "0x808B5E0", VA = "0x18808C9E0")]
		public void ZPCSVIBCEIQ(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x808B850", Offset = "0x808A450", VA = "0x18808B850")]
		public float PANMZHUWYLR(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x808C020", Offset = "0x808AC20", VA = "0x18808C020")]
		private void SHIUSMWNCRK(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x808A490", Offset = "0x8089090", VA = "0x18808A490")]
		public void CITXDWMBRRS(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x808C720", Offset = "0x808B320", VA = "0x18808C720")]
		public float TUBKUQVJFGX(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x808AE60", Offset = "0x8089A60", VA = "0x18808AE60")]
		private void GKSCAANWCXG(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x808C700", Offset = "0x808B300", VA = "0x18808C700")]
		public void TRMABZYHEGW(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x808B290", Offset = "0x8089E90", VA = "0x18808B290")]
		public float HMPTSIPDVGR()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x808CC80", Offset = "0x808B880", VA = "0x18808CC80")]
		public void ZVELYGGVFBN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x808AB40", Offset = "0x8089740", VA = "0x18808AB40")]
		public string FSLWBXVESQW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3451320", Offset = "0x344FF20", VA = "0x183451320")]
		public void GGGDOIPELEC<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x34516C0", Offset = "0x34502C0", VA = "0x1834516C0")]
		public List<c> QRALLFAVBST<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x808BC90", Offset = "0x808A890", VA = "0x18808BC90")]
		public void RNMXBNAQNTY(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x808CBD0", Offset = "0x808B7D0", VA = "0x18808CBD0")]
		public Span<byte> ZUKTAXKXKOT()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x808C4C0", Offset = "0x808B0C0", VA = "0x18808C4C0")]
		public void TOGCCMOHKPY(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x808AD30", Offset = "0x8089930", VA = "0x18808AD30")]
		public void FWSHVONQQLE(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x808A6C0", Offset = "0x80892C0", VA = "0x18808A6C0")]
		public uint CNCXSTEBOLB(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x808C140", Offset = "0x808AD40", VA = "0x18808C140")]
		private void SSWZIBPTDXT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x808AF50", Offset = "0x8089B50", VA = "0x18808AF50")]
		private void GKWQQSSEDHD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class EINAVRRQYRI
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private enum CompressionType : uint
		{
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			Reference,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			Basic,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			Range,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			Full
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x808D210", Offset = "0x808BE10", VA = "0x18808D210")]
		public static void PRRHFXFEHRI(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x808D630", Offset = "0x808C230", VA = "0x18808D630")]
		public static void USSPSJXTSEL(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x808CE90", Offset = "0x808BA90", VA = "0x18808CE90")]
		public static ViewId CQNFJFHDUQL(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x808D410", Offset = "0x808C010", VA = "0x18808D410")]
		public static PartialViewId TVVYGSMHWZS(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x808CED0", Offset = "0x808BAD0", VA = "0x18808CED0")]
		private static bool LGXIUDJPAQN(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x808DA40", Offset = "0x808C640", VA = "0x18808DA40")]
		private static PartialViewId XCPQSWPVHDY(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x808D030", Offset = "0x808BC30", VA = "0x18808D030")]
		private static bool MQTQVUAFYXK(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x808D220", Offset = "0x808BE20", VA = "0x18808D220")]
		private static ViewId SRCZEQKLQCP(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x808DBB0", Offset = "0x808C7B0", VA = "0x18808DBB0")]
		private static bool XRLARQCGXBH(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x808D8A0", Offset = "0x808C4A0", VA = "0x18808D8A0")]
		private static ViewId WOIIRANDNLQ(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ZLILNTAWGFD : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds RBHCKIXAESV;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x808FE10", Offset = "0x808EA10", VA = "0x18808FE10")]
		public ZLILNTAWGFD(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ONSTVJELUHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float DFATKPTANRV;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 EBEDOUUXMJR;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 QTLJHRFMYBX;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds RBHCKIXAESV;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x808F750", Offset = "0x808E350", VA = "0x18808F750")]
		public static void YJUPQRZPMES(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x808ECC0", Offset = "0x808D8C0", VA = "0x18808ECC0")]
		public static Quaternion OPEYEZHIOEL(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x808F480", Offset = "0x808E080", VA = "0x18808F480")]
		public static void RZVURWHLLGR(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x808EF50", Offset = "0x808DB50", VA = "0x18808EF50")]
		public static Vector3 ORRIEBQBMUG(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x808F170", Offset = "0x808DD70", VA = "0x18808F170")]
		public static void OZMDYTPJHSN(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x808E820", Offset = "0x808D420", VA = "0x18808E820")]
		public static Vector3 MVKWWQNXJZS(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x808F050", Offset = "0x808DC50", VA = "0x18808F050")]
		public static void OZMDYTPJHSN(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x808EB90", Offset = "0x808D790", VA = "0x18808EB90")]
		public static Vector3 MVKWWQNXJZS(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x808F310", Offset = "0x808DF10", VA = "0x18808F310")]
		private static void PXAHZVTBWMI(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x808DF00", Offset = "0x808CB00", VA = "0x18808DF00")]
		private static Vector3 CRKXBUKINSB(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x808F9A0", Offset = "0x808E5A0", VA = "0x18808F9A0")]
		public static void YTQZHPKONDG(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x808FB10", Offset = "0x808E710", VA = "0x18808FB10")]
		public static Quaternion YVXYIUEDMIN(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x808E550", Offset = "0x808D150", VA = "0x18808E550")]
		public static void GDHGOTJRMCE(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x808E6E0", Offset = "0x808D2E0", VA = "0x18808E6E0")]
		public static float KVABPBZSTDJ(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x808E350", Offset = "0x808CF50", VA = "0x18808E350")]
		public static void EXQMWZFIVMV(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x808DFE0", Offset = "0x808CBE0", VA = "0x18808DFE0")]
		public static Vector3 CTZJGZHDOTO(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x808F590", Offset = "0x808E190", VA = "0x18808F590")]
		public static void SEDDFOAQOJX(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x808E710", Offset = "0x808D310", VA = "0x18808E710")]
		public static Vector3 MAFOAFVGTBO(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x808DEA0", Offset = "0x808CAA0", VA = "0x18808DEA0")]
		public static void AWRAPDRKTSU(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x808E580", Offset = "0x808D180", VA = "0x18808E580")]
		public static Vector3 JAKLYAVSYCT(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x808F3D0", Offset = "0x808DFD0", VA = "0x18808F3D0")]
		public static void QCFYBYQACQO(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x808E600", Offset = "0x808D200", VA = "0x18808E600")]
		public static Vector3 JNUFDTFYIRH(this BitPacker a, float b, float c, int d = 8)
		{
			return default(Vector3);
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
