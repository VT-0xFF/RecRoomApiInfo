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
public delegate void PLMJOJGAJFH(RigidbodyEx HKPJGJGAHGD);
[Cpp2IlInjected.Token(Token = "0x2000003")]
public delegate void BAMKPCIEPMF(RigidbodyEx HKPJGJGAHGD, bool OOJFFOBBJFE = false);
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DHPGLPGANNB
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
public enum LADBPODPGPP
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum GLAMMEJCNLN
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[KHBNPKNGIHN(typeof(CEIPOJNOHHH), new string[] { "Ignore", "Mock" })]
public class HNLCKBGMDFK : CEIPOJNOHHH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MEIEJLAKHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7E0510", Offset = "0x7DEF10", VA = "0x1807E0510", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
	public void HMBIHCMKOEC(string BNFACNGELAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "6")]
	public void AJNMJJHKDOH(RigidbodyEx AJJNHIINFFP, Action GMHPLHJININ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78DC20", VA = "0x18078F220", Slot = "7")]
	public MLODEPOBAIH FIIBHKDEGBJ(int ANACFCDIDEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "8")]
	public void KLJOLGAGHIJ(Vector3 EPLNOJDLOPL, float CCNIKCCCDOB, Color GJNHDHNOICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public HNLCKBGMDFK()
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
		private static readonly EACOFNPIGGG HPMNJKNOKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private bool JCCIOFIAHLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private KILHMEMGMIO GPBFBAGNPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		[HAPNNLGHBBJ(EEBNILOIPCE.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[HAPNNLGHBBJ(EEBNILOIPCE.SelfAndParent, true, false, false)]
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
		private LADBPODPGPP physicsInterpolation;

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
		internal KILHMEMGMIO DLPENDOGCEG
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6592620", Offset = "0x6591020", VA = "0x186592620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> PHBLENHDKPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x78FC80", Offset = "0x78E680", VA = "0x18078FC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x78FCF0", Offset = "0x78E6F0", VA = "0x18078FCF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx DDNONGPOAJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x65946D0", Offset = "0x65930D0", VA = "0x1865946D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx DABPAFAJNAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6594630", Offset = "0x6593030", VA = "0x186594630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx CDMOGOKIPKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x65952F0", Offset = "0x6593CF0", VA = "0x1865952F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6596870", Offset = "0x6595270", VA = "0x186596870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform GPFKAHJFLJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7B8FB0", Offset = "0x7B79B0", VA = "0x1807B8FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform GIKHDPPMBOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7B8FB0", Offset = "0x7B79B0", VA = "0x1807B8FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public CKAPAPIDKKF DDEFJFBDGJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x65943F0", Offset = "0x6592DF0", VA = "0x1865943F0")]
			get
			{
				return default(CKAPAPIDKKF);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6596020", Offset = "0x6594A20", VA = "0x186596020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DMAKBKCDAJB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6594980", Offset = "0x6593380", VA = "0x186594980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FBALNADLPCO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6594510", Offset = "0x6592F10", VA = "0x186594510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IBFPFLLNHAF JADAAPBCGHM
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x65948C0", Offset = "0x65932C0", VA = "0x1865948C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x65961E0", Offset = "0x6594BE0", VA = "0x1865961E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public OGEJCJLEECF JDNHLOMLHBB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6594860", Offset = "0x6593260", VA = "0x186594860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6596170", Offset = "0x6594B70", VA = "0x186596170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool PAGMMGPHAJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x65947B0", Offset = "0x65931B0", VA = "0x1865947B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody AJEBBECNDIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6594810", Offset = "0x6593210", VA = "0x186594810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HFLMAHEOICL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6594570", Offset = "0x6592F70", VA = "0x186594570")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6596090", Offset = "0x6594A90", VA = "0x186596090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool LCPPPIFHKII
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5D66BD0", Offset = "0x5D655D0", VA = "0x185D66BD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5D660A0", Offset = "0x5D64AA0", VA = "0x185D660A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ILAFIEOKEON
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6595290", Offset = "0x6593C90", VA = "0x186595290")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float AKKPMFIOHPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6595230", Offset = "0x6593C30", VA = "0x186595230")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6596800", Offset = "0x6595200", VA = "0x186596800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float FDEPLLIFNMD
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6594BE0", Offset = "0x65935E0", VA = "0x186594BE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6596480", Offset = "0x6594E80", VA = "0x186596480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float KHENEOLNGLG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x65949E0", Offset = "0x65933E0", VA = "0x1865949E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6596250", Offset = "0x6594C50", VA = "0x186596250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool OJHFADHHFGG
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6595850", Offset = "0x6594250", VA = "0x186595850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6596DD0", Offset = "0x65957D0", VA = "0x186596DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 BCKLOGPKMGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6595010", Offset = "0x6593A10", VA = "0x186595010")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x65965D0", Offset = "0x6594FD0", VA = "0x1865965D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 EPLNOJDLOPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6595990", Offset = "0x6594390", VA = "0x186595990")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode OHMGBGCKCAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6594B20", Offset = "0x6593520", VA = "0x186594B20")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x65963A0", Offset = "0x6594DA0", VA = "0x1865963A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float LMOJAOMGEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x65945D0", Offset = "0x6592FD0", VA = "0x1865945D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6596100", Offset = "0x6594B00", VA = "0x186596100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints IGMMJGKAHGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6594B80", Offset = "0x6593580", VA = "0x186594B80")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6596410", Offset = "0x6594E10", VA = "0x186596410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 FHKFLINMCBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6595390", Offset = "0x6593D90", VA = "0x186595390")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 PONHBPHPBFE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6595390", Offset = "0x6593D90", VA = "0x186595390")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6596BB0", Offset = "0x65955B0", VA = "0x186596BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float HKAHBEBLFID
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x65950F0", Offset = "0x6593AF0", VA = "0x1865950F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x65966B0", Offset = "0x65950B0", VA = "0x1865966B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float PHELDOAPPAP
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x65957F0", Offset = "0x65941F0", VA = "0x1865957F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6596D60", Offset = "0x6595760", VA = "0x186596D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion ILIEMKNJKAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6595470", Offset = "0x6593E70", VA = "0x186595470")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6596930", Offset = "0x6595330", VA = "0x186596930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion NBNHHGOKGHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6595710", Offset = "0x6594110", VA = "0x186595710")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6596C90", Offset = "0x6595690", VA = "0x186596C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 HLJJJHJKOCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6595550", Offset = "0x6593F50", VA = "0x186595550")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6596A00", Offset = "0x6595400", VA = "0x186596A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion OPAHIHGMKDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6595630", Offset = "0x6594030", VA = "0x186595630")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6596AE0", Offset = "0x65954E0", VA = "0x186596AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 FEGCMBDOBNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x65958B0", Offset = "0x65942B0", VA = "0x1865958B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6596E40", Offset = "0x6595840", VA = "0x186596E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 BFFOOLAMBIB
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6595150", Offset = "0x6593B50", VA = "0x186595150")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6596720", Offset = "0x6595120", VA = "0x186596720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 PABPMGJGOIN
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6594A40", Offset = "0x6593440", VA = "0x186594A40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x65962C0", Offset = "0x6594CC0", VA = "0x1865962C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 OMNPLMFLMGI
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6594F30", Offset = "0x6593930", VA = "0x186594F30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x65964F0", Offset = "0x6594EF0", VA = "0x1865964F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 KCGNANNGOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6594DF0", Offset = "0x65937F0", VA = "0x186594DF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion KKCCJIEMMHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6594D10", Offset = "0x6593710", VA = "0x186594D10")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 GPHDGNCKAJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6595B50", Offset = "0x6594550", VA = "0x186595B50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 JLLOPAEABOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6595A70", Offset = "0x6594470", VA = "0x186595A70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool KNEFJOKKMJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6594ED0", Offset = "0x65938D0", VA = "0x186594ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool KMBJANENHOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6594920", Offset = "0x6593320", VA = "0x186594920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool CLICEMHHOLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x65944B0", Offset = "0x6592EB0", VA = "0x1865944B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool ENJLCAOLEEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6594450", Offset = "0x6592E50", VA = "0x186594450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool DJBPKHLCKPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6594390", Offset = "0x6592D90", VA = "0x186594390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool NFLMNIIHFPB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6594C40", Offset = "0x6593640", VA = "0x186594C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool NDGHBLBODDG
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x511D730", Offset = "0x511C130", VA = "0x18511D730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PLMJOJGAJFH OCKDHBPDGGO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x65942B0", Offset = "0x6592CB0", VA = "0x1865942B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6595F40", Offset = "0x6594940", VA = "0x186595F40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event BAMKPCIEPMF MICEAPFEGIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6594240", Offset = "0x6592C40", VA = "0x186594240")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6595ED0", Offset = "0x65948D0", VA = "0x186595ED0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event PLMJOJGAJFH BOEHDHLHDOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6593FA0", Offset = "0x65929A0", VA = "0x186593FA0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6595C30", Offset = "0x6594630", VA = "0x186595C30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event PLMJOJGAJFH OAMBIPLMBPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6594010", Offset = "0x6592A10", VA = "0x186594010")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6595CA0", Offset = "0x65946A0", VA = "0x186595CA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event PLMJOJGAJFH EJHBHIPPJKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6594160", Offset = "0x6592B60", VA = "0x186594160")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6595DF0", Offset = "0x65947F0", VA = "0x186595DF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<CPDDDNECHFB, CPDDDNECHFB> OHGEEJKEHNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x65940F0", Offset = "0x6592AF0", VA = "0x1865940F0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6595D80", Offset = "0x6594780", VA = "0x186595D80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event PLMJOJGAJFH BMGOJJOKLPN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x65941D0", Offset = "0x6592BD0", VA = "0x1865941D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6595E60", Offset = "0x6594860", VA = "0x186595E60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event PLMJOJGAJFH LAMAAFNIAAF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6594320", Offset = "0x6592D20", VA = "0x186594320")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6595FB0", Offset = "0x65949B0", VA = "0x186595FB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event PLMJOJGAJFH KBAFEACEFMN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6594080", Offset = "0x6592A80", VA = "0x186594080")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6595D10", Offset = "0x6594710", VA = "0x186595D10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x790CA0", Offset = "0x78F6A0", VA = "0x180790CA0")]
		internal void BJLABENAHLA(KILHMEMGMIO DPFABJBBFIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6593070", Offset = "0x6591A70", VA = "0x186593070")]
		internal void PBIFMMNBPOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6593CC0", Offset = "0x65926C0", VA = "0x186593CC0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody LBNMHALADMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6593990", Offset = "0x6592390", VA = "0x186593990")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) LGMCEMMFMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x65923D0", Offset = "0x6590DD0", VA = "0x1865923D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6592620", Offset = "0x6591020", VA = "0x186592620")]
		private KILHMEMGMIO NNLNDMMPMBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6592B70", Offset = "0x6591570", VA = "0x186592B70")]
		private void KKNCHBJCPHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6593160", Offset = "0x6591B60", VA = "0x186593160")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6593070", Offset = "0x6591A70", VA = "0x186593070")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6593100", Offset = "0x6591B00", VA = "0x186593100")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x65931C0", Offset = "0x6591BC0", VA = "0x1865931C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6591A80", Offset = "0x6590480", VA = "0x186591A80")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object BDAPLOBBPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6593220", Offset = "0x6591C20", VA = "0x186593220")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object BDAPLOBBPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x65926D0", Offset = "0x65910D0", VA = "0x1865926D0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6593010", Offset = "0x6591A10", VA = "0x186593010")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6593AF0", Offset = "0x65924F0", VA = "0x186593AF0")]
		public void SetParent(RigidbodyEx BEEGCHJLJFC, bool OOJFFOBBJFE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6593530", Offset = "0x6591F30", VA = "0x186593530")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6592950", Offset = "0x6591350", VA = "0x186592950")]
		public bool IsRigidbodyAncestor(RigidbodyEx DPFKLEKNGDL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6592A30", Offset = "0x6591430", VA = "0x186592A30")]
		public bool IsRigidbodyDescendant(RigidbodyEx ICMAKOMHGEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6591CF0", Offset = "0x65906F0", VA = "0x186591CF0")]
		public void AddInterpolationRestriction(object BDAPLOBBPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6593290", Offset = "0x6591C90", VA = "0x186593290")]
		public void RemoveInterpolationRestriction(object BDAPLOBBPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6592440", Offset = "0x6590E40", VA = "0x186592440")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6591D60", Offset = "0x6590760", VA = "0x186591D60")]
		public void AddKinematic(object BDAPLOBBPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6593300", Offset = "0x6591D00", VA = "0x186593300")]
		public void RemoveKinematic(object BDAPLOBBPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6593A70", Offset = "0x6592470", VA = "0x186593A70")]
		public void SetKinematic(object BDAPLOBBPIE, bool IMCAGEPDHDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6593890", Offset = "0x6592290", VA = "0x186593890")]
		public void SetDiscontinuousPositionAndRotation(Vector3 DFMMIOGMKKL, Quaternion HHDMDNNPAEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6593790", Offset = "0x6592190", VA = "0x186593790")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 EBKILOPCAFO, Quaternion LAPNFLAIMAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6592840", Offset = "0x6591240", VA = "0x186592840")]
		public Vector3 GetConstrainedVelocity(Vector3 FEGCMBDOBNF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6592730", Offset = "0x6591130", VA = "0x186592730")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 PABPMGJGOIN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6591C00", Offset = "0x6590600", VA = "0x186591C00")]
		public void AddForce(Vector3 JAAMGDODLLF, ForceMode AEJDMFGIJOM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6591AF0", Offset = "0x65904F0", VA = "0x186591AF0")]
		public void AddForceAtPosition(Vector3 JAAMGDODLLF, Vector3 CJONGNPPIAD, ForceMode AEJDMFGIJOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6591F30", Offset = "0x6590930", VA = "0x186591F30")]
		public void AddTorque(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6591DD0", Offset = "0x65907D0", VA = "0x186591DD0")]
		public void AddRelativeTorque(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6593D90", Offset = "0x6592790", VA = "0x186593D90")]
		public Vector3 WorldToLocalVelocity(Vector3 EGEFCPMFFFJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6592F00", Offset = "0x6591900", VA = "0x186592F00")]
		public Vector3 LocalToWorldVelocity(Vector3 BFFOOLAMBIB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x65925C0", Offset = "0x6590FC0", VA = "0x1865925C0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6592560", Offset = "0x6590F60", VA = "0x186592560")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6592500", Offset = "0x6590F00", VA = "0x186592500")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x65924A0", Offset = "0x6590EA0", VA = "0x1865924A0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6593690", Offset = "0x6592090", VA = "0x186593690")]
		public void ResetVelocityWorldSpace(Vector3 MBDDFANMDHG, Vector3 JDOCNMMEPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6593590", Offset = "0x6591F90", VA = "0x186593590")]
		public void ResetVelocityLocalSpace(Vector3 JEAPEJGJLMF, Vector3 OMNPLMFLMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6593450", Offset = "0x6591E50", VA = "0x186593450")]
		public void ResetLinearVelocityLocalSpace(Vector3 JEAPEJGJLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6593C20", Offset = "0x6592620", VA = "0x186593C20")]
		public bool SweepTest(Vector3 NEGLEJJNHEL, [Out] RaycastHit AFJMBFCIKFN, float ECIJIDKCAEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6592B10", Offset = "0x6591510", VA = "0x186592B10")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6593BC0", Offset = "0x65925C0", VA = "0x186593BC0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6593D30", Offset = "0x6592730", VA = "0x186593D30")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6591EC0", Offset = "0x65908C0", VA = "0x186591EC0")]
		public void AddShouldHaveUnityRigidbodyToken(object BDAPLOBBPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6593370", Offset = "0x6591D70", VA = "0x186593370")]
		public void RemoveShouldHaveUnityRigidbodyToken(object BDAPLOBBPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6592260", Offset = "0x6590C60", VA = "0x186592260")]
		public void ApplyForceVelocityChange(DHPGLPGANNB EPKOBECIBEK, Vector3 KJIJGBOHKPF, float MKKHJDIICOM, float DGABKEGNMEH = 8f, float OFFAEJLJJAN = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x65921C0", Offset = "0x6590BC0", VA = "0x1865921C0")]
		public void ApplyAngularVelocityChange(GLAMMEJCNLN NHEGDAIEAAI, Vector3 IIILLOOECBD, float ODLNACAFJEE = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6592320", Offset = "0x6590D20", VA = "0x186592320")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(GLAMMEJCNLN NHEGDAIEAAI, Vector3 KPKKBKKOGOG, float IPEEDIDLNPN = 7f, float BFKJOMIGDBJ = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x65920F0", Offset = "0x6590AF0", VA = "0x1865920F0")]
		public bool AllowedScaleChange(float LNNEBGNNLBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6592020", Offset = "0x6590A20", VA = "0x186592020")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx PJFKHGGFLEG, object BDAPLOBBPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x65933E0", Offset = "0x6591DE0", VA = "0x1865933E0")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object BDAPLOBBPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6593F30", Offset = "0x6592930", VA = "0x186593F30")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class EBCGIDIOJHF
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6572A60", Offset = "0x6571460", VA = "0x186572A60")]
	public static KILHMEMGMIO DLPENDOGCEG(this RigidbodyEx AJJNHIINFFP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PABNOLNKAEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody PJMDPLADOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView PLAMGEMMEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 OMGECHBBEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 GOOIGCPCPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public LADBPODPGPP KBHGDJPPDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool JEEHDBPJCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool LMFPMBMNJON;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[KHBNPKNGIHN(typeof(HFDDDAIIHPO), new string[] { })]
public class MCJOCHELEJC : HFDDDAIIHPO, DKOLEACPDKF
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EACOFNPIGGG ACIECAMLMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private HLEGHDEFGID PLEJPFAFEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private CEIPOJNOHHH OHKJJALONEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private BJCIHLLDPNJ GFPLGAHCMFM;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public CEIPOJNOHHH IBIHIDOOPBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public BJCIHLLDPNJ PHAHFJGKAED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6587030", Offset = "0x6585A30", VA = "0x186587030", Slot = "8")]
	public void InitReferences(HANNLEINLJM OPLKFNLAKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6586D80", Offset = "0x6585780", VA = "0x186586D80", Slot = "6")]
	public IMIAHONOOAG EOEMCFOBAGH(RigidbodyEx AJJNHIINFFP)
	{
		return default(IMIAHONOOAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6587160", Offset = "0x6585B60", VA = "0x186587160")]
	private static IMIAHONOOAG NIJIOKPOKHI(RigidbodyEx AJJNHIINFFP)
	{
		return default(IMIAHONOOAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x65870C0", Offset = "0x6585AC0", VA = "0x1865870C0", Slot = "7")]
	public KILHMEMGMIO NEPDGHJGNNP(RigidbodyEx AJJNHIINFFP, PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public MCJOCHELEJC()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static BCNLEBGHOIF UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int FCGBFNHBGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int CKMEKEHFBFG;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x65918E0", Offset = "0x65902E0", VA = "0x1865918E0")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6591920", Offset = "0x6590320", VA = "0x186591920")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6591900", Offset = "0x6590300", VA = "0x186591900")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string BKNCBJIACBJ, [Optional] UnityEngine.Object AGHGCGMHDAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string BKNCBJIACBJ, [Optional] UnityEngine.Object AGHGCGMHDAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6591A30", Offset = "0x6590430", VA = "0x186591A30")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class PLIPEGBPNJK
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6591620", Offset = "0x6590020", VA = "0x186591620")]
	public static void EGOGFKGPONO(this Rigidbody LBNMHALADMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x65917B0", Offset = "0x65901B0", VA = "0x1865917B0")]
	public static void EGOGFKGPONO(this Rigidbody LBNMHALADMA, Vector3 KNIMKMFLPLH, Quaternion KKCCJIEMMHI, Vector3 CNJGGPJJJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xC248F0", Offset = "0xC232F0", VA = "0x180C248F0")]
	public static void IOPOMMKDKMF(Vector3 FEGCMBDOBNF, Vector3 AJENBHCBECD, [Out] Vector3 IHHDCMILCFL, [Out] Vector3 PEMDBKEKIAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JLILCGCANFG
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private class MCEFHNCBBBC : IBFPFLLNHAF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x79F990", Offset = "0x79E390", VA = "0x18079F990", Slot = "4")]
		public Vector3 BCFPBPDKJIO()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x79F990", Offset = "0x79E390", VA = "0x18079F990", Slot = "5")]
		public Vector3 IFCDEHGJDLN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
		public MCEFHNCBBBC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public static IBFPFLLNHAF PFOBDGFPKNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x657D970", Offset = "0x657C370", VA = "0x18657D970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IPKFHCMGOAF
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CollisionDetectionMode CMLEKLAKLFM
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
	void DBBCHFMHPJJ();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PLDOCDAEHHG(bool KNEFJOKKMJF);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABKMFOGFPGL(bool KNEFJOKKMJF);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EBIELIJIFDB(Rigidbody PJMDPLADOJA);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PKEBEHOIHNG(Vector3 NEGLEJJNHEL, [Out] RaycastHit AFJMBFCIKFN, float ECIJIDKCAEE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NCPFNNMIHPI : IDisposable, NDCKNADOPHE
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	DJEILIGJBKK DDEFJFBDGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<CPDDDNECHFB, CPDDDNECHFB> OHGEEJKEHNL;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DBBCHFMHPJJ();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[OPOKMAKOLPO(ECDJNIOPJID.Application)]
public interface BJCIHLLDPNJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NJDFIEODIDF HGOJPACHALC(KILHMEMGMIO DPFABJBBFIB);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MEJPMIBFJMA BFPAHCJDHPD(KILHMEMGMIO DPFABJBBFIB);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LBHKGIPFNKF LKMEBGGKIPC(KILHMEMGMIO DPFABJBBFIB);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JHLKDBFMMGA NNDODPCCFGB(KILHMEMGMIO DPFABJBBFIB);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AOAMMPDGLJK EMGCEBCBBAI(KILHMEMGMIO DPFABJBBFIB);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NCPFNNMIHPI PPONOHIGPID(KILHMEMGMIO DPFABJBBFIB);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PNLNJFAHGEA OACFNGONNLN(KILHMEMGMIO DPFABJBBFIB);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JLBMCFCJPPJ KFGFHHMJBFK(KILHMEMGMIO DPFABJBBFIB);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IPKFHCMGOAF BJKCMOICJIG(KILHMEMGMIO DPFABJBBFIB);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PMKAALGHPNI JPBPJGKMLNC(KILHMEMGMIO DPFABJBBFIB);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	MMFMABDKKFC LNABLMPEEKD(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LELJKNLCCBM EKKEHMIMCCO(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	BMIDDOIJIOI CAFNJFMEHEB(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MJBCDJCCJAJ NAOJIDPLABJ(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AMKBKDLBHCJ IDDPNOBAJPD(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KILHMEMGMIO NEPDGHJGNNP(RigidbodyEx AJJNHIINFFP, PABNOLNKAEE OBAHLGOPPIK, HFDDDAIIHPO FHOCAIDBAPC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JLBMCFCJPPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPOHLHMCEDO(Vector3 JAAMGDODLLF, ForceMode AEJDMFGIJOM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBNODMLJGCF(Vector3 JAAMGDODLLF, Vector3 CJONGNPPIAD, ForceMode AEJDMFGIJOM);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BOPHHFJIMLM(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCBPNNFPOBE(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface PMKAALGHPNI
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool ILAEENNJICK
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
	void EBIELIJIFDB(Rigidbody PJMDPLADOJA);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LOKBAEDKGLM(Rigidbody PJMDPLADOJA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NJDFIEODIDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	IReadOnlyList<KILHMEMGMIO> LFJPDEOEFJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	KILHMEMGMIO DABPAFAJNAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	KILHMEMGMIO HOANOOGFEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event PLMJOJGAJFH BOEHDHLHDOF;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event PLMJOJGAJFH OAMBIPLMBPK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event BAMKPCIEPMF HAMJIKFPLDP;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action MGMLBJJIMLI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action HLGPNKDHDJP;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<KILHMEMGMIO> NIBKBAOPJII;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<KILHMEMGMIO> HIOFLJKKBFB;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action JGJCDGHHMEB;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<KILHMEMGMIO> BHHOANKGAJA;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NPECOABHDEF(KILHMEMGMIO FPOAHANPCBM, bool OOJFFOBBJFE = false);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LBHKGIPFNKF
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Vector3 JOKOACMONEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 POGIDPHBGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBFGBIDMJCI(KILHMEMGMIO CDMOGOKIPKH, object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHEJMMOJLPB(object BDAPLOBBPIE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MJBCDJCCJAJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 FAINBFHJMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 OJAFBCGIAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	float JODNLNLNKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float FAPOHPCOLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 CKDEFCJLFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Quaternion JIPHILJPONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event PLMJOJGAJFH HIDDNLKNBNG;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HEAJILGOOGK((Quaternion rot, Vector3 moments) LGMCEMMFMED);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EFFKAAKBLCO();

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GCEGFILNODA();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ADDJEOFAHLK();

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EBIELIJIFDB(Rigidbody PJMDPLADOJA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LOKBAEDKGLM(Rigidbody PJMDPLADOJA);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JMJOEKEJEAA();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BMIDDOIJIOI
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DBBCHFMHPJJ();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKFIHOBLMIE(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPHJIJOIAON(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBOOONHFIDB(KILHMEMGMIO AJJNHIINFFP);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OKKKPKBJDDF(KILHMEMGMIO AJJNHIINFFP);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AKBMFAHOGOH();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PNLNJFAHGEA
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool JCGIPIDHHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event PLMJOJGAJFH CJMFCOHIPLH;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NIMIIKDCJGG();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJDHAFEBCIM(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CBOEMBMAEJG(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LADLDDLBDFM(object BDAPLOBBPIE, bool IMCAGEPDHDI);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable AOKIBPAOIKK();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EBIELIJIFDB(Rigidbody BHAECPFLHOI);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LOKBAEDKGLM(Rigidbody PJMDPLADOJA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LELJKNLCCBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool DMAKBKCDAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool FBALNADLPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event PLMJOJGAJFH CCLFKILHDNK;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DBBCHFMHPJJ();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HNFKODBGEFO(KILHMEMGMIO CDMOGOKIPKH);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OLNPEOMEJAG(KILHMEMGMIO CDMOGOKIPKH);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface AMKBKDLBHCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HFLMAHEOICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool GFICKOHNPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	RigidbodyConstraints ONGIKALHKMJ
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
	void EBIELIJIFDB(Rigidbody PJMDPLADOJA);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOKBAEDKGLM(Rigidbody PJMDPLADOJA);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface JHLKDBFMMGA
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float BDBNDEDAAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float OOFICFHPLHJ
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
	void EBIELIJIFDB(Rigidbody PJMDPLADOJA);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LOKBAEDKGLM(Rigidbody PJMDPLADOJA);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NHBEOOGAEGN
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx AKDHEGAGIBH);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface AOAMMPDGLJK
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event PLMJOJGAJFH EFCBHNNCGAN;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBBCHFMHPJJ();

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PACBHFODHNO();

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GCBAAPLBMPB();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BBIDCEIAOOG();

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOGABFIGGEC();

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JHAJHPKECNH();

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AMEAMGDDHBF(bool ABJMBKAGLDC);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface MMFMABDKKFC
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Rigidbody AJEBBECNDIH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool HLCLDNJLLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBBCHFMHPJJ();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void COMENENNGPM(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MBPIOIADFBD(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NBFGCDEHJID();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OEFKPKGLMHC();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MEJPMIBFJMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	IBFPFLLNHAF JADAAPBCGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	OGEJCJLEECF JDNHLOMLHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 CJGIJMHEFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 NCPEOPJCLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 HCDCLKKFCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 IKOPJKIPHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float LMOJAOMGEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	bool PAGMMGPHAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DBBCHFMHPJJ();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BGHFLAIHOFA(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NBFBDEGHLOH(GLAMMEJCNLN NHEGDAIEAAI, Vector3 IIILLOOECBD, float ODLNACAFJEE = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AGGCOBHBDOJ(DHPGLPGANNB EPKOBECIBEK, Vector3 KJIJGBOHKPF, float MKKHJDIICOM, float DGABKEGNMEH = 8f, float OFFAEJLJJAN = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KECLKLLLJCG(GLAMMEJCNLN NHEGDAIEAAI, Vector3 KPKKBKKOGOG, float IPEEDIDLNPN = 7f, float BFKJOMIGDBJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HAEDBJACJPL();

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void NILMLKNJAPJ();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void OPKNKOBHJMB();

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GPGJCFADKHO();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EBIELIJIFDB(Rigidbody PJMDPLADOJA);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 JBOCHKECIPN(Vector3 FEGCMBDOBNF);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void CIMFPNNLPIE(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JLMNCDBILKL(Vector3 LDLAACBNKIG);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ABIONAOINEN(Vector3 JEAPEJGJLMF, Vector3 OMNPLMFLMGI);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void MCCNHKLJDLJ(Vector3 MBDDFANMDHG, Vector3 JDOCNMMEPAN);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 BIIFKCAIIHA(Vector3 BFFOOLAMBIB);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 PDACNOPIGAN(Vector3 EGEFCPMFFFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[OPOKMAKOLPO(ECDJNIOPJID.Application)]
public interface CEIPOJNOHHH
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool MEIEJLAKHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMBIHCMKOEC(string BNFACNGELAB);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AJNMJJHKDOH(RigidbodyEx AJJNHIINFFP, Action GMHPLHJININ);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MLODEPOBAIH FIIBHKDEGBJ(int ANACFCDIDEE);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KLJOLGAGHIJ(Vector3 EPLNOJDLOPL, float CCNIKCCCDOB, Color GJNHDHNOICC);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[OPOKMAKOLPO(ECDJNIOPJID.Application)]
public interface HFDDDAIIHPO
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	CEIPOJNOHHH IBIHIDOOPBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	BJCIHLLDPNJ PHAHFJGKAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IMIAHONOOAG EOEMCFOBAGH(RigidbodyEx AJJNHIINFFP);

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KILHMEMGMIO NEPDGHJGNNP(RigidbodyEx AJJNHIINFFP, PABNOLNKAEE OBAHLGOPPIK);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface OGEJCJLEECF
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIOAEOHNHKH(Vector3 MHFMKLJKLOC);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKACMBFIIDG(Vector3 PABPMGJGOIN);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGPEHPNNDDM(Vector3 MHFMKLJKLOC);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FEPKIMMEOAK(Vector3 PABPMGJGOIN);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface IBFPFLLNHAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BCFPBPDKJIO();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 IFCDEHGJDLN();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface KILHMEMGMIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	Rigidbody AJEBBECNDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	RigidbodyEx FOJOLNIMAFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	GameObject EJJIGIIPPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	Transform EDLKPFGIAFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	KILHMEMGMIO HOANOOGFEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	IReadOnlyList<KILHMEMGMIO> LFJPDEOEFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	KILHMEMGMIO DABPAFAJNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool DMAKBKCDAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool FBALNADLPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	IBFPFLLNHAF JADAAPBCGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	OGEJCJLEECF JDNHLOMLHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	float LMOJAOMGEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	Vector3 NCPEOPJCLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 IKOPJKIPHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 CJGIJMHEFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 HCDCLKKFCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	bool ENJLCAOLEEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool DJBPKHLCKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool PAGMMGPHAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	Vector3 JOKOACMONEA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 POGIDPHBGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 FAINBFHJMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 OJAFBCGIAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	float JODNLNLNKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float FAPOHPCOLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	Vector3 CKDEFCJLFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Quaternion JIPHILJPONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	float BDBNDEDAAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float OOFICFHPLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	bool ILAEENNJICK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	DJEILIGJBKK DDEFJFBDGJE
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool JCGIPIDHHBG
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	Transform GIKHDPPMBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 HHJDGIIEKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	float HBEFDOKACNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float HAOIBKAOKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Quaternion LNJJBBKFHHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Vector3 CNBDLNEPHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Quaternion AHCNHPCACEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	RigidbodyConstraints ONGIKALHKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	bool HFLMAHEOICL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	CollisionDetectionMode CMLEKLAKLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool KMBJANENHOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event PLMJOJGAJFH BOEHDHLHDOF;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event PLMJOJGAJFH OAMBIPLMBPK;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event BAMKPCIEPMF HAMJIKFPLDP;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event PLMJOJGAJFH CCLFKILHDNK;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event PLMJOJGAJFH EJHBHIPPJKI;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event PLMJOJGAJFH EFCBHNNCGAN;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<CPDDDNECHFB, CPDDDNECHFB> OHGEEJKEHNL;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event PLMJOJGAJFH CJMFCOHIPLH;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event PLMJOJGAJFH KBAFEACEFMN;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void HEAJILGOOGK((Quaternion rot, Vector3 moments) LGMCEMMFMED);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void DBBCHFMHPJJ();

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void KKPMFLHMHGN();

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void MCCNPJCCHLO();

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void BBIDCEIAOOG();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void NPECOABHDEF(KILHMEMGMIO BEEGCHJLJFC, bool OOJFFOBBJFE = false);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void FIAFCEDAHGN(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void EAOBKKNCNHP(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 PDACNOPIGAN(Vector3 EGEFCPMFFFJ);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 BIIFKCAIIHA(Vector3 BFFOOLAMBIB);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void GPGJCFADKHO();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void NILMLKNJAPJ();

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void HAEDBJACJPL();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void MCCNHKLJDLJ(Vector3 MBDDFANMDHG, Vector3 JDOCNMMEPAN);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void ABIONAOINEN(Vector3 JEAPEJGJLMF, Vector3 OMNPLMFLMGI);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void JLMNCDBILKL(Vector3 LDLAACBNKIG);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void AGGCOBHBDOJ(DHPGLPGANNB EPKOBECIBEK, Vector3 KJIJGBOHKPF, float MKKHJDIICOM, float DGABKEGNMEH = 8f, float OFFAEJLJJAN = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void NBFBDEGHLOH(GLAMMEJCNLN NHEGDAIEAAI, Vector3 IIILLOOECBD, float ODLNACAFJEE = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void KECLKLLLJCG(GLAMMEJCNLN NHEGDAIEAAI, Vector3 KPKKBKKOGOG, float IPEEDIDLNPN = 7f, float BFKJOMIGDBJ = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 JBOCHKECIPN(Vector3 BEEGCHJLJFC);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 AMMFFIMFOFM(Vector3 BEEGCHJLJFC);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void OPKNKOBHJMB();

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void JDNEMFPNANJ(KILHMEMGMIO PJFKHGGFLEG, object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void LFGOAJMEKJP(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void GCEGFILNODA();

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void EFFKAAKBLCO();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void ADDJEOFAHLK();

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool PACBHFODHNO();

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void JHAJHPKECNH();

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable AOKIBPAOIKK();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void EJDHAFEBCIM(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void CBOEMBMAEJG(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void LADLDDLBDFM(object BDAPLOBBPIE, bool IMCAGEPDHDI);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void GEGLCBNJAHA(Vector3 DFMMIOGMKKL, Quaternion HHDMDNNPAEP);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void HJMLLONPGKB(Vector3 EBKILOPCAFO, Quaternion LAPNFLAIMAG);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool KOINGAPCINL(float LNNEBGNNLBM);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void LFIBPELFMMG(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void AFKGIMEPEKN(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void COMENENNGPM(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void MBPIOIADFBD(object BDAPLOBBPIE);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void DPOHLHMCEDO(Vector3 JAAMGDODLLF, ForceMode AEJDMFGIJOM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void LBNODMLJGCF(Vector3 JAAMGDODLLF, Vector3 CJONGNPPIAD, ForceMode AEJDMFGIJOM);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void BOPHHFJIMLM(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void MCBPNNFPOBE(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool PKEBEHOIHNG(Vector3 NEGLEJJNHEL, [Out] RaycastHit AFJMBFCIKFN, float ECIJIDKCAEE);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void JMJOEKEJEAA();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MPEOKLPOFLL : KILHMEMGMIO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal readonly HFDDDAIIHPO FHOCAIDBAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal NJDFIEODIDF EPEPPGJLEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal BMIDDOIJIOI PBAIJJHFAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal LELJKNLCCBM PFIBIJACCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal MEJPMIBFJMA FEGCMBDOBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal LBHKGIPFNKF BLCDAHOANII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal MJBCDJCCJAJ NFNOAFAOPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal JHLKDBFMMGA KEDBBFFAOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal PMKAALGHPNI EDHABKKNCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal AOAMMPDGLJK JFDJALFMNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal NCPFNNMIHPI MBOMPNINAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal PNLNJFAHGEA PDHIIHECGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal JLBMCFCJPPJ JAAMGDODLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal AMKBKDLBHCJ DHIIFNPCFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal MMFMABDKKFC PJMDPLADOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal IPKFHCMGOAF DPLCCIELOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal IDisposable IBCBKMPGHMK;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyEx FOJOLNIMAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x797760", Offset = "0x796160", VA = "0x180797760", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7977C0", Offset = "0x7961C0", VA = "0x1807977C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GameObject EJJIGIIPPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x863F90", Offset = "0x862990", VA = "0x180863F90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x863F70", Offset = "0x862970", VA = "0x180863F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public Transform EDLKPFGIAFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x658DE80", Offset = "0x658C880", VA = "0x18658DE80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Rigidbody AJEBBECNDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x658E710", Offset = "0x658D110", VA = "0x18658E710", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public KILHMEMGMIO HOANOOGFEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x658B260", Offset = "0x6589C60", VA = "0x18658B260", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x658ABD0", Offset = "0x65895D0", VA = "0x18658ABD0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IReadOnlyList<KILHMEMGMIO> LFJPDEOEFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x658D0D0", Offset = "0x658BAD0", VA = "0x18658D0D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public KILHMEMGMIO DABPAFAJNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x658C230", Offset = "0x658AC30", VA = "0x18658C230", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool CMOGBCADODC
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6589B80", Offset = "0x6588580", VA = "0x186589B80", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool DMAKBKCDAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x658BA70", Offset = "0x658A470", VA = "0x18658BA70", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool FBALNADLPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6589330", Offset = "0x6587D30", VA = "0x186589330", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public IBFPFLLNHAF JADAAPBCGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x658DBF0", Offset = "0x658C5F0", VA = "0x18658DBF0", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x658BF00", Offset = "0x658A900", VA = "0x18658BF00", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public OGEJCJLEECF JDNHLOMLHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x658BEB0", Offset = "0x658A8B0", VA = "0x18658BEB0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x658AE30", Offset = "0x6589830", VA = "0x18658AE30", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float LMOJAOMGEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x658B900", Offset = "0x658A300", VA = "0x18658B900", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x658CAE0", Offset = "0x658B4E0", VA = "0x18658CAE0", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Vector3 NCPEOPJCLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x658D840", Offset = "0x658C240", VA = "0x18658D840", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x6589FA0", Offset = "0x65889A0", VA = "0x186589FA0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 IKOPJKIPHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x658B670", Offset = "0x658A070", VA = "0x18658B670", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x658CB40", Offset = "0x658B540", VA = "0x18658CB40", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 CJGIJMHEFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x658C340", Offset = "0x658AD40", VA = "0x18658C340", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6589590", Offset = "0x6587F90", VA = "0x186589590", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 HCDCLKKFCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6589BE0", Offset = "0x65885E0", VA = "0x186589BE0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x658E240", Offset = "0x658CC40", VA = "0x18658E240", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool CLICEMHHOLK
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x658E320", Offset = "0x658CD20", VA = "0x18658E320", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool ENJLCAOLEEB
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x658A6E0", Offset = "0x65890E0", VA = "0x18658A6E0", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool DJBPKHLCKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x658C690", Offset = "0x658B090", VA = "0x18658C690", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool PAGMMGPHAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x658DAB0", Offset = "0x658C4B0", VA = "0x18658DAB0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Vector3 JOKOACMONEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x658E550", Offset = "0x658CF50", VA = "0x18658E550", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 POGIDPHBGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x658DF10", Offset = "0x658C910", VA = "0x18658DF10", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 FAINBFHJMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6589EC0", Offset = "0x65888C0", VA = "0x186589EC0", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6588A30", Offset = "0x6587430", VA = "0x186588A30", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 OJAFBCGIAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x658B460", Offset = "0x6589E60", VA = "0x18658B460", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public float JODNLNLNKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x658AA50", Offset = "0x6589450", VA = "0x18658AA50", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float FAPOHPCOLIL
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x658BA20", Offset = "0x658A420", VA = "0x18658BA20", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x658C950", Offset = "0x658B350", VA = "0x18658C950", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 CKDEFCJLFHM
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x658D180", Offset = "0x658BB80", VA = "0x18658D180", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Quaternion JIPHILJPONE
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x658A800", Offset = "0x6589200", VA = "0x18658A800", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float BDBNDEDAAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x658B620", Offset = "0x658A020", VA = "0x18658B620", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x658A930", Offset = "0x6589330", VA = "0x18658A930", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float OOFICFHPLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x658B1B0", Offset = "0x6589BB0", VA = "0x18658B1B0", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6589E60", Offset = "0x6588860", VA = "0x186589E60", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool ILAEENNJICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x658CE40", Offset = "0x658B840", VA = "0x18658CE40", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x658C2E0", Offset = "0x658ACE0", VA = "0x18658C2E0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public DJEILIGJBKK DDEFJFBDGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x658D7A0", Offset = "0x658C1A0", VA = "0x18658D7A0", Slot = "48")]
		get
		{
			return default(DJEILIGJBKK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x6588D40", Offset = "0x6587740", VA = "0x186588D40", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool JCGIPIDHHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x658DB00", Offset = "0x658C500", VA = "0x18658DB00", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Transform GIKHDPPMBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x658CDD0", Offset = "0x658B7D0", VA = "0x18658CDD0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Vector3 HHJDGIIEKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x658E0C0", Offset = "0x658CAC0", VA = "0x18658E0C0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x658B300", Offset = "0x6589D00", VA = "0x18658B300", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public float HBEFDOKACNO
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x658DA90", Offset = "0x658C490", VA = "0x18658DA90", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x658BCF0", Offset = "0x658A6F0", VA = "0x18658BCF0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float HAOIBKAOKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x658DE00", Offset = "0x658C800", VA = "0x18658DE00", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x658BF60", Offset = "0x658A960", VA = "0x18658BF60", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public Quaternion LNJJBBKFHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x658C5E0", Offset = "0x658AFE0", VA = "0x18658C5E0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x658E620", Offset = "0x658D020", VA = "0x18658E620", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Vector3 CNBDLNEPHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x658D7F0", Offset = "0x658C1F0", VA = "0x18658D7F0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6589540", Offset = "0x6587F40", VA = "0x186589540", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Quaternion AHCNHPCACEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x658E370", Offset = "0x658CD70", VA = "0x18658E370", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x658BE10", Offset = "0x658A810", VA = "0x18658BE10", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public RigidbodyConstraints ONGIKALHKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x658B3C0", Offset = "0x6589DC0", VA = "0x18658B3C0", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x658CC20", Offset = "0x658B620", VA = "0x18658CC20", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool HFLMAHEOICL
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x65891E0", Offset = "0x6587BE0", VA = "0x1865891E0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6589670", Offset = "0x6588070", VA = "0x186589670", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CollisionDetectionMode CMLEKLAKLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6589190", Offset = "0x6587B90", VA = "0x186589190", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x658C280", Offset = "0x658AC80", VA = "0x18658C280", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool MMALFLALMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6588EA0", Offset = "0x65878A0", VA = "0x186588EA0", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool KMBJANENHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x658BB70", Offset = "0x658A570", VA = "0x18658BB70", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool NHMHCNIJLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x658CC80", Offset = "0x658B680", VA = "0x18658CC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool BJEHHIEJDJN
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x658E170", Offset = "0x658CB70", VA = "0x18658E170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event PLMJOJGAJFH BOEHDHLHDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x658B200", Offset = "0x6589C00", VA = "0x18658B200", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x658BE50", Offset = "0x658A850", VA = "0x18658BE50", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event PLMJOJGAJFH OAMBIPLMBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x658A990", Offset = "0x6589390", VA = "0x18658A990", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x658A740", Offset = "0x6589140", VA = "0x18658A740", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event BAMKPCIEPMF HAMJIKFPLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x658C160", Offset = "0x658AB60", VA = "0x18658C160", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x658DE20", Offset = "0x658C820", VA = "0x18658DE20", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event PLMJOJGAJFH CCLFKILHDNK
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x658C420", Offset = "0x658AE20", VA = "0x18658C420", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x658DC40", Offset = "0x658C640", VA = "0x18658DC40", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event PLMJOJGAJFH EJHBHIPPJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6589090", Offset = "0x6587A90", VA = "0x186589090", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x658A370", Offset = "0x6588D70", VA = "0x18658A370", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event PLMJOJGAJFH EFCBHNNCGAN
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x658A8D0", Offset = "0x65892D0", VA = "0x18658A8D0", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6588B10", Offset = "0x6587510", VA = "0x186588B10", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<CPDDDNECHFB, CPDDDNECHFB> OHGEEJKEHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x658E760", Offset = "0x658D160", VA = "0x18658E760", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x658D120", Offset = "0x658BB20", VA = "0x18658D120", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event PLMJOJGAJFH CJMFCOHIPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x658B8A0", Offset = "0x658A2A0", VA = "0x18658B8A0", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6588BC0", Offset = "0x65875C0", VA = "0x186588BC0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event PLMJOJGAJFH KBAFEACEFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x658BD60", Offset = "0x658A760", VA = "0x18658BD60", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x658BAC0", Offset = "0x658A4C0", VA = "0x18658BAC0", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6578EC0", Offset = "0x65778C0", VA = "0x186578EC0")]
	public MPEOKLPOFLL(GameObject PKKHAEKNIBL, RigidbodyEx GOMFFLGGNKD, HFDDDAIIHPO FHOCAIDBAPC, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x658D260", Offset = "0x658BC60", VA = "0x18658D260", Slot = "135")]
	protected virtual void LKPKPNCBDHP(HFDDDAIIHPO FHOCAIDBAPC, PABNOLNKAEE OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x658A560", Offset = "0x6588F60", VA = "0x18658A560", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6589D20", Offset = "0x6588720", VA = "0x186589D20", Slot = "71")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x658B2B0", Offset = "0x6589CB0", VA = "0x18658B2B0", Slot = "72")]
	public void KKPMFLHMHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x658D780", Offset = "0x658C180", VA = "0x18658D780", Slot = "73")]
	public void MCCNPJCCHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6588FE0", Offset = "0x65879E0", VA = "0x186588FE0")]
	private void AOAHONMAAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x658DCF0", Offset = "0x658C6F0", VA = "0x18658DCF0", Slot = "81")]
	public void NPECOABHDEF(KILHMEMGMIO BEEGCHJLJFC, bool OOJFFOBBJFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x658A9F0", Offset = "0x65893F0", VA = "0x18658A9F0", Slot = "84")]
	public void FIAFCEDAHGN(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x658A630", Offset = "0x6589030", VA = "0x18658A630", Slot = "85")]
	public void EAOBKKNCNHP(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x658E3B0", Offset = "0x658CDB0", VA = "0x18658E3B0", Slot = "86")]
	public Vector3 PDACNOPIGAN(Vector3 EGEFCPMFFFJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6589230", Offset = "0x6587C30", VA = "0x186589230", Slot = "87")]
	public Vector3 BIIFKCAIIHA(Vector3 BFFOOLAMBIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x658B2B0", Offset = "0x6589CB0", VA = "0x18658B2B0", Slot = "88")]
	public void GPGJCFADKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x658DCA0", Offset = "0x658C6A0", VA = "0x18658DCA0", Slot = "89")]
	public void NILMLKNJAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x658B410", Offset = "0x6589E10", VA = "0x18658B410", Slot = "90")]
	public void HAEDBJACJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x658D690", Offset = "0x658C090", VA = "0x18658D690", Slot = "91")]
	public void MCCNHKLJDLJ(Vector3 MBDDFANMDHG, Vector3 JDOCNMMEPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x6588940", Offset = "0x6587340", VA = "0x186588940", Slot = "92")]
	public void ABIONAOINEN(Vector3 JEAPEJGJLMF, Vector3 OMNPLMFLMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x658C9B0", Offset = "0x658B3B0", VA = "0x18658C9B0", Slot = "93")]
	public void JLMNCDBILKL(Vector3 LDLAACBNKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x6588C80", Offset = "0x6587680", VA = "0x186588C80", Slot = "94")]
	public void AGGCOBHBDOJ(DHPGLPGANNB EPKOBECIBEK, Vector3 KJIJGBOHKPF, float MKKHJDIICOM, float DGABKEGNMEH = 8f, float OFFAEJLJJAN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x658DB50", Offset = "0x658C550", VA = "0x18658DB50", Slot = "95")]
	public void NBFBDEGHLOH(GLAMMEJCNLN NHEGDAIEAAI, Vector3 IIILLOOECBD, float ODLNACAFJEE = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x658CD20", Offset = "0x658B720", VA = "0x18658CD20", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void KECLKLLLJCG(GLAMMEJCNLN NHEGDAIEAAI, Vector3 KPKKBKKOGOG, float IPEEDIDLNPN = 7f, float BFKJOMIGDBJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x658C060", Offset = "0x658AA60", VA = "0x18658C060", Slot = "97")]
	public Vector3 JBOCHKECIPN(Vector3 BEEGCHJLJFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6588DA0", Offset = "0x65877A0", VA = "0x186588DA0", Slot = "98")]
	public Vector3 AMMFFIMFOFM(Vector3 BEEGCHJLJFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x658E1A0", Offset = "0x658CBA0", VA = "0x18658E1A0", Slot = "99")]
	public void OPKNKOBHJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x658C1C0", Offset = "0x658ABC0", VA = "0x18658C1C0", Slot = "100")]
	public void JDNEMFPNANJ(KILHMEMGMIO PJFKHGGFLEG, object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x658D010", Offset = "0x658BA10", VA = "0x18658D010", Slot = "101")]
	public void LFGOAJMEKJP(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x658B540", Offset = "0x6589F40", VA = "0x18658B540", Slot = "41")]
	public void HEAJILGOOGK((Quaternion rot, Vector3 moments) LGMCEMMFMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x658AB80", Offset = "0x6589580", VA = "0x18658AB80", Slot = "104")]
	public void GCEGFILNODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x658A690", Offset = "0x6589090", VA = "0x18658A690", Slot = "105")]
	public void EFFKAAKBLCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6588B70", Offset = "0x6587570", VA = "0x186588B70", Slot = "106")]
	public void ADDJEOFAHLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x658E1F0", Offset = "0x658CBF0", VA = "0x18658E1F0", Slot = "109")]
	public bool PACBHFODHNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6589140", Offset = "0x6587B40", VA = "0x186589140", Slot = "74")]
	public void BBIDCEIAOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x658C480", Offset = "0x658AE80", VA = "0x18658C480", Slot = "110")]
	public void JHAJHPKECNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x65890F0", Offset = "0x6587AF0", VA = "0x1865890F0", Slot = "115")]
	public IDisposable AOKIBPAOIKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x658A7A0", Offset = "0x65891A0", VA = "0x18658A7A0", Slot = "116")]
	public void EJDHAFEBCIM(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x65897B0", Offset = "0x65881B0", VA = "0x1865897B0", Slot = "117")]
	public void CBOEMBMAEJG(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x658CE90", Offset = "0x658B890", VA = "0x18658CE90", Slot = "118")]
	public void LADLDDLBDFM(object BDAPLOBBPIE, bool IMCAGEPDHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x658AC30", Offset = "0x6589630", VA = "0x18658AC30", Slot = "121")]
	public void GEGLCBNJAHA(Vector3 DFMMIOGMKKL, Quaternion HHDMDNNPAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x658B750", Offset = "0x658A150", VA = "0x18658B750", Slot = "122")]
	public void HJMLLONPGKB(Vector3 EBKILOPCAFO, Quaternion LAPNFLAIMAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x658CDE0", Offset = "0x658B7E0", VA = "0x18658CDE0", Slot = "123")]
	public bool KOINGAPCINL(float LNNEBGNNLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x658D070", Offset = "0x658BA70", VA = "0x18658D070", Slot = "124")]
	public void LFIBPELFMMG(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x6588C20", Offset = "0x6587620", VA = "0x186588C20", Slot = "125")]
	public void AFKGIMEPEKN(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x6589CC0", Offset = "0x65886C0", VA = "0x186589CC0", Slot = "126")]
	public void COMENENNGPM(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x658D550", Offset = "0x658BF50", VA = "0x18658D550", Slot = "127")]
	public void MBPIOIADFBD(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x658A480", Offset = "0x6588E80", VA = "0x18658A480", Slot = "128")]
	public void DPOHLHMCEDO(Vector3 JAAMGDODLLF, ForceMode AEJDMFGIJOM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x658CF00", Offset = "0x658B900", VA = "0x18658CF00", Slot = "129")]
	public void LBNODMLJGCF(Vector3 JAAMGDODLLF, Vector3 CJONGNPPIAD, ForceMode AEJDMFGIJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x65896D0", Offset = "0x65880D0", VA = "0x1865896D0", Slot = "130")]
	public void BOPHHFJIMLM(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x658D5B0", Offset = "0x658BFB0", VA = "0x18658D5B0", Slot = "131")]
	public void MCBPNNFPOBE(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x658E4B0", Offset = "0x658CEB0", VA = "0x18658E4B0", Slot = "132")]
	public bool PKEBEHOIHNG(Vector3 NEGLEJJNHEL, [Out] RaycastHit AFJMBFCIKFN, float ECIJIDKCAEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x658CA90", Offset = "0x658B490", VA = "0x18658CA90", Slot = "133")]
	public void JMJOEKEJEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x658E7C0", Offset = "0x658D1C0", VA = "0x18658E7C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x658AAA0", Offset = "0x65894A0", VA = "0x18658AAA0")]
	private void FKDEOEDFJAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x658C4D0", Offset = "0x658AED0", VA = "0x18658C4D0")]
	private void JHKEHPCGONF(KILHMEMGMIO CDMOGOKIPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x658A080", Offset = "0x6588A80", VA = "0x18658A080")]
	private void DGBKLDNBGBP(KILHMEMGMIO CDMOGOKIPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x658A3D0", Offset = "0x6588DD0", VA = "0x18658A3D0")]
	private void DOLBIPDCCLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x658A270", Offset = "0x6588C70", VA = "0x18658A270")]
	private void DICEELLIACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x658C770", Offset = "0x658B170", VA = "0x18658C770")]
	private void JJPNGDMBCGH(KILHMEMGMIO FBOBLAPMHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x658B950", Offset = "0x658A350", VA = "0x18658B950")]
	private void HNFKODBGEFO(KILHMEMGMIO CDMOGOKIPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x658DFF0", Offset = "0x658C9F0", VA = "0x18658DFF0")]
	private void OLNPEOMEJAG(KILHMEMGMIO CDMOGOKIPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x658D920", Offset = "0x658C320", VA = "0x18658D920")]
	private void MHEBNFEFNHG(RigidbodyEx CDMOGOKIPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6589380", Offset = "0x6587D80", VA = "0x186589380", Slot = "140")]
	protected virtual void BMCOFIGACGA(RigidbodyEx AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x658AE90", Offset = "0x6589890", VA = "0x18658AE90")]
	protected void GICPFJOOMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x6589810", Offset = "0x6588210", VA = "0x186589810")]
	protected void CCAGELFIJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x658DD60", Offset = "0x658C760", VA = "0x18658DD60", Slot = "141")]
	protected virtual IDisposable OAAKIBNPNGN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal static class EJPEGGMFHIG
{
	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x6572B50", Offset = "0x6571550", VA = "0x186572B50")]
	public static KILHMEMGMIO BDAGDOBIAFP(this KILHMEMGMIO AJJNHIINFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x6572CD0", Offset = "0x65716D0", VA = "0x186572CD0")]
	public static bool LHGMMJNLLOO(this KILHMEMGMIO AJJNHIINFFP, KILHMEMGMIO DPFKLEKNGDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6572C00", Offset = "0x6571600", VA = "0x186572C00")]
	public static bool CFAGADLBLBJ(this KILHMEMGMIO AJJNHIINFFP, KILHMEMGMIO ICMAKOMHGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6572C80", Offset = "0x6571680", VA = "0x186572C80")]
	public static RigidbodyEx FOJOLNIMAFN(this KILHMEMGMIO DLPENDOGCEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6572AD0", Offset = "0x65714D0", VA = "0x186572AD0")]
	public static MPEOKLPOFLL AOLCHMPKOCA(this KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal class JDLKJDBGIGL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly MPEOKLPOFLL AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool BDLHHIBLMII;

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x657CEE0", Offset = "0x657B8E0", VA = "0x18657CEE0")]
	public JDLKJDBGIGL(MPEOKLPOFLL HJICGNIAELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x657CE80", Offset = "0x657B880", VA = "0x18657CE80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal sealed class FMHFDNKPDEE : BKDMIHLLLMJ, IPKFHCMGOAF
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private CollisionDetectionMode DBIKBHEEHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6576DA0", Offset = "0x65757A0", VA = "0x186576DA0")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x65768D0", Offset = "0x65752D0", VA = "0x1865768D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private Rigidbody AJEBBECNDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x65716E0", Offset = "0x65700E0", VA = "0x1865716E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CollisionDetectionMode CMLEKLAKLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x65767C0", Offset = "0x65751C0", VA = "0x1865767C0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6576CE0", Offset = "0x65756E0", VA = "0x186576CE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x656FBD0", Offset = "0x656E5D0", VA = "0x18656FBD0")]
	public FMHFDNKPDEE(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x6576940", Offset = "0x6575340", VA = "0x186576940", Slot = "6")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x6576A90", Offset = "0x6575490", VA = "0x186576A90", Slot = "9")]
	public void EBIELIJIFDB(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6576F60", Offset = "0x6575960", VA = "0x186576F60", Slot = "7")]
	public void PLDOCDAEHHG(bool KNEFJOKKMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x65767B0", Offset = "0x65751B0", VA = "0x1865767B0", Slot = "8")]
	public void ABKMFOGFPGL(bool KNEFJOKKMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6576E00", Offset = "0x6575800", VA = "0x186576E00", Slot = "10")]
	public bool PKEBEHOIHNG(Vector3 NEGLEJJNHEL, [Out] RaycastHit AFJMBFCIKFN, float ECIJIDKCAEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6576B70", Offset = "0x6575570", VA = "0x186576B70")]
	private void FFKJILKHHEK(bool KNEFJOKKMJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class FHGNIEPIFGJ : BKDMIHLLLMJ, NCPFNNMIHPI, IDisposable, NDCKNADOPHE
{
	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public DJEILIGJBKK OGGLFOKIODI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x6573870", Offset = "0x6572270", VA = "0x186573870")]
		get
		{
			return default(DJEILIGJBKK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x65734D0", Offset = "0x6571ED0", VA = "0x1865734D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public DJEILIGJBKK DDEFJFBDGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6573670", Offset = "0x6572070", VA = "0x186573670", Slot = "6")]
		get
		{
			return default(DJEILIGJBKK);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x65734D0", Offset = "0x6571ED0", VA = "0x1865734D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private Transform PAEJIHJOPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78DC20", VA = "0x18078F220", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<CPDDDNECHFB, CPDDDNECHFB> OHGEEJKEHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6573970", Offset = "0x6572370", VA = "0x186573970", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x65735C0", Offset = "0x6571FC0", VA = "0x1865735C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x656FBD0", Offset = "0x656E5D0", VA = "0x18656FBD0")]
	public FHGNIEPIFGJ(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6573950", Offset = "0x6572350", VA = "0x186573950", Slot = "11")]
	public void OnChangedDistanceBand(CPDDDNECHFB PNPIPJDIOOB, CPDDDNECHFB KLJIIBEOHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "12")]
	public void OnChangedVisibility(bool CKILIKCPEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "8")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class MBNFDEAPFEG : BKDMIHLLLMJ, JLBMCFCJPPJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Rigidbody AJEBBECNDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x65716E0", Offset = "0x65700E0", VA = "0x1865716E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private bool JCGIPIDHHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6571690", Offset = "0x6570090", VA = "0x186571690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool CMOGBCADODC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6570AD0", Offset = "0x656F4D0", VA = "0x186570AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private KILHMEMGMIO HOANOOGFEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6586240", Offset = "0x6584C40", VA = "0x186586240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x656FBD0", Offset = "0x656E5D0", VA = "0x18656FBD0")]
	public MBNFDEAPFEG(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x65860E0", Offset = "0x6584AE0", VA = "0x1865860E0", Slot = "4")]
	public void DPOHLHMCEDO(Vector3 JAAMGDODLLF, ForceMode AEJDMFGIJOM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6586500", Offset = "0x6584F00", VA = "0x186586500")]
	private void JAGJMPLLPHN(Vector3 JAAMGDODLLF, ForceMode AEJDMFGIJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x65867E0", Offset = "0x65851E0", VA = "0x1865867E0", Slot = "5")]
	public void LBNODMLJGCF(Vector3 JAAMGDODLLF, Vector3 CJONGNPPIAD, ForceMode AEJDMFGIJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6585EA0", Offset = "0x65848A0", VA = "0x186585EA0", Slot = "6")]
	public void BOPHHFJIMLM(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x65862A0", Offset = "0x6584CA0", VA = "0x1865862A0")]
	private void HBGJBALHLJD(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6586A60", Offset = "0x6585460", VA = "0x186586A60", Slot = "7")]
	public void MCBPNNFPOBE(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6586000", Offset = "0x6584A00", VA = "0x186586000")]
	private void CIBIHDAPBBB(string BKNCBJIACBJ, UnityEngine.Object AGHGCGMHDAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class FJNBEMNMBPD : BKDMIHLLLMJ, PMKAALGHPNI
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool ILAEENNJICK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x6575AE0", Offset = "0x65744E0", VA = "0x186575AE0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x6575990", Offset = "0x6574390", VA = "0x186575990", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x656FBD0", Offset = "0x656E5D0", VA = "0x18656FBD0")]
	public FJNBEMNMBPD(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6575900", Offset = "0x6574300", VA = "0x186575900", Slot = "6")]
	public void EBIELIJIFDB(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6575B40", Offset = "0x6574540", VA = "0x186575B40", Slot = "7")]
	public void LOKBAEDKGLM(Rigidbody PJMDPLADOJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class LNPAEGPLKLH : BKDMIHLLLMJ, NJDFIEODIDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly EACOFNPIGGG KABDBHIDFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly JKGMGFGICDP OPPFAHLAIHL;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private Transform EDLKPFGIAFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x6585B20", Offset = "0x6584520", VA = "0x186585B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public IMIAHONOOAG NAKEFNBNHMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x6584190", Offset = "0x6582B90", VA = "0x186584190")]
		get
		{
			return default(IMIAHONOOAG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6585B50", Offset = "0x6584550", VA = "0x186585B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public KILHMEMGMIO HOANOOGFEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6584950", Offset = "0x6583350", VA = "0x186584950", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x65846E0", Offset = "0x65830E0", VA = "0x1865846E0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public IMIAHONOOAG AOFGBDOAHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x6584130", Offset = "0x6582B30", VA = "0x186584130")]
		get
		{
			return default(IMIAHONOOAG);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x6585BC0", Offset = "0x65845C0", VA = "0x186585BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public KILHMEMGMIO DABPAFAJNAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x6584F90", Offset = "0x6583990", VA = "0x186584F90", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public IReadOnlyList<KILHMEMGMIO> LFJPDEOEFJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x78FC80", Offset = "0x78E680", VA = "0x18078FC80", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event PLMJOJGAJFH BOEHDHLHDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x65848B0", Offset = "0x65832B0", VA = "0x1865848B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6584DA0", Offset = "0x65837A0", VA = "0x186584DA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event PLMJOJGAJFH OAMBIPLMBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6584640", Offset = "0x6583040", VA = "0x186584640", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x65843C0", Offset = "0x6582DC0", VA = "0x1865843C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event BAMKPCIEPMF HAMJIKFPLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6584E40", Offset = "0x6583840", VA = "0x186584E40", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x6585A80", Offset = "0x6584480", VA = "0x186585A80", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action MGMLBJJIMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6585000", Offset = "0x6583A00", VA = "0x186585000", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x6584C60", Offset = "0x6583660", VA = "0x186584C60", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action HLGPNKDHDJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x6584D00", Offset = "0x6583700", VA = "0x186584D00", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x6585860", Offset = "0x6584260", VA = "0x186585860", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<KILHMEMGMIO> NIBKBAOPJII
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x6583DE0", Offset = "0x65827E0", VA = "0x186583DE0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x6584800", Offset = "0x6583200", VA = "0x186584800", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<KILHMEMGMIO> HIOFLJKKBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6585900", Offset = "0x6584300", VA = "0x186585900", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6583E90", Offset = "0x6582890", VA = "0x186583E90", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action JGJCDGHHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x6583F40", Offset = "0x6582940", VA = "0x186583F40", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x65849C0", Offset = "0x65833C0", VA = "0x1865849C0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<KILHMEMGMIO> BHHOANKGAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6584EE0", Offset = "0x65838E0", VA = "0x186584EE0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6583FE0", Offset = "0x65829E0", VA = "0x186583FE0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6585CC0", Offset = "0x65846C0", VA = "0x186585CC0")]
	public LNPAEGPLKLH(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x65841F0", Offset = "0x6582BF0", VA = "0x1865841F0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x6585A00", Offset = "0x6584400", VA = "0x186585A00", Slot = "26")]
	public void NPECOABHDEF(KILHMEMGMIO FPOAHANPCBM, bool OOJFFOBBJFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x65859B0", Offset = "0x65843B0", VA = "0x1865859B0")]
	private void NPECOABHDEF(HLEKIFJMIMG FPOAHANPCBM, bool OOJFFOBBJFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x65853E0", Offset = "0x6583DE0", VA = "0x1865853E0")]
	private void LICKGFKEMPG(HLEKIFJMIMG FPOAHANPCBM, bool OOJFFOBBJFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x65850A0", Offset = "0x6583AA0", VA = "0x1865850A0")]
	private void KENKMDKEIJJ(HLEKIFJMIMG FBOBLAPMHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6584A60", Offset = "0x6583460", VA = "0x186584A60")]
	private void HIJAHONBKGC(HLEKIFJMIMG FBOBLAPMHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6584460", Offset = "0x6582E60", VA = "0x186584460")]
	private void ELBJFHOBCCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6584750", Offset = "0x6583150", VA = "0x186584750")]
	private void GMIFIEEALPK(HLEKIFJMIMG FBOBLAPMHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x65852F0", Offset = "0x6583CF0", VA = "0x1865852F0")]
	private void KJCMLMHPPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x6584320", Offset = "0x6582D20", VA = "0x186584320")]
	private void ECOOBADFKEJ(HLEKIFJMIMG AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x6584090", Offset = "0x6582A90", VA = "0x186584090")]
	private void AMOMMIPOPEL(HLEKIFJMIMG AJJNHIINFFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class CJGDDCFPBAM
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x65708E0", Offset = "0x656F2E0", VA = "0x1865708E0")]
	public static LNPAEGPLKLH GNPLKPECELJ(this KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class MHOEOKFDGLO : BKDMIHLLLMJ, LBHKGIPFNKF
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public Vector3 JOKOACMONEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x6588910", Offset = "0x6587310", VA = "0x186588910", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 POGIDPHBGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6588480", Offset = "0x6586E80", VA = "0x186588480", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private Vector3 CJGIJMHEFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6587F10", Offset = "0x6586910", VA = "0x186587F10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private KILHMEMGMIO HIEBMECNAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6587DB0", Offset = "0x65867B0", VA = "0x186587DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x656FBD0", Offset = "0x656E5D0", VA = "0x18656FBD0")]
	public MHOEOKFDGLO(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x65887C0", Offset = "0x65871C0", VA = "0x1865887C0", Slot = "6")]
	public void PBFGBIDMJCI(KILHMEMGMIO CDMOGOKIPKH, object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x65886B0", Offset = "0x65870B0", VA = "0x1865886B0")]
	private void PBFGBIDMJCI(HLEKIFJMIMG CDMOGOKIPKH, object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x6588000", Offset = "0x6586A00", VA = "0x186588000", Slot = "7")]
	public void KHEJMMOJLPB(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6588070", Offset = "0x6586A70", VA = "0x186588070")]
	private Vector3 MLPKJBJIHJF()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class BGHJGBKKDJH
{
	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x656FAA0", Offset = "0x656E4A0", VA = "0x18656FAA0")]
	public static MHOEOKFDGLO GLBPPFIANHD(this KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class INIDMPHAEBG : BKDMIHLLLMJ, MJBCDJCCJAJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 FAINBFHJMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x657AE80", Offset = "0x6579880", VA = "0x18657AE80", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x6579500", Offset = "0x6577F00", VA = "0x186579500", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public Vector3 NDLDHLJFHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x657B000", Offset = "0x6579A00", VA = "0x18657B000")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 IPJFHNJMFMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x657BE60", Offset = "0x657A860", VA = "0x18657BE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 OJAFBCGIAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x657B840", Offset = "0x657A240", VA = "0x18657B840", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float JODNLNLNKEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x657B4D0", Offset = "0x6579ED0", VA = "0x18657B4D0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public float JDAFJBABNNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x657BD20", Offset = "0x657A720", VA = "0x18657BD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float FAPOHPCOLIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x657BCC0", Offset = "0x657A6C0", VA = "0x18657BCC0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x657BDA0", Offset = "0x657A7A0", VA = "0x18657BDA0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public Vector3 CKDEFCJLFHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x657C770", Offset = "0x657B170", VA = "0x18657C770", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Quaternion JIPHILJPONE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x657B4A0", Offset = "0x6579EA0", VA = "0x18657B4A0", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private Rigidbody AJEBBECNDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x65716E0", Offset = "0x65700E0", VA = "0x1865716E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event PLMJOJGAJFH HIDDNLKNBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x657AB80", Offset = "0x6579580", VA = "0x18657AB80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x657B400", Offset = "0x6579E00", VA = "0x18657B400", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x657CB90", Offset = "0x657B590", VA = "0x18657CB90")]
	public INIDMPHAEBG(KILHMEMGMIO AJJNHIINFFP, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x657B720", Offset = "0x657A120", VA = "0x18657B720")]
	public float3 GJNAGLGEBEH()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x657BA30", Offset = "0x657A430", VA = "0x18657BA30", Slot = "14")]
	public void HEAJILGOOGK((Quaternion rot, Vector3 moments) LGMCEMMFMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x657B530", Offset = "0x6579F30", VA = "0x18657B530", Slot = "16")]
	public void GCEGFILNODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x657B0B0", Offset = "0x6579AB0", VA = "0x18657B0B0", Slot = "15")]
	public void EFFKAAKBLCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x657AF30", Offset = "0x6579930", VA = "0x18657AF30", Slot = "18")]
	public void EBIELIJIFDB(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x657C7A0", Offset = "0x657B1A0", VA = "0x18657C7A0", Slot = "19")]
	public void LOKBAEDKGLM(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6579680", Offset = "0x6578080", VA = "0x186579680", Slot = "17")]
	public void ADDJEOFAHLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x657BF90", Offset = "0x657A990", VA = "0x18657BF90", Slot = "20")]
	public void JMJOEKEJEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6571DA0", Offset = "0x65707A0", VA = "0x186571DA0")]
	public void NLEGMOEMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6579500", Offset = "0x6577F00", VA = "0x186579500")]
	private void DMHLFJGJNLC(Vector3 BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x657C590", Offset = "0x657AF90", VA = "0x18657C590")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 LAILPLECAMA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x657BDA0", Offset = "0x657A7A0", VA = "0x18657BDA0")]
	private void NIHLIOIGGMK(float BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x657AC20", Offset = "0x6579620", VA = "0x18657AC20")]
	private Vector3 DDDCNKAIDED()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x657A940", Offset = "0x6579340", VA = "0x18657A940")]
	private Quaternion CCFBLLKDAOO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x65796E0", Offset = "0x65780E0", VA = "0x1865796E0")]
	internal (float, Vector3) AIHFGHOGAOK(Rigidbody DNLMBGGHJFL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class DMHGHAKICFG
{
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x65717C0", Offset = "0x65701C0", VA = "0x1865717C0")]
	public static INIDMPHAEBG BDDIFHPHCOE(this KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class PJGALEBPENG : BKDMIHLLLMJ, BMIDDOIJIOI
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public bool HONFKFCAIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6590F40", Offset = "0x658F940", VA = "0x186590F40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public EMJNKAFCANP NBLOOFOANDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6590EE0", Offset = "0x658F8E0", VA = "0x186590EE0", Slot = "11")]
		get
		{
			return default(EMJNKAFCANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private EMJNKAFCANP ENFPODEOOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x6590EE0", Offset = "0x658F8E0", VA = "0x186590EE0")]
		get
		{
			return default(EMJNKAFCANP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x65913A0", Offset = "0x658FDA0", VA = "0x1865913A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6591510", Offset = "0x658FF10", VA = "0x186591510")]
	public PJGALEBPENG(KILHMEMGMIO AJJNHIINFFP, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6590DE0", Offset = "0x658F7E0", VA = "0x186590DE0", Slot = "4")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x6590FA0", Offset = "0x658F9A0", VA = "0x186590FA0")]
	private bool DGENNHNDEGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x6591410", Offset = "0x658FE10", VA = "0x186591410", Slot = "5")]
	public void OKFIHOBLMIE(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6590D60", Offset = "0x658F760", VA = "0x186590D60", Slot = "6")]
	public void CPHJIJOIAON(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6590C00", Offset = "0x658F600", VA = "0x186590C00", Slot = "9")]
	public void AKBMFAHOGOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x65912A0", Offset = "0x658FCA0", VA = "0x1865912A0")]
	private void JFFGCDANHNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6591100", Offset = "0x658FB00", VA = "0x186591100")]
	private void HGBIBBGOMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6591490", Offset = "0x658FE90", VA = "0x186591490", Slot = "8")]
	public void OKKKPKBJDDF(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6591080", Offset = "0x658FA80", VA = "0x186591080", Slot = "7")]
	public void FBOOONHFIDB(KILHMEMGMIO AJJNHIINFFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class EACFFCMJLLP : BKDMIHLLLMJ, PNLNJFAHGEA
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool JCGIPIDHHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x6571D40", Offset = "0x6570740", VA = "0x186571D40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private bool IEALNCCEBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6571960", Offset = "0x6570360", VA = "0x186571960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event PLMJOJGAJFH CJMFCOHIPLH
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x6571AC0", Offset = "0x65704C0", VA = "0x186571AC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6571850", Offset = "0x6570250", VA = "0x186571850", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x656FBD0", Offset = "0x656E5D0", VA = "0x18656FBD0")]
	public EACFFCMJLLP(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x65718F0", Offset = "0x65702F0", VA = "0x1865718F0", Slot = "11")]
	public IDisposable AOKIBPAOIKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6571AB0", Offset = "0x65704B0", VA = "0x186571AB0", Slot = "8")]
	public void EJDHAFEBCIM(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x65719C0", Offset = "0x65703C0", VA = "0x1865719C0", Slot = "9")]
	public void CBOEMBMAEJG(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x6571B60", Offset = "0x6570560", VA = "0x186571B60", Slot = "10")]
	public void LADLDDLBDFM(object BDAPLOBBPIE, bool IMCAGEPDHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x65719D0", Offset = "0x65703D0", VA = "0x1865719D0", Slot = "12")]
	public void EBIELIJIFDB(Rigidbody BHAECPFLHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6571C60", Offset = "0x6570660", VA = "0x186571C60", Slot = "13")]
	public void LOKBAEDKGLM(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6571DA0", Offset = "0x65707A0", VA = "0x186571DA0", Slot = "6")]
	public void NIMIIKDCJGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class HBIBKHJLGLJ : BKDMIHLLLMJ, LELJKNLCCBM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private PhotonView PLAMGEMMEND;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool DMAKBKCDAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x6577650", Offset = "0x6576050", VA = "0x186577650", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool FBALNADLPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6576F70", Offset = "0x6575970", VA = "0x186576F70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event PLMJOJGAJFH CCLFKILHDNK
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x65779A0", Offset = "0x65763A0", VA = "0x1865779A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x6577A40", Offset = "0x6576440", VA = "0x186577A40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6577CE0", Offset = "0x65766E0", VA = "0x186577CE0")]
	public HBIBKHJLGLJ(KILHMEMGMIO AJJNHIINFFP, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6577000", Offset = "0x6575A00", VA = "0x186577000", Slot = "8")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6577130", Offset = "0x6575B30", VA = "0x186577130", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6577450", Offset = "0x6575E50", VA = "0x186577450", Slot = "9")]
	public void HNFKODBGEFO(KILHMEMGMIO CDMOGOKIPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6577AE0", Offset = "0x65764E0", VA = "0x186577AE0", Slot = "10")]
	public void OLNPEOMEJAG(KILHMEMGMIO CDMOGOKIPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x65777C0", Offset = "0x65761C0", VA = "0x1865777C0")]
	private void JBOLGJFBDMF(PhotonView JMHBFLOPOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6577670", Offset = "0x6576070", VA = "0x186577670")]
	private void IPAEKILAHCI(RigidbodyEx HBCFMOJKBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x6577290", Offset = "0x6575C90", VA = "0x186577290")]
	private void EFHPDDCCGOD(PhotonView OBBCOFJJGFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal static class PGAGJPDJLCC
{
	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x65904E0", Offset = "0x658EEE0", VA = "0x1865904E0")]
	public static HBIBKHJLGLJ IFJEFICHPGE(this MPEOKLPOFLL DPFABJBBFIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class PIBEDPBOGGI : BKDMIHLLLMJ, AMKBKDLBHCJ
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool HFLMAHEOICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x65905B0", Offset = "0x658EFB0", VA = "0x1865905B0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6590610", Offset = "0x658F010", VA = "0x186590610", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool GFICKOHNPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6590680", Offset = "0x658F080", VA = "0x186590680", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6590540", Offset = "0x658EF40", VA = "0x186590540")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyConstraints ONGIKALHKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x6590770", Offset = "0x658F170", VA = "0x186590770", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x65907D0", Offset = "0x658F1D0", VA = "0x1865907D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x65909D0", Offset = "0x658F3D0", VA = "0x1865909D0")]
	public PIBEDPBOGGI(KILHMEMGMIO AJJNHIINFFP, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x65906E0", Offset = "0x658F0E0", VA = "0x1865906E0", Slot = "9")]
	public void EBIELIJIFDB(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x6590950", Offset = "0x658F350", VA = "0x186590950", Slot = "10")]
	public void LOKBAEDKGLM(Rigidbody PJMDPLADOJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class JEPPFLAODHD : BKDMIHLLLMJ, JHLKDBFMMGA
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public float BDBNDEDAAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x657D350", Offset = "0x657BD50", VA = "0x18657D350", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x657D1A0", Offset = "0x657BBA0", VA = "0x18657D1A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float OOFICFHPLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x657D2F0", Offset = "0x657BCF0", VA = "0x18657D2F0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x657CF60", Offset = "0x657B960", VA = "0x18657CF60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x656FBD0", Offset = "0x656E5D0", VA = "0x18656FBD0")]
	public JEPPFLAODHD(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x657D0B0", Offset = "0x657BAB0", VA = "0x18657D0B0", Slot = "8")]
	public void EBIELIJIFDB(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x657D3B0", Offset = "0x657BDB0", VA = "0x18657D3B0", Slot = "9")]
	public void LOKBAEDKGLM(Rigidbody PJMDPLADOJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[KHBNPKNGIHN(typeof(MMFFCJOPKEA), new string[] { })]
public sealed class BPJMGHKBHID : DKOLEACPDKF, MMFFCJOPKEA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[HOGGOCOBCAF]
	private BBADMEGBCBC AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool BDLHHIBLMII;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool KHGKOOPGFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x8113D0", Offset = "0x80FDD0", VA = "0x1808113D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x65703E0", Offset = "0x656EDE0", VA = "0x1865703E0", Slot = "4")]
	public void InitReferences(HANNLEINLJM OPLKFNLAKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x656FF90", Offset = "0x656E990", VA = "0x18656FF90", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x656FD30", Offset = "0x656E730", VA = "0x18656FD30", Slot = "6")]
	public void AIHFGHOGAOK(IMIAHONOOAG DGJIHKHJFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x65701C0", Offset = "0x656EBC0", VA = "0x1865701C0", Slot = "7")]
	public void IPMLIEBPHLO(IMIAHONOOAG DGJIHKHJFEB, bool MHCONAGPKII, bool OOCPKFNEJGD, bool CICLKGHKFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x656FE50", Offset = "0x656E850", VA = "0x18656FE50", Slot = "8")]
	public void BEJHPMGFAMF(IMIAHONOOAG DGJIHKHJFEB, float3 BFFOOLAMBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x6570080", Offset = "0x656EA80", VA = "0x186570080", Slot = "9")]
	public void IABACMFEANE(IMIAHONOOAG DGJIHKHJFEB, float3 OMNPLMFLMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x656FFC0", Offset = "0x656E9C0", VA = "0x18656FFC0")]
	private bool GHOHOMOPPBK(IMIAHONOOAG DGJIHKHJFEB, [Out] HLEKIFJMIMG DPFABJBBFIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x6570430", Offset = "0x656EE30", VA = "0x186570430")]
	private bool JBLPGCIMHPB(IMIAHONOOAG DGJIHKHJFEB, [Out] INIDMPHAEBG LHHPGMDAPPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6570520", Offset = "0x656EF20", VA = "0x186570520")]
	private bool LLBADCIOCBK(IMIAHONOOAG DGJIHKHJFEB, [Out] JMLEKPJPLHH ONBDDJHJMAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public BPJMGHKBHID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class KFHBMAJEMBJ : BKDMIHLLLMJ, AOAMMPDGLJK
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private Rigidbody AJEBBECNDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x65716E0", Offset = "0x65700E0", VA = "0x1865716E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private bool MMALFLALMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x657E010", Offset = "0x657CA10", VA = "0x18657E010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private KILHMEMGMIO HOANOOGFEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x6582A10", Offset = "0x6581410", VA = "0x186582A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private bool CMOGBCADODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x65827F0", Offset = "0x65811F0", VA = "0x1865827F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool NDBPAEFFEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x6582F70", Offset = "0x6581970", VA = "0x186582F70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x6582690", Offset = "0x6581090", VA = "0x186582690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool LGOKICLONPK
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6582C90", Offset = "0x6581690", VA = "0x186582C90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x6582BB0", Offset = "0x65815B0", VA = "0x186582BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private int LAHDGFFPECC
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x6582C20", Offset = "0x6581620", VA = "0x186582C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event PLMJOJGAJFH EFCBHNNCGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6582900", Offset = "0x6581300", VA = "0x186582900", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x65825F0", Offset = "0x6580FF0", VA = "0x1865825F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x6582FD0", Offset = "0x65819D0", VA = "0x186582FD0")]
	public KFHBMAJEMBJ(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x6582850", Offset = "0x6581250", VA = "0x186582850", Slot = "6")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x65829A0", Offset = "0x65813A0", VA = "0x1865829A0", Slot = "8")]
	public void GCBAAPLBMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x6582CF0", Offset = "0x65816F0", VA = "0x186582CF0", Slot = "7")]
	public bool PACBHFODHNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x6582700", Offset = "0x6581100", VA = "0x186582700", Slot = "9")]
	public void BBIDCEIAOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x6571DA0", Offset = "0x65707A0", VA = "0x186571DA0", Slot = "12")]
	public void AMEAMGDDHBF(bool ABJMBKAGLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x6582A70", Offset = "0x6581470", VA = "0x186582A70", Slot = "11")]
	public void JHAJHPKECNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "10")]
	public void LOGABFIGGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x6582E90", Offset = "0x6581890", VA = "0x186582E90")]
	private void PIEEMFNJFAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class MCMHBKFCCDK : BKDMIHLLLMJ, MMFMABDKKFC
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Rigidbody AJEBBECNDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x6587C10", Offset = "0x6586610", VA = "0x186587C10", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x6587B20", Offset = "0x6586520", VA = "0x186587B20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private bool CMOGBCADODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x6570AD0", Offset = "0x656F4D0", VA = "0x186570AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool HLCLDNJLLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x65875C0", Offset = "0x6585FC0", VA = "0x1865875C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x6587CF0", Offset = "0x65866F0", VA = "0x186587CF0")]
	public MCMHBKFCCDK(KILHMEMGMIO AJJNHIINFFP, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x6587340", Offset = "0x6585D40", VA = "0x186587340", Slot = "5")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x65872C0", Offset = "0x6585CC0", VA = "0x1865872C0", Slot = "7")]
	public void COMENENNGPM(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x6587880", Offset = "0x6586280", VA = "0x186587880", Slot = "8")]
	public void MBPIOIADFBD(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x6587900", Offset = "0x6586300", VA = "0x186587900", Slot = "9")]
	public void NBFGCDEHJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x6587620", Offset = "0x6586020", VA = "0x186587620", Slot = "11")]
	public void FOOIFCELMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x65873F0", Offset = "0x6585DF0", VA = "0x1865873F0", Slot = "12")]
	public void EAAIJOKHJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "10")]
	public void OEFKPKGLMHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class JMLEKPJPLHH : BKDMIHLLLMJ, MEJPMIBFJMA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IBFPFLLNHAF JADAAPBCGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x6580910", Offset = "0x657F310", VA = "0x186580910", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x657F290", Offset = "0x657DC90", VA = "0x18657F290", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public OGEJCJLEECF JDNHLOMLHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x657EC60", Offset = "0x657D660", VA = "0x18657EC60", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x657E7C0", Offset = "0x657D1C0", VA = "0x18657E7C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 CJGIJMHEFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x657F3E0", Offset = "0x657DDE0", VA = "0x18657F3E0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x657E2C0", Offset = "0x657CCC0", VA = "0x18657E2C0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 NCPEOPJCLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x65805D0", Offset = "0x657EFD0", VA = "0x1865805D0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x657E500", Offset = "0x657CF00", VA = "0x18657E500", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 HCDCLKKFCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x657E3F0", Offset = "0x657CDF0", VA = "0x18657E3F0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x6581330", Offset = "0x657FD30", VA = "0x186581330", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 IKOPJKIPHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x657E940", Offset = "0x657D340", VA = "0x18657E940", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x657F760", Offset = "0x657E160", VA = "0x18657F760", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float LMOJAOMGEEK
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x657E970", Offset = "0x657D370", VA = "0x18657E970", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x657F440", Offset = "0x657DE40", VA = "0x18657F440", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public bool PAGMMGPHAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6580600", Offset = "0x657F000", VA = "0x186580600", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private JLBMCFCJPPJ KEJCJOLNLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x1E6FC30", Offset = "0x1E6E630", VA = "0x181E6FC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private bool MMALFLALMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x657E010", Offset = "0x657CA10", VA = "0x18657E010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x656FBD0", Offset = "0x656E5D0", VA = "0x18656FBD0")]
	public JMLEKPJPLHH(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x657E090", Offset = "0x657CA90", VA = "0x18657E090", Slot = "20")]
	public void BGHFLAIHOFA(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x657E380", Offset = "0x657CD80", VA = "0x18657E380", Slot = "30")]
	public void CIMFPNNLPIE(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x657E450", Offset = "0x657CE50", VA = "0x18657E450", Slot = "19")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x657E530", Offset = "0x657CF30", VA = "0x18657E530", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x657E5F0", Offset = "0x657CFF0", VA = "0x18657E5F0", Slot = "28")]
	public void EBIELIJIFDB(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x65813F0", Offset = "0x657FDF0", VA = "0x1865813F0", Slot = "35")]
	public Vector3 PDACNOPIGAN(Vector3 EGEFCPMFFFJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x657E100", Offset = "0x657CB00", VA = "0x18657E100", Slot = "34")]
	public Vector3 BIIFKCAIIHA(Vector3 BFFOOLAMBIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x657E450", Offset = "0x657CE50", VA = "0x18657E450", Slot = "27")]
	public void GPGJCFADKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x65809C0", Offset = "0x657F3C0", VA = "0x1865809C0", Slot = "25")]
	public void NILMLKNJAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x657E830", Offset = "0x657D230", VA = "0x18657E830", Slot = "24")]
	public void HAEDBJACJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x6580390", Offset = "0x657ED90", VA = "0x186580390", Slot = "33")]
	public void MCCNHKLJDLJ(Vector3 MBDDFANMDHG, Vector3 JDOCNMMEPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x657DA40", Offset = "0x657C440", VA = "0x18657DA40", Slot = "32")]
	public void ABIONAOINEN(Vector3 JEAPEJGJLMF, Vector3 OMNPLMFLMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x657F590", Offset = "0x657DF90", VA = "0x18657F590", Slot = "31")]
	public void JLMNCDBILKL(Vector3 LDLAACBNKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x657DAA0", Offset = "0x657C4A0", VA = "0x18657DAA0", Slot = "22")]
	public void AGGCOBHBDOJ(DHPGLPGANNB EPKOBECIBEK, Vector3 KJIJGBOHKPF, float MKKHJDIICOM, float DGABKEGNMEH = 8f, float OFFAEJLJJAN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x6580660", Offset = "0x657F060", VA = "0x186580660", Slot = "21")]
	public void NBFBDEGHLOH(GLAMMEJCNLN NHEGDAIEAAI, Vector3 IIILLOOECBD, float ODLNACAFJEE = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x657FA10", Offset = "0x657E410", VA = "0x18657FA10", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void KECLKLLLJCG(GLAMMEJCNLN NHEGDAIEAAI, Vector3 KPKKBKKOGOG, float IPEEDIDLNPN = 7f, float BFKJOMIGDBJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x657F300", Offset = "0x657DD00", VA = "0x18657F300", Slot = "29")]
	public Vector3 JBOCHKECIPN(Vector3 FEGCMBDOBNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x65811A0", Offset = "0x657FBA0", VA = "0x1865811A0", Slot = "26")]
	public void OPKNKOBHJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x657F440", Offset = "0x657DE40", VA = "0x18657F440")]
	private void JLJIFNMIOAG(float BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x6580FD0", Offset = "0x657F9D0", VA = "0x186580FD0")]
	private void OFFKCLNMCHB(Vector3 IIILLOOECBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x657F790", Offset = "0x657E190", VA = "0x18657F790")]
	private Vector3 KDHKPGEFLGC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x657ED10", Offset = "0x657D710", VA = "0x18657ED10")]
	private void INPFMAEGJOD(Vector3 BFFOOLAMBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x657E9D0", Offset = "0x657D3D0", VA = "0x18657E9D0")]
	private Vector3 IFCDEHGJDLN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x657FE20", Offset = "0x657E820", VA = "0x18657FE20")]
	private void LKACMBFIIDG(Vector3 BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x657E760", Offset = "0x657D160", VA = "0x18657E760")]
	private void FPBGOKPJAOF(Vector3 FEGCMBDOBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x657E030", Offset = "0x657CA30", VA = "0x18657E030")]
	private void BFHGOIAILFD(Vector3 PABPMGJGOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x6580A20", Offset = "0x657F420", VA = "0x186580A20")]
	private void ODLCNJMNLIL(string ONLOGHPNDLO, Vector3 BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x657E890", Offset = "0x657D290", VA = "0x18657E890")]
	private void HFNLIOBBMCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal class BKDMIHLLLMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly HLEKIFJMIMG AJJNHIINFFP;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	protected BBADMEGBCBC DMCBGGPFAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x566ABC0", Offset = "0x56695C0", VA = "0x18566ABC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected IMIAHONOOAG KANFNNMDBCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x566AC00", Offset = "0x5669600", VA = "0x18566AC00")]
		get
		{
			return default(IMIAHONOOAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x656FBD0", Offset = "0x656E5D0", VA = "0x18656FBD0")]
	public BKDMIHLLLMJ(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x656FB30", Offset = "0x656E530", VA = "0x18656FB30")]
	protected KILHMEMGMIO GIFIMDJKANB(IMIAHONOOAG AAKAMGFECAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class JMOHAAOPOOL : BJCIHLLDPNJ
{
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x6581BB0", Offset = "0x65805B0", VA = "0x186581BB0", Slot = "4")]
	public NJDFIEODIDF HGOJPACHALC(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x65815D0", Offset = "0x657FFD0", VA = "0x1865815D0", Slot = "5")]
	public MEJPMIBFJMA BFPAHCJDHPD(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6582080", Offset = "0x6580A80", VA = "0x186582080", Slot = "6")]
	public LBHKGIPFNKF LKMEBGGKIPC(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x6582290", Offset = "0x6580C90", VA = "0x186582290", Slot = "7")]
	public JHLKDBFMMGA NNDODPCCFGB(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x6581A40", Offset = "0x6580440", VA = "0x186581A40", Slot = "8")]
	public AOAMMPDGLJK EMGCEBCBBAI(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6582450", Offset = "0x6580E50", VA = "0x186582450", Slot = "9")]
	public NCPFNNMIHPI PPONOHIGPID(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6582370", Offset = "0x6580D70", VA = "0x186582370", Slot = "10")]
	public PNLNJFAHGEA OACFNGONNLN(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6581F90", Offset = "0x6580990", VA = "0x186581F90", Slot = "11")]
	public JLBMCFCJPPJ KFGFHHMJBFK(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x65816B0", Offset = "0x65800B0", VA = "0x1865816B0", Slot = "12")]
	public IPKFHCMGOAF BJKCMOICJIG(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x6581EB0", Offset = "0x65808B0", VA = "0x186581EB0", Slot = "13")]
	public PMKAALGHPNI JPBPJGKMLNC(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x6581DB0", Offset = "0x65807B0", VA = "0x186581DB0")]
	public MMFMABDKKFC LNABLMPEEKD(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x6581940", Offset = "0x6580340", VA = "0x186581940")]
	public LELJKNLCCBM EKKEHMIMCCO(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x6581790", Offset = "0x6580190", VA = "0x186581790")]
	public BMIDDOIJIOI CAFNJFMEHEB(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x65818D0", Offset = "0x65802D0", VA = "0x1865818D0")]
	public MJBCDJCCJAJ NAOJIDPLABJ(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x6581C10", Offset = "0x6580610", VA = "0x186581C10")]
	public AMKBKDLBHCJ IDDPNOBAJPD(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x6582160", Offset = "0x6580B60", VA = "0x186582160", Slot = "19")]
	public KILHMEMGMIO NEPDGHJGNNP(RigidbodyEx AJJNHIINFFP, PABNOLNKAEE OBAHLGOPPIK, HFDDDAIIHPO FHOCAIDBAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public JMOHAAOPOOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x6581DB0", Offset = "0x65807B0", VA = "0x186581DB0", Slot = "14")]
	private MMFMABDKKFC IHILIMIFBLH(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x6581940", Offset = "0x6580340", VA = "0x186581940", Slot = "15")]
	private LELJKNLCCBM KAEEHPHBCEL(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x6581790", Offset = "0x6580190", VA = "0x186581790", Slot = "16")]
	private BMIDDOIJIOI KJBAKLOFLFB(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x65818D0", Offset = "0x65802D0", VA = "0x1865818D0", Slot = "17")]
	private MJBCDJCCJAJ DIHPGKEEEGF(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x6582070", Offset = "0x6580A70", VA = "0x186582070", Slot = "18")]
	private AMKBKDLBHCJ KOGHOMOKPKA(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DefaultMember("Item")]
public sealed class JKGMGFGICDP : IReadOnlyList<KILHMEMGMIO>, IEnumerable<KILHMEMGMIO>, IEnumerable, IReadOnlyCollection<KILHMEMGMIO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly IMIAHONOOAG AAKAMGFECAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly BBADMEGBCBC JJMPOMPHBIH;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int MDLNLAAIONI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x657D920", Offset = "0x657C320", VA = "0x18657D920", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public KILHMEMGMIO OBNEKGFINAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x657D7D0", Offset = "0x657C1D0", VA = "0x18657D7D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x3EBA840", Offset = "0x3EB9240", VA = "0x183EBA840")]
	public JKGMGFGICDP(IMIAHONOOAG AAKAMGFECAG, BBADMEGBCBC JJMPOMPHBIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x657D6C0", Offset = "0x657C0C0", VA = "0x18657D6C0", Slot = "6")]
	public IEnumerator<KILHMEMGMIO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x657D6C0", Offset = "0x657C0C0", VA = "0x18657D6C0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x657D7D0", Offset = "0x657C1D0", VA = "0x18657D7D0")]
	[CompilerGenerated]
	private KILHMEMGMIO HFIBJJPKCIM(int HLIHAMMEEIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[KHBNPKNGIHN(typeof(BJCIHLLDPNJ), new string[] { })]
public class FLICFBBJBCG : BJCIHLLDPNJ, DKOLEACPDKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly BJCIHLLDPNJ DNEFMKDPPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly BJCIHLLDPNJ IAGENJLCLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HLEGHDEFGID PLEJPFAFEGC;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private BJCIHLLDPNJ PHAHFJGKAED
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x6575DA0", Offset = "0x65747A0", VA = "0x186575DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6576200", Offset = "0x6574C00", VA = "0x186576200", Slot = "20")]
	public void InitReferences(HANNLEINLJM OPLKFNLAKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6576000", Offset = "0x6574A00", VA = "0x186576000", Slot = "4")]
	public NJDFIEODIDF HGOJPACHALC(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6575BB0", Offset = "0x65745B0", VA = "0x186575BB0", Slot = "5")]
	public MEJPMIBFJMA BFPAHCJDHPD(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6576390", Offset = "0x6574D90", VA = "0x186576390", Slot = "6")]
	public LBHKGIPFNKF LKMEBGGKIPC(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6576520", Offset = "0x6574F20", VA = "0x186576520", Slot = "7")]
	public JHLKDBFMMGA NNDODPCCFGB(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x6575F60", Offset = "0x6574960", VA = "0x186575F60", Slot = "8")]
	public AOAMMPDGLJK EMGCEBCBBAI(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6576660", Offset = "0x6575060", VA = "0x186576660", Slot = "9")]
	public NCPFNNMIHPI PPONOHIGPID(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x65765C0", Offset = "0x6574FC0", VA = "0x1865765C0", Slot = "10")]
	public PNLNJFAHGEA OACFNGONNLN(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x65762F0", Offset = "0x6574CF0", VA = "0x1865762F0", Slot = "11")]
	public JLBMCFCJPPJ KFGFHHMJBFK(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6575C50", Offset = "0x6574650", VA = "0x186575C50", Slot = "12")]
	public IPKFHCMGOAF BJKCMOICJIG(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6576250", Offset = "0x6574C50", VA = "0x186576250", Slot = "13")]
	public PMKAALGHPNI JPBPJGKMLNC(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x6576150", Offset = "0x6574B50", VA = "0x186576150")]
	public MMFMABDKKFC LNABLMPEEKD(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6575EB0", Offset = "0x65748B0", VA = "0x186575EB0")]
	public LELJKNLCCBM EKKEHMIMCCO(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6575CF0", Offset = "0x65746F0", VA = "0x186575CF0")]
	public BMIDDOIJIOI CAFNJFMEHEB(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x6575E00", Offset = "0x6574800", VA = "0x186575E00")]
	public MJBCDJCCJAJ NAOJIDPLABJ(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x65760A0", Offset = "0x6574AA0", VA = "0x1865760A0")]
	public AMKBKDLBHCJ IDDPNOBAJPD(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x6576430", Offset = "0x6574E30", VA = "0x186576430", Slot = "19")]
	public KILHMEMGMIO NEPDGHJGNNP(RigidbodyEx AJJNHIINFFP, PABNOLNKAEE OBAHLGOPPIK, HFDDDAIIHPO FHOCAIDBAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x6576700", Offset = "0x6575100", VA = "0x186576700")]
	public FLICFBBJBCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x6576150", Offset = "0x6574B50", VA = "0x186576150", Slot = "14")]
	private MMFMABDKKFC IHILIMIFBLH(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x6575EB0", Offset = "0x65748B0", VA = "0x186575EB0", Slot = "15")]
	private LELJKNLCCBM KAEEHPHBCEL(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x6575CF0", Offset = "0x65746F0", VA = "0x186575CF0", Slot = "16")]
	private BMIDDOIJIOI KJBAKLOFLFB(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x6575E00", Offset = "0x6574800", VA = "0x186575E00", Slot = "17")]
	private MJBCDJCCJAJ DIHPGKEEEGF(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x65760A0", Offset = "0x6574AA0", VA = "0x1865760A0", Slot = "18")]
	private AMKBKDLBHCJ KOGHOMOKPKA(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[UnityEngine.Scripting.Preserve]
public sealed class KFGCOMFHOJC : KILHMEMGMIO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly KFGCOMFHOJC KHPIFBDMEAA;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public Rigidbody AJEBBECNDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public RigidbodyEx FOJOLNIMAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public GameObject EJJIGIIPPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Transform EDLKPFGIAFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public KILHMEMGMIO HOANOOGFEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x79A7B0", Offset = "0x7991B0", VA = "0x18079A7B0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public IReadOnlyList<KILHMEMGMIO> LFJPDEOEFJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x793B30", Offset = "0x792530", VA = "0x180793B30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public KILHMEMGMIO DABPAFAJNAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x793D40", Offset = "0x792740", VA = "0x180793D40", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public bool DMAKBKCDAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x8060A0", Offset = "0x804AA0", VA = "0x1808060A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool FBALNADLPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7D9EC0", Offset = "0x7D88C0", VA = "0x1807D9EC0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public IBFPFLLNHAF JADAAPBCGHM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x78FC90", Offset = "0x78E690", VA = "0x18078FC90", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x78FCA0", Offset = "0x78E6A0", VA = "0x18078FCA0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public OGEJCJLEECF JDNHLOMLHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x78FCC0", Offset = "0x78E6C0", VA = "0x18078FCC0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x78FCD0", Offset = "0x78E6D0", VA = "0x18078FCD0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float LMOJAOMGEEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x9E5140", Offset = "0x9E3B40", VA = "0x1809E5140", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x89EFB0", Offset = "0x89D9B0", VA = "0x18089EFB0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 NCPEOPJCLAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1B21E30", Offset = "0x1B20830", VA = "0x181B21E30", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x364B260", Offset = "0x3649C60", VA = "0x18364B260", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 IKOPJKIPHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x49080D0", Offset = "0x4906AD0", VA = "0x1849080D0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x4906FF0", Offset = "0x49059F0", VA = "0x184906FF0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 CJGIJMHEFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x39E6C80", Offset = "0x39E5680", VA = "0x1839E6C80", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x39E2840", Offset = "0x39E1240", VA = "0x1839E2840", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 HCDCLKKFCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xB1CD30", Offset = "0xB1B730", VA = "0x180B1CD30", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public bool ENJLCAOLEEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x92C8A0", Offset = "0x92B2A0", VA = "0x18092C8A0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool DJBPKHLCKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x176C660", Offset = "0x176B060", VA = "0x18176C660", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool PAGMMGPHAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5E0F6A0", Offset = "0x5E0E0A0", VA = "0x185E0F6A0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 JOKOACMONEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x39E2780", Offset = "0x39E1180", VA = "0x1839E2780", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 POGIDPHBGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x9571B0", Offset = "0x955BB0", VA = "0x1809571B0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 FAINBFHJMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0xB1CD30", Offset = "0xB1B730", VA = "0x180B1CD30", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 OJAFBCGIAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x6582530", Offset = "0x6580F30", VA = "0x186582530", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float JODNLNLNKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1A491C0", Offset = "0x1A47BC0", VA = "0x181A491C0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float FAPOHPCOLIL
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D40", Offset = "0x7E0740", VA = "0x1807E1D40", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 CKDEFCJLFHM
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xB1CD30", Offset = "0xB1B730", VA = "0x180B1CD30", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion JIPHILJPONE
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7E0460", Offset = "0x7DEE60", VA = "0x1807E0460", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float BDBNDEDAAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D40", Offset = "0x7E0740", VA = "0x1807E1D40", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float OOFICFHPLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D40", Offset = "0x7E0740", VA = "0x1807E1D40", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool ILAEENNJICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public DJEILIGJBKK DDEFJFBDGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "48")]
		get
		{
			return default(DJEILIGJBKK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool JCGIPIDHHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0xCC0CE0", Offset = "0xCBF6E0", VA = "0x180CC0CE0", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public Transform GIKHDPPMBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x8F7410", Offset = "0x8F5E10", VA = "0x1808F7410", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Vector3 HHJDGIIEKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0xB1CD30", Offset = "0xB1B730", VA = "0x180B1CD30", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float HBEFDOKACNO
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D40", Offset = "0x7E0740", VA = "0x1807E1D40", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float HAOIBKAOKCB
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7E1D40", Offset = "0x7E0740", VA = "0x1807E1D40", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion LNJJBBKFHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x987890", Offset = "0x986290", VA = "0x180987890", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 CNBDLNEPHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xB1CD30", Offset = "0xB1B730", VA = "0x180B1CD30", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion AHCNHPCACEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x987890", Offset = "0x986290", VA = "0x180987890", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public RigidbodyConstraints ONGIKALHKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78DC20", VA = "0x18078F220", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool HFLMAHEOICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public CollisionDetectionMode CMLEKLAKLFM
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78DC20", VA = "0x18078F220", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public bool KMBJANENHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC380", Offset = "0x8CAD80", VA = "0x1808CC380", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event PLMJOJGAJFH BOEHDHLHDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event PLMJOJGAJFH OAMBIPLMBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event BAMKPCIEPMF HAMJIKFPLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event PLMJOJGAJFH CCLFKILHDNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event PLMJOJGAJFH EJHBHIPPJKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event PLMJOJGAJFH EFCBHNNCGAN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<CPDDDNECHFB, CPDDDNECHFB> OHGEEJKEHNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event PLMJOJGAJFH CJMFCOHIPLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event PLMJOJGAJFH KBAFEACEFMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "41")]
	public void HEAJILGOOGK((Quaternion rot, Vector3 moments) LGMCEMMFMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "71")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "72")]
	public void KKPMFLHMHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "73")]
	public void MCCNPJCCHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "74")]
	public void BBIDCEIAOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "81")]
	public void NPECOABHDEF(KILHMEMGMIO BEEGCHJLJFC, bool OOJFFOBBJFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "84")]
	public void FIAFCEDAHGN(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "85")]
	public void EAOBKKNCNHP(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xB1CD30", Offset = "0xB1B730", VA = "0x180B1CD30", Slot = "86")]
	public Vector3 PDACNOPIGAN(Vector3 EGEFCPMFFFJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xB1CD30", Offset = "0xB1B730", VA = "0x180B1CD30", Slot = "87")]
	public Vector3 BIIFKCAIIHA(Vector3 BFFOOLAMBIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "88")]
	public void GPGJCFADKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "89")]
	public void NILMLKNJAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "90")]
	public void HAEDBJACJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "91")]
	public void MCCNHKLJDLJ(Vector3 MBDDFANMDHG, Vector3 JDOCNMMEPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "92")]
	public void ABIONAOINEN(Vector3 JEAPEJGJLMF, Vector3 OMNPLMFLMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "93")]
	public void JLMNCDBILKL(Vector3 LDLAACBNKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "94")]
	public void AGGCOBHBDOJ(DHPGLPGANNB EPKOBECIBEK, Vector3 KJIJGBOHKPF, float MKKHJDIICOM, float DGABKEGNMEH = 8f, float OFFAEJLJJAN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "95")]
	public void NBFBDEGHLOH(GLAMMEJCNLN NHEGDAIEAAI, Vector3 IIILLOOECBD, float ODLNACAFJEE = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "96")]
	public void KECLKLLLJCG(GLAMMEJCNLN NHEGDAIEAAI, Vector3 KPKKBKKOGOG, float IPEEDIDLNPN = 7f, float BFKJOMIGDBJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xB1CD30", Offset = "0xB1B730", VA = "0x180B1CD30", Slot = "97")]
	public Vector3 JBOCHKECIPN(Vector3 BEEGCHJLJFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xB1CD30", Offset = "0xB1B730", VA = "0x180B1CD30", Slot = "98")]
	public Vector3 AMMFFIMFOFM(Vector3 BEEGCHJLJFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "99")]
	public void OPKNKOBHJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "100")]
	public void JDNEMFPNANJ(KILHMEMGMIO PJFKHGGFLEG, object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "101")]
	public void LFGOAJMEKJP(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "104")]
	public void GCEGFILNODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "105")]
	public void EFFKAAKBLCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "106")]
	public void ADDJEOFAHLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "109")]
	public bool PACBHFODHNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "110")]
	public void JHAJHPKECNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78DC20", VA = "0x18078F220", Slot = "115")]
	public IDisposable AOKIBPAOIKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "116")]
	public void EJDHAFEBCIM(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "117")]
	public void CBOEMBMAEJG(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "118")]
	public void LADLDDLBDFM(object BDAPLOBBPIE, bool IMCAGEPDHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "121")]
	public void GEGLCBNJAHA(Vector3 DFMMIOGMKKL, Quaternion HHDMDNNPAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "122")]
	public void HJMLLONPGKB(Vector3 EBKILOPCAFO, Quaternion LAPNFLAIMAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "123")]
	public bool KOINGAPCINL(float LNNEBGNNLBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "124")]
	public void LFIBPELFMMG(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "125")]
	public void AFKGIMEPEKN(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "126")]
	public void COMENENNGPM(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "127")]
	public void MBPIOIADFBD(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "128")]
	public void DPOHLHMCEDO(Vector3 JAAMGDODLLF, ForceMode AEJDMFGIJOM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "129")]
	public void LBNODMLJGCF(Vector3 JAAMGDODLLF, Vector3 CJONGNPPIAD, ForceMode AEJDMFGIJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "130")]
	public void BOPHHFJIMLM(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "131")]
	public void MCBPNNFPOBE(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x6582550", Offset = "0x6580F50", VA = "0x186582550", Slot = "132")]
	public bool PKEBEHOIHNG(Vector3 NEGLEJJNHEL, [Out] RaycastHit AFJMBFCIKFN, float ECIJIDKCAEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "133")]
	public void JMJOEKEJEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public KFGCOMFHOJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public sealed class HLEKIFJMIMG : MPEOKLPOFLL, JMMLFPJJFBD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	internal IMIAHONOOAG AAKAMGFECAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	internal BBADMEGBCBC IHPNBNDGOGA;

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x6578EC0", Offset = "0x65778C0", VA = "0x186578EC0")]
	public HLEKIFJMIMG(GameObject PKKHAEKNIBL, RigidbodyEx GOMFFLGGNKD, HFDDDAIIHPO FHOCAIDBAPC, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x6578B30", Offset = "0x6577530", VA = "0x186578B30", Slot = "135")]
	protected override void LKPKPNCBDHP(HFDDDAIIHPO FHOCAIDBAPC, PABNOLNKAEE OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x78F220", Offset = "0x78DC20", VA = "0x18078F220", Slot = "141")]
	protected override IDisposable OAAKIBNPNGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x65786D0", Offset = "0x65770D0", VA = "0x1865786D0", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x6578410", Offset = "0x6576E10", VA = "0x186578410", Slot = "142")]
	public void AFPEOOFLIFH(AMJAHPDIMMI PNPIPJDIOOB, AMJAHPDIMMI KLJIIBEOHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x6578A70", Offset = "0x6577470", VA = "0x186578A70", Slot = "143")]
	public void KDHCGJPMJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x6578DA0", Offset = "0x65777A0", VA = "0x186578DA0", Slot = "144")]
	public void PBLONGEJIDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x65784E0", Offset = "0x6576EE0", VA = "0x1865784E0", Slot = "145")]
	public void AMEAMGDDHBF(bool ABJMBKAGLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x6578540", Offset = "0x6576F40", VA = "0x186578540", Slot = "146")]
	public bool BPCLOPGCELP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x6578E60", Offset = "0x6577860", VA = "0x186578E60", Slot = "147")]
	public void PDHGOALDPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "140")]
	protected override void BMCOFIGACGA(RigidbodyEx HNGEGNONPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x6578840", Offset = "0x6577240", VA = "0x186578840")]
	private void FLJLHIEKPOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal static class LIFPHLFCKIL
{
	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x6583D90", Offset = "0x6582790", VA = "0x186583D90")]
	public static MPEOKLPOFLL NAACFDCEJEH(this KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface NJPFFPMGPNC : NJDFIEODIDF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECOOBADFKEJ(KILHMEMGMIO AJJNHIINFFP);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMOMMIPOPEL(KILHMEMGMIO AJJNHIINFFP);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KENKMDKEIJJ(KILHMEMGMIO FBOBLAPMHHK);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HIJAHONBKGC(KILHMEMGMIO FBOBLAPMHHK);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface MCMBBKPNOKN : LBHKGIPFNKF
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	MPDAHJGADKA<KILHMEMGMIO> AEIGHGOCHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	KILHMEMGMIO HIEBMECNAPM
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface CFDEBCCOEAE : MJBCDJCCJAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) AIHFGHOGAOK(Rigidbody DNLMBGGHJFL);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface NMPFMMFLJMO : LELJKNLCCBM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	PhotonView NDNDJLPIPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class HKDDDBPHCOE : IPKFHCMGOAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly MPEOKLPOFLL AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private CollisionDetectionMode LLIHIKHEDEI;

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	private Rigidbody AJEBBECNDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x65716E0", Offset = "0x65700E0", VA = "0x1865716E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public CollisionDetectionMode CMLEKLAKLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x6577E70", Offset = "0x6576870", VA = "0x186577E70", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x6578230", Offset = "0x6576C30", VA = "0x186578230", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x6571730", Offset = "0x6570130", VA = "0x186571730")]
	public HKDDDBPHCOE(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x6577F80", Offset = "0x6576980", VA = "0x186577F80", Slot = "6")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6578090", Offset = "0x6576A90", VA = "0x186578090", Slot = "9")]
	public void EBIELIJIFDB(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x6578400", Offset = "0x6576E00", VA = "0x186578400", Slot = "7")]
	public void PLDOCDAEHHG(bool KNEFJOKKMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x6577E60", Offset = "0x6576860", VA = "0x186577E60", Slot = "8")]
	public void ABKMFOGFPGL(bool KNEFJOKKMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x65782A0", Offset = "0x6576CA0", VA = "0x1865782A0", Slot = "10")]
	public bool PKEBEHOIHNG(Vector3 NEGLEJJNHEL, [Out] RaycastHit AFJMBFCIKFN, float ECIJIDKCAEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x6578110", Offset = "0x6576B10", VA = "0x186578110")]
	private void FFKJILKHHEK(bool KNEFJOKKMJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public sealed class EPOMIECIKGL : NCPFNNMIHPI, IDisposable, NDCKNADOPHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly MPEOKLPOFLL AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private DJEILIGJBKK KHFEJALGGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private MLODEPOBAIH GMHJDCNCCEI;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public DJEILIGJBKK DDEFJFBDGJE
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x6573240", Offset = "0x6571C40", VA = "0x186573240", Slot = "6")]
		get
		{
			return default(DJEILIGJBKK);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x6572D70", Offset = "0x6571770", VA = "0x186572D70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private Transform PAEJIHJOPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6572D50", Offset = "0x6571750", VA = "0x186572D50", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<CPDDDNECHFB, CPDDDNECHFB> OHGEEJKEHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x6573390", Offset = "0x6571D90", VA = "0x186573390", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x6573190", Offset = "0x6571B90", VA = "0x186573190", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6573440", Offset = "0x6571E40", VA = "0x186573440")]
	public EPOMIECIKGL(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6572E40", Offset = "0x6571840", VA = "0x186572E40", Slot = "8")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6573140", Offset = "0x6571B40", VA = "0x186573140", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x1B97D20", Offset = "0x1B96720", VA = "0x181B97D20", Slot = "11")]
	private void KCBPGBJNCHO(CPDDDNECHFB BGBCAFIGCEH, CPDDDNECHFB KOFBLEFJMMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "12")]
	private void CCODMOFGLEO(bool CKILIKCPEIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class DBNPLNNNJNN : JLBMCFCJPPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly MPEOKLPOFLL AJJNHIINFFP;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Rigidbody AJEBBECNDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x65716E0", Offset = "0x65700E0", VA = "0x1865716E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool JCGIPIDHHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x6571690", Offset = "0x6570090", VA = "0x186571690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool CMOGBCADODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x6570AD0", Offset = "0x656F4D0", VA = "0x186570AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private KILHMEMGMIO HOANOOGFEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x6570C90", Offset = "0x656F690", VA = "0x186570C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6571730", Offset = "0x6570130", VA = "0x186571730")]
	public DBNPLNNNJNN(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x6570B30", Offset = "0x656F530", VA = "0x186570B30", Slot = "4")]
	public void DPOHLHMCEDO(Vector3 JAAMGDODLLF, ForceMode AEJDMFGIJOM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x6570F50", Offset = "0x656F950", VA = "0x186570F50")]
	private void JAGJMPLLPHN(Vector3 JAAMGDODLLF, ForceMode AEJDMFGIJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x65711B0", Offset = "0x656FBB0", VA = "0x1865711B0", Slot = "5")]
	public void LBNODMLJGCF(Vector3 JAAMGDODLLF, Vector3 CJONGNPPIAD, ForceMode AEJDMFGIJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x6570970", Offset = "0x656F370", VA = "0x186570970", Slot = "6")]
	public void BOPHHFJIMLM(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x6570CF0", Offset = "0x656F6F0", VA = "0x186570CF0")]
	private void HBGJBALHLJD(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x6571430", Offset = "0x656FE30", VA = "0x186571430", Slot = "7")]
	public void MCBPNNFPOBE(Vector3 KFPNFEDGMFN, ForceMode AEJDMFGIJOM = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class LCMHANFCIFK : PMKAALGHPNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly MPEOKLPOFLL AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool OJHFADHHFGG;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public bool ILAEENNJICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x8113D0", Offset = "0x80FDD0", VA = "0x1808113D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x6583C80", Offset = "0x6582680", VA = "0x186583C80", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x6571730", Offset = "0x6570130", VA = "0x186571730")]
	public LCMHANFCIFK(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x6583C50", Offset = "0x6582650", VA = "0x186583C50", Slot = "6")]
	public void EBIELIJIFDB(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6575B40", Offset = "0x6574540", VA = "0x186575B40", Slot = "7")]
	public void LOKBAEDKGLM(Rigidbody PJMDPLADOJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class FIBLPHEDFFB : NJPFFPMGPNC, NJDFIEODIDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly KILHMEMGMIO AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly List<KILHMEMGMIO> OBBOPKHIMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private KILHMEMGMIO AJBLHMMPNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private KILHMEMGMIO CDMOGOKIPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Transform PBMKOBOMHFL;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private Transform EDLKPFGIAFF
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x65757E0", Offset = "0x65741E0", VA = "0x1865757E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public KILHMEMGMIO HOANOOGFEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x791C70", Offset = "0x790670", VA = "0x180791C70", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6574350", Offset = "0x6572D50", VA = "0x186574350", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public KILHMEMGMIO DABPAFAJNAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x78FCB0", Offset = "0x78E6B0", VA = "0x18078FCB0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public IReadOnlyList<KILHMEMGMIO> LFJPDEOEFJP
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x78FC80", Offset = "0x78E680", VA = "0x18078FC80", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event PLMJOJGAJFH BOEHDHLHDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6574450", Offset = "0x6572E50", VA = "0x186574450", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x6574950", Offset = "0x6573350", VA = "0x186574950", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event PLMJOJGAJFH OAMBIPLMBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x65742B0", Offset = "0x6572CB0", VA = "0x1865742B0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x6574170", Offset = "0x6572B70", VA = "0x186574170", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event BAMKPCIEPMF HAMJIKFPLDP
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x65749F0", Offset = "0x65733F0", VA = "0x1865749F0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x6575740", Offset = "0x6574140", VA = "0x186575740", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action MGMLBJJIMLI
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6574B40", Offset = "0x6573540", VA = "0x186574B40", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6574810", Offset = "0x6573210", VA = "0x186574810", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action HLGPNKDHDJP
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x65748B0", Offset = "0x65732B0", VA = "0x1865748B0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x6575070", Offset = "0x6573A70", VA = "0x186575070", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<KILHMEMGMIO> NIBKBAOPJII
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6573A20", Offset = "0x6572420", VA = "0x186573A20", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x65743A0", Offset = "0x6572DA0", VA = "0x1865743A0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<KILHMEMGMIO> HIOFLJKKBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x6575110", Offset = "0x6573B10", VA = "0x186575110", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x6573AD0", Offset = "0x65724D0", VA = "0x186573AD0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action JGJCDGHHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6573B80", Offset = "0x6572580", VA = "0x186573B80", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x65744F0", Offset = "0x6572EF0", VA = "0x1865744F0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<KILHMEMGMIO> BHHOANKGAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x6574A90", Offset = "0x6573490", VA = "0x186574A90", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x6573C20", Offset = "0x6572620", VA = "0x186573C20", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x6575840", Offset = "0x6574240", VA = "0x186575840")]
	public FIBLPHEDFFB(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x6573FE0", Offset = "0x65729E0", VA = "0x186573FE0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x65751C0", Offset = "0x6573BC0", VA = "0x1865751C0", Slot = "30")]
	public void NPECOABHDEF(KILHMEMGMIO FPOAHANPCBM, bool OOJFFOBBJFE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x6574BE0", Offset = "0x65735E0", VA = "0x186574BE0", Slot = "6")]
	public void KENKMDKEIJJ(KILHMEMGMIO FBOBLAPMHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x6574590", Offset = "0x6572F90", VA = "0x186574590", Slot = "7")]
	public void HIJAHONBKGC(KILHMEMGMIO FBOBLAPMHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x6574080", Offset = "0x6572A80", VA = "0x186574080", Slot = "4")]
	public void ECOOBADFKEJ(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6573CD0", Offset = "0x65726D0", VA = "0x186573CD0", Slot = "5")]
	public void AMOMMIPOPEL(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x6574210", Offset = "0x6572C10", VA = "0x186574210")]
	private void ELBJFHOBCCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x6574360", Offset = "0x6572D60", VA = "0x186574360")]
	private void GMIFIEEALPK(KILHMEMGMIO FBOBLAPMHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x6573D70", Offset = "0x6572770", VA = "0x186573D70")]
	private void BDKEMLIOFBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x6574E50", Offset = "0x6573850", VA = "0x186574E50")]
	private void KJCMLMHPPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x6573EB0", Offset = "0x65728B0", VA = "0x186573EB0")]
	private void CIJGENADADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x6574F80", Offset = "0x6573980", VA = "0x186574F80")]
	[CompilerGenerated]
	private object LCHJHGPGBLA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class MCGBPGCHKGJ
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x6586CC0", Offset = "0x65856C0", VA = "0x186586CC0")]
	public static NJPFFPMGPNC GNPLKPECELJ(this KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class EAPNONNHJEK : MCMBBKPNOKN, LBHKGIPFNKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly MPEOKLPOFLL AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly MPDAHJGADKA<KILHMEMGMIO> GAGKGAMBHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool KIBBANEJICH;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public MPDAHJGADKA<KILHMEMGMIO> AEIGHGOCHBB
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 JOKOACMONEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x6572930", Offset = "0x6571330", VA = "0x186572930", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 POGIDPHBGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x6572700", Offset = "0x6571100", VA = "0x186572700", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private Vector3 CJGIJMHEFKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x6572220", Offset = "0x6570C20", VA = "0x186572220")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public KILHMEMGMIO HIEBMECNAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x6571DE0", Offset = "0x65707E0", VA = "0x186571DE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6572960", Offset = "0x6571360", VA = "0x186572960")]
	public EAPNONNHJEK(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x65728C0", Offset = "0x65712C0", VA = "0x1865728C0", Slot = "8")]
	public void PBFGBIDMJCI(KILHMEMGMIO CDMOGOKIPKH, object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6572310", Offset = "0x6570D10", VA = "0x186572310", Slot = "9")]
	public void KHEJMMOJLPB(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x6572370", Offset = "0x6570D70", VA = "0x186572370")]
	private Vector3 MLPKJBJIHJF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x6571E90", Offset = "0x6570890", VA = "0x186571E90")]
	private void DHNHHGKDAOB(KILHMEMGMIO NPDMANKKHCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class HGKBEPBLMGJ
{
	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x6577DA0", Offset = "0x65767A0", VA = "0x186577DA0")]
	public static MCMBBKPNOKN GLBPPFIANHD(this KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class ALGLFFIBOFK : CFDEBCCOEAE, MJBCDJCCJAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MPEOKLPOFLL AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OverridableVector3 OMGECHBBEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly OverridableVector3 GOOIGCPCPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private float AKKPMFIOHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private float ILAFIEOKEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Vector3 BCKLOGPKMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Vector3? KCGNANNGOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Quaternion? KKCCJIEMMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool EBNPFDOCDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool GMDDGGALLEF;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public Vector3 FAINBFHJMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x1061F90", Offset = "0x1060990", VA = "0x181061F90", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x656CE30", Offset = "0x656B830", VA = "0x18656CE30", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 OJAFBCGIAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x656EAD0", Offset = "0x656D4D0", VA = "0x18656EAD0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public float JODNLNLNKEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x1172E50", Offset = "0x1171850", VA = "0x181172E50", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x656E9C0", Offset = "0x656D3C0", VA = "0x18656E9C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float FAPOHPCOLIL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xBA6F30", Offset = "0xBA5930", VA = "0x180BA6F30", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x656EE00", Offset = "0x656D800", VA = "0x18656EE00", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 CKDEFCJLFHM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x656F440", Offset = "0x656DE40", VA = "0x18656F440", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Quaternion JIPHILJPONE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x656E690", Offset = "0x656D090", VA = "0x18656E690", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	private Rigidbody AJEBBECNDIH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x656F860", Offset = "0x656E260", VA = "0x18656F860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event PLMJOJGAJFH HIDDNLKNBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x656E1F0", Offset = "0x656CBF0", VA = "0x18656E1F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x656E5F0", Offset = "0x656CFF0", VA = "0x18656E5F0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x656F8B0", Offset = "0x656E2B0", VA = "0x18656F8B0")]
	public ALGLFFIBOFK(KILHMEMGMIO AJJNHIINFFP, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x656E810", Offset = "0x656D210", VA = "0x18656E810", Slot = "17")]
	public void GCEGFILNODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x656E510", Offset = "0x656CF10", VA = "0x18656E510", Slot = "16")]
	public void EFFKAAKBLCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x656E430", Offset = "0x656CE30", VA = "0x18656E430", Slot = "19")]
	public void EBIELIJIFDB(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x656F5D0", Offset = "0x656DFD0", VA = "0x18656F5D0", Slot = "20")]
	public void LOKBAEDKGLM(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x656CEE0", Offset = "0x656B8E0", VA = "0x18656CEE0", Slot = "18")]
	public void ADDJEOFAHLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x656EEB0", Offset = "0x656D8B0", VA = "0x18656EEB0", Slot = "21")]
	public void JMJOEKEJEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x656CE30", Offset = "0x656B830", VA = "0x18656CE30")]
	private void OIHBEFDKOOM(Vector3 BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x656F350", Offset = "0x656DD50", VA = "0x18656F350")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 LAILPLECAMA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x656E9C0", Offset = "0x656D3C0", VA = "0x18656E9C0")]
	private void OAKPFEPAEHP(float BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x656EE00", Offset = "0x656D800", VA = "0x18656EE00")]
	private void NIHLIOIGGMK(float BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x656E290", Offset = "0x656CC90", VA = "0x18656E290")]
	private Vector3 DDDCNKAIDED()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x656EBD0", Offset = "0x656D5D0", VA = "0x18656EBD0", Slot = "15")]
	public void HEAJILGOOGK((Quaternion rot, Vector3 moments) LGMCEMMFMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x656E070", Offset = "0x656CA70", VA = "0x18656E070")]
	private Quaternion CCFBLLKDAOO()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x656DFA0", Offset = "0x656C9A0", VA = "0x18656DFA0")]
	public void AIHFGHOGAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x656D050", Offset = "0x656BA50", VA = "0x18656D050", Slot = "4")]
	public (float, Vector3) AIHFGHOGAOK(Rigidbody DNLMBGGHJFL)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class PIMBBGEDCEG
{
	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x6590B40", Offset = "0x658F540", VA = "0x186590B40")]
	public static CFDEBCCOEAE BDDIFHPHCOE(this KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class ACIPAAIKOEH : BMIDDOIJIOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly MPEOKLPOFLL AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly NFHAIGOLJDB PDLKDLAAEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly EMJNKAFCANP KBHGDJPPDJK;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool HONFKFCAIOE
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public EMJNKAFCANP NBLOOFOANDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x8C1570", Offset = "0x8BFF70", VA = "0x1808C1570", Slot = "11")]
		get
		{
			return default(EMJNKAFCANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x656CD30", Offset = "0x656B730", VA = "0x18656CD30")]
	public ACIPAAIKOEH(KILHMEMGMIO AJJNHIINFFP, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x656C880", Offset = "0x656B280", VA = "0x18656C880", Slot = "4")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x656C950", Offset = "0x656B350", VA = "0x18656C950")]
	private bool DGENNHNDEGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x656CCC0", Offset = "0x656B6C0", VA = "0x18656CCC0", Slot = "5")]
	public void OKFIHOBLMIE(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x656C850", Offset = "0x656B250", VA = "0x18656C850", Slot = "6")]
	public void CPHJIJOIAON(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x656C710", Offset = "0x656B110", VA = "0x18656C710", Slot = "9")]
	public void AKBMFAHOGOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x656CBA0", Offset = "0x656B5A0", VA = "0x18656CBA0")]
	private void JFFGCDANHNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x656CA30", Offset = "0x656B430", VA = "0x18656CA30")]
	private void HGBIBBGOMLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x656CCF0", Offset = "0x656B6F0", VA = "0x18656CCF0", Slot = "8")]
	public void OKKKPKBJDDF(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x656C9F0", Offset = "0x656B3F0", VA = "0x18656C9F0", Slot = "7")]
	public void FBOOONHFIDB(KILHMEMGMIO AJJNHIINFFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class IIFOABHMFMB : PNLNJFAHGEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly MPEOKLPOFLL AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly NFHAIGOLJDB JCCNLHEBOBH;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool JCGIPIDHHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x6579320", Offset = "0x6577D20", VA = "0x186579320", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event PLMJOJGAJFH CJMFCOHIPLH
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x6579140", Offset = "0x6577B40", VA = "0x186579140", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x6578F90", Offset = "0x6577990", VA = "0x186578F90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x6579410", Offset = "0x6577E10", VA = "0x186579410")]
	public IIFOABHMFMB(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x6579030", Offset = "0x6577A30", VA = "0x186579030", Slot = "11")]
	public IDisposable AOKIBPAOIKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x6579130", Offset = "0x6577B30", VA = "0x186579130", Slot = "8")]
	public void EJDHAFEBCIM(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x65790A0", Offset = "0x6577AA0", VA = "0x1865790A0", Slot = "9")]
	public void CBOEMBMAEJG(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x65791E0", Offset = "0x6577BE0", VA = "0x1865791E0", Slot = "10")]
	public void LADLDDLBDFM(object BDAPLOBBPIE, bool IMCAGEPDHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x65793D0", Offset = "0x6577DD0", VA = "0x1865793D0", Slot = "6")]
	public void NIMIIKDCJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x65790B0", Offset = "0x6577AB0", VA = "0x1865790B0", Slot = "12")]
	public void EBIELIJIFDB(Rigidbody BHAECPFLHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x65792F0", Offset = "0x6577CF0", VA = "0x1865792F0", Slot = "13")]
	public void LOKBAEDKGLM(Rigidbody PJMDPLADOJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class ONKINCEPKNH : NMPFMMFLJMO, LELJKNLCCBM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly MPEOKLPOFLL AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private PhotonView PLAMGEMMEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool JKBAHLKPDNO;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public PhotonView NDNDJLPIPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool DMAKBKCDAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x6577650", Offset = "0x6576050", VA = "0x186577650", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool FBALNADLPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x87FD70", Offset = "0x87E770", VA = "0x18087FD70", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event PLMJOJGAJFH CCLFKILHDNK
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x6590180", Offset = "0x658EB80", VA = "0x186590180", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x6590220", Offset = "0x658EC20", VA = "0x186590220", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x6590430", Offset = "0x658EE30", VA = "0x186590430")]
	public ONKINCEPKNH(KILHMEMGMIO AJJNHIINFFP, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x658F8A0", Offset = "0x658E2A0", VA = "0x18658F8A0", Slot = "9")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x658F9D0", Offset = "0x658E3D0", VA = "0x18658F9D0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x658FD40", Offset = "0x658E740", VA = "0x18658FD40", Slot = "10")]
	public void HNFKODBGEFO(KILHMEMGMIO CDMOGOKIPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x65902C0", Offset = "0x658ECC0", VA = "0x1865902C0", Slot = "11")]
	public void OLNPEOMEJAG(KILHMEMGMIO CDMOGOKIPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x6590010", Offset = "0x658EA10", VA = "0x186590010")]
	private void JBOLGJFBDMF(PhotonView JMHBFLOPOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x658FEB0", Offset = "0x658E8B0", VA = "0x18658FEB0")]
	private void IPAEKILAHCI(RigidbodyEx HBCFMOJKBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x658FAD0", Offset = "0x658E4D0", VA = "0x18658FAD0")]
	private void EFHPDDCCGOD(PhotonView OBBCOFJJGFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal static class BOFECBEIBGA
{
	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x656FC70", Offset = "0x656E670", VA = "0x18656FC70")]
	public static NMPFMMFLJMO IFJEFICHPGE(this KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class JKFOMDFILHC : AMKBKDLBHCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly MPEOKLPOFLL AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private RigidbodyConstraints IGMMJGKAHGN;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool HFLMAHEOICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xAF6530", Offset = "0xAF4F30", VA = "0x180AF6530", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x3E2EB40", Offset = "0x3E2D540", VA = "0x183E2EB40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool GFICKOHNPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x1B0BBE0", Offset = "0x1B0A5E0", VA = "0x181B0BBE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x3E2EB30", Offset = "0x3E2D530", VA = "0x183E2EB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public RigidbodyConstraints ONGIKALHKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x7977F0", Offset = "0x7961F0", VA = "0x1807977F0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x657D4B0", Offset = "0x657BEB0", VA = "0x18657D4B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x657D610", Offset = "0x657C010", VA = "0x18657D610")]
	public JKFOMDFILHC(KILHMEMGMIO AJJNHIINFFP, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x657D480", Offset = "0x657BE80", VA = "0x18657D480", Slot = "9")]
	public void EBIELIJIFDB(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x657D5E0", Offset = "0x657BFE0", VA = "0x18657D5E0", Slot = "10")]
	public void LOKBAEDKGLM(Rigidbody PJMDPLADOJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class CHKMLHMKBIB : JHLKDBFMMGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly KILHMEMGMIO AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float FDEPLLIFNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float KHENEOLNGLG;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public float BDBNDEDAAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x89F540", Offset = "0x89DF40", VA = "0x18089F540", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x6570730", Offset = "0x656F130", VA = "0x186570730", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float OOFICFHPLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x969BE0", Offset = "0x9685E0", VA = "0x180969BE0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x6570610", Offset = "0x656F010", VA = "0x186570610", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x65708A0", Offset = "0x656F2A0", VA = "0x1865708A0")]
	public CHKMLHMKBIB(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x65706E0", Offset = "0x656F0E0", VA = "0x1865706E0", Slot = "8")]
	public void EBIELIJIFDB(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x6570800", Offset = "0x656F200", VA = "0x186570800", Slot = "9")]
	public void LOKBAEDKGLM(Rigidbody PJMDPLADOJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class KIDPAJDNOPJ : AOAMMPDGLJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly MPEOKLPOFLL AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool KPCLJJNODPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool HCBADNADMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int OEJGGLDEEHL;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private Rigidbody AJEBBECNDIH
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x656F860", Offset = "0x656E260", VA = "0x18656F860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private bool MMALFLALMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x65831F0", Offset = "0x6581BF0", VA = "0x1865831F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private KILHMEMGMIO HOANOOGFEFE
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x6583450", Offset = "0x6581E50", VA = "0x186583450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private bool CMOGBCADODC
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x65832B0", Offset = "0x6581CB0", VA = "0x1865832B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event PLMJOJGAJFH EFCBHNNCGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x65833A0", Offset = "0x6581DA0", VA = "0x1865833A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x6583100", Offset = "0x6581B00", VA = "0x186583100", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x6583BC0", Offset = "0x65825C0", VA = "0x186583BC0")]
	public KIDPAJDNOPJ(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x6583310", Offset = "0x6581D10", VA = "0x186583310", Slot = "6")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x6583440", Offset = "0x6581E40", VA = "0x186583440", Slot = "8")]
	public void GCBAAPLBMPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x65838E0", Offset = "0x65822E0", VA = "0x1865838E0", Slot = "7")]
	public bool PACBHFODHNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x6583210", Offset = "0x6581C10", VA = "0x186583210", Slot = "9")]
	public void BBIDCEIAOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x65834B0", Offset = "0x6581EB0", VA = "0x1865834B0", Slot = "11")]
	public void JHAJHPKECNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x65831A0", Offset = "0x6581BA0", VA = "0x1865831A0", Slot = "12")]
	public void AMEAMGDDHBF(bool ABJMBKAGLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x6583550", Offset = "0x6581F50", VA = "0x186583550", Slot = "10")]
	public void LOGABFIGGEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x6583700", Offset = "0x6582100", VA = "0x186583700")]
	private bool NELAHNKEJOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x6583A30", Offset = "0x6582430", VA = "0x186583A30")]
	private void PIEEMFNJFAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class OIKIPKLDGFE : MMFMABDKKFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly MPEOKLPOFLL AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly NFHAIGOLJDB EOAFGOFOKJH;

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public Rigidbody AJEBBECNDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x790CA0", Offset = "0x78F6A0", VA = "0x180790CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool CMOGBCADODC
	{
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x6570AD0", Offset = "0x656F4D0", VA = "0x186570AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public bool HLCLDNJLLGI
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x658F790", Offset = "0x658E190", VA = "0x18658F790")]
	public OIKIPKLDGFE(KILHMEMGMIO AJJNHIINFFP, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x658E9E0", Offset = "0x658D3E0", VA = "0x18658E9E0", Slot = "5")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x658E800", Offset = "0x658D200", VA = "0x18658E800", Slot = "7")]
	public void COMENENNGPM(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x658EDF0", Offset = "0x658D7F0", VA = "0x18658EDF0", Slot = "8")]
	public void MBPIOIADFBD(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x658EE20", Offset = "0x658D820", VA = "0x18658EE20", Slot = "9")]
	public void NBFGCDEHJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x658EC00", Offset = "0x658D600", VA = "0x18658EC00", Slot = "11")]
	public void FOOIFCELMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x658EA80", Offset = "0x658D480", VA = "0x18658EA80", Slot = "12")]
	public void EAAIJOKHJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x658F300", Offset = "0x658DD00", VA = "0x18658F300", Slot = "10")]
	public void OEFKPKGLMHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x658F150", Offset = "0x658DB50", VA = "0x18658F150")]
	private void NCBBKOEMLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x658E830", Offset = "0x658D230", VA = "0x18658E830")]
	private void DAMFNEAKMNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class MNBAKOBNKII : MEJPMIBFJMA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly MPEOKLPOFLL AJJNHIINFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly NFHAIGOLJDB IBDLPNAODAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float LKPPAMHBCFA;

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public IBFPFLLNHAF JADAAPBCGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x793D30", Offset = "0x792730", VA = "0x180793D30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public OGEJCJLEECF JDNHLOMLHBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x79A7B0", Offset = "0x7991B0", VA = "0x18079A7B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 CJGIJMHEFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x6598960", Offset = "0x6597360", VA = "0x186598960", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x65977D0", Offset = "0x65961D0", VA = "0x1865977D0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 NCPEOPJCLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x6599730", Offset = "0x6598130", VA = "0x186599730", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x6597A60", Offset = "0x6596460", VA = "0x186597A60", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 HCDCLKKFCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x6597890", Offset = "0x6596290", VA = "0x186597890", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x6599DB0", Offset = "0x65987B0", VA = "0x186599DB0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 IKOPJKIPHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x65981D0", Offset = "0x6596BD0", VA = "0x1865981D0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x6598CA0", Offset = "0x65976A0", VA = "0x186598CA0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public float LMOJAOMGEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7E3010", Offset = "0x7E1A10", VA = "0x1807E3010", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x6598A80", Offset = "0x6597480", VA = "0x186598A80", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public bool PAGMMGPHAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x16700E0", Offset = "0x166EAE0", VA = "0x1816700E0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private JLBMCFCJPPJ KEJCJOLNLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x1E6FC30", Offset = "0x1E6E630", VA = "0x181E6FC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private bool MMALFLALMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x657E010", Offset = "0x657CA10", VA = "0x18657E010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x6599FE0", Offset = "0x65989E0", VA = "0x186599FE0")]
	public MNBAKOBNKII(KILHMEMGMIO AJJNHIINFFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x65979B0", Offset = "0x65963B0", VA = "0x1865979B0", Slot = "19")]
	public void DBBCHFMHPJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x6597A90", Offset = "0x6596490", VA = "0x186597A90", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x6597B60", Offset = "0x6596560", VA = "0x186597B60", Slot = "28")]
	public void EBIELIJIFDB(Rigidbody PJMDPLADOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xB11FC0", Offset = "0xB109C0", VA = "0x180B11FC0", Slot = "20")]
	public void BGHFLAIHOFA(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0xB125E0", Offset = "0xB10FE0", VA = "0x180B125E0", Slot = "30")]
	public void CIMFPNNLPIE(object BDAPLOBBPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x6599E70", Offset = "0x6598870", VA = "0x186599E70", Slot = "35")]
	public Vector3 PDACNOPIGAN(Vector3 EGEFCPMFFFJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x6597680", Offset = "0x6596080", VA = "0x186597680", Slot = "34")]
	public Vector3 BIIFKCAIIHA(Vector3 BFFOOLAMBIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x65979B0", Offset = "0x65963B0", VA = "0x1865979B0", Slot = "27")]
	public void GPGJCFADKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x6599AB0", Offset = "0x65984B0", VA = "0x186599AB0", Slot = "25")]
	public void NILMLKNJAPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x65980C0", Offset = "0x6596AC0", VA = "0x1865980C0", Slot = "24")]
	public void HAEDBJACJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x6599590", Offset = "0x6597F90", VA = "0x186599590", Slot = "33")]
	public void MCCNHKLJDLJ(Vector3 MBDDFANMDHG, Vector3 JDOCNMMEPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x6596FF0", Offset = "0x65959F0", VA = "0x186596FF0", Slot = "32")]
	public void ABIONAOINEN(Vector3 JEAPEJGJLMF, Vector3 OMNPLMFLMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x6598B30", Offset = "0x6597530", VA = "0x186598B30", Slot = "31")]
	public void JLMNCDBILKL(Vector3 LDLAACBNKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x6597050", Offset = "0x6595A50", VA = "0x186597050", Slot = "22")]
	public void AGGCOBHBDOJ(DHPGLPGANNB EPKOBECIBEK, Vector3 KJIJGBOHKPF, float MKKHJDIICOM, float DGABKEGNMEH = 8f, float OFFAEJLJJAN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x6599820", Offset = "0x6598220", VA = "0x186599820", Slot = "21")]
	public void NBFBDEGHLOH(GLAMMEJCNLN NHEGDAIEAAI, Vector3 IIILLOOECBD, float ODLNACAFJEE = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x6598DB0", Offset = "0x65977B0", VA = "0x186598DB0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void KECLKLLLJCG(GLAMMEJCNLN NHEGDAIEAAI, Vector3 KPKKBKKOGOG, float IPEEDIDLNPN = 7f, float BFKJOMIGDBJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x6598800", Offset = "0x6597200", VA = "0x186598800", Slot = "29")]
	public Vector3 JBOCHKECIPN(Vector3 FEGCMBDOBNF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x6599C80", Offset = "0x6598680", VA = "0x186599C80", Slot = "26")]
	public void OPKNKOBHJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x6598A80", Offset = "0x6597480", VA = "0x186598A80")]
	private void JLJIFNMIOAG(float BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x6599B10", Offset = "0x6598510", VA = "0x186599B10")]
	private void OFFKCLNMCHB(Vector3 IIILLOOECBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x6598CD0", Offset = "0x65976D0", VA = "0x186598CD0")]
	private Vector3 KDHKPGEFLGC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x65983A0", Offset = "0x6596DA0", VA = "0x1865983A0")]
	private void INPFMAEGJOD(Vector3 BFFOOLAMBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x65982C0", Offset = "0x6596CC0", VA = "0x1865982C0")]
	private Vector3 IFCDEHGJDLN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x6599150", Offset = "0x6597B50", VA = "0x186599150")]
	private void LKACMBFIIDG(Vector3 BEEGCHJLJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x6597C30", Offset = "0x6596630", VA = "0x186597C30")]
	private void FPBGOKPJAOF(Vector3 BFFOOLAMBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x6598120", Offset = "0x6596B20", VA = "0x186598120")]
	private void HFNLIOBBMCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class PCKNGOLLELN : BJCIHLLDPNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x659A370", Offset = "0x6598D70", VA = "0x18659A370", Slot = "4")]
	public NJDFIEODIDF HGOJPACHALC(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x659A080", Offset = "0x6598A80", VA = "0x18659A080", Slot = "5")]
	public MEJPMIBFJMA BFPAHCJDHPD(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x659A570", Offset = "0x6598F70", VA = "0x18659A570", Slot = "6")]
	public LBHKGIPFNKF LKMEBGGKIPC(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x659A680", Offset = "0x6599080", VA = "0x18659A680", Slot = "7")]
	public JHLKDBFMMGA NNDODPCCFGB(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x659A310", Offset = "0x6598D10", VA = "0x18659A310", Slot = "8")]
	public AOAMMPDGLJK EMGCEBCBBAI(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x659A740", Offset = "0x6599140", VA = "0x18659A740", Slot = "9")]
	public NCPFNNMIHPI PPONOHIGPID(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x659A6E0", Offset = "0x65990E0", VA = "0x18659A6E0", Slot = "10")]
	public PNLNJFAHGEA OACFNGONNLN(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x659A510", Offset = "0x6598F10", VA = "0x18659A510", Slot = "11")]
	public JLBMCFCJPPJ KFGFHHMJBFK(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x659A160", Offset = "0x6598B60", VA = "0x18659A160", Slot = "12")]
	public IPKFHCMGOAF BJKCMOICJIG(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x659A4B0", Offset = "0x6598EB0", VA = "0x18659A4B0", Slot = "13")]
	public PMKAALGHPNI JPBPJGKMLNC(KILHMEMGMIO DPFABJBBFIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x659A440", Offset = "0x6598E40", VA = "0x18659A440")]
	public MMFMABDKKFC LNABLMPEEKD(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x659A2A0", Offset = "0x6598CA0", VA = "0x18659A2A0")]
	public LELJKNLCCBM EKKEHMIMCCO(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x659A1C0", Offset = "0x6598BC0", VA = "0x18659A1C0")]
	public BMIDDOIJIOI CAFNJFMEHEB(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x659A230", Offset = "0x6598C30", VA = "0x18659A230")]
	public MJBCDJCCJAJ NAOJIDPLABJ(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x659A3D0", Offset = "0x6598DD0", VA = "0x18659A3D0")]
	public AMKBKDLBHCJ IDDPNOBAJPD(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x659A5D0", Offset = "0x6598FD0", VA = "0x18659A5D0", Slot = "19")]
	public KILHMEMGMIO NEPDGHJGNNP(RigidbodyEx AJJNHIINFFP, PABNOLNKAEE OBAHLGOPPIK, HFDDDAIIHPO FHOCAIDBAPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public PCKNGOLLELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x659A440", Offset = "0x6598E40", VA = "0x18659A440", Slot = "14")]
	private MMFMABDKKFC IHILIMIFBLH(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x659A2A0", Offset = "0x6598CA0", VA = "0x18659A2A0", Slot = "15")]
	private LELJKNLCCBM KAEEHPHBCEL(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x659A1C0", Offset = "0x6598BC0", VA = "0x18659A1C0", Slot = "16")]
	private BMIDDOIJIOI KJBAKLOFLFB(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x659A230", Offset = "0x6598C30", VA = "0x18659A230", Slot = "17")]
	private MJBCDJCCJAJ DIHPGKEEEGF(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x659A3D0", Offset = "0x6598DD0", VA = "0x18659A3D0", Slot = "18")]
	private AMKBKDLBHCJ KOGHOMOKPKA(KILHMEMGMIO DPFABJBBFIB, [In] PABNOLNKAEE OBAHLGOPPIK)
	{
		return null;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : ELEICGBPLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x659A7A0", Offset = "0x65991A0", VA = "0x18659A7A0", Slot = "6")]
		public sealed override void PKKGNKNPCEJ(OCKNAJKJMFD MKEOIOPNPIL)
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
