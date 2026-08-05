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
		[Cpp2IlInjected.Address(RVA = "0x83E5CA0", Offset = "0x83E4AA0", VA = "0x1883E5CA0", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int KTYUMGIUCZX = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int TTMVGXPZFKP = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int MDBBDCUOHAO = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] FGGAXUYGJZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string KOFWMHOWXAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream UZGAHSKVPQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool YXZYJYYASRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> JBQTEIFHIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int NKUWKLUPAAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int PNWQOQJLAQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] VHZAPFEIJHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int TKIMYPUGAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int SCXJCMFWFRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int JMUDQHOUJOE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool WCGBLMLQLDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x143BC80", Offset = "0x143AA80", VA = "0x18143BC80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83E3620", Offset = "0x83E2420", VA = "0x1883E3620")]
		public static int NILCUJMLQND(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83E3600", Offset = "0x83E2400", VA = "0x1883E3600")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83E4BA0", Offset = "0x83E39A0", VA = "0x1883E4BA0")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83E24E0", Offset = "0x83E12E0", VA = "0x1883E24E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83E38B0", Offset = "0x83E26B0", VA = "0x1883E38B0")]
		public void POHUUBOTUKY(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83E2780", Offset = "0x83E1580", VA = "0x1883E2780")]
		private void GGNMJUDGXPL([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83E24C0", Offset = "0x83E12C0", VA = "0x1883E24C0")]
		public int DPIIVUKJAOC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83E24A0", Offset = "0x83E12A0", VA = "0x1883E24A0")]
		public int DPIIVUKJAOC([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83E3FE0", Offset = "0x83E2DE0", VA = "0x1883E3FE0")]
		public int SNUMXEQLVBV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83E2D30", Offset = "0x83E1B30", VA = "0x1883E2D30")]
		public int IVEEEOSZADH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83E4760", Offset = "0x83E3560", VA = "0x1883E4760")]
		public void VPXMZTILGFO(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83E4680", Offset = "0x83E3480", VA = "0x1883E4680")]
		public void VPXMZTILGFO(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83E45A0", Offset = "0x83E33A0", VA = "0x1883E45A0")]
		public void VPXMZTILGFO(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83E26B0", Offset = "0x83E14B0", VA = "0x1883E26B0")]
		private void FWLAYVOTIRP(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83E3A60", Offset = "0x83E2860", VA = "0x1883E3A60")]
		public void QFCBWPAMONL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83E48E0", Offset = "0x83E36E0", VA = "0x1883E48E0")]
		public void XJGFBMLPEYV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83E2430", Offset = "0x83E1230", VA = "0x1883E2430")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83E1F90", Offset = "0x83E0D90", VA = "0x1883E1F90")]
		public void ALOOGZXUMGW(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83E3DB0", Offset = "0x83E2BB0", VA = "0x1883E3DB0")]
		public Guid SCGZHEGSWGN()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x83E3810", Offset = "0x83E2610", VA = "0x1883E3810")]
		public void NYKKRDXKFZF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83E3350", Offset = "0x83E2150", VA = "0x1883E3350")]
		public bool KCVKICJHKLW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83E28C0", Offset = "0x83E16C0", VA = "0x1883E28C0")]
		public void IFMQDWSJHVS(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83E23B0", Offset = "0x83E11B0", VA = "0x1883E23B0")]
		public int CUVYLDHLXUZ(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83E4430", Offset = "0x83E3230", VA = "0x1883E4430")]
		public void UIVMSRRFFPT(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83E3C30", Offset = "0x83E2A30", VA = "0x1883E3C30")]
		public void QWNTBJLYEKD(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83E3D30", Offset = "0x83E2B30", VA = "0x1883E3D30")]
		public byte RGIZLSEMPNI(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83E2630", Offset = "0x83E1430", VA = "0x1883E2630")]
		public uint EICQBSHPRAY(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83E3840", Offset = "0x83E2640", VA = "0x1883E3840")]
		public void OIQSRXDOGHH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83E36E0", Offset = "0x83E24E0", VA = "0x1883E36E0")]
		public void NOIDLLIWCTE(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83E4960", Offset = "0x83E3760", VA = "0x1883E4960")]
		public int XMZVDOAAMDY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83E3CD0", Offset = "0x83E2AD0", VA = "0x1883E3CD0")]
		public long RFUQQPZLXVF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x73C02C0", Offset = "0x73BF0C0", VA = "0x1873C02C0")]
		private static uint MZXDAFVMQCH(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x739D760", Offset = "0x739C560", VA = "0x18739D760")]
		private static int OZBIUHPMXFV(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x83E2850", Offset = "0x83E1650", VA = "0x1883E2850")]
		private static ulong HUZRLMTGCJO(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83E2DC0", Offset = "0x83E1BC0", VA = "0x1883E2DC0")]
		private static long JASLIPAZNPW(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83E38A0", Offset = "0x83E26A0", VA = "0x1883E38A0")]
		public void OVONWRVGUCQ(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83E4450", Offset = "0x83E3250", VA = "0x1883E4450")]
		public void UYOWQSRYQOJ(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x83E23A0", Offset = "0x83E11A0", VA = "0x1883E23A0")]
		public uint CNJLQHUVLIF()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83E32A0", Offset = "0x83E20A0", VA = "0x1883E32A0")]
		public ulong JZKTYCYWHEC()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83E4000", Offset = "0x83E2E00", VA = "0x1883E4000")]
		public void TQORPTDSZEH(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83E2100", Offset = "0x83E0F00", VA = "0x1883E2100")]
		public float CFPOCBGEEJG(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83E2550", Offset = "0x83E1350", VA = "0x1883E2550")]
		private void EBXZSNPEPZT(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83E2960", Offset = "0x83E1760", VA = "0x1883E2960")]
		public void IPFSTUYEFEP(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83E3EA0", Offset = "0x83E2CA0", VA = "0x1883E3EA0")]
		public float SHTAWDRFQNY(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83E2860", Offset = "0x83E1660", VA = "0x1883E2860")]
		private void IATYMYHNRAJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83E4290", Offset = "0x83E3090", VA = "0x1883E4290")]
		public void UFQFDSBVWZZ(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83E3980", Offset = "0x83E2780", VA = "0x1883E3980")]
		public float PVDYXMEGMRE(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83E49C0", Offset = "0x83E37C0", VA = "0x1883E49C0")]
		private void YCPFVJPBDPX(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83E3370", Offset = "0x83E2170", VA = "0x1883E3370")]
		public void KNMORNCIJIR(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83E20E0", Offset = "0x83E0EE0", VA = "0x1883E20E0")]
		public float AVKXIMJMOZW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83E3750", Offset = "0x83E2550", VA = "0x1883E3750")]
		public void NQSIGELESNY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83E21B0", Offset = "0x83E0FB0", VA = "0x1883E21B0")]
		public string CLYXLJVVRWF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3505EA0", Offset = "0x3504CA0", VA = "0x183505EA0")]
		public void OSNXFKNCFBR<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3506230", Offset = "0x3505030", VA = "0x183506230")]
		public List<c> RJKWMAKLEKY<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83E3A70", Offset = "0x83E2870", VA = "0x1883E3A70")]
		public void QKIKRSMNEHF(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83E3020", Offset = "0x83E1E20", VA = "0x1883E3020")]
		public Span<byte> JPDUXMWBCLW()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x83E2AF0", Offset = "0x83E18F0", VA = "0x1883E2AF0")]
		public void IUWTNHSKUOT(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83E47B0", Offset = "0x83E35B0", VA = "0x1883E47B0")]
		public void XGQGBVXUGRR(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83E30D0", Offset = "0x83E1ED0", VA = "0x1883E30D0")]
		public uint JXCCCMCBBUI(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83E2DD0", Offset = "0x83E1BD0", VA = "0x1883E2DD0")]
		private void JEZRESVGGCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83E3390", Offset = "0x83E2190", VA = "0x1883E3390")]
		private void LQSCPRTLSWE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class LAJQLWIJGUH
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
		[Cpp2IlInjected.Address(RVA = "0x83E4F30", Offset = "0x83E3D30", VA = "0x1883E4F30")]
		public static void FLWQYRFAFKX(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83E50B0", Offset = "0x83E3EB0", VA = "0x1883E50B0")]
		public static void HAJYMCJHEAY(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83E5590", Offset = "0x83E4390", VA = "0x1883E5590")]
		public static ViewId KNTHROPOFEE(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x83E4D10", Offset = "0x83E3B10", VA = "0x1883E4D10")]
		public static PartialViewId BQPOVYFQIFL(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83E5960", Offset = "0x83E4760", VA = "0x1883E5960")]
		private static bool XSJDJNIWHGQ(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x83E4F40", Offset = "0x83E3D40", VA = "0x1883E4F40")]
		private static PartialViewId GSVWQDAKKGN(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x83E5AC0", Offset = "0x83E48C0", VA = "0x1883E5AC0")]
		private static bool ZBQNOUKAFRT(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x83E5770", Offset = "0x83E4570", VA = "0x1883E5770")]
		private static ViewId XKZIPYIQUAU(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83E5320", Offset = "0x83E4120", VA = "0x1883E5320")]
		private static bool HOBFSXEONIU(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83E55D0", Offset = "0x83E43D0", VA = "0x1883E55D0")]
		private static ViewId MSSQQQLYGKF(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CAMSGJMZDLQ : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds HCULPWTHYEM;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83E4C80", Offset = "0x83E3A80", VA = "0x1883E4C80")]
		public CAMSGJMZDLQ(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class YLESYPATOJG
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float TINVYCGRPJE;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 DKCRJCKCKMC;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 IZGETVBMRCC;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds HCULPWTHYEM;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83E7140", Offset = "0x83E5F40", VA = "0x1883E7140")]
		public static void KORZDQNUSPZ(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83E6380", Offset = "0x83E5180", VA = "0x1883E6380")]
		public static Quaternion BNRBYCCNGIU(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83E6610", Offset = "0x83E5410", VA = "0x1883E6610")]
		public static void CRDYGLOSXSK(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83E6F30", Offset = "0x83E5D30", VA = "0x1883E6F30")]
		public static Vector3 GUUWXWBCPUX(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83E6C70", Offset = "0x83E5A70", VA = "0x1883E6C70")]
		public static void FZIQIBZAWNK(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83E5E50", Offset = "0x83E4C50", VA = "0x1883E5E50")]
		public static Vector3 BBJYWPCEEKL(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83E6E10", Offset = "0x83E5C10", VA = "0x1883E6E10")]
		public static void FZIQIBZAWNK(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x83E5D20", Offset = "0x83E4B20", VA = "0x1883E5D20")]
		public static Vector3 BBJYWPCEEKL(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83E7590", Offset = "0x83E6390", VA = "0x1883E7590")]
		private static void OMLGJPNCQSZ(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83E78A0", Offset = "0x83E66A0", VA = "0x1883E78A0")]
		private static Vector3 VCKCBEVCVVA(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83E7730", Offset = "0x83E6530", VA = "0x1883E7730")]
		public static void UIWEBUJGWMJ(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x83E6720", Offset = "0x83E5520", VA = "0x1883E6720")]
		public static Quaternion DRQHCBKECKO(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x83E6850", Offset = "0x83E5650", VA = "0x1883E6850")]
		public static void DSKOCOLMMPR(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x83E7980", Offset = "0x83E6780", VA = "0x1883E7980")]
		public static float VVBHRXATJUS(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x83E7390", Offset = "0x83E6190", VA = "0x1883E7390")]
		public static void MOPQCNNJQQY(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x83E6900", Offset = "0x83E5700", VA = "0x1883E6900")]
		public static Vector3 FKCHTRVXUYP(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x83E61C0", Offset = "0x83E4FC0", VA = "0x1883E61C0")]
		public static void BGPKDKZXIUQ(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x83E7030", Offset = "0x83E5E30", VA = "0x1883E7030")]
		public static Vector3 GZVCOAKNZQT(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x83E79B0", Offset = "0x83E67B0", VA = "0x1883E79B0")]
		public static void XEXWASWVPHJ(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x83E6880", Offset = "0x83E5680", VA = "0x1883E6880")]
		public static Vector3 EPASAADZPUK(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x83E7A10", Offset = "0x83E6810", VA = "0x1883E7A10")]
		public static void ZOGIJMJKXSF(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x83E7650", Offset = "0x83E6450", VA = "0x1883E7650")]
		public static Vector3 QZJLKQSLOYI(this BitPacker a, float b, float c, int d = 8)
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
