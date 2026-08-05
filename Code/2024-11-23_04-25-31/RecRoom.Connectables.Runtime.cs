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
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Connectables_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : IGBHOMLLHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D358E0", Offset = "0x6D342E0", VA = "0x186D358E0", Slot = "4")]
		public override void KFMGLABNFNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
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
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private ServiceBitset bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8AD530", Offset = "0x8ABF30", VA = "0x1808AD530", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6D36420", Offset = "0x6D34E20", VA = "0x186D36420", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6D35E00", Offset = "0x6D34800", VA = "0x186D35E00")]
		private void ACOMFCOBJKA(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D35F70", Offset = "0x6D34970", VA = "0x186D35F70")]
		private void MODGDFGCADD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D360E0", Offset = "0x6D34AE0", VA = "0x186D360E0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D36460", Offset = "0x6D34E60", VA = "0x186D36460")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class FFPGAGECABH : INBNJOEBHLI, CGBLBMCHGNL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class IGOBIPOFOMH : IEnumerable<CNJKDEGGJHP>, IEnumerable, IEnumerator<CNJKDEGGJHP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private CNJKDEGGJHP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private PPOLLJKPCNH localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public PPOLLJKPCNH <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public FFPGAGECABH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private AEBGFDOLDHN <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private JLGFNBKOOPK.KLDKFCLDHGI <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private CNJKDEGGJHP System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8FD7C0", Offset = "0x8FC1C0", VA = "0x1808FD7C0")]
		[DebuggerHidden]
		public IGOBIPOFOMH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6D31260", Offset = "0x6D2FC60", VA = "0x186D31260", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6D30DA0", Offset = "0x6D2F7A0", VA = "0x186D30DA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6D30D80", Offset = "0x6D2F780", VA = "0x186D30D80")]
		private void BFPHAGOPJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6D31210", Offset = "0x6D2FC10", VA = "0x186D31210", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6D31160", Offset = "0x6D2FB60", VA = "0x186D31160", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CNJKDEGGJHP> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6D31160", Offset = "0x6D2FB60", VA = "0x186D31160", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class KPMMMJHNMCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public FFPGAGECABH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public PLLLBFGFLFO nodeData;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public KPMMMJHNMCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6D31AB0", Offset = "0x6D304B0", VA = "0x186D31AB0")]
		internal object KKKAHODGIIA(PLLLBFGFLFO x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DAACHLHIMAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public PLLLBFGFLFO child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public KPMMMJHNMCL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public DAACHLHIMAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6D294B0", Offset = "0x6D27EB0", VA = "0x186D294B0")]
		internal object KKIEFFMIDCK((PLLLBFGFLFO child, PLLLBFGFLFO nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly KLEHBGEJMBN HCKBPOJINJG;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly KLEHBGEJMBN MCEMOIEKCAF;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly KLEHBGEJMBN DJEJOJIABJJ;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly KLEHBGEJMBN KCBIGABPEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private DDKKDJPKBNM DHEFNLNAPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private LEGOIMIDOML CGCEELNOAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private EOCIEIGBAMG AOCHDDFPHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private OOFFCEEPMOH LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private AOIIGGGGAPO PPGJNAJBJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HGPNIGKDALD KGNEDNNDCGP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool EHENKOHBJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE220", Offset = "0x8BCC20", VA = "0x1808BE220", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BDC10", Offset = "0x8BC610", VA = "0x1808BDC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MJELFDKKEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<CNJKDEGGJHP, CNJKDEGGJHP> KDBPPLHCLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D2ECA0", Offset = "0x6D2D6A0", VA = "0x186D2ECA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D2CBF0", Offset = "0x6D2B5F0", VA = "0x186D2CBF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<CNJKDEGGJHP, CNJKDEGGJHP> DFFLEINFKPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D2CEB0", Offset = "0x6D2B8B0", VA = "0x186D2CEB0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D2BB30", Offset = "0x6D2A530", VA = "0x186D2BB30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<CNJKDEGGJHP, CNJKDEGGJHP, CNJKDEGGJHP> GNAJECMBGNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D2BA10", Offset = "0x6D2A410", VA = "0x186D2BA10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D2D8A0", Offset = "0x6D2C2A0", VA = "0x186D2D8A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D30120", Offset = "0x6D2EB20", VA = "0x186D30120")]
	public FFPGAGECABH(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D2D630", Offset = "0x6D2C030", VA = "0x186D2D630", Slot = "12")]
	public void GCHKJEOLKFE(GameObject NJFNKLJIFDE, DGGDGHJBBEF ANHHFAJMJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6D2D240", Offset = "0x6D2BC40", VA = "0x186D2D240", Slot = "26")]
	public void ENOAJELNKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6D2E120", Offset = "0x6D2CB20", VA = "0x186D2E120", Slot = "22")]
	public bool IEILPLBLJOG(PLLLBFGFLFO KENDFLINCBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6D2D950", Offset = "0x6D2C350", VA = "0x186D2D950")]
	private void GJHFBHFPDKO(PPOLLJKPCNH HPNMCLDJEPL, PPOLLJKPCNH NPLNPAAMEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F180", Offset = "0x6D2DB80", VA = "0x186D2F180")]
	private void MGAJODJDKCE(PPOLLJKPCNH HPNMCLDJEPL, PPOLLJKPCNH FHJINKFIOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D2FCC0", Offset = "0x6D2E6C0", VA = "0x186D2FCC0")]
	private void PALPKGEICKL(PPOLLJKPCNH HPNMCLDJEPL, PPOLLJKPCNH FHJINKFIOIA, PPOLLJKPCNH NPLNPAAMEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D2C7E0", Offset = "0x6D2B1E0", VA = "0x186D2C7E0")]
	private void DLDOMGMDGME(PPOLLJKPCNH HPNMCLDJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "13")]
	public void HIEHKMNLIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D2EE00", Offset = "0x6D2D800", VA = "0x186D2EE00", Slot = "14")]
	public void KFMGLABNFNG(CNJKDEGGJHP LMJNGKAIDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "15")]
	public void INPOOCDAMHF(CNJKDEGGJHP LMJNGKAIDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6D2EB40", Offset = "0x6D2D540", VA = "0x186D2EB40", Slot = "17")]
	public void JPLOFCABLKD(CNJKDEGGJHP LMJNGKAIDMM, CNJKDEGGJHP MBPDCPMPDGG, Vector3 MBNCLINCGNN, Quaternion OMHOPFBFJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D2EA00", Offset = "0x6D2D400", VA = "0x186D2EA00")]
	public void JPLOFCABLKD(PPOLLJKPCNH FHMNKMMPPIB, PPOLLJKPCNH MBPDCPMPDGG, Vector3 MBNCLINCGNN, Quaternion OMHOPFBFJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D2ED50", Offset = "0x6D2D750", VA = "0x186D2ED50")]
	public void KECEIDOMGLJ(CNJKDEGGJHP LMJNGKAIDMM, float NCBFNFENEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D2E490", Offset = "0x6D2CE90", VA = "0x186D2E490", Slot = "18")]
	public void JJPOMJOJEDI(CNJKDEGGJHP CLJIMJAIFKC, int KEMAKMPOIGK, CNJKDEGGJHP EPJPGFGIBOG, int HOBOPPJNOJH, Vector3 MBNCLINCGNN, Quaternion OMHOPFBFJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6D2FF20", Offset = "0x6D2E920", VA = "0x186D2FF20")]
	private float PBLNGALILOL(PPOLLJKPCNH FHMNKMMPPIB, PPOLLJKPCNH NNFBEGDDJKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6D2E300", Offset = "0x6D2CD00", VA = "0x186D2E300")]
	public void JJPOMJOJEDI(PPOLLJKPCNH FHMNKMMPPIB, PPOLLJKPCNH NNFBEGDDJKL, Vector3 MBNCLINCGNN, Quaternion OMHOPFBFJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D2E430", Offset = "0x6D2CE30", VA = "0x186D2E430")]
	public void JJPOMJOJEDI(PPOLLJKPCNH FHMNKMMPPIB, PPOLLJKPCNH NNFBEGDDJKL, Vector3 MBNCLINCGNN, Quaternion OMHOPFBFJAO, float NCBFNFENEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F9C0", Offset = "0x6D2E3C0", VA = "0x186D2F9C0", Slot = "19")]
	public void OBHPECNHKHF(CNJKDEGGJHP LMJNGKAIDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D2BBE0", Offset = "0x6D2A5E0", VA = "0x186D2BBE0")]
	public bool AHHHFOGPFPM(PPOLLJKPCNH FKHJJLCBKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D2CCA0", Offset = "0x6D2B6A0", VA = "0x186D2CCA0", Slot = "16")]
	public void DPHIHHNNADC(CNJKDEGGJHP LMJNGKAIDMM, HashSet<CNJKDEGGJHP> GANPDGMNADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "20")]
	public PMCFCEKPJLA MCILCCFKBIG(bool EEIFLKFMEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "21")]
	public PMCFCEKPJLA IOFMAAKJOMO(HashSet<Guid> OHENNIFLAJA, bool EEIFLKFMEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D2BAC0", Offset = "0x6D2A4C0", VA = "0x186D2BAC0", Slot = "23")]
	public void AFKHFOJOIPA(PMCFCEKPJLA ADJABNNJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2DD50", Offset = "0x6D2C750", VA = "0x186D2DD50", Slot = "24")]
	public void HIJJHAJOGEB(PMCFCEKPJLA ADJABNNJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D2EDE0", Offset = "0x6D2D7E0", VA = "0x186D2EDE0", Slot = "25")]
	public void KEJLPBPJPDM(PMCFCEKPJLA ADJABNNJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D2BE70", Offset = "0x6D2A870", VA = "0x186D2BE70")]
	private void BJEGGNCLPKP(PPOLLJKPCNH FHMNKMMPPIB, PPOLLJKPCNH NNFBEGDDJKL, Vector3 MBNCLINCGNN, Quaternion OMHOPFBFJAO, float NCBFNFENEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6D2E5E0", Offset = "0x6D2CFE0", VA = "0x186D2E5E0")]
	private void JMBFCLOGIPP(PPOLLJKPCNH FHMNKMMPPIB, PPOLLJKPCNH AOBPGDDFDPP, Vector3 MBNCLINCGNN, Quaternion OMHOPFBFJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F110", Offset = "0x6D2DB10", VA = "0x186D2F110")]
	private void KJJLKPJIKCH(PPOLLJKPCNH FHMNKMMPPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F930", Offset = "0x6D2E330", VA = "0x186D2F930")]
	[IteratorStateMachine(typeof(IGOBIPOFOMH))]
	public IEnumerable<CNJKDEGGJHP> OAFBKDPMIGF(PPOLLJKPCNH FKHJJLCBKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D2C6A0", Offset = "0x6D2B0A0", VA = "0x186D2C6A0")]
	internal CNJKDEGGJHP DIGAOOBCEEJ(PPOLLJKPCNH FKHJJLCBKFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6D2C1D0", Offset = "0x6D2ABD0", VA = "0x186D2C1D0")]
	internal PPOLLJKPCNH DACPBFKCFAK(CNJKDEGGJHP LMJNGKAIDMM)
	{
		return default(PPOLLJKPCNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D2F3A0", Offset = "0x6D2DDA0", VA = "0x186D2F3A0")]
	private bool NKPKPAIHDEL(PLLLBFGFLFO KENDFLINCBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D2DB60", Offset = "0x6D2C560", VA = "0x186D2DB60")]
	private bool HAIBEGNBMOB(PLLLBFGFLFO KENDFLINCBC, [Out] CNJKDEGGJHP NNFBEGDDJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D2C310", Offset = "0x6D2AD10", VA = "0x186D2C310")]
	private CNJKDEGGJHP DIGAOOBCEEJ(PLLLBFGFLFO KENDFLINCBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6D2DDC0", Offset = "0x6D2C7C0", VA = "0x186D2DDC0")]
	private CNJKDEGGJHP HILFEJNEMLP(PLLLBFGFLFO KENDFLINCBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D2DF50", Offset = "0x6D2C950", VA = "0x186D2DF50")]
	private CNJKDEGGJHP IBJIBHFBFBF(PLLLBFGFLFO KENDFLINCBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6D25490", Offset = "0x6D23E90", VA = "0x186D25490")]
	private static Guid IFFGKJMMIPF(PLLLBFGFLFO KENDFLINCBC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D2D540", Offset = "0x6D2BF40", VA = "0x186D2D540")]
	private string FKJIILMPMMB(PLLLBFGFLFO KENDFLINCBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6D2DBC0", Offset = "0x6D2C5C0", VA = "0x186D2DBC0")]
	private void HHCAMBCPAPC(CNJKDEGGJHP FHMNKMMPPIB, CNJKDEGGJHP AOBPGDDFDPP, RigidTransform JLAOJDHGLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D2FB30", Offset = "0x6D2E530", VA = "0x186D2FB30")]
	private void OCPHGKBKLHJ(CNJKDEGGJHP AOBPGDDFDPP, CNJKDEGGJHP FHMNKMMPPIB, RigidTransform JLAOJDHGLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6D2D1E0", Offset = "0x6D2BBE0", VA = "0x186D2D1E0")]
	private void EKAKJOCEBPH(CNJKDEGGJHP ABAGGDDNNJL, CNJKDEGGJHP FHMNKMMPPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D2E170", Offset = "0x6D2CB70", VA = "0x186D2E170")]
	private void IEMIJFMIIEA(CNJKDEGGJHP FHMNKMMPPIB, CNJKDEGGJHP NNFBEGDDJKL, RigidTransform JLAOJDHGLJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6D2D430", Offset = "0x6D2BE30", VA = "0x186D2D430")]
	private void EPIFHACEPKN(PPOLLJKPCNH FKHJJLCBKFN, CNJKDEGGJHP LMJNGKAIDMM, PPOLLJKPCNH FHJINKFIOIA, PPOLLJKPCNH NPLNPAAMEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D2CF60", Offset = "0x6D2B960", VA = "0x186D2CF60")]
	private void EGGFGPKJIOC(PPOLLJKPCNH FKHJJLCBKFN, CNJKDEGGJHP LMJNGKAIDMM, CNJKDEGGJHP MAJFAFAPLMJ, CNJKDEGGJHP KBEMHCJOEGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CPBIAEFPDED
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class LGFKNKDKKMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public KNPHAFHLPCE container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public LGFKNKDKKMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D31B20", Offset = "0x6D30520", VA = "0x186D31B20")]
		internal FFPGAGECABH HFLDFMOHJEA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6D291D0", Offset = "0x6D27BD0", VA = "0x186D291D0")]
	public static void KCHHHAPJJLG(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6D29350", Offset = "0x6D27D50", VA = "0x186D29350")]
	public static void NLACONBBBNE(KNPHAFHLPCE DNJEODDCEHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class LOADHJCMONC : GBMMCKGEMKI, LHCLCHHLODI
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx IENODGFEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly FFPGAGECABH FJNAKFEJNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly JFGBIGLKDHF KNGNCDJBGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly FBBGDDLNNIN LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly BEMKBHJBCBB[] JGJFHFDPBFI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PPOLLJKPCNH MDFEOCGBIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8AD530", Offset = "0x8ABF30", VA = "0x1808AD530", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(PPOLLJKPCNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CNJKDEGGJHP EBCDHOFLNCF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6D337A0", Offset = "0x6D321A0", VA = "0x186D337A0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CNJKDEGGJHP LINIPGBHKFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6D32860", Offset = "0x6D31260", VA = "0x186D32860", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 OMNGNPEFLCF
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6D31DD0", Offset = "0x6D307D0", VA = "0x186D31DD0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion JAINMEGMFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6D31C80", Offset = "0x6D30680", VA = "0x186D31C80", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IMDKKADOPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6D333E0", Offset = "0x6D31DE0", VA = "0x186D333E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<CNJKDEGGJHP> HNAJGKLCHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6D32000", Offset = "0x6D30A00", VA = "0x186D32000", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool FHDNHGOPOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9349D0", Offset = "0x9333D0", VA = "0x1809349D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x93E990", Offset = "0x93D390", VA = "0x18093E990", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform DNOKGDKBFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D339B0", Offset = "0x6D323B0", VA = "0x186D339B0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject LCAKBKAANHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2864E30", Offset = "0x2863830", VA = "0x182864E30", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string OENPDLODONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D336D0", Offset = "0x6D320D0", VA = "0x186D336D0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid ENMMMHBJMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6D33800", Offset = "0x6D32200", VA = "0x186D33800", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OHAJAIDBNOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6D338E0", Offset = "0x6D322E0", VA = "0x186D338E0", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool HHEEGGGMBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool MAGCJJNEEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6D33110", Offset = "0x6D31B10", VA = "0x186D33110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event KBGIJPKEPIO CFECKJFJBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6D330B0", Offset = "0x6D31AB0", VA = "0x186D330B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6D32800", Offset = "0x6D31200", VA = "0x186D32800", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event KBGIJPKEPIO GINFDMGIPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6D327A0", Offset = "0x6D311A0", VA = "0x186D327A0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6D31C20", Offset = "0x6D30620", VA = "0x186D31C20", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event KBGIJPKEPIO NBHAHOAACPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6D33450", Offset = "0x6D31E50", VA = "0x186D33450", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D31E30", Offset = "0x6D30830", VA = "0x186D31E30", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event BHCMPDFKCAI EKJCGOKHION
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D32D30", Offset = "0x6D31730", VA = "0x186D32D30", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D31CE0", Offset = "0x6D306E0", VA = "0x186D31CE0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D335D0", Offset = "0x6D31FD0", VA = "0x186D335D0")]
	public LOADHJCMONC(PPOLLJKPCNH ICDADLEHPCK, RigidbodyEx IENODGFEGDN, JFGBIGLKDHF KNGNCDJBGBM, BEMKBHJBCBB[] JGJFHFDPBFI, FBBGDDLNNIN LPMHKEAJABJ, INBNJOEBHLI FJNAKFEJNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D33500", Offset = "0x6D31F00", VA = "0x186D33500", Slot = "19")]
	public void POAPKFKGGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "21")]
	public void DMLMGMGMPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B80660", Offset = "0x6B7F060", VA = "0x186B80660", Slot = "22")]
	public void GCIIJPMFCII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6D334B0", Offset = "0x6D31EB0", VA = "0x186D334B0", Slot = "20")]
	public void PMHKFLKJGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6D32030", Offset = "0x6D30A30", VA = "0x186D32030", Slot = "25")]
	public void GFCJMDKDADJ(int HGBFJCLPFOC, CNJKDEGGJHP EPJPGFGIBOG, int KPOEOBKLLID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6D31F30", Offset = "0x6D30930", VA = "0x186D31F30", Slot = "26")]
	public void EDHFPGLKCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6D32DD0", Offset = "0x6D317D0", VA = "0x186D32DD0", Slot = "27")]
	public void KHICIDDLHNN(int HGBFJCLPFOC, CNJKDEGGJHP CLJIMJAIFKC, int MJJOCBPKKNE, [Optional] Vector3? OOBOMCNEKOM, [Optional] Quaternion? CLOFOLGHGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6D33160", Offset = "0x6D31B60", VA = "0x186D33160", Slot = "28")]
	public void NKCELEAICIC(CNJKDEGGJHP CLJIMJAIFKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6D32920", Offset = "0x6D31320", VA = "0x186D32920", Slot = "31")]
	public void JNOKPKLBMOG(Vector3 MFEJCPKGNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6D32440", Offset = "0x6D30E40", VA = "0x186D32440", Slot = "29")]
	public void HHDNIHEFFIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6D331E0", Offset = "0x6D31BE0", VA = "0x186D331E0", Slot = "30")]
	public void ODAIFFJCGAC(int GCBONJOGHCD, Vector3 BODEELBOMLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D32370", Offset = "0x6D30D70", VA = "0x186D32370", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int HGBFJCLPFOC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6D32240", Offset = "0x6D30C40", VA = "0x186D32240", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int HGBFJCLPFOC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9DB6A0", Offset = "0x9DA0A0", VA = "0x1809DB6A0", Slot = "42")]
	public Color GetConnectionSlotColor(int HGBFJCLPFOC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6D31E90", Offset = "0x6D30890", VA = "0x186D31E90", Slot = "43")]
	public bool CanConnectTo(int HGBFJCLPFOC, CNJKDEGGJHP DAPDBJMLAJC, int ELFCMANOBBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "44")]
	public void ParentChanged(int HGBFJCLPFOC, CNJKDEGGJHP ADCIMJHLPJO, int GBAFFBNNGOD, Vector3 KGNLIDKOOJD, Quaternion LIMCDNDPOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "45")]
	public void ChildAdded(int HGBFJCLPFOC, CNJKDEGGJHP ECKPIOGLFOJ, int AOPOFJLADAM, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "46")]
	public void ChildRemoved(int HGBFJCLPFOC, CNJKDEGGJHP JLBCFDKFAFC, int ICODPELDKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "47")]
	public void ConnectionModified(int HGBFJCLPFOC, CNJKDEGGJHP EPJPGFGIBOG, int KPOEOBKLLID, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6D33530", Offset = "0x6D31F30", VA = "0x186D33530", Slot = "48")]
	public void RootChanged(CNJKDEGGJHP CKCCOKGGIPO, CNJKDEGGJHP HMBLDOENEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6D31BD0", Offset = "0x6D305D0", VA = "0x186D31BD0", Slot = "23")]
	public void ACPALNLHFHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D31D80", Offset = "0x6D30780", VA = "0x186D31D80", Slot = "24")]
	public void CEBBDDMFDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D32750", Offset = "0x6D31150", VA = "0x186D32750")]
	private void HJNFNEIMBMB(bool FMHNIGLGBBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(DKKOLFNHPNK), new string[] { })]
public class ICDLAEEMPLH : DKKOLFNHPNK, GPMHGHCNDML, DGPGGKHFMFC
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class ABNNJJDCFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public ICDLAEEMPLH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public JLGFNBKOOPK localIds;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public ABNNJJDCFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6D20D90", Offset = "0x6D1F790", VA = "0x186D20D90")]
		internal void FGIBBIFAHCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[DependsOn]
	private HMLBMEKJNDI BNEOBONNMCF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object CNHIPPDPLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D30190", Offset = "0x6D2EB90", VA = "0x186D30190", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6D30220", Offset = "0x6D2EC20", VA = "0x186D30220", Slot = "5")]
	public void NIDODLNCLBK(JLGFNBKOOPK BDIKAGAIBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6D30380", Offset = "0x6D2ED80", VA = "0x186D30380", Slot = "6")]
	private void OHIECHPGLCJ(POGCJGLPEEP KGNEDNNDCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xC796A0", Offset = "0xC780A0", VA = "0x180C796A0", Slot = "7")]
	private void ACPNJHKHIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public ICDLAEEMPLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(INBNJOEBHLI), new string[] { "Ignore", "Mock" })]
public class EGPPCNFBLCE : INBNJOEBHLI, CGBLBMCHGNL
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool EHENKOHBJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool MJELFDKKEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<CNJKDEGGJHP, CNJKDEGGJHP> KDBPPLHCLBE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6D2AE00", Offset = "0x6D29800", VA = "0x186D2AE00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6D2ABF0", Offset = "0x6D295F0", VA = "0x186D2ABF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<CNJKDEGGJHP, CNJKDEGGJHP> DFFLEINFKPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6D2ACA0", Offset = "0x6D296A0", VA = "0x186D2ACA0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6D2AB40", Offset = "0x6D29540", VA = "0x186D2AB40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<CNJKDEGGJHP, CNJKDEGGJHP, CNJKDEGGJHP> GNAJECMBGNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6D2AA90", Offset = "0x6D29490", VA = "0x186D2AA90", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6D2AD50", Offset = "0x6D29750", VA = "0x186D2AD50", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "26")]
	public void ENOAJELNKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "12")]
	public void GCHKJEOLKFE(GameObject NJFNKLJIFDE, DGGDGHJBBEF ANHHFAJMJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "13")]
	public void HIEHKMNLIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "14")]
	public void KFMGLABNFNG(CNJKDEGGJHP LMJNGKAIDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "15")]
	public void INPOOCDAMHF(CNJKDEGGJHP LMJNGKAIDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "16")]
	public void DPHIHHNNADC(CNJKDEGGJHP LMJNGKAIDMM, HashSet<CNJKDEGGJHP> GANPDGMNADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "17")]
	public void JPLOFCABLKD(CNJKDEGGJHP LMJNGKAIDMM, CNJKDEGGJHP MBPDCPMPDGG, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "18")]
	public void JJPOMJOJEDI(CNJKDEGGJHP LMJNGKAIDMM, int PPLIIJMLBOM, CNJKDEGGJHP AOBPGDDFDPP, int GBAFFBNNGOD, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "19")]
	public void OBHPECNHKHF(CNJKDEGGJHP LMJNGKAIDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "20")]
	public PMCFCEKPJLA MCILCCFKBIG(bool EEIFLKFMEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA60", Offset = "0x8AB460", VA = "0x1808ACA60", Slot = "21")]
	public PMCFCEKPJLA IOFMAAKJOMO(HashSet<Guid> OHENNIFLAJA, bool EEIFLKFMEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "22")]
	public bool IEILPLBLJOG(PLLLBFGFLFO KENDFLINCBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "23")]
	public void AFKHFOJOIPA(PMCFCEKPJLA ADJABNNJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "24")]
	public void HIJJHAJOGEB(PMCFCEKPJLA ADJABNNJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "25")]
	public void KEJLPBPJPDM(PMCFCEKPJLA ADJABNNJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public EGPPCNFBLCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CNJKDEGGJHP : LHCLCHHLODI, IEquatable<CNJKDEGGJHP>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LHCLCHHLODI
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	CNJKDEGGJHP EBCDHOFLNCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform DNOKGDKBFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject LCAKBKAANHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string OENPDLODONH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid ENMMMHBJMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int OHAJAIDBNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	PPOLLJKPCNH MDFEOCGBIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HHEEGGGMBKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int HGBFJCLPFOC);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int HGBFJCLPFOC);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int HGBFJCLPFOC);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int HGBFJCLPFOC, CNJKDEGGJHP DAPDBJMLAJC, int JEHGJJMEBJB);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int HGBFJCLPFOC, CNJKDEGGJHP ADCIMJHLPJO, int GBAFFBNNGOD, Vector3 KGNLIDKOOJD, Quaternion LIMCDNDPOFO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int HGBFJCLPFOC, CNJKDEGGJHP ECKPIOGLFOJ, int AOPOFJLADAM, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int HGBFJCLPFOC, CNJKDEGGJHP JLBCFDKFAFC, int ICODPELDKKM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int HGBFJCLPFOC, CNJKDEGGJHP EPJPGFGIBOG, int LDNHGBAFPPK, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(CNJKDEGGJHP CKCCOKGGIPO, CNJKDEGGJHP HMBLDOENEAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface INBNJOEBHLI : CGBLBMCHGNL
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool EHENKOHBJJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MJELFDKKEJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<CNJKDEGGJHP, CNJKDEGGJHP> KDBPPLHCLBE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<CNJKDEGGJHP, CNJKDEGGJHP> DFFLEINFKPN;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<CNJKDEGGJHP, CNJKDEGGJHP, CNJKDEGGJHP> GNAJECMBGNC;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GCHKJEOLKFE(GameObject NJFNKLJIFDE, DGGDGHJBBEF ANHHFAJMJOI);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HIEHKMNLIKI();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KFMGLABNFNG(CNJKDEGGJHP LMJNGKAIDMM);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void INPOOCDAMHF(CNJKDEGGJHP LMJNGKAIDMM);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DPHIHHNNADC(CNJKDEGGJHP LMJNGKAIDMM, HashSet<CNJKDEGGJHP> GANPDGMNADB);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JPLOFCABLKD(CNJKDEGGJHP LMJNGKAIDMM, CNJKDEGGJHP MBPDCPMPDGG, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JJPOMJOJEDI(CNJKDEGGJHP LMJNGKAIDMM, int PPLIIJMLBOM, CNJKDEGGJHP AOBPGDDFDPP, int GBAFFBNNGOD, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OBHPECNHKHF(CNJKDEGGJHP LMJNGKAIDMM);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	PMCFCEKPJLA MCILCCFKBIG(bool EEIFLKFMEDC);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	PMCFCEKPJLA IOFMAAKJOMO(HashSet<Guid> OHENNIFLAJA, bool EEIFLKFMEDC);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool IEILPLBLJOG(PLLLBFGFLFO KENDFLINCBC);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void AFKHFOJOIPA(PMCFCEKPJLA ADJABNNJNMI);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HIJJHAJOGEB(PMCFCEKPJLA ADJABNNJNMI);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KEJLPBPJPDM(PMCFCEKPJLA ADJABNNJNMI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OOFFCEEPMOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool AMMJCMAEPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CNJKDEGGJHP IBJIBHFBFBF(int LEBGEDDPMGE);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CNJKDEGGJHP HILFEJNEMLP(Guid IFCCBCDJADL);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KKLMNEFIIHN(CNJKDEGGJHP LMJNGKAIDMM);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DLGLEHAFCEA();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AHHBCEOBLMG(CNJKDEGGJHP KNGNCDJBGBM);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface FBBGDDLNNIN
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MAGCJJNEEJB(JFGBIGLKDHF KNGNCDJBGBM);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EBJBCNIHNBO(JFGBIGLKDHF KNGNCDJBGBM);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string LEOPEEFLAFM(JFGBIGLKDHF KNGNCDJBGBM);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid DMIOJHBLLPB(JFGBIGLKDHF KNGNCDJBGBM);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NIIKAFFACAI(JFGBIGLKDHF KNGNCDJBGBM);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PHLALFIHNLB(JFGBIGLKDHF KNGNCDJBGBM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void KBGIJPKEPIO(CNJKDEGGJHP CLJIMJAIFKC, int GEAOPJDBNAJ, CNJKDEGGJHP EPJPGFGIBOG, int GCBENLMHMPC, [Optional] Vector3? OOBOMCNEKOM, [Optional] Quaternion? CLOFOLGHGAK);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void BHCMPDFKCAI(CNJKDEGGJHP CKCCOKGGIPO, CNJKDEGGJHP HMBLDOENEAJ);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JFGBIGLKDHF : CNJKDEGGJHP, LHCLCHHLODI, IEquatable<CNJKDEGGJHP>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GBMMCKGEMKI : LHCLCHHLODI
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	CNJKDEGGJHP LINIPGBHKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<CNJKDEGGJHP> HNAJGKLCHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 OMNGNPEFLCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion JAINMEGMFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool IMDKKADOPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool FHDNHGOPOMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event KBGIJPKEPIO CFECKJFJBPC;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event KBGIJPKEPIO GINFDMGIPEM;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event KBGIJPKEPIO NBHAHOAACPK;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event BHCMPDFKCAI EKJCGOKHION;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void POAPKFKGGGK();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PMHKFLKJGHI();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DMLMGMGMPBF();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void GCIIJPMFCII();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ACPALNLHFHP();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CEBBDDMFDDG();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GFCJMDKDADJ(int HGBFJCLPFOC, CNJKDEGGJHP EPJPGFGIBOG, int KPOEOBKLLID);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EDHFPGLKCFC();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KHICIDDLHNN(int HGBFJCLPFOC, CNJKDEGGJHP CLJIMJAIFKC, int MJJOCBPKKNE, [Optional] Vector3? OOBOMCNEKOM, [Optional] Quaternion? CLOFOLGHGAK);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NKCELEAICIC(CNJKDEGGJHP CLJIMJAIFKC);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void HHDNIHEFFIN();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ODAIFFJCGAC(int GCBONJOGHCD, Vector3 BODEELBOMLJ);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JNOKPKLBMOG(Vector3 MFEJCPKGNGM);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BEMKBHJBCBB
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 MKMBPADECNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DGGDGHJBBEF
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool DGDCKCLGBLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	PADEDAJFEFD PFEPMEFKKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, DGGDGHJBBEF
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
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xBB0080", Offset = "0xBAEA80", VA = "0x180BB0080", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public PADEDAJFEFD LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6D293A0", Offset = "0x6D27DA0", VA = "0x186D293A0")]
		public static ConnectableConfigData BPNHHIPIMCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6D29460", Offset = "0x6D27E60", VA = "0x186D29460")]
		public ConnectableConfigData(LegacyConnectableLinkVisual AINGMPICLJH, bool JJNDMIFIJGE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct EFDKNGDNCMC : IEquatable<EFDKNGDNCMC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public CNJKDEGGJHP LMJNGKAIDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int JHMIOGNAOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int LDNHGBAFPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 OOBOMCNEKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion CLOFOLGHGAK;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6D2AA30", Offset = "0x6D29430", VA = "0x186D2AA30")]
	public EFDKNGDNCMC(CNJKDEGGJHP LMJNGKAIDMM, int JHMIOGNAOMC, int LDNHGBAFPPK, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A910", Offset = "0x6D29310", VA = "0x186D2A910")]
	public EFDKNGDNCMC(CNJKDEGGJHP LMJNGKAIDMM, int JHMIOGNAOMC, int LDNHGBAFPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A9B0", Offset = "0x6D293B0", VA = "0x186D2A9B0")]
	public EFDKNGDNCMC(CNJKDEGGJHP LMJNGKAIDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A4A0", Offset = "0x6D28EA0", VA = "0x186D2A4A0", Slot = "4")]
	public bool Equals(EFDKNGDNCMC GDOGPMPJPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A550", Offset = "0x6D28F50", VA = "0x186D2A550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class BGGDJECELEH : FCOIGJPBCOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform FOBEMKFOBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private PADEDAJFEFD AINMFCHEGEE;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x67EE420", Offset = "0x67ECE20", VA = "0x1867EE420", Slot = "4")]
	public void GCHKJEOLKFE(Transform FOBEMKFOBOH, PADEDAJFEFD AINMFCHEGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6D26DC0", Offset = "0x6D257C0", VA = "0x186D26DC0", Slot = "5")]
	public PADEDAJFEFD IDCEPNHBOFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6D26E90", Offset = "0x6D25890", VA = "0x186D26E90", Slot = "6")]
	public void LHEFNFNLCBI(PADEDAJFEFD EJLJKHIJHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public BGGDJECELEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class APJGEJECDON : IDisposable, FMHBGBOIECC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PENMJJCKJCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CNJKDEGGJHP oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CNJKDEGGJHP newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public PENMJJCKJCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6D35BC0", Offset = "0x6D345C0", VA = "0x186D35BC0")]
		internal bool EDAOMFCBEIF(KBBNHICCOHM node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly EJEADCHPMCI BPLKHDPJJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EELCOFEALJK MJDAKLHLKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private IPGKMNHKGKE MMCIPCCEHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool JJNDMIFIJGE;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly KLEHBGEJMBN LGDJIGEMEIC;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KBBNHICCOHM BPFDMKBMANG
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6D216B0", Offset = "0x6D200B0", VA = "0x186D216B0")]
	public bool AKHGEPPHBBI([In] MMHDGPBBALG GGEMPJLCHFC, bool GADJBKMDMEE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6D219E0", Offset = "0x6D203E0", VA = "0x186D219E0")]
	private bool DFNPODLPPLN([In] MMHDGPBBALG GGEMPJLCHFC, bool GADJBKMDMEE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6D244C0", Offset = "0x6D22EC0", VA = "0x186D244C0")]
	public APJGEJECDON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6D22850", Offset = "0x6D21250", VA = "0x186D22850", Slot = "5")]
	public void GCHKJEOLKFE(INBNJOEBHLI PLJBPLDMFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6D21830", Offset = "0x6D20230", VA = "0x186D21830", Slot = "17")]
	public void BHPDEGJELDB(KHFKJMNGGLA HFJNADOBPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6D22B00", Offset = "0x6D21500", VA = "0x186D22B00", Slot = "12")]
	public void HEFBLHHEHOL(Func<CNJKDEGGJHP, bool> GGECEGBLPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6D22B10", Offset = "0x6D21510", VA = "0x186D22B10")]
	private void HEFBLHHEHOL(EJEADCHPMCI OFGAFPGJIKO, Func<CNJKDEGGJHP, bool> GGECEGBLPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6D219C0", Offset = "0x6D203C0", VA = "0x186D219C0", Slot = "11")]
	public void DDBDEOJEMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6D23A50", Offset = "0x6D22450", VA = "0x186D23A50", Slot = "8")]
	public bool OCJKFMGPNPA(CNJKDEGGJHP KKKCLPJOEDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6D23B80", Offset = "0x6D22580", VA = "0x186D23B80")]
	private bool OPJGILKGGPJ(CNJKDEGGJHP HBODNLOACNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6D23750", Offset = "0x6D22150", VA = "0x186D23750")]
	private static bool JPDGKCGOGKC(CNJKDEGGJHP HBODNLOACNK, EJEADCHPMCI IMDBCDBDODH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6D23360", Offset = "0x6D21D60", VA = "0x186D23360")]
	private void JMMMHGICMGB(Transform EFFDMOIOECA, EJEADCHPMCI LEMKOGENDIE, EJEADCHPMCI[] MAIPELPBMAF, CNJKDEGGJHP GFFJKEINDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6D22D60", Offset = "0x6D21760", VA = "0x186D22D60")]
	private EFDKNGDNCMC INMANNJOFEC(Transform LFHHEEAMHAI, EFDKNGDNCMC KGBBADKNAKH)
	{
		return default(EFDKNGDNCMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6D23100", Offset = "0x6D21B00", VA = "0x186D23100")]
	private static bool JJHLFLCNNNF(EJEADCHPMCI IMDBCDBDODH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6D22AA0", Offset = "0x6D214A0", VA = "0x186D22AA0", Slot = "9")]
	public bool GGNPPMGEMHO(CNJKDEGGJHP BCKMCONANOB, int MJJOCBPKKNE, int KPOEOBKLLID, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6D22EB0", Offset = "0x6D218B0", VA = "0x186D22EB0")]
	private bool JIBBCAADKOA(CNJKDEGGJHP BCKMCONANOB, int MJJOCBPKKNE, int KPOEOBKLLID, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6D24280", Offset = "0x6D22C80", VA = "0x186D24280")]
	private static void PLELBNCKHMA(CNJKDEGGJHP BCKMCONANOB, int MJJOCBPKKNE, int KPOEOBKLLID, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK, EJEADCHPMCI AGEJDLINKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6D22C40", Offset = "0x6D21640", VA = "0x186D22C40")]
	private void HHCAMBCPAPC(CNJKDEGGJHP LNAOPPEBDFO, int PPLIIJMLBOM, CNJKDEGGJHP AOBPGDDFDPP, int GBAFFBNNGOD, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6D239E0", Offset = "0x6D223E0", VA = "0x186D239E0")]
	private void NPFFAOCFEBI(EJEADCHPMCI OFGAFPGJIKO, CNJKDEGGJHP MAJFAFAPLMJ, CNJKDEGGJHP KBEMHCJOEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6D23970", Offset = "0x6D22370", VA = "0x186D23970")]
	private void NPFFAOCFEBI(CNJKDEGGJHP LMJNGKAIDMM, CNJKDEGGJHP MAJFAFAPLMJ, CNJKDEGGJHP KBEMHCJOEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6D22580", Offset = "0x6D20F80", VA = "0x186D22580")]
	private void EGGFGPKJIOC(CNJKDEGGJHP LMJNGKAIDMM, CNJKDEGGJHP MAJFAFAPLMJ, CNJKDEGGJHP KBEMHCJOEGI, bool ILCGKGLAAEP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6D225F0", Offset = "0x6D20FF0", VA = "0x186D225F0")]
	private void EGGFGPKJIOC(EJEADCHPMCI ELFANOAFHKM, CNJKDEGGJHP GFFJKEINDJA, CNJKDEGGJHP HMBLDOENEAJ, bool ILCGKGLAAEP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6D23A60", Offset = "0x6D22460", VA = "0x186D23A60")]
	private void OCPHGKBKLHJ(CNJKDEGGJHP FHMNKMMPPIB, int MJJOCBPKKNE, CNJKDEGGJHP AOBPGDDFDPP, int GBAFFBNNGOD, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6D226F0", Offset = "0x6D210F0", VA = "0x186D226F0")]
	private void EKAKJOCEBPH(KBBNHICCOHM NNFBEGDDJKL, KBBNHICCOHM KJGEJKCEKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6D21860", Offset = "0x6D20260", VA = "0x186D21860", Slot = "18")]
	public CNJKDEGGJHP COGDPMFIJAA(CNJKDEGGJHP LMJNGKAIDMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6D21FA0", Offset = "0x6D209A0", VA = "0x186D21FA0", Slot = "13")]
	public void DPHIHHNNADC(CNJKDEGGJHP LMJNGKAIDMM, HashSet<CNJKDEGGJHP> OMGEDBCEPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6D22340", Offset = "0x6D20D40", VA = "0x186D22340", Slot = "14")]
	public List<CNJKDEGGJHP> EDJNMAKBLMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6D22900", Offset = "0x6D21300", VA = "0x186D22900")]
	protected KBBNHICCOHM GEJDOIOMDEA(KBBNHICCOHM OFGAFPGJIKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6D232C0", Offset = "0x6D21CC0", VA = "0x186D232C0")]
	protected EJEADCHPMCI[] JLACJGLPIAD(EJEADCHPMCI IMDBCDBDODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6D21720", Offset = "0x6D20120", VA = "0x186D21720")]
	protected bool BHBMHFLLHOF(CNJKDEGGJHP LMJNGKAIDMM, [Out] EJEADCHPMCI OFGAFPGJIKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D23800", Offset = "0x6D22200", VA = "0x186D23800", Slot = "15")]
	public bool MCLMMHNJFPF(CNJKDEGGJHP LMJNGKAIDMM, [Out] EFDKNGDNCMC BPOOHMGGDBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D23930", Offset = "0x6D22330", VA = "0x186D23930")]
	protected EJEADCHPMCI NNBLDMEFBKH(EFDKNGDNCMC FJOIPOIOAGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6D216C0", Offset = "0x6D200C0", VA = "0x186D216C0", Slot = "10")]
	public bool BEPNPOKKEMK(CNJKDEGGJHP LNAOPPEBDFO, int PPLIIJMLBOM, CNJKDEGGJHP AOBPGDDFDPP, int GBAFFBNNGOD, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6D21100", Offset = "0x6D1FB00", VA = "0x186D21100")]
	private bool ACDCNFKGBKG(CNJKDEGGJHP LNAOPPEBDFO, int PPLIIJMLBOM, CNJKDEGGJHP AOBPGDDFDPP, int GBAFFBNNGOD, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6D229D0", Offset = "0x6D213D0", VA = "0x186D229D0")]
	private static bool GGMNNDHHMIF(EJEADCHPMCI CHGMLEHKNCF, EFDKNGDNCMC BENBLHJKGNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6D216B0", Offset = "0x6D200B0", VA = "0x186D216B0", Slot = "7")]
	private bool KOIOBNONKDD([In] MMHDGPBBALG GGEMPJLCHFC, bool GADJBKMDMEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class BHPCLOMBDCP : INBNJOEBHLI, CGBLBMCHGNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly KNPHAFHLPCE DNJEODDCEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly IPGKMNHKGKE MMCIPCCEHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly KDOAKMFEILD KCBCPNJMBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly BEKDNBMHPFM OALFBBPLHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly FMHBGBOIECC ADJABNNJNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal FACHBBEFNOM LPMHKEAJABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal NPEFJPLCFIG PPPAPIDLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal EELCOFEALJK GACHKDMNJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool JJNDMIFIJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool ECCEDPIPFBD;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool PIHCODHJNFH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xC6F5E0", Offset = "0xC6DFE0", VA = "0x180C6F5E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1E11AA0", Offset = "0x1E104A0", VA = "0x181E11AA0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool EHENKOHBJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xC6F5D0", Offset = "0xC6DFD0", VA = "0x180C6F5D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1E11A90", Offset = "0x1E10490", VA = "0x181E11A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MJELFDKKEJF
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7620", Offset = "0x8C6020", VA = "0x1808C7620", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<CNJKDEGGJHP, CNJKDEGGJHP> KDBPPLHCLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6D28890", Offset = "0x6D27290", VA = "0x186D28890", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6D27780", Offset = "0x6D26180", VA = "0x186D27780", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<CNJKDEGGJHP, CNJKDEGGJHP> DFFLEINFKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6D27940", Offset = "0x6D26340", VA = "0x186D27940", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6D270F0", Offset = "0x6D25AF0", VA = "0x186D270F0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<CNJKDEGGJHP, CNJKDEGGJHP, CNJKDEGGJHP> GNAJECMBGNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6D26F70", Offset = "0x6D25970", VA = "0x186D26F70", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6D28160", Offset = "0x6D26B60", VA = "0x186D28160", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6D28CA0", Offset = "0x6D276A0", VA = "0x186D28CA0")]
	public BHPCLOMBDCP(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6D27B90", Offset = "0x6D26590", VA = "0x186D27B90", Slot = "12")]
	public void GCHKJEOLKFE(GameObject NJFNKLJIFDE, DGGDGHJBBEF ANHHFAJMJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6D27AF0", Offset = "0x6D264F0", VA = "0x186D27AF0", Slot = "26")]
	public void ENOAJELNKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6D28220", Offset = "0x6D26C20", VA = "0x186D28220", Slot = "13")]
	public void HIEHKMNLIKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6D28930", Offset = "0x6D27330", VA = "0x186D28930", Slot = "14")]
	public void KFMGLABNFNG(CNJKDEGGJHP LMJNGKAIDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6D278E0", Offset = "0x6D262E0", VA = "0x186D278E0", Slot = "15")]
	public void INPOOCDAMHF(CNJKDEGGJHP LMJNGKAIDMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6D28350", Offset = "0x6D26D50", VA = "0x186D28350", Slot = "22")]
	public bool IEILPLBLJOG(PLLLBFGFLFO KENDFLINCBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6D276C0", Offset = "0x6D260C0", VA = "0x186D276C0")]
	internal bool DFNPODLPPLN([In] MMHDGPBBALG GGEMPJLCHFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6D26FD0", Offset = "0x6D259D0", VA = "0x186D26FD0")]
	internal bool ACDCNFKGBKG([In] MMHDGPBBALG GGEMPJLCHFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6D281C0", Offset = "0x6D26BC0", VA = "0x186D281C0")]
	internal bool HDPJENGLMDG([In] MMHDGPBBALG GGEMPJLCHFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6D279A0", Offset = "0x6D263A0", VA = "0x186D279A0")]
	internal bool EECIFJOJOAE([In] MMHDGPBBALG GGEMPJLCHFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6D27290", Offset = "0x6D25C90", VA = "0x186D27290")]
	internal void DBEPGGJPNKG(CNJKDEGGJHP LMJNGKAIDMM, int LKGJADKFAPD, bool GADJBKMDMEE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6D278E0", Offset = "0x6D262E0", VA = "0x186D278E0")]
	internal bool EAGJIKLHCNH(CNJKDEGGJHP MMDNCOPELHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6D27150", Offset = "0x6D25B50", VA = "0x186D27150")]
	internal bool BIGLKPMNEPP(CNJKDEGGJHP BCKMCONANOB, int MJJOCBPKKNE, int KPOEOBKLLID, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6D277E0", Offset = "0x6D261E0", VA = "0x186D277E0", Slot = "16")]
	public void DPHIHHNNADC(CNJKDEGGJHP LMJNGKAIDMM, HashSet<CNJKDEGGJHP> GANPDGMNADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6D28680", Offset = "0x6D27080", VA = "0x186D28680", Slot = "17")]
	public void JPLOFCABLKD(CNJKDEGGJHP BCKMCONANOB, CNJKDEGGJHP MBPDCPMPDGG, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6D28540", Offset = "0x6D26F40", VA = "0x186D28540", Slot = "18")]
	public void JJPOMJOJEDI(CNJKDEGGJHP LNAOPPEBDFO, int PPLIIJMLBOM, CNJKDEGGJHP AOBPGDDFDPP, int GBAFFBNNGOD, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D28AD0", Offset = "0x6D274D0", VA = "0x186D28AD0", Slot = "19")]
	public void OBHPECNHKHF(CNJKDEGGJHP LNAOPPEBDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6D27470", Offset = "0x6D25E70", VA = "0x186D27470")]
	public void DBHIAMGHMCH([Optional] PCAKHKFMPEL ABGCIBIFHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6D27060", Offset = "0x6D25A60", VA = "0x186D27060", Slot = "23")]
	public void AFKHFOJOIPA(PMCFCEKPJLA ADJABNNJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6D28950", Offset = "0x6D27350", VA = "0x186D28950", Slot = "20")]
	public PMCFCEKPJLA MCILCCFKBIG(bool EEIFLKFMEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6D283A0", Offset = "0x6D26DA0", VA = "0x186D283A0", Slot = "21")]
	public PMCFCEKPJLA IOFMAAKJOMO(HashSet<Guid> OHENNIFLAJA, bool EEIFLKFMEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6D288F0", Offset = "0x6D272F0", VA = "0x186D288F0", Slot = "25")]
	public void KEJLPBPJPDM(PMCFCEKPJLA ADJABNNJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6D282A0", Offset = "0x6D26CA0", VA = "0x186D282A0", Slot = "24")]
	public void HIJJHAJOGEB(PMCFCEKPJLA ADJABNNJNMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class IPGKMNHKGKE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly KECBCJGCBNA<CNJKDEGGJHP, CNJKDEGGJHP> KDBPPLHCLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly KECBCJGCBNA<CNJKDEGGJHP, CNJKDEGGJHP> DFFLEINFKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly GKHPECILONI<CNJKDEGGJHP, CNJKDEGGJHP, CNJKDEGGJHP> GNAJECMBGNC;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6D31400", Offset = "0x6D2FE00", VA = "0x186D31400")]
	public IPGKMNHKGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
	public void GCHKJEOLKFE(BHPCLOMBDCP PLJBPLDMFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6D31340", Offset = "0x6D2FD40", VA = "0x186D31340")]
	public void NFJGAIEOKIJ(CNJKDEGGJHP NNFBEGDDJKL, CNJKDEGGJHP FHMNKMMPPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6D313A0", Offset = "0x6D2FDA0", VA = "0x186D313A0")]
	public void OCJEMMLKJHM(CNJKDEGGJHP NNFBEGDDJKL, CNJKDEGGJHP FHMNKMMPPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6D312C0", Offset = "0x6D2FCC0", VA = "0x186D312C0")]
	public void HEBIGPDAFEL(CNJKDEGGJHP ABAGGDDNNJL, CNJKDEGGJHP AOBPGDDFDPP, CNJKDEGGJHP FHMNKMMPPIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class KDOAKMFEILD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private BHPCLOMBDCP PLJBPLDMFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NPEFJPLCFIG PPPAPIDLOLG;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public KDOAKMFEILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6D31710", Offset = "0x6D30110", VA = "0x186D31710")]
	public void GCHKJEOLKFE(BHPCLOMBDCP PLJBPLDMFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6D316E0", Offset = "0x6D300E0", VA = "0x186D316E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6D316F0", Offset = "0x6D300F0", VA = "0x186D316F0")]
	private void GAMCLDCAFEE(PCAKHKFMPEL JOCAMECBDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6D31A40", Offset = "0x6D30440", VA = "0x186D31A40")]
	private void PLCEADIDHHL(PCAKHKFMPEL CFPFIBBDKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6D31840", Offset = "0x6D30240", VA = "0x186D31840")]
	public void MBFDFDFPBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6D31940", Offset = "0x6D30340", VA = "0x186D31940")]
	public void PIKDCMPONKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class ACJKGKDOGPE
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BHFJDCODFDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public KNPHAFHLPCE container;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public BHFJDCODFDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6D26F00", Offset = "0x6D25900", VA = "0x186D26F00")]
		internal BHPCLOMBDCP HFLDFMOHJEA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6D20E80", Offset = "0x6D1F880", VA = "0x186D20E80")]
	public static void KCHHHAPJJLG(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6D21080", Offset = "0x6D1FA80", VA = "0x186D21080")]
	public static void NLACONBBBNE(KNPHAFHLPCE DNJEODDCEHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class DLNNGPCPDNK : IDisposable, EELCOFEALJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, PADEDAJFEFD> PIOPEIFIFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly KHFKJMNGGLA PHJHKCGDCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private FCOIGJPBCOB AFEECIAGMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private FMHBGBOIECC ADJABNNJNMI;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static ProfilerMarker NMGEIDOHDEC;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A3C0", Offset = "0x6D28DC0", VA = "0x186D2A3C0")]
	public DLNNGPCPDNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6D29870", Offset = "0x6D28270", VA = "0x186D29870", Slot = "7")]
	public void GCHKJEOLKFE(FMHBGBOIECC ADJABNNJNMI, FCOIGJPBCOB AFEECIAGMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6D29C20", Offset = "0x6D28620", VA = "0x186D29C20", Slot = "5")]
	public void JAPPKIFEGMA(KBBNHICCOHM LGFAAHNODCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6D29700", Offset = "0x6D28100", VA = "0x186D29700", Slot = "9")]
	public void BECKPBFFIDI(KBBNHICCOHM IEKNDHEINBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6D29A60", Offset = "0x6D28460", VA = "0x186D29A60", Slot = "8")]
	public void IAIENKDGDBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6D2A010", Offset = "0x6D28A10", VA = "0x186D2A010", Slot = "10")]
	public void OKOKJNEIKIJ(KBBNHICCOHM JDAGOLHCIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6D298B0", Offset = "0x6D282B0", VA = "0x186D298B0", Slot = "11")]
	public void HMMALHJCFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6D29E60", Offset = "0x6D28860", VA = "0x186D29E60")]
	private bool NGFPAKACALB(KBBNHICCOHM DHCJGAOOJAG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class BEKDNBMHPFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct IGMAPFCCKFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly EJEADCHPMCI AAOHBOEJKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HashSet<Guid> OHENNIFLAJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly PLLLBFGFLFO HPBBFCPIBEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly PLLLBFGFLFO CLCLGFPOLLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly bool EEIFLKFMEDC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool EJBPNLDADNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x6D30990", Offset = "0x6D2F390", VA = "0x186D30990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6D30D10", Offset = "0x6D2F710", VA = "0x186D30D10")]
		public IGMAPFCCKFK(EJEADCHPMCI AAOHBOEJKBA, HashSet<Guid> OHENNIFLAJA, bool EEIFLKFMEDC, [Optional] PLLLBFGFLFO HPBBFCPIBEE, [Optional] PLLLBFGFLFO CLCLGFPOLLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6D30AB0", Offset = "0x6D2F4B0", VA = "0x186D30AB0")]
		public PLLLBFGFLFO HLGBFIEHJDG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6D30C50", Offset = "0x6D2F650", VA = "0x186D30C50")]
		private PLLLBFGFLFO LNGMHGEIDPH([Out] PLLLBFGFLFO ADHHJNOLDGL, [Out] PLLLBFGFLFO PEFMGBKHNDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6D30440", Offset = "0x6D2EE40", VA = "0x186D30440")]
		private PLLLBFGFLFO AGMKPCIACFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6D30660", Offset = "0x6D2F060", VA = "0x186D30660")]
		private void BGOGFNCHJBA(PLLLBFGFLFO FGKKJMAHGGL, PLLLBFGFLFO JCNPJEKCAAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6D307D0", Offset = "0x6D2F1D0", VA = "0x186D307D0")]
		private void CNLFNIGKJGP(PLLLBFGFLFO ADHHJNOLDGL, PLLLBFGFLFO PEFMGBKHNDF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly KLEHBGEJMBN DAKGLLFOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private BHPCLOMBDCP PLJBPLDMFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private FMHBGBOIECC ADJABNNJNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private EELCOFEALJK MJDAKLHLKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NPEFJPLCFIG PPPAPIDLOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool FCFIPHMGGBA;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool MLEMJPBLLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6D269E0", Offset = "0x6D253E0", VA = "0x186D269E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool PIHCODHJNFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6D258C0", Offset = "0x6D242C0", VA = "0x186D258C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6D26360", Offset = "0x6D24D60", VA = "0x186D26360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6D24CF0", Offset = "0x6D236F0", VA = "0x186D24CF0")]
	public void GCHKJEOLKFE(BHPCLOMBDCP PLJBPLDMFHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6D26030", Offset = "0x6D24A30", VA = "0x186D26030")]
	public PMCFCEKPJLA MCILCCFKBIG(bool EEIFLKFMEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6D25720", Offset = "0x6D24120", VA = "0x186D25720")]
	public PMCFCEKPJLA IOFMAAKJOMO(HashSet<Guid> OHENNIFLAJA, bool EEIFLKFMEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6D24690", Offset = "0x6D23090", VA = "0x186D24690")]
	public void AFKHFOJOIPA(PMCFCEKPJLA ADJABNNJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6D24D80", Offset = "0x6D23780", VA = "0x186D24D80")]
	public void HIJJHAJOGEB(PMCFCEKPJLA ADJABNNJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6D26330", Offset = "0x6D24D30", VA = "0x186D26330")]
	public void MNHLAMEDPGD(PMCFCEKPJLA ADJABNNJNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6D25D30", Offset = "0x6D24730", VA = "0x186D25D30")]
	private void KFGKFACDENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6D25B00", Offset = "0x6D24500", VA = "0x186D25B00")]
	private PLLLBFGFLFO JOMIKHHJJHN(EJEADCHPMCI OFGAFPGJIKO, bool EEIFLKFMEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6D254D0", Offset = "0x6D23ED0", VA = "0x186D254D0")]
	private static void IKGKJGLEKJF(EJEADCHPMCI OFGAFPGJIKO, bool EEIFLKFMEDC, PLLLBFGFLFO KENDFLINCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6D258E0", Offset = "0x6D242E0", VA = "0x186D258E0")]
	private void JILIGEFMFKD(EJEADCHPMCI OFGAFPGJIKO, bool EEIFLKFMEDC, PLLLBFGFLFO KENDFLINCBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6D26CC0", Offset = "0x6D256C0", VA = "0x186D26CC0")]
	private PLLLBFGFLFO PDLACJLOLMH(EJEADCHPMCI AAOHBOEJKBA, HashSet<Guid> OHENNIFLAJA, bool EEIFLKFMEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6D26A30", Offset = "0x6D25430", VA = "0x186D26A30")]
	private bool OBMDOODBJCF(PMCFCEKPJLA DILKOBCFNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6D26380", Offset = "0x6D24D80", VA = "0x186D26380")]
	private bool NKPKPAIHDEL(PLLLBFGFLFO KENDFLINCBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6D24D60", Offset = "0x6D23760", VA = "0x186D24D60")]
	private bool GDHBIJFJPPG(PMCFCEKPJLA ADJABNNJNMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6D25F20", Offset = "0x6D24920", VA = "0x186D25F20")]
	private static bool KNOIKKMDALG(PLLLBFGFLFO KENDFLINCBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6D25200", Offset = "0x6D23C00", VA = "0x186D25200")]
	public static bool IEILPLBLJOG(PLLLBFGFLFO KENDFLINCBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6D24720", Offset = "0x6D23120", VA = "0x186D24720")]
	private CNJKDEGGJHP DIGAOOBCEEJ(PLLLBFGFLFO KENDFLINCBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x6D25080", Offset = "0x6D23A80", VA = "0x186D25080")]
	private CNJKDEGGJHP IBJIBHFBFBF(PLLLBFGFLFO KENDFLINCBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6D261A0", Offset = "0x6D24BA0", VA = "0x186D261A0")]
	private CNJKDEGGJHP MHANCLELNJF(PLLLBFGFLFO KENDFLINCBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6D25490", Offset = "0x6D23E90", VA = "0x186D25490")]
	private static Guid IFFGKJMMIPF(PLLLBFGFLFO KENDFLINCBC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6D24C00", Offset = "0x6D23600", VA = "0x186D24C00")]
	private string FKJIILMPMMB(PLLLBFGFLFO KENDFLINCBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6D24A70", Offset = "0x6D23470", VA = "0x186D24A70")]
	private bool EDIBGNNELPM(EJEADCHPMCI OFGAFPGJIKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6D24E20", Offset = "0x6D23820", VA = "0x186D24E20")]
	private static void HLEGCNLJJJM(EJEADCHPMCI AAOHBOEJKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public BEKDNBMHPFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct MMHDGPBBALG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public CNJKDEGGJHP FHMNKMMPPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public CNJKDEGGJHP NNFBEGDDJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int MJJOCBPKKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int KPOEOBKLLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector3 OOBOMCNEKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Quaternion CLOFOLGHGAK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public EFDKNGDNCMC OIBECIMALJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6D35AB0", Offset = "0x6D344B0", VA = "0x186D35AB0")]
		get
		{
			return default(EFDKNGDNCMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public EFDKNGDNCMC LJMLAPDDKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x6D35A80", Offset = "0x6D34480", VA = "0x186D35A80")]
		get
		{
			return default(EFDKNGDNCMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6D35B50", Offset = "0x6D34550", VA = "0x186D35B50")]
	public MMHDGPBBALG(CNJKDEGGJHP FHMNKMMPPIB, CNJKDEGGJHP NNFBEGDDJKL, int MJJOCBPKKNE, int KPOEOBKLLID, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface FMHBGBOIECC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	KBBNHICCOHM BPFDMKBMANG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCHKJEOLKFE(INBNJOEBHLI PLJBPLDMFHL);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AKHGEPPHBBI([In] MMHDGPBBALG GGEMPJLCHFC, bool GADJBKMDMEE = true);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OCJKFMGPNPA(CNJKDEGGJHP KKKCLPJOEDH);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GGNPPMGEMHO(CNJKDEGGJHP BCKMCONANOB, int MJJOCBPKKNE, int KPOEOBKLLID, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BEPNPOKKEMK(CNJKDEGGJHP LNAOPPEBDFO, int PPLIIJMLBOM, CNJKDEGGJHP AOBPGDDFDPP, int GBAFFBNNGOD, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DDBDEOJEMLK();

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HEFBLHHEHOL(Func<CNJKDEGGJHP, bool> GGECEGBLPDC);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DPHIHHNNADC(CNJKDEGGJHP LMJNGKAIDMM, HashSet<CNJKDEGGJHP> OMGEDBCEPAJ);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<CNJKDEGGJHP> EDJNMAKBLMK();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MCLMMHNJFPF(CNJKDEGGJHP LMJNGKAIDMM, [Out] EFDKNGDNCMC BPOOHMGGDBJ);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BHPDEGJELDB(KHFKJMNGGLA HFJNADOBPEL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool KHFKJMNGGLA(KBBNHICCOHM OFGAFPGJIKO);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface KBBNHICCOHM
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CNJKDEGGJHP MFGKGMFFBEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	KBBNHICCOHM NBMBHAFDNEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	EFDKNGDNCMC CLMCNGOOJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool BFJOHGEMGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface PADEDAJFEFD : FLJGFPLMMNG.EHBOGEJLMAC
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGMCENCOPJL(CNJKDEGGJHP EPJPGFGIBOG, EFDKNGDNCMC FHMNKMMPPIB);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLPIHHIABEA(CNJKDEGGJHP EPJPGFGIBOG, EFDKNGDNCMC FHMNKMMPPIB);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JAPHCHKDJGE(CNJKDEGGJHP EPJPGFGIBOG, EFDKNGDNCMC FHMNKMMPPIB);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LKEGHNOFEMF(CNJKDEGGJHP EPJPGFGIBOG, EFDKNGDNCMC FHMNKMMPPIB);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PADEDAJFEFD Instantiate(Transform FOBEMKFOBOH);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GBEJNBBIIJK();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface FCOIGJPBCOB
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCHKJEOLKFE(Transform FOBEMKFOBOH, PADEDAJFEFD AINMFCHEGEE);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PADEDAJFEFD IDCEPNHBOFI();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LHEFNFNLCBI(PADEDAJFEFD EJLJKHIJHNL);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FACHBBEFNOM : OOFFCEEPMOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKKMOJJLCDH();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KELBFJIMIJI(Guid ECEAOGOFGJH);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface EELCOFEALJK
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JAPPKIFEGMA(KBBNHICCOHM LGFAAHNODCN);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GCHKJEOLKFE(FMHBGBOIECC ADJABNNJNMI, FCOIGJPBCOB IFHPKEPHFAH);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IAIENKDGDBC();

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BECKPBFFIDI(KBBNHICCOHM IEKNDHEINBH);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OKOKJNEIKIJ(KBBNHICCOHM JDAGOLHCIGL);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HMMALHJCFDK();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class EJEADCHPMCI : KBBNHICCOHM
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CIEGKFBBFDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public EFDKNGDNCMC nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public EJEADCHPMCI foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public CIEGKFBBFDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x6D29090", Offset = "0x6D27A90", VA = "0x186D29090")]
		internal bool CBCGGIBHEBN(KBBNHICCOHM x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private EFDKNGDNCMC BPOOHMGGDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LinkedList<EJEADCHPMCI> POJDHIBGFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private EJEADCHPMCI MAKIIBFGEJG;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public EFDKNGDNCMC CLMCNGOOJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9EF0", Offset = "0x3BF88F0", VA = "0x183BF9EF0", Slot = "6")]
		get
		{
			return default(EFDKNGDNCMC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D2AEB0", Offset = "0x6D298B0", VA = "0x186D2AEB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private EJEADCHPMCI NNFBEGDDJKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8B0160", Offset = "0x8AEB60", VA = "0x1808B0160")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B1A0", Offset = "0x6D29BA0", VA = "0x186D2B1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KBBNHICCOHM NBMBHAFDNEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B0160", Offset = "0x8AEB60", VA = "0x1808B0160", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public CNJKDEGGJHP MFGKGMFFBEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool BFJOHGEMGJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B330", Offset = "0x6D29D30", VA = "0x186D2B330", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool GOGHADJJGEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B490", Offset = "0x6D29E90", VA = "0x186D2B490", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected EJEADCHPMCI ELFANOAFHKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6D2B4E0", Offset = "0x6D29EE0", VA = "0x186D2B4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B960", Offset = "0x6D2A360", VA = "0x186D2B960")]
	public EJEADCHPMCI(EFDKNGDNCMC BALELPGIIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B340", Offset = "0x6D29D40", VA = "0x186D2B340")]
	public EJEADCHPMCI IMLJIONIHGH(EFDKNGDNCMC OALFOEAHCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B500", Offset = "0x6D29F00", VA = "0x186D2B500")]
	public EJEADCHPMCI MLLCPFBMHIG(EFDKNGDNCMC PADEJDCHMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B780", Offset = "0x6D2A180", VA = "0x186D2B780")]
	public EJEADCHPMCI PJOABDGMIKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B050", Offset = "0x6D29A50", VA = "0x186D2B050")]
	public void CFGGIHGKNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B280", Offset = "0x6D29C80", VA = "0x186D2B280")]
	public EJEADCHPMCI GDOPCJOKDIL(EFDKNGDNCMC AOBPGDDFDPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6D2AEF0", Offset = "0x6D298F0", VA = "0x186D2AEF0")]
	private static void BHPDEGJELDB(EJEADCHPMCI PGEDFFCNBNL, KHFKJMNGGLA FAGENEAKFKC, bool FEMAKAJNNBC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6D2AEE0", Offset = "0x6D298E0", VA = "0x186D2AEE0", Slot = "9")]
	public void BHPDEGJELDB(KHFKJMNGGLA HFJNADOBPEL, bool ILCGKGLAAEP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6D2B680", Offset = "0x6D2A080", VA = "0x186D2B680")]
	public static EJEADCHPMCI NNBLDMEFBKH(EJEADCHPMCI PGEDFFCNBNL, EFDKNGDNCMC PMFGGPENGJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface NPEFJPLCFIG
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool MLEMJPBLLEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool AMMJCMAEPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<PCAKHKFMPEL> GAMCLDCAFEE;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<PCAKHKFMPEL> PLCEADIDHHL;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(BHPCLOMBDCP PLJBPLDMFHL);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(CNJKDEGGJHP BCKMCONANOB, CNJKDEGGJHP MBPDCPMPDGG, int MJJOCBPKKNE, int KPOEOBKLLID, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(CNJKDEGGJHP LNAOPPEBDFO, int PPLIIJMLBOM, CNJKDEGGJHP AOBPGDDFDPP, int GBAFFBNNGOD, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(PMCFCEKPJLA JFIMJLFIEBM, [Optional] PCAKHKFMPEL ABGCIBIFHBA);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, NPEFJPLCFIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private BHPCLOMBDCP PLJBPLDMFHL;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool MLEMJPBLLEI
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6D35700", Offset = "0x6D34100", VA = "0x186D35700", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool AMMJCMAEPPP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6D35760", Offset = "0x6D34160", VA = "0x186D35760", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<PCAKHKFMPEL> GAMCLDCAFEE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x6D35660", Offset = "0x6D34060", VA = "0x186D35660", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x6D35840", Offset = "0x6D34240", VA = "0x186D35840", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<PCAKHKFMPEL> PLCEADIDHHL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x6D355C0", Offset = "0x6D33FC0", VA = "0x186D355C0", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x6D357A0", Offset = "0x6D341A0", VA = "0x186D357A0", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B00F0", Offset = "0x8AEAF0", VA = "0x1808B00F0", Slot = "19")]
		public void SetManager(BHPCLOMBDCP PLJBPLDMFHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D35590", Offset = "0x6D33F90", VA = "0x186D35590")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D34310", Offset = "0x6D32D10", VA = "0x186D34310", Slot = "23")]
		public void RequestMasterConnectNodes(CNJKDEGGJHP CLJIMJAIFKC, int MJJOCBPKKNE, CNJKDEGGJHP EPJPGFGIBOG, int KPOEOBKLLID, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D34440", Offset = "0x6D32E40", VA = "0x186D34440", Slot = "24")]
		public void RequestMasterDisconnectNode(CNJKDEGGJHP KKKCLPJOEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x6D34500", Offset = "0x6D32F00", VA = "0x186D34500", Slot = "20")]
		public void RequestMasterModifyNode(CNJKDEGGJHP BCKMCONANOB, CNJKDEGGJHP MBPDCPMPDGG, int MJJOCBPKKNE, int KPOEOBKLLID, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6D34630", Offset = "0x6D33030", VA = "0x186D34630", Slot = "21")]
		public void RequestMasterReparentNodes(CNJKDEGGJHP LNAOPPEBDFO, int PPLIIJMLBOM, CNJKDEGGJHP AOBPGDDFDPP, int GBAFFBNNGOD, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6D34760", Offset = "0x6D33160", VA = "0x186D34760", Slot = "25")]
		public void RequestMasterReparentToRoot(CNJKDEGGJHP LNAOPPEBDFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6D341E0", Offset = "0x6D32BE0", VA = "0x186D341E0", Slot = "22")]
		public void RequestDeserializeConnectableGraph(PMCFCEKPJLA JFIMJLFIEBM, [Optional] PCAKHKFMPEL ABGCIBIFHBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6D34B40", Offset = "0x6D33540", VA = "0x186D34B40")]
		[DPGPLMKJAEN]
		private void RpcMasterConnectNodes(CNJKDEGGJHP CLJIMJAIFKC, int MJJOCBPKKNE, CNJKDEGGJHP EPJPGFGIBOG, int KPOEOBKLLID, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6D34E00", Offset = "0x6D33800", VA = "0x186D34E00")]
		[DPGPLMKJAEN]
		private void RpcMasterDisconnectNode(CNJKDEGGJHP KKKCLPJOEDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x6D35140", Offset = "0x6D33B40", VA = "0x186D35140")]
		[DPGPLMKJAEN]
		private void RpcMasterReparentNodes(CNJKDEGGJHP LNAOPPEBDFO, int PPLIIJMLBOM, CNJKDEGGJHP AOBPGDDFDPP, int GBAFFBNNGOD, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6D34F40", Offset = "0x6D33940", VA = "0x186D34F40")]
		[DPGPLMKJAEN]
		private void RpcMasterModifyNode(CNJKDEGGJHP BCKMCONANOB, CNJKDEGGJHP MBPDCPMPDGG, int MJJOCBPKKNE, int KPOEOBKLLID, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6D34930", Offset = "0x6D33330", VA = "0x186D34930")]
		[DPGPLMKJAEN]
		private void RpcConnectNodes(CNJKDEGGJHP CLJIMJAIFKC, int MJJOCBPKKNE, CNJKDEGGJHP EPJPGFGIBOG, int KPOEOBKLLID, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK, AHMODBNBOOC CIOPGHNMALK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6D34AB0", Offset = "0x6D334B0", VA = "0x186D34AB0")]
		[DPGPLMKJAEN]
		private void RpcDisconnectNode(CNJKDEGGJHP KKKCLPJOEDH, AHMODBNBOOC CIOPGHNMALK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6D35490", Offset = "0x6D33E90", VA = "0x186D35490")]
		[DPGPLMKJAEN]
		private void RpcReparentNodes(CNJKDEGGJHP LNAOPPEBDFO, int PPLIIJMLBOM, CNJKDEGGJHP AOBPGDDFDPP, int GBAFFBNNGOD, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK, AHMODBNBOOC CIOPGHNMALK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6D353D0", Offset = "0x6D33DD0", VA = "0x186D353D0")]
		[DPGPLMKJAEN]
		private void RpcModifyNode(CNJKDEGGJHP BCKMCONANOB, int MJJOCBPKKNE, int KPOEOBKLLID, Vector3 OOBOMCNEKOM, Quaternion CLOFOLGHGAK, AHMODBNBOOC CIOPGHNMALK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6D34A70", Offset = "0x6D33470", VA = "0x186D34A70")]
		[DPGPLMKJAEN]
		private void RpcDeserializeConnectableGraph(PMCFCEKPJLA ADJABNNJNMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8C9250", Offset = "0x8C7C50", VA = "0x1808C9250")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, PADEDAJFEFD, FLJGFPLMMNG.EHBOGEJLMAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6D33C30", Offset = "0x6D32630", VA = "0x186D33C30", Slot = "4")]
		private void HOJKMHIPNBG(CNJKDEGGJHP EPJPGFGIBOG, EFDKNGDNCMC FHMNKMMPPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D33E10", Offset = "0x6D32810", VA = "0x186D33E10", Slot = "5")]
		private void PKGLOLILKHA(CNJKDEGGJHP EPJPGFGIBOG, EFDKNGDNCMC FHMNKMMPPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6D34080", Offset = "0x6D32A80", VA = "0x186D34080", Slot = "6")]
		private void PPONGBNHCMC(CNJKDEGGJHP EPJPGFGIBOG, EFDKNGDNCMC FHMNKMMPPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6D339D0", Offset = "0x6D323D0", VA = "0x186D339D0", Slot = "7")]
		private void EOKPEECKDME(CNJKDEGGJHP EPJPGFGIBOG, EFDKNGDNCMC FHMNKMMPPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6D33BC0", Offset = "0x6D325C0", VA = "0x186D33BC0", Slot = "8")]
		private PADEDAJFEFD HFMOACMGKHP(Transform FOBEMKFOBOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6D33DB0", Offset = "0x6D327B0", VA = "0x186D33DB0", Slot = "9")]
		private void OOPAIFLDNLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class HBOKJKGEAOJ
{
	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2EFB080", Offset = "0x2EF9A80", VA = "0x182EFB080")]
	public static PGDINBGECPO<T> MKLJCKAMJGK<T>(this KNPHAFHLPCE DNJEODDCEHK)
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
