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
		[Cpp2IlInjected.Address(RVA = "0x970C2E0", Offset = "0x970ACE0", VA = "0x18970C2E0", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
			[Cpp2IlInjected.Address(RVA = "0x1665F50", Offset = "0x1664950", VA = "0x181665F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x97087A0", Offset = "0x97071A0", VA = "0x1897087A0")]
		public static int BBCHOPDJIHX(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9709990", Offset = "0x9708390", VA = "0x189709990")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x970B2F0", Offset = "0x9709CF0", VA = "0x18970B2F0")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9708FC0", Offset = "0x97079C0", VA = "0x189708FC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x970A3E0", Offset = "0x9708DE0", VA = "0x18970A3E0")]
		public void RETKZKQFHBO(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x970AC60", Offset = "0x9709660", VA = "0x18970AC60")]
		private void WJITLVNBQNL([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9709CD0", Offset = "0x97086D0", VA = "0x189709CD0")]
		public int PHEDGQOREDI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9709CF0", Offset = "0x97086F0", VA = "0x189709CF0")]
		public int PHEDGQOREDI([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9708FA0", Offset = "0x97079A0", VA = "0x189708FA0")]
		public int DLIUVYKLXBV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x97092F0", Offset = "0x9707CF0", VA = "0x1897092F0")]
		public int IWGKOYRBAJT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9709630", Offset = "0x9708030", VA = "0x189709630")]
		public void JXPUDMFUGGU(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9709680", Offset = "0x9708080", VA = "0x189709680")]
		public void JXPUDMFUGGU(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9709550", Offset = "0x9707F50", VA = "0x189709550")]
		public void JXPUDMFUGGU(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9709030", Offset = "0x9707A30", VA = "0x189709030")]
		private void FQIOCXQYCWV(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9709DC0", Offset = "0x97087C0", VA = "0x189709DC0")]
		public void PZDUOCFMEOR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9709770", Offset = "0x9708170", VA = "0x189709770")]
		public void KKUMSYWAXYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9708C40", Offset = "0x9707640", VA = "0x189708C40")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x970B0B0", Offset = "0x9709AB0", VA = "0x18970B0B0")]
		public void ZUYMPMRDCWO(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x970A8C0", Offset = "0x97092C0", VA = "0x18970A8C0")]
		public Guid VKJFCINXKGN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9709100", Offset = "0x9707B00", VA = "0x189709100")]
		public void HKZVPVZAHTR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x97086E0", Offset = "0x97070E0", VA = "0x1897086E0")]
		public bool ANJHCYYYMDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9708700", Offset = "0x9707100", VA = "0x189708700")]
		public void AQJRYHTKZNK(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9709380", Offset = "0x9707D80", VA = "0x189709380")]
		public int IYAIHYLFMYV(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9708C20", Offset = "0x9707620", VA = "0x189708C20")]
		public void CFHFTKPLEPP(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x970A4B0", Offset = "0x9708EB0", VA = "0x18970A4B0")]
		public void RKVOCMQAZHF(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x970A5D0", Offset = "0x9708FD0", VA = "0x18970A5D0")]
		public byte TSTMKJJZOGS(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9709860", Offset = "0x9708260", VA = "0x189709860")]
		public uint LNEVBRDLRIA(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x97099D0", Offset = "0x97083D0", VA = "0x1897099D0")]
		public void NTRHRNVJHMB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x97097F0", Offset = "0x97081F0", VA = "0x1897097F0")]
		public void KKWIPDLDHGC(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x970A570", Offset = "0x9708F70", VA = "0x18970A570")]
		public int RRMMSEEBFVQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x970A9B0", Offset = "0x97093B0", VA = "0x18970A9B0")]
		public long VPQLUNDATWL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86B84F0", Offset = "0x86B6EF0", VA = "0x1886B84F0")]
		private static uint RZGDJDGKNPJ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86955B0", Offset = "0x8693FB0", VA = "0x1886955B0")]
		private static int TYEOYNIJWVZ(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x97099B0", Offset = "0x97083B0", VA = "0x1897099B0")]
		private static ulong NAVEKSQXPVS(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x97099C0", Offset = "0x97083C0", VA = "0x1897099C0")]
		private static long NTJEWMHCXGY(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x970AF60", Offset = "0x9709960", VA = "0x18970AF60")]
		public void YNVTXPOZPPS(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9709400", Offset = "0x9707E00", VA = "0x189709400")]
		public void JLTOBFFIMVL(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9709760", Offset = "0x9708160", VA = "0x189709760")]
		public uint KAHREDSGUMZ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9709D10", Offset = "0x9708710", VA = "0x189709D10")]
		public ulong PQPFPYNJYBM()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9708860", Offset = "0x9707260", VA = "0x189708860")]
		public void BLIICAYKHMX(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9708EF0", Offset = "0x97078F0", VA = "0x189708EF0")]
		public float DBKRNTQYRIU(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9709A30", Offset = "0x9708430", VA = "0x189709A30")]
		private void OHHBDKFUMWF(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9709FC0", Offset = "0x97089C0", VA = "0x189709FC0")]
		public void QGKFPACLEZR(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x970AF70", Offset = "0x9709970", VA = "0x18970AF70")]
		public float YZNBPZZDTQG(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x970AF00", Offset = "0x9709900", VA = "0x18970AF00")]
		private void WYUOBFYSQZT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x970A240", Offset = "0x9708C40", VA = "0x18970A240")]
		public void QTXVSJKONEP(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9709BF0", Offset = "0x97085F0", VA = "0x189709BF0")]
		public float PFPOEMNYFSO(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x970A150", Offset = "0x9708B50", VA = "0x18970A150")]
		private void QGQRFNBWLPH(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x970A550", Offset = "0x9708F50", VA = "0x18970A550")]
		public void RPOZYZOLQKB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9709BD0", Offset = "0x97085D0", VA = "0x189709BD0")]
		public float OZLOPPNANIM()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9709B10", Offset = "0x9708510", VA = "0x189709B10")]
		public void OYTEHOFQISW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9709DD0", Offset = "0x97087D0", VA = "0x189709DD0")]
		public string QFVYWTTUAVD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37C5A70", Offset = "0x37C4470", VA = "0x1837C5A70")]
		public void BKACKDXHLRJ<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x37C5E00", Offset = "0x37C4800", VA = "0x1837C5E00")]
		public List<c> FLOXBPKQHYQ<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9709130", Offset = "0x9707B30", VA = "0x189709130")]
		public void HTLYLSNXCZB(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x97098E0", Offset = "0x97082E0", VA = "0x1897098E0")]
		public Span<byte> MDODMPWHTNW()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9708CB0", Offset = "0x97076B0", VA = "0x189708CB0")]
		public void DAAMFVWCIVF(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9708AF0", Offset = "0x97074F0", VA = "0x189708AF0")]
		public void CCBUTKFHHQX(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x970AD30", Offset = "0x9709730", VA = "0x18970AD30")]
		public uint WSEIXPTTMVK(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x970AA10", Offset = "0x9709410", VA = "0x18970AA10")]
		private void VWUJBGDQVDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x970A650", Offset = "0x9709050", VA = "0x18970A650")]
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
		[Cpp2IlInjected.Address(RVA = "0x970B8F0", Offset = "0x970A2F0", VA = "0x18970B8F0")]
		public static void JQZRBMGKVAT(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x970C070", Offset = "0x970AA70", VA = "0x18970C070")]
		public static void XSNYPSNKVFC(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x970BB70", Offset = "0x970A570", VA = "0x18970BB70")]
		public static ViewId QQWWMRSUQFW(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x970B530", Offset = "0x9709F30", VA = "0x18970B530")]
		public static PartialViewId IBCLRNSLJMR(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x970BD20", Offset = "0x970A720", VA = "0x18970BD20")]
		private static bool WILBIPJCVRC(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x970BBB0", Offset = "0x970A5B0", VA = "0x18970BBB0")]
		private static PartialViewId SKUZTXOAIER(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x970B350", Offset = "0x9709D50", VA = "0x18970B350")]
		private static bool CFQTAWIVYJH(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x970BE80", Offset = "0x970A880", VA = "0x18970BE80")]
		private static ViewId WVSGDFYSSKA(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x970B900", Offset = "0x970A300", VA = "0x18970B900")]
		private static bool LKDHWAJJAUA(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x970B750", Offset = "0x970A150", VA = "0x18970B750")]
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
		[Cpp2IlInjected.Address(RVA = "0x970E2D0", Offset = "0x970CCD0", VA = "0x18970E2D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x970D3D0", Offset = "0x970BDD0", VA = "0x18970D3D0")]
		public static void TCARTGFVAVV(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x970DE70", Offset = "0x970C870", VA = "0x18970DE70")]
		public static Quaternion ZGLYJPWQZPS(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x970D620", Offset = "0x970C020", VA = "0x18970D620")]
		public static void TNIURHZLHMG(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x970D2D0", Offset = "0x970BCD0", VA = "0x18970D2D0")]
		public static Vector3 SNYYGVEBSHN(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x970CB70", Offset = "0x970B570", VA = "0x18970CB70")]
		public static void MQFLXVHMXSM(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x970DB00", Offset = "0x970C500", VA = "0x18970DB00")]
		public static Vector3 YQPWIFYQUCD(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x970CA50", Offset = "0x970B450", VA = "0x18970CA50")]
		public static void MQFLXVHMXSM(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x970D9D0", Offset = "0x970C3D0", VA = "0x18970D9D0")]
		public static Vector3 YQPWIFYQUCD(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x970C990", Offset = "0x970B390", VA = "0x18970C990")]
		private static void KZMYETUDOYV(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x970C880", Offset = "0x970B280", VA = "0x18970C880")]
		private static Vector3 HVFFFWVNUHA(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x970CD10", Offset = "0x970B710", VA = "0x18970CD10")]
		public static void NURDAVBRUHT(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x970D840", Offset = "0x970C240", VA = "0x18970D840")]
		public static Quaternion VJLQMFCUJQO(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x970C360", Offset = "0x970AD60", VA = "0x18970C360")]
		public static void CWDPGDUZXFJ(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x970C960", Offset = "0x970B360", VA = "0x18970C960")]
		public static float JCBSBPWACTY(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x970C5D0", Offset = "0x970AFD0", VA = "0x18970C5D0")]
		public static void FWRTSHFSXAM(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x970CE80", Offset = "0x970B880", VA = "0x18970CE80")]
		public static Vector3 QPECXCRWDFB(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x970C390", Offset = "0x970AD90", VA = "0x18970C390")]
		public static void DDZUKSGFSBO(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x970D730", Offset = "0x970C130", VA = "0x18970D730")]
		public static Vector3 VGBBRWVHXVR(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x970D970", Offset = "0x970C370", VA = "0x18970D970")]
		public static void YFORZVGBBXJ(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x970C550", Offset = "0x970AF50", VA = "0x18970C550")]
		public static Vector3 EFHZZWRIVKG(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x970C7D0", Offset = "0x970B1D0", VA = "0x18970C7D0")]
		public static void HQHCHSWEAUF(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x970D1F0", Offset = "0x970BBF0", VA = "0x18970D1F0")]
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
