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
		[Cpp2IlInjected.Address(RVA = "0x98AF210", Offset = "0x98AE210", VA = "0x1898AF210", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
			[Cpp2IlInjected.Address(RVA = "0x1681AA0", Offset = "0x1680AA0", VA = "0x181681AA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98AB6D0", Offset = "0x98AA6D0", VA = "0x1898AB6D0")]
		public static int BBCHOPDJIHX(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98AC8C0", Offset = "0x98AB8C0", VA = "0x1898AC8C0")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98AE220", Offset = "0x98AD220", VA = "0x1898AE220")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98ABEF0", Offset = "0x98AAEF0", VA = "0x1898ABEF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x98AD310", Offset = "0x98AC310", VA = "0x1898AD310")]
		public void RETKZKQFHBO(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x98ADB90", Offset = "0x98ACB90", VA = "0x1898ADB90")]
		private void WJITLVNBQNL([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x98ACC00", Offset = "0x98ABC00", VA = "0x1898ACC00")]
		public int PHEDGQOREDI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x98ACC20", Offset = "0x98ABC20", VA = "0x1898ACC20")]
		public int PHEDGQOREDI([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x98ABED0", Offset = "0x98AAED0", VA = "0x1898ABED0")]
		public int DLIUVYKLXBV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x98AC220", Offset = "0x98AB220", VA = "0x1898AC220")]
		public int IWGKOYRBAJT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x98AC560", Offset = "0x98AB560", VA = "0x1898AC560")]
		public void JXPUDMFUGGU(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x98AC5B0", Offset = "0x98AB5B0", VA = "0x1898AC5B0")]
		public void JXPUDMFUGGU(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x98AC480", Offset = "0x98AB480", VA = "0x1898AC480")]
		public void JXPUDMFUGGU(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x98ABF60", Offset = "0x98AAF60", VA = "0x1898ABF60")]
		private void FQIOCXQYCWV(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x98ACCF0", Offset = "0x98ABCF0", VA = "0x1898ACCF0")]
		public void PZDUOCFMEOR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x98AC6A0", Offset = "0x98AB6A0", VA = "0x1898AC6A0")]
		public void KKUMSYWAXYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x98ABB70", Offset = "0x98AAB70", VA = "0x1898ABB70")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x98ADFE0", Offset = "0x98ACFE0", VA = "0x1898ADFE0")]
		public void ZUYMPMRDCWO(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x98AD7F0", Offset = "0x98AC7F0", VA = "0x1898AD7F0")]
		public Guid VKJFCINXKGN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x98AC030", Offset = "0x98AB030", VA = "0x1898AC030")]
		public void HKZVPVZAHTR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x98AB610", Offset = "0x98AA610", VA = "0x1898AB610")]
		public bool ANJHCYYYMDO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x98AB630", Offset = "0x98AA630", VA = "0x1898AB630")]
		public void AQJRYHTKZNK(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x98AC2B0", Offset = "0x98AB2B0", VA = "0x1898AC2B0")]
		public int IYAIHYLFMYV(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x98ABB50", Offset = "0x98AAB50", VA = "0x1898ABB50")]
		public void CFHFTKPLEPP(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x98AD3E0", Offset = "0x98AC3E0", VA = "0x1898AD3E0")]
		public void RKVOCMQAZHF(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x98AD500", Offset = "0x98AC500", VA = "0x1898AD500")]
		public byte TSTMKJJZOGS(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x98AC790", Offset = "0x98AB790", VA = "0x1898AC790")]
		public uint LNEVBRDLRIA(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x98AC900", Offset = "0x98AB900", VA = "0x1898AC900")]
		public void NTRHRNVJHMB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x98AC720", Offset = "0x98AB720", VA = "0x1898AC720")]
		public void KKWIPDLDHGC(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98AD4A0", Offset = "0x98AC4A0", VA = "0x1898AD4A0")]
		public int RRMMSEEBFVQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98AD8E0", Offset = "0x98AC8E0", VA = "0x1898AD8E0")]
		public long VPQLUNDATWL()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8857F70", Offset = "0x8856F70", VA = "0x188857F70")]
		private static uint RZGDJDGKNPJ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8835030", Offset = "0x8834030", VA = "0x188835030")]
		private static int TYEOYNIJWVZ(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x98AC8E0", Offset = "0x98AB8E0", VA = "0x1898AC8E0")]
		private static ulong NAVEKSQXPVS(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x98AC8F0", Offset = "0x98AB8F0", VA = "0x1898AC8F0")]
		private static long NTJEWMHCXGY(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x98ADE90", Offset = "0x98ACE90", VA = "0x1898ADE90")]
		public void YNVTXPOZPPS(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x98AC330", Offset = "0x98AB330", VA = "0x1898AC330")]
		public void JLTOBFFIMVL(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x98AC690", Offset = "0x98AB690", VA = "0x1898AC690")]
		public uint KAHREDSGUMZ()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x98ACC40", Offset = "0x98ABC40", VA = "0x1898ACC40")]
		public ulong PQPFPYNJYBM()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x98AB790", Offset = "0x98AA790", VA = "0x1898AB790")]
		public void BLIICAYKHMX(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x98ABE20", Offset = "0x98AAE20", VA = "0x1898ABE20")]
		public float DBKRNTQYRIU(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x98AC960", Offset = "0x98AB960", VA = "0x1898AC960")]
		private void OHHBDKFUMWF(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x98ACEF0", Offset = "0x98ABEF0", VA = "0x1898ACEF0")]
		public void QGKFPACLEZR(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x98ADEA0", Offset = "0x98ACEA0", VA = "0x1898ADEA0")]
		public float YZNBPZZDTQG(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x98ADE30", Offset = "0x98ACE30", VA = "0x1898ADE30")]
		private void WYUOBFYSQZT(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x98AD170", Offset = "0x98AC170", VA = "0x1898AD170")]
		public void QTXVSJKONEP(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x98ACB20", Offset = "0x98ABB20", VA = "0x1898ACB20")]
		public float PFPOEMNYFSO(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x98AD080", Offset = "0x98AC080", VA = "0x1898AD080")]
		private void QGQRFNBWLPH(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x98AD480", Offset = "0x98AC480", VA = "0x1898AD480")]
		public void RPOZYZOLQKB(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98ACB00", Offset = "0x98ABB00", VA = "0x1898ACB00")]
		public float OZLOPPNANIM()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x98ACA40", Offset = "0x98ABA40", VA = "0x1898ACA40")]
		public void OYTEHOFQISW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x98ACD00", Offset = "0x98ABD00", VA = "0x1898ACD00")]
		public string QFVYWTTUAVD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37E3D50", Offset = "0x37E2D50", VA = "0x1837E3D50")]
		public void BKACKDXHLRJ<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x37E40E0", Offset = "0x37E30E0", VA = "0x1837E40E0")]
		public List<c> FLOXBPKQHYQ<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x98AC060", Offset = "0x98AB060", VA = "0x1898AC060")]
		public void HTLYLSNXCZB(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x98AC810", Offset = "0x98AB810", VA = "0x1898AC810")]
		public Span<byte> MDODMPWHTNW()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x98ABBE0", Offset = "0x98AABE0", VA = "0x1898ABBE0")]
		public void DAAMFVWCIVF(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x98ABA20", Offset = "0x98AAA20", VA = "0x1898ABA20")]
		public void CCBUTKFHHQX(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x98ADC60", Offset = "0x98ACC60", VA = "0x1898ADC60")]
		public uint WSEIXPTTMVK(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x98AD940", Offset = "0x98AC940", VA = "0x1898AD940")]
		private void VWUJBGDQVDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x98AD580", Offset = "0x98AC580", VA = "0x1898AD580")]
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
		[Cpp2IlInjected.Address(RVA = "0x98AE820", Offset = "0x98AD820", VA = "0x1898AE820")]
		public static void JQZRBMGKVAT(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x98AEFA0", Offset = "0x98ADFA0", VA = "0x1898AEFA0")]
		public static void XSNYPSNKVFC(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x98AEAA0", Offset = "0x98ADAA0", VA = "0x1898AEAA0")]
		public static ViewId QQWWMRSUQFW(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x98AE460", Offset = "0x98AD460", VA = "0x1898AE460")]
		public static PartialViewId IBCLRNSLJMR(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x98AEC50", Offset = "0x98ADC50", VA = "0x1898AEC50")]
		private static bool WILBIPJCVRC(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x98AEAE0", Offset = "0x98ADAE0", VA = "0x1898AEAE0")]
		private static PartialViewId SKUZTXOAIER(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x98AE280", Offset = "0x98AD280", VA = "0x1898AE280")]
		private static bool CFQTAWIVYJH(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x98AEDB0", Offset = "0x98ADDB0", VA = "0x1898AEDB0")]
		private static ViewId WVSGDFYSSKA(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x98AE830", Offset = "0x98AD830", VA = "0x1898AE830")]
		private static bool LKDHWAJJAUA(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x98AE680", Offset = "0x98AD680", VA = "0x1898AE680")]
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
		[Cpp2IlInjected.Address(RVA = "0x98B1200", Offset = "0x98B0200", VA = "0x1898B1200")]
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
		[Cpp2IlInjected.Address(RVA = "0x98B0300", Offset = "0x98AF300", VA = "0x1898B0300")]
		public static void TCARTGFVAVV(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x98B0DA0", Offset = "0x98AFDA0", VA = "0x1898B0DA0")]
		public static Quaternion ZGLYJPWQZPS(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x98B0550", Offset = "0x98AF550", VA = "0x1898B0550")]
		public static void TNIURHZLHMG(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x98B0200", Offset = "0x98AF200", VA = "0x1898B0200")]
		public static Vector3 SNYYGVEBSHN(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x98AFAA0", Offset = "0x98AEAA0", VA = "0x1898AFAA0")]
		public static void MQFLXVHMXSM(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x98B0A30", Offset = "0x98AFA30", VA = "0x1898B0A30")]
		public static Vector3 YQPWIFYQUCD(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x98AF980", Offset = "0x98AE980", VA = "0x1898AF980")]
		public static void MQFLXVHMXSM(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x98B0900", Offset = "0x98AF900", VA = "0x1898B0900")]
		public static Vector3 YQPWIFYQUCD(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x98AF8C0", Offset = "0x98AE8C0", VA = "0x1898AF8C0")]
		private static void KZMYETUDOYV(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x98AF7B0", Offset = "0x98AE7B0", VA = "0x1898AF7B0")]
		private static Vector3 HVFFFWVNUHA(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x98AFC40", Offset = "0x98AEC40", VA = "0x1898AFC40")]
		public static void NURDAVBRUHT(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x98B0770", Offset = "0x98AF770", VA = "0x1898B0770")]
		public static Quaternion VJLQMFCUJQO(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x98AF290", Offset = "0x98AE290", VA = "0x1898AF290")]
		public static void CWDPGDUZXFJ(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x98AF890", Offset = "0x98AE890", VA = "0x1898AF890")]
		public static float JCBSBPWACTY(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x98AF500", Offset = "0x98AE500", VA = "0x1898AF500")]
		public static void FWRTSHFSXAM(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x98AFDB0", Offset = "0x98AEDB0", VA = "0x1898AFDB0")]
		public static Vector3 QPECXCRWDFB(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x98AF2C0", Offset = "0x98AE2C0", VA = "0x1898AF2C0")]
		public static void DDZUKSGFSBO(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x98B0660", Offset = "0x98AF660", VA = "0x1898B0660")]
		public static Vector3 VGBBRWVHXVR(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x98B08A0", Offset = "0x98AF8A0", VA = "0x1898B08A0")]
		public static void YFORZVGBBXJ(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x98AF480", Offset = "0x98AE480", VA = "0x1898AF480")]
		public static Vector3 EFHZZWRIVKG(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x98AF700", Offset = "0x98AE700", VA = "0x1898AF700")]
		public static void HQHCHSWEAUF(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x98B0120", Offset = "0x98AF120", VA = "0x1898B0120")]
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
