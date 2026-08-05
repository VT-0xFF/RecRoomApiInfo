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
		[Cpp2IlInjected.Address(RVA = "0x96F2260", Offset = "0x96F0C60", VA = "0x1896F2260", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int XHYXZNBHEJD = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int SQZGZHHZRZV = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int PVEFZDSJWXA = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] FVJLEUBJTIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string YWCKBCVIHUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream XZKNHOXMFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool NVAEWLFTICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> CUDBJAWILYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int ROUDPJRHPZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int RKXCQQMLMHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] APBICIRZHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int ENUMIGJZLQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int FYSWJBDBSSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int ARNAWXVDVXG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool ZLMXUIEQGAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x16596E0", Offset = "0x16580E0", VA = "0x1816596E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x96EEBE0", Offset = "0x96ED5E0", VA = "0x1896EEBE0")]
		public static int VRWJNZUEAKN(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x96EDBF0", Offset = "0x96EC5F0", VA = "0x1896EDBF0")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x96EF380", Offset = "0x96EDD80", VA = "0x1896EF380")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x96ECF10", Offset = "0x96EB910", VA = "0x1896ECF10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x96EE7B0", Offset = "0x96ED1B0", VA = "0x1896EE7B0")]
		public void TKZJXDBFKIQ(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x96ED370", Offset = "0x96EBD70", VA = "0x1896ED370")]
		private void GQLFXDLNWEJ([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x96ED730", Offset = "0x96EC130", VA = "0x1896ED730")]
		public int LJZAODFTDTI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x96ED750", Offset = "0x96EC150", VA = "0x1896ED750")]
		public int LJZAODFTDTI([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x96EEF90", Offset = "0x96ED990", VA = "0x1896EEF90")]
		public int YGLUZFZAVUT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x96EEF00", Offset = "0x96ED900", VA = "0x1896EEF00")]
		public int WZDARLRHBLH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x96EF140", Offset = "0x96EDB40", VA = "0x1896EF140")]
		public void ZVHELLWXVFO(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x96EF060", Offset = "0x96EDA60", VA = "0x1896EF060")]
		public void ZVHELLWXVFO(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x96EF190", Offset = "0x96EDB90", VA = "0x1896EF190")]
		public void ZVHELLWXVFO(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x96EECA0", Offset = "0x96ED6A0", VA = "0x1896EECA0")]
		private void WLWVZQZCLJP(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x96EEB70", Offset = "0x96ED570", VA = "0x1896EEB70")]
		public void VEOTADHPKTL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x96ECE90", Offset = "0x96EB890", VA = "0x1896ECE90")]
		public void DYBCKOXSTTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x96ECD40", Offset = "0x96EB740", VA = "0x1896ECD40")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x96EDE20", Offset = "0x96EC820", VA = "0x1896EDE20")]
		public void OZZDGDXCPJA(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x96EE920", Offset = "0x96ED320", VA = "0x1896EE920")]
		public Guid TVZXWJWDGWJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x96ED340", Offset = "0x96EBD40", VA = "0x1896ED340")]
		public void GGSROABXXOX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x96EF270", Offset = "0x96EDC70", VA = "0x1896EF270")]
		public bool ZXDPKDWUMOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x96ED770", Offset = "0x96EC170", VA = "0x1896ED770")]
		public void LYBYTMRTFRG(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x96ED440", Offset = "0x96EBE40", VA = "0x1896ED440")]
		public int HIFHBNCGMQZ(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x96EE900", Offset = "0x96ED300", VA = "0x1896EE900")]
		public void TTVKZADJMAJ(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x96ED4E0", Offset = "0x96EBEE0", VA = "0x1896ED4E0")]
		public void HSWTATBHDPR(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x96EE880", Offset = "0x96ED280", VA = "0x1896EE880")]
		public byte TLNBTBVWCVY(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x96ECE10", Offset = "0x96EB810", VA = "0x1896ECE10")]
		public uint DXWDPPFHUSM(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x96ED6D0", Offset = "0x96EC0D0", VA = "0x1896ED6D0")]
		public void JXCAHELXMSN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x96ED2D0", Offset = "0x96EBCD0", VA = "0x1896ED2D0")]
		public void GFLHAIDUJAS(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x96ED670", Offset = "0x96EC070", VA = "0x1896ED670")]
		public int JEFSJGICRNE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x96EEB80", Offset = "0x96ED580", VA = "0x1896EEB80")]
		public long VLVXJHZQOQP()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x869A470", Offset = "0x8698E70", VA = "0x18869A470")]
		private static uint CIUMYQAOVUD(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8677580", Offset = "0x8675F80", VA = "0x188677580")]
		private static int YKCNUFCFSXB(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x96EEA10", Offset = "0x96ED410", VA = "0x1896EEA10")]
		private static ulong UNCOSHNGBRW(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x96EDF70", Offset = "0x96EC970", VA = "0x1896EDF70")]
		private static long QHYCXOCDIVS(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x96EDF80", Offset = "0x96EC980", VA = "0x1896EDF80")]
		public void QLFLSOUNNZS(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x96EEA20", Offset = "0x96ED420", VA = "0x1896EEA20")]
		public void UXBWVJPLFZL(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x96ECBF0", Offset = "0x96EB5F0", VA = "0x1896ECBF0")]
		public uint CEVYCDSDPEB()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x96EE700", Offset = "0x96ED100", VA = "0x1896EE700")]
		public ulong THXSHZJRNDY()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x96EC770", Offset = "0x96EB170", VA = "0x1896EC770")]
		public void ARBIQPMLVFB(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x96EEFB0", Offset = "0x96ED9B0", VA = "0x1896EEFB0")]
		public float ZSDVSDAANCU(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x96ED1F0", Offset = "0x96EBBF0", VA = "0x1896ED1F0")]
		private void FZZFMMULFFH(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x96EED70", Offset = "0x96ED770", VA = "0x1896EED70")]
		public void WLYGXEGOHKX(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x96ECC00", Offset = "0x96EB600", VA = "0x1896ECC00")]
		public float CRUXWBKDVOG(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x96ECDB0", Offset = "0x96EB7B0", VA = "0x1896ECDB0")]
		private void DKPVRAFMSQJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x96EDA50", Offset = "0x96EC450", VA = "0x1896EDA50")]
		public void MXQSFILSMKD(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x96EE200", Offset = "0x96ECC00", VA = "0x1896EE200")]
		public float RNJWPONSZJU(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x96ED580", Offset = "0x96EBF80", VA = "0x1896ED580")]
		private void IBXLNKCUFOV(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x96EDE00", Offset = "0x96EC800", VA = "0x1896EDE00")]
		public void NZELVMHLNEN(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x96ED4C0", Offset = "0x96EBEC0", VA = "0x1896ED4C0")]
		public float HOBNVIWPZTK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x96ECA00", Offset = "0x96EB400", VA = "0x1896ECA00")]
		public void BAGGSQHWUKC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x96EDC10", Offset = "0x96EC610", VA = "0x1896EDC10")]
		public string NLHWEPYTRLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37C6C40", Offset = "0x37C5640", VA = "0x1837C6C40")]
		public void CZXDQRUDGPF<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x37C6FD0", Offset = "0x37C59D0", VA = "0x1837C6FD0")]
		public List<c> RCXMDCUEAZW<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x96EE040", Offset = "0x96ECA40", VA = "0x1896EE040")]
		public void RLIONWPGOJV(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x96EDF90", Offset = "0x96EC990", VA = "0x1896EDF90")]
		public Span<byte> QRAZEOZUAUQ()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x96ED810", Offset = "0x96EC210", VA = "0x1896ED810")]
		public void MUDNHEWOEHN(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x96ECAC0", Offset = "0x96EB4C0", VA = "0x1896ECAC0")]
		public void BDXJXHHKLMT(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x96EE530", Offset = "0x96ECF30", VA = "0x1896EE530")]
		public uint TFUVJQOMAPK(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x96EE2E0", Offset = "0x96ECCE0", VA = "0x1896EE2E0")]
		private void SPFYUCMGOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x96ECF80", Offset = "0x96EB980", VA = "0x1896ECF80")]
		private void FAMJIIELQEM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class LXJDHDZHOBZ
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
		[Cpp2IlInjected.Address(RVA = "0x96F16E0", Offset = "0x96F00E0", VA = "0x1896F16E0")]
		public static void EXGMSUQJTDJ(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x96F1BE0", Offset = "0x96F05E0", VA = "0x1896F1BE0")]
		public static void MMIKJOCVFKE(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x96F2040", Offset = "0x96F0A40", VA = "0x1896F2040")]
		public static ViewId SNKRDMLXIAU(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x96F19C0", Offset = "0x96F03C0", VA = "0x1896F19C0")]
		public static PartialViewId KKWIXLPGYLT(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x96F1860", Offset = "0x96F0260", VA = "0x1896F1860")]
		private static bool HEQLFECIKFS(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x96F16F0", Offset = "0x96F00F0", VA = "0x1896F16F0")]
		private static PartialViewId FEOMUQTHFIZ(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x96F2080", Offset = "0x96F0A80", VA = "0x1896F2080")]
		private static bool ZSNGLQUJYAN(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x96F1E50", Offset = "0x96F0850", VA = "0x1896F1E50")]
		private static ViewId SGEEUXTBFGQ(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x96F12D0", Offset = "0x96EFCD0", VA = "0x1896F12D0")]
		private static bool AKUOEXTMKNK(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x96F1540", Offset = "0x96EFF40", VA = "0x1896F1540")]
		private static ViewId EXCAWSGHGQN(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ZYNFPWIPXFQ : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds QDHVDPQEHME;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x96F2360", Offset = "0x96F0D60", VA = "0x1896F2360")]
		public ZYNFPWIPXFQ(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class HCORMQGTURS
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float QSYCEUTTFBI;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 ZSQRRQAOOOC;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 NSQXYVSOPVY;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds QDHVDPQEHME;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x96EFB10", Offset = "0x96EE510", VA = "0x1896EFB10")]
		public static void CRKSUBUDQSX(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x96F0940", Offset = "0x96EF340", VA = "0x1896F0940")]
		public static Quaternion WIIDOYABLEE(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x96F0640", Offset = "0x96EF040", VA = "0x1896F0640")]
		public static void RLLXSUEOJXE(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x96EFA10", Offset = "0x96EE410", VA = "0x1896EFA10")]
		public static Vector3 CPPBCXRONBB(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x96EF500", Offset = "0x96EDF00", VA = "0x1896EF500")]
		public static void APDFIIJECNW(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x96EFD60", Offset = "0x96EE760", VA = "0x1896EFD60")]
		public static Vector3 CRWXKCNRMXN(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x96EF3E0", Offset = "0x96EDDE0", VA = "0x1896EF3E0")]
		public static void APDFIIJECNW(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x96F00D0", Offset = "0x96EEAD0", VA = "0x1896F00D0")]
		public static Vector3 CRWXKCNRMXN(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x96F0390", Offset = "0x96EED90", VA = "0x1896F0390")]
		private static void JBMBGXOGVZT(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x96F0200", Offset = "0x96EEC00", VA = "0x1896F0200")]
		private static Vector3 GFAILIDNOHU(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x96F1010", Offset = "0x96EFA10", VA = "0x1896F1010")]
		public static void ZVNHLQMPUIV(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x96F0EE0", Offset = "0x96EF8E0", VA = "0x1896F0EE0")]
		public static Quaternion YECUUPOYMVM(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x96F0910", Offset = "0x96EF310", VA = "0x1896F0910")]
		public static void RUSMODTTIAD(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x96F0EB0", Offset = "0x96EF8B0", VA = "0x1896F0EB0")]
		public static float XESMAFFZWLM(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x96F0BD0", Offset = "0x96EF5D0", VA = "0x1896F0BD0")]
		public static void XDMFPMHBECI(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x96EF6A0", Offset = "0x96EE0A0", VA = "0x1896EF6A0")]
		public static Vector3 CNCBZOILWRB(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x96F0750", Offset = "0x96EF150", VA = "0x1896F0750")]
		public static void RMLZUMBZWCY(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x96F04D0", Offset = "0x96EEED0", VA = "0x1896F04D0")]
		public static Vector3 PDGGFATCIFZ(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x96F05E0", Offset = "0x96EEFE0", VA = "0x1896F05E0")]
		public static void RIIXDBJEBSX(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x96F0450", Offset = "0x96EEE50", VA = "0x1896F0450")]
		public static Vector3 JMIYNCETVWK(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x96F02E0", Offset = "0x96EECE0", VA = "0x1896F02E0")]
		public static void GVPRDQRKJIF(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x96F0DD0", Offset = "0x96EF7D0", VA = "0x1896F0DD0")]
		public static Vector3 XEIGQEWFCPW(this BitPacker a, float b, float c, int d = 8)
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
