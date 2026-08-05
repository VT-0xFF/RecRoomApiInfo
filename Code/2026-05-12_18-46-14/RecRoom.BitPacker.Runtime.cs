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
		[Cpp2IlInjected.Address(RVA = "0x9859710", Offset = "0x9858110", VA = "0x189859710", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x1689B40", Offset = "0x1688540", VA = "0x181689B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98560E0", Offset = "0x9854AE0", VA = "0x1898560E0")]
		public static int VRWJNZUEAKN(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98550F0", Offset = "0x9853AF0", VA = "0x1898550F0")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9856860", Offset = "0x9855260", VA = "0x189856860")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9854410", Offset = "0x9852E10", VA = "0x189854410", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9855CB0", Offset = "0x98546B0", VA = "0x189855CB0")]
		public void TKZJXDBFKIQ(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9854870", Offset = "0x9853270", VA = "0x189854870")]
		private void GQLFXDLNWEJ([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9854C30", Offset = "0x9853630", VA = "0x189854C30")]
		public int LJZAODFTDTI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9854C50", Offset = "0x9853650", VA = "0x189854C50")]
		public int LJZAODFTDTI([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9856480", Offset = "0x9854E80", VA = "0x189856480")]
		public int YGLUZFZAVUT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x98563F0", Offset = "0x9854DF0", VA = "0x1898563F0")]
		public int WZDARLRHBLH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9856630", Offset = "0x9855030", VA = "0x189856630")]
		public void ZVHELLWXVFO(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9856550", Offset = "0x9854F50", VA = "0x189856550")]
		public void ZVHELLWXVFO(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9856680", Offset = "0x9855080", VA = "0x189856680")]
		public void ZVHELLWXVFO(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9856190", Offset = "0x9854B90", VA = "0x189856190")]
		private void WLWVZQZCLJP(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9856070", Offset = "0x9854A70", VA = "0x189856070")]
		public void VEOTADHPKTL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9854390", Offset = "0x9852D90", VA = "0x189854390")]
		public void DYBCKOXSTTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9854240", Offset = "0x9852C40", VA = "0x189854240")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9855320", Offset = "0x9853D20", VA = "0x189855320")]
		public void OZZDGDXCPJA(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9855E20", Offset = "0x9854820", VA = "0x189855E20")]
		public Guid TVZXWJWDGWJ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9854840", Offset = "0x9853240", VA = "0x189854840")]
		public void GGSROABXXOX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9856760", Offset = "0x9855160", VA = "0x189856760")]
		public bool ZXDPKDWUMOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9854C70", Offset = "0x9853670", VA = "0x189854C70")]
		public void LYBYTMRTFRG(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9854940", Offset = "0x9853340", VA = "0x189854940")]
		public int HIFHBNCGMQZ(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9855E00", Offset = "0x9854800", VA = "0x189855E00")]
		public void TTVKZADJMAJ(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x98549E0", Offset = "0x98533E0", VA = "0x1898549E0")]
		public void HSWTATBHDPR(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9855D80", Offset = "0x9854780", VA = "0x189855D80")]
		public byte TLNBTBVWCVY(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9854310", Offset = "0x9852D10", VA = "0x189854310")]
		public uint DXWDPPFHUSM(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9854BD0", Offset = "0x98535D0", VA = "0x189854BD0")]
		public void JXCAHELXMSN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x98547D0", Offset = "0x98531D0", VA = "0x1898547D0")]
		public void GFLHAIDUJAS(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9854B70", Offset = "0x9853570", VA = "0x189854B70")]
		public int JEFSJGICRNE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9856080", Offset = "0x9854A80", VA = "0x189856080")]
		public long VLVXJHZQOQP()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8816470", Offset = "0x8814E70", VA = "0x188816470")]
		private static uint CIUMYQAOVUD(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x87F3810", Offset = "0x87F2210", VA = "0x1887F3810")]
		private static int YKCNUFCFSXB(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9855F10", Offset = "0x9854910", VA = "0x189855F10")]
		private static ulong UNCOSHNGBRW(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9855470", Offset = "0x9853E70", VA = "0x189855470")]
		private static long QHYCXOCDIVS(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9855480", Offset = "0x9853E80", VA = "0x189855480")]
		public void QLFLSOUNNZS(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9855F20", Offset = "0x9854920", VA = "0x189855F20")]
		public void UXBWVJPLFZL(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x98540F0", Offset = "0x9852AF0", VA = "0x1898540F0")]
		public uint CEVYCDSDPEB()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9855C00", Offset = "0x9854600", VA = "0x189855C00")]
		public ulong THXSHZJRNDY()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9853C70", Offset = "0x9852670", VA = "0x189853C70")]
		public void ARBIQPMLVFB(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x98564A0", Offset = "0x9854EA0", VA = "0x1898564A0")]
		public float ZSDVSDAANCU(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x98546F0", Offset = "0x98530F0", VA = "0x1898546F0")]
		private void FZZFMMULFFH(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9856260", Offset = "0x9854C60", VA = "0x189856260")]
		public void WLYGXEGOHKX(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9854100", Offset = "0x9852B00", VA = "0x189854100")]
		public float CRUXWBKDVOG(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x98542B0", Offset = "0x9852CB0", VA = "0x1898542B0")]
		private void DKPVRAFMSQJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9854F50", Offset = "0x9853950", VA = "0x189854F50")]
		public void MXQSFILSMKD(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9855700", Offset = "0x9854100", VA = "0x189855700")]
		public float RNJWPONSZJU(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9854A80", Offset = "0x9853480", VA = "0x189854A80")]
		private void IBXLNKCUFOV(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9855300", Offset = "0x9853D00", VA = "0x189855300")]
		public void NZELVMHLNEN(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x98549C0", Offset = "0x98533C0", VA = "0x1898549C0")]
		public float HOBNVIWPZTK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9853F00", Offset = "0x9852900", VA = "0x189853F00")]
		public void BAGGSQHWUKC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9855110", Offset = "0x9853B10", VA = "0x189855110")]
		public string NLHWEPYTRLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37E43B0", Offset = "0x37E2DB0", VA = "0x1837E43B0")]
		public void CZXDQRUDGPF<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x37E4750", Offset = "0x37E3150", VA = "0x1837E4750")]
		public List<c> RCXMDCUEAZW<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9855540", Offset = "0x9853F40", VA = "0x189855540")]
		public void RLIONWPGOJV(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9855490", Offset = "0x9853E90", VA = "0x189855490")]
		public Span<byte> QRAZEOZUAUQ()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9854D10", Offset = "0x9853710", VA = "0x189854D10")]
		public void MUDNHEWOEHN(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9853FC0", Offset = "0x98529C0", VA = "0x189853FC0")]
		public void BDXJXHHKLMT(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9855A30", Offset = "0x9854430", VA = "0x189855A30")]
		public uint TFUVJQOMAPK(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x98557E0", Offset = "0x98541E0", VA = "0x1898557E0")]
		private void SPFYUCMGOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9854480", Offset = "0x9852E80", VA = "0x189854480")]
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
		[Cpp2IlInjected.Address(RVA = "0x9858B90", Offset = "0x9857590", VA = "0x189858B90")]
		public static void EXGMSUQJTDJ(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9859090", Offset = "0x9857A90", VA = "0x189859090")]
		public static void MMIKJOCVFKE(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x98594F0", Offset = "0x9857EF0", VA = "0x1898594F0")]
		public static ViewId SNKRDMLXIAU(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9858E70", Offset = "0x9857870", VA = "0x189858E70")]
		public static PartialViewId KKWIXLPGYLT(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9858D10", Offset = "0x9857710", VA = "0x189858D10")]
		private static bool HEQLFECIKFS(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9858BA0", Offset = "0x98575A0", VA = "0x189858BA0")]
		private static PartialViewId FEOMUQTHFIZ(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9859530", Offset = "0x9857F30", VA = "0x189859530")]
		private static bool ZSNGLQUJYAN(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9859300", Offset = "0x9857D00", VA = "0x189859300")]
		private static ViewId SGEEUXTBFGQ(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9858780", Offset = "0x9857180", VA = "0x189858780")]
		private static bool AKUOEXTMKNK(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x98589F0", Offset = "0x98573F0", VA = "0x1898589F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9859800", Offset = "0x9858200", VA = "0x189859800")]
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
		[Cpp2IlInjected.Address(RVA = "0x9856FE0", Offset = "0x98559E0", VA = "0x189856FE0")]
		public static void CRKSUBUDQSX(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9857E00", Offset = "0x9856800", VA = "0x189857E00")]
		public static Quaternion WIIDOYABLEE(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9857B10", Offset = "0x9856510", VA = "0x189857B10")]
		public static void RLLXSUEOJXE(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9856EF0", Offset = "0x98558F0", VA = "0x189856EF0")]
		public static Vector3 CPPBCXRONBB(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x98569E0", Offset = "0x98553E0", VA = "0x1898569E0")]
		public static void APDFIIJECNW(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9857230", Offset = "0x9855C30", VA = "0x189857230")]
		public static Vector3 CRWXKCNRMXN(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x98568C0", Offset = "0x98552C0", VA = "0x1898568C0")]
		public static void APDFIIJECNW(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x98575A0", Offset = "0x9855FA0", VA = "0x1898575A0")]
		public static Vector3 CRWXKCNRMXN(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9857860", Offset = "0x9856260", VA = "0x189857860")]
		private static void JBMBGXOGVZT(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x98576D0", Offset = "0x98560D0", VA = "0x1898576D0")]
		private static Vector3 GFAILIDNOHU(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x98584D0", Offset = "0x9856ED0", VA = "0x1898584D0")]
		public static void ZVNHLQMPUIV(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x98583A0", Offset = "0x9856DA0", VA = "0x1898583A0")]
		public static Quaternion YECUUPOYMVM(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9857DD0", Offset = "0x98567D0", VA = "0x189857DD0")]
		public static void RUSMODTTIAD(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9858370", Offset = "0x9856D70", VA = "0x189858370")]
		public static float XESMAFFZWLM(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9858090", Offset = "0x9856A90", VA = "0x189858090")]
		public static void XDMFPMHBECI(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9856B80", Offset = "0x9855580", VA = "0x189856B80")]
		public static Vector3 CNCBZOILWRB(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9857C20", Offset = "0x9856620", VA = "0x189857C20")]
		public static void RMLZUMBZWCY(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x98579A0", Offset = "0x98563A0", VA = "0x1898579A0")]
		public static Vector3 PDGGFATCIFZ(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9857AB0", Offset = "0x98564B0", VA = "0x189857AB0")]
		public static void RIIXDBJEBSX(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9857920", Offset = "0x9856320", VA = "0x189857920")]
		public static Vector3 JMIYNCETVWK(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x98577B0", Offset = "0x98561B0", VA = "0x1898577B0")]
		public static void GVPRDQRKJIF(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9858290", Offset = "0x9856C90", VA = "0x189858290")]
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
