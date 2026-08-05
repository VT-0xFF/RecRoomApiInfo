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
		[Cpp2IlInjected.Address(RVA = "0x970DBA0", Offset = "0x970C7A0", VA = "0x18970DBA0", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int PIFFXHJKFAN = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int GGJAUEEPBOP = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int HOGNJSBWCVY = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] YSYFNJJKCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string OQLKECEKFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream YRTONKBXERO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool HCNAKQAKXCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> XBUPHSRNKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int YEQEMZEHAIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int ZRBTQXHMCXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] VTTHANUICKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int EKDIALFNHXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int LMHLNHACIZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int GYSMTGVWYHW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool MFSIWUXQYPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x16677F0", Offset = "0x16663F0", VA = "0x1816677F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x970A060", Offset = "0x9708C60", VA = "0x18970A060")]
		public static int BBCHOPDJIHX(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x970B250", Offset = "0x9709E50", VA = "0x18970B250")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x970CBB0", Offset = "0x970B7B0", VA = "0x18970CBB0")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x970A880", Offset = "0x9709480", VA = "0x18970A880", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x970BCA0", Offset = "0x970A8A0", VA = "0x18970BCA0")]
		public void RETKZKQFHBO(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x970C520", Offset = "0x970B120", VA = "0x18970C520")]
		private void WJITLVNBQNL([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x970B590", Offset = "0x970A190", VA = "0x18970B590")]
		public int PHEDGQOREDI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x970B5B0", Offset = "0x970A1B0", VA = "0x18970B5B0")]
		public int PHEDGQOREDI([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x970A860", Offset = "0x9709460", VA = "0x18970A860")]
		public int DLIUVYKLXBV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x970ABB0", Offset = "0x97097B0", VA = "0x18970ABB0")]
		public int IWGKOYRBAJT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x970AEF0", Offset = "0x9709AF0", VA = "0x18970AEF0")]
		public void JXPUDMFUGGU(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x970AF40", Offset = "0x9709B40", VA = "0x18970AF40")]
		public void JXPUDMFUGGU(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x970AE10", Offset = "0x9709A10", VA = "0x18970AE10")]
		public void JXPUDMFUGGU(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x970A8F0", Offset = "0x97094F0", VA = "0x18970A8F0")]
		private void FQIOCXQYCWV(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x970B680", Offset = "0x970A280", VA = "0x18970B680")]
		public void PZDUOCFMEOR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x970B030", Offset = "0x9709C30", VA = "0x18970B030")]
		public void KKUMSYWAXYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x970A500", Offset = "0x9709100", VA = "0x18970A500")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x970C970", Offset = "0x970B570", VA = "0x18970C970")]
		public void ZUYMPMRDCWO(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x970C180", Offset = "0x970AD80", VA = "0x18970C180")]
		public Guid VKJFCINXKGN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x970A9C0", Offset = "0x97095C0", VA = "0x18970A9C0")]
		public void HKZVPVZAHTR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9709FA0", Offset = "0x9708BA0", VA = "0x189709FA0")]
		public bool ANJHCYYYMDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9709FC0", Offset = "0x9708BC0", VA = "0x189709FC0")]
		public void AQJRYHTKZNK(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x970AC40", Offset = "0x9709840", VA = "0x18970AC40")]
		public int IYAIHYLFMYV(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x970A4E0", Offset = "0x97090E0", VA = "0x18970A4E0")]
		public void CFHFTKPLEPP(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x970BD70", Offset = "0x970A970", VA = "0x18970BD70")]
		public void RKVOCMQAZHF(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x970BE90", Offset = "0x970AA90", VA = "0x18970BE90")]
		public byte TSTMKJJZOGS(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x970B120", Offset = "0x9709D20", VA = "0x18970B120")]
		public uint LNEVBRDLRIA(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x970B290", Offset = "0x9709E90", VA = "0x18970B290")]
		public void NTRHRNVJHMB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x970B0B0", Offset = "0x9709CB0", VA = "0x18970B0B0")]
		public void KKWIPDLDHGC(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x970BE30", Offset = "0x970AA30", VA = "0x18970BE30")]
		public int RRMMSEEBFVQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x970C270", Offset = "0x970AE70", VA = "0x18970C270")]
		public long VPQLUNDATWL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86B9C70", Offset = "0x86B8870", VA = "0x1886B9C70")]
		private static uint RZGDJDGKNPJ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8696D30", Offset = "0x8695930", VA = "0x188696D30")]
		private static int TYEOYNIJWVZ(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x970B270", Offset = "0x9709E70", VA = "0x18970B270")]
		private static ulong NAVEKSQXPVS(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x970B280", Offset = "0x9709E80", VA = "0x18970B280")]
		private static long NTJEWMHCXGY(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x970C820", Offset = "0x970B420", VA = "0x18970C820")]
		public void YNVTXPOZPPS(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x970ACC0", Offset = "0x97098C0", VA = "0x18970ACC0")]
		public void JLTOBFFIMVL(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x970B020", Offset = "0x9709C20", VA = "0x18970B020")]
		public uint KAHREDSGUMZ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x970B5D0", Offset = "0x970A1D0", VA = "0x18970B5D0")]
		public ulong PQPFPYNJYBM()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x970A120", Offset = "0x9708D20", VA = "0x18970A120")]
		public void BLIICAYKHMX(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x970A7B0", Offset = "0x97093B0", VA = "0x18970A7B0")]
		public float DBKRNTQYRIU(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x970B2F0", Offset = "0x9709EF0", VA = "0x18970B2F0")]
		private void OHHBDKFUMWF(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x970B880", Offset = "0x970A480", VA = "0x18970B880")]
		public void QGKFPACLEZR(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x970C830", Offset = "0x970B430", VA = "0x18970C830")]
		public float YZNBPZZDTQG(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x970C7C0", Offset = "0x970B3C0", VA = "0x18970C7C0")]
		private void WYUOBFYSQZT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x970BB00", Offset = "0x970A700", VA = "0x18970BB00")]
		public void QTXVSJKONEP(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x970B4B0", Offset = "0x970A0B0", VA = "0x18970B4B0")]
		public float PFPOEMNYFSO(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x970BA10", Offset = "0x970A610", VA = "0x18970BA10")]
		private void QGQRFNBWLPH(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x970BE10", Offset = "0x970AA10", VA = "0x18970BE10")]
		public void RPOZYZOLQKB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x970B490", Offset = "0x970A090", VA = "0x18970B490")]
		public float OZLOPPNANIM()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x970B3D0", Offset = "0x9709FD0", VA = "0x18970B3D0")]
		public void OYTEHOFQISW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x970B690", Offset = "0x970A290", VA = "0x18970B690")]
		public string QFVYWTTUAVD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37C7160", Offset = "0x37C5D60", VA = "0x1837C7160")]
		public void BKACKDXHLRJ<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x37C74F0", Offset = "0x37C60F0", VA = "0x1837C74F0")]
		public List<c> FLOXBPKQHYQ<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x970A9F0", Offset = "0x97095F0", VA = "0x18970A9F0")]
		public void HTLYLSNXCZB(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x970B1A0", Offset = "0x9709DA0", VA = "0x18970B1A0")]
		public Span<byte> MDODMPWHTNW()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x970A570", Offset = "0x9709170", VA = "0x18970A570")]
		public void DAAMFVWCIVF(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x970A3B0", Offset = "0x9708FB0", VA = "0x18970A3B0")]
		public void CCBUTKFHHQX(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x970C5F0", Offset = "0x970B1F0", VA = "0x18970C5F0")]
		public uint WSEIXPTTMVK(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x970C2D0", Offset = "0x970AED0", VA = "0x18970C2D0")]
		private void VWUJBGDQVDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x970BF10", Offset = "0x970AB10", VA = "0x18970BF10")]
		private void UGRQJIXJSXC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class DBHWWYZNKMP
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
		[Cpp2IlInjected.Address(RVA = "0x970D1B0", Offset = "0x970BDB0", VA = "0x18970D1B0")]
		public static void JQZRBMGKVAT(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x970D930", Offset = "0x970C530", VA = "0x18970D930")]
		public static void XSNYPSNKVFC(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x970D430", Offset = "0x970C030", VA = "0x18970D430")]
		public static ViewId QQWWMRSUQFW(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x970CDF0", Offset = "0x970B9F0", VA = "0x18970CDF0")]
		public static PartialViewId IBCLRNSLJMR(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x970D5E0", Offset = "0x970C1E0", VA = "0x18970D5E0")]
		private static bool WILBIPJCVRC(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x970D470", Offset = "0x970C070", VA = "0x18970D470")]
		private static PartialViewId SKUZTXOAIER(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x970CC10", Offset = "0x970B810", VA = "0x18970CC10")]
		private static bool CFQTAWIVYJH(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x970D740", Offset = "0x970C340", VA = "0x18970D740")]
		private static ViewId WVSGDFYSSKA(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x970D1C0", Offset = "0x970BDC0", VA = "0x18970D1C0")]
		private static bool LKDHWAJJAUA(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x970D010", Offset = "0x970BC10", VA = "0x18970D010")]
		private static ViewId INLGVZQAYFH(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class YSECAGUKWLE : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds WOBSKRNBOXO;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x970FB90", Offset = "0x970E790", VA = "0x18970FB90")]
		public YSECAGUKWLE(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class NRABATQSJVC
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float FEPKXTZJNKK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 WZPKNSWPFZU;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 UUJDGBVNTGC;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds WOBSKRNBOXO;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x970EC90", Offset = "0x970D890", VA = "0x18970EC90")]
		public static void TCARTGFVAVV(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x970F730", Offset = "0x970E330", VA = "0x18970F730")]
		public static Quaternion ZGLYJPWQZPS(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x970EEE0", Offset = "0x970DAE0", VA = "0x18970EEE0")]
		public static void TNIURHZLHMG(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x970EB90", Offset = "0x970D790", VA = "0x18970EB90")]
		public static Vector3 SNYYGVEBSHN(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x970E430", Offset = "0x970D030", VA = "0x18970E430")]
		public static void MQFLXVHMXSM(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x970F3C0", Offset = "0x970DFC0", VA = "0x18970F3C0")]
		public static Vector3 YQPWIFYQUCD(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x970E310", Offset = "0x970CF10", VA = "0x18970E310")]
		public static void MQFLXVHMXSM(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x970F290", Offset = "0x970DE90", VA = "0x18970F290")]
		public static Vector3 YQPWIFYQUCD(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x970E250", Offset = "0x970CE50", VA = "0x18970E250")]
		private static void KZMYETUDOYV(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x970E140", Offset = "0x970CD40", VA = "0x18970E140")]
		private static Vector3 HVFFFWVNUHA(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x970E5D0", Offset = "0x970D1D0", VA = "0x18970E5D0")]
		public static void NURDAVBRUHT(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x970F100", Offset = "0x970DD00", VA = "0x18970F100")]
		public static Quaternion VJLQMFCUJQO(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x970DC20", Offset = "0x970C820", VA = "0x18970DC20")]
		public static void CWDPGDUZXFJ(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x970E220", Offset = "0x970CE20", VA = "0x18970E220")]
		public static float JCBSBPWACTY(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x970DE90", Offset = "0x970CA90", VA = "0x18970DE90")]
		public static void FWRTSHFSXAM(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x970E740", Offset = "0x970D340", VA = "0x18970E740")]
		public static Vector3 QPECXCRWDFB(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x970DC50", Offset = "0x970C850", VA = "0x18970DC50")]
		public static void DDZUKSGFSBO(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x970EFF0", Offset = "0x970DBF0", VA = "0x18970EFF0")]
		public static Vector3 VGBBRWVHXVR(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x970F230", Offset = "0x970DE30", VA = "0x18970F230")]
		public static void YFORZVGBBXJ(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x970DE10", Offset = "0x970CA10", VA = "0x18970DE10")]
		public static Vector3 EFHZZWRIVKG(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x970E090", Offset = "0x970CC90", VA = "0x18970E090")]
		public static void HQHCHSWEAUF(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x970EAB0", Offset = "0x970D6B0", VA = "0x18970EAB0")]
		public static Vector3 QWVRGUJOABG(this BitPacker a, float b, float c, int d = 8)
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
