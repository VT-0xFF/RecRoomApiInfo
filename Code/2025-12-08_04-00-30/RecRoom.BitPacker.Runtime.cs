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
		[Cpp2IlInjected.Address(RVA = "0x810A290", Offset = "0x8108A90", VA = "0x18810A290", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int ZEMXNTKZHME = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int ZQEBHRWNBEW = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int CAXURVRVWQX = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] EUVSYYKVHVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string KARCCLSLYBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream QWGJKTCCGUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool UVTYIVMAQRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> OXZAQMYQHWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int IQYNEEPJVUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int UHHRZRYJZQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] RHJVKJRQWUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int DRJXVWHLQPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int NWWIMFARHRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int QAAZYQFDHVH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool UQNMBOLUBON
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x1342640", Offset = "0x1340E40", VA = "0x181342640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8105190", Offset = "0x8103990", VA = "0x188105190")]
		public static int JACBXFIAZDM(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8105590", Offset = "0x8103D90", VA = "0x188105590")]
		public static uint NJXLXGWWXEE(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81073E0", Offset = "0x8105BE0", VA = "0x1881073E0")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8104B10", Offset = "0x8103310", VA = "0x188104B10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8105F70", Offset = "0x8104770", VA = "0x188105F70")]
		public void UDXEFUOQHKD(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8105630", Offset = "0x8103E30", VA = "0x188105630")]
		private void OPIADAPQRDQ([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8106D20", Offset = "0x8105520", VA = "0x188106D20")]
		public int YYJXUSLEBUX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8106D00", Offset = "0x8105500", VA = "0x188106D00")]
		public int YYJXUSLEBUX([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8104AF0", Offset = "0x81032F0", VA = "0x188104AF0")]
		public int DXPBQEFUTUK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81057B0", Offset = "0x8103FB0", VA = "0x1881057B0")]
		public int PTRETVOPAWY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81069A0", Offset = "0x81051A0", VA = "0x1881069A0")]
		public void YKVVPIBVQPB(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8106AD0", Offset = "0x81052D0", VA = "0x188106AD0")]
		public void YKVVPIBVQPB(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x81069F0", Offset = "0x81051F0", VA = "0x1881069F0")]
		public void YKVVPIBVQPB(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8105BA0", Offset = "0x81043A0", VA = "0x188105BA0")]
		private void RBCKRUIALPE(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8105F60", Offset = "0x8104760", VA = "0x188105F60")]
		public void UDHLSDBHDHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8104EC0", Offset = "0x81036C0", VA = "0x188104EC0")]
		public void IMNNXXEEACE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8104A80", Offset = "0x8103280", VA = "0x188104A80")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8106BB0", Offset = "0x81053B0", VA = "0x188106BB0")]
		public void YOGRSICFVLF(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8105E40", Offset = "0x8104640", VA = "0x188105E40")]
		public Guid TEQSOGYGJTA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8105F30", Offset = "0x8104730", VA = "0x188105F30")]
		public void TRFNXRMVMVQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8105720", Offset = "0x8103F20", VA = "0x188105720")]
		public bool OTVJPCMAWMD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8106630", Offset = "0x8104E30", VA = "0x188106630")]
		public void XDHIHZPEKDB(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8104B80", Offset = "0x8103380", VA = "0x188104B80")]
		public int EADCIDQEEXC(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8106610", Offset = "0x8104E10", VA = "0x188106610")]
		public void XAADUUTADMY(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81047F0", Offset = "0x8102FF0", VA = "0x1881047F0")]
		public void AECKCFSEZKS(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81070E0", Offset = "0x81058E0", VA = "0x1881070E0")]
		public byte ZHRRQYZLOCB(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81055B0", Offset = "0x8103DB0", VA = "0x1881055B0")]
		public uint OEOMEZFSJRZ(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x81066D0", Offset = "0x8104ED0", VA = "0x1881066D0")]
		public void XHNAGXNNKPG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8105740", Offset = "0x8103F40", VA = "0x188105740")]
		public void OWKQJHDJPHT(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8104A20", Offset = "0x8103220", VA = "0x188104A20")]
		public int CVHEUGEGXCF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8106940", Offset = "0x8105140", VA = "0x188106940")]
		public long YJSHKQSMRQW()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7119A60", Offset = "0x7118260", VA = "0x187119A60")]
		private static uint MIFPIXLLLXS(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x70F7160", Offset = "0x70F5960", VA = "0x1870F7160")]
		private static int STNUOMCHAFG(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8106040", Offset = "0x8104840", VA = "0x188106040")]
		private static ulong UESPEHAJRTJ(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8106D40", Offset = "0x8105540", VA = "0x188106D40")]
		private static long YZEGFOFDLNR(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x81054A0", Offset = "0x8103CA0", VA = "0x1881054A0")]
		public void MWAHFKSNJRV(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x81067F0", Offset = "0x8104FF0", VA = "0x1881067F0")]
		public void YHALSSQREEM(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8106730", Offset = "0x8104F30", VA = "0x188106730")]
		public uint XJOVLTQBDIA()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8105D90", Offset = "0x8104590", VA = "0x188105D90")]
		public ulong SUUWGZDQIXP()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8106190", Offset = "0x8104990", VA = "0x188106190")]
		public void WJDEVWQIWKS(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8106740", Offset = "0x8104F40", VA = "0x188106740")]
		public float YGKEOSSRJPR(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8104DE0", Offset = "0x81035E0", VA = "0x188104DE0")]
		private void GEJBMELQMMO(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8104890", Offset = "0x8103090", VA = "0x188104890")]
		public void AQVPXBQCXLC(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8106050", Offset = "0x8104850", VA = "0x188106050")]
		public float VUNSDUJBWPF(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8105C70", Offset = "0x8104470", VA = "0x188105C70")]
		private void SCNCGTBEFSY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8107160", Offset = "0x8105960", VA = "0x188107160")]
		public void ZJTUWBCPZDC(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81054B0", Offset = "0x8103CB0", VA = "0x1881054B0")]
		public float MZCIIMCXLYP(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8105840", Offset = "0x8104040", VA = "0x188105840")]
		private void PWIVTPDXSUA(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8105240", Offset = "0x8103A40", VA = "0x188105240")]
		public void KEEAPRJQHXE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8105700", Offset = "0x8103F00", VA = "0x188105700")]
		public float ORBLIDSIZEJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8105CD0", Offset = "0x81044D0", VA = "0x188105CD0")]
		public void SUFCNMFQCSL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8106420", Offset = "0x8104C20", VA = "0x188106420")]
		public string WPIQFNJPLYO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x344AA90", Offset = "0x3449290", VA = "0x18344AA90")]
		public void BCZTVSTQJGC<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x344AE30", Offset = "0x3449630", VA = "0x18344AE30")]
		public List<c> QQJXUNEPPNJ<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8106D50", Offset = "0x8105550", VA = "0x188106D50")]
		public void ZDDZVARRETI(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8104D30", Offset = "0x8103530", VA = "0x188104D30")]
		public Span<byte> FAJBJDPXKBZ()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8105260", Offset = "0x8103A60", VA = "0x188105260")]
		public void KODPYHBLTIO(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8104C00", Offset = "0x8103400", VA = "0x188104C00")]
		public void EJHBEAVLRFY(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8106F10", Offset = "0x8105710", VA = "0x188106F10")]
		public uint ZEMGQYPHRDJ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8104F40", Offset = "0x8103740", VA = "0x188104F40")]
		private void IPCPIFUYJTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8105930", Offset = "0x8104130", VA = "0x188105930")]
		private void QDXTEMXJFJL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class HPIRPYENCDY
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
		[Cpp2IlInjected.Address(RVA = "0x8109EB0", Offset = "0x81086B0", VA = "0x188109EB0")]
		public static void JCODHSIUKJI(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8109300", Offset = "0x8107B00", VA = "0x188109300")]
		public static void AAXVWRXHGHB(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x810A060", Offset = "0x8108860", VA = "0x18810A060")]
		public static ViewId MXOVBPZIPSP(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8109C90", Offset = "0x8108490", VA = "0x188109C90")]
		public static PartialViewId HTIWJOKVAPS(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8109B30", Offset = "0x8108330", VA = "0x188109B30")]
		private static bool HGXCJVOOCAR(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8109570", Offset = "0x8107D70", VA = "0x188109570")]
		private static PartialViewId EMOGSHKYEOS(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8109950", Offset = "0x8108150", VA = "0x188109950")]
		private static bool GAFCMHPRWYM(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x810A0A0", Offset = "0x81088A0", VA = "0x18810A0A0")]
		private static ViewId OYPJALAQPWX(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x81096E0", Offset = "0x8107EE0", VA = "0x1881096E0")]
		private static bool EZXNGVUWRLH(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8109EC0", Offset = "0x81086C0", VA = "0x188109EC0")]
		private static ViewId LSBWDGHBPSO(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class VXNOYJGVJXP : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds SDYITFSGKPX;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x810A380", Offset = "0x8108B80", VA = "0x18810A380")]
		public VXNOYJGVJXP(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class GEOCXFUHXOX
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float APJEHHQBHMT;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 KHKCPWEMATZ;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 WCUUIJAVWBD;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds SDYITFSGKPX;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8108C30", Offset = "0x8107430", VA = "0x188108C30")]
		public static void VYCKNGCQAUG(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8107C20", Offset = "0x8106420", VA = "0x188107C20")]
		public static Quaternion NJLEPHULHBZ(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8107B10", Offset = "0x8106310", VA = "0x188107B10")]
		public static void NCKECMMBJCV(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8107730", Offset = "0x8105F30", VA = "0x188107730")]
		public static Vector3 HJLDBQVLYTE(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8107970", Offset = "0x8106170", VA = "0x188107970")]
		public static void LEYBWJNVMNX(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8108170", Offset = "0x8106970", VA = "0x188108170")]
		public static Vector3 TZVRLEDTFFW(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8107850", Offset = "0x8106050", VA = "0x188107850")]
		public static void LEYBWJNVMNX(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x81084E0", Offset = "0x8106CE0", VA = "0x1881084E0")]
		public static Vector3 TZVRLEDTFFW(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8109100", Offset = "0x8107900", VA = "0x188109100")]
		private static void ZOCZPSMOTYI(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8107650", Offset = "0x8105E50", VA = "0x188107650")]
		private static Vector3 DZAIXRQDRWF(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8108AC0", Offset = "0x81072C0", VA = "0x188108AC0")]
		public static void VIKLYBOIPZG(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8107F60", Offset = "0x8106760", VA = "0x188107F60")]
		public static Quaternion QQEMAWXWXUF(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8107820", Offset = "0x8106020", VA = "0x188107820")]
		public static void IJGSCDTYPUQ(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8108720", Offset = "0x8106F20", VA = "0x188108720")]
		public static float UOHUENVDWPB(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8108E80", Offset = "0x8107680", VA = "0x188108E80")]
		public static void WMODXOLHXTD(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8108750", Offset = "0x8106F50", VA = "0x188108750")]
		public static Vector3 URUOQVQRVSQ(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x81074A0", Offset = "0x8105CA0", VA = "0x1881074A0")]
		public static void DPBKILGGDIJ(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8108610", Offset = "0x8106E10", VA = "0x188108610")]
		public static Vector3 UERTXAAOHYU(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8107440", Offset = "0x8105C40", VA = "0x188107440")]
		public static void BFCMQAIBBGY(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8109080", Offset = "0x8107880", VA = "0x188109080")]
		public static Vector3 ZNFACKVRCJJ(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8107EB0", Offset = "0x81066B0", VA = "0x188107EB0")]
		public static void PFDJXWZNTLY(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8108090", Offset = "0x8106890", VA = "0x188108090")]
		public static Vector3 SUSEOJDZXDD(this BitPacker a, float b, float c, int d = 8)
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
