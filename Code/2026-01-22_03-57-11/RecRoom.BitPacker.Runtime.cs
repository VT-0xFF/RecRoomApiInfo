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
		[Cpp2IlInjected.Address(RVA = "0x81C2980", Offset = "0x81C1180", VA = "0x1881C2980", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int LTRITSNSYVW = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int LCRLYJJKNMW = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int JCTRXLXVRUL = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] HYDYGYGZQAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string HQOLKWUHATT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream XSQNZUILJRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool RZGQHFGTELR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> HSPCCOZCDPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int RNFMLWDVEXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int TXGTWPFIHZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] HCWRCSDXJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int DWQOMDDHOKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int XWHHNMXLXGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int AEMCJVMQSXH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool MDHBDXFSZQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x13CB7C0", Offset = "0x13C9FC0", VA = "0x1813CB7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x81C0DE0", Offset = "0x81BF5E0", VA = "0x1881C0DE0")]
		public static int LADXLJAAHRA(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x81C1F50", Offset = "0x81C0750", VA = "0x1881C1F50")]
		public static uint TCHHWJHOAWE(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81C2920", Offset = "0x81C1120", VA = "0x1881C2920")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81C0390", Offset = "0x81BEB90", VA = "0x1881C0390", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81C14A0", Offset = "0x81BFCA0", VA = "0x1881C14A0")]
		public void OHCXQKNPJYP(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x81C2050", Offset = "0x81C0850", VA = "0x1881C2050")]
		private void VCRDDGWTAYS([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81C02D0", Offset = "0x81BEAD0", VA = "0x1881C02D0")]
		public int CKAUEQOIEBB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81C02B0", Offset = "0x81BEAB0", VA = "0x1881C02B0")]
		public int CKAUEQOIEBB([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81BFFF0", Offset = "0x81BE7F0", VA = "0x1881BFFF0")]
		public int CAPMDDYAVJY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81C1570", Offset = "0x81BFD70", VA = "0x1881C1570")]
		public int OTWCTLZPWOY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81C2120", Offset = "0x81C0920", VA = "0x1881C2120")]
		public void VEQQCRSTISL(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81C2170", Offset = "0x81C0970", VA = "0x1881C2170")]
		public void VEQQCRSTISL(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x81C2250", Offset = "0x81C0A50", VA = "0x1881C2250")]
		public void VEQQCRSTISL(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x81C01E0", Offset = "0x81BE9E0", VA = "0x1881C01E0")]
		private void CGYXOXGMCAG(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x81C1F40", Offset = "0x81C0740", VA = "0x1881C1F40")]
		public void TBGNOKTEVCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81C25F0", Offset = "0x81C0DF0", VA = "0x1881C25F0")]
		public void XMFQBMGRUIY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81C02F0", Offset = "0x81BEAF0", VA = "0x1881C02F0")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x81C1AB0", Offset = "0x81C02B0", VA = "0x1881C1AB0")]
		public void QGWPQYEJUXZ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81C0900", Offset = "0x81BF100", VA = "0x1881C0900")]
		public Guid IFXMPVNDHKC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x81C0360", Offset = "0x81BEB60", VA = "0x1881C0360")]
		public void DTROCFLZPTQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x81C1480", Offset = "0x81BFC80", VA = "0x1881C1480")]
		public bool OFTTDPHWYTN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81C1670", Offset = "0x81BFE70", VA = "0x1881C1670")]
		public void PQVCLHLVDJB(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81C1EC0", Offset = "0x81C06C0", VA = "0x1881C1EC0")]
		public int STPIEMDZMLK(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81C2670", Offset = "0x81C0E70", VA = "0x1881C2670")]
		public void XQREVLYGQWI(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81C1020", Offset = "0x81BF820", VA = "0x1881C1020")]
		public void MEMKDUFOZFM(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81C1E20", Offset = "0x81C0620", VA = "0x1881C1E20")]
		public byte RZDWHWTZJBH(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81BFF70", Offset = "0x81BE770", VA = "0x1881BFF70")]
		public uint AVBZIZJHVQT(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x81C1600", Offset = "0x81BFE00", VA = "0x1881C1600")]
		public void PAMSXRFKNVO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x81C1C00", Offset = "0x81C0400", VA = "0x1881C1C00")]
		public void QJEBCSLBZTL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x81C1170", Offset = "0x81BF970", VA = "0x1881C1170")]
		public int NPALAMNTUMN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81C11D0", Offset = "0x81BF9D0", VA = "0x1881C11D0")]
		public long NSQQRYJWNZU()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x71C8910", Offset = "0x71C7110", VA = "0x1871C8910")]
		private static uint HTSPOCOVQBC(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x71A5FE0", Offset = "0x71A47E0", VA = "0x1871A5FE0")]
		private static int KVUHLBKJZRS(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x81C1660", Offset = "0x81BFE60", VA = "0x1881C1660")]
		private static ulong PQFPJMDTVWT(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x81C1D60", Offset = "0x81C0560", VA = "0x1881C1D60")]
		private static long QUYGLVAMVBB(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x81C2830", Offset = "0x81C1030", VA = "0x1881C2830")]
		public void YPOVEJWAVTB(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x81C0C90", Offset = "0x81BF490", VA = "0x1881C0C90")]
		public void KXNXOQCPWMM(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x81C0400", Offset = "0x81BEC00", VA = "0x1881C0400")]
		public uint EMVLXKNFHAY()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x81C10C0", Offset = "0x81BF8C0", VA = "0x1881C10C0")]
		public ulong MTQUTWGIXCN()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81C0670", Offset = "0x81BEE70", VA = "0x1881C0670")]
		public void HWNAYFUBAMW(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x81C1D70", Offset = "0x81C0570", VA = "0x1881C1D70")]
		public float RLQHUXTTBTR(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81C09F0", Offset = "0x81BF1F0", VA = "0x1881C09F0")]
		private void IVKHCMRDDFI(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x81C0E90", Offset = "0x81BF690", VA = "0x1881C0E90")]
		public void LCMWTNYPFQY(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x81C04D0", Offset = "0x81BECD0", VA = "0x1881C04D0")]
		public float GOTKQZCARJF(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81C0610", Offset = "0x81BEE10", VA = "0x1881C0610")]
		private void HVMKJOAQLKI(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81C2690", Offset = "0x81C0E90", VA = "0x1881C2690")]
		public void XTLYIPBAVAQ(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81C1F70", Offset = "0x81C0770", VA = "0x1881C1F70")]
		public float UESIOCCHFCL(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x81C1C70", Offset = "0x81C0470", VA = "0x1881C1C70")]
		private void QSZFCJZOTKA(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x81C1EA0", Offset = "0x81C06A0", VA = "0x1881C1EA0")]
		public void SAEPTSARBIC(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x81C2330", Offset = "0x81C0B30", VA = "0x1881C2330")]
		public float WEYJHFWGANL()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81C0410", Offset = "0x81BEC10", VA = "0x1881C0410")]
		public void EZGUIMGOKOL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x81C2350", Offset = "0x81C0B50", VA = "0x1881C2350")]
		public string WKENXSJRKKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x348EE50", Offset = "0x348D650", VA = "0x18348EE50")]
		public void JYTEYXBFSAK<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x348F1F0", Offset = "0x348D9F0", VA = "0x18348F1F0")]
		public List<c> WESUIKQPLWH<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81C0AD0", Offset = "0x81BF2D0", VA = "0x1881C0AD0")]
		public void KIPRYVMNEZE(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x81C2540", Offset = "0x81C0D40", VA = "0x1881C2540")]
		public Span<byte> XDRPUYQUWBZ()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x81BFD30", Offset = "0x81BE530", VA = "0x1881BFD30")]
		public void AAZIOMYLOFY(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81C1980", Offset = "0x81C0180", VA = "0x1881C1980")]
		public void QGPFXEUFRJY(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x81C0010", Offset = "0x81BE810", VA = "0x1881C0010")]
		public uint CEQFEIWAYKH(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x81C1230", Offset = "0x81BFA30", VA = "0x1881C1230")]
		private void OBEPSWIPZSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x81C1710", Offset = "0x81BFF10", VA = "0x1881C1710")]
		private void QFDFHYDHTSB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class TPNONNPULQS
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
		[Cpp2IlInjected.Address(RVA = "0x81C4AA0", Offset = "0x81C32A0", VA = "0x1881C4AA0")]
		public static void LPIVKAHMIQC(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x81C4C50", Offset = "0x81C3450", VA = "0x1881C4C50")]
		public static void SBUPHXBNNUL(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x81C4C10", Offset = "0x81C3410", VA = "0x1881C4C10")]
		public static ViewId QHKIFUTJJFJ(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x81C5130", Offset = "0x81C3930", VA = "0x1881C5130")]
		public static PartialViewId VQRUFLCKZEM(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x81C4AB0", Offset = "0x81C32B0", VA = "0x1881C4AB0")]
		private static bool QCFCZWGMSMB(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x81C54F0", Offset = "0x81C3CF0", VA = "0x1881C54F0")]
		private static PartialViewId WALMQUWBSDI(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x81C48C0", Offset = "0x81C30C0", VA = "0x1881C48C0")]
		private static bool FJSLHDEEDMA(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x81C5660", Offset = "0x81C3E60", VA = "0x1881C5660")]
		private static ViewId XFFAHQMVSFV(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x81C4EC0", Offset = "0x81C36C0", VA = "0x1881C4EC0")]
		private static bool URLTHVHLPVL(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x81C5350", Offset = "0x81C3B50", VA = "0x1881C5350")]
		private static ViewId VTYIQCPMDEK(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class UCEKLRVLQKN : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds DUPVCDMWJHD;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x81C58C0", Offset = "0x81C40C0", VA = "0x1881C58C0")]
		public UCEKLRVLQKN(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class SEFJRAILAUP
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float VURDEZZSVGH;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 FGCQVKSHVEL;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 RFTILXXISSJ;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds DUPVCDMWJHD;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x81C3AF0", Offset = "0x81C22F0", VA = "0x1881C3AF0")]
		public static void MYXTKFCYXEC(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x81C4410", Offset = "0x81C2C10", VA = "0x1881C4410")]
		public static Quaternion YLVHXYCYEMX(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x81C2A00", Offset = "0x81C1200", VA = "0x1881C2A00")]
		public static void CEZCISQVLKV(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x81C3690", Offset = "0x81C1E90", VA = "0x1881C3690")]
		public static Vector3 KDJRQIISVFM(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x81C3950", Offset = "0x81C2150", VA = "0x1881C3950")]
		public static void MCYQPBKDZSJ(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x81C3240", Offset = "0x81C1A40", VA = "0x1881C3240")]
		public static Vector3 ISJUWIESMDO(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x81C3830", Offset = "0x81C2030", VA = "0x1881C3830")]
		public static void MCYQPBKDZSJ(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x81C3110", Offset = "0x81C1910", VA = "0x1881C3110")]
		public static Vector3 ISJUWIESMDO(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x81C3E70", Offset = "0x81C2670", VA = "0x1881C3E70")]
		private static void QKXITIBTRJG(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x81C46A0", Offset = "0x81C2EA0", VA = "0x1881C46A0")]
		private static Vector3 YWWVHVLETMR(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x81C42A0", Offset = "0x81C2AA0", VA = "0x1881C42A0")]
		public static void VBQMMBTHRYI(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x81C3D40", Offset = "0x81C2540", VA = "0x1881C3D40")]
		public static Quaternion PVAUAWACVMF(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x81C30E0", Offset = "0x81C18E0", VA = "0x1881C30E0")]
		public static void FQZMOFZQWAU(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x81C3F30", Offset = "0x81C2730", VA = "0x1881C3F30")]
		public static float SJRYVRSURCH(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x81C2EE0", Offset = "0x81C16E0", VA = "0x1881C2EE0")]
		public static void FJOHGADZFXL(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x81C2B10", Offset = "0x81C1310", VA = "0x1881C2B10")]
		public static Vector3 EVSWILPBTCA(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x81C3FE0", Offset = "0x81C27E0", VA = "0x1881C3FE0")]
		public static void UFPNTGWLJFP(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x81C4190", Offset = "0x81C2990", VA = "0x1881C4190")]
		public static Vector3 UQXYXZLFRXW(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x81C2E80", Offset = "0x81C1680", VA = "0x1881C2E80")]
		public static void FIVHIFEBAJW(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x81C3F60", Offset = "0x81C2760", VA = "0x1881C3F60")]
		public static Vector3 TXZHLKYWLUX(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x81C3780", Offset = "0x81C1F80", VA = "0x1881C3780")]
		public static void KWHHGDMOKHE(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x81C35B0", Offset = "0x81C1DB0", VA = "0x1881C35B0")]
		public static Vector3 IVECTWDIKOZ(this BitPacker a, float b, float c, int d = 8)
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
