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
		[Cpp2IlInjected.Address(RVA = "0x97175C0", Offset = "0x9715FC0", VA = "0x1897175C0", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int QMBXFMTBMJB = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int GELDBJKMFYJ = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int EVIHFCRLAIE = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] CEDQSORRBPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string RDUWUDOUXCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream HLPZONXAPSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool NROORYJEBAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> JWZWLJNYGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int ODBTFAUYTZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int SRNIFKOQJCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] OFBRTFZTPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int NRWRWCSLVTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int OAMQJEOEQPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int ISHGPJLISJQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool IMACAOMGSWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x165E770", Offset = "0x165D170", VA = "0x18165E770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x97151E0", Offset = "0x9713BE0", VA = "0x1897151E0")]
		public static int FLZPFVLTMPN(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9716180", Offset = "0x9714B80", VA = "0x189716180")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9717560", Offset = "0x9715F60", VA = "0x189717560")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9715170", Offset = "0x9713B70", VA = "0x189715170", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x97165D0", Offset = "0x9714FD0", VA = "0x1897165D0")]
		public void QJMRYRACNGC(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9715D50", Offset = "0x9714750", VA = "0x189715D50")]
		private void JHMREXIGGLJ([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x97155D0", Offset = "0x9713FD0", VA = "0x1897155D0")]
		public int GXBIXLKTWAA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x97155B0", Offset = "0x9713FB0", VA = "0x1897155B0")]
		public int GXBIXLKTWAA([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9714950", Offset = "0x9713350", VA = "0x189714950")]
		public int ACTVRAWSXGZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9715000", Offset = "0x9713A00", VA = "0x189715000")]
		public int DMECXFXGZXJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9714A80", Offset = "0x9713480", VA = "0x189714A80")]
		public void BVCGRRGSAWW(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9714AD0", Offset = "0x97134D0", VA = "0x189714AD0")]
		public void BVCGRRGSAWW(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x97149A0", Offset = "0x97133A0", VA = "0x1897149A0")]
		public void BVCGRRGSAWW(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9717130", Offset = "0x9715B30", VA = "0x189717130")]
		private void UYMXBLBZWUX(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9714990", Offset = "0x9713390", VA = "0x189714990")]
		public void BSZGNQKEAKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9715A00", Offset = "0x9714400", VA = "0x189715A00")]
		public void HTCUGTKMJCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9714F70", Offset = "0x9713970", VA = "0x189714F70")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9714E20", Offset = "0x9713820", VA = "0x189714E20")]
		public void CWABBKBDSTS(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9715300", Offset = "0x9713D00", VA = "0x189715300")]
		public Guid FUJYTNDAZLF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9716AE0", Offset = "0x97154E0", VA = "0x189716AE0")]
		public void SOHSBIPQYWF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9714970", Offset = "0x9713370", VA = "0x189714970")]
		public bool AZIQPIIKJEG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9716E00", Offset = "0x9715800", VA = "0x189716E00")]
		public void UNJOXADQNBU(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9715610", Offset = "0x9714010", VA = "0x189715610")]
		public int HITQVXUIVAL(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x97155F0", Offset = "0x9713FF0", VA = "0x1897155F0")]
		public void HHKUVERYKOH(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x97160E0", Offset = "0x9714AE0", VA = "0x1897160E0")]
		public void MNUONSKDASJ(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x97153F0", Offset = "0x9713DF0", VA = "0x1897153F0")]
		public byte FVGXJXOJVLK(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9717390", Offset = "0x9715D90", VA = "0x189717390")]
		public uint XSXWXKWRWSO(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9715550", Offset = "0x9713F50", VA = "0x189715550")]
		public void GOPCJHOXWYD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9715F80", Offset = "0x9714980", VA = "0x189715F80")]
		public void LTIZTSRZSKQ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9717410", Offset = "0x9715E10", VA = "0x189717410")]
		public int ZNTXMCFFCCA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9715CF0", Offset = "0x97146F0", VA = "0x189715CF0")]
		public long JHAUNRQLFSF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86C1770", Offset = "0x86C0170", VA = "0x1886C1770")]
		private static uint SLNEJUSUMOB(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x869E880", Offset = "0x869D280", VA = "0x18869E880")]
		private static int VMHIQVMEVHP(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9715E30", Offset = "0x9714830", VA = "0x189715E30")]
		private static ulong KNKBKJARJFQ(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x97165C0", Offset = "0x9714FC0", VA = "0x1897165C0")]
		private static long POTMUDZGXLA(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9715E20", Offset = "0x9714820", VA = "0x189715E20")]
		public void JUTOCITKTKW(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9716B10", Offset = "0x9715510", VA = "0x189716B10")]
		public void UEPQSHZREWX(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9716780", Offset = "0x9715180", VA = "0x189716780")]
		public uint QPJYEHXWBDB()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9714BB0", Offset = "0x97135B0", VA = "0x189714BB0")]
		public ulong BXFGBZOIWAM()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9716EA0", Offset = "0x97158A0", VA = "0x189716EA0")]
		public void UUXNXDMGYNH(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9716840", Offset = "0x9715240", VA = "0x189716840")]
		public float RWHHNENRFCG(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9715090", Offset = "0x9713A90", VA = "0x189715090")]
		private void DZBAGVHRSAT(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9717200", Offset = "0x9715C00", VA = "0x189717200")]
		public void WMSSODYXFEJ(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9715E40", Offset = "0x9714840", VA = "0x189715E40")]
		public float KVPNHBDVQSI(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x97152A0", Offset = "0x9713CA0", VA = "0x1897152A0")]
		private void FTPXBWBRPRJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9716C60", Offset = "0x9715660", VA = "0x189716C60")]
		public void UJBWZVEDFZT(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x97166A0", Offset = "0x97150A0", VA = "0x1897166A0")]
		public float QKAHXGQLZGM(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9715FF0", Offset = "0x97149F0", VA = "0x189715FF0")]
		private void MDISUDAQVJJ(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9714FE0", Offset = "0x97139E0", VA = "0x189714FE0")]
		public void DJTOMBXHJAP(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9715470", Offset = "0x9713E70", VA = "0x189715470")]
		public float GFWQYPUNISS()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9715490", Offset = "0x9713E90", VA = "0x189715490")]
		public void GGIJYDDSQHW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x97168F0", Offset = "0x97152F0", VA = "0x1897168F0")]
		public string SARWKHTQHVR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37C98E0", Offset = "0x37C82E0", VA = "0x1837C98E0")]
		public void ZOCLZKLCWCR<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x37C9480", Offset = "0x37C7E80", VA = "0x1837C9480")]
		public List<c> CMARJVDOIXE<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9714C60", Offset = "0x9713660", VA = "0x189714C60")]
		public void CCGSEVNXCTX(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9716790", Offset = "0x9715190", VA = "0x189716790")]
		public Span<byte> RJECPIOJMRE()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9715690", Offset = "0x9714090", VA = "0x189715690")]
		public void HJSKHERHKNT(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x97158D0", Offset = "0x97142D0", VA = "0x1897158D0")]
		public void HKQFVFCCHMZ(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x97161A0", Offset = "0x9714BA0", VA = "0x1897161A0")]
		public uint NENUTDQVJEK(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9716370", Offset = "0x9714D70", VA = "0x189716370")]
		private void OBVSYFPJAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9715A80", Offset = "0x9714480", VA = "0x189715A80")]
		private void INWPQFSVJPY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class BBAWXSXJZEJ
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
		[Cpp2IlInjected.Address(RVA = "0x9714410", Offset = "0x9712E10", VA = "0x189714410")]
		public static void RGMSRIHZHEF(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x97141A0", Offset = "0x9712BA0", VA = "0x1897141A0")]
		public static void PPLOUUASFZU(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9714160", Offset = "0x9712B60", VA = "0x189714160")]
		public static ViewId KRVYXFXZFXA(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9714420", Offset = "0x9712E20", VA = "0x189714420")]
		public static PartialViewId RJDUKPBNAKT(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9713BA0", Offset = "0x97125A0", VA = "0x189713BA0")]
		private static bool APDFHXQAWAO(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9714640", Offset = "0x9713040", VA = "0x189714640")]
		private static PartialViewId RSMDOCWCLWD(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x97139C0", Offset = "0x97123C0", VA = "0x1897139C0")]
		private static bool AACZFJPHGFF(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9713D00", Offset = "0x9712700", VA = "0x189713D00")]
		private static ViewId BXKHHDNSULI(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9713EF0", Offset = "0x97128F0", VA = "0x189713EF0")]
		private static bool DBPIVHFUCEO(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x97147B0", Offset = "0x97131B0", VA = "0x1897147B0")]
		private static ViewId UJYHVOJIENJ(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class TPPDIYTVAKY : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds SPBGTCNNQTE;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x97176C0", Offset = "0x97160C0", VA = "0x1897176C0")]
		public TPPDIYTVAKY(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ZTYLACSAJIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float AXKYWCNLPHO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 YDVFWBRFCOQ;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 PMCJWJAXYIQ;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds SPBGTCNNQTE;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x97192A0", Offset = "0x9717CA0", VA = "0x1897192A0")]
		public static void ZVLHTNCTRRD(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x97188A0", Offset = "0x97172A0", VA = "0x1897188A0")]
		public static Quaternion MPPERLBVEPI(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9718790", Offset = "0x9717190", VA = "0x189718790")]
		public static void LXMQJTTIZGE(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9718580", Offset = "0x9716F80", VA = "0x189718580")]
		public static Vector3 JQFQPLJFSIN(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9718100", Offset = "0x9716B00", VA = "0x189718100")]
		public static void FUKSSJBWALY(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9717D90", Offset = "0x9716790", VA = "0x189717D90")]
		public static Vector3 DWQJONDUNQF(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x97182A0", Offset = "0x9716CA0", VA = "0x1897182A0")]
		public static void FUKSSJBWALY(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9717C60", Offset = "0x9716660", VA = "0x189717C60")]
		public static Vector3 DWQJONDUNQF(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9717BA0", Offset = "0x97165A0", VA = "0x189717BA0")]
		private static void CTOVRJSWROL(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9718680", Offset = "0x9717080", VA = "0x189718680")]
		private static Vector3 JUGAVRRKOCA(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9717750", Offset = "0x9716150", VA = "0x189717750")]
		public static void AOYHUPONEZR(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9718EA0", Offset = "0x97178A0", VA = "0x189718EA0")]
		public static Quaternion SRCJTBDQXUA(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9719190", Offset = "0x9717B90", VA = "0x189719190")]
		public static void WHFXSKQOUHP(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9718760", Offset = "0x9717160", VA = "0x189718760")]
		public static float KLGFSKUPAGY(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x97178C0", Offset = "0x97162C0", VA = "0x1897178C0")]
		public static void BMSNIPJOWKK(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9718B30", Offset = "0x9717530", VA = "0x189718B30")]
		public static Vector3 QORFFAHSMAN(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x97183C0", Offset = "0x9716DC0", VA = "0x1897183C0")]
		public static void HMQWKBULSWC(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9718FD0", Offset = "0x97179D0", VA = "0x189718FD0")]
		public static Vector3 THQGXVVRFLT(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9719240", Offset = "0x9717C40", VA = "0x189719240")]
		public static void ZQZXRFSWOXP(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x97191C0", Offset = "0x9717BC0", VA = "0x1897191C0")]
		public static Vector3 XEXKQPAJMAA(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x97190E0", Offset = "0x9717AE0", VA = "0x1897190E0")]
		public static void UTHFLPTINWH(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9717AC0", Offset = "0x97164C0", VA = "0x189717AC0")]
		public static Vector3 BWMHALZQANA(this BitPacker a, float b, float c, int d = 8)
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
