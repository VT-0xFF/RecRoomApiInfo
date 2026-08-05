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
		[Cpp2IlInjected.Address(RVA = "0x96F5AF0", Offset = "0x96F48F0", VA = "0x1896F5AF0", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int MIBBDAVHVZU = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int GFGSNGVVOGU = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int NAAQJDNSRQF = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] RRHVLYLBJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string UQXDTUSFGJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream YLWPBWKOLDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool HDCVHPRCRRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> WKXKOCQWTZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int NIXJEDYWODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int IWSPLTXDVUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] SGWUOOAXACT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int YNSCFWUWJQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int YMKEJXSUCWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int ETYZLILSKLV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool QABLXIYOSBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x165E3C0", Offset = "0x165D1C0", VA = "0x18165E3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x96F2D60", Offset = "0x96F1B60", VA = "0x1896F2D60")]
		public static int SQTXBRINXGU(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x96F27D0", Offset = "0x96F15D0", VA = "0x1896F27D0")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x96F3A90", Offset = "0x96F2890", VA = "0x1896F3A90")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x96F14D0", Offset = "0x96F02D0", VA = "0x1896F14D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x96F2350", Offset = "0x96F1150", VA = "0x1896F2350")]
		public void KZHBUYQHHRL(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x96F3130", Offset = "0x96F1F30", VA = "0x1896F3130")]
		private void TFUNIDDFHMQ([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x96F25A0", Offset = "0x96F13A0", VA = "0x1896F25A0")]
		public int MGOOPCJSQGB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x96F2580", Offset = "0x96F1380", VA = "0x1896F2580")]
		public int MGOOPCJSQGB([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x96F29E0", Offset = "0x96F17E0", VA = "0x1896F29E0")]
		public int PJOOYOWAWBC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x96F2A00", Offset = "0x96F1800", VA = "0x1896F2A00")]
		public int PMZAMVALXHI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x96F25C0", Offset = "0x96F13C0", VA = "0x1896F25C0")]
		public void MJFLJESHDAF(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x96F2610", Offset = "0x96F1410", VA = "0x1896F2610")]
		public void MJFLJESHDAF(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x96F26F0", Offset = "0x96F14F0", VA = "0x1896F26F0")]
		public void MJFLJESHDAF(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x96F3670", Offset = "0x96F2470", VA = "0x1896F3670")]
		private void YZWMICKTSWQ(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x96F2480", Offset = "0x96F1280", VA = "0x1896F2480")]
		public void MDURUAHXXRU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x96F12E0", Offset = "0x96F00E0", VA = "0x1896F12E0")]
		public void CYTWXUVEUPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x96F1360", Offset = "0x96F0160", VA = "0x1896F1360")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x96F1150", Offset = "0x96EFF50", VA = "0x1896F1150")]
		public void CQBCHADGYZD(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x96F2490", Offset = "0x96F1290", VA = "0x1896F2490")]
		public Guid MGBYIUZGVKQ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x96F2A90", Offset = "0x96F1890", VA = "0x1896F2A90")]
		public void PRFKKNJHBCA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x96F13D0", Offset = "0x96F01D0", VA = "0x1896F13D0")]
		public bool DMRPOXCKUAJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x96F1040", Offset = "0x96EFE40", VA = "0x1896F1040")]
		public void BJRCNMZBKZH(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x96F34F0", Offset = "0x96F22F0", VA = "0x1896F34F0")]
		public int YGIOOONRVBE(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x96F29C0", Offset = "0x96F17C0", VA = "0x1896F29C0")]
		public void PHVJALDVLQW(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x96F3090", Offset = "0x96F1E90", VA = "0x1896F3090")]
		public void TCTXZXJIXOI(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x96F1C20", Offset = "0x96F0A20", VA = "0x1896F1C20")]
		public byte HZUHYQXJVSD(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x96F2020", Offset = "0x96F0E20", VA = "0x1896F2020")]
		public uint JOSGKCYHLXD(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x96F1830", Offset = "0x96F0630", VA = "0x1896F1830")]
		public void FYNASIKQSMS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x96F10E0", Offset = "0x96EFEE0", VA = "0x1896F10E0")]
		public void CMRERJZCGKD(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x96F20A0", Offset = "0x96F0EA0", VA = "0x1896F20A0")]
		public int JYDXORXYWLF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x96F2420", Offset = "0x96F1220", VA = "0x1896F2420")]
		public long LRXVAYWBLQI()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86A0AA0", Offset = "0x869F8A0", VA = "0x1886A0AA0")]
		private static uint RDWJPHHUXEK(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x867DB60", Offset = "0x867C960", VA = "0x18867DB60")]
		private static int NXXDSMRVOMO(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x96F3650", Offset = "0x96F2450", VA = "0x1896F3650")]
		private static ulong YZOHVPVDRGR(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x96F33B0", Offset = "0x96F21B0", VA = "0x1896F33B0")]
		private static long WABOPDRXYNX(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x96F3660", Offset = "0x96F2460", VA = "0x1896F3660")]
		public void YZTAZOTNXAB(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x96F3200", Offset = "0x96F2000", VA = "0x1896F3200")]
		public void TLJMXKSEGAS(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x96F3990", Offset = "0x96F2790", VA = "0x1896F3990")]
		public uint ZVCSQBZGEJE()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x96F2AC0", Offset = "0x96F18C0", VA = "0x1896F2AC0")]
		public ulong QIBQPIPKHNF()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x96F1D90", Offset = "0x96F0B90", VA = "0x1896F1D90")]
		public void JONRBOFXOQU(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x96F1780", Offset = "0x96F0580", VA = "0x1896F1780")]
		public float EUMTWLTGXIV(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x96F13F0", Offset = "0x96F01F0", VA = "0x1896F13F0")]
		private void DSVTPZWZPJK(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x96F3740", Offset = "0x96F2540", VA = "0x1896F3740")]
		public void ZQPOONCVXWG(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x96F2C20", Offset = "0x96F1A20", VA = "0x1896F2C20")]
		public float SBQYBMVOGHX(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x96F3350", Offset = "0x96F2150", VA = "0x1896F3350")]
		private void VZHANHORNJE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x96F1A80", Offset = "0x96F0880", VA = "0x1896F1A80")]
		public void GVGXWTFTIJI(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x96F3570", Offset = "0x96F2370", VA = "0x1896F3570")]
		public float YNATPPLGGXT(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x96F1CA0", Offset = "0x96F0AA0", VA = "0x1896F1CA0")]
		private void IEVFNEGIRYC(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x96F12A0", Offset = "0x96F00A0", VA = "0x1896F12A0")]
		public void CUXLWQMMSJK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x96F12C0", Offset = "0x96F00C0", VA = "0x1896F12C0")]
		public float CWOUIQLAAVR()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x96F38D0", Offset = "0x96F26D0", VA = "0x1896F38D0")]
		public void ZUQIIUYABXP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x96F1890", Offset = "0x96F0690", VA = "0x1896F1890")]
		public string FZCCFRHFRYI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37BD4E0", Offset = "0x37BC2E0", VA = "0x1837BD4E0")]
		public void XXJQLSGAGTC<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x37BD080", Offset = "0x37BBE80", VA = "0x1837BD080")]
		public List<c> EYZPXMFHJON<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x96F0E80", Offset = "0x96EFC80", VA = "0x1896F0E80")]
		public void AHYNKECSLFC(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x96F2B70", Offset = "0x96F1970", VA = "0x1896F2B70")]
		public Span<byte> RXORNKYCXTT()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x96F1540", Offset = "0x96F0340", VA = "0x1896F1540")]
		public void EIUZOSTGJRS(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x96F33C0", Offset = "0x96F21C0", VA = "0x1896F33C0")]
		public void WJUSEHRXXRK(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x96F27F0", Offset = "0x96F15F0", VA = "0x1896F27F0")]
		public uint PEEVVQQGQYV(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x96F2100", Offset = "0x96F0F00", VA = "0x1896F2100")]
		private void KSNZRDXIPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x96F2E20", Offset = "0x96F1C20", VA = "0x1896F2E20")]
		private void TATHLNKSTWT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class TLVKJFJWCME
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
		[Cpp2IlInjected.Address(RVA = "0x96F5D10", Offset = "0x96F4B10", VA = "0x1896F5D10")]
		public static void GMAYFTNIQSA(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x96F6890", Offset = "0x96F5690", VA = "0x1896F6890")]
		public static void TDXAVOOQRSR(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x96F5B70", Offset = "0x96F4970", VA = "0x1896F5B70")]
		public static ViewId BJDDLIUFVMV(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x96F6670", Offset = "0x96F5470", VA = "0x1896F6670")]
		public static PartialViewId QOCKNPBWDLQ(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x96F5BB0", Offset = "0x96F49B0", VA = "0x1896F5BB0")]
		private static bool DTVMKWXLJQL(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x96F6500", Offset = "0x96F5300", VA = "0x1896F6500")]
		private static PartialViewId QNCDAHDITKA(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x96F6320", Offset = "0x96F5120", VA = "0x1896F6320")]
		private static bool NQWKLMHJOGG(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x96F5EC0", Offset = "0x96F4CC0", VA = "0x1896F5EC0")]
		private static ViewId KHYDFAUTYGV(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x96F60B0", Offset = "0x96F4EB0", VA = "0x1896F60B0")]
		private static bool NFBDEQQYIGT(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x96F5D20", Offset = "0x96F4B20", VA = "0x1896F5D20")]
		private static ViewId JJRUPEJMRDO(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CGDNNPCPEFZ : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds TKCAETURTWT;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x96F3B70", Offset = "0x96F2970", VA = "0x1896F3B70")]
		public CGDNNPCPEFZ(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class LMGNBTNSDGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float BFFDSYAYOAN;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 SSNIEIHXIHL;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 UBKCJGBHRRF;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds TKCAETURTWT;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x96F3F80", Offset = "0x96F2D80", VA = "0x1896F3F80")]
		public static void BOWTKLRWABO(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x96F4540", Offset = "0x96F3340", VA = "0x1896F4540")]
		public static Quaternion DVOTAYSZWZX(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x96F5780", Offset = "0x96F4580", VA = "0x1896F5780")]
		public static void TJHFBWUVYTB(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x96F5440", Offset = "0x96F4240", VA = "0x1896F5440")]
		public static Vector3 QXWDWSTAYBS(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x96F3D20", Offset = "0x96F2B20", VA = "0x1896F3D20")]
		public static void AREYKMVMVCL(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x96F4EC0", Offset = "0x96F3CC0", VA = "0x1896F4EC0")]
		public static Vector3 OCXPUGZSBRQ(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x96F3C00", Offset = "0x96F2A00", VA = "0x1896F3C00")]
		public static void AREYKMVMVCL(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x96F4D90", Offset = "0x96F3B90", VA = "0x1896F4D90")]
		public static Vector3 OCXPUGZSBRQ(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x96F3EC0", Offset = "0x96F2CC0", VA = "0x1896F3EC0")]
		private static void ASEWHHPFODU(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x96F5360", Offset = "0x96F4160", VA = "0x1896F5360")]
		private static Vector3 QRESXJYFDXZ(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x96F43D0", Offset = "0x96F31D0", VA = "0x1896F43D0")]
		public static void DKNJFNPFAHY(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x96F5230", Offset = "0x96F4030", VA = "0x1896F5230")]
		public static Quaternion OWJYCILPBZF(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x96F4940", Offset = "0x96F3740", VA = "0x1896F4940")]
		public static void FSZUQBMDZCS(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x96F5890", Offset = "0x96F4690", VA = "0x1896F5890")]
		public static float TZKYSKOZSTP(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x96F41D0", Offset = "0x96F2FD0", VA = "0x1896F41D0")]
		public static void CCNPWSRWGDN(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x96F4A20", Offset = "0x96F3820", VA = "0x1896F4A20")]
		public static Vector3 NDTJRZZGSVE(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x96F55C0", Offset = "0x96F43C0", VA = "0x1896F55C0")]
		public static void SNYXODQUAOX(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x96F4830", Offset = "0x96F3630", VA = "0x1896F4830")]
		public static Vector3 ELTRUVAXRHU(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x96F47D0", Offset = "0x96F35D0", VA = "0x1896F47D0")]
		public static void DYRXLSBYLBU(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x96F5540", Offset = "0x96F4340", VA = "0x1896F5540")]
		public static Vector3 RSSPEOWMNZH(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x96F4970", Offset = "0x96F3770", VA = "0x1896F4970")]
		public static void FVIEFNQFEGA(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x96F58C0", Offset = "0x96F46C0", VA = "0x1896F58C0")]
		public static Vector3 XSHAVGMXPUT(this BitPacker a, float b, float c, int d = 8)
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
