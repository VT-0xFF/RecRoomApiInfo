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
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x71BB590", Offset = "0x71BA390", VA = "0x1871BB590", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x71C0F80", Offset = "0x71BFD80", VA = "0x1871C0F80", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71C0AE0", Offset = "0x71BF8E0", VA = "0x1871C0AE0")]
		private void OGIEEDDHGBJ(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71C0970", Offset = "0x71BF770", VA = "0x1871C0970")]
		private void FEMILMKCAKN(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71C0C50", Offset = "0x71BFA50", VA = "0x1871C0C50", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71C0FC0", Offset = "0x71BFDC0", VA = "0x1871C0FC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class MHPKOFCIMHM : MDIOAMPOCNO, EJBGNPMNAED
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	private sealed class BGNBCOALCFB : IEnumerable<LNAPBGCAIIL>, IEnumerable, IEnumerator<LNAPBGCAIIL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private LNAPBGCAIIL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private ODHMICMEHJH localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ODHMICMEHJH <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MHPKOFCIMHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private PHOLKIHIPKK <objects>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private FEBOOADAFMA.NBPJANPGBBK <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private LNAPBGCAIIL System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.IConnectable>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4C0", Offset = "0xC3A2C0", VA = "0x180C3B4C0")]
		[DebuggerHidden]
		public BGNBCOALCFB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x71AC2C0", Offset = "0x71AB0C0", VA = "0x1871AC2C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x71ABE00", Offset = "0x71AAC00", VA = "0x1871ABE00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x71ABDE0", Offset = "0x71AABE0", VA = "0x1871ABDE0")]
		private void GEDOPIMJGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x71AC270", Offset = "0x71AB070", VA = "0x1871AC270", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x71AC1C0", Offset = "0x71AAFC0", VA = "0x1871AC1C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LNAPBGCAIIL> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.IConnectable>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x71AC1C0", Offset = "0x71AAFC0", VA = "0x1871AC1C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class CIFAEGNBFEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public MHPKOFCIMHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public DHNBFDEFDEB nodeData;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public CIFAEGNBFEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x71AC5D0", Offset = "0x71AB3D0", VA = "0x1871AC5D0")]
		internal object ADDPIHGKEAC(DHNBFDEFDEB x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class FOAOKNDFMAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public DHNBFDEFDEB child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CIFAEGNBFEH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public FOAOKNDFMAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x71AECC0", Offset = "0x71ADAC0", VA = "0x1871AECC0")]
		internal object EIIIFONCGBO((DHNBFDEFDEB child, DHNBFDEFDEB nodeData) x)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly IMOCAMGHNDM ALENIJGFEJL;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly IMOCAMGHNDM MICNCLJPFPB;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly IMOCAMGHNDM CHFKBGJBCAB;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly IMOCAMGHNDM DKNPPMCPOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private FBNMMGJAKMI NCJACMOPEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private JDCLPPHDFCC ANPHJHHNLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private FOBFMNKCFNO MCFFBNNLCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private LNINCLPBIHA BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private AIIEKAIMAJJ BLKDJICDONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly GFBFNKLADJN AGGPMDGGKLP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OBOEGBKEDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAC0F00", Offset = "0xABFD00", VA = "0x180AC0F00", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAC04C0", Offset = "0xABF2C0", VA = "0x180AC04C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LGKBHJJGBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<LNAPBGCAIIL, LNAPBGCAIIL> GIMHLAKKPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71BE4D0", Offset = "0x71BD2D0", VA = "0x1871BE4D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x71BC2B0", Offset = "0x71BB0B0", VA = "0x1871BC2B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<LNAPBGCAIIL, LNAPBGCAIIL> PGPOOIJIHKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x71BBF50", Offset = "0x71BAD50", VA = "0x1871BBF50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71BCD70", Offset = "0x71BBB70", VA = "0x1871BCD70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<LNAPBGCAIIL, LNAPBGCAIIL, LNAPBGCAIIL> LAEEBFGIBOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x71BC000", Offset = "0x71BAE00", VA = "0x1871BC000", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x71BE7E0", Offset = "0x71BD5E0", VA = "0x1871BE7E0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x71C01F0", Offset = "0x71BEFF0", VA = "0x1871C01F0")]
	public MHPKOFCIMHM(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x71BECB0", Offset = "0x71BDAB0", VA = "0x1871BECB0", Slot = "12")]
	public void JEELJGCJJCO(GameObject IHNPMPCJPIK, DFGKEGHKDMN FMOBMCFIDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x71BFA70", Offset = "0x71BE870", VA = "0x1871BFA70", Slot = "26")]
	public void OAKNFNBDPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x71BFA20", Offset = "0x71BE820", VA = "0x1871BFA20", Slot = "22")]
	public bool MIKIEJFIKBJ(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x71BDA10", Offset = "0x71BC810", VA = "0x1871BDA10")]
	private void GKJJMJLKMJG(ODHMICMEHJH DGCIIKCNEHK, ODHMICMEHJH GDGGAJKJIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x71BDC20", Offset = "0x71BCA20", VA = "0x1871BDC20")]
	private void GKLNGENMDHG(ODHMICMEHJH DGCIIKCNEHK, ODHMICMEHJH MOIKCEENIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x71BE580", Offset = "0x71BD380", VA = "0x1871BE580")]
	private void HHHJAEOCFAO(ODHMICMEHJH DGCIIKCNEHK, ODHMICMEHJH MOIKCEENIJG, ODHMICMEHJH GDGGAJKJIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x71BF150", Offset = "0x71BDF50", VA = "0x1871BF150")]
	private void LBCKJEBIMKF(ODHMICMEHJH DGCIIKCNEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "13")]
	public void IGIPDIBMNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x71BCE20", Offset = "0x71BBC20", VA = "0x1871BCE20", Slot = "14")]
	public void EHDMJEMLBPD(LNAPBGCAIIL DDPEIHFGGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "15")]
	public void HLGNNFLCMJP(LNAPBGCAIIL DDPEIHFGGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x71BF8C0", Offset = "0x71BE6C0", VA = "0x1871BF8C0", Slot = "17")]
	public void MDBFKHFNCGP(LNAPBGCAIIL DDPEIHFGGKE, LNAPBGCAIIL CDONMEHBEBH, Vector3 PFKOKOAMOAJ, Quaternion ACJIHPAJKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x71BF780", Offset = "0x71BE580", VA = "0x1871BF780")]
	public void MDBFKHFNCGP(ODHMICMEHJH DOOFGBAMPBE, ODHMICMEHJH CDONMEHBEBH, Vector3 PFKOKOAMOAJ, Quaternion ACJIHPAJKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x71BEF20", Offset = "0x71BDD20", VA = "0x1871BEF20")]
	public void JFPGIEEIDME(LNAPBGCAIIL DDPEIHFGGKE, float MCOIPKFBCAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x71BE890", Offset = "0x71BD690", VA = "0x1871BE890", Slot = "18")]
	public void HPPPMKLHNON(LNAPBGCAIIL IDOCGCDLFAJ, int MOPJCBHCNJP, LNAPBGCAIIL NECCGCDBJPF, int DHJADGKOGLM, Vector3 PFKOKOAMOAJ, Quaternion ACJIHPAJKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x71BD960", Offset = "0x71BC760", VA = "0x1871BD960")]
	private float GINGCMCABKD(ODHMICMEHJH DOOFGBAMPBE, ODHMICMEHJH IFAMCPHMKIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x71BE9F0", Offset = "0x71BD7F0", VA = "0x1871BE9F0")]
	public void HPPPMKLHNON(ODHMICMEHJH DOOFGBAMPBE, ODHMICMEHJH IFAMCPHMKIP, Vector3 PFKOKOAMOAJ, Quaternion ACJIHPAJKOG, bool NMFGPHMDGCE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x71BEB30", Offset = "0x71BD930", VA = "0x1871BEB30")]
	public void HPPPMKLHNON(ODHMICMEHJH DOOFGBAMPBE, ODHMICMEHJH IFAMCPHMKIP, Vector3 PFKOKOAMOAJ, Quaternion ACJIHPAJKOG, float MCOIPKFBCAL, bool NMFGPHMDGCE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x71BC360", Offset = "0x71BB160", VA = "0x1871BC360", Slot = "19")]
	public void BJFPPKPLINH(LNAPBGCAIIL DDPEIHFGGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x71BFC60", Offset = "0x71BEA60", VA = "0x1871BFC60")]
	public bool PGLEOHBENJM(ODHMICMEHJH ADODGOLJGFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x71BC0B0", Offset = "0x71BAEB0", VA = "0x1871BC0B0", Slot = "16")]
	public void BCNCADPADAH(LNAPBGCAIIL DDPEIHFGGKE, HashSet<LNAPBGCAIIL> JCFGBKEDLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "20")]
	public OLCIGFHLLEM FOALPIOAIHG(bool JLDCAKEIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "21")]
	public OLCIGFHLLEM MMBECACMAOB(HashSet<Guid> AIILGHFCBLA, bool JLDCAKEIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x71BF580", Offset = "0x71BE380", VA = "0x1871BF580", Slot = "23")]
	public void LLEDPBDPEFA(OLCIGFHLLEM LIPFFAIMLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x71BD4F0", Offset = "0x71BC2F0", VA = "0x1871BD4F0", Slot = "24")]
	public void FMJCLMEEPND(OLCIGFHLLEM LIPFFAIMLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x71BF560", Offset = "0x71BE360", VA = "0x1871BF560", Slot = "25")]
	public void LFMGNOMMLMF(OLCIGFHLLEM LIPFFAIMLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x71BCA10", Offset = "0x71BB810", VA = "0x1871BCA10")]
	private void DAPIGLFJNGM(ODHMICMEHJH DOOFGBAMPBE, ODHMICMEHJH IFAMCPHMKIP, Vector3 PFKOKOAMOAJ, Quaternion ACJIHPAJKOG, float MCOIPKFBCAL, bool NMFGPHMDGCE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x71BB7C0", Offset = "0x71BA5C0", VA = "0x1871BB7C0")]
	private void AKHMIFBGKMJ(ODHMICMEHJH DOOFGBAMPBE, ODHMICMEHJH LBOOKOKCBHL, Vector3 PFKOKOAMOAJ, Quaternion ACJIHPAJKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x71BC9A0", Offset = "0x71BB7A0", VA = "0x1871BC9A0")]
	private void CECPHLNCDML(ODHMICMEHJH DOOFGBAMPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x71BB730", Offset = "0x71BA530", VA = "0x1871BB730")]
	[IteratorStateMachine(typeof(BGNBCOALCFB))]
	public IEnumerable<LNAPBGCAIIL> AAOBIAAJFDM(ODHMICMEHJH ADODGOLJGFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x71BC4D0", Offset = "0x71BB2D0", VA = "0x1871BC4D0")]
	internal LNAPBGCAIIL CCMEHDJLJPJ(ODHMICMEHJH ADODGOLJGFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x71BEFB0", Offset = "0x71BDDB0", VA = "0x1871BEFB0")]
	internal ODHMICMEHJH JLGFKLNLFJN(LNAPBGCAIIL DDPEIHFGGKE)
	{
		return default(ODHMICMEHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x71BDE40", Offset = "0x71BCC40", VA = "0x1871BDE40")]
	private bool GLKDLMLCJMO(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x71BD490", Offset = "0x71BC290", VA = "0x1871BD490")]
	private bool FKBHFMKGJHI(DHNBFDEFDEB JDNLPMLJDPE, [Out] LNAPBGCAIIL IFAMCPHMKIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x71BC600", Offset = "0x71BB400", VA = "0x1871BC600")]
	private LNAPBGCAIIL CCMEHDJLJPJ(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x71BD560", Offset = "0x71BC360", VA = "0x1871BD560")]
	private LNAPBGCAIIL GECACAGFCPK(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x71BD2B0", Offset = "0x71BC0B0", VA = "0x1871BD2B0")]
	private LNAPBGCAIIL FANCDNFHFBL(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x71B0FD0", Offset = "0x71AFDD0", VA = "0x1871B0FD0")]
	private static Guid MIIAOJDALDF(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x71BE3E0", Offset = "0x71BD1E0", VA = "0x1871BE3E0")]
	private string GOKAEJPOAAH(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x71BF5F0", Offset = "0x71BE3F0", VA = "0x1871BF5F0")]
	private void MBJAGKFGMJC(LNAPBGCAIIL DOOFGBAMPBE, LNAPBGCAIIL LBOOKOKCBHL, RigidTransform MJKOCFIPPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x71BFEF0", Offset = "0x71BECF0", VA = "0x1871BFEF0")]
	private void PLAKHPJJJKE(LNAPBGCAIIL LBOOKOKCBHL, LNAPBGCAIIL DOOFGBAMPBE, RigidTransform MJKOCFIPPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x71BF0F0", Offset = "0x71BDEF0", VA = "0x1871BF0F0")]
	private void KNADJEMIJJP(LNAPBGCAIIL NJOCGFOKJDP, LNAPBGCAIIL DOOFGBAMPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x71BD120", Offset = "0x71BBF20", VA = "0x1871BD120")]
	private void EMCHLDHNBPH(LNAPBGCAIIL DOOFGBAMPBE, LNAPBGCAIIL IFAMCPHMKIP, RigidTransform MJKOCFIPPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x71BEBA0", Offset = "0x71BD9A0", VA = "0x1871BEBA0")]
	private void INGHEDIMBMA(ODHMICMEHJH ADODGOLJGFP, LNAPBGCAIIL DDPEIHFGGKE, ODHMICMEHJH MOIKCEENIJG, ODHMICMEHJH GDGGAJKJIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x71BD6E0", Offset = "0x71BC4E0", VA = "0x1871BD6E0")]
	private void GHJFPONDIAC(ODHMICMEHJH ADODGOLJGFP, LNAPBGCAIIL DDPEIHFGGKE, LNAPBGCAIIL PECHBKJABHG, LNAPBGCAIIL CBHPLMNJMDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class GLDBIPOCDJB
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class HJCPMCOMCGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public IEPIHLKICIO container;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public HJCPMCOMCGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x71B4F60", Offset = "0x71B3D60", VA = "0x1871B4F60")]
		internal MHPKOFCIMHM PDMIGKHGBEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x71B1680", Offset = "0x71B0480", VA = "0x1871B1680")]
	public static void HDFOBHIJIBI(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x71B1630", Offset = "0x71B0430", VA = "0x1871B1630")]
	public static void GFMEPBJIPIN(IEPIHLKICIO BCNFHKMHIOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class LCAAMDFGCOK : DCHGOIKGMOE, GFIAMLKFPOO
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly RigidbodyEx EDMNKJJOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly MHPKOFCIMHM OEBKOOFKIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly BFHFEGCJFFJ EGNMLHCMFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly GOAJJJFNAOG BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly GKEJGIIFGGC[] DPCFNILHLBJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(ODHMICMEHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LNAPBGCAIIL OFLDJEKOGII
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x71B90C0", Offset = "0x71B7EC0", VA = "0x1871B90C0", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LNAPBGCAIIL HMAKPADIDAD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x71B7560", Offset = "0x71B6360", VA = "0x1871B7560", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Vector3 FDDGEHCPIGP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x71B7500", Offset = "0x71B6300", VA = "0x1871B7500", Slot = "14")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Quaternion DFGJNMEHMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x71B83D0", Offset = "0x71B71D0", VA = "0x1871B83D0", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EHCPPGENBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x71B8D80", Offset = "0x71B7B80", VA = "0x1871B8D80", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IEnumerable<LNAPBGCAIIL> JCNHINCCMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x71B7910", Offset = "0x71B6710", VA = "0x1871B7910", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	[Obsolete]
	public bool AOHHBPNJJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xADD5A0", Offset = "0xADC3A0", VA = "0x180ADD5A0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAFFF00", Offset = "0xAFED00", VA = "0x180AFFF00", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public Transform HHEFOFLOCNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x71B92C0", Offset = "0x71B80C0", VA = "0x1871B92C0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GameObject JEKAHIGLEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B58330", Offset = "0x2B57130", VA = "0x182B58330", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x71B9000", Offset = "0x71B7E00", VA = "0x1871B9000", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Guid KPGEPJKNFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x71B9120", Offset = "0x71B7F20", VA = "0x1871B9120", Slot = "36")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int KDDJAHGHHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x71B9200", Offset = "0x71B8000", VA = "0x1871B9200", Slot = "37")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MJGINKKKBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "39")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private bool CKGCMBAEKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x71B89F0", Offset = "0x71B77F0", VA = "0x1871B89F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event GOKJILOCHHO CEAHKOMJMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x71B7940", Offset = "0x71B6740", VA = "0x1871B7940", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x71B76C0", Offset = "0x71B64C0", VA = "0x1871B76C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event GOKJILOCHHO KPHEAAGAMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x71B7CB0", Offset = "0x71B6AB0", VA = "0x1871B7CB0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x71B8370", Offset = "0x71B7170", VA = "0x1871B8370", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event GOKJILOCHHO DOPGBDEDMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x71B8DF0", Offset = "0x71B7BF0", VA = "0x1871B8DF0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x71B8D20", Offset = "0x71B7B20", VA = "0x1871B8D20", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event GPKPPCMLIPH OJMENFEAHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x71B8B60", Offset = "0x71B7960", VA = "0x1871B8B60", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x71B8C00", Offset = "0x71B7A00", VA = "0x1871B8C00", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x71B8F00", Offset = "0x71B7D00", VA = "0x1871B8F00")]
	public LCAAMDFGCOK(ODHMICMEHJH FEOCBDNIFLG, RigidbodyEx EDMNKJJOIJK, BFHFEGCJFFJ EGNMLHCMFAJ, GKEJGIIFGGC[] DPCFNILHLBJ, GOAJJJFNAOG BPGIOHMMDAI, MDIOAMPOCNO OEBKOOFKIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x71B8CA0", Offset = "0x71B7AA0", VA = "0x1871B8CA0", Slot = "19")]
	public void NLNNABDBLFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "21")]
	public void EJBPMPEFKJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6E90", Offset = "0x6FB5C90", VA = "0x186FB6E90", Slot = "22")]
	public void HMIJDDGNMIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x71B8CD0", Offset = "0x71B7AD0", VA = "0x1871B8CD0", Slot = "20")]
	public void ODCOABNFDHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x71B8430", Offset = "0x71B7230", VA = "0x1871B8430", Slot = "25")]
	public void HIHBEOFFCGH(int FONONCEMPGM, LNAPBGCAIIL NECCGCDBJPF, int GABIDFJGIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x71B8640", Offset = "0x71B7440", VA = "0x1871B8640", Slot = "26")]
	public void IEHOPJBDBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x71B8710", Offset = "0x71B7510", VA = "0x1871B8710", Slot = "27")]
	public void IMOEJAFJGNK(int FONONCEMPGM, LNAPBGCAIIL IDOCGCDLFAJ, int KDOLCBKLHME, [Optional] Vector3? NLEOEIHBFKL, [Optional] Quaternion? FJCGMNKEFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x71B8A90", Offset = "0x71B7890", VA = "0x1871B8A90", Slot = "28")]
	public void NCMPLOENDED(LNAPBGCAIIL IDOCGCDLFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x71B7F60", Offset = "0x71B6D60", VA = "0x1871B7F60", Slot = "31")]
	public void HBNEGMIDHGD(Vector3 FCAMHKCPNDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x71B79A0", Offset = "0x71B67A0", VA = "0x1871B79A0", Slot = "29")]
	public void EHJMFDIIJLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x71B7720", Offset = "0x71B6520", VA = "0x1871B7720", Slot = "30")]
	public void DGELCALEOKP(int KNCPCNBMDNF, Vector3 COKJJHJKDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x71B7E90", Offset = "0x71B6C90", VA = "0x1871B7E90", Slot = "41")]
	public Vector3 GetConnectionSlotPosition(int FONONCEMPGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x71B7D60", Offset = "0x71B6B60", VA = "0x1871B7D60", Slot = "40")]
	public Vector3 GetConnectionSlotLocalPosition(int FONONCEMPGM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xAB5DC0", Offset = "0xAB4BC0", VA = "0x180AB5DC0", Slot = "42")]
	public Color GetConnectionSlotColor(int FONONCEMPGM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x71B7620", Offset = "0x71B6420", VA = "0x1871B7620", Slot = "43")]
	public bool CanConnectTo(int FONONCEMPGM, LNAPBGCAIIL PDDDNHDCDFC, int HMMDMJDMKMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "44")]
	public void ParentChanged(int FONONCEMPGM, LNAPBGCAIIL CEFFLLNBPEN, int CIKBMGDKHEJ, Vector3 KLBDDNNHGHC, Quaternion JODKOAKNNMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "45")]
	public void ChildAdded(int FONONCEMPGM, LNAPBGCAIIL LINOOIDDHCA, int DIKFNPIPBDL, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "46")]
	public void ChildRemoved(int FONONCEMPGM, LNAPBGCAIIL AMJPCPHMKCD, int FELLFLGGBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "47")]
	public void ConnectionModified(int FONONCEMPGM, LNAPBGCAIIL NECCGCDBJPF, int GABIDFJGIGM, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x71B8E50", Offset = "0x71B7C50", VA = "0x1871B8E50", Slot = "48")]
	public void RootChanged(LNAPBGCAIIL NEGNLNEKBJG, LNAPBGCAIIL JENPMLIJDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x71B8A40", Offset = "0x71B7840", VA = "0x1871B8A40", Slot = "23")]
	public void MDFEEAJEGHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x71B8B10", Offset = "0x71B7910", VA = "0x1871B8B10", Slot = "24")]
	public void NDDJNGCMIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x71B7D10", Offset = "0x71B6B10", VA = "0x1871B7D10")]
	private void FAAPPEOILNE(bool LEGHPHIHELG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RegisterService(typeof(MFEEIFPBBIA), new string[] { })]
public class BIHDIFOOPFB : MFEEIFPBBIA, JGMFHEFMNDL, HFKIOGDGJAO
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CPMPAJAGNLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public BIHDIFOOPFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public FEBOOADAFMA localIds;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public CPMPAJAGNLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x71AC640", Offset = "0x71AB440", VA = "0x1871AC640")]
		internal void LFCHKAOEPBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[DependsOn]
	private NFHKFLLBENH ONBPKFMECNJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public object JIBPPKENFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x71AC370", Offset = "0x71AB170", VA = "0x1871AC370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x71AC400", Offset = "0x71AB200", VA = "0x1871AC400", Slot = "5")]
	public void OHPBCOGJFOK(FEBOOADAFMA CKLFLFGMLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x71AC320", Offset = "0x71AB120", VA = "0x1871AC320", Slot = "6")]
	private void BKNPNHIBBHM(BFHPBCPPECP AGGPMDGGKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xF9FB80", Offset = "0xF9E980", VA = "0x180F9FB80", Slot = "7")]
	private void JAPPIEFINBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public BIHDIFOOPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RegisterService(typeof(MDIOAMPOCNO), new string[] { "Ignore", "Mock" })]
public class JHJHKFFAPAP : MDIOAMPOCNO, EJBGNPMNAED
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OBOEGBKEDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool LGKBHJJGBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<LNAPBGCAIIL, LNAPBGCAIIL> GIMHLAKKPPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x71B73A0", Offset = "0x71B61A0", VA = "0x1871B73A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x71B7240", Offset = "0x71B6040", VA = "0x1871B7240", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<LNAPBGCAIIL, LNAPBGCAIIL> PGPOOIJIHKG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x71B70E0", Offset = "0x71B5EE0", VA = "0x1871B70E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x71B72F0", Offset = "0x71B60F0", VA = "0x1871B72F0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<LNAPBGCAIIL, LNAPBGCAIIL, LNAPBGCAIIL> LAEEBFGIBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x71B7190", Offset = "0x71B5F90", VA = "0x1871B7190", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x71B7450", Offset = "0x71B6250", VA = "0x1871B7450", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "26")]
	public void OAKNFNBDPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "12")]
	public void JEELJGCJJCO(GameObject IHNPMPCJPIK, DFGKEGHKDMN FMOBMCFIDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "13")]
	public void IGIPDIBMNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "14")]
	public void EHDMJEMLBPD(LNAPBGCAIIL DDPEIHFGGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "15")]
	public void HLGNNFLCMJP(LNAPBGCAIIL DDPEIHFGGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "16")]
	public void BCNCADPADAH(LNAPBGCAIIL DDPEIHFGGKE, HashSet<LNAPBGCAIIL> JCFGBKEDLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "17")]
	public void MDBFKHFNCGP(LNAPBGCAIIL DDPEIHFGGKE, LNAPBGCAIIL CDONMEHBEBH, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "18")]
	public void HPPPMKLHNON(LNAPBGCAIIL DDPEIHFGGKE, int MDJELHAMOHJ, LNAPBGCAIIL LBOOKOKCBHL, int CIKBMGDKHEJ, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "19")]
	public void BJFPPKPLINH(LNAPBGCAIIL DDPEIHFGGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "20")]
	public OLCIGFHLLEM FOALPIOAIHG(bool JLDCAKEIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "21")]
	public OLCIGFHLLEM MMBECACMAOB(HashSet<Guid> AIILGHFCBLA, bool JLDCAKEIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "22")]
	public bool MIKIEJFIKBJ(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "23")]
	public void LLEDPBDPEFA(OLCIGFHLLEM LIPFFAIMLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "24")]
	public void FMJCLMEEPND(OLCIGFHLLEM LIPFFAIMLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "25")]
	public void LFMGNOMMLMF(OLCIGFHLLEM LIPFFAIMLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public JHJHKFFAPAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LNAPBGCAIIL : GFIAMLKFPOO, IEquatable<LNAPBGCAIIL>
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface GFIAMLKFPOO
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	LNAPBGCAIIL OFLDJEKOGII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform HHEFOFLOCNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	GameObject JEKAHIGLEHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	Guid KPGEPJKNFPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	int KDDJAHGHHAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	ODHMICMEHJH PCOIIKCHBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool MJGINKKKBIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector3 GetConnectionSlotLocalPosition(int FONONCEMPGM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Vector3 GetConnectionSlotPosition(int FONONCEMPGM);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color GetConnectionSlotColor(int FONONCEMPGM);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool CanConnectTo(int FONONCEMPGM, LNAPBGCAIIL PDDDNHDCDFC, int FHHOEKEPJIA);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ParentChanged(int FONONCEMPGM, LNAPBGCAIIL CEFFLLNBPEN, int CIKBMGDKHEJ, Vector3 KLBDDNNHGHC, Quaternion JODKOAKNNMK);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ChildAdded(int FONONCEMPGM, LNAPBGCAIIL LINOOIDDHCA, int DIKFNPIPBDL, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ChildRemoved(int FONONCEMPGM, LNAPBGCAIIL AMJPCPHMKCD, int FELLFLGGBOA);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ConnectionModified(int FONONCEMPGM, LNAPBGCAIIL NECCGCDBJPF, int GMAPAGBIEAI, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void RootChanged(LNAPBGCAIIL NEGNLNEKBJG, LNAPBGCAIIL JENPMLIJDPN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[ServiceLifetime(Lifetime.OMRoom)]
public interface MDIOAMPOCNO : EJBGNPMNAED
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool OBOEGBKEDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool LGKBHJJGBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<LNAPBGCAIIL, LNAPBGCAIIL> GIMHLAKKPPK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<LNAPBGCAIIL, LNAPBGCAIIL> PGPOOIJIHKG;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<LNAPBGCAIIL, LNAPBGCAIIL, LNAPBGCAIIL> LAEEBFGIBOH;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JEELJGCJJCO(GameObject IHNPMPCJPIK, DFGKEGHKDMN FMOBMCFIDCJ);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IGIPDIBMNHA();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EHDMJEMLBPD(LNAPBGCAIIL DDPEIHFGGKE);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HLGNNFLCMJP(LNAPBGCAIIL DDPEIHFGGKE);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BCNCADPADAH(LNAPBGCAIIL DDPEIHFGGKE, HashSet<LNAPBGCAIIL> JCFGBKEDLOJ);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MDBFKHFNCGP(LNAPBGCAIIL DDPEIHFGGKE, LNAPBGCAIIL CDONMEHBEBH, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HPPPMKLHNON(LNAPBGCAIIL DDPEIHFGGKE, int MDJELHAMOHJ, LNAPBGCAIIL LBOOKOKCBHL, int CIKBMGDKHEJ, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BJFPPKPLINH(LNAPBGCAIIL DDPEIHFGGKE);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "16")]
	OLCIGFHLLEM FOALPIOAIHG(bool JLDCAKEIACB);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "17")]
	OLCIGFHLLEM MMBECACMAOB(HashSet<Guid> AIILGHFCBLA, bool JLDCAKEIACB);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MIKIEJFIKBJ(DHNBFDEFDEB JDNLPMLJDPE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LLEDPBDPEFA(OLCIGFHLLEM LIPFFAIMLKE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FMJCLMEEPND(OLCIGFHLLEM LIPFFAIMLKE);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LFMGNOMMLMF(OLCIGFHLLEM LIPFFAIMLKE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LNINCLPBIHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool KMMCJNIIPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LNAPBGCAIIL FANCDNFHFBL(int NOIFAKCBCCF);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LNAPBGCAIIL GECACAGFCPK(Guid KIPEECENOPC);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JBJGIJIGEGJ(LNAPBGCAIIL DDPEIHFGGKE);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GFHDBNEJIMB();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EKHKJGPDOML(LNAPBGCAIIL EGNMLHCMFAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[ServiceLifetime(Lifetime.Application)]
public interface GOAJJJFNAOG
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKGCMBAEKHK(BFHFEGCJFFJ EGNMLHCMFAJ);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IMHCOJDJFOL(BFHFEGCJFFJ EGNMLHCMFAJ);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string NBOHNBCFHOP(BFHFEGCJFFJ EGNMLHCMFAJ);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid MOMELMDLNFA(BFHFEGCJFFJ EGNMLHCMFAJ);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int EKJPFJNPNAA(BFHFEGCJFFJ EGNMLHCMFAJ);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMBKHFMEPDN(BFHFEGCJFFJ EGNMLHCMFAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public delegate void GOKJILOCHHO(LNAPBGCAIIL IDOCGCDLFAJ, int IDIHPFDLCKJ, LNAPBGCAIIL NECCGCDBJPF, int FPMPNPPEHBI, [Optional] Vector3? NLEOEIHBFKL, [Optional] Quaternion? FJCGMNKEFID);
[Cpp2IlInjected.Token(Token = "0x2000015")]
public delegate void GPKPPCMLIPH(LNAPBGCAIIL NEGNLNEKBJG, LNAPBGCAIIL JENPMLIJDPN);
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BFHFEGCJFFJ : LNAPBGCAIIL, GFIAMLKFPOO, IEquatable<LNAPBGCAIIL>
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DCHGOIKGMOE : GFIAMLKFPOO
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	LNAPBGCAIIL HMAKPADIDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	IEnumerable<LNAPBGCAIIL> JCNHINCCMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	Vector3 FDDGEHCPIGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	Quaternion DFGJNMEHMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool EHCPPGENBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool AOHHBPNJJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "14")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event GOKJILOCHHO CEAHKOMJMAC;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event GOKJILOCHHO KPHEAAGAMGC;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event GOKJILOCHHO DOPGBDEDMAF;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event GPKPPCMLIPH OJMENFEAHLC;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NLNNABDBLFO();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ODCOABNFDHI();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EJBPMPEFKJO();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void HMIJDDGNMIB();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void MDFEEAJEGHK();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NDDJNGCMIFO();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HIHBEOFFCGH(int FONONCEMPGM, LNAPBGCAIIL NECCGCDBJPF, int GABIDFJGIGM);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IEHOPJBDBEG();

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void IMOEJAFJGNK(int FONONCEMPGM, LNAPBGCAIIL IDOCGCDLFAJ, int KDOLCBKLHME, [Optional] Vector3? NLEOEIHBFKL, [Optional] Quaternion? FJCGMNKEFID);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void NCMPLOENDED(LNAPBGCAIIL IDOCGCDLFAJ);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void EHJMFDIIJLB();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DGELCALEOKP(int KNCPCNBMDNF, Vector3 COKJJHJKDKB);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HBNEGMIDHGD(Vector3 FCAMHKCPNDP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GKEJGIIFGGC
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	Vector3 ILCGGIDKPEL
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
public interface DFGKEGHKDMN
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool KOLAHAFHOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	FBCDKBKIGNB JJPEAMHBLDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ConnectableConfigData : ScriptableObject, DFGKEGHKDMN
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
			[Cpp2IlInjected.Address(RVA = "0xBE0400", Offset = "0xBDF200", VA = "0x180BE0400", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public FBCDKBKIGNB LegacyLinkVisualPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x71AC730", Offset = "0x71AB530", VA = "0x1871AC730")]
		public static ConnectableConfigData FFKFLPFEAGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x71AC7F0", Offset = "0x71AB5F0", VA = "0x1871AC7F0")]
		public ConnectableConfigData(LegacyConnectableLinkVisual FNEPEJODOPM, bool AFONHEEKNEC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DFDMHJNGKOI : IEquatable<DFDMHJNGKOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public LNAPBGCAIIL DDPEIHFGGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int CFNGNNDNPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int GMAPAGBIEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector3 NLEOEIHBFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Quaternion FJCGMNKEFID;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x71ACF20", Offset = "0x71ABD20", VA = "0x1871ACF20")]
	public DFDMHJNGKOI(LNAPBGCAIIL DDPEIHFGGKE, int CFNGNNDNPAC, int GMAPAGBIEAI, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x71AD010", Offset = "0x71ABE10", VA = "0x1871AD010")]
	public DFDMHJNGKOI(LNAPBGCAIIL DDPEIHFGGKE, int CFNGNNDNPAC, int GMAPAGBIEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x71ACF80", Offset = "0x71ABD80", VA = "0x1871ACF80")]
	public DFDMHJNGKOI(LNAPBGCAIIL DDPEIHFGGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x71ACAA0", Offset = "0x71AB8A0", VA = "0x1871ACAA0", Slot = "4")]
	public bool Equals(DFDMHJNGKOI LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x71ACB50", Offset = "0x71AB950", VA = "0x1871ACB50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[UnityEngine.Scripting.Preserve]
public class PFFODLCLPKJ : OBENHCPDLIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Transform KAEMFHJNGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private FBCDKBKIGNB ICIJGKNABCA;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6C3BCB0", Offset = "0x6C3AAB0", VA = "0x186C3BCB0", Slot = "4")]
	public void JEELJGCJJCO(Transform KAEMFHJNGPI, FBCDKBKIGNB ICIJGKNABCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x71C06A0", Offset = "0x71BF4A0", VA = "0x1871C06A0", Slot = "5")]
	public FBCDKBKIGNB AMDFKKJMEKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x71C0760", Offset = "0x71BF560", VA = "0x1871C0760", Slot = "6")]
	public void MGDJHDFFKHI(FBCDKBKIGNB HNHKLGCEHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public PFFODLCLPKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class HFMNAKHOLEO : IDisposable, IFGAIPGBCOK
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EHIOJGGBDOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public LNAPBGCAIIL oldRootConnectable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public LNAPBGCAIIL newRootConnectable;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public EHIOJGGBDOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x71AD330", Offset = "0x71AC130", VA = "0x1871AD330")]
		internal bool DBBFLKMFIBI(JEFPJKOOIDB node)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly AABOEAGFIOJ IBBKLBFNGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private GNMJACBJHDJ EPGEDCNGJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private DBDBLDANJJJ LFLBNOFMAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool AFONHEEKNEC;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly IMOCAMGHNDM JBFDMAAMOBI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JEFPJKOOIDB DIPIAJCGAGN
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x71B4040", Offset = "0x71B2E40", VA = "0x1871B4040")]
	public bool LGKMBLICHAB([In] DIIDGFDKBEP JOAPLPPIFPC, bool KKELODCGHDG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x71B3A80", Offset = "0x71B2880", VA = "0x1871B3A80")]
	private bool KADJMBFBKPE([In] DIIDGFDKBEP JOAPLPPIFPC, bool KKELODCGHDG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x71B4D90", Offset = "0x71B3B90", VA = "0x1871B4D90")]
	public HFMNAKHOLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x71B3810", Offset = "0x71B2610", VA = "0x1871B3810", Slot = "5")]
	public void JEELJGCJJCO(MDIOAMPOCNO HLDNIAJEGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x71B4A60", Offset = "0x71B3860", VA = "0x1871B4A60", Slot = "17")]
	public void PBCMKFKAJAL(FANJBGGLLEK JMGOMJNPFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x71B3130", Offset = "0x71B1F30", VA = "0x1871B3130", Slot = "12")]
	public void HLAJNALKPJP(Func<LNAPBGCAIIL, bool> KAHKKBBAEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x71B3000", Offset = "0x71B1E00", VA = "0x1871B3000")]
	private void HLAJNALKPJP(AABOEAGFIOJ KFDHCNOCENN, Func<LNAPBGCAIIL, bool> KAHKKBBAEJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x71B4220", Offset = "0x71B3020", VA = "0x1871B4220", Slot = "11")]
	public void KPNEHFPOEOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x71B1B80", Offset = "0x71B0980", VA = "0x1871B1B80", Slot = "8")]
	public bool BCGGLHMBGOD(LNAPBGCAIIL EBOADEHKBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x71B27D0", Offset = "0x71B15D0", VA = "0x1871B27D0")]
	private bool HFHHFEFMPLD(LNAPBGCAIIL JIPMCHAGCGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x71B1FA0", Offset = "0x71B0DA0", VA = "0x1871B1FA0")]
	private static bool CHENOECPFGJ(LNAPBGCAIIL JIPMCHAGCGN, AABOEAGFIOJ PJHFNGDPABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x71B3180", Offset = "0x71B1F80", VA = "0x1871B3180")]
	private void HLPCPMOIKEK(Transform CHOJDAKFFMM, AABOEAGFIOJ GHCIJODOANF, AABOEAGFIOJ[] BFCMFEENEMP, LNAPBGCAIIL EOGGPNACKLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x71B2510", Offset = "0x71B1310", VA = "0x1871B2510")]
	private DFDMHJNGKOI FBKPNFLGBKP(Transform PMAIPCLKCJE, DFDMHJNGKOI IDIALOIONHM)
	{
		return default(DFDMHJNGKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x71B38C0", Offset = "0x71B26C0", VA = "0x1871B38C0")]
	private static bool JEGCAECFLIJ(AABOEAGFIOJ PJHFNGDPABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x71B19C0", Offset = "0x71B07C0", VA = "0x1871B19C0", Slot = "9")]
	public bool AJDOCBDFOKC(LNAPBGCAIIL JCAKCOJJFCM, int KDOLCBKLHME, int GABIDFJGIGM, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x71B3560", Offset = "0x71B2360", VA = "0x1871B3560")]
	private bool IMGBFONDCEG(LNAPBGCAIIL JCAKCOJJFCM, int KDOLCBKLHME, int GABIDFJGIGM, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x71B2260", Offset = "0x71B1060", VA = "0x1871B2260")]
	private static void DNCABMBNAEP(LNAPBGCAIIL JCAKCOJJFCM, int KDOLCBKLHME, int GABIDFJGIGM, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID, AABOEAGFIOJ FINFOEHJKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x71B4240", Offset = "0x71B3040", VA = "0x1871B4240")]
	private void MBJAGKFGMJC(LNAPBGCAIIL OILBIEHFDJG, int MDJELHAMOHJ, LNAPBGCAIIL LBOOKOKCBHL, int CIKBMGDKHEJ, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x71B21F0", Offset = "0x71B0FF0", VA = "0x1871B21F0")]
	private void DEDKNFGHIBK(AABOEAGFIOJ KFDHCNOCENN, LNAPBGCAIIL PECHBKJABHG, LNAPBGCAIIL CBHPLMNJMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x71B2180", Offset = "0x71B0F80", VA = "0x1871B2180")]
	private void DEDKNFGHIBK(LNAPBGCAIIL DDPEIHFGGKE, LNAPBGCAIIL PECHBKJABHG, LNAPBGCAIIL CBHPLMNJMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x71B2660", Offset = "0x71B1460", VA = "0x1871B2660")]
	private void GHJFPONDIAC(LNAPBGCAIIL DDPEIHFGGKE, LNAPBGCAIIL PECHBKJABHG, LNAPBGCAIIL CBHPLMNJMDN, bool HHGJBHHOKKE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x71B26D0", Offset = "0x71B14D0", VA = "0x1871B26D0")]
	private void GHJFPONDIAC(AABOEAGFIOJ DOJENPPADJD, LNAPBGCAIIL EOGGPNACKLK, LNAPBGCAIIL JENPMLIJDPN, bool HHGJBHHOKKE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x71B4BA0", Offset = "0x71B39A0", VA = "0x1871B4BA0")]
	private void PLAKHPJJJKE(LNAPBGCAIIL DOOFGBAMPBE, int KDOLCBKLHME, LNAPBGCAIIL LBOOKOKCBHL, int CIKBMGDKHEJ, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x71B4050", Offset = "0x71B2E50", VA = "0x1871B4050")]
	private void KNADJEMIJJP(JEFPJKOOIDB IFAMCPHMKIP, JEFPJKOOIDB INPGOIPLAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x71B1A20", Offset = "0x71B0820", VA = "0x1871B1A20", Slot = "18")]
	public LNAPBGCAIIL AKLGBIOIPHP(LNAPBGCAIIL DDPEIHFGGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x71B1B90", Offset = "0x71B0990", VA = "0x1871B1B90", Slot = "13")]
	public void BCNCADPADAH(LNAPBGCAIIL DDPEIHFGGKE, HashSet<LNAPBGCAIIL> DAFNBBGLFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x71B2DC0", Offset = "0x71B1BC0", VA = "0x1871B2DC0", Slot = "14")]
	public List<LNAPBGCAIIL> HKOLPKKEMPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x71B48F0", Offset = "0x71B36F0", VA = "0x1871B48F0")]
	protected JEFPJKOOIDB NOLAOJBEKJM(JEFPJKOOIDB KFDHCNOCENN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x71B49C0", Offset = "0x71B37C0", VA = "0x1871B49C0")]
	protected AABOEAGFIOJ[] OOPMJDKHIEJ(AABOEAGFIOJ PJHFNGDPABK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x71B4A90", Offset = "0x71B3890", VA = "0x1871B4A90")]
	protected bool PHNDGKOHEDK(LNAPBGCAIIL DDPEIHFGGKE, [Out] AABOEAGFIOJ KFDHCNOCENN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x71B2050", Offset = "0x71B0E50", VA = "0x1871B2050", Slot = "15")]
	public bool DCEHGHOGMDJ(LNAPBGCAIIL DDPEIHFGGKE, [Out] DFDMHJNGKOI CJGMHAIPPNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x71B3140", Offset = "0x71B1F40", VA = "0x1871B3140")]
	protected AABOEAGFIOJ HLLPGKBJCNH(DFDMHJNGKOI DHKAOBPAGOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x71B1F40", Offset = "0x71B0D40", VA = "0x1871B1F40", Slot = "10")]
	public bool BHOKFKBJCPE(LNAPBGCAIIL OILBIEHFDJG, int MDJELHAMOHJ, LNAPBGCAIIL LBOOKOKCBHL, int CIKBMGDKHEJ, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x71B4360", Offset = "0x71B3160", VA = "0x1871B4360")]
	private bool NNPBHJMOBGK(LNAPBGCAIIL OILBIEHFDJG, int MDJELHAMOHJ, LNAPBGCAIIL LBOOKOKCBHL, int CIKBMGDKHEJ, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x71B2440", Offset = "0x71B1240", VA = "0x1871B2440")]
	private static bool EMCIBEKJEDK(AABOEAGFIOJ DPNKBMAMMDF, DFDMHJNGKOI PPJKMABLNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x71B4040", Offset = "0x71B2E40", VA = "0x1871B4040", Slot = "7")]
	private bool KDMJFJHPFJO([In] DIIDGFDKBEP JOAPLPPIFPC, bool KKELODCGHDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[UnityEngine.Scripting.Preserve]
internal class JBCKOKFJBGC : MDIOAMPOCNO, EJBGNPMNAED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly IEPIHLKICIO BCNFHKMHIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly DBDBLDANJJJ LFLBNOFMAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	internal readonly NOIGIDNIOIK KCMPOKMAOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly GHJGLDMBAGP HKKPJLKBJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal readonly IFGAIPGBCOK LIPFFAIMLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal GLFCBKGGDGA BPGIOHMMDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal BGJGLPFIFCK JGDMKGHAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal GNMJACBJHDJ KJAKMDKGDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal bool AFONHEEKNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private bool CMOMCNOGNJD;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool PMIENFHPDHA
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xABDF30", Offset = "0xABCD30", VA = "0x180ABDF30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x10AD250", Offset = "0x10AC050", VA = "0x1810AD250")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OBOEGBKEDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xF8EAF0", Offset = "0xF8D8F0", VA = "0x180F8EAF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x22DE4B0", Offset = "0x22DD2B0", VA = "0x1822DE4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool LGKBHJJGBEC
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<LNAPBGCAIIL, LNAPBGCAIIL> GIMHLAKKPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x71B5690", Offset = "0x71B4490", VA = "0x1871B5690", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x71B51C0", Offset = "0x71B3FC0", VA = "0x1871B51C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<LNAPBGCAIIL, LNAPBGCAIIL> PGPOOIJIHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x71B5010", Offset = "0x71B3E10", VA = "0x1871B5010", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x71B53E0", Offset = "0x71B41E0", VA = "0x1871B53E0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<LNAPBGCAIIL, LNAPBGCAIIL, LNAPBGCAIIL> LAEEBFGIBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x71B5070", Offset = "0x71B3E70", VA = "0x1871B5070", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x71B56F0", Offset = "0x71B44F0", VA = "0x1871B56F0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x71B6CF0", Offset = "0x71B5AF0", VA = "0x1871B6CF0")]
	public JBCKOKFJBGC(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x71B5AC0", Offset = "0x71B48C0", VA = "0x1871B5AC0", Slot = "12")]
	public void JEELJGCJJCO(GameObject IHNPMPCJPIK, DFGKEGHKDMN FMOBMCFIDCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x71B6C50", Offset = "0x71B5A50", VA = "0x1871B6C50", Slot = "26")]
	public void OAKNFNBDPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x71B58F0", Offset = "0x71B46F0", VA = "0x1871B58F0", Slot = "13")]
	public void IGIPDIBMNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x71B5440", Offset = "0x71B4240", VA = "0x1871B5440", Slot = "14")]
	public void EHDMJEMLBPD(LNAPBGCAIIL DDPEIHFGGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x71B5750", Offset = "0x71B4550", VA = "0x1871B5750", Slot = "15")]
	public void HLGNNFLCMJP(LNAPBGCAIIL DDPEIHFGGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x71B6660", Offset = "0x71B5460", VA = "0x1871B6660", Slot = "22")]
	public bool MIKIEJFIKBJ(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x71B60E0", Offset = "0x71B4EE0", VA = "0x1871B60E0")]
	internal bool KADJMBFBKPE([In] DIIDGFDKBEP JOAPLPPIFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x71B6980", Offset = "0x71B5780", VA = "0x1871B6980")]
	internal bool NNPBHJMOBGK([In] DIIDGFDKBEP JOAPLPPIFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x71B6080", Offset = "0x71B4E80", VA = "0x1871B6080")]
	internal bool JNNNBKGNFIF([In] DIIDGFDKBEP JOAPLPPIFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x71B5970", Offset = "0x71B4770", VA = "0x1871B5970")]
	internal bool IMKFHAANDNH([In] DIIDGFDKBEP JOAPLPPIFPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x71B6480", Offset = "0x71B5280", VA = "0x1871B6480")]
	internal void MEIPOLEJIKG(LNAPBGCAIIL DDPEIHFGGKE, int HCOAGIHEBEP, bool KKELODCGHDG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x71B5750", Offset = "0x71B4550", VA = "0x1871B5750")]
	internal bool PDLPEKPCMIL(LNAPBGCAIIL CFAPIKCNBCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x71B66B0", Offset = "0x71B54B0", VA = "0x1871B66B0")]
	internal bool MKJJJDCLEPN(LNAPBGCAIIL JCAKCOJJFCM, int KDOLCBKLHME, int GABIDFJGIGM, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x71B50D0", Offset = "0x71B3ED0", VA = "0x1871B50D0", Slot = "16")]
	public void BCNCADPADAH(LNAPBGCAIIL DDPEIHFGGKE, HashSet<LNAPBGCAIIL> JCFGBKEDLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x71B6270", Offset = "0x71B5070", VA = "0x1871B6270", Slot = "17")]
	public void MDBFKHFNCGP(LNAPBGCAIIL JCAKCOJJFCM, LNAPBGCAIIL CDONMEHBEBH, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x71B57B0", Offset = "0x71B45B0", VA = "0x1871B57B0", Slot = "18")]
	public void HPPPMKLHNON(LNAPBGCAIIL OILBIEHFDJG, int MDJELHAMOHJ, LNAPBGCAIIL LBOOKOKCBHL, int CIKBMGDKHEJ, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x71B5220", Offset = "0x71B4020", VA = "0x1871B5220", Slot = "19")]
	public void BJFPPKPLINH(LNAPBGCAIIL OILBIEHFDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x71B6A10", Offset = "0x71B5810", VA = "0x1871B6A10")]
	public void OADDJGCLFFB([Optional] CJFICBKGKGE KFNALGBCHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x71B61E0", Offset = "0x71B4FE0", VA = "0x1871B61E0", Slot = "23")]
	public void LLEDPBDPEFA(OLCIGFHLLEM LIPFFAIMLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x71B5510", Offset = "0x71B4310", VA = "0x1871B5510", Slot = "20")]
	public OLCIGFHLLEM FOALPIOAIHG(bool JLDCAKEIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x71B67E0", Offset = "0x71B55E0", VA = "0x1871B67E0", Slot = "21")]
	public OLCIGFHLLEM MMBECACMAOB(HashSet<Guid> AIILGHFCBLA, bool JLDCAKEIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x71B61A0", Offset = "0x71B4FA0", VA = "0x1871B61A0", Slot = "25")]
	public void LFMGNOMMLMF(OLCIGFHLLEM LIPFFAIMLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x71B5460", Offset = "0x71B4260", VA = "0x1871B5460", Slot = "24")]
	public void FMJCLMEEPND(OLCIGFHLLEM LIPFFAIMLKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal class DBDBLDANJJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly HPCPKCGMACP<LNAPBGCAIIL, LNAPBGCAIIL> GIMHLAKKPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly HPCPKCGMACP<LNAPBGCAIIL, LNAPBGCAIIL> PGPOOIJIHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly COCBDDCHECL<LNAPBGCAIIL, LNAPBGCAIIL, LNAPBGCAIIL> LAEEBFGIBOH;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x71AC980", Offset = "0x71AB780", VA = "0x1871AC980")]
	public DBDBLDANJJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	public void JEELJGCJJCO(JBCKOKFJBGC HLDNIAJEGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x71AC840", Offset = "0x71AB640", VA = "0x1871AC840")]
	public void ENAIJPIBKGB(LNAPBGCAIIL IFAMCPHMKIP, LNAPBGCAIIL DOOFGBAMPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x71AC8A0", Offset = "0x71AB6A0", VA = "0x1871AC8A0")]
	public void MBHJKDEFBMO(LNAPBGCAIIL IFAMCPHMKIP, LNAPBGCAIIL DOOFGBAMPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x71AC900", Offset = "0x71AB700", VA = "0x1871AC900")]
	public void NLIPMHGBHHE(LNAPBGCAIIL NJOCGFOKJDP, LNAPBGCAIIL LBOOKOKCBHL, LNAPBGCAIIL DOOFGBAMPBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class NOIGIDNIOIK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private JBCKOKFJBGC HLDNIAJEGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private BGJGLPFIFCK JGDMKGHAADE;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public NOIGIDNIOIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x71C0400", Offset = "0x71BF200", VA = "0x1871C0400")]
	public void JEELJGCJJCO(JBCKOKFJBGC HLDNIAJEGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x71C03D0", Offset = "0x71BF1D0", VA = "0x1871C03D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x71C03E0", Offset = "0x71BF1E0", VA = "0x1871C03E0")]
	private void HOMOBBLMLOJ(CJFICBKGKGE CJJBIEHOBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x71C0530", Offset = "0x71BF330", VA = "0x1871C0530")]
	private void JOICHOMAGLA(CJFICBKGKGE PMLHAJCDCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x71C05A0", Offset = "0x71BF3A0", VA = "0x1871C05A0")]
	public void PNCPFCLGIOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x71C02D0", Offset = "0x71BF0D0", VA = "0x1871C02D0")]
	public void CKGCGFHGCII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LKLMOABIOKH
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class NGPKJOCMJNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public IEPIHLKICIO container;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public NGPKJOCMJNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x71C0260", Offset = "0x71BF060", VA = "0x1871C0260")]
		internal JBCKOKFJBGC PDMIGKHGBEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x71B9360", Offset = "0x71B8160", VA = "0x1871B9360")]
	public static void HDFOBHIJIBI(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x71B92E0", Offset = "0x71B80E0", VA = "0x1871B92E0")]
	public static void GFMEPBJIPIN(IEPIHLKICIO BCNFHKMHIOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[UnityEngine.Scripting.Preserve]
internal class FAINMNJGMHK : IDisposable, GNMJACBJHDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, FBCDKBKIGNB> DIHNJAJJNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly FANJBGGLLEK ECJPKMIBNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private OBENHCPDLIN DNJEKDGCDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private IFGAIPGBCOK LIPFFAIMLKE;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static ProfilerMarker OOBJDHKCBMH;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x71AEBE0", Offset = "0x71AD9E0", VA = "0x1871AEBE0")]
	public FAINMNJGMHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x71AE7D0", Offset = "0x71AD5D0", VA = "0x1871AE7D0", Slot = "7")]
	public void JEELJGCJJCO(IFGAIPGBCOK LIPFFAIMLKE, OBENHCPDLIN DNJEKDGCDMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x71AE1C0", Offset = "0x71ACFC0", VA = "0x1871AE1C0", Slot = "5")]
	public void DBLFGENICAJ(JEFPJKOOIDB EBPGLMNFFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x71AE590", Offset = "0x71AD390", VA = "0x1871AE590", Slot = "9")]
	public void HCDACFOKKDM(JEFPJKOOIDB HPPBMOALFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x71AE810", Offset = "0x71AD610", VA = "0x1871AE810", Slot = "8")]
	public void NBFMGLJJPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x71ADF70", Offset = "0x71ACD70", VA = "0x1871ADF70", Slot = "10")]
	public void BOKKHIKECBD(JEFPJKOOIDB GFHFHDNHPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x71ADDF0", Offset = "0x71ACBF0", VA = "0x1871ADDF0", Slot = "11")]
	public void BJNLNGIACFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x71AE9D0", Offset = "0x71AD7D0", VA = "0x1871AE9D0")]
	private bool NFCFEIOKDDP(JEFPJKOOIDB PANJCGCFAKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class GHJGLDMBAGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	internal struct EHNKKNOOIAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private readonly AABOEAGFIOJ ADCNGGMICEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly HashSet<Guid> AIILGHFCBLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly DHNBFDEFDEB ADHHGLDPGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly DHNBFDEFDEB BADOEJCGBPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly bool JLDCAKEIACB;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool JGCGEOCECPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x71AD4C0", Offset = "0x71AC2C0", VA = "0x1871AD4C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x71ADD80", Offset = "0x71ACB80", VA = "0x1871ADD80")]
		public EHNKKNOOIAH(AABOEAGFIOJ ADCNGGMICEB, HashSet<Guid> AIILGHFCBLA, bool JLDCAKEIACB, [Optional] DHNBFDEFDEB ADHHGLDPGAC, [Optional] DHNBFDEFDEB BADOEJCGBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x71ADBE0", Offset = "0x71AC9E0", VA = "0x1871ADBE0")]
		public DHNBFDEFDEB NPIKEPIONAB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x71AD960", Offset = "0x71AC760", VA = "0x1871AD960")]
		private DHNBFDEFDEB MOKPIFDDBDJ([Out] DHNBFDEFDEB LGDHJCAEJAH, [Out] DHNBFDEFDEB GJDMIOCBJOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x71AD5D0", Offset = "0x71AC3D0", VA = "0x1871AD5D0")]
		private DHNBFDEFDEB MKAEHHGPOED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x71AD7F0", Offset = "0x71AC5F0", VA = "0x1871AD7F0")]
		private void MNMFIACHLEF(DHNBFDEFDEB PILKNHKAHMI, DHNBFDEFDEB BFBHPHKBDCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x71ADA20", Offset = "0x71AC820", VA = "0x1871ADA20")]
		private void NHNDFPLKDNH(DHNBFDEFDEB LGDHJCAEJAH, DHNBFDEFDEB GJDMIOCBJOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private JBCKOKFJBGC HLDNIAJEGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private IFGAIPGBCOK LIPFFAIMLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private GNMJACBJHDJ EPGEDCNGJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private BGJGLPFIFCK JGDMKGHAADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool OPAOCGMFOOK;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool ONDFMJNMKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x71AF6E0", Offset = "0x71AE4E0", VA = "0x1871AF6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool PMIENFHPDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x71B0660", Offset = "0x71AF460", VA = "0x1871B0660")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x71AEF10", Offset = "0x71ADD10", VA = "0x1871AEF10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x71B0680", Offset = "0x71AF480", VA = "0x1871B0680")]
	public void JEELJGCJJCO(JBCKOKFJBGC HLDNIAJEGKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x71AF950", Offset = "0x71AE750", VA = "0x1871AF950")]
	public OLCIGFHLLEM FOALPIOAIHG(bool JLDCAKEIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x71B12A0", Offset = "0x71B00A0", VA = "0x1871B12A0")]
	public OLCIGFHLLEM MMBECACMAOB(HashSet<Guid> AIILGHFCBLA, bool JLDCAKEIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x71B0F40", Offset = "0x71AFD40", VA = "0x1871B0F40")]
	public void LLEDPBDPEFA(OLCIGFHLLEM LIPFFAIMLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x71AF8B0", Offset = "0x71AE6B0", VA = "0x1871AF8B0")]
	public void FMJCLMEEPND(OLCIGFHLLEM LIPFFAIMLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x71B0630", Offset = "0x71AF430", VA = "0x1871B0630")]
	public void HGMLCOGNGAD(OLCIGFHLLEM LIPFFAIMLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x71AEF30", Offset = "0x71ADD30", VA = "0x1871AEF30")]
	private void BJJOEIIKEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x71B1440", Offset = "0x71B0240", VA = "0x1871B1440")]
	private DHNBFDEFDEB OEMFFAMLNLE(AABOEAGFIOJ KFDHCNOCENN, bool JLDCAKEIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x71B0880", Offset = "0x71AF680", VA = "0x1871B0880")]
	private static void LBNMDIMHFMM(AABOEAGFIOJ KFDHCNOCENN, bool JLDCAKEIACB, DHNBFDEFDEB JDNLPMLJDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x71B0410", Offset = "0x71AF210", VA = "0x1871B0410")]
	private void HEOBNLEKHJI(AABOEAGFIOJ KFDHCNOCENN, bool JLDCAKEIACB, DHNBFDEFDEB JDNLPMLJDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x71B1530", Offset = "0x71B0330", VA = "0x1871B1530")]
	private DHNBFDEFDEB PFFPJKBIOJJ(AABOEAGFIOJ ADCNGGMICEB, HashSet<Guid> AIILGHFCBLA, bool JLDCAKEIACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x71AF110", Offset = "0x71ADF10", VA = "0x1871AF110")]
	private bool BOMKDPABLBO(OLCIGFHLLEM PILILNPGAMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x71AFCB0", Offset = "0x71AEAB0", VA = "0x1871AFCB0")]
	private bool GLKDLMLCJMO(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x71B0C50", Offset = "0x71AFA50", VA = "0x1871B0C50")]
	private bool LGCMMCNJLHF(OLCIGFHLLEM LIPFFAIMLKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x71B0B30", Offset = "0x71AF930", VA = "0x1871B0B30")]
	private static bool LFGEEGOBHOF(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x71B1010", Offset = "0x71AFE10", VA = "0x1871B1010")]
	public static bool MIKIEJFIKBJ(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x71AF390", Offset = "0x71AE190", VA = "0x1871AF390")]
	private LNAPBGCAIIL CCMEHDJLJPJ(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x71AF730", Offset = "0x71AE530", VA = "0x1871AF730")]
	private LNAPBGCAIIL FANCDNFHFBL(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x71B06F0", Offset = "0x71AF4F0", VA = "0x1871B06F0")]
	private LNAPBGCAIIL KHJFFKCJPOO(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x71B0FD0", Offset = "0x71AFDD0", VA = "0x1871B0FD0")]
	private static Guid MIIAOJDALDF(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x71B0320", Offset = "0x71AF120", VA = "0x1871B0320")]
	private string GOKAEJPOAAH(DHNBFDEFDEB JDNLPMLJDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x71AFAC0", Offset = "0x71AE8C0", VA = "0x1871AFAC0")]
	private bool GEBFLPNGNDB(AABOEAGFIOJ KFDHCNOCENN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x71B0C70", Offset = "0x71AFA70", VA = "0x1871B0C70")]
	private static void LKCMJHNKIIN(AABOEAGFIOJ ADCNGGMICEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public GHJGLDMBAGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal struct DIIDGFDKBEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public LNAPBGCAIIL DOOFGBAMPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public LNAPBGCAIIL IFAMCPHMKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int KDOLCBKLHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int GABIDFJGIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector3 NLEOEIHBFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Quaternion FJCGMNKEFID;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public DFDMHJNGKOI BIJHIKOOABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x71AD1F0", Offset = "0x71ABFF0", VA = "0x1871AD1F0")]
		get
		{
			return default(DFDMHJNGKOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public DFDMHJNGKOI PAIBFINCGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x71AD290", Offset = "0x71AC090", VA = "0x1871AD290")]
		get
		{
			return default(DFDMHJNGKOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x71AD2C0", Offset = "0x71AC0C0", VA = "0x1871AD2C0")]
	public DIIDGFDKBEP(LNAPBGCAIIL DOOFGBAMPBE, LNAPBGCAIIL IFAMCPHMKIP, int KDOLCBKLHME, int GABIDFJGIGM, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface IFGAIPGBCOK
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	JEFPJKOOIDB DIPIAJCGAGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEELJGCJJCO(MDIOAMPOCNO HLDNIAJEGKP);

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LGKMBLICHAB([In] DIIDGFDKBEP JOAPLPPIFPC, bool KKELODCGHDG = true);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BCGGLHMBGOD(LNAPBGCAIIL EBOADEHKBKF);

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AJDOCBDFOKC(LNAPBGCAIIL JCAKCOJJFCM, int KDOLCBKLHME, int GABIDFJGIGM, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID);

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BHOKFKBJCPE(LNAPBGCAIIL OILBIEHFDJG, int MDJELHAMOHJ, LNAPBGCAIIL LBOOKOKCBHL, int CIKBMGDKHEJ, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID);

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KPNEHFPOEOO();

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HLAJNALKPJP(Func<LNAPBGCAIIL, bool> KAHKKBBAEJG);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BCNCADPADAH(LNAPBGCAIIL DDPEIHFGGKE, HashSet<LNAPBGCAIIL> DAFNBBGLFEI);

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "9")]
	List<LNAPBGCAIIL> HKOLPKKEMPM();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DCEHGHOGMDJ(LNAPBGCAIIL DDPEIHFGGKE, [Out] DFDMHJNGKOI CJGMHAIPPNL);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PBCMKFKAJAL(FANJBGGLLEK JMGOMJNPFIN);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal delegate bool FANJBGGLLEK(JEFPJKOOIDB KFDHCNOCENN);
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface JEFPJKOOIDB
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LNAPBGCAIIL OMIEJKCPLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	JEFPJKOOIDB LCIGPFKHHMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DFDMHJNGKOI OHCBLNJAIBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool JKMHMLJIAEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FBCDKBKIGNB : DKPDMABDAHO.JPJJFDLJDCD
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EODJIAICOIO(LNAPBGCAIIL NECCGCDBJPF, DFDMHJNGKOI DOOFGBAMPBE);

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJHGKMJJBHN(LNAPBGCAIIL NECCGCDBJPF, DFDMHJNGKOI DOOFGBAMPBE);

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBJCMGKCCKO(LNAPBGCAIIL NECCGCDBJPF, DFDMHJNGKOI DOOFGBAMPBE);

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GPKPPIIMDFF(LNAPBGCAIIL NECCGCDBJPF, DFDMHJNGKOI DOOFGBAMPBE);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FBCDKBKIGNB Instantiate(Transform KAEMFHJNGPI);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MJMAPJMIAED();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface OBENHCPDLIN
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEELJGCJJCO(Transform KAEMFHJNGPI, FBCDKBKIGNB ICIJGKNABCA);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FBCDKBKIGNB AMDFKKJMEKN();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MGDJHDFFKHI(FBCDKBKIGNB HNHKLGCEHNA);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface GLFCBKGGDGA : LNINCLPBIHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPLAKGNIBAI();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FCFAMCMDOEN(Guid JJJCAJFEAAO);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface GNMJACBJHDJ
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBLFGENICAJ(JEFPJKOOIDB EBPGLMNFFOP);

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JEELJGCJJCO(IFGAIPGBCOK LIPFFAIMLKE, OBENHCPDLIN MLENHGFFECG);

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NBFMGLJJPBN();

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCDACFOKKDM(JEFPJKOOIDB HPPBMOALFLM);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BOKKHIKECBD(JEFPJKOOIDB GFHFHDNHPFL);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BJNLNGIACFC();
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal class AABOEAGFIOJ : JEFPJKOOIDB
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class DHMINJDKALL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public DFDMHJNGKOI nodeContentToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AABOEAGFIOJ foundNode;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DHMINJDKALL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x71AD0B0", Offset = "0x71ABEB0", VA = "0x1871AD0B0")]
		internal bool NGAKIDOGPOE(JEFPJKOOIDB x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private DFDMHJNGKOI CJGMHAIPPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public LinkedList<AABOEAGFIOJ> FDEJDHNLPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private AABOEAGFIOJ FEFOLINAAPC;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DFDMHJNGKOI OHCBLNJAIBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x10AD5B0", Offset = "0x10AC3B0", VA = "0x1810AD5B0", Slot = "6")]
		get
		{
			return default(DFDMHJNGKOI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x10ACC40", Offset = "0x10ABA40", VA = "0x1810ACC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private AABOEAGFIOJ IFAMCPHMKIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x71AB590", Offset = "0x71AA390", VA = "0x1871AB590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public JEFPJKOOIDB LCIGPFKHHMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LNAPBGCAIIL OMIEJKCPLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool JKMHMLJIAEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x71AB2B0", Offset = "0x71AA0B0", VA = "0x1871AB2B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool OEGLGCODDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x71ABA00", Offset = "0x71AA800", VA = "0x1871ABA00", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	protected AABOEAGFIOJ DOJENPPADJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x71ABD10", Offset = "0x71AAB10", VA = "0x1871ABD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x71ABD30", Offset = "0x71AAB30", VA = "0x1871ABD30")]
	public AABOEAGFIOJ(DFDMHJNGKOI HIPBLNDMNBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x71AB2C0", Offset = "0x71AA0C0", VA = "0x1871AB2C0")]
	public AABOEAGFIOJ AOEKKHIFAME(DFDMHJNGKOI PEBCGCCMFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x71AB410", Offset = "0x71AA210", VA = "0x1871AB410")]
	public AABOEAGFIOJ EPMCFOMLBEF(DFDMHJNGKOI JCHBNMNGGBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x71AB770", Offset = "0x71AA570", VA = "0x1871AB770")]
	public AABOEAGFIOJ IEINLEAGPOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x71ABA50", Offset = "0x71AA850", VA = "0x1871ABA50")]
	public void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x71AB950", Offset = "0x71AA750", VA = "0x1871AB950")]
	public AABOEAGFIOJ JJKNGGHJODL(DFDMHJNGKOI LBOOKOKCBHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x71ABBB0", Offset = "0x71AA9B0", VA = "0x1871ABBB0")]
	private static void PBCMKFKAJAL(AABOEAGFIOJ KHHHFCNIDKM, FANJBGGLLEK GOPOAFOKCPE, bool BGLGKEJPBJA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x71ABBA0", Offset = "0x71AA9A0", VA = "0x1871ABBA0", Slot = "9")]
	public void PBCMKFKAJAL(FANJBGGLLEK JMGOMJNPFIN, bool HHGJBHHOKKE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x71AB670", Offset = "0x71AA470", VA = "0x1871AB670")]
	public static AABOEAGFIOJ HLLPGKBJCNH(AABOEAGFIOJ KHHHFCNIDKM, DFDMHJNGKOI BIELBLAKAGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface BGJGLPFIFCK
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool ONDFMJNMKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool KMMCJNIIPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event Action<CJFICBKGKGE> HOMOBBLMLOJ;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event Action<CJFICBKGKGE> JOICHOMAGLA;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void SetManager(JBCKOKFJBGC HLDNIAJEGKP);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void RequestMasterModifyNode(LNAPBGCAIIL JCAKCOJJFCM, LNAPBGCAIIL CDONMEHBEBH, int KDOLCBKLHME, int GABIDFJGIGM, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void RequestMasterReparentNodes(LNAPBGCAIIL OILBIEHFDJG, int MDJELHAMOHJ, LNAPBGCAIIL LBOOKOKCBHL, int CIKBMGDKHEJ, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void RequestDeserializeConnectableGraph(OLCIGFHLLEM LOIKMMEOEBL, [Optional] CJFICBKGKGE KFNALGBCHHH);
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal class LegacyConnectableNetworking : MonoBehaviourPun, BGJGLPFIFCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private JBCKOKFJBGC HLDNIAJEGKP;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool ONDFMJNMKAE
		{
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x71BB390", Offset = "0x71BA190", VA = "0x1871BB390", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool KMMCJNIIPIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x71BB3F0", Offset = "0x71BA1F0", VA = "0x1871BB3F0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		public event Action<CJFICBKGKGE> HOMOBBLMLOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x71BB2E0", Offset = "0x71BA0E0", VA = "0x1871BB2E0", Slot = "13")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x71BB4E0", Offset = "0x71BA2E0", VA = "0x1871BB4E0", Slot = "14")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		public event Action<CJFICBKGKGE> JOICHOMAGLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x71BB230", Offset = "0x71BA030", VA = "0x1871BB230", Slot = "15")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x71BB430", Offset = "0x71BA230", VA = "0x1871BB430", Slot = "16")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8F4480", Offset = "0x8F3280", VA = "0x1808F4480", Slot = "19")]
		public void SetManager(JBCKOKFJBGC HLDNIAJEGKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x71BB200", Offset = "0x71BA000", VA = "0x1871BB200")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x71B9F80", Offset = "0x71B8D80", VA = "0x1871B9F80", Slot = "23")]
		public void RequestMasterConnectNodes(LNAPBGCAIIL IDOCGCDLFAJ, int KDOLCBKLHME, LNAPBGCAIIL NECCGCDBJPF, int GABIDFJGIGM, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x71BA0B0", Offset = "0x71B8EB0", VA = "0x1871BA0B0", Slot = "24")]
		public void RequestMasterDisconnectNode(LNAPBGCAIIL EBOADEHKBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x71BA170", Offset = "0x71B8F70", VA = "0x1871BA170", Slot = "20")]
		public void RequestMasterModifyNode(LNAPBGCAIIL JCAKCOJJFCM, LNAPBGCAIIL CDONMEHBEBH, int KDOLCBKLHME, int GABIDFJGIGM, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x71BA2A0", Offset = "0x71B90A0", VA = "0x1871BA2A0", Slot = "21")]
		public void RequestMasterReparentNodes(LNAPBGCAIIL OILBIEHFDJG, int MDJELHAMOHJ, LNAPBGCAIIL LBOOKOKCBHL, int CIKBMGDKHEJ, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x71BA3D0", Offset = "0x71B91D0", VA = "0x1871BA3D0", Slot = "25")]
		public void RequestMasterReparentToRoot(LNAPBGCAIIL OILBIEHFDJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x71B9E50", Offset = "0x71B8C50", VA = "0x1871B9E50", Slot = "22")]
		public void RequestDeserializeConnectableGraph(OLCIGFHLLEM LOIKMMEOEBL, [Optional] CJFICBKGKGE KFNALGBCHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x71BA7B0", Offset = "0x71B95B0", VA = "0x1871BA7B0")]
		[FFHMIBPHFPB]
		private void RpcMasterConnectNodes(LNAPBGCAIIL IDOCGCDLFAJ, int KDOLCBKLHME, LNAPBGCAIIL NECCGCDBJPF, int GABIDFJGIGM, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x71BAA70", Offset = "0x71B9870", VA = "0x1871BAA70")]
		[FFHMIBPHFPB]
		private void RpcMasterDisconnectNode(LNAPBGCAIIL EBOADEHKBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x71BADB0", Offset = "0x71B9BB0", VA = "0x1871BADB0")]
		[FFHMIBPHFPB]
		private void RpcMasterReparentNodes(LNAPBGCAIIL OILBIEHFDJG, int MDJELHAMOHJ, LNAPBGCAIIL LBOOKOKCBHL, int CIKBMGDKHEJ, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x71BABB0", Offset = "0x71B99B0", VA = "0x1871BABB0")]
		[FFHMIBPHFPB]
		private void RpcMasterModifyNode(LNAPBGCAIIL JCAKCOJJFCM, LNAPBGCAIIL CDONMEHBEBH, int KDOLCBKLHME, int GABIDFJGIGM, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x71BA5A0", Offset = "0x71B93A0", VA = "0x1871BA5A0")]
		[FFHMIBPHFPB]
		private void RpcConnectNodes(LNAPBGCAIIL IDOCGCDLFAJ, int KDOLCBKLHME, LNAPBGCAIIL NECCGCDBJPF, int GABIDFJGIGM, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID, PCFKAIEJBBD LLLMGCLAHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x71BA720", Offset = "0x71B9520", VA = "0x1871BA720")]
		[FFHMIBPHFPB]
		private void RpcDisconnectNode(LNAPBGCAIIL EBOADEHKBKF, PCFKAIEJBBD LLLMGCLAHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x71BB100", Offset = "0x71B9F00", VA = "0x1871BB100")]
		[FFHMIBPHFPB]
		private void RpcReparentNodes(LNAPBGCAIIL OILBIEHFDJG, int MDJELHAMOHJ, LNAPBGCAIIL LBOOKOKCBHL, int CIKBMGDKHEJ, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID, PCFKAIEJBBD LLLMGCLAHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x71BB040", Offset = "0x71B9E40", VA = "0x1871BB040")]
		[FFHMIBPHFPB]
		private void RpcModifyNode(LNAPBGCAIIL JCAKCOJJFCM, int KDOLCBKLHME, int GABIDFJGIGM, Vector3 NLEOEIHBFKL, Quaternion FJCGMNKEFID, PCFKAIEJBBD LLLMGCLAHCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x71BA6E0", Offset = "0x71B94E0", VA = "0x1871BA6E0")]
		[FFHMIBPHFPB]
		private void RpcDeserializeConnectableGraph(OLCIGFHLLEM LIPFFAIMLKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x912AB0", Offset = "0x9118B0", VA = "0x180912AB0")]
		public LegacyConnectableNetworking()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class LegacyConnectableLinkVisual : MonoBehaviour, FBCDKBKIGNB, DKPDMABDAHO.JPJJFDLJDCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private LineRenderer lineRenderer;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x71B9CD0", Offset = "0x71B8AD0", VA = "0x1871B9CD0", Slot = "4")]
		private void KLDJOPKJFFE(LNAPBGCAIIL NECCGCDBJPF, DFDMHJNGKOI DOOFGBAMPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x71B9560", Offset = "0x71B8360", VA = "0x1871B9560", Slot = "5")]
		private void AAGGDKLKOHO(LNAPBGCAIIL NECCGCDBJPF, DFDMHJNGKOI DOOFGBAMPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x71B9A40", Offset = "0x71B8840", VA = "0x1871B9A40", Slot = "6")]
		private void FNOPFCODING(LNAPBGCAIIL NECCGCDBJPF, DFDMHJNGKOI DOOFGBAMPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x71B97E0", Offset = "0x71B85E0", VA = "0x1871B97E0", Slot = "7")]
		private void APBBDODCAHA(LNAPBGCAIIL NECCGCDBJPF, DFDMHJNGKOI DOOFGBAMPBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x71B99D0", Offset = "0x71B87D0", VA = "0x1871B99D0", Slot = "8")]
		private FBCDKBKIGNB CJBKFFHFEBM(Transform KAEMFHJNGPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x71B9C70", Offset = "0x71B8A70", VA = "0x1871B9C70", Slot = "9")]
		private void IEIAJLPDDNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
		public LegacyConnectableLinkVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class OMOEAMGKGIK
{
	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3495CC0", Offset = "0x3494AC0", VA = "0x183495CC0")]
	public static FMBAOGDPJMN<T> HHGDKGOINKB<T>(this IEPIHLKICIO BCNFHKMHIOK)
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
