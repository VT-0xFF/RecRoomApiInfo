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
		[Cpp2IlInjected.Address(RVA = "0x835F320", Offset = "0x835E320", VA = "0x18835F320", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int MULRNMQVPGU = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int GOFHVYNCIGC = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int UJJFAXRKFGL = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] EJBDJOPAENY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string VETXHIFLZBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream EZLNHVVBKST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool AKXAVKLKYHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> SQJZSGPDUJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int XFWXQVORSOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int IWWHNUVYWGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] DJCOKSWICBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int OAFENDSABPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int FJSHSXDBLRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int RSXLENGGHAN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool QAGVTTIQCIR
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x13F68A0", Offset = "0x13F58A0", VA = "0x1813F68A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x835C840", Offset = "0x835B840", VA = "0x18835C840")]
		public static int BLDEFIPRQVQ(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x835D780", Offset = "0x835C780", VA = "0x18835D780")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x835F1C0", Offset = "0x835E1C0", VA = "0x18835F1C0")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x835C9C0", Offset = "0x835B9C0", VA = "0x18835C9C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x835EB00", Offset = "0x835DB00", VA = "0x18835EB00")]
		public void VSPONUVBRSX(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x835D530", Offset = "0x835C530", VA = "0x18835D530")]
		private void LAGTHDDTVMK([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x835CDD0", Offset = "0x835BDD0", VA = "0x18835CDD0")]
		public int GFVCBJFUNWP()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x835CDF0", Offset = "0x835BDF0", VA = "0x18835CDF0")]
		public int GFVCBJFUNWP([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x835E060", Offset = "0x835D060", VA = "0x18835E060")]
		public int TYFASCZFCGO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x835D2C0", Offset = "0x835C2C0", VA = "0x18835D2C0")]
		public int HIJDWUMTIEI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x835DE50", Offset = "0x835CE50", VA = "0x18835DE50")]
		public void RHCIKAONDGT(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x835DC90", Offset = "0x835CC90", VA = "0x18835DC90")]
		public void RHCIKAONDGT(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x835DD70", Offset = "0x835CD70", VA = "0x18835DD70")]
		public void RHCIKAONDGT(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x835D7A0", Offset = "0x835C7A0", VA = "0x18835D7A0")]
		private void NHNTLQOHTGS(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x835DA30", Offset = "0x835CA30", VA = "0x18835DA30")]
		public void PMGAJXEQXEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x835CE10", Offset = "0x835BE10", VA = "0x18835CE10")]
		public void GXVUIAVFJUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x835C950", Offset = "0x835B950", VA = "0x18835C950")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x835CC80", Offset = "0x835BC80", VA = "0x18835CC80")]
		public void FWOWVQOEBTZ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x835EDB0", Offset = "0x835DDB0", VA = "0x18835EDB0")]
		public Guid XKIZGULWLKO()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x835EC30", Offset = "0x835DC30", VA = "0x18835EC30")]
		public void WKLFXVWVKSS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x835E5D0", Offset = "0x835D5D0", VA = "0x18835E5D0")]
		public bool UYXLNUQFDAL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x835F040", Offset = "0x835E040", VA = "0x18835F040")]
		public void ZZJBQWLZECH(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x835D9B0", Offset = "0x835C9B0", VA = "0x18835D9B0")]
		public int PGNMPXXZMFK(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x835D600", Offset = "0x835C600", VA = "0x18835D600")]
		public void LDIJHHYNWDC(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x835E4D0", Offset = "0x835D4D0", VA = "0x18835E4D0")]
		public void UYJEFDKBUDA(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x835CC00", Offset = "0x835BC00", VA = "0x18835CC00")]
		public byte FAOGFZJFLMN(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x835DEA0", Offset = "0x835CEA0", VA = "0x18835DEA0")]
		public uint SDTAPXNUEVR(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x835C8F0", Offset = "0x835B8F0", VA = "0x18835C8F0")]
		public void CZVOEPMXJOQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x835D350", Offset = "0x835C350", VA = "0x18835D350")]
		public void HNRREZOHOMJ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x835D640", Offset = "0x835C640", VA = "0x18835D640")]
		public int LMKWINCYDFT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x835E570", Offset = "0x835D570", VA = "0x18835E570")]
		public long UYQEGBHINUC()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x734E660", Offset = "0x734D660", VA = "0x18734E660")]
		private static uint TEHYRCJHSYY(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x732BD90", Offset = "0x732AD90", VA = "0x18732BD90")]
		private static int MELGNWCBGWA(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x835EEA0", Offset = "0x835DEA0", VA = "0x18835EEA0")]
		private static ulong ZDLXRVZKOIH(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x835E080", Offset = "0x835D080", VA = "0x18835E080")]
		private static long UAYGJFQZMRR(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x835E050", Offset = "0x835D050", VA = "0x18835E050")]
		public void TNURYUYSMQH(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x835EC60", Offset = "0x835DC60", VA = "0x18835EC60")]
		public void WNZFNIWFBWI(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x835D470", Offset = "0x835C470", VA = "0x18835D470")]
		public uint JICBGQBZFAE()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x835D3C0", Offset = "0x835C3C0", VA = "0x18835D3C0")]
		public ulong IMGGZPAOZQV()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x835E6E0", Offset = "0x835D6E0", VA = "0x18835E6E0")]
		public void VPLFWORLSAC(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x835EF90", Offset = "0x835DF90", VA = "0x18835EF90")]
		public float ZWQWOJSHNOP(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x835E090", Offset = "0x835D090", VA = "0x18835E090")]
		private void UDACLBCFXPA(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x835E970", Offset = "0x835D970", VA = "0x18835E970")]
		public void VPVCXWEAXIU(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x835D870", Offset = "0x835C870", VA = "0x18835D870")]
		public float OIAKSNUTFHN(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x835EBD0", Offset = "0x835DBD0", VA = "0x18835EBD0")]
		private void VZJVHAQTQLO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x835E330", Offset = "0x835D330", VA = "0x18835E330")]
		public void UFCXWVLGCAA(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x835D6A0", Offset = "0x835C6A0", VA = "0x18835D6A0")]
		public float MJYJQFYWPML(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x835E5F0", Offset = "0x835D5F0", VA = "0x18835E5F0")]
		private void VGTYCNAMBRW(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x835EEB0", Offset = "0x835DEB0", VA = "0x18835EEB0")]
		public void ZSBEQDSYAFI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x835D620", Offset = "0x835C620", VA = "0x18835D620")]
		public float LHXSCUSLJGB()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x835EED0", Offset = "0x835DED0", VA = "0x18835EED0")]
		public void ZTNOXTUFWKP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x835CE90", Offset = "0x835BE90", VA = "0x18835CE90")]
		public string GYKQTAEDUEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x34DBAD0", Offset = "0x34DAAD0", VA = "0x1834DBAD0")]
		public void LJPDJTXLXVQ<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x34DBE60", Offset = "0x34DAE60", VA = "0x1834DBE60")]
		public List<c> TCWMCMYZZIH<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x835E170", Offset = "0x835D170", VA = "0x18835E170")]
		public void UEESTKLCXEG(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x835D480", Offset = "0x835C480", VA = "0x18835D480")]
		public Span<byte> KFLRIVVQLKP()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x835D080", Offset = "0x835C080", VA = "0x18835D080")]
		public void HBKBXDUIIFM(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x835DF20", Offset = "0x835CF20", VA = "0x18835DF20")]
		public void SHSXEHRKRJU(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x835CA30", Offset = "0x835BA30", VA = "0x18835CA30")]
		public uint EYYYKBCGMAP(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x835DA40", Offset = "0x835CA40", VA = "0x18835DA40")]
		private void PSVDOAVCZKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x835C5D0", Offset = "0x835B5D0", VA = "0x18835C5D0")]
		private void AMUPWTQSTNH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class QNAUUZNXUNY
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
		[Cpp2IlInjected.Address(RVA = "0x835F870", Offset = "0x835E870", VA = "0x18835F870")]
		public static void GPZUBVAFFIS(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x835F3E0", Offset = "0x835E3E0", VA = "0x18835F3E0")]
		public static void ARNMITGRVXB(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x835F3A0", Offset = "0x835E3A0", VA = "0x18835F3A0")]
		public static ViewId AFUULGYSPNV(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x835F650", Offset = "0x835E650", VA = "0x18835F650")]
		public static PartialViewId DAQIKMLWJVW(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x835F880", Offset = "0x835E880", VA = "0x18835F880")]
		private static bool NKMUQGOOXZP(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x835FBC0", Offset = "0x835EBC0", VA = "0x18835FBC0")]
		private static PartialViewId RNNHFXIEGDE(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x835F9E0", Offset = "0x835E9E0", VA = "0x18835F9E0")]
		private static bool PMAUEJBXNCI(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x835FD30", Offset = "0x835ED30", VA = "0x18835FD30")]
		private static ViewId RQUMPERWRST(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83600C0", Offset = "0x835F0C0", VA = "0x1883600C0")]
		private static bool ZQZEHTKMODX(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x835FF20", Offset = "0x835EF20", VA = "0x18835FF20")]
		private static ViewId ZLUXNYOHBUW(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class DGHPPGNBWRT : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds OYHYNIISIPD;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x835F290", Offset = "0x835E290", VA = "0x18835F290")]
		public DGHPPGNBWRT(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ZJUJKPZQKET
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float WENZMLDBQUD;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 YQFDNILXUBB;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 QZCAMCGKLDH;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds OYHYNIISIPD;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83608D0", Offset = "0x835F8D0", VA = "0x1883608D0")]
		public static void EUHZKJLFKQC(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8360B20", Offset = "0x835FB20", VA = "0x188360B20")]
		public static Quaternion FXQTFDRWQQL(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8360DB0", Offset = "0x835FDB0", VA = "0x188360DB0")]
		public static void HCOBPKCYEZX(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8361EE0", Offset = "0x8360EE0", VA = "0x188361EE0")]
		public static Vector3 XBWYIWUTXNQ(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8360450", Offset = "0x835F450", VA = "0x188360450")]
		public static void AXWWSDXEHJP(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83619C0", Offset = "0x83609C0", VA = "0x1883619C0")]
		public static Vector3 USGSWTCDJYM(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8360330", Offset = "0x835F330", VA = "0x188360330")]
		public static void AXWWSDXEHJP(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8361890", Offset = "0x8360890", VA = "0x188361890")]
		public static Vector3 USGSWTCDJYM(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8361100", Offset = "0x8360100", VA = "0x188361100")]
		private static void ODEFUENSULS(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83605F0", Offset = "0x835F5F0", VA = "0x1883605F0")]
		private static Vector3 CMTUCXAOEUR(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83611F0", Offset = "0x83601F0", VA = "0x1883611F0")]
		public static void OXLLLKCSUBO(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8360EC0", Offset = "0x835FEC0", VA = "0x188360EC0")]
		public static Quaternion IAYCHAWTEMV(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8361360", Offset = "0x8360360", VA = "0x188361360")]
		public static void RUNFYLXAXBK(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x83611C0", Offset = "0x83601C0", VA = "0x1883611C0")]
		public static float ODTGOFQEBGT(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x83606D0", Offset = "0x835F6D0", VA = "0x1883606D0")]
		public static void EKHJIHXHHDP(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8361520", Offset = "0x8360520", VA = "0x188361520")]
		public static Vector3 UKDOSCWBLUQ(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8361D30", Offset = "0x8360D30", VA = "0x188361D30")]
		public static void VNCHPIDWEUR(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8361390", Offset = "0x8360390", VA = "0x188361390")]
		public static Vector3 SCSZMTGEKSI(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x83610A0", Offset = "0x83600A0", VA = "0x1883610A0")]
		public static void LNYSOKCICSI(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x83614A0", Offset = "0x83604A0", VA = "0x1883614A0")]
		public static Vector3 SSTUJMHTQEH(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8360FF0", Offset = "0x835FFF0", VA = "0x188360FF0")]
		public static void IMGBWZNFRQK(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8361FD0", Offset = "0x8360FD0", VA = "0x188361FD0")]
		public static Vector3 YZFXGSHODGZ(this BitPacker a, float b, float c, int d = 8)
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
