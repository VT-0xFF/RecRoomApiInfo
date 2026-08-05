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
		[Cpp2IlInjected.Address(RVA = "0x82F4F40", Offset = "0x82F4140", VA = "0x1882F4F40", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int UYYPLJPSKXP = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int BXBLDCSZYHF = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int HPMTHIKQGYG = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] ONWDMDYVRDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string UYJTJQEOCTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream HYFAJRPIYVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool EXGVLBDUHMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> JGJJXRKBAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int NOVRWVCMUEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int MDGUGTJHAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] YLRXWLXMGWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int YARDSQHMUPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int GSDCBYFEXBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int XBSWCUFZIHS;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool BGGMLYXVJHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x13FE540", Offset = "0x13FD740", VA = "0x1813FE540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82F23B0", Offset = "0x82F15B0", VA = "0x1882F23B0")]
		public static int BRUTFRWLJSJ(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82F34E0", Offset = "0x82F26E0", VA = "0x1882F34E0")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82F4DE0", Offset = "0x82F3FE0", VA = "0x1882F4DE0")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82F28F0", Offset = "0x82F1AF0", VA = "0x1882F28F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82F47B0", Offset = "0x82F39B0", VA = "0x1882F47B0")]
		public void WSIZGRGCIRO(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82F3200", Offset = "0x82F2400", VA = "0x1882F3200")]
		private void JQHACSTKHMF([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82F3C90", Offset = "0x82F2E90", VA = "0x1882F3C90")]
		public int SIEXNCAOCUS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82F3C70", Offset = "0x82F2E70", VA = "0x1882F3C70")]
		public int SIEXNCAOCUS([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82F3C50", Offset = "0x82F2E50", VA = "0x1882F3C50")]
		public int SBFDRXFDLLF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82F2790", Offset = "0x82F1990", VA = "0x1882F2790")]
		public int CWZMPUFCBFT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82F3520", Offset = "0x82F2720", VA = "0x1882F3520")]
		public void NODLTCMTFOM(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82F3650", Offset = "0x82F2850", VA = "0x1882F3650")]
		public void NODLTCMTFOM(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82F3570", Offset = "0x82F2770", VA = "0x1882F3570")]
		public void NODLTCMTFOM(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x82F3800", Offset = "0x82F2A00", VA = "0x1882F3800")]
		private void NZXFRGHBVQB(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82F4270", Offset = "0x82F3470", VA = "0x1882F4270")]
		public void UQQMQPIDDBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82F3F00", Offset = "0x82F3100", VA = "0x1882F3F00")]
		public void SQDLBYCYQRP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82F2820", Offset = "0x82F1A20", VA = "0x1882F2820")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82F2D50", Offset = "0x82F1F50", VA = "0x1882F2D50")]
		public void GTPTAMINEWK(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82F4950", Offset = "0x82F3B50", VA = "0x1882F4950")]
		public Guid YGQKOORSKCR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x82F3730", Offset = "0x82F2930", VA = "0x1882F3730")]
		public void NPRRVKGJILZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82F3440", Offset = "0x82F2640", VA = "0x1882F3440")]
		public bool LHUSSBXSMFO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82F3760", Offset = "0x82F2960", VA = "0x1882F3760")]
		public void NPZFCZQJWLW(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82F4A40", Offset = "0x82F3C40", VA = "0x1882F4A40")]
		public int ZIHKZGWBVYF(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82F46E0", Offset = "0x82F38E0", VA = "0x1882F46E0")]
		public void VRMPMZBITFL(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82F2CB0", Offset = "0x82F1EB0", VA = "0x1882F2CB0")]
		public void GMMBAIJUOUD(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82F2F80", Offset = "0x82F2180", VA = "0x1882F2F80")]
		public byte IBKEFSRBJLA(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82F3460", Offset = "0x82F2660", VA = "0x1882F3460")]
		public uint LWITFEWOVIM(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82F2890", Offset = "0x82F1A90", VA = "0x1882F2890")]
		public void DZWRODLKKDL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82F3930", Offset = "0x82F2B30", VA = "0x1882F3930")]
		public void QEUGBXFFBBY(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82F3000", Offset = "0x82F2200", VA = "0x1882F3000")]
		public int IGQBDYQVRPA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82F38D0", Offset = "0x82F2AD0", VA = "0x1882F38D0")]
		public long OHABXYIDQQH()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x72E9580", Offset = "0x72E8780", VA = "0x1872E9580")]
		private static uint ZAJPJZEZXRJ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x72C6CD0", Offset = "0x72C5ED0", VA = "0x1872C6CD0")]
		private static int FGJAJEKIWVV(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x82F3A70", Offset = "0x82F2C70", VA = "0x1882F3A70")]
		private static ulong QYFENIEXNQA(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82F4940", Offset = "0x82F3B40", VA = "0x1882F4940")]
		private static long XKRCCVXACTO(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82F3420", Offset = "0x82F2620", VA = "0x1882F3420")]
		public void KJVOQEAXZQU(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x82F32D0", Offset = "0x82F24D0", VA = "0x1882F32D0")]
		public void JYLVMMXTGIZ(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x82F3430", Offset = "0x82F2630", VA = "0x1882F3430")]
		public uint KUBYGDCPHGF()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x82F39A0", Offset = "0x82F2BA0", VA = "0x1882F39A0")]
		public ulong QMNWYZGKFIW()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82F3F80", Offset = "0x82F3180", VA = "0x1882F3F80")]
		public void SQKCXDECDED(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82F3150", Offset = "0x82F2350", VA = "0x1882F3150")]
		public float JNVXDATUNQQ(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82F2BD0", Offset = "0x82F1DD0", VA = "0x1882F2BD0")]
		private void GGWQXBKSCMN(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x82F4420", Offset = "0x82F3620", VA = "0x1882F4420")]
		public void VJYLMLHGRUD(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x82F2460", Offset = "0x82F1660", VA = "0x1882F2460")]
		public float BXTLNRMLCSS(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82F4210", Offset = "0x82F3410", VA = "0x1882F4210")]
		private void TSBCCVSEQNH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82F4280", Offset = "0x82F3480", VA = "0x1882F4280")]
		public void UZXNLPTPCUX(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82F2EA0", Offset = "0x82F20A0", VA = "0x1882F2EA0")]
		public float HGZLUBRNISO(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x82F3060", Offset = "0x82F2260", VA = "0x1882F3060")]
		private void INVHERKOTTT(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82F3500", Offset = "0x82F2700", VA = "0x1882F3500")]
		public void NCGHMEMPAEZ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82F3A50", Offset = "0x82F2C50", VA = "0x1882F3A50")]
		public float QODHRQAZPNG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x82F4880", Offset = "0x82F3A80", VA = "0x1882F4880")]
		public void XJKSKEOLXZA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82F25A0", Offset = "0x82F17A0", VA = "0x1882F25A0")]
		public string CCTIULEFAZX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x34C9070", Offset = "0x34C8270", VA = "0x1834C9070")]
		public void JTUVJMRDHBF<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x34C9410", Offset = "0x34C8610", VA = "0x1834C9410")]
		public List<c> QQYLQZTGENG<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82F21F0", Offset = "0x82F13F0", VA = "0x1882F21F0")]
		public void AWKAPVNTTDN(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x82F4700", Offset = "0x82F3900", VA = "0x1882F4700")]
		public Span<byte> VYNVRSRDWIQ()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82F4AC0", Offset = "0x82F3CC0", VA = "0x1882F4AC0")]
		public void ZNIKPKWYTUX(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82F45B0", Offset = "0x82F37B0", VA = "0x1882F45B0")]
		public void VPXHRAUJTTN(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82F3A80", Offset = "0x82F2C80", VA = "0x1882F3A80")]
		public uint SAKALWGJIUY(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82F3CB0", Offset = "0x82F2EB0", VA = "0x1882F3CB0")]
		private void SOBEZFWSJOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82F2960", Offset = "0x82F1B60", VA = "0x1882F2960")]
		private void EDYSEPQRNKE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class SNEOWJPSDGT
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
		[Cpp2IlInjected.Address(RVA = "0x82F5950", Offset = "0x82F4B50", VA = "0x1882F5950")]
		public static void NFAPOKQPWTV(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x82F56E0", Offset = "0x82F48E0", VA = "0x1882F56E0")]
		public static void LGPXEYMSKMM(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82F54C0", Offset = "0x82F46C0", VA = "0x1882F54C0")]
		public static ViewId IUDYRJTNPUI(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x82F5960", Offset = "0x82F4B60", VA = "0x1882F5960")]
		public static PartialViewId SVGIZMIMJWJ(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x82F5B80", Offset = "0x82F4D80", VA = "0x1882F5B80")]
		private static bool YMXZPZFDFAI(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x82F51B0", Offset = "0x82F43B0", VA = "0x1882F51B0")]
		private static PartialViewId BDUHFFFZDRP(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x82F5500", Offset = "0x82F4700", VA = "0x1882F5500")]
		private static bool IYFYDZJWNXT(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x82F4FC0", Offset = "0x82F41C0", VA = "0x1882F4FC0")]
		private static ViewId ABWIRZMUQTS(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x82F5CE0", Offset = "0x82F4EE0", VA = "0x1882F5CE0")]
		private static bool YPFGDIXOWIU(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x82F5320", Offset = "0x82F4520", VA = "0x1882F5320")]
		private static ViewId ELETZAIKDWN(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class GMIOQTBTZQS : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds EEFFBKMVYYI;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x82F4EB0", Offset = "0x82F40B0", VA = "0x1882F4EB0")]
		public GMIOQTBTZQS(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class VNASVSSZFHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float GDEHKFNOFRI;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 WBXFUQOZFZY;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 RQUPFLZEIOS;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds EEFFBKMVYYI;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x82F7A80", Offset = "0x82F6C80", VA = "0x1882F7A80")]
		public static void ZXOEWNFDGNZ(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x82F77F0", Offset = "0x82F69F0", VA = "0x1882F77F0")]
		public static Quaternion ZWFCYIGCNYU(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x82F6830", Offset = "0x82F5A30", VA = "0x1882F6830")]
		public static void OKACOFIJHTE(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x82F6B80", Offset = "0x82F5D80", VA = "0x1882F6B80")]
		public static Vector3 TAQNFUORQWT(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82F63F0", Offset = "0x82F55F0", VA = "0x1882F63F0")]
		public static void FNPMHQISZHO(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x82F6D20", Offset = "0x82F5F20", VA = "0x1882F6D20")]
		public static Vector3 UVIVJUINHBF(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x82F6590", Offset = "0x82F5790", VA = "0x1882F6590")]
		public static void FNPMHQISZHO(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x82F7090", Offset = "0x82F6290", VA = "0x1882F7090")]
		public static Vector3 UVIVJUINHBF(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x82F66E0", Offset = "0x82F58E0", VA = "0x1882F66E0")]
		private static void IBANSBQQDUF(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x82F69C0", Offset = "0x82F5BC0", VA = "0x1882F69C0")]
		private static Vector3 RKWFYKBMYGG(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x82F6080", Offset = "0x82F5280", VA = "0x1882F6080")]
		public static void EHWKCQSXFGN(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x82F5F50", Offset = "0x82F5150", VA = "0x1882F5F50")]
		public static Quaternion ALRTHCDKZQC(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x82F67A0", Offset = "0x82F59A0", VA = "0x1882F67A0")]
		public static void MKEJFVQOAVB(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x82F66B0", Offset = "0x82F58B0", VA = "0x1882F66B0")]
		public static float GESINJXXZLY(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x82F61F0", Offset = "0x82F53F0", VA = "0x1882F61F0")]
		public static void FFMIDACRBDS(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x82F72D0", Offset = "0x82F64D0", VA = "0x1882F72D0")]
		public static Vector3 WGRMWAEWSCH(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x82F7640", Offset = "0x82F6840", VA = "0x1882F7640")]
		public static void XHYESSFCDEQ(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x82F71C0", Offset = "0x82F63C0", VA = "0x1882F71C0")]
		public static Vector3 UWBXZTWYZRF(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x82F67D0", Offset = "0x82F59D0", VA = "0x1882F67D0")]
		public static void NBMRTEUOWEH(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x82F6940", Offset = "0x82F5B40", VA = "0x1882F6940")]
		public static Vector3 OVJZGNZFJRU(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x82F6C70", Offset = "0x82F5E70", VA = "0x1882F6C70")]
		public static void ULLCIXZBUQZ(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x82F6AA0", Offset = "0x82F5CA0", VA = "0x1882F6AA0")]
		public static Vector3 RPRBMBZGOME(this BitPacker a, float b, float c, int d = 8)
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
