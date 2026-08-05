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
		[Cpp2IlInjected.Address(RVA = "0x814B4E0", Offset = "0x814A8E0", VA = "0x18814B4E0", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int MVFGKXMBJJF = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int UXRRNUNKVOV = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int HKNEEVJTAVK = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] GEEBLWZIDNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string WGMVTHSHJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private StreamBuffer HVRLZMVWVQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Stream WVCYRDRSGKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool RNAXVARTMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Memory<byte> HHUGYHOGCLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int QBBKQHTALAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int DTMIEQTTBLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly byte[] OIEYIHBKGZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int PHWZXJGWXFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int BNAXBFJPCLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int MFVBARLLROC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool RAXLUEGOKJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD03F00", Offset = "0xD03300", VA = "0x180D03F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x814A270", Offset = "0x8149670", VA = "0x18814A270")]
		public static int WXEIONGMKWP(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8149340", Offset = "0x8148740", VA = "0x188149340")]
		public static uint KMUMGTTMPGJ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x814A4F0", Offset = "0x81498F0", VA = "0x18814A4F0")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8147D00", Offset = "0x8147100", VA = "0x188147D00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x814A3D0", Offset = "0x81497D0", VA = "0x18814A3D0")]
		public void ZYFBQEXJAXM(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x814A390", Offset = "0x8149790", VA = "0x18814A390")]
		public void ZYFBQEXJAXM(StreamBuffer a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81491B0", Offset = "0x81485B0", VA = "0x1881491B0")]
		private void JTSENASXBBR([Optional] StreamBuffer a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x814A370", Offset = "0x8149770", VA = "0x18814A370")]
		public int XSKCIMTFBJS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x814A350", Offset = "0x8149750", VA = "0x18814A350")]
		public int XSKCIMTFBJS([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8147CE0", Offset = "0x81470E0", VA = "0x188147CE0")]
		public int DNTCXQDQZSR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8149040", Offset = "0x8148440", VA = "0x188149040")]
		public int JAJIEJUTJZF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8148B90", Offset = "0x8147F90", VA = "0x188148B90")]
		public void IIHWBHIOUAK(StreamBuffer a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8148BE0", Offset = "0x8147FE0", VA = "0x188148BE0")]
		public void IIHWBHIOUAK(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8148CD0", Offset = "0x81480D0", VA = "0x188148CD0")]
		public void IIHWBHIOUAK(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8147B70", Offset = "0x8146F70", VA = "0x188147B70")]
		private void BWKPMWDZCDJ(int a, [Optional] StreamBuffer b, [Optional] Memory<byte>? c, [Optional] Stream d, [Optional] object e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81486C0", Offset = "0x8147AC0", VA = "0x1881486C0")]
		public void GYTJUDJLDXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8149B40", Offset = "0x8148F40", VA = "0x188149B40")]
		public void SUXNSYBCWCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8147C50", Offset = "0x8147050", VA = "0x188147C50")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8148DC0", Offset = "0x81481C0", VA = "0x188148DC0")]
		public void IOMNRVRZNTO(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8147A80", Offset = "0x8146E80", VA = "0x188147A80")]
		public Guid BPPUOLRYPZZ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x814A320", Offset = "0x8149720", VA = "0x18814A320")]
		public void WYBRVQTXYZX(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8149850", Offset = "0x8148C50", VA = "0x188149850")]
		public bool MQJJNRDCLBU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8148810", Offset = "0x8147C10", VA = "0x188148810")]
		public void HTNXQRWXZXC(sbyte a, sbyte b, sbyte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8148020", Offset = "0x8147420", VA = "0x188148020")]
		public void FBPGBDIVLTI(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8149360", Offset = "0x8148760", VA = "0x188149360")]
		public sbyte KYRDWXXJSIN(sbyte a, sbyte b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8148640", Offset = "0x8147A40", VA = "0x188148640")]
		public int GSLRLHEALFJ(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8147A50", Offset = "0x8146E50", VA = "0x188147A50")]
		public void BLEKFKOXARR(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8149AA0", Offset = "0x8148EA0", VA = "0x188149AA0")]
		public void RWREQMRGSZL(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8149970", Offset = "0x8148D70", VA = "0x188149970")]
		public byte ORYMSJMTMGY(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8149890", Offset = "0x8148C90", VA = "0x188149890")]
		public uint NBXHZPZHXHQ(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8149910", Offset = "0x8148D10", VA = "0x188149910")]
		public void OKNMJQVXKSH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x814A0B0", Offset = "0x81494B0", VA = "0x18814A0B0")]
		public void WCUSPQYKFPS(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x81497F0", Offset = "0x8148BF0", VA = "0x1881497F0")]
		public int MODTBCSLHMQ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8148250", Offset = "0x8147650", VA = "0x188148250")]
		public long FVZJKRBUEOB()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x70CC7F0", Offset = "0x70CBBF0", VA = "0x1870CC7F0")]
		private static uint LIWNMQPAQOZ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x70A9F20", Offset = "0x70A9320", VA = "0x1870A9F20")]
		private static int RQJVJDLIJAN(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8147CD0", Offset = "0x81470D0", VA = "0x188147CD0")]
		private static ulong DKTKNEWXNGO(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x81497E0", Offset = "0x8148BE0", VA = "0x1881497E0")]
		private static long MMHLJLKRHBE(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8147D80", Offset = "0x8147180", VA = "0x188147D80")]
		public void EKKERCAMQZU(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x814A120", Offset = "0x8149520", VA = "0x18814A120")]
		public void WWCARDWKMEL(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8147A70", Offset = "0x8146E70", VA = "0x188147A70")]
		public uint BOFDWRCBTFV()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8149290", Offset = "0x8148690", VA = "0x188149290")]
		public ulong JWIVXNPZPYY()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8149C30", Offset = "0x8149030", VA = "0x188149C30")]
		public void VBTLFUTDXXH(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x81499F0", Offset = "0x8148DF0", VA = "0x1881499F0")]
		public float OYDPSLAXAVE(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81477D0", Offset = "0x8146BD0", VA = "0x1881477D0")]
		private void BAGJGKEJTHR(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81480C0", Offset = "0x81474C0", VA = "0x1881480C0")]
		public void FLGNZGKGELH(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81486D0", Offset = "0x8147AD0", VA = "0x1881486D0")]
		public float GZHANNHPCUE(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8149BD0", Offset = "0x8148FD0", VA = "0x188149BD0")]
		private void VBJDBSXDEUP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x81478B0", Offset = "0x8146CB0", VA = "0x1881478B0")]
		public void BBTRQGTMIGV(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8148830", Offset = "0x8147C30", VA = "0x188148830")]
		public float HXNJNMIBFXK(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81482B0", Offset = "0x81476B0", VA = "0x1881482B0")]
		private void GFWCTAUAEZV(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8149870", Offset = "0x8148C70", VA = "0x188149870")]
		public void MWHNBKSCLHR(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8149190", Offset = "0x8148590", VA = "0x188149190")]
		public float JLIXAAAPWKC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8147F60", Offset = "0x8147360", VA = "0x188147F60")]
		public void EPWFMYEBYWQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8149EC0", Offset = "0x81492C0", VA = "0x188149EC0")]
		public string WBYJXZJWBNR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x34119F0", Offset = "0x3410DF0", VA = "0x1834119F0")]
		public void LFHHJGVHKCB<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3411590", Offset = "0x3410990", VA = "0x183411590")]
		public List<c> FGWJYPBWSHE<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81493E0", Offset = "0x81487E0", VA = "0x1881493E0")]
		public void LIYTUEPQCTH(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x81490E0", Offset = "0x81484E0", VA = "0x1881490E0")]
		public Span<byte> JDTUABOHNXM()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x81495A0", Offset = "0x81489A0", VA = "0x1881495A0")]
		public void LJGGLJUZYDH(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8148F10", Offset = "0x8148310", VA = "0x188148F10")]
		public void IPOYCKHTVYJ(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8147D90", Offset = "0x8147190", VA = "0x188147D90")]
		public uint EKWARVHMZLE(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8148910", Offset = "0x8147D10", VA = "0x188148910")]
		private void IGLPXEVGQGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x81483A0", Offset = "0x81477A0", VA = "0x1881483A0")]
		private void GRIKCQDOPFE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class LRRYBNVJCQV
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private enum CompressionType : uint
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			Reference,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			Basic,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			Range,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			Full
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x814AB50", Offset = "0x8149F50", VA = "0x18814AB50")]
		public static void MFGPSADESFP(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x814A6C0", Offset = "0x8149AC0", VA = "0x18814A6C0")]
		public static void HKNKHCHFAQC(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x814AB10", Offset = "0x8149F10", VA = "0x18814AB10")]
		public static ViewId LSGHAKOWXOS(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x814B2C0", Offset = "0x814A6C0", VA = "0x18814B2C0")]
		public static PartialViewId YVWJXOKUWLR(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x814AB60", Offset = "0x8149F60", VA = "0x18814AB60")]
		private static bool NDENAIZIYDQ(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x814A550", Offset = "0x8149950", VA = "0x18814A550")]
		private static PartialViewId CYDZRGBREBB(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x814A930", Offset = "0x8149D30", VA = "0x18814A930")]
		private static bool HPBEISNBASD(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x814B0D0", Offset = "0x814A4D0", VA = "0x18814B0D0")]
		private static ViewId STYBDYXJEXA(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x814ACC0", Offset = "0x814A0C0", VA = "0x18814ACC0")]
		private static bool NPLTFERGKBU(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x814AF30", Offset = "0x814A330", VA = "0x18814AF30")]
		private static ViewId RNLHHOSKGFZ(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class RYHNHQCDIJK : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Bounds AWULBMHPCZY;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x814B5D0", Offset = "0x814A9D0", VA = "0x18814B5D0")]
		public RYHNHQCDIJK(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class XPVVNXVKCLA
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly float KXJAJTKJQMA;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 TRMJUUUNVUA;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Vector3 BYLSBVTPDPG;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly Bounds AWULBMHPCZY;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x814D0B0", Offset = "0x814C4B0", VA = "0x18814D0B0")]
		public static void XHHDACENOXL(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x814CBE0", Offset = "0x814BFE0", VA = "0x18814CBE0")]
		public static Quaternion VCZSRTLILLE(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x814B660", Offset = "0x814AA60", VA = "0x18814B660")]
		public static void AFMMWCQSQKI(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x814BC80", Offset = "0x814B080", VA = "0x18814BC80")]
		public static Vector3 ECERRZURTMZ(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x814B9C0", Offset = "0x814ADC0", VA = "0x18814B9C0")]
		public static void DEJCNVUGTYC(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x814BEA0", Offset = "0x814B2A0", VA = "0x18814BEA0")]
		public static Vector3 EYGGTWDONHX(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x814BB60", Offset = "0x814AF60", VA = "0x18814BB60")]
		public static void DEJCNVUGTYC(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x814BD70", Offset = "0x814B170", VA = "0x18814BD70")]
		public static Vector3 EYGGTWDONHX(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x814C450", Offset = "0x814B850", VA = "0x18814C450")]
		private static void JSZIJUULNIH(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x814D300", Offset = "0x814C700", VA = "0x18814D300")]
		private static Vector3 ZXLDOHLDRKU(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x814B770", Offset = "0x814AB70", VA = "0x18814B770")]
		public static void BRITZXUAULN(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x814CE70", Offset = "0x814C270", VA = "0x18814CE70")]
		public static Quaternion VVEJASPEQHW(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x814C930", Offset = "0x814BD30", VA = "0x18814C930")]
		public static void PBQIRPECTRX(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x814C420", Offset = "0x814B820", VA = "0x18814C420")]
		public static float JDQNHIOUCKI(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x814C960", Offset = "0x814BD60", VA = "0x18814C960")]
		public static void SBBIPYDGQPI(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x814C5C0", Offset = "0x814B9C0", VA = "0x18814C5C0")]
		public static Vector3 MKNBDQBHWQF(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x814C210", Offset = "0x814B610", VA = "0x18814C210")]
		public static void HZKFEYXAJIC(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x814CFA0", Offset = "0x814C3A0", VA = "0x18814CFA0")]
		public static Vector3 WEVYJKYLRKF(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x814C3C0", Offset = "0x814B7C0", VA = "0x18814C3C0")]
		public static void IHBIUUFOJAB(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x814CB60", Offset = "0x814BF60", VA = "0x18814CB60")]
		public static Vector3 UAHNBHZYBCI(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x814C510", Offset = "0x814B910", VA = "0x18814C510")]
		public static void KSREUUCTWJV(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x814B8E0", Offset = "0x814ACE0", VA = "0x18814B8E0")]
		public static Vector3 BSVJZYXIXWC(this BitPacker a, float b, float c, int d = 8)
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
