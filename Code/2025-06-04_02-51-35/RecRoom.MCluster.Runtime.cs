using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
using RecRoom.MCluster;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_MCluster_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8012D00", Offset = "0x8011500", VA = "0x188012D00", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public struct ICJHILFFPOO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] IKJNKNAFAEK;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] EIBKFJHIAIC;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] ELCJKHBDEGI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1F60400", Offset = "0x1F5EC00", VA = "0x181F60400")]
	public static int EDHFJBGEDFI(EONMBNAKAHK GBIENHEIENE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8010A80", Offset = "0x800F280", VA = "0x188010A80")]
	public static int IACHKKIOMBL(EONMBNAKAHK GBIENHEIENE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MCMGPMJJBFH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int IMLHELCLAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JDJECDMPGGG PCNFLGHIEEK(int MBAOJAPNLMO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 DJNHGKFEPKL(int MBAOJAPNLMO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HOAIPFDEDJB DMLLPLAIBOP();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FLBFCIJJHNF CNPPEIODOFN();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LIFKLOAJLAI : CKBOCOJEGMJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private HOAIPFDEDJB KCODNJGBFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform CGFDFONAGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<EHBJHMIIJBM> BABPAFIPPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private NPHGJFHFHME JLBNGFCJDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private ENGACKHJFOE PELINLGHNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool IMHPHBBMPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MCMGPMJJBFH BIPGFOOJDJJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float NMOJPDKJLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC860C0", Offset = "0xC848C0", VA = "0x180C860C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC85A80", Offset = "0xC84280", VA = "0x180C85A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GLLEIOMJAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC9B990", Offset = "0xC9A190", VA = "0x180C9B990")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD98160", Offset = "0xD96960", VA = "0x180D98160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LLNIDLAPIID
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xE06130", Offset = "0xE04930", VA = "0x180E06130")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xE04960", Offset = "0xE03160", VA = "0x180E04960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool ALIOKCOAJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1F62EC0", Offset = "0x1F616C0", VA = "0x181F62EC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1F62550", Offset = "0x1F60D50", VA = "0x181F62550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DBEBLPHAJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x202C790", Offset = "0x202AF90", VA = "0x18202C790", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x8012530", Offset = "0x8010D30", VA = "0x188012530")]
	public LIFKLOAJLAI(MCMGPMJJBFH NGABBABGLLA, bool BPJJBHHNMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x80112E0", Offset = "0x800FAE0", VA = "0x1880112E0")]
	private bool BOKNEKEAPFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8011510", Offset = "0x800FD10", VA = "0x188011510", Slot = "4")]
	public bool GGGBGBDKNKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8012360", Offset = "0x8010B60", VA = "0x188012360", Slot = "5")]
	public bool JNHFKCNMNLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8012140", Offset = "0x8010940", VA = "0x188012140", Slot = "6")]
	public void HKOLMKDGPPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8011500", Offset = "0x800FD00", VA = "0x188011500", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FDCDOKPPGAO
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDLHLPLIFGK(CommandBuffer CAGFFDPMGEA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct OHPKDDFGGJA : FDCDOKPPGAO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int FIOOAILODJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier IKEIPNLMNGG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x524BA40", Offset = "0x524A240", VA = "0x18524BA40")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x80152B0", Offset = "0x8013AB0", VA = "0x1880152B0")]
	public OHPKDDFGGJA(int EBHOIBHGECB, RenderTargetIdentifier IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8015260", Offset = "0x8013A60", VA = "0x188015260", Slot = "4")]
	public void JDLHLPLIFGK(CommandBuffer CAGFFDPMGEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct BPAGFNNOLOO : FDCDOKPPGAO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int FIOOAILODJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] CDMPFBJKNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xE2A210", Offset = "0xE28A10", VA = "0x180E2A210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x175B230", Offset = "0x1759A30", VA = "0x18175B230")]
	public BPAGFNNOLOO(int EBHOIBHGECB, Vector4[] IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8005800", Offset = "0x8004000", VA = "0x188005800", Slot = "4")]
	public void JDLHLPLIFGK(CommandBuffer CAGFFDPMGEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct DBGGMEKGKCG : FDCDOKPPGAO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int FIOOAILODJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] HBCHBJFGALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xE2A210", Offset = "0xE28A10", VA = "0x180E2A210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x175B230", Offset = "0x1759A30", VA = "0x18175B230")]
	public DBGGMEKGKCG(int EBHOIBHGECB, float[] IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8005DB0", Offset = "0x80045B0", VA = "0x188005DB0", Slot = "4")]
	public void JDLHLPLIFGK(CommandBuffer CAGFFDPMGEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HJKOALIDOPH : FDCDOKPPGAO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xDB8D70", Offset = "0xDB7570", VA = "0x180DB8D70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool BLNLFGEBLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xDB8C20", Offset = "0xDB7420", VA = "0x180DB8C20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x18D8EE0", Offset = "0x18D76E0", VA = "0x1818D8EE0")]
	public HJKOALIDOPH(string HPANEBBHGAC, bool EMMOENAPJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x80108B0", Offset = "0x800F0B0", VA = "0x1880108B0", Slot = "4")]
	public void JDLHLPLIFGK(CommandBuffer CAGFFDPMGEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct FLBFCIJJHNF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 NNNDNNKFBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1125530", Offset = "0x1123D30", VA = "0x181125530")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 JBMNDMPLOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HGHDDFAFCIO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int PKJLNBNFFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7F0", Offset = "0xA8CFF0", VA = "0x180A8E7F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float DFONBCFLLNH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xF047C0", Offset = "0xF02FC0", VA = "0x180F047C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8008AF0", Offset = "0x80072F0", VA = "0x188008AF0")]
	public FLBFCIJJHNF(Color BIKIHAKPCIG, int OPCLBPEBBAA, int BEIKFCEAAEK, float JBAMMJAPHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x11A5480", Offset = "0x11A3C80", VA = "0x1811A5480")]
	private static float4 PGLJFAONOMC(Color BIKIHAKPCIG)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8008A60", Offset = "0x8007260", VA = "0x188008A60")]
	private static Hash128 AKCLJLNPLKE(FLBFCIJJHNF NGABBABGLLA)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NPHGJFHFHME : CKBOCOJEGMJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string IJMOMAHNGNC;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string KHDCMGHCKIL;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string FEBKLOBAHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private FLBFCIJJHNF GNLIJKONJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private KLNEFDOHGAN IPKNLMFNGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 EJGIAKIEPDB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ENGACKHJFOE ACICIADAKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA50730", Offset = "0xA4EF30", VA = "0x180A50730")]
		[CompilerGenerated]
		get
		{
			return default(ENGACKHJFOE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x13E94D0", Offset = "0x13E7CD0", VA = "0x1813E94D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool GLLEIOMJAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1155EA0", Offset = "0x11546A0", VA = "0x181155EA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6DBD440", Offset = "0x6DBBC40", VA = "0x186DBD440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LLNIDLAPIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x27C9E50", Offset = "0x27C8650", VA = "0x1827C9E50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F0C0", Offset = "0x7F6D8C0", VA = "0x187F6F0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool DBEBLPHAJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool ALIOKCOAJKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7CB0", Offset = "0x6EE64B0", VA = "0x186EE7CB0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8014CF0", Offset = "0x80134F0", VA = "0x188014CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int PJLMPJGAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8014CA0", Offset = "0x80134A0", VA = "0x188014CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8015220", Offset = "0x8013A20", VA = "0x188015220")]
	public NPHGJFHFHME(FLBFCIJJHNF ENFFOMMHILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8014BA0", Offset = "0x80133A0", VA = "0x188014BA0")]
	private bool BOKNEKEAPFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8014D00", Offset = "0x8013500", VA = "0x188014D00", Slot = "4")]
	public bool GGGBGBDKNKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8015100", Offset = "0x8013900", VA = "0x188015100")]
	private static KLNEFDOHGAN ODPOHHDKCLH(FLBFCIJJHNF NGABBABGLLA)
	{
		return default(KLNEFDOHGAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8014F50", Offset = "0x8013750", VA = "0x188014F50", Slot = "5")]
	public bool JNHFKCNMNLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8014E50", Offset = "0x8013650", VA = "0x188014E50", Slot = "6")]
	public void HKOLMKDGPPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "9")]
	public void Dispose()
	{
	}
}
namespace RecRoom.MCluster
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MClusterData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			[Reload("Shaders/ClusterUpdate.compute", ReloadAttribute.Package.Root)]
			public ComputeShader UpdateShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[Reload("Shaders/ClusterRaster.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ClusterRasterShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[Reload("Shaders/ClusterCoarseCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader CoarseCullShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[Reload("Shaders/ClusterFineCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader FineCullShader;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8014030", Offset = "0x8012830", VA = "0x188014030", Slot = "0")]
		public override bool Equals(object KEKEFPAJGHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8014230", Offset = "0x8012A30", VA = "0x188014230", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC33770", Offset = "0xC31F70", VA = "0x180C33770")]
		public MClusterData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleRendererFeature(null)]
	public class MClusterRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private HBOGMCDOMHE opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static GMMPOACKBOK CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8014A30", Offset = "0x8013230", VA = "0x188014A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8014A80", Offset = "0x8013280", VA = "0x188014A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8014310", Offset = "0x8012B10", VA = "0x188014310", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x80142E0", Offset = "0x8012AE0", VA = "0x1880142E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FKGIDFBJGGD, RenderingData HJEINGEGIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x80147E0", Offset = "0x8012FE0", VA = "0x1880147E0")]
		public void GKPOAOGDFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1767B30", Offset = "0x1766330", VA = "0x181767B30")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JBIPLODNJLM<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private PMMBLBNFPGL PJBCMPDGMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private PMMBLBNFPGL CKHEDDAEEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private ComputeBuffer CMHHLNCNMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private RenderTexture GGDPMJKNKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int EMGJIBECHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int POFAJDMFIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string AGDJCMOKODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private string NPINOEKODKK;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA30050", Offset = "0xA2E850", VA = "0x180A30050")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int ACKFKFEFKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA69AA0", Offset = "0xA682A0", VA = "0x180A69AA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int MKJEEMLAPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA46F30", Offset = "0xA45730", VA = "0x180A46F30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x508B680", Offset = "0x5089E80", VA = "0x18508B680")]
	public JBIPLODNJLM(string HPANEBBHGAC, int FLNDHDBFKGH, [Optional] RenderTextureFormat? HKOGDKBPFKC, bool ENFHMMICDAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x50892A0", Offset = "0x5087AA0", VA = "0x1850892A0")]
	public void JNHFKCNMNLI(CommandBuffer CAGFFDPMGEA, NativeArray<ValType> IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5088320", Offset = "0x5086B20", VA = "0x185088320")]
	public void BEIICNIBHBO(CommandBuffer CAGFFDPMGEA, ComputeShader HIGOJLKKHGA, int PDMGJMFKPPJ, int BHAMLDEPMKJ = -1, int CEPMNCDAMDO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x50877E0", Offset = "0x5085FE0", VA = "0x1850877E0")]
	public void BEIICNIBHBO(Material IPKNLMFNGIO, int BHAMLDEPMKJ = -1, int CEPMNCDAMDO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5088A80", Offset = "0x5087280", VA = "0x185088A80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FCHACJFIKOI
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEIICNIBHBO(Material ENFFOMMHILM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CGJDDJFEFGJ<SrcEntry, DstEntry> : FCHACJFIKOI, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected bool[] GNAHOOPGNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected PMMBLBNFPGL DDJCFDPFBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected PMMBLBNFPGL CDCNBJANNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<int> OBEJCAGDOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected NativeArray<SrcEntry> NGEHNIEKJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int LMEFNAEHFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected int GIGJFDILBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected JBIPLODNJLM<int> CHHENNJOGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected JBIPLODNJLM<SrcEntry> NAPLLDKAPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected JBIPLODNJLM<DstEntry> MBJIHFHNNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected ComputeShader AFHBLELFNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int IJDGFGKKION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int NFLDNOELJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int JGBMHOFEPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int CNNDFCJCCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int BNOKNMDKDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int GNDKKKCLEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int PDHHBPKMCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int KPJMAOCMLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int KFPLGHBENFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int IFFLGPEABKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int MLLNAECJKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected int HEOHNFPHLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected string KEJIIJJINJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected float[] FLHKGOMPDBM;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int KCIKODHLHPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x669E5B0", Offset = "0x669CDB0", VA = "0x18669E5B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string OMNOEPOPIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x669CB80", Offset = "0x669B380", VA = "0x18669CB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x669FFB0", Offset = "0x669E7B0", VA = "0x18669FFB0")]
	public CGJDDJFEFGJ(string HPANEBBHGAC, int DIMEPJCMNDN, int LFBILKBMFPK, RenderTextureFormat HKOGDKBPFKC, ComputeShader KOMOKCAOECA, int FICPBLPHOKD = 0, int EKFDBNNHMOB = 0, int OCJDCLCOHNO = 0, int FEPKLNGMLFA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x669E540", Offset = "0x669CD40", VA = "0x18669E540")]
	public int KJNKCHBCIHG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x669C560", Offset = "0x669AD60", VA = "0x18669C560")]
	protected void GPAPDGNEFEJ(int PNJCJGEIDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x669BC40", Offset = "0x669A440", VA = "0x18669BC40")]
	public ENGACKHJFOE GGGBGBDKNKJ(SrcEntry IMINNNCPCJF)
	{
		return default(ENGACKHJFOE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x669DB50", Offset = "0x669C350", VA = "0x18669DB50")]
	public bool JNHFKCNMNLI(ENGACKHJFOE DAMJGGDGMEF, SrcEntry IMINNNCPCJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x669C6B0", Offset = "0x669AEB0", VA = "0x18669C6B0")]
	public bool HKOLMKDGPPH(ENGACKHJFOE DAMJGGDGMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "6")]
	protected virtual void DMPGBMGJOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x669ECA0", Offset = "0x669D4A0", VA = "0x18669ECA0", Slot = "7")]
	public void OGDAGKODMBD(CommandBuffer CAGFFDPMGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x669F070", Offset = "0x669D870", VA = "0x18669F070", Slot = "8")]
	public void OGDAGKODMBD(CommandBuffer CAGFFDPMGEA, ComputeShader KOMOKCAOECA, int FICPBLPHOKD = -1, int EKFDBNNHMOB = -1, int OCJDCLCOHNO = -1, int FEPKLNGMLFA = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x669B270", Offset = "0x6699A70", VA = "0x18669B270", Slot = "9")]
	public void BEIICNIBHBO(CommandBuffer CAGFFDPMGEA, ComputeShader KOMOKCAOECA, int FICPBLPHOKD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x669B200", Offset = "0x6699A00", VA = "0x18669B200", Slot = "4")]
	public void BEIICNIBHBO(Material IPKNLMFNGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x669B420", Offset = "0x6699C20", VA = "0x18669B420", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PMMBLBNFPGL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong BIBMMCMGCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong LKCJMPCAKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HFBGLHEOMGE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct OIHIOGEACKO : PMMBLBNFPGL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private IDisposable IIDHOGPKICC;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong BIBMMCMGCBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xE2A210", Offset = "0xE28A10", VA = "0x180E2A210", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x2A76DE0", Offset = "0x2A755E0", VA = "0x182A76DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong LKCJMPCAKCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8015350", Offset = "0x8013B50", VA = "0x188015350")]
		internal OIHIOGEACKO(IDisposable EIKGKBIFPLB, ulong GMLEHFJOPFF, ulong DDEMMICNKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x80152D0", Offset = "0x8013AD0", VA = "0x1880152D0", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct IDELJDAHIML : PMMBLBNFPGL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private RenderTexture OIIOPEDHLGG;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong BIBMMCMGCBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xE2A210", Offset = "0xE28A10", VA = "0x180E2A210", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2A76DE0", Offset = "0x2A755E0", VA = "0x182A76DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong LKCJMPCAKCI
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x80111D0", Offset = "0x800F9D0", VA = "0x1880111D0")]
		public IDELJDAHIML(RenderTexture AILALHOICPD, ulong ODJKACNOABD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8011130", Offset = "0x800F930", VA = "0x188011130", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong ACJECJKKKGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8010000", Offset = "0x800E800", VA = "0x188010000")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8010040", Offset = "0x800E840", VA = "0x188010040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong BIPNMOCELCG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8010080", Offset = "0x800E880", VA = "0x188010080")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8010870", Offset = "0x800F070", VA = "0x188010870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8010560", Offset = "0x800ED60", VA = "0x188010560")]
	public static ComputeBuffer INHDMBAMCNE(int FMGALNGIOGC, int JBLOMLIDEPI, ComputeBufferType CEPGAJKBPDM, [Out] PMMBLBNFPGL DAMJGGDGMEF, ComputeBufferMode MFMCIMMKBLC = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x80101D0", Offset = "0x800E9D0", VA = "0x1880101D0")]
	public static RenderTexture INHDMBAMCNE(int DMFNFGGJFBG, int GPMLECINMDG, int FODPGBDGFAK, RenderTextureFormat HKOGDKBPFKC, [Out] PMMBLBNFPGL DAMJGGDGMEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x39F4CC0", Offset = "0x39F34C0", VA = "0x1839F4CC0")]
	public static NativeArray<T> BCNPOOPFNLL<T>(NativeArray<T> IIDHOGPKICC, ulong AEPPOMGGPKB, [Out] PMMBLBNFPGL DAMJGGDGMEF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x39F5BC0", Offset = "0x39F43C0", VA = "0x1839F5BC0")]
	public static NativeArray<T> INHDMBAMCNE<T>(int AEPPOMGGPKB, Allocator GFNKGIEEHMD, [Out] PMMBLBNFPGL DAMJGGDGMEF, NativeArrayOptions OJJIDCCJBBN = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8010730", Offset = "0x800EF30", VA = "0x188010730")]
	public static void MMIAFMKGHIE(PMMBLBNFPGL IIDHOGPKICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x80100C0", Offset = "0x800E8C0", VA = "0x1880100C0")]
	public static uint HOJDJOGGOND(RenderTextureFormat HKOGDKBPFKC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FEFDKLMKKHB : CGJDDJFEFGJ<HNDFHKPLCDI, HNDFHKPLCDI>
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct ACDMFJAHPAK : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<int> DHMBCLFIBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[ReadOnly]
		private NativeArray<float> JICAIOEOLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4x4> FMKDBGMJEAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[WriteOnly]
		private NativeArray<float4> IFMAIINOFDK;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x80057D0", Offset = "0x8003FD0", VA = "0x1880057D0")]
		public ACDMFJAHPAK(NativeArray<int> AHHLECCJODI, NativeArray<float> IFEHHPLMIKL, NativeArray<float4x4> ODMBDMIMFOF, NativeArray<float4> CPNFKJGECEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8005610", Offset = "0x8003E10", VA = "0x188005610", Slot = "4")]
		public void Execute(int PNJCJGEIDHG, TransformAccess KCODNJGBFEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[BurstCompile]
	public struct DDLLGHPGOIB : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<int> DHMBCLFIBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4x4> FOKGPEDALKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[ReadOnly]
		private NativeArray<float4> NDCBHLOLGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[WriteOnly]
		private NativeArray<HNDFHKPLCDI> ANFFGEGDAKM;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x80057D0", Offset = "0x8003FD0", VA = "0x1880057D0")]
		public DDLLGHPGOIB(NativeArray<int> AHHLECCJODI, NativeArray<float4x4> JDDMOHAAIAA, NativeArray<float4> PIEGNPICCNK, NativeArray<HNDFHKPLCDI> NMNMOFPMJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8005E90", Offset = "0x8004690", VA = "0x188005E90", Slot = "4")]
		public void Execute(int PNJCJGEIDHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private const byte GCGCEIDNHCF = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private TransformAccessArray PKDDGKFBIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> NEDGGPFNKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4x4> DNAHLBIIJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<float4> HPMFLKJKOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> NKAEPAEMFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> GKGNFKNNHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private PMMBLBNFPGL BHIJNEOHGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private PMMBLBNFPGL GOPCKKMKOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private PMMBLBNFPGL PJGIHJAOIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private PMMBLBNFPGL LDFBAINIEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private PMMBLBNFPGL CDMOKJABHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private Transform JPEFOCMEDMC;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8008700", Offset = "0x8006F00", VA = "0x188008700")]
	public FEFDKLMKKHB(int DIMEPJCMNDN, int LFBILKBMFPK, ComputeShader KOMOKCAOECA, int FICPBLPHOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x80080A0", Offset = "0x80068A0", VA = "0x1880080A0", Slot = "6")]
	protected override void DMPGBMGJOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8008640", Offset = "0x8006E40", VA = "0x188008640")]
	private void LONCEKGFDJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8008430", Offset = "0x8006C30", VA = "0x188008430")]
	public bool KKAPAPCBAPN(ENGACKHJFOE DAMJGGDGMEF, Transform KCODNJGBFEK, float LJJIJEBFDGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8008350", Offset = "0x8006B50", VA = "0x188008350")]
	public void GCMMOMAMFPA(ENGACKHJFOE DAMJGGDGMEF, float LJJIJEBFDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8008590", Offset = "0x8006D90", VA = "0x188008590")]
	public void LHDKBJNFLKE(ENGACKHJFOE DAMJGGDGMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x80082B0", Offset = "0x8006AB0", VA = "0x1880082B0", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface JDJECDMPGGG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LFBDKLHLLEO BFIAMMMMINP();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface DDAIHEHCCHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 NNNDNNKFBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int HLNAFGKHLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int KICNGCGAMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> EOALAOOGNLB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> EAOKBEELIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> APDBAIBJBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> MIMBCOEJCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> ILPHACAHDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> IFFBKBCDGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int MPLEMFFBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int IPAKCACLILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int GAOCBGLMHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool ABNFNEOCGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OGDAGKODMBD();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LPDBGAFGOCH : DDAIHEHCCHN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private JDJECDMPGGG IMBEKMCHKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private LFBDKLHLLEO MLCGFPJFGFN;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 NNNDNNKFBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xDC52A0", Offset = "0xDC3AA0", VA = "0x180DC52A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool JAIAHBBDAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D370", Offset = "0xA2BB70", VA = "0x180A2D370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int HLNAFGKHLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7F0", Offset = "0xA8CFF0", VA = "0x180A8E7F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xF60F70", Offset = "0xF5F770", VA = "0x180F60F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int KICNGCGAMCG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA32B90", Offset = "0xA31390", VA = "0x180A32B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int GPKHEHOFCAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x14C02F0", Offset = "0x14BEAF0", VA = "0x1814C02F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> EOALAOOGNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8012990", Offset = "0x8011190", VA = "0x188012990", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> EAOKBEELIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8012B10", Offset = "0x8011310", VA = "0x188012B10", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> APDBAIBJBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8012B40", Offset = "0x8011340", VA = "0x188012B40", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> MIMBCOEJCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8012920", Offset = "0x8011120", VA = "0x188012920", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> ILPHACAHDBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8012A20", Offset = "0x8011220", VA = "0x188012A20", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> IFFBKBCDGBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8012AE0", Offset = "0x80112E0", VA = "0x188012AE0", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ABNFNEOCGHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA56260", Offset = "0xA54A60", VA = "0x180A56260", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA56080", Offset = "0xA54880", VA = "0x180A56080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int MPLEMFFBIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8012B90", Offset = "0x8011390", VA = "0x188012B90", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int IPAKCACLILB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8012A00", Offset = "0x8011200", VA = "0x188012A00", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int GAOCBGLMHHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8012B70", Offset = "0x8011370", VA = "0x188012B70", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8012CB0", Offset = "0x80114B0", VA = "0x188012CB0")]
	public LPDBGAFGOCH(Hash128 CEGOJJNEECN, JDJECDMPGGG IMBEKMCHKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x8012BA0", Offset = "0x80113A0", VA = "0x188012BA0", Slot = "16")]
	public void OGDAGKODMBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x8012A50", Offset = "0x8011250", VA = "0x188012A50", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct ENGACKHJFOE : IEquatable<ENGACKHJFOE>
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly ENGACKHJFOE HBDEBEHCDNA;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int PJLMPJGAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
	public ENGACKHJFOE(int PNJCJGEIDHG = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8007D50", Offset = "0x8006550", VA = "0x188007D50", Slot = "4")]
	public bool Equals(ENGACKHJFOE KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8007C80", Offset = "0x8006480", VA = "0x188007C80", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8007DA0", Offset = "0x80065A0", VA = "0x188007DA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class EHBJHMIIJBM : CKBOCOJEGMJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private bool IMHPHBBMPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private DDAIHEHCCHN AFNAGJGJGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<ENGACKHJFOE> JMFDGAECNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<ENGACKHJFOE> IHIAKOEKBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private List<ENGACKHJFOE> JIHEBOLHMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Dictionary<int, uint> JKLKNHMOIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int GDOBIAAONDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int KIHBHAHLAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int HBHDNHHCDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int FONLLPNFDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private int EGPBOBMLJFL;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int PJLMPJGAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x80061A0", Offset = "0x80049A0", VA = "0x1880061A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8007AD0", Offset = "0x80062D0", VA = "0x188007AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool GLLEIOMJAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9A0", Offset = "0xA9D1A0", VA = "0x180A9E9A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9B0", Offset = "0xA9D1B0", VA = "0x180A9E9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool LLNIDLAPIID
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA9E920", Offset = "0xA9D120", VA = "0x180A9E920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA9E930", Offset = "0xA9D130", VA = "0x180A9E930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool DBEBLPHAJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool ALIOKCOAJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2818FB0", Offset = "0x28177B0", VA = "0x182818FB0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA9E990", Offset = "0xA9D190", VA = "0x180A9E990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float NMOJPDKJLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xF57F10", Offset = "0xF56710", VA = "0x180F57F10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xF57F30", Offset = "0xF56730", VA = "0x180F57F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8007B10", Offset = "0x8006310", VA = "0x188007B10")]
	public EHBJHMIIJBM(DDAIHEHCCHN MLCGFPJFGFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x80075A0", Offset = "0x8005DA0", VA = "0x1880075A0")]
	private void HPOEPHIDFGE(DDAIHEHCCHN MLCGFPJFGFN, int GDOBIAAONDM, int EFCNDNNJFBP, int PNJCJGEIDHG, int GMHFDIAPGEN, OBDBPCHCGIF IMINNNCPCJF, float INFIDOCEOIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8006C90", Offset = "0x8005490", VA = "0x188006C90")]
	private void GKLNOGBCOAB(DDAIHEHCCHN MLCGFPJFGFN, int MAGODFIFDIN, int PNJCJGEIDHG, uint3 DKPJPCAJIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8005F00", Offset = "0x8004700", VA = "0x188005F00")]
	private bool BOKNEKEAPFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x80062B0", Offset = "0x8004AB0", VA = "0x1880062B0", Slot = "4")]
	public bool GGGBGBDKNKJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8007A50", Offset = "0x8006250", VA = "0x188007A50", Slot = "5")]
	public bool JNHFKCNMNLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8006F50", Offset = "0x8005750", VA = "0x188006F50", Slot = "6")]
	public void HKOLMKDGPPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8006250", Offset = "0x8004A50", VA = "0x188006250")]
	public void GCOOMJDMNEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x8006250", Offset = "0x8004A50", VA = "0x188006250", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CKBOCOJEGMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool DBEBLPHAJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool ALIOKCOAJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGGBGBDKNKJ();

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JNHFKCNMNLI();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HKOLMKDGPPH();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MADPALCCGMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly float PMGAIGANENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, EHBJHMIIJBM> OJKOCGIFPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Dictionary<Hash128, NPHGJFHFHME> FKLFINLPENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<CKBOCOJEGMJ> CLCGBDDFIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<CKBOCOJEGMJ> JEBIBFAHGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Queue<CKBOCOJEGMJ> CNDOAPEGNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int JOLLIHNKKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private int NBIGKCBFOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private float MGIAOJDNICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool OAJIMBOMMDN;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool DEIJKCDNOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x178BDF0", Offset = "0x178A5F0", VA = "0x18178BDF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x17A0590", Offset = "0x179ED90", VA = "0x1817A0590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool INDOJKHMPLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8012D90", Offset = "0x8011590", VA = "0x188012D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string OMNOEPOPIHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8012F90", Offset = "0x8011790", VA = "0x188012F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8013900", Offset = "0x8012100", VA = "0x188013900")]
	public void NPKOAIMJPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8013880", Offset = "0x8012080", VA = "0x188013880")]
	public void KHFDEKFAMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8013EA0", Offset = "0x80126A0", VA = "0x188013EA0")]
	public MADPALCCGMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8013470", Offset = "0x8011C70", VA = "0x188013470")]
	public LIFKLOAJLAI KELFLPPCOLM(MCMGPMJJBFH CMJLAOBGHAL, bool BPJJBHHNMBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8013330", Offset = "0x8011B30", VA = "0x188013330")]
	public NPHGJFHFHME KELFLPPCOLM(FLBFCIJJHNF IPKNLMFNGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x8013890", Offset = "0x8012090", VA = "0x188013890")]
	public bool NCCPOPFIDHM(Hash128 EBHOIBHGECB, [Out] EHBJHMIIJBM CCELHJFCCIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x80135A0", Offset = "0x8011DA0", VA = "0x1880135A0")]
	public EHBJHMIIJBM KELFLPPCOLM(DDAIHEHCCHN MLCGFPJFGFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x8012DE0", Offset = "0x80115E0", VA = "0x188012DE0")]
	private void DLHIHOADJBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8012E00", Offset = "0x8011600", VA = "0x188012E00")]
	private bool DMHOHJIPHGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x8013910", Offset = "0x8012110", VA = "0x188013910")]
	public void OGDAGKODMBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8012E80", Offset = "0x8011680", VA = "0x188012E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8013DB0", Offset = "0x80125B0", VA = "0x188013DB0")]
	public void PBPOAHLKNMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GIICADBKGCB : CGJDDJFEFGJ<LLOGLGPADPP, LLOGLGPADPP>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8008C20", Offset = "0x8007420", VA = "0x188008C20")]
	public GIICADBKGCB(int DIMEPJCMNDN, int LFBILKBMFPK, ComputeShader KOMOKCAOECA, int FICPBLPHOKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FCBIHKBEFMI : CGJDDJFEFGJ<KLNEFDOHGAN, KLNEFDOHGAN>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8007FF0", Offset = "0x80067F0", VA = "0x188007FF0")]
	public FCBIHKBEFMI(int DIMEPJCMNDN, int LFBILKBMFPK, ComputeShader KOMOKCAOECA, int FICPBLPHOKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class DCDHKOKKKJD : CGJDDJFEFGJ<OMEEBCLCEEO, OMEEBCLCEEO>
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8005DE0", Offset = "0x80045E0", VA = "0x188005DE0")]
	public DCDHKOKKKJD(int DIMEPJCMNDN, int LFBILKBMFPK, ComputeShader KOMOKCAOECA, int FICPBLPHOKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KJOFEPHBIED : CGJDDJFEFGJ<NJEMHCMOHFC, DCCIEJGBAPK>
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8011200", Offset = "0x800FA00", VA = "0x188011200")]
	public KJOFEPHBIED(int DIMEPJCMNDN, int LFBILKBMFPK, ComputeShader KOMOKCAOECA, int FICPBLPHOKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class NFLKDNJOMMN : CGJDDJFEFGJ<ABPBCEENJPL, ABPBCEENJPL>
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8014AF0", Offset = "0x80132F0", VA = "0x188014AF0")]
	public NFLKDNJOMMN(int DIMEPJCMNDN, int LFBILKBMFPK, ComputeShader KOMOKCAOECA, int FICPBLPHOKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class HBOGMCDOMHE : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private GMMPOACKBOK BOHEANJECCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool EMMOENAPJHM;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public static bool ODFLAEBPMPF;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x800FFC0", Offset = "0x800E7C0", VA = "0x18800FFC0")]
	public HBOGMCDOMHE(GMMPOACKBOK FMOLEIMNODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x800FE30", Offset = "0x800E630", VA = "0x18800FE30", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer CAGFFDPMGEA, RenderingData HJEINGEGIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x800FBC0", Offset = "0x800E3C0", VA = "0x18800FBC0", Slot = "6")]
	public override void Configure(CommandBuffer CAGFFDPMGEA, RenderTextureDescriptor LNGAKLJOIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x800FC00", Offset = "0x800E400", VA = "0x18800FC00", Slot = "9")]
	public override void Execute(ScriptableRenderContext MJAGIMDGJBK, RenderingData HJEINGEGIBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class CJMCAIMNMBG
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public readonly struct EPALGOLOALC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly string HPANEBBHGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CommandBuffer CAGFFDPMGEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly ScriptableRenderContext MJAGIMDGJBK;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8007EE0", Offset = "0x80066E0", VA = "0x188007EE0")]
		public EPALGOLOALC(string GNGOOBOMOEG, ScriptableRenderContext NKLJBKNDIGI, [Out] CommandBuffer DFAJMBKFBLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8007E30", Offset = "0x8006630", VA = "0x188007E30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8005C60", Offset = "0x8004460", VA = "0x188005C60")]
	public static bool IBPPLLGMBLE(RenderingData HJEINGEGIBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8005830", Offset = "0x8004030", VA = "0x188005830")]
	public static void AAAMLJFGAJP(CommandBuffer CAGFFDPMGEA, ScriptableRenderContext MJAGIMDGJBK, ShadowDrawingSettings OIIBNOKOCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8005A00", Offset = "0x8004200", VA = "0x188005A00")]
	public static void CAELKJPGAKE(CommandBuffer CAGFFDPMGEA, ScriptableRenderContext MJAGIMDGJBK, RenderingData HJEINGEGIBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class GMMPOACKBOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class FKMMELGBBOG
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int AGPDICJAJME;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public static readonly int KAMMNKHMLME;
	}

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static JBIPLODNJLM<PGEGDFNFAIE> GAFIJEBMFDM;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static JBIPLODNJLM<uint> JANOJDAAJMO;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static PMMBLBNFPGL INILCCGEGOC;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static ComputeBuffer CPHFOMPJFFL;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static List<FCHACJFIKOI> NCPKAOLNMCH;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int PIONKADKKFO;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int DJJMGBNJFAD;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int ALEHGGJOKDO;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int NCNKOFGEHCA;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static int[] NPFFMONEPFP;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static Material[] OCANAINPCIF;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private static FDCDOKPPGAO[][] CKMHMHFFNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Plane[] LNLAOLLPNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int PPODBJALGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int LOMGGKCFGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int NAGDAOAGOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int PMIDNDJFMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int MOMNNOFNGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int OFIHMPNFLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int PBJJOCKNGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int FKGPMAJJIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int NKDLODGIOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int GBMPDOCCGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int NFICLDCEPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int JAMKKDNPNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int DANJNMFHJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int OPCFHEPFMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int AMMOJHGIEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int OHJLAIDAPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int LMEBPILFMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int GAMDEPBMOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private float[] HFNDACODDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private MADPALCCGMN GDJBKJECOFG;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool CGCIMFOFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x800DE40", Offset = "0x800C640", VA = "0x18800DE40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x800EF30", Offset = "0x800D730", VA = "0x18800EF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool NOGKKPLMKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8009630", Offset = "0x8007E30", VA = "0x188009630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x800F5A0", Offset = "0x800DDA0", VA = "0x18800F5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData KFMKJLCMCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x800F600", Offset = "0x800DE00", VA = "0x18800F600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8009A80", Offset = "0x8008280", VA = "0x188009A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static FEFDKLMKKHB NEMJCJODGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8009B60", Offset = "0x8008360", VA = "0x188009B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8009810", Offset = "0x8008010", VA = "0x188009810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static GIICADBKGCB NMEHFBKFBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x800F7A0", Offset = "0x800DFA0", VA = "0x18800F7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8009AF0", Offset = "0x80082F0", VA = "0x188009AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static FCBIHKBEFMI EJPAOFLMJAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8009680", Offset = "0x8007E80", VA = "0x188009680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8009730", Offset = "0x8007F30", VA = "0x188009730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static DCDHKOKKKJD IKOKPOILDAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x800D910", Offset = "0x800C110", VA = "0x18800D910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x800F650", Offset = "0x800DE50", VA = "0x18800F650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static KJOFEPHBIED KMBBMKEMHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x800EEE0", Offset = "0x800D6E0", VA = "0x18800EEE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x80098F0", Offset = "0x80080F0", VA = "0x1880098F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static NFLKDNJOMMN NGNMOAGMHDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x800D8C0", Offset = "0x800C0C0", VA = "0x18800D8C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8009880", Offset = "0x8008080", VA = "0x188009880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material IKCFMBLHFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x800F550", Offset = "0x800DD50", VA = "0x18800F550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x800F6C0", Offset = "0x800DEC0", VA = "0x18800F6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material BBJPHMAJDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x800DEE0", Offset = "0x800C6E0", VA = "0x18800DEE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x800AEC0", Offset = "0x80096C0", VA = "0x18800AEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material FHMJDDLBDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x800AD90", Offset = "0x8009590", VA = "0x18800AD90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x800DDD0", Offset = "0x800C5D0", VA = "0x18800DDD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material FBBOHNABGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x800DE90", Offset = "0x800C690", VA = "0x18800DE90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x80097A0", Offset = "0x8007FA0", VA = "0x1880097A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool DBDHKNDNGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x800B800", Offset = "0x800A000", VA = "0x18800B800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x800A7F0", Offset = "0x8008FF0", VA = "0x18800A7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool INDOJKHMPLK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x80096D0", Offset = "0x8007ED0", VA = "0x1880096D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string OMNOEPOPIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x800B8A0", Offset = "0x800A0A0", VA = "0x18800B8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x800F960", Offset = "0x800E160", VA = "0x18800F960")]
	internal GMMPOACKBOK([Optional] MClusterData KPOIEHLJDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x800BF50", Offset = "0x800A750", VA = "0x18800BF50")]
	public void IEAMPCKAMFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x800EE40", Offset = "0x800D640", VA = "0x18800EE40")]
	public void MPHLEMKNJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x8009960", Offset = "0x8008160", VA = "0x188009960")]
	public void DMMMMNHEBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x800D820", Offset = "0x800C020", VA = "0x18800D820")]
	public bool JAPPAGFFHDB(Hash128 CEGOJJNEECN, [Out] EHBJHMIIJBM MLCGFPJFGFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x800DD10", Offset = "0x800C510", VA = "0x18800DD10")]
	public EHBJHMIIJBM KELFLPPCOLM(DDAIHEHCCHN IMINNNCPCJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x800DB20", Offset = "0x800C320", VA = "0x18800DB20")]
	public NPHGJFHFHME KELFLPPCOLM(FLBFCIJJHNF IPKNLMFNGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x800D960", Offset = "0x800C160", VA = "0x18800D960")]
	public LIFKLOAJLAI KELFLPPCOLM(MCMGPMJJBFH CMJLAOBGHAL, bool BPJJBHHNMBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x800B850", Offset = "0x800A050", VA = "0x18800B850")]
	public void HKOLMKDGPPH(CKBOCOJEGMJ LDIEJDNDIGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x800F7F0", Offset = "0x800DFF0", VA = "0x18800F7F0")]
	public static void PPKMJEENMIH(EONMBNAKAHK GBIENHEIENE, FDCDOKPPGAO[] IMINNNCPCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x800AF30", Offset = "0x8009730", VA = "0x18800AF30")]
	private void HEKKPLLFFNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x8009BB0", Offset = "0x80083B0", VA = "0x188009BB0")]
	private static void FLKLHJDFKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x8009150", Offset = "0x8007950", VA = "0x188009150")]
	public void ALDOFNEGALH(CommandBuffer CAGFFDPMGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x8009460", Offset = "0x8007C60", VA = "0x188009460")]
	public void ANADEGBGNGN([Optional] ScriptableRenderContext? MJAGIMDGJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x800D270", Offset = "0x800BA70", VA = "0x18800D270")]
	public void IJIPPMKENHJ(CommandBuffer CAGFFDPMGEA, ShadowSplitData OKGNDMLNGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x800D540", Offset = "0x800BD40", VA = "0x18800D540")]
	public void IJIPPMKENHJ(CommandBuffer CAGFFDPMGEA, CameraData MBMMNELFKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x800A850", Offset = "0x8009050", VA = "0x18800A850")]
	public void GBHPKLGMBHK(CommandBuffer CAGFFDPMGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x800F730", Offset = "0x800DF30", VA = "0x18800F730")]
	public void ONMONGLCOCC(CommandBuffer CAGFFDPMGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x8008CD0", Offset = "0x80074D0", VA = "0x188008CD0")]
	public void AJIAFIHINNM(CommandBuffer CAGFFDPMGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x800EF90", Offset = "0x800D790", VA = "0x18800EF90")]
	public void NDGOGCIEKHM(CommandBuffer CAGFFDPMGEA, EONMBNAKAHK KDNDJFKJGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x800ADE0", Offset = "0x80095E0", VA = "0x18800ADE0")]
	public void GKPOAOGDFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x800DF30", Offset = "0x800C730", VA = "0x18800DF30")]
	public void MMIAFMKGHIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8009970", Offset = "0x8008170", VA = "0x188009970", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BHLAKLEFJKF
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x27B7F90", Offset = "0x27B6790", VA = "0x1827B7F90")]
	public static int MCKGCNIGECB(int CCPDHPNHILC, int MIMKEDJDCCI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct HNDFHKPLCDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4x4 BCAFJAPMGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float4 FIDGFJEADML;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly HNDFHKPLCDI OOLOMCCBOJC;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public static readonly HNDFHKPLCDI HBDEBEHCDNA;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x8010A50", Offset = "0x800F250", VA = "0x188010A50")]
	public HNDFHKPLCDI(float4x4 ENOHIELBMNP, float4 KNCOLCPBFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x80108F0", Offset = "0x800F0F0", VA = "0x1880108F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct OBDBPCHCGIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 KKEEFCOJJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 IILAMILCBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 GENEBLLECDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 IBCFHEFBMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 OGHIPLNOEHD;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct JPIDDKNFHAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public float4 KKEEFCOJJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 IILAMILCBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 GENEBLLECDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 IBCFHEFBMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public half4 OGHIPLNOEHD;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct DCCIEJGBAPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public JPIDDKNFHAH BKOMDFNEIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public JPIDDKNFHAH DGDOEAEJNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public JPIDDKNFHAH JNGIMKJGEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public JPIDDKNFHAH CLAIJEHKOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public JPIDDKNFHAH BHPILLNGIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public JPIDDKNFHAH PBKEPBFNBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public JPIDDKNFHAH OKIENJNAMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public JPIDDKNFHAH NOELOPMCLMB;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct NJEMHCMOHFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public OBDBPCHCGIF BKOMDFNEIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public OBDBPCHCGIF DGDOEAEJNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public OBDBPCHCGIF JNGIMKJGEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public OBDBPCHCGIF CLAIJEHKOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public OBDBPCHCGIF BHPILLNGIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public OBDBPCHCGIF PBKEPBFNBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public OBDBPCHCGIF OKIENJNAMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public OBDBPCHCGIF NOELOPMCLMB;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct KLNEFDOHGAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float4 GHACELNNKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint OPCLBPEBBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public uint BEIKFCEAAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float JBAMMJAPHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint EACPFDMKJLG;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x80112B0", Offset = "0x800FAB0", VA = "0x1880112B0")]
	public KLNEFDOHGAN(FLBFCIJJHNF IPKNLMFNGIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct PGEGDFNFAIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint MBANEHEGGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint CDDMOLJHPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint GMHFDIAPGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint EACPFDMKJLG;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x8015440", Offset = "0x8013C40", VA = "0x188015440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct OMEEBCLCEEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint EFCNDNNJFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint GLKEPNPBMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint KIHBHAHLAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint EACPFDMKJLG;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x8015390", Offset = "0x8013B90", VA = "0x188015390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct LLOGLGPADPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint OBCBHDBACIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint NHFCEEPCDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint LCJEDPMCENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint DGPBFAJIIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint PLBBCGCJJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint GDOCLIPNNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint CCAFCGAJEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint EACPFDMKJLG;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x80125F0", Offset = "0x8010DF0", VA = "0x1880125F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct ABPBCEENJPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 NMKEKHCDDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 OEJDNNBGFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 ANCOPLOMFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 PHFCENJPHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 JCDEMCEIKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 GKICGMOABJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 DIBGDJGMFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public uint3 JFNPKNFGHMC;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8005210", Offset = "0x8003A10", VA = "0x188005210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum EONMBNAKAHK
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Opaque,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	DepthOnly,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Transparent,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Shadow
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
