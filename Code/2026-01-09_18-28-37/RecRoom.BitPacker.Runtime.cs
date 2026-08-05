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
		[Cpp2IlInjected.Address(RVA = "0x80DA870", Offset = "0x80D9C70", VA = "0x1880DA870", Slot = "4")]
		public override void MKOAUOREKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int IPZVKOVNHHV = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int EBHJKKMKPDP = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int XVWIONCFXQE = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] LKUMRMHBCUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string CILZJNVHMHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream NOVXPGPMHEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool USCTQEADKUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> HHLFCKBJOCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int HXWMFWUDBAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int LQKJRXGSRWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] BJSSBXKAYNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int UDVDVMDTGFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int MAGCLGOLVQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int WDBHMDFUWMW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool TNWSJHDHYUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x13473B0", Offset = "0x13467B0", VA = "0x1813473B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x80D5CC0", Offset = "0x80D50C0", VA = "0x1880D5CC0")]
		public static int HZTDMZGIANN(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80D5BB0", Offset = "0x80D4FB0", VA = "0x1880D5BB0")]
		public static uint GPOCJRIJWGR(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x80D79C0", Offset = "0x80D6DC0", VA = "0x1880D79C0")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80D5520", Offset = "0x80D4920", VA = "0x1880D5520", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80D6F60", Offset = "0x80D6360", VA = "0x1880D6F60")]
		public void QPCDYDPQHDU(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80D7040", Offset = "0x80D6440", VA = "0x1880D7040")]
		private void RKBWDHSVAIL([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x80D7780", Offset = "0x80D6B80", VA = "0x1880D7780")]
		public int ZIYJXDRDDIA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80D7760", Offset = "0x80D6B60", VA = "0x1880D7760")]
		public int ZIYJXDRDDIA([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80D5990", Offset = "0x80D4D90", VA = "0x1880D5990")]
		public int FSQCYAPRMTP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80D57E0", Offset = "0x80D4BE0", VA = "0x1880D57E0")]
		public int FAVNVSGFDYD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80D6BB0", Offset = "0x80D5FB0", VA = "0x1880D6BB0")]
		public void OCAXCFBXBXM(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x80D6CE0", Offset = "0x80D60E0", VA = "0x1880D6CE0")]
		public void OCAXCFBXBXM(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x80D6C00", Offset = "0x80D6000", VA = "0x1880D6C00")]
		public void OCAXCFBXBXM(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80D5AE0", Offset = "0x80D4EE0", VA = "0x1880D5AE0")]
		private void GKZZBDUEPGL(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80D5CB0", Offset = "0x80D50B0", VA = "0x1880D5CB0")]
		public void HXLHROKUYPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80D4DD0", Offset = "0x80D41D0", VA = "0x1880D4DD0")]
		public void APIHRXZQPLZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x80D5130", Offset = "0x80D4530", VA = "0x1880D5130")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x80D53D0", Offset = "0x80D47D0", VA = "0x1880D53D0")]
		public void DYIIJEBIKDO(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80D6E70", Offset = "0x80D6270", VA = "0x1880D6E70")]
		public Guid PDABSTLPNZF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x80D74E0", Offset = "0x80D68E0", VA = "0x1880D74E0")]
		public void UTXWHJAULDL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80D67C0", Offset = "0x80D5BC0", VA = "0x1880D67C0")]
		public bool KNSUXVTNHZY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80D64D0", Offset = "0x80D58D0", VA = "0x1880D64D0")]
		public void KGKKSPBDMHY(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x80D50B0", Offset = "0x80D44B0", VA = "0x1880D50B0")]
		public int CLYGWHQHDBF(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x80D7740", Offset = "0x80D6B40", VA = "0x1880D7740")]
		public void ZFUEXQGCRGX(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x80D6A30", Offset = "0x80D5E30", VA = "0x1880D6A30")]
		public void MXUNLGSTFWR(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x80D7520", Offset = "0x80D6920", VA = "0x1880D7520")]
		public byte WJPLFAUAGAY(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x80D69B0", Offset = "0x80D5DB0", VA = "0x1880D69B0")]
		public uint MXKHSFJVBAK(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80D51A0", Offset = "0x80D45A0", VA = "0x1880D51A0")]
		public void DCNLNBASAYH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x80D5920", Offset = "0x80D4D20", VA = "0x1880D5920")]
		public void FKTHHFOMIKM(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x80D67E0", Offset = "0x80D5BE0", VA = "0x1880D67E0")]
		public int LHEUIKPCRVS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x80D5050", Offset = "0x80D4450", VA = "0x1880D5050")]
		public long CFHWLDDTEZP()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x70E8A00", Offset = "0x70E7E00", VA = "0x1870E8A00")]
		private static uint KTBMACYPQQZ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x70C60E0", Offset = "0x70C54E0", VA = "0x1870C60E0")]
		private static int CUBHJHSHPMR(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x80D57D0", Offset = "0x80D4BD0", VA = "0x1880D57D0")]
		private static ulong EPBDNCYYCVI(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x80D7510", Offset = "0x80D6910", VA = "0x1880D7510")]
		private static long UVYEJWAEMEG(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80D7730", Offset = "0x80D6B30", VA = "0x1880D7730")]
		public void WYNSSYEJTQG(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x80D6860", Offset = "0x80D5C60", VA = "0x1880D6860")]
		public void MKBFEZJFBSX(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x80D7030", Offset = "0x80D6430", VA = "0x1880D7030")]
		public uint RDZVQJOAXCX()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80D4F40", Offset = "0x80D4340", VA = "0x1880D4F40")]
		public ulong BIISKVQWOBO()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80D6240", Offset = "0x80D5640", VA = "0x1880D6240")]
		public void KDXIWLFUSGR(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x80D6DC0", Offset = "0x80D61C0", VA = "0x1880D6DC0")]
		public float OPIHIOGUDKC(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x80D6AD0", Offset = "0x80D5ED0", VA = "0x1880D6AD0")]
		private void NKXUIRAPNJJ(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x80D75A0", Offset = "0x80D69A0", VA = "0x1880D75A0")]
		public void WQRVRUKNUTD(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x80D77A0", Offset = "0x80D6BA0", VA = "0x1880D77A0")]
		public float ZWYTFZNKUEI(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x80D4FF0", Offset = "0x80D43F0", VA = "0x1880D4FF0")]
		private void BXSSSVTOGXV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x80D5D70", Offset = "0x80D5170", VA = "0x1880D5D70")]
		public void INZSJWPZQDH(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x80D5BD0", Offset = "0x80D4FD0", VA = "0x1880D5BD0")]
		public float GSWMCJSRDAU(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x80D4E50", Offset = "0x80D4250", VA = "0x1880D4E50")]
		private void AXNTAQBDNSL(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x80D6840", Offset = "0x80D5C40", VA = "0x1880D6840")]
		public void MEUIHMLIWZF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x80D7110", Offset = "0x80D6510", VA = "0x1880D7110")]
		public float RTIZBPTDZGC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x80D5F10", Offset = "0x80D5310", VA = "0x1880D5F10")]
		public void JTAODDQKAJW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80D72F0", Offset = "0x80D66F0", VA = "0x1880D72F0")]
		public string TEHZBYUZCOX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3452790", Offset = "0x3451B90", VA = "0x183452790")]
		public void UEJGEHXOAZP<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3452330", Offset = "0x3451730", VA = "0x183452330")]
		public List<c> EUSKWLRPLRI<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80D7130", Offset = "0x80D6530", VA = "0x1880D7130")]
		public void SCMKQJFYWYR(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x80D5870", Offset = "0x80D4C70", VA = "0x1880D5870")]
		public Span<byte> FKLURDGPHCC()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x80D5590", Offset = "0x80D4990", VA = "0x1880D5590")]
		public void EFFTECBMIRP(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x80D59B0", Offset = "0x80D4DB0", VA = "0x1880D59B0")]
		public void GIOPQNVUPAV(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x80D5200", Offset = "0x80D4600", VA = "0x1880D5200")]
		public uint DNZZCAMXBHQ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x80D6570", Offset = "0x80D5970", VA = "0x1880D6570")]
		private void KJPQAAOWBEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x80D5FD0", Offset = "0x80D53D0", VA = "0x1880D5FD0")]
		private void JYIUMSWEAEO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class JQJJWJZQWJP
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
		[Cpp2IlInjected.Address(RVA = "0x80D9FF0", Offset = "0x80D93F0", VA = "0x1880D9FF0")]
		public static void OKHLKVBPHTL(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x80DA390", Offset = "0x80D9790", VA = "0x1880DA390")]
		public static void STRWGRBTEVM(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x80D9C60", Offset = "0x80D9060", VA = "0x1880D9C60")]
		public static ViewId DMOKUATJIBM(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x80D98E0", Offset = "0x80D8CE0", VA = "0x1880D98E0")]
		public static PartialViewId BEFVWOJKXOL(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x80D9B00", Offset = "0x80D8F00", VA = "0x1880D9B00")]
		private static bool CBUFQBEEKVA(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x80D9E80", Offset = "0x80D9280", VA = "0x1880D9E80")]
		private static PartialViewId MDFSTYYQURV(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x80D9CA0", Offset = "0x80D90A0", VA = "0x1880D9CA0")]
		private static bool JYLGWIQCECX(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x80DA1A0", Offset = "0x80D95A0", VA = "0x1880DA1A0")]
		private static ViewId SKFXIPSSHEG(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x80DA600", Offset = "0x80D9A00", VA = "0x1880DA600")]
		private static bool VYOIRFJUXHY(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x80DA000", Offset = "0x80D9400", VA = "0x1880DA000")]
		private static ViewId OTBAVZBWBWX(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AZJZLCLALWA : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds DSODENFKINU;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x80D4D40", Offset = "0x80D4140", VA = "0x1880D4D40")]
		public AZJZLCLALWA(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class EDISFTSZUCW
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float PPOQLBVWKPW;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 MFYFKERJLBS;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 DNUOAZXVWMM;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds DSODENFKINU;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x80D8F20", Offset = "0x80D8320", VA = "0x1880D8F20")]
		public static void UMQDJGORHQB(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x80D8150", Offset = "0x80D7550", VA = "0x1880D8150")]
		public static Quaternion KTGGLKWODAG(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x80D8B90", Offset = "0x80D7F90", VA = "0x1880D8B90")]
		public static void QMJRLDZNASM(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x80D7BD0", Offset = "0x80D6FD0", VA = "0x1880D7BD0")]
		public static Vector3 FLQRHQJHHHX(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x80D9290", Offset = "0x80D8690", VA = "0x1880D9290")]
		public static void WCUKUHKDNSS(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x80D8650", Offset = "0x80D7A50", VA = "0x1880D8650")]
		public static Vector3 NNVIXCUIQKB(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x80D9170", Offset = "0x80D8570", VA = "0x1880D9170")]
		public static void WCUKUHKDNSS(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x80D8520", Offset = "0x80D7920", VA = "0x1880D8520")]
		public static Vector3 NNVIXCUIQKB(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x80D8AA0", Offset = "0x80D7EA0", VA = "0x1880D8AA0")]
		private static void OHITJZGMKXB(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x80D8440", Offset = "0x80D7840", VA = "0x1880D8440")]
		private static Vector3 NMMDIQQOEEY(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x80D7CC0", Offset = "0x80D70C0", VA = "0x1880D7CC0")]
		public static void FTGAFZYBURF(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x80D7E60", Offset = "0x80D7260", VA = "0x1880D7E60")]
		public static Quaternion IHJIOWIQFIE(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x80D8B60", Offset = "0x80D7F60", VA = "0x1880D8B60")]
		public static void PAVNTEAKWGF(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x80D7E30", Offset = "0x80D7230", VA = "0x1880D7E30")]
		public static float HFHHGHFRLLO(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x80D8CA0", Offset = "0x80D80A0", VA = "0x1880D8CA0")]
		public static void QPLGWHJPPGK(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x80D9430", Offset = "0x80D8830", VA = "0x1880D9430")]
		public static Vector3 ZUBDMKBFQCV(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x80D7A20", Offset = "0x80D6E20", VA = "0x1880D7A20")]
		public static void DPLDTLGPPAW(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x80D8040", Offset = "0x80D7440", VA = "0x1880D8040")]
		public static Vector3 JQAZGVHDUKN(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x80D83E0", Offset = "0x80D77E0", VA = "0x1880D83E0")]
		public static void NMFSEVQOZTX(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x80D8EA0", Offset = "0x80D82A0", VA = "0x1880D8EA0")]
		public static Vector3 SGWLLVIXMWA(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x80D7F90", Offset = "0x80D7390", VA = "0x1880D7F90")]
		public static void IVFSYEADOZB(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x80D89C0", Offset = "0x80D7DC0", VA = "0x1880D89C0")]
		public static Vector3 NSUSOSOJRRA(this BitPacker a, float b, float c, int d = 8)
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
