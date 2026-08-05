using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6AB28D0", Offset = "0x6AB0ED0", VA = "0x186AB28D0", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private DFMCGIMCFGD bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private DFMCGIMCFGD bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7F30", Offset = "0x6AB6530", VA = "0x186AB7F30", Slot = "5")]
		public override void NPEPAFCACGO(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7F70", Offset = "0x6AB6570", VA = "0x186AB7F70")]
		private void PPMCIGPJJHC(OKABLMMJMFE registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7A80", Offset = "0x6AB6080", VA = "0x186AB7A80")]
		private void BJMOLFMPHAJ(OKABLMMJMFE registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7BF0", Offset = "0x6AB61F0", VA = "0x186AB7BF0", Slot = "6")]
		public override void BLGFFGICMBK(OKABLMMJMFE registry, [In] EFAAIAEHAHM filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6AB80E0", Offset = "0x6AB66E0", VA = "0x186AB80E0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class JEINCLLFPMP : FHIOCBHJNHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class JKEONLPOODB : IEnumerable<JKGBAPEDMGJ>, IEnumerable, IEnumerator<JKGBAPEDMGJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private JKGBAPEDMGJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private GJJPJLAFENF localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public GJJPJLAFENF <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public JEINCLLFPMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private NCCKDCPPFNC <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private PLFGOKCIKHG.LJANIOCAPMG <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private JKGBAPEDMGJ System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x965BF0", Offset = "0x9641F0", VA = "0x180965BF0")]
		[DebuggerHidden]
		public JKEONLPOODB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6AACDA0", Offset = "0x6AAB3A0", VA = "0x186AACDA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6AAC8E0", Offset = "0x6AAAEE0", VA = "0x186AAC8E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6AAC8C0", Offset = "0x6AAAEC0", VA = "0x186AAC8C0")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6AACD50", Offset = "0x6AAB350", VA = "0x186AACD50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6AACCA0", Offset = "0x6AAB2A0", VA = "0x186AACCA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JKGBAPEDMGJ> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6AACCA0", Offset = "0x6AAB2A0", VA = "0x186AACCA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class CMDFDDGNPEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public JEINCLLFPMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public BHLNHBCANEC nodeData;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public CMDFDDGNPEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6AA4600", Offset = "0x6AA2C00", VA = "0x186AA4600")]
		internal object LPGKDDDGABN(BHLNHBCANEC x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DFMJDMNEOGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public BHLNHBCANEC child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CMDFDDGNPEB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public DFMJDMNEOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5170", Offset = "0x6AA3770", VA = "0x186AA5170")]
		internal object LEFCKNOMDBP((BHLNHBCANEC child, BHLNHBCANEC nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly CMICIECANPG NHMIOEMGOMJ;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly CMICIECANPG AMMINDEOHLL;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly CMICIECANPG AHCNMJHGJNJ;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly CMICIECANPG PHOGMMGFGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private BPONAJLONCI OOKEOGNIGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private KHHOGBPENGN CHMJBKDFMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private EGMIGEMPNPA NFIBDOHOIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private KINGIDJGNNN GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private KNOEEDIBAID ECLICOGMAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly BNPCGNGBNKJ KKAHGNKMLJM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LEALCMGAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x897530", Offset = "0x895B30", VA = "0x180897530", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8972C0", Offset = "0x8958C0", VA = "0x1808972C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IPGOGDBCELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IHBBKLCKNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6AAAA20", Offset = "0x6AA9020", VA = "0x186AAAA20", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6AAA650", Offset = "0x6AA8C50", VA = "0x186AAA650", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IMEFPKNHJND
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6AAA700", Offset = "0x6AA8D00", VA = "0x186AAA700", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6AAC650", Offset = "0x6AAAC50", VA = "0x186AAC650", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ, JKGBAPEDMGJ> LDJEIGGDPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6AAA3D0", Offset = "0x6AA89D0", VA = "0x186AAA3D0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6AA8100", Offset = "0x6AA6700", VA = "0x186AA8100", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC850", Offset = "0x6AAAE50", VA = "0x186AAC850")]
	public JEINCLLFPMP(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8760", Offset = "0x6AA6D60", VA = "0x186AA8760", Slot = "12")]
	public void AIFHKOLJDOL(GameObject MNKAGJEGJCF, HHDPMFKBGKA GHLGDEIDHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9CA0", Offset = "0x6AA82A0", VA = "0x186AA9CA0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6AAB090", Offset = "0x6AA9690", VA = "0x186AAB090", Slot = "22")]
	public bool KBJCJNGOENG(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6AA97F0", Offset = "0x6AA7DF0", VA = "0x186AA97F0")]
	private void DFLFBMMDKHF(GJJPJLAFENF ODOBLMCCBPI, GJJPJLAFENF FIMGMAIGKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6AAAAD0", Offset = "0x6AA90D0", VA = "0x186AAAAD0")]
	private void IJEBNMDGKEJ(GJJPJLAFENF ODOBLMCCBPI, GJJPJLAFENF IPEPHOJIFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA7B0", Offset = "0x6AA8DB0", VA = "0x186AAA7B0")]
	private void HPLGJCBCEGJ(GJJPJLAFENF ODOBLMCCBPI, GJJPJLAFENF IPEPHOJIFNP, GJJPJLAFENF FIMGMAIGKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6AAB840", Offset = "0x6AA9E40", VA = "0x186AAB840")]
	private void LDEPAENEEDM(GJJPJLAFENF ODOBLMCCBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "13")]
	public void KOLHFLEMELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6AAAD80", Offset = "0x6AA9380", VA = "0x186AAAD80", Slot = "14")]
	public void JJJMHPMEAIK(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "15")]
	public void KEAJIFAKOEB(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9B40", Offset = "0x6AA8140", VA = "0x186AA9B40", Slot = "17")]
	public void DOIDPFJPGHL(JKGBAPEDMGJ GMLGNLBKHFJ, JKGBAPEDMGJ NNJPJBJGPIA, Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9A00", Offset = "0x6AA8000", VA = "0x186AA9A00")]
	public void DOIDPFJPGHL(GJJPJLAFENF JGEMMJEFOMN, GJJPJLAFENF NNJPJBJGPIA, Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9400", Offset = "0x6AA7A00", VA = "0x186AA9400")]
	public void CIOCFAHGKED(JKGBAPEDMGJ GMLGNLBKHFJ, float LDFEJLDJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6AABDF0", Offset = "0x6AAA3F0", VA = "0x186AABDF0", Slot = "18")]
	public void LJKIHEEOAEA(JKGBAPEDMGJ LJILLNPANEE, int ODCNDKNIIKA, JKGBAPEDMGJ PALJEDCNNHB, int AMJEONDEHHF, Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC530", Offset = "0x6AAAB30", VA = "0x186AAC530")]
	private float OCPGGJLKEOC(GJJPJLAFENF JGEMMJEFOMN, GJJPJLAFENF LDJCBIBELIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6AABCC0", Offset = "0x6AAA2C0", VA = "0x186AABCC0")]
	public void LJKIHEEOAEA(GJJPJLAFENF JGEMMJEFOMN, GJJPJLAFENF LDJCBIBELIM, Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6AABF40", Offset = "0x6AAA540", VA = "0x186AABF40")]
	public void LJKIHEEOAEA(GJJPJLAFENF JGEMMJEFOMN, GJJPJLAFENF LDJCBIBELIM, Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB, float LDFEJLDJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8BC0", Offset = "0x6AA71C0", VA = "0x186AA8BC0", Slot = "19")]
	public void BKEPMFGDDNJ(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6AAB5B0", Offset = "0x6AA9BB0", VA = "0x186AAB5B0")]
	public bool LDCLODIOACA(GJJPJLAFENF IDOMJKBDODC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9490", Offset = "0x6AA7A90", VA = "0x186AA9490", Slot = "16")]
	public void CKMHKNGAPII(JKGBAPEDMGJ GMLGNLBKHFJ, HashSet<JKGBAPEDMGJ> DGGMGCFCNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "20")]
	public PHAOBOBOLNJ FLKLJBHOCFB(bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "21")]
	public PHAOBOBOLNJ AAGDMIJHHEK(HashSet<Guid> MCDFALIBDMM, bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6AAAD10", Offset = "0x6AA9310", VA = "0x186AAAD10", Slot = "23")]
	public void JIBJELAGLED(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6AAC5E0", Offset = "0x6AAABE0", VA = "0x186AAC5E0", Slot = "24")]
	public void PGBAOMFJFHK(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6AAACF0", Offset = "0x6AA92F0", VA = "0x186AAACF0", Slot = "25")]
	public void IMEFKEPJNOP(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA90A0", Offset = "0x6AA76A0", VA = "0x186AA90A0")]
	private void CDGBMAELNNM(GJJPJLAFENF JGEMMJEFOMN, GJJPJLAFENF LDJCBIBELIM, Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB, float LDFEJLDJAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8340", Offset = "0x6AA6940", VA = "0x186AA8340")]
	private void AIAPGCPEBON(GJJPJLAFENF JGEMMJEFOMN, GJJPJLAFENF LEEMAEKICLM, Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6AABC50", Offset = "0x6AAA250", VA = "0x186AABC50")]
	private void LFNCOGEDFIH(GJJPJLAFENF JGEMMJEFOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9010", Offset = "0x6AA7610", VA = "0x186AA9010")]
	[IteratorStateMachine(typeof(JKEONLPOODB))]
	public IEnumerable<JKGBAPEDMGJ> CCKPINKEOLJ(GJJPJLAFENF IDOMJKBDODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6AAB470", Offset = "0x6AA9A70", VA = "0x186AAB470")]
	internal JKGBAPEDMGJ KOENKONHBKO(GJJPJLAFENF IDOMJKBDODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA060", Offset = "0x6AA8660", VA = "0x186AAA060")]
	internal GJJPJLAFENF FAOKHAEHJJG(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
		return default(GJJPJLAFENF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6AABFA0", Offset = "0x6AAA5A0", VA = "0x186AABFA0")]
	private bool LMAFBIFMOJA(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6AA89D0", Offset = "0x6AA6FD0", VA = "0x186AA89D0")]
	private bool APINMDGBJAB(BHLNHBCANEC GANDHMGOAJC, [Out] JKGBAPEDMGJ LDJCBIBELIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6AAB0E0", Offset = "0x6AA96E0", VA = "0x186AAB0E0")]
	private JKGBAPEDMGJ KOENKONHBKO(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8A30", Offset = "0x6AA7030", VA = "0x186AA8A30")]
	private JKGBAPEDMGJ BIJCGIMPKOC(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA480", Offset = "0x6AA8A80", VA = "0x186AAA480")]
	private JKGBAPEDMGJ GJMJHICGPEH(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9E90", Offset = "0x6AA8490", VA = "0x186AA9E90")]
	private static Guid EJNIJLINDPP(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6AA96A0", Offset = "0x6AA7CA0", VA = "0x186AA96A0")]
	private string CPDJIHPFIKP(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA240", Offset = "0x6AA8840", VA = "0x186AAA240")]
	private void FEFENLFBMED(JKGBAPEDMGJ JGEMMJEFOMN, JKGBAPEDMGJ LEEMAEKICLM, RigidTransform LENANFGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6AA81B0", Offset = "0x6AA67B0", VA = "0x186AA81B0")]
	private void ADKEMFADIAA(JKGBAPEDMGJ LEEMAEKICLM, JKGBAPEDMGJ JGEMMJEFOMN, RigidTransform LENANFGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9790", Offset = "0x6AA7D90", VA = "0x186AA9790")]
	private void CPPIPLFLDFD(JKGBAPEDMGJ DNBOOMFENIJ, JKGBAPEDMGJ JGEMMJEFOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9ED0", Offset = "0x6AA84D0", VA = "0x186AA9ED0")]
	private void ELIIAFKOOBA(JKGBAPEDMGJ JGEMMJEFOMN, JKGBAPEDMGJ LDJCBIBELIM, RigidTransform LENANFGCBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6AAA130", Offset = "0x6AA8730", VA = "0x186AAA130")]
	private void FBPMIAFALBA(GJJPJLAFENF IDOMJKBDODC, JKGBAPEDMGJ GMLGNLBKHFJ, GJJPJLAFENF IPEPHOJIFNP, GJJPJLAFENF FIMGMAIGKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA8D30", Offset = "0x6AA7330", VA = "0x186AA8D30")]
	private void CBPABIPLPHF(GJJPJLAFENF IDOMJKBDODC, JKGBAPEDMGJ GMLGNLBKHFJ, JKGBAPEDMGJ HKDOFPMCHOC, JKGBAPEDMGJ MKEMFFOAONA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OFMGFDMHAML
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DCBFLNFAPCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public JEFLJDHAGDI container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public DCBFLNFAPCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6AA50C0", Offset = "0x6AA36C0", VA = "0x186AA50C0")]
		internal JEINCLLFPMP IKLPOLNHFIM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6AB44F0", Offset = "0x6AB2AF0", VA = "0x186AB44F0")]
	public static void EAPLAPAFJKI(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4670", Offset = "0x6AB2C70", VA = "0x186AB4670")]
	public static void GGCHANDPBKN(JEFLJDHAGDI EOPOOELIKIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class EGDABLAKIMG : OFIPACJDOMA, GNPNNILMOKC
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx IOHJIPHILJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly JEINCLLFPMP AKOIMNMLALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly EGPPLLIHJFC BNPDFEHMEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly FOCEFOJIINF GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly BOPEIAPFBDN[] OHKDDJEHKPC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GJJPJLAFENF BKJDJDPGCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(GJJPJLAFENF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JKGBAPEDMGJ JPADHLKOAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6AA6F40", Offset = "0x6AA5540", VA = "0x186AA6F40", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JKGBAPEDMGJ DACAMIEIMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5770", Offset = "0x6AA3D70", VA = "0x186AA5770", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 LOHKPOHDCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6AA6470", Offset = "0x6AA4A70", VA = "0x186AA6470", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion BLEJECJIKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5460", Offset = "0x6AA3A60", VA = "0x186AA5460", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool NHHPDLIBFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6AA6640", Offset = "0x6AA4C40", VA = "0x186AA6640", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<JKGBAPEDMGJ> CONBKKDKINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5550", Offset = "0x6AA3B50", VA = "0x186AA5550", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool HJLNKMDBIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9237A0", Offset = "0x921DA0", VA = "0x1809237A0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x923DE0", Offset = "0x9223E0", VA = "0x180923DE0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform MJIIFCFMCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6AA7150", Offset = "0x6AA5750", VA = "0x186AA7150", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject MNAAHCNCEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2669720", Offset = "0x2667D20", VA = "0x182669720", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6AA6E70", Offset = "0x6AA5470", VA = "0x186AA6E70", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid JBNKBFFELBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6AA6FA0", Offset = "0x6AA55A0", VA = "0x186AA6FA0", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OJMIGIPMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6AA7080", Offset = "0x6AA5680", VA = "0x186AA7080", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool DGGOHFNNKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool BMDLPLLHIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5CA0", Offset = "0x6AA42A0", VA = "0x186AA5CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event BDCGJCECBFG GMDDJFGICFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6AA56C0", Offset = "0x6AA3CC0", VA = "0x186AA56C0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6AA6990", Offset = "0x6AA4F90", VA = "0x186AA6990", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event BDCGJCECBFG JFAKCDCIKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5C40", Offset = "0x6AA4240", VA = "0x186AA5C40", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6AA69F0", Offset = "0x6AA4FF0", VA = "0x186AA69F0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event BDCGJCECBFG DJBOFBPJEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5CF0", Offset = "0x6AA42F0", VA = "0x186AA5CF0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6AA54C0", Offset = "0x6AA3AC0", VA = "0x186AA54C0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event BGNCBNDOMLJ BDHFAPMGKLH
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5580", Offset = "0x6AA3B80", VA = "0x186AA5580", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6AA53C0", Offset = "0x6AA39C0", VA = "0x186AA53C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6D70", Offset = "0x6AA5370", VA = "0x186AA6D70")]
	public EGDABLAKIMG(GJJPJLAFENF CFIHBJLNKJE, RigidbodyEx IOHJIPHILJI, EGPPLLIHJFC BNPDFEHMEBG, BOPEIAPFBDN[] OHKDDJEHKPC, FOCEFOJIINF GDGJPCNEJIO, FHIOCBHJNHK AKOIMNMLALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5520", Offset = "0x6AA3B20", VA = "0x186AA5520", Slot = "19")]
	public void BPMACNMHMCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "21")]
	public void EAEIGHAMGMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6903B90", Offset = "0x6902190", VA = "0x186903B90", Slot = "22")]
	public void EADKCDFFBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6AA65F0", Offset = "0x6AA4BF0", VA = "0x186AA65F0", Slot = "20")]
	public void LHKIFFPBGID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6260", Offset = "0x6AA4860", VA = "0x186AA6260", Slot = "25")]
	public void IHOABJMDLCB(int EDGBEJEFBGH, JKGBAPEDMGJ PALJEDCNNHB, int PPGHOBGEOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA64D0", Offset = "0x6AA4AD0", VA = "0x186AA64D0", Slot = "26")]
	public void KAIGONABNNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA66B0", Offset = "0x6AA4CB0", VA = "0x186AA66B0", Slot = "27")]
	public void MPNBIPBGGIF(int EDGBEJEFBGH, JKGBAPEDMGJ LJILLNPANEE, int OCAKALCKIMO, [Optional] Vector3? GGECHGICAME, [Optional] Quaternion? OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6A50", Offset = "0x6AA5050", VA = "0x186AA6A50", Slot = "28")]
	public void OPIPHALAIAA(JKGBAPEDMGJ LJILLNPANEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5830", Offset = "0x6AA3E30", VA = "0x186AA5830", Slot = "31")]
	public void FMEBJOPCKPJ(Vector3 IANHBKPCOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5F50", Offset = "0x6AA4550", VA = "0x186AA5F50", Slot = "29")]
	public void IHBFBOHFMNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6AD0", Offset = "0x6AA50D0", VA = "0x186AA6AD0", Slot = "30")]
	public void PMLHFFEDBLB(int HGFDMIDEFHN, Vector3 NJELOECLOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5E80", Offset = "0x6AA4480", VA = "0x186AA5E80", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int EDGBEJEFBGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5D50", Offset = "0x6AA4350", VA = "0x186AA5D50", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int EDGBEJEFBGH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA2BAC0", Offset = "0xA2A0C0", VA = "0x180A2BAC0", Slot = "42")]
	public Color GetConnectionSlotColor(int EDGBEJEFBGH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5620", Offset = "0x6AA3C20", VA = "0x186AA5620", Slot = "43")]
	public bool CanConnectTo(int EDGBEJEFBGH, JKGBAPEDMGJ MNHIMAMNOGH, int HGIANKMFMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "44")]
	public void ParentChanged(int EDGBEJEFBGH, JKGBAPEDMGJ BFFHMJOANDP, int CLLLKNBHIOD, Vector3 AKIGBGKKGPC, Quaternion GFEAIBJDDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "45")]
	public void ChildAdded(int EDGBEJEFBGH, JKGBAPEDMGJ OGIFFMPCHPO, int BKFNHEIKLGC, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "46")]
	public void ChildRemoved(int EDGBEJEFBGH, JKGBAPEDMGJ HJDDBIIOGKG, int DHNPBBBBBFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "47")]
	public void ConnectionModified(int EDGBEJEFBGH, JKGBAPEDMGJ PALJEDCNNHB, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA6CD0", Offset = "0x6AA52D0", VA = "0x186AA6CD0", Slot = "48")]
	public void RootChanged(JKGBAPEDMGJ ICMPCEMAEJP, JKGBAPEDMGJ ELIKAFIKJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6AA5720", Offset = "0x6AA3D20", VA = "0x186AA5720", Slot = "23")]
	public void EEAOAODDHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6AA57E0", Offset = "0x6AA3DE0", VA = "0x186AA57E0", Slot = "24")]
	public void FELAMAHGMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6AA65A0", Offset = "0x6AA4BA0", VA = "0x186AA65A0")]
	private void LDKAICGMJDA(bool BLGOCELJPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AODOHJCIOJB(typeof(BHCONKAFAIG), new string[] { })]
public class OEBALIHMHFF : BHCONKAFAIG, KINLAMFGOOC
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class FOPDGHLLJHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public OEBALIHMHFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public PLFGOKCIKHG localIds;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public FOPDGHLLJHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6AA7670", Offset = "0x6AA5C70", VA = "0x186AA7670")]
		internal void LGBBIHFGOCP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[GGBOHIFGDPB]
	private OJKEJOIGBJA JANHEKCDHCN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object COFINOAJIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6AB4230", Offset = "0x6AB2830", VA = "0x186AB4230", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4430", Offset = "0x6AB2A30", VA = "0x186AB4430", Slot = "6")]
	public void InitReferences(GOMDDPLFKLJ KKAHGNKMLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6AB42C0", Offset = "0x6AB28C0", VA = "0x186AB42C0", Slot = "5")]
	public void IPDGDAAEALJ(PLFGOKCIKHG DKJJBNFOMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public OEBALIHMHFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[AODOHJCIOJB(typeof(FHIOCBHJNHK), new string[] { "Ignore", "Mock" })]
public class JLNKIBPJMLH : FHIOCBHJNHK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LEALCMGAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IPGOGDBCELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IHBBKLCKNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6AAD0C0", Offset = "0x6AAB6C0", VA = "0x186AAD0C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6AACF60", Offset = "0x6AAB560", VA = "0x186AACF60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IMEFPKNHJND
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6AAD010", Offset = "0x6AAB610", VA = "0x186AAD010", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6AAD170", Offset = "0x6AAB770", VA = "0x186AAD170", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ, JKGBAPEDMGJ> LDJEIGGDPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6AACEB0", Offset = "0x6AAB4B0", VA = "0x186AACEB0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6AACE00", Offset = "0x6AAB400", VA = "0x186AACE00", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "12")]
	public void AIFHKOLJDOL(GameObject MNKAGJEGJCF, HHDPMFKBGKA GHLGDEIDHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "13")]
	public void KOLHFLEMELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "14")]
	public void JJJMHPMEAIK(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "15")]
	public void KEAJIFAKOEB(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "16")]
	public void CKMHKNGAPII(JKGBAPEDMGJ GMLGNLBKHFJ, HashSet<JKGBAPEDMGJ> DGGMGCFCNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "17")]
	public void DOIDPFJPGHL(JKGBAPEDMGJ GMLGNLBKHFJ, JKGBAPEDMGJ NNJPJBJGPIA, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "18")]
	public void LJKIHEEOAEA(JKGBAPEDMGJ GMLGNLBKHFJ, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "19")]
	public void BKEPMFGDDNJ(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "20")]
	public PHAOBOBOLNJ FLKLJBHOCFB(bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "21")]
	public PHAOBOBOLNJ AAGDMIJHHEK(HashSet<Guid> MCDFALIBDMM, bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "22")]
	public bool KBJCJNGOENG(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "23")]
	public void JIBJELAGLED(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "24")]
	public void PGBAOMFJFHK(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "25")]
	public void IMEFKEPJNOP(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public JLNKIBPJMLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JKGBAPEDMGJ : GNPNNILMOKC, IEquatable<JKGBAPEDMGJ>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GNPNNILMOKC
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	JKGBAPEDMGJ JPADHLKOAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform MJIIFCFMCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject MNAAHCNCEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid JBNKBFFELBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int OJMIGIPMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	GJJPJLAFENF BKJDJDPGCNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool DGGOHFNNKCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int EDGBEJEFBGH);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int EDGBEJEFBGH);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int EDGBEJEFBGH);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int EDGBEJEFBGH, JKGBAPEDMGJ MNHIMAMNOGH, int FKKMLOBPIJC);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int EDGBEJEFBGH, JKGBAPEDMGJ BFFHMJOANDP, int CLLLKNBHIOD, Vector3 AKIGBGKKGPC, Quaternion GFEAIBJDDAE);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int EDGBEJEFBGH, JKGBAPEDMGJ OGIFFMPCHPO, int BKFNHEIKLGC, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int EDGBEJEFBGH, JKGBAPEDMGJ HJDDBIIOGKG, int DHNPBBBBBFK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int EDGBEJEFBGH, JKGBAPEDMGJ PALJEDCNNHB, int PMLPEPHIDPM, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(JKGBAPEDMGJ ICMPCEMAEJP, JKGBAPEDMGJ ELIKAFIKJIO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[FMCCJGKNHAK(IIIIPAKMKHE.OMRoom)]
public interface FHIOCBHJNHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool LEALCMGAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool IPGOGDBCELH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IHBBKLCKNAE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IMEFPKNHJND;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<JKGBAPEDMGJ, JKGBAPEDMGJ, JKGBAPEDMGJ> LDJEIGGDPGA;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AIFHKOLJDOL(GameObject MNKAGJEGJCF, HHDPMFKBGKA GHLGDEIDHDM);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KOLHFLEMELG();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JJJMHPMEAIK(JKGBAPEDMGJ GMLGNLBKHFJ);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KEAJIFAKOEB(JKGBAPEDMGJ GMLGNLBKHFJ);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CKMHKNGAPII(JKGBAPEDMGJ GMLGNLBKHFJ, HashSet<JKGBAPEDMGJ> DGGMGCFCNKM);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DOIDPFJPGHL(JKGBAPEDMGJ GMLGNLBKHFJ, JKGBAPEDMGJ NNJPJBJGPIA, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LJKIHEEOAEA(JKGBAPEDMGJ GMLGNLBKHFJ, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BKEPMFGDDNJ(JKGBAPEDMGJ GMLGNLBKHFJ);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	PHAOBOBOLNJ FLKLJBHOCFB(bool ILAOOODHNBG);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "17")]
	PHAOBOBOLNJ AAGDMIJHHEK(HashSet<Guid> MCDFALIBDMM, bool ILAOOODHNBG);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool KBJCJNGOENG(BHLNHBCANEC GANDHMGOAJC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void JIBJELAGLED(PHAOBOBOLNJ BDFEFAPJDHE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PGBAOMFJFHK(PHAOBOBOLNJ BDFEFAPJDHE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IMEFKEPJNOP(PHAOBOBOLNJ BDFEFAPJDHE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KINGIDJGNNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DMIFGEPFKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JKGBAPEDMGJ GJMJHICGPEH(int AIJLAMCPGBD);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JKGBAPEDMGJ BIJCGIMPKOC(Guid HHFBLGLBAFM);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IIGONIELMFB(JKGBAPEDMGJ GMLGNLBKHFJ);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MLAFPFCADFM();

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CKJJPFGKECL(JKGBAPEDMGJ BNPDFEHMEBG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[FMCCJGKNHAK(IIIIPAKMKHE.Application)]
public interface FOCEFOJIINF
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BMDLPLLHIGM(EGPPLLIHJFC BNPDFEHMEBG);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CJJMIBEEKAE(EGPPLLIHJFC BNPDFEHMEBG);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string MMNNMIFPMID(EGPPLLIHJFC BNPDFEHMEBG);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PCEIOMLDDPC(EGPPLLIHJFC BNPDFEHMEBG);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NCGKLJEDPIM(EGPPLLIHJFC BNPDFEHMEBG);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JMEGINAFJJF(EGPPLLIHJFC BNPDFEHMEBG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void BDCGJCECBFG(JKGBAPEDMGJ LJILLNPANEE, int DKGAKFIOBAB, JKGBAPEDMGJ PALJEDCNNHB, int JHALJPEJOEN, [Optional] Vector3? GGECHGICAME, [Optional] Quaternion? OKBBDAFCHNJ);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void BGNCBNDOMLJ(JKGBAPEDMGJ ICMPCEMAEJP, JKGBAPEDMGJ ELIKAFIKJIO);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EGPPLLIHJFC : JKGBAPEDMGJ, GNPNNILMOKC, IEquatable<JKGBAPEDMGJ>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OFIPACJDOMA : GNPNNILMOKC
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	JKGBAPEDMGJ DACAMIEIMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<JKGBAPEDMGJ> CONBKKDKINP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 LOHKPOHDCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion BLEJECJIKKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool NHHPDLIBFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool HJLNKMDBIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event BDCGJCECBFG GMDDJFGICFB;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event BDCGJCECBFG JFAKCDCIKGC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event BDCGJCECBFG DJBOFBPJEJF;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event BGNCBNDOMLJ BDHFAPMGKLH;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BPMACNMHMCK();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LHKIFFPBGID();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EAEIGHAMGMI();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EADKCDFFBEM();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void EEAOAODDHPD();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FELAMAHGMPL();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IHOABJMDLCB(int EDGBEJEFBGH, JKGBAPEDMGJ PALJEDCNNHB, int PPGHOBGEOGE);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KAIGONABNNN();

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MPNBIPBGGIF(int EDGBEJEFBGH, JKGBAPEDMGJ LJILLNPANEE, int OCAKALCKIMO, [Optional] Vector3? GGECHGICAME, [Optional] Quaternion? OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void OPIPHALAIAA(JKGBAPEDMGJ LJILLNPANEE);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void IHBFBOHFMNM();

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PMLHFFEDBLB(int HGFDMIDEFHN, Vector3 NJELOECLOIL);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FMEBJOPCKPJ(Vector3 IANHBKPCOAF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BOPEIAPFBDN
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 FHFHKGKODEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface HHDPMFKBGKA
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OIBAJCLPOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FNMMPAFJNAP IFAKPMDKKFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, HHDPMFKBGKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public const string RUNTIME_CONFIG_PATH = "ConnectableConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private bool verboseLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[FormerlySerializedAs("linkVisualPrefab")]
		[SerializeField]
		private LegacyConnectableLinkVisual legacyLinkVisualPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool VerboseLogging
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9F2D20", Offset = "0x9F1320", VA = "0x1809F2D20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public FNMMPAFJNAP LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6AA4670", Offset = "0x6AA2C70", VA = "0x186AA4670")]
		public static ConnectableConfigData MAHEJLCNCLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6AA4730", Offset = "0x6AA2D30", VA = "0x186AA4730")]
		public ConnectableConfigData(LegacyConnectableLinkVisual ANHAOHHOLPJ, bool HCPJKJGIHMN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HDHAHFKGGAI : IEquatable<HDHAHFKGGAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public JKGBAPEDMGJ GMLGNLBKHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int IFGAAGJBJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int PMLPEPHIDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 GGECHGICAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion OKBBDAFCHNJ;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7E30", Offset = "0x6AA6430", VA = "0x186AA7E30")]
	public HDHAHFKGGAI(JKGBAPEDMGJ GMLGNLBKHFJ, int IFGAAGJBJJB, int PMLPEPHIDPM, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7D10", Offset = "0x6AA6310", VA = "0x186AA7D10")]
	public HDHAHFKGGAI(JKGBAPEDMGJ GMLGNLBKHFJ, int IFGAAGJBJJB, int PMLPEPHIDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7DB0", Offset = "0x6AA63B0", VA = "0x186AA7DB0")]
	public HDHAHFKGGAI(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6AA78A0", Offset = "0x6AA5EA0", VA = "0x186AA78A0", Slot = "4")]
	public bool Equals(HDHAHFKGGAI PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7950", Offset = "0x6AA5F50", VA = "0x186AA7950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class IKNDKGEGBPA : LCEKIFGAPCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform FLDLBOHKNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private FNMMPAFJNAP NLNNAEIEIMP;

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x65ACE00", Offset = "0x65AB400", VA = "0x1865ACE00", Slot = "4")]
	public void AIFHKOLJDOL(Transform FLDLBOHKNDN, FNMMPAFJNAP NLNNAEIEIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7FC0", Offset = "0x6AA65C0", VA = "0x186AA7FC0", Slot = "5")]
	public FNMMPAFJNAP IPINNKBKDNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7F50", Offset = "0x6AA6550", VA = "0x186AA7F50", Slot = "6")]
	public void ABGMIDFNOAD(FNMMPAFJNAP EGLPALGNHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public IKNDKGEGBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class KLPICNFJMCM : IDisposable, ACAGJKBHNFN
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HIFJPGLGEMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public JKGBAPEDMGJ oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public JKGBAPEDMGJ newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public HIFJPGLGEMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6AA7E90", Offset = "0x6AA6490", VA = "0x186AA7E90")]
		internal bool JEAKKBDFPKF(KPEPDKLILEK node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly OBLEHAGJMML CCMBPPAOJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private KBOPNBNCEJG DCLKOGBCAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private PAFAJCKFCAE NMPHPKABOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool HCPJKJGIHMN;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly CMICIECANPG AGBJIKKEMAD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KPEPDKLILEK GEBPHFIJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF020", Offset = "0x6AAD620", VA = "0x186AAF020")]
	public bool OILDKDGNOMB([In] GILOHHMHLLN JGCMECODHDI, bool BCNPKHABFBL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF180", Offset = "0x6AAD780", VA = "0x186AAF180")]
	private bool FHMKDCBGJNC([In] GILOHHMHLLN JGCMECODHDI, bool BCNPKHABFBL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB05C0", Offset = "0x6AAEBC0", VA = "0x186AB05C0")]
	public KLPICNFJMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD410", Offset = "0x6AABA10", VA = "0x186AAD410", Slot = "5")]
	public void AIFHKOLJDOL(FHIOCBHJNHK EHABNPPLNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6AADE90", Offset = "0x6AAC490", VA = "0x186AADE90", Slot = "17")]
	public void CCGECIHNNFJ(BODHOPONGMF JMKAJHCEDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF950", Offset = "0x6AADF50", VA = "0x186AAF950", Slot = "12")]
	public void HCPJLGBFCBP(Func<JKGBAPEDMGJ, bool> KHEBOEENKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF820", Offset = "0x6AADE20", VA = "0x186AAF820")]
	private void HCPJLGBFCBP(OBLEHAGJMML KOHLOCENPAH, Func<JKGBAPEDMGJ, bool> KHEBOEENKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF030", Offset = "0x6AAD630", VA = "0x186AAF030", Slot = "11")]
	public void ENOKKHKKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF050", Offset = "0x6AAD650", VA = "0x186AAF050", Slot = "8")]
	public bool FABGBKCDGJF(JKGBAPEDMGJ MHEJCKDLEJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD4A0", Offset = "0x6AABAA0", VA = "0x186AAD4A0")]
	private bool AOHKJKBHJJC(JKGBAPEDMGJ NDCGGBMNCJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF9C0", Offset = "0x6AADFC0", VA = "0x186AAF9C0")]
	private static bool KFPLCLGHBNB(JKGBAPEDMGJ NDCGGBMNCJO, OBLEHAGJMML OFPOMHJBMCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6AAEAD0", Offset = "0x6AAD0D0", VA = "0x186AAEAD0")]
	private void DHCDMMKANMA(Transform CHOOGBCBHHH, OBLEHAGJMML PAFGKIFMBJM, OBLEHAGJMML[] GFOAHFPJBDL, JKGBAPEDMGJ DKNHKFJKLGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6AADF20", Offset = "0x6AAC520", VA = "0x186AADF20")]
	private HDHAHFKGGAI CGNJKIJDDPF(Transform PPHMGNDPCFN, HDHAHFKGGAI PFBLDLHKFBJ)
	{
		return default(HDHAHFKGGAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0230", Offset = "0x6AAE830", VA = "0x186AB0230")]
	private static bool NPMFGIKGKJM(OBLEHAGJMML OFPOMHJBMCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6AADEC0", Offset = "0x6AAC4C0", VA = "0x186AADEC0", Slot = "9")]
	public bool CEJEPBILKOJ(JKGBAPEDMGJ BNNBHPJIPAL, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6AAE2B0", Offset = "0x6AAC8B0", VA = "0x186AAE2B0")]
	private bool CIHJDKLDNML(JKGBAPEDMGJ BNNBHPJIPAL, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6AADBA0", Offset = "0x6AAC1A0", VA = "0x186AADBA0")]
	private static void BDOIGGFHCDE(JKGBAPEDMGJ BNNBHPJIPAL, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ, OBLEHAGJMML BFMLFHGNNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF060", Offset = "0x6AAD660", VA = "0x186AAF060")]
	private void FEFENLFBMED(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0090", Offset = "0x6AAE690", VA = "0x186AB0090")]
	private void LHINCDJBDHI(OBLEHAGJMML KOHLOCENPAH, JKGBAPEDMGJ HKDOFPMCHOC, JKGBAPEDMGJ MKEMFFOAONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0020", Offset = "0x6AAE620", VA = "0x186AB0020")]
	private void LHINCDJBDHI(JKGBAPEDMGJ GMLGNLBKHFJ, JKGBAPEDMGJ HKDOFPMCHOC, JKGBAPEDMGJ MKEMFFOAONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6AADD20", Offset = "0x6AAC320", VA = "0x186AADD20")]
	private void CBPABIPLPHF(JKGBAPEDMGJ GMLGNLBKHFJ, JKGBAPEDMGJ HKDOFPMCHOC, JKGBAPEDMGJ MKEMFFOAONA, bool IMCDJBIPJDI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6AADD90", Offset = "0x6AAC390", VA = "0x186AADD90")]
	private void CBPABIPLPHF(OBLEHAGJMML JPBBEMPIGCM, JKGBAPEDMGJ DKNHKFJKLGH, JKGBAPEDMGJ ELIKAFIKJIO, bool IMCDJBIPJDI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD220", Offset = "0x6AAB820", VA = "0x186AAD220")]
	private void ADKEMFADIAA(JKGBAPEDMGJ JGEMMJEFOMN, int OCAKALCKIMO, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6AAE8A0", Offset = "0x6AACEA0", VA = "0x186AAE8A0")]
	private void CPPIPLFLDFD(KPEPDKLILEK LDJCBIBELIM, KPEPDKLILEK PIAKJOABJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6AAEEC0", Offset = "0x6AAD4C0", VA = "0x186AAEEC0", Slot = "18")]
	public JKGBAPEDMGJ DHHFLPBDCJB(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6AAE500", Offset = "0x6AACB00", VA = "0x186AAE500", Slot = "13")]
	public void CKMHKNGAPII(JKGBAPEDMGJ GMLGNLBKHFJ, HashSet<JKGBAPEDMGJ> DGBFBJAMNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6AAE070", Offset = "0x6AAC670", VA = "0x186AAE070", Slot = "14")]
	public List<JKGBAPEDMGJ> CHGBHBABLKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6AAD340", Offset = "0x6AAB940", VA = "0x186AAD340")]
	protected KPEPDKLILEK AFKMNCHAENA(KPEPDKLILEK KOHLOCENPAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF740", Offset = "0x6AADD40", VA = "0x186AAF740")]
	protected OBLEHAGJMML[] FLHPCELAGKL(OBLEHAGJMML OFPOMHJBMCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6AB03F0", Offset = "0x6AAE9F0", VA = "0x186AB03F0")]
	protected bool OFGMLIEIGEG(JKGBAPEDMGJ GMLGNLBKHFJ, [Out] OBLEHAGJMML KOHLOCENPAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0100", Offset = "0x6AAE700", VA = "0x186AB0100", Slot = "15")]
	public bool LJLMHGFHAFD(JKGBAPEDMGJ GMLGNLBKHFJ, [Out] HDHAHFKGGAI PHKLAKHNMNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF7E0", Offset = "0x6AADDE0", VA = "0x186AAF7E0")]
	protected OBLEHAGJMML GPCOEFNOHPP(HDHAHFKGGAI AKOGPFLNHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF960", Offset = "0x6AADF60", VA = "0x186AAF960", Slot = "10")]
	public bool IAFBMCBELLL(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6AAFA70", Offset = "0x6AAE070", VA = "0x186AAFA70")]
	private bool KGFFNKLACEE(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6AAEA00", Offset = "0x6AAD000", VA = "0x186AAEA00")]
	private static bool DCDNGKIOMBD(OBLEHAGJMML KOPFLCFHELE, HDHAHFKGGAI HNJPAPDIGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6AAF020", Offset = "0x6AAD620", VA = "0x186AAF020", Slot = "7")]
	private bool EEDHBEGNDMM([In] GILOHHMHLLN JGCMECODHDI, bool BCNPKHABFBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class ABKIOLMPIAK : FHIOCBHJNHK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly JEFLJDHAGDI EOPOOELIKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly PAFAJCKFCAE NMPHPKABOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly FOGILIDAFJL ODDLIEAOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly PKAMOJILALE CPHOOKBAPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly ACAGJKBHNFN BDFEFAPJDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal FFAFDAGJCFB GDGJPCNEJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal MEBBLNOINLC BPCHJLBHPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal KBOPNBNCEJG PKNAKFGJENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool HCPJKJGIHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool GMEFPBOPBHJ;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GJDFIKPHMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xAC94C0", Offset = "0xAC7AC0", VA = "0x180AC94C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1B5B9B0", Offset = "0x1B59FB0", VA = "0x181B5B9B0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LEALCMGAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xAC94B0", Offset = "0xAC7AB0", VA = "0x180AC94B0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1B5B9A0", Offset = "0x1B59FA0", VA = "0x181B5B9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool IPGOGDBCELH
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IHBBKLCKNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6AA3940", Offset = "0x6AA1F40", VA = "0x186AA3940", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6AA3620", Offset = "0x6AA1C20", VA = "0x186AA3620", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ> IMEFPKNHJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6AA3790", Offset = "0x6AA1D90", VA = "0x186AA3790", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6AA3FF0", Offset = "0x6AA25F0", VA = "0x186AA3FF0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<JKGBAPEDMGJ, JKGBAPEDMGJ, JKGBAPEDMGJ> LDJEIGGDPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6AA35C0", Offset = "0x6AA1BC0", VA = "0x186AA35C0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6AA2790", Offset = "0x6AA0D90", VA = "0x186AA2790", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA4050", Offset = "0x6AA2650", VA = "0x186AA4050")]
	public ABKIOLMPIAK(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6AA27F0", Offset = "0x6AA0DF0", VA = "0x186AA27F0", Slot = "12")]
	public void AIFHKOLJDOL(GameObject MNKAGJEGJCF, HHDPMFKBGKA GHLGDEIDHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6AA32A0", Offset = "0x6AA18A0", VA = "0x186AA32A0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3BD0", Offset = "0x6AA21D0", VA = "0x186AA3BD0", Slot = "13")]
	public void KOLHFLEMELG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3A70", Offset = "0x6AA2070", VA = "0x186AA3A70", Slot = "14")]
	public void JJJMHPMEAIK(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3340", Offset = "0x6AA1940", VA = "0x186AA3340", Slot = "15")]
	public void KEAJIFAKOEB(JKGBAPEDMGJ GMLGNLBKHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3AF0", Offset = "0x6AA20F0", VA = "0x186AA3AF0", Slot = "22")]
	public bool KBJCJNGOENG(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6AA34E0", Offset = "0x6AA1AE0", VA = "0x186AA34E0")]
	internal bool FHMKDCBGJNC([In] GILOHHMHLLN JGCMECODHDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3B40", Offset = "0x6AA2140", VA = "0x186AA3B40")]
	internal bool KGFFNKLACEE([In] GILOHHMHLLN JGCMECODHDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3A90", Offset = "0x6AA2090", VA = "0x186AA3A90")]
	internal bool JOMEKGBGBBC([In] GILOHHMHLLN JGCMECODHDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6AA37F0", Offset = "0x6AA1DF0", VA = "0x186AA37F0")]
	internal bool HLNBOEGFJBN([In] GILOHHMHLLN JGCMECODHDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3D60", Offset = "0x6AA2360", VA = "0x186AA3D60")]
	internal void MNBNFKCHBPI(JKGBAPEDMGJ GMLGNLBKHFJ, int DIHDLGJMOHO, bool BCNPKHABFBL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3340", Offset = "0x6AA1940", VA = "0x186AA3340")]
	internal bool EAIMCMPINGC(JKGBAPEDMGJ HPFINHLPMLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6AA33A0", Offset = "0x6AA19A0", VA = "0x186AA33A0")]
	internal bool FEGEECKDOKF(JKGBAPEDMGJ BNNBHPJIPAL, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6AA2F90", Offset = "0x6AA1590", VA = "0x186AA2F90", Slot = "16")]
	public void CKMHKNGAPII(JKGBAPEDMGJ GMLGNLBKHFJ, HashSet<JKGBAPEDMGJ> DGGMGCFCNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3090", Offset = "0x6AA1690", VA = "0x186AA3090", Slot = "17")]
	public void DOIDPFJPGHL(JKGBAPEDMGJ BNNBHPJIPAL, JKGBAPEDMGJ NNJPJBJGPIA, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3C20", Offset = "0x6AA2220", VA = "0x186AA3C20", Slot = "18")]
	public void LJKIHEEOAEA(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6AA2DC0", Offset = "0x6AA13C0", VA = "0x186AA2DC0", Slot = "19")]
	public void BKEPMFGDDNJ(JKGBAPEDMGJ LDDIOHEAPDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3680", Offset = "0x6AA1C80", VA = "0x186AA3680")]
	public void HALOCGIBBLH([Optional] FKHHMLJBCHF MANOCABBPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6AA39E0", Offset = "0x6AA1FE0", VA = "0x186AA39E0", Slot = "23")]
	public void JIBJELAGLED(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6AA35A0", Offset = "0x6AA1BA0", VA = "0x186AA35A0", Slot = "20")]
	public PHAOBOBOLNJ FLKLJBHOCFB(bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6AA2770", Offset = "0x6AA0D70", VA = "0x186AA2770", Slot = "21")]
	public PHAOBOBOLNJ AAGDMIJHHEK(HashSet<Guid> MCDFALIBDMM, bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6AA39A0", Offset = "0x6AA1FA0", VA = "0x186AA39A0", Slot = "25")]
	public void IMEFKEPJNOP(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6AA3F40", Offset = "0x6AA2540", VA = "0x186AA3F40", Slot = "24")]
	public void PGBAOMFJFHK(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class PAFAJCKFCAE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly LLEJOEJOMJB<JKGBAPEDMGJ, JKGBAPEDMGJ> IHBBKLCKNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly LLEJOEJOMJB<JKGBAPEDMGJ, JKGBAPEDMGJ> IMEFPKNHJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly MFOJMBEOKED<JKGBAPEDMGJ, JKGBAPEDMGJ, JKGBAPEDMGJ> LDJEIGGDPGA;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4800", Offset = "0x6AB2E00", VA = "0x186AB4800")]
	public PAFAJCKFCAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	public void AIFHKOLJDOL(ABKIOLMPIAK EHABNPPLNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB47A0", Offset = "0x6AB2DA0", VA = "0x186AB47A0")]
	public void PNIGHCHOHAD(JKGBAPEDMGJ LDJCBIBELIM, JKGBAPEDMGJ JGEMMJEFOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6AB46C0", Offset = "0x6AB2CC0", VA = "0x186AB46C0")]
	public void IPLEKPDNJIJ(JKGBAPEDMGJ LDJCBIBELIM, JKGBAPEDMGJ JGEMMJEFOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4720", Offset = "0x6AB2D20", VA = "0x186AB4720")]
	public void MEEKBPIMKPN(JKGBAPEDMGJ DNBOOMFENIJ, JKGBAPEDMGJ LEEMAEKICLM, JKGBAPEDMGJ JGEMMJEFOMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class FOGILIDAFJL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private ABKIOLMPIAK EHABNPPLNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private MEBBLNOINLC BPCHJLBHPKH;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public FOGILIDAFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6AA72A0", Offset = "0x6AA58A0", VA = "0x186AA72A0")]
	public void AIFHKOLJDOL(ABKIOLMPIAK EHABNPPLNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6AA74D0", Offset = "0x6AA5AD0", VA = "0x186AA74D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7650", Offset = "0x6AA5C50", VA = "0x186AA7650")]
	private void LMIGIHMKGBE(FKHHMLJBCHF JDDNDMPDAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6AA74E0", Offset = "0x6AA5AE0", VA = "0x186AA74E0")]
	private void KJEDPAEBLIJ(FKHHMLJBCHF ECDFEGAFAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7550", Offset = "0x6AA5B50", VA = "0x186AA7550")]
	public void LFBHDFGIJDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6AA73D0", Offset = "0x6AA59D0", VA = "0x186AA73D0")]
	public void CBKGFFDIPJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KPHAPFIENCP
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ILIPALECFKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public JEFLJDHAGDI container;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public ILIPALECFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6AA8090", Offset = "0x6AA6690", VA = "0x186AA8090")]
		internal ABKIOLMPIAK IKLPOLNHFIM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0790", Offset = "0x6AAED90", VA = "0x186AB0790")]
	public static void EAPLAPAFJKI(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6AB0990", Offset = "0x6AAEF90", VA = "0x186AB0990")]
	public static void GGCHANDPBKN(JEFLJDHAGDI EOPOOELIKIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class MAJOMBJGPEJ : IDisposable, KBOPNBNCEJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, FNMMPAFJNAP> PCPNGGGLOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly BODHOPONGMF IMNKDOHDGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private LCEKIFGAPCG BNJJIPLFCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private ACAGJKBHNFN BDFEFAPJDHE;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6AB35F0", Offset = "0x6AB1BF0", VA = "0x186AB35F0")]
	public MAJOMBJGPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6AB2A70", Offset = "0x6AB1070", VA = "0x186AB2A70", Slot = "7")]
	public void AIFHKOLJDOL(ACAGJKBHNFN BDFEFAPJDHE, LCEKIFGAPCG BNJJIPLFCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6AB2B80", Offset = "0x6AB1180", VA = "0x186AB2B80", Slot = "5")]
	public void CMHJMDKDLFB(KPEPDKLILEK ECKPCDCMHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB2DC0", Offset = "0x6AB13C0", VA = "0x186AB2DC0", Slot = "9")]
	public void CPLFJDDMMCC(KPEPDKLILEK KBNFBKEMDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB30E0", Offset = "0x6AB16E0", VA = "0x186AB30E0", Slot = "8")]
	public void FNOOEHMLIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB32A0", Offset = "0x6AB18A0", VA = "0x186AB32A0", Slot = "10")]
	public void OEFGAAAGCKO(KPEPDKLILEK JECMHPEPOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB2AB0", Offset = "0x6AB10B0", VA = "0x186AB2AB0", Slot = "11")]
	public void CLCNNEEFBAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6AB2F30", Offset = "0x6AB1530", VA = "0x186AB2F30")]
	private bool FMBEAOBHICE(KPEPDKLILEK ODPGHJEEHCK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class PKAMOJILALE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct DALCJLFELKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly OBLEHAGJMML PMDAEJKCPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly HashSet<Guid> MCDFALIBDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly BHLNHBCANEC MFFAFHAKJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly BHLNHBCANEC PMLBOLPFHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly bool ILAOOODHNBG;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool LJLOADEMIKH
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x6AA4780", Offset = "0x6AA2D80", VA = "0x186AA4780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6AA5050", Offset = "0x6AA3650", VA = "0x186AA5050")]
		public DALCJLFELKD(OBLEHAGJMML PMDAEJKCPDF, HashSet<Guid> MCDFALIBDMM, bool ILAOOODHNBG, [Optional] BHLNHBCANEC MFFAFHAKJIE, [Optional] BHLNHBCANEC PMLBOLPFHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6AA48A0", Offset = "0x6AA2EA0", VA = "0x186AA48A0")]
		public BHLNHBCANEC AMCHBAGBIFH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6AA4DD0", Offset = "0x6AA33D0", VA = "0x186AA4DD0")]
		private BHLNHBCANEC INEIOCHLIDA([Out] BHLNHBCANEC ICMBCFIFFLO, [Out] BHLNHBCANEC BIKBCFNNHOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6AA4A40", Offset = "0x6AA3040", VA = "0x186AA4A40")]
		private BHLNHBCANEC DDMCPIHMGEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6AA4C60", Offset = "0x6AA3260", VA = "0x186AA4C60")]
		private void GNJIHMKMMJD(BHLNHBCANEC NDPILDBMCLH, BHLNHBCANEC FDHCBBKCJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6AA4E90", Offset = "0x6AA3490", VA = "0x186AA4E90")]
		private void LLMGOMNENGC(BHLNHBCANEC ICMBCFIFFLO, BHLNHBCANEC BIKBCFNNHOG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private ABKIOLMPIAK EHABNPPLNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private ACAGJKBHNFN BDFEFAPJDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private KBOPNBNCEJG DCLKOGBCAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private MEBBLNOINLC BPCHJLBHPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool ODIKBJFCDNB;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool IBLJOFBLDGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6AB7770", Offset = "0x6AB5D70", VA = "0x186AB7770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool GJDFIKPHMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6AB64F0", Offset = "0x6AB4AF0", VA = "0x186AB64F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6AB64D0", Offset = "0x6AB4AD0", VA = "0x186AB64D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4FB0", Offset = "0x6AB35B0", VA = "0x186AB4FB0")]
	public void AIFHKOLJDOL(ABKIOLMPIAK EHABNPPLNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5C40", Offset = "0x6AB4240", VA = "0x186AB5C40")]
	public PHAOBOBOLNJ FLKLJBHOCFB(bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4920", Offset = "0x6AB2F20", VA = "0x186AB4920")]
	public PHAOBOBOLNJ AAGDMIJHHEK(HashSet<Guid> MCDFALIBDMM, bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6510", Offset = "0x6AB4B10", VA = "0x186AB6510")]
	public void JIBJELAGLED(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6AB77C0", Offset = "0x6AB5DC0", VA = "0x186AB77C0")]
	public void PGBAOMFJFHK(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB7860", Offset = "0x6AB5E60", VA = "0x186AB7860")]
	public void PIFHNAJLACM(PHAOBOBOLNJ BDFEFAPJDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6DA0", Offset = "0x6AB53A0", VA = "0x186AB6DA0")]
	private void KPOHEOFAHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5420", Offset = "0x6AB3A20", VA = "0x186AB5420")]
	private BHLNHBCANEC CCFLNMOJIAB(OBLEHAGJMML KOHLOCENPAH, bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6AB59D0", Offset = "0x6AB3FD0", VA = "0x186AB59D0")]
	private static void FABFPBCIDGL(OBLEHAGJMML KOHLOCENPAH, bool ILAOOODHNBG, BHLNHBCANEC GANDHMGOAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6AB65A0", Offset = "0x6AB4BA0", VA = "0x186AB65A0")]
	private void KANKIDAMIKB(OBLEHAGJMML KOHLOCENPAH, bool ILAOOODHNBG, BHLNHBCANEC GANDHMGOAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5390", Offset = "0x6AB3990", VA = "0x186AB5390")]
	private BHLNHBCANEC BOPEDIABKKD(OBLEHAGJMML PMDAEJKCPDF, HashSet<Guid> MCDFALIBDMM, bool ILAOOODHNBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5740", Offset = "0x6AB3D40", VA = "0x186AB5740")]
	private bool DAFJJEBJMPB(PHAOBOBOLNJ IPEEJDIIKEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6F90", Offset = "0x6AB5590", VA = "0x186AB6F90")]
	private bool LMAFBIFMOJA(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5C20", Offset = "0x6AB4220", VA = "0x186AB5C20")]
	private bool FGKLLOGMGGM(PHAOBOBOLNJ BDFEFAPJDHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5020", Offset = "0x6AB3620", VA = "0x186AB5020")]
	private static bool AOOHGDGJDCJ(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6AB67C0", Offset = "0x6AB4DC0", VA = "0x186AB67C0")]
	public static bool KBJCJNGOENG(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6A50", Offset = "0x6AB5050", VA = "0x186AB6A50")]
	private JKGBAPEDMGJ KOENKONHBKO(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6AB61C0", Offset = "0x6AB47C0", VA = "0x186AB61C0")]
	private JKGBAPEDMGJ GJMJHICGPEH(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6AB6340", Offset = "0x6AB4940", VA = "0x186AB6340")]
	private JKGBAPEDMGJ IFGBDFIJLMC(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6AA9E90", Offset = "0x6AA8490", VA = "0x186AA9E90")]
	private static Guid EJNIJLINDPP(BHLNHBCANEC GANDHMGOAJC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5650", Offset = "0x6AB3C50", VA = "0x186AB5650")]
	private string CPDJIHPFIKP(BHLNHBCANEC GANDHMGOAJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6AB75F0", Offset = "0x6AB5BF0", VA = "0x186AB75F0")]
	private bool NPKFIHJAPGB(OBLEHAGJMML KOHLOCENPAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6AB5130", Offset = "0x6AB3730", VA = "0x186AB5130")]
	private static void BHLEFLNBNBH(OBLEHAGJMML PMDAEJKCPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public PKAMOJILALE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct GILOHHMHLLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public JKGBAPEDMGJ JGEMMJEFOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public JKGBAPEDMGJ LDJCBIBELIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public int OCAKALCKIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int PPGHOBGEOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Vector3 GGECHGICAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Quaternion OKBBDAFCHNJ;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HDHAHFKGGAI KIDJIBFMGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6AA7760", Offset = "0x6AA5D60", VA = "0x186AA7760")]
		get
		{
			return default(HDHAHFKGGAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public HDHAHFKGGAI HOPABIEBMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6AA7800", Offset = "0x6AA5E00", VA = "0x186AA7800")]
		get
		{
			return default(HDHAHFKGGAI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6AA7830", Offset = "0x6AA5E30", VA = "0x186AA7830")]
	public GILOHHMHLLN(JKGBAPEDMGJ JGEMMJEFOMN, JKGBAPEDMGJ LDJCBIBELIM, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface ACAGJKBHNFN
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KPEPDKLILEK GEBPHFIJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIFHKOLJDOL(FHIOCBHJNHK EHABNPPLNPG);

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OILDKDGNOMB([In] GILOHHMHLLN JGCMECODHDI, bool BCNPKHABFBL = true);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FABGBKCDGJF(JKGBAPEDMGJ MHEJCKDLEJM);

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CEJEPBILKOJ(JKGBAPEDMGJ BNNBHPJIPAL, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IAFBMCBELLL(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ENOKKHKKMCA();

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HCPJLGBFCBP(Func<JKGBAPEDMGJ, bool> KHEBOEENKHI);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CKMHKNGAPII(JKGBAPEDMGJ GMLGNLBKHFJ, HashSet<JKGBAPEDMGJ> DGBFBJAMNHE);

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<JKGBAPEDMGJ> CHGBHBABLKL();

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LJLMHGFHAFD(JKGBAPEDMGJ GMLGNLBKHFJ, [Out] HDHAHFKGGAI PHKLAKHNMNL);

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CCGECIHNNFJ(BODHOPONGMF JMKAJHCEDCI);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool BODHOPONGMF(KPEPDKLILEK KOHLOCENPAH);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface KPEPDKLILEK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	JKGBAPEDMGJ KEPFPNKIAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KPEPDKLILEK NPDGLEPLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HDHAHFKGGAI OHEPLKGPIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool NBPJNOCMAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FNMMPAFJNAP : MIGGNMFODMK.KHDFJDKCGNC
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMLGEKNOMHA(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCCINAJCPJF(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN);

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMNCLKHLEIM(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABGOPMFAOBD(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FNMMPAFJNAP Instantiate(Transform FLDLBOHKNDN);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AGDCKPANMGG();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface LCEKIFGAPCG
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIFHKOLJDOL(Transform FLDLBOHKNDN, FNMMPAFJNAP NLNNAEIEIMP);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FNMMPAFJNAP IPINNKBKDNN();

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABGMIDFNOAD(FNMMPAFJNAP EGLPALGNHHA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FFAFDAGJCFB : KINGIDJGNNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OGPIBIKOHCA(Guid HDMMLBENEIG);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface KBOPNBNCEJG
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMHJMDKDLFB(KPEPDKLILEK ECKPCDCMHGF);

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIFHKOLJDOL(ACAGJKBHNFN BDFEFAPJDHE, LCEKIFGAPCG FLJOHEIPLLG);

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FNOOEHMLIKM();

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CPLFJDDMMCC(KPEPDKLILEK KBNFBKEMDBM);

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OEFGAAAGCKO(KPEPDKLILEK JECMHPEPOMP);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CLCNNEEFBAO();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class OBLEHAGJMML : KPEPDKLILEK
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FMMMFMEBCEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public HDHAHFKGGAI nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public OBLEHAGJMML foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public FMMMFMEBCEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6AA7170", Offset = "0x6AA5770", VA = "0x186AA7170")]
		internal bool NOFFKDGGCCN(KPEPDKLILEK x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private HDHAHFKGGAI PHKLAKHNMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public LinkedList<OBLEHAGJMML> FGHOHFEKFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private OBLEHAGJMML APDDILPGCOD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public HDHAHFKGGAI OHEPLKGPIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x39E29F0", Offset = "0x39E0FF0", VA = "0x1839E29F0", Slot = "6")]
		get
		{
			return default(HDHAHFKGGAI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3990", Offset = "0x6AB1F90", VA = "0x186AB3990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private OBLEHAGJMML LDJCBIBELIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x887850", Offset = "0x885E50", VA = "0x180887850")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x6AB39E0", Offset = "0x6AB1FE0", VA = "0x186AB39E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KPEPDKLILEK NPDGLEPLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x887850", Offset = "0x885E50", VA = "0x180887850", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public JKGBAPEDMGJ KEPFPNKIAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NBPJNOCMAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3AC0", Offset = "0x6AB20C0", VA = "0x186AB3AC0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool IBCNPGKMFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6AB3AD0", Offset = "0x6AB20D0", VA = "0x186AB3AD0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected OBLEHAGJMML JPBBEMPIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6AB39C0", Offset = "0x6AB1FC0", VA = "0x186AB39C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6AB4180", Offset = "0x6AB2780", VA = "0x186AB4180")]
	public OBLEHAGJMML(HDHAHFKGGAI OIICFAFOFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6AB36D0", Offset = "0x6AB1CD0", VA = "0x186AB36D0")]
	public OBLEHAGJMML BHLBCINICIP(HDHAHFKGGAI KPOKPKMMFBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6AB3C20", Offset = "0x6AB2220", VA = "0x186AB3C20")]
	public OBLEHAGJMML GPMKONEBJLL(HDHAHFKGGAI DNBPBHCKJKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6AB3DA0", Offset = "0x6AB23A0", VA = "0x186AB3DA0")]
	public OBLEHAGJMML MBEEDABKNGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6AB3F80", Offset = "0x6AB2580", VA = "0x186AB3F80")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6AB40D0", Offset = "0x6AB26D0", VA = "0x186AB40D0")]
	public OBLEHAGJMML PCODOFGDAIF(HDHAHFKGGAI LEEMAEKICLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6AB3830", Offset = "0x6AB1E30", VA = "0x186AB3830")]
	private static void CCGECIHNNFJ(OBLEHAGJMML GKPPEDCAFOG, BODHOPONGMF OPLFDLOEKLI, bool PMGGOLDJHKI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6AB3820", Offset = "0x6AB1E20", VA = "0x186AB3820", Slot = "9")]
	public void CCGECIHNNFJ(BODHOPONGMF JMKAJHCEDCI, bool IMCDJBIPJDI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6AB3B20", Offset = "0x6AB2120", VA = "0x186AB3B20")]
	public static OBLEHAGJMML GPCOEFNOHPP(OBLEHAGJMML GKPPEDCAFOG, HDHAHFKGGAI KMBGLJBDLMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface MEBBLNOINLC
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool IBLJOFBLDGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool DMIFGEPFKNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<FKHHMLJBCHF> LMIGIHMKGBE;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<FKHHMLJBCHF> KJEDPAEBLIJ;

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(ABKIOLMPIAK EHABNPPLNPG);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(JKGBAPEDMGJ BNNBHPJIPAL, JKGBAPEDMGJ NNJPJBJGPIA, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(PHAOBOBOLNJ NDPAKEFCAAD, [Optional] FKHHMLJBCHF MANOCABBPEE);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, MEBBLNOINLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private ABKIOLMPIAK EHABNPPLNPG;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool IBLJOFBLDGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x6AB26F0", Offset = "0x6AB0CF0", VA = "0x186AB26F0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool DMIFGEPFKNN
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x6AB2750", Offset = "0x6AB0D50", VA = "0x186AB2750", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<FKHHMLJBCHF> LMIGIHMKGBE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x6AB2650", Offset = "0x6AB0C50", VA = "0x186AB2650", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6AB2830", Offset = "0x6AB0E30", VA = "0x186AB2830", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<FKHHMLJBCHF> KJEDPAEBLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6AB25B0", Offset = "0x6AB0BB0", VA = "0x186AB25B0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x6AB2790", Offset = "0x6AB0D90", VA = "0x186AB2790", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8860B0", VA = "0x180887AB0", Slot = "19")]
		public void SetManager(ABKIOLMPIAK EHABNPPLNPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6AB2580", Offset = "0x6AB0B80", VA = "0x186AB2580")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1300", Offset = "0x6AAF900", VA = "0x186AB1300", Slot = "23")]
		public void RequestMasterConnectNodes(JKGBAPEDMGJ LJILLNPANEE, int OCAKALCKIMO, JKGBAPEDMGJ PALJEDCNNHB, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1430", Offset = "0x6AAFA30", VA = "0x186AB1430", Slot = "24")]
		public void RequestMasterDisconnectNode(JKGBAPEDMGJ MHEJCKDLEJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6AB14F0", Offset = "0x6AAFAF0", VA = "0x186AB14F0", Slot = "20")]
		public void RequestMasterModifyNode(JKGBAPEDMGJ BNNBHPJIPAL, JKGBAPEDMGJ NNJPJBJGPIA, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1620", Offset = "0x6AAFC20", VA = "0x186AB1620", Slot = "21")]
		public void RequestMasterReparentNodes(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1750", Offset = "0x6AAFD50", VA = "0x186AB1750", Slot = "25")]
		public void RequestMasterReparentToRoot(JKGBAPEDMGJ LDDIOHEAPDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6AB11D0", Offset = "0x6AAF7D0", VA = "0x186AB11D0", Slot = "22")]
		public void RequestDeserializeConnectableGraph(PHAOBOBOLNJ NDPAKEFCAAD, [Optional] FKHHMLJBCHF MANOCABBPEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1B30", Offset = "0x6AB0130", VA = "0x186AB1B30")]
		[CALMNHBOCBN]
		private void RpcMasterConnectNodes(JKGBAPEDMGJ LJILLNPANEE, int OCAKALCKIMO, JKGBAPEDMGJ PALJEDCNNHB, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1DF0", Offset = "0x6AB03F0", VA = "0x186AB1DF0")]
		[CALMNHBOCBN]
		private void RpcMasterDisconnectNode(JKGBAPEDMGJ MHEJCKDLEJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6AB2130", Offset = "0x6AB0730", VA = "0x186AB2130")]
		[CALMNHBOCBN]
		private void RpcMasterReparentNodes(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1F30", Offset = "0x6AB0530", VA = "0x186AB1F30")]
		[CALMNHBOCBN]
		private void RpcMasterModifyNode(JKGBAPEDMGJ BNNBHPJIPAL, JKGBAPEDMGJ NNJPJBJGPIA, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1920", Offset = "0x6AAFF20", VA = "0x186AB1920")]
		[CALMNHBOCBN]
		private void RpcConnectNodes(JKGBAPEDMGJ LJILLNPANEE, int OCAKALCKIMO, JKGBAPEDMGJ PALJEDCNNHB, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ, ANNBFJKOLHL CPHDIHMBDPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1AA0", Offset = "0x6AB00A0", VA = "0x186AB1AA0")]
		[CALMNHBOCBN]
		private void RpcDisconnectNode(JKGBAPEDMGJ MHEJCKDLEJM, ANNBFJKOLHL CPHDIHMBDPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6AB2480", Offset = "0x6AB0A80", VA = "0x186AB2480")]
		[CALMNHBOCBN]
		private void RpcReparentNodes(JKGBAPEDMGJ LDDIOHEAPDG, int ILAHGDPBKKB, JKGBAPEDMGJ LEEMAEKICLM, int CLLLKNBHIOD, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ, ANNBFJKOLHL CPHDIHMBDPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6AB23C0", Offset = "0x6AB09C0", VA = "0x186AB23C0")]
		[CALMNHBOCBN]
		private void RpcModifyNode(JKGBAPEDMGJ BNNBHPJIPAL, int OCAKALCKIMO, int PPGHOBGEOGE, Vector3 GGECHGICAME, Quaternion OKBBDAFCHNJ, ANNBFJKOLHL CPHDIHMBDPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6AB1A60", Offset = "0x6AB0060", VA = "0x186AB1A60")]
		[CALMNHBOCBN]
		private void RpcDeserializeConnectableGraph(PHAOBOBOLNJ BDFEFAPJDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8A2270", Offset = "0x8A0870", VA = "0x1808A2270")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, FNMMPAFJNAP, MIGGNMFODMK.KHDFJDKCGNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6AB0D70", Offset = "0x6AAF370", VA = "0x186AB0D70", Slot = "4")]
		private void JMCFJKOJONG(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6AB0F60", Offset = "0x6AAF560", VA = "0x186AB0F60", Slot = "5")]
		private void PHDNLHNMKFG(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x6AB0A10", Offset = "0x6AAF010", VA = "0x186AB0A10", Slot = "6")]
		private void BGPBOPDPCOF(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6AB0B20", Offset = "0x6AAF120", VA = "0x186AB0B20", Slot = "7")]
		private void CKAOIJHAIBL(JKGBAPEDMGJ PALJEDCNNHB, HDHAHFKGGAI JGEMMJEFOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6AB0EF0", Offset = "0x6AAF4F0", VA = "0x186AB0EF0", Slot = "8")]
		private FNMMPAFJNAP KKHFECLIPKC(Transform FLDLBOHKNDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6AB0D10", Offset = "0x6AAF310", VA = "0x186AB0D10", Slot = "9")]
		private void GDNLIDPLGFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class NNKBLPFCFIO
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2E22100", Offset = "0x2E20700", VA = "0x182E22100")]
	public static NANBFBCLJBB<T> IMOIHLJDLKI<T>(this JEFLJDHAGDI EOPOOELIKIH)
	{
		return null;
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
