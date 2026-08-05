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
using RecRoom.Utils.OverridableFields;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : DHLIEKNFJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x66D7970", Offset = "0x66D6570", VA = "0x1866D7970", Slot = "4")]
		public override void FAEDNEGPAEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Rbex_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : PHLPCMENMHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int[] localIndices1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private LDHNJOCMJPB bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private LDHNJOCMJPB bitset1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6098AD0", Offset = "0x60976D0", VA = "0x186098AD0", Slot = "5")]
		public override void BMHMIKCNLDO(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x66E1670", Offset = "0x66E0270", VA = "0x1866E1670")]
		private void CHPLFCKFEKA(ABPDLMJCFLP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x66E17E0", Offset = "0x66E03E0", VA = "0x1866E17E0")]
		private void IINCMBEFNLF(ABPDLMJCFLP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x66E1C10", Offset = "0x66E0810", VA = "0x1866E1C10", Slot = "6")]
		public override void LHKPJBJBOHH(ABPDLMJCFLP registry, [In] DPPIIBFLCBO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "8")]
		public override void CAHAKELCOOI(EJCABKCJHLL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66E1E00", Offset = "0x66E0A00", VA = "0x1866E1E00")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public delegate void NLLFFIABIEF(RigidbodyEx HFDNKDCBJLN);
[Cpp2IlInjected.Token(Token = "0x2000005")]
public delegate void FHKBNIHODPH(RigidbodyEx HFDNKDCBJLN, bool JEGJCOJCDFA = false);
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum OKBDODKFILO
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Reflective,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	FullOverride
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum FKJFOONDHJA
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum PBBDPLGMKGP
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[HPFMEPGDOBP(typeof(LEFGAJLAOJC), new string[] { "Ignore", "Mock" })]
public class DCKJLOJKGEH : LEFGAJLAOJC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PBHPOMFKCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8029C0", Offset = "0x8015C0", VA = "0x1808029C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
	public void OFJGNAHELPD(string JDDBJGCFGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "6")]
	public void JHIPHBILIFH(RigidbodyEx OMNMDMGCEIK, Action ODKDNEPMNIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "7")]
	public LNGAEKLFLOG PGAPFJDODBN(int EDKOHGBAKEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "8")]
	public void DPGMKLMNOKP(Vector3 CIBIPLLPOAM, float JFDFINIEDNE, Color IFKECNAKMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public DCKJLOJKGEH()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly HEENJBKIIAO ELOLNNMOJND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool LIFAABGAIDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private BJMCMIHAOAN EAFKGHPLPIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		[EKKIFMIKPHJ(NNBAHLKNBEN.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[EKKIFMIKPHJ(NNBAHLKNBEN.SelfAndParent, true, false, false)]
		[SerializeField]
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
		private FKJFOONDHJA physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		[SerializeField]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		[SerializeField]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		internal BJMCMIHAOAN GBBJIHOCAIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x66DCAC0", Offset = "0x66DB6C0", VA = "0x1866DCAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<RigidbodyEx> ALKDPFOCKHH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7B7A10", Offset = "0x7B6610", VA = "0x1807B7A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7B79B0", Offset = "0x7B65B0", VA = "0x1807B79B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx HBDOMJFDEMK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x66DED50", Offset = "0x66DD950", VA = "0x1866DED50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx IPIIEHOLADF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x66DECB0", Offset = "0x66DD8B0", VA = "0x1866DECB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx MJOMMKLGFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x66DF970", Offset = "0x66DE570", VA = "0x1866DF970")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x66E0EF0", Offset = "0x66DFAF0", VA = "0x1866E0EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform FJMNCFAILBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7D9CE0", Offset = "0x7D88E0", VA = "0x1807D9CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform BHOBDNLGCEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7D9CE0", Offset = "0x7D88E0", VA = "0x1807D9CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ELFGFCBFNPG MLKMPKEELDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x66DEA70", Offset = "0x66DD670", VA = "0x1866DEA70")]
			get
			{
				return default(ELFGFCBFNPG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x66E06A0", Offset = "0x66DF2A0", VA = "0x1866E06A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AGNNDKKCCPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x66DF000", Offset = "0x66DDC00", VA = "0x1866DF000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool BBGKGDILHOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x66DEB90", Offset = "0x66DD790", VA = "0x1866DEB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JOCDBOPNLKP KEELFKNLNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x66DEF40", Offset = "0x66DDB40", VA = "0x1866DEF40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x66E0860", Offset = "0x66DF460", VA = "0x1866E0860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public PHKIGEHOIKG AHMJAKNHCLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x66DEEE0", Offset = "0x66DDAE0", VA = "0x1866DEEE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x66E07F0", Offset = "0x66DF3F0", VA = "0x1866E07F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool ACLLLEEFMPG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x66DEE30", Offset = "0x66DDA30", VA = "0x1866DEE30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody JBNNJMKLPMN
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x66DEE90", Offset = "0x66DDA90", VA = "0x1866DEE90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool MBOMONLMKPE
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x66DEBF0", Offset = "0x66DD7F0", VA = "0x1866DEBF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x66E0710", Offset = "0x66DF310", VA = "0x1866E0710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool BNGOHFFDCOI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5EA4F70", Offset = "0x5EA3B70", VA = "0x185EA4F70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5EA4D90", Offset = "0x5EA3990", VA = "0x185EA4D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float COOCMODNLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x66DF910", Offset = "0x66DE510", VA = "0x1866DF910")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float IMIDLOBIBCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x66DF8B0", Offset = "0x66DE4B0", VA = "0x1866DF8B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x66E0E80", Offset = "0x66DFA80", VA = "0x1866E0E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float BCMJKEKLFCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x66DF260", Offset = "0x66DDE60", VA = "0x1866DF260")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x66E0B00", Offset = "0x66DF700", VA = "0x1866E0B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float OPCEKLFMMME
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x66DF060", Offset = "0x66DDC60", VA = "0x1866DF060")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x66E08D0", Offset = "0x66DF4D0", VA = "0x1866E08D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool AODPDAGEBMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x66DFED0", Offset = "0x66DEAD0", VA = "0x1866DFED0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x66E1450", Offset = "0x66E0050", VA = "0x1866E1450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 IGOLPHNGHPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x66DF690", Offset = "0x66DE290", VA = "0x1866DF690")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x66E0C50", Offset = "0x66DF850", VA = "0x1866E0C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 CIBIPLLPOAM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x66E0010", Offset = "0x66DEC10", VA = "0x1866E0010")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode KKMEAILGENL
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x66DF1A0", Offset = "0x66DDDA0", VA = "0x1866DF1A0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x66E0A20", Offset = "0x66DF620", VA = "0x1866E0A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float MMDOKNOFEJH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x66DEC50", Offset = "0x66DD850", VA = "0x1866DEC50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x66E0780", Offset = "0x66DF380", VA = "0x1866E0780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints GNOFCBICNBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x66DF200", Offset = "0x66DDE00", VA = "0x1866DF200")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x66E0A90", Offset = "0x66DF690", VA = "0x1866E0A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 GAGKMNHLPIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x66DFA10", Offset = "0x66DE610", VA = "0x1866DFA10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 HOBKKIAAPCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x66DFA10", Offset = "0x66DE610", VA = "0x1866DFA10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x66E1230", Offset = "0x66DFE30", VA = "0x1866E1230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MPLHIABBNCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x66DF770", Offset = "0x66DE370", VA = "0x1866DF770")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x66E0D30", Offset = "0x66DF930", VA = "0x1866E0D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float LEGOINJIMOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x66DFE70", Offset = "0x66DEA70", VA = "0x1866DFE70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x66E13E0", Offset = "0x66DFFE0", VA = "0x1866E13E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion FJCIPDBCMBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x66DFAF0", Offset = "0x66DE6F0", VA = "0x1866DFAF0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x66E0FB0", Offset = "0x66DFBB0", VA = "0x1866E0FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion BFOMIBHJCAG
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x66DFD90", Offset = "0x66DE990", VA = "0x1866DFD90")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x66E1310", Offset = "0x66DFF10", VA = "0x1866E1310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 HBPKLABLICD
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x66DFBD0", Offset = "0x66DE7D0", VA = "0x1866DFBD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x66E1080", Offset = "0x66DFC80", VA = "0x1866E1080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion FOFBLMNLPMD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x66DFCB0", Offset = "0x66DE8B0", VA = "0x1866DFCB0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x66E1160", Offset = "0x66DFD60", VA = "0x1866E1160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 OOFHBPOGMFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x66DFF30", Offset = "0x66DEB30", VA = "0x1866DFF30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x66E14C0", Offset = "0x66E00C0", VA = "0x1866E14C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 ELNPHHHHPEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x66DF7D0", Offset = "0x66DE3D0", VA = "0x1866DF7D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x66E0DA0", Offset = "0x66DF9A0", VA = "0x1866E0DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 DJANAFJPKFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x66DF0C0", Offset = "0x66DDCC0", VA = "0x1866DF0C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x66E0940", Offset = "0x66DF540", VA = "0x1866E0940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 AFNLMPCCDCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x66DF5B0", Offset = "0x66DE1B0", VA = "0x1866DF5B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x66E0B70", Offset = "0x66DF770", VA = "0x1866E0B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 OHKJAEKCMKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x66DF470", Offset = "0x66DE070", VA = "0x1866DF470")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion EHIABHDJGJC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x66DF390", Offset = "0x66DDF90", VA = "0x1866DF390")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 EAHBLAJMJPH
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x66E01D0", Offset = "0x66DEDD0", VA = "0x1866E01D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 BLMCCFGMPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x66E00F0", Offset = "0x66DECF0", VA = "0x1866E00F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool NAHNEHJELAE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x66DF550", Offset = "0x66DE150", VA = "0x1866DF550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IEMEKLGHHPN
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x66DEFA0", Offset = "0x66DDBA0", VA = "0x1866DEFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool IOKHLIKOEDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x66DEB30", Offset = "0x66DD730", VA = "0x1866DEB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool CFGCPDFFMBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x66DEAD0", Offset = "0x66DD6D0", VA = "0x1866DEAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool OEDIAFBDIHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x66DEA10", Offset = "0x66DD610", VA = "0x1866DEA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool JHEPJEEBGGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x66DF2C0", Offset = "0x66DDEC0", VA = "0x1866DF2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool OANKOMELEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x5210DA0", Offset = "0x520F9A0", VA = "0x185210DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event NLLFFIABIEF IOPCEKPGKCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x66DE930", Offset = "0x66DD530", VA = "0x1866DE930")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x66E05C0", Offset = "0x66DF1C0", VA = "0x1866E05C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event FHKBNIHODPH KHJBHCMHPDG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x66DE8C0", Offset = "0x66DD4C0", VA = "0x1866DE8C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x66E0550", Offset = "0x66DF150", VA = "0x1866E0550")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event NLLFFIABIEF PLPIHINPPHH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x66DE620", Offset = "0x66DD220", VA = "0x1866DE620")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x66E02B0", Offset = "0x66DEEB0", VA = "0x1866E02B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event NLLFFIABIEF LFOHMEELELK
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x66DE690", Offset = "0x66DD290", VA = "0x1866DE690")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x66E0320", Offset = "0x66DEF20", VA = "0x1866E0320")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event NLLFFIABIEF BGOGNDOFJCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x66DE7E0", Offset = "0x66DD3E0", VA = "0x1866DE7E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x66E0470", Offset = "0x66DF070", VA = "0x1866E0470")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<FPPFILBLGKN, FPPFILBLGKN> DGGPELGLIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x66DE770", Offset = "0x66DD370", VA = "0x1866DE770")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x66E0400", Offset = "0x66DF000", VA = "0x1866E0400")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event NLLFFIABIEF JMCCNLAIDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x66DE850", Offset = "0x66DD450", VA = "0x1866DE850")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x66E04E0", Offset = "0x66DF0E0", VA = "0x1866E04E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event NLLFFIABIEF JMPBCCGJKKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x66DE9A0", Offset = "0x66DD5A0", VA = "0x1866DE9A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x66E0630", Offset = "0x66DF230", VA = "0x1866E0630")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event NLLFFIABIEF HIIHDDMKOAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x66DE700", Offset = "0x66DD300", VA = "0x1866DE700")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x66E0390", Offset = "0x66DEF90", VA = "0x1866E0390")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B40", Offset = "0x7B1740", VA = "0x1807B2B40")]
		internal void DLBOBFLOJHC(BJMCMIHAOAN GAFLMOIGPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x66DD580", Offset = "0x66DC180", VA = "0x1866DD580")]
		internal void KODNLLLHDAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x66DE340", Offset = "0x66DCF40", VA = "0x1866DE340")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody GBBFFJMHGNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x66DE010", Offset = "0x66DCC10", VA = "0x1866DE010")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) PHCBCMGJCHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x66DCA50", Offset = "0x66DB650", VA = "0x1866DCA50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x66DCAC0", Offset = "0x66DB6C0", VA = "0x1866DCAC0")]
		private BJMCMIHAOAN BBONCAFMCEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x66DCFD0", Offset = "0x66DBBD0", VA = "0x1866DCFD0")]
		private void IKHOBAFCBDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x66DD7E0", Offset = "0x66DC3E0", VA = "0x1866DD7E0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x66DD580", Offset = "0x66DC180", VA = "0x1866DD580")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x66DD780", Offset = "0x66DC380", VA = "0x1866DD780")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x66DD840", Offset = "0x66DC440", VA = "0x1866DD840")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x66DC100", Offset = "0x66DAD00", VA = "0x1866DC100")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object DGPOLLDAHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x66DD8A0", Offset = "0x66DC4A0", VA = "0x1866DD8A0")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object DGPOLLDAHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x66DCD50", Offset = "0x66DB950", VA = "0x1866DCD50")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x66DD720", Offset = "0x66DC320", VA = "0x1866DD720")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x66DE170", Offset = "0x66DCD70", VA = "0x1866DE170")]
		public void SetParent(RigidbodyEx BLKAHBIJBJO, bool JEGJCOJCDFA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x66DDBB0", Offset = "0x66DC7B0", VA = "0x1866DDBB0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x66DD360", Offset = "0x66DBF60", VA = "0x1866DD360")]
		public bool IsRigidbodyAncestor(RigidbodyEx KDOCKBLJCOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x66DD440", Offset = "0x66DC040", VA = "0x1866DD440")]
		public bool IsRigidbodyDescendant(RigidbodyEx NOBELDOHHEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x66DC370", Offset = "0x66DAF70", VA = "0x1866DC370")]
		public void AddInterpolationRestriction(object DGPOLLDAHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x66DD910", Offset = "0x66DC510", VA = "0x1866DD910")]
		public void RemoveInterpolationRestriction(object DGPOLLDAHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x66DCB70", Offset = "0x66DB770", VA = "0x1866DCB70")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x66DC3E0", Offset = "0x66DAFE0", VA = "0x1866DC3E0")]
		public void AddKinematic(object DGPOLLDAHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x66DD980", Offset = "0x66DC580", VA = "0x1866DD980")]
		public void RemoveKinematic(object DGPOLLDAHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x66DE0F0", Offset = "0x66DCCF0", VA = "0x1866DE0F0")]
		public void SetKinematic(object DGPOLLDAHJK, bool BOKIBJHHDGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x66DDF10", Offset = "0x66DCB10", VA = "0x1866DDF10")]
		public void SetDiscontinuousPositionAndRotation(Vector3 LFAJOKFODCI, Quaternion LHKLCGGIEFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x66DDE10", Offset = "0x66DCA10", VA = "0x1866DDE10")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 LPCNBIPOLOL, Quaternion FCMLIKCNDHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x66DCEC0", Offset = "0x66DBAC0", VA = "0x1866DCEC0")]
		public Vector3 GetConstrainedVelocity(Vector3 OOFHBPOGMFI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x66DCDB0", Offset = "0x66DB9B0", VA = "0x1866DCDB0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 DJANAFJPKFF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x66DC280", Offset = "0x66DAE80", VA = "0x1866DC280")]
		public void AddForce(Vector3 FAAGKOCIKOI, ForceMode APJPDPKOFAH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x66DC170", Offset = "0x66DAD70", VA = "0x1866DC170")]
		public void AddForceAtPosition(Vector3 FAAGKOCIKOI, Vector3 GMKEEAOHFFK, ForceMode APJPDPKOFAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x66DC5B0", Offset = "0x66DB1B0", VA = "0x1866DC5B0")]
		public void AddTorque(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x66DC450", Offset = "0x66DB050", VA = "0x1866DC450")]
		public void AddRelativeTorque(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x66DE410", Offset = "0x66DD010", VA = "0x1866DE410")]
		public Vector3 WorldToLocalVelocity(Vector3 PGDJIMHEKKN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x66DD610", Offset = "0x66DC210", VA = "0x1866DD610")]
		public Vector3 LocalToWorldVelocity(Vector3 ELNPHHHHPEK)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x66DCCF0", Offset = "0x66DB8F0", VA = "0x1866DCCF0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x66DCC90", Offset = "0x66DB890", VA = "0x1866DCC90")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x66DCC30", Offset = "0x66DB830", VA = "0x1866DCC30")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x66DCBD0", Offset = "0x66DB7D0", VA = "0x1866DCBD0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x66DDD10", Offset = "0x66DC910", VA = "0x1866DDD10")]
		public void ResetVelocityWorldSpace(Vector3 CHOCCJMBHHH, Vector3 EJADLEACNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x66DDC10", Offset = "0x66DC810", VA = "0x1866DDC10")]
		public void ResetVelocityLocalSpace(Vector3 HGOGJHLOJAG, Vector3 AFNLMPCCDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x66DDAD0", Offset = "0x66DC6D0", VA = "0x1866DDAD0")]
		public void ResetLinearVelocityLocalSpace(Vector3 HGOGJHLOJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x66DE2A0", Offset = "0x66DCEA0", VA = "0x1866DE2A0")]
		public bool SweepTest(Vector3 MPBHICGGLEH, [Out] RaycastHit ILKMOJMGBDO, float BFEIMLNJNAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x66DD520", Offset = "0x66DC120", VA = "0x1866DD520")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x66DE240", Offset = "0x66DCE40", VA = "0x1866DE240")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x66DE3B0", Offset = "0x66DCFB0", VA = "0x1866DE3B0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x66DC540", Offset = "0x66DB140", VA = "0x1866DC540")]
		public void AddShouldHaveUnityRigidbodyToken(object DGPOLLDAHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x66DD9F0", Offset = "0x66DC5F0", VA = "0x1866DD9F0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object DGPOLLDAHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x66DC8E0", Offset = "0x66DB4E0", VA = "0x1866DC8E0")]
		public void ApplyForceVelocityChange(OKBDODKFILO BICEJGPIEBJ, Vector3 CHDBCKHPDAC, float HILHKLHIOBI, float BJCAFEBCJFP = 8f, float DGBAKIODNPH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x66DC840", Offset = "0x66DB440", VA = "0x1866DC840")]
		public void ApplyAngularVelocityChange(PBBDPLGMKGP EAMPALLILCJ, Vector3 JNAHKEMOGDI, float ONMFMGGNEAA = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x66DC9A0", Offset = "0x66DB5A0", VA = "0x1866DC9A0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(PBBDPLGMKGP EAMPALLILCJ, Vector3 MJCNDCDLGEO, float IGJFENCFNAC = 7f, float EBNGHIMKDLA = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x66DC770", Offset = "0x66DB370", VA = "0x1866DC770")]
		public bool AllowedScaleChange(float MHDIGCPHMNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x66DC6A0", Offset = "0x66DB2A0", VA = "0x1866DC6A0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx AHJIAKNPKHM, object DGPOLLDAHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x66DDA60", Offset = "0x66DC660", VA = "0x1866DDA60")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object DGPOLLDAHJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x66DE5B0", Offset = "0x66DD1B0", VA = "0x1866DE5B0")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class KEBIENBMIND
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x66D2630", Offset = "0x66D1230", VA = "0x1866D2630")]
	public static BJMCMIHAOAN GBBJIHOCAIH(this RigidbodyEx OMNMDMGCEIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct EHBKKADJPIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Rigidbody FDMOAPCLJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public PhotonView PLFOOMNCGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OverridableVector3 ODMOIAIAIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OverridableVector3 CMAODNIPGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public FKJFOONDHJA NLNFNBHBJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool MGPFCGOKOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public bool ICCJBBMNIHH;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[HPFMEPGDOBP(typeof(MPKNHBEKGNG), new string[] { })]
public class NJPBLMLOAFP : MPKNHBEKGNG, CODHFNHPPCE
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly HEENJBKIIAO BNEDOBBKLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private HIJFPNHKCCA CKIFFKIJBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private LEFGAJLAOJC FOHLLAJCPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private GNFINNJDICD HKEELDLDHDN;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LEFGAJLAOJC KOIOJGFJDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public GNFINNJDICD PINJBHJCBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x66D81D0", Offset = "0x66D6DD0", VA = "0x1866D81D0", Slot = "8")]
	public void InitReferences(FEPHIFPIELB CNNJJGDOONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x66D83D0", Offset = "0x66D6FD0", VA = "0x1866D83D0", Slot = "6")]
	public BEKECMPFECE NLFAHMMPKIO(RigidbodyEx OMNMDMGCEIK)
	{
		return default(BEKECMPFECE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x66D8300", Offset = "0x66D6F00", VA = "0x1866D8300")]
	private static BEKECMPFECE NKIJPGENPHH(RigidbodyEx OMNMDMGCEIK)
	{
		return default(BEKECMPFECE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x66D8260", Offset = "0x66D6E60", VA = "0x1866D8260", Slot = "7")]
	public BJMCMIHAOAN JGALJMINGIM(RigidbodyEx OMNMDMGCEIK, EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public NJPBLMLOAFP()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static GPEAFMNAGCL UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int IKACAPANDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int KJNOMHMMMKG;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x66DBF60", Offset = "0x66DAB60", VA = "0x1866DBF60")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x66DBFA0", Offset = "0x66DABA0", VA = "0x1866DBFA0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x66DBF80", Offset = "0x66DAB80", VA = "0x1866DBF80")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string COECLHOAJJF, [Optional] UnityEngine.Object LAMCDJBBCDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string COECLHOAJJF, [Optional] UnityEngine.Object LAMCDJBBCDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x66DC0B0", Offset = "0x66DACB0", VA = "0x1866DC0B0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JIEFKHEDKBL
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x66D0D00", Offset = "0x66CF900", VA = "0x1866D0D00")]
	public static void ODKCFKMKNLL(this Rigidbody GBBFFJMHGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x66D0E90", Offset = "0x66CFA90", VA = "0x1866D0E90")]
	public static void ODKCFKMKNLL(this Rigidbody GBBFFJMHGNH, Vector3 ECLKCBIAPHE, Quaternion EHIABHDJGJC, Vector3 EDDBPIGNHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xCB3050", Offset = "0xCB1C50", VA = "0x180CB3050")]
	public static void ABHHBIIDPNC(Vector3 OOFHBPOGMFI, Vector3 JJMOIFJMOBF, [Out] Vector3 DPMMPBFLODM, [Out] Vector3 GOHOGMNJKBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NJLBOJBHCPC
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class NIIOOLPMMOI : JOCDBOPNLKP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C0990", Offset = "0x7BF590", VA = "0x1807C0990", Slot = "4")]
		public Vector3 BDPCMAHNJFE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C0990", Offset = "0x7BF590", VA = "0x1807C0990", Slot = "5")]
		public Vector3 HBLDNODAMHI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public NIIOOLPMMOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static JOCDBOPNLKP GAIAMCKEPNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x66D8100", Offset = "0x66D6D00", VA = "0x1866D8100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface FEOCOJKJPGH
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode DMODODGADMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GOCGJIABMDK();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LAEGHJBMOJD(bool NAHNEHJELAE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GEDOJIHBLPM(bool NAHNEHJELAE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LBEOKIABJGF(Rigidbody FDMOAPCLJOG);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DCFJJMBHNNG(Vector3 MPBHICGGLEH, [Out] RaycastHit ILKMOJMGBDO, float BFEIMLNJNAB);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface LBDNMDIBBEK : IDisposable, NMBBICMEIBB
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	LFBHMICPMPL MLKMPKEELDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<FPPFILBLGKN, FPPFILBLGKN> DGGPELGLIHK;

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GOCGJIABMDK();
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DGEMLDNOGCP(KHAPMDLCPBB.Application)]
public interface GNFINNJDICD
{
	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KHBLGBAHCDC FIHBJAEJMIC(BJMCMIHAOAN GAFLMOIGPJD);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KGOHGPCLOMC FJCEJBNAOHM(BJMCMIHAOAN GAFLMOIGPJD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LIFEPKGIJHF FCOKFHHNMKK(BJMCMIHAOAN GAFLMOIGPJD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NKDKDJKKDLP CAHEIIHONKJ(BJMCMIHAOAN GAFLMOIGPJD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OKKFBLIHGAN JMBAAHGKDJN(BJMCMIHAOAN GAFLMOIGPJD);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LBDNMDIBBEK FPPIFHEFKDB(BJMCMIHAOAN GAFLMOIGPJD);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GPFIHEKHKME KCOPDHKOBMK(BJMCMIHAOAN GAFLMOIGPJD);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FLHJNAPHMKL HPFOOCLDOCD(BJMCMIHAOAN GAFLMOIGPJD);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FEOCOJKJPGH JNAJMEOLADF(BJMCMIHAOAN GAFLMOIGPJD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BAKCDMGFCKN BBCFHECHEII(BJMCMIHAOAN GAFLMOIGPJD);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HIOMHBCLCIE LOKJCDDFHNC(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IJHFOBCIDEN GGHDNPDHFGC(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PJLBFHKEOMI GIPILBKDLLM(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IEFANOFLFDI OAFOCPLIIFN(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GMCAOMHAHAD LFGFMELKLEI(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BJMCMIHAOAN JGALJMINGIM(RigidbodyEx OMNMDMGCEIK, EHBKKADJPIG KOMCCCIEHEA, MPKNHBEKGNG DFCFBMIMDHA);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FLHJNAPHMKL
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEKCKHOHLEN(Vector3 FAAGKOCIKOI, ForceMode APJPDPKOFAH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LOPMGOIKGAN(Vector3 FAAGKOCIKOI, Vector3 GMKEEAOHFFK, ForceMode APJPDPKOFAH);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MLLIELJKFDC(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LLDFNJABFEJ(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BAKCDMGFCKN
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool CINNBCIONHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBEOKIABJGF(Rigidbody FDMOAPCLJOG);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KHBLGBAHCDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<BJMCMIHAOAN> CBLLDOJBFCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	BJMCMIHAOAN IPIIEHOLADF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	BJMCMIHAOAN CJONHGOLKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event NLLFFIABIEF PLPIHINPPHH;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event NLLFFIABIEF LFOHMEELELK;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event FHKBNIHODPH HIGJPPLHPAD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action LBBNIJAFOOH;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action FFFHPAFIMOJ;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<BJMCMIHAOAN> AHLFODDIILP;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<BJMCMIHAOAN> PPGHOHDENCI;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action EFHPEOPMBIJ;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<BJMCMIHAOAN> BFBOIPFFKDF;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FEJIDBPIKMP(BJMCMIHAOAN AECJKOCMHDK, bool JEGJCOJCDFA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface LIFEPKGIJHF
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 EBLMFDDKEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 BPGKAIAAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HLHELKEJELJ(BJMCMIHAOAN MJOMMKLGFIJ, object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NJOMKBNAFEE(object DGPOLLDAHJK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IEFANOFLFDI
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 FFAIGCMHHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 NJDJDHGKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float EALFMGEJGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float LNLNCOJKKNM
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 DCBBNGOJMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion CCNLEEGECMA
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event NLLFFIABIEF BDOLGLIKOIO;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MKPKKJBFLAP((Quaternion rot, Vector3 moments) PHCBCMGJCHC);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OBMGJNIIIPL();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LOMMBILMFCD();

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void MPIALNGEOOH();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LBEOKIABJGF(Rigidbody FDMOAPCLJOG);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KDIAFPNPNCE();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface PJLBFHKEOMI
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOCGJIABMDK();

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIDEKIMPGII(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FFCHECPMLEK(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GIKFGDBFEHG(BJMCMIHAOAN OMNMDMGCEIK);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NFCMHAJHKJH(BJMCMIHAOAN OMNMDMGCEIK);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OFPBNNJNPHB();
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface GPFIHEKHKME
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool EEAIMLBNNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event NLLFFIABIEF DFNDIMKGOEG;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GHNGEKOPJOO();

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PFEGJBEENME(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MAKEADALNME(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IPLFOIJIMBL(object DGPOLLDAHJK, bool BOKIBJHHDGI);

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IDisposable AAMDLDDLNIP();

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LBEOKIABJGF(Rigidbody GNCJKDNCDJM);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface IJHFOBCIDEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool AGNNDKKCCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool BBGKGDILHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event NLLFFIABIEF GDGOEKNFDHA;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GOCGJIABMDK();

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HNCCJHLGDOF(BJMCMIHAOAN MJOMMKLGFIJ);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KGABCPDDKIA(BJMCMIHAOAN MJOMMKLGFIJ);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GMCAOMHAHAD
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool MBOMONLMKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool OGGPAJCGJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints NGEGICHGBFL
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LBEOKIABJGF(Rigidbody FDMOAPCLJOG);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NKDKDJKKDLP
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float MJBPKJIDMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float EELNPMMHMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LBEOKIABJGF(Rigidbody FDMOAPCLJOG);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface BGJIOCMPOMD
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx PABLLHEENPI);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OKKFBLIHGAN
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event NLLFFIABIEF BKKENEHPLMN;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GOCGJIABMDK();

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MLEHCIAKPAH();

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGBCADPLEDK();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DEGHNDEPLGN();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EFOHCLEMCPN();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BHAJNCDJOHC();

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DNFILLAAEDE(bool JNMAPFFBLPC);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HIOMHBCLCIE
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody JBNNJMKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool OPLHEKEKKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GOCGJIABMDK();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IFHAEHKJMPK(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHAGBMILJCD(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABBBMNACDBP();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NGHDAPBNNBI();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KGOHGPCLOMC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	JOCDBOPNLKP KEELFKNLNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	PHKIGEHOIKG AHMJAKNHCLH
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 MPFFLKOCICM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 MHHLEAKFCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 FNHDGMNMDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 FMDMJBJGMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float MMDOKNOFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool ACLLLEEFMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GOCGJIABMDK();

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MBGJOPKMLPM(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OHNKGGFPMAD(PBBDPLGMKGP EAMPALLILCJ, Vector3 JNAHKEMOGDI, float ONMFMGGNEAA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void JFFHPELHLNL(OKBDODKFILO BICEJGPIEBJ, Vector3 CHDBCKHPDAC, float HILHKLHIOBI, float BJCAFEBCJFP = 8f, float DGBAKIODNPH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FFFIALHGPFH(PBBDPLGMKGP EAMPALLILCJ, Vector3 MJCNDCDLGEO, float IGJFENCFNAC = 7f, float EBNGHIMKDLA = 1f);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HHFEJJICKNM();

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KCIHBLIKEJG();

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DBPPBOGEOKJ();

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void PPNICGFLMEE();

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LBEOKIABJGF(Rigidbody FDMOAPCLJOG);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 IDPCMNKLDGF(Vector3 OOFHBPOGMFI);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void IDJDBPAHAFK(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IFBCAPKEMMP(Vector3 HOMOCIAEAOI);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NNGOMJJFEEG(Vector3 HGOGJHLOJAG, Vector3 AFNLMPCCDCB);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FOKPFHFGFAM(Vector3 CHOCCJMBHHH, Vector3 EJADLEACNNP);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 HFGBPGIKACE(Vector3 ELNPHHHHPEK);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 CDBKINCADHG(Vector3 PGDJIMHEKKN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DGEMLDNOGCP(KHAPMDLCPBB.Application)]
public interface LEFGAJLAOJC
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool PBHPOMFKCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFJGNAHELPD(string JDDBJGCFGMI);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHIPHBILIFH(RigidbodyEx OMNMDMGCEIK, Action ODKDNEPMNIA);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LNGAEKLFLOG PGAPFJDODBN(int EDKOHGBAKEE);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DPGMKLMNOKP(Vector3 CIBIPLLPOAM, float JFDFINIEDNE, Color IFKECNAKMLM);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DGEMLDNOGCP(KHAPMDLCPBB.Application)]
public interface MPKNHBEKGNG
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	LEFGAJLAOJC KOIOJGFJDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	GNFINNJDICD PINJBHJCBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BEKECMPFECE NLFAHMMPKIO(RigidbodyEx OMNMDMGCEIK);

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BJMCMIHAOAN JGALJMINGIM(RigidbodyEx OMNMDMGCEIK, EHBKKADJPIG KOMCCCIEHEA);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PHKIGEHOIKG
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HGGNHOIPJPC(Vector3 OGJHIPLEDOM);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALGINOCAIKH(Vector3 DJANAFJPKFF);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IDDKBKBAPFB(Vector3 OGJHIPLEDOM);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PKOOGAFPEGN(Vector3 DJANAFJPKFF);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface JOCDBOPNLKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 BDPCMAHNJFE();

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 HBLDNODAMHI();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface BJMCMIHAOAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	Rigidbody JBNNJMKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	RigidbodyEx NLDADHGCFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	GameObject JPLPKEPDGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	Transform OAKAFONNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	BJMCMIHAOAN CJONHGOLKBM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	IReadOnlyList<BJMCMIHAOAN> CBLLDOJBFCA
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	BJMCMIHAOAN IPIIEHOLADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	bool AGNNDKKCCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	bool BBGKGDILHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	JOCDBOPNLKP KEELFKNLNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	PHKIGEHOIKG AHMJAKNHCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	float MMDOKNOFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	Vector3 MHHLEAKFCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	Vector3 FMDMJBJGMIL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	Vector3 MPFFLKOCICM
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	Vector3 FNHDGMNMDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool CFGCPDFFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool OEDIAFBDIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	bool ACLLLEEFMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	Vector3 EBLMFDDKEBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	Vector3 BPGKAIAAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	Vector3 FFAIGCMHHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	Vector3 NJDJDHGKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	float EALFMGEJGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float LNLNCOJKKNM
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	Vector3 DCBBNGOJMKA
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Quaternion CCNLEEGECMA
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	float MJBPKJIDMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	float EELNPMMHMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool CINNBCIONHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	LFBHMICPMPL MLKMPKEELDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	bool EEAIMLBNNGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Transform BHOBDNLGCEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Vector3 NENGMJCMOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	float HALBHNAEBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "51")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	float FKFDJAKAOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	Quaternion AOJJKMGFBBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	Vector3 ADMMPHIELJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Quaternion IMKNHDNNIAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	RigidbodyConstraints NGEGICHGBFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	bool MBOMONLMKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	CollisionDetectionMode DMODODGADMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool IEMEKLGHHPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event NLLFFIABIEF PLPIHINPPHH;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event NLLFFIABIEF LFOHMEELELK;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event FHKBNIHODPH HIGJPPLHPAD;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event NLLFFIABIEF GDGOEKNFDHA;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event NLLFFIABIEF BGOGNDOFJCI;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event NLLFFIABIEF BKKENEHPLMN;

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<FPPFILBLGKN, FPPFILBLGKN> DGGPELGLIHK;

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event NLLFFIABIEF DFNDIMKGOEG;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event NLLFFIABIEF HIIHDDMKOAF;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void MKPKKJBFLAP((Quaternion rot, Vector3 moments) PHCBCMGJCHC);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "67")]
	void GOCGJIABMDK();

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void HMDHBDDGMPA();

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void HGKKBPFOMEM();

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void DEGHNDEPLGN();

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void FEJIDBPIKMP(BJMCMIHAOAN BLKAHBIJBJO, bool JEGJCOJCDFA = false);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void HCEMOLFIFCE(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void AEIFOHKLMDD(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "82")]
	Vector3 CDBKINCADHG(Vector3 PGDJIMHEKKN);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "83")]
	Vector3 HFGBPGIKACE(Vector3 ELNPHHHHPEK);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void PPNICGFLMEE();

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void KCIHBLIKEJG();

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "86")]
	void HHFEJJICKNM();

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "87")]
	void FOKPFHFGFAM(Vector3 CHOCCJMBHHH, Vector3 EJADLEACNNP);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void NNGOMJJFEEG(Vector3 HGOGJHLOJAG, Vector3 AFNLMPCCDCB);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void IFBCAPKEMMP(Vector3 HOMOCIAEAOI);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void JFFHPELHLNL(OKBDODKFILO BICEJGPIEBJ, Vector3 CHDBCKHPDAC, float HILHKLHIOBI, float BJCAFEBCJFP = 8f, float DGBAKIODNPH = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void OHNKGGFPMAD(PBBDPLGMKGP EAMPALLILCJ, Vector3 JNAHKEMOGDI, float ONMFMGGNEAA = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void FFFIALHGPFH(PBBDPLGMKGP EAMPALLILCJ, Vector3 MJCNDCDLGEO, float IGJFENCFNAC = 7f, float EBNGHIMKDLA = 1f);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "93")]
	Vector3 IDPCMNKLDGF(Vector3 BLKAHBIJBJO);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "94")]
	Vector3 PDHHGJIIIBF(Vector3 BLKAHBIJBJO);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void DBPPBOGEOKJ();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void MMNLFEKADFO(BJMCMIHAOAN AHJIAKNPKHM, object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "97")]
	void PMFNHJBKAJF(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void LOMMBILMFCD();

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void OBMGJNIIIPL();

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "102")]
	void MPIALNGEOOH();

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "105")]
	bool MLEHCIAKPAH();

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void BHAJNCDJOHC();

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "111")]
	IDisposable AAMDLDDLNIP();

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "112")]
	void PFEGJBEENME(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "113")]
	void MAKEADALNME(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "114")]
	void IPLFOIJIMBL(object DGPOLLDAHJK, bool BOKIBJHHDGI);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void DNGIMDPHALM(Vector3 LFAJOKFODCI, Quaternion LHKLCGGIEFH);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void DMBPOEDHNAJ(Vector3 LPCNBIPOLOL, Quaternion FCMLIKCNDHL);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "119")]
	bool EJFLAFIJOEA(float MHDIGCPHMNA);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "120")]
	void JPCIIFGJAJP(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void MNFCEFOPKHM(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void IFHAEHKJMPK(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "123")]
	void KHAGBMILJCD(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void CEKCKHOHLEN(Vector3 FAAGKOCIKOI, ForceMode APJPDPKOFAH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void LOPMGOIKGAN(Vector3 FAAGKOCIKOI, Vector3 GMKEEAOHFFK, ForceMode APJPDPKOFAH);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void MLLIELJKFDC(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void LLDFNJABFEJ(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "128")]
	bool DCFJJMBHNNG(Vector3 MPBHICGGLEH, [Out] RaycastHit ILKMOJMGBDO, float BFEIMLNJNAB);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void KDIAFPNPNCE();
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class GJAKNCPMCGH : BJMCMIHAOAN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal readonly MPKNHBEKGNG DFCFBMIMDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	internal KHBLGBAHCDC PAMDJEAMGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal PJLBFHKEOMI IIIAJMDNJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal IJHFOBCIDEN DMIFDBFMGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal KGOHGPCLOMC OOFHBPOGMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal LIFEPKGIJHF LOHFPMAIPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal IEFANOFLFDI KFCBHICAADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal NKDKDJKKDLP EGOKPJAPLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal BAKCDMGFCKN GIGDGCFLHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal OKKFBLIHGAN LOGCBCKIBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal LBDNMDIBBEK BJBIDPIJINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal GPFIHEKHKME LPFDCCPODIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal FLHJNAPHMKL FAAGKOCIKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal GMCAOMHAHAD JBOIEKCFGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal HIOMHBCLCIE FDMOAPCLJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal FEOCOJKJPGH OHJOJKAGOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal IDisposable MDJECINJGBH;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public RigidbodyEx NLDADHGCFJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B1630", Offset = "0x7B0230", VA = "0x1807B1630", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B16E0", Offset = "0x7B02E0", VA = "0x1807B16E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public GameObject JPLPKEPDGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x878330", Offset = "0x876F30", VA = "0x180878330", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x878450", Offset = "0x877050", VA = "0x180878450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Transform OAKAFONNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x66C3030", Offset = "0x66C1C30", VA = "0x1866C3030", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public Rigidbody JBNNJMKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x66C4DA0", Offset = "0x66C39A0", VA = "0x1866C4DA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public BJMCMIHAOAN CJONHGOLKBM
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x66C69F0", Offset = "0x66C55F0", VA = "0x1866C69F0", Slot = "8")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x66C2C10", Offset = "0x66C1810", VA = "0x1866C2C10", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IReadOnlyList<BJMCMIHAOAN> CBLLDOJBFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x66C7DC0", Offset = "0x66C69C0", VA = "0x1866C7DC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public BJMCMIHAOAN IPIIEHOLADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x66C7C30", Offset = "0x66C6830", VA = "0x1866C7C30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool KJDIINNFMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x66C5700", Offset = "0x66C4300", VA = "0x1866C5700", Slot = "137")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool AGNNDKKCCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x66C30C0", Offset = "0x66C1CC0", VA = "0x1866C30C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool BBGKGDILHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x66C5DF0", Offset = "0x66C49F0", VA = "0x1866C5DF0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public JOCDBOPNLKP KEELFKNLNDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x66C6500", Offset = "0x66C5100", VA = "0x1866C6500", Slot = "14")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x66C5E40", Offset = "0x66C4A40", VA = "0x1866C5E40", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public PHKIGEHOIKG AHMJAKNHCLH
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x66C7640", Offset = "0x66C6240", VA = "0x1866C7640", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x66C2C70", Offset = "0x66C1870", VA = "0x1866C2C70", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public float MMDOKNOFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x66C4600", Offset = "0x66C3200", VA = "0x1866C4600", Slot = "18")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x66C3F60", Offset = "0x66C2B60", VA = "0x1866C3F60", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public Vector3 MHHLEAKFCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x66C7C80", Offset = "0x66C6880", VA = "0x1866C7C80", Slot = "20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x66C43A0", Offset = "0x66C2FA0", VA = "0x1866C43A0", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public Vector3 FMDMJBJGMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x66C62B0", Offset = "0x66C4EB0", VA = "0x1866C62B0", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x66C6E70", Offset = "0x66C5A70", VA = "0x1866C6E70", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public Vector3 MPFFLKOCICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x66C28A0", Offset = "0x66C14A0", VA = "0x1866C28A0", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x66C26E0", Offset = "0x66C12E0", VA = "0x1866C26E0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Vector3 FNHDGMNMDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x66C7320", Offset = "0x66C5F20", VA = "0x1866C7320", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x66C5620", Offset = "0x66C4220", VA = "0x1866C5620", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool IOKHLIKOEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x66C2370", Offset = "0x66C0F70", VA = "0x1866C2370", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool CFGCPDFFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x66C2080", Offset = "0x66C0C80", VA = "0x1866C2080", Slot = "28")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool OEDIAFBDIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x66C5D10", Offset = "0x66C4910", VA = "0x1866C5D10", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool ACLLLEEFMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x66C6040", Offset = "0x66C4C40", VA = "0x1866C6040", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public Vector3 EBLMFDDKEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x66C2D30", Offset = "0x66C1930", VA = "0x1866C2D30", Slot = "31")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 BPGKAIAAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x66C4FD0", Offset = "0x66C3BD0", VA = "0x1866C4FD0", Slot = "32")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 FFAIGCMHHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x66C4070", Offset = "0x66C2C70", VA = "0x1866C4070", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x66C6550", Offset = "0x66C5150", VA = "0x1866C6550", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 NJDJDHGKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x66C4BE0", Offset = "0x66C37E0", VA = "0x1866C4BE0", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public float EALFMGEJGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x66C5350", Offset = "0x66C3F50", VA = "0x1866C5350", Slot = "36")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public float LNLNCOJKKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x66C2BC0", Offset = "0x66C17C0", VA = "0x1866C2BC0", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x66C3C80", Offset = "0x66C2880", VA = "0x1866C3C80", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 DCBBNGOJMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x66C41B0", Offset = "0x66C2DB0", VA = "0x1866C41B0", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Quaternion CCNLEEGECMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x66C6F50", Offset = "0x66C5B50", VA = "0x1866C6F50", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float MJBPKJIDMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x66C6E20", Offset = "0x66C5A20", VA = "0x1866C6E20", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x66C4F70", Offset = "0x66C3B70", VA = "0x1866C4F70", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float EELNPMMHMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x66C5900", Offset = "0x66C4500", VA = "0x1866C5900", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x66C2200", Offset = "0x66C0E00", VA = "0x1866C2200", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool CINNBCIONHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x66C53A0", Offset = "0x66C3FA0", VA = "0x1866C53A0", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x66C4150", Offset = "0x66C2D50", VA = "0x1866C4150", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public LFBHMICPMPL MLKMPKEELDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x66C5540", Offset = "0x66C4140", VA = "0x1866C5540", Slot = "48")]
		get
		{
			return default(LFBHMICPMPL);
		}
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x66C25D0", Offset = "0x66C11D0", VA = "0x1866C25D0", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool EEAIMLBNNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x66C2EA0", Offset = "0x66C1AA0", VA = "0x1866C2EA0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Transform BHOBDNLGCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x66C4CE0", Offset = "0x66C38E0", VA = "0x1866C4CE0", Slot = "51")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public Vector3 NENGMJCMOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x66C3FC0", Offset = "0x66C2BC0", VA = "0x1866C3FC0", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x66C35D0", Offset = "0x66C21D0", VA = "0x1866C35D0", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public float HALBHNAEBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x66C54C0", Offset = "0x66C40C0", VA = "0x1866C54C0", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x66C72B0", Offset = "0x66C5EB0", VA = "0x1866C72B0", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public float FKFDJAKAOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x66C4380", Offset = "0x66C2F80", VA = "0x1866C4380", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x66C7690", Offset = "0x66C6290", VA = "0x1866C7690", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public Quaternion AOJJKMGFBBF
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x66C7200", Offset = "0x66C5E00", VA = "0x1866C7200", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x66C7890", Offset = "0x66C6490", VA = "0x1866C7890", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public Vector3 ADMMPHIELJP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x66C69A0", Offset = "0x66C55A0", VA = "0x1866C69A0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x66C55D0", Offset = "0x66C41D0", VA = "0x1866C55D0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Quaternion IMKNHDNNIAC
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x66C34C0", Offset = "0x66C20C0", VA = "0x1866C34C0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x66C5590", Offset = "0x66C4190", VA = "0x1866C5590", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints NGEGICHGBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x66C6D70", Offset = "0x66C5970", VA = "0x1866C6D70", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x66C2CD0", Offset = "0x66C18D0", VA = "0x1866C2CD0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool MBOMONLMKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x66C39B0", Offset = "0x66C25B0", VA = "0x1866C39B0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x66C2A80", Offset = "0x66C1680", VA = "0x1866C2A80", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public CollisionDetectionMode DMODODGADMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x66C59B0", Offset = "0x66C45B0", VA = "0x1866C59B0", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x66C5EA0", Offset = "0x66C4AA0", VA = "0x1866C5EA0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool KNNEIIAHPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x66C5A00", Offset = "0x66C4600", VA = "0x1866C5A00", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool IEMEKLGHHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x66C4480", Offset = "0x66C3080", VA = "0x1866C4480", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool HDPDNCPCEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x66C1FE0", Offset = "0x66C0BE0", VA = "0x1866C1FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool OIHGPNIIPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x66C5820", Offset = "0x66C4420", VA = "0x1866C5820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event NLLFFIABIEF PLPIHINPPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x66C6DC0", Offset = "0x66C59C0", VA = "0x1866C6DC0", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x66C54E0", Offset = "0x66C40E0", VA = "0x1866C54E0", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event NLLFFIABIEF LFOHMEELELK
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x66C4CF0", Offset = "0x66C38F0", VA = "0x1866C4CF0", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x66C53F0", Offset = "0x66C3FF0", VA = "0x1866C53F0", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event FHKBNIHODPH HIGJPPLHPAD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x66C2520", Offset = "0x66C1120", VA = "0x1866C2520", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x66C23C0", Offset = "0x66C0FC0", VA = "0x1866C23C0", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event NLLFFIABIEF GDGOEKNFDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x66C75E0", Offset = "0x66C61E0", VA = "0x1866C75E0", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x66C50B0", Offset = "0x66C3CB0", VA = "0x1866C50B0", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event NLLFFIABIEF BGOGNDOFJCI
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x66C4DF0", Offset = "0x66C39F0", VA = "0x1866C4DF0", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x66C3C20", Offset = "0x66C2820", VA = "0x1866C3C20", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event NLLFFIABIEF BKKENEHPLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x66C2140", Offset = "0x66C0D40", VA = "0x1866C2140", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x66C5F00", Offset = "0x66C4B00", VA = "0x1866C5F00", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<FPPFILBLGKN, FPPFILBLGKN> DGGPELGLIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x66C3260", Offset = "0x66C1E60", VA = "0x1866C3260", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x66C21A0", Offset = "0x66C0DA0", VA = "0x1866C21A0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event NLLFFIABIEF DFNDIMKGOEG
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x66C6090", Offset = "0x66C4C90", VA = "0x1866C6090", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x66C7BD0", Offset = "0x66C67D0", VA = "0x1866C7BD0", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event NLLFFIABIEF HIIHDDMKOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x66C5850", Offset = "0x66C4450", VA = "0x1866C5850", Slot = "119")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x66C2630", Offset = "0x66C1230", VA = "0x1866C2630", Slot = "120")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x66C7E50", Offset = "0x66C6A50", VA = "0x1866C7E50")]
	public GJAKNCPMCGH(GameObject DNJHAKIPIPL, RigidbodyEx HFJEOIFFIDL, MPKNHBEKGNG DFCFBMIMDHA, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x66C4650", Offset = "0x66C3250", VA = "0x1866C4650", Slot = "135")]
	protected virtual void GJGPGGHDADE(MPKNHBEKGNG DFCFBMIMDHA, EHBKKADJPIG KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x66C3500", Offset = "0x66C2100", VA = "0x1866C3500", Slot = "136")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x66C4940", Offset = "0x66C3540", VA = "0x1866C4940", Slot = "71")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x66C4E50", Offset = "0x66C3A50", VA = "0x1866C4E50", Slot = "72")]
	public void HMDHBDDGMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x66C4CC0", Offset = "0x66C38C0", VA = "0x1866C4CC0", Slot = "73")]
	public void HGKKBPFOMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x66C3CE0", Offset = "0x66C28E0", VA = "0x1866C3CE0")]
	private void FDKIGCMLLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x66C3D90", Offset = "0x66C2990", VA = "0x1866C3D90", Slot = "81")]
	public void FEJIDBPIKMP(BJMCMIHAOAN BLKAHBIJBJO, bool JEGJCOJCDFA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x66C4A80", Offset = "0x66C3680", VA = "0x1866C4A80", Slot = "84")]
	public void HCEMOLFIFCE(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x66C20E0", Offset = "0x66C0CE0", VA = "0x1866C20E0", Slot = "85")]
	public void AEIFOHKLMDD(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x66C2980", Offset = "0x66C1580", VA = "0x1866C2980", Slot = "86")]
	public Vector3 CDBKINCADHG(Vector3 PGDJIMHEKKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x66C4AE0", Offset = "0x66C36E0", VA = "0x1866C4AE0", Slot = "87")]
	public Vector3 HFGBPGIKACE(Vector3 ELNPHHHHPEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x66C4E50", Offset = "0x66C3A50", VA = "0x1866C4E50", Slot = "88")]
	public void PPNICGFLMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x66C5B40", Offset = "0x66C4740", VA = "0x1866C5B40", Slot = "89")]
	public void KCIHBLIKEJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x66C4D50", Offset = "0x66C3950", VA = "0x1866C4D50", Slot = "90")]
	public void HHFEJJICKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x66C4290", Offset = "0x66C2E90", VA = "0x1866C4290", Slot = "91")]
	public void FOKPFHFGFAM(Vector3 CHOCCJMBHHH, Vector3 EJADLEACNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x66C7020", Offset = "0x66C5C20", VA = "0x1866C7020", Slot = "92")]
	public void NNGOMJJFEEG(Vector3 HGOGJHLOJAG, Vector3 AFNLMPCCDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x66C5210", Offset = "0x66C3E10", VA = "0x1866C5210", Slot = "93")]
	public void IFBCAPKEMMP(Vector3 HOMOCIAEAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x66C5760", Offset = "0x66C4360", VA = "0x1866C5760", Slot = "94")]
	public void JFFHPELHLNL(OKBDODKFILO BICEJGPIEBJ, Vector3 CHDBCKHPDAC, float HILHKLHIOBI, float BJCAFEBCJFP = 8f, float DGBAKIODNPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x66C7160", Offset = "0x66C5D60", VA = "0x1866C7160", Slot = "95")]
	public void OHNKGGFPMAD(PBBDPLGMKGP EAMPALLILCJ, Vector3 JNAHKEMOGDI, float ONMFMGGNEAA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x66C3E00", Offset = "0x66C2A00", VA = "0x1866C3E00", Slot = "96")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void FFFIALHGPFH(PBBDPLGMKGP EAMPALLILCJ, Vector3 MJCNDCDLGEO, float IGJFENCFNAC = 7f, float EBNGHIMKDLA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x66C5110", Offset = "0x66C3D10", VA = "0x1866C5110", Slot = "97")]
	public Vector3 IDPCMNKLDGF(Vector3 BLKAHBIJBJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x66C7790", Offset = "0x66C6390", VA = "0x1866C7790", Slot = "98")]
	public Vector3 PDHHGJIIIBF(Vector3 BLKAHBIJBJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x66C2EF0", Offset = "0x66C1AF0", VA = "0x1866C2EF0", Slot = "99")]
	public void DBPPBOGEOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x66C6C50", Offset = "0x66C5850", VA = "0x1866C6C50", Slot = "100")]
	public void MMNLFEKADFO(BJMCMIHAOAN AHJIAKNPKHM, object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x66C7D60", Offset = "0x66C6960", VA = "0x1866C7D60", Slot = "101")]
	public void PMFNHJBKAJF(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x66C6A40", Offset = "0x66C5640", VA = "0x1866C6A40", Slot = "41")]
	public void MKPKKJBFLAP((Quaternion rot, Vector3 moments) PHCBCMGJCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x66C6260", Offset = "0x66C4E60", VA = "0x1866C6260", Slot = "104")]
	public void LOMMBILMFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x66C7110", Offset = "0x66C5D10", VA = "0x1866C7110", Slot = "105")]
	public void OBMGJNIIIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x66C6D20", Offset = "0x66C5920", VA = "0x1866C6D20", Slot = "106")]
	public void MPIALNGEOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x66C6B20", Offset = "0x66C5720", VA = "0x1866C6B20", Slot = "109")]
	public bool MLEHCIAKPAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x66C2FE0", Offset = "0x66C1BE0", VA = "0x1866C2FE0", Slot = "74")]
	public void DEGHNDEPLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x66C2580", Offset = "0x66C1180", VA = "0x1866C2580", Slot = "110")]
	public void BHAJNCDJOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x66C1F90", Offset = "0x66C0B90", VA = "0x1866C1F90", Slot = "115")]
	public IDisposable AAMDLDDLNIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x66C7980", Offset = "0x66C6580", VA = "0x1866C7980", Slot = "116")]
	public void PFEGJBEENME(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x66C64A0", Offset = "0x66C50A0", VA = "0x1866C64A0", Slot = "117")]
	public void MAKEADALNME(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x66C5450", Offset = "0x66C4050", VA = "0x1866C5450", Slot = "118")]
	public void IPLFOIJIMBL(object DGPOLLDAHJK, bool BOKIBJHHDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x66C32C0", Offset = "0x66C1EC0", VA = "0x1866C32C0", Slot = "121")]
	public void DNGIMDPHALM(Vector3 LFAJOKFODCI, Quaternion LHKLCGGIEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x66C3110", Offset = "0x66C1D10", VA = "0x1866C3110", Slot = "122")]
	public void DMBPOEDHNAJ(Vector3 LPCNBIPOLOL, Quaternion FCMLIKCNDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x66C3A00", Offset = "0x66C2600", VA = "0x1866C3A00", Slot = "123")]
	public bool EJFLAFIJOEA(float MHDIGCPHMNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x66C5950", Offset = "0x66C4550", VA = "0x1866C5950", Slot = "124")]
	public void JPCIIFGJAJP(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x66C6CC0", Offset = "0x66C58C0", VA = "0x1866C6CC0", Slot = "125")]
	public void MNFCEFOPKHM(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x66C52F0", Offset = "0x66C3EF0", VA = "0x1866C52F0", Slot = "126")]
	public void IFHAEHKJMPK(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x66C5CB0", Offset = "0x66C48B0", VA = "0x1866C5CB0", Slot = "127")]
	public void KHAGBMILJCD(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x66C2AE0", Offset = "0x66C16E0", VA = "0x1866C2AE0", Slot = "128")]
	public void CEKCKHOHLEN(Vector3 FAAGKOCIKOI, ForceMode APJPDPKOFAH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x66C6390", Offset = "0x66C4F90", VA = "0x1866C6390", Slot = "129")]
	public void LOPMGOIKGAN(Vector3 FAAGKOCIKOI, Vector3 GMKEEAOHFFK, ForceMode APJPDPKOFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x66C6B70", Offset = "0x66C5770", VA = "0x1866C6B70", Slot = "130")]
	public void MLLIELJKFDC(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x66C5F60", Offset = "0x66C4B60", VA = "0x1866C5F60", Slot = "131")]
	public void LLDFNJABFEJ(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x66C2F40", Offset = "0x66C1B40", VA = "0x1866C2F40", Slot = "132")]
	public bool DCFJJMBHNNG(Vector3 MPBHICGGLEH, [Out] RaycastHit ILKMOJMGBDO, float BFEIMLNJNAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x66C5B90", Offset = "0x66C4790", VA = "0x1866C5B90", Slot = "133")]
	public void KDIAFPNPNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x66C7E10", Offset = "0x66C6A10", VA = "0x1866C7E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x66C27C0", Offset = "0x66C13C0", VA = "0x1866C27C0")]
	private void BKKMDBDEGMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x66C2260", Offset = "0x66C0E60", VA = "0x1866C2260")]
	private void AONCFHEOLJC(BJMCMIHAOAN MJOMMKLGFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x66C79E0", Offset = "0x66C65E0", VA = "0x1866C79E0")]
	private void PGJCFGEGGJN(BJMCMIHAOAN MJOMMKLGFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x66C3EB0", Offset = "0x66C2AB0", VA = "0x1866C3EB0")]
	private void FGBBCEKDDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x66C2420", Offset = "0x66C1020", VA = "0x1866C2420")]
	private void BCHIIOMEJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x66C7400", Offset = "0x66C6000", VA = "0x1866C7400")]
	private void OKGLIJBJDCI(BJMCMIHAOAN IDPPDAEHKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x66C4EA0", Offset = "0x66C3AA0", VA = "0x1866C4EA0")]
	private void HNCCJHLGDOF(BJMCMIHAOAN MJOMMKLGFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x66C5BE0", Offset = "0x66C47E0", VA = "0x1866C5BE0")]
	private void KGABCPDDKIA(BJMCMIHAOAN MJOMMKLGFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x66C60F0", Offset = "0x66C4CF0", VA = "0x1866C60F0")]
	private void LNCGOMPEHKI(RigidbodyEx MJOMMKLGFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x66C3A60", Offset = "0x66C2660", VA = "0x1866C3A60", Slot = "140")]
	protected virtual void EJGLCFONGFP(RigidbodyEx OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x66C3690", Offset = "0x66C2290", VA = "0x1866C3690")]
	protected void EEBBEFFOCBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x66C6630", Offset = "0x66C5230", VA = "0x1866C6630")]
	protected void MGLBGOIBHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x66C2E00", Offset = "0x66C1A00", VA = "0x1866C2E00", Slot = "141")]
	protected virtual IDisposable CLJAMAIKGME()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class OLIDDFCOFJD
{
	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x66DAF10", Offset = "0x66D9B10", VA = "0x1866DAF10")]
	public static BJMCMIHAOAN MKGCNALADAO(this BJMCMIHAOAN OMNMDMGCEIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x66DB010", Offset = "0x66D9C10", VA = "0x1866DB010")]
	public static bool NMJOBEAOJGD(this BJMCMIHAOAN OMNMDMGCEIK, BJMCMIHAOAN KDOCKBLJCOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x66DAE10", Offset = "0x66D9A10", VA = "0x1866DAE10")]
	public static bool IEPHEIBDMEE(this BJMCMIHAOAN OMNMDMGCEIK, BJMCMIHAOAN NOBELDOHHEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x66DAFC0", Offset = "0x66D9BC0", VA = "0x1866DAFC0")]
	public static RigidbodyEx NLDADHGCFJO(this BJMCMIHAOAN GBBJIHOCAIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x66DAE90", Offset = "0x66D9A90", VA = "0x1866DAE90")]
	public static GJAKNCPMCGH MENMMMLEKIN(this BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal class AEEAKABJPLB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly GJAKNCPMCGH OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool KLIIIEHJHJF;

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x66BA8F0", Offset = "0x66B94F0", VA = "0x1866BA8F0")]
	public AEEAKABJPLB(GJAKNCPMCGH GOHLFLJBMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x66BA890", Offset = "0x66B9490", VA = "0x1866BA890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal sealed class OIMDCMGOBFI : DDCDPIBPACO, FEOCOJKJPGH
{
	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CollisionDetectionMode HEKIMPCBPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x66DAB90", Offset = "0x66D9790", VA = "0x1866DAB90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x66DADA0", Offset = "0x66D99A0", VA = "0x1866DADA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private Rigidbody JBNNJMKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x66BC5D0", Offset = "0x66BB1D0", VA = "0x1866BC5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CollisionDetectionMode DMODODGADMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x66DAA80", Offset = "0x66D9680", VA = "0x1866DAA80", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x66DABF0", Offset = "0x66D97F0", VA = "0x1866DABF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x66BECA0", Offset = "0x66BD8A0", VA = "0x1866BECA0")]
	public OIMDCMGOBFI(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x66DA930", Offset = "0x66D9530", VA = "0x1866DA930", Slot = "6")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x66DACC0", Offset = "0x66D98C0", VA = "0x1866DACC0", Slot = "9")]
	public void LBEOKIABJGF(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x66DACB0", Offset = "0x66D98B0", VA = "0x1866DACB0", Slot = "7")]
	public void LAEGHJBMOJD(bool NAHNEHJELAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x66DA920", Offset = "0x66D9520", VA = "0x1866DA920", Slot = "8")]
	public void GEDOJIHBLPM(bool NAHNEHJELAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x66DA7C0", Offset = "0x66D93C0", VA = "0x1866DA7C0", Slot = "10")]
	public bool DCFJJMBHNNG(Vector3 MPBHICGGLEH, [Out] RaycastHit ILKMOJMGBDO, float BFEIMLNJNAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x66DA650", Offset = "0x66D9250", VA = "0x1866DA650")]
	private void AJLOKILDMOM(bool NAHNEHJELAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class DCLAAAEIGNA : DDCDPIBPACO, LBDNMDIBBEK, IDisposable, NMBBICMEIBB
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public LFBHMICPMPL GJJAJMFKNFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x66BF6F0", Offset = "0x66BE2F0", VA = "0x1866BF6F0")]
		get
		{
			return default(LFBHMICPMPL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x66BF350", Offset = "0x66BDF50", VA = "0x1866BF350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public LFBHMICPMPL MLKMPKEELDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x66BF4F0", Offset = "0x66BE0F0", VA = "0x1866BF4F0", Slot = "6")]
		get
		{
			return default(LFBHMICPMPL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x66BF350", Offset = "0x66BDF50", VA = "0x1866BF350", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private Transform MDFPGPIKJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event Action<FPPFILBLGKN, FPPFILBLGKN> DGGPELGLIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x66BF440", Offset = "0x66BE040", VA = "0x1866BF440", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x66BF2A0", Offset = "0x66BDEA0", VA = "0x1866BF2A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x66BECA0", Offset = "0x66BD8A0", VA = "0x1866BECA0")]
	public DCLAAAEIGNA(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x66BF7D0", Offset = "0x66BE3D0", VA = "0x1866BF7D0", Slot = "11")]
	public void OnChangedDistanceBand(FPPFILBLGKN BCGMNFKKHHA, FPPFILBLGKN EBCOJIOCDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "12")]
	public void OnChangedVisibility(bool JFOEBCKJLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "8")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class GBLABPGONNM : DDCDPIBPACO, FLHJNAPHMKL
{
	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private Rigidbody JBNNJMKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x66BC5D0", Offset = "0x66BB1D0", VA = "0x1866BC5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private bool EEAIMLBNNGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x66BC580", Offset = "0x66BB180", VA = "0x1866BC580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private bool KJDIINNFMHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x66BC620", Offset = "0x66BB220", VA = "0x1866BC620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private BJMCMIHAOAN CJONHGOLKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x66C13F0", Offset = "0x66BFFF0", VA = "0x1866C13F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x66BECA0", Offset = "0x66BD8A0", VA = "0x1866BECA0")]
	public GBLABPGONNM(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x66C0AD0", Offset = "0x66BF6D0", VA = "0x1866C0AD0", Slot = "4")]
	public void CEKCKHOHLEN(Vector3 FAAGKOCIKOI, ForceMode APJPDPKOFAH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x66C0C30", Offset = "0x66BF830", VA = "0x1866C0C30")]
	private void KIDIDNNGMCK(Vector3 FAAGKOCIKOI, ForceMode APJPDPKOFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x66C1170", Offset = "0x66BFD70", VA = "0x1866C1170", Slot = "5")]
	public void LOPMGOIKGAN(Vector3 FAAGKOCIKOI, Vector3 GMKEEAOHFFK, ForceMode APJPDPKOFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x66C1450", Offset = "0x66C0050", VA = "0x1866C1450", Slot = "6")]
	public void MLLIELJKFDC(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x66C15B0", Offset = "0x66C01B0", VA = "0x1866C15B0")]
	private void OJOKJLKEKNO(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x66C0F10", Offset = "0x66BFB10", VA = "0x1866C0F10", Slot = "7")]
	public void LLDFNJABFEJ(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x66C09F0", Offset = "0x66BF5F0", VA = "0x1866C09F0")]
	private void AGKNLPHAFKB(string COECLHOAJJF, UnityEngine.Object LAMCDJBBCDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class DBJOMCADAFN : DDCDPIBPACO, BAKCDMGFCKN
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool CINNBCIONHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x66BF140", Offset = "0x66BDD40", VA = "0x1866BF140", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x66BEFF0", Offset = "0x66BDBF0", VA = "0x1866BEFF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x66BECA0", Offset = "0x66BD8A0", VA = "0x1866BECA0")]
	public DBJOMCADAFN(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x66BF1A0", Offset = "0x66BDDA0", VA = "0x1866BF1A0", Slot = "6")]
	public void LBEOKIABJGF(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x66BF230", Offset = "0x66BDE30", VA = "0x1866BF230", Slot = "7")]
	public void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class GNGCFIGNAMM : DDCDPIBPACO, KHBLGBAHCDC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly HEENJBKIIAO JOHOMNJJMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly COHDNAIOOFG MOIKBPMBBLG;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private Transform OAKAFONNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x66C9000", Offset = "0x66C7C00", VA = "0x1866C9000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public BEKECMPFECE PGBJNIEDENL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x66C9430", Offset = "0x66C8030", VA = "0x1866C9430")]
		get
		{
			return default(BEKECMPFECE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x66CA580", Offset = "0x66C9180", VA = "0x1866CA580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public BJMCMIHAOAN CJONHGOLKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x66C9EA0", Offset = "0x66C8AA0", VA = "0x1866C9EA0", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x66C8F30", Offset = "0x66C7B30", VA = "0x1866C8F30", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public BEKECMPFECE KCNFIKAAPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x66C8FA0", Offset = "0x66C7BA0", VA = "0x1866C8FA0")]
		get
		{
			return default(BEKECMPFECE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x66C9E30", Offset = "0x66C8A30", VA = "0x1866C9E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public BJMCMIHAOAN IPIIEHOLADF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x66CA740", Offset = "0x66C9340", VA = "0x1866CA740", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IReadOnlyList<BJMCMIHAOAN> CBLLDOJBFCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A10", Offset = "0x7B6610", VA = "0x1807B7A10", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event NLLFFIABIEF PLPIHINPPHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x66CA430", Offset = "0x66C9030", VA = "0x1866CA430", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x66C98D0", Offset = "0x66C84D0", VA = "0x1866C98D0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event NLLFFIABIEF LFOHMEELELK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x66C9790", Offset = "0x66C8390", VA = "0x1866C9790", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x66C9830", Offset = "0x66C8430", VA = "0x1866C9830", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event FHKBNIHODPH HIGJPPLHPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x66C8C90", Offset = "0x66C7890", VA = "0x1866C8C90", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x66C8BF0", Offset = "0x66C77F0", VA = "0x1866C8BF0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event Action LBBNIJAFOOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x66C9C50", Offset = "0x66C8850", VA = "0x1866C9C50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x66C9A60", Offset = "0x66C8660", VA = "0x1866C9A60", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event Action FFFHPAFIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x66CA5F0", Offset = "0x66C91F0", VA = "0x1866CA5F0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x66C9160", Offset = "0x66C7D60", VA = "0x1866C9160", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event Action<BJMCMIHAOAN> AHLFODDIILP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x66C96E0", Offset = "0x66C82E0", VA = "0x1866C96E0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x66CA7B0", Offset = "0x66C93B0", VA = "0x1866CA7B0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<BJMCMIHAOAN> PPGHOHDENCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x66C9B00", Offset = "0x66C8700", VA = "0x1866C9B00", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x66CA4D0", Offset = "0x66C90D0", VA = "0x1866CA4D0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event Action EFHPEOPMBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x66C9CF0", Offset = "0x66C88F0", VA = "0x1866C9CF0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x66C9D90", Offset = "0x66C8990", VA = "0x1866C9D90", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event Action<BJMCMIHAOAN> BFBOIPFFKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x66CA690", Offset = "0x66C9290", VA = "0x1866CA690", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x66C9200", Offset = "0x66C7E00", VA = "0x1866C9200", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x66CA8F0", Offset = "0x66C94F0", VA = "0x1866CA8F0")]
	public GNGCFIGNAMM(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x66C9030", Offset = "0x66C7C30", VA = "0x1866C9030", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x66C9300", Offset = "0x66C7F00", VA = "0x1866C9300", Slot = "26")]
	public void FEJIDBPIKMP(BJMCMIHAOAN AECJKOCMHDK, bool JEGJCOJCDFA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x66C92B0", Offset = "0x66C7EB0", VA = "0x1866C92B0")]
	private void FEJIDBPIKMP(HKDNNMALKIB AECJKOCMHDK, bool JEGJCOJCDFA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x66C9F10", Offset = "0x66C8B10", VA = "0x1866C9F10")]
	private void NAOMNIIAANH(HKDNNMALKIB AECJKOCMHDK, bool JEGJCOJCDFA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x66C9490", Offset = "0x66C8090", VA = "0x1866C9490")]
	private void FOOLJALPMFI(HKDNNMALKIB IDPPDAEHKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x66C8D30", Offset = "0x66C7930", VA = "0x1866C8D30")]
	private void BLBECBCGGNH(HKDNNMALKIB IDPPDAEHKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x66C8A10", Offset = "0x66C7610", VA = "0x1866C8A10")]
	private void ACLBDBEAGAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x66C9380", Offset = "0x66C7F80", VA = "0x1866C9380")]
	private void FHGDHHDDFEH(HKDNNMALKIB IDPPDAEHKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x66C9970", Offset = "0x66C8570", VA = "0x1866C9970")]
	private void JDMGIJBPIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x66C9BB0", Offset = "0x66C87B0", VA = "0x1866C9BB0")]
	private void KBPDEGGFOIC(HKDNNMALKIB OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x66CA390", Offset = "0x66C8F90", VA = "0x1866CA390")]
	private void NFKLPPDDJIP(HKDNNMALKIB OMNMDMGCEIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class LAKCEOJCLBA
{
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x66D6C60", Offset = "0x66D5860", VA = "0x1866D6C60")]
	public static GNGCFIGNAMM POOKOLBDHBA(this BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal sealed class JLEIMENCFAA : DDCDPIBPACO, LIFEPKGIJHF
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 EBLMFDDKEBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x66D1170", Offset = "0x66CFD70", VA = "0x1866D1170", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 BPGKAIAAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x66D1560", Offset = "0x66D0160", VA = "0x1866D1560", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	private Vector3 MPFFLKOCICM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x66D1080", Offset = "0x66CFC80", VA = "0x1866D1080")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private BJMCMIHAOAN ABBBEFGENMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x66D11A0", Offset = "0x66CFDA0", VA = "0x1866D11A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x66BECA0", Offset = "0x66BD8A0", VA = "0x1866BECA0")]
	public JLEIMENCFAA(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x66D1300", Offset = "0x66CFF00", VA = "0x1866D1300", Slot = "6")]
	public void HLHELKEJELJ(BJMCMIHAOAN MJOMMKLGFIJ, object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x66D1450", Offset = "0x66D0050", VA = "0x1866D1450")]
	private void HLHELKEJELJ(HKDNNMALKIB MJOMMKLGFIJ, object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x66D1BA0", Offset = "0x66D07A0", VA = "0x1866D1BA0", Slot = "7")]
	public void NJOMKBNAFEE(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x66D1790", Offset = "0x66D0390", VA = "0x1866D1790")]
	private Vector3 LIFNLDJFLEI()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal static class PGCONGCGKEL
{
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x66DB090", Offset = "0x66D9C90", VA = "0x1866DB090")]
	public static JLEIMENCFAA PNHOPFEIPEO(this BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class KPDFOJMMHMK : DDCDPIBPACO, IEFANOFLFDI
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	[Obsolete("Use LocalCenterOfMassOfSelf or LocalCenterOfMassOfHierarchy, as LocalCenterOfMass changes based on context")]
	public Vector3 FFAIGCMHHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x66D4AC0", Offset = "0x66D36C0", VA = "0x1866D4AC0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x66D4D90", Offset = "0x66D3990", VA = "0x1866D4D90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 MCLHLKGHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x66D32E0", Offset = "0x66D1EE0", VA = "0x1866D32E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 HJOKFECKGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x66D3610", Offset = "0x66D2210", VA = "0x1866D3610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	[Obsolete("Use TryGetWorldCenterOfMassOfHierarchy() or GetWorldCenterOfMassOfSelf()")]
	public Vector3 NJDJDHGKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x66D4BA0", Offset = "0x66D37A0", VA = "0x1866D4BA0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	[Obsolete("Use MassOfSelf or TryGetMassOfHierarchy instead")]
	public float EALFMGEJGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x66D4F10", Offset = "0x66D3B10", VA = "0x1866D4F10", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public float JIKHKGPIBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x66D68F0", Offset = "0x66D54F0", VA = "0x1866D68F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public float LNLNCOJKKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x66D3740", Offset = "0x66D2340", VA = "0x1866D3740", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x66D4A00", Offset = "0x66D3600", VA = "0x1866D4A00", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 DCBBNGOJMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x66D4B70", Offset = "0x66D3770", VA = "0x1866D4B70", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Quaternion CCNLEEGECMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x66D6570", Offset = "0x66D5170", VA = "0x1866D6570", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private Rigidbody JBNNJMKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x66BC5D0", Offset = "0x66BB1D0", VA = "0x1866BC5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event NLLFFIABIEF BDOLGLIKOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x66D4F70", Offset = "0x66D3B70", VA = "0x1866D4F70", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x66D3390", Offset = "0x66D1F90", VA = "0x1866D3390", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x66D6970", Offset = "0x66D5570", VA = "0x1866D6970")]
	public KPDFOJMMHMK(BJMCMIHAOAN OMNMDMGCEIK, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x66D5010", Offset = "0x66D3C10", VA = "0x1866D5010")]
	public float3 JGNDABGNJIC()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x66D5E90", Offset = "0x66D4A90", VA = "0x1866D5E90", Slot = "14")]
	public void MKPKKJBFLAP((Quaternion rot, Vector3 moments) PHCBCMGJCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x66D5A60", Offset = "0x66D4660", VA = "0x1866D5A60", Slot = "16")]
	public void LOMMBILMFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x66D65A0", Offset = "0x66D51A0", VA = "0x1866D65A0", Slot = "15")]
	public void OBMGJNIIIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x66D5990", Offset = "0x66D4590", VA = "0x1866D5990", Slot = "18")]
	public void LBEOKIABJGF(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x66D6180", Offset = "0x66D4D80", VA = "0x1866D6180", Slot = "19")]
	public void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x66D6120", Offset = "0x66D4D20", VA = "0x1866D6120", Slot = "17")]
	public void MPIALNGEOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x66D5130", Offset = "0x66D3D30", VA = "0x1866D5130", Slot = "20")]
	public void KDIAFPNPNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x66BDF00", Offset = "0x66BCB00", VA = "0x1866BDF00")]
	public void AOPFPLKCDCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x66D4D90", Offset = "0x66D3990", VA = "0x1866D4D90")]
	private void IAPALBPMHFM(Vector3 BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x66D3430", Offset = "0x66D2030", VA = "0x1866D3430")]
	[Obsolete("Changes based on context.  the unity rigidbody center of mass has a different scale as well")]
	private Vector3 BCPDIANGGPK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x66D4A00", Offset = "0x66D3600", VA = "0x1866D4A00")]
	private void GNNJCBKEOFG(float BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x66D5730", Offset = "0x66D4330", VA = "0x1866D5730")]
	private Vector3 KHPCPPEGJAF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x66D5C50", Offset = "0x66D4850", VA = "0x1866D5C50")]
	private Quaternion MEDNHBOJNMA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x66D37A0", Offset = "0x66D23A0", VA = "0x1866D37A0")]
	internal (float, Vector3) DMENAJJKODB(Rigidbody KGIGPLLIEFJ)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal static class FIJDNMLIANE
{
	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x66C02F0", Offset = "0x66BEEF0", VA = "0x1866C02F0")]
	public static KPDFOJMMHMK CDLMCFINEKO(this BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class JOMMMBNLJHN : DDCDPIBPACO, PJLBFHKEOMI
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool EMLEAHDGAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x66D22E0", Offset = "0x66D0EE0", VA = "0x1866D22E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public MIOBPNFJILE EAEGIAFCPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x66D20E0", Offset = "0x66D0CE0", VA = "0x1866D20E0", Slot = "11")]
		get
		{
			return default(MIOBPNFJILE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private MIOBPNFJILE CPDMDLDNGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x66D20E0", Offset = "0x66D0CE0", VA = "0x1866D20E0")]
		get
		{
			return default(MIOBPNFJILE);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x66D1D10", Offset = "0x66D0910", VA = "0x1866D1D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x66D2520", Offset = "0x66D1120", VA = "0x1866D2520")]
	public JOMMMBNLJHN(BJMCMIHAOAN OMNMDMGCEIK, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x66D1EE0", Offset = "0x66D0AE0", VA = "0x1866D1EE0", Slot = "4")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x66D1D80", Offset = "0x66D0980", VA = "0x1866D1D80")]
	private bool FLCNAIMKKIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x66D1C10", Offset = "0x66D0810", VA = "0x1866D1C10", Slot = "5")]
	public void CIDEKIMPGII(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x66D1C90", Offset = "0x66D0890", VA = "0x1866D1C90", Slot = "6")]
	public void FFCHECPMLEK(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x66D23C0", Offset = "0x66D0FC0", VA = "0x1866D23C0", Slot = "9")]
	public void OFPBNNJNPHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x66D1FE0", Offset = "0x66D0BE0", VA = "0x1866D1FE0")]
	private void JGHDBHMMKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x66D2140", Offset = "0x66D0D40", VA = "0x1866D2140")]
	private void MGIOCGGKFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x66D2340", Offset = "0x66D0F40", VA = "0x1866D2340", Slot = "8")]
	public void NFCMHAJHKJH(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x66D1E60", Offset = "0x66D0A60", VA = "0x1866D1E60", Slot = "7")]
	public void GIKFGDBFEHG(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class DDHJECOMPDI : DDCDPIBPACO, GPFIHEKHKME
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool EEAIMLBNNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x66BF900", Offset = "0x66BE500", VA = "0x1866BF900", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool KPMGPCAIBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x66BFA60", Offset = "0x66BE660", VA = "0x1866BFA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event NLLFFIABIEF DFNDIMKGOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x66BFBA0", Offset = "0x66BE7A0", VA = "0x1866BFBA0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x66BFD40", Offset = "0x66BE940", VA = "0x1866BFD40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x66BECA0", Offset = "0x66BD8A0", VA = "0x1866BECA0")]
	public DDHJECOMPDI(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x66BF890", Offset = "0x66BE490", VA = "0x1866BF890", Slot = "11")]
	public IDisposable AAMDLDDLNIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x66BFD30", Offset = "0x66BE930", VA = "0x1866BFD30", Slot = "8")]
	public void PFEGJBEENME(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x66BFC40", Offset = "0x66BE840", VA = "0x1866BFC40", Slot = "9")]
	public void MAKEADALNME(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x66BF960", Offset = "0x66BE560", VA = "0x1866BF960", Slot = "10")]
	public void IPLFOIJIMBL(object DGPOLLDAHJK, bool BOKIBJHHDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x66BFAC0", Offset = "0x66BE6C0", VA = "0x1866BFAC0", Slot = "12")]
	public void LBEOKIABJGF(Rigidbody GNCJKDNCDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x66BFC50", Offset = "0x66BE850", VA = "0x1866BFC50", Slot = "13")]
	public void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x66BDF00", Offset = "0x66BCB00", VA = "0x1866BDF00", Slot = "6")]
	public void GHNGEKOPJOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal sealed class IBBFLKBKOHC : DDCDPIBPACO, IJHFOBCIDEN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private PhotonView PLFOOMNCGCH;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool AGNNDKKCCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x66CF6F0", Offset = "0x66CE2F0", VA = "0x1866CF6F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool BBGKGDILHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x66D0020", Offset = "0x66CEC20", VA = "0x1866D0020", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event NLLFFIABIEF GDGOEKNFDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x66D03C0", Offset = "0x66CEFC0", VA = "0x1866D03C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x66CFD80", Offset = "0x66CE980", VA = "0x1866CFD80", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x66D0460", Offset = "0x66CF060", VA = "0x1866D0460")]
	public IBBFLKBKOHC(BJMCMIHAOAN OMNMDMGCEIK, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x66CFA50", Offset = "0x66CE650", VA = "0x1866CFA50", Slot = "8")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x66CF710", Offset = "0x66CE310", VA = "0x1866CF710", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x66CFB80", Offset = "0x66CE780", VA = "0x1866CFB80", Slot = "9")]
	public void HNCCJHLGDOF(BJMCMIHAOAN MJOMMKLGFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x66CFE20", Offset = "0x66CEA20", VA = "0x1866CFE20", Slot = "10")]
	public void KGABCPDDKIA(BJMCMIHAOAN MJOMMKLGFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x66CF870", Offset = "0x66CE470", VA = "0x1866CF870")]
	private void EAHEACMLNIM(PhotonView FNIFCFMDPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x66D00B0", Offset = "0x66CECB0", VA = "0x1866D00B0")]
	private void MDFBMLLDOFH(RigidbodyEx DBDGJKKCKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x66D0200", Offset = "0x66CEE00", VA = "0x1866D0200")]
	private void MDFIADMJOFH(PhotonView MCECJDHIJLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal static class NNHAAGGBDNK
{
	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x66D8710", Offset = "0x66D7310", VA = "0x1866D8710")]
	public static IBBFLKBKOHC FHLBOHFPFJI(this GJAKNCPMCGH GAFLMOIGPJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class HEFKNPJPCEG : DDCDPIBPACO, GMCAOMHAHAD
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool MBOMONLMKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x66CACC0", Offset = "0x66C98C0", VA = "0x1866CACC0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x66CAAD0", Offset = "0x66C96D0", VA = "0x1866CAAD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool OGGPAJCGJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x66CAD90", Offset = "0x66C9990", VA = "0x1866CAD90", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x66CAD20", Offset = "0x66C9920", VA = "0x1866CAD20")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public RigidbodyConstraints NGEGICHGBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x66CAE80", Offset = "0x66C9A80", VA = "0x1866CAE80", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x66CAB40", Offset = "0x66C9740", VA = "0x1866CAB40", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x66CAF60", Offset = "0x66C9B60", VA = "0x1866CAF60")]
	public HEFKNPJPCEG(BJMCMIHAOAN OMNMDMGCEIK, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x66CADF0", Offset = "0x66C99F0", VA = "0x1866CADF0", Slot = "9")]
	public void LBEOKIABJGF(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x66CAEE0", Offset = "0x66C9AE0", VA = "0x1866CAEE0", Slot = "10")]
	public void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class CGHDJAJJEGA : DDCDPIBPACO, NKDKDJKKDLP
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public float MJBPKJIDMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x66BEB70", Offset = "0x66BD770", VA = "0x1866BEB70", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x66BE8D0", Offset = "0x66BD4D0", VA = "0x1866BE8D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public float EELNPMMHMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x66BEA20", Offset = "0x66BD620", VA = "0x1866BEA20", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x66BE780", Offset = "0x66BD380", VA = "0x1866BE780", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x66BECA0", Offset = "0x66BD8A0", VA = "0x1866BECA0")]
	public CGHDJAJJEGA(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x66BEA80", Offset = "0x66BD680", VA = "0x1866BEA80", Slot = "8")]
	public void LBEOKIABJGF(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x66BEBD0", Offset = "0x66BD7D0", VA = "0x1866BEBD0", Slot = "9")]
	public void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[HPFMEPGDOBP(typeof(ANJFLPNGIKH), new string[] { })]
public sealed class BKMGLDBILOH : CODHFNHPPCE, ANJFLPNGIKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[MGKGBPDFBHO]
	private OINLIJKLJPH OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool KLIIIEHJHJF;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool CPEAOGPNKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x82E0E0", Offset = "0x82CCE0", VA = "0x18082E0E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x66BD7E0", Offset = "0x66BC3E0", VA = "0x1866BD7E0", Slot = "4")]
	public void InitReferences(FEPHIFPIELB CNNJJGDOONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x66BD4D0", Offset = "0x66BC0D0", VA = "0x1866BD4D0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x66BD3B0", Offset = "0x66BBFB0", VA = "0x1866BD3B0", Slot = "6")]
	public void DMENAJJKODB(BEKECMPFECE OJMIDFGBOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x66BD5C0", Offset = "0x66BC1C0", VA = "0x1866BD5C0", Slot = "7")]
	public void HIKIJMIINIG(BEKECMPFECE OJMIDFGBOBJ, bool NBEJEFEGJEN, bool ENHBOOMBECE, bool EMEDGKDOLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x66BDA10", Offset = "0x66BC610", VA = "0x1866BDA10", Slot = "8")]
	public void PDDEIJDNEJB(BEKECMPFECE OJMIDFGBOBJ, float3 ELNPHHHHPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x66BD270", Offset = "0x66BBE70", VA = "0x1866BD270", Slot = "9")]
	public void AEKOPPFLOMB(BEKECMPFECE OJMIDFGBOBJ, float3 AFNLMPCCDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x66BD500", Offset = "0x66BC100", VA = "0x1866BD500")]
	private bool FGDMHGMIPKA(BEKECMPFECE OJMIDFGBOBJ, [Out] HKDNNMALKIB GAFLMOIGPJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x66BD920", Offset = "0x66BC520", VA = "0x1866BD920")]
	private bool PCOOJAMLIDA(BEKECMPFECE OJMIDFGBOBJ, [Out] KPDFOJMMHMK APAJBAIDHGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x66BD830", Offset = "0x66BC430", VA = "0x1866BD830")]
	private bool MNBOECPJFCB(BEKECMPFECE OJMIDFGBOBJ, [Out] HJCGIOPNGJJ IEMOKBNNGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public BKMGLDBILOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class BLBEAGIAGIG : DDCDPIBPACO, OKKFBLIHGAN
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	private Rigidbody JBNNJMKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x66BC5D0", Offset = "0x66BB1D0", VA = "0x1866BC5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private bool KNNEIIAHPMA
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x66BE050", Offset = "0x66BCC50", VA = "0x1866BE050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private BJMCMIHAOAN CJONHGOLKBM
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x66BE180", Offset = "0x66BCD80", VA = "0x1866BE180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private bool KJDIINNFMHK
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x66BDFF0", Offset = "0x66BCBF0", VA = "0x1866BDFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private bool GJNEJBFABIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x66BE3F0", Offset = "0x66BCFF0", VA = "0x1866BE3F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x66BE110", Offset = "0x66BCD10", VA = "0x1866BE110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private bool CCHNDCPGDGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x66BE450", Offset = "0x66BD050", VA = "0x1866BE450")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x66BE520", Offset = "0x66BD120", VA = "0x1866BE520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private int GHPIOKCOJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x66BE380", Offset = "0x66BCF80", VA = "0x1866BE380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event NLLFFIABIEF BKKENEHPLMN
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x66BDB50", Offset = "0x66BC750", VA = "0x1866BDB50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x66BE070", Offset = "0x66BCC70", VA = "0x1866BE070", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x66BE590", Offset = "0x66BD190", VA = "0x1866BE590")]
	public BLBEAGIAGIG(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x66BDF40", Offset = "0x66BCB40", VA = "0x1866BDF40", Slot = "6")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x66BE4B0", Offset = "0x66BD0B0", VA = "0x1866BE4B0", Slot = "8")]
	public void PGBCADPLEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x66BE1E0", Offset = "0x66BCDE0", VA = "0x1866BE1E0", Slot = "7")]
	public bool MLEHCIAKPAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x66BDE10", Offset = "0x66BCA10", VA = "0x1866BDE10", Slot = "9")]
	public void DEGHNDEPLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x66BDF00", Offset = "0x66BCB00", VA = "0x1866BDF00", Slot = "12")]
	public void DNFILLAAEDE(bool JNMAPFFBLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x66BDCD0", Offset = "0x66BC8D0", VA = "0x1866BDCD0", Slot = "11")]
	public void BHAJNCDJOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "10")]
	public void EFOHCLEMCPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x66BDBF0", Offset = "0x66BC7F0", VA = "0x1866BDBF0")]
	private void AOBPJJLNBBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class GKCPCNANPEM : DDCDPIBPACO, HIOMHBCLCIE
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public Rigidbody JBNNJMKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x66C81F0", Offset = "0x66C6DF0", VA = "0x1866C81F0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x66C8780", Offset = "0x66C7380", VA = "0x1866C8780")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private bool KJDIINNFMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x66BC620", Offset = "0x66BB220", VA = "0x1866BC620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool OPLHEKEKKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x66C88F0", Offset = "0x66C74F0", VA = "0x1866C88F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x66C8950", Offset = "0x66C7550", VA = "0x1866C8950")]
	public GKCPCNANPEM(BJMCMIHAOAN OMNMDMGCEIK, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x66C8140", Offset = "0x66C6D40", VA = "0x1866C8140", Slot = "5")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x66C8530", Offset = "0x66C7130", VA = "0x1866C8530", Slot = "7")]
	public void IFHAEHKJMPK(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x66C8870", Offset = "0x66C7470", VA = "0x1866C8870", Slot = "8")]
	public void KHAGBMILJCD(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x66C7F20", Offset = "0x66C6B20", VA = "0x1866C7F20", Slot = "9")]
	public void ABBBMNACDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x66C82D0", Offset = "0x66C6ED0", VA = "0x1866C82D0", Slot = "11")]
	public void IDOGGHKMOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x66C85B0", Offset = "0x66C71B0", VA = "0x1866C85B0", Slot = "12")]
	public void IHIOGKDIDJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "10")]
	public void NGHDAPBNNBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal sealed class HJCGIOPNGJJ : DDCDPIBPACO, KGOHGPCLOMC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public JOCDBOPNLKP KEELFKNLNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x66CE640", Offset = "0x66CD240", VA = "0x1866CE640", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x66CE150", Offset = "0x66CCD50", VA = "0x1866CE150", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public PHKIGEHOIKG AHMJAKNHCLH
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x66CEB00", Offset = "0x66CD700", VA = "0x1866CEB00", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x66CB940", Offset = "0x66CA540", VA = "0x1866CB940", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 MPFFLKOCICM
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x66CB700", Offset = "0x66CA300", VA = "0x1866CB700", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x66CB640", Offset = "0x66CA240", VA = "0x1866CB640", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public Vector3 MHHLEAKFCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x66CEC10", Offset = "0x66CD810", VA = "0x1866CEC10", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x66CCB20", Offset = "0x66CB720", VA = "0x1866CCB20", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public Vector3 FNHDGMNMDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x66CEAA0", Offset = "0x66CD6A0", VA = "0x1866CEAA0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x66CD430", Offset = "0x66CC030", VA = "0x1866CD430", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public Vector3 FMDMJBJGMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x66CE610", Offset = "0x66CD210", VA = "0x1866CE610", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x66CE760", Offset = "0x66CD360", VA = "0x1866CE760", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public float MMDOKNOFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x66CCB50", Offset = "0x66CB750", VA = "0x1866CCB50", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x66CC790", Offset = "0x66CB390", VA = "0x1866CC790", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public bool ACLLLEEFMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x66CE5B0", Offset = "0x66CD1B0", VA = "0x1866CE5B0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private FLHJNAPHMKL EKAMEAOMAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA5F0", Offset = "0x5FD91F0", VA = "0x185FDA5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private bool KNNEIIAHPMA
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x66BE050", Offset = "0x66BCC50", VA = "0x1866BE050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x66BECA0", Offset = "0x66BD8A0", VA = "0x1866BECA0")]
	public HJCGIOPNGJJ(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x66CE6F0", Offset = "0x66CD2F0", VA = "0x1866CE6F0", Slot = "20")]
	public void MBGJOPKMLPM(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x66CD110", Offset = "0x66CBD10", VA = "0x1866CD110", Slot = "30")]
	public void IDJDBPAHAFK(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x66CCBB0", Offset = "0x66CB7B0", VA = "0x1866CCBB0", Slot = "19")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x66CC2C0", Offset = "0x66CAEC0", VA = "0x1866CC2C0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x66CE1C0", Offset = "0x66CCDC0", VA = "0x1866CE1C0", Slot = "28")]
	public void LBEOKIABJGF(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x66CB760", Offset = "0x66CA360", VA = "0x1866CB760", Slot = "35")]
	public Vector3 CDBKINCADHG(Vector3 PGDJIMHEKKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x66CCEF0", Offset = "0x66CBAF0", VA = "0x1866CCEF0", Slot = "34")]
	public Vector3 HFGBPGIKACE(Vector3 ELNPHHHHPEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x66CCBB0", Offset = "0x66CB7B0", VA = "0x1866CCBB0", Slot = "27")]
	public void PPNICGFLMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x66CE0F0", Offset = "0x66CCCF0", VA = "0x1866CE0F0", Slot = "25")]
	public void KCIHBLIKEJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x66CD0B0", Offset = "0x66CBCB0", VA = "0x1866CD0B0", Slot = "24")]
	public void HHFEJJICKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x66CC8E0", Offset = "0x66CB4E0", VA = "0x1866CC8E0", Slot = "33")]
	public void FOKPFHFGFAM(Vector3 CHOCCJMBHHH, Vector3 EJADLEACNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x66CE790", Offset = "0x66CD390", VA = "0x1866CE790", Slot = "32")]
	public void NNGOMJJFEEG(Vector3 HGOGJHLOJAG, Vector3 AFNLMPCCDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x66CD260", Offset = "0x66CBE60", VA = "0x1866CD260", Slot = "31")]
	public void IFBCAPKEMMP(Vector3 HOMOCIAEAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x66CD4F0", Offset = "0x66CC0F0", VA = "0x1866CD4F0", Slot = "22")]
	public void JFFHPELHLNL(OKBDODKFILO BICEJGPIEBJ, Vector3 CHDBCKHPDAC, float HILHKLHIOBI, float BJCAFEBCJFP = 8f, float DGBAKIODNPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x66CE7F0", Offset = "0x66CD3F0", VA = "0x1866CE7F0", Slot = "21")]
	public void OHNKGGFPMAD(PBBDPLGMKGP EAMPALLILCJ, Vector3 JNAHKEMOGDI, float ONMFMGGNEAA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x66CC380", Offset = "0x66CAF80", VA = "0x1866CC380", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void FFFIALHGPFH(PBBDPLGMKGP EAMPALLILCJ, Vector3 MJCNDCDLGEO, float IGJFENCFNAC = 7f, float EBNGHIMKDLA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x66CD180", Offset = "0x66CBD80", VA = "0x1866CD180", Slot = "29")]
	public Vector3 IDPCMNKLDGF(Vector3 OOFHBPOGMFI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x66CB9B0", Offset = "0x66CA5B0", VA = "0x1866CB9B0", Slot = "26")]
	public void DBPPBOGEOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x66CC790", Offset = "0x66CB390", VA = "0x1866CC790")]
	private void GNPDLPDHLAF(float BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x66CBB40", Offset = "0x66CA740", VA = "0x1866CBB40")]
	private void DHBKGCCIEKP(Vector3 JNAHKEMOGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x66CE330", Offset = "0x66CCF30", VA = "0x1866CE330")]
	private Vector3 LDPECLKJMHP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x66CDA60", Offset = "0x66CC660", VA = "0x1866CDA60")]
	private void JJBBPDMCKFA(Vector3 ELNPHHHHPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x66CCC60", Offset = "0x66CB860", VA = "0x1866CCC60")]
	private Vector3 HBLDNODAMHI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x66CB0D0", Offset = "0x66C9CD0", VA = "0x1866CB0D0")]
	private void ALGINOCAIKH(Vector3 BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x66CEBB0", Offset = "0x66CD7B0", VA = "0x1866CEBB0")]
	private void PBJCHJCBJPL(Vector3 OOFHBPOGMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x66CE090", Offset = "0x66CCC90", VA = "0x1866CE090")]
	private void JNIDMLCKCCO(Vector3 DJANAFJPKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x66CBD10", Offset = "0x66CA910", VA = "0x1866CBD10")]
	private void DPJGGJNJLAH(string HNHJEFEJLLE, Vector3 BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x66CDFE0", Offset = "0x66CCBE0", VA = "0x1866CDFE0")]
	private void JKBJGAKJCHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal class DDCDPIBPACO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly HKDNNMALKIB OMNMDMGCEIK;

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	protected OINLIJKLJPH MKGFKBGANLC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5787D50", Offset = "0x5786950", VA = "0x185787D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	protected BEKECMPFECE GJILOKJAIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5787D90", Offset = "0x5786990", VA = "0x185787D90")]
		get
		{
			return default(BEKECMPFECE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x66BECA0", Offset = "0x66BD8A0", VA = "0x1866BECA0")]
	public DDCDPIBPACO(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x66BF7F0", Offset = "0x66BE3F0", VA = "0x1866BF7F0")]
	protected BJMCMIHAOAN DMIICBCMNOJ(BEKECMPFECE HKEBHFPJOKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class AEMOLLLKBPN : GNFINNJDICD
{
	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x66BAE10", Offset = "0x66B9A10", VA = "0x1866BAE10", Slot = "4")]
	public KHBLGBAHCDC FIHBJAEJMIC(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x66BAE70", Offset = "0x66B9A70", VA = "0x1866BAE70", Slot = "5")]
	public KGOHGPCLOMC FJCEJBNAOHM(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x66BAD30", Offset = "0x66B9930", VA = "0x1866BAD30", Slot = "6")]
	public LIFEPKGIJHF FCOKFHHNMKK(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x66BAA50", Offset = "0x66B9650", VA = "0x1866BAA50", Slot = "7")]
	public NKDKDJKKDLP CAHEIIHONKJ(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x66BB380", Offset = "0x66B9F80", VA = "0x1866BB380", Slot = "8")]
	public OKKFBLIHGAN JMBAAHGKDJN(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x66BAF50", Offset = "0x66B9B50", VA = "0x1866BAF50", Slot = "9")]
	public LBDNMDIBBEK FPPIFHEFKDB(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x66BB5D0", Offset = "0x66BA1D0", VA = "0x1866BB5D0", Slot = "10")]
	public GPFIHEKHKME KCOPDHKOBMK(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x66BB170", Offset = "0x66B9D70", VA = "0x1866BB170", Slot = "11")]
	public FLHJNAPHMKL HPFOOCLDOCD(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x66BB4F0", Offset = "0x66BA0F0", VA = "0x1866BB4F0", Slot = "12")]
	public FEOCOJKJPGH JNAJMEOLADF(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x66BA970", Offset = "0x66B9570", VA = "0x1866BA970", Slot = "13")]
	public BAKCDMGFCKN BBCFHECHEII(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x66BAC30", Offset = "0x66B9830", VA = "0x1866BAC30")]
	public HIOMHBCLCIE LOKJCDDFHNC(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x66BAB30", Offset = "0x66B9730", VA = "0x1866BAB30")]
	public IJHFOBCIDEN GGHDNPDHFGC(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x66BB030", Offset = "0x66B9C30", VA = "0x1866BB030")]
	public PJLBFHKEOMI GIPILBKDLLM(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x66BB850", Offset = "0x66BA450", VA = "0x1866BB850")]
	public IEFANOFLFDI OAFOCPLIIFN(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x66BB6B0", Offset = "0x66BA2B0", VA = "0x1866BB6B0")]
	public GMCAOMHAHAD LFGFMELKLEI(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x66BB250", Offset = "0x66B9E50", VA = "0x1866BB250", Slot = "19")]
	public BJMCMIHAOAN JGALJMINGIM(RigidbodyEx OMNMDMGCEIK, EHBKKADJPIG KOMCCCIEHEA, MPKNHBEKGNG DFCFBMIMDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public AEMOLLLKBPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x66BAC30", Offset = "0x66B9830", VA = "0x1866BAC30", Slot = "14")]
	private HIOMHBCLCIE EMIDJLBIPKE(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x66BAB30", Offset = "0x66B9730", VA = "0x1866BAB30", Slot = "15")]
	private IJHFOBCIDEN EIKFNJAJOOE(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x66BB030", Offset = "0x66B9C30", VA = "0x1866BB030", Slot = "16")]
	private PJLBFHKEOMI GOEFNMIOEDH(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x66BB850", Offset = "0x66BA450", VA = "0x1866BB850", Slot = "17")]
	private IEFANOFLFDI LKMDJKBIBPH(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x66BB8C0", Offset = "0x66BA4C0", VA = "0x1866BB8C0", Slot = "18")]
	private GMCAOMHAHAD MOFECJAPFGE(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DefaultMember("Item")]
public sealed class COHDNAIOOFG : IReadOnlyList<BJMCMIHAOAN>, IEnumerable<BJMCMIHAOAN>, IEnumerable, IReadOnlyCollection<BJMCMIHAOAN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly BEKECMPFECE HKEBHFPJOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly OINLIJKLJPH OEENJIMJELK;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public int LOHCAPLAMPA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x66BEFA0", Offset = "0x66BDBA0", VA = "0x1866BEFA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public BJMCMIHAOAN JHFKALHEADE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x66BEE50", Offset = "0x66BDA50", VA = "0x1866BEE50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x358D740", Offset = "0x358C340", VA = "0x18358D740")]
	public COHDNAIOOFG(BEKECMPFECE HKEBHFPJOKD, OINLIJKLJPH OEENJIMJELK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x66BED40", Offset = "0x66BD940", VA = "0x1866BED40", Slot = "6")]
	public IEnumerator<BJMCMIHAOAN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x66BED40", Offset = "0x66BD940", VA = "0x1866BED40", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x66BEE50", Offset = "0x66BDA50", VA = "0x1866BEE50")]
	[CompilerGenerated]
	private BJMCMIHAOAN LGPPHLJDJBJ(int CFPNJHJGBGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[HPFMEPGDOBP(typeof(GNFINNJDICD), new string[] { })]
public class PPDNDFMHOKJ : GNFINNJDICD, CODHFNHPPCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly GNFINNJDICD DLLHOPJLNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly GNFINNJDICD LGCLODPBBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private HIJFPNHKCCA CKIFFKIJBKA;

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private GNFINNJDICD PINJBHJCBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x66DBB10", Offset = "0x66DA710", VA = "0x1866DBB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x66DB9D0", Offset = "0x66DA5D0", VA = "0x1866DB9D0", Slot = "20")]
	public void InitReferences(FEPHIFPIELB CNNJJGDOONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x66DB6A0", Offset = "0x66DA2A0", VA = "0x1866DB6A0", Slot = "4")]
	public KHBLGBAHCDC FIHBJAEJMIC(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x66DB740", Offset = "0x66DA340", VA = "0x1866DB740", Slot = "5")]
	public KGOHGPCLOMC FJCEJBNAOHM(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x66DB600", Offset = "0x66DA200", VA = "0x1866DB600", Slot = "6")]
	public LIFEPKGIJHF FCOKFHHNMKK(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x66DB400", Offset = "0x66DA000", VA = "0x1866DB400", Slot = "7")]
	public NKDKDJKKDLP CAHEIIHONKJ(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x66DBB70", Offset = "0x66DA770", VA = "0x1866DBB70", Slot = "8")]
	public OKKFBLIHGAN JMBAAHGKDJN(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x66DB7E0", Offset = "0x66DA3E0", VA = "0x1866DB7E0", Slot = "9")]
	public LBDNMDIBBEK FPPIFHEFKDB(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x66DBCB0", Offset = "0x66DA8B0", VA = "0x1866DBCB0", Slot = "10")]
	public GPFIHEKHKME KCOPDHKOBMK(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x66DB930", Offset = "0x66DA530", VA = "0x1866DB930", Slot = "11")]
	public FLHJNAPHMKL HPFOOCLDOCD(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x66DBC10", Offset = "0x66DA810", VA = "0x1866DBC10", Slot = "12")]
	public FEOCOJKJPGH JNAJMEOLADF(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x66DB360", Offset = "0x66D9F60", VA = "0x1866DB360", Slot = "13")]
	public BAKCDMGFCKN BBCFHECHEII(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x66DB550", Offset = "0x66DA150", VA = "0x1866DB550")]
	public HIOMHBCLCIE LOKJCDDFHNC(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x66DB4A0", Offset = "0x66DA0A0", VA = "0x1866DB4A0")]
	public IJHFOBCIDEN GGHDNPDHFGC(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x66DB880", Offset = "0x66DA480", VA = "0x1866DB880")]
	public PJLBFHKEOMI GIPILBKDLLM(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x66DBE00", Offset = "0x66DAA00", VA = "0x1866DBE00")]
	public IEFANOFLFDI OAFOCPLIIFN(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x66DBD50", Offset = "0x66DA950", VA = "0x1866DBD50")]
	public GMCAOMHAHAD LFGFMELKLEI(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x66DBA20", Offset = "0x66DA620", VA = "0x1866DBA20", Slot = "19")]
	public BJMCMIHAOAN JGALJMINGIM(RigidbodyEx OMNMDMGCEIK, EHBKKADJPIG KOMCCCIEHEA, MPKNHBEKGNG DFCFBMIMDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x66DBEB0", Offset = "0x66DAAB0", VA = "0x1866DBEB0")]
	public PPDNDFMHOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x66DB550", Offset = "0x66DA150", VA = "0x1866DB550", Slot = "14")]
	private HIOMHBCLCIE EMIDJLBIPKE(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x66DB4A0", Offset = "0x66DA0A0", VA = "0x1866DB4A0", Slot = "15")]
	private IJHFOBCIDEN EIKFNJAJOOE(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x66DB880", Offset = "0x66DA480", VA = "0x1866DB880", Slot = "16")]
	private PJLBFHKEOMI GOEFNMIOEDH(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x66DBE00", Offset = "0x66DAA00", VA = "0x1866DBE00", Slot = "17")]
	private IEFANOFLFDI LKMDJKBIBPH(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x66DBD50", Offset = "0x66DA950", VA = "0x1866DBD50", Slot = "18")]
	private GMCAOMHAHAD MOFECJAPFGE(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[UnityEngine.Scripting.Preserve]
public sealed class BOLDOPIJENG : BJMCMIHAOAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly BOLDOPIJENG EJGFFMEDDPG;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public Rigidbody JBNNJMKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public RigidbodyEx NLDADHGCFJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public GameObject JPLPKEPDGKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public Transform OAKAFONNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public BJMCMIHAOAN CJONHGOLKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5350", Offset = "0x7B3F50", VA = "0x1807B5350", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IReadOnlyList<BJMCMIHAOAN> CBLLDOJBFCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B70", Offset = "0x7B1770", VA = "0x1807B2B70", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public BJMCMIHAOAN IPIIEHOLADF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B50", Offset = "0x7B1750", VA = "0x1807B2B50", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool AGNNDKKCCPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x878320", Offset = "0x876F20", VA = "0x180878320", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public bool BBGKGDILHOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7FB680", Offset = "0x7FA280", VA = "0x1807FB680", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public JOCDBOPNLKP KEELFKNLNDE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B7990", Offset = "0x7B6590", VA = "0x1807B7990", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B79E0", Offset = "0x7B65E0", VA = "0x1807B79E0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public PHKIGEHOIKG AHMJAKNHCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A00", Offset = "0x7B6600", VA = "0x1807B7A00", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B79C0", Offset = "0x7B65C0", VA = "0x1807B79C0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public float MMDOKNOFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F040", VA = "0x180A70440", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x939F90", Offset = "0x938B90", VA = "0x180939F90", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Vector3 MHHLEAKFCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x1C4BFA0", Offset = "0x1C4ABA0", VA = "0x181C4BFA0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x372AAD0", Offset = "0x37296D0", VA = "0x18372AAD0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public Vector3 FMDMJBJGMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x4806E50", Offset = "0x4805A50", VA = "0x184806E50", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x4804120", Offset = "0x4802D20", VA = "0x184804120", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public Vector3 MPFFLKOCICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x5037160", Offset = "0x5035D60", VA = "0x185037160", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x5037880", Offset = "0x5036480", VA = "0x185037880", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public Vector3 FNHDGMNMDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xB9F610", Offset = "0xB9E210", VA = "0x180B9F610", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool CFGCPDFFMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x9ECF80", Offset = "0x9EBB80", VA = "0x1809ECF80", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool OEDIAFBDIHO
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x186E9D0", Offset = "0x186D5D0", VA = "0x18186E9D0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public bool ACLLLEEFMPG
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5F2F390", Offset = "0x5F2DF90", VA = "0x185F2F390", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 EBLMFDDKEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x5037840", Offset = "0x5036440", VA = "0x185037840", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 BPGKAIAAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x985830", Offset = "0x984430", VA = "0x180985830", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 FFAIGCMHHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xB9F610", Offset = "0xB9E210", VA = "0x180B9F610", Slot = "33")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "34")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 NJDJDHGKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x66BE6E0", Offset = "0x66BD2E0", VA = "0x1866BE6E0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float EALFMGEJGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1B67EC0", Offset = "0x1B66AC0", VA = "0x181B67EC0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public float LNLNCOJKKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D40", Offset = "0x8C5940", VA = "0x1808C6D40", Slot = "37")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Vector3 DCBBNGOJMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xB9F610", Offset = "0xB9E210", VA = "0x180B9F610", Slot = "39")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public Quaternion CCNLEEGECMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x802910", Offset = "0x801510", VA = "0x180802910", Slot = "40")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float MJBPKJIDMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D40", Offset = "0x8C5940", VA = "0x1808C6D40", Slot = "42")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public float EELNPMMHMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D40", Offset = "0x8C5940", VA = "0x1808C6D40", Slot = "44")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public bool CINNBCIONHG
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "46")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public LFBHMICPMPL MLKMPKEELDI
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "48")]
		get
		{
			return default(LFBHMICPMPL);
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "49")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public bool EEAIMLBNNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x12927F0", Offset = "0x12913F0", VA = "0x1812927F0", Slot = "50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public Transform BHOBDNLGCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x961110", Offset = "0x95FD10", VA = "0x180961110", Slot = "51")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public Vector3 NENGMJCMOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xB9F610", Offset = "0xB9E210", VA = "0x180B9F610", Slot = "52")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "53")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public float HALBHNAEBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D40", Offset = "0x8C5940", VA = "0x1808C6D40", Slot = "54")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public float FKFDJAKAOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D40", Offset = "0x8C5940", VA = "0x1808C6D40", Slot = "56")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Quaternion AOJJKMGFBBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5E0", Offset = "0xA0A1E0", VA = "0x180A0B5E0", Slot = "58")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Vector3 ADMMPHIELJP
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xB9F610", Offset = "0xB9E210", VA = "0x180B9F610", Slot = "60")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public Quaternion IMKNHDNNIAC
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0xA0B5E0", Offset = "0xA0A1E0", VA = "0x180A0B5E0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public RigidbodyConstraints NGEGICHGBFL
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "64")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool MBOMONLMKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public CollisionDetectionMode DMODODGADMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "68")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public bool IEMEKLGHHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x9196E0", Offset = "0x9182E0", VA = "0x1809196E0", Slot = "70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event NLLFFIABIEF PLPIHINPPHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "75")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "76")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event NLLFFIABIEF LFOHMEELELK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "77")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "78")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event FHKBNIHODPH HIGJPPLHPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event NLLFFIABIEF GDGOEKNFDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "82")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "83")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event NLLFFIABIEF BGOGNDOFJCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "102")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "103")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event NLLFFIABIEF BKKENEHPLMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "107")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "108")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event Action<FPPFILBLGKN, FPPFILBLGKN> DGGPELGLIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event NLLFFIABIEF DFNDIMKGOEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "113")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "114")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event NLLFFIABIEF HIIHDDMKOAF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "119")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "120")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "41")]
	public void MKPKKJBFLAP((Quaternion rot, Vector3 moments) PHCBCMGJCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "71")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "72")]
	public void HMDHBDDGMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "73")]
	public void HGKKBPFOMEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "74")]
	public void DEGHNDEPLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "134")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "81")]
	public void FEJIDBPIKMP(BJMCMIHAOAN BLKAHBIJBJO, bool JEGJCOJCDFA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "84")]
	public void HCEMOLFIFCE(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "85")]
	public void AEIFOHKLMDD(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0xB9F610", Offset = "0xB9E210", VA = "0x180B9F610", Slot = "86")]
	public Vector3 CDBKINCADHG(Vector3 PGDJIMHEKKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xB9F610", Offset = "0xB9E210", VA = "0x180B9F610", Slot = "87")]
	public Vector3 HFGBPGIKACE(Vector3 ELNPHHHHPEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "88")]
	public void PPNICGFLMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "89")]
	public void KCIHBLIKEJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "90")]
	public void HHFEJJICKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "91")]
	public void FOKPFHFGFAM(Vector3 CHOCCJMBHHH, Vector3 EJADLEACNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "92")]
	public void NNGOMJJFEEG(Vector3 HGOGJHLOJAG, Vector3 AFNLMPCCDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "93")]
	public void IFBCAPKEMMP(Vector3 HOMOCIAEAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "94")]
	public void JFFHPELHLNL(OKBDODKFILO BICEJGPIEBJ, Vector3 CHDBCKHPDAC, float HILHKLHIOBI, float BJCAFEBCJFP = 8f, float DGBAKIODNPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "95")]
	public void OHNKGGFPMAD(PBBDPLGMKGP EAMPALLILCJ, Vector3 JNAHKEMOGDI, float ONMFMGGNEAA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "96")]
	public void FFFIALHGPFH(PBBDPLGMKGP EAMPALLILCJ, Vector3 MJCNDCDLGEO, float IGJFENCFNAC = 7f, float EBNGHIMKDLA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xB9F610", Offset = "0xB9E210", VA = "0x180B9F610", Slot = "97")]
	public Vector3 IDPCMNKLDGF(Vector3 BLKAHBIJBJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xB9F610", Offset = "0xB9E210", VA = "0x180B9F610", Slot = "98")]
	public Vector3 PDHHGJIIIBF(Vector3 BLKAHBIJBJO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "99")]
	public void DBPPBOGEOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "100")]
	public void MMNLFEKADFO(BJMCMIHAOAN AHJIAKNPKHM, object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "101")]
	public void PMFNHJBKAJF(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "104")]
	public void LOMMBILMFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "105")]
	public void OBMGJNIIIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "106")]
	public void MPIALNGEOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "109")]
	public bool MLEHCIAKPAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "110")]
	public void BHAJNCDJOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "115")]
	public IDisposable AAMDLDDLNIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "116")]
	public void PFEGJBEENME(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "117")]
	public void MAKEADALNME(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "118")]
	public void IPLFOIJIMBL(object DGPOLLDAHJK, bool BOKIBJHHDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "121")]
	public void DNGIMDPHALM(Vector3 LFAJOKFODCI, Quaternion LHKLCGGIEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "122")]
	public void DMBPOEDHNAJ(Vector3 LPCNBIPOLOL, Quaternion FCMLIKCNDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "123")]
	public bool EJFLAFIJOEA(float MHDIGCPHMNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "124")]
	public void JPCIIFGJAJP(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "125")]
	public void MNFCEFOPKHM(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "126")]
	public void IFHAEHKJMPK(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "127")]
	public void KHAGBMILJCD(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "128")]
	public void CEKCKHOHLEN(Vector3 FAAGKOCIKOI, ForceMode APJPDPKOFAH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "129")]
	public void LOPMGOIKGAN(Vector3 FAAGKOCIKOI, Vector3 GMKEEAOHFFK, ForceMode APJPDPKOFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "130")]
	public void MLLIELJKFDC(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "131")]
	public void LLDFNJABFEJ(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x66BE6C0", Offset = "0x66BD2C0", VA = "0x1866BE6C0", Slot = "132")]
	public bool DCFJJMBHNNG(Vector3 MPBHICGGLEH, [Out] RaycastHit ILKMOJMGBDO, float BFEIMLNJNAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "133")]
	public void KDIAFPNPNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public BOLDOPIJENG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public sealed class HKDNNMALKIB : GJAKNCPMCGH, HCNAIJBDPFJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	internal BEKECMPFECE HKEBHFPJOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	internal OINLIJKLJPH MKLPFKOLLHE;

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x66C7E50", Offset = "0x66C6A50", VA = "0x1866C7E50")]
	public HKDNNMALKIB(GameObject DNJHAKIPIPL, RigidbodyEx HFJEOIFFIDL, MPKNHBEKGNG DFCFBMIMDHA, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x66CF0A0", Offset = "0x66CDCA0", VA = "0x1866CF0A0", Slot = "135")]
	protected override void GJGPGGHDADE(MPKNHBEKGNG DFCFBMIMDHA, EHBKKADJPIG KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AEE10", VA = "0x1807B0210", Slot = "141")]
	protected override IDisposable CLJAMAIKGME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x66CEF30", Offset = "0x66CDB30", VA = "0x1866CEF30", Slot = "136")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x66CF310", Offset = "0x66CDF10", VA = "0x1866CF310", Slot = "142")]
	public void IFCLJBAFAKL(FELBOIIGGGO BCGMNFKKHHA, FELBOIIGGGO EBCOJIOCDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x66CF3E0", Offset = "0x66CDFE0", VA = "0x1866CF3E0", Slot = "143")]
	public void JHOLKLJOFGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x66CF4A0", Offset = "0x66CE0A0", VA = "0x1866CF4A0", Slot = "144")]
	public void NLAJDBNNDCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x66CEED0", Offset = "0x66CDAD0", VA = "0x1866CEED0", Slot = "145")]
	public void DNFILLAAEDE(bool JNMAPFFBLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x66CF560", Offset = "0x66CE160", VA = "0x1866CF560", Slot = "146")]
	public bool OAJBCJPHPGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x66CEE70", Offset = "0x66CDA70", VA = "0x1866CEE70", Slot = "147")]
	public void DAIICGAGCCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "140")]
	protected override void EJGLCFONGFP(RigidbodyEx BGBHFDMLCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x66CEC40", Offset = "0x66CD840", VA = "0x1866CEC40")]
	private void CEPJNBLKFLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal static class MDGGDIFEJGO
{
	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x66D7A80", Offset = "0x66D6680", VA = "0x1866D7A80")]
	public static GJAKNCPMCGH BLJJOEBHAME(this BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface CNGJNCGCGGB : KHBLGBAHCDC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KBPDEGGFOIC(BJMCMIHAOAN OMNMDMGCEIK);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFKLPPDDJIP(BJMCMIHAOAN OMNMDMGCEIK);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOOLJALPMFI(BJMCMIHAOAN IDPPDAEHKHE);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BLBECBCGGNH(BJMCMIHAOAN IDPPDAEHKHE);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface ECKDNOAABMM : LIFEPKGIJHF
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	FOJIKLJMAHO<BJMCMIHAOAN> HJHIOPMDNGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	BJMCMIHAOAN ABBBEFGENMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface HGACCDBFAAD : IEFANOFLFDI
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) DMENAJJKODB(Rigidbody KGIGPLLIEFJ);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface LPPKOFBOHJM : IJHFOBCIDEN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	PhotonView CHKCKKIEDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class FKINNJDMKFD : FEOCOJKJPGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly GJAKNCPMCGH OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private CollisionDetectionMode PDPNKAIKMCH;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody JBNNJMKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x66BC5D0", Offset = "0x66BB1D0", VA = "0x1866BC5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public CollisionDetectionMode DMODODGADMF
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x66C07E0", Offset = "0x66BF3E0", VA = "0x1866C07E0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x66C08F0", Offset = "0x66BF4F0", VA = "0x1866C08F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x66BD1E0", Offset = "0x66BBDE0", VA = "0x1866BD1E0")]
	public FKINNJDMKFD(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x66C06D0", Offset = "0x66BF2D0", VA = "0x1866C06D0", Slot = "6")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x66C0970", Offset = "0x66BF570", VA = "0x1866C0970", Slot = "9")]
	public void LBEOKIABJGF(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x66C0960", Offset = "0x66BF560", VA = "0x1866C0960", Slot = "7")]
	public void LAEGHJBMOJD(bool NAHNEHJELAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x66C06C0", Offset = "0x66BF2C0", VA = "0x1866C06C0", Slot = "8")]
	public void GEDOJIHBLPM(bool NAHNEHJELAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x66C0560", Offset = "0x66BF160", VA = "0x1866C0560", Slot = "10")]
	public bool DCFJJMBHNNG(Vector3 MPBHICGGLEH, [Out] RaycastHit ILKMOJMGBDO, float BFEIMLNJNAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x66C0440", Offset = "0x66BF040", VA = "0x1866C0440")]
	private void AJLOKILDMOM(bool NAHNEHJELAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public sealed class GBPAFNBEOAD : LBDNMDIBBEK, IDisposable, NMBBICMEIBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly GJAKNCPMCGH OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private LFBHMICPMPL DDCMHELMOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private LNGAEKLFLOG JOJIEIFLOFI;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public LFBHMICPMPL MLKMPKEELDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x66C1DB0", Offset = "0x66C09B0", VA = "0x1866C1DB0", Slot = "6")]
		get
		{
			return default(LFBHMICPMPL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x66C18C0", Offset = "0x66C04C0", VA = "0x1866C18C0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private Transform MDFPGPIKJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x66C1990", Offset = "0x66C0590", VA = "0x1866C1990", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<FPPFILBLGKN, FPPFILBLGKN> DGGPELGLIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x66C19B0", Offset = "0x66C05B0", VA = "0x1866C19B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x66C1810", Offset = "0x66C0410", VA = "0x1866C1810", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x66C1F00", Offset = "0x66C0B00", VA = "0x1866C1F00")]
	public GBPAFNBEOAD(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x66C1AB0", Offset = "0x66C06B0", VA = "0x1866C1AB0", Slot = "8")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x66C1A60", Offset = "0x66C0660", VA = "0x1866C1A60", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x823A30", Offset = "0x822630", VA = "0x180823A30", Slot = "11")]
	private void DFHNHMPGOLJ(FPPFILBLGKN OJAIGPFEEFN, FPPFILBLGKN PHHKIEBOCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "12")]
	private void KONNMLDIIPF(bool JFOEBCKJLLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class AJOFKOKJHED : FLHJNAPHMKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly GJAKNCPMCGH OMNMDMGCEIK;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private Rigidbody JBNNJMKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x66BC5D0", Offset = "0x66BB1D0", VA = "0x1866BC5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool EEAIMLBNNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x66BC580", Offset = "0x66BB180", VA = "0x1866BC580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool KJDIINNFMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x66BC620", Offset = "0x66BB220", VA = "0x1866BC620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private BJMCMIHAOAN CJONHGOLKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x66BCDC0", Offset = "0x66BB9C0", VA = "0x1866BCDC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x66BD1E0", Offset = "0x66BBDE0", VA = "0x1866BD1E0")]
	public AJOFKOKJHED(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x66BC420", Offset = "0x66BB020", VA = "0x1866BC420", Slot = "4")]
	public void CEKCKHOHLEN(Vector3 FAAGKOCIKOI, ForceMode APJPDPKOFAH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x66BC680", Offset = "0x66BB280", VA = "0x1866BC680")]
	private void KIDIDNNGMCK(Vector3 FAAGKOCIKOI, ForceMode APJPDPKOFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x66BCB40", Offset = "0x66BB740", VA = "0x1866BCB40", Slot = "5")]
	public void LOPMGOIKGAN(Vector3 FAAGKOCIKOI, Vector3 GMKEEAOHFFK, ForceMode APJPDPKOFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x66BCE20", Offset = "0x66BBA20", VA = "0x1866BCE20", Slot = "6")]
	public void MLLIELJKFDC(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x66BCF80", Offset = "0x66BBB80", VA = "0x1866BCF80")]
	private void OJOKJLKEKNO(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x66BC8E0", Offset = "0x66BB4E0", VA = "0x1866BC8E0", Slot = "7")]
	public void LLDFNJABFEJ(Vector3 JHIEGPMMJDP, ForceMode APJPDPKOFAH = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class FCHGNOMPIAK : BAKCDMGFCKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly GJAKNCPMCGH OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private bool AODPDAGEBMH;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public bool CINNBCIONHG
	{
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x82E0E0", Offset = "0x82CCE0", VA = "0x18082E0E0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x66C00B0", Offset = "0x66BECB0", VA = "0x1866C00B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x66BD1E0", Offset = "0x66BBDE0", VA = "0x1866BD1E0")]
	public FCHGNOMPIAK(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x66C01C0", Offset = "0x66BEDC0", VA = "0x1866C01C0", Slot = "6")]
	public void LBEOKIABJGF(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x66BF230", Offset = "0x66BDE30", VA = "0x1866BF230", Slot = "7")]
	public void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal sealed class OAMGIJOFDDK : CNGJNCGCGGB, KHBLGBAHCDC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly BJMCMIHAOAN OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly List<BJMCMIHAOAN> PDLIMJGDPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private BJMCMIHAOAN EBCHPMPLBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private BJMCMIHAOAN MJOMMKLGFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Transform NJLOJENCAHC;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private Transform OAKAFONNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x66D8CD0", Offset = "0x66D78D0", VA = "0x1866D8CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public BJMCMIHAOAN CJONHGOLKBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x7B79F0", Offset = "0x7B65F0", VA = "0x1807B79F0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x66D8CC0", Offset = "0x66D78C0", VA = "0x1866D8CC0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public BJMCMIHAOAN IPIIEHOLADF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A20", Offset = "0x7B6620", VA = "0x1807B7A20", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public IReadOnlyList<BJMCMIHAOAN> CBLLDOJBFCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A10", Offset = "0x7B6610", VA = "0x1807B7A10", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event NLLFFIABIEF PLPIHINPPHH
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x66DA240", Offset = "0x66D8E40", VA = "0x1866DA240", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x66D9BB0", Offset = "0x66D87B0", VA = "0x1866D9BB0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event NLLFFIABIEF LFOHMEELELK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x66D9800", Offset = "0x66D8400", VA = "0x1866D9800", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x66D9B10", Offset = "0x66D8710", VA = "0x1866D9B10", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event FHKBNIHODPH HIGJPPLHPAD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x66D88B0", Offset = "0x66D74B0", VA = "0x1866D88B0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x66D8810", Offset = "0x66D7410", VA = "0x1866D8810", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event Action LBBNIJAFOOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x66D9FC0", Offset = "0x66D8BC0", VA = "0x1866D9FC0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x66D9D80", Offset = "0x66D8980", VA = "0x1866D9D80", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event Action FFFHPAFIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x66DA390", Offset = "0x66D8F90", VA = "0x1866DA390", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x66D8DD0", Offset = "0x66D79D0", VA = "0x1866D8DD0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event Action<BJMCMIHAOAN> AHLFODDIILP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x66D9750", Offset = "0x66D8350", VA = "0x1866D9750", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x66DA4E0", Offset = "0x66D90E0", VA = "0x1866DA4E0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action<BJMCMIHAOAN> PPGHOHDENCI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x66D9E20", Offset = "0x66D8A20", VA = "0x1866D9E20", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x66DA2E0", Offset = "0x66D8EE0", VA = "0x1866DA2E0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action EFHPEOPMBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x66DA060", Offset = "0x66D8C60", VA = "0x1866DA060", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x66DA100", Offset = "0x66D8D00", VA = "0x1866DA100", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<BJMCMIHAOAN> BFBOIPFFKDF
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x66DA430", Offset = "0x66D9030", VA = "0x1866DA430", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x66D8E70", Offset = "0x66D7A70", VA = "0x1866D8E70", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x66DA590", Offset = "0x66D9190", VA = "0x1866DA590")]
	public OAMGIJOFDDK(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x66D8D30", Offset = "0x66D7930", VA = "0x1866D8D30", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x66D8F20", Offset = "0x66D7B20", VA = "0x1866D8F20", Slot = "30")]
	public void FEJIDBPIKMP(BJMCMIHAOAN AECJKOCMHDK, bool JEGJCOJCDFA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x66D94E0", Offset = "0x66D80E0", VA = "0x1866D94E0", Slot = "6")]
	public void FOOLJALPMFI(BJMCMIHAOAN IDPPDAEHKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x66D8950", Offset = "0x66D7550", VA = "0x1866D8950", Slot = "7")]
	public void BLBECBCGGNH(BJMCMIHAOAN IDPPDAEHKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x66D9ED0", Offset = "0x66D8AD0", VA = "0x1866D9ED0", Slot = "4")]
	public void KBPDEGGFOIC(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x66DA1A0", Offset = "0x66D8DA0", VA = "0x1866DA1A0", Slot = "5")]
	public void NFKLPPDDJIP(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x66D8770", Offset = "0x66D7370", VA = "0x1866D8770")]
	private void ACLBDBEAGAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x66D94A0", Offset = "0x66D80A0", VA = "0x1866D94A0")]
	private void FHGDHHDDFEH(BJMCMIHAOAN IDPPDAEHKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x66D98A0", Offset = "0x66D84A0", VA = "0x1866D98A0")]
	private void HIBCMBBFJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x66D9C50", Offset = "0x66D8850", VA = "0x1866D9C50")]
	private void JDMGIJBPIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x66D99E0", Offset = "0x66D85E0", VA = "0x1866D99E0")]
	private void IJEBIMBHGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x66D8BD0", Offset = "0x66D77D0", VA = "0x1866D8BD0")]
	[CompilerGenerated]
	private object CFOKBMEHBDJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class FJLIKHHINCP
{
	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x66C0380", Offset = "0x66BEF80", VA = "0x1866C0380")]
	public static CNGJNCGCGGB POOKOLBDHBA(this BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal sealed class LNLFGPBBNBG : ECKDNOAABMM, LIFEPKGIJHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly GJAKNCPMCGH OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly FOJIKLJMAHO<BJMCMIHAOAN> AEDOOGHPHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool JDEAPBEDGOB;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public FOJIKLJMAHO<BJMCMIHAOAN> HJHIOPMDNGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 EBLMFDDKEBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x66D6DE0", Offset = "0x66D59E0", VA = "0x1866D6DE0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Vector3 BPGKAIAAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x66D6F30", Offset = "0x66D5B30", VA = "0x1866D6F30", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private Vector3 MPFFLKOCICM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x66D6CF0", Offset = "0x66D58F0", VA = "0x1866D6CF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public BJMCMIHAOAN ABBBEFGENMN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x66D6E10", Offset = "0x66D5A10", VA = "0x1866D6E10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x66D7870", Offset = "0x66D6470", VA = "0x1866D7870")]
	public LNLFGPBBNBG(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x66D6EC0", Offset = "0x66D5AC0", VA = "0x1866D6EC0", Slot = "8")]
	public void HLHELKEJELJ(BJMCMIHAOAN MJOMMKLGFIJ, object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x66D7810", Offset = "0x66D6410", VA = "0x1866D7810", Slot = "9")]
	public void NJOMKBNAFEE(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x66D7480", Offset = "0x66D6080", VA = "0x1866D7480")]
	private Vector3 LIFNLDJFLEI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x66D70F0", Offset = "0x66D5CF0", VA = "0x1866D70F0")]
	private void KMHNCCGMDBE(BJMCMIHAOAN BCHFFCAHIJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class JKNEBOFMGCI
{
	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x66D0FC0", Offset = "0x66CFBC0", VA = "0x1866D0FC0")]
	public static ECKDNOAABMM PNHOPFEIPEO(this BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class AANPBKIEAOO : HGACCDBFAAD, IEFANOFLFDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly GJAKNCPMCGH OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly OverridableVector3 ODMOIAIAIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly OverridableVector3 CMAODNIPGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private float IMIDLOBIBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float COOCMODNLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Vector3 IGOLPHNGHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Vector3? OHKJAEKCMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Quaternion? EHIABHDJGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool BPAIGAILPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool BPIEOKAPNPC;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 FFAIGCMHHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xBE5280", Offset = "0xBE3E80", VA = "0x180BE5280", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x66B9410", Offset = "0x66B8010", VA = "0x1866B9410", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Vector3 NJDJDHGKEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x66B9220", Offset = "0x66B7E20", VA = "0x1866B9220", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public float EALFMGEJGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x123C190", Offset = "0x123AD90", VA = "0x18123C190", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x66B8F80", Offset = "0x66B7B80", VA = "0x1866B8F80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public float LNLNCOJKKNM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xC6E690", Offset = "0xC6D290", VA = "0x180C6E690", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x66B8ED0", Offset = "0x66B7AD0", VA = "0x1866B8ED0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Vector3 DCBBNGOJMKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x66B9090", Offset = "0x66B7C90", VA = "0x1866B9090", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public Quaternion CCNLEEGECMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x66BA540", Offset = "0x66B9140", VA = "0x1866BA540", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	private Rigidbody JBNNJMKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x66B9320", Offset = "0x66B7F20", VA = "0x1866B9320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event NLLFFIABIEF BDOLGLIKOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x66B9370", Offset = "0x66B7F70", VA = "0x1866B9370", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x66B7D20", Offset = "0x66B6920", VA = "0x1866B7D20", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x66BA7A0", Offset = "0x66B93A0", VA = "0x1866BA7A0")]
	public AANPBKIEAOO(BJMCMIHAOAN OMNMDMGCEIK, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x66B9BE0", Offset = "0x66B87E0", VA = "0x1866B9BE0", Slot = "17")]
	public void LOMMBILMFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x66BA6C0", Offset = "0x66B92C0", VA = "0x1866BA6C0", Slot = "16")]
	public void OBMGJNIIIPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x66B9B00", Offset = "0x66B8700", VA = "0x1866B9B00", Slot = "19")]
	public void LBEOKIABJGF(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x66BA2B0", Offset = "0x66B8EB0", VA = "0x1866BA2B0", Slot = "20")]
	public void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x66BA140", Offset = "0x66B8D40", VA = "0x1866BA140", Slot = "18")]
	public void MPIALNGEOOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x66B94C0", Offset = "0x66B80C0", VA = "0x1866B94C0", Slot = "21")]
	public void KDIAFPNPNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x66B9410", Offset = "0x66B8010", VA = "0x1866B9410")]
	private void JLCHOIPAKCG(Vector3 BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x66B7DC0", Offset = "0x66B69C0", VA = "0x1866B7DC0")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 BCPDIANGGPK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x66B8F80", Offset = "0x66B7B80", VA = "0x1866B8F80")]
	private void NENGJPFFEMC(float BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x66B8ED0", Offset = "0x66B7AD0", VA = "0x1866B8ED0")]
	private void GNNJCBKEOFG(float BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x66B9960", Offset = "0x66B8560", VA = "0x1866B9960")]
	private Vector3 KHPCPPEGJAF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x66B9F10", Offset = "0x66B8B10", VA = "0x1866B9F10", Slot = "15")]
	public void MKPKKJBFLAP((Quaternion rot, Vector3 moments) PHCBCMGJCHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x66B9D90", Offset = "0x66B8990", VA = "0x1866B9D90")]
	private Quaternion MEDNHBOJNMA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x66B8E00", Offset = "0x66B7A00", VA = "0x1866B8E00")]
	public void DMENAJJKODB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x66B7EB0", Offset = "0x66B6AB0", VA = "0x1866B7EB0", Slot = "4")]
	public (float, Vector3) DMENAJJKODB(Rigidbody KGIGPLLIEFJ)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal static class IDOMHALAGPJ
{
	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x66D0520", Offset = "0x66CF120", VA = "0x1866D0520")]
	public static HGACCDBFAAD CDLMCFINEKO(this BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class IPFMPJEKHLN : PJLBFHKEOMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly GJAKNCPMCGH OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly IDAAIAHGGDM LGJHEBIBEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly MIOBPNFJILE NLNFNBHBJDC;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public bool EMLEAHDGAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xD6A140", Offset = "0xD68D40", VA = "0x180D6A140", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public MIOBPNFJILE EAEGIAFCPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x961750", Offset = "0x960350", VA = "0x180961750", Slot = "11")]
		get
		{
			return default(MIOBPNFJILE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x66D0C00", Offset = "0x66CF800", VA = "0x1866D0C00")]
	public IPFMPJEKHLN(BJMCMIHAOAN OMNMDMGCEIK, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x66D0720", Offset = "0x66CF320", VA = "0x1866D0720", Slot = "4")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x66D0640", Offset = "0x66CF240", VA = "0x1866D0640")]
	private bool FLCNAIMKKIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x66D05E0", Offset = "0x66CF1E0", VA = "0x1866D05E0", Slot = "5")]
	public void CIDEKIMPGII(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x66D0610", Offset = "0x66CF210", VA = "0x1866D0610", Slot = "6")]
	public void FFCHECPMLEK(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x66D0AC0", Offset = "0x66CF6C0", VA = "0x1866D0AC0", Slot = "9")]
	public void OFPBNNJNPHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x66D07F0", Offset = "0x66CF3F0", VA = "0x1866D07F0")]
	private void JGHDBHMMKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x66D0910", Offset = "0x66CF510", VA = "0x1866D0910")]
	private void MGIOCGGKFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x66D0A80", Offset = "0x66CF680", VA = "0x1866D0A80", Slot = "8")]
	public void NFCMHAJHKJH(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x66D06E0", Offset = "0x66CF2E0", VA = "0x1866D06E0", Slot = "7")]
	public void GIKFGDBFEHG(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class MNECMIMAELL : GPFIHEKHKME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly GJAKNCPMCGH OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly IDAAIAHGGDM MGEAFEDAGIM;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool EEAIMLBNNGC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x66D7B40", Offset = "0x66D6740", VA = "0x1866D7B40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event NLLFFIABIEF DFNDIMKGOEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x66D7DC0", Offset = "0x66D69C0", VA = "0x1866D7DC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x66D7EB0", Offset = "0x66D6AB0", VA = "0x1866D7EB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x66D7F50", Offset = "0x66D6B50", VA = "0x1866D7F50")]
	public MNECMIMAELL(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x66D7AD0", Offset = "0x66D66D0", VA = "0x1866D7AD0", Slot = "11")]
	public IDisposable AAMDLDDLNIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x66D7EA0", Offset = "0x66D6AA0", VA = "0x1866D7EA0", Slot = "8")]
	public void PFEGJBEENME(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x66D7E60", Offset = "0x66D6A60", VA = "0x1866D7E60", Slot = "9")]
	public void MAKEADALNME(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x66D7C30", Offset = "0x66D6830", VA = "0x1866D7C30", Slot = "10")]
	public void IPLFOIJIMBL(object DGPOLLDAHJK, bool BOKIBJHHDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x66D7BF0", Offset = "0x66D67F0", VA = "0x1866D7BF0", Slot = "6")]
	public void GHNGEKOPJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x66D7D40", Offset = "0x66D6940", VA = "0x1866D7D40", Slot = "12")]
	public void LBEOKIABJGF(Rigidbody GNCJKDNCDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x66D7E70", Offset = "0x66D6A70", VA = "0x1866D7E70", Slot = "13")]
	public void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class KNNGJAGAKCH : LPPKOFBOHJM, IJHFOBCIDEN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly GJAKNCPMCGH OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private PhotonView PLFOOMNCGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool BGOANLCGMCN;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public PhotonView CHKCKKIEDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool AGNNDKKCCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x66CF6F0", Offset = "0x66CE2F0", VA = "0x1866CF6F0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool BBGKGDILHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x8F8240", Offset = "0x8F6E40", VA = "0x1808F8240", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event NLLFFIABIEF GDGOEKNFDHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x66D3190", Offset = "0x66D1D90", VA = "0x1866D3190", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x66D2BB0", Offset = "0x66D17B0", VA = "0x1866D2BB0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x66D3230", Offset = "0x66D1E30", VA = "0x1866D3230")]
	public KNNGJAGAKCH(BJMCMIHAOAN OMNMDMGCEIK, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x66D2910", Offset = "0x66D1510", VA = "0x1866D2910", Slot = "9")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x66D26A0", Offset = "0x66D12A0", VA = "0x1866D26A0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x66D2A40", Offset = "0x66D1640", VA = "0x1866D2A40", Slot = "10")]
	public void HNCCJHLGDOF(BJMCMIHAOAN MJOMMKLGFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x66D2C50", Offset = "0x66D1850", VA = "0x1866D2C50", Slot = "11")]
	public void KGABCPDDKIA(BJMCMIHAOAN MJOMMKLGFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x66D27A0", Offset = "0x66D13A0", VA = "0x1866D27A0")]
	private void EAHEACMLNIM(PhotonView FNIFCFMDPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x66D2DC0", Offset = "0x66D19C0", VA = "0x1866D2DC0")]
	private void MDFBMLLDOFH(RigidbodyEx DBDGJKKCKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x66D2F20", Offset = "0x66D1B20", VA = "0x1866D2F20")]
	private void MDFIADMJOFH(PhotonView MCECJDHIJLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class NBEBMGLEBMB
{
	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x66D8040", Offset = "0x66D6C40", VA = "0x1866D8040")]
	public static LPPKOFBOHJM FHLBOHFPFJI(this BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class PLFDKDDEJAL : GMCAOMHAHAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly GJAKNCPMCGH OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private RigidbodyConstraints GNOFCBICNBA;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool MBOMONLMKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xB79A60", Offset = "0xB78660", VA = "0x180B79A60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x3ED64A0", Offset = "0x3ED50A0", VA = "0x183ED64A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public bool OGGPAJCGJIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xDE9340", Offset = "0xDE7F40", VA = "0x180DE9340", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x3ED6490", Offset = "0x3ED5090", VA = "0x183ED6490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public RigidbodyConstraints NGEGICHGBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x7B1560", Offset = "0x7B0160", VA = "0x1807B1560", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x66DB120", Offset = "0x66D9D20", VA = "0x1866DB120", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x66DB2B0", Offset = "0x66D9EB0", VA = "0x1866DB2B0")]
	public PLFDKDDEJAL(BJMCMIHAOAN OMNMDMGCEIK, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x66DB250", Offset = "0x66D9E50", VA = "0x1866DB250", Slot = "9")]
	public void LBEOKIABJGF(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x66DB280", Offset = "0x66D9E80", VA = "0x1866DB280", Slot = "10")]
	public void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class EGOGBHGEMMJ : NKDKDJKKDLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly BJMCMIHAOAN OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private float BCMJKEKLFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private float OPCEKLFMMME;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public float MJBPKJIDMHD
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x93A5F0", Offset = "0x9391F0", VA = "0x18093A5F0", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x66BFEB0", Offset = "0x66BEAB0", VA = "0x1866BFEB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public float EELNPMMHMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x9F49F0", Offset = "0x9F35F0", VA = "0x1809F49F0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x66BFDE0", Offset = "0x66BE9E0", VA = "0x1866BFDE0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x66C0070", Offset = "0x66BEC70", VA = "0x1866C0070")]
	public EGOGBHGEMMJ(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x66BFF80", Offset = "0x66BEB80", VA = "0x1866BFF80", Slot = "8")]
	public void LBEOKIABJGF(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x66BFFD0", Offset = "0x66BEBD0", VA = "0x1866BFFD0", Slot = "9")]
	public void NHMIGGNPEJO(Rigidbody FDMOAPCLJOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class AFEAFPNHAKC : OKKFBLIHGAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly GJAKNCPMCGH OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool JKCMPHFFGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool HGJACJIOJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int ABAHNFADIED;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private Rigidbody JBNNJMKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x66B9320", Offset = "0x66B7F20", VA = "0x1866B9320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	private bool KNNEIIAHPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x66BC110", Offset = "0x66BAD10", VA = "0x1866BC110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private BJMCMIHAOAN CJONHGOLKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x66BC1D0", Offset = "0x66BADD0", VA = "0x1866BC1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	private bool KJDIINNFMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x66BC0B0", Offset = "0x66BACB0", VA = "0x1866BC0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event NLLFFIABIEF BKKENEHPLMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x66BB8D0", Offset = "0x66BA4D0", VA = "0x1866BB8D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x66BC130", Offset = "0x66BAD30", VA = "0x1866BC130", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x66BC390", Offset = "0x66BAF90", VA = "0x1866BC390")]
	public AFEAFPNHAKC(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x66BBE40", Offset = "0x66BAA40", VA = "0x1866BBE40", Slot = "6")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x66BC380", Offset = "0x66BAF80", VA = "0x1866BC380", Slot = "8")]
	public void PGBCADPLEDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x66BC230", Offset = "0x66BAE30", VA = "0x1866BC230", Slot = "7")]
	public bool MLEHCIAKPAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x66BBBA0", Offset = "0x66BA7A0", VA = "0x1866BBBA0", Slot = "9")]
	public void DEGHNDEPLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x66BBB00", Offset = "0x66BA700", VA = "0x1866BBB00", Slot = "11")]
	public void BHAJNCDJOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x66BBC40", Offset = "0x66BA840", VA = "0x1866BBC40", Slot = "12")]
	public void DNFILLAAEDE(bool JNMAPFFBLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x66BBC90", Offset = "0x66BA890", VA = "0x1866BBC90", Slot = "10")]
	public void EFOHCLEMCPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x66BBED0", Offset = "0x66BAAD0", VA = "0x1866BBED0")]
	private bool HAFFJIAMBMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x66BB970", Offset = "0x66BA570", VA = "0x1866BB970")]
	private void AOBPJJLNBBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class IFMHNDGFJOI : HIOMHBCLCIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly GJAKNCPMCGH OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly IDAAIAHGGDM KKJLEFMPNPN;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Rigidbody JBNNJMKLPMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B40", Offset = "0x7B1740", VA = "0x1807B2B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	private bool KJDIINNFMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x66E58C0", Offset = "0x66E44C0", VA = "0x1866E58C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public bool OPLHEKEKKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xD6A140", Offset = "0xD68D40", VA = "0x180D6A140", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x66E5FA0", Offset = "0x66E4BA0", VA = "0x1866E5FA0")]
	public IFMHNDGFJOI(BJMCMIHAOAN OMNMDMGCEIK, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x66E5480", Offset = "0x66E4080", VA = "0x1866E5480", Slot = "5")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x66E5710", Offset = "0x66E4310", VA = "0x1866E5710", Slot = "7")]
	public void IFHAEHKJMPK(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x66E58E0", Offset = "0x66E44E0", VA = "0x1866E58E0", Slot = "8")]
	public void KHAGBMILJCD(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x66E5030", Offset = "0x66E3C30", VA = "0x1866E5030", Slot = "9")]
	public void ABBBMNACDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x66E5520", Offset = "0x66E4120", VA = "0x1866E5520", Slot = "11")]
	public void IDOGGHKMOHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x66E5740", Offset = "0x66E4340", VA = "0x1866E5740", Slot = "12")]
	public void IHIOGKDIDJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x66E5A90", Offset = "0x66E4690", VA = "0x1866E5A90", Slot = "10")]
	public void NGHDAPBNNBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x66E5910", Offset = "0x66E4510", VA = "0x1866E5910")]
	private void MOMNIOJLOCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x66E5300", Offset = "0x66E3F00", VA = "0x1866E5300")]
	private void BJPPIPKBFBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class HBCKKMEHCKP : KGOHGPCLOMC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly GJAKNCPMCGH OMNMDMGCEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly IDAAIAHGGDM NOKADMBILCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float NFJICLEMGNN;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public JOCDBOPNLKP KEELFKNLNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B10", Offset = "0x7B1710", VA = "0x1807B2B10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public PHKIGEHOIKG AHMJAKNHCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7B5350", Offset = "0x7B3F50", VA = "0x1807B5350", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Vector3 MPFFLKOCICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x66E2510", Offset = "0x66E1110", VA = "0x1866E2510", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x66E2450", Offset = "0x66E1050", VA = "0x1866E2450", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public Vector3 MHHLEAKFCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x66E4EA0", Offset = "0x66E3AA0", VA = "0x1866E4EA0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x66E3090", Offset = "0x66E1C90", VA = "0x1866E3090", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public Vector3 FNHDGMNMDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x66E48F0", Offset = "0x66E34F0", VA = "0x1866E48F0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x66E36D0", Offset = "0x66E22D0", VA = "0x1866E36D0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public Vector3 FMDMJBJGMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x66E44E0", Offset = "0x66E30E0", VA = "0x1866E44E0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x66E45D0", Offset = "0x66E31D0", VA = "0x1866E45D0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public float MMDOKNOFEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x96E430", Offset = "0x96D030", VA = "0x18096E430", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x66E2E40", Offset = "0x66E1A40", VA = "0x1866E2E40", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool ACLLLEEFMPG
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x172CD70", Offset = "0x172B970", VA = "0x18172CD70", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	private FLHJNAPHMKL EKAMEAOMAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x5FDA5F0", Offset = "0x5FD91F0", VA = "0x185FDA5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	private bool KNNEIIAHPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x66BE050", Offset = "0x66BCC50", VA = "0x1866BE050")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x66E4F90", Offset = "0x66E3B90", VA = "0x1866E4F90")]
	public HBCKKMEHCKP(BJMCMIHAOAN OMNMDMGCEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x66E30C0", Offset = "0x66E1CC0", VA = "0x1866E30C0", Slot = "19")]
	public void GOCGJIABMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x66E2A40", Offset = "0x66E1640", VA = "0x1866E2A40", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x66E4330", Offset = "0x66E2F30", VA = "0x1866E4330", Slot = "28")]
	public void LBEOKIABJGF(Rigidbody FDMOAPCLJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0xBBA580", Offset = "0xBB9180", VA = "0x180BBA580", Slot = "20")]
	public void MBGJOPKMLPM(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0xBB9AF0", Offset = "0xBB86F0", VA = "0x180BB9AF0", Slot = "30")]
	public void IDJDBPAHAFK(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x66E2630", Offset = "0x66E1230", VA = "0x1866E2630", Slot = "35")]
	public Vector3 CDBKINCADHG(Vector3 PGDJIMHEKKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x66E3250", Offset = "0x66E1E50", VA = "0x1866E3250", Slot = "34")]
	public Vector3 HFGBPGIKACE(Vector3 ELNPHHHHPEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x66E30C0", Offset = "0x66E1CC0", VA = "0x1866E30C0", Slot = "27")]
	public void PPNICGFLMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x66E42D0", Offset = "0x66E2ED0", VA = "0x1866E42D0", Slot = "25")]
	public void KCIHBLIKEJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x66E33A0", Offset = "0x66E1FA0", VA = "0x1866E33A0", Slot = "24")]
	public void HHFEJJICKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x66E2EF0", Offset = "0x66E1AF0", VA = "0x1866E2EF0", Slot = "33")]
	public void FOKPFHFGFAM(Vector3 CHOCCJMBHHH, Vector3 EJADLEACNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x66E4600", Offset = "0x66E3200", VA = "0x1866E4600", Slot = "32")]
	public void NNGOMJJFEEG(Vector3 HGOGJHLOJAG, Vector3 AFNLMPCCDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x66E3560", Offset = "0x66E2160", VA = "0x1866E3560", Slot = "31")]
	public void IFBCAPKEMMP(Vector3 HOMOCIAEAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x66E3790", Offset = "0x66E2390", VA = "0x1866E3790", Slot = "22")]
	public void JFFHPELHLNL(OKBDODKFILO BICEJGPIEBJ, Vector3 CHDBCKHPDAC, float HILHKLHIOBI, float BJCAFEBCJFP = 8f, float DGBAKIODNPH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x66E4660", Offset = "0x66E3260", VA = "0x1866E4660", Slot = "21")]
	public void OHNKGGFPMAD(PBBDPLGMKGP EAMPALLILCJ, Vector3 JNAHKEMOGDI, float ONMFMGGNEAA = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x66E2AA0", Offset = "0x66E16A0", VA = "0x1866E2AA0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void FFFIALHGPFH(PBBDPLGMKGP EAMPALLILCJ, Vector3 MJCNDCDLGEO, float IGJFENCFNAC = 7f, float EBNGHIMKDLA = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x66E3400", Offset = "0x66E2000", VA = "0x1866E3400", Slot = "29")]
	public Vector3 IDPCMNKLDGF(Vector3 OOFHBPOGMFI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x66E27A0", Offset = "0x66E13A0", VA = "0x1866E27A0", Slot = "26")]
	public void DBPPBOGEOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x66E2E40", Offset = "0x66E1A40", VA = "0x1866E2E40")]
	private void GNPDLPDHLAF(float BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x66E28D0", Offset = "0x66E14D0", VA = "0x1866E28D0")]
	private void DHBKGCCIEKP(Vector3 JNAHKEMOGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x66E4400", Offset = "0x66E3000", VA = "0x1866E4400")]
	private Vector3 LDPECLKJMHP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x66E3DC0", Offset = "0x66E29C0", VA = "0x1866E3DC0")]
	private void JJBBPDMCKFA(Vector3 ELNPHHHHPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x66E3170", Offset = "0x66E1D70", VA = "0x1866E3170")]
	private Vector3 HBLDNODAMHI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x66E2010", Offset = "0x66E0C10", VA = "0x1866E2010")]
	private void ALGINOCAIKH(Vector3 BLKAHBIJBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x66E4A10", Offset = "0x66E3610", VA = "0x1866E4A10")]
	private void PBJCHJCBJPL(Vector3 ELNPHHHHPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x66E4220", Offset = "0x66E2E20", VA = "0x1866E4220")]
	private void JKBJGAKJCHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class NBFBOCJMPIB : GNFINNJDICD
{
	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x66E62E0", Offset = "0x66E4EE0", VA = "0x1866E62E0", Slot = "4")]
	public KHBLGBAHCDC FIHBJAEJMIC(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x66E6340", Offset = "0x66E4F40", VA = "0x1866E6340", Slot = "5")]
	public KGOHGPCLOMC FJCEJBNAOHM(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x66E6280", Offset = "0x66E4E80", VA = "0x1866E6280", Slot = "6")]
	public LIFEPKGIJHF FCOKFHHNMKK(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x66E60C0", Offset = "0x66E4CC0", VA = "0x1866E60C0", Slot = "7")]
	public NKDKDJKKDLP CAHEIIHONKJ(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x66E6600", Offset = "0x66E5200", VA = "0x1866E6600", Slot = "8")]
	public OKKFBLIHGAN JMBAAHGKDJN(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x66E6420", Offset = "0x66E5020", VA = "0x1866E6420", Slot = "9")]
	public LBDNMDIBBEK FPPIFHEFKDB(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x66E66C0", Offset = "0x66E52C0", VA = "0x1866E66C0", Slot = "10")]
	public GPFIHEKHKME KCOPDHKOBMK(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x66E64F0", Offset = "0x66E50F0", VA = "0x1866E64F0", Slot = "11")]
	public FLHJNAPHMKL HPFOOCLDOCD(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x66E6660", Offset = "0x66E5260", VA = "0x1866E6660", Slot = "12")]
	public FEOCOJKJPGH JNAJMEOLADF(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x66E6060", Offset = "0x66E4C60", VA = "0x1866E6060", Slot = "13")]
	public BAKCDMGFCKN BBCFHECHEII(BJMCMIHAOAN GAFLMOIGPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x66E6190", Offset = "0x66E4D90", VA = "0x1866E6190")]
	public HIOMHBCLCIE LOKJCDDFHNC(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x66E6120", Offset = "0x66E4D20", VA = "0x1866E6120")]
	public IJHFOBCIDEN GGHDNPDHFGC(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x66E6480", Offset = "0x66E5080", VA = "0x1866E6480")]
	public PJLBFHKEOMI GIPILBKDLLM(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x66E6790", Offset = "0x66E5390", VA = "0x1866E6790")]
	public IEFANOFLFDI OAFOCPLIIFN(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x66E6720", Offset = "0x66E5320", VA = "0x1866E6720")]
	public GMCAOMHAHAD LFGFMELKLEI(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x66E6550", Offset = "0x66E5150", VA = "0x1866E6550", Slot = "19")]
	public BJMCMIHAOAN JGALJMINGIM(RigidbodyEx OMNMDMGCEIK, EHBKKADJPIG KOMCCCIEHEA, MPKNHBEKGNG DFCFBMIMDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public NBFBOCJMPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x66E6190", Offset = "0x66E4D90", VA = "0x1866E6190", Slot = "14")]
	private HIOMHBCLCIE EMIDJLBIPKE(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x66E6120", Offset = "0x66E4D20", VA = "0x1866E6120", Slot = "15")]
	private IJHFOBCIDEN EIKFNJAJOOE(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x66E6480", Offset = "0x66E5080", VA = "0x1866E6480", Slot = "16")]
	private PJLBFHKEOMI GOEFNMIOEDH(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x66E6790", Offset = "0x66E5390", VA = "0x1866E6790", Slot = "17")]
	private IEFANOFLFDI LKMDJKBIBPH(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x66E6720", Offset = "0x66E5320", VA = "0x1866E6720", Slot = "18")]
	private GMCAOMHAHAD MOFECJAPFGE(BJMCMIHAOAN GAFLMOIGPJD, [In] EHBKKADJPIG KOMCCCIEHEA)
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
