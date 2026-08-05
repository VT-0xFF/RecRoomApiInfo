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
public delegate void KMLLDHKLNHB(RigidbodyEx LEMEEGAEFGP);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void NIMMIJKBCKC(RigidbodyEx LEMEEGAEFGP, bool CBBCAJJMHGC = false);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum AHJEMOLEOCF
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
public enum IDHKNKNFBDE
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BLKDNNDGCAM
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[PEPANDEJFKC(typeof(ENIFEAFEHGC), new string[] { "Ignore", "Mock" })]
public class GDLANPCNABO : ENIFEAFEHGC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KMNPPKAGOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7DFEC0", Offset = "0x7DECC0", VA = "0x1807DFEC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
	public void KMDNKBCLCFF(string NGPMDAJFCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "6")]
	public void PCBNIPNJBHL(RigidbodyEx PEPBKPMNFNI, Action APDAGBKMGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x790850", Offset = "0x78F650", VA = "0x180790850", Slot = "7")]
	public GHJCIMDKCIA KCGFILMKHBJ(int KDPAPFJJIKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "8")]
	public void HHDJNCIHPGD(Vector3 LJDNEKKMMDN, float JELACPOCNDN, Color PIPDACHFJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public GDLANPCNABO()
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
		private static readonly IBJKCJFAAOH IHKGLIACNAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool JCDGGILKOKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private HOCOKNCJJJL HCGJLIGBHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[BIOJMLLEHME(LNILAIILNJP.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[BIOJMLLEHME(LNILAIILNJP.SelfAndParent, true, false, false)]
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
		private IDHKNKNFBDE physicsInterpolation;

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
		internal HOCOKNCJJJL JCDNCCJHBID
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6594130", Offset = "0x6592F30", VA = "0x186594130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> OECJPKDDEBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x78D1E0", Offset = "0x78BFE0", VA = "0x18078D1E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x78D190", Offset = "0x78BF90", VA = "0x18078D190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx KOFAABBJAOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x65963C0", Offset = "0x65951C0", VA = "0x1865963C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx AFMCAHCKNML
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6596320", Offset = "0x6595120", VA = "0x186596320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx GEFCENNBDFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6596FE0", Offset = "0x6595DE0", VA = "0x186596FE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6598560", Offset = "0x6597360", VA = "0x186598560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform IGHDBFBBENN
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7B78F0", Offset = "0x7B66F0", VA = "0x1807B78F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform MDKKBAHPDEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7B78F0", Offset = "0x7B66F0", VA = "0x1807B78F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IJDELAFHAFH MOLPKOCNFMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x65960E0", Offset = "0x6594EE0", VA = "0x1865960E0")]
			get
			{
				return default(IJDELAFHAFH);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6597D10", Offset = "0x6596B10", VA = "0x186597D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ABNELKLFCHC
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6596670", Offset = "0x6595470", VA = "0x186596670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JFIHIEOEGDH
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6596200", Offset = "0x6595000", VA = "0x186596200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MGCEECGEKMF LPFAHBIJNHG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x65965B0", Offset = "0x65953B0", VA = "0x1865965B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6597ED0", Offset = "0x6596CD0", VA = "0x186597ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public HPAJGICJEFB MGKENKKHODO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6596550", Offset = "0x6595350", VA = "0x186596550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6597E60", Offset = "0x6596C60", VA = "0x186597E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool HGIFPNBCLNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x65964A0", Offset = "0x65952A0", VA = "0x1865964A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody IPBDLEBHNMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6596500", Offset = "0x6595300", VA = "0x186596500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FDFHHODHCKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6596260", Offset = "0x6595060", VA = "0x186596260")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6597D80", Offset = "0x6596B80", VA = "0x186597D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool KGDHOJMJBMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5D66820", Offset = "0x5D65620", VA = "0x185D66820")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5D66160", Offset = "0x5D64F60", VA = "0x185D66160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float BHBLGLMNKMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6596F80", Offset = "0x6595D80", VA = "0x186596F80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float GJCKFBFCEDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6596F20", Offset = "0x6595D20", VA = "0x186596F20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x65984F0", Offset = "0x65972F0", VA = "0x1865984F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float CEPBIIEHIDE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x65968D0", Offset = "0x65956D0", VA = "0x1865968D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6598170", Offset = "0x6596F70", VA = "0x186598170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float NBEEAPGALPG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x65966D0", Offset = "0x65954D0", VA = "0x1865966D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6597F40", Offset = "0x6596D40", VA = "0x186597F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool GPEMLPIJEHD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6597540", Offset = "0x6596340", VA = "0x186597540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6598AC0", Offset = "0x65978C0", VA = "0x186598AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 PKBBLDNIPGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6596D00", Offset = "0x6595B00", VA = "0x186596D00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x65982C0", Offset = "0x65970C0", VA = "0x1865982C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 LJDNEKKMMDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6597680", Offset = "0x6596480", VA = "0x186597680")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode PMONHLLEEFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6596810", Offset = "0x6595610", VA = "0x186596810")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6598090", Offset = "0x6596E90", VA = "0x186598090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float JPIKGPBAPKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x65962C0", Offset = "0x65950C0", VA = "0x1865962C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6597DF0", Offset = "0x6596BF0", VA = "0x186597DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints OAINGMHFFCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6596870", Offset = "0x6595670", VA = "0x186596870")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6598100", Offset = "0x6596F00", VA = "0x186598100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 JLKEANKJIGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6597080", Offset = "0x6595E80", VA = "0x186597080")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 NBIJHOFFBBN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6597080", Offset = "0x6595E80", VA = "0x186597080")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x65988A0", Offset = "0x65976A0", VA = "0x1865988A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float MBKOAAMAHKF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6596DE0", Offset = "0x6595BE0", VA = "0x186596DE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x65983A0", Offset = "0x65971A0", VA = "0x1865983A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float OJEBCLFFGEG
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x65974E0", Offset = "0x65962E0", VA = "0x1865974E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6598A50", Offset = "0x6597850", VA = "0x186598A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion CAKFCGNEEIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6597160", Offset = "0x6595F60", VA = "0x186597160")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6598620", Offset = "0x6597420", VA = "0x186598620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion CFPEKKLDDKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6597400", Offset = "0x6596200", VA = "0x186597400")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6598980", Offset = "0x6597780", VA = "0x186598980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 CMAANGFNIPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6597240", Offset = "0x6596040", VA = "0x186597240")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x65986F0", Offset = "0x65974F0", VA = "0x1865986F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion GHHECCKCDJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6597320", Offset = "0x6596120", VA = "0x186597320")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x65987D0", Offset = "0x65975D0", VA = "0x1865987D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 IBOAKNMBPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x65975A0", Offset = "0x65963A0", VA = "0x1865975A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6598B30", Offset = "0x6597930", VA = "0x186598B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 ELAAHADLBAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6596E40", Offset = "0x6595C40", VA = "0x186596E40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6598410", Offset = "0x6597210", VA = "0x186598410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 LAKKBNDDMCC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6596730", Offset = "0x6595530", VA = "0x186596730")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6597FB0", Offset = "0x6596DB0", VA = "0x186597FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 AENMCPJCABI
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6596C20", Offset = "0x6595A20", VA = "0x186596C20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x65981E0", Offset = "0x6596FE0", VA = "0x1865981E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 FKBADOLPHED
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6596AE0", Offset = "0x65958E0", VA = "0x186596AE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion IFEHNKOEBAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6596A00", Offset = "0x6595800", VA = "0x186596A00")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 AMBKKKCDCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6597840", Offset = "0x6596640", VA = "0x186597840")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 GDBMIICPEBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6597760", Offset = "0x6596560", VA = "0x186597760")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool CILBJFBOKEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6596BC0", Offset = "0x65959C0", VA = "0x186596BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool JNOAJEPMAKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6596610", Offset = "0x6595410", VA = "0x186596610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool DFIIJPPANGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x65961A0", Offset = "0x6594FA0", VA = "0x1865961A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool MKMJFAPOFGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6596140", Offset = "0x6594F40", VA = "0x186596140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool KPODKJNJJJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6596080", Offset = "0x6594E80", VA = "0x186596080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DKNEDPDHOEH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6596930", Offset = "0x6595730", VA = "0x186596930")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool GFKJDIILPIK
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x511DF80", Offset = "0x511CD80", VA = "0x18511DF80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event KMLLDHKLNHB MBOGFBCCNJL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6595FA0", Offset = "0x6594DA0", VA = "0x186595FA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6597C30", Offset = "0x6596A30", VA = "0x186597C30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event NIMMIJKBCKC FHCCBOBCCLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6595F30", Offset = "0x6594D30", VA = "0x186595F30")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6597BC0", Offset = "0x65969C0", VA = "0x186597BC0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event KMLLDHKLNHB BNAOHCNEGMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6595C90", Offset = "0x6594A90", VA = "0x186595C90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6597920", Offset = "0x6596720", VA = "0x186597920")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event KMLLDHKLNHB HDECEFIHABI
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6595D00", Offset = "0x6594B00", VA = "0x186595D00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6597990", Offset = "0x6596790", VA = "0x186597990")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event KMLLDHKLNHB MBNIDDDOFPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6595E50", Offset = "0x6594C50", VA = "0x186595E50")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6597AE0", Offset = "0x65968E0", VA = "0x186597AE0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<DBLNOAOKDFO, DBLNOAOKDFO> IPAOGELMBEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6595DE0", Offset = "0x6594BE0", VA = "0x186595DE0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6597A70", Offset = "0x6596870", VA = "0x186597A70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event KMLLDHKLNHB IBKGEPKLEBK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6595EC0", Offset = "0x6594CC0", VA = "0x186595EC0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6597B50", Offset = "0x6596950", VA = "0x186597B50")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event KMLLDHKLNHB GAFMDPAPOAA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6596010", Offset = "0x6594E10", VA = "0x186596010")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6597CA0", Offset = "0x6596AA0", VA = "0x186597CA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event KMLLDHKLNHB OIPAMNELJOI
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6595D70", Offset = "0x6594B70", VA = "0x186595D70")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6597A00", Offset = "0x6596800", VA = "0x186597A00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7919F0", Offset = "0x7907F0", VA = "0x1807919F0")]
		internal void JAHNEFIKJCO(HOCOKNCJJJL OGNMHOKFLGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6594D00", Offset = "0x6593B00", VA = "0x186594D00")]
		internal void MPGHCDLCAOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65959B0", Offset = "0x65947B0", VA = "0x1865959B0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody CDHILDHFFPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6595680", Offset = "0x6594480", VA = "0x186595680")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) FBAOFMDOKLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x65940C0", Offset = "0x6592EC0", VA = "0x1865940C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6594130", Offset = "0x6592F30", VA = "0x186594130")]
		private HOCOKNCJJJL BFIKCAGICIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6594420", Offset = "0x6593220", VA = "0x186594420")]
		private void FFIHNOCNALB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6594E50", Offset = "0x6593C50", VA = "0x186594E50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6594D00", Offset = "0x6593B00", VA = "0x186594D00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6594DF0", Offset = "0x6593BF0", VA = "0x186594DF0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6594EB0", Offset = "0x6593CB0", VA = "0x186594EB0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6593770", Offset = "0x6592570", VA = "0x186593770")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object CGFEMNMBCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6594F10", Offset = "0x6593D10", VA = "0x186594F10")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object CGFEMNMBCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x65943C0", Offset = "0x65931C0", VA = "0x1865943C0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6594D90", Offset = "0x6593B90", VA = "0x186594D90")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x65957E0", Offset = "0x65945E0", VA = "0x1865957E0")]
		public void SetParent(RigidbodyEx MBDKMNBCLGF, bool CBBCAJJMHGC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6595220", Offset = "0x6594020", VA = "0x186595220")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x65949D0", Offset = "0x65937D0", VA = "0x1865949D0")]
		public bool IsRigidbodyAncestor(RigidbodyEx GPGJJKPHMFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6594AB0", Offset = "0x65938B0", VA = "0x186594AB0")]
		public bool IsRigidbodyDescendant(RigidbodyEx GEJPGMKHABC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x65939E0", Offset = "0x65927E0", VA = "0x1865939E0")]
		public void AddInterpolationRestriction(object CGFEMNMBCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6594F80", Offset = "0x6593D80", VA = "0x186594F80")]
		public void RemoveInterpolationRestriction(object CGFEMNMBCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x65941E0", Offset = "0x6592FE0", VA = "0x1865941E0")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6593A50", Offset = "0x6592850", VA = "0x186593A50")]
		public void AddKinematic(object CGFEMNMBCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6594FF0", Offset = "0x6593DF0", VA = "0x186594FF0")]
		public void RemoveKinematic(object CGFEMNMBCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6595760", Offset = "0x6594560", VA = "0x186595760")]
		public void SetKinematic(object CGFEMNMBCOK, bool CBBINBGOOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6595580", Offset = "0x6594380", VA = "0x186595580")]
		public void SetDiscontinuousPositionAndRotation(Vector3 PFANPBOJHKO, Quaternion JLIIAAHEPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6595480", Offset = "0x6594280", VA = "0x186595480")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 JFGNPHEAHMM, Quaternion ENJEADHDIDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x65948C0", Offset = "0x65936C0", VA = "0x1865948C0")]
		public Vector3 GetConstrainedVelocity(Vector3 IBOAKNMBPHJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x65947B0", Offset = "0x65935B0", VA = "0x1865947B0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 LAKKBNDDMCC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x65938F0", Offset = "0x65926F0", VA = "0x1865938F0")]
		public void AddForce(Vector3 OEPPFJFNIGI, ForceMode EPBICJOOLLM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x65937E0", Offset = "0x65925E0", VA = "0x1865937E0")]
		public void AddForceAtPosition(Vector3 OEPPFJFNIGI, Vector3 MHFADBEELBD, ForceMode EPBICJOOLLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6593C20", Offset = "0x6592A20", VA = "0x186593C20")]
		public void AddTorque(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6593AC0", Offset = "0x65928C0", VA = "0x186593AC0")]
		public void AddRelativeTorque(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6595A80", Offset = "0x6594880", VA = "0x186595A80")]
		public Vector3 WorldToLocalVelocity(Vector3 GIDEDHBNIIB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6594BF0", Offset = "0x65939F0", VA = "0x186594BF0")]
		public Vector3 LocalToWorldVelocity(Vector3 ELAAHADLBAJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6594360", Offset = "0x6593160", VA = "0x186594360")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6594300", Offset = "0x6593100", VA = "0x186594300")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x65942A0", Offset = "0x65930A0", VA = "0x1865942A0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6594240", Offset = "0x6593040", VA = "0x186594240")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6595380", Offset = "0x6594180", VA = "0x186595380")]
		public void ResetVelocityWorldSpace(Vector3 ICMDGAJHNJH, Vector3 NLEHEKMGGMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6595280", Offset = "0x6594080", VA = "0x186595280")]
		public void ResetVelocityLocalSpace(Vector3 LEGBBGNFGAH, Vector3 AENMCPJCABI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6595140", Offset = "0x6593F40", VA = "0x186595140")]
		public void ResetLinearVelocityLocalSpace(Vector3 LEGBBGNFGAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6595910", Offset = "0x6594710", VA = "0x186595910")]
		public bool SweepTest(Vector3 MIEHBOELEKH, [Out] RaycastHit FLCMLIJJMDF, float HABIICFCBMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6594B90", Offset = "0x6593990", VA = "0x186594B90")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x65958B0", Offset = "0x65946B0", VA = "0x1865958B0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6595A20", Offset = "0x6594820", VA = "0x186595A20")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6593BB0", Offset = "0x65929B0", VA = "0x186593BB0")]
		public void AddShouldHaveUnityRigidbodyToken(object CGFEMNMBCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6595060", Offset = "0x6593E60", VA = "0x186595060")]
		public void RemoveShouldHaveUnityRigidbodyToken(object CGFEMNMBCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6593F50", Offset = "0x6592D50", VA = "0x186593F50")]
		public void ApplyForceVelocityChange(AHJEMOLEOCF DOMBBBCLFNH, Vector3 JDPPPDLIMNC, float FGMPHFJDLNP, float NHIPDPPCCON = 8f, float JLAKPJONIJI = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6593EB0", Offset = "0x6592CB0", VA = "0x186593EB0")]
		public void ApplyAngularVelocityChange(BLKDNNDGCAM NOLEAKKDJBJ, Vector3 CADBLKCNADJ, float FLNLIBPIIPJ = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6594010", Offset = "0x6592E10", VA = "0x186594010")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(BLKDNNDGCAM NOLEAKKDJBJ, Vector3 NJBEEEBFFMP, float GEICNPCCJJP = 7f, float HAIPIONFKGO = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6593DE0", Offset = "0x6592BE0", VA = "0x186593DE0")]
		public bool AllowedScaleChange(float HEJLHBONEPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6593D10", Offset = "0x6592B10", VA = "0x186593D10")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx FFJOAOEIGIP, object CGFEMNMBCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x65950D0", Offset = "0x6593ED0", VA = "0x1865950D0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object CGFEMNMBCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6595C20", Offset = "0x6594A20", VA = "0x186595C20")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class PJPAIJHMDOH
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6592820", Offset = "0x6591620", VA = "0x186592820")]
	public static HOCOKNCJJJL JCDNCCJHBID(this RigidbodyEx PEPBKPMNFNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FIBIHOCDGLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody JFJBDLHDNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView DNCAKFJJANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 HOBIHMABMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 KNEHKMIGBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public IDHKNKNFBDE OFDNEFJDBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool ODBFLGLAGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool NHMKGFJPNKM;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[PEPANDEJFKC(typeof(KIHGMKIMLMB), new string[] { })]
public class HJLMOKHNEHA : KIHGMKIMLMB, CAAHJAMNMLN
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly IBJKCJFAAOH LHKCFFJGAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private HFNEOJBFIDL DHNLBCIJHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private ENIFEAFEHGC KJKENJAPKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private AFIHALNIHNG FGBGCFKFPCE;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public ENIFEAFEHGC LCMNJMCAAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public AFIHALNIHNG ODNOMPLAOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x657D9C0", Offset = "0x657C7C0", VA = "0x18657D9C0", Slot = "8")]
	public void InitReferences(ELAIGJGMPAC LFFHKCFMLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x657DAF0", Offset = "0x657C8F0", VA = "0x18657DAF0", Slot = "6")]
	public IHEBGBCJDGF KLHLLKHHINA(RigidbodyEx PEPBKPMNFNI)
	{
		return default(IHEBGBCJDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x657D8F0", Offset = "0x657C6F0", VA = "0x18657D8F0")]
	private static IHEBGBCJDGF BPNLOBLHLIC(RigidbodyEx PEPBKPMNFNI)
	{
		return default(IHEBGBCJDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x657DA50", Offset = "0x657C850", VA = "0x18657DA50", Slot = "7")]
	public HOCOKNCJJJL JNIPPDNMLOE(RigidbodyEx PEPBKPMNFNI, FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public HJLMOKHNEHA()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static AHOMABILGKI UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int PDJKMELLFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int PMKFCJHBIPL;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x65935D0", Offset = "0x65923D0", VA = "0x1865935D0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6593610", Offset = "0x6592410", VA = "0x186593610")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x65935F0", Offset = "0x65923F0", VA = "0x1865935F0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string EKPMNNKLPFJ, [Optional] UnityEngine.Object BCCEHJNGNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string EKPMNNKLPFJ, [Optional] UnityEngine.Object BCCEHJNGNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6593720", Offset = "0x6592520", VA = "0x186593720")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JEBPBPPKNKO
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6588A30", Offset = "0x6587830", VA = "0x186588A30")]
	public static void FOLEMMBEKOH(this Rigidbody CDHILDHFFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6588BC0", Offset = "0x65879C0", VA = "0x186588BC0")]
	public static void FOLEMMBEKOH(this Rigidbody CDHILDHFFPG, Vector3 HLJCOFOBHOG, Quaternion IFEHNKOEBAM, Vector3 NLFAEDHGGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xC23460", Offset = "0xC22260", VA = "0x180C23460")]
	public static void LAIBNMMHJNA(Vector3 IBOAKNMBPHJ, Vector3 ONELACJMJNO, [Out] Vector3 KOPFIFEAOKN, [Out] Vector3 IKPIBFCELGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class OIBEHCCMOHN
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class GMFKEECNDGJ : MGCEECGEKMF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x79E990", Offset = "0x79D790", VA = "0x18079E990", Slot = "4")]
		public Vector3 GNFDIIJDNFO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x79E990", Offset = "0x79D790", VA = "0x18079E990", Slot = "5")]
		public Vector3 JEGPOCGLFKJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public GMFKEECNDGJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static MGCEECGEKMF IGDAFLGNAII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6591120", Offset = "0x658FF20", VA = "0x186591120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KAANPNMIOAE
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CollisionDetectionMode IDMHPOPJIHE
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
	void JLCDGKOMKPF();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FIIPOLMLNMH(bool CILBJFBOKEM);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EHKJALKMMMF(bool CILBJFBOKEM);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IAODFPGOEMM(Rigidbody JFJBDLHDNAF);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BHCHBFOMIPI(Vector3 MIEHBOELEKH, [Out] RaycastHit FLCMLIJJMDF, float HABIICFCBMI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NEONIKIGNOM : IDisposable, OLBCLCMIHIN
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	PAFONDGDNMK MOLPKOCNFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<DBLNOAOKDFO, DBLNOAOKDFO> IPAOGELMBEC;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JLCDGKOMKPF();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface AFIHALNIHNG
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CKLGIFHIGHO OKFBKNPKKJO(HOCOKNCJJJL OGNMHOKFLGN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PODEFIECECN DIJHOGKFJKM(HOCOKNCJJJL OGNMHOKFLGN);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GLIPCIFAGOC GDJPHBPKHNJ(HOCOKNCJJJL OGNMHOKFLGN);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JEAMKLFGBLG PGCAICLJJGM(HOCOKNCJJJL OGNMHOKFLGN);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KKCCCEBIOOC ALKBCLEDBPK(HOCOKNCJJJL OGNMHOKFLGN);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NEONIKIGNOM ILMBMNHMFAG(HOCOKNCJJJL OGNMHOKFLGN);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BKOKPDEKNJH IDLHODBOGHG(HOCOKNCJJJL OGNMHOKFLGN);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KJJOBHEGCDH EOMIFOEKPNK(HOCOKNCJJJL OGNMHOKFLGN);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KAANPNMIOAE BMPPGEDLLOD(HOCOKNCJJJL OGNMHOKFLGN);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CPMGGCMJEFL PBPMEFGGJCN(HOCOKNCJJJL OGNMHOKFLGN);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BGIBMNHFFAL OJMFJOJGMAK(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KOAIPOCHCAG OBJFBIMFFOJ(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DIFIBOKOPFH EBDPONLMGFC(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BFNIHOELDII JNILOGAKBGP(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DLBLGAFPKNL IKOHNJJNLIG(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HOCOKNCJJJL JNIPPDNMLOE(RigidbodyEx PEPBKPMNFNI, FIBIHOCDGLH HKPHNGEBIED, KIHGMKIMLMB OMCPJFGHGNL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface KJJOBHEGCDH
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCKJFIGJGEB(Vector3 OEPPFJFNIGI, ForceMode EPBICJOOLLM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NJMOCBNPAKL(Vector3 OEPPFJFNIGI, Vector3 MHFADBEELBD, ForceMode EPBICJOOLLM);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBGMHHCAPCO(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MHALFEFGJOK(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CPMGGCMJEFL
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool EECMBGIOICM
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
	void IAODFPGOEMM(Rigidbody JFJBDLHDNAF);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CKLGIFHIGHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IReadOnlyList<HOCOKNCJJJL> GBLPMGDCAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HOCOKNCJJJL AFMCAHCKNML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	HOCOKNCJJJL KKHLELLCELL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event KMLLDHKLNHB BNAOHCNEGMN;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event KMLLDHKLNHB HDECEFIHABI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event NIMMIJKBCKC MHJPLIPDKBJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action HBJFOGNOFBL;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action HBCGELIPFMN;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<HOCOKNCJJJL> CPOBBINAGHB;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<HOCOKNCJJJL> FGAAOJOGPMD;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action ENEHNMGDEFG;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<HOCOKNCJJJL> MHJCEFODJMB;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FAJLKEPAOJL(HOCOKNCJJJL BLKPHAHLOKB, bool CBBCAJJMHGC = false);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GLIPCIFAGOC
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 JINBIHENJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 IJLCEKKMHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCGMOLPFCCM(HOCOKNCJJJL GEFCENNBDFI, object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FIIKKBLHPHA(object CGFEMNMBCOK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BFNIHOELDII
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 EJCJCCCLDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 DGAECMDABMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float FODEBPPKIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float JHADICINMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 OEIBPPHAACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Quaternion JHMBGDMNHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event KMLLDHKLNHB MKEBNIGCJHF;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MJELCFAAKJB((Quaternion rot, Vector3 moments) FBAOFMDOKLD);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JICBDBPLDOD();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void AGGNEFHHFBG();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HOCMAMFFDFE();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IAODFPGOEMM(Rigidbody JFJBDLHDNAF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NHDCMNAHDKL();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface DIFIBOKOPFH
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JLCDGKOMKPF();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFPLLCNOCAO(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNGAPJGKAGE(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HCJFFMGGMPO(HOCOKNCJJJL PEPBKPMNFNI);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KGLMAHJBOML(HOCOKNCJJJL PEPBKPMNFNI);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BHJCIECCICC();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface BKOKPDEKNJH
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool OEPGKIKIHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event KMLLDHKLNHB BAHMJIMEKOI;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBDDBOMIPDG();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IENDNCEOIPO(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CKANGJMMAHK(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PMFJDBOLJIN(object CGFEMNMBCOK, bool CBBINBGOOHO);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable EGFHGEBFABK();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IAODFPGOEMM(Rigidbody BPHKIOCOHDN);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface KOAIPOCHCAG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool ABNELKLFCHC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool JFIHIEOEGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event KMLLDHKLNHB DKFDPEBGMMJ;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JLCDGKOMKPF();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AADLCAECLDP(HOCOKNCJJJL GEFCENNBDFI);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JHCPEHGGFOG(HOCOKNCJJJL GEFCENNBDFI);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface DLBLGAFPKNL
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool FDFHHODHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool ANLLEHIJIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	RigidbodyConstraints HKHPMHDBMED
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
	void IAODFPGOEMM(Rigidbody JFJBDLHDNAF);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface JEAMKLFGBLG
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float GEJLHPDFKOI
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float JJDGBGJFOAC
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
	void IAODFPGOEMM(Rigidbody JFJBDLHDNAF);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NPECALAMHAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx OMCJHALLKJF);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface KKCCCEBIOOC
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event KMLLDHKLNHB FPHBHNGLHEC;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JLCDGKOMKPF();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DDEBGNLPGNM();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNEFDHENJIE();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IFFAGOPFNMM();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HELPDJDAKNL();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AFHIICHEDNO();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JNKCDBMJHEO(bool JNJHHJMDGIF);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BGIBMNHFFAL
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Rigidbody IPBDLEBHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool LKKCLGOAFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLCDGKOMKPF();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NHKMCHHACHL(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CBGIICEIMPH(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KJPDNIGCMDG();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HOJBJFGFKBI();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PODEFIECECN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	MGCEECGEKMF LPFAHBIJNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	HPAJGICJEFB MGKENKKHODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 LPCHKJFNCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 NIKNGCBKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 CLDGKCKHKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 GAKADIGGDAE
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float JPIKGPBAPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool HGIFPNBCLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void JLCDGKOMKPF();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ECOKLILBDKM(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OFMPPFIBNAG(BLKDNNDGCAM NOLEAKKDJBJ, Vector3 CADBLKCNADJ, float FLNLIBPIIPJ = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void DPPEIIHAENP(AHJEMOLEOCF DOMBBBCLFNH, Vector3 JDPPPDLIMNC, float FGMPHFJDLNP, float NHIPDPPCCON = 8f, float JLAKPJONIJI = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ELHBGOAJOGC(BLKDNNDGCAM NOLEAKKDJBJ, Vector3 NJBEEEBFFMP, float GEICNPCCJJP = 7f, float HAIPIONFKGO = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KPOOFCIGNPJ();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void PMEMAPAJFNA();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void KMHMNKCAIGJ();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void OFNJJILONJB();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IAODFPGOEMM(Rigidbody JFJBDLHDNAF);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 KJGPOOAELFJ(Vector3 IBOAKNMBPHJ);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GMIMDDMODFH(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void AJEKGCONBHI(Vector3 NNEEBDCMMHB);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void EBCPJPAPBLD(Vector3 LEGBBGNFGAH, Vector3 AENMCPJCABI);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void GBNPJKONKNI(Vector3 ICMDGAJHNJH, Vector3 NLEHEKMGGMG);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 KICPKKDLGLB(Vector3 ELAAHADLBAJ);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 BJPPEMCNCNB(Vector3 GIDEDHBNIIB);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface ENIFEAFEHGC
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool KMNPPKAGOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMDNKBCLCFF(string NGPMDAJFCLG);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PCBNIPNJBHL(RigidbodyEx PEPBKPMNFNI, Action APDAGBKMGMB);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GHJCIMDKCIA KCGFILMKHBJ(int KDPAPFJJIKI);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHDJNCIHPGD(Vector3 LJDNEKKMMDN, float JELACPOCNDN, Color PIPDACHFJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface KIHGMKIMLMB
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	ENIFEAFEHGC LCMNJMCAAPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	AFIHALNIHNG ODNOMPLAOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IHEBGBCJDGF KLHLLKHHINA(RigidbodyEx PEPBKPMNFNI);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HOCOKNCJJJL JNIPPDNMLOE(RigidbodyEx PEPBKPMNFNI, FIBIHOCDGLH HKPHNGEBIED);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface HPAJGICJEFB
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMAMNHPKEGC(Vector3 FDCCPECEDLM);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLKGKHDHCBK(Vector3 LAKKBNDDMCC);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LGBIKOOHIME(Vector3 FDCCPECEDLM);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PGFJBGMDAEN(Vector3 LAKKBNDDMCC);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface MGCEECGEKMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 GNFDIIJDNFO();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 JEGPOCGLFKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HOCOKNCJJJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Rigidbody IPBDLEBHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	RigidbodyEx EGONAAJJGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject KKKIKGBJKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Transform NFGCKFGOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	HOCOKNCJJJL KKHLELLCELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IReadOnlyList<HOCOKNCJJJL> GBLPMGDCAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	HOCOKNCJJJL AFMCAHCKNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool ABNELKLFCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool JFIHIEOEGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	MGCEECGEKMF LPFAHBIJNHG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	HPAJGICJEFB MGKENKKHODO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float JPIKGPBAPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Vector3 NIKNGCBKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 GAKADIGGDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 LPCHKJFNCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 CLDGKCKHKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool MKMJFAPOFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool KPODKJNJJJE
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool HGIFPNBCLNI
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 JINBIHENJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 IJLCEKKMHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 EJCJCCCLDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 DGAECMDABMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float FODEBPPKIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float JHADICINMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 OEIBPPHAACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Quaternion JHMBGDMNHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float GEJLHPDFKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float JJDGBGJFOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool EECMBGIOICM
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	PAFONDGDNMK MOLPKOCNFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool OEPGKIKIHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Transform MDKKBAHPDEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 NGCGAKJOFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float JNOEGBPPEPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float CDHGIFNIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion CLLHHFCJJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 NPLKDHGJDME
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Quaternion GJJMADPKFKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	RigidbodyConstraints HKHPMHDBMED
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool FDFHHODHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	CollisionDetectionMode IDMHPOPJIHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool JNOAJEPMAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event KMLLDHKLNHB BNAOHCNEGMN;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event KMLLDHKLNHB HDECEFIHABI;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event NIMMIJKBCKC MHJPLIPDKBJ;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event KMLLDHKLNHB DKFDPEBGMMJ;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event KMLLDHKLNHB MBNIDDDOFPB;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event KMLLDHKLNHB FPHBHNGLHEC;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<DBLNOAOKDFO, DBLNOAOKDFO> IPAOGELMBEC;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event KMLLDHKLNHB BAHMJIMEKOI;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event KMLLDHKLNHB OIPAMNELJOI;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void MJELCFAAKJB((Quaternion rot, Vector3 moments) FBAOFMDOKLD);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void JLCDGKOMKPF();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void MPHBBHPMAKB();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void GMIHCFFINOB();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void IFFAGOPFNMM();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void FAJLKEPAOJL(HOCOKNCJJJL MBDKMNBCLGF, bool CBBCAJJMHGC = false);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void BPNNKGFPPMF(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void FDOAJHEFCLF(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 BJPPEMCNCNB(Vector3 GIDEDHBNIIB);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 KICPKKDLGLB(Vector3 ELAAHADLBAJ);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void OFNJJILONJB();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void PMEMAPAJFNA();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void KPOOFCIGNPJ();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void GBNPJKONKNI(Vector3 ICMDGAJHNJH, Vector3 NLEHEKMGGMG);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void EBCPJPAPBLD(Vector3 LEGBBGNFGAH, Vector3 AENMCPJCABI);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void AJEKGCONBHI(Vector3 NNEEBDCMMHB);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void DPPEIIHAENP(AHJEMOLEOCF DOMBBBCLFNH, Vector3 JDPPPDLIMNC, float FGMPHFJDLNP, float NHIPDPPCCON = 8f, float JLAKPJONIJI = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void OFMPPFIBNAG(BLKDNNDGCAM NOLEAKKDJBJ, Vector3 CADBLKCNADJ, float FLNLIBPIIPJ = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void ELHBGOAJOGC(BLKDNNDGCAM NOLEAKKDJBJ, Vector3 NJBEEEBFFMP, float GEICNPCCJJP = 7f, float HAIPIONFKGO = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 KJGPOOAELFJ(Vector3 MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 FDJIPELKHIA(Vector3 MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void KMHMNKCAIGJ();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void DNIIGNIMPDE(HOCOKNCJJJL FFJOAOEIGIP, object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void PKELMAKFLIK(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void AGGNEFHHFBG();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void JICBDBPLDOD();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void HOCMAMFFDFE();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool DDEBGNLPGNM();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void AFHIICHEDNO();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable EGFHGEBFABK();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void IENDNCEOIPO(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void CKANGJMMAHK(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void PMFJDBOLJIN(object CGFEMNMBCOK, bool CBBINBGOOHO);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void PEIOJNEJNHP(Vector3 PFANPBOJHKO, Quaternion JLIIAAHEPHA);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void NIOKEFCGOLH(Vector3 JFGNPHEAHMM, Quaternion ENJEADHDIDC);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool HPBOLFFGNPL(float HEJLHBONEPM);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void MDPKCEGMPGM(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void HEGNFAIAPEJ(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void NHKMCHHACHL(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void CBGIICEIMPH(object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void HCKJFIGJGEB(Vector3 OEPPFJFNIGI, ForceMode EPBICJOOLLM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void NJMOCBNPAKL(Vector3 OEPPFJFNIGI, Vector3 MHFADBEELBD, ForceMode EPBICJOOLLM);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void EBGMHHCAPCO(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void MHALFEFGJOK(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool BHCHBFOMIPI(Vector3 MIEHBOELEKH, [Out] RaycastHit FLCMLIJJMDF, float HABIICFCBMI);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void NHDCMNAHDKL();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HOIECNNMMJA : HOCOKNCJJJL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly KIHGMKIMLMB OMCPJFGHGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal CKLGIFHIGHO JAPBHKJEKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal DIFIBOKOPFH MIJPKFECKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal KOAIPOCHCAG POFLHJBECFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal PODEFIECECN IBOAKNMBPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal GLIPCIFAGOC NHDMECBMIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal BFNIHOELDII DBAPPBMFMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal JEAMKLFGBLG DHENKKEONDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal CPMGGCMJEFL CLAPKANIFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal KKCCCEBIOOC EKBNIAPPGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal NEONIKIGNOM LPNIAPAANEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal BKOKPDEKNJH PEBFJMIELOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal KJJOBHEGCDH OEPPFJFNIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal DLBLGAFPKNL FPKCKJGMGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal BGIBMNHFFAL JFJBDLHDNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal KAANPNMIOAE JFHOMGABIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal IDisposable HCPOEELLJDF;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyEx EGONAAJJGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x798FA0", Offset = "0x797DA0", VA = "0x180798FA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797E00", VA = "0x180799000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GameObject KKKIKGBJKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x858ED0", Offset = "0x857CD0", VA = "0x180858ED0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8585D0", Offset = "0x8573D0", VA = "0x1808585D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Transform NFGCKFGOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x657FEC0", Offset = "0x657ECC0", VA = "0x18657FEC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody IPBDLEBHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6581F20", Offset = "0x6580D20", VA = "0x186581F20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public HOCOKNCJJJL KKHLELLCELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x6581CB0", Offset = "0x6580AB0", VA = "0x186581CB0", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x657DFA0", Offset = "0x657CDA0", VA = "0x18657DFA0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<HOCOKNCJJJL> GBLPMGDCAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6581440", Offset = "0x6580240", VA = "0x186581440", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public HOCOKNCJJJL AFMCAHCKNML
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x6583000", Offset = "0x6581E00", VA = "0x186583000", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool OMKJPAHHFCA
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6581490", Offset = "0x6580290", VA = "0x186581490", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool ABNELKLFCHC
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6580740", Offset = "0x657F540", VA = "0x186580740", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool JFIHIEOEGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x65831A0", Offset = "0x6581FA0", VA = "0x1865831A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public MGCEECGEKMF LPFAHBIJNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x657ECA0", Offset = "0x657DAA0", VA = "0x18657ECA0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x657E7C0", Offset = "0x657D5C0", VA = "0x18657E7C0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public HPAJGICJEFB MGKENKKHODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x657E8E0", Offset = "0x657D6E0", VA = "0x18657E8E0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x657F5A0", Offset = "0x657E3A0", VA = "0x18657F5A0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float JPIKGPBAPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x6583050", Offset = "0x6581E50", VA = "0x186583050", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x6583350", Offset = "0x6582150", VA = "0x186583350", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 NIKNGCBKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x65811C0", Offset = "0x657FFC0", VA = "0x1865811C0", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6580890", Offset = "0x657F690", VA = "0x186580890", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 GAKADIGGDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x657F690", Offset = "0x657E490", VA = "0x18657F690", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x657EF20", Offset = "0x657DD20", VA = "0x18657EF20", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 LPCHKJFNCCE
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x657E670", Offset = "0x657D470", VA = "0x18657E670", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x657EBC0", Offset = "0x657D9C0", VA = "0x18657EBC0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 CLDGKCKHKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6580490", Offset = "0x657F290", VA = "0x186580490", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x65829D0", Offset = "0x65817D0", VA = "0x1865829D0", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool DFIIJPPANGO
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6581ED0", Offset = "0x6580CD0", VA = "0x186581ED0", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool MKMJFAPOFGF
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6580220", Offset = "0x657F020", VA = "0x186580220", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool KPODKJNJJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x6581650", Offset = "0x6580450", VA = "0x186581650", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool HGIFPNBCLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x65801D0", Offset = "0x657EFD0", VA = "0x1865801D0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 JINBIHENJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x65827F0", Offset = "0x65815F0", VA = "0x1865827F0", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 IJLCEKKMHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6581090", Offset = "0x657FE90", VA = "0x186581090", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 EJCJCCCLDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6583490", Offset = "0x6582290", VA = "0x186583490", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6581A40", Offset = "0x6580840", VA = "0x186581A40", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 DGAECMDABMD
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6580AE0", Offset = "0x657F8E0", VA = "0x186580AE0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float FODEBPPKIDA
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6580F70", Offset = "0x657FD70", VA = "0x186580F70", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float JHADICINMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x657F060", Offset = "0x657DE60", VA = "0x18657F060", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6580280", Offset = "0x657F080", VA = "0x186580280", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 OEIBPPHAACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6580C10", Offset = "0x657FA10", VA = "0x186580C10", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion JHMBGDMNHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x657E350", Offset = "0x657D150", VA = "0x18657E350", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float GEJLHPDFKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x657E9F0", Offset = "0x657D7F0", VA = "0x18657E9F0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x6581D00", Offset = "0x6580B00", VA = "0x186581D00", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float JJDGBGJFOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x65807D0", Offset = "0x657F5D0", VA = "0x1865807D0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x65817E0", Offset = "0x65805E0", VA = "0x1865817E0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool EECMBGIOICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6580BC0", Offset = "0x657F9C0", VA = "0x186580BC0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x65821C0", Offset = "0x6580FC0", VA = "0x1865821C0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public PAFONDGDNMK MOLPKOCNFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x6580020", Offset = "0x657EE20", VA = "0x186580020", Slot = "48")]
		get
		{
			return default(PAFONDGDNMK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x657E820", Offset = "0x657D620", VA = "0x18657E820", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool OEPGKIKIHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6580840", Offset = "0x657F640", VA = "0x186580840", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform MDKKBAHPDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6580AD0", Offset = "0x657F8D0", VA = "0x186580AD0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 NGCGAKJOFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x6581730", Offset = "0x6580530", VA = "0x186581730", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x657F0B0", Offset = "0x657DEB0", VA = "0x18657F0B0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float JNOEGBPPEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x6580970", Offset = "0x657F770", VA = "0x186580970", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x657E750", Offset = "0x657D550", VA = "0x18657E750", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float CDHGIFNIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x657E330", Offset = "0x657D130", VA = "0x18657E330", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x65814F0", Offset = "0x65802F0", VA = "0x1865814F0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion CLLHHFCJJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6580660", Offset = "0x657F460", VA = "0x186580660", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6580340", Offset = "0x657F140", VA = "0x186580340", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 NPLKDHGJDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6582280", Offset = "0x6581080", VA = "0x186582280", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x657E0A0", Offset = "0x657CEA0", VA = "0x18657E0A0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion GJJMADPKFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x657F600", Offset = "0x657E400", VA = "0x18657F600", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6580790", Offset = "0x657F590", VA = "0x186580790", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints HKHPMHDBMED
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6583B40", Offset = "0x6582940", VA = "0x186583B40", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x657FF50", Offset = "0x657ED50", VA = "0x18657FF50", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool FDFHHODHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6583250", Offset = "0x6582050", VA = "0x186583250", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6580430", Offset = "0x657F230", VA = "0x186580430", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode IDMHPOPJIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6581C10", Offset = "0x6580A10", VA = "0x186581C10", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x65802E0", Offset = "0x657F0E0", VA = "0x1865802E0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool GEFECGMFJOK
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x65825A0", Offset = "0x65813A0", VA = "0x1865825A0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool JNOAJEPMAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x657EA40", Offset = "0x657D840", VA = "0x18657EA40", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool BAPANHIOHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6583B90", Offset = "0x6582990", VA = "0x186583B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool GDKPPGBELMK
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6580710", Offset = "0x657F510", VA = "0x186580710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event KMLLDHKLNHB BNAOHCNEGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6582490", Offset = "0x6581290", VA = "0x186582490", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6581D60", Offset = "0x6580B60", VA = "0x186581D60", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event KMLLDHKLNHB HDECEFIHABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x657E2D0", Offset = "0x657D0D0", VA = "0x18657E2D0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x65826E0", Offset = "0x65814E0", VA = "0x1865826E0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event NIMMIJKBCKC MHJPLIPDKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x657F1E0", Offset = "0x657DFE0", VA = "0x18657F1E0", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6580DA0", Offset = "0x657FBA0", VA = "0x186580DA0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event KMLLDHKLNHB DKFDPEBGMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6580EB0", Offset = "0x657FCB0", VA = "0x186580EB0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6581F70", Offset = "0x6580D70", VA = "0x186581F70", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event KMLLDHKLNHB MBNIDDDOFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x65828C0", Offset = "0x65816C0", VA = "0x1865828C0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x65815F0", Offset = "0x65803F0", VA = "0x1865815F0", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event KMLLDHKLNHB FPHBHNGLHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x65813E0", Offset = "0x65801E0", VA = "0x1865813E0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6583140", Offset = "0x6581F40", VA = "0x186583140", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<DBLNOAOKDFO, DBLNOAOKDFO> IPAOGELMBEC
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x65824F0", Offset = "0x65812F0", VA = "0x1865824F0", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x657F000", Offset = "0x657DE00", VA = "0x18657F000", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event KMLLDHKLNHB BAHMJIMEKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x65831F0", Offset = "0x6581FF0", VA = "0x1865831F0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6580F10", Offset = "0x657FD10", VA = "0x186580F10", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event KMLLDHKLNHB OIPAMNELJOI
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x657E5C0", Offset = "0x657D3C0", VA = "0x18657E5C0", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6583A90", Offset = "0x6582890", VA = "0x186583A90", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6583D90", Offset = "0x6582B90", VA = "0x186583D90")]
	public HOIECNNMMJA(GameObject FAIKIGMIEFB, RigidbodyEx PGDECOKLCDF, KIHGMKIMLMB OMCPJFGHGNL, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6582D10", Offset = "0x6581B10", VA = "0x186582D10", Slot = "135")]
	protected virtual void NKNJKCGIGKK(KIHGMKIMLMB OMCPJFGHGNL, FIBIHOCDGLH HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x657F300", Offset = "0x657E100", VA = "0x18657F300", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x65812A0", Offset = "0x65800A0", VA = "0x1865812A0", Slot = "71")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6582550", Offset = "0x6581350", VA = "0x186582550", Slot = "72")]
	public void MPHBBHPMAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6580820", Offset = "0x657F620", VA = "0x186580820", Slot = "73")]
	public void GMIHCFFINOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x65832A0", Offset = "0x65820A0", VA = "0x1865832A0")]
	private void ONLBGOJJDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x657FFB0", Offset = "0x657EDB0", VA = "0x18657FFB0", Slot = "81")]
	public void FAJLKEPAOJL(HOCOKNCJJJL MBDKMNBCLGF, bool CBBCAJJMHGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x657E880", Offset = "0x657D680", VA = "0x18657E880", Slot = "84")]
	public void BPNNKGFPPMF(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6580170", Offset = "0x657EF70", VA = "0x186580170", Slot = "85")]
	public void FDOAJHEFCLF(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x657E4C0", Offset = "0x657D2C0", VA = "0x18657E4C0", Slot = "86")]
	public Vector3 BJPPEMCNCNB(Vector3 GIDEDHBNIIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6581840", Offset = "0x6580640", VA = "0x186581840", Slot = "87")]
	public Vector3 KICPKKDLGLB(Vector3 ELAAHADLBAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6582550", Offset = "0x6581350", VA = "0x186582550", Slot = "88")]
	public void OFNJJILONJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6583C90", Offset = "0x6582A90", VA = "0x186583C90", Slot = "89")]
	public void PMEMAPAJFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6581C60", Offset = "0x6580A60", VA = "0x186581C60", Slot = "90")]
	public void KPOOFCIGNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6580570", Offset = "0x657F370", VA = "0x186580570", Slot = "91")]
	public void GBNPJKONKNI(Vector3 ICMDGAJHNJH, Vector3 NLEHEKMGGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x657F3D0", Offset = "0x657E1D0", VA = "0x18657F3D0", Slot = "92")]
	public void EBCPJPAPBLD(Vector3 LEGBBGNFGAH, Vector3 AENMCPJCABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x657E0F0", Offset = "0x657CEF0", VA = "0x18657E0F0", Slot = "93")]
	public void AJEKGCONBHI(Vector3 NNEEBDCMMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x657F240", Offset = "0x657E040", VA = "0x18657F240", Slot = "94")]
	public void DPPEIIHAENP(AHJEMOLEOCF DOMBBBCLFNH, Vector3 JDPPPDLIMNC, float FGMPHFJDLNP, float NHIPDPPCCON = 8f, float JLAKPJONIJI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x65830A0", Offset = "0x6581EA0", VA = "0x1865830A0", Slot = "95")]
	public void OFMPPFIBNAG(BLKDNNDGCAM NOLEAKKDJBJ, Vector3 CADBLKCNADJ, float FLNLIBPIIPJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x657F770", Offset = "0x657E570", VA = "0x18657F770", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ELHBGOAJOGC(BLKDNNDGCAM NOLEAKKDJBJ, Vector3 NJBEEEBFFMP, float GEICNPCCJJP = 7f, float HAIPIONFKGO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6581940", Offset = "0x6580740", VA = "0x186581940", Slot = "97")]
	public Vector3 KJGPOOAELFJ(Vector3 MBDKMNBCLGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6580070", Offset = "0x657EE70", VA = "0x186580070", Slot = "98")]
	public Vector3 FDJIPELKHIA(Vector3 MBDKMNBCLGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6581BC0", Offset = "0x65809C0", VA = "0x186581BC0", Slot = "99")]
	public void KMHMNKCAIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x657F170", Offset = "0x657DF70", VA = "0x18657F170", Slot = "100")]
	public void DNIIGNIMPDE(HOCOKNCJJJL FFJOAOEIGIP, object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6583C30", Offset = "0x6582A30", VA = "0x186583C30", Slot = "101")]
	public void PKELMAKFLIK(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x65823B0", Offset = "0x65811B0", VA = "0x1865823B0", Slot = "41")]
	public void MJELCFAAKJB((Quaternion rot, Vector3 moments) FBAOFMDOKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x657E050", Offset = "0x657CE50", VA = "0x18657E050", Slot = "104")]
	public void AGGNEFHHFBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6581170", Offset = "0x657FF70", VA = "0x186581170", Slot = "105")]
	public void JICBDBPLDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6580CF0", Offset = "0x657FAF0", VA = "0x186580CF0", Slot = "106")]
	public void HOCMAMFFDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x657EED0", Offset = "0x657DCD0", VA = "0x18657EED0", Slot = "109")]
	public bool DDEBGNLPGNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6580E60", Offset = "0x657FC60", VA = "0x186580E60", Slot = "74")]
	public void IFFAGOPFNMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x657E000", Offset = "0x657CE00", VA = "0x18657E000", Slot = "110")]
	public void AFHIICHEDNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x657F640", Offset = "0x657E440", VA = "0x18657F640", Slot = "115")]
	public IDisposable EGFHGEBFABK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6580E00", Offset = "0x657FC00", VA = "0x186580E00", Slot = "116")]
	public void IENDNCEOIPO(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x657E990", Offset = "0x657D790", VA = "0x18657E990", Slot = "117")]
	public void CKANGJMMAHK(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x6583CE0", Offset = "0x6582AE0", VA = "0x186583CE0", Slot = "118")]
	public void PMFJDBOLJIN(object CGFEMNMBCOK, bool CBBINBGOOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6583890", Offset = "0x6582690", VA = "0x186583890", Slot = "121")]
	public void PEIOJNEJNHP(Vector3 PFANPBOJHKO, Quaternion JLIIAAHEPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6582AB0", Offset = "0x65818B0", VA = "0x186582AB0", Slot = "122")]
	public void NIOKEFCGOLH(Vector3 JFGNPHEAHMM, Quaternion ENJEADHDIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x6580D40", Offset = "0x657FB40", VA = "0x186580D40", Slot = "123")]
	public bool HPBOLFFGNPL(float HEJLHBONEPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x6582220", Offset = "0x6581020", VA = "0x186582220", Slot = "124")]
	public void MDPKCEGMPGM(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x6580A70", Offset = "0x657F870", VA = "0x186580A70", Slot = "125")]
	public void HEGNFAIAPEJ(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x6582970", Offset = "0x6581770", VA = "0x186582970", Slot = "126")]
	public void NHKMCHHACHL(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x657E930", Offset = "0x657D730", VA = "0x18657E930", Slot = "127")]
	public void CBGIICEIMPH(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x6580990", Offset = "0x657F790", VA = "0x186580990", Slot = "128")]
	public void HCKJFIGJGEB(Vector3 OEPPFJFNIGI, ForceMode EPBICJOOLLM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x6582C00", Offset = "0x6581A00", VA = "0x186582C00", Slot = "129")]
	public void NJMOCBNPAKL(Vector3 OEPPFJFNIGI, Vector3 MHFADBEELBD, ForceMode EPBICJOOLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x657F4C0", Offset = "0x657E2C0", VA = "0x18657F4C0", Slot = "130")]
	public void EBGMHHCAPCO(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x65822D0", Offset = "0x65810D0", VA = "0x1865822D0", Slot = "131")]
	public void MHALFEFGJOK(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x657E420", Offset = "0x657D220", VA = "0x18657E420", Slot = "132")]
	public bool BHCHBFOMIPI(Vector3 MIEHBOELEKH, [Out] RaycastHit FLCMLIJJMDF, float HABIICFCBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x6582920", Offset = "0x6581720", VA = "0x186582920", Slot = "133")]
	public void NHDCMNAHDKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x6583D50", Offset = "0x6582B50", VA = "0x186583D50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x65833B0", Offset = "0x65821B0", VA = "0x1865833B0")]
	private void OOOONBNDILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6581DC0", Offset = "0x6580BC0", VA = "0x186581DC0")]
	private void LGHDCIDBNCE(HOCOKNCJJJL GEFCENNBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6581FD0", Offset = "0x6580DD0", VA = "0x186581FD0")]
	private void MAADBCACBDJ(HOCOKNCJJJL GEFCENNBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6582740", Offset = "0x6581540", VA = "0x186582740")]
	private void NEOGHIPBKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x657E1D0", Offset = "0x657CFD0", VA = "0x18657E1D0")]
	private void AODMIMNFNGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x657ECF0", Offset = "0x657DAF0", VA = "0x18657ECF0")]
	private void DCPBAOCLFIB(HOCOKNCJJJL HKFCBILJEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x657DED0", Offset = "0x657CCD0", VA = "0x18657DED0")]
	private void AADLCAECLDP(HOCOKNCJJJL GEFCENNBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6580FC0", Offset = "0x657FDC0", VA = "0x186580FC0")]
	private void JHCPEHGGFOG(HOCOKNCJJJL GEFCENNBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x657FD50", Offset = "0x657EB50", VA = "0x18657FD50")]
	private void EOAAGHBIOJB(RigidbodyEx GEFCENNBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x657FB90", Offset = "0x657E990", VA = "0x18657FB90", Slot = "140")]
	protected virtual void ENIMJBGALNK(RigidbodyEx PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6583570", Offset = "0x6582370", VA = "0x186583570")]
	protected void PEFCANBLKBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x657F820", Offset = "0x657E620", VA = "0x18657F820")]
	protected void EMDFMIOGDAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x6581B20", Offset = "0x6580920", VA = "0x186581B20", Slot = "141")]
	protected virtual IDisposable KLFMOFPLODJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class KPGOJBMMAHO
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6589500", Offset = "0x6588300", VA = "0x186589500")]
	public static HOCOKNCJJJL BCKKPDGCKOA(this HOCOKNCJJJL PEPBKPMNFNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6589700", Offset = "0x6588500", VA = "0x186589700")]
	public static bool MKBKCDLLDAN(this HOCOKNCJJJL PEPBKPMNFNI, HOCOKNCJJJL GPGJJKPHMFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6589680", Offset = "0x6588480", VA = "0x186589680")]
	public static bool HFDGPJMIIIG(this HOCOKNCJJJL PEPBKPMNFNI, HOCOKNCJJJL GEJPGMKHABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x65895B0", Offset = "0x65883B0", VA = "0x1865895B0")]
	public static RigidbodyEx EGONAAJJGKP(this HOCOKNCJJJL JCDNCCJHBID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6589600", Offset = "0x6588400", VA = "0x186589600")]
	public static HOIECNNMMJA FGJLLKCBPPO(this HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class MJJAKBIMOLC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly HOIECNNMMJA PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool DNFKHDPAHCP;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x658E0B0", Offset = "0x658CEB0", VA = "0x18658E0B0")]
	public MJJAKBIMOLC(HOIECNNMMJA CBMBPKNBJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x658E050", Offset = "0x658CE50", VA = "0x18658E050", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class DMFFJGPFOMN : HKGDMFAEAJF, KAANPNMIOAE
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CollisionDetectionMode KHNKMLHINMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6577AE0", Offset = "0x65768E0", VA = "0x186577AE0")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x65775F0", Offset = "0x65763F0", VA = "0x1865775F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody IPBDLEBHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x656EB10", Offset = "0x656D910", VA = "0x18656EB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode IDMHPOPJIHE
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6577B40", Offset = "0x6576940", VA = "0x186577B40", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6577680", Offset = "0x6576480", VA = "0x186577680", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x656F320", Offset = "0x656E120", VA = "0x18656F320")]
	public DMFFJGPFOMN(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6577990", Offset = "0x6576790", VA = "0x186577990", Slot = "6")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6577740", Offset = "0x6576540", VA = "0x186577740", Slot = "9")]
	public void IAODFPGOEMM(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6577670", Offset = "0x6576470", VA = "0x186577670", Slot = "7")]
	public void FIIPOLMLNMH(bool CILBJFBOKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6577660", Offset = "0x6576460", VA = "0x186577660", Slot = "8")]
	public void EHKJALKMMMF(bool CILBJFBOKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6577490", Offset = "0x6576290", VA = "0x186577490", Slot = "10")]
	public bool BHCHBFOMIPI(Vector3 MIEHBOELEKH, [Out] RaycastHit FLCMLIJJMDF, float HABIICFCBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6577820", Offset = "0x6576620", VA = "0x186577820")]
	private void IPNCMDCENEF(bool CILBJFBOKEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class POIFNJNPCJI : HKGDMFAEAJF, NEONIKIGNOM, IDisposable, OLBCLCMIHIN
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public PAFONDGDNMK DADGJFKOLKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6593170", Offset = "0x6591F70", VA = "0x186593170")]
		get
		{
			return default(PAFONDGDNMK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6593080", Offset = "0x6591E80", VA = "0x186593080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public PAFONDGDNMK MOLPKOCNFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6593300", Offset = "0x6592100", VA = "0x186593300", Slot = "6")]
		get
		{
			return default(PAFONDGDNMK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6593080", Offset = "0x6591E80", VA = "0x186593080", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private Transform FKAONBNEFGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x790850", Offset = "0x78F650", VA = "0x180790850", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<DBLNOAOKDFO, DBLNOAOKDFO> IPAOGELMBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6593500", Offset = "0x6592300", VA = "0x186593500", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6593250", Offset = "0x6592050", VA = "0x186593250", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x656F320", Offset = "0x656E120", VA = "0x18656F320")]
	public POIFNJNPCJI(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x65935B0", Offset = "0x65923B0", VA = "0x1865935B0", Slot = "11")]
	public void OnChangedDistanceBand(DBLNOAOKDFO IFLOCMFOCNC, DBLNOAOKDFO DGAGGGGMJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "12")]
	public void OnChangedVisibility(bool ELJJPHIJEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "8")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class ADOPNGEJLAG : HKGDMFAEAJF, KJJOBHEGCDH
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Rigidbody IPBDLEBHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x656EB10", Offset = "0x656D910", VA = "0x18656EB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool OEPGKIKIHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x656E8A0", Offset = "0x656D6A0", VA = "0x18656E8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool OMKJPAHHFCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x656EA50", Offset = "0x656D850", VA = "0x18656EA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private HOCOKNCJJJL KKHLELLCELL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x656EAB0", Offset = "0x656D8B0", VA = "0x18656EAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x656F320", Offset = "0x656E120", VA = "0x18656F320")]
	public ADOPNGEJLAG(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x656E8F0", Offset = "0x656D6F0", VA = "0x18656E8F0", Slot = "4")]
	public void HCKJFIGJGEB(Vector3 OEPPFJFNIGI, ForceMode EPBICJOOLLM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x656F040", Offset = "0x656DE40", VA = "0x18656F040")]
	private void PFPLKABGOFG(Vector3 OEPPFJFNIGI, ForceMode EPBICJOOLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x656EDC0", Offset = "0x656DBC0", VA = "0x18656EDC0", Slot = "5")]
	public void NJMOCBNPAKL(Vector3 OEPPFJFNIGI, Vector3 MHFADBEELBD, ForceMode EPBICJOOLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x656E660", Offset = "0x656D460", VA = "0x18656E660", Slot = "6")]
	public void EBGMHHCAPCO(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x656E400", Offset = "0x656D200", VA = "0x18656E400")]
	private void DGIPOGLNHLI(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x656EB60", Offset = "0x656D960", VA = "0x18656EB60", Slot = "7")]
	public void MHALFEFGJOK(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x656E7C0", Offset = "0x656D5C0", VA = "0x18656E7C0")]
	private void FPLGBFAGNKF(string EKPMNNKLPFJ, UnityEngine.Object BCCEHJNGNAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class PJPCACLBGIN : HKGDMFAEAJF, CPMGGCMJEFL
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool EECMBGIOICM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6592890", Offset = "0x6591690", VA = "0x186592890", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6592980", Offset = "0x6591780", VA = "0x186592980", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x656F320", Offset = "0x656E120", VA = "0x18656F320")]
	public PJPCACLBGIN(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x65928F0", Offset = "0x65916F0", VA = "0x1865928F0", Slot = "6")]
	public void IAODFPGOEMM(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6591220", Offset = "0x6590020", VA = "0x186591220", Slot = "7")]
	public void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class CAMHGBAECKN : HKGDMFAEAJF, CKLGIFHIGHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly IBJKCJFAAOH KJLJJPBFGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly LAGGFDMKHCI PMKPINEELFN;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private Transform NFGCKFGOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6571E20", Offset = "0x6570C20", VA = "0x186571E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public IHEBGBCJDGF PJKDBJAMCKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6571DC0", Offset = "0x6570BC0", VA = "0x186571DC0")]
		get
		{
			return default(IHEBGBCJDGF);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6571D50", Offset = "0x6570B50", VA = "0x186571D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public HOCOKNCJJJL KKHLELLCELL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x65725F0", Offset = "0x65713F0", VA = "0x1865725F0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x65711C0", Offset = "0x656FFC0", VA = "0x1865711C0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public IHEBGBCJDGF PBGBMBOBDNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x6571230", Offset = "0x6570030", VA = "0x186571230")]
		get
		{
			return default(IHEBGBCJDGF);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6572700", Offset = "0x6571500", VA = "0x186572700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public HOCOKNCJJJL AFMCAHCKNML
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6572AA0", Offset = "0x65718A0", VA = "0x186572AA0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyList<HOCOKNCJJJL> GBLPMGDCAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x78D1E0", Offset = "0x78BFE0", VA = "0x18078D1E0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event KMLLDHKLNHB BNAOHCNEGMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x65728C0", Offset = "0x65716C0", VA = "0x1865728C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6572660", Offset = "0x6571460", VA = "0x186572660", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event KMLLDHKLNHB HDECEFIHABI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6571290", Offset = "0x6570090", VA = "0x186571290", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6572960", Offset = "0x6571760", VA = "0x186572960", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event NIMMIJKBCKC MHJPLIPDKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6571B80", Offset = "0x6570980", VA = "0x186571B80", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x65720C0", Offset = "0x6570EC0", VA = "0x1865720C0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action HBJFOGNOFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6572820", Offset = "0x6571620", VA = "0x186572820", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6571330", Offset = "0x6570130", VA = "0x186571330", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action HBCGELIPFMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6571480", Offset = "0x6570280", VA = "0x186571480", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6571AE0", Offset = "0x65708E0", VA = "0x186571AE0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<HOCOKNCJJJL> CPOBBINAGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6572D10", Offset = "0x6571B10", VA = "0x186572D10", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6572C60", Offset = "0x6571A60", VA = "0x186572C60", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<HOCOKNCJJJL> FGAAOJOGPMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6572770", Offset = "0x6571570", VA = "0x186572770", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6571F20", Offset = "0x6570D20", VA = "0x186571F20", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action ENEHNMGDEFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x65719A0", Offset = "0x65707A0", VA = "0x1865719A0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6572BC0", Offset = "0x65719C0", VA = "0x186572BC0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<HOCOKNCJJJL> MHJCEFODJMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6572340", Offset = "0x6571140", VA = "0x186572340", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6572B10", Offset = "0x6571910", VA = "0x186572B10", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x65730A0", Offset = "0x6571EA0", VA = "0x1865730A0")]
	public CAMHGBAECKN(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6571C20", Offset = "0x6570A20", VA = "0x186571C20", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6571E50", Offset = "0x6570C50", VA = "0x186571E50", Slot = "26")]
	public void FAJLKEPAOJL(HOCOKNCJJJL BLKPHAHLOKB, bool CBBCAJJMHGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x6571ED0", Offset = "0x6570CD0", VA = "0x186571ED0")]
	private void FAJLKEPAOJL(NHPCFDNHGEI BLKPHAHLOKB, bool CBBCAJJMHGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x6571520", Offset = "0x6570320", VA = "0x186571520")]
	private void CBCDGNGCKDN(NHPCFDNHGEI BLKPHAHLOKB, bool CBBCAJJMHGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x6572DC0", Offset = "0x6571BC0", VA = "0x186572DC0")]
	private void POCNJHNIKOF(NHPCFDNHGEI HKFCBILJEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x65723F0", Offset = "0x65711F0", VA = "0x1865723F0")]
	private void KOLBEIOPEGH(NHPCFDNHGEI HKFCBILJEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6572160", Offset = "0x6570F60", VA = "0x186572160")]
	private void HPNLIMDINDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x65713D0", Offset = "0x65701D0", VA = "0x1865713D0")]
	private void BGLLEJONCHN(NHPCFDNHGEI HKFCBILJEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6571FD0", Offset = "0x6570DD0", VA = "0x186571FD0")]
	private void GNLDMELOJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6571A40", Offset = "0x6570840", VA = "0x186571A40")]
	private void CFNLJBABIEO(NHPCFDNHGEI PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6572A00", Offset = "0x6571800", VA = "0x186572A00")]
	private void NOFDGEJFFEB(NHPCFDNHGEI PEPBKPMNFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class MGEEGEFCHMI
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x658D5A0", Offset = "0x658C3A0", VA = "0x18658D5A0")]
	public static CAMHGBAECKN BOFFHIIBNLO(this HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class HOMLMJCKDBD : HKGDMFAEAJF, GLIPCIFAGOC
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Vector3 JINBIHENJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x65849C0", Offset = "0x65837C0", VA = "0x1865849C0", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 IJLCEKKMHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x65843D0", Offset = "0x65831D0", VA = "0x1865843D0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 LPCHKJFNCCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6583E60", Offset = "0x6582C60", VA = "0x186583E60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private HOCOKNCJJJL BHPBCMLBECJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6584860", Offset = "0x6583660", VA = "0x186584860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x656F320", Offset = "0x656E120", VA = "0x18656F320")]
	public HOMLMJCKDBD(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x6584600", Offset = "0x6583400", VA = "0x186584600", Slot = "6")]
	public void KCGMOLPFCCM(HOCOKNCJJJL GEFCENNBDFI, object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x6584750", Offset = "0x6583550", VA = "0x186584750")]
	private void KCGMOLPFCCM(NHPCFDNHGEI GEFCENNBDFI, object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6583F50", Offset = "0x6582D50", VA = "0x186583F50", Slot = "7")]
	public void FIIKKBLHPHA(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6583FC0", Offset = "0x6582DC0", VA = "0x186583FC0")]
	private Vector3 GBBKPHHCHCP()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class GHNBIHOOCDC
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x657B560", Offset = "0x657A360", VA = "0x18657B560")]
	public static HOMLMJCKDBD GEIECDDKJML(this HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class IEDFPEENBMD : HKGDMFAEAJF, BFNIHOELDII
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 EJCJCCCLDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x6587FF0", Offset = "0x6586DF0", VA = "0x186587FF0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6584AB0", Offset = "0x65838B0", VA = "0x186584AB0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 MKEIAPKPHDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x6584EE0", Offset = "0x6583CE0", VA = "0x186584EE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 INOIBAEICFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6587450", Offset = "0x6586250", VA = "0x186587450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 DGAECMDABMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6586840", Offset = "0x6585640", VA = "0x186586840", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float FODEBPPKIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6586B90", Offset = "0x6585990", VA = "0x186586B90", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float AKCEOLJBAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x6586580", Offset = "0x6585380", VA = "0x186586580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float JHADICINMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x6586520", Offset = "0x6585320", VA = "0x186586520", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6584C30", Offset = "0x6583A30", VA = "0x186584C30", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 OEIBPPHAACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x6586A30", Offset = "0x6585830", VA = "0x186586A30", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion JHMBGDMNHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x6584F90", Offset = "0x6583D90", VA = "0x186584F90", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody IPBDLEBHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x656EB10", Offset = "0x656D910", VA = "0x18656EB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event KMLLDHKLNHB MKEBNIGCJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x65880A0", Offset = "0x6586EA0", VA = "0x1865880A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x6586220", Offset = "0x6585020", VA = "0x186586220", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6588140", Offset = "0x6586F40", VA = "0x186588140")]
	public IEDFPEENBMD(HOCOKNCJJJL PEPBKPMNFNI, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6586F40", Offset = "0x6585D40", VA = "0x186586F40")]
	public float3 JLBKFIDBMMP()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6587580", Offset = "0x6586380", VA = "0x186587580", Slot = "14")]
	public void MJELCFAAKJB((Quaternion rot, Vector3 moments) FBAOFMDOKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6584CF0", Offset = "0x6583AF0", VA = "0x186584CF0", Slot = "16")]
	public void AGGNEFHHFBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6586BF0", Offset = "0x65859F0", VA = "0x186586BF0", Slot = "15")]
	public void JICBDBPLDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6586AC0", Offset = "0x65858C0", VA = "0x186586AC0", Slot = "18")]
	public void IAODFPGOEMM(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6587060", Offset = "0x6585E60", VA = "0x186587060", Slot = "19")]
	public void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6586A60", Offset = "0x6585860", VA = "0x186586A60", Slot = "17")]
	public void HOCMAMFFDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6587810", Offset = "0x6586610", VA = "0x186587810", Slot = "20")]
	public void NHDCMNAHDKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6577250", Offset = "0x6576050", VA = "0x186577250")]
	public void FLLEAFFBLIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6584AB0", Offset = "0x65838B0", VA = "0x186584AB0")]
	private void ACMHLJPKNDK(Vector3 MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6587E10", Offset = "0x6586C10", VA = "0x186587E10")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 OJIBJBCFMEO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x6584C30", Offset = "0x6583A30", VA = "0x186584C30")]
	private void AFHIHHCCAHF(float MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x65862C0", Offset = "0x65850C0", VA = "0x1865862C0")]
	private Vector3 DCLDAKGHPGG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x6586600", Offset = "0x6585400", VA = "0x186586600")]
	private Quaternion HEPLKICINDI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x6584FC0", Offset = "0x6583DC0", VA = "0x186584FC0")]
	internal (float, Vector3) CEELNNDPECH(Rigidbody OAFCIPMNNPA)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class KOLJLBFEINM
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x6589470", Offset = "0x6588270", VA = "0x186589470")]
	public static IEDFPEENBMD BIBCIIMEBPO(this HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class MHKOIELCNKI : HKGDMFAEAJF, DIFIBOKOPFH
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool OPHBHNHFOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x658DA10", Offset = "0x658C810", VA = "0x18658DA10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public GDIMELFCBCC MCFEFCOMAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x658D630", Offset = "0x658C430", VA = "0x18658D630", Slot = "11")]
		get
		{
			return default(GDIMELFCBCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private GDIMELFCBCC LOHKDNICOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x658D630", Offset = "0x658C430", VA = "0x18658D630")]
		get
		{
			return default(GDIMELFCBCC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x658DB70", Offset = "0x658C970", VA = "0x18658DB70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x658DF40", Offset = "0x658CD40", VA = "0x18658DF40")]
	public MHKOIELCNKI(HOCOKNCJJJL PEPBKPMNFNI, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x658DA70", Offset = "0x658C870", VA = "0x18658DA70", Slot = "4")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x658DE60", Offset = "0x658CC60", VA = "0x18658DE60")]
	private bool PEJOGAPIGNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x658DDE0", Offset = "0x658CBE0", VA = "0x18658DDE0", Slot = "5")]
	public void MFPLLCNOCAO(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x658DD60", Offset = "0x658CB60", VA = "0x18658DD60", Slot = "6")]
	public void LNGAPJGKAGE(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x658D690", Offset = "0x658C490", VA = "0x18658D690", Slot = "9")]
	public void BHJCIECCICC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x658DC60", Offset = "0x658CA60", VA = "0x18658DC60")]
	private void LLHDHGAEHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x658D870", Offset = "0x658C670", VA = "0x18658D870")]
	private void IADOGNODBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x658DBE0", Offset = "0x658C9E0", VA = "0x18658DBE0", Slot = "8")]
	public void KGLMAHJBOML(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x658D7F0", Offset = "0x658C5F0", VA = "0x18658D7F0", Slot = "7")]
	public void HCJFFMGGMPO(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class DLODNMICHKC : HKGDMFAEAJF, BKOKPDEKNJH
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool OEPGKIKIHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x6576F80", Offset = "0x6575D80", VA = "0x186576F80", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool FFPMMANMBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6577290", Offset = "0x6576090", VA = "0x186577290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event KMLLDHKLNHB BAHMJIMEKOI
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x65772F0", Offset = "0x65760F0", VA = "0x1865772F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x65770D0", Offset = "0x6575ED0", VA = "0x1865770D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x656F320", Offset = "0x656E120", VA = "0x18656F320")]
	public DLODNMICHKC(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x6576F10", Offset = "0x6575D10", VA = "0x186576F10", Slot = "11")]
	public IDisposable EGFHGEBFABK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x65770C0", Offset = "0x6575EC0", VA = "0x1865770C0", Slot = "8")]
	public void IENDNCEOIPO(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6576F00", Offset = "0x6575D00", VA = "0x186576F00", Slot = "9")]
	public void CKANGJMMAHK(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6577390", Offset = "0x6576190", VA = "0x186577390", Slot = "10")]
	public void PMFJDBOLJIN(object CGFEMNMBCOK, bool CBBINBGOOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x6576FE0", Offset = "0x6575DE0", VA = "0x186576FE0", Slot = "12")]
	public void IAODFPGOEMM(Rigidbody BPHKIOCOHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6577170", Offset = "0x6575F70", VA = "0x186577170", Slot = "13")]
	public void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6577250", Offset = "0x6576050", VA = "0x186577250", Slot = "6")]
	public void MBDDBOMIPDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class GNFJPDGNDDG : HKGDMFAEAJF, KOAIPOCHCAG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PhotonView DNCAKFJJANK;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool ABNELKLFCHC
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x657BAA0", Offset = "0x657A8A0", VA = "0x18657BAA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool JFIHIEOEGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x657C2D0", Offset = "0x657B0D0", VA = "0x18657C2D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event KMLLDHKLNHB DKFDPEBGMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x657BAC0", Offset = "0x657A8C0", VA = "0x18657BAC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x657C070", Offset = "0x657AE70", VA = "0x18657C070", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x657C360", Offset = "0x657B160", VA = "0x18657C360")]
	public GNFJPDGNDDG(HOCOKNCJJJL PEPBKPMNFNI, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x657BF40", Offset = "0x657AD40", VA = "0x18657BF40", Slot = "8")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x657B940", Offset = "0x657A740", VA = "0x18657B940", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x657B5F0", Offset = "0x657A3F0", VA = "0x18657B5F0", Slot = "9")]
	public void AADLCAECLDP(HOCOKNCJJJL GEFCENNBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x657BD40", Offset = "0x657AB40", VA = "0x18657BD40", Slot = "10")]
	public void JHCPEHGGFOG(HOCOKNCJJJL GEFCENNBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x657BB60", Offset = "0x657A960", VA = "0x18657BB60")]
	private void JEEICFENNDC(PhotonView GLOHIMKEIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x657B7F0", Offset = "0x657A5F0", VA = "0x18657B7F0")]
	private void DDHOIDLDDMM(RigidbodyEx OOHELMNJMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x657C110", Offset = "0x657AF10", VA = "0x18657C110")]
	private void OFPEFMEHGMI(PhotonView NNOJJJIGEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class EEHOOFKJMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x65789A0", Offset = "0x65777A0", VA = "0x1865789A0")]
	public static GNFJPDGNDDG FKKIGIGEEGG(this HOIECNNMMJA OGNMHOKFLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class IGGGDPJBGCK : HKGDMFAEAJF, DLBLGAFPKNL
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool FDFHHODHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6588800", Offset = "0x6587600", VA = "0x186588800", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6588620", Offset = "0x6587420", VA = "0x186588620", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool ANLLEHIJIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6588690", Offset = "0x6587490", VA = "0x186588690", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6588430", Offset = "0x6587230", VA = "0x186588430")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints HKHPMHDBMED
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x6588860", Offset = "0x6587660", VA = "0x186588860", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x65884A0", Offset = "0x65872A0", VA = "0x1865884A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x65888C0", Offset = "0x65876C0", VA = "0x1865888C0")]
	public IGGGDPJBGCK(HOCOKNCJJJL PEPBKPMNFNI, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x65886F0", Offset = "0x65874F0", VA = "0x1865886F0", Slot = "9")]
	public void IAODFPGOEMM(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6588780", Offset = "0x6587580", VA = "0x186588780", Slot = "10")]
	public void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class PAHNONEILFJ : HKGDMFAEAJF, JEAMKLFGBLG
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float GEJLHPDFKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x65913A0", Offset = "0x65901A0", VA = "0x1865913A0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6591770", Offset = "0x6590570", VA = "0x186591770", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float JJDGBGJFOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6591400", Offset = "0x6590200", VA = "0x186591400", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6591620", Offset = "0x6590420", VA = "0x186591620", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x656F320", Offset = "0x656E120", VA = "0x18656F320")]
	public PAHNONEILFJ(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x6591460", Offset = "0x6590260", VA = "0x186591460", Slot = "8")]
	public void IAODFPGOEMM(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x6591550", Offset = "0x6590350", VA = "0x186591550", Slot = "9")]
	public void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[PEPANDEJFKC(typeof(JJPMMEDFJKI), new string[] { })]
public sealed class HCLILGJOLMN : CAAHJAMNMLN, JJPMMEDFJKI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[GCMNLGLAIFA]
	private MNAODNLKFNG PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool DNFKHDPAHCP;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool AIJOHIMAHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x814B60", Offset = "0x813960", VA = "0x180814B60", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x657C720", Offset = "0x657B520", VA = "0x18657C720", Slot = "4")]
	public void InitReferences(ELAIGJGMPAC LFFHKCFMLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x657C600", Offset = "0x657B400", VA = "0x18657C600", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x657C4E0", Offset = "0x657B2E0", VA = "0x18657C4E0", Slot = "6")]
	public void CEELNNDPECH(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x657C8B0", Offset = "0x657B6B0", VA = "0x18657C8B0", Slot = "7")]
	public void JIMKOIOJAFE(IHEBGBCJDGF ELLEDDADJFH, bool PBECGCGDAFI, bool DBKHGCDGHOG, bool BODGCKGJLLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x657CBC0", Offset = "0x657B9C0", VA = "0x18657CBC0", Slot = "8")]
	public void OGFEDLIPHKP(IHEBGBCJDGF ELLEDDADJFH, float3 ELAAHADLBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x657C770", Offset = "0x657B570", VA = "0x18657C770", Slot = "9")]
	public void JENGFPDNEPG(IHEBGBCJDGF ELLEDDADJFH, float3 AENMCPJCABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x657CD00", Offset = "0x657BB00", VA = "0x18657CD00")]
	private bool PDAAJLKBBLF(IHEBGBCJDGF ELLEDDADJFH, [Out] NHPCFDNHGEI OGNMHOKFLGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x657C630", Offset = "0x657B430", VA = "0x18657C630")]
	private bool FCBGEOMLCLO(IHEBGBCJDGF ELLEDDADJFH, [Out] IEDFPEENBMD LNNNGLHPBKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x657CAD0", Offset = "0x657B8D0", VA = "0x18657CAD0")]
	private bool LMAMNIIEIDP(IHEBGBCJDGF ELLEDDADJFH, [Out] MBECJIKDLGN DHBMPKPEGHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public HCLILGJOLMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class HFOJLDKNGPI : HKGDMFAEAJF, KKCCCEBIOOC
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private Rigidbody IPBDLEBHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x656EB10", Offset = "0x656D910", VA = "0x18656EB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool GEFECGMFJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x657D630", Offset = "0x657C430", VA = "0x18657D630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private HOCOKNCJJJL KKHLELLCELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x657D570", Offset = "0x657C370", VA = "0x18657D570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool OMKJPAHHFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x657D4A0", Offset = "0x657C2A0", VA = "0x18657D4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool LCNJGPLDCJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x657D760", Offset = "0x657C560", VA = "0x18657D760")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x657D650", Offset = "0x657C450", VA = "0x18657D650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool IIPPEEKPHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x657D5D0", Offset = "0x657C3D0", VA = "0x18657D5D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x657D500", Offset = "0x657C300", VA = "0x18657D500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int ANJCAPHCGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x657D1F0", Offset = "0x657BFF0", VA = "0x18657D1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event KMLLDHKLNHB FPHBHNGLHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x657D400", Offset = "0x657C200", VA = "0x18657D400", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x657D6C0", Offset = "0x657C4C0", VA = "0x18657D6C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x657D7C0", Offset = "0x657C5C0", VA = "0x18657D7C0")]
	public HFOJLDKNGPI(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x657D350", Offset = "0x657C150", VA = "0x18657D350", Slot = "6")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x657D0A0", Offset = "0x657BEA0", VA = "0x18657D0A0", Slot = "8")]
	public void DNEFDHENJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x657CF00", Offset = "0x657BD00", VA = "0x18657CF00", Slot = "7")]
	public bool DDEBGNLPGNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x657D260", Offset = "0x657C060", VA = "0x18657D260", Slot = "9")]
	public void IFFAGOPFNMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6577250", Offset = "0x6576050", VA = "0x186577250", Slot = "12")]
	public void JNKCDBMJHEO(bool JNJHHJMDGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x657CDC0", Offset = "0x657BBC0", VA = "0x18657CDC0", Slot = "11")]
	public void AFHIICHEDNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "10")]
	public void HELPDJDAKNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x657D110", Offset = "0x657BF10", VA = "0x18657D110")]
	private void EKNIOINKFNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class CAKBPHLJIDO : HKGDMFAEAJF, BGIBMNHFFAL
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Rigidbody IPBDLEBHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6570FA0", Offset = "0x656FDA0", VA = "0x186570FA0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x65706D0", Offset = "0x656F4D0", VA = "0x1865706D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool OMKJPAHHFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x656EA50", Offset = "0x656D850", VA = "0x18656EA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool LKKCLGOAFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6570840", Offset = "0x656F640", VA = "0x186570840", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6571100", Offset = "0x656FF00", VA = "0x186571100")]
	public CAKBPHLJIDO(HOCOKNCJJJL PEPBKPMNFNI, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6570B00", Offset = "0x656F900", VA = "0x186570B00", Slot = "5")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x6571080", Offset = "0x656FE80", VA = "0x186571080", Slot = "7")]
	public void NHKMCHHACHL(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x65707C0", Offset = "0x656F5C0", VA = "0x1865707C0", Slot = "8")]
	public void CBGIICEIMPH(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6570BB0", Offset = "0x656F9B0", VA = "0x186570BB0", Slot = "9")]
	public void KJPDNIGCMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x65708A0", Offset = "0x656F6A0", VA = "0x1865708A0", Slot = "11")]
	public void GFFIHBECMAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x6570DD0", Offset = "0x656FBD0", VA = "0x186570DD0", Slot = "12")]
	public void KLBAHEAFICN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "10")]
	public void HOJBJFGFKBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class MBECJIKDLGN : HKGDMFAEAJF, PODEFIECECN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public MGCEECGEKMF LPFAHBIJNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x658A0E0", Offset = "0x6588EE0", VA = "0x18658A0E0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6589EA0", Offset = "0x6588CA0", VA = "0x186589EA0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public HPAJGICJEFB MGKENKKHODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x6589F10", Offset = "0x6588D10", VA = "0x186589F10", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x658A850", Offset = "0x6589650", VA = "0x18658A850", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 LPCHKJFNCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6589E40", Offset = "0x6588C40", VA = "0x186589E40", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x658A020", Offset = "0x6588E20", VA = "0x18658A020", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 NIKNGCBKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x658C230", Offset = "0x658B030", VA = "0x18658C230", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x658BCB0", Offset = "0x658AAB0", VA = "0x18658BCB0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 CLDGKCKHKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x658B430", Offset = "0x658A230", VA = "0x18658B430", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x658CEF0", Offset = "0x658BCF0", VA = "0x18658CEF0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 GAKADIGGDAE
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x658A930", Offset = "0x6589730", VA = "0x18658A930", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x658A190", Offset = "0x6588F90", VA = "0x18658A190", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float JPIKGPBAPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x658D230", Offset = "0x658C030", VA = "0x18658D230", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x658BCE0", Offset = "0x658AAE0", VA = "0x18658BCE0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool HGIFPNBCLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x658B320", Offset = "0x658A120", VA = "0x18658B320", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private KJJOBHEGCDH LPPAPCHCKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1E626F0", Offset = "0x1E614F0", VA = "0x181E626F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool GEFECGMFJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x657D630", Offset = "0x657C430", VA = "0x18657D630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x656F320", Offset = "0x656E120", VA = "0x18656F320")]
	public MBECJIKDLGN(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x658A8C0", Offset = "0x65896C0", VA = "0x18658A8C0", Slot = "20")]
	public void ECOKLILBDKM(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x658BC40", Offset = "0x658AA40", VA = "0x18658BC40", Slot = "30")]
	public void GMIMDDMODFH(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x658C260", Offset = "0x658B060", VA = "0x18658C260", Slot = "19")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x658A730", Offset = "0x6589530", VA = "0x18658A730", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x658BE30", Offset = "0x658AC30", VA = "0x18658BE30", Slot = "28")]
	public void IAODFPGOEMM(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x6589C60", Offset = "0x6588A60", VA = "0x186589C60", Slot = "35")]
	public Vector3 BJPPEMCNCNB(Vector3 GIDEDHBNIIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x658C4E0", Offset = "0x658B2E0", VA = "0x18658C4E0", Slot = "34")]
	public Vector3 KICPKKDLGLB(Vector3 ELAAHADLBAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x658C260", Offset = "0x658B060", VA = "0x18658C260", Slot = "27")]
	public void OFNJJILONJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x658D540", Offset = "0x658C340", VA = "0x18658D540", Slot = "25")]
	public void PMEMAPAJFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x658C910", Offset = "0x658B710", VA = "0x18658C910", Slot = "24")]
	public void KPOOFCIGNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x658B490", Offset = "0x658A290", VA = "0x18658B490", Slot = "33")]
	public void GBNPJKONKNI(Vector3 ICMDGAJHNJH, Vector3 NLEHEKMGGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x658A7F0", Offset = "0x65895F0", VA = "0x18658A7F0", Slot = "32")]
	public void EBCPJPAPBLD(Vector3 LEGBBGNFGAH, Vector3 AENMCPJCABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x6589A30", Offset = "0x6588830", VA = "0x186589A30", Slot = "31")]
	public void AJEKGCONBHI(Vector3 NNEEBDCMMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x658A1C0", Offset = "0x6588FC0", VA = "0x18658A1C0", Slot = "22")]
	public void DPPEIIHAENP(AHJEMOLEOCF DOMBBBCLFNH, Vector3 JDPPPDLIMNC, float FGMPHFJDLNP, float NHIPDPPCCON = 8f, float JLAKPJONIJI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x658D290", Offset = "0x658C090", VA = "0x18658D290", Slot = "21")]
	public void OFMPPFIBNAG(BLKDNNDGCAM NOLEAKKDJBJ, Vector3 CADBLKCNADJ, float FLNLIBPIIPJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x658AF10", Offset = "0x6589D10", VA = "0x18658AF10", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ELHBGOAJOGC(BLKDNNDGCAM NOLEAKKDJBJ, Vector3 NJBEEEBFFMP, float GEICNPCCJJP = 7f, float HAIPIONFKGO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x658C6A0", Offset = "0x658B4A0", VA = "0x18658C6A0", Slot = "29")]
	public Vector3 KJGPOOAELFJ(Vector3 IBOAKNMBPHJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x658C780", Offset = "0x658B580", VA = "0x18658C780", Slot = "26")]
	public void KMHMNKCAIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x658BCE0", Offset = "0x658AAE0", VA = "0x18658BCE0")]
	private void HNFMHNDFKDF(float MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x658C310", Offset = "0x658B110", VA = "0x18658C310")]
	private void KEFGNCKFJJL(Vector3 CADBLKCNADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x658CFB0", Offset = "0x658BDB0", VA = "0x18658CFB0")]
	private Vector3 NOKJLBMDJJP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x658C970", Offset = "0x658B770", VA = "0x18658C970")]
	private void MJKDCGNFPAC(Vector3 ELAAHADLBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x658BFA0", Offset = "0x658ADA0", VA = "0x18658BFA0")]
	private Vector3 JEGPOCGLFKJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x658B6D0", Offset = "0x658A4D0", VA = "0x18658B6D0")]
	private void GLKGKHDHCBK(Vector3 MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6589C00", Offset = "0x6588A00", VA = "0x186589C00")]
	private void BCABKNJEBMO(Vector3 IBOAKNMBPHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x6589FC0", Offset = "0x6588DC0", VA = "0x186589FC0")]
	private void CJNEBKOBJEO(Vector3 LAKKBNDDMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x658A960", Offset = "0x6589760", VA = "0x18658A960")]
	private void EKDOAPFGJDH(string JNPJNIPAMLF, Vector3 MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x658B380", Offset = "0x658A180", VA = "0x18658B380")]
	private void FJEDPDNKEBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class HKGDMFAEAJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly NHPCFDNHGEI PEPBKPMNFNI;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected MNAODNLKFNG IPFJFBHDGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x566B410", Offset = "0x566A210", VA = "0x18566B410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x566B450", Offset = "0x566A250", VA = "0x18566B450")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x656F320", Offset = "0x656E120", VA = "0x18656F320")]
	public HKGDMFAEAJF(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x657DE30", Offset = "0x657CC30", VA = "0x18657DE30")]
	protected HOCOKNCJJJL PMNNKJDGFHC(IHEBGBCJDGF PGGKKHAPCMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class PEMLGJIKOJH : AFIHALNIHNG
{
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6592600", Offset = "0x6591400", VA = "0x186592600", Slot = "4")]
	public CKLGIFHIGHO OKFBKNPKKJO(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x6591B10", Offset = "0x6590910", VA = "0x186591B10", Slot = "5")]
	public PODEFIECECN DIJHOGKFJKM(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6591E10", Offset = "0x6590C10", VA = "0x186591E10", Slot = "6")]
	public GLIPCIFAGOC GDJPHBPKHNJ(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6592740", Offset = "0x6591540", VA = "0x186592740", Slot = "7")]
	public JEAMKLFGBLG PGCAICLJJGM(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x65918C0", Offset = "0x65906C0", VA = "0x1865918C0", Slot = "8")]
	public KKCCCEBIOOC ALKBCLEDBPK(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x65921E0", Offset = "0x6590FE0", VA = "0x1865921E0", Slot = "9")]
	public NEONIKIGNOM ILMBMNHMFAG(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6591F60", Offset = "0x6590D60", VA = "0x186591F60", Slot = "10")]
	public BKOKPDEKNJH IDLHODBOGHG(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6591D30", Offset = "0x6590B30", VA = "0x186591D30", Slot = "11")]
	public KJJOBHEGCDH EOMIFOEKPNK(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x6591A30", Offset = "0x6590830", VA = "0x186591A30", Slot = "12")]
	public KAANPNMIOAE BMPPGEDLLOD(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6592660", Offset = "0x6591460", VA = "0x186592660", Slot = "13")]
	public CPMGGCMJEFL PBPMEFGGJCN(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6592400", Offset = "0x6591200", VA = "0x186592400")]
	public BGIBMNHFFAL OJMFJOJGMAK(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6592500", Offset = "0x6591300", VA = "0x186592500")]
	public KOAIPOCHCAG OBJFBIMFFOJ(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6591BF0", Offset = "0x65909F0", VA = "0x186591BF0")]
	public DIFIBOKOPFH EBDPONLMGFC(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x6591EF0", Offset = "0x6590CF0", VA = "0x186591EF0")]
	public BFNIHOELDII JNILOGAKBGP(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6592040", Offset = "0x6590E40", VA = "0x186592040")]
	public DLBLGAFPKNL IKOHNJJNLIG(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x65922C0", Offset = "0x65910C0", VA = "0x1865922C0", Slot = "19")]
	public HOCOKNCJJJL JNIPPDNMLOE(RigidbodyEx PEPBKPMNFNI, FIBIHOCDGLH HKPHNGEBIED, KIHGMKIMLMB OMCPJFGHGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public PEMLGJIKOJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6592400", Offset = "0x6591200", VA = "0x186592400", Slot = "14")]
	private BGIBMNHFFAL MLHEILBJOJF(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6592500", Offset = "0x6591300", VA = "0x186592500", Slot = "15")]
	private KOAIPOCHCAG NDGNBJCIPCK(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6591BF0", Offset = "0x65909F0", VA = "0x186591BF0", Slot = "16")]
	private DIFIBOKOPFH KFOKNDKJEMN(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x6591EF0", Offset = "0x6590CF0", VA = "0x186591EF0", Slot = "17")]
	private BFNIHOELDII HKFFIEFLGAN(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x65923F0", Offset = "0x65911F0", VA = "0x1865923F0", Slot = "18")]
	private DLBLGAFPKNL MHHEDGELOOO(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public sealed class LAGGFDMKHCI : IReadOnlyList<HOCOKNCJJJL>, IEnumerable<HOCOKNCJJJL>, IEnumerable, IReadOnlyCollection<HOCOKNCJJJL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly MNAODNLKFNG FPJDEMDEKEI;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x65899E0", Offset = "0x65887E0", VA = "0x1865899E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public HOCOKNCJJJL CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x6589890", Offset = "0x6588690", VA = "0x186589890", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x36F37F0", Offset = "0x36F25F0", VA = "0x1836F37F0")]
	public LAGGFDMKHCI(IHEBGBCJDGF PGGKKHAPCMA, MNAODNLKFNG FPJDEMDEKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6589780", Offset = "0x6588580", VA = "0x186589780", Slot = "6")]
	public IEnumerator<HOCOKNCJJJL> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x6589780", Offset = "0x6588580", VA = "0x186589780", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6589890", Offset = "0x6588690", VA = "0x186589890")]
	[CompilerGenerated]
	private HOCOKNCJJJL KJFMAEABJJG(int HBLLIHHIKIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[PEPANDEJFKC(typeof(AFIHALNIHNG), new string[] { })]
public class NMCPOEBKPNO : AFIHALNIHNG, CAAHJAMNMLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly AFIHALNIHNG IIDDNEKMDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly AFIHALNIHNG KMIADGADFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HFNEOJBFIDL DHNLBCIJHGE;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private AFIHALNIHNG ODNOMPLAOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x658F5E0", Offset = "0x658E3E0", VA = "0x18658F5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x658F980", Offset = "0x658E780", VA = "0x18658F980", Slot = "20")]
	public void InitReferences(ELAIGJGMPAC LFFHKCFMLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x658FC20", Offset = "0x658EA20", VA = "0x18658FC20", Slot = "4")]
	public CKLGIFHIGHO OKFBKNPKKJO(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x658F3F0", Offset = "0x658E1F0", VA = "0x18658F3F0", Slot = "5")]
	public PODEFIECECN DIJHOGKFJKM(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x658F640", Offset = "0x658E440", VA = "0x18658F640", Slot = "6")]
	public GLIPCIFAGOC GDJPHBPKHNJ(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x658FD60", Offset = "0x658EB60", VA = "0x18658FD60", Slot = "7")]
	public JEAMKLFGBLG PGCAICLJJGM(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x658F2B0", Offset = "0x658E0B0", VA = "0x18658F2B0", Slot = "8")]
	public KKCCCEBIOOC ALKBCLEDBPK(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x658F8E0", Offset = "0x658E6E0", VA = "0x18658F8E0", Slot = "9")]
	public NEONIKIGNOM ILMBMNHMFAG(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x658F790", Offset = "0x658E590", VA = "0x18658F790", Slot = "10")]
	public BKOKPDEKNJH IDLHODBOGHG(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x658F540", Offset = "0x658E340", VA = "0x18658F540", Slot = "11")]
	public KJJOBHEGCDH EOMIFOEKPNK(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x658F350", Offset = "0x658E150", VA = "0x18658F350", Slot = "12")]
	public KAANPNMIOAE BMPPGEDLLOD(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x658FCC0", Offset = "0x658EAC0", VA = "0x18658FCC0", Slot = "13")]
	public CPMGGCMJEFL PBPMEFGGJCN(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x658FAC0", Offset = "0x658E8C0", VA = "0x18658FAC0")]
	public BGIBMNHFFAL OJMFJOJGMAK(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x658FB70", Offset = "0x658E970", VA = "0x18658FB70")]
	public KOAIPOCHCAG OBJFBIMFFOJ(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x658F490", Offset = "0x658E290", VA = "0x18658F490")]
	public DIFIBOKOPFH EBDPONLMGFC(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x658F6E0", Offset = "0x658E4E0", VA = "0x18658F6E0")]
	public BFNIHOELDII JNILOGAKBGP(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x658F830", Offset = "0x658E630", VA = "0x18658F830")]
	public DLBLGAFPKNL IKOHNJJNLIG(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x658F9D0", Offset = "0x658E7D0", VA = "0x18658F9D0", Slot = "19")]
	public HOCOKNCJJJL JNIPPDNMLOE(RigidbodyEx PEPBKPMNFNI, FIBIHOCDGLH HKPHNGEBIED, KIHGMKIMLMB OMCPJFGHGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x658FE00", Offset = "0x658EC00", VA = "0x18658FE00")]
	public NMCPOEBKPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x658FAC0", Offset = "0x658E8C0", VA = "0x18658FAC0", Slot = "14")]
	private BGIBMNHFFAL MLHEILBJOJF(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x658FB70", Offset = "0x658E970", VA = "0x18658FB70", Slot = "15")]
	private KOAIPOCHCAG NDGNBJCIPCK(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x658F490", Offset = "0x658E290", VA = "0x18658F490", Slot = "16")]
	private DIFIBOKOPFH KFOKNDKJEMN(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x658F6E0", Offset = "0x658E4E0", VA = "0x18658F6E0", Slot = "17")]
	private BFNIHOELDII HKFFIEFLGAN(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x658F830", Offset = "0x658E630", VA = "0x18658F830", Slot = "18")]
	private DLBLGAFPKNL MHHEDGELOOO(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[UnityEngine.Scripting.Preserve]
public sealed class CONMMLJELMN : HOCOKNCJJJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly CONMMLJELMN CEIKCOHBGGB;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Rigidbody IPBDLEBHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public RigidbodyEx EGONAAJJGKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GameObject KKKIKGBJKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Transform NFGCKFGOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x78E2A0", Offset = "0x78D0A0", VA = "0x18078E2A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public HOCOKNCJJJL KKHLELLCELL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x78E270", Offset = "0x78D070", VA = "0x18078E270", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7944B0", Offset = "0x7932B0", VA = "0x1807944B0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IReadOnlyList<HOCOKNCJJJL> GBLPMGDCAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x78DFA0", Offset = "0x78CDA0", VA = "0x18078DFA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public HOCOKNCJJJL AFMCAHCKNML
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x78E1F0", Offset = "0x78CFF0", VA = "0x18078E1F0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool ABNELKLFCHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x804710", Offset = "0x803510", VA = "0x180804710", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool JFIHIEOEGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7D8FA0", Offset = "0x7D7DA0", VA = "0x1807D8FA0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public MGCEECGEKMF LPFAHBIJNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x78D1A0", Offset = "0x78BFA0", VA = "0x18078D1A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x78D1C0", Offset = "0x78BFC0", VA = "0x18078D1C0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public HPAJGICJEFB MGKENKKHODO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x78D1B0", Offset = "0x78BFB0", VA = "0x18078D1B0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x78D1D0", Offset = "0x78BFD0", VA = "0x18078D1D0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float JPIKGPBAPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x9E4300", Offset = "0x9E3100", VA = "0x1809E4300", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x89ECC0", Offset = "0x89DAC0", VA = "0x18089ECC0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 NIKNGCBKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1B22EF0", Offset = "0x1B21CF0", VA = "0x181B22EF0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3A8F1C0", Offset = "0x3A8DFC0", VA = "0x183A8F1C0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 GAKADIGGDAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x46C32D0", Offset = "0x46C20D0", VA = "0x1846C32D0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x46C2660", Offset = "0x46C1460", VA = "0x1846C2660", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 LPCHKJFNCCE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x324CDD0", Offset = "0x324BBD0", VA = "0x18324CDD0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x324E200", Offset = "0x324D000", VA = "0x18324E200", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 CLDGKCKHKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xB1AE80", Offset = "0xB19C80", VA = "0x180B1AE80", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool MKMJFAPOFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x92A540", Offset = "0x929340", VA = "0x18092A540", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool KPODKJNJJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1763390", Offset = "0x1762190", VA = "0x181763390", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool HGIFPNBCLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5E0AC20", Offset = "0x5E09A20", VA = "0x185E0AC20", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 JINBIHENJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x324CD10", Offset = "0x324BB10", VA = "0x18324CD10", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 IJLCEKKMHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x955DE0", Offset = "0x954BE0", VA = "0x180955DE0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 EJCJCCCLDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xB1AE80", Offset = "0xB19C80", VA = "0x180B1AE80", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 DGAECMDABMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x65732A0", Offset = "0x65720A0", VA = "0x1865732A0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float FODEBPPKIDA
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1A4A320", Offset = "0x1A49120", VA = "0x181A4A320", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float JHADICINMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7E0BB0", Offset = "0x7DF9B0", VA = "0x1807E0BB0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 OEIBPPHAACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xB1AE80", Offset = "0xB19C80", VA = "0x180B1AE80", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion JHMBGDMNHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7DFE10", Offset = "0x7DEC10", VA = "0x1807DFE10", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float GEJLHPDFKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7E0BB0", Offset = "0x7DF9B0", VA = "0x1807E0BB0", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float JJDGBGJFOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7E0BB0", Offset = "0x7DF9B0", VA = "0x1807E0BB0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool EECMBGIOICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public PAFONDGDNMK MOLPKOCNFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "48")]
		get
		{
			return default(PAFONDGDNMK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool OEPGKIKIHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xCBF9C0", Offset = "0xCBE7C0", VA = "0x180CBF9C0", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Transform MDKKBAHPDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x8F5C10", Offset = "0x8F4A10", VA = "0x1808F5C10", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 NGCGAKJOFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xB1AE80", Offset = "0xB19C80", VA = "0x180B1AE80", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float JNOEGBPPEPF
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7E0BB0", Offset = "0x7DF9B0", VA = "0x1807E0BB0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float CDHGIFNIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7E0BB0", Offset = "0x7DF9B0", VA = "0x1807E0BB0", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion CLLHHFCJJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x97BEF0", Offset = "0x97ACF0", VA = "0x18097BEF0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 NPLKDHGJDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xB1AE80", Offset = "0xB19C80", VA = "0x180B1AE80", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion GJJMADPKFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x97BEF0", Offset = "0x97ACF0", VA = "0x18097BEF0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints HKHPMHDBMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x790850", Offset = "0x78F650", VA = "0x180790850", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool FDFHHODHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CollisionDetectionMode IDMHPOPJIHE
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x790850", Offset = "0x78F650", VA = "0x180790850", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool JNOAJEPMAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x8CAC40", Offset = "0x8C9A40", VA = "0x1808CAC40", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event KMLLDHKLNHB BNAOHCNEGMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event KMLLDHKLNHB HDECEFIHABI
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event NIMMIJKBCKC MHJPLIPDKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event KMLLDHKLNHB DKFDPEBGMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event KMLLDHKLNHB MBNIDDDOFPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event KMLLDHKLNHB FPHBHNGLHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<DBLNOAOKDFO, DBLNOAOKDFO> IPAOGELMBEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event KMLLDHKLNHB BAHMJIMEKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event KMLLDHKLNHB OIPAMNELJOI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "41")]
	public void MJELCFAAKJB((Quaternion rot, Vector3 moments) FBAOFMDOKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "71")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "72")]
	public void MPHBBHPMAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "73")]
	public void GMIHCFFINOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "74")]
	public void IFFAGOPFNMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "81")]
	public void FAJLKEPAOJL(HOCOKNCJJJL MBDKMNBCLGF, bool CBBCAJJMHGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "84")]
	public void BPNNKGFPPMF(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "85")]
	public void FDOAJHEFCLF(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xB1AE80", Offset = "0xB19C80", VA = "0x180B1AE80", Slot = "86")]
	public Vector3 BJPPEMCNCNB(Vector3 GIDEDHBNIIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xB1AE80", Offset = "0xB19C80", VA = "0x180B1AE80", Slot = "87")]
	public Vector3 KICPKKDLGLB(Vector3 ELAAHADLBAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "88")]
	public void OFNJJILONJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "89")]
	public void PMEMAPAJFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "90")]
	public void KPOOFCIGNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "91")]
	public void GBNPJKONKNI(Vector3 ICMDGAJHNJH, Vector3 NLEHEKMGGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "92")]
	public void EBCPJPAPBLD(Vector3 LEGBBGNFGAH, Vector3 AENMCPJCABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "93")]
	public void AJEKGCONBHI(Vector3 NNEEBDCMMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "94")]
	public void DPPEIIHAENP(AHJEMOLEOCF DOMBBBCLFNH, Vector3 JDPPPDLIMNC, float FGMPHFJDLNP, float NHIPDPPCCON = 8f, float JLAKPJONIJI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "95")]
	public void OFMPPFIBNAG(BLKDNNDGCAM NOLEAKKDJBJ, Vector3 CADBLKCNADJ, float FLNLIBPIIPJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "96")]
	public void ELHBGOAJOGC(BLKDNNDGCAM NOLEAKKDJBJ, Vector3 NJBEEEBFFMP, float GEICNPCCJJP = 7f, float HAIPIONFKGO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xB1AE80", Offset = "0xB19C80", VA = "0x180B1AE80", Slot = "97")]
	public Vector3 KJGPOOAELFJ(Vector3 MBDKMNBCLGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xB1AE80", Offset = "0xB19C80", VA = "0x180B1AE80", Slot = "98")]
	public Vector3 FDJIPELKHIA(Vector3 MBDKMNBCLGF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "99")]
	public void KMHMNKCAIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "100")]
	public void DNIIGNIMPDE(HOCOKNCJJJL FFJOAOEIGIP, object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "101")]
	public void PKELMAKFLIK(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "104")]
	public void AGGNEFHHFBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "105")]
	public void JICBDBPLDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "106")]
	public void HOCMAMFFDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "109")]
	public bool DDEBGNLPGNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "110")]
	public void AFHIICHEDNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x790850", Offset = "0x78F650", VA = "0x180790850", Slot = "115")]
	public IDisposable EGFHGEBFABK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "116")]
	public void IENDNCEOIPO(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "117")]
	public void CKANGJMMAHK(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "118")]
	public void PMFJDBOLJIN(object CGFEMNMBCOK, bool CBBINBGOOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "121")]
	public void PEIOJNEJNHP(Vector3 PFANPBOJHKO, Quaternion JLIIAAHEPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "122")]
	public void NIOKEFCGOLH(Vector3 JFGNPHEAHMM, Quaternion ENJEADHDIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "123")]
	public bool HPBOLFFGNPL(float HEJLHBONEPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "124")]
	public void MDPKCEGMPGM(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "125")]
	public void HEGNFAIAPEJ(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "126")]
	public void NHKMCHHACHL(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "127")]
	public void CBGIICEIMPH(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "128")]
	public void HCKJFIGJGEB(Vector3 OEPPFJFNIGI, ForceMode EPBICJOOLLM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "129")]
	public void NJMOCBNPAKL(Vector3 OEPPFJFNIGI, Vector3 MHFADBEELBD, ForceMode EPBICJOOLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "130")]
	public void EBGMHHCAPCO(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "131")]
	public void MHALFEFGJOK(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6573280", Offset = "0x6572080", VA = "0x186573280", Slot = "132")]
	public bool BHCHBFOMIPI(Vector3 MIEHBOELEKH, [Out] RaycastHit FLCMLIJJMDF, float HABIICFCBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "133")]
	public void NHDCMNAHDKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public CONMMLJELMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class NHPCFDNHGEI : HOIECNNMMJA, FHGIILMILDH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal MNAODNLKFNG CCCICOOIKEA;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6583D90", Offset = "0x6582B90", VA = "0x186583D90")]
	public NHPCFDNHGEI(GameObject FAIKIGMIEFB, RigidbodyEx PGDECOKLCDF, KIHGMKIMLMB OMCPJFGHGNL, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x658EBF0", Offset = "0x658D9F0", VA = "0x18658EBF0", Slot = "135")]
	protected override void NKNJKCGIGKK(KIHGMKIMLMB OMCPJFGHGNL, FIBIHOCDGLH HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x790850", Offset = "0x78F650", VA = "0x180790850", Slot = "141")]
	protected override IDisposable KLFMOFPLODJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x658E700", Offset = "0x658D500", VA = "0x18658E700", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x658EB20", Offset = "0x658D920", VA = "0x18658EB20", Slot = "142")]
	public void LHIMCGHOPEJ(GEKKOKFDLIA IFLOCMFOCNC, GEKKOKFDLIA DGAGGGGMJJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x658EEC0", Offset = "0x658DCC0", VA = "0x18658EEC0", Slot = "143")]
	public void ONHLENKOBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x658EA60", Offset = "0x658D860", VA = "0x18658EA60", Slot = "144")]
	public void JOIAJCKKGHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x658EA00", Offset = "0x658D800", VA = "0x18658EA00", Slot = "145")]
	public void JNKCDBMJHEO(bool JNJHHJMDGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x658E870", Offset = "0x658D670", VA = "0x18658E870", Slot = "146")]
	public bool FANBEMKGHGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x658EE60", Offset = "0x658DC60", VA = "0x18658EE60", Slot = "147")]
	public void OBPNHEIFIEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "140")]
	protected override void ENIMJBGALNK(RigidbodyEx JFLBCAAFGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x658EF80", Offset = "0x658DD80", VA = "0x18658EF80")]
	private void OOKHDMKMKKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class BKANDDHLPDF
{
	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6570680", Offset = "0x656F480", VA = "0x186570680")]
	public static HOIECNNMMJA CPKONDHEDOE(this HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface CLGMEOPHBKD : CKLGIFHIGHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFNLJBABIEO(HOCOKNCJJJL PEPBKPMNFNI);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOFDGEJFFEB(HOCOKNCJJJL PEPBKPMNFNI);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void POCNJHNIKOF(HOCOKNCJJJL HKFCBILJEBG);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KOLBEIOPEGH(HOCOKNCJJJL HKFCBILJEBG);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface LPIHEECJOPL : GLIPCIFAGOC
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	AALKOAKIONG<HOCOKNCJJJL> DPLLOKKEPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	HOCOKNCJJJL BHPBCMLBECJ
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface HANBEKHPMHE : BFNIHOELDII
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) CEELNNDPECH(Rigidbody OAFCIPMNNPA);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface PMEGKAHEOGD : KOAIPOCHCAG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PhotonView CPGMFIBABKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class PLCHLNNIFHD : KAANPNMIOAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly HOIECNNMMJA PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private CollisionDetectionMode HKBIKBAHJPD;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private Rigidbody IPBDLEBHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x656EB10", Offset = "0x656D910", VA = "0x18656EB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode IDMHPOPJIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x6592F70", Offset = "0x6591D70", VA = "0x186592F70", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x6592C50", Offset = "0x6591A50", VA = "0x186592C50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6578910", Offset = "0x6577710", VA = "0x186578910")]
	public PLCHLNNIFHD(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6592E60", Offset = "0x6591C60", VA = "0x186592E60", Slot = "6")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6592CC0", Offset = "0x6591AC0", VA = "0x186592CC0", Slot = "9")]
	public void IAODFPGOEMM(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6592C40", Offset = "0x6591A40", VA = "0x186592C40", Slot = "7")]
	public void FIIPOLMLNMH(bool CILBJFBOKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6592C30", Offset = "0x6591A30", VA = "0x186592C30", Slot = "8")]
	public void EHKJALKMMMF(bool CILBJFBOKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x6592AD0", Offset = "0x65918D0", VA = "0x186592AD0", Slot = "10")]
	public bool BHCHBFOMIPI(Vector3 MIEHBOELEKH, [Out] RaycastHit FLCMLIJJMDF, float HABIICFCBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6592D40", Offset = "0x6591B40", VA = "0x186592D40")]
	private void IPNCMDCENEF(bool CILBJFBOKEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class JFCFIMHANDA : NEONIKIGNOM, IDisposable, OLBCLCMIHIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly HOIECNNMMJA PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private PAFONDGDNMK FFCFMCFKHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private GHJCIMDKCIA ICKMHIBBNFH;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public PAFONDGDNMK MOLPKOCNFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x6588EC0", Offset = "0x6587CC0", VA = "0x186588EC0", Slot = "6")]
		get
		{
			return default(PAFONDGDNMK);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x6588CF0", Offset = "0x6587AF0", VA = "0x186588CF0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform FKAONBNEFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6589310", Offset = "0x6588110", VA = "0x186589310", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<DBLNOAOKDFO, DBLNOAOKDFO> IPAOGELMBEC
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x6589330", Offset = "0x6588130", VA = "0x186589330", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x6588DC0", Offset = "0x6587BC0", VA = "0x186588DC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x65893E0", Offset = "0x65881E0", VA = "0x1865893E0")]
	public JFCFIMHANDA(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6589010", Offset = "0x6587E10", VA = "0x186589010", Slot = "8")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6588E70", Offset = "0x6587C70", VA = "0x186588E70", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1BAB5B0", Offset = "0x1BAA3B0", VA = "0x181BAB5B0", Slot = "11")]
	private void EBLMNIEPDBN(DBLNOAOKDFO HKNGEMLKFBK, DBLNOAOKDFO JCBPPFJLBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "12")]
	private void JIIKKJNNAOC(bool ELJJPHIJEBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class DMMECKAIALC : KJJOBHEGCDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly HOIECNNMMJA PEPBKPMNFNI;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Rigidbody IPBDLEBHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x656EB10", Offset = "0x656D910", VA = "0x18656EB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool OEPGKIKIHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x656E8A0", Offset = "0x656D6A0", VA = "0x18656E8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool OMKJPAHHFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x656EA50", Offset = "0x656D850", VA = "0x18656EA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private HOCOKNCJJJL KKHLELLCELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6578170", Offset = "0x6576F70", VA = "0x186578170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6578910", Offset = "0x6577710", VA = "0x186578910")]
	public DMMECKAIALC(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6578010", Offset = "0x6576E10", VA = "0x186578010", Slot = "4")]
	public void HCKJFIGJGEB(Vector3 OEPPFJFNIGI, ForceMode EPBICJOOLLM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x65786B0", Offset = "0x65774B0", VA = "0x1865786B0")]
	private void PFPLKABGOFG(Vector3 OEPPFJFNIGI, ForceMode EPBICJOOLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x6578430", Offset = "0x6577230", VA = "0x186578430", Slot = "5")]
	public void NJMOCBNPAKL(Vector3 OEPPFJFNIGI, Vector3 MHFADBEELBD, ForceMode EPBICJOOLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6577EB0", Offset = "0x6576CB0", VA = "0x186577EB0", Slot = "6")]
	public void EBGMHHCAPCO(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6577C50", Offset = "0x6576A50", VA = "0x186577C50")]
	private void DGIPOGLNHLI(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x65781D0", Offset = "0x6576FD0", VA = "0x1865781D0", Slot = "7")]
	public void MHALFEFGJOK(Vector3 FKPNPMPFICH, ForceMode EPBICJOOLLM = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class PAGOMMEBOLO : CPMGGCMJEFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly HOIECNNMMJA PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool GPEMLPIJEHD;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool EECMBGIOICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x814B60", Offset = "0x813960", VA = "0x180814B60", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x6591290", Offset = "0x6590090", VA = "0x186591290", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6578910", Offset = "0x6577710", VA = "0x186578910")]
	public PAGOMMEBOLO(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x65911F0", Offset = "0x658FFF0", VA = "0x1865911F0", Slot = "6")]
	public void IAODFPGOEMM(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6591220", Offset = "0x6590020", VA = "0x186591220", Slot = "7")]
	public void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class EIGLKNOLOPN : CLGMEOPHBKD, CKLGIFHIGHO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly HOCOKNCJJJL PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<HOCOKNCJJJL> AEBCGDIKJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private HOCOKNCJJJL BPBPHOELENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private HOCOKNCJJJL GEFCENNBDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform CLMPNAKCOFK;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private Transform NFGCKFGOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x6579210", Offset = "0x6578010", VA = "0x186579210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public HOCOKNCJJJL KKHLELLCELL
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x78E0C0", Offset = "0x78CEC0", VA = "0x18078E0C0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6578A00", Offset = "0x6577800", VA = "0x186578A00", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public HOCOKNCJJJL AFMCAHCKNML
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x78E210", Offset = "0x78D010", VA = "0x18078E210", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IReadOnlyList<HOCOKNCJJJL> GBLPMGDCAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x78D1E0", Offset = "0x78BFE0", VA = "0x18078D1E0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event KMLLDHKLNHB BNAOHCNEGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x657A120", Offset = "0x6578F20", VA = "0x18657A120", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x6579F30", Offset = "0x6578D30", VA = "0x186579F30", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event KMLLDHKLNHB HDECEFIHABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6578B40", Offset = "0x6577940", VA = "0x186578B40", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x657A1C0", Offset = "0x6578FC0", VA = "0x18657A1C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event NIMMIJKBCKC MHJPLIPDKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x6578F90", Offset = "0x6577D90", VA = "0x186578F90", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6579AC0", Offset = "0x65788C0", VA = "0x186579AC0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action HBJFOGNOFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x657A080", Offset = "0x6578E80", VA = "0x18657A080", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6578BE0", Offset = "0x65779E0", VA = "0x186578BE0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action HBCGELIPFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x6578CC0", Offset = "0x6577AC0", VA = "0x186578CC0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6578EF0", Offset = "0x6577CF0", VA = "0x186578EF0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<HOCOKNCJJJL> CPOBBINAGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x657A500", Offset = "0x6579300", VA = "0x18657A500", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x657A450", Offset = "0x6579250", VA = "0x18657A450", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<HOCOKNCJJJL> FGAAOJOGPMD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6579FD0", Offset = "0x6578DD0", VA = "0x186579FD0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x65797F0", Offset = "0x65785F0", VA = "0x1865797F0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action ENEHNMGDEFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6578D60", Offset = "0x6577B60", VA = "0x186578D60", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x657A3B0", Offset = "0x65791B0", VA = "0x18657A3B0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<HOCOKNCJJJL> MHJCEFODJMB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x6579C00", Offset = "0x6578A00", VA = "0x186579C00", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x657A300", Offset = "0x6579100", VA = "0x18657A300", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x657A820", Offset = "0x6579620", VA = "0x18657A820")]
	public EIGLKNOLOPN(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6579030", Offset = "0x6577E30", VA = "0x186579030", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x6579270", Offset = "0x6578070", VA = "0x186579270", Slot = "30")]
	public void FAJLKEPAOJL(HOCOKNCJJJL BLKPHAHLOKB, bool CBBCAJJMHGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x657A5B0", Offset = "0x65793B0", VA = "0x18657A5B0", Slot = "6")]
	public void POCNJHNIKOF(HOCOKNCJJJL HKFCBILJEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x6579CB0", Offset = "0x6578AB0", VA = "0x186579CB0", Slot = "7")]
	public void KOLBEIOPEGH(HOCOKNCJJJL HKFCBILJEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6578E00", Offset = "0x6577C00", VA = "0x186578E00", Slot = "4")]
	public void CFNLJBABIEO(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x657A260", Offset = "0x6579060", VA = "0x18657A260", Slot = "5")]
	public void NOFDGEJFFEB(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x6579B60", Offset = "0x6578960", VA = "0x186579B60")]
	private void HPNLIMDINDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x6578C80", Offset = "0x6577A80", VA = "0x186578C80")]
	private void BGLLEJONCHN(HOCOKNCJJJL HKFCBILJEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x65790D0", Offset = "0x6577ED0", VA = "0x1865790D0")]
	private void ELGCEPOBJBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x6579990", Offset = "0x6578790", VA = "0x186579990")]
	private void GNLDMELOJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x6578A10", Offset = "0x6577810", VA = "0x186578A10")]
	private void AOIJBEPAPOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x65798A0", Offset = "0x65786A0", VA = "0x1865798A0")]
	[CompilerGenerated]
	private object GFJECLFEMEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class IAAJNNACFMP
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x65849F0", Offset = "0x65837F0", VA = "0x1865849F0")]
	public static CLGMEOPHBKD BOFFHIIBNLO(this HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class FKFIICKCHFD : LPIHEECJOPL, GLIPCIFAGOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly HOIECNNMMJA PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AALKOAKIONG<HOCOKNCJJJL> GKOGAHLDGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool NBEMOBDEHAD;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public AALKOAKIONG<HOCOKNCJJJL> DPLLOKKEPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 JINBIHENJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x657B430", Offset = "0x657A230", VA = "0x18657B430", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 IJLCEKKMHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x657B150", Offset = "0x6579F50", VA = "0x18657B150", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 LPCHKJFNCCE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x657A8E0", Offset = "0x65796E0", VA = "0x18657A8E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public HOCOKNCJJJL BHPBCMLBECJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x657B380", Offset = "0x657A180", VA = "0x18657B380", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x657B460", Offset = "0x657A260", VA = "0x18657B460")]
	public FKFIICKCHFD(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x657B310", Offset = "0x657A110", VA = "0x18657B310", Slot = "8")]
	public void KCGMOLPFCCM(HOCOKNCJJJL GEFCENNBDFI, object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x657AD60", Offset = "0x6579B60", VA = "0x18657AD60", Slot = "9")]
	public void FIIKKBLHPHA(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x657ADC0", Offset = "0x6579BC0", VA = "0x18657ADC0")]
	private Vector3 GBBKPHHCHCP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x657A9D0", Offset = "0x65797D0", VA = "0x18657A9D0")]
	private void BODJAKABPGG(HOCOKNCJJJL EOINKKFALIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class GOMHLNDONGK
{
	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x657C420", Offset = "0x657B220", VA = "0x18657C420")]
	public static LPIHEECJOPL GEIECDDKJML(this HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class DHCOEMFKGBM : HANBEKHPMHE, BFNIHOELDII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HOIECNNMMJA PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OverridableVector3 HOBIHMABMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OverridableVector3 KNEHKMIGBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float GJCKFBFCEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float BHBLGLMNKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Vector3 PKBBLDNIPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Vector3? FKBADOLPHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Quaternion? IFEHNKOEBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool ECPPOBJGELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool AOKBDEGEIDN;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 EJCJCCCLDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x106A240", Offset = "0x1069040", VA = "0x18106A240", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x6574640", Offset = "0x6573440", VA = "0x186574640", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 DGAECMDABMD
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x6575D60", Offset = "0x6574B60", VA = "0x186575D60", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float FODEBPPKIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x1171A10", Offset = "0x1170810", VA = "0x181171A10", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x6575890", Offset = "0x6574690", VA = "0x186575890")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float JHADICINMEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xBA5BC0", Offset = "0xBA49C0", VA = "0x180BA5BC0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x65743E0", Offset = "0x65731E0", VA = "0x1865743E0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 OEIBPPHAACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x6575E60", Offset = "0x6574C60", VA = "0x186575E60", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion JHMBGDMNHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x65746F0", Offset = "0x65734F0", VA = "0x1865746F0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody IPBDLEBHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x656FDC0", Offset = "0x656EBC0", VA = "0x18656FDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event KMLLDHKLNHB MKEBNIGCJHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x6576D70", Offset = "0x6575B70", VA = "0x186576D70", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x65759A0", Offset = "0x65747A0", VA = "0x1865759A0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x6576E10", Offset = "0x6575C10", VA = "0x186576E10")]
	public DHCOEMFKGBM(HOCOKNCJJJL PEPBKPMNFNI, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x6574490", Offset = "0x6573290", VA = "0x186574490", Slot = "17")]
	public void AGGNEFHHFBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x6576240", Offset = "0x6575040", VA = "0x186576240", Slot = "16")]
	public void JICBDBPLDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6576160", Offset = "0x6574F60", VA = "0x186576160", Slot = "19")]
	public void IAODFPGOEMM(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x6576320", Offset = "0x6575120", VA = "0x186576320", Slot = "20")]
	public void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x6575FF0", Offset = "0x6574DF0", VA = "0x186575FF0", Slot = "18")]
	public void HOCMAMFFDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x65767E0", Offset = "0x65755E0", VA = "0x1865767E0", Slot = "21")]
	public void NHDCMNAHDKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x6574640", Offset = "0x6573440", VA = "0x186574640")]
	private void BCNMHHGEMIE(Vector3 MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x6576C80", Offset = "0x6575A80", VA = "0x186576C80")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 OJIBJBCFMEO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x6575890", Offset = "0x6574690", VA = "0x186575890")]
	private void NJAALGOGEDN(float MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x65743E0", Offset = "0x65731E0", VA = "0x1865743E0")]
	private void AFHIHHCCAHF(float MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6575A40", Offset = "0x6574840", VA = "0x186575A40")]
	private Vector3 DCLDAKGHPGG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x65765B0", Offset = "0x65753B0", VA = "0x1865765B0", Slot = "15")]
	public void MJELCFAAKJB((Quaternion rot, Vector3 moments) FBAOFMDOKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6575BE0", Offset = "0x65749E0", VA = "0x186575BE0")]
	private Quaternion HEPLKICINDI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x6574870", Offset = "0x6573670", VA = "0x186574870")]
	public void CEELNNDPECH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x6574940", Offset = "0x6573740", VA = "0x186574940", Slot = "4")]
	public (float, Vector3) CEELNNDPECH(Rigidbody OAFCIPMNNPA)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class MLKCJJACKKI
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x658E130", Offset = "0x658CF30", VA = "0x18658E130")]
	public static HANBEKHPMHE BIBCIIMEBPO(this HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class BBOABEAEFKJ : DIFIBOKOPFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly HOIECNNMMJA PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly NJMPJPAIPEI BEIILLLDHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly GDIMELFCBCC OFDNEFJDBAK;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool OPHBHNHFOED
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xCE02E0", Offset = "0xCDF0E0", VA = "0x180CE02E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public GDIMELFCBCC MCFEFCOMAJF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFC0", Offset = "0x8BDDC0", VA = "0x1808BEFC0", Slot = "11")]
		get
		{
			return default(GDIMELFCBCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x6570580", Offset = "0x656F380", VA = "0x186570580")]
	public BBOABEAEFKJ(HOCOKNCJJJL PEPBKPMNFNI, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x6570250", Offset = "0x656F050", VA = "0x186570250", Slot = "4")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x65704E0", Offset = "0x656F2E0", VA = "0x1865704E0")]
	private bool PEJOGAPIGNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x65704B0", Offset = "0x656F2B0", VA = "0x1865704B0", Slot = "5")]
	public void MFPLLCNOCAO(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x6570480", Offset = "0x656F280", VA = "0x186570480", Slot = "6")]
	public void LNGAPJGKAGE(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x656FF60", Offset = "0x656ED60", VA = "0x18656FF60", Slot = "9")]
	public void BHJCIECCICC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x6570360", Offset = "0x656F160", VA = "0x186570360")]
	private void LLHDHGAEHPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x65700E0", Offset = "0x656EEE0", VA = "0x1865700E0")]
	private void IADOGNODBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x6570320", Offset = "0x656F120", VA = "0x186570320", Slot = "8")]
	public void KGLMAHJBOML(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x65700A0", Offset = "0x656EEA0", VA = "0x1865700A0", Slot = "7")]
	public void HCJFFMGGMPO(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class NOKJGHMFLCG : BKOKPDEKNJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly HOIECNNMMJA PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly NJMPJPAIPEI FDPPHOLLOMJ;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool OEPGKIKIHMG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x658FFF0", Offset = "0x658EDF0", VA = "0x18658FFF0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event KMLLDHKLNHB BAHMJIMEKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x6590240", Offset = "0x658F040", VA = "0x186590240", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x6590130", Offset = "0x658EF30", VA = "0x186590130", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x65903F0", Offset = "0x658F1F0", VA = "0x1865903F0")]
	public NOKJGHMFLCG(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x658FF80", Offset = "0x658ED80", VA = "0x18658FF80", Slot = "11")]
	public IDisposable EGFHGEBFABK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6590120", Offset = "0x658EF20", VA = "0x186590120", Slot = "8")]
	public void IENDNCEOIPO(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x658FF70", Offset = "0x658ED70", VA = "0x18658FF70", Slot = "9")]
	public void CKANGJMMAHK(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x65902E0", Offset = "0x658F0E0", VA = "0x1865902E0", Slot = "10")]
	public void PMFJDBOLJIN(object CGFEMNMBCOK, bool CBBINBGOOHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x6590200", Offset = "0x658F000", VA = "0x186590200", Slot = "6")]
	public void MBDDBOMIPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x65900A0", Offset = "0x658EEA0", VA = "0x1865900A0", Slot = "12")]
	public void IAODFPGOEMM(Rigidbody BPHKIOCOHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x65901D0", Offset = "0x658EFD0", VA = "0x1865901D0", Slot = "13")]
	public void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class ODECFJLIHKE : PMEGKAHEOGD, KOAIPOCHCAG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly HOIECNNMMJA PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private PhotonView DNCAKFJJANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool OLMEKNAODPA;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PhotonView CPGMFIBABKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool ABNELKLFCHC
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x657BAA0", Offset = "0x657A8A0", VA = "0x18657BAA0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool JFIHIEOEGDH
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x87DEA0", Offset = "0x87CCA0", VA = "0x18087DEA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event KMLLDHKLNHB DKFDPEBGMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x65908B0", Offset = "0x658F6B0", VA = "0x1865908B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x6590D60", Offset = "0x658FB60", VA = "0x186590D60", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x6591070", Offset = "0x658FE70", VA = "0x186591070")]
	public ODECFJLIHKE(HOCOKNCJJJL PEPBKPMNFNI, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x6590C30", Offset = "0x658FA30", VA = "0x186590C30", Slot = "9")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x65907B0", Offset = "0x658F5B0", VA = "0x1865907B0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x65904E0", Offset = "0x658F2E0", VA = "0x1865904E0", Slot = "10")]
	public void AADLCAECLDP(HOCOKNCJJJL GEFCENNBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x6590AC0", Offset = "0x658F8C0", VA = "0x186590AC0", Slot = "11")]
	public void JHCPEHGGFOG(HOCOKNCJJJL GEFCENNBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x6590950", Offset = "0x658F750", VA = "0x186590950")]
	private void JEEICFENNDC(PhotonView GLOHIMKEIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x6590650", Offset = "0x658F450", VA = "0x186590650")]
	private void DDHOIDLDDMM(RigidbodyEx OOHELMNJMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x6590E00", Offset = "0x658FC00", VA = "0x186590E00")]
	private void OFPEFMEHGMI(PhotonView NNOJJJIGEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class NMPGFFHBAKI
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x658FEB0", Offset = "0x658ECB0", VA = "0x18658FEB0")]
	public static PMEGKAHEOGD FKKIGIGEEGG(this HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class NFLBJHIFKNG : DLBLGAFPKNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly HOIECNNMMJA PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private RigidbodyConstraints OAINGMHFFCF;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool FDFHHODHCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xAF5690", Offset = "0xAF4490", VA = "0x180AF5690", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7A70", Offset = "0x3DD6870", VA = "0x183DD7A70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool ANLLEHIJIFP
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1B09E30", Offset = "0x1B08C30", VA = "0x181B09E30", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3DD7A80", Offset = "0x3DD6880", VA = "0x183DD7A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public RigidbodyConstraints HKHPMHDBMED
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x7944A0", Offset = "0x7932A0", VA = "0x1807944A0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x658E4C0", Offset = "0x658D2C0", VA = "0x18658E4C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x658E650", Offset = "0x658D450", VA = "0x18658E650")]
	public NFLBJHIFKNG(HOCOKNCJJJL PEPBKPMNFNI, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x658E5F0", Offset = "0x658D3F0", VA = "0x18658E5F0", Slot = "9")]
	public void IAODFPGOEMM(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x658E620", Offset = "0x658D420", VA = "0x18658E620", Slot = "10")]
	public void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class NCONDKGJJOB : JEAMKLFGBLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly HOCOKNCJJJL PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float CEPBIIEHIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float NBEEAPGALPG;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float GEJLHPDFKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x89F230", Offset = "0x89E030", VA = "0x18089F230", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x658E3B0", Offset = "0x658D1B0", VA = "0x18658E3B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float JJDGBGJFOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x9674F0", Offset = "0x9662F0", VA = "0x1809674F0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x658E2E0", Offset = "0x658D0E0", VA = "0x18658E2E0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x658E480", Offset = "0x658D280", VA = "0x18658E480")]
	public NCONDKGJJOB(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x658E1F0", Offset = "0x658CFF0", VA = "0x18658E1F0", Slot = "8")]
	public void IAODFPGOEMM(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x658E240", Offset = "0x658D040", VA = "0x18658E240", Slot = "9")]
	public void JPMMCBCKMEB(Rigidbody JFJBDLHDNAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class AIHNKKBLABO : KKCCCEBIOOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly HOIECNNMMJA PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool CKPEOCCIIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool EALFEMKLAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int ECOIEDEBLJK;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody IPBDLEBHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x656FDC0", Offset = "0x656EBC0", VA = "0x18656FDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool GEFECGMFJOK
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x656FE10", Offset = "0x656EC10", VA = "0x18656FE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private HOCOKNCJJJL KKHLELLCELL
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x656FD60", Offset = "0x656EB60", VA = "0x18656FD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool OMKJPAHHFCA
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x656FCB0", Offset = "0x656EAB0", VA = "0x18656FCB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event KMLLDHKLNHB FPHBHNGLHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x656FC10", Offset = "0x656EA10", VA = "0x18656FC10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x656FE30", Offset = "0x656EC30", VA = "0x18656FE30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x656FED0", Offset = "0x656ECD0", VA = "0x18656FED0")]
	public AIHNKKBLABO(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x656FB80", Offset = "0x656E980", VA = "0x18656FB80", Slot = "6")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x656F5B0", Offset = "0x656E3B0", VA = "0x18656F5B0", Slot = "8")]
	public void DNEFDHENJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x656F460", Offset = "0x656E260", VA = "0x18656F460", Slot = "7")]
	public bool DDEBGNLPGNM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x656FAE0", Offset = "0x656E8E0", VA = "0x18656FAE0", Slot = "9")]
	public void IFFAGOPFNMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x656F3C0", Offset = "0x656E1C0", VA = "0x18656F3C0", Slot = "11")]
	public void AFHIICHEDNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x656FD10", Offset = "0x656EB10", VA = "0x18656FD10", Slot = "12")]
	public void JNKCDBMJHEO(bool JNJHHJMDGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x656F750", Offset = "0x656E550", VA = "0x18656F750", Slot = "10")]
	public void HELPDJDAKNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x656F900", Offset = "0x656E700", VA = "0x18656F900")]
	private bool IBHMMCJCLPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x656F5C0", Offset = "0x656E3C0", VA = "0x18656F5C0")]
	private void EKNIOINKFNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class DBFLGOHIHHE : BGIBMNHFFAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly HOIECNNMMJA PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly NJMPJPAIPEI GBIHJKHAPLB;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Rigidbody IPBDLEBHNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x7919F0", Offset = "0x7907F0", VA = "0x1807919F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool OMKJPAHHFCA
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x656EA50", Offset = "0x656D850", VA = "0x18656EA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool LKKCLGOAFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xCE02E0", Offset = "0xCDF0E0", VA = "0x180CE02E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x65742D0", Offset = "0x65730D0", VA = "0x1865742D0")]
	public DBFLGOHIHHE(HOCOKNCJJJL PEPBKPMNFNI, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x6573BA0", Offset = "0x65729A0", VA = "0x186573BA0", Slot = "5")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x65740F0", Offset = "0x6572EF0", VA = "0x1865740F0", Slot = "7")]
	public void NHKMCHHACHL(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x6573340", Offset = "0x6572140", VA = "0x186573340", Slot = "8")]
	public void CBGIICEIMPH(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x6573C40", Offset = "0x6572A40", VA = "0x186573C40", Slot = "9")]
	public void KJPDNIGCMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x6573370", Offset = "0x6572170", VA = "0x186573370", Slot = "11")]
	public void GFFIHBECMAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x6573F70", Offset = "0x6572D70", VA = "0x186573F70", Slot = "12")]
	public void KLBAHEAFICN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x6573560", Offset = "0x6572360", VA = "0x186573560", Slot = "10")]
	public void HOJBJFGFKBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x65739F0", Offset = "0x65727F0", VA = "0x1865739F0")]
	private void IPFCGIBFJMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x6574120", Offset = "0x6572F20", VA = "0x186574120")]
	private void ODEJKLGJCLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class JFNMDJPOBKA : PODEFIECECN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly HOIECNNMMJA PEPBKPMNFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly NJMPJPAIPEI HOFBFDBIIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float MEDEIFJCMFA;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public MGCEECGEKMF LPFAHBIJNHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x78E2A0", Offset = "0x78D0A0", VA = "0x18078E2A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x795720", Offset = "0x794520", VA = "0x180795720", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public HPAJGICJEFB MGKENKKHODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x78E270", Offset = "0x78D070", VA = "0x18078E270", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7944B0", Offset = "0x7932B0", VA = "0x1807944B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 LPCHKJFNCCE
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6599450", Offset = "0x6598250", VA = "0x186599450", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6599570", Offset = "0x6598370", VA = "0x186599570", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 NIKNGCBKBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x659AC90", Offset = "0x6599A90", VA = "0x18659AC90", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x659AA00", Offset = "0x6599800", VA = "0x18659AA00", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 CLDGKCKHKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x659A300", Offset = "0x6599100", VA = "0x18659A300", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x659B840", Offset = "0x659A640", VA = "0x18659B840", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 GAKADIGGDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x6599DC0", Offset = "0x6598BC0", VA = "0x186599DC0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x6599630", Offset = "0x6598430", VA = "0x186599630", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float JPIKGPBAPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7E3840", Offset = "0x7E2640", VA = "0x1807E3840", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x659AA30", Offset = "0x6599830", VA = "0x18659AA30", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool HGIFPNBCLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x1669B40", Offset = "0x1668940", VA = "0x181669B40", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private KJJOBHEGCDH LPPAPCHCKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1E626F0", Offset = "0x1E614F0", VA = "0x181E626F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool GEFECGMFJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x657D630", Offset = "0x657C430", VA = "0x18657D630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x659BCD0", Offset = "0x659AAD0", VA = "0x18659BCD0")]
	public JFNMDJPOBKA(HOCOKNCJJJL PEPBKPMNFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x659AD80", Offset = "0x6599B80", VA = "0x18659AD80", Slot = "19")]
	public void JLCDGKOMKPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x6599C90", Offset = "0x6598A90", VA = "0x186599C90", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x659AAE0", Offset = "0x65998E0", VA = "0x18659AAE0", Slot = "28")]
	public void IAODFPGOEMM(Rigidbody JFJBDLHDNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xB22840", Offset = "0xB21640", VA = "0x180B22840", Slot = "20")]
	public void ECOKLILBDKM(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0xB21110", Offset = "0xB1FF10", VA = "0x180B21110", Slot = "30")]
	public void GMIMDDMODFH(object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x65992E0", Offset = "0x65980E0", VA = "0x1865992E0", Slot = "35")]
	public Vector3 BJPPEMCNCNB(Vector3 GIDEDHBNIIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x659AFA0", Offset = "0x6599DA0", VA = "0x18659AFA0", Slot = "34")]
	public Vector3 KICPKKDLGLB(Vector3 ELAAHADLBAJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x659AD80", Offset = "0x6599B80", VA = "0x18659AD80", Slot = "27")]
	public void OFNJJILONJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x659BC70", Offset = "0x659AA70", VA = "0x18659BC70", Slot = "25")]
	public void PMEMAPAJFNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x659B380", Offset = "0x659A180", VA = "0x18659B380", Slot = "24")]
	public void KPOOFCIGNPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x659A420", Offset = "0x6599220", VA = "0x18659A420", Slot = "33")]
	public void GBNPJKONKNI(Vector3 ICMDGAJHNJH, Vector3 NLEHEKMGGMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6599D60", Offset = "0x6598B60", VA = "0x186599D60", Slot = "32")]
	public void EBCPJPAPBLD(Vector3 LEGBBGNFGAH, Vector3 AENMCPJCABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x6598CE0", Offset = "0x6597AE0", VA = "0x186598CE0", Slot = "31")]
	public void AJEKGCONBHI(Vector3 NNEEBDCMMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6599660", Offset = "0x6598460", VA = "0x186599660", Slot = "22")]
	public void DPPEIIHAENP(AHJEMOLEOCF DOMBBBCLFNH, Vector3 JDPPPDLIMNC, float FGMPHFJDLNP, float NHIPDPPCCON = 8f, float JLAKPJONIJI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x659B9E0", Offset = "0x659A7E0", VA = "0x18659B9E0", Slot = "21")]
	public void OFMPPFIBNAG(BLKDNNDGCAM NOLEAKKDJBJ, Vector3 CADBLKCNADJ, float FLNLIBPIIPJ = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x6599EB0", Offset = "0x6598CB0", VA = "0x186599EB0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ELHBGOAJOGC(BLKDNNDGCAM NOLEAKKDJBJ, Vector3 NJBEEEBFFMP, float GEICNPCCJJP = 7f, float HAIPIONFKGO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x659B0F0", Offset = "0x6599EF0", VA = "0x18659B0F0", Slot = "29")]
	public Vector3 KJGPOOAELFJ(Vector3 IBOAKNMBPHJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x659B250", Offset = "0x659A050", VA = "0x18659B250", Slot = "26")]
	public void KMHMNKCAIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x659AA30", Offset = "0x6599830", VA = "0x18659AA30")]
	private void HNFMHNDFKDF(float MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x659AE30", Offset = "0x6599C30", VA = "0x18659AE30")]
	private void KEFGNCKFJJL(Vector3 CADBLKCNADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x659B900", Offset = "0x659A700", VA = "0x18659B900")]
	private Vector3 NOKJLBMDJJP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x659B3E0", Offset = "0x659A1E0", VA = "0x18659B3E0")]
	private void MJKDCGNFPAC(Vector3 ELAAHADLBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x659ABB0", Offset = "0x65999B0", VA = "0x18659ABB0")]
	private Vector3 JEGPOCGLFKJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x659A5C0", Offset = "0x65993C0", VA = "0x18659A5C0")]
	private void GLKGKHDHCBK(Vector3 MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x6598E50", Offset = "0x6597C50", VA = "0x186598E50")]
	private void BCABKNJEBMO(Vector3 ELAAHADLBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x659A250", Offset = "0x6599050", VA = "0x18659A250")]
	private void FJEDPDNKEBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class OJBDKFECNPE : AFIHALNIHNG
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x659C370", Offset = "0x659B170", VA = "0x18659C370", Slot = "4")]
	public CKLGIFHIGHO OKFBKNPKKJO(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x659BE30", Offset = "0x659AC30", VA = "0x18659BE30", Slot = "5")]
	public PODEFIECECN DIJHOGKFJKM(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x659BFE0", Offset = "0x659ADE0", VA = "0x18659BFE0", Slot = "6")]
	public GLIPCIFAGOC GDJPHBPKHNJ(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x659C430", Offset = "0x659B230", VA = "0x18659C430", Slot = "7")]
	public JEAMKLFGBLG PGCAICLJJGM(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x659BD70", Offset = "0x659AB70", VA = "0x18659BD70", Slot = "8")]
	public KKCCCEBIOOC ALKBCLEDBPK(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x659C180", Offset = "0x659AF80", VA = "0x18659C180", Slot = "9")]
	public NEONIKIGNOM ILMBMNHMFAG(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x659C0B0", Offset = "0x659AEB0", VA = "0x18659C0B0", Slot = "10")]
	public BKOKPDEKNJH IDLHODBOGHG(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x659BF80", Offset = "0x659AD80", VA = "0x18659BF80", Slot = "11")]
	public KJJOBHEGCDH EOMIFOEKPNK(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x659BDD0", Offset = "0x659ABD0", VA = "0x18659BDD0", Slot = "12")]
	public KAANPNMIOAE BMPPGEDLLOD(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x659C3D0", Offset = "0x659B1D0", VA = "0x18659C3D0", Slot = "13")]
	public CPMGGCMJEFL PBPMEFGGJCN(HOCOKNCJJJL OGNMHOKFLGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x659C290", Offset = "0x659B090", VA = "0x18659C290")]
	public BGIBMNHFFAL OJMFJOJGMAK(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x659C300", Offset = "0x659B100", VA = "0x18659C300")]
	public KOAIPOCHCAG OBJFBIMFFOJ(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x659BF10", Offset = "0x659AD10", VA = "0x18659BF10")]
	public DIFIBOKOPFH EBDPONLMGFC(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x659C040", Offset = "0x659AE40", VA = "0x18659C040")]
	public BFNIHOELDII JNILOGAKBGP(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x659C110", Offset = "0x659AF10", VA = "0x18659C110")]
	public DLBLGAFPKNL IKOHNJJNLIG(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x659C1E0", Offset = "0x659AFE0", VA = "0x18659C1E0", Slot = "19")]
	public HOCOKNCJJJL JNIPPDNMLOE(RigidbodyEx PEPBKPMNFNI, FIBIHOCDGLH HKPHNGEBIED, KIHGMKIMLMB OMCPJFGHGNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public OJBDKFECNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x659C290", Offset = "0x659B090", VA = "0x18659C290", Slot = "14")]
	private BGIBMNHFFAL MLHEILBJOJF(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x659C300", Offset = "0x659B100", VA = "0x18659C300", Slot = "15")]
	private KOAIPOCHCAG NDGNBJCIPCK(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x659BF10", Offset = "0x659AD10", VA = "0x18659BF10", Slot = "16")]
	private DIFIBOKOPFH KFOKNDKJEMN(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x659C040", Offset = "0x659AE40", VA = "0x18659C040", Slot = "17")]
	private BFNIHOELDII HKFFIEFLGAN(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x659C110", Offset = "0x659AF10", VA = "0x18659C110", Slot = "18")]
	private DLBLGAFPKNL MHHEDGELOOO(HOCOKNCJJJL OGNMHOKFLGN, [In] FIBIHOCDGLH HKPHNGEBIED)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : GCOJLFMNBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x659C490", Offset = "0x659B290", VA = "0x18659C490", Slot = "6")]
		public sealed override void FJKDFPHMFOG(FIHGIMENDOE EAGOMMNFHFH)
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
