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
using RecRoom.CodeGen.Attributes;
using RecRoom.Utils.OverridableFields;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public delegate void MNAOAJBPDNO(RigidbodyEx OHKPEFFOBGF);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void LMCBABHNBJC(RigidbodyEx OHKPEFFOBGF, bool NHBKKIBCJBF = false);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum EHJPDGLKMMO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DIDNFNFEOHI
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum MCPIEBENNGH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[GAMIKAOGCAJ(typeof(KPNBDAHOHHH), new string[] { "Ignore", "Mock" })]
public class JCOMCNHGABE : KPNBDAHOHHH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool PAHACEGGGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C5270", Offset = "0x7C3A70", VA = "0x1807C5270", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
	public void JBKBOFEGICG(string MFCNDEMKIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "6")]
	public void ADKBKGEGEDC(RigidbodyEx FECPDCEPJMM, Action KJDOCFCKCJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x772210", Offset = "0x770A10", VA = "0x180772210", Slot = "7")]
	public KDNKFCKOHOL HGDFJAOCPMA(int ENAOMEPDJGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "8")]
	public void FOOFJGDDAPA(Vector3 OAOPKELIOCF, float JMLNLMLPBKH, Color NGHDCCDAAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public JCOMCNHGABE()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly DNJICJAPBOC OMOADMPNLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool CJAHAJBEDCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private POGGKJJBDBG IIJBDCEPNBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[MMBBKBIGDCH(JEAHCFCDLNC.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[MMBBKBIGDCH(JEAHCFCDLNC.SelfAndParent, true, false, false)]
		[SerializeField]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[FormerlySerializedAs("forceNoInterpolation")]
		[SerializeField]
		private DIDNFNFEOHI physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[HideInInspector]
		[SerializeField]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal POGGKJJBDBG MILFBNPFDGB
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x63B5160", Offset = "0x63B3960", VA = "0x1863B5160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> LFEDIAGMCGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x772CC0", Offset = "0x7714C0", VA = "0x180772CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x772CB0", Offset = "0x7714B0", VA = "0x180772CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx AJAIPCEBPEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x63B6950", Offset = "0x63B5150", VA = "0x1863B6950")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx NJGNBOOOJDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x63B68B0", Offset = "0x63B50B0", VA = "0x1863B68B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx DEINPDMGBDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x63B7570", Offset = "0x63B5D70", VA = "0x1863B7570")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63B8AF0", Offset = "0x63B72F0", VA = "0x1863B8AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform IOINMCEJIFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x79B540", Offset = "0x799D40", VA = "0x18079B540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform JIGIMPEEGAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x79B540", Offset = "0x799D40", VA = "0x18079B540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IMFCFGHBGGD HOBBHNFHPOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x63B6670", Offset = "0x63B4E70", VA = "0x1863B6670")]
			get
			{
				return default(IMFCFGHBGGD);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x63B82A0", Offset = "0x63B6AA0", VA = "0x1863B82A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LIDGFPBONBF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x63B6C00", Offset = "0x63B5400", VA = "0x1863B6C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LKECHLBCGPB
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63B6790", Offset = "0x63B4F90", VA = "0x1863B6790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public FNFCKEINJLI BMJIADBDFHA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x63B6B40", Offset = "0x63B5340", VA = "0x1863B6B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x63B8460", Offset = "0x63B6C60", VA = "0x1863B8460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public CCOBILGDEMA JKMLFKFFLDD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x63B6AE0", Offset = "0x63B52E0", VA = "0x1863B6AE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x63B83F0", Offset = "0x63B6BF0", VA = "0x1863B83F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool GLDNNIEGOKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x63B6A30", Offset = "0x63B5230", VA = "0x1863B6A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody AEJAAAHOLGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x63B6A90", Offset = "0x63B5290", VA = "0x1863B6A90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HNEBFNGJAEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x63B67F0", Offset = "0x63B4FF0", VA = "0x1863B67F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x63B8310", Offset = "0x63B6B10", VA = "0x1863B8310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LOMBELGPFMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1B24300", Offset = "0x1B22B00", VA = "0x181B24300")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5BF8B40", Offset = "0x5BF7340", VA = "0x185BF8B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float DKBLLJFFMEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x63B7510", Offset = "0x63B5D10", VA = "0x1863B7510")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float BBMGMEMIHFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x63B74B0", Offset = "0x63B5CB0", VA = "0x1863B74B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x63B8A80", Offset = "0x63B7280", VA = "0x1863B8A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float DGIEADHACBB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x63B6E60", Offset = "0x63B5660", VA = "0x1863B6E60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x63B8700", Offset = "0x63B6F00", VA = "0x1863B8700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float KCPEJLPPPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x63B6C60", Offset = "0x63B5460", VA = "0x1863B6C60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x63B84D0", Offset = "0x63B6CD0", VA = "0x1863B84D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool HHHGOMLBOAB
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x63B7AD0", Offset = "0x63B62D0", VA = "0x1863B7AD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x63B9050", Offset = "0x63B7850", VA = "0x1863B9050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 DACFNBOCDJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x63B7290", Offset = "0x63B5A90", VA = "0x1863B7290")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x63B8850", Offset = "0x63B7050", VA = "0x1863B8850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 OAOPKELIOCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x63B7C10", Offset = "0x63B6410", VA = "0x1863B7C10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode MDILCBCHDAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x63B6DA0", Offset = "0x63B55A0", VA = "0x1863B6DA0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x63B8620", Offset = "0x63B6E20", VA = "0x1863B8620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float OFLBICEGOHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x63B6850", Offset = "0x63B5050", VA = "0x1863B6850")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x63B8380", Offset = "0x63B6B80", VA = "0x1863B8380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints AFFGAPEFNCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x63B6E00", Offset = "0x63B5600", VA = "0x1863B6E00")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x63B8690", Offset = "0x63B6E90", VA = "0x1863B8690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 KMOKDMBPKBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x63B7610", Offset = "0x63B5E10", VA = "0x1863B7610")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 OGOEDPDLCMK
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x63B7610", Offset = "0x63B5E10", VA = "0x1863B7610")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x63B8E30", Offset = "0x63B7630", VA = "0x1863B8E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float PCHJELNHBAN
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x63B7370", Offset = "0x63B5B70", VA = "0x1863B7370")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x63B8930", Offset = "0x63B7130", VA = "0x1863B8930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float KFHKPOPKIGC
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x63B7A70", Offset = "0x63B6270", VA = "0x1863B7A70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x63B8FE0", Offset = "0x63B77E0", VA = "0x1863B8FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion BHFAPNDGIHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x63B76F0", Offset = "0x63B5EF0", VA = "0x1863B76F0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x63B8BB0", Offset = "0x63B73B0", VA = "0x1863B8BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion GCCLACCEIPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x63B7990", Offset = "0x63B6190", VA = "0x1863B7990")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x63B8F10", Offset = "0x63B7710", VA = "0x1863B8F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 BCMONKJNDLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x63B77D0", Offset = "0x63B5FD0", VA = "0x1863B77D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x63B8C80", Offset = "0x63B7480", VA = "0x1863B8C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion CHMEJOEMCAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x63B78B0", Offset = "0x63B60B0", VA = "0x1863B78B0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x63B8D60", Offset = "0x63B7560", VA = "0x1863B8D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 GNMILCCIALP
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x63B7B30", Offset = "0x63B6330", VA = "0x1863B7B30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x63B90C0", Offset = "0x63B78C0", VA = "0x1863B90C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 APODGKHBFFA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x63B73D0", Offset = "0x63B5BD0", VA = "0x1863B73D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x63B89A0", Offset = "0x63B71A0", VA = "0x1863B89A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 FGDMIAMGAFN
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x63B6CC0", Offset = "0x63B54C0", VA = "0x1863B6CC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x63B8540", Offset = "0x63B6D40", VA = "0x1863B8540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 PBDPKEGAFGB
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x63B71B0", Offset = "0x63B59B0", VA = "0x1863B71B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x63B8770", Offset = "0x63B6F70", VA = "0x1863B8770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 DLLPAIDEDPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x63B7070", Offset = "0x63B5870", VA = "0x1863B7070")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion FCFMPHOGDHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x63B6F90", Offset = "0x63B5790", VA = "0x1863B6F90")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 NOBOFBEEILO
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x63B7DD0", Offset = "0x63B65D0", VA = "0x1863B7DD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 LDPJANIDJKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x63B7CF0", Offset = "0x63B64F0", VA = "0x1863B7CF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool MEDCLPBNJBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x63B7150", Offset = "0x63B5950", VA = "0x1863B7150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool JNDOHIHFOND
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x63B6BA0", Offset = "0x63B53A0", VA = "0x1863B6BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool OMCEMNAJBOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x63B6730", Offset = "0x63B4F30", VA = "0x1863B6730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool JHANJIIICHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x63B66D0", Offset = "0x63B4ED0", VA = "0x1863B66D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool BLENKJNIOFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x63B6610", Offset = "0x63B4E10", VA = "0x1863B6610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EPJBKNPAAMA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x63B6EC0", Offset = "0x63B56C0", VA = "0x1863B6EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool PCAIHPKKNOH
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x4FC25B0", Offset = "0x4FC0DB0", VA = "0x184FC25B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event MNAOAJBPDNO FCMPOBPJFLM
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x63B6530", Offset = "0x63B4D30", VA = "0x1863B6530")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x63B81C0", Offset = "0x63B69C0", VA = "0x1863B81C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LMCBABHNBJC ADPBLAJDALE
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x63B64C0", Offset = "0x63B4CC0", VA = "0x1863B64C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x63B8150", Offset = "0x63B6950", VA = "0x1863B8150")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event MNAOAJBPDNO NJEOLLLCKDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x63B6220", Offset = "0x63B4A20", VA = "0x1863B6220")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x63B7EB0", Offset = "0x63B66B0", VA = "0x1863B7EB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event MNAOAJBPDNO ACIAFKEOCDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x63B6290", Offset = "0x63B4A90", VA = "0x1863B6290")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x63B7F20", Offset = "0x63B6720", VA = "0x1863B7F20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event MNAOAJBPDNO HFGAHMOBFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x63B63E0", Offset = "0x63B4BE0", VA = "0x1863B63E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x63B8070", Offset = "0x63B6870", VA = "0x1863B8070")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<CNMEGLEHJFK, CNMEGLEHJFK> NOPDCHJHHLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x63B6370", Offset = "0x63B4B70", VA = "0x1863B6370")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x63B8000", Offset = "0x63B6800", VA = "0x1863B8000")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event MNAOAJBPDNO HGDKEMFHECN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x63B6450", Offset = "0x63B4C50", VA = "0x1863B6450")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x63B80E0", Offset = "0x63B68E0", VA = "0x1863B80E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event MNAOAJBPDNO EHIJOJLGOML
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x63B65A0", Offset = "0x63B4DA0", VA = "0x1863B65A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x63B8230", Offset = "0x63B6A30", VA = "0x1863B8230")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event MNAOAJBPDNO KEOAECKKAAM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x63B6300", Offset = "0x63B4B00", VA = "0x1863B6300")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x63B7F90", Offset = "0x63B6790", VA = "0x1863B7F90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x773B60", Offset = "0x772360", VA = "0x180773B60")]
		internal void IHCHPFIKFNC(POGGKJJBDBG EGAILLJGEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x63B4EB0", Offset = "0x63B36B0", VA = "0x1863B4EB0")]
		internal void IBNEBOMLJHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x63B5F40", Offset = "0x63B4740", VA = "0x1863B5F40")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody AAKGNHJBJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x63B5C10", Offset = "0x63B4410", VA = "0x1863B5C10")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) BGCIDCLPDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63B4650", Offset = "0x63B2E50", VA = "0x1863B4650")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63B5160", Offset = "0x63B3960", VA = "0x1863B5160")]
		private POGGKJJBDBG LGBNFFELLMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63B48A0", Offset = "0x63B30A0", VA = "0x1863B48A0")]
		private void DNNHMGCFPEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63B53E0", Offset = "0x63B3BE0", VA = "0x1863B53E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x63B4EB0", Offset = "0x63B36B0", VA = "0x1863B4EB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x63B5380", Offset = "0x63B3B80", VA = "0x1863B5380")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x63B5440", Offset = "0x63B3C40", VA = "0x1863B5440")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63B3D00", Offset = "0x63B2500", VA = "0x1863B3D00")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object JECMOKMEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x63B54A0", Offset = "0x63B3CA0", VA = "0x1863B54A0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object JECMOKMEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x63B4C30", Offset = "0x63B3430", VA = "0x1863B4C30")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x63B5320", Offset = "0x63B3B20", VA = "0x1863B5320")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x63B5D70", Offset = "0x63B4570", VA = "0x1863B5D70")]
		public void SetParent(RigidbodyEx DOLICEBFIPF, bool NHBKKIBCJBF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x63B57B0", Offset = "0x63B3FB0", VA = "0x1863B57B0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x63B4F40", Offset = "0x63B3740", VA = "0x1863B4F40")]
		public bool IsRigidbodyAncestor(RigidbodyEx FHKEGDBIEEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x63B5020", Offset = "0x63B3820", VA = "0x1863B5020")]
		public bool IsRigidbodyDescendant(RigidbodyEx AEFKCMJCEOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x63B3F70", Offset = "0x63B2770", VA = "0x1863B3F70")]
		public void AddInterpolationRestriction(object JECMOKMEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x63B5510", Offset = "0x63B3D10", VA = "0x1863B5510")]
		public void RemoveInterpolationRestriction(object JECMOKMEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x63B46C0", Offset = "0x63B2EC0", VA = "0x1863B46C0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x63B3FE0", Offset = "0x63B27E0", VA = "0x1863B3FE0")]
		public void AddKinematic(object JECMOKMEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x63B5580", Offset = "0x63B3D80", VA = "0x1863B5580")]
		public void RemoveKinematic(object JECMOKMEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x63B5CF0", Offset = "0x63B44F0", VA = "0x1863B5CF0")]
		public void SetKinematic(object JECMOKMEJED, bool EHOKAKODAMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x63B5B10", Offset = "0x63B4310", VA = "0x1863B5B10")]
		public void SetDiscontinuousPositionAndRotation(Vector3 DOHLFDBOKIE, Quaternion EIHDCMDHFCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x63B5A10", Offset = "0x63B4210", VA = "0x1863B5A10")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 LKKNBMNGINO, Quaternion PBEHPLLCMLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x63B4DA0", Offset = "0x63B35A0", VA = "0x1863B4DA0")]
		public Vector3 GetConstrainedVelocity(Vector3 GNMILCCIALP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x63B4C90", Offset = "0x63B3490", VA = "0x1863B4C90")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 FGDMIAMGAFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x63B3E80", Offset = "0x63B2680", VA = "0x1863B3E80")]
		public void AddForce(Vector3 PPEPKNMOGPK, ForceMode FCKKFKNEIAA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x63B3D70", Offset = "0x63B2570", VA = "0x1863B3D70")]
		public void AddForceAtPosition(Vector3 PPEPKNMOGPK, Vector3 FLFCGPFDCMD, ForceMode FCKKFKNEIAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x63B41B0", Offset = "0x63B29B0", VA = "0x1863B41B0")]
		public void AddTorque(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x63B4050", Offset = "0x63B2850", VA = "0x1863B4050")]
		public void AddRelativeTorque(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x63B6010", Offset = "0x63B4810", VA = "0x1863B6010")]
		public Vector3 WorldToLocalVelocity(Vector3 OHFPEKLPEIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63B5210", Offset = "0x63B3A10", VA = "0x1863B5210")]
		public Vector3 LocalToWorldVelocity(Vector3 APODGKHBFFA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x63B4840", Offset = "0x63B3040", VA = "0x1863B4840")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x63B47E0", Offset = "0x63B2FE0", VA = "0x1863B47E0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x63B4780", Offset = "0x63B2F80", VA = "0x1863B4780")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x63B4720", Offset = "0x63B2F20", VA = "0x1863B4720")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x63B5910", Offset = "0x63B4110", VA = "0x1863B5910")]
		public void ResetVelocityWorldSpace(Vector3 BOIAGDGMNAH, Vector3 NFFCADAKPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x63B5810", Offset = "0x63B4010", VA = "0x1863B5810")]
		public void ResetVelocityLocalSpace(Vector3 KBAMJEPPMDE, Vector3 PBDPKEGAFGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x63B56D0", Offset = "0x63B3ED0", VA = "0x1863B56D0")]
		public void ResetLinearVelocityLocalSpace(Vector3 KBAMJEPPMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x63B5EA0", Offset = "0x63B46A0", VA = "0x1863B5EA0")]
		public bool SweepTest(Vector3 HDJKLLNHJHP, [Out] RaycastHit GPFENAPHDDP, float EMBKCPDDBCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x63B5100", Offset = "0x63B3900", VA = "0x1863B5100")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x63B5E40", Offset = "0x63B4640", VA = "0x1863B5E40")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x63B5FB0", Offset = "0x63B47B0", VA = "0x1863B5FB0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x63B4140", Offset = "0x63B2940", VA = "0x1863B4140")]
		public void AddShouldHaveUnityRigidbodyToken(object JECMOKMEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x63B55F0", Offset = "0x63B3DF0", VA = "0x1863B55F0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object JECMOKMEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x63B44E0", Offset = "0x63B2CE0", VA = "0x1863B44E0")]
		public void ApplyForceVelocityChange(EHJPDGLKMMO DADIMGHMLOP, Vector3 LIJNNJCBAEJ, float FKHPADCABCD, float HDNCDJHLDBB = 8f, float GCNJLKJIGFF = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x63B4440", Offset = "0x63B2C40", VA = "0x1863B4440")]
		public void ApplyAngularVelocityChange(MCPIEBENNGH BAPJDGLKOEF, Vector3 LEDLJNHCDLO, float BLJLIMNEJDP = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x63B45A0", Offset = "0x63B2DA0", VA = "0x1863B45A0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(MCPIEBENNGH BAPJDGLKOEF, Vector3 JOBDANNFLEE, float NKKKJJHPIPH = 7f, float IDADDGNGKCJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x63B4370", Offset = "0x63B2B70", VA = "0x1863B4370")]
		public bool AllowedScaleChange(float HOEPBGDAMOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x63B42A0", Offset = "0x63B2AA0", VA = "0x1863B42A0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx CCPGANDNELJ, object JECMOKMEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x63B5660", Offset = "0x63B3E60", VA = "0x1863B5660")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object JECMOKMEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x63B61B0", Offset = "0x63B49B0", VA = "0x1863B61B0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class MNBJLMHOIKP
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x63A76F0", Offset = "0x63A5EF0", VA = "0x1863A76F0")]
	public static POGGKJJBDBG MILFBNPFDGB(this RigidbodyEx FECPDCEPJMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct INKLBHHLMIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody BDKLGEAFBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView LPLCFGFEGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 KLKINIFJLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 CCHPLFLDCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public DIDNFNFEOHI GABMNKCDOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool GPCFMDHBPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool BOGEKALGKOI;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[GAMIKAOGCAJ(typeof(AMANEILBFPD), new string[] { })]
public class JIPBNNBACIA : AMANEILBFPD, MKBPNJOHGJA
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly DNJICJAPBOC KIDCMOJGGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private JHFKEPJCCJB HOBCKHPFNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private KPNBDAHOHHH NFMOFHCEAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NCOOLHKGNAN HCLNPCAIBJA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public KPNBDAHOHHH PELEPLGFCGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NCOOLHKGNAN ECJDOOMNBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x639F800", Offset = "0x639E000", VA = "0x18639F800", Slot = "8")]
	public void InitReferences(OFKKFGHIPBF EFCIJOEMPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x639FA00", Offset = "0x639E200", VA = "0x18639FA00", Slot = "6")]
	public FJLCNCEHANP NHNBDNJPJDA(RigidbodyEx FECPDCEPJMM)
	{
		return default(FJLCNCEHANP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x639F890", Offset = "0x639E090", VA = "0x18639F890")]
	private static FJLCNCEHANP JIEHPEJOFFA(RigidbodyEx FECPDCEPJMM)
	{
		return default(FJLCNCEHANP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x639F960", Offset = "0x639E160", VA = "0x18639F960", Slot = "7")]
	public POGGKJJBDBG MNFLNCEGJAE(RigidbodyEx FECPDCEPJMM, INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public JIPBNNBACIA()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static LJECGABKDKN UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int PHDGAJBDGHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int PHMGOCPIPBJ;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x63B3B60", Offset = "0x63B2360", VA = "0x1863B3B60")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x63B3BA0", Offset = "0x63B23A0", VA = "0x1863B3BA0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x63B3B80", Offset = "0x63B2380", VA = "0x1863B3B80")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string OLDFIJBKFKG, [Optional] UnityEngine.Object LFDLOIPEDMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string OLDFIJBKFKG, [Optional] UnityEngine.Object LFDLOIPEDMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x63B3CB0", Offset = "0x63B24B0", VA = "0x1863B3CB0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class IEMPDIMDMDN
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x639E610", Offset = "0x639CE10", VA = "0x18639E610")]
	public static void HEJKIBNHGOO(this Rigidbody AAKGNHJBJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x639E7A0", Offset = "0x639CFA0", VA = "0x18639E7A0")]
	public static void HEJKIBNHGOO(this Rigidbody AAKGNHJBJGN, Vector3 DDGJCBNMGKH, Quaternion FCFMPHOGDHG, Vector3 ECNNMHCHPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xBD57F0", Offset = "0xBD3FF0", VA = "0x180BD57F0")]
	public static void BIDCPOBIACC(Vector3 GNMILCCIALP, Vector3 HMKNLJLLNBH, [Out] Vector3 EAANPBAMBLN, [Out] Vector3 FAKFENHNBBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ONDGJACPPON
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class CNHPMHFHKPA : FNFCKEINJLI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x782990", Offset = "0x781190", VA = "0x180782990", Slot = "4")]
		public Vector3 DBMGEIINIAC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x782990", Offset = "0x781190", VA = "0x180782990", Slot = "5")]
		public Vector3 ABDOGEEGNAM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public CNHPMHFHKPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static FNFCKEINJLI EPELHPLOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x63B0450", Offset = "0x63AEC50", VA = "0x1863B0450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EJPEEHDHNOM
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CollisionDetectionMode LDGJDGADDBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOFBOIAJCEO();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CKGADLFFCGE(bool MEDCLPBNJBI);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDMMPEFBDOC(bool MEDCLPBNJBI);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HALNBOKHIJD(Vector3 HDJKLLNHJHP, [Out] RaycastHit GPFENAPHDDP, float EMBKCPDDBCB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IEIELLFCAND : IDisposable, EGPBCNGHIJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	BPHGBOIEMNK HOBBHNFHPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<CNMEGLEHJFK, CNMEGLEHJFK> NOPDCHJHHLP;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LOFBOIAJCEO();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface NCOOLHKGNAN
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPGIGOMAAKB AFGINIHHGCD(POGGKJJBDBG EGAILLJGEID);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HKBIMCGMLPJ FCNMBFEAADH(POGGKJJBDBG EGAILLJGEID);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MGNMEGJCJIO JMGCKPMDLND(POGGKJJBDBG EGAILLJGEID);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NGEJIGOEOMC IBIACGPIINK(POGGKJJBDBG EGAILLJGEID);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CJEHKOJIGBF CPGPCFIDIJG(POGGKJJBDBG EGAILLJGEID);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IEIELLFCAND PPINIDDDGGJ(POGGKJJBDBG EGAILLJGEID);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	APDMJJOBGGL DJEIDEIEBAM(POGGKJJBDBG EGAILLJGEID);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FLJDFNDMMBM MANPFJECCFK(POGGKJJBDBG EGAILLJGEID);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EJPEEHDHNOM AJJOBCIDKAJ(POGGKJJBDBG EGAILLJGEID);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PAEKHDOLDKK MIIEIDJAIED(POGGKJJBDBG EGAILLJGEID);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HAPFHFGLCJK HIGLLJIGHIJ(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FHCFOFKDBIB DBCEBDCGAOO(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OPNJMHNPJFL GPJOCDMGGBK(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CGBPAEDIJBL IGOMBOELLNI(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GPGFKDNCHEE AMMDKDEKPBM(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	POGGKJJBDBG MNFLNCEGJAE(RigidbodyEx FECPDCEPJMM, INKLBHHLMIO FCHBDAMJEHN, AMANEILBFPD CLDKLPDMMOI);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FLJDFNDMMBM
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKDDBEKDEDO(Vector3 PPEPKNMOGPK, ForceMode FCKKFKNEIAA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJLNPDBLDOJ(Vector3 PPEPKNMOGPK, Vector3 FLFCGPFDCMD, ForceMode FCKKFKNEIAA);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHCIGHLDGFH(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HOFDPKDCOLG(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PAEKHDOLDKK
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool PEDIPIDFJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HPGIGOMAAKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IReadOnlyList<POGGKJJBDBG> IKJOMIHCPMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	POGGKJJBDBG NJGNBOOOJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	POGGKJJBDBG LLPGCPJGINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event MNAOAJBPDNO NJEOLLLCKDA;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event MNAOAJBPDNO ACIAFKEOCDM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event LMCBABHNBJC KKHEDLEFENB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action LCAGGODFGJF;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action ICGLFKNDHIO;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<POGGKJJBDBG> DGJEOHFEFPH;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<POGGKJJBDBG> HMOFKJHBJEP;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action PDMLBOPCJOA;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<POGGKJJBDBG> OAKEJDAGKBE;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PJMHJPJDMME(POGGKJJBDBG AKJKKHGAFEH, bool NHBKKIBCJBF = false);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MGNMEGJCJIO
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 CIFGMIBJHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 MEMIEGNNCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGLAIAPGMJH(POGGKJJBDBG DEINPDMGBDC, object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KCFAFLFGJIC(object JECMOKMEJED);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CGBPAEDIJBL
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 OCJFPLHJFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 GHLIIPFFCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float POIAJHCGEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float FJDGCFDCMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 JGJCBHOOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Quaternion ECFAFHPNLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event MNAOAJBPDNO KPPAEFKPCKI;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NMHLMPNFNEB((Quaternion rot, Vector3 moments) BGCIDCLPDOE);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HFLMIGNMBKH();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JJNHCABBDGF();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PLLCMKJOJBI();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MFCCKEJINLP();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OPNJMHNPJFL
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOFBOIAJCEO();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AINHAMJFIKB(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KHDJAPGNKKL(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INGKLNGGEHI(POGGKJJBDBG FECPDCEPJMM);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LPGJLFMOLON(POGGKJJBDBG FECPDCEPJMM);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HMJPDJEHBGN();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface APDMJJOBGGL
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool HFPCJNNENJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event MNAOAJBPDNO OGAFLABKONM;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AFOAIBPAJEC();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PEHCNDHCOOI(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CMJNCADEFHC(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NBDAOKDHCMP(object JECMOKMEJED, bool EHOKAKODAMF);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable JCJPJEEHIPP();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CGFLGPMMKNA(Rigidbody EKEIFPIAPLM);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FHCFOFKDBIB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool LIDGFPBONBF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool LKECHLBCGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event MNAOAJBPDNO AOCFIDLDHLO;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LOFBOIAJCEO();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NAGIGIACEMM(POGGKJJBDBG DEINPDMGBDC);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MJJAOFJCABM(POGGKJJBDBG DEINPDMGBDC);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface GPGFKDNCHEE
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HNEBFNGJAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool EOPDNIBOEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	RigidbodyConstraints DFKCOLAGHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface NGEJIGOEOMC
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float NMHLKIHHHKD
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float FEBHECBJBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BEFDEIPAKNE
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx IGHCAJFACJK);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CJEHKOJIGBF
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event MNAOAJBPDNO ELOPKDOIPDF;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOFBOIAJCEO();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MLKENLCNPKP();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLOONHHCEEI();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KJOLGJJILBC();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LIMHMJPDFFC();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LKNGBPGLIHI();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JFPAJDBOAJK(bool EGEEOFOOENC);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface HAPFHFGLCJK
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Rigidbody AEJAAAHOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool KDONFFIMDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LOFBOIAJCEO();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJJAOAMDCMC(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HIJLGBEGIJI(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GBJJIEEPEAA();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ONNJPBCNPIP();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HKBIMCGMLPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	FNFCKEINJLI BMJIADBDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	CCOBILGDEMA JKMLFKFFLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 PPDGIAKDDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 HJMJIBMHPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 PBHMNNEDFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 NOLJCEALFMH
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float OFLBICEGOHF
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool GLDNNIEGOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LOFBOIAJCEO();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LJKLCOHFDNP(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void FBGHMOEINPA(MCPIEBENNGH BAPJDGLKOEF, Vector3 LEDLJNHCDLO, float BLJLIMNEJDP = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AJBOHICGGKK(EHJPDGLKMMO DADIMGHMLOP, Vector3 LIJNNJCBAEJ, float FKHPADCABCD, float HDNCDJHLDBB = 8f, float GCNJLKJIGFF = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LLJNMOLMGDL(MCPIEBENNGH BAPJDGLKOEF, Vector3 JOBDANNFLEE, float NKKKJJHPIPH = 7f, float IDADDGNGKCJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HHDDHHOIEJN();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DKOPONKEFEE();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NJOOAFJBPPB();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BBOGKPNJBEM();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 OEGANIFDLFG(Vector3 GNMILCCIALP);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NMKAMGJMLNI(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void PFHBAFGLOKF(Vector3 KPJFPLIJJKM);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OGFHPENECCK(Vector3 KBAMJEPPMDE, Vector3 PBDPKEGAFGB);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void EOLOBIKHGKC(Vector3 BOIAGDGMNAH, Vector3 NFFCADAKPAF);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 PAKBHMIDCFN(Vector3 APODGKHBFFA);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 FHBGLKBMNCP(Vector3 OHFPEKLPEIO);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface KPNBDAHOHHH
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool PAHACEGGGIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBKBOFEGICG(string MFCNDEMKIPG);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADKBKGEGEDC(RigidbodyEx FECPDCEPJMM, Action KJDOCFCKCJE);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KDNKFCKOHOL HGDFJAOCPMA(int ENAOMEPDJGK);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOOFJGDDAPA(Vector3 OAOPKELIOCF, float JMLNLMLPBKH, Color NGHDCCDAAOH);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface AMANEILBFPD
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	KPNBDAHOHHH PELEPLGFCGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	NCOOLHKGNAN ECJDOOMNBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FJLCNCEHANP NHNBDNJPJDA(RigidbodyEx FECPDCEPJMM);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	POGGKJJBDBG MNFLNCEGJAE(RigidbodyEx FECPDCEPJMM, INKLBHHLMIO FCHBDAMJEHN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface CCOBILGDEMA
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNGAFLNMDMG(Vector3 EMLJJDCCHEI);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FHICHLFFGAM(Vector3 FGDMIAMGAFN);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBHMAECNNBO(Vector3 EMLJJDCCHEI);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MJPIDPIIKAD(Vector3 FGDMIAMGAFN);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface FNFCKEINJLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 DBMGEIINIAC();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 ABDOGEEGNAM();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface POGGKJJBDBG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Rigidbody AEJAAAHOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	RigidbodyEx HMCMHGPEDHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject KFEADEMCIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Transform MJNMNKLDGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	POGGKJJBDBG LLPGCPJGINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IReadOnlyList<POGGKJJBDBG> IKJOMIHCPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	POGGKJJBDBG NJGNBOOOJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool LIDGFPBONBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool LKECHLBCGPB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	FNFCKEINJLI BMJIADBDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	CCOBILGDEMA JKMLFKFFLDD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float OFLBICEGOHF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Vector3 HJMJIBMHPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 NOLJCEALFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 PPDGIAKDDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 PBHMNNEDFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool JHANJIIICHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool BLENKJNIOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool GLDNNIEGOKM
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 CIFGMIBJHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 MEMIEGNNCPI
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 OCJFPLHJFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 GHLIIPFFCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float POIAJHCGEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float FJDGCFDCMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 JGJCBHOOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Quaternion ECFAFHPNLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float NMHLKIHHHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float FEBHECBJBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool PEDIPIDFJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	BPHGBOIEMNK HOBBHNFHPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool HFPCJNNENJE
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Transform JIGIMPEEGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 EMMCDGJCGBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float GMFFIOIPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float MIMEPHPGCNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion NCMEEMHABEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 HAONNNBKPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Quaternion MGBCJOLDJFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	RigidbodyConstraints DFKCOLAGHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool HNEBFNGJAEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	CollisionDetectionMode LDGJDGADDBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool JNDOHIHFOND
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event MNAOAJBPDNO NJEOLLLCKDA;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event MNAOAJBPDNO ACIAFKEOCDM;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event LMCBABHNBJC KKHEDLEFENB;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event MNAOAJBPDNO AOCFIDLDHLO;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event MNAOAJBPDNO HFGAHMOBFHO;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event MNAOAJBPDNO ELOPKDOIPDF;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<CNMEGLEHJFK, CNMEGLEHJFK> NOPDCHJHHLP;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event MNAOAJBPDNO OGAFLABKONM;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event MNAOAJBPDNO KEOAECKKAAM;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void NMHLMPNFNEB((Quaternion rot, Vector3 moments) BGCIDCLPDOE);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void LOFBOIAJCEO();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void IAKKLBIFDLD();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void IALOONNAOHL();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void KJOLGJJILBC();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void PJMHJPJDMME(POGGKJJBDBG DOLICEBFIPF, bool NHBKKIBCJBF = false);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void EALMAGOLHAM(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void NBMPEEEJOOM(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 FHBGLKBMNCP(Vector3 OHFPEKLPEIO);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 PAKBHMIDCFN(Vector3 APODGKHBFFA);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void BBOGKPNJBEM();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void DKOPONKEFEE();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void HHDDHHOIEJN();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void EOLOBIKHGKC(Vector3 BOIAGDGMNAH, Vector3 NFFCADAKPAF);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void OGFHPENECCK(Vector3 KBAMJEPPMDE, Vector3 PBDPKEGAFGB);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void PFHBAFGLOKF(Vector3 KPJFPLIJJKM);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void AJBOHICGGKK(EHJPDGLKMMO DADIMGHMLOP, Vector3 LIJNNJCBAEJ, float FKHPADCABCD, float HDNCDJHLDBB = 8f, float GCNJLKJIGFF = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void FBGHMOEINPA(MCPIEBENNGH BAPJDGLKOEF, Vector3 LEDLJNHCDLO, float BLJLIMNEJDP = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void LLJNMOLMGDL(MCPIEBENNGH BAPJDGLKOEF, Vector3 JOBDANNFLEE, float NKKKJJHPIPH = 7f, float IDADDGNGKCJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 OEGANIFDLFG(Vector3 DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 PIPFNMLLCJH(Vector3 DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void NJOOAFJBPPB();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void HAAPCJDCEBK(POGGKJJBDBG CCPGANDNELJ, object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void MKPOIADAHKB(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void JJNHCABBDGF();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void HFLMIGNMBKH();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void PLLCMKJOJBI();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool MLKENLCNPKP();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void LKNGBPGLIHI();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable JCJPJEEHIPP();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void PEHCNDHCOOI(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void CMJNCADEFHC(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void NBDAOKDHCMP(object JECMOKMEJED, bool EHOKAKODAMF);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void MHGMHGKMGBM(Vector3 DOHLFDBOKIE, Quaternion EIHDCMDHFCJ);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void CGHOIONKBHH(Vector3 LKKNBMNGINO, Quaternion PBEHPLLCMLE);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool PNKADAMPJHB(float HOEPBGDAMOC);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void CFJPJHIJLBP(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void AJOBODFBJEB(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void LJJAOAMDCMC(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void HIJLGBEGIJI(object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void CKDDBEKDEDO(Vector3 PPEPKNMOGPK, ForceMode FCKKFKNEIAA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void FJLNPDBLDOJ(Vector3 PPEPKNMOGPK, Vector3 FLFCGPFDCMD, ForceMode FCKKFKNEIAA);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void JHCIGHLDGFH(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void HOFDPKDCOLG(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool HALNBOKHIJD(Vector3 HDJKLLNHJHP, [Out] RaycastHit GPFENAPHDDP, float EMBKCPDDBCB);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void MFCCKEJINLP();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class AKOGDJKMCIG : POGGKJJBDBG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly AMANEILBFPD CLDKLPDMMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal HPGIGOMAAKB FBPPNMFJDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal OPNJMHNPJFL DMFNDGDHHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal FHCFOFKDBIB LDLLIEOINBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal HKBIMCGMLPJ GNMILCCIALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal MGNMEGJCJIO AGGMJHONBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal CGBPAEDIJBL CBHHPLLLNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal NGEJIGOEOMC BFLBOAMHGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal PAEKHDOLDKK ELFFMBHKPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal CJEHKOJIGBF LOLGLOJOJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal IEIELLFCAND NPDKHJFGCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal APDMJJOBGGL HPENFJNHLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal FLJDFNDMMBM PPEPKNMOGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal GPGFKDNCHEE PBPGPIDCGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal HAPFHFGLCJK BDKLGEAFBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal EJPEEHDHNOM MOCKBMFFAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal IDisposable EJMPDEMGJKD;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyEx HMCMHGPEDHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x777260", Offset = "0x775A60", VA = "0x180777260", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7770F0", Offset = "0x7758F0", VA = "0x1807770F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GameObject KFEADEMCIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x839580", Offset = "0x837D80", VA = "0x180839580", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x838E00", Offset = "0x837600", VA = "0x180838E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Transform MJNMNKLDGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6397450", Offset = "0x6395C50", VA = "0x186397450", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody AEJAAAHOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x63935E0", Offset = "0x6391DE0", VA = "0x1863935E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public POGGKJJBDBG LLPGCPJGINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x63946C0", Offset = "0x6392EC0", VA = "0x1863946C0", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x6396D00", Offset = "0x6395500", VA = "0x186396D00", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<POGGKJJBDBG> IKJOMIHCPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6394C60", Offset = "0x6393460", VA = "0x186394C60", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public POGGKJJBDBG NJGNBOOOJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6394E80", Offset = "0x6393680", VA = "0x186394E80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool NPECNPKKINB
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6397040", Offset = "0x6395840", VA = "0x186397040", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool LIDGFPBONBF
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6396570", Offset = "0x6394D70", VA = "0x186396570", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool LKECHLBCGPB
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6391990", Offset = "0x6390190", VA = "0x186391990", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public FNFCKEINJLI BMJIADBDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6392A30", Offset = "0x6391230", VA = "0x186392A30", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6392650", Offset = "0x6390E50", VA = "0x186392650", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public CCOBILGDEMA JKMLFKFFLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6397160", Offset = "0x6395960", VA = "0x186397160", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x63973F0", Offset = "0x6395BF0", VA = "0x1863973F0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float OFLBICEGOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6395510", Offset = "0x6393D10", VA = "0x186395510", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6394730", Offset = "0x6392F30", VA = "0x186394730", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 HJMJIBMHPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x6394890", Offset = "0x6393090", VA = "0x186394890", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6393E90", Offset = "0x6392690", VA = "0x186393E90", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 NOLJCEALFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x6391B00", Offset = "0x6390300", VA = "0x186391B00", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6396430", Offset = "0x6394C30", VA = "0x186396430", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 PPDGIAKDDFI
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6395A50", Offset = "0x6394250", VA = "0x186395A50", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6395970", Offset = "0x6394170", VA = "0x186395970", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 PBHMNNEDFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6391DA0", Offset = "0x63905A0", VA = "0x186391DA0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x63926B0", Offset = "0x6390EB0", VA = "0x1863926B0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool OMCEMNAJBOM
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6394DE0", Offset = "0x63935E0", VA = "0x186394DE0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool JHANJIIICHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x63968B0", Offset = "0x63950B0", VA = "0x1863968B0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool BLENKJNIOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6394ED0", Offset = "0x63936D0", VA = "0x186394ED0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool GLDNNIEGOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6393E40", Offset = "0x6392640", VA = "0x186393E40", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 CIFGMIBJHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6396A40", Offset = "0x6395240", VA = "0x186396A40", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 MEMIEGNNCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6392A80", Offset = "0x6391280", VA = "0x186392A80", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 OCJFPLHJFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x63923D0", Offset = "0x6390BD0", VA = "0x1863923D0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x63931D0", Offset = "0x63919D0", VA = "0x1863931D0", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 GHLIIPFFCJH
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x63967D0", Offset = "0x6394FD0", VA = "0x1863967D0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float POIAJHCGEIE
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6394E30", Offset = "0x6393630", VA = "0x186394E30", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float FJDGCFDCMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6395070", Offset = "0x6393870", VA = "0x186395070", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x63950C0", Offset = "0x63938C0", VA = "0x1863950C0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 JGJCBHOOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6396B70", Offset = "0x6395370", VA = "0x186396B70", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion ECFAFHPNLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x63920E0", Offset = "0x63908E0", VA = "0x1863920E0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float NMHLKIHHHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x63943A0", Offset = "0x6392BA0", VA = "0x1863943A0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6394340", Offset = "0x6392B40", VA = "0x186394340", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float FEBHECBJBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x63954C0", Offset = "0x6393CC0", VA = "0x1863954C0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x63941E0", Offset = "0x63929E0", VA = "0x1863941E0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool PEDIPIDFJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6393DF0", Offset = "0x63925F0", VA = "0x186393DF0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6395120", Offset = "0x6393920", VA = "0x186395120", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public BPHGBOIEMNK HOBBHNFHPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x6391BE0", Offset = "0x63903E0", VA = "0x186391BE0", Slot = "48")]
		get
		{
			return default(BPHGBOIEMNK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x6392080", Offset = "0x6390880", VA = "0x186392080", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool HFPCJNNENJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6393180", Offset = "0x6391980", VA = "0x186393180", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform JIGIMPEEGAF
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x63921B0", Offset = "0x63909B0", VA = "0x1863921B0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 EMMCDGJCGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6394790", Offset = "0x6392F90", VA = "0x186394790", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x63970A0", Offset = "0x63958A0", VA = "0x1863970A0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float GMFFIOIPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6394FB0", Offset = "0x63937B0", VA = "0x186394FB0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6391FC0", Offset = "0x63907C0", VA = "0x186391FC0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float MIMEPHPGCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6396610", Offset = "0x6394E10", VA = "0x186396610", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6394B60", Offset = "0x6393360", VA = "0x186394B60", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion NCMEEMHABEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6394130", Offset = "0x6392930", VA = "0x186394130", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x63943F0", Offset = "0x6392BF0", VA = "0x1863943F0", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 HAONNNBKPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6393090", Offset = "0x6391890", VA = "0x186393090", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6394840", Offset = "0x6393040", VA = "0x186394840", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion MGBCJOLDJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6397000", Offset = "0x6395800", VA = "0x186397000", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x63962C0", Offset = "0x6394AC0", VA = "0x1863962C0", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints DFKCOLAGHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6392030", Offset = "0x6390830", VA = "0x186392030", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6396B10", Offset = "0x6395310", VA = "0x186396B10", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool HNEBFNGJAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6394FD0", Offset = "0x63937D0", VA = "0x186394FD0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6392790", Offset = "0x6390F90", VA = "0x186392790", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode LDGJDGADDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6395180", Offset = "0x6393980", VA = "0x186395180", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6393AA0", Offset = "0x63922A0", VA = "0x186393AA0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool KCHEDKBHPFL
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6391E80", Offset = "0x6390680", VA = "0x186391E80", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool JNDOHIHFOND
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6393920", Offset = "0x6392120", VA = "0x186393920", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool FKCFEDJAJGL
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x63930E0", Offset = "0x63918E0", VA = "0x1863930E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool KAEAIDIPNHC
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6393D10", Offset = "0x6392510", VA = "0x186393D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event MNAOAJBPDNO NJEOLLLCKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6391C80", Offset = "0x6390480", VA = "0x186391C80", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x63928A0", Offset = "0x63910A0", VA = "0x1863928A0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event MNAOAJBPDNO ACIAFKEOCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6391CE0", Offset = "0x63904E0", VA = "0x186391CE0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6392C60", Offset = "0x6391460", VA = "0x186392C60", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event LMCBABHNBJC KKHEDLEFENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x63927F0", Offset = "0x6390FF0", VA = "0x1863927F0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x63949D0", Offset = "0x63931D0", VA = "0x1863949D0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event MNAOAJBPDNO AOCFIDLDHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6392CC0", Offset = "0x63914C0", VA = "0x186392CC0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6395B30", Offset = "0x6394330", VA = "0x186395B30", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event MNAOAJBPDNO HFGAHMOBFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6393580", Offset = "0x6391D80", VA = "0x186393580", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6394970", Offset = "0x6393170", VA = "0x186394970", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event MNAOAJBPDNO ELOPKDOIPDF
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x6393630", Offset = "0x6391E30", VA = "0x186393630", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6394580", Offset = "0x6392D80", VA = "0x186394580", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<CNMEGLEHJFK, CNMEGLEHJFK> NOPDCHJHHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x6392590", Offset = "0x6390D90", VA = "0x186392590", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x6391D40", Offset = "0x6390540", VA = "0x186391D40", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event MNAOAJBPDNO OGAFLABKONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x63921C0", Offset = "0x63909C0", VA = "0x1863921C0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6396300", Offset = "0x6394B00", VA = "0x186396300", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event MNAOAJBPDNO KEOAECKKAAM
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6396E60", Offset = "0x6395660", VA = "0x186396E60", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6393D40", Offset = "0x6392540", VA = "0x186393D40", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6397740", Offset = "0x6395F40", VA = "0x186397740")]
	public AKOGDJKMCIG(GameObject AOMHCMIECFG, RigidbodyEx JFHPHBFCOGJ, AMANEILBFPD CLDKLPDMMOI, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x63951D0", Offset = "0x63939D0", VA = "0x1863951D0", Slot = "135")]
	protected virtual void LDMDFIKAJNH(AMANEILBFPD CLDKLPDMMOI, INKLBHHLMIO FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6392900", Offset = "0x6391100", VA = "0x186392900", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6395830", Offset = "0x6394030", VA = "0x186395830", Slot = "71")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6391C30", Offset = "0x6390430", VA = "0x186391C30", Slot = "72")]
	public void IAKKLBIFDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6394710", Offset = "0x6392F10", VA = "0x186394710", Slot = "73")]
	public void IALOONNAOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6396C50", Offset = "0x6395450", VA = "0x186396C50")]
	private void OBFGJLHMCFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x63975E0", Offset = "0x6395DE0", VA = "0x1863975E0", Slot = "81")]
	public void PJMHJPJDMME(POGGKJJBDBG DOLICEBFIPF, bool NHBKKIBCJBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x63929D0", Offset = "0x63911D0", VA = "0x1863929D0", Slot = "84")]
	public void EALMAGOLHAM(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6396770", Offset = "0x6394F70", VA = "0x186396770", Slot = "85")]
	public void NBMPEEEJOOM(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6393B00", Offset = "0x6392300", VA = "0x186393B00", Slot = "86")]
	public Vector3 FHBGLKBMNCP(Vector3 OHFPEKLPEIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x63971B0", Offset = "0x63959B0", VA = "0x1863971B0", Slot = "87")]
	public Vector3 PAKBHMIDCFN(Vector3 APODGKHBFFA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6391C30", Offset = "0x6390430", VA = "0x186391C30", Slot = "88")]
	public void BBOGKPNJBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6392850", Offset = "0x6391050", VA = "0x186392850", Slot = "89")]
	public void DKOPONKEFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6394290", Offset = "0x6392A90", VA = "0x186394290", Slot = "90")]
	public void HHDDHHOIEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6393490", Offset = "0x6391C90", VA = "0x186393490", Slot = "91")]
	public void EOLOBIKHGKC(Vector3 BOIAGDGMNAH, Vector3 NFFCADAKPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6396F10", Offset = "0x6395710", VA = "0x186396F10", Slot = "92")]
	public void OGFHPENECCK(Vector3 KBAMJEPPMDE, Vector3 PBDPKEGAFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6397310", Offset = "0x6395B10", VA = "0x186397310", Slot = "93")]
	public void PFHBAFGLOKF(Vector3 KPJFPLIJJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x63919E0", Offset = "0x63901E0", VA = "0x1863919E0", Slot = "94")]
	public void AJBOHICGGKK(EHJPDGLKMMO DADIMGHMLOP, Vector3 LIJNNJCBAEJ, float FKHPADCABCD, float HDNCDJHLDBB = 8f, float GCNJLKJIGFF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6393690", Offset = "0x6391E90", VA = "0x186393690", Slot = "95")]
	public void FBGHMOEINPA(MCPIEBENNGH BAPJDGLKOEF, Vector3 LEDLJNHCDLO, float BLJLIMNEJDP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6395610", Offset = "0x6393E10", VA = "0x186395610", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LLJNMOLMGDL(MCPIEBENNGH BAPJDGLKOEF, Vector3 JOBDANNFLEE, float NKKKJJHPIPH = 7f, float IDADDGNGKCJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6396D60", Offset = "0x6395560", VA = "0x186396D60", Slot = "97")]
	public Vector3 OEGANIFDLFG(Vector3 DOLICEBFIPF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x63974E0", Offset = "0x6395CE0", VA = "0x1863974E0", Slot = "98")]
	public Vector3 PIPFNMLLCJH(Vector3 DOLICEBFIPF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6396910", Offset = "0x6395110", VA = "0x186396910", Slot = "99")]
	public void NJOOAFJBPPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6394020", Offset = "0x6392820", VA = "0x186394020", Slot = "100")]
	public void HAAPCJDCEBK(POGGKJJBDBG CCPGANDNELJ, object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6396510", Offset = "0x6394D10", VA = "0x186396510", Slot = "101")]
	public void MKPOIADAHKB(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6396960", Offset = "0x6395160", VA = "0x186396960", Slot = "41")]
	public void NMHLMPNFNEB((Quaternion rot, Vector3 moments) BGCIDCLPDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6394D90", Offset = "0x6393590", VA = "0x186394D90", Slot = "104")]
	public void JJNHCABBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6394240", Offset = "0x6392A40", VA = "0x186394240", Slot = "105")]
	public void HFLMIGNMBKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6397650", Offset = "0x6395E50", VA = "0x186397650", Slot = "106")]
	public void PLLCMKJOJBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x63965C0", Offset = "0x6394DC0", VA = "0x1863965C0", Slot = "109")]
	public bool MLKENLCNPKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6395020", Offset = "0x6393820", VA = "0x186395020", Slot = "74")]
	public void KJOLGJJILBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x63955C0", Offset = "0x6393DC0", VA = "0x1863955C0", Slot = "110")]
	public void LKNGBPGLIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6394B10", Offset = "0x6393310", VA = "0x186394B10", Slot = "115")]
	public IDisposable JCJPJEEHIPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x63972B0", Offset = "0x6395AB0", VA = "0x1863972B0", Slot = "116")]
	public void PEHCNDHCOOI(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x63925F0", Offset = "0x6390DF0", VA = "0x1863925F0", Slot = "117")]
	public void CMJNCADEFHC(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6396700", Offset = "0x6394F00", VA = "0x186396700", Slot = "118")]
	public void NBDAOKDHCMP(object JECMOKMEJED, bool EHOKAKODAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x63960C0", Offset = "0x63948C0", VA = "0x1863960C0", Slot = "121")]
	public void MHGMHGKMGBM(Vector3 DOHLFDBOKIE, Quaternion EIHDCMDHFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6392280", Offset = "0x6390A80", VA = "0x186392280", Slot = "122")]
	public void CGHOIONKBHH(Vector3 LKKNBMNGINO, Quaternion PBEHPLLCMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x63976A0", Offset = "0x6395EA0", VA = "0x1863976A0", Slot = "123")]
	public bool PNKADAMPJHB(float HOEPBGDAMOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6392220", Offset = "0x6390A20", VA = "0x186392220", Slot = "124")]
	public void CFJPJHIJLBP(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x6391AA0", Offset = "0x63902A0", VA = "0x186391AA0", Slot = "125")]
	public void AJOBODFBJEB(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x6395560", Offset = "0x6393D60", VA = "0x186395560", Slot = "126")]
	public void LJJAOAMDCMC(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x63942E0", Offset = "0x6392AE0", VA = "0x1863942E0", Slot = "127")]
	public void HIJLGBEGIJI(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x63924B0", Offset = "0x6390CB0", VA = "0x1863924B0", Slot = "128")]
	public void CKDDBEKDEDO(Vector3 PPEPKNMOGPK, ForceMode FCKKFKNEIAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6393C00", Offset = "0x6392400", VA = "0x186393C00", Slot = "129")]
	public void FJLNPDBLDOJ(Vector3 PPEPKNMOGPK, Vector3 FLFCGPFDCMD, ForceMode FCKKFKNEIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x6394CB0", Offset = "0x63934B0", VA = "0x186394CB0", Slot = "130")]
	public void JHCIGHLDGFH(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x63945E0", Offset = "0x6392DE0", VA = "0x1863945E0", Slot = "131")]
	public void HOFDPKDCOLG(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x6394090", Offset = "0x6392890", VA = "0x186394090", Slot = "132")]
	public bool HALNBOKHIJD(Vector3 HDJKLLNHJHP, [Out] RaycastHit GPFENAPHDDP, float EMBKCPDDBCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x6395EB0", Offset = "0x63946B0", VA = "0x186395EB0", Slot = "133")]
	public void MFCCKEJINLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x6397700", Offset = "0x6395F00", VA = "0x186397700", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6394A30", Offset = "0x6393230", VA = "0x186394A30")]
	private void IMIJOINGJNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6391880", Offset = "0x6390080", VA = "0x186391880")]
	private void ACNIEJHCKAH(POGGKJJBDBG DEINPDMGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6393730", Offset = "0x6391F30", VA = "0x186393730")]
	private void FEBLIFCJNJP(POGGKJJBDBG DEINPDMGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6393F70", Offset = "0x6392770", VA = "0x186393F70")]
	private void GLPLKGLINBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6392B60", Offset = "0x6391360", VA = "0x186392B60")]
	private void ECNCHKBBMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x63932B0", Offset = "0x6391AB0", VA = "0x1863932B0")]
	private void EMMMJIEEFEK(POGGKJJBDBG GELDACEOOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6396630", Offset = "0x6394E30", VA = "0x186396630")]
	private void NAGIGIACEMM(POGGKJJBDBG DEINPDMGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6396360", Offset = "0x6394B60", VA = "0x186396360")]
	private void MJJAOFJCABM(POGGKJJBDBG DEINPDMGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x63956C0", Offset = "0x6393EC0", VA = "0x1863956C0")]
	private void LNODFLLELLN(RigidbodyEx DEINPDMGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6395F00", Offset = "0x6394700", VA = "0x186395F00", Slot = "140")]
	protected virtual void MHACMGOMHFA(RigidbodyEx FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6395B90", Offset = "0x6394390", VA = "0x186395B90")]
	protected void MEODEPLGIMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6392D20", Offset = "0x6391520", VA = "0x186392D20")]
	protected void EFMPPMHADGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x63944E0", Offset = "0x6392CE0", VA = "0x1863944E0", Slot = "141")]
	protected virtual IDisposable HLKPAKHFDEL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class PCPLJPFIBGM
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x63B0520", Offset = "0x63AED20", VA = "0x1863B0520")]
	public static POGGKJJBDBG ABEIGACADAJ(this POGGKJJBDBG FECPDCEPJMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x63B0720", Offset = "0x63AEF20", VA = "0x1863B0720")]
	public static bool OBCMBHILFBD(this POGGKJJBDBG FECPDCEPJMM, POGGKJJBDBG FHKEGDBIEEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x63B06A0", Offset = "0x63AEEA0", VA = "0x1863B06A0")]
	public static bool KFIDELJJAHO(this POGGKJJBDBG FECPDCEPJMM, POGGKJJBDBG AEFKCMJCEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x63B0650", Offset = "0x63AEE50", VA = "0x1863B0650")]
	public static RigidbodyEx HMCMHGPEDHD(this POGGKJJBDBG MILFBNPFDGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x63B05D0", Offset = "0x63AEDD0", VA = "0x1863B05D0")]
	public static AKOGDJKMCIG BCFJDJJPMHG(this POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class CFBPLHEBDFJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly AKOGDJKMCIG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool HDNMPGDBKCJ;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6398930", Offset = "0x6397130", VA = "0x186398930")]
	public CFBPLHEBDFJ(AKOGDJKMCIG PMKDCBJFJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x63988D0", Offset = "0x63970D0", VA = "0x1863988D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class LPKLJMGMFJL : BOLKAIIOIOP, EJPEEHDHNOM
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CollisionDetectionMode CCDFBLKDPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x63A6300", Offset = "0x63A4B00", VA = "0x1863A6300")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x63A61D0", Offset = "0x63A49D0", VA = "0x1863A61D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody AEJAAAHOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x638E9F0", Offset = "0x638D1F0", VA = "0x18638E9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode LDGJDGADDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x63A6640", Offset = "0x63A4E40", VA = "0x1863A6640", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x63A6240", Offset = "0x63A4A40", VA = "0x1863A6240", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x638F540", Offset = "0x638DD40", VA = "0x18638F540")]
	public LPKLJMGMFJL(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x63A6750", Offset = "0x63A4F50", VA = "0x1863A6750", Slot = "6")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x63A60E0", Offset = "0x63A48E0", VA = "0x1863A60E0", Slot = "9")]
	public void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x63A61C0", Offset = "0x63A49C0", VA = "0x1863A61C0", Slot = "7")]
	public void CKGADLFFCGE(bool MEDCLPBNJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x63A64C0", Offset = "0x63A4CC0", VA = "0x1863A64C0", Slot = "8")]
	public void JDMMPEFBDOC(bool MEDCLPBNJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x63A6360", Offset = "0x63A4B60", VA = "0x1863A6360", Slot = "10")]
	public bool HALNBOKHIJD(Vector3 HDJKLLNHJHP, [Out] RaycastHit GPFENAPHDDP, float EMBKCPDDBCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x63A64D0", Offset = "0x63A4CD0", VA = "0x1863A64D0")]
	private void JJAFJCPHHIN(bool MEDCLPBNJBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class ADEEHNKPBGC : BOLKAIIOIOP, IEIELLFCAND, IDisposable, EGPBCNGHIJJ
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public BPHGBOIEMNK NNHJONEBDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x638F440", Offset = "0x638DC40", VA = "0x18638F440")]
		get
		{
			return default(BPHGBOIEMNK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x638F2A0", Offset = "0x638DAA0", VA = "0x18638F2A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public BPHGBOIEMNK HOBBHNFHPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x638EFF0", Offset = "0x638D7F0", VA = "0x18638EFF0", Slot = "6")]
		get
		{
			return default(BPHGBOIEMNK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x638F2A0", Offset = "0x638DAA0", VA = "0x18638F2A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private Transform CPAPGDOKBCD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x772210", Offset = "0x770A10", VA = "0x180772210", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<CNMEGLEHJFK, CNMEGLEHJFK> NOPDCHJHHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x638F390", Offset = "0x638DB90", VA = "0x18638F390", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x638F1F0", Offset = "0x638D9F0", VA = "0x18638F1F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x638F540", Offset = "0x638DD40", VA = "0x18638F540")]
	public ADEEHNKPBGC(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x638F520", Offset = "0x638DD20", VA = "0x18638F520", Slot = "11")]
	public void OnChangedDistanceBand(CNMEGLEHJFK OBEMFNIFBAB, CNMEGLEHJFK JJFAODAJEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "12")]
	public void OnChangedVisibility(bool POJIHNGDPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "8")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class KAACFDDPGAO : BOLKAIIOIOP, FLJDFNDMMBM
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Rigidbody AEJAAAHOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x638E9F0", Offset = "0x638D1F0", VA = "0x18638E9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool HFPCJNNENJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x639FF60", Offset = "0x639E760", VA = "0x18639FF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool NPECNPKKINB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x63999D0", Offset = "0x63981D0", VA = "0x1863999D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private POGGKJJBDBG LLPGCPJGINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x63A0770", Offset = "0x639EF70", VA = "0x1863A0770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x638F540", Offset = "0x638DD40", VA = "0x18638F540")]
	public KAACFDDPGAO(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x639FE00", Offset = "0x639E600", VA = "0x18639FE00", Slot = "4")]
	public void CKDDBEKDEDO(Vector3 PPEPKNMOGPK, ForceMode FCKKFKNEIAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x63A0230", Offset = "0x639EA30", VA = "0x1863A0230")]
	private void GHIEHEDAMAA(Vector3 PPEPKNMOGPK, ForceMode FCKKFKNEIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x639FFB0", Offset = "0x639E7B0", VA = "0x18639FFB0", Slot = "5")]
	public void FJLNPDBLDOJ(Vector3 PPEPKNMOGPK, Vector3 FLFCGPFDCMD, ForceMode FCKKFKNEIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x63A07D0", Offset = "0x639EFD0", VA = "0x1863A07D0", Slot = "6")]
	public void JHCIGHLDGFH(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x63A0930", Offset = "0x639F130", VA = "0x1863A0930")]
	private void JPMMGIKPOND(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x63A0510", Offset = "0x639ED10", VA = "0x1863A0510", Slot = "7")]
	public void HOFDPKDCOLG(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x63A0B90", Offset = "0x639F390", VA = "0x1863A0B90")]
	private void OHIILDFJLAF(string OLDFIJBKFKG, UnityEngine.Object LFDLOIPEDMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class FEOJFCEEFII : BOLKAIIOIOP, PAEKHDOLDKK
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool PEDIPIDFJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x639C410", Offset = "0x639AC10", VA = "0x18639C410", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x639C470", Offset = "0x639AC70", VA = "0x18639C470", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x638F540", Offset = "0x638DD40", VA = "0x18638F540")]
	public FEOJFCEEFII(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x639C380", Offset = "0x639AB80", VA = "0x18639C380", Slot = "6")]
	public void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x639B620", Offset = "0x6399E20", VA = "0x18639B620", Slot = "7")]
	public void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class PLAGJDOPPMH : BOLKAIIOIOP, HPGIGOMAAKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly DNJICJAPBOC CIONGBLDKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly MKBEOGNKAKG LMLEHEKMGAC;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private Transform MJNMNKLDGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x63B25B0", Offset = "0x63B0DB0", VA = "0x1863B25B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public FJLCNCEHANP LALPEDNGECK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x63B2350", Offset = "0x63B0B50", VA = "0x1863B2350")]
		get
		{
			return default(FJLCNCEHANP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x63B23B0", Offset = "0x63B0BB0", VA = "0x1863B23B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public POGGKJJBDBG LLPGCPJGINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x63B1A10", Offset = "0x63B0210", VA = "0x1863B1A10", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x63B2420", Offset = "0x63B0C20", VA = "0x1863B2420", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public FJLCNCEHANP FHMBEHJKBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x63B1D10", Offset = "0x63B0510", VA = "0x1863B1D10")]
		get
		{
			return default(FJLCNCEHANP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x63B2490", Offset = "0x63B0C90", VA = "0x1863B2490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public POGGKJJBDBG NJGNBOOOJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x63B20A0", Offset = "0x63B08A0", VA = "0x1863B20A0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyList<POGGKJJBDBG> IKJOMIHCPMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x772CC0", Offset = "0x7714C0", VA = "0x180772CC0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event MNAOAJBPDNO NJEOLLLCKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x63B0D90", Offset = "0x63AF590", VA = "0x1863B0D90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x63B1160", Offset = "0x63AF960", VA = "0x1863B1160", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event MNAOAJBPDNO ACIAFKEOCDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x63B0E30", Offset = "0x63AF630", VA = "0x1863B0E30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x63B13D0", Offset = "0x63AFBD0", VA = "0x1863B13D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event LMCBABHNBJC KKHEDLEFENB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x63B10C0", Offset = "0x63AF8C0", VA = "0x1863B10C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x63B1E10", Offset = "0x63B0610", VA = "0x1863B1E10", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action LCAGGODFGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x63B0ED0", Offset = "0x63AF6D0", VA = "0x1863B0ED0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x63B1330", Offset = "0x63AFB30", VA = "0x1863B1330", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action ICGLFKNDHIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x63B1770", Offset = "0x63AFF70", VA = "0x1863B1770", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x63B1EB0", Offset = "0x63B06B0", VA = "0x1863B1EB0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<POGGKJJBDBG> DGJEOHFEFPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x63B16C0", Offset = "0x63AFEC0", VA = "0x1863B16C0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x63B0CE0", Offset = "0x63AF4E0", VA = "0x1863B0CE0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<POGGKJJBDBG> HMOFKJHBJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x63B1FF0", Offset = "0x63B07F0", VA = "0x1863B1FF0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x63B22A0", Offset = "0x63B0AA0", VA = "0x1863B22A0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action PDMLBOPCJOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x63B2110", Offset = "0x63B0910", VA = "0x1863B2110", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x63B1D70", Offset = "0x63B0570", VA = "0x1863B1D70", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<POGGKJJBDBG> OAKEJDAGKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x63B1A80", Offset = "0x63B0280", VA = "0x1863B1A80", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x63B2500", Offset = "0x63B0D00", VA = "0x1863B2500", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x63B2740", Offset = "0x63B0F40", VA = "0x1863B2740")]
	public PLAGJDOPPMH(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x63B1200", Offset = "0x63AFA00", VA = "0x1863B1200", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x63B2630", Offset = "0x63B0E30", VA = "0x1863B2630", Slot = "26")]
	public void PJMHJPJDMME(POGGKJJBDBG AKJKKHGAFEH, bool NHBKKIBCJBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x63B25E0", Offset = "0x63B0DE0", VA = "0x1863B25E0")]
	private void PJMHJPJDMME(ENJHFKIBOLH AKJKKHGAFEH, bool NHBKKIBCJBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x63B0860", Offset = "0x63AF060", VA = "0x1863B0860")]
	private void AJKGKLDDEIH(ENJHFKIBOLH AKJKKHGAFEH, bool NHBKKIBCJBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x63B1470", Offset = "0x63AFC70", VA = "0x1863B1470")]
	private void FCDHJOLCBFG(ENJHFKIBOLH GELDACEOOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x63B1810", Offset = "0x63B0010", VA = "0x1863B1810")]
	private void HEFCMPOMMAH(ENJHFKIBOLH GELDACEOOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x63B1B30", Offset = "0x63B0330", VA = "0x1863B1B30")]
	private void IAAKHDCPJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x63B1010", Offset = "0x63AF810", VA = "0x1863B1010")]
	private void BPLOKDGNOFE(ENJHFKIBOLH GELDACEOOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x63B21B0", Offset = "0x63B09B0", VA = "0x1863B21B0")]
	private void MKNJLOLGNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x63B1F50", Offset = "0x63B0750", VA = "0x1863B1F50")]
	private void INCJAOOAMKN(ENJHFKIBOLH FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x63B0F70", Offset = "0x63AF770", VA = "0x1863B0F70")]
	private void BFNAGAOKBLP(ENJHFKIBOLH FECPDCEPJMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class CPJCEOLDFGN
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x63989B0", Offset = "0x63971B0", VA = "0x1863989B0")]
	public static PLAGJDOPPMH ODEJGIOKIEL(this POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class AIAANBNHPEP : BOLKAIIOIOP, MGNMEGJCJIO
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Vector3 CIFGMIBJHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x6391850", Offset = "0x6390050", VA = "0x186391850", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 MEMIEGNNCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6390F50", Offset = "0x638F750", VA = "0x186390F50", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 PPDGIAKDDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6391760", Offset = "0x638FF60", VA = "0x186391760")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private POGGKJJBDBG OCGFAPALLBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6391600", Offset = "0x638FE00", VA = "0x186391600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x638F540", Offset = "0x638DD40", VA = "0x18638F540")]
	public AIAANBNHPEP(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6390CF0", Offset = "0x638F4F0", VA = "0x186390CF0", Slot = "6")]
	public void AGLAIAPGMJH(POGGKJJBDBG DEINPDMGBDC, object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6390E40", Offset = "0x638F640", VA = "0x186390E40")]
	private void AGLAIAPGMJH(ENJHFKIBOLH DEINPDMGBDC, object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6391590", Offset = "0x638FD90", VA = "0x186391590", Slot = "7")]
	public void KCFAFLFGJIC(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6391180", Offset = "0x638F980", VA = "0x186391180")]
	private Vector3 GJCMMPKPAPM()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class LNOGPNDIJDM
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x63A6050", Offset = "0x63A4850", VA = "0x1863A6050")]
	public static AIAANBNHPEP PICONMCALMN(this POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class LLGADFJJMOG : BOLKAIIOIOP, CGBPAEDIJBL
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 OCJFPLHJFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x63A1BE0", Offset = "0x63A03E0", VA = "0x1863A1BE0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x63A1C90", Offset = "0x63A0490", VA = "0x1863A1C90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 HKBOMIOOGIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x63A2A80", Offset = "0x63A1280", VA = "0x1863A2A80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 PBPLNIIIGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x63A1F30", Offset = "0x63A0730", VA = "0x1863A1F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 GHLIIPFFCJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x63A3310", Offset = "0x63A1B10", VA = "0x1863A3310", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float POIAJHCGEIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x63A29C0", Offset = "0x63A11C0", VA = "0x1863A29C0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float LAONMCEOHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x63A26B0", Offset = "0x63A0EB0", VA = "0x1863A26B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float FJDGCFDCMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x63A2A20", Offset = "0x63A1220", VA = "0x1863A2A20", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x63A2060", Offset = "0x63A0860", VA = "0x1863A2060", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 JGJCBHOOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x63A4E80", Offset = "0x63A3680", VA = "0x1863A4E80", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion ECFAFHPNLKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x63A1AE0", Offset = "0x63A02E0", VA = "0x1863A1AE0", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody AEJAAAHOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x638E9F0", Offset = "0x638D1F0", VA = "0x18638E9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event MNAOAJBPDNO KPPAEFKPCKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x63A38F0", Offset = "0x63A20F0", VA = "0x1863A38F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x63A2730", Offset = "0x63A0F30", VA = "0x1863A2730", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x63A5170", Offset = "0x63A3970", VA = "0x1863A5170")]
	public LLGADFJJMOG(POGGKJJBDBG FECPDCEPJMM, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x63A1E10", Offset = "0x63A0610", VA = "0x1863A1E10")]
	public float3 EPNIHHBELCO()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x63A3990", Offset = "0x63A2190", VA = "0x1863A3990", Slot = "14")]
	public void NMHLMPNFNEB((Quaternion rot, Vector3 moments) BGCIDCLPDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x63A27D0", Offset = "0x63A0FD0", VA = "0x1863A27D0", Slot = "16")]
	public void JJNHCABBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x63A2360", Offset = "0x63A0B60", VA = "0x1863A2360", Slot = "15")]
	public void HFLMIGNMBKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x63A1B10", Offset = "0x63A0310", VA = "0x1863A1B10", Slot = "18")]
	public void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x63A3500", Offset = "0x63A1D00", VA = "0x1863A3500", Slot = "19")]
	public void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x63A5110", Offset = "0x63A3910", VA = "0x1863A5110", Slot = "17")]
	public void PLLCMKJOJBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x63A2D10", Offset = "0x63A1510", VA = "0x1863A2D10", Slot = "20")]
	public void MFCCKEJINLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6399B40", Offset = "0x6398340", VA = "0x186399B40")]
	public void JCJMOGFEGOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x63A1C90", Offset = "0x63A0490", VA = "0x1863A1C90")]
	private void COEFADGIDCC(Vector3 DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x63A2B30", Offset = "0x63A1330", VA = "0x1863A2B30")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 LFHLOOHFANO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x63A2060", Offset = "0x63A0860", VA = "0x1863A2060")]
	private void GGHIGAFKEBK(float DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x63A4EB0", Offset = "0x63A36B0", VA = "0x1863A4EB0")]
	private Vector3 PEKFCBNCOPJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x63A2120", Offset = "0x63A0920", VA = "0x1863A2120")]
	private Quaternion GMINBOOJLDA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x63A3C20", Offset = "0x63A2420", VA = "0x1863A3C20")]
	internal (float, Vector3) NPGOJDGPLGD(Rigidbody NJCGEGPLHLJ)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class FNBFDHONDCO
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x639CFE0", Offset = "0x639B7E0", VA = "0x18639CFE0")]
	public static LLGADFJJMOG CFCKBHMEHMA(this POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class FIFAKLEGIJM : BOLKAIIOIOP, OPNJMHNPJFL
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool FMDODLNJCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x639C740", Offset = "0x639AF40", VA = "0x18639C740", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public GGAPDDJFBMN EAGPGMEICLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x639CE70", Offset = "0x639B670", VA = "0x18639CE70", Slot = "11")]
		get
		{
			return default(GGAPDDJFBMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private GGAPDDJFBMN NOLONDONLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x639CE70", Offset = "0x639B670", VA = "0x18639CE70")]
		get
		{
			return default(GGAPDDJFBMN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x639C7A0", Offset = "0x639AFA0", VA = "0x18639C7A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x639CED0", Offset = "0x639B6D0", VA = "0x18639CED0")]
	public FIFAKLEGIJM(POGGKJJBDBG FECPDCEPJMM, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x639CCF0", Offset = "0x639B4F0", VA = "0x18639CCF0", Slot = "4")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x639CC10", Offset = "0x639B410", VA = "0x18639CC10")]
	private bool KLCOCKCDBEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x639C5C0", Offset = "0x639ADC0", VA = "0x18639C5C0", Slot = "5")]
	public void AINHAMJFIKB(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x639CB90", Offset = "0x639B390", VA = "0x18639CB90", Slot = "6")]
	public void KHDJAPGNKKL(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x639C9B0", Offset = "0x639B1B0", VA = "0x18639C9B0", Slot = "9")]
	public void HMJPDJEHBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x639C640", Offset = "0x639AE40", VA = "0x18639C640")]
	private void APGJHGPFAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x639C810", Offset = "0x639B010", VA = "0x18639C810")]
	private void HIFDBKAHGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x639CDF0", Offset = "0x639B5F0", VA = "0x18639CDF0", Slot = "8")]
	public void LPGJLFMOLON(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x639CB10", Offset = "0x639B310", VA = "0x18639CB10", Slot = "7")]
	public void INGKLNGGEHI(POGGKJJBDBG FECPDCEPJMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class DFAHGJCPJFF : BOLKAIIOIOP, APDMJJOBGGL
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool HFPCJNNENJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x6399D10", Offset = "0x6398510", VA = "0x186399D10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool KKNHDKEBOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6399E80", Offset = "0x6398680", VA = "0x186399E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event MNAOAJBPDNO OGAFLABKONM
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6399B80", Offset = "0x6398380", VA = "0x186399B80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6399DE0", Offset = "0x63985E0", VA = "0x186399DE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x638F540", Offset = "0x638DD40", VA = "0x18638F540")]
	public DFAHGJCPJFF(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6399D70", Offset = "0x6398570", VA = "0x186399D70", Slot = "11")]
	public IDisposable JCJPJEEHIPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x639A0C0", Offset = "0x63988C0", VA = "0x18639A0C0", Slot = "8")]
	public void PEHCNDHCOOI(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6399D00", Offset = "0x6398500", VA = "0x186399D00", Slot = "9")]
	public void CMJNCADEFHC(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6399EE0", Offset = "0x63986E0", VA = "0x186399EE0", Slot = "10")]
	public void NBDAOKDHCMP(object JECMOKMEJED, bool EHOKAKODAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x6399C20", Offset = "0x6398420", VA = "0x186399C20", Slot = "12")]
	public void CGFLGPMMKNA(Rigidbody EKEIFPIAPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6399FE0", Offset = "0x63987E0", VA = "0x186399FE0", Slot = "13")]
	public void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6399B40", Offset = "0x6398340", VA = "0x186399B40", Slot = "6")]
	public void AFOAIBPAJEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class HILCBJAJKPP : BOLKAIIOIOP, FHCFOFKDBIB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PhotonView LPLCFGFEGLF;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool LIDGFPBONBF
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x639DC10", Offset = "0x639C410", VA = "0x18639DC10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool LKECHLBCGPB
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x639D0C0", Offset = "0x639B8C0", VA = "0x18639D0C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event MNAOAJBPDNO AOCFIDLDHLO
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x639D7A0", Offset = "0x639BFA0", VA = "0x18639D7A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x639D970", Offset = "0x639C170", VA = "0x18639D970", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x639DE30", Offset = "0x639C630", VA = "0x18639DE30")]
	public HILCBJAJKPP(POGGKJJBDBG FECPDCEPJMM, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x639D840", Offset = "0x639C040", VA = "0x18639D840", Slot = "8")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x639D640", Offset = "0x639BE40", VA = "0x18639D640", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x639DC30", Offset = "0x639C430", VA = "0x18639DC30", Slot = "9")]
	public void NAGIGIACEMM(POGGKJJBDBG DEINPDMGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x639DA10", Offset = "0x639C210", VA = "0x18639DA10", Slot = "10")]
	public void MJJAOFJCABM(POGGKJJBDBG DEINPDMGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x639D460", Offset = "0x639BC60", VA = "0x18639D460")]
	private void DLICDFEAOIK(PhotonView DAOOCLCDGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x639D310", Offset = "0x639BB10", VA = "0x18639D310")]
	private void CEAPAPJIMIJ(RigidbodyEx ECOCPDCNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x639D150", Offset = "0x639B950", VA = "0x18639D150")]
	private void BNGJDGKGKML(PhotonView IBNJJLPPBAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class IPFICAADDLL
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x639EBA0", Offset = "0x639D3A0", VA = "0x18639EBA0")]
	public static HILCBJAJKPP KIPDLFHCMIL(this AKOGDJKMCIG EGAILLJGEID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class POEJFFHPGJL : BOLKAIIOIOP, GPGFKDNCHEE
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool HNEBFNGJAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x63B3720", Offset = "0x63B1F20", VA = "0x1863B3720", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x63B3650", Offset = "0x63B1E50", VA = "0x1863B3650", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool EOPDNIBOEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x63B36C0", Offset = "0x63B1EC0", VA = "0x1863B36C0", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x63B3780", Offset = "0x63B1F80", VA = "0x1863B3780")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints DFKCOLAGHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x63B3560", Offset = "0x63B1D60", VA = "0x1863B3560", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x63B3870", Offset = "0x63B2070", VA = "0x1863B3870", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x63B39F0", Offset = "0x63B21F0", VA = "0x1863B39F0")]
	public POEJFFHPGJL(POGGKJJBDBG FECPDCEPJMM, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x63B35C0", Offset = "0x63B1DC0", VA = "0x1863B35C0", Slot = "9")]
	public void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x63B37F0", Offset = "0x63B1FF0", VA = "0x1863B37F0", Slot = "10")]
	public void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class AFJAKPEJIGB : BOLKAIIOIOP, NGEJIGOEOMC
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float NMHLKIHHHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x638F970", Offset = "0x638E170", VA = "0x18638F970", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x638F820", Offset = "0x638E020", VA = "0x18638F820", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float FEBHECBJBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x638F9D0", Offset = "0x638E1D0", VA = "0x18638F9D0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x638F6D0", Offset = "0x638DED0", VA = "0x18638F6D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x638F540", Offset = "0x638DD40", VA = "0x18638F540")]
	public AFJAKPEJIGB(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x638F5E0", Offset = "0x638DDE0", VA = "0x18638F5E0", Slot = "8")]
	public void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x638FA30", Offset = "0x638E230", VA = "0x18638FA30", Slot = "9")]
	public void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[GAMIKAOGCAJ(typeof(HIENMCCIMBD), new string[] { })]
public sealed class DPOLHMLMEDJ : MKBPNJOHGJA, HIENMCCIMBD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[MAEAEKFAHDI]
	private AILGFLBOLPC FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool HDNMPGDBKCJ;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool MGKHEKGJIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F30", Offset = "0x7F5730", VA = "0x1807F6F30", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x639AE60", Offset = "0x6399660", VA = "0x18639AE60", Slot = "4")]
	public void InitReferences(OFKKFGHIPBF EFCIJOEMPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x639ACF0", Offset = "0x63994F0", VA = "0x18639ACF0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x639B280", Offset = "0x6399A80", VA = "0x18639B280", Slot = "6")]
	public void NPGOJDGPLGD(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x639AFA0", Offset = "0x63997A0", VA = "0x18639AFA0", Slot = "7")]
	public void JIGBLHFHECP(FJLCNCEHANP HFMJJPJADMB, bool IHMEODGLHBA, bool IABJGKHPMFB, bool CJMCAMMPCCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x639AD20", Offset = "0x6399520", VA = "0x18639AD20", Slot = "8")]
	public void HNMDEEDDHHB(FJLCNCEHANP HFMJJPJADMB, float3 APODGKHBFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x639B3A0", Offset = "0x6399BA0", VA = "0x18639B3A0", Slot = "9")]
	public void OJKLAAHPNFO(FJLCNCEHANP HFMJJPJADMB, float3 PBDPKEGAFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x639B1C0", Offset = "0x63999C0", VA = "0x18639B1C0")]
	private bool MGEHOFFIFEN(FJLCNCEHANP HFMJJPJADMB, [Out] ENJHFKIBOLH EGAILLJGEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x639AEB0", Offset = "0x63996B0", VA = "0x18639AEB0")]
	private bool JHNPHODOPIG(FJLCNCEHANP HFMJJPJADMB, [Out] LLGADFJJMOG GNLHCOLGPNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x639AC00", Offset = "0x6399400", VA = "0x18639AC00")]
	private bool CFOMIMHPIJI(FJLCNCEHANP HFMJJPJADMB, [Out] OLKNJLPHCOD KGBCNBMIEHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public DPOLHMLMEDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class DPHFNEGOFAG : BOLKAIIOIOP, CJEHKOJIGBF
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private Rigidbody AEJAAAHOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x638E9F0", Offset = "0x638D1F0", VA = "0x18638E9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool KCHEDKBHPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x639A0D0", Offset = "0x63988D0", VA = "0x18639A0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private POGGKJJBDBG LLPGCPJGINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x639A440", Offset = "0x6398C40", VA = "0x18639A440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool NPECNPKKINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x639AA00", Offset = "0x6399200", VA = "0x18639AA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool PODDKKJFDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x639A260", Offset = "0x6398A60", VA = "0x18639A260")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x639A6D0", Offset = "0x6398ED0", VA = "0x18639A6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool NGAFOFGBMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x639A200", Offset = "0x6398A00", VA = "0x18639A200")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x639A0F0", Offset = "0x63988F0", VA = "0x18639A0F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int IIJFFNDNNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x639AA60", Offset = "0x6399260", VA = "0x18639AA60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event MNAOAJBPDNO ELOPKDOIPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x639A160", Offset = "0x6398960", VA = "0x18639A160", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x639A3A0", Offset = "0x6398BA0", VA = "0x18639A3A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x639AAD0", Offset = "0x63992D0", VA = "0x18639AAD0")]
	public DPHFNEGOFAG(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x639A740", Offset = "0x6398F40", VA = "0x18639A740", Slot = "6")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x639A990", Offset = "0x6399190", VA = "0x18639A990", Slot = "8")]
	public void NLOONHHCEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x639A7F0", Offset = "0x6398FF0", VA = "0x18639A7F0", Slot = "7")]
	public bool MLKENLCNPKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x639A4A0", Offset = "0x6398CA0", VA = "0x18639A4A0", Slot = "9")]
	public void KJOLGJJILBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6399B40", Offset = "0x6398340", VA = "0x186399B40", Slot = "12")]
	public void JFPAJDBOAJK(bool EGEEOFOOENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x639A590", Offset = "0x6398D90", VA = "0x18639A590", Slot = "11")]
	public void LKNGBPGLIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "10")]
	public void LIMHMJPDFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x639A2C0", Offset = "0x6398AC0", VA = "0x18639A2C0")]
	private void HEHBJFHOHHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class LLKAIEAGHGM : BOLKAIIOIOP, HAPFHFGLCJK
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Rigidbody AEJAAAHOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x63A5460", Offset = "0x63A3C60", VA = "0x1863A5460", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x63A5DA0", Offset = "0x63A45A0", VA = "0x1863A5DA0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool NPECNPKKINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x63999D0", Offset = "0x63981D0", VA = "0x1863999D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool KDONFFIMDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x63A5760", Offset = "0x63A3F60", VA = "0x1863A5760", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x63A5E90", Offset = "0x63A4690", VA = "0x1863A5E90")]
	public LLKAIEAGHGM(POGGKJJBDBG FECPDCEPJMM, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x63A5A90", Offset = "0x63A4290", VA = "0x1863A5A90", Slot = "5")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x63A5A10", Offset = "0x63A4210", VA = "0x1863A5A10", Slot = "7")]
	public void LJJAOAMDCMC(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x63A57C0", Offset = "0x63A3FC0", VA = "0x1863A57C0", Slot = "8")]
	public void HIJLGBEGIJI(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x63A5540", Offset = "0x63A3D40", VA = "0x1863A5540", Slot = "9")]
	public void GBJJIEEPEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x63A5B40", Offset = "0x63A4340", VA = "0x1863A5B40", Slot = "11")]
	public void NFBPOGJFOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x63A5840", Offset = "0x63A4040", VA = "0x1863A5840", Slot = "12")]
	public void KHCPIMLGLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "10")]
	public void ONNJPBCNPIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class OLKNJLPHCOD : BOLKAIIOIOP, HKBIMCGMLPJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public FNFCKEINJLI BMJIADBDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x63ADBC0", Offset = "0x63AC3C0", VA = "0x1863ADBC0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x63AD970", Offset = "0x63AC170", VA = "0x1863AD970", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public CCOBILGDEMA JKMLFKFFLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x63AFFA0", Offset = "0x63AE7A0", VA = "0x1863AFFA0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x63B03E0", Offset = "0x63AEBE0", VA = "0x1863B03E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 PPDGIAKDDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x63AF780", Offset = "0x63ADF80", VA = "0x1863AF780", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x63AF6C0", Offset = "0x63ADEC0", VA = "0x1863AF6C0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 HJMJIBMHPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x63AEC00", Offset = "0x63AD400", VA = "0x1863AEC00", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x63AE9C0", Offset = "0x63AD1C0", VA = "0x1863AE9C0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 PBHMNNEDFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x63AD220", Offset = "0x63ABA20", VA = "0x1863AD220", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x63AD9E0", Offset = "0x63AC1E0", VA = "0x1863AD9E0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 NOLJCEALFMH
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x63AD0E0", Offset = "0x63AB8E0", VA = "0x1863AD0E0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x63AFA60", Offset = "0x63AE260", VA = "0x1863AFA60", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float OFLBICEGOHF
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x63AF1E0", Offset = "0x63AD9E0", VA = "0x1863AF1E0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x63AEAB0", Offset = "0x63AD2B0", VA = "0x1863AEAB0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool GLDNNIEGOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x63AE960", Offset = "0x63AD160", VA = "0x1863AE960", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private FLJDFNDMMBM OODMMCKEFCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1CB75A0", Offset = "0x1CB5DA0", VA = "0x181CB75A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool KCHEDKBHPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x639A0D0", Offset = "0x63988D0", VA = "0x18639A0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x638F540", Offset = "0x638DD40", VA = "0x18638F540")]
	public OLKNJLPHCOD(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x63AF240", Offset = "0x63ADA40", VA = "0x1863AF240", Slot = "20")]
	public void LJKLCOHFDNP(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x63AFDF0", Offset = "0x63AE5F0", VA = "0x1863AFDF0", Slot = "30")]
	public void NMKAMGJMLNI(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x63AD170", Offset = "0x63AB970", VA = "0x1863AD170", Slot = "19")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x63ADB00", Offset = "0x63AC300", VA = "0x1863ADB00", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x63AD800", Offset = "0x63AC000", VA = "0x1863AD800", Slot = "28")]
	public void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x63AE160", Offset = "0x63AC960", VA = "0x1863AE160", Slot = "35")]
	public Vector3 FHBGLKBMNCP(Vector3 OHFPEKLPEIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x63B0050", Offset = "0x63AE850", VA = "0x1863B0050", Slot = "34")]
	public Vector3 PAKBHMIDCFN(Vector3 APODGKHBFFA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x63AD170", Offset = "0x63AB970", VA = "0x1863AD170", Slot = "27")]
	public void BBOGKPNJBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x63ADAA0", Offset = "0x63AC2A0", VA = "0x1863ADAA0", Slot = "25")]
	public void DKOPONKEFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x63AEA50", Offset = "0x63AD250", VA = "0x1863AEA50", Slot = "24")]
	public void HHDDHHOIEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x63ADC70", Offset = "0x63AC470", VA = "0x1863ADC70", Slot = "33")]
	public void EOLOBIKHGKC(Vector3 BOIAGDGMNAH, Vector3 NFFCADAKPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x63AFF40", Offset = "0x63AE740", VA = "0x1863AFF40", Slot = "32")]
	public void OGFHPENECCK(Vector3 KBAMJEPPMDE, Vector3 PBDPKEGAFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x63B0210", Offset = "0x63AEA10", VA = "0x1863B0210", Slot = "31")]
	public void PFHBAFGLOKF(Vector3 KPJFPLIJJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x63ACB70", Offset = "0x63AB370", VA = "0x1863ACB70", Slot = "22")]
	public void AJBOHICGGKK(EHJPDGLKMMO DADIMGHMLOP, Vector3 LIJNNJCBAEJ, float FKHPADCABCD, float HDNCDJHLDBB = 8f, float GCNJLKJIGFF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x63ADEB0", Offset = "0x63AC6B0", VA = "0x1863ADEB0", Slot = "21")]
	public void FBGHMOEINPA(MCPIEBENNGH BAPJDGLKOEF, Vector3 LEDLJNHCDLO, float BLJLIMNEJDP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x63AF2B0", Offset = "0x63ADAB0", VA = "0x1863AF2B0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LLJNMOLMGDL(MCPIEBENNGH BAPJDGLKOEF, Vector3 JOBDANNFLEE, float NKKKJJHPIPH = 7f, float IDADDGNGKCJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x63AFE60", Offset = "0x63AE660", VA = "0x1863AFE60", Slot = "29")]
	public Vector3 OEGANIFDLFG(Vector3 GNMILCCIALP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x63AFC60", Offset = "0x63AE460", VA = "0x1863AFC60", Slot = "26")]
	public void NJOOAFJBPPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x63AEAB0", Offset = "0x63AD2B0", VA = "0x1863AEAB0")]
	private void LONAIFJHJGN(float DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x63AFA90", Offset = "0x63AE290", VA = "0x1863AFA90")]
	private void NJGENMNAOJP(Vector3 LEDLJNHCDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x63AF7E0", Offset = "0x63ADFE0", VA = "0x1863AF7E0")]
	private Vector3 MHBDCHJBEPB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x63AD280", Offset = "0x63ABA80", VA = "0x1863AD280")]
	private void CDMGMKCJPCK(Vector3 APODGKHBFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x63AC8E0", Offset = "0x63AB0E0", VA = "0x1863AC8E0")]
	private Vector3 ABDOGEEGNAM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x63AE340", Offset = "0x63ACB40", VA = "0x1863AE340")]
	private void FHICHLFFGAM(Vector3 DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x63AD110", Offset = "0x63AB910", VA = "0x1863AD110")]
	private void AMMNGOGLBAP(Vector3 GNMILCCIALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x63AE9F0", Offset = "0x63AD1F0", VA = "0x1863AE9F0")]
	private void HGCGDMCOLJL(Vector3 FGDMIAMGAFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x63AEC30", Offset = "0x63AD430", VA = "0x1863AEC30")]
	private void LEHNJKFPBMD(string DFKBJHMCCNM, Vector3 DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x63AE8B0", Offset = "0x63AD0B0", VA = "0x1863AE8B0")]
	private void GDBGEPAOMNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class BOLKAIIOIOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly ENJHFKIBOLH FECPDCEPJMM;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected AILGFLBOLPC OAHHJMMHLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5513360", Offset = "0x5511B60", VA = "0x185513360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x55133A0", Offset = "0x5511BA0", VA = "0x1855133A0")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x638F540", Offset = "0x638DD40", VA = "0x18638F540")]
	public BOLKAIIOIOP(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x6398830", Offset = "0x6397030", VA = "0x186398830")]
	protected POGGKJJBDBG HJNNOONEOMP(FJLCNCEHANP PDNACDIBMJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class BHLMBOLDIPB : NCOOLHKGNAN
{
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x63978D0", Offset = "0x63960D0", VA = "0x1863978D0", Slot = "4")]
	public HPGIGOMAAKB AFGINIHHGCD(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6397F00", Offset = "0x6396700", VA = "0x186397F00", Slot = "5")]
	public HKBIMCGMLPJ FCNMBFEAADH(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6398380", Offset = "0x6396B80", VA = "0x186398380", Slot = "6")]
	public MGNMEGJCJIO JMGCKPMDLND(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6398220", Offset = "0x6396A20", VA = "0x186398220", Slot = "7")]
	public NGEJIGOEOMC IBIACGPIINK(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6397BB0", Offset = "0x63963B0", VA = "0x186397BB0", Slot = "8")]
	public CJEHKOJIGBF CPGPCFIDIJG(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6398750", Offset = "0x6396F50", VA = "0x186398750", Slot = "9")]
	public IEIELLFCAND PPINIDDDGGJ(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6397E20", Offset = "0x6396620", VA = "0x186397E20", Slot = "10")]
	public APDMJJOBGGL DJEIDEIEBAM(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6398460", Offset = "0x6396C60", VA = "0x186398460", Slot = "11")]
	public FLJDFNDMMBM MANPFJECCFK(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6397930", Offset = "0x6396130", VA = "0x186397930", Slot = "12")]
	public EJPEEHDHNOM AJJOBCIDKAJ(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6398540", Offset = "0x6396D40", VA = "0x186398540", Slot = "13")]
	public PAEKHDOLDKK MIIEIDJAIED(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6397FE0", Offset = "0x63967E0", VA = "0x186397FE0")]
	public HAPFHFGLCJK HIGLLJIGHIJ(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6397D20", Offset = "0x6396520", VA = "0x186397D20")]
	public FHCFOFKDBIB DBCEBDCGAOO(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x63980E0", Offset = "0x63968E0", VA = "0x1863980E0")]
	public OPNJMHNPJFL GPJOCDMGGBK(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6398300", Offset = "0x6396B00", VA = "0x186398300")]
	public CGBPAEDIJBL IGOMBOELLNI(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6397A10", Offset = "0x6396210", VA = "0x186397A10")]
	public GPGFKDNCHEE AMMDKDEKPBM(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6398620", Offset = "0x6396E20", VA = "0x186398620", Slot = "19")]
	public POGGKJJBDBG MNFLNCEGJAE(RigidbodyEx FECPDCEPJMM, INKLBHHLMIO FCHBDAMJEHN, AMANEILBFPD CLDKLPDMMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public BHLMBOLDIPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6397FE0", Offset = "0x63967E0", VA = "0x186397FE0", Slot = "14")]
	private HAPFHFGLCJK FDLGNKNCNDB(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6397D20", Offset = "0x6396520", VA = "0x186397D20", Slot = "15")]
	private FHCFOFKDBIB GOBBLEMPFAF(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x63980E0", Offset = "0x63968E0", VA = "0x1863980E0", Slot = "16")]
	private OPNJMHNPJFL HPEOBCEFJEJ(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6398300", Offset = "0x6396B00", VA = "0x186398300", Slot = "17")]
	private CGBPAEDIJBL KOPIJAJINMJ(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6398370", Offset = "0x6396B70", VA = "0x186398370", Slot = "18")]
	private GPGFKDNCHEE INCAGNIHKMA(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public sealed class MKBEOGNKAKG : IReadOnlyList<POGGKJJBDBG>, IEnumerable<POGGKJJBDBG>, IEnumerable, IReadOnlyCollection<POGGKJJBDBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly AILGFLBOLPC NECECMHOHDJ;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x63A76A0", Offset = "0x63A5EA0", VA = "0x1863A76A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public POGGKJJBDBG OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x63A7550", Offset = "0x63A5D50", VA = "0x1863A7550", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x4235AB0", Offset = "0x42342B0", VA = "0x184235AB0")]
	public MKBEOGNKAKG(FJLCNCEHANP PDNACDIBMJE, AILGFLBOLPC NECECMHOHDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x63A7440", Offset = "0x63A5C40", VA = "0x1863A7440", Slot = "6")]
	public IEnumerator<POGGKJJBDBG> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x63A7440", Offset = "0x63A5C40", VA = "0x1863A7440", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x63A7550", Offset = "0x63A5D50", VA = "0x1863A7550")]
	[CompilerGenerated]
	private POGGKJJBDBG LBJIJLECIPD(int BOCONGADANC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[GAMIKAOGCAJ(typeof(NCOOLHKGNAN), new string[] { })]
public class JANAGLBDDLI : NCOOLHKGNAN, MKBPNJOHGJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly NCOOLHKGNAN ACLOJGBDHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly NCOOLHKGNAN HNBBKFNICEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private JHFKEPJCCJB HOBCKHPFNDP;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private NCOOLHKGNAN ECJDOOMNBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x639F650", Offset = "0x639DE50", VA = "0x18639F650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x639F330", Offset = "0x639DB30", VA = "0x18639F330", Slot = "20")]
	public void InitReferences(OFKKFGHIPBF EFCIJOEMPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x639EC00", Offset = "0x639D400", VA = "0x18639EC00", Slot = "4")]
	public HPGIGOMAAKB AFGINIHHGCD(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x639EFE0", Offset = "0x639D7E0", VA = "0x18639EFE0", Slot = "5")]
	public HKBIMCGMLPJ FCNMBFEAADH(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x639F380", Offset = "0x639DB80", VA = "0x18639F380", Slot = "6")]
	public MGNMEGJCJIO JMGCKPMDLND(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x639F1E0", Offset = "0x639D9E0", VA = "0x18639F1E0", Slot = "7")]
	public NGEJIGOEOMC IBIACGPIINK(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x639EDF0", Offset = "0x639D5F0", VA = "0x18639EDF0", Slot = "8")]
	public CJEHKOJIGBF CPGPCFIDIJG(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x639F6B0", Offset = "0x639DEB0", VA = "0x18639F6B0", Slot = "9")]
	public IEIELLFCAND PPINIDDDGGJ(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x639EF40", Offset = "0x639D740", VA = "0x18639EF40", Slot = "10")]
	public APDMJJOBGGL DJEIDEIEBAM(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x639F420", Offset = "0x639DC20", VA = "0x18639F420", Slot = "11")]
	public FLJDFNDMMBM MANPFJECCFK(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x639ECA0", Offset = "0x639D4A0", VA = "0x18639ECA0", Slot = "12")]
	public EJPEEHDHNOM AJJOBCIDKAJ(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x639F4C0", Offset = "0x639DCC0", VA = "0x18639F4C0", Slot = "13")]
	public PAEKHDOLDKK MIIEIDJAIED(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x639F080", Offset = "0x639D880", VA = "0x18639F080")]
	public HAPFHFGLCJK HIGLLJIGHIJ(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x639EE90", Offset = "0x639D690", VA = "0x18639EE90")]
	public FHCFOFKDBIB DBCEBDCGAOO(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x639F130", Offset = "0x639D930", VA = "0x18639F130")]
	public OPNJMHNPJFL GPJOCDMGGBK(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x639F280", Offset = "0x639DA80", VA = "0x18639F280")]
	public CGBPAEDIJBL IGOMBOELLNI(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x639ED40", Offset = "0x639D540", VA = "0x18639ED40")]
	public GPGFKDNCHEE AMMDKDEKPBM(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x639F560", Offset = "0x639DD60", VA = "0x18639F560", Slot = "19")]
	public POGGKJJBDBG MNFLNCEGJAE(RigidbodyEx FECPDCEPJMM, INKLBHHLMIO FCHBDAMJEHN, AMANEILBFPD CLDKLPDMMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x639F750", Offset = "0x639DF50", VA = "0x18639F750")]
	public JANAGLBDDLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x639F080", Offset = "0x639D880", VA = "0x18639F080", Slot = "14")]
	private HAPFHFGLCJK FDLGNKNCNDB(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x639EE90", Offset = "0x639D690", VA = "0x18639EE90", Slot = "15")]
	private FHCFOFKDBIB GOBBLEMPFAF(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x639F130", Offset = "0x639D930", VA = "0x18639F130", Slot = "16")]
	private OPNJMHNPJFL HPEOBCEFJEJ(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x639F280", Offset = "0x639DA80", VA = "0x18639F280", Slot = "17")]
	private CGBPAEDIJBL KOPIJAJINMJ(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x639ED40", Offset = "0x639D540", VA = "0x18639ED40", Slot = "18")]
	private GPGFKDNCHEE INCAGNIHKMA(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[UnityEngine.Scripting.Preserve]
public sealed class KMIPCGLONLL : POGGKJJBDBG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly KMIPCGLONLL ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Rigidbody AEJAAAHOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x773B10", Offset = "0x772310", VA = "0x180773B10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public RigidbodyEx HMCMHGPEDHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GameObject KFEADEMCIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Transform MJNMNKLDGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7790D0", Offset = "0x7778D0", VA = "0x1807790D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public POGGKJJBDBG LLPGCPJGINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x773B40", Offset = "0x772340", VA = "0x180773B40", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x773B70", Offset = "0x772370", VA = "0x180773B70", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IReadOnlyList<POGGKJJBDBG> IKJOMIHCPMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x778B40", Offset = "0x777340", VA = "0x180778B40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public POGGKJJBDBG NJGNBOOOJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x778B20", Offset = "0x777320", VA = "0x180778B20", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool LIDGFPBONBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7DFA70", Offset = "0x7DE270", VA = "0x1807DFA70", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool LKECHLBCGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xD24250", Offset = "0xD22A50", VA = "0x180D24250", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public FNFCKEINJLI BMJIADBDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x772C80", Offset = "0x771480", VA = "0x180772C80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x772CA0", Offset = "0x7714A0", VA = "0x180772CA0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public CCOBILGDEMA JKMLFKFFLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x772C70", Offset = "0x771470", VA = "0x180772C70", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x772C90", Offset = "0x771490", VA = "0x180772C90", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float OFLBICEGOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x9B5CE0", Offset = "0x9B44E0", VA = "0x1809B5CE0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x871E00", Offset = "0x870600", VA = "0x180871E00", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 HJMJIBMHPKO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1AD15C0", Offset = "0x1ACFDC0", VA = "0x181AD15C0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x39D5F00", Offset = "0x39D4700", VA = "0x1839D5F00", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 NOLJCEALFMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x63A0D30", Offset = "0x639F530", VA = "0x1863A0D30", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x63A0D70", Offset = "0x639F570", VA = "0x1863A0D70", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 PPDGIAKDDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x3F055C0", Offset = "0x3F03DC0", VA = "0x183F055C0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x19FC9F0", Offset = "0x19FB1F0", VA = "0x1819FC9F0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 PBHMNNEDFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xAE0AD0", Offset = "0xADF2D0", VA = "0x180AE0AD0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool JHANJIIICHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8F4340", Offset = "0x8F2B40", VA = "0x1808F4340", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool BLENKJNIOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1713540", Offset = "0x1711D40", VA = "0x181713540", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool GLDNNIEGOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5C93EC0", Offset = "0x5C926C0", VA = "0x185C93EC0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 CIFGMIBJHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x3F08440", Offset = "0x3F06C40", VA = "0x183F08440", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 MEMIEGNNCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x943620", Offset = "0x941E20", VA = "0x180943620", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 OCJFPLHJFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xAE0AD0", Offset = "0xADF2D0", VA = "0x180AE0AD0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 GHLIIPFFCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x63A0D80", Offset = "0x639F580", VA = "0x1863A0D80", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float POIAJHCGEIE
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x542E410", Offset = "0x542CC10", VA = "0x18542E410", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float FJDGCFDCMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F70", Offset = "0x7C5770", VA = "0x1807C6F70", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 JGJCBHOOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xAE0AD0", Offset = "0xADF2D0", VA = "0x180AE0AD0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion ECFAFHPNLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7C51C0", Offset = "0x7C39C0", VA = "0x1807C51C0", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float NMHLKIHHHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F70", Offset = "0x7C5770", VA = "0x1807C6F70", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float FEBHECBJBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F70", Offset = "0x7C5770", VA = "0x1807C6F70", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool PEDIPIDFJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public BPHGBOIEMNK HOBBHNFHPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "48")]
		get
		{
			return default(BPHGBOIEMNK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool HFPCJNNENJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x11865C0", Offset = "0x1184DC0", VA = "0x1811865C0", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Transform JIGIMPEEGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x8C4180", Offset = "0x8C2980", VA = "0x1808C4180", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 EMMCDGJCGBO
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xAE0AD0", Offset = "0xADF2D0", VA = "0x180AE0AD0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float GMFFIOIPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F70", Offset = "0x7C5770", VA = "0x1807C6F70", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float MIMEPHPGCNN
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F70", Offset = "0x7C5770", VA = "0x1807C6F70", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion NCMEEMHABEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x968510", Offset = "0x966D10", VA = "0x180968510", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 HAONNNBKPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xAE0AD0", Offset = "0xADF2D0", VA = "0x180AE0AD0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion MGBCJOLDJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x968510", Offset = "0x966D10", VA = "0x180968510", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints DFKCOLAGHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x772210", Offset = "0x770A10", VA = "0x180772210", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool HNEBFNGJAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CollisionDetectionMode LDGJDGADDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x772210", Offset = "0x770A10", VA = "0x180772210", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool JNDOHIHFOND
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x880DB0", Offset = "0x87F5B0", VA = "0x180880DB0", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event MNAOAJBPDNO NJEOLLLCKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event MNAOAJBPDNO ACIAFKEOCDM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event LMCBABHNBJC KKHEDLEFENB
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event MNAOAJBPDNO AOCFIDLDHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event MNAOAJBPDNO HFGAHMOBFHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event MNAOAJBPDNO ELOPKDOIPDF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<CNMEGLEHJFK, CNMEGLEHJFK> NOPDCHJHHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event MNAOAJBPDNO OGAFLABKONM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event MNAOAJBPDNO KEOAECKKAAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "41")]
	public void NMHLMPNFNEB((Quaternion rot, Vector3 moments) BGCIDCLPDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "71")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "72")]
	public void IAKKLBIFDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "73")]
	public void IALOONNAOHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "74")]
	public void KJOLGJJILBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "81")]
	public void PJMHJPJDMME(POGGKJJBDBG DOLICEBFIPF, bool NHBKKIBCJBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "84")]
	public void EALMAGOLHAM(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "85")]
	public void NBMPEEEJOOM(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xAE0AD0", Offset = "0xADF2D0", VA = "0x180AE0AD0", Slot = "86")]
	public Vector3 FHBGLKBMNCP(Vector3 OHFPEKLPEIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xAE0AD0", Offset = "0xADF2D0", VA = "0x180AE0AD0", Slot = "87")]
	public Vector3 PAKBHMIDCFN(Vector3 APODGKHBFFA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "88")]
	public void BBOGKPNJBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "89")]
	public void DKOPONKEFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "90")]
	public void HHDDHHOIEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "91")]
	public void EOLOBIKHGKC(Vector3 BOIAGDGMNAH, Vector3 NFFCADAKPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "92")]
	public void OGFHPENECCK(Vector3 KBAMJEPPMDE, Vector3 PBDPKEGAFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "93")]
	public void PFHBAFGLOKF(Vector3 KPJFPLIJJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "94")]
	public void AJBOHICGGKK(EHJPDGLKMMO DADIMGHMLOP, Vector3 LIJNNJCBAEJ, float FKHPADCABCD, float HDNCDJHLDBB = 8f, float GCNJLKJIGFF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "95")]
	public void FBGHMOEINPA(MCPIEBENNGH BAPJDGLKOEF, Vector3 LEDLJNHCDLO, float BLJLIMNEJDP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "96")]
	public void LLJNMOLMGDL(MCPIEBENNGH BAPJDGLKOEF, Vector3 JOBDANNFLEE, float NKKKJJHPIPH = 7f, float IDADDGNGKCJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xAE0AD0", Offset = "0xADF2D0", VA = "0x180AE0AD0", Slot = "97")]
	public Vector3 OEGANIFDLFG(Vector3 DOLICEBFIPF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xAE0AD0", Offset = "0xADF2D0", VA = "0x180AE0AD0", Slot = "98")]
	public Vector3 PIPFNMLLCJH(Vector3 DOLICEBFIPF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "99")]
	public void NJOOAFJBPPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "100")]
	public void HAAPCJDCEBK(POGGKJJBDBG CCPGANDNELJ, object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "101")]
	public void MKPOIADAHKB(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "104")]
	public void JJNHCABBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "105")]
	public void HFLMIGNMBKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "106")]
	public void PLLCMKJOJBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "109")]
	public bool MLKENLCNPKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "110")]
	public void LKNGBPGLIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x772210", Offset = "0x770A10", VA = "0x180772210", Slot = "115")]
	public IDisposable JCJPJEEHIPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "116")]
	public void PEHCNDHCOOI(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "117")]
	public void CMJNCADEFHC(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "118")]
	public void NBDAOKDHCMP(object JECMOKMEJED, bool EHOKAKODAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "121")]
	public void MHGMHGKMGBM(Vector3 DOHLFDBOKIE, Quaternion EIHDCMDHFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "122")]
	public void CGHOIONKBHH(Vector3 LKKNBMNGINO, Quaternion PBEHPLLCMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "123")]
	public bool PNKADAMPJHB(float HOEPBGDAMOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "124")]
	public void CFJPJHIJLBP(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "125")]
	public void AJOBODFBJEB(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "126")]
	public void LJJAOAMDCMC(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "127")]
	public void HIJLGBEGIJI(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "128")]
	public void CKDDBEKDEDO(Vector3 PPEPKNMOGPK, ForceMode FCKKFKNEIAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "129")]
	public void FJLNPDBLDOJ(Vector3 PPEPKNMOGPK, Vector3 FLFCGPFDCMD, ForceMode FCKKFKNEIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "130")]
	public void JHCIGHLDGFH(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "131")]
	public void HOFDPKDCOLG(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x63A0D50", Offset = "0x639F550", VA = "0x1863A0D50", Slot = "132")]
	public bool HALNBOKHIJD(Vector3 HDJKLLNHJHP, [Out] RaycastHit GPFENAPHDDP, float EMBKCPDDBCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "133")]
	public void MFCCKEJINLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public KMIPCGLONLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class ENJHFKIBOLH : AKOGDJKMCIG, BKONHFHHNPH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal AILGFLBOLPC BIMKCNLDLJP;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6397740", Offset = "0x6395F40", VA = "0x186397740")]
	public ENJHFKIBOLH(GameObject AOMHCMIECFG, RigidbodyEx JFHPHBFCOGJ, AMANEILBFPD CLDKLPDMMOI, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x639BC80", Offset = "0x639A480", VA = "0x18639BC80", Slot = "135")]
	protected override void LDMDFIKAJNH(AMANEILBFPD CLDKLPDMMOI, INKLBHHLMIO FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x772210", Offset = "0x770A10", VA = "0x180772210", Slot = "141")]
	protected override IDisposable HLKPAKHFDEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x639B820", Offset = "0x639A020", VA = "0x18639B820", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x639B750", Offset = "0x6399F50", VA = "0x18639B750", Slot = "142")]
	public void CIGMOAFANAD(PFMKCMICBGB OBEMFNIFBAB, PFMKCMICBGB JJFAODAJEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x639BEF0", Offset = "0x639A6F0", VA = "0x18639BEF0", Slot = "143")]
	public void MLLMKNBNJPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x639B690", Offset = "0x6399E90", VA = "0x18639B690", Slot = "144")]
	public void BINLDMHLKMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x639BBC0", Offset = "0x639A3C0", VA = "0x18639BBC0", Slot = "145")]
	public void JFPAJDBOAJK(bool EGEEOFOOENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x639BFB0", Offset = "0x639A7B0", VA = "0x18639BFB0", Slot = "146")]
	public bool OCDFBPGODKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x639BC20", Offset = "0x639A420", VA = "0x18639BC20", Slot = "147")]
	public void JLLDJKAJBLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "140")]
	protected override void MHACMGOMHFA(RigidbodyEx CCHIEENNEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x639B990", Offset = "0x639A190", VA = "0x18639B990")]
	private void GJCDBPHEOHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class GEEHGDGKPNE
{
	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x639D070", Offset = "0x639B870", VA = "0x18639D070")]
	public static AKOGDJKMCIG EKDFKFEPMGE(this POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface CCFIPPFAEBG : HPGIGOMAAKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INCJAOOAMKN(POGGKJJBDBG FECPDCEPJMM);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFNAGAOKBLP(POGGKJJBDBG FECPDCEPJMM);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FCDHJOLCBFG(POGGKJJBDBG GELDACEOOLL);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HEFCMPOMMAH(POGGKJJBDBG GELDACEOOLL);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface NNCGHGPKFPJ : MGNMEGJCJIO
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	AFBJGAIEKPN<POGGKJJBDBG> NPMFIIEOAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	POGGKJJBDBG OCGFAPALLBK
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface CDIIDBLGLCN : CGBPAEDIJBL
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) NPGOJDGPLGD(Rigidbody NJCGEGPLHLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface OAJLIJDLOMA : FHCFOFKDBIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PhotonView FMJACDFLFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class ABIFPHMADKD : EJPEEHDHNOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly AKOGDJKMCIG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private CollisionDetectionMode OPHJLIHPEPH;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private Rigidbody AEJAAAHOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x638E9F0", Offset = "0x638D1F0", VA = "0x18638E9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode LDGJDGADDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x638ED40", Offset = "0x638D540", VA = "0x18638ED40", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x638EA40", Offset = "0x638D240", VA = "0x18638EA40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x638EF60", Offset = "0x638D760", VA = "0x18638EF60")]
	public ABIFPHMADKD(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x638EE50", Offset = "0x638D650", VA = "0x18638EE50", Slot = "6")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x638E960", Offset = "0x638D160", VA = "0x18638E960", Slot = "9")]
	public void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x638E9E0", Offset = "0x638D1E0", VA = "0x18638E9E0", Slot = "7")]
	public void CKGADLFFCGE(bool MEDCLPBNJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x638EC10", Offset = "0x638D410", VA = "0x18638EC10", Slot = "8")]
	public void JDMMPEFBDOC(bool MEDCLPBNJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x638EAB0", Offset = "0x638D2B0", VA = "0x18638EAB0", Slot = "10")]
	public bool HALNBOKHIJD(Vector3 HDJKLLNHJHP, [Out] RaycastHit GPFENAPHDDP, float EMBKCPDDBCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x638EC20", Offset = "0x638D420", VA = "0x18638EC20")]
	private void JJAFJCPHHIN(bool MEDCLPBNJBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class OKMIAJADECH : IEIELLFCAND, IDisposable, EGPBCNGHIJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly AKOGDJKMCIG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private BPHGBOIEMNK KMJDMHFDIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private KDNKFCKOHOL IHFGNENKDDH;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public BPHGBOIEMNK HOBBHNFHPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x63AC160", Offset = "0x63AA960", VA = "0x1863AC160", Slot = "6")]
		get
		{
			return default(BPHGBOIEMNK);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x63AC360", Offset = "0x63AAB60", VA = "0x1863AC360", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform CPAPGDOKBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x63AC4E0", Offset = "0x63AACE0", VA = "0x1863AC4E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<CNMEGLEHJFK, CNMEGLEHJFK> NOPDCHJHHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x63AC430", Offset = "0x63AAC30", VA = "0x1863AC430", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x63AC2B0", Offset = "0x63AAAB0", VA = "0x1863AC2B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x63AC850", Offset = "0x63AB050", VA = "0x1863AC850")]
	public OKMIAJADECH(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x63AC550", Offset = "0x63AAD50", VA = "0x1863AC550", Slot = "8")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x63AC500", Offset = "0x63AAD00", VA = "0x1863AC500", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1B50D70", Offset = "0x1B4F570", VA = "0x181B50D70", Slot = "11")]
	private void DPKHLFMANLF(CNMEGLEHJFK PHOGCBLPLDJ, CNMEGLEHJFK EPMBKIEBGGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "12")]
	private void LOJIBOMAOGJ(bool POJIHNGDPFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class LAJMFIEAFDG : FLJDFNDMMBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly AKOGDJKMCIG FECPDCEPJMM;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Rigidbody AEJAAAHOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x638E9F0", Offset = "0x638D1F0", VA = "0x18638E9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool HFPCJNNENJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x639FF60", Offset = "0x639E760", VA = "0x18639FF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool NPECNPKKINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x63999D0", Offset = "0x63981D0", VA = "0x1863999D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private POGGKJJBDBG LLPGCPJGINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x63A16C0", Offset = "0x639FEC0", VA = "0x1863A16C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x638EF60", Offset = "0x638D760", VA = "0x18638EF60")]
	public LAJMFIEAFDG(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x63A0E20", Offset = "0x639F620", VA = "0x1863A0E20", Slot = "4")]
	public void CKDDBEKDEDO(Vector3 PPEPKNMOGPK, ForceMode FCKKFKNEIAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x63A1200", Offset = "0x639FA00", VA = "0x1863A1200")]
	private void GHIEHEDAMAA(Vector3 PPEPKNMOGPK, ForceMode FCKKFKNEIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x63A0F80", Offset = "0x639F780", VA = "0x1863A0F80", Slot = "5")]
	public void FJLNPDBLDOJ(Vector3 PPEPKNMOGPK, Vector3 FLFCGPFDCMD, ForceMode FCKKFKNEIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x63A1720", Offset = "0x639FF20", VA = "0x1863A1720", Slot = "6")]
	public void JHCIGHLDGFH(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x63A1880", Offset = "0x63A0080", VA = "0x1863A1880")]
	private void JPMMGIKPOND(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x63A1460", Offset = "0x639FC60", VA = "0x1863A1460", Slot = "7")]
	public void HOFDPKDCOLG(Vector3 EHGDKIFNEPL, ForceMode FCKKFKNEIAA = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class EBIMPMCIBMH : PAEKHDOLDKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly AKOGDJKMCIG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool HHHGOMLBOAB;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool PEDIPIDFJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F30", Offset = "0x7F5730", VA = "0x1807F6F30", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x639B510", Offset = "0x6399D10", VA = "0x18639B510", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x638EF60", Offset = "0x638D760", VA = "0x18638EF60")]
	public EBIMPMCIBMH(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x639B4E0", Offset = "0x6399CE0", VA = "0x18639B4E0", Slot = "6")]
	public void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x639B620", Offset = "0x6399E20", VA = "0x18639B620", Slot = "7")]
	public void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class MOBODPKAONI : CCFIPPFAEBG, HPGIGOMAAKB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly POGGKJJBDBG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<POGGKJJBDBG> HKNJLPPIDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private POGGKJJBDBG PHEKGOFMNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private POGGKJJBDBG DEINPDMGBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform AIPCPGDBFNE;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private Transform MJNMNKLDGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x63ABAC0", Offset = "0x63AA2C0", VA = "0x1863ABAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public POGGKJJBDBG LLPGCPJGINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x779F00", Offset = "0x778700", VA = "0x180779F00", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x63ABA00", Offset = "0x63AA200", VA = "0x1863ABA00", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public POGGKJJBDBG NJGNBOOOJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x779ED0", Offset = "0x7786D0", VA = "0x180779ED0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IReadOnlyList<POGGKJJBDBG> IKJOMIHCPMF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x772CC0", Offset = "0x7714C0", VA = "0x180772CC0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event MNAOAJBPDNO NJEOLLLCKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x63AA330", Offset = "0x63A8B30", VA = "0x1863AA330", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x63AA7D0", Offset = "0x63A8FD0", VA = "0x1863AA7D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event MNAOAJBPDNO ACIAFKEOCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x63AA3D0", Offset = "0x63A8BD0", VA = "0x1863AA3D0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x63AA9B0", Offset = "0x63A91B0", VA = "0x1863AA9B0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event LMCBABHNBJC KKHEDLEFENB
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x63AA730", Offset = "0x63A8F30", VA = "0x1863AA730", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x63AB370", Offset = "0x63A9B70", VA = "0x1863AB370", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action LCAGGODFGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x63AA470", Offset = "0x63A8C70", VA = "0x1863AA470", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x63AA910", Offset = "0x63A9110", VA = "0x1863AA910", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action ICGLFKNDHIO
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x63AAE60", Offset = "0x63A9660", VA = "0x1863AAE60", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x63AB410", Offset = "0x63A9C10", VA = "0x1863AB410", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<POGGKJJBDBG> DGJEOHFEFPH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x63AACC0", Offset = "0x63A94C0", VA = "0x1863AACC0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x63AA280", Offset = "0x63A8A80", VA = "0x1863AA280", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<POGGKJJBDBG> HMOFKJHBJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x63AB6D0", Offset = "0x63A9ED0", VA = "0x1863AB6D0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x63AB950", Offset = "0x63AA150", VA = "0x1863AB950", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action PDMLBOPCJOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x63AB780", Offset = "0x63A9F80", VA = "0x1863AB780", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x63AB2D0", Offset = "0x63A9AD0", VA = "0x1863AB2D0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<POGGKJJBDBG> OAKEJDAGKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x63AB180", Offset = "0x63A9980", VA = "0x1863AB180", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x63ABA10", Offset = "0x63AA210", VA = "0x1863ABA10", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x63AC0A0", Offset = "0x63AA8A0", VA = "0x1863AC0A0")]
	public MOBODPKAONI(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x63AA870", Offset = "0x63A9070", VA = "0x1863AA870", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x63ABB20", Offset = "0x63AA320", VA = "0x1863ABB20", Slot = "30")]
	public void PJMHJPJDMME(POGGKJJBDBG AKJKKHGAFEH, bool NHBKKIBCJBF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x63AAA50", Offset = "0x63A9250", VA = "0x1863AAA50", Slot = "6")]
	public void FCDHJOLCBFG(POGGKJJBDBG GELDACEOOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x63AAF00", Offset = "0x63A9700", VA = "0x1863AAF00", Slot = "7")]
	public void HEFCMPOMMAH(POGGKJJBDBG GELDACEOOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x63AB4B0", Offset = "0x63A9CB0", VA = "0x1863AB4B0", Slot = "4")]
	public void INCJAOOAMKN(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x63AA510", Offset = "0x63A8D10", VA = "0x1863AA510", Slot = "5")]
	public void BFNAGAOKBLP(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x63AB230", Offset = "0x63A9A30", VA = "0x1863AB230")]
	private void IAAKHDCPJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x63AA5B0", Offset = "0x63A8DB0", VA = "0x1863AA5B0")]
	private void BPLOKDGNOFE(POGGKJJBDBG GELDACEOOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x63AA5F0", Offset = "0x63A8DF0", VA = "0x1863AA5F0")]
	private void CAJNLAFNAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x63AB820", Offset = "0x63AA020", VA = "0x1863AB820")]
	private void MKNJLOLGNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x63AB5A0", Offset = "0x63A9DA0", VA = "0x1863AB5A0")]
	private void INLDCOOKGCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x63AAD70", Offset = "0x63A9570", VA = "0x1863AAD70")]
	[CompilerGenerated]
	private object HANICPDJIEK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class APHCCPBMNLN
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x6397810", Offset = "0x6396010", VA = "0x186397810")]
	public static CCFIPPFAEBG ODEJGIOKIEL(this POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class AFKDDHAGJPN : NNCGHGPKFPJ, MGNMEGJCJIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly AKOGDJKMCIG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AFBJGAIEKPN<POGGKJJBDBG> HKDCMDPDCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool ALPLLNBFFHA;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public AFBJGAIEKPN<POGGKJJBDBG> NPMFIIEOAPA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 CIFGMIBJHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x63902C0", Offset = "0x638EAC0", VA = "0x1863902C0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 MEMIEGNNCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x638FB70", Offset = "0x638E370", VA = "0x18638FB70", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 PPDGIAKDDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x63901D0", Offset = "0x638E9D0", VA = "0x1863901D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public POGGKJJBDBG OCGFAPALLBK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x6390120", Offset = "0x638E920", VA = "0x186390120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6390680", Offset = "0x638EE80", VA = "0x186390680")]
	public AFKDDHAGJPN(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x638FB00", Offset = "0x638E300", VA = "0x18638FB00", Slot = "8")]
	public void AGLAIAPGMJH(POGGKJJBDBG DEINPDMGBDC, object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x63900C0", Offset = "0x638E8C0", VA = "0x1863900C0", Slot = "9")]
	public void KCFAFLFGJIC(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x638FD30", Offset = "0x638E530", VA = "0x18638FD30")]
	private Vector3 GJCMMPKPAPM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x63902F0", Offset = "0x638EAF0", VA = "0x1863902F0")]
	private void PNLKPLOJJGN(POGGKJJBDBG DJDAGIGOJOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class JJJHOHBPNPC
{
	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x639FD40", Offset = "0x639E540", VA = "0x18639FD40")]
	public static NNCGHGPKFPJ PICONMCALMN(this POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class MNKLMLMEIKP : CDIIDBLGLCN, CGBPAEDIJBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly AKOGDJKMCIG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OverridableVector3 KLKINIFJLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OverridableVector3 CCHPLFLDCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float BBMGMEMIHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float DKBLLJFFMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Vector3 DACFNBOCDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Vector3? DLLPAIDEDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Quaternion? FCFMPHOGDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool OBLKKFFPBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool PMBGKIKGGDP;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 OCJFPLHJFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x102B500", Offset = "0x1029D00", VA = "0x18102B500", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x63A79C0", Offset = "0x63A61C0", VA = "0x1863A79C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 GHLIIPFFCJH
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x63A8670", Offset = "0x63A6E70", VA = "0x1863A8670", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float POIAJHCGEIE
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x10FED20", Offset = "0x10FD520", VA = "0x1810FED20", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x63A7FD0", Offset = "0x63A67D0", VA = "0x1863A7FD0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float FJDGCFDCMJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xB73EE0", Offset = "0xB726E0", VA = "0x180B73EE0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x63A7A70", Offset = "0x63A6270", VA = "0x1863A7A70", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 JGJCBHOOMHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x63A9CF0", Offset = "0x63A84F0", VA = "0x1863A9CF0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion ECFAFHPNLKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x63A7760", Offset = "0x63A5F60", VA = "0x1863A7760", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody AEJAAAHOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x63A6AA0", Offset = "0x63A52A0", VA = "0x1863A6AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event MNAOAJBPDNO KPPAEFKPCKI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x63A8A00", Offset = "0x63A7200", VA = "0x1863A8A00", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x63A7D80", Offset = "0x63A6580", VA = "0x1863A7D80", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x63AA190", Offset = "0x63A8990", VA = "0x1863AA190")]
	public MNKLMLMEIKP(POGGKJJBDBG FECPDCEPJMM, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x63A7E20", Offset = "0x63A6620", VA = "0x1863A7E20", Slot = "17")]
	public void JJNHCABBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x63A7CA0", Offset = "0x63A64A0", VA = "0x1863A7CA0", Slot = "16")]
	public void HFLMIGNMBKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x63A78E0", Offset = "0x63A60E0", VA = "0x1863A78E0", Slot = "19")]
	public void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x63A8770", Offset = "0x63A6F70", VA = "0x1863A8770", Slot = "20")]
	public void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x63AA020", Offset = "0x63A8820", VA = "0x1863AA020", Slot = "18")]
	public void PLLCMKJOJBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x63A81D0", Offset = "0x63A69D0", VA = "0x1863A81D0", Slot = "21")]
	public void MFCCKEJINLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x63A79C0", Offset = "0x63A61C0", VA = "0x1863A79C0")]
	private void OKBMDJKKNIL(Vector3 DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x63A80E0", Offset = "0x63A68E0", VA = "0x1863A80E0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 LFHLOOHFANO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x63A7FD0", Offset = "0x63A67D0", VA = "0x1863A7FD0")]
	private void KMPLBLFJIIM(float DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x63A7A70", Offset = "0x63A6270", VA = "0x1863A7A70")]
	private void GGHIGAFKEBK(float DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x63A9E80", Offset = "0x63A8680", VA = "0x1863A9E80")]
	private Vector3 PEKFCBNCOPJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x63A8AA0", Offset = "0x63A72A0", VA = "0x1863A8AA0", Slot = "15")]
	public void NMHLMPNFNEB((Quaternion rot, Vector3 moments) BGCIDCLPDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x63A7B20", Offset = "0x63A6320", VA = "0x1863A7B20")]
	private Quaternion GMINBOOJLDA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x63A8CD0", Offset = "0x63A74D0", VA = "0x1863A8CD0")]
	public void NPGOJDGPLGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x63A8DA0", Offset = "0x63A75A0", VA = "0x1863A8DA0", Slot = "4")]
	public (float, Vector3) NPGOJDGPLGD(Rigidbody NJCGEGPLHLJ)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class PJPLOMIEILA
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x63B07A0", Offset = "0x63AEFA0", VA = "0x1863B07A0")]
	public static CDIIDBLGLCN CFCKBHMEHMA(this POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class ICILFEDLOHI : OPNJMHNPJFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly AKOGDJKMCIG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly GOLBCHGOILO CDFFLAHCHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly GGAPDDJFBMN GABMNKCDOJF;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool FMDODLNJCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xCA8A70", Offset = "0xCA7270", VA = "0x180CA8A70", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public GGAPDDJFBMN EAGPGMEICLK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x89AF10", Offset = "0x899710", VA = "0x18089AF10", Slot = "11")]
		get
		{
			return default(GGAPDDJFBMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x639E510", Offset = "0x639CD10", VA = "0x18639E510")]
	public ICILFEDLOHI(POGGKJJBDBG FECPDCEPJMM, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x639E400", Offset = "0x639CC00", VA = "0x18639E400", Slot = "4")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x639E360", Offset = "0x639CB60", VA = "0x18639E360")]
	private bool KLCOCKCDBEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x639DEF0", Offset = "0x639C6F0", VA = "0x18639DEF0", Slot = "5")]
	public void AINHAMJFIKB(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x639E330", Offset = "0x639CB30", VA = "0x18639E330", Slot = "6")]
	public void KHDJAPGNKKL(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x639E1B0", Offset = "0x639C9B0", VA = "0x18639E1B0", Slot = "9")]
	public void HMJPDJEHBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x639DF20", Offset = "0x639C720", VA = "0x18639DF20")]
	private void APGJHGPFAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x639E040", Offset = "0x639C840", VA = "0x18639E040")]
	private void HIFDBKAHGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x639E4D0", Offset = "0x639CCD0", VA = "0x18639E4D0", Slot = "8")]
	public void LPGJLFMOLON(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x639E2F0", Offset = "0x639CAF0", VA = "0x18639E2F0", Slot = "7")]
	public void INGKLNGGEHI(POGGKJJBDBG FECPDCEPJMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class AHKJCEKOOGK : APDMJJOBGGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly AKOGDJKMCIG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly GOLBCHGOILO AMMJLDEJDBC;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool HFPCJNNENJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x63908F0", Offset = "0x638F0F0", VA = "0x1863908F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event MNAOAJBPDNO OGAFLABKONM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x63907C0", Offset = "0x638EFC0", VA = "0x1863907C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x6390A10", Offset = "0x638F210", VA = "0x186390A10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6390C00", Offset = "0x638F400", VA = "0x186390C00")]
	public AHKJCEKOOGK(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x63909A0", Offset = "0x638F1A0", VA = "0x1863909A0", Slot = "11")]
	public IDisposable JCJPJEEHIPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6390BF0", Offset = "0x638F3F0", VA = "0x186390BF0", Slot = "8")]
	public void PEHCNDHCOOI(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x63908E0", Offset = "0x638F0E0", VA = "0x1863908E0", Slot = "9")]
	public void CMJNCADEFHC(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x6390AB0", Offset = "0x638F2B0", VA = "0x186390AB0", Slot = "10")]
	public void NBDAOKDHCMP(object JECMOKMEJED, bool EHOKAKODAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x6390780", Offset = "0x638EF80", VA = "0x186390780", Slot = "6")]
	public void AFOAIBPAJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x6390860", Offset = "0x638F060", VA = "0x186390860", Slot = "12")]
	public void CGFLGPMMKNA(Rigidbody EKEIFPIAPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x6390BC0", Offset = "0x638F3C0", VA = "0x186390BC0", Slot = "13")]
	public void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class PMCNCBACKCI : OAJLIJDLOMA, FHCFOFKDBIB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly AKOGDJKMCIG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private PhotonView LPLCFGFEGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool DEGBMNOHJBG;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PhotonView FMJACDFLFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool LIDGFPBONBF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x639DC10", Offset = "0x639C410", VA = "0x18639DC10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool LKECHLBCGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x854330", Offset = "0x852B30", VA = "0x180854330", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event MNAOAJBPDNO AOCFIDLDHLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x63B2F60", Offset = "0x63B1760", VA = "0x1863B2F60", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x63B3130", Offset = "0x63B1930", VA = "0x1863B3130", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x63B34B0", Offset = "0x63B1CB0", VA = "0x1863B34B0")]
	public PMCNCBACKCI(POGGKJJBDBG FECPDCEPJMM, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x63B3000", Offset = "0x63B1800", VA = "0x1863B3000", Slot = "9")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x63B2E60", Offset = "0x63B1660", VA = "0x1863B2E60", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x63B3340", Offset = "0x63B1B40", VA = "0x1863B3340", Slot = "10")]
	public void NAGIGIACEMM(POGGKJJBDBG DEINPDMGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x63B31D0", Offset = "0x63B19D0", VA = "0x1863B31D0", Slot = "11")]
	public void MJJAOFJCABM(POGGKJJBDBG DEINPDMGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x63B2CF0", Offset = "0x63B14F0", VA = "0x1863B2CF0")]
	private void DLICDFEAOIK(PhotonView DAOOCLCDGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x63B2B90", Offset = "0x63B1390", VA = "0x1863B2B90")]
	private void CEAPAPJIMIJ(RigidbodyEx ECOCPDCNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x63B2920", Offset = "0x63B1120", VA = "0x1863B2920")]
	private void BNGJDGKGKML(PhotonView IBNJJLPPBAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class KAIMGBINDDP
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x63A0C70", Offset = "0x639F470", VA = "0x1863A0C70")]
	public static OAJLIJDLOMA KIPDLFHCMIL(this POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class FCIALEJMIOG : GPGFKDNCHEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly AKOGDJKMCIG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private RigidbodyConstraints AFFGAPEFNCA;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool HNEBFNGJAEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xABA270", Offset = "0xAB8A70", VA = "0x180ABA270", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x3CEB070", Offset = "0x3CE9870", VA = "0x183CEB070", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool EOPDNIBOEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1AC1E80", Offset = "0x1AC0680", VA = "0x181AC1E80", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3CEB080", Offset = "0x3CE9880", VA = "0x183CEB080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public RigidbodyConstraints DFKCOLAGHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x773AF0", Offset = "0x7722F0", VA = "0x180773AF0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x639C1A0", Offset = "0x639A9A0", VA = "0x18639C1A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x639C2D0", Offset = "0x639AAD0", VA = "0x18639C2D0")]
	public FCIALEJMIOG(POGGKJJBDBG FECPDCEPJMM, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x639C140", Offset = "0x639A940", VA = "0x18639C140", Slot = "9")]
	public void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x639C170", Offset = "0x639A970", VA = "0x18639C170", Slot = "10")]
	public void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class IOGPKCCOEIM : NGEJIGOEOMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly POGGKJJBDBG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float DGIEADHACBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float KCPEJLPPPHJ;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float NMHLKIHHHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x872370", Offset = "0x870B70", VA = "0x180872370", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x639E9F0", Offset = "0x639D1F0", VA = "0x18639E9F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float FEBHECBJBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x913080", Offset = "0x911880", VA = "0x180913080", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x639E920", Offset = "0x639D120", VA = "0x18639E920", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x639EB60", Offset = "0x639D360", VA = "0x18639EB60")]
	public IOGPKCCOEIM(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x639E8D0", Offset = "0x639D0D0", VA = "0x18639E8D0", Slot = "8")]
	public void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x639EAC0", Offset = "0x639D2C0", VA = "0x18639EAC0", Slot = "9")]
	public void NDJMEPGIGOL(Rigidbody BDKLGEAFBBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class MKAIPBIHCLL : CJEHKOJIGBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly AKOGDJKMCIG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool AFIOJCGBEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool MIIHDCKOAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int PAGLOHHJKLN;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody AEJAAAHOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x63A6AA0", Offset = "0x63A52A0", VA = "0x1863A6AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool KCHEDKBHPFL
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x63A68A0", Offset = "0x63A50A0", VA = "0x1863A68A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private POGGKJJBDBG LLPGCPJGINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x63A6DC0", Offset = "0x63A55C0", VA = "0x1863A6DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool NPECNPKKINB
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x63A7350", Offset = "0x63A5B50", VA = "0x1863A7350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event MNAOAJBPDNO ELOPKDOIPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x63A6AF0", Offset = "0x63A52F0", VA = "0x1863A6AF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x63A6D20", Offset = "0x63A5520", VA = "0x1863A6D20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x63A73B0", Offset = "0x63A5BB0", VA = "0x1863A73B0")]
	public MKAIPBIHCLL(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x63A7160", Offset = "0x63A5960", VA = "0x1863A7160", Slot = "6")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x63A7340", Offset = "0x63A5B40", VA = "0x1863A7340", Slot = "8")]
	public void NLOONHHCEEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x63A71F0", Offset = "0x63A59F0", VA = "0x1863A71F0", Slot = "7")]
	public bool MLKENLCNPKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x63A6E70", Offset = "0x63A5670", VA = "0x1863A6E70", Slot = "9")]
	public void KJOLGJJILBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x63A70C0", Offset = "0x63A58C0", VA = "0x1863A70C0", Slot = "11")]
	public void LKNGBPGLIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x63A6E20", Offset = "0x63A5620", VA = "0x1863A6E20", Slot = "12")]
	public void JFPAJDBOAJK(bool EGEEOFOOENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x63A6F10", Offset = "0x63A5710", VA = "0x1863A6F10", Slot = "10")]
	public void LIMHMJPDFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x63A68C0", Offset = "0x63A50C0", VA = "0x1863A68C0")]
	private bool DBDJAMHMBNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x63A6B90", Offset = "0x63A5390", VA = "0x1863A6B90")]
	private void HEHBJFHOHHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class DAFAADICMMI : HAPFHFGLCJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly AKOGDJKMCIG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly GOLBCHGOILO DFPPHIAIMFF;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Rigidbody AEJAAAHOLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x773B00", Offset = "0x772300", VA = "0x180773B00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x773B60", Offset = "0x772360", VA = "0x180773B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool NPECNPKKINB
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x63999D0", Offset = "0x63981D0", VA = "0x1863999D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool KDONFFIMDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xCA8A70", Offset = "0xCA7270", VA = "0x180CA8A70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x6399A30", Offset = "0x6398230", VA = "0x186399A30")]
	public DAFAADICMMI(POGGKJJBDBG FECPDCEPJMM, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x6399100", Offset = "0x6397900", VA = "0x186399100", Slot = "5")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x63990D0", Offset = "0x63978D0", VA = "0x1863990D0", Slot = "7")]
	public void LJJAOAMDCMC(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x6398D70", Offset = "0x6397570", VA = "0x186398D70", Slot = "8")]
	public void HIJLGBEGIJI(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6398A40", Offset = "0x6397240", VA = "0x186398A40", Slot = "9")]
	public void GBJJIEEPEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x63991A0", Offset = "0x63979A0", VA = "0x1863991A0", Slot = "11")]
	public void NFBPOGJFOJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x6398F50", Offset = "0x6397750", VA = "0x186398F50", Slot = "12")]
	public void KHCPIMLGLMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x6399540", Offset = "0x6397D40", VA = "0x186399540", Slot = "10")]
	public void ONNJPBCNPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x6399390", Offset = "0x6397B90", VA = "0x186399390")]
	private void NHFMKKBDLHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x6398DA0", Offset = "0x63975A0", VA = "0x186398DA0")]
	private void IEOPDDIMNOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class FPGAHOBGBEK : HKBIMCGMLPJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly AKOGDJKMCIG FECPDCEPJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly GOLBCHGOILO NDKNGAFHKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float CGIIPEMHFIN;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public FNFCKEINJLI BMJIADBDFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x7790D0", Offset = "0x7778D0", VA = "0x1807790D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x778B30", Offset = "0x777330", VA = "0x180778B30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public CCOBILGDEMA JKMLFKFFLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x773B40", Offset = "0x772340", VA = "0x180773B40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x773B70", Offset = "0x772370", VA = "0x180773B70", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 PPDGIAKDDFI
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x63BB910", Offset = "0x63BA110", VA = "0x1863BB910", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x63BB850", Offset = "0x63BA050", VA = "0x1863BB850", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 HJMJIBMHPKO
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x63BB3C0", Offset = "0x63B9BC0", VA = "0x1863BB3C0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x63BB280", Offset = "0x63B9A80", VA = "0x1863BB280", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 PBHMNNEDFGD
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x63B9FB0", Offset = "0x63B87B0", VA = "0x1863B9FB0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x63BA600", Offset = "0x63B8E00", VA = "0x1863BA600", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 NOLJCEALFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x63B9980", Offset = "0x63B8180", VA = "0x1863B9980", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x63BBB10", Offset = "0x63BA310", VA = "0x1863BBB10", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float OFLBICEGOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7C8210", Offset = "0x7C6A10", VA = "0x1807C8210", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x63BB310", Offset = "0x63B9B10", VA = "0x1863BB310", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool GLDNNIEGOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x1627F40", Offset = "0x1626740", VA = "0x181627F40", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private FLJDFNDMMBM OODMMCKEFCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1CB75A0", Offset = "0x1CB5DA0", VA = "0x181CB75A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool KCHEDKBHPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x639A0D0", Offset = "0x63988D0", VA = "0x18639A0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x63BC260", Offset = "0x63BAA60", VA = "0x1863BC260")]
	public FPGAHOBGBEK(POGGKJJBDBG FECPDCEPJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x63B9F00", Offset = "0x63B8700", VA = "0x1863B9F00", Slot = "19")]
	public void LOFBOIAJCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x63BA720", Offset = "0x63B8F20", VA = "0x1863BA720", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x63BA530", Offset = "0x63B8D30", VA = "0x1863BA530", Slot = "28")]
	public void CGFLGPMMKNA(Rigidbody BDKLGEAFBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xB00440", Offset = "0xAFEC40", VA = "0x180B00440", Slot = "20")]
	public void LJKLCOHFDNP(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0xB00200", Offset = "0xAFEA00", VA = "0x180B00200", Slot = "30")]
	public void NMKAMGJMLNI(object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x63BAC20", Offset = "0x63B9420", VA = "0x1863BAC20", Slot = "35")]
	public Vector3 FHBGLKBMNCP(Vector3 OHFPEKLPEIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x63BBFA0", Offset = "0x63BA7A0", VA = "0x1863BBFA0", Slot = "34")]
	public Vector3 PAKBHMIDCFN(Vector3 APODGKHBFFA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x63B9F00", Offset = "0x63B8700", VA = "0x1863B9F00", Slot = "27")]
	public void BBOGKPNJBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x63BA6C0", Offset = "0x63B8EC0", VA = "0x1863BA6C0", Slot = "25")]
	public void DKOPONKEFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x63BB2B0", Offset = "0x63B9AB0", VA = "0x1863BB2B0", Slot = "24")]
	public void HHDDHHOIEJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x63BA7F0", Offset = "0x63B8FF0", VA = "0x1863BA7F0", Slot = "33")]
	public void EOLOBIKHGKC(Vector3 BOIAGDGMNAH, Vector3 NFFCADAKPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x63BBF40", Offset = "0x63BA740", VA = "0x1863BBF40", Slot = "32")]
	public void OGFHPENECCK(Vector3 KBAMJEPPMDE, Vector3 PBDPKEGAFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x63BC0F0", Offset = "0x63BA8F0", VA = "0x1863BC0F0", Slot = "31")]
	public void PFHBAFGLOKF(Vector3 KPJFPLIJJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x63B9350", Offset = "0x63B7B50", VA = "0x1863B9350", Slot = "22")]
	public void AJBOHICGGKK(EHJPDGLKMMO DADIMGHMLOP, Vector3 LIJNNJCBAEJ, float FKHPADCABCD, float HDNCDJHLDBB = 8f, float GCNJLKJIGFF = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x63BA990", Offset = "0x63B9190", VA = "0x1863BA990", Slot = "21")]
	public void FBGHMOEINPA(MCPIEBENNGH BAPJDGLKOEF, Vector3 LEDLJNHCDLO, float BLJLIMNEJDP = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x63BB4B0", Offset = "0x63B9CB0", VA = "0x1863BB4B0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void LLJNMOLMGDL(MCPIEBENNGH BAPJDGLKOEF, Vector3 JOBDANNFLEE, float NKKKJJHPIPH = 7f, float IDADDGNGKCJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x63BBDE0", Offset = "0x63BA5E0", VA = "0x1863BBDE0", Slot = "29")]
	public Vector3 OEGANIFDLFG(Vector3 GNMILCCIALP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x63BBCB0", Offset = "0x63BA4B0", VA = "0x1863BBCB0", Slot = "26")]
	public void NJOOAFJBPPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x63BB310", Offset = "0x63B9B10", VA = "0x1863BB310")]
	private void LONAIFJHJGN(float DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x63BBB40", Offset = "0x63BA340", VA = "0x1863BBB40")]
	private void NJGENMNAOJP(Vector3 LEDLJNHCDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x63BBA30", Offset = "0x63BA230", VA = "0x1863BBA30")]
	private Vector3 MHBDCHJBEPB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x63BA0D0", Offset = "0x63B88D0", VA = "0x1863BA0D0")]
	private void CDMGMKCJPCK(Vector3 APODGKHBFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x63B9270", Offset = "0x63B7A70", VA = "0x1863B9270")]
	private Vector3 ABDOGEEGNAM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x63BAD90", Offset = "0x63B9590", VA = "0x1863BAD90")]
	private void FHICHLFFGAM(Vector3 DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x63B9A70", Offset = "0x63B8270", VA = "0x1863B9A70")]
	private void AMMNGOGLBAP(Vector3 APODGKHBFFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x63BB1D0", Offset = "0x63B99D0", VA = "0x1863BB1D0")]
	private void GDBGEPAOMNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class PGECMMKMAPG : NCOOLHKGNAN
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x63BC300", Offset = "0x63BAB00", VA = "0x1863BC300", Slot = "4")]
	public HPGIGOMAAKB AFGINIHHGCD(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x63BC560", Offset = "0x63BAD60", VA = "0x1863BC560", Slot = "5")]
	public HKBIMCGMLPJ FCNMBFEAADH(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x63BC7F0", Offset = "0x63BAFF0", VA = "0x1863BC7F0", Slot = "6")]
	public MGNMEGJCJIO JMGCKPMDLND(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x63BC720", Offset = "0x63BAF20", VA = "0x1863BC720", Slot = "7")]
	public NGEJIGOEOMC IBIACGPIINK(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x63BC430", Offset = "0x63BAC30", VA = "0x1863BC430", Slot = "8")]
	public CJEHKOJIGBF CPGPCFIDIJG(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x63BC9C0", Offset = "0x63BB1C0", VA = "0x1863BC9C0", Slot = "9")]
	public IEIELLFCAND PPINIDDDGGJ(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x63BC500", Offset = "0x63BAD00", VA = "0x1863BC500", Slot = "10")]
	public APDMJJOBGGL DJEIDEIEBAM(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x63BC850", Offset = "0x63BB050", VA = "0x1863BC850", Slot = "11")]
	public FLJDFNDMMBM MANPFJECCFK(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x63BC360", Offset = "0x63BAB60", VA = "0x1863BC360", Slot = "12")]
	public EJPEEHDHNOM AJJOBCIDKAJ(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x63BC8B0", Offset = "0x63BB0B0", VA = "0x1863BC8B0", Slot = "13")]
	public PAEKHDOLDKK MIIEIDJAIED(POGGKJJBDBG EGAILLJGEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x63BC640", Offset = "0x63BAE40", VA = "0x1863BC640")]
	public HAPFHFGLCJK HIGLLJIGHIJ(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x63BC490", Offset = "0x63BAC90", VA = "0x1863BC490")]
	public FHCFOFKDBIB DBCEBDCGAOO(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x63BC6B0", Offset = "0x63BAEB0", VA = "0x1863BC6B0")]
	public OPNJMHNPJFL GPJOCDMGGBK(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x63BC780", Offset = "0x63BAF80", VA = "0x1863BC780")]
	public CGBPAEDIJBL IGOMBOELLNI(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x63BC3C0", Offset = "0x63BABC0", VA = "0x1863BC3C0")]
	public GPGFKDNCHEE AMMDKDEKPBM(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x63BC910", Offset = "0x63BB110", VA = "0x1863BC910", Slot = "19")]
	public POGGKJJBDBG MNFLNCEGJAE(RigidbodyEx FECPDCEPJMM, INKLBHHLMIO FCHBDAMJEHN, AMANEILBFPD CLDKLPDMMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public PGECMMKMAPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x63BC640", Offset = "0x63BAE40", VA = "0x1863BC640", Slot = "14")]
	private HAPFHFGLCJK FDLGNKNCNDB(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x63BC490", Offset = "0x63BAC90", VA = "0x1863BC490", Slot = "15")]
	private FHCFOFKDBIB GOBBLEMPFAF(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x63BC6B0", Offset = "0x63BAEB0", VA = "0x1863BC6B0", Slot = "16")]
	private OPNJMHNPJFL HPEOBCEFJEJ(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x63BC780", Offset = "0x63BAF80", VA = "0x1863BC780", Slot = "17")]
	private CGBPAEDIJBL KOPIJAJINMJ(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x63BC3C0", Offset = "0x63BABC0", VA = "0x1863BC3C0", Slot = "18")]
	private GPGFKDNCHEE INCAGNIHKMA(POGGKJJBDBG EGAILLJGEID, [In] INKLBHHLMIO FCHBDAMJEHN)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : HHDBBJLHMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x79C400", Offset = "0x79AC00", VA = "0x18079C400")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x63BCA20", Offset = "0x63BB220", VA = "0x1863BCA20", Slot = "6")]
		public sealed override void EGCAFGLFJCE(AIFIIBGGMIK CGEKFPDGHCG)
		{
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
