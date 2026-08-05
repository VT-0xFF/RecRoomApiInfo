using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
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
		[Cpp2IlInjected.Address(RVA = "0x88AE5D0", Offset = "0x88AD1D0", VA = "0x1888AE5D0", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public uint AsUInt;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public float AsFloat;
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class TPHUAHWUYJW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public float NAYXTZCDTXN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public float FGNPFNDJFFD;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public TPHUAHWUYJW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x88AF6F0", Offset = "0x88AE2F0", VA = "0x1888AF6F0")]
			internal object OSQBSPUFALO((string contextName, float value, float minimum, float maximum, int integerBits, int fractionalBits) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int RMMZVDVGJZI = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int FYTZWECXXWM = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int HTOTSYVJJPT = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] MDDFQHWUPIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string VMVLOZVNEYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private StreamBuffer QZNPGPVAFDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Stream TQEPMXGEUGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool RZZEJSIPKRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Memory<byte> ECHOXEISYYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int KBFFEIASEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int QCXPZCIZGSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly byte[] NGPQXANHNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int TQNCXDLRTIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int IDGOJUMLPYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int TXOZHCFJCZF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool PJLEPPRGIDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xDD47D0", Offset = "0xDD33D0", VA = "0x180DD47D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88AC090", Offset = "0x88AAC90", VA = "0x1888AC090")]
		public static int WHXNANEGSXK(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88AAE60", Offset = "0x88A9A60", VA = "0x1888AAE60")]
		public static uint JKZJRLVIHNY(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88AC680", Offset = "0x88AB280", VA = "0x1888AC680")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88AA1B0", Offset = "0x88A8DB0", VA = "0x1888AA1B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88ABC60", Offset = "0x88AA860", VA = "0x1888ABC60")]
		public void QFNJDSGBMRD(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88ABCA0", Offset = "0x88AA8A0", VA = "0x1888ABCA0")]
		public void QFNJDSGBMRD(StreamBuffer a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88AAC90", Offset = "0x88A9890", VA = "0x1888AAC90")]
		private void HNDCGUDXUAY([Optional] StreamBuffer a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x88ABC20", Offset = "0x88AA820", VA = "0x1888ABC20")]
		public int PLJQOORHXSJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88ABC40", Offset = "0x88AA840", VA = "0x1888ABC40")]
		public int PLJQOORHXSJ([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88AC4D0", Offset = "0x88AB0D0", VA = "0x1888AC4D0")]
		public int ZHCHRWVAPGQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88AA920", Offset = "0x88A9520", VA = "0x1888AA920")]
		public int GGLAWDZBTLE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88A9B50", Offset = "0x88A8750", VA = "0x1888A9B50")]
		public void CWOQAZKLSSR(StreamBuffer a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x88A9BA0", Offset = "0x88A87A0", VA = "0x1888A9BA0")]
		public void CWOQAZKLSSR(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88A9A60", Offset = "0x88A8660", VA = "0x1888A9A60")]
		public void CWOQAZKLSSR(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88AC150", Offset = "0x88AAD50", VA = "0x1888AC150")]
		private void WZTVQLQDNTG(int a, [Optional] StreamBuffer b, [Optional] Memory<byte>? c, [Optional] Stream d, [Optional] object e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88AAD70", Offset = "0x88A9970", VA = "0x1888AAD70")]
		public void HYWKZIVXHHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x88AA890", Offset = "0x88A9490", VA = "0x1888AA890")]
		public void FZWXYRUDQPY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x88A9C90", Offset = "0x88A8890", VA = "0x1888A9C90")]
		public void UYBLZELGVMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x88A9C90", Offset = "0x88A8890", VA = "0x1888A9C90")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88AB500", Offset = "0x88AA100", VA = "0x1888AB500")]
		public void OCFUXGIYMAR(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x88AB8F0", Offset = "0x88AA4F0", VA = "0x1888AB8F0")]
		public Guid OQVLDBIOIEE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88AAAF0", Offset = "0x88A96F0", VA = "0x1888AAAF0")]
		public void GWQRHFABUDO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88AB2A0", Offset = "0x88A9EA0", VA = "0x1888AB2A0")]
		public bool MMLHWOGTCUF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x88AAFE0", Offset = "0x88A9BE0", VA = "0x1888AAFE0")]
		public void KFMGTRUBBPF(sbyte a, sbyte b, sbyte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x88ABF60", Offset = "0x88AAB60", VA = "0x1888ABF60")]
		public void TUHBYBQLIUV(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x88ABCE0", Offset = "0x88AA8E0", VA = "0x1888ABCE0")]
		public sbyte QKIVAXDGRAU(sbyte a, sbyte b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88A97A0", Offset = "0x88A83A0", VA = "0x1888A97A0")]
		public int ARXIRJDBKPI(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88AC070", Offset = "0x88AAC70", VA = "0x1888AC070")]
		public void WCCJJWNTXAC(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88AC4F0", Offset = "0x88AB0F0", VA = "0x1888AC4F0")]
		public void ZZIHCAMNNDK(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88AB420", Offset = "0x88AA020", VA = "0x1888AB420")]
		public byte NRUWZNHPIIX(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x88A99E0", Offset = "0x88A85E0", VA = "0x1888A99E0")]
		public uint CEWJVSWFETL(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x88AB9E0", Offset = "0x88AA5E0", VA = "0x1888AB9E0")]
		public void OVGZEUIVLDE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88AC000", Offset = "0x88AAC00", VA = "0x1888AC000")]
		public void UCEGYAJBZSL(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x88AB4A0", Offset = "0x88AA0A0", VA = "0x1888AB4A0")]
		public int OBXTNUPACRN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88AC230", Offset = "0x88AAE30", VA = "0x1888AC230")]
		public long XAMXXMWYUJO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x786CAE0", Offset = "0x786B6E0", VA = "0x18786CAE0")]
		private static uint LJKHLWSILMO(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7849F10", Offset = "0x7848B10", VA = "0x187849F10")]
		private static int FPLGJXVDLXA(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x88ABD60", Offset = "0x88AA960", VA = "0x1888ABD60")]
		private static ulong ROFRNXTPLBP(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88AB280", Offset = "0x88A9E80", VA = "0x1888AB280")]
		private static long LNUDVQJQVMZ(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88AAE80", Offset = "0x88A9A80", VA = "0x1888AAE80")]
		public void JLHTQBJFZNL(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x88AAE90", Offset = "0x88A9A90", VA = "0x1888AAE90")]
		public void JRFYPEZDQDQ(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x88AB290", Offset = "0x88A9E90", VA = "0x1888AB290")]
		public uint LTMXNYRZALM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x88AB370", Offset = "0x88A9F70", VA = "0x1888AB370")]
		public ulong NEJOWUHBFAD()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88AA670", Offset = "0x88A9270", VA = "0x1888AA670")]
		public void FMXUMGTYZCI(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x88AB2C0", Offset = "0x88A9EC0", VA = "0x1888AB2C0")]
		public float MYYSDFBNWJT(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x88AB650", Offset = "0x88AA250", VA = "0x1888AB650")]
		private void ODHJVAPVIRC(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88AAB20", Offset = "0x88A9720", VA = "0x1888AAB20")]
		public void GYJIBGLQAJY(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x88A98E0", Offset = "0x88A84E0", VA = "0x1888A98E0")]
		public float BZAYQLUKVUV(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x88A9D10", Offset = "0x88A8910", VA = "0x1888A9D10")]
		private void DYUXOGOHQZE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88AA250", Offset = "0x88A8E50", VA = "0x1888AA250")]
		public void ESRBFIACMWS(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88AAD80", Offset = "0x88A9980", VA = "0x1888AAD80")]
		public float JBZPAZYRGVT(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88A9390", Offset = "0x88A7F90", VA = "0x1888A9390")]
		private void ARQRDVXEBVE(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88AA230", Offset = "0x88A8E30", VA = "0x1888AA230")]
		public void EMXFBJHNZJS(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA40", Offset = "0x88AA640", VA = "0x1888ABA40")]
		public float OVRGLLILZJJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88A9820", Offset = "0x88A8420", VA = "0x1888A9820")]
		public void BBZLMTFLKZT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x88ABD70", Offset = "0x88AA970", VA = "0x1888ABD70")]
		public string SGYIHNXQSAQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x399DB30", Offset = "0x399C730", VA = "0x18399DB30")]
		public void PJBVKMIIYIE<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x399D6D0", Offset = "0x399C2D0", VA = "0x18399D6D0")]
		public List<c> MMTJRICHTMV<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA60", Offset = "0x88AA660", VA = "0x1888ABA60")]
		public void PHNDHOGMBFO(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88AB1D0", Offset = "0x88A9DD0", VA = "0x1888AB1D0")]
		public Span<byte> LGWVVGOSBMF()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88AC290", Offset = "0x88AAE90", VA = "0x1888AC290")]
		public void YGPJTMEGLSE(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88AA9C0", Offset = "0x88A95C0", VA = "0x1888AA9C0")]
		public void GJEVKKTAJVW(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x88AB000", Offset = "0x88A9C00", VA = "0x1888AB000")]
		public uint KSKAMGXVJUF(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x88AA3F0", Offset = "0x88A8FF0", VA = "0x1888AA3F0")]
		private void FGKGJNRGMQD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x88A9F10", Offset = "0x88A8B10", VA = "0x1888A9F10")]
		private void DZABHONXWQH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class NQGIWDPWRPO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private enum CompressionType : uint
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			Reference,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			Basic,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			Range,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			Full
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x88AF5D0", Offset = "0x88AE1D0", VA = "0x1888AF5D0")]
		public static void YLUPKWOXVOY(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x88AF360", Offset = "0x88ADF60", VA = "0x1888AF360")]
		public static void XMBCKDOEILP(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x88AE650", Offset = "0x88AD250", VA = "0x1888AE650")]
		public static ViewId CLDCJGCSGMV(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x88AE9A0", Offset = "0x88AD5A0", VA = "0x1888AE9A0")]
		public static PartialViewId OWHLMZVSCXQ(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x88AF200", Offset = "0x88ADE00", VA = "0x1888AF200")]
		private static bool VJOHDSKJOAL(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x88AE830", Offset = "0x88AD430", VA = "0x1888AE830")]
		private static PartialViewId HIHBQGNGWGQ(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x88AEE30", Offset = "0x88ADA30", VA = "0x1888AEE30")]
		private static bool TSSBDWGBWWK(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x88AF010", Offset = "0x88ADC10", VA = "0x1888AF010")]
		private static ViewId UVKHXVMVXDL(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x88AEBC0", Offset = "0x88AD7C0", VA = "0x1888AEBC0")]
		private static bool TICYFHHRPDJ(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x88AE690", Offset = "0x88AD290", VA = "0x1888AE690")]
		private static ViewId ECKRVRLIMWA(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class QAPTNLHMCQP : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly Bounds QNKOYEXDKTR;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x88AF660", Offset = "0x88AE260", VA = "0x1888AF660")]
		public QAPTNLHMCQP(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public static class JHLYDTMNNYN
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly float MQIORPYQRSJ;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		internal static readonly Vector3 RGAYUWWYMZT;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		internal static readonly Vector3 KPIDJEKTURF;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly Bounds QNKOYEXDKTR;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x88ADEC0", Offset = "0x88ACAC0", VA = "0x1888ADEC0")]
		public static void SXWQDYOZSRK(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x88AE110", Offset = "0x88ACD10", VA = "0x1888AE110")]
		public static Quaternion VSSZEZWVLWN(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x88ACB80", Offset = "0x88AB780", VA = "0x1888ACB80")]
		public static void DWEQUFQGORJ(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x88ACC90", Offset = "0x88AB890", VA = "0x1888ACC90")]
		public static Vector3 EIJZWLALWGE(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x88AD330", Offset = "0x88ABF30", VA = "0x1888AD330")]
		public static void ICJAOWAVQYX(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x88AC6E0", Offset = "0x88AB2E0", VA = "0x1888AC6E0")]
		public static Vector3 DDVQVCKUOVA(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x88AD210", Offset = "0x88ABE10", VA = "0x1888AD210")]
		public static void ICJAOWAVQYX(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x88ACA50", Offset = "0x88AB650", VA = "0x1888ACA50")]
		public static Vector3 DDVQVCKUOVA(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x88ADDA0", Offset = "0x88AC9A0", VA = "0x1888ADDA0")]
		private static void SGVCMQDIXFY(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x88ADA20", Offset = "0x88AC620", VA = "0x1888ADA20")]
		private static Vector3 QCWDOFUNMFN(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x88ADB00", Offset = "0x88AC700", VA = "0x1888ADB00")]
		public static void RSGEXZXISJI(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x88ADC70", Offset = "0x88AC870", VA = "0x1888ADC70")]
		public static Quaternion SCDRKQURKSL(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x88AE3A0", Offset = "0x88ACFA0", VA = "0x1888AE3A0")]
		public static void WGSNJPPSEHA(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x88AD770", Offset = "0x88AC370", VA = "0x1888AD770")]
		public static float KYSJWHZJDEV(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x88AD7A0", Offset = "0x88AC3A0", VA = "0x1888AD7A0")]
		public static void LPCZBYGEWPJ(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x88ACEA0", Offset = "0x88ABAA0", VA = "0x1888ACEA0")]
		public static Vector3 GJYMBAOVXTQ(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x88AD4D0", Offset = "0x88AC0D0", VA = "0x1888AD4D0")]
		public static void JMMWXJTTFYD(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x88ACD90", Offset = "0x88AB990", VA = "0x1888ACD90")]
		public static Vector3 GBNXBDQPUOO(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x88ADE60", Offset = "0x88ACA60", VA = "0x1888ADE60")]
		public static void SKPTVKJLIAO(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x88AD9A0", Offset = "0x88AC5A0", VA = "0x1888AD9A0")]
		public static Vector3 OYBTIIFGGWN(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x88AE3D0", Offset = "0x88ACFD0", VA = "0x1888AE3D0")]
		public static void YSTYIBFTJLO(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x88AD690", Offset = "0x88AC290", VA = "0x1888AD690")]
		public static Vector3 JUDITZPHPUH(this BitPacker a, float b, float c, int d = 8)
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
