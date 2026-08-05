using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using Photon.Pun;
using RecRoom;
using RecRoom.Utils.OverridableFields;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class HLOBGGLGDAA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public const string DFJOKHOGNFF = "RBEX_DEFAULT";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const float OEMENDBLINC = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const float DGNIBDHFCFN = 0f;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const float PDDNBGOAKOA = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public HLOBGGLGDAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void EDIBFGHGGCA(RigidbodyEx DCOJFFFIMPL);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void ACIELCLFAEN(RigidbodyEx DCOJFFFIMPL, bool IFGMNFNELBJ = false);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DECKJPMKMOF
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BJBMJALPHDL
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum KNHPIJHAJOD
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MMDAJOCGCAI : PHNOFPCAHIJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MCDKPACJJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6E4780", Offset = "0x6E3B80", VA = "0x1806E4780", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FHBFAPMHJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B9670", Offset = "0x7B8A70", VA = "0x1807B9670", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "6")]
	public MGNDJKECDKI OCKDIIHIKMO(float ACNMABPOPNI)
	{
		return default(MGNDJKECDKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
	public void BKCAAEBNAMB(KBOBIGJEJBE JGHFLANLLNE, float COJCFIHHPEL, PBCNLFIKHBJ HFEDMGOCEAE = PBCNLFIKHBJ.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "8")]
	public void BKCAAEBNAMB(KBOBIGJEJBE JGHFLANLLNE, Transform LIMOOMKJBJJ, float COJCFIHHPEL, PBCNLFIKHBJ HFEDMGOCEAE = PBCNLFIKHBJ.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "9")]
	public void AMDCHGLDEGN(KBOBIGJEJBE JGHFLANLLNE, [Optional] float? COJCFIHHPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "10")]
	public void GAMANBAONBG(KBOBIGJEJBE COMMLBIKDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "11")]
	public MGNDJKECDKI MAOKNIDBPAB(KBOBIGJEJBE JGHFLANLLNE)
	{
		return default(MGNDJKECDKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x798260", Offset = "0x797660", VA = "0x180798260", Slot = "12")]
	public bool OMGDELIKMGI(KBOBIGJEJBE JGHFLANLLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "13")]
	public void FEAAHCFMCPJ(KBOBIGJEJBE JGHFLANLLNE, PBCNLFIKHBJ EJCAELBKKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public MMDAJOCGCAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AOJPGBJKDNL(typeof(HANJHOFAIIG), new string[] { "Ignore", "Mock" })]
public class NOHOJICLHBK : HANJHOFAIIG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AGHHEIGJJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x826290", Offset = "0x825690", VA = "0x180826290", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
	public void GGPDJFPKDNK(string MCGMECECHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "6")]
	public void PHMKDEPLADH(RigidbodyEx ANLOJMEANJA, Action EFFJGLADCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "7")]
	public PHNOFPCAHIJ AOOKGCFEGKB(int CPJFGFFPAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "8")]
	public void MOAMMOCEKDL(Vector3 EGIBEGOGBHF, float JHLNCECPADL, Color EELAMBEFNPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NOHOJICLHBK()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool FGGBDCIABAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private ILPKGDCLANM FFOFGJKMODA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[PODIOEAPHLB(HLAHMBHIFJM.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[PODIOEAPHLB(HLAHMBHIFJM.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private BJBMJALPHDL physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[HideInInspector]
		[SerializeField]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		internal ILPKGDCLANM LAFDJCIIPKH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x64B7760", Offset = "0x64B6B60", VA = "0x1864B7760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<RigidbodyEx> MKGCJNINDKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x845B30", Offset = "0x844F30", VA = "0x180845B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7CE8C0", Offset = "0x7CDCC0", VA = "0x1807CE8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx IHPOMLANOPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x64B98B0", Offset = "0x64B8CB0", VA = "0x1864B98B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx COIMCDBNODG
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x64B9850", Offset = "0x64B8C50", VA = "0x1864B9850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RigidbodyEx CNDFBGEJOLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x64BA410", Offset = "0x64B9810", VA = "0x1864BA410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x64BBB60", Offset = "0x64BAF60", VA = "0x1864BBB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform LLDFEFLPEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xFB5590", Offset = "0xFB4990", VA = "0x180FB5590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform PLHBFGAGLJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xFB5590", Offset = "0xFB4990", VA = "0x180FB5590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public PBCNLFIKHBJ KDPBDNOOOJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x64B9540", Offset = "0x64B8940", VA = "0x1864B9540")]
			get
			{
				return default(PBCNLFIKHBJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x64BB100", Offset = "0x64BA500", VA = "0x1864BB100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool CGHGEFKIEKD
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x64B9AC0", Offset = "0x64B8EC0", VA = "0x1864B9AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool JPNKMIMLPNM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x64B96D0", Offset = "0x64B8AD0", VA = "0x1864B96D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public EBGEGLGLHEI BMELAMIAMGC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x64B9A60", Offset = "0x64B8E60", VA = "0x1864B9A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x64BB310", Offset = "0x64BA710", VA = "0x1864BB310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public INKGBOPGLAH ANJHOFGNHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x64B9A00", Offset = "0x64B8E00", VA = "0x1864B9A00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x64BB2A0", Offset = "0x64BA6A0", VA = "0x1864BB2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OPOGDDHDOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x64B98E0", Offset = "0x64B8CE0", VA = "0x1864B98E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Rigidbody AHDPHMEMOJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x64B9940", Offset = "0x64B8D40", VA = "0x1864B9940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool KALNOEALNHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x64B9790", Offset = "0x64B8B90", VA = "0x1864B9790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x64BB1C0", Offset = "0x64BA5C0", VA = "0x1864BB1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PDPFOKCKDAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x239A670", Offset = "0x2399A70", VA = "0x18239A670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2399A50", Offset = "0x2398E50", VA = "0x182399A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float CDPAONMBAJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x64BA3B0", Offset = "0x64B97B0", VA = "0x1864BA3B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float IBIBANLMLNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x64BA350", Offset = "0x64B9750", VA = "0x1864BA350")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x64BBAF0", Offset = "0x64BAEF0", VA = "0x1864BBAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float HEMOAGALFFP
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x64B9D20", Offset = "0x64B9120", VA = "0x1864B9D20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x64BB5B0", Offset = "0x64BA9B0", VA = "0x1864BB5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float PGKLJIMOLEL
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x64B9B20", Offset = "0x64B8F20", VA = "0x1864B9B20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x64BB380", Offset = "0x64BA780", VA = "0x1864BB380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool CMHLOPHGHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x64BA930", Offset = "0x64B9D30", VA = "0x1864BA930")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x64BC0A0", Offset = "0x64BB4A0", VA = "0x1864BC0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DBBHDGCNJCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x64BA130", Offset = "0x64B9530", VA = "0x1864BA130")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x64BB8C0", Offset = "0x64BACC0", VA = "0x1864BB8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 EGIBEGOGBHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x64BAA70", Offset = "0x64B9E70", VA = "0x1864BAA70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public CollisionDetectionMode FAAIIKCDIED
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x64B9C60", Offset = "0x64B9060", VA = "0x1864B9C60")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x64BB4D0", Offset = "0x64BA8D0", VA = "0x1864BB4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float DBEIDHEFFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x64B97F0", Offset = "0x64B8BF0", VA = "0x1864B97F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x64BB230", Offset = "0x64BA630", VA = "0x1864BB230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public RigidbodyConstraints FPIDJKEBJEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x64B9CC0", Offset = "0x64B90C0", VA = "0x1864B9CC0")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x64BB540", Offset = "0x64BA940", VA = "0x1864BB540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 BEDIICGMFIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x64BA470", Offset = "0x64B9870", VA = "0x1864BA470")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 NGIALGNKIDA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x64BA470", Offset = "0x64B9870", VA = "0x1864BA470")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x64BBE70", Offset = "0x64BB270", VA = "0x1864BBE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float DCLBFJLNLME
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x64BA210", Offset = "0x64B9610", VA = "0x1864BA210")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x64BB9A0", Offset = "0x64BADA0", VA = "0x1864BB9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float HGHMGIPKCAO
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x64BA8D0", Offset = "0x64B9CD0", VA = "0x1864BA8D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x64BC030", Offset = "0x64BB430", VA = "0x1864BC030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion LBPADAHLHDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x64BA550", Offset = "0x64B9950", VA = "0x1864BA550")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x64BBBD0", Offset = "0x64BAFD0", VA = "0x1864BBBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion JPINCEONOBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x64BA7F0", Offset = "0x64B9BF0", VA = "0x1864BA7F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x64BBF50", Offset = "0x64BB350", VA = "0x1864BBF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 ODEDGJACBHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x64BA630", Offset = "0x64B9A30", VA = "0x1864BA630")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x64BBCB0", Offset = "0x64BB0B0", VA = "0x1864BBCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Quaternion ENDEEMNIFGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x64BA710", Offset = "0x64B9B10", VA = "0x1864BA710")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x64BBD90", Offset = "0x64BB190", VA = "0x1864BBD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 LCOAJKBMAJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x64BA990", Offset = "0x64B9D90", VA = "0x1864BA990")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x64BC110", Offset = "0x64BB510", VA = "0x1864BC110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 HJHGPEHMJHF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x64BA270", Offset = "0x64B9670", VA = "0x1864BA270")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x64BBA10", Offset = "0x64BAE10", VA = "0x1864BBA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 FAJPHALHEOE
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x64B9B80", Offset = "0x64B8F80", VA = "0x1864B9B80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x64BB3F0", Offset = "0x64BA7F0", VA = "0x1864BB3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 HFPOKJMMMMK
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x64BA050", Offset = "0x64B9450", VA = "0x1864BA050")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x64BB7E0", Offset = "0x64BABE0", VA = "0x1864BB7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 JCICHJCCDHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x64B9F10", Offset = "0x64B9310", VA = "0x1864B9F10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x64BB700", Offset = "0x64BAB00", VA = "0x1864BB700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Quaternion JEKGPCGHMDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x64B9E30", Offset = "0x64B9230", VA = "0x1864B9E30")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x64BB620", Offset = "0x64BAA20", VA = "0x1864BB620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 BFDCFPFIOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x64BAC30", Offset = "0x64BA030", VA = "0x1864BAC30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 GABDCOCADDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x64BAB50", Offset = "0x64B9F50", VA = "0x1864BAB50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool OJFDJHJECDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x64B9FF0", Offset = "0x64B93F0", VA = "0x1864B9FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool ENBBKGECCLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x64B9730", Offset = "0x64B8B30", VA = "0x1864B9730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool NPFHJJBDFMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x64B9670", Offset = "0x64B8A70", VA = "0x1864B9670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool PNPHIGEIMIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x64B9610", Offset = "0x64B8A10", VA = "0x1864B9610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool INGLGNBAOLO
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x64B94E0", Offset = "0x64B88E0", VA = "0x1864B94E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool PNGBLEMFBOD
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x64B9D80", Offset = "0x64B9180", VA = "0x1864B9D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool BFCALEBFFJP
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x757BE0", Offset = "0x756FE0", VA = "0x180757BE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event EDIBFGHGGCA KEGHIBHONJN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x64B9400", Offset = "0x64B8800", VA = "0x1864B9400")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x64BB020", Offset = "0x64BA420", VA = "0x1864BB020")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event ACIELCLFAEN DADIHLHBAKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x64B9390", Offset = "0x64B8790", VA = "0x1864B9390")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x64BAFB0", Offset = "0x64BA3B0", VA = "0x1864BAFB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event EDIBFGHGGCA LCINONPFDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x64B90F0", Offset = "0x64B84F0", VA = "0x1864B90F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x64BAD10", Offset = "0x64BA110", VA = "0x1864BAD10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event EDIBFGHGGCA AEIOOPKGCAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x64B9160", Offset = "0x64B8560", VA = "0x1864B9160")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x64BAD80", Offset = "0x64BA180", VA = "0x1864BAD80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event EDIBFGHGGCA MLANLPOEPNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x64B92B0", Offset = "0x64B86B0", VA = "0x1864B92B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x64BAED0", Offset = "0x64BA2D0", VA = "0x1864BAED0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<MGNDJKECDKI, MGNDJKECDKI> AKEAABLCGJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x64B9240", Offset = "0x64B8640", VA = "0x1864B9240")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x64BAE60", Offset = "0x64BA260", VA = "0x1864BAE60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event EDIBFGHGGCA OEIOPFFENBB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x64B9320", Offset = "0x64B8720", VA = "0x1864B9320")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x64BAF40", Offset = "0x64BA340", VA = "0x1864BAF40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event EDIBFGHGGCA CABIIHJECBH
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x64B9470", Offset = "0x64B8870", VA = "0x1864B9470")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x64BB090", Offset = "0x64BA490", VA = "0x1864BB090")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event EDIBFGHGGCA EALFLPLHJKO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x64B91D0", Offset = "0x64B85D0", VA = "0x1864B91D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x64BADF0", Offset = "0x64BA1F0", VA = "0x1864BADF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x762090", VA = "0x180762C90")]
		internal void EIFENMGIFFC(ILPKGDCLANM OOJCPNBFJMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x64B7870", Offset = "0x64B6C70", VA = "0x1864B7870")]
		internal void CIGDAFODPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x64B8E40", Offset = "0x64B8240", VA = "0x1864B8E40")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody EKIGIINNFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x64B76F0", Offset = "0x64B6AF0", VA = "0x1864B76F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x64B7760", Offset = "0x64B6B60", VA = "0x1864B7760")]
		private ILPKGDCLANM HMAJJILADAN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x64B7D40", Offset = "0x64B7140", VA = "0x1864B7D40")]
		private void HCLJCDJPJCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x64B8380", Offset = "0x64B7780", VA = "0x1864B8380")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x64B8310", Offset = "0x64B7710", VA = "0x1864B8310")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x64B7AE0", Offset = "0x64B6EE0", VA = "0x1864B7AE0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x64B8320", Offset = "0x64B7720", VA = "0x1864B8320")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x64B83E0", Offset = "0x64B77E0", VA = "0x1864B83E0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x64B6D80", Offset = "0x64B6180", VA = "0x1864B6D80")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x64B8450", Offset = "0x64B7850", VA = "0x1864B8450")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x64B7A80", Offset = "0x64B6E80", VA = "0x1864B7A80")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x64B82B0", Offset = "0x64B76B0", VA = "0x1864B82B0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x64B8C40", Offset = "0x64B8040", VA = "0x1864B8C40")]
		public void SetParent(RigidbodyEx FPLJCBGEJAP, bool IFGMNFNELBJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x64B8760", Offset = "0x64B7B60", VA = "0x1864B8760")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x64B80D0", Offset = "0x64B74D0", VA = "0x1864B80D0")]
		public bool IsRigidbodyAncestor(RigidbodyEx AMGMMOMIJNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x64B8110", Offset = "0x64B7510", VA = "0x1864B8110")]
		public bool IsRigidbodyDescendant(RigidbodyEx BOIHIMFEHKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x64B6FA0", Offset = "0x64B63A0", VA = "0x1864B6FA0")]
		public void AddInterpolationRestriction(object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x64B84C0", Offset = "0x64B78C0", VA = "0x1864B84C0")]
		public void RemoveInterpolationRestriction(object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x64B7810", Offset = "0x64B6C10", VA = "0x1864B7810")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x64B7010", Offset = "0x64B6410", VA = "0x1864B7010")]
		public void AddKinematic(object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x64B8530", Offset = "0x64B7930", VA = "0x1864B8530")]
		public void RemoveKinematic(object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x64B8BC0", Offset = "0x64B7FC0", VA = "0x1864B8BC0")]
		public void SetKinematic(object JCHAGIDHJIB, bool IJHPBMOOGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x64B8AC0", Offset = "0x64B7EC0", VA = "0x1864B8AC0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 GDMOLPCGLJL, Quaternion NGMHNDELPAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x64B89C0", Offset = "0x64B7DC0", VA = "0x1864B89C0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 EKAJOFOCODC, Quaternion MNLPDACKEJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x64B7C40", Offset = "0x64B7040", VA = "0x1864B7C40")]
		public Vector3 GetConstrainedVelocity(Vector3 LCOAJKBMAJL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x64B7B40", Offset = "0x64B6F40", VA = "0x1864B7B40")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 FAJPHALHEOE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x64B6F10", Offset = "0x64B6310", VA = "0x1864B6F10")]
		public void AddForce(Vector3 MGJBBFOJNFN, ForceMode ACLPJPMEMPD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x64B6DF0", Offset = "0x64B61F0", VA = "0x1864B6DF0")]
		public void AddForceAtPosition(Vector3 MGJBBFOJNFN, Vector3 KGJPEGOHADA, ForceMode ACLPJPMEMPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x64B7110", Offset = "0x64B6510", VA = "0x1864B7110")]
		public void AddTorque(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x64B7080", Offset = "0x64B6480", VA = "0x1864B7080")]
		public void AddRelativeTorque(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x64B8F20", Offset = "0x64B8320", VA = "0x1864B8F20")]
		public Vector3 WorldToLocalVelocity(Vector3 GAGJBCNBONM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x64B81B0", Offset = "0x64B75B0", VA = "0x1864B81B0")]
		public Vector3 LocalToWorldVelocity(Vector3 HJHGPEHMJHF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x64B7A20", Offset = "0x64B6E20", VA = "0x1864B7A20")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x64B79C0", Offset = "0x64B6DC0", VA = "0x1864B79C0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x64B7960", Offset = "0x64B6D60", VA = "0x1864B7960")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x64B7900", Offset = "0x64B6D00", VA = "0x1864B7900")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x64B88C0", Offset = "0x64B7CC0", VA = "0x1864B88C0")]
		public void ResetVelocityWorldSpace(Vector3 JGLKMMBAANF, Vector3 CGGAGNJAJMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x64B87C0", Offset = "0x64B7BC0", VA = "0x1864B87C0")]
		public void ResetVelocityLocalSpace(Vector3 JHIGCONLFIL, Vector3 HFPOKJMMMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x64B8680", Offset = "0x64B7A80", VA = "0x1864B8680")]
		public void ResetLinearVelocityLocalSpace(Vector3 JHIGCONLFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x64B8D30", Offset = "0x64B8130", VA = "0x1864B8D30")]
		public bool SweepTest(Vector3 GPCLDFNJCPC, out RaycastHit CLAJPNPLGKF, float DODLNOOJAAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x64B8150", Offset = "0x64B7550", VA = "0x1864B8150")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x64B8CD0", Offset = "0x64B80D0", VA = "0x1864B8CD0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x64B8EC0", Offset = "0x64B82C0", VA = "0x1864B8EC0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x64B71A0", Offset = "0x64B65A0", VA = "0x1864B71A0")]
		public void AddUnityRigidbody(object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x64B85A0", Offset = "0x64B79A0", VA = "0x1864B85A0")]
		public void RemoveUnityRigidbody(object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x64B74C0", Offset = "0x64B68C0", VA = "0x1864B74C0")]
		public void ApplyForceVelocityChange(DECKJPMKMOF PBPIIFNFGMJ, Vector3 KPDDBGLPIPH, float JFKBEMOFNCC, float JDPJMACMKOO = 8f, float BGOCILFMLAJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x64B73C0", Offset = "0x64B67C0", VA = "0x1864B73C0")]
		public void ApplyAngularVelocityChange(KNHPIJHAJOD PBGBCGCEMBN, Vector3 AFDDLCHPJJF, float NPLCIBKJLLM = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x64B75E0", Offset = "0x64B69E0", VA = "0x1864B75E0")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(KNHPIJHAJOD PBGBCGCEMBN, Vector3 GCFIGFMOIAL, float FJKGBGGIOMN = 7f, float CIHKPDDBHIH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x64B7300", Offset = "0x64B6700", VA = "0x1864B7300")]
		public bool AllowedScaleChange(float PAGNPNMCLDG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x64B7210", Offset = "0x64B6610", VA = "0x1864B7210")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx OOOHDEPMGEH, object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x64B8610", Offset = "0x64B7A10", VA = "0x1864B8610")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object JCHAGIDHJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x64B9070", Offset = "0x64B8470", VA = "0x1864B9070")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class JNPIBMLIBFM
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x576C790", Offset = "0x576BB90", VA = "0x18576C790")]
	public static ILPKGDCLANM LAFDJCIIPKH(this RigidbodyEx ANLOJMEANJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct AJCCCMFGALH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody BBOHKHOPNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView MGBGBEHJPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 JKJKCACHMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 PFMGHEAKHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public BJBMJALPHDL NGANBKDNDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool DAHNEJOMJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool KCGJACAPNGO;
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	[AOJPGBJKDNL(typeof(OJKFOMAKLHL), new string[] { })]
	public class RigidbodyExManager : OJKFOMAKLHL, NGENPNOGFON
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private APLFFAOJOGK CGENOKFJBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private HANJHOFAIIG CMMLIBKHPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private LEOOJPIMKPF GFCOCLEJPKI;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool GNKIPPJGIOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x64B6C50", Offset = "0x64B6050", VA = "0x1864B6C50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public HANJHOFAIIG PBGLAENKPGC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public LEOOJPIMKPF FGFNBFDFJLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x64B6CA0", Offset = "0x64B60A0", VA = "0x1864B6CA0", Slot = "12")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x64B6780", Offset = "0x64B5B80", VA = "0x1864B6780", Slot = "7")]
		public KJNCFICFIIE JECPDBMMNIE(RigidbodyEx ANLOJMEANJA)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x64B6470", Offset = "0x64B5870", VA = "0x1864B6470")]
		private static KJNCFICFIIE CKLGOICBHBD(RigidbodyEx ANLOJMEANJA)
		{
			return default(KJNCFICFIIE);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x64B6B40", Offset = "0x64B5F40", VA = "0x1864B6B40", Slot = "8")]
		public ILPKGDCLANM KJPIJLPLBGM(RigidbodyEx ANLOJMEANJA, AJCCCMFGALH MPEBBGJJODN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x64B66B0", Offset = "0x64B5AB0", VA = "0x1864B66B0", Slot = "11")]
		private RigidbodyEx FDJBJCOANCD(GameObject EBOMDGJFPAB, AJCCCMFGALH MPEBBGJJODN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x64B6A50", Offset = "0x64B5E50", VA = "0x1864B6A50", Slot = "9")]
		public void KCDNBAPEHOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x64B6560", Offset = "0x64B5960", VA = "0x1864B6560", Slot = "10")]
		public void EBFJCJMEBKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public RigidbodyExManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static EKMBIMLBDEI UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int PFHBDOPCCLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int NLGDOAKFNIH;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x64B5F50", Offset = "0x64B5350", VA = "0x1864B5F50")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x64B5F90", Offset = "0x64B5390", VA = "0x1864B5F90")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x64B5F70", Offset = "0x64B5370", VA = "0x1864B5F70")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string CIBBLLOHCGM, [Optional] UnityEngine.Object OEGBAMNPENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string CIBBLLOHCGM, [Optional] UnityEngine.Object OEGBAMNPENI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x64B6080", Offset = "0x64B5480", VA = "0x1864B6080")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IMAAOKHIHNA
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x57649D0", Offset = "0x5763DD0", VA = "0x1857649D0")]
	public static void KDNFOBIJKKD(this Rigidbody EKIGIINNFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5764B20", Offset = "0x5763F20", VA = "0x185764B20")]
	public static void KDNFOBIJKKD(this Rigidbody EKIGIINNFEP, Vector3 JCICHJCCDHH, Quaternion JEKGPCGHMDD, Vector3 MBPENBBAAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5764900", Offset = "0x5763D00", VA = "0x185764900")]
	public static void HIBGNJACGIF(Vector3 LCOAJKBMAJL, Vector3 FGGPFFJEFOG, out Vector3 KMBIDHIPLHL, out Vector3 GCECBKIBMOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class OOOLPCDCION
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class KMOCNBGEAMK : EBGEGLGLHEI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1D3CD80", Offset = "0x1D3C180", VA = "0x181D3CD80", Slot = "4")]
		public Vector3 FMKJIMPKBEN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D3CD80", Offset = "0x1D3C180", VA = "0x181D3CD80", Slot = "5")]
		public Vector3 MEIMIOALBOA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public KMOCNBGEAMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static EBGEGLGLHEI OFMNKNCAMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x64B4F40", Offset = "0x64B4340", VA = "0x1864B4F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BHPPDHHNLNA
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode IAMKOICFOLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIJACFILAPJ();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OLKKMPKLMOH(bool OJFDJHJECDC);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NHNABIMKNII(bool OJFDJHJECDC);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GKLGDFBHMGO(Vector3 GPCLDFNJCPC, out RaycastHit CLAJPNPLGKF, float DODLNOOJAAB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OJLHAIBOJPN : IDisposable, KBOBIGJEJBE
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CJAGCCPNBHO KDPBDNOOOJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<MGNDJKECDKI, MGNDJKECDKI> AKEAABLCGJL;

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MIJACFILAPJ();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[PHECHDJFGDG(FPOGPJMGMEG.Application)]
public interface LEOOJPIMKPF
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ADOGOEHBGDB AAIELKNPPKB(ILPKGDCLANM OOJCPNBFJMK);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CFCPCALGPCF LHIONECBHJJ(ILPKGDCLANM OOJCPNBFJMK);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CIIPJDJKCCC BAOIHDCCDIH(ILPKGDCLANM OOJCPNBFJMK);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NHKIFEBOFCL MBIDMBEKDDD(ILPKGDCLANM OOJCPNBFJMK);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KOMDCHOGFGK HMBJBMIALGL(ILPKGDCLANM OOJCPNBFJMK);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OJLHAIBOJPN HMIMPAILINC(ILPKGDCLANM OOJCPNBFJMK);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MCFFBCKBDAO LOFBBHEMFPA(ILPKGDCLANM OOJCPNBFJMK);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IBBIOIIEBJO AAGLGOEMMIF(ILPKGDCLANM OOJCPNBFJMK);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BHPPDHHNLNA IBGFDICMLHJ(ILPKGDCLANM OOJCPNBFJMK);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	OAAAINOINDE DMKJDDCFKFA(ILPKGDCLANM OOJCPNBFJMK);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NOKJHKJHDMG IGAMCAFAOGF(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EGCPDEMCLIG IKEEEHBMMCL(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ADFLIEJPGFD DBGOAOBHJAP(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN);

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JIEGAMCNMJJ PMEEKEEKDHM(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CBOKBEGMIKO KHDHIBGGPLP(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ILPKGDCLANM KJPIJLPLBGM(RigidbodyEx ANLOJMEANJA, AJCCCMFGALH MPEBBGJJODN, OJKFOMAKLHL NBEGMMIIDMD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IBBIOIIEBJO
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBDPMHJLAOJ(Vector3 MGJBBFOJNFN, ForceMode ACLPJPMEMPD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEGGFDIPJGD(Vector3 MGJBBFOJNFN, Vector3 KGJPEGOHADA, ForceMode ACLPJPMEMPD);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NHPOGNDMGCD(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OOHCEIMBKPD(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface OAAAINOINDE
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool IEHOHDHFOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ADOGOEHBGDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<ILPKGDCLANM> MKGCJNINDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	ILPKGDCLANM COIMCDBNODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	ILPKGDCLANM DOOCCGCNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event EDIBFGHGGCA LCINONPFDFJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event EDIBFGHGGCA AEIOOPKGCAD;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event ACIELCLFAEN GLHDOLCKNJG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action LCDAKJJPPHI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action PIEPJLKMPBM;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<ILPKGDCLANM> EMGAIKGILMC;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<ILPKGDCLANM> DBHPMCGPIKO;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action BDCLBCCHGLO;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<ILPKGDCLANM> MMMCLOIFIMM;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NPKNFKDMNIH(ILPKGDCLANM HKBAAFCKIFC, bool IFGMNFNELBJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CIIPJDJKCCC
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 NADFFGFBCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 FCAFMICJDPP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLCFANBFIPP(ILPKGDCLANM CNDFBGEJOLI, object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BJEODEMDDGM(object JCHAGIDHJIB);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface JIEGAMCNMJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 NBHBELAIBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 NEBCIADIING
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float DGNOOEIGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float HEPAGCBLJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 LMJCLPIBEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion GKPDPMCDGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event EDIBFGHGGCA HEGPDCDAOAI;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JFGCPDOODIN();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FIDFLJGKPNB();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LJINPIHKMGE();

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MLNJLBLGJPE();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ADFLIEJPGFD
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool GGCHCLPEMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	HIHNKPGEDDE NOJLEBJKKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIJACFILAPJ();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GFMOKLHHCDB(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MGCLAOAADOC(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PIKIAPJONJN(ILPKGDCLANM ANLOJMEANJA);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NFPKFACOBKP(ILPKGDCLANM ANLOJMEANJA);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IFNGLGFDCFP();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface MCFFBCKBDAO
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool NNGCGJNPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	IEnumerable<object> GJGGGEBIAIA
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event EDIBFGHGGCA JFCBDEPNNFP;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PMNFOIDFING(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IJEHIOABNMP(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KKMLFIEGHLB(object JCHAGIDHJIB, bool IJHPBMOOGIC);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable PAAMLEOMHIM();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AOAIBKKGCDK(Rigidbody DFDJIBDBDBK);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface EGCPDEMCLIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool CGHGEFKIEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool JPNKMIMLPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event EDIBFGHGGCA ADNHDJAIKIN;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MIJACFILAPJ();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CIGLGJDDJMB(ILPKGDCLANM CNDFBGEJOLI);

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HGGPHOKEFDD(ILPKGDCLANM CNDFBGEJOLI);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface CBOKBEGMIKO
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool KALNOEALNHD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool OMLANDBOKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	RigidbodyConstraints BLKADDBBOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NHKIFEBOFCL
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float PPGDDPLBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float KMCPMIOLLOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BBGKFCJIKGG
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx NCBLIFAIKLK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KOMDCHOGFGK
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event EDIBFGHGGCA KPKPOEOAKMF;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MIJACFILAPJ();

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NACOMAKPFBJ();

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KKIECAKDELN();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KENKHKBKEMD();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AIADGDGDDLM();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HIDPENPEHKH();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PEMMOGJEFHM(bool IADBGGBPGCE);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface NOKJHKJHDMG
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Rigidbody AHDPHMEMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MIJACFILAPJ();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HDOOPNPHDOG(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ODNLFMCNIMM(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KEOPHCFHNBD();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IANPFGAPGHM();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EBMMJMCNPHK();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LCNBPFHHODO();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface CFCPCALGPCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	EBGEGLGLHEI BMELAMIAMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	INKGBOPGLAH ANJHOFGNHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 OCAOFDKLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 DECNMOIHGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	Vector3 ADAGFBPLONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Vector3 NOKDFHICMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float DBEIDHEFFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool OPOGDDHDOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MIJACFILAPJ();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ENGBBGGKKNM(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CLFDNPJGLDL(KNHPIJHAJOD PBGBCGCEMBN, Vector3 AFDDLCHPJJF, float NPLCIBKJLLM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void CEJGEKHJMLG(DECKJPMKMOF PBPIIFNFGMJ, Vector3 KPDDBGLPIPH, float JFKBEMOFNCC, float JDPJMACMKOO = 8f, float BGOCILFMLAJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LDOJANPFHBD(KNHPIJHAJOD PBGBCGCEMBN, Vector3 GCFIGFMOIAL, float FJKGBGGIOMN = 7f, float CIHKPDDBHIH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MKACKJBHFEF();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HKHMPMLAFOA();

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MDCDACBDOBA();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void DPEFKKCHLHN();

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 KGFENKABDKJ(Vector3 FAJPHALHEOE);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 CNDCONBFANC(Vector3 LCOAJKBMAJL);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void BIHLENLICGJ(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CKNMFLEDJLC(Vector3 DKCFLDFLDGI);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DHMMJCMENIL(Vector3 JHIGCONLFIL, Vector3 HFPOKJMMMMK);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void DAHIGAIEIHL(Vector3 JGLKMMBAANF, Vector3 CGGAGNJAJMN);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 BMFAGCHKKGB(Vector3 HJHGPEHMJHF);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 NFEHGJFPFGI(Vector3 GAGJBCNBONM);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[PHECHDJFGDG(FPOGPJMGMEG.Application)]
public interface HANJHOFAIIG
{
	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool AGHHEIGJJBF
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGPDJFPKDNK(string MCGMECECHJK);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PHMKDEPLADH(RigidbodyEx ANLOJMEANJA, Action EFFJGLADCMH);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PHNOFPCAHIJ AOOKGCFEGKB(int CPJFGFFPAGG);

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MOAMMOCEKDL(Vector3 EGIBEGOGBHF, float JHLNCECPADL, Color EELAMBEFNPK);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[PHECHDJFGDG(FPOGPJMGMEG.Application)]
public interface OJKFOMAKLHL
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	HANJHOFAIIG PBGLAENKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	LEOOJPIMKPF FGFNBFDFJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	bool GNKIPPJGIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KJNCFICFIIE JECPDBMMNIE(RigidbodyEx ANLOJMEANJA);

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ILPKGDCLANM KJPIJLPLBGM(RigidbodyEx ANLOJMEANJA, AJCCCMFGALH MPEBBGJJODN);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KCDNBAPEHOJ();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EBFJCJMEBKG();

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx EAECNANLFGO(GameObject EBOMDGJFPAB, [Optional] AJCCCMFGALH MPEBBGJJODN);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface INKGBOPGLAH
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JNIGHLNKKIB(Vector3 FODCNAMDAPN);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBBALBPNJAI(Vector3 FAJPHALHEOE);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DLHEOIEBPEB(Vector3 FODCNAMDAPN);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FKAEDCJLKFP(Vector3 FAJPHALHEOE);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EBGEGLGLHEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 FMKJIMPKBEN();

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 MEIMIOALBOA();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface ILPKGDCLANM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	Rigidbody AHDPHMEMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	RigidbodyEx BHGLFKBHMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	GameObject BNDGKEGJNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	Transform KJAFIIABLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	IEnumerable<object> PJIOBNNHBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	ILPKGDCLANM DOOCCGCNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	IReadOnlyList<ILPKGDCLANM> MKGCJNINDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	ILPKGDCLANM COIMCDBNODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	bool CFLBJAOIJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	bool CGHGEFKIEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool JPNKMIMLPNM
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	EBGEGLGLHEI BMELAMIAMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	INKGBOPGLAH ANJHOFGNHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	float DBEIDHEFFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 DECNMOIHGHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 NOKDFHICMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 OCAOFDKLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 ADAGFBPLONM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool NPFHJJBDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool PNPHIGEIMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	bool INGLGNBAOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool OPOGDDHDOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Vector3 NADFFGFBCFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 FCAFMICJDPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 NBHBELAIBDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	Vector3 NEBCIADIING
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float DGNOOEIGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	float HEPAGCBLJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 LMJCLPIBEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	Quaternion GKPDPMCDGGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float PPGDDPLBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	float KMCPMIOLLOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	bool IEHOHDHFOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "47")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	CJAGCCPNBHO KDPBDNOOOJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool NNGCGJNPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	Transform LLDFEFLPEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	Transform PLHBFGAGLJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	Vector3 GABFGMFOOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "54")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	float NFPKDNBCCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "56")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	float EDFAOBJKHJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "58")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	Quaternion JLHJOCIFNIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "60")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	Vector3 MHKILGKADHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "62")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	Quaternion MIIEKLEEEMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "63")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "64")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	RigidbodyConstraints BLKADDBBOFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "65")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "66")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	bool KALNOEALNHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "68")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	CollisionDetectionMode IAMKOICFOLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "69")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "70")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool ENBBKGECCLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "71")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event EDIBFGHGGCA LCINONPFDFJ;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event EDIBFGHGGCA AEIOOPKGCAD;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event ACIELCLFAEN GLHDOLCKNJG;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event EDIBFGHGGCA ADNHDJAIKIN;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event EDIBFGHGGCA MLANLPOEPNP;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event EDIBFGHGGCA KPKPOEOAKMF;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<MGNDJKECDKI, MGNDJKECDKI> AKEAABLCGJL;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event EDIBFGHGGCA DIDLCNJHPFN;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event EDIBFGHGGCA EALFLPLHJKO;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void MIJACFILAPJ();

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void NLGOPKLJAKB();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void BLFLGDGOFJA();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void KENKHKBKEMD();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void IBNFJMIBNMN();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void NPKNFKDMNIH(ILPKGDCLANM FPLJCBGEJAP, bool IFGMNFNELBJ = false);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void DCDDGAENFBD(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void IJHDNPOHOGP(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "88")]
	Vector3 NFEHGJFPFGI(Vector3 GAGJBCNBONM);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "89")]
	Vector3 BMFAGCHKKGB(Vector3 HJHGPEHMJHF);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void DPEFKKCHLHN();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void HKHMPMLAFOA();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void MKACKJBHFEF();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void DAHIGAIEIHL(Vector3 JGLKMMBAANF, Vector3 CGGAGNJAJMN);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void DHMMJCMENIL(Vector3 JHIGCONLFIL, Vector3 HFPOKJMMMMK);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void CKNMFLEDJLC(Vector3 DKCFLDFLDGI);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void CEJGEKHJMLG(DECKJPMKMOF PBPIIFNFGMJ, Vector3 KPDDBGLPIPH, float JFKBEMOFNCC, float JDPJMACMKOO = 8f, float BGOCILFMLAJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void CLFDNPJGLDL(KNHPIJHAJOD PBGBCGCEMBN, Vector3 AFDDLCHPJJF, float NPLCIBKJLLM = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "98")]
	void LDOJANPFHBD(KNHPIJHAJOD PBGBCGCEMBN, Vector3 GCFIGFMOIAL, float FJKGBGGIOMN = 7f, float CIHKPDDBHIH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "99")]
	Vector3 CNDCONBFANC(Vector3 FPLJCBGEJAP);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "100")]
	Vector3 KGFENKABDKJ(Vector3 FPLJCBGEJAP);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void MDCDACBDOBA();

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void HDKKHDLJCBD(ILPKGDCLANM OOOHDEPMGEH, object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "103")]
	void EDEKAPKDAHN(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void FIDFLJGKPNB();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "107")]
	void JFGCPDOODIN();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "108")]
	void LJINPIHKMGE();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "111")]
	bool NACOMAKPFBJ();

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void HIDPENPEHKH();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "117")]
	IDisposable PAAMLEOMHIM();

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void PMNFOIDFING(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "119")]
	void IJEHIOABNMP(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void KKMLFIEGHLB(object JCHAGIDHJIB, bool IJHPBMOOGIC);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void NIAKJNPHHHF(Vector3 GDMOLPCGLJL, Quaternion NGMHNDELPAP);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void MJMAFAAGDNC(Vector3 EKAJOFOCODC, Quaternion MNLPDACKEJI);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "125")]
	bool NFACIKGNEPL(float PAGNPNMCLDG);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void DIIDEFIFECE(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void GJMDDKPKLLD(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "128")]
	void HDOOPNPHDOG(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void ODNLFMCNIMM(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void IBDPMHJLAOJ(Vector3 MGJBBFOJNFN, ForceMode ACLPJPMEMPD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void FEGGFDIPJGD(Vector3 MGJBBFOJNFN, Vector3 KGJPEGOHADA, ForceMode ACLPJPMEMPD);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void NHPOGNDMGCD(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "133")]
	void OOHCEIMBKPD(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "134")]
	bool GKLGDFBHMGO(Vector3 GPCLDFNJCPC, out RaycastHit CLAJPNPLGKF, float DODLNOOJAAB);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "135")]
	void MLNJLBLGJPE();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "136")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OHCGFGEMIAI : ILPKGDCLANM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly OJKFOMAKLHL NBEGMMIIDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal ADOGOEHBGDB MDDAOJACOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal ADFLIEJPGFD FHAFFKBCKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal EGCPDEMCLIG PHNFNFPBDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal CFCPCALGPCF LCOAJKBMAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal CIIPJDJKCCC JDGNDMMLOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal JIEGAMCNMJJ BANHIBIDAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal NHKIFEBOFCL DNCFGALAGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal OAAAINOINDE OPMOBIODPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal KOMDCHOGFGK JMPDCDAINBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal OJLHAIBOJPN GHHACBMLIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal MCFFBCKBDAO OJNAOHFBOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal IBBIOIIEBJO MGJBBFOJNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal CBOKBEGMIKO JFKJPOOFOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal NOKJHKJHDMG BBOHKHOPNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal BHPPDHHNLNA CCPEGKECOOE;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public RigidbodyEx BHGLFKBHMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x884180", Offset = "0x883580", VA = "0x180884180", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0xD29410", Offset = "0xD28810", VA = "0x180D29410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GameObject BNDGKEGJNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x795BC0", Offset = "0x794FC0", VA = "0x180795BC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x795C80", Offset = "0x795080", VA = "0x180795C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Transform KJAFIIABLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5775E40", Offset = "0x5775240", VA = "0x185775E40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public IEnumerable<object> PJIOBNNHBEH
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x5776C10", Offset = "0x5776010", VA = "0x185776C10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Rigidbody AHDPHMEMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5776740", Offset = "0x5775B40", VA = "0x185776740", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public ILPKGDCLANM DOOCCGCNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5774C50", Offset = "0x5774050", VA = "0x185774C50", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x5778320", Offset = "0x5777720", VA = "0x185778320", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public IReadOnlyList<ILPKGDCLANM> MKGCJNINDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5775F30", Offset = "0x5775330", VA = "0x185775F30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public ILPKGDCLANM COIMCDBNODG
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5776420", Offset = "0x5775820", VA = "0x185776420", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool CFLBJAOIJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x57752C0", Offset = "0x57746C0", VA = "0x1857752C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool CGHGEFKIEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5774C00", Offset = "0x5774000", VA = "0x185774C00", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool JPNKMIMLPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x5777F00", Offset = "0x5777300", VA = "0x185777F00", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public EBGEGLGLHEI BMELAMIAMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x5777AC0", Offset = "0x5776EC0", VA = "0x185777AC0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x5777F50", Offset = "0x5777350", VA = "0x185777F50", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public INKGBOPGLAH ANJHOFGNHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x5774150", Offset = "0x5773550", VA = "0x185774150", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x5773420", Offset = "0x5772820", VA = "0x185773420", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public float DBEIDHEFFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x57766A0", Offset = "0x5775AA0", VA = "0x1857766A0", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x57760E0", Offset = "0x57754E0", VA = "0x1857760E0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 DECNMOIHGHH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5774F90", Offset = "0x5774390", VA = "0x185774F90", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5778250", Offset = "0x5777650", VA = "0x185778250", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 NOKDFHICMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5774B30", Offset = "0x5773F30", VA = "0x185774B30", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x57732A0", Offset = "0x57726A0", VA = "0x1857732A0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 OCAOFDKLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5774030", Offset = "0x5773430", VA = "0x185774030", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5776DE0", Offset = "0x57761E0", VA = "0x185776DE0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 ADAGFBPLONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5777B70", Offset = "0x5776F70", VA = "0x185777B70", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5775B30", Offset = "0x5774F30", VA = "0x185775B30", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool NPFHJJBDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x57766F0", Offset = "0x5775AF0", VA = "0x1857766F0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool PNPHIGEIMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x57775F0", Offset = "0x57769F0", VA = "0x1857775F0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool INGLGNBAOLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5774CA0", Offset = "0x57740A0", VA = "0x185774CA0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool OPOGDDHDOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x57733D0", Offset = "0x57727D0", VA = "0x1857733D0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Vector3 NADFFGFBCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5775C60", Offset = "0x5775060", VA = "0x185775C60", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 FCAFMICJDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5775320", Offset = "0x5774720", VA = "0x185775320", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Vector3 NBHBELAIBDB
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x57735D0", Offset = "0x57729D0", VA = "0x1857735D0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5776560", Offset = "0x5775960", VA = "0x185776560", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 NEBCIADIING
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5778000", Offset = "0x5777400", VA = "0x185778000", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float DGNOOEIGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x5777A70", Offset = "0x5776E70", VA = "0x185777A70", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float HEPAGCBLJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x5775F80", Offset = "0x5775380", VA = "0x185775F80", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x5776D80", Offset = "0x5776180", VA = "0x185776D80", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Vector3 LMJCLPIBEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x57731D0", Offset = "0x57725D0", VA = "0x1857731D0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5776C60", Offset = "0x5776060", VA = "0x185776C60", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion GKPDPMCDGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x57789C0", Offset = "0x5777DC0", VA = "0x1857789C0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5772DD0", Offset = "0x57721D0", VA = "0x185772DD0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public float PPGDDPLBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5775110", Offset = "0x5774510", VA = "0x185775110", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x57742C0", Offset = "0x57736C0", VA = "0x1857742C0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public float KMCPMIOLLOM
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5773480", Offset = "0x5772880", VA = "0x185773480", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x5776EB0", Offset = "0x57762B0", VA = "0x185776EB0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool IEHOHDHFOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5774100", Offset = "0x5773500", VA = "0x185774100", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x57753F0", Offset = "0x57747F0", VA = "0x1857753F0", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CJAGCCPNBHO KDPBDNOOOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x5772CC0", Offset = "0x57720C0", VA = "0x185772CC0", Slot = "52")]
		get
		{
			return default(CJAGCCPNBHO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x5777150", Offset = "0x5776550", VA = "0x185777150", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool NNGCGJNPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x57783E0", Offset = "0x57777E0", VA = "0x1857783E0", Slot = "54")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public Transform LLDFEFLPEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x57734D0", Offset = "0x57728D0", VA = "0x1857734D0", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public Transform PLHBFGAGLJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x57734D0", Offset = "0x57728D0", VA = "0x1857734D0", Slot = "56")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public Vector3 GABFGMFOOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x5777C40", Offset = "0x5777040", VA = "0x185777C40", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5776270", Offset = "0x5775670", VA = "0x185776270", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public float NFPKDNBCCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5773370", Offset = "0x5772770", VA = "0x185773370", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5777D30", Offset = "0x5777130", VA = "0x185777D30", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public float EDFAOBJKHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x5774E20", Offset = "0x5774220", VA = "0x185774E20", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5778770", Offset = "0x5777B70", VA = "0x185778770", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public Quaternion JLHJOCIFNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5775060", Offset = "0x5774460", VA = "0x185775060", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5776790", Offset = "0x5775B90", VA = "0x185776790", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Vector3 MHKILGKADHG
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x5774420", Offset = "0x5773820", VA = "0x185774420", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5776380", Offset = "0x5775780", VA = "0x185776380", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public Quaternion MIIEKLEEEMM
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x57743E0", Offset = "0x57737E0", VA = "0x1857743E0", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5777CF0", Offset = "0x57770F0", VA = "0x185777CF0", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public RigidbodyConstraints BLKADDBBOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x5775DF0", Offset = "0x57751F0", VA = "0x185775DF0", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5775560", Offset = "0x5774960", VA = "0x185775560", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool KALNOEALNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5777FB0", Offset = "0x57773B0", VA = "0x185777FB0", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x57745E0", Offset = "0x57739E0", VA = "0x1857745E0", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public CollisionDetectionMode IAMKOICFOLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x5772C70", Offset = "0x5772070", VA = "0x185772C70", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5774320", Offset = "0x5773720", VA = "0x185774320", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool ENBBKGECCLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x5778A90", Offset = "0x5777E90", VA = "0x185778A90", Slot = "75")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event EDIBFGHGGCA LCINONPFDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5774470", Offset = "0x5773870", VA = "0x185774470", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5776320", Offset = "0x5775720", VA = "0x185776320", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event EDIBFGHGGCA AEIOOPKGCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5775ED0", Offset = "0x57752D0", VA = "0x185775ED0", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5775C00", Offset = "0x5775000", VA = "0x185775C00", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event ACIELCLFAEN GLHDOLCKNJG
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x5772D10", Offset = "0x5772110", VA = "0x185772D10", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x5776030", Offset = "0x5775430", VA = "0x185776030", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event EDIBFGHGGCA ADNHDJAIKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5777B10", Offset = "0x5776F10", VA = "0x185777B10", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5773C40", Offset = "0x5773040", VA = "0x185773C40", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event EDIBFGHGGCA MLANLPOEPNP
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x57759A0", Offset = "0x5774DA0", VA = "0x1857759A0", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x5776210", Offset = "0x5775610", VA = "0x185776210", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event EDIBFGHGGCA KPKPOEOAKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5775FD0", Offset = "0x57753D0", VA = "0x185775FD0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5773970", Offset = "0x5772D70", VA = "0x185773970", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<MGNDJKECDKI, MGNDJKECDKI> AKEAABLCGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x5772D70", Offset = "0x5772170", VA = "0x185772D70", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x5778710", Offset = "0x5777B10", VA = "0x185778710", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event EDIBFGHGGCA DIDLCNJHPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x5774F30", Offset = "0x5774330", VA = "0x185774F30", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x5778380", Offset = "0x5777780", VA = "0x185778380", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event EDIBFGHGGCA EALFLPLHJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5778920", Offset = "0x5777D20", VA = "0x185778920", Slot = "125")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5774D80", Offset = "0x5774180", VA = "0x185774D80", Slot = "126")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5772540", Offset = "0x5771940", VA = "0x185772540")]
	public OHCGFGEMIAI(GameObject CEPEJEHMODM, RigidbodyEx PLOGKPJMLPD, OJKFOMAKLHL NBEGMMIIDMD, in AJCCCMFGALH MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5776820", Offset = "0x5775C20", VA = "0x185776820", Slot = "142")]
	protected virtual void LCJPMHAPAHD(OJKFOMAKLHL NBEGMMIIDMD, AJCCCMFGALH MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x57741F0", Offset = "0x57735F0", VA = "0x1857741F0", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5777210", Offset = "0x5776610", VA = "0x185777210", Slot = "76")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x57741A0", Offset = "0x57735A0", VA = "0x1857741A0", Slot = "77")]
	public void NLGOPKLJAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x1DEF130", Offset = "0x1DEE530", VA = "0x181DEF130", Slot = "78")]
	public void BLFLGDGOFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5775A80", Offset = "0x5774E80", VA = "0x185775A80", Slot = "144")]
	public virtual void IBNFJMIBNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5777E30", Offset = "0x5777230", VA = "0x185777E30", Slot = "87")]
	public void NPKNFKDMNIH(ILPKGDCLANM FPLJCBGEJAP, bool IFGMNFNELBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5773E80", Offset = "0x5773280", VA = "0x185773E80", Slot = "90")]
	public void DCDDGAENFBD(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5775D90", Offset = "0x5775190", VA = "0x185775D90", Slot = "91")]
	public void IJHDNPOHOGP(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x57776F0", Offset = "0x5776AF0", VA = "0x1857776F0", Slot = "92")]
	public Vector3 NFEHGJFPFGI(Vector3 GAGJBCNBONM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x57734E0", Offset = "0x57728E0", VA = "0x1857734E0", Slot = "93")]
	public Vector3 BMFAGCHKKGB(Vector3 HJHGPEHMJHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x57741A0", Offset = "0x57735A0", VA = "0x1857741A0", Slot = "94")]
	public void DPEFKKCHLHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5775950", Offset = "0x5774D50", VA = "0x185775950", Slot = "95")]
	public void HKHMPMLAFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x5777500", Offset = "0x5776900", VA = "0x185777500", Slot = "96")]
	public void MKACKJBHFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x5773D90", Offset = "0x5773190", VA = "0x185773D90", Slot = "97")]
	public void DAHIGAIEIHL(Vector3 JGLKMMBAANF, Vector3 CGGAGNJAJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x5773EE0", Offset = "0x57732E0", VA = "0x185773EE0", Slot = "98")]
	public void DHMMJCMENIL(Vector3 JHIGCONLFIL, Vector3 HFPOKJMMMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x57738A0", Offset = "0x5772CA0", VA = "0x1857738A0", Slot = "99")]
	public void CKNMFLEDJLC(Vector3 DKCFLDFLDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x57736A0", Offset = "0x5772AA0", VA = "0x1857736A0", Slot = "100")]
	public void CEJGEKHJMLG(DECKJPMKMOF PBPIIFNFGMJ, Vector3 KPDDBGLPIPH, float JFKBEMOFNCC, float JDPJMACMKOO = 8f, float BGOCILFMLAJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x57739D0", Offset = "0x5772DD0", VA = "0x1857739D0", Slot = "101")]
	public void CLFDNPJGLDL(KNHPIJHAJOD PBGBCGCEMBN, Vector3 AFDDLCHPJJF, float NPLCIBKJLLM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5776B00", Offset = "0x5775F00", VA = "0x185776B00", Slot = "102")]
	[Obsolete]
	public void LDOJANPFHBD(KNHPIJHAJOD PBGBCGCEMBN, Vector3 GCFIGFMOIAL, float FJKGBGGIOMN = 7f, float CIHKPDDBHIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5773CA0", Offset = "0x57730A0", VA = "0x185773CA0", Slot = "103")]
	public Vector3 CNDCONBFANC(Vector3 FPLJCBGEJAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5776470", Offset = "0x5775870", VA = "0x185776470", Slot = "104")]
	public Vector3 KGFENKABDKJ(Vector3 FPLJCBGEJAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x5776F10", Offset = "0x5776310", VA = "0x185776F10", Slot = "105")]
	public void MDCDACBDOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x57755C0", Offset = "0x57749C0", VA = "0x1857755C0", Slot = "106")]
	public void HDKKHDLJCBD(ILPKGDCLANM OOOHDEPMGEH, object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x5774380", Offset = "0x5773780", VA = "0x185774380", Slot = "107")]
	public void EDEKAPKDAHN(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x5774AE0", Offset = "0x5773EE0", VA = "0x185774AE0", Slot = "110")]
	public void FIDFLJGKPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x5776090", Offset = "0x5775490", VA = "0x185776090", Slot = "111")]
	public void JFGCPDOODIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5776D30", Offset = "0x5776130", VA = "0x185776D30", Slot = "112")]
	public void LJINPIHKMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x57775A0", Offset = "0x57769A0", VA = "0x1857775A0", Slot = "115")]
	public bool NACOMAKPFBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x57763D0", Offset = "0x57757D0", VA = "0x1857763D0", Slot = "79")]
	public void KENKHKBKEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x57757D0", Offset = "0x5774BD0", VA = "0x1857757D0", Slot = "116")]
	public void HIDPENPEHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5778200", Offset = "0x5777600", VA = "0x185778200", Slot = "121")]
	public IDisposable PAAMLEOMHIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5778BD0", Offset = "0x5777FD0", VA = "0x185778BD0", Slot = "122")]
	public void PMNFOIDFING(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x5775D30", Offset = "0x5775130", VA = "0x185775D30", Slot = "123")]
	public void IJEHIOABNMP(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x5776630", Offset = "0x5775A30", VA = "0x185776630", Slot = "124")]
	public void KKMLFIEGHLB(object JCHAGIDHJIB, bool IJHPBMOOGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x5777860", Offset = "0x5776C60", VA = "0x185777860", Slot = "127")]
	public void NIAKJNPHHHF(Vector3 GDMOLPCGLJL, Quaternion NGMHNDELPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5777350", Offset = "0x5776750", VA = "0x185777350", Slot = "128")]
	public void MJMAFAAGDNC(Vector3 EKAJOFOCODC, Quaternion MNLPDACKEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5777650", Offset = "0x5776A50", VA = "0x185777650", Slot = "129")]
	public bool NFACIKGNEPL(float PAGNPNMCLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x5773FD0", Offset = "0x57733D0", VA = "0x185773FD0", Slot = "130")]
	public void DIIDEFIFECE(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5775160", Offset = "0x5774560", VA = "0x185775160", Slot = "131")]
	public void GJMDDKPKLLD(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5775690", Offset = "0x5774A90", VA = "0x185775690", Slot = "132")]
	public void HDOOPNPHDOG(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5777EA0", Offset = "0x57772A0", VA = "0x185777EA0", Slot = "133")]
	public void ODNLFMCNIMM(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5775A00", Offset = "0x5774E00", VA = "0x185775A00", Slot = "134")]
	public void IBDPMHJLAOJ(Vector3 MGJBBFOJNFN, ForceMode ACLPJPMEMPD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x57744D0", Offset = "0x57738D0", VA = "0x1857744D0", Slot = "135")]
	public void FEGGFDIPJGD(Vector3 MGJBBFOJNFN, Vector3 KGJPEGOHADA, ForceMode ACLPJPMEMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x57777E0", Offset = "0x5776BE0", VA = "0x1857777E0", Slot = "136")]
	public void NHPOGNDMGCD(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5778180", Offset = "0x5777580", VA = "0x185778180", Slot = "137")]
	public void OOHCEIMBKPD(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x57751C0", Offset = "0x57745C0", VA = "0x1857751C0", Slot = "138")]
	public bool GKLGDFBHMGO(Vector3 GPCLDFNJCPC, out RaycastHit CLAJPNPLGKF, float DODLNOOJAAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5777550", Offset = "0x5776950", VA = "0x185777550", Slot = "139")]
	public void MLNJLBLGJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x5778C30", Offset = "0x5778030", VA = "0x185778C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x5776140", Offset = "0x5775540", VA = "0x185776140")]
	private void JLPDACIMNBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5775450", Offset = "0x5774850", VA = "0x185775450")]
	private void HCGAIELFOAA(ILPKGDCLANM CNDFBGEJOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x5776F60", Offset = "0x5776360", VA = "0x185776F60")]
	private void MDHMNEIDDGO(ILPKGDCLANM CNDFBGEJOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x57780D0", Offset = "0x57774D0", VA = "0x1857780D0")]
	private void ONPCCJCGBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x57749E0", Offset = "0x5773DE0", VA = "0x1857749E0")]
	private void FHLKBFJEJMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5774E80", Offset = "0x5774280", VA = "0x185774E80")]
	private void GEKABFHHPIA(ILPKGDCLANM AEFPCOFIJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x57737C0", Offset = "0x5772BC0", VA = "0x1857737C0")]
	private void CIGLGJDDJMB(ILPKGDCLANM CNDFBGEJOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x57756F0", Offset = "0x5774AF0", VA = "0x1857756F0")]
	private void HGGPHOKEFDD(ILPKGDCLANM CNDFBGEJOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x5773AD0", Offset = "0x5772ED0", VA = "0x185773AD0")]
	private void CMEFCOGLMJP(RigidbodyEx CNDFBGEJOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x5774640", Offset = "0x5773A40", VA = "0x185774640")]
	private void FGPHBBPDCNL(RigidbodyEx ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5775820", Offset = "0x5774C20", VA = "0x185775820")]
	[Conditional("UNITY_EDITOR")]
	private void HJLCBIJMHOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5778430", Offset = "0x5777830", VA = "0x185778430")]
	protected void PFKINBGLKHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5772EA0", Offset = "0x57722A0", VA = "0x185772EA0")]
	protected void AKEENABFPMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class EICCLFGOBDN
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5761150", Offset = "0x5760550", VA = "0x185761150")]
	public static ILPKGDCLANM EAMMLNDGOFG(this ILPKGDCLANM ANLOJMEANJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5761010", Offset = "0x5760410", VA = "0x185761010")]
	public static bool AEMGCKFFDCF(this ILPKGDCLANM ANLOJMEANJA, ILPKGDCLANM AMGMMOMIJNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5761210", Offset = "0x5760610", VA = "0x185761210")]
	public static bool KJFINOLCEKF(this ILPKGDCLANM ANLOJMEANJA, ILPKGDCLANM BOIHIMFEHKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5761090", Offset = "0x5760490", VA = "0x185761090")]
	public static RigidbodyEx BHGLFKBHMAO(this ILPKGDCLANM LAFDJCIIPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x57610E0", Offset = "0x57604E0", VA = "0x1857610E0")]
	public static OHCGFGEMIAI DIJBIPMPNHH(this ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class KGNCMGBONEK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly OHCGFGEMIAI ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x576CEA0", Offset = "0x576C2A0", VA = "0x18576CEA0")]
	public KGNCMGBONEK(OHCGFGEMIAI NJOAOGNOOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x576CE40", Offset = "0x576C240", VA = "0x18576CE40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class PDGDPKDJBAB : GNCHIECDDOK, BHPPDHHNLNA
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CollisionDetectionMode ABCAOMKPELN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x64B5250", Offset = "0x64B4650", VA = "0x1864B5250")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x64B55D0", Offset = "0x64B49D0", VA = "0x1864B55D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private Rigidbody AHDPHMEMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x64B54E0", Offset = "0x64B48E0", VA = "0x1864B54E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CollisionDetectionMode IAMKOICFOLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x64B5010", Offset = "0x64B4410", VA = "0x1864B5010", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x64B5110", Offset = "0x64B4510", VA = "0x1864B5110", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x64B56E0", Offset = "0x64B4AE0", VA = "0x1864B56E0")]
	public PDGDPKDJBAB(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x64B5500", Offset = "0x64B4900", VA = "0x1864B5500", Slot = "6")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x64B50B0", Offset = "0x64B44B0", VA = "0x1864B50B0", Slot = "9")]
	public void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x64B56D0", Offset = "0x64B4AD0", VA = "0x1864B56D0", Slot = "7")]
	public void OLKKMPKLMOH(bool OJFDJHJECDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x64B55C0", Offset = "0x64B49C0", VA = "0x1864B55C0", Slot = "8")]
	public void NHNABIMKNII(bool OJFDJHJECDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x64B5150", Offset = "0x64B4550", VA = "0x1864B5150", Slot = "10")]
	public bool GKLGDFBHMGO(Vector3 GPCLDFNJCPC, out RaycastHit CLAJPNPLGKF, float DODLNOOJAAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x64B5340", Offset = "0x64B4740", VA = "0x1864B5340")]
	private void JFELFPNDNNK(bool OJFDJHJECDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class DLAOOEBMIJC : GNCHIECDDOK, OJLHAIBOJPN, IDisposable, KBOBIGJEJBE
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public CJAGCCPNBHO MPAPCJJCDOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x57601A0", Offset = "0x575F5A0", VA = "0x1857601A0")]
		get
		{
			return default(CJAGCCPNBHO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x5760280", Offset = "0x575F680", VA = "0x185760280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public CJAGCCPNBHO KDPBDNOOOJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x575FEE0", Offset = "0x575F2E0", VA = "0x18575FEE0", Slot = "6")]
		get
		{
			return default(CJAGCCPNBHO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5760280", Offset = "0x575F680", VA = "0x185760280", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private Transform HPOIIANAAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<MGNDJKECDKI, MGNDJKECDKI> AKEAABLCGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x5760100", Offset = "0x575F500", VA = "0x185760100", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x57603D0", Offset = "0x575F7D0", VA = "0x1857603D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x575A320", Offset = "0x5759720", VA = "0x18575A320")]
	public DLAOOEBMIJC(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5760370", Offset = "0x575F770", VA = "0x185760370", Slot = "11")]
	public void OnChangedDistanceBand(MGNDJKECDKI AJNJONIBFJA, MGNDJKECDKI IOHONDKAJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "12")]
	public void OnChangedVisibility(bool HNLCKLOEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "8")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class JBPPACKFKIG : GNCHIECDDOK, IBBIOIIEBJO
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private Rigidbody AHDPHMEMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5762DF0", Offset = "0x57621F0", VA = "0x185762DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private bool NNGCGJNPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x57668C0", Offset = "0x5765CC0", VA = "0x1857668C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private bool CFLBJAOIJMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x575F450", Offset = "0x575E850", VA = "0x18575F450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	private ILPKGDCLANM DOOCCGCNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x5766320", Offset = "0x5765720", VA = "0x185766320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x575A320", Offset = "0x5759720", VA = "0x18575A320")]
	public JBPPACKFKIG(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5766380", Offset = "0x5765780", VA = "0x185766380", Slot = "4")]
	public void IBDPMHJLAOJ(Vector3 MGJBBFOJNFN, ForceMode ACLPJPMEMPD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5766B90", Offset = "0x5765F90", VA = "0x185766B90")]
	private void POOOPLPPMCF(Vector3 MGJBBFOJNFN, ForceMode ACLPJPMEMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5766080", Offset = "0x5765480", VA = "0x185766080", Slot = "5")]
	public void FEGGFDIPJGD(Vector3 MGJBBFOJNFN, Vector3 KGJPEGOHADA, ForceMode ACLPJPMEMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x57664E0", Offset = "0x57658E0", VA = "0x1857664E0", Slot = "6")]
	public void NHPOGNDMGCD(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x5766910", Offset = "0x5765D10", VA = "0x185766910")]
	private void PIOAAKBALPI(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5766640", Offset = "0x5765A40", VA = "0x185766640", Slot = "7")]
	public void OOHCEIMBKPD(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class JLAHPJKFDKM : GNCHIECDDOK, OAAAINOINDE
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool IEHOHDHFOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x576B890", Offset = "0x576AC90", VA = "0x18576B890", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x576B970", Offset = "0x576AD70", VA = "0x18576B970", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x575A320", Offset = "0x5759720", VA = "0x18575A320")]
	public JLAHPJKFDKM(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x576B790", Offset = "0x576AB90", VA = "0x18576B790", Slot = "6")]
	public void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x57612C0", Offset = "0x57606C0", VA = "0x1857612C0", Slot = "7")]
	public void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class BJHPDAPGLJH : GNCHIECDDOK, ADOGOEHBGDB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly NINEGPNHKCN GNLABAOMILF;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Transform KJAFIIABLMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x57549D0", Offset = "0x5753DD0", VA = "0x1857549D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public KJNCFICFIIE BPEKBHPOCKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x5754CC0", Offset = "0x57540C0", VA = "0x185754CC0")]
		get
		{
			return default(KJNCFICFIIE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x5753C50", Offset = "0x5753050", VA = "0x185753C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public ILPKGDCLANM DOOCCGCNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x57545B0", Offset = "0x57539B0", VA = "0x1857545B0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x5755530", Offset = "0x5754930", VA = "0x185755530", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public KJNCFICFIIE HGFBJCNCLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5754830", Offset = "0x5753C30", VA = "0x185754830")]
		get
		{
			return default(KJNCFICFIIE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x5754E60", Offset = "0x5754260", VA = "0x185754E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public ILPKGDCLANM COIMCDBNODG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x5754C80", Offset = "0x5754080", VA = "0x185754C80", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public IReadOnlyList<ILPKGDCLANM> MKGCJNINDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x845B30", Offset = "0x844F30", VA = "0x180845B30", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event EDIBFGHGGCA LCINONPFDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5754460", Offset = "0x5753860", VA = "0x185754460", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x5754BE0", Offset = "0x5753FE0", VA = "0x185754BE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event EDIBFGHGGCA AEIOOPKGCAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x5754A00", Offset = "0x5753E00", VA = "0x185754A00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x5754930", Offset = "0x5753D30", VA = "0x185754930", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event ACIELCLFAEN GLHDOLCKNJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x57539F0", Offset = "0x5752DF0", VA = "0x1857539F0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x5754AA0", Offset = "0x5753EA0", VA = "0x185754AA0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action LCDAKJJPPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x5753D50", Offset = "0x5753150", VA = "0x185753D50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x57543C0", Offset = "0x57537C0", VA = "0x1857543C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action PIEPJLKMPBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x5755360", Offset = "0x5754760", VA = "0x185755360", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x5754B40", Offset = "0x5753F40", VA = "0x185754B40", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<ILPKGDCLANM> EMGAIKGILMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5754150", Offset = "0x5753550", VA = "0x185754150", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x5754790", Offset = "0x5753B90", VA = "0x185754790", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<ILPKGDCLANM> DBHPMCGPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x5754F60", Offset = "0x5754360", VA = "0x185754F60", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x57552C0", Offset = "0x57546C0", VA = "0x1857552C0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action BDCLBCCHGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5755000", Offset = "0x5754400", VA = "0x185755000", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x5753DF0", Offset = "0x57531F0", VA = "0x185753DF0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<ILPKGDCLANM> MMMCLOIFIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x57555A0", Offset = "0x57549A0", VA = "0x1857555A0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5754DC0", Offset = "0x57541C0", VA = "0x185754DC0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5755EC0", Offset = "0x57552C0", VA = "0x185755EC0")]
	public BJHPDAPGLJH(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x57541F0", Offset = "0x57535F0", VA = "0x1857541F0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x57551D0", Offset = "0x57545D0", VA = "0x1857551D0", Slot = "26")]
	public void NPKNFKDMNIH(ILPKGDCLANM HKBAAFCKIFC, bool IFGMNFNELBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5755250", Offset = "0x5754650", VA = "0x185755250")]
	private void NPKNFKDMNIH(OBCILHHKOMD HKBAAFCKIFC, bool IFGMNFNELBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5755640", Offset = "0x5754A40", VA = "0x185755640")]
	private void PIBNEKFKHLO(OBCILHHKOMD HKBAAFCKIFC, bool IFGMNFNELBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5753A90", Offset = "0x5752E90", VA = "0x185753A90")]
	private void AGCCDDOIMHC(OBCILHHKOMD AEFPCOFIJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5753E90", Offset = "0x5753290", VA = "0x185753E90")]
	private void CMAOMHAJMJN(OBCILHHKOMD AEFPCOFIJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x57545F0", Offset = "0x57539F0", VA = "0x1857545F0")]
	private void HEMDGLJLLGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5753840", Offset = "0x5752C40", VA = "0x185753840")]
	private void ACBEFEDBMGL(OBCILHHKOMD AEFPCOFIJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5754500", Offset = "0x5753900", VA = "0x185754500")]
	private void FLIGOGOGPEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x57550A0", Offset = "0x57544A0", VA = "0x1857550A0")]
	private void NJBAPIKGECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5755400", Offset = "0x5754800", VA = "0x185755400")]
	private void OFOBOCNNGKJ(OBCILHHKOMD ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x57538C0", Offset = "0x5752CC0", VA = "0x1857538C0")]
	private void ADHHJICHDIC(OBCILHHKOMD ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5754050", Offset = "0x5753450", VA = "0x185754050")]
	[CompilerGenerated]
	private object DHNDNPHMBKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class OMBLCHEBHDC
{
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x64B4ED0", Offset = "0x64B42D0", VA = "0x1864B4ED0")]
	public static BJHPDAPGLJH NIAOPJFMOLB(this ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class JBNPGELECEA : GNCHIECDDOK, CIIPJDJKCCC
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public Vector3 NADFFGFBCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x57659A0", Offset = "0x5764DA0", VA = "0x1857659A0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public Vector3 FCAFMICJDPP
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x5765760", Offset = "0x5764B60", VA = "0x185765760", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private Vector3 OCAOFDKLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x5765520", Offset = "0x5764920", VA = "0x185765520")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private ILPKGDCLANM GKDOADEHHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x5765600", Offset = "0x5764A00", VA = "0x185765600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x575A320", Offset = "0x5759720", VA = "0x18575A320")]
	public JBNPGELECEA(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5765B00", Offset = "0x5764F00", VA = "0x185765B00", Slot = "6")]
	public void LLCFANBFIPP(ILPKGDCLANM CNDFBGEJOLI, object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x57659D0", Offset = "0x5764DD0", VA = "0x1857659D0")]
	private void LLCFANBFIPP(OBCILHHKOMD CNDFBGEJOLI, object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5765430", Offset = "0x5764830", VA = "0x185765430", Slot = "7")]
	public void BJEODEMDDGM(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x5765C90", Offset = "0x5765090", VA = "0x185765C90")]
	private Vector3 MOAHKNMINPI()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class DAJOIGBJBDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x575ED80", Offset = "0x575E180", VA = "0x18575ED80")]
	public static JBNPGELECEA MAEFCBNMPCO(this ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class LEFOGOEBBFM : GNCHIECDDOK, JIEGAMCNMJJ
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 NBHBELAIBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x576D450", Offset = "0x576C850", VA = "0x18576D450", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x576E4D0", Offset = "0x576D8D0", VA = "0x18576E4D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 NEBCIADIING
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x576EF10", Offset = "0x576E310", VA = "0x18576EF10", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public float DGNOOEIGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x576EE30", Offset = "0x576E230", VA = "0x18576EE30", Slot = "9")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x576E140", Offset = "0x576D540", VA = "0x18576E140")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float HEPAGCBLJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x576E060", Offset = "0x576D460", VA = "0x18576E060", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x576E930", Offset = "0x576DD30", VA = "0x18576E930", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public Vector3 LMJCLPIBEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x576CFF0", Offset = "0x576C3F0", VA = "0x18576CFF0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x576E820", Offset = "0x576DC20", VA = "0x18576E820", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public Quaternion GKPDPMCDGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x576F030", Offset = "0x576E430", VA = "0x18576F030", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x576CFD0", Offset = "0x576C3D0", VA = "0x18576CFD0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private Rigidbody AHDPHMEMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x5762DF0", Offset = "0x57621F0", VA = "0x185762DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event EDIBFGHGGCA HEGPDCDAOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x576CF30", Offset = "0x576C330", VA = "0x18576CF30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x576D900", Offset = "0x576CD00", VA = "0x18576D900", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5770510", Offset = "0x576F910", VA = "0x185770510")]
	public LEFOGOEBBFM(ILPKGDCLANM ANLOJMEANJA, in AJCCCMFGALH MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x576DAC0", Offset = "0x576CEC0", VA = "0x18576DAC0", Slot = "17")]
	public void FIDFLJGKPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x576E150", Offset = "0x576D550", VA = "0x18576E150", Slot = "16")]
	public void JFGCPDOODIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x576D020", Offset = "0x576C420", VA = "0x18576D020", Slot = "19")]
	public void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x576D580", Offset = "0x576C980", VA = "0x18576D580", Slot = "20")]
	public void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x576E850", Offset = "0x576DC50", VA = "0x18576E850", Slot = "18")]
	public void LJINPIHKMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x576E940", Offset = "0x576DD40", VA = "0x18576E940", Slot = "21")]
	public void MLNJLBLGJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x57633D0", Offset = "0x57627D0", VA = "0x1857633D0")]
	public void FBOGNHDJLKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x576E4D0", Offset = "0x576D8D0", VA = "0x18576E4D0")]
	private void OCKGBEDIOBF(Vector3 FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x576D9A0", Offset = "0x576CDA0", VA = "0x18576D9A0")]
	private Vector3 FFKMKNPIIDO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x576DCD0", Offset = "0x576D0D0", VA = "0x18576DCD0")]
	private void GPMNBNEDCPK(float FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x576DEA0", Offset = "0x576D2A0", VA = "0x18576DEA0")]
	private void JCGIGDNDJOK(float FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x57702E0", Offset = "0x576F6E0", VA = "0x1857702E0")]
	private Vector3 POAPPABNILC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x576F060", Offset = "0x576E460", VA = "0x18576F060")]
	private void PLAEAPJDCBO(Vector3 FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x576E610", Offset = "0x576DA10", VA = "0x18576E610")]
	private Quaternion LDDGFCNKCBH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x576D240", Offset = "0x576C640", VA = "0x18576D240")]
	private void BHHKJIJCGJK(Quaternion FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x576F290", Offset = "0x576E690", VA = "0x18576F290")]
	internal (float, Vector3) PNACOPOAKOE(Rigidbody HJJDCBPFLHO)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class DCCBHONOIMD
{
	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x575EE10", Offset = "0x575E210", VA = "0x18575EE10")]
	public static LEFOGOEBBFM LAJJIBJCDBJ(this ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class CBMNLGMDHOE : GNCHIECDDOK, ADFLIEJPGFD
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private const string JFEEHPGBIFL = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool GGCHCLPEMCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x57568D0", Offset = "0x5755CD0", VA = "0x1857568D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public HIHNKPGEDDE NOJLEBJKKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x57564F0", Offset = "0x57558F0", VA = "0x1857564F0", Slot = "5")]
		get
		{
			return default(HIHNKPGEDDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private HIHNKPGEDDE JGAHEIIAIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x5756500", Offset = "0x5755900", VA = "0x185756500")]
		get
		{
			return default(HIHNKPGEDDE);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x5756150", Offset = "0x5755550", VA = "0x185756150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x57569F0", Offset = "0x5755DF0", VA = "0x1857569F0")]
	public CBMNLGMDHOE(ILPKGDCLANM ANLOJMEANJA, in AJCCCMFGALH MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x57567D0", Offset = "0x5755BD0", VA = "0x1857567D0", Slot = "6")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5756340", Offset = "0x5755740", VA = "0x185756340")]
	private bool GONKCFFJNPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x5756240", Offset = "0x5755640", VA = "0x185756240", Slot = "7")]
	public void GFMOKLHHCDB(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x57566D0", Offset = "0x5755AD0", VA = "0x1857566D0", Slot = "8")]
	public void MGCLAOAADOC(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x57563E0", Offset = "0x57557E0", VA = "0x1857563E0", Slot = "11")]
	public void IFNGLGFDCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x57565E0", Offset = "0x57559E0", VA = "0x1857565E0")]
	private void LOCHMOGKNAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x5756000", Offset = "0x5755400", VA = "0x185756000")]
	private void EHJDFJBNBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x5756890", Offset = "0x5755C90", VA = "0x185756890", Slot = "10")]
	public void NFPKFACOBKP(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x57569B0", Offset = "0x5755DB0", VA = "0x1857569B0", Slot = "9")]
	public void PIKIAPJONJN(ILPKGDCLANM ANLOJMEANJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class OCDMEFKJLNL : GNCHIECDDOK, MCFFBCKBDAO
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool NNGCGJNPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x5772BA0", Offset = "0x5771FA0", VA = "0x185772BA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IEnumerable<object> GJGGGEBIAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x5772A20", Offset = "0x5771E20", VA = "0x185772A20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private bool BGLNONNLJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x57726C0", Offset = "0x5771AC0", VA = "0x1857726C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event EDIBFGHGGCA JFCBDEPNNFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x5772920", Offset = "0x5771D20", VA = "0x185772920", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x5772B00", Offset = "0x5771F00", VA = "0x185772B00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x575A320", Offset = "0x5759720", VA = "0x18575A320")]
	public OCDMEFKJLNL(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x57729C0", Offset = "0x5771DC0", VA = "0x1857729C0", Slot = "11")]
	public IDisposable PAAMLEOMHIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x5772C60", Offset = "0x5772060", VA = "0x185772C60", Slot = "8")]
	public void PMNFOIDFING(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x57726B0", Offset = "0x5771AB0", VA = "0x1857726B0", Slot = "9")]
	public void IJEHIOABNMP(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x57727A0", Offset = "0x5771BA0", VA = "0x1857727A0", Slot = "10")]
	public void KKMLFIEGHLB(object JCHAGIDHJIB, bool IJHPBMOOGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x5772610", Offset = "0x5771A10", VA = "0x185772610", Slot = "12")]
	public void AOAIBKKGCDK(Rigidbody DFDJIBDBDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5772680", Offset = "0x5771A80", VA = "0x185772680", Slot = "13")]
	public void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class GKCNGFMACMA : GNCHIECDDOK, EGCPDEMCLIG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private PhotonView MGBGBEHJPNP;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool CGHGEFKIEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x575E7C0", Offset = "0x575DBC0", VA = "0x18575E7C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool JPNKMIMLPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x57620A0", Offset = "0x57614A0", VA = "0x1857620A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event EDIBFGHGGCA ADNHDJAIKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x5762000", Offset = "0x5761400", VA = "0x185762000", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x57616E0", Offset = "0x5760AE0", VA = "0x1857616E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x57623A0", Offset = "0x57617A0", VA = "0x1857623A0")]
	public GKCNGFMACMA(ILPKGDCLANM ANLOJMEANJA, in AJCCCMFGALH MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5761EB0", Offset = "0x57612B0", VA = "0x185761EB0", Slot = "8")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5761780", Offset = "0x5760B80", VA = "0x185761780", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x57614D0", Offset = "0x57608D0", VA = "0x1857614D0", Slot = "9")]
	public void CIGLGJDDJMB(ILPKGDCLANM CNDFBGEJOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x5761CA0", Offset = "0x57610A0", VA = "0x185761CA0", Slot = "10")]
	public void HGGPHOKEFDD(ILPKGDCLANM CNDFBGEJOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x57621B0", Offset = "0x57615B0", VA = "0x1857621B0")]
	private void OLNEFICPOKJ(PhotonView FIONCGDKAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x5761970", Offset = "0x5760D70", VA = "0x185761970")]
	private void FICOABAIBOO(RigidbodyEx LADCCMEPEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x5761AD0", Offset = "0x5760ED0", VA = "0x185761AD0")]
	private void FMHOCGCEJDB(PhotonView KIOKLPICDOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class DCHIEANBBFI
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x575EEA0", Offset = "0x575E2A0", VA = "0x18575EEA0")]
	public static GKCNGFMACMA ENHKKOOLCLG(this OHCGFGEMIAI OOJCPNBFJMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class CFJKDODILHB : GNCHIECDDOK, CBOKBEGMIKO
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool KALNOEALNHD
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x575AB40", Offset = "0x5759F40", VA = "0x18575AB40", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x575A690", Offset = "0x5759A90", VA = "0x18575A690", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool OMLANDBOKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x575AA60", Offset = "0x5759E60", VA = "0x18575AA60", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x575A4A0", Offset = "0x57598A0", VA = "0x18575A4A0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public RigidbodyConstraints BLKADDBBOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x575A980", Offset = "0x5759D80", VA = "0x18575A980", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x575A780", Offset = "0x5759B80", VA = "0x18575A780", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x575AC20", Offset = "0x575A020", VA = "0x18575AC20")]
	public CFJKDODILHB(ILPKGDCLANM ANLOJMEANJA, in AJCCCMFGALH MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x575A3A0", Offset = "0x57597A0", VA = "0x18575A3A0", Slot = "9")]
	public void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x575A590", Offset = "0x5759990", VA = "0x18575A590", Slot = "10")]
	public void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class IMGHJLGOPMF : GNCHIECDDOK, NHKIFEBOFCL
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public float PPGDDPLBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x5765180", Offset = "0x5764580", VA = "0x185765180", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x5764FB0", Offset = "0x57643B0", VA = "0x185764FB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public float KMCPMIOLLOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x5764E00", Offset = "0x5764200", VA = "0x185764E00", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x5765260", Offset = "0x5764660", VA = "0x185765260", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x575A320", Offset = "0x5759720", VA = "0x18575A320")]
	public IMGHJLGOPMF(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x5764C30", Offset = "0x5764030", VA = "0x185764C30", Slot = "8")]
	public void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x5764EE0", Offset = "0x57642E0", VA = "0x185764EE0", Slot = "9")]
	public void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB)
	{
	}
}
namespace RecRoom.Rbex.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[AOJPGBJKDNL(typeof(JPGOMJFBJNM), new string[] { })]
	[NAPHGBOEKGO(GPIMBHHJLKL.Physics)]
	public sealed class RbexServiceCallbacks : NGENPNOGFON, JPGOMJFBJNM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly BBHAOFNBCPD CDECIAPNKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private KJFHICGMDLJ ANLOJMEANJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private bool GBMPCBCEGPH;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool PGGMGHNLHNL
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x85F6B0", Offset = "0x85EAB0", VA = "0x18085F6B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x64B6120", Offset = "0x64B5520", VA = "0x1864B6120", Slot = "4")]
		public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x64B60F0", Offset = "0x64B54F0", VA = "0x1864B60F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x64B6170", Offset = "0x64B5570", VA = "0x1864B6170", Slot = "6")]
		public void PNACOPOAKOE(KJNCFICFIIE GNKPFNIMJND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public RbexServiceCallbacks()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class GKIBBFBJKGE : GNCHIECDDOK, KOMDCHOGFGK
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public const int IPBIGAOHPHO = 10;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public const float ELOICAAPEML = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public const float MMPKDAEDLNH = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public const float GOMDJPNPGBM = 5f;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private Rigidbody AHDPHMEMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x5762DF0", Offset = "0x57621F0", VA = "0x185762DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool BAAKFPABGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x5762760", Offset = "0x5761B60", VA = "0x185762760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool ENBBKGECCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x575A300", Offset = "0x5759700", VA = "0x18575A300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	private ILPKGDCLANM DOOCCGCNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x57628E0", Offset = "0x5761CE0", VA = "0x1857628E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	private bool CFLBJAOIJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x5762940", Offset = "0x5761D40", VA = "0x185762940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private bool INODMHAIHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x5762800", Offset = "0x5761C00", VA = "0x185762800")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x5762E40", Offset = "0x5762240", VA = "0x185762E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private bool BLECPCCGHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x5763200", Offset = "0x5762600", VA = "0x185763200")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x57632E0", Offset = "0x57626E0", VA = "0x1857632E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private int PCLDDLKBICB
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x5762430", Offset = "0x5761830", VA = "0x185762430")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x5762CF0", Offset = "0x57620F0", VA = "0x185762CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event EDIBFGHGGCA KPKPOEOAKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x5762A50", Offset = "0x5761E50", VA = "0x185762A50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x5762510", Offset = "0x5761910", VA = "0x185762510", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x5763410", Offset = "0x5762810", VA = "0x185763410")]
	public GKIBBFBJKGE(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x5762F30", Offset = "0x5762330", VA = "0x185762F30", Slot = "6")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x5762DE0", Offset = "0x57621E0", VA = "0x185762DE0", Slot = "8")]
	public void KKIECAKDELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x5762FE0", Offset = "0x57623E0", VA = "0x185762FE0", Slot = "7")]
	public bool NACOMAKPFBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x5762C40", Offset = "0x5762040", VA = "0x185762C40", Slot = "9")]
	public void KENKHKBKEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x57633D0", Offset = "0x57627D0", VA = "0x1857633D0", Slot = "12")]
	public void PEMMOGJEFHM(bool IADBGGBPGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x57629A0", Offset = "0x5761DA0", VA = "0x1857629A0", Slot = "11")]
	public void HIDPENPEHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "10")]
	public void AIADGDGDDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x57625B0", Offset = "0x57619B0", VA = "0x1857625B0")]
	private bool CLKHHKKBPPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5762AF0", Offset = "0x5761EF0", VA = "0x185762AF0")]
	private void JLLHDEAAMKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class DGLLHFGHFGC : GNCHIECDDOK, NOKJHKJHDMG
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private const string FKIKGLINABK = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Rigidbody AHDPHMEMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x575FAD0", Offset = "0x575EED0", VA = "0x18575FAD0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x575FD60", Offset = "0x575F160", VA = "0x18575FD60")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private bool CFLBJAOIJMM
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x575F450", Offset = "0x575E850", VA = "0x18575F450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x575FE50", Offset = "0x575F250", VA = "0x18575FE50")]
	public DGLLHFGHFGC(ILPKGDCLANM ANLOJMEANJA, in AJCCCMFGALH MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x575FBB0", Offset = "0x575EFB0", VA = "0x18575FBB0", Slot = "5")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x575F4B0", Offset = "0x575E8B0", VA = "0x18575F4B0", Slot = "6")]
	public void HDOOPNPHDOG(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x575FC60", Offset = "0x575F060", VA = "0x18575FC60", Slot = "7")]
	public void ODNLFMCNIMM(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x575F810", Offset = "0x575EC10", VA = "0x18575F810", Slot = "8")]
	public void KEOPHCFHNBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x575F5B0", Offset = "0x575E9B0", VA = "0x18575F5B0", Slot = "9")]
	public void IANPFGAPGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x575F280", Offset = "0x575E680", VA = "0x18575F280", Slot = "10")]
	public void EBMMJMCNPHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "11")]
	public void LCNBPFHHODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x575EF00", Offset = "0x575E300", VA = "0x18575EF00")]
	private void AHHPDDMBENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x575F0C0", Offset = "0x575E4C0", VA = "0x18575F0C0")]
	private void CGFJDDMOHPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class CEOIICFBILA : GNCHIECDDOK, CFCPCALGPCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public EBGEGLGLHEI BMELAMIAMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x5759F60", Offset = "0x5759360", VA = "0x185759F60", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x575A1E0", Offset = "0x57595E0", VA = "0x18575A1E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public INKGBOPGLAH ANJHOFGNHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5757D00", Offset = "0x5757100", VA = "0x185757D00", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5756CB0", Offset = "0x57560B0", VA = "0x185756CB0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 OCAOFDKLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5757BB0", Offset = "0x5756FB0", VA = "0x185757BB0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5759A40", Offset = "0x5758E40", VA = "0x185759A40", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 DECNMOIHGHH
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5758650", Offset = "0x5757A50", VA = "0x185758650", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x575A2D0", Offset = "0x57596D0", VA = "0x18575A2D0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 ADAGFBPLONM
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x575A090", Offset = "0x5759490", VA = "0x18575A090", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5758900", Offset = "0x5757D00", VA = "0x185758900", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 NOKDFHICMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5758530", Offset = "0x5757930", VA = "0x185758530", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5756BA0", Offset = "0x5755FA0", VA = "0x185756BA0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float DBEIDHEFFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5758D50", Offset = "0x5758150", VA = "0x185758D50", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x57589C0", Offset = "0x5757DC0", VA = "0x1857589C0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public bool OPOGDDHDOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5756BD0", Offset = "0x5755FD0", VA = "0x185756BD0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private IBBIOIIEBJO KEMDHJDNANE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x258E8D0", Offset = "0x258DCD0", VA = "0x18258E8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	private bool ENBBKGECCLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x575A300", Offset = "0x5759700", VA = "0x18575A300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x575A320", Offset = "0x5759720", VA = "0x18575A320")]
	public CEOIICFBILA(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x5758330", Offset = "0x5757730", VA = "0x185758330", Slot = "20")]
	public void ENGBBGGKKNM(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x5756DA0", Offset = "0x57561A0", VA = "0x185756DA0", Slot = "31")]
	public void BIHLENLICGJ(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5757E30", Offset = "0x5757230", VA = "0x185757E30", Slot = "19")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5757EA0", Offset = "0x57572A0", VA = "0x185757EA0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5756B60", Offset = "0x5755F60", VA = "0x185756B60", Slot = "28")]
	public void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5759D80", Offset = "0x5759180", VA = "0x185759D80", Slot = "36")]
	public Vector3 NFEHGJFPFGI(Vector3 GAGJBCNBONM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5756E90", Offset = "0x5756290", VA = "0x185756E90", Slot = "35")]
	public Vector3 BMFAGCHKKGB(Vector3 HJHGPEHMJHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5757E30", Offset = "0x5757230", VA = "0x185757E30", Slot = "27")]
	public void DPEFKKCHLHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5758760", Offset = "0x5757B60", VA = "0x185758760", Slot = "25")]
	public void HKHMPMLAFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5759D40", Offset = "0x5759140", VA = "0x185759D40", Slot = "24")]
	public void MKACKJBHFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5757910", Offset = "0x5756D10", VA = "0x185757910", Slot = "34")]
	public void DAHIGAIEIHL(Vector3 JGLKMMBAANF, Vector3 CGGAGNJAJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5757B50", Offset = "0x5756F50", VA = "0x185757B50", Slot = "33")]
	public void DHMMJCMENIL(Vector3 JHIGCONLFIL, Vector3 HFPOKJMMMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x57574C0", Offset = "0x57568C0", VA = "0x1857574C0", Slot = "32")]
	public void CKNMFLEDJLC(Vector3 DKCFLDFLDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5757050", Offset = "0x5756450", VA = "0x185757050", Slot = "22")]
	public void CEJGEKHJMLG(DECKJPMKMOF PBPIIFNFGMJ, Vector3 KPDDBGLPIPH, float JFKBEMOFNCC, float JDPJMACMKOO = 8f, float BGOCILFMLAJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5757620", Offset = "0x5756A20", VA = "0x185757620", Slot = "21")]
	public void CLFDNPJGLDL(KNHPIJHAJOD PBGBCGCEMBN, Vector3 AFDDLCHPJJF, float NPLCIBKJLLM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5759770", Offset = "0x5758B70", VA = "0x185759770", Slot = "23")]
	[Obsolete]
	public void LDOJANPFHBD(KNHPIJHAJOD PBGBCGCEMBN, Vector3 GCFIGFMOIAL, float FJKGBGGIOMN = 7f, float CIHKPDDBHIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5757850", Offset = "0x5756C50", VA = "0x185757850", Slot = "30")]
	public Vector3 CNDCONBFANC(Vector3 LCOAJKBMAJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5758C60", Offset = "0x5758060", VA = "0x185758C60", Slot = "29")]
	public Vector3 KGFENKABDKJ(Vector3 FAJPHALHEOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5759B00", Offset = "0x5758F00", VA = "0x185759B00", Slot = "26")]
	public void MDCDACBDOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x57589D0", Offset = "0x5757DD0", VA = "0x1857589D0")]
	private void KALOANMLBLG(float FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x57587A0", Offset = "0x5757BA0", VA = "0x1857587A0")]
	private void IBEJIJHPKJL(Vector3 AFDDLCHPJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5758420", Offset = "0x5757820", VA = "0x185758420")]
	private Vector3 EPJOMOKDEAJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5758E30", Offset = "0x5758230", VA = "0x185758E30")]
	private void KMMMFMAPJGO(Vector3 HJHGPEHMJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5759C30", Offset = "0x5759030", VA = "0x185759C30")]
	private Vector3 MEIMIOALBOA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5757FD0", Offset = "0x57573D0", VA = "0x185757FD0")]
	private void EBBALBPNJAI(Vector3 FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5759170", Offset = "0x5758570", VA = "0x185759170")]
	private void LDKFDGFEFJE(Vector3 HJHGPEHMJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5758BA0", Offset = "0x5757FA0", VA = "0x185758BA0")]
	private void KDKFJKLJJEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class GNCHIECDDOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly OBCILHHKOMD ANLOJMEANJA;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	protected KJFHICGMDLJ MEBJEGLBOKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x1446FC0", Offset = "0x14463C0", VA = "0x181446FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	protected KJNCFICFIIE CIMKHMBODDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x57646F0", Offset = "0x5763AF0", VA = "0x1857646F0")]
		get
		{
			return default(KJNCFICFIIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x575A320", Offset = "0x5759720", VA = "0x18575A320")]
	public GNCHIECDDOK(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x5764720", Offset = "0x5763B20", VA = "0x185764720")]
	protected ILPKGDCLANM MFIAPDNPKIB(KJNCFICFIIE LJGIOCJLACK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class EECNFEDCKNP : LEOOJPIMKPF
{
	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x5760510", Offset = "0x575F910", VA = "0x185760510", Slot = "4")]
	public ADOGOEHBGDB AAIELKNPPKB(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x5760E30", Offset = "0x5760230", VA = "0x185760E30", Slot = "5")]
	public CFCPCALGPCF LHIONECBHJJ(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x5760680", Offset = "0x575FA80", VA = "0x185760680", Slot = "6")]
	public CIIPJDJKCCC BAOIHDCCDIH(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5760F70", Offset = "0x5760370", VA = "0x185760F70", Slot = "7")]
	public NHKIFEBOFCL MBIDMBEKDDD(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x5760A80", Offset = "0x575FE80", VA = "0x185760A80", Slot = "8")]
	public KOMDCHOGFGK HMBJBMIALGL(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5760AE0", Offset = "0x575FEE0", VA = "0x185760AE0", Slot = "9")]
	public OJLHAIBOJPN HMIMPAILINC(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5760ED0", Offset = "0x57602D0", VA = "0x185760ED0", Slot = "10")]
	public MCFFBCKBDAO LOFBBHEMFPA(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x5760470", Offset = "0x575F870", VA = "0x185760470", Slot = "11")]
	public IBBIOIIEBJO AAGLGOEMMIF(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5760B80", Offset = "0x575FF80", VA = "0x185760B80", Slot = "12")]
	public BHPPDHHNLNA IBGFDICMLHJ(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x57608B0", Offset = "0x575FCB0", VA = "0x1857608B0", Slot = "13")]
	public OAAAINOINDE DMKJDDCFKFA(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5760BE0", Offset = "0x575FFE0", VA = "0x185760BE0")]
	public NOKJHKJHDMG IGAMCAFAOGF(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5760950", Offset = "0x575FD50", VA = "0x185760950")]
	public EGCPDEMCLIG IKEEEHBMMCL(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5760720", Offset = "0x575FB20", VA = "0x185760720")]
	public ADFLIEJPGFD DBGOAOBHJAP(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5760A10", Offset = "0x575FE10", VA = "0x185760A10")]
	public JIEGAMCNMJJ PMEEKEEKDHM(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5760CA0", Offset = "0x57600A0", VA = "0x185760CA0")]
	public CBOKBEGMIKO KHDHIBGGPLP(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5760D10", Offset = "0x5760110", VA = "0x185760D10", Slot = "19")]
	public ILPKGDCLANM KJPIJLPLBGM(RigidbodyEx ANLOJMEANJA, AJCCCMFGALH MPEBBGJJODN, OJKFOMAKLHL NBEGMMIIDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public EECNFEDCKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5760BE0", Offset = "0x575FFE0", VA = "0x185760BE0", Slot = "14")]
	private NOKJHKJHDMG OAEIAMKHBEP(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5760950", Offset = "0x575FD50", VA = "0x185760950", Slot = "15")]
	private EGCPDEMCLIG ECLMHJBKPMI(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5760720", Offset = "0x575FB20", VA = "0x185760720", Slot = "16")]
	private ADFLIEJPGFD IICOJKOINIF(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5760A10", Offset = "0x575FE10", VA = "0x185760A10", Slot = "17")]
	private JIEGAMCNMJJ HHCKEBFMEEF(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5760CA0", Offset = "0x57600A0", VA = "0x185760CA0", Slot = "18")]
	private CBOKBEGMIKO MOBILJLGBGN(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class NINEGPNHKCN : IReadOnlyList<ILPKGDCLANM>, IEnumerable<ILPKGDCLANM>, IEnumerable, IReadOnlyCollection<ILPKGDCLANM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly KJNCFICFIIE LJGIOCJLACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly KJFHICGMDLJ OCGDPJBGCPH;

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x57717C0", Offset = "0x5770BC0", VA = "0x1857717C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public ILPKGDCLANM CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x5771890", Offset = "0x5770C90", VA = "0x185771890", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5771770", Offset = "0x5770B70", VA = "0x185771770")]
	public NINEGPNHKCN(KJNCFICFIIE LJGIOCJLACK, KJFHICGMDLJ OCGDPJBGCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x57715D0", Offset = "0x57709D0", VA = "0x1857715D0", Slot = "6")]
	public IEnumerator<ILPKGDCLANM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x57715D0", Offset = "0x57709D0", VA = "0x1857715D0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5771760", Offset = "0x5770B60", VA = "0x185771760")]
	[CompilerGenerated]
	private ILPKGDCLANM LGHBLGPJBOD(int MDFMPEMHONH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[AOJPGBJKDNL(typeof(LEOOJPIMKPF), new string[] { })]
public class AGIHDFJPHNE : LEOOJPIMKPF, NGENPNOGFON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly LEOOJPIMKPF GACDMEBBMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly LEOOJPIMKPF CBHBKOJKJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private APLFFAOJOGK CGENOKFJBNJ;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	private LEOOJPIMKPF FGFNBFDFJLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x57531D0", Offset = "0x57525D0", VA = "0x1857531D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5753610", Offset = "0x5752A10", VA = "0x185753610", Slot = "20")]
	public void PBJBMEPEDIE(LODNGHNPONL KPGPMPPLGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5752B50", Offset = "0x5751F50", VA = "0x185752B50", Slot = "4")]
	public ADOGOEHBGDB AAIELKNPPKB(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5753430", Offset = "0x5752830", VA = "0x185753430", Slot = "5")]
	public CFCPCALGPCF LHIONECBHJJ(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5752BF0", Offset = "0x5751FF0", VA = "0x185752BF0", Slot = "6")]
	public CIIPJDJKCCC BAOIHDCCDIH(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5753570", Offset = "0x5752970", VA = "0x185753570", Slot = "7")]
	public NHKIFEBOFCL MBIDMBEKDDD(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5752F40", Offset = "0x5752340", VA = "0x185752F40", Slot = "8")]
	public KOMDCHOGFGK HMBJBMIALGL(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5752FE0", Offset = "0x57523E0", VA = "0x185752FE0", Slot = "9")]
	public OJLHAIBOJPN HMIMPAILINC(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x57534D0", Offset = "0x57528D0", VA = "0x1857534D0", Slot = "10")]
	public MCFFBCKBDAO LOFBBHEMFPA(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5752AB0", Offset = "0x5751EB0", VA = "0x185752AB0", Slot = "11")]
	public IBBIOIIEBJO AAGLGOEMMIF(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5753080", Offset = "0x5752480", VA = "0x185753080", Slot = "12")]
	public BHPPDHHNLNA IBGFDICMLHJ(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5752D40", Offset = "0x5752140", VA = "0x185752D40", Slot = "13")]
	public OAAAINOINDE DMKJDDCFKFA(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5753120", Offset = "0x5752520", VA = "0x185753120")]
	public NOKJHKJHDMG IGAMCAFAOGF(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x5752DE0", Offset = "0x57521E0", VA = "0x185752DE0")]
	public EGCPDEMCLIG IKEEEHBMMCL(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5752C90", Offset = "0x5752090", VA = "0x185752C90")]
	public ADFLIEJPGFD DBGOAOBHJAP(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5752E90", Offset = "0x5752290", VA = "0x185752E90")]
	public JIEGAMCNMJJ PMEEKEEKDHM(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5753230", Offset = "0x5752630", VA = "0x185753230")]
	public CBOKBEGMIKO KHDHIBGGPLP(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x57532E0", Offset = "0x57526E0", VA = "0x1857532E0", Slot = "19")]
	public ILPKGDCLANM KJPIJLPLBGM(RigidbodyEx ANLOJMEANJA, AJCCCMFGALH MPEBBGJJODN, OJKFOMAKLHL NBEGMMIIDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5753660", Offset = "0x5752A60", VA = "0x185753660")]
	public AGIHDFJPHNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5753120", Offset = "0x5752520", VA = "0x185753120", Slot = "14")]
	private NOKJHKJHDMG OAEIAMKHBEP(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5752DE0", Offset = "0x57521E0", VA = "0x185752DE0", Slot = "15")]
	private EGCPDEMCLIG ECLMHJBKPMI(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5752C90", Offset = "0x5752090", VA = "0x185752C90", Slot = "16")]
	private ADFLIEJPGFD IICOJKOINIF(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5752E90", Offset = "0x5752290", VA = "0x185752E90", Slot = "17")]
	private JIEGAMCNMJJ HHCKEBFMEEF(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x5753230", Offset = "0x5752630", VA = "0x185753230", Slot = "18")]
	private CBOKBEGMIKO MOBILJLGBGN(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[Preserve]
public sealed class AJPEEJAHMPF : ILPKGDCLANM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly AJPEEJAHMPF KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Rigidbody AHDPHMEMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public RigidbodyEx BHGLFKBHMAO
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public GameObject BNDGKEGJNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Transform KJAFIIABLMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public IEnumerable<object> PJIOBNNHBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public ILPKGDCLANM DOOCCGCNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6C72D0", Offset = "0x6C66D0", VA = "0x1806C72D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7776A0", Offset = "0x776AA0", VA = "0x1807776A0", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public IReadOnlyList<ILPKGDCLANM> MKGCJNINDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6D2590", Offset = "0x6D1990", VA = "0x1806D2590", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public ILPKGDCLANM COIMCDBNODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x6E1530", Offset = "0x6E0930", VA = "0x1806E1530", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool CFLBJAOIJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0xAD41A0", Offset = "0xAD35A0", VA = "0x180AD41A0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool CGHGEFKIEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x777520", Offset = "0x776920", VA = "0x180777520", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool JPNKMIMLPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0xCF5350", Offset = "0xCF4750", VA = "0x180CF5350", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public EBGEGLGLHEI BMELAMIAMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6E0", Offset = "0x6C9AE0", VA = "0x1806CA6E0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x875110", Offset = "0x874510", VA = "0x180875110", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public INKGBOPGLAH ANJHOFGNHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x845B30", Offset = "0x844F30", VA = "0x180845B30", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8C0", Offset = "0x7CDCC0", VA = "0x1807CE8C0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public float DBEIDHEFFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x19134A0", Offset = "0x19128A0", VA = "0x1819134A0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x18CABC0", Offset = "0x18C9FC0", VA = "0x1818CABC0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 DECNMOIHGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x39C0960", Offset = "0x39BFD60", VA = "0x1839C0960", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x39BFDF0", Offset = "0x39BF1F0", VA = "0x1839BFDF0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 NOKDFHICMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x25F1FF0", Offset = "0x25F13F0", VA = "0x1825F1FF0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x25EF000", Offset = "0x25EE400", VA = "0x1825EF000", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 OCAOFDKLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x25F2010", Offset = "0x25F1410", VA = "0x1825F2010", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x25EFB80", Offset = "0x25EEF80", VA = "0x1825EFB80", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 ADAGFBPLONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x6C8320", Offset = "0x6C7720", VA = "0x1806C8320", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public bool NPFHJJBDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x9CA600", Offset = "0x9C9A00", VA = "0x1809CA600", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public bool PNPHIGEIMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0xDB7F70", Offset = "0xDB7370", VA = "0x180DB7F70", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public bool INGLGNBAOLO
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xDB7F60", Offset = "0xDB7360", VA = "0x180DB7F60", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public bool OPOGDDHDOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x120E070", Offset = "0x120D470", VA = "0x18120E070", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 NADFFGFBCFP
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1299DA0", Offset = "0x12991A0", VA = "0x181299DA0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 FCAFMICJDPP
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1331610", Offset = "0x1330A10", VA = "0x181331610", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Vector3 NBHBELAIBDB
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8320", Offset = "0x6C7720", VA = "0x1806C8320", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Vector3 NEBCIADIING
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x25F20D0", Offset = "0x25F14D0", VA = "0x1825F20D0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public float DGNOOEIGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xB5C3E0", Offset = "0xB5B7E0", VA = "0x180B5C3E0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float HEPAGCBLJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xAF43C0", Offset = "0xAF37C0", VA = "0x180AF43C0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 LMJCLPIBEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x6C8320", Offset = "0x6C7720", VA = "0x1806C8320", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion GKPDPMCDGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x6D31D0", Offset = "0x6D25D0", VA = "0x1806D31D0", Slot = "44")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public float PPGDDPLBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xAF43C0", Offset = "0xAF37C0", VA = "0x180AF43C0", Slot = "46")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float KMCPMIOLLOM
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xAF43C0", Offset = "0xAF37C0", VA = "0x180AF43C0", Slot = "48")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool IEHOHDHFOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "51")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool IHIDHEMMEAG
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CJAGCCPNBHO KDPBDNOOOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "52")]
		get
		{
			return default(CJAGCCPNBHO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool NNGCGJNPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1063DE0", Offset = "0x10631E0", VA = "0x181063DE0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Transform LLDFEFLPEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x7CA9E0", Offset = "0x7C9DE0", VA = "0x1807CA9E0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Transform PLHBFGAGLJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0xA18820", Offset = "0xA17C20", VA = "0x180A18820", Slot = "56")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 GABFGMFOOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x6C8320", Offset = "0x6C7720", VA = "0x1806C8320", Slot = "57")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float NFPKDNBCCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xAF43C0", Offset = "0xAF37C0", VA = "0x180AF43C0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float EDFAOBJKHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xAF43C0", Offset = "0xAF37C0", VA = "0x180AF43C0", Slot = "61")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "62")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion JLHJOCIFNIF
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x21D9530", Offset = "0x21D8930", VA = "0x1821D9530", Slot = "63")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public Vector3 MHKILGKADHG
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x6C8320", Offset = "0x6C7720", VA = "0x1806C8320", Slot = "65")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public Quaternion MIIEKLEEEMM
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x21D9530", Offset = "0x21D8930", VA = "0x1821D9530", Slot = "67")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public RigidbodyConstraints BLKADDBBOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "69")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public bool KALNOEALNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "71")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "72")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public CollisionDetectionMode IAMKOICFOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "73")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool ENBBKGECCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xCE7050", Offset = "0xCE6450", VA = "0x180CE7050", Slot = "75")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event EDIBFGHGGCA LCINONPFDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event EDIBFGHGGCA AEIOOPKGCAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event ACIELCLFAEN GLHDOLCKNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "85")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "86")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event EDIBFGHGGCA ADNHDJAIKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "88")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "89")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event EDIBFGHGGCA MLANLPOEPNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "108")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "109")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event EDIBFGHGGCA KPKPOEOAKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<MGNDJKECDKI, MGNDJKECDKI> AKEAABLCGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event EDIBFGHGGCA DIDLCNJHPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event EDIBFGHGGCA EALFLPLHJKO
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "125")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "126")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "76")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "77")]
	public void NLGOPKLJAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "78")]
	public void BLFLGDGOFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "79")]
	public void KENKHKBKEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "80")]
	public void IBNFJMIBNMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "141")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "87")]
	public void NPKNFKDMNIH(ILPKGDCLANM FPLJCBGEJAP, bool IFGMNFNELBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "90")]
	public void DCDDGAENFBD(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "91")]
	public void IJHDNPOHOGP(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6C8320", Offset = "0x6C7720", VA = "0x1806C8320", Slot = "92")]
	public Vector3 NFEHGJFPFGI(Vector3 GAGJBCNBONM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6C8320", Offset = "0x6C7720", VA = "0x1806C8320", Slot = "93")]
	public Vector3 BMFAGCHKKGB(Vector3 HJHGPEHMJHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "94")]
	public void DPEFKKCHLHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "95")]
	public void HKHMPMLAFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "96")]
	public void MKACKJBHFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "97")]
	public void DAHIGAIEIHL(Vector3 JGLKMMBAANF, Vector3 CGGAGNJAJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "98")]
	public void DHMMJCMENIL(Vector3 JHIGCONLFIL, Vector3 HFPOKJMMMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "99")]
	public void CKNMFLEDJLC(Vector3 DKCFLDFLDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "100")]
	public void CEJGEKHJMLG(DECKJPMKMOF PBPIIFNFGMJ, Vector3 KPDDBGLPIPH, float JFKBEMOFNCC, float JDPJMACMKOO = 8f, float BGOCILFMLAJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "101")]
	public void CLFDNPJGLDL(KNHPIJHAJOD PBGBCGCEMBN, Vector3 AFDDLCHPJJF, float NPLCIBKJLLM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "102")]
	public void LDOJANPFHBD(KNHPIJHAJOD PBGBCGCEMBN, Vector3 GCFIGFMOIAL, float FJKGBGGIOMN = 7f, float CIHKPDDBHIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x6C8320", Offset = "0x6C7720", VA = "0x1806C8320", Slot = "103")]
	public Vector3 CNDCONBFANC(Vector3 FPLJCBGEJAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8320", Offset = "0x6C7720", VA = "0x1806C8320", Slot = "104")]
	public Vector3 KGFENKABDKJ(Vector3 FPLJCBGEJAP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "105")]
	public void MDCDACBDOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "106")]
	public void HDKKHDLJCBD(ILPKGDCLANM OOOHDEPMGEH, object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "107")]
	public void EDEKAPKDAHN(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "110")]
	public void FIDFLJGKPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "111")]
	public void JFGCPDOODIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "112")]
	public void LJINPIHKMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "115")]
	public bool NACOMAKPFBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "116")]
	public void HIDPENPEHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930", Slot = "121")]
	public IDisposable PAAMLEOMHIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "122")]
	public void PMNFOIDFING(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "123")]
	public void IJEHIOABNMP(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "124")]
	public void KKMLFIEGHLB(object JCHAGIDHJIB, bool IJHPBMOOGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "127")]
	public void NIAKJNPHHHF(Vector3 GDMOLPCGLJL, Quaternion NGMHNDELPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "128")]
	public void MJMAFAAGDNC(Vector3 EKAJOFOCODC, Quaternion MNLPDACKEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "129")]
	public bool NFACIKGNEPL(float PAGNPNMCLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "130")]
	public void DIIDEFIFECE(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "131")]
	public void GJMDDKPKLLD(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "132")]
	public void HDOOPNPHDOG(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "133")]
	public void ODNLFMCNIMM(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "134")]
	public void IBDPMHJLAOJ(Vector3 MGJBBFOJNFN, ForceMode ACLPJPMEMPD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "135")]
	public void FEGGFDIPJGD(Vector3 MGJBBFOJNFN, Vector3 KGJPEGOHADA, ForceMode ACLPJPMEMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "136")]
	public void NHPOGNDMGCD(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "137")]
	public void OOHCEIMBKPD(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x5753700", Offset = "0x5752B00", VA = "0x185753700", Slot = "138")]
	public bool GKLGDFBHMGO(Vector3 GPCLDFNJCPC, out RaycastHit CLAJPNPLGKF, float DODLNOOJAAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "139")]
	public void MLNJLBLGJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public AJPEEJAHMPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class OBCILHHKOMD : OHCGFGEMIAI, ENMGKLMFFLD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	internal KJNCFICFIIE LJGIOCJLACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	internal KJFHICGMDLJ BAKPEDBKNBE;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5772540", Offset = "0x5771940", VA = "0x185772540")]
	public OBCILHHKOMD(GameObject CEPEJEHMODM, RigidbodyEx PLOGKPJMLPD, OJKFOMAKLHL NBEGMMIIDMD, in AJCCCMFGALH MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5771EA0", Offset = "0x57712A0", VA = "0x185771EA0", Slot = "142")]
	protected override void LCJPMHAPAHD(OJKFOMAKLHL NBEGMMIIDMD, AJCCCMFGALH MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5771D10", Offset = "0x5771110", VA = "0x185771D10", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x57721F0", Offset = "0x57715F0", VA = "0x1857721F0", Slot = "145")]
	public void OEBJGEDHHIB(HCFBDPBEMPC AJNJONIBFJA, HCFBDPBEMPC IOHONDKAJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x5772130", Offset = "0x5771530", VA = "0x185772130", Slot = "146")]
	public void NHBIHICHPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x57722C0", Offset = "0x57716C0", VA = "0x1857722C0", Slot = "147")]
	public void OMLGGMHGOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5772380", Offset = "0x5771780", VA = "0x185772380", Slot = "148")]
	public void PEMMOGJEFHM(bool IADBGGBPGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x57723E0", Offset = "0x57717E0", VA = "0x1857723E0", Slot = "149")]
	public bool PPEJNLOLNLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "144")]
	public override void IBNFJMIBNMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class KDJLKJLFLOM
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x576C810", Offset = "0x576BC10", VA = "0x18576C810")]
	public static OHCGFGEMIAI NCLENJEGECM(this ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface NMBOBBPFJII : ADOGOEHBGDB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFOBOCNNGKJ(ILPKGDCLANM ANLOJMEANJA);

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADHHJICHDIC(ILPKGDCLANM ANLOJMEANJA);

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGCCDDOIMHC(ILPKGDCLANM AEFPCOFIJNP);

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CMAOMHAJMJN(ILPKGDCLANM AEFPCOFIJNP);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface JBNBJBBPPAP : CIIPJDJKCCC
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	global::ILLCLDGOCBE<ILPKGDCLANM> DBIAAJGIGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	ILPKGDCLANM GKDOADEHHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface AFFABMCDMFE : JIEGAMCNMJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) PNACOPOAKOE(Rigidbody HJJDCBPFLHO);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface MNLONBJIHIP : EGCPDEMCLIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	PhotonView EFHJHBMGCMB
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class KFGJGEIIOKK : BHPPDHHNLNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly OHCGFGEMIAI ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private CollisionDetectionMode EGLKBFANDMD;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private Rigidbody AHDPHMEMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5762DF0", Offset = "0x57621F0", VA = "0x185762DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public CollisionDetectionMode IAMKOICFOLP
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x576C860", Offset = "0x576BC60", VA = "0x18576C860", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x576C9F0", Offset = "0x576BDF0", VA = "0x18576C9F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x5761440", Offset = "0x5760840", VA = "0x185761440")]
	public KFGJGEIIOKK(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x576CD00", Offset = "0x576C100", VA = "0x18576CD00", Slot = "6")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x576C970", Offset = "0x576BD70", VA = "0x18576C970", Slot = "9")]
	public void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x576CE30", Offset = "0x576C230", VA = "0x18576CE30", Slot = "7")]
	public void OLKKMPKLMOH(bool OJFDJHJECDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x576CE20", Offset = "0x576C220", VA = "0x18576CE20", Slot = "8")]
	public void NHNABIMKNII(bool OJFDJHJECDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x576CA60", Offset = "0x576BE60", VA = "0x18576CA60", Slot = "10")]
	public bool GKLGDFBHMGO(Vector3 GPCLDFNJCPC, out RaycastHit CLAJPNPLGKF, float DODLNOOJAAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x576CBD0", Offset = "0x576BFD0", VA = "0x18576CBD0")]
	private void JFELFPNDNNK(bool OJFDJHJECDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class CKNBAIEJABO : OJLHAIBOJPN, IDisposable, KBOBIGJEJBE
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public const int MLOAJKEIFGJ = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly OHCGFGEMIAI ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private CJAGCCPNBHO BOFHILDOAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private PHNOFPCAHIJ JCPOHCFAOJL;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public CJAGCCPNBHO KDPBDNOOOJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x575AE60", Offset = "0x575A260", VA = "0x18575AE60", Slot = "6")]
		get
		{
			return default(CJAGCCPNBHO);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x575B0F0", Offset = "0x575A4F0", VA = "0x18575B0F0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	private Transform HPOIIANAAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x575B4A0", Offset = "0x575A8A0", VA = "0x18575B4A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<MGNDJKECDKI, MGNDJKECDKI> AKEAABLCGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x575AFA0", Offset = "0x575A3A0", VA = "0x18575AFA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x575B4C0", Offset = "0x575A8C0", VA = "0x18575B4C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x575B560", Offset = "0x575A960", VA = "0x18575B560")]
	public CKNBAIEJABO(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x575B1C0", Offset = "0x575A5C0", VA = "0x18575B1C0", Slot = "8")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x575B040", Offset = "0x575A440", VA = "0x18575B040", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x575B090", Offset = "0x575A490", VA = "0x18575B090", Slot = "11")]
	private void HABEEBLGDAH(MGNDJKECDKI GJLONDIJOCN, MGNDJKECDKI HAJFBLJEELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "12")]
	private void IPMBHGBEDNF(bool HNLCKLOEHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class LHLINHGCOJP : IBBIOIIEBJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly OHCGFGEMIAI ANLOJMEANJA;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Rigidbody AHDPHMEMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x5762DF0", Offset = "0x57621F0", VA = "0x185762DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private bool NNGCGJNPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x57668C0", Offset = "0x5765CC0", VA = "0x1857668C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool CFLBJAOIJMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x575F450", Offset = "0x575E850", VA = "0x18575F450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private ILPKGDCLANM DOOCCGCNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x5770A70", Offset = "0x576FE70", VA = "0x185770A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x5761440", Offset = "0x5760840", VA = "0x185761440")]
	public LHLINHGCOJP(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x5770AD0", Offset = "0x576FED0", VA = "0x185770AD0", Slot = "4")]
	public void IBDPMHJLAOJ(Vector3 MGJBBFOJNFN, ForceMode ACLPJPMEMPD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x5771290", Offset = "0x5770690", VA = "0x185771290")]
	private void POOOPLPPMCF(Vector3 MGJBBFOJNFN, ForceMode ACLPJPMEMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x57707D0", Offset = "0x576FBD0", VA = "0x1857707D0", Slot = "5")]
	public void FEGGFDIPJGD(Vector3 MGJBBFOJNFN, Vector3 KGJPEGOHADA, ForceMode ACLPJPMEMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x5770C30", Offset = "0x5770030", VA = "0x185770C30", Slot = "6")]
	public void NHPOGNDMGCD(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x5771010", Offset = "0x5770410", VA = "0x185771010")]
	private void PIOAAKBALPI(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x5770D90", Offset = "0x5770190", VA = "0x185770D90", Slot = "7")]
	public void OOHCEIMBKPD(Vector3 FGAAOKBOGGE, ForceMode ACLPJPMEMPD = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class FBANNGFGCGB : OAAAINOINDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly OHCGFGEMIAI ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool CMHLOPHGHPJ;

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public bool IEHOHDHFOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x85F6B0", Offset = "0x85EAB0", VA = "0x18085F6B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x5761330", Offset = "0x5760730", VA = "0x185761330", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x5761440", Offset = "0x5760840", VA = "0x185761440")]
	public FBANNGFGCGB(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x5761290", Offset = "0x5760690", VA = "0x185761290", Slot = "6")]
	public void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x57612C0", Offset = "0x57606C0", VA = "0x1857612C0", Slot = "7")]
	public void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class AFENGEPDNPG : NMBOBBPFJII, ADOGOEHBGDB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly ILPKGDCLANM ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly List<ILPKGDCLANM> GNLABAOMILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private ILPKGDCLANM ALLJDBGIIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private ILPKGDCLANM CNDFBGEJOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Transform LFEBHKFGHLH;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private Transform KJAFIIABLMD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x5751BF0", Offset = "0x5750FF0", VA = "0x185751BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public ILPKGDCLANM DOOCCGCNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x75A820", Offset = "0x759C20", VA = "0x18075A820", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x5752950", Offset = "0x5751D50", VA = "0x185752950", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public ILPKGDCLANM COIMCDBNODG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x845B40", Offset = "0x844F40", VA = "0x180845B40", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IReadOnlyList<ILPKGDCLANM> MKGCJNINDKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x845B30", Offset = "0x844F30", VA = "0x180845B30", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event EDIBFGHGGCA LCINONPFDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x5751760", Offset = "0x5750B60", VA = "0x185751760", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x5751E30", Offset = "0x5751230", VA = "0x185751E30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event EDIBFGHGGCA AEIOOPKGCAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x5751C50", Offset = "0x5751050", VA = "0x185751C50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x5751B50", Offset = "0x5750F50", VA = "0x185751B50", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event ACIELCLFAEN GLHDOLCKNJG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x5750DC0", Offset = "0x57501C0", VA = "0x185750DC0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x5751CF0", Offset = "0x57510F0", VA = "0x185751CF0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action LCDAKJJPPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x57510B0", Offset = "0x57504B0", VA = "0x1857510B0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x57516C0", Offset = "0x5750AC0", VA = "0x1857516C0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action PIEPJLKMPBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x5752810", Offset = "0x5751C10", VA = "0x185752810", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x5751D90", Offset = "0x5751190", VA = "0x185751D90", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<ILPKGDCLANM> EMGAIKGILMC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x57515A0", Offset = "0x57509A0", VA = "0x1857515A0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x5751AB0", Offset = "0x5750EB0", VA = "0x185751AB0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<ILPKGDCLANM> DBHPMCGPIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x5751F70", Offset = "0x5751370", VA = "0x185751F70", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x5752770", Offset = "0x5751B70", VA = "0x185752770", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action BDCLBCCHGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x5752010", Offset = "0x5751410", VA = "0x185752010", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x5751150", Offset = "0x5750550", VA = "0x185751150", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<ILPKGDCLANM> MMMCLOIFIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x5752960", Offset = "0x5751D60", VA = "0x185752960", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x5751ED0", Offset = "0x57512D0", VA = "0x185751ED0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x5752A00", Offset = "0x5751E00", VA = "0x185752A00")]
	public AFENGEPDNPG(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x5751640", Offset = "0x5750A40", VA = "0x185751640", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x57521E0", Offset = "0x57515E0", VA = "0x1857521E0", Slot = "30")]
	public void NPKNFKDMNIH(ILPKGDCLANM HKBAAFCKIFC, bool IFGMNFNELBJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5750E60", Offset = "0x5750260", VA = "0x185750E60", Slot = "6")]
	public void AGCCDDOIMHC(ILPKGDCLANM AEFPCOFIJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x57511F0", Offset = "0x57505F0", VA = "0x1857511F0", Slot = "7")]
	public void CMAOMHAJMJN(ILPKGDCLANM AEFPCOFIJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x57528B0", Offset = "0x5751CB0", VA = "0x1857528B0", Slot = "4")]
	public void OFOBOCNNGKJ(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x5750D20", Offset = "0x5750120", VA = "0x185750D20", Slot = "5")]
	public void ADHHJICHDIC(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x5751930", Offset = "0x5750D30", VA = "0x185751930")]
	private void HEMDGLJLLGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x5750CE0", Offset = "0x57500E0", VA = "0x185750CE0")]
	private void ACBEFEDBMGL(ILPKGDCLANM AEFPCOFIJNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x5751450", Offset = "0x5750850", VA = "0x185751450")]
	private void DOCPAPNCECP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x5751800", Offset = "0x5750C00", VA = "0x185751800")]
	private void FLIGOGOGPEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x57520B0", Offset = "0x57514B0", VA = "0x1857520B0")]
	private void NJBAPIKGECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x57519C0", Offset = "0x5750DC0", VA = "0x1857519C0")]
	[CompilerGenerated]
	private object HFLDPNAANJF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class MIDPFEIANHN
{
	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x5771510", Offset = "0x5770910", VA = "0x185771510")]
	public static NMBOBBPFJII NIAOPJFMOLB(this ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class JMBIPKLKLML : JBNBJBBPPAP, CIIPJDJKCCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly OHCGFGEMIAI ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly global::ILLCLDGOCBE<ILPKGDCLANM> EMEDNGNPDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool PKHIMNMNJEP;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public global::ILLCLDGOCBE<ILPKGDCLANM> DBIAAJGIGAE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Vector3 NADFFGFBCFP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x576C2B0", Offset = "0x576B6B0", VA = "0x18576C2B0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Vector3 FCAFMICJDPP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x576C0E0", Offset = "0x576B4E0", VA = "0x18576C0E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private Vector3 OCAOFDKLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x576BBB0", Offset = "0x576AFB0", VA = "0x18576BBB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public ILPKGDCLANM GKDOADEHHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x576BC90", Offset = "0x576B090", VA = "0x18576BC90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x576C6A0", Offset = "0x576BAA0", VA = "0x18576C6A0")]
	public JMBIPKLKLML(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x576C2E0", Offset = "0x576B6E0", VA = "0x18576C2E0", Slot = "8")]
	public void LLCFANBFIPP(ILPKGDCLANM CNDFBGEJOLI, object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x576BB50", Offset = "0x576AF50", VA = "0x18576BB50", Slot = "9")]
	public void BJEODEMDDGM(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x576C350", Offset = "0x576B750", VA = "0x18576C350")]
	private Vector3 MOAHKNMINPI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x576BD40", Offset = "0x576B140", VA = "0x18576BD40")]
	private void GFDOGHNMNBB(ILPKGDCLANM ODGFKICDNLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class HPKLNOJHGGM
{
	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x5764840", Offset = "0x5763C40", VA = "0x185764840")]
	public static JBNBJBBPPAP MAEFCBNMPCO(this ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class CLAJGBCMDDF : AFFABMCDMFE, JIEGAMCNMJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly OHCGFGEMIAI ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly OverridableVector3 JKJKCACHMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly OverridableVector3 PFMGHEAKHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float IBIBANLMLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private float CDPAONMBAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Vector3 DBBHDGCNJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Vector3? JCICHJCCDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Quaternion? JEKGPCGHMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool BIJBCMAPFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool PJHNLGPHFFE;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public Vector3 NBHBELAIBDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x1DD56D0", Offset = "0x1DD4AD0", VA = "0x181DD56D0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x575C290", Offset = "0x575B690", VA = "0x18575C290", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public Vector3 NEBCIADIING
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x575CC30", Offset = "0x575C030", VA = "0x18575CC30", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public float DGNOOEIGHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F86B0", Offset = "0x7F7AB0", VA = "0x1807F86B0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x575C070", Offset = "0x575B470", VA = "0x18575C070")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public float HEPAGCBLJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FC0", Offset = "0x8D33C0", VA = "0x1808D3FC0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x575C190", Offset = "0x575B590", VA = "0x18575C190", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public Vector3 LMJCLPIBEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x575B830", Offset = "0x575AC30", VA = "0x18575B830", Slot = "13")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x575C460", Offset = "0x575B860", VA = "0x18575C460", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Quaternion GKPDPMCDGGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x575CD30", Offset = "0x575C130", VA = "0x18575CD30", Slot = "15")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x575B690", Offset = "0x575AA90", VA = "0x18575B690", Slot = "16")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody AHDPHMEMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x575C2B0", Offset = "0x575B6B0", VA = "0x18575C2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event EDIBFGHGGCA HEGPDCDAOAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x575B5F0", Offset = "0x575A9F0", VA = "0x18575B5F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x575BD20", Offset = "0x575B120", VA = "0x18575BD20", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x575DFC0", Offset = "0x575D3C0", VA = "0x18575DFC0")]
	public CLAJGBCMDDF(ILPKGDCLANM ANLOJMEANJA, in AJCCCMFGALH MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x575BEB0", Offset = "0x575B2B0", VA = "0x18575BEB0", Slot = "18")]
	public void FIDFLJGKPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x575C1B0", Offset = "0x575B5B0", VA = "0x18575C1B0", Slot = "17")]
	public void JFGCPDOODIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x575B9A0", Offset = "0x575ADA0", VA = "0x18575B9A0", Slot = "20")]
	public void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x575BA80", Offset = "0x575AE80", VA = "0x18575BA80", Slot = "21")]
	public void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x575C600", Offset = "0x575BA00", VA = "0x18575C600", Slot = "19")]
	public void LJINPIHKMGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x575C770", Offset = "0x575BB70", VA = "0x18575C770", Slot = "22")]
	public void MLNJLBLGJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x575C290", Offset = "0x575B690", VA = "0x18575C290")]
	private void OCKGBEDIOBF(Vector3 FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x575BDC0", Offset = "0x575B1C0", VA = "0x18575BDC0")]
	private Vector3 FFKMKNPIIDO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x575C070", Offset = "0x575B470", VA = "0x18575C070")]
	private void GPMNBNEDCPK(float FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x575C190", Offset = "0x575B590", VA = "0x18575C190")]
	private void JCGIGDNDJOK(float FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x575DE40", Offset = "0x575D240", VA = "0x18575DE40")]
	private Vector3 POAPPABNILC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x575C460", Offset = "0x575B860", VA = "0x18575C460")]
	private void PLAEAPJDCBO(Vector3 FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x575C300", Offset = "0x575B700", VA = "0x18575C300")]
	private Quaternion LDDGFCNKCBH()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x575B690", Offset = "0x575AA90", VA = "0x18575B690")]
	private void BHHKJIJCGJK(Quaternion FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x575DD60", Offset = "0x575D160", VA = "0x18575DD60")]
	public void PNACOPOAKOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x575CEA0", Offset = "0x575C2A0", VA = "0x18575CEA0", Slot = "4")]
	public (float, Vector3) PNACOPOAKOE(Rigidbody HJJDCBPFLHO)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class BHBJNNKCHIH
{
	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x5753780", Offset = "0x5752B80", VA = "0x185753780")]
	public static AFFABMCDMFE LAJJIBJCDBJ(this ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class JECKBEFLDAI : ADFLIEJPGFD
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private const string JFEEHPGBIFL = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly OHCGFGEMIAI ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly DIIDNNFFODO FOPIDAGPODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly HIHNKPGEDDE NGANBKDNDFJ;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool GGCHCLPEMCO
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x1BF3FD0", Offset = "0x1BF33D0", VA = "0x181BF3FD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public HIHNKPGEDDE NOJLEBJKKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x764360", Offset = "0x763760", VA = "0x180764360", Slot = "5")]
		get
		{
			return default(HIHNKPGEDDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x5767420", Offset = "0x5766820", VA = "0x185767420")]
	public JECKBEFLDAI(ILPKGDCLANM ANLOJMEANJA, in AJCCCMFGALH MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x57672D0", Offset = "0x57666D0", VA = "0x1857672D0", Slot = "6")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x5766FC0", Offset = "0x57663C0", VA = "0x185766FC0")]
	private bool GONKCFFJNPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x5766F90", Offset = "0x5766390", VA = "0x185766F90", Slot = "7")]
	public void GFMOKLHHCDB(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x57672A0", Offset = "0x57666A0", VA = "0x1857672A0", Slot = "8")]
	public void MGCLAOAADOC(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x5767060", Offset = "0x5766460", VA = "0x185767060", Slot = "11")]
	public void IFNGLGFDCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x5767190", Offset = "0x5766590", VA = "0x185767190")]
	private void LOCHMOGKNAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x5766E10", Offset = "0x5766210", VA = "0x185766E10")]
	private void EHJDFJBNBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x57673A0", Offset = "0x57667A0", VA = "0x1857673A0", Slot = "10")]
	public void NFPKFACOBKP(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x57673E0", Offset = "0x57667E0", VA = "0x1857673E0", Slot = "9")]
	public void PIKIAPJONJN(ILPKGDCLANM ANLOJMEANJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class JICNCFLDBJK : MCFFBCKBDAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly OHCGFGEMIAI ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly DIIDNNFFODO BCGGFABLLMI;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool NNGCGJNPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x5768680", Offset = "0x5767A80", VA = "0x185768680", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<object> GJGGGEBIAIA
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x57685C0", Offset = "0x57679C0", VA = "0x1857685C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event EDIBFGHGGCA JFCBDEPNNFP
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x57684C0", Offset = "0x57678C0", VA = "0x1857684C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x57685E0", Offset = "0x57679E0", VA = "0x1857685E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5768820", Offset = "0x5767C20", VA = "0x185768820")]
	public JICNCFLDBJK(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x5768560", Offset = "0x5767960", VA = "0x185768560", Slot = "11")]
	public IDisposable PAAMLEOMHIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x5768740", Offset = "0x5767B40", VA = "0x185768740", Slot = "8")]
	public void PMNFOIDFING(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x57683B0", Offset = "0x57677B0", VA = "0x1857683B0", Slot = "9")]
	public void IJEHIOABNMP(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x57683C0", Offset = "0x57677C0", VA = "0x1857683C0", Slot = "10")]
	public void KKMLFIEGHLB(object JCHAGIDHJIB, bool IJHPBMOOGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5768300", Offset = "0x5767700", VA = "0x185768300", Slot = "12")]
	public void AOAIBKKGCDK(Rigidbody DFDJIBDBDBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5768380", Offset = "0x5767780", VA = "0x185768380", Slot = "13")]
	public void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class DACKEAKGFGN : MNLONBJIHIP, EGCPDEMCLIG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly OHCGFGEMIAI ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private PhotonView MGBGBEHJPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool GDJMPEIMAKL;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public PhotonView EFHJHBMGCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool CGHGEFKIEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x575E7C0", Offset = "0x575DBC0", VA = "0x18575E7C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool JPNKMIMLPNM
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x8A81C0", Offset = "0x8A75C0", VA = "0x1808A81C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event EDIBFGHGGCA ADNHDJAIKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x575EAC0", Offset = "0x575DEC0", VA = "0x18575EAC0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x575E220", Offset = "0x575D620", VA = "0x18575E220", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x575ECE0", Offset = "0x575E0E0", VA = "0x18575ECE0")]
	public DACKEAKGFGN(ILPKGDCLANM ANLOJMEANJA, in AJCCCMFGALH MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x575E970", Offset = "0x575DD70", VA = "0x18575E970", Slot = "9")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x575E2C0", Offset = "0x575D6C0", VA = "0x18575E2C0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x575E090", Offset = "0x575D490", VA = "0x18575E090", Slot = "10")]
	public void CIGLGJDDJMB(ILPKGDCLANM CNDFBGEJOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x575E7E0", Offset = "0x575DBE0", VA = "0x18575E7E0", Slot = "11")]
	public void HGGPHOKEFDD(ILPKGDCLANM CNDFBGEJOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x575EB60", Offset = "0x575DF60", VA = "0x18575EB60")]
	private void OLNEFICPOKJ(PhotonView FIONCGDKAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x575E3D0", Offset = "0x575D7D0", VA = "0x18575E3D0")]
	private void FICOABAIBOO(RigidbodyEx LADCCMEPEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x575E540", Offset = "0x575D940", VA = "0x18575E540")]
	private void FMHOCGCEJDB(PhotonView KIOKLPICDOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class JGABGPKOJPP
{
	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x5767510", Offset = "0x5766910", VA = "0x185767510")]
	public static MNLONBJIHIP ENHKKOOLCLG(this ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class PPPFHBBMKAA : CBOKBEGMIKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly OHCGFGEMIAI ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private RigidbodyConstraints FPIDJKEBJEI;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public bool KALNOEALNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xB597C0", Offset = "0xB58BC0", VA = "0x180B597C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x875120", Offset = "0x874520", VA = "0x180875120", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool OMLANDBOKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xB597B0", Offset = "0xB58BB0", VA = "0x180B597B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xB59AB0", Offset = "0xB58EB0", VA = "0x180B59AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public RigidbodyConstraints BLKADDBBOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x705BA0", Offset = "0x704FA0", VA = "0x180705BA0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x64B5E10", Offset = "0x64B5210", VA = "0x1864B5E10", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x64B5EF0", Offset = "0x64B52F0", VA = "0x1864B5EF0")]
	public PPPFHBBMKAA(ILPKGDCLANM ANLOJMEANJA, in AJCCCMFGALH MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x64B5DB0", Offset = "0x64B51B0", VA = "0x1864B5DB0", Slot = "9")]
	public void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x64B5DE0", Offset = "0x64B51E0", VA = "0x1864B5DE0", Slot = "10")]
	public void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class NKEBOAMMJBB : NHKIFEBOFCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly ILPKGDCLANM ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float HEMOAGALFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float PGKLJIMOLEL;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public float PPGDDPLBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x85BD40", Offset = "0x85B140", VA = "0x18085BD40", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x5771B30", Offset = "0x5770F30", VA = "0x185771B30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public float KMCPMIOLLOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x9F1C80", Offset = "0x9F1080", VA = "0x1809F1C80", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x5771C00", Offset = "0x5771000", VA = "0x185771C00", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x5771CD0", Offset = "0x57710D0", VA = "0x185771CD0")]
	public NKEBOAMMJBB(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x5771A40", Offset = "0x5770E40", VA = "0x185771A40", Slot = "8")]
	public void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x5771A90", Offset = "0x5770E90", VA = "0x185771A90", Slot = "9")]
	public void DGKPNIDGDPJ(Rigidbody BBOHKHOPNCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class JGOLCDCHNKE : KOMDCHOGFGK
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private const int IPBIGAOHPHO = 10;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private const float ELOICAAPEML = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const float MMPKDAEDLNH = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private const float GOMDJPNPGBM = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly OHCGFGEMIAI ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool FBLIMELCEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool FKMPNAMOLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int NJHEOBDPBHL;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	private Rigidbody AHDPHMEMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x575C2B0", Offset = "0x575B6B0", VA = "0x18575C2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	private bool BAAKFPABGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x5767B50", Offset = "0x5766F50", VA = "0x185767B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool ENBBKGECCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x5768250", Offset = "0x5767650", VA = "0x185768250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private ILPKGDCLANM DOOCCGCNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x5767BF0", Offset = "0x5766FF0", VA = "0x185767BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool CFLBJAOIJMM
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x5767C50", Offset = "0x5767050", VA = "0x185767C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event EDIBFGHGGCA KPKPOEOAKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x5767D50", Offset = "0x5767150", VA = "0x185767D50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x5767900", Offset = "0x5766D00", VA = "0x185767900", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5768270", Offset = "0x5767670", VA = "0x185768270")]
	public JGOLCDCHNKE(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5768030", Offset = "0x5767430", VA = "0x185768030", Slot = "6")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5768020", Offset = "0x5767420", VA = "0x185768020", Slot = "8")]
	public void KKIECAKDELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x57680C0", Offset = "0x57674C0", VA = "0x1857680C0", Slot = "7")]
	public bool NACOMAKPFBJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x5767F80", Offset = "0x5767380", VA = "0x185767F80", Slot = "9")]
	public void KENKHKBKEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x5767CB0", Offset = "0x57670B0", VA = "0x185767CB0", Slot = "11")]
	public void HIDPENPEHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5768210", Offset = "0x5767610", VA = "0x185768210", Slot = "12")]
	public void PEMMOGJEFHM(bool IADBGGBPGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x57675D0", Offset = "0x57669D0", VA = "0x1857675D0", Slot = "10")]
	public void AIADGDGDDLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x57679A0", Offset = "0x5766DA0", VA = "0x1857679A0")]
	private bool CLKHHKKBPPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5767DF0", Offset = "0x57671F0", VA = "0x185767DF0")]
	private void JLLHDEAAMKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class GMJMMIJPGBO : NOKJHKJHDMG
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const string FKIKGLINABK = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly OHCGFGEMIAI ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly DIIDNNFFODO OPDLEJDGLCE;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Rigidbody AHDPHMEMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x762090", VA = "0x180762C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	private bool CFLBJAOIJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x575F450", Offset = "0x575E850", VA = "0x18575F450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5764600", Offset = "0x5763A00", VA = "0x185764600")]
	public GMJMMIJPGBO(ILPKGDCLANM ANLOJMEANJA, in AJCCCMFGALH MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5764520", Offset = "0x5763920", VA = "0x185764520", Slot = "5")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5763AF0", Offset = "0x5762EF0", VA = "0x185763AF0", Slot = "6")]
	public void HDOOPNPHDOG(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x57645D0", Offset = "0x57639D0", VA = "0x1857645D0", Slot = "7")]
	public void ODNLFMCNIMM(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x5763D20", Offset = "0x5763120", VA = "0x185763D20", Slot = "8")]
	public void KEOPHCFHNBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x5763B20", Offset = "0x5762F20", VA = "0x185763B20", Slot = "9")]
	public void IANPFGAPGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x5763970", Offset = "0x5762D70", VA = "0x185763970", Slot = "10")]
	public void EBMMJMCNPHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5764080", Offset = "0x5763480", VA = "0x185764080", Slot = "11")]
	public void LCNBPFHHODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5763610", Offset = "0x5762A10", VA = "0x185763610")]
	private void AHHPDDMBENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x57637C0", Offset = "0x5762BC0", VA = "0x1857637C0")]
	private void CGFJDDMOHPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class JIKCHPLAJBO : CFCPCALGPCF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly OHCGFGEMIAI ANLOJMEANJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly DIIDNNFFODO EIBDEOLMGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private float HCOJLIDODNN;

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public EBGEGLGLHEI BMELAMIAMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x963B10", Offset = "0x962F10", VA = "0x180963B10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public INKGBOPGLAH ANJHOFGNHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x81B670", Offset = "0x81AA70", VA = "0x18081B670", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public Vector3 OCAOFDKLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5769740", Offset = "0x5768B40", VA = "0x185769740", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x576B050", Offset = "0x576A450", VA = "0x18576B050", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public Vector3 DECNMOIHGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x5769E50", Offset = "0x5769250", VA = "0x185769E50", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x576B680", Offset = "0x576AA80", VA = "0x18576B680", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public Vector3 ADAGFBPLONM
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x576B550", Offset = "0x576A950", VA = "0x18576B550", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x576A0C0", Offset = "0x57694C0", VA = "0x18576A0C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public Vector3 NOKDFHICMLB
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x5769D60", Offset = "0x5769160", VA = "0x185769D60", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x5768A30", Offset = "0x5767E30", VA = "0x185768A30", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	public float DBEIDHEFFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x78F510", Offset = "0x78E910", VA = "0x18078F510", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x576A180", Offset = "0x5769580", VA = "0x18576A180", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public bool OPOGDDHDOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x2B9D920", Offset = "0x2B9CD20", VA = "0x182B9D920", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private IBBIOIIEBJO KEMDHJDNANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x258E8D0", Offset = "0x258DCD0", VA = "0x18258E8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	private bool ENBBKGECCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x575A300", Offset = "0x5759700", VA = "0x18575A300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x576B6B0", Offset = "0x576AAB0", VA = "0x18576B6B0")]
	public JIKCHPLAJBO(ILPKGDCLANM ANLOJMEANJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x5769860", Offset = "0x5768C60", VA = "0x185769860", Slot = "19")]
	public void MIJACFILAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x57698D0", Offset = "0x5768CD0", VA = "0x1857698D0", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x5768900", Offset = "0x5767D00", VA = "0x185768900", Slot = "28")]
	public void AOAIBKKGCDK(Rigidbody BBOHKHOPNCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x2309CE0", Offset = "0x23090E0", VA = "0x182309CE0", Slot = "20")]
	public void ENGBBGGKKNM(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x23096B0", Offset = "0x2308AB0", VA = "0x1823096B0", Slot = "31")]
	public void BIHLENLICGJ(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x576B370", Offset = "0x576A770", VA = "0x18576B370", Slot = "36")]
	public Vector3 NFEHGJFPFGI(Vector3 GAGJBCNBONM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x5768A60", Offset = "0x5767E60", VA = "0x185768A60", Slot = "35")]
	public Vector3 BMFAGCHKKGB(Vector3 HJHGPEHMJHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x5769860", Offset = "0x5768C60", VA = "0x185769860", Slot = "27")]
	public void DPEFKKCHLHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x5769F40", Offset = "0x5769340", VA = "0x185769F40", Slot = "25")]
	public void HKHMPMLAFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x576B330", Offset = "0x576A730", VA = "0x18576B330", Slot = "24")]
	public void MKACKJBHFEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x57694A0", Offset = "0x57688A0", VA = "0x1857694A0", Slot = "34")]
	public void DAHIGAIEIHL(Vector3 JGLKMMBAANF, Vector3 CGGAGNJAJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x57696E0", Offset = "0x5768AE0", VA = "0x1857696E0", Slot = "33")]
	public void DHMMJCMENIL(Vector3 JHIGCONLFIL, Vector3 HFPOKJMMMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5769070", Offset = "0x5768470", VA = "0x185769070", Slot = "32")]
	public void CKNMFLEDJLC(Vector3 DKCFLDFLDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5768C20", Offset = "0x5768020", VA = "0x185768C20", Slot = "22")]
	public void CEJGEKHJMLG(DECKJPMKMOF PBPIIFNFGMJ, Vector3 KPDDBGLPIPH, float JFKBEMOFNCC, float JDPJMACMKOO = 8f, float BGOCILFMLAJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x57691B0", Offset = "0x57685B0", VA = "0x1857691B0", Slot = "21")]
	public void CLFDNPJGLDL(KNHPIJHAJOD PBGBCGCEMBN, Vector3 AFDDLCHPJJF, float NPLCIBKJLLM = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x576AD80", Offset = "0x576A180", VA = "0x18576AD80", Slot = "23")]
	[Obsolete]
	public void LDOJANPFHBD(KNHPIJHAJOD PBGBCGCEMBN, Vector3 GCFIGFMOIAL, float FJKGBGGIOMN = 7f, float CIHKPDDBHIH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x57693E0", Offset = "0x57687E0", VA = "0x1857693E0", Slot = "30")]
	public Vector3 CNDCONBFANC(Vector3 LCOAJKBMAJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x576A360", Offset = "0x5769760", VA = "0x18576A360", Slot = "29")]
	public Vector3 KGFENKABDKJ(Vector3 FAJPHALHEOE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x576B110", Offset = "0x576A510", VA = "0x18576B110", Slot = "26")]
	public void MDCDACBDOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x576A180", Offset = "0x5769580", VA = "0x18576A180")]
	private void KALOANMLBLG(float FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5769F80", Offset = "0x5769380", VA = "0x185769F80")]
	private void IBEJIJHPKJL(Vector3 AFDDLCHPJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x5769C70", Offset = "0x5769070", VA = "0x185769C70")]
	private Vector3 EPJOMOKDEAJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x576A450", Offset = "0x5769850", VA = "0x18576A450")]
	private void KMMMFMAPJGO(Vector3 HJHGPEHMJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x576B240", Offset = "0x576A640", VA = "0x18576B240")]
	private Vector3 MEIMIOALBOA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5769930", Offset = "0x5768D30", VA = "0x185769930")]
	private void EBBALBPNJAI(Vector3 FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x576A780", Offset = "0x5769B80", VA = "0x18576A780")]
	private void LDKFDGFEFJE(Vector3 HJHGPEHMJHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x576A2A0", Offset = "0x57696A0", VA = "0x18576A2A0")]
	private void KDKFJKLJJEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class PMJGOFKAJEA : LEOOJPIMKPF
{
	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x64B5750", Offset = "0x64B4B50", VA = "0x1864B5750", Slot = "4")]
	public ADOGOEHBGDB AAIELKNPPKB(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x64B5C90", Offset = "0x64B5090", VA = "0x1864B5C90", Slot = "5")]
	public CFCPCALGPCF LHIONECBHJJ(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x64B57B0", Offset = "0x64B4BB0", VA = "0x1864B57B0", Slot = "6")]
	public CIIPJDJKCCC BAOIHDCCDIH(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x64B5D50", Offset = "0x64B5150", VA = "0x1864B5D50", Slot = "7")]
	public NHKIFEBOFCL MBIDMBEKDDD(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x64B59C0", Offset = "0x64B4DC0", VA = "0x1864B59C0", Slot = "8")]
	public KOMDCHOGFGK HMBJBMIALGL(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x64B5A20", Offset = "0x64B4E20", VA = "0x1864B5A20", Slot = "9")]
	public OJLHAIBOJPN HMIMPAILINC(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x64B5CF0", Offset = "0x64B50F0", VA = "0x1864B5CF0", Slot = "10")]
	public MCFFBCKBDAO LOFBBHEMFPA(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x64B56F0", Offset = "0x64B4AF0", VA = "0x1864B56F0", Slot = "11")]
	public IBBIOIIEBJO AAGLGOEMMIF(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x64B5A80", Offset = "0x64B4E80", VA = "0x1864B5A80", Slot = "12")]
	public BHPPDHHNLNA IBGFDICMLHJ(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x64B5880", Offset = "0x64B4C80", VA = "0x1864B5880", Slot = "13")]
	public OAAAINOINDE DMKJDDCFKFA(ILPKGDCLANM OOJCPNBFJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x64B5AE0", Offset = "0x64B4EE0", VA = "0x1864B5AE0")]
	public NOKJHKJHDMG IGAMCAFAOGF(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x64B58E0", Offset = "0x64B4CE0", VA = "0x1864B58E0")]
	public EGCPDEMCLIG IKEEEHBMMCL(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x64B5810", Offset = "0x64B4C10", VA = "0x1864B5810")]
	public ADFLIEJPGFD DBGOAOBHJAP(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x64B5950", Offset = "0x64B4D50", VA = "0x1864B5950")]
	public JIEGAMCNMJJ PMEEKEEKDHM(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x64B5B50", Offset = "0x64B4F50", VA = "0x1864B5B50")]
	public CBOKBEGMIKO KHDHIBGGPLP(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x64B5BE0", Offset = "0x64B4FE0", VA = "0x1864B5BE0", Slot = "19")]
	public ILPKGDCLANM KJPIJLPLBGM(RigidbodyEx ANLOJMEANJA, AJCCCMFGALH MPEBBGJJODN, OJKFOMAKLHL NBEGMMIIDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public PMJGOFKAJEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x64B5AE0", Offset = "0x64B4EE0", VA = "0x1864B5AE0", Slot = "14")]
	private NOKJHKJHDMG OAEIAMKHBEP(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x64B58E0", Offset = "0x64B4CE0", VA = "0x1864B58E0", Slot = "15")]
	private EGCPDEMCLIG ECLMHJBKPMI(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x64B5810", Offset = "0x64B4C10", VA = "0x1864B5810", Slot = "16")]
	private ADFLIEJPGFD IICOJKOINIF(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x64B5950", Offset = "0x64B4D50", VA = "0x1864B5950", Slot = "17")]
	private JIEGAMCNMJJ HHCKEBFMEEF(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x64B5B50", Offset = "0x64B4F50", VA = "0x1864B5B50", Slot = "18")]
	private CBOKBEGMIKO MOBILJLGBGN(ILPKGDCLANM OOJCPNBFJMK, in AJCCCMFGALH MPEBBGJJODN)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[Preserve]
	internal class _RRAssemblyIndex : AOMBDDGFEEO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7CADD0", Offset = "0x7CA1D0", VA = "0x1807CADD0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x64BC3A0", Offset = "0x64BB7A0", VA = "0x1864BC3A0", Slot = "6")]
		public sealed override void MOOHCJAEEBD(CDEIOGNPKKE KCKLDKHBENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x64BC310", Offset = "0x64BB710", VA = "0x1864BC310", Slot = "4")]
		public sealed override void IPAAHMOMIKO()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x5750540", Offset = "0x574F940", VA = "0x185750540")]
	private static string OGMGDCCGOFL(byte[] CFEKEMJOJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x57501F0", Offset = "0x574F5F0", VA = "0x1857501F0")]
	public static string DFBBLGFDDMJ(byte[] GJDBLJLIDDI, bool JLJMGNGGBON)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
